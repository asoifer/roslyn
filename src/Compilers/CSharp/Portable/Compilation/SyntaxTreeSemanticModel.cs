// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class SyntaxTreeSemanticModel : CSharpSemanticModel
    {
        private readonly CSharpCompilation _compilation;

        private readonly SyntaxTree _syntaxTree;

        private ImmutableDictionary<CSharpSyntaxNode, MemberSemanticModel> _memberModels;

        private readonly BinderFactory _binderFactory;

        private Func<CSharpSyntaxNode, MemberSemanticModel> _createMemberModelFunction;

        private readonly bool _ignoresAccessibility;

        private ScriptLocalScopeBinder.Labels _globalStatementLabels;

        private static readonly Func<CSharpSyntaxNode, bool> s_isMemberDeclarationFunction;

        internal SyntaxTreeSemanticModel(CSharpCompilation compilation, SyntaxTree syntaxTree, bool ignoreAccessibility = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10930, 1783, 2377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 889, 901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 940, 951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1283, 1363);
                this._memberModels = ImmutableDictionary<CSharpSyntaxNode, MemberSemanticModel>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1407, 1421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1484, 1510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1543, 1564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1613, 1635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1928, 1955);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1969, 1994);

                _syntaxTree = syntaxTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 2008, 2052);

                _ignoresAccessibility = ignoreAccessibility;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 2068, 2271) || true) && (!f_10930_2073_2089(this).SyntaxTrees.Contains(syntaxTree))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 2068, 2271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 2156, 2256);

                    throw f_10930_2162_2255(nameof(syntaxTree), f_10930_2214_2254());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 2068, 2271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 2287, 2366);

                _binderFactory = f_10930_2304_2365(compilation, f_10930_2333_2343(), ignoreAccessibility);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10930, 1783, 2377);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 1783, 2377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 1783, 2377);
            }
        }

        internal SyntaxTreeSemanticModel(CSharpCompilation parentCompilation, SyntaxTree parentSyntaxTree, SyntaxTree speculatedSyntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10930, 2389, 2717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 889, 901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 940, 951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1283, 1363);
                this._memberModels = ImmutableDictionary<CSharpSyntaxNode, MemberSemanticModel>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1407, 1421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1484, 1510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1543, 1564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1613, 1635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 2545, 2578);

                _compilation = parentCompilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 2592, 2627);

                _syntaxTree = speculatedSyntaxTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 2641, 2706);

                _binderFactory = f_10930_2658_2705(_compilation, parentSyntaxTree);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10930, 2389, 2717);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 2389, 2717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 2389, 2717);
            }
        }

        public override CSharpCompilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 2906, 2977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 2942, 2962);

                    return _compilation;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 2906, 2977);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 2836, 2988);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 2836, 2988);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CSharpSyntaxNode Root
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 3194, 3292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 3230, 3277);

                    return (CSharpSyntaxNode)f_10930_3255_3276(_syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 3194, 3292);

                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10930_3255_3276(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.GetRoot();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 3255, 3276);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 3130, 3303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 3130, 3303);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SyntaxTree SyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 3489, 3559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 3525, 3544);

                    return _syntaxTree;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 3489, 3559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 3427, 3570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 3427, 3570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IgnoresAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 3816, 3853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 3822, 3851);

                    return _ignoresAccessibility;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 3816, 3853);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 3750, 3864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 3750, 3864);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void VerifySpanForGetDiagnostics(TextSpan? span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 3876, 4114);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 3957, 4103) || true) && (span.HasValue && (DynAbs.Tracing.TraceSender.Expression_True(10930, 3961, 4018) && !f_10930_3979_3988(this).FullSpan.Contains(span.Value)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 3957, 4103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 4052, 4088);

                    throw f_10930_4058_4087("span");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 3957, 4103);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 3876, 4114);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_3979_3988(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 3979, 3988);
                    return return_v;
                }


                System.ArgumentException
                f_10930_4058_4087(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 4058, 4087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 3876, 4114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 3876, 4114);
            }
        }

        public override ImmutableArray<Diagnostic> GetSyntaxDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 4126, 4537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 4303, 4337);

                f_10930_4303_4336(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 4351, 4526);

                return f_10930_4358_4525(f_10930_4358_4369(), CompilationStage.Parse, f_10930_4436_4451(this), span, includeEarlierStages: false, cancellationToken: cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 4126, 4537);

                int
                f_10930_4303_4336(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.Text.TextSpan?
                span)
                {
                    this_param.VerifySpanForGetDiagnostics(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 4303, 4336);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_4358_4369()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 4358, 4369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_4436_4451(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 4436, 4451);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10930_4358_4525(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CompilationStage
                stage, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, bool
                includeEarlierStages, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnosticsForSyntaxTree(stage, syntaxTree, filterSpanWithinTree, includeEarlierStages: includeEarlierStages, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 4358, 4525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 4126, 4537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 4126, 4537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Diagnostic> GetDeclarationDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 4549, 4967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 4731, 4765);

                f_10930_4731_4764(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 4779, 4956);

                return f_10930_4786_4955(f_10930_4786_4797(), CompilationStage.Declare, f_10930_4866_4881(this), span, includeEarlierStages: false, cancellationToken: cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 4549, 4967);

                int
                f_10930_4731_4764(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.Text.TextSpan?
                span)
                {
                    this_param.VerifySpanForGetDiagnostics(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 4731, 4764);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_4786_4797()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 4786, 4797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_4866_4881(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 4866, 4881);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10930_4786_4955(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CompilationStage
                stage, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, bool
                includeEarlierStages, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnosticsForSyntaxTree(stage, syntaxTree, filterSpanWithinTree, includeEarlierStages: includeEarlierStages, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 4786, 4955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 4549, 4967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 4549, 4967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Diagnostic> GetMethodBodyDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 4979, 5396);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 5160, 5194);

                f_10930_5160_5193(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 5208, 5385);

                return f_10930_5215_5384(f_10930_5215_5226(), CompilationStage.Compile, f_10930_5295_5310(this), span, includeEarlierStages: false, cancellationToken: cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 4979, 5396);

                int
                f_10930_5160_5193(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.Text.TextSpan?
                span)
                {
                    this_param.VerifySpanForGetDiagnostics(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 5160, 5193);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_5215_5226()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 5215, 5226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_5295_5310(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 5295, 5310);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10930_5215_5384(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CompilationStage
                stage, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, bool
                includeEarlierStages, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnosticsForSyntaxTree(stage, syntaxTree, filterSpanWithinTree, includeEarlierStages: includeEarlierStages, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 5215, 5384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 4979, 5396);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 4979, 5396);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Diagnostic> GetDiagnostics(TextSpan? span = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 5408, 5814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 5579, 5613);

                f_10930_5579_5612(this, span);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 5627, 5803);

                return f_10930_5634_5802(f_10930_5634_5645(), CompilationStage.Compile, f_10930_5714_5729(this), span, includeEarlierStages: true, cancellationToken: cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 5408, 5814);

                int
                f_10930_5579_5612(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.Text.TextSpan?
                span)
                {
                    this_param.VerifySpanForGetDiagnostics(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 5579, 5612);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_5634_5645()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 5634, 5645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_5714_5729(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 5714, 5729);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10930_5634_5802(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CompilationStage
                stage, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.Text.TextSpan?
                filterSpanWithinTree, bool
                includeEarlierStages, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDiagnosticsForSyntaxTree(stage, syntaxTree, filterSpanWithinTree, includeEarlierStages: includeEarlierStages, cancellationToken: cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 5634, 5802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 5408, 5814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 5408, 5814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Binder GetEnclosingBinderInternal(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 6034, 6956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 6124, 6157);

                f_10930_6124_6156(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 6171, 6251);

                SyntaxToken
                token = f_10930_6191_6250(f_10930_6191_6200(this), position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 6394, 6595) || true) && (position == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10930, 6398, 6442) && position != token.SpanStart))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 6394, 6595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 6476, 6580);

                    return f_10930_6483_6579(f_10930_6483_6528(_binderFactory, f_10930_6508_6517(this), position), f_10930_6549_6578(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 6394, 6595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 6611, 6670);

                MemberSemanticModel
                memberModel = f_10930_6645_6669(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 6684, 6804) || true) && (memberModel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 6684, 6804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 6741, 6789);

                    return f_10930_6748_6788(memberModel, position);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 6684, 6804);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 6820, 6945);

                return f_10930_6827_6944(f_10930_6827_6893(_binderFactory, (CSharpSyntaxNode)token.Parent, position), f_10930_6914_6943(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 6034, 6956);

                int
                f_10930_6124_6156(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    this_param.AssertPositionAdjusted(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6124, 6156);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_6191_6200(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 6191, 6200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10930_6191_6250(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindTokenIncludingCrefAndNameAttributes(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6191, 6250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_6508_6517(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 6508, 6517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_6483_6528(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, int
                position)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6483, 6528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFlags
                f_10930_6549_6578(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.GetSemanticModelBinderFlags();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6549, 6578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_6483_6579(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6483, 6579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_6645_6669(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6645, 6669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_6748_6788(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6748, 6788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_6827_6893(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, int
                position)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode?)node, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6827, 6893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFlags
                f_10930_6914_6943(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.GetSemanticModelBinderFlags();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6914, 6943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_6827_6944(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 6827, 6944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 6034, 6956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 6034, 6956);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IOperation GetOperationWorker(CSharpSyntaxNode node, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 6968, 8408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 7100, 7126);

                MemberSemanticModel
                model
                = default(MemberSemanticModel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 7142, 8180);

                switch (node)
                {

                    case ConstructorDeclarationSyntax constructor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 7142, 8180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 7256, 7355);

                        model = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 7264, 7325) || (((f_10930_7265_7289(constructor) || (DynAbs.Tracing.TraceSender.Expression_False(10930, 7265, 7324) || f_10930_7293_7316(constructor) != null)) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 7328, 7347)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 7350, 7354))) ? f_10930_7328_7347(this, node) : null;
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 7377, 7383);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 7142, 8180);

                    case BaseMethodDeclarationSyntax method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 7142, 8180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 7463, 7520);

                        model = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 7471, 7490) || ((f_10930_7471_7490(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 7493, 7512)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 7515, 7519))) ? f_10930_7493_7512(this, node) : null;
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 7542, 7548);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 7142, 8180);

                    case AccessorDeclarationSyntax accessor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 7142, 8180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 7628, 7724);

                        model = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 7636, 7694) || (((f_10930_7637_7650(accessor) != null || (DynAbs.Tracing.TraceSender.Expression_False(10930, 7637, 7693) || f_10930_7662_7685(accessor) != null)) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 7697, 7716)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 7719, 7723))) ? f_10930_7697_7716(this, node) : null;
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 7746, 7752);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 7142, 8180);

                    case RecordDeclarationSyntax { ParameterList: { }, PrimaryConstructorBaseType: { } } recordDeclaration when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 7873, 7963) || true) && (f_10930_7878_7931(this, recordDeclaration) is SynthesizedRecordConstructor) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 7873, 7963) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 7142, 8180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 7986, 8027);

                        model = f_10930_7994_8026(this, recordDeclaration);
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 8049, 8055);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 7142, 8180);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 7142, 8180);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8103, 8137);

                        model = f_10930_8111_8136(this, node);
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 8159, 8165);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 7142, 8180);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8196, 8397) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 8196, 8397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8247, 8304);

                    return f_10930_8254_8303(model, node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 8196, 8397);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 8196, 8397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8370, 8382);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 8196, 8397);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 6968, 8408);

                bool
                f_10930_7265_7289(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                declaration)
                {
                    var return_v = declaration.HasAnyBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 7265, 7289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10930_7293_7316(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 7293, 7316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_7328_7347(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetOrAddModel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 7328, 7347);
                    return return_v;
                }


                bool
                f_10930_7471_7490(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                declaration)
                {
                    var return_v = declaration.HasAnyBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 7471, 7490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_7493_7512(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetOrAddModel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 7493, 7512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10930_7637_7650(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 7637, 7650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10930_7662_7685(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 7662, 7685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_7697_7716(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetOrAddModel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 7697, 7716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                f_10930_7878_7931(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                node)
                {
                    var return_v = this_param.TryGetSynthesizedRecordConstructor(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 7878, 7931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_7994_8026(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetOrAddModel((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 7994, 8026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_8111_8136(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 8111, 8136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IOperation?
                f_10930_8254_8303(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetOperationWorker(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 8254, 8303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 6968, 8408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 6968, 8408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SymbolInfo GetSymbolInfoWorker(CSharpSyntaxNode node, SymbolInfoOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 8420, 13239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8609, 8644);

                f_10930_8609_8643(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8760, 8805);

                node = f_10930_8767_8804(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8821, 8859);

                var
                model = f_10930_8833_8858(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8873, 8891);

                SymbolInfo
                result
                = default(SymbolInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8907, 8941);

                XmlNameAttributeSyntax
                attrSyntax
                = default(XmlNameAttributeSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8955, 8977);

                CrefSyntax
                crefSyntax
                = default(CrefSyntax);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 8993, 13198) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 8993, 13198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 9201, 9270);

                    result = f_10930_9210_9269(model, node, options, cancellationToken);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 9450, 10998) || true) && ((object)result.Symbol == null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 9454, 9533) && result.CandidateReason == CandidateReason.None) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 9454, 9561) && node is ExpressionSyntax) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 9454, 9627) && f_10930_9565_9627(node)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 9450, 10998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 9669, 9737);

                        var
                        binder = f_10930_9682_9736(this, f_10930_9706_9735(this, node))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 9761, 10979) || true) && (binder != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 9761, 10979);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 10054, 10092);

                            binder = f_10930_10063_10091(binder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 10120, 10166);

                            var
                            diagnostics = f_10930_10138_10165()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 10192, 10275);

                            BoundExpression
                            bound = f_10930_10216_10274(binder, node, diagnostics)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 10301, 10320);

                            f_10930_10301_10319(diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 10348, 10462);

                            SymbolInfo
                            info = f_10930_10366_10461(this, options, bound, bound, boundNodeForSyntacticParent: null, binderOpt: null)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 10488, 10956) || true) && ((object)info.Symbol != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 10488, 10956);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 10577, 10689);

                                result = f_10930_10586_10688(null, f_10930_10607_10650(info.Symbol), CandidateReason.NotATypeOrNamespace);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 10488, 10956);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 10488, 10956);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 10747, 10956) || true) && (f_10930_10751_10781_M(!info.CandidateSymbols.IsEmpty))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 10747, 10956);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 10839, 10929);

                                    result = f_10930_10848_10928(null, info.CandidateSymbols, CandidateReason.NotATypeOrNamespace);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 10747, 10956);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 10488, 10956);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 9761, 10979);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 9450, 10998);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 8993, 13198);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 8993, 13198);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 11032, 13198) || true) && (f_10930_11036_11054(f_10930_11036_11047(node)) == SyntaxKind.XmlNameAttribute && (DynAbs.Tracing.TraceSender.Expression_True(10930, 11036, 11158) && f_10930_11089_11150((attrSyntax = (XmlNameAttributeSyntax)f_10930_11127_11138(node))) == node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 11032, 13198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 11192, 11217);

                        result = SymbolInfo.None;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 11237, 11305);

                        var
                        binder = f_10930_11250_11304(this, f_10930_11274_11303(this, node))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 11323, 12430) || true) && (binder != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 11323, 12430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 11383, 11433);

                            HashSet<DiagnosticInfo>
                            useSiteDiagnostics = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 11455, 11533);

                            var
                            symbols = f_10930_11469_11532(binder, attrSyntax, ref useSiteDiagnostics)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 11719, 11820);

                            f_10930_11719_11819(symbols.All(s => s.Kind == SymbolKind.TypeParameter || s.Kind == SymbolKind.Parameter));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 11844, 12411);

                            switch (symbols.Length)
                            {

                                case 0:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 11844, 12411);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 11953, 11978);

                                    result = SymbolInfo.None;
                                    DynAbs.Tracing.TraceSender.TraceBreak(10930, 12008, 12014);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 11844, 12411);

                                case 1:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 11844, 12411);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 12077, 12163);

                                    result = f_10930_12086_12162(symbols, LookupResultKind.Viable, isDynamic: false);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10930, 12193, 12199);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 11844, 12411);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 11844, 12411);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 12263, 12352);

                                    result = f_10930_12272_12351(symbols, LookupResultKind.Ambiguous, isDynamic: false);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10930, 12382, 12388);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 11844, 12411);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 11323, 12430);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 11032, 13198);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 11032, 13198);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 12464, 13198) || true) && ((crefSyntax = node as CrefSyntax) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 12464, 13198);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 12543, 12602);

                            int
                            adjustedPosition = f_10930_12566_12601(this, crefSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 12620, 12716);

                            result = f_10930_12629_12715(this, adjustedPosition, crefSyntax, options, f_10930_12686_12714(crefSyntax));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 12464, 13198);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 12464, 13198);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 12941, 13073);

                            var
                            symbol = f_10930_12954_13072(this, node, bindVarAsAliasFirst: (options & SymbolInfoOptions.PreserveAliases) != 0)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 13091, 13183);

                            result = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 13100, 13122) || (((object)symbol != null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 13125, 13164)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 13167, 13182))) ? f_10930_13125_13164(symbol, options) : SymbolInfo.None;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 12464, 13198);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 11032, 13198);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 8993, 13198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 13214, 13228);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 8420, 13239);

                int
                f_10930_8609_8643(Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options)
                {
                    ValidateSymbolInfoOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 8609, 8643);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_8767_8804(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = SyntaxFactory.GetStandaloneNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 8767, 8804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_8833_8858(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 8833, 8858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_9210_9269(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfoWorker(node, options, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 9210, 9269);
                    return return_v;
                }


                bool
                f_10930_9565_9627(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = SyntaxFacts.IsInNamespaceOrTypeContext((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 9565, 9627);
                    return return_v;
                }


                int
                f_10930_9706_9735(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 9706, 9735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_9682_9736(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 9682, 9736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                f_10930_10063_10091(Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalScopeBinder(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 10063, 10091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10930_10138_10165()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 10138, 10165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10930_10216_10274(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindExpression((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 10216, 10274);
                    return return_v;
                }


                int
                f_10930_10301_10319(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 10301, 10319);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_10366_10461(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options, Microsoft.CodeAnalysis.CSharp.BoundExpression
                lowestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundExpression
                highestBoundNode, Microsoft.CodeAnalysis.CSharp.BoundNode
                boundNodeForSyntacticParent, Microsoft.CodeAnalysis.CSharp.Binder
                binderOpt)
                {
                    var return_v = this_param.GetSymbolInfoForNode(options, (Microsoft.CodeAnalysis.CSharp.BoundNode)lowestBoundNode, (Microsoft.CodeAnalysis.CSharp.BoundNode)highestBoundNode, boundNodeForSyntacticParent: boundNodeForSyntacticParent, binderOpt: binderOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 10366, 10461);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10930_10607_10650(Microsoft.CodeAnalysis.ISymbol
                item)
                {
                    var return_v = ImmutableArray.Create<ISymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 10607, 10650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_10586_10688(Microsoft.CodeAnalysis.ISymbol?
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                candidateSymbols, Microsoft.CodeAnalysis.CandidateReason
                candidateReason)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolInfo(symbol, candidateSymbols, candidateReason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 10586, 10688);
                    return return_v;
                }


                bool
                f_10930_10751_10781_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 10751, 10781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_10848_10928(Microsoft.CodeAnalysis.ISymbol?
                symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                candidateSymbols, Microsoft.CodeAnalysis.CandidateReason
                candidateReason)
                {
                    var return_v = new Microsoft.CodeAnalysis.SymbolInfo(symbol, candidateSymbols, candidateReason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 10848, 10928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_11036_11047(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 11036, 11047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_11036_11054(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 11036, 11054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_11127_11138(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 11127, 11138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10930_11089_11150(Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 11089, 11150);
                    return return_v;
                }


                int
                f_10930_11274_11303(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 11274, 11303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_11250_11304(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 11250, 11304);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10930_11469_11532(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.XmlNameAttributeSyntax
                syntax, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.BindXmlNameAttribute(syntax, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 11469, 11532);
                    return return_v;
                }


                int
                f_10930_11719_11819(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 11719, 11819);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_12086_12162(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, bool
                isDynamic)
                {
                    var return_v = SymbolInfoFactory.Create(symbols, resultKind, isDynamic: isDynamic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 12086, 12162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_12272_12351(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, bool
                isDynamic)
                {
                    var return_v = SymbolInfoFactory.Create(symbols, resultKind, isDynamic: isDynamic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 12272, 12351);
                    return return_v;
                }


                int
                f_10930_12566_12601(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 12566, 12601);
                    return return_v;
                }


                bool
                f_10930_12686_12714(Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                crefSyntax)
                {
                    var return_v = HasParameterList(crefSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 12686, 12714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_12629_12715(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                crefSyntax, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options, bool
                hasParameterList)
                {
                    var return_v = this_param.GetCrefSymbolInfo(position, crefSyntax, options, hasParameterList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 12629, 12715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_12954_13072(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, bool
                bindVarAsAliasFirst)
                {
                    var return_v = this_param.GetSemanticInfoSymbolInNonMemberContext(node, bindVarAsAliasFirst: bindVarAsAliasFirst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 12954, 13072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_13125_13164(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options)
                {
                    var return_v = GetSymbolInfoForSymbol(symbol, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 13125, 13164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 8420, 13239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 8420, 13239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override SymbolInfo GetCollectionInitializerSymbolInfoWorker(InitializerExpressionSyntax collectionInitializer, ExpressionSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 13251, 13931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 13485, 13540);

                var
                model = f_10930_13497_13539(this, collectionInitializer)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 13556, 13881) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 13556, 13881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 13764, 13866);

                    return f_10930_13771_13865(model, collectionInitializer, node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 13556, 13881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 13897, 13920);

                return SymbolInfo.None;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 13251, 13931);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_13497_13539(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 13497, 13539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_13771_13865(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.InitializerExpressionSyntax
                collectionInitializer, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetCollectionInitializerSymbolInfoWorker(collectionInitializer, node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 13771, 13865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 13251, 13931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 13251, 13931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override CSharpTypeInfo GetTypeInfoWorker(CSharpSyntaxNode node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 13943, 15059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 14207, 14252);

                node = f_10930_14214_14251(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 14268, 14306);

                var
                model = f_10930_14280_14305(this, node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 14322, 15048) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 14322, 15048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 14530, 14586);

                    return f_10930_14537_14585(model, node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 14322, 15048);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 14322, 15048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 14811, 14898);

                    var
                    symbol = f_10930_14824_14897(this, node, bindVarAsAliasFirst: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 14950, 15033);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 14957, 14979) || (((object)symbol != null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 14982, 15010)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 15013, 15032))) ? f_10930_14982_15010(symbol) : CSharpTypeInfo.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 14322, 15048);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 13943, 15059);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_14214_14251(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = SyntaxFactory.GetStandaloneNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 14214, 14251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_14280_14305(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 14280, 14305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpTypeInfo
                f_10930_14537_14585(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetTypeInfoWorker(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 14537, 14585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_14824_14897(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, bool
                bindVarAsAliasFirst)
                {
                    var return_v = this_param.GetSemanticInfoSymbolInNonMemberContext(node, bindVarAsAliasFirst: bindVarAsAliasFirst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 14824, 14897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpTypeInfo
                f_10930_14982_15010(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = GetTypeInfoForSymbol(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 14982, 15010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 13943, 15059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 13943, 15059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol GetSemanticInfoSymbolInNonMemberContext(CSharpSyntaxNode node, bool bindVarAsAliasFirst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 15482, 19473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 15610, 15658);

                f_10930_15610_15657(f_10930_15623_15648(this, node) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 15674, 15742);

                var
                binder = f_10930_15687_15741(this, f_10930_15711_15740(this, node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 15756, 19434) || true) && (binder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 15756, 19434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 15967, 15997);

                    var
                    type = node as TypeSyntax
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 16015, 19419) || true) && ((object)type != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 16015, 19419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 16173, 16226);

                        var
                        basesBeingResolved = f_10930_16198_16225(this, type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 16250, 16296);

                        var
                        diagnostics = f_10930_16268_16295()
                        ;
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 16370, 19257) || true) && (f_10930_16374_16417(type))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 16370, 19257);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 16475, 16557);

                                return f_10930_16482_16556(binder, node as IdentifierNameSyntax, diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 16370, 19257);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 16370, 19257);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 16615, 19257) || true) && (f_10930_16619_16656(type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 16615, 19257);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 16714, 16902) || true) && (f_10930_16718_16729_M(!type.IsVar))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 16714, 16902);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 16795, 16871);

                                        return f_10930_16802_16863(binder, type, diagnostics, basesBeingResolved).Symbol;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 16714, 16902);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 16934, 17114);

                                    Symbol
                                    result = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 16950, 16969) || ((bindVarAsAliasFirst
                                    && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 17005, 17073)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 17109, 17113))) ? f_10930_17005_17066(binder, type, diagnostics, basesBeingResolved).Symbol
                                    : null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 17648, 18877) || true) && ((object)result == null || (DynAbs.Tracing.TraceSender.Expression_False(10930, 17652, 17713) || f_10930_17678_17689(result) == SymbolKind.ErrorType))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 17648, 18877);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 18298, 18358);

                                        var
                                        variableDecl = f_10930_18317_18328(type) as VariableDeclarationSyntax
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 18392, 18846) || true) && (variableDecl != null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 18396, 18448) && variableDecl.Variables.Any()))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 18392, 18846);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 18522, 18595);

                                            var
                                            fieldSymbol = f_10930_18540_18594(this, variableDecl.Variables.First())
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 18633, 18811) || true) && ((object)fieldSymbol != null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 18633, 18811);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 18746, 18772);

                                                result = f_10930_18755_18771(fieldSymbol);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 18633, 18811);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 18392, 18846);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 17648, 18877);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 18909, 18995);

                                    return result ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10930, 18916, 18994) ?? f_10930_18926_18987(binder, type, diagnostics, basesBeingResolved).Symbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 16615, 19257);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 16615, 19257);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 19109, 19230);

                                    return f_10930_19116_19222(binder, type, diagnostics, basesBeingResolved, basesBeingResolved != null).Symbol;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 16615, 19257);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 16370, 19257);
                            }
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(10930, 19302, 19400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 19358, 19377);

                            f_10930_19358_19376(diagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitFinally(10930, 19302, 19400);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 16015, 19419);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 15756, 19434);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 19450, 19462);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 15482, 19473);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_15623_15648(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 15623, 15648);
                    return return_v;
                }


                int
                f_10930_15610_15657(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 15610, 15657);
                    return 0;
                }


                int
                f_10930_15711_15740(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetAdjustedNodePosition((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 15711, 15740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_15687_15741(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 15687, 15741);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10930_16198_16225(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                expression)
                {
                    var return_v = this_param.GetBasesBeingResolved(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 16198, 16225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10930_16268_16295()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 16268, 16295);
                    return return_v;
                }


                bool
                f_10930_16374_16417(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node)
                {
                    var return_v = SyntaxFacts.IsNamespaceAliasQualifier((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 16374, 16417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_16482_16556(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindNamespaceAliasSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax?)node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 16482, 16556);
                    return return_v;
                }


                bool
                f_10930_16619_16656(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                node)
                {
                    var return_v = SyntaxFacts.IsInTypeOnlyContext((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 16619, 16656);
                    return return_v;
                }


                bool
                f_10930_16718_16729_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 16718, 16729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10930_16802_16863(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindTypeOrAlias((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 16802, 16863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10930_17005_17066(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindTypeOrAlias((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 17005, 17066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10930_17678_17689(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 17678, 17689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_18317_18328(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 18317, 18328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10930_18540_18594(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                variableDecl)
                {
                    var return_v = this_param.GetDeclaredFieldSymbol(variableDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 18540, 18594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10930_18755_18771(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 18755, 18771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10930_18926_18987(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved)
                {
                    var return_v = this_param.BindTypeOrAlias((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 18926, 18987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.NamespaceOrTypeOrAliasSymbolWithAnnotations
                f_10930_19116_19222(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, bool
                suppressUseSiteDiagnostics)
                {
                    var return_v = this_param.BindNamespaceOrTypeOrAliasSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 19116, 19222);
                    return return_v;
                }


                int
                f_10930_19358_19376(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 19358, 19376);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 15482, 19473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 15482, 19473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetMemberGroupWorker(CSharpSyntaxNode node, SymbolInfoOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 19485, 20026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 19787, 19832);

                node = f_10930_19794_19831(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 19848, 19886);

                var
                model = f_10930_19860_19885(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 19900, 20015);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 19907, 19920) || ((model == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 19923, 19951)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 19954, 20014))) ? ImmutableArray<Symbol>.Empty : f_10930_19954_20014(model, node, options, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 19485, 20026);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_19794_19831(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = SyntaxFactory.GetStandaloneNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 19794, 19831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_19860_19885(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 19860, 19885);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10930_19954_20014(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetMemberGroupWorker(node, options, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 19954, 20014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 19485, 20026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 19485, 20026);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<IPropertySymbol> GetIndexerGroupWorker(CSharpSyntaxNode node, SymbolInfoOptions options, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 20038, 20599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 20350, 20395);

                node = f_10930_20357_20394(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 20411, 20449);

                var
                model = f_10930_20423_20448(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 20463, 20588);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 20470, 20483) || ((model == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 20486, 20523)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 20526, 20587))) ? ImmutableArray<IPropertySymbol>.Empty : f_10930_20526_20587(model, node, options, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 20038, 20599);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_20357_20394(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = SyntaxFactory.GetStandaloneNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 20357, 20394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_20423_20448(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 20423, 20448);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IPropertySymbol>
                f_10930_20526_20587(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, Microsoft.CodeAnalysis.CSharp.CSharpSemanticModel.SymbolInfoOptions
                options, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetIndexerGroupWorker(node, options, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 20526, 20587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 20038, 20599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 20038, 20599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Optional<object> GetConstantValueWorker(CSharpSyntaxNode node, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 20611, 21062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 20833, 20878);

                node = f_10930_20840_20877(node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 20894, 20932);

                var
                model = f_10930_20906_20931(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 20946, 21051);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 20953, 20966) || ((model == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 20969, 20994)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 20997, 21050))) ? default(Optional<object>) : f_10930_20997_21050(model, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 20611, 21062);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_20840_20877(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = SyntaxFactory.GetStandaloneNode(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 20840, 20877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_20906_20931(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 20906, 20931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Optional<object>
                f_10930_20997_21050(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetConstantValueWorker(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 20997, 21050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 20611, 21062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 20611, 21062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override QueryClauseInfo GetQueryClauseInfo(QueryClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 21074, 21440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 21239, 21261);

                f_10930_21239_21260(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 21275, 21313);

                var
                model = f_10930_21287_21312(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 21327, 21429);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 21334, 21349) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 21352, 21376)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 21379, 21428))) ? default(QueryClauseInfo) : f_10930_21379_21428(model, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 21074, 21440);

                int
                f_10930_21239_21260(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 21239, 21260);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_21287_21312(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 21287, 21312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.QueryClauseInfo
                f_10930_21379_21428(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetQueryClauseInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 21379, 21428);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 21074, 21440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 21074, 21440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SymbolInfo GetSymbolInfo(SelectOrGroupClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 21452, 21802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 21615, 21637);

                f_10930_21615_21636(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 21651, 21689);

                var
                model = f_10930_21663_21688(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 21703, 21791);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 21710, 21725) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 21728, 21743)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 21746, 21790))) ? SymbolInfo.None : f_10930_21746_21790(model, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 21452, 21802);

                int
                f_10930_21615_21636(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 21615, 21636);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_21663_21688(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 21663, 21688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_21746_21790(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 21746, 21790);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 21452, 21802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 21452, 21802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override TypeInfo GetTypeInfo(SelectOrGroupClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 21814, 22162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 21973, 21995);

                f_10930_21973_21994(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 22009, 22047);

                var
                model = f_10930_22021_22046(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 22061, 22151);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 22068, 22083) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 22086, 22105)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 22108, 22150))) ? CSharpTypeInfo.None : f_10930_22108_22150(model, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 21814, 22162);

                int
                f_10930_21973_21994(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 21973, 21994);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_22021_22046(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 22021, 22046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_10930_22108_22150(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SelectOrGroupClauseSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetTypeInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 22108, 22150);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 21814, 22162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 21814, 22162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IPropertySymbol GetDeclaredSymbol(AnonymousObjectMemberDeclaratorSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 22174, 22586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 22370, 22404);

                f_10930_22370_22403(this, declaratorSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 22418, 22468);

                var
                model = f_10930_22430_22467(this, declaratorSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 22482, 22575);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 22489, 22504) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 22507, 22511)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 22514, 22574))) ? null : f_10930_22514_22574(model, declaratorSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 22174, 22586);

                int
                f_10930_22370_22403(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 22370, 22403);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_22430_22467(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 22430, 22467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol
                f_10930_22514_22574(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectMemberDeclaratorSyntax
                declaratorSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declaratorSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 22514, 22574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 22174, 22586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 22174, 22586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override INamedTypeSymbol GetDeclaredSymbol(AnonymousObjectCreationExpressionSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 22598, 23013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 22797, 22831);

                f_10930_22797_22830(this, declaratorSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 22845, 22895);

                var
                model = f_10930_22857_22894(this, declaratorSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 22909, 23002);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 22916, 22931) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 22934, 22938)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 22941, 23001))) ? null : f_10930_22941_23001(model, declaratorSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 22598, 23013);

                int
                f_10930_22797_22830(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 22797, 22830);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_22857_22894(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 22857, 22894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10930_22941_23001(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousObjectCreationExpressionSyntax
                declaratorSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declaratorSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 22941, 23001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 22598, 23013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 22598, 23013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override INamedTypeSymbol GetDeclaredSymbol(TupleExpressionSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 23025, 23422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 23206, 23240);

                f_10930_23206_23239(this, declaratorSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 23254, 23304);

                var
                model = f_10930_23266_23303(this, declaratorSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 23318, 23411);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 23325, 23340) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 23343, 23347)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 23350, 23410))) ? null : f_10930_23350_23410(model, declaratorSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 23025, 23422);

                int
                f_10930_23206_23239(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 23206, 23239);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_23266_23303(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 23266, 23303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10930_23350_23410(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                declaratorSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declaratorSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 23350, 23410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 23025, 23422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 23025, 23422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(ArgumentSyntax declaratorSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 23434, 23815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 23599, 23633);

                f_10930_23599_23632(this, declaratorSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 23647, 23697);

                var
                model = f_10930_23659_23696(this, declaratorSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 23711, 23804);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 23718, 23733) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 23736, 23740)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 23743, 23803))) ? null : f_10930_23743_23803(model, declaratorSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 23434, 23815);

                int
                f_10930_23599_23632(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 23599, 23632);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_23659_23696(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 23659, 23696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10930_23743_23803(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                declaratorSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declaratorSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 23743, 23803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 23434, 23815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 23434, 23815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IRangeVariableSymbol GetDeclaredSymbol(QueryClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 23827, 24176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 23996, 24018);

                f_10930_23996_24017(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 24032, 24070);

                var
                model = f_10930_24044_24069(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 24084, 24165);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 24091, 24106) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 24109, 24113)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 24116, 24164))) ? null : f_10930_24116_24164(model, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 23827, 24176);

                int
                f_10930_23996_24017(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 23996, 24017);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_24044_24069(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 24044, 24069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IRangeVariableSymbol
                f_10930_24116_24164(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryClauseSyntax
                queryClause, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(queryClause, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 24116, 24164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 23827, 24176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 23827, 24176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IRangeVariableSymbol GetDeclaredSymbol(JoinIntoClauseSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 24188, 24540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 24360, 24382);

                f_10930_24360_24381(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 24396, 24434);

                var
                model = f_10930_24408_24433(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 24448, 24529);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 24455, 24470) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 24473, 24477)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 24480, 24528))) ? null : f_10930_24480_24528(model, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 24188, 24540);

                int
                f_10930_24360_24381(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 24360, 24381);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_24408_24433(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 24408, 24433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IRangeVariableSymbol
                f_10930_24480_24528(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.JoinIntoClauseSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 24480, 24528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 24188, 24540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 24188, 24540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IRangeVariableSymbol GetDeclaredSymbol(QueryContinuationSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 24552, 24907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 24727, 24749);

                f_10930_24727_24748(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 24763, 24801);

                var
                model = f_10930_24775_24800(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 24815, 24896);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 24822, 24837) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 24840, 24844)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 24847, 24895))) ? null : f_10930_24847_24895(model, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 24552, 24907);

                int
                f_10930_24727_24748(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 24727, 24748);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_24775_24800(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 24775, 24800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IRangeVariableSymbol
                f_10930_24847_24895(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.QueryContinuationSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 24847, 24895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 24552, 24907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 24552, 24907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override SymbolInfo GetSymbolInfo(OrderingSyntax node, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 24919, 25258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 25071, 25093);

                f_10930_25071_25092(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 25107, 25145);

                var
                model = f_10930_25119_25144(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 25159, 25247);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 25166, 25181) || (((model == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 25184, 25199)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 25202, 25246))) ? SymbolInfo.None : f_10930_25202_25246(model, node, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 24919, 25258);

                int
                f_10930_25071_25092(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 25071, 25092);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_25119_25144(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 25119, 25144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_10930_25202_25246(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.OrderingSyntax
                node, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetSymbolInfo(node, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 25202, 25246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 24919, 25258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 24919, 25258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ConsList<TypeSymbol> GetBasesBeingResolved(TypeSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 25270, 26255);
                try
                {            // if the expression is the child of a base-list node, then the expression should be
                             // bound in the context of the containing symbols base being resolved.
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 25550, 26216) || true) && (expression != null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 25557, 25604) && f_10930_25579_25596(expression) != null))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 25606, 25650)
        , expression = f_10930_25619_25636(expression) as TypeSyntax, DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 25550, 26216))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 25550, 26216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 25684, 25715);

                        var
                        parent = f_10930_25697_25714(expression)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 25733, 26201) || true) && (parent is BaseTypeSyntax baseType && (DynAbs.Tracing.TraceSender.Expression_True(10930, 25737, 25795) && f_10930_25774_25787(parent) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 25737, 25842) && f_10930_25799_25819(f_10930_25799_25812(parent)) == SyntaxKind.BaseList) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 25737, 25873) && f_10930_25846_25859(baseType) == expression))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 25733, 26201);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 25956, 26015);

                            var
                            decl = (BaseTypeDeclarationSyntax)f_10930_25994_26014(f_10930_25994_26007(parent))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26037, 26079);

                            var
                            symbol = f_10930_26050_26078(this, decl)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26101, 26182);

                            return f_10930_26108_26181(ConsList<TypeSymbol>.Empty, f_10930_26143_26180(f_10930_26143_26161(symbol)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 25733, 26201);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10930, 1, 667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10930, 1, 667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26232, 26244);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 25270, 26255);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_25579_25596(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 25579, 25596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_25619_25636(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 25619, 25636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_25697_25714(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 25697, 25714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_25774_25787(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 25774, 25787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_25799_25812(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 25799, 25812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_25799_25819(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 25799, 25819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10930_25846_25859(Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 25846, 25859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_25994_26007(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 25994, 26007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_25994_26014(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 25994, 26014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10930_26050_26078(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax?
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 26050, 26078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10930_26143_26161(Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 26143, 26161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_26143_26180(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 26143, 26180);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10930_26108_26181(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                head)
                {
                    var return_v = list.Prepend<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)head);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 26108, 26181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 25270, 26255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 25270, 26255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Conversion ClassifyConversion(ExpressionSyntax expression, ITypeSymbol destination, bool isExplicitInSource = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 26267, 27897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26424, 26509);

                TypeSymbol
                csdestination = f_10930_26451_26508(destination, nameof(destination))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26525, 26728) || true) && (f_10930_26529_26546(expression) == SyntaxKind.DeclarationExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 26525, 26728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26682, 26713);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 26525, 26728);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26744, 26875) || true) && (isExplicitInSource)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 26744, 26875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26800, 26860);

                    return f_10930_26807_26859(this, expression, csdestination);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 26744, 26875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26891, 26919);

                f_10930_26891_26918(this, expression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 26935, 27068) || true) && ((object)destination == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 26935, 27068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 27000, 27053);

                    throw f_10930_27006_27052(nameof(destination));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 26935, 27068);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 27369, 27413);

                var
                model = f_10930_27381_27412(this, expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 27427, 27813) || true) && (model == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 27427, 27813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 27767, 27798);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 27427, 27813);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 27829, 27886);

                return f_10930_27836_27885(model, expression, destination);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 26267, 27897);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10930_26451_26508(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                paramName)
                {
                    var return_v = symbol.EnsureCSharpSymbolOrNull(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 26451, 26508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_26529_26546(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 26529, 26546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10930_26807_26859(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = this_param.ClassifyConversionForCast(expression, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 26807, 26859);
                    return return_v;
                }


                int
                f_10930_26891_26918(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 26891, 26918);
                    return 0;
                }


                System.ArgumentNullException
                f_10930_27006_27052(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 27006, 27052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_27381_27412(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 27381, 27412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10930_27836_27885(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.ITypeSymbol
                destination)
                {
                    var return_v = this_param.ClassifyConversion(expression, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 27836, 27885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 26267, 27897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 26267, 27897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Conversion ClassifyConversionForCast(ExpressionSyntax expression, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 27909, 28769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 28041, 28069);

                f_10930_28041_28068(this, expression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 28085, 28218) || true) && ((object)destination == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 28085, 28218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 28150, 28203);

                    throw f_10930_28156_28202(nameof(destination));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 28085, 28218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 28234, 28278);

                var
                model = f_10930_28246_28277(this, expression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 28292, 28678) || true) && (model == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 28292, 28678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 28632, 28663);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 28292, 28678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 28694, 28758);

                return f_10930_28701_28757(model, expression, destination);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 27909, 28769);

                int
                f_10930_28041_28068(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 28041, 28068);
                    return 0;
                }


                System.ArgumentNullException
                f_10930_28156_28202(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 28156, 28202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_28246_28277(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 28246, 28277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10930_28701_28757(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = this_param.ClassifyConversionForCast(expression, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 28701, 28757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 27909, 28769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 27909, 28769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsSpeculativeSemanticModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 28853, 28874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 28859, 28872);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 28853, 28874);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 28781, 28885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 28781, 28885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int OriginalPositionForSpeculation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 28972, 28989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 28978, 28987);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 28972, 28989);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 28897, 29000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 28897, 29000);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override CSharpSemanticModel ParentModel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 29084, 29104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 29090, 29102);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 29084, 29104);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 29012, 29115);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 29012, 29115);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SemanticModel ContainingModelOrSelf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 29205, 29225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 29211, 29223);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 29205, 29225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 29127, 29236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 29127, 29236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, TypeSyntax type, SpeculativeBindingOption bindingOption, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 29248, 30163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 29481, 29525);

                position = f_10930_29492_29524(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 29541, 29583);

                var
                model = f_10930_29553_29582(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 29597, 29777) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 29597, 29777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 29648, 29762);

                    return f_10930_29655_29761(model, parentModel, position, type, bindingOption, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 29597, 29777);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 29793, 29861);

                Binder
                binder = f_10930_29809_29860(this, position, type, bindingOption)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 29875, 30085) || true) && (binder != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 29875, 30085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 29927, 30040);

                    speculativeModel = f_10930_29946_30039(parentModel, type, binder, position, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30058, 30070);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 29875, 30085);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30101, 30125);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30139, 30152);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 29248, 30163);

                int
                f_10930_29492_29524(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 29492, 29524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_29553_29582(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 29553, 29582);
                    return return_v;
                }


                bool
                f_10930_29655_29761(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelCore(parentModel, position, type, bindingOption, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 29655, 29761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_29809_29860(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = this_param.GetSpeculativeBinder(position, (Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)expression, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 29809, 29860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpeculativeSyntaxTreeSemanticModel
                f_10930_29946_30039(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                root, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, int
                position, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption)
                {
                    var return_v = SpeculativeSyntaxTreeSemanticModel.Create(parentSemanticModel, root, rootBinder, position, bindingOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 29946, 30039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 29248, 30163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 29248, 30163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, CrefSyntax crefSyntax, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 30175, 30773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30367, 30411);

                position = f_10930_30378_30410(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30427, 30472);

                Binder
                binder = f_10930_30443_30471(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30486, 30695) || true) && (f_10930_30490_30504_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(binder, 10930, 30490, 30504)?.InCref) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 30486, 30695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30546, 30650);

                    speculativeModel = f_10930_30565_30649(parentModel, crefSyntax, binder, position);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30668, 30680);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 30486, 30695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30711, 30735);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30749, 30762);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 30175, 30773);

                int
                f_10930_30378_30410(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 30378, 30410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_30443_30471(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 30443, 30471);
                    return return_v;
                }


                bool?
                f_10930_30490_30504_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 30490, 30504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SpeculativeSyntaxTreeSemanticModel
                f_10930_30565_30649(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.CrefSyntax
                root, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, int
                position)
                {
                    var return_v = SpeculativeSyntaxTreeSemanticModel.Create(parentSemanticModel, root, rootBinder, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 30565, 30649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 30175, 30773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 30175, 30773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, StatementSyntax statement, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 30785, 31352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 30988, 31032);

                position = f_10930_30999_31031(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31048, 31090);

                var
                model = f_10930_31060_31089(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31104, 31274) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 31104, 31274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31155, 31259);

                    return f_10930_31162_31258(model, parentModel, position, statement, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 31104, 31274);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31290, 31314);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31328, 31341);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 30785, 31352);

                int
                f_10930_30999_31031(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 30999, 31031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_31060_31089(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 31060, 31089);
                    return return_v;
                }


                bool
                f_10930_31162_31258(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                statement, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelCore(parentModel, position, statement, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 31162, 31258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 30785, 31352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 30785, 31352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, BaseMethodDeclarationSyntax method, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 31364, 31963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31589, 31633);

                position = f_10930_31600_31632(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31649, 31691);

                var
                model = f_10930_31661_31690(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31705, 31885) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 31705, 31885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31756, 31870);

                    return f_10930_31763_31869(model, parentModel, position, method, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 31705, 31885);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31901, 31925);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 31939, 31952);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 31364, 31963);

                int
                f_10930_31600_31632(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 31600, 31632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_31661_31690(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 31661, 31690);
                    return return_v;
                }


                bool
                f_10930_31763_31869(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                method, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelForMethodBodyCore(parentModel, position, method, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 31763, 31869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 31364, 31963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 31364, 31963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool TryGetSpeculativeSemanticModelForMethodBodyCore(SyntaxTreeSemanticModel parentModel, int position, AccessorDeclarationSyntax accessor, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 31975, 32576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32200, 32244);

                position = f_10930_32211_32243(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32260, 32302);

                var
                model = f_10930_32272_32301(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32316, 32498) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 32316, 32498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32367, 32483);

                    return f_10930_32374_32482(model, parentModel, position, accessor, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 32316, 32498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32514, 32538);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32552, 32565);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 31975, 32576);

                int
                f_10930_32211_32243(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 32211, 32243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_32272_32301(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 32272, 32301);
                    return return_v;
                }


                bool
                f_10930_32374_32482(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                accessor, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelForMethodBodyCore(parentModel, position, accessor, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 32374, 32482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 31975, 32576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 31975, 32576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, EqualsValueClauseSyntax initializer, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 32588, 33167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32801, 32845);

                position = f_10930_32812_32844(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32861, 32903);

                var
                model = f_10930_32873_32902(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32917, 33089) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 32917, 33089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 32968, 33074);

                    return f_10930_32975_33073(model, parentModel, position, initializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 32917, 33089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 33105, 33129);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 33143, 33156);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 32588, 33167);

                int
                f_10930_32812_32844(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 32812, 32844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_32873_32902(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 32873, 32902);
                    return return_v;
                }


                bool
                f_10930_32975_33073(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                initializer, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelCore(parentModel, position, initializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 32975, 33073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 32588, 33167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 32588, 33167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ArrowExpressionClauseSyntax expressionBody, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 33179, 33761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 33392, 33436);

                position = f_10930_33403_33435(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 33452, 33494);

                var
                model = f_10930_33464_33493(this, position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 33508, 33683) || true) && (model != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 33508, 33683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 33559, 33668);

                    return f_10930_33566_33667(model, parentModel, position, expressionBody, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 33508, 33683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 33699, 33723);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 33737, 33750);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 33179, 33761);

                int
                f_10930_33403_33435(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 33403, 33435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_33464_33493(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 33464, 33493);
                    return return_v;
                }


                bool
                f_10930_33566_33667(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                expressionBody, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelCore(parentModel, position, expressionBody, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 33566, 33667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 33179, 33761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 33179, 33761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, ConstructorInitializerSyntax constructorInitializer, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 33773, 34651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34002, 34046);

                position = f_10930_34013_34045(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34062, 34211);

                var
                existingConstructorInitializer = f_10930_34099_34210(f_10930_34099_34193(f_10930_34099_34154(f_10930_34099_34128(f_10930_34099_34108(this), position).Parent)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34227, 34573) || true) && (existingConstructorInitializer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 34227, 34573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34303, 34345);

                    var
                    model = f_10930_34315_34344(this, position)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34363, 34558) || true) && (model != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 34363, 34558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34422, 34539);

                        return f_10930_34429_34538(model, parentModel, position, constructorInitializer, out speculativeModel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 34363, 34558);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 34227, 34573);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34589, 34613);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34627, 34640);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 33773, 34651);

                int
                f_10930_34013_34045(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34013, 34045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_34099_34108(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 34099, 34108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10930_34099_34128(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34099, 34128);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10930_34099_34154(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.AncestorsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34099, 34154);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax>
                f_10930_34099_34193(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34099, 34193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                f_10930_34099_34210(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax>
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34099, 34210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_34315_34344(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34315, 34344);
                    return return_v;
                }


                bool
                f_10930_34429_34538(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                constructorInitializer, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelCore(parentModel, position, constructorInitializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34429, 34538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 33773, 34651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 33773, 34651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool TryGetSpeculativeSemanticModelCore(SyntaxTreeSemanticModel parentModel, int position, PrimaryConstructorBaseTypeSyntax constructorInitializer, out SemanticModel speculativeModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 34663, 35571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34896, 34940);

                position = f_10930_34907_34939(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 34956, 35109);

                var
                existingConstructorInitializer = f_10930_34993_35108(f_10930_34993_35091(f_10930_34993_35048(f_10930_34993_35022(f_10930_34993_35002(this), position).Parent)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 35125, 35493) || true) && (existingConstructorInitializer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 35125, 35493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 35201, 35265);

                    var
                    model = f_10930_35213_35264(this, existingConstructorInitializer)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 35283, 35478) || true) && (model != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 35283, 35478);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 35342, 35459);

                        return f_10930_35349_35458(model, parentModel, position, constructorInitializer, out speculativeModel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 35283, 35478);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 35125, 35493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 35509, 35533);

                speculativeModel = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 35547, 35560);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 34663, 35571);

                int
                f_10930_34907_34939(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34907, 34939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_34993_35002(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 34993, 35002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10930_34993_35022(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindToken(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34993, 35022);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_10930_34993_35048(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.AncestorsAndSelf();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34993, 35048);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax>
                f_10930_34993_35091(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34993, 35091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                f_10930_34993_35108(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax>
                source)
                {
                    var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 34993, 35108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_35213_35264(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 35213, 35264);
                    return return_v;
                }


                bool
                f_10930_35349_35458(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentModel, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                constructorInitializer, out Microsoft.CodeAnalysis.SemanticModel
                speculativeModel)
                {
                    var return_v = this_param.TryGetSpeculativeSemanticModelCore(parentModel, position, constructorInitializer, out speculativeModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 35349, 35458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 34663, 35571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 34663, 35571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BoundExpression GetSpeculativelyBoundExpression(int position, ExpressionSyntax expression, SpeculativeBindingOption bindingOption, out Binder binder, out ImmutableArray<Symbol> crefSymbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 35583, 36746);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 35815, 35938) || true) && (expression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 35815, 35938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 35871, 35923);

                    throw f_10930_35877_35922(nameof(expression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 35815, 35938);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 36177, 36596) || true) && (bindingOption == SpeculativeBindingOption.BindAsExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 36177, 36596);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 36273, 36317);

                    position = f_10930_36284_36316(this, position);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 36335, 36372);

                    var
                    model = f_10930_36347_36371(this, position)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 36390, 36581) || true) && (model is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 36390, 36581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 36451, 36562);

                        return f_10930_36458_36561(model, position, expression, bindingOption, out binder, out crefSymbols);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 36390, 36581);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 36177, 36596);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 36612, 36735);

                return f_10930_36619_36734(this, position, expression, bindingOption, out binder, out crefSymbols);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 35583, 36746);

                System.ArgumentNullException
                f_10930_35877_35922(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 35877, 35922);
                    return return_v;
                }


                int
                f_10930_36284_36316(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 36284, 36316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_36347_36371(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 36347, 36371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10930_36458_36561(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption, out Microsoft.CodeAnalysis.CSharp.Binder
                binder, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                crefSymbols)
                {
                    var return_v = this_param.GetSpeculativelyBoundExpression(position, expression, bindingOption, out binder, out crefSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 36458, 36561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10930_36619_36734(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression, Microsoft.CodeAnalysis.SpeculativeBindingOption
                bindingOption, out Microsoft.CodeAnalysis.CSharp.Binder
                binder, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                crefSymbols)
                {
                    var return_v = this_param.GetSpeculativelyBoundExpressionWithoutNullability(position, expression, bindingOption, out binder, out crefSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 36619, 36734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 35583, 36746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 35583, 36746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AttributeSemanticModel CreateSpeculativeAttributeSemanticModel(int position, AttributeSyntax attribute, Binder binder, AliasSymbol aliasOpt, NamedTypeSymbol attributeType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 36758, 37251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 36963, 37083);

                var
                memberModel = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 36981, 37048) || ((f_10930_36981_37048(this, position, attribute) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 37051, 37075)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 37078, 37082))) ? f_10930_37051_37075(this, position) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 37097, 37240);

                return f_10930_37104_37239(this, attribute, attributeType, aliasOpt, binder, f_10930_37195_37228_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(memberModel, 10930, 37195, 37228)?.GetRemappedSymbols()), position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 36758, 37251);

                bool
                f_10930_36981_37048(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                speculativeSyntax)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledAtSpeculativePosition(position, (Microsoft.CodeAnalysis.SyntaxNode)speculativeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 36981, 37048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_37051_37075(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 37051, 37075);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                f_10930_37195_37228_I(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 37195, 37228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AttributeSemanticModel
                f_10930_37104_37239(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                parentSemanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                aliasOpt, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                parentRemappedSymbolsOpt, int
                position)
                {
                    var return_v = AttributeSemanticModel.CreateSpeculative(parentSemanticModel, syntax, attributeType, aliasOpt, rootBinder, parentRemappedSymbolsOpt, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 37104, 37239);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 36758, 37251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 36758, 37251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsNullableAnalysisEnabledAtSpeculativePosition(int position, SyntaxNode speculativeSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 37263, 38092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 37392, 37449);

                f_10930_37392_37448(f_10930_37405_37433(speculativeSyntax) != f_10930_37437_37447());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 37858, 38081);

                return f_10930_37865_37963(((CSharpSyntaxTree)f_10930_37884_37912(speculativeSyntax)), f_10930_37940_37962(speculativeSyntax)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10930, 37865, 38080) ?? f_10930_37984_38080(f_10930_37984_37995(), f_10930_38042_38052(), f_10930_38054_38079(position, 0)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 37263, 38092);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_37405_37433(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 37405, 37433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_37437_37447()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 37437, 37447);
                    return return_v;
                }


                int
                f_10930_37392_37448(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 37392, 37448);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_37884_37912(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 37884, 37912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_37940_37962(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 37940, 37962);
                    return return_v;
                }


                bool?
                f_10930_37865_37963(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.IsNullableAnalysisEnabled(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 37865, 37963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_37984_37995()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 37984, 37995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_38042_38052()
                {
                    var return_v = SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 38042, 38052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_38054_38079(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 38054, 38079);
                    return return_v;
                }


                bool
                f_10930_37984_38080(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                tree, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.IsNullableAnalysisEnabledIn((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxTree)tree, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 37984, 38080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 37263, 38092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 37263, 38092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberSemanticModel GetMemberModel(int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 38104, 41077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 38185, 38218);

                f_10930_38185_38217(this, position);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 38232, 38336);

                CSharpSyntaxNode
                node = (CSharpSyntaxNode)f_10930_38274_38328(f_10930_38274_38278(), position).Parent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 38350, 38407);

                CSharpSyntaxNode
                memberDecl = f_10930_38380_38406(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 38423, 38454);

                bool
                outsideMemberDecl = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 38468, 40995) || true) && (memberDecl != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 38468, 40995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 38524, 40980);

                    switch (f_10930_38532_38549(memberDecl))
                    {

                        case SyntaxKind.AddAccessorDeclaration:
                        case SyntaxKind.RemoveAccessorDeclaration:
                        case SyntaxKind.GetAccessorDeclaration:
                        case SyntaxKind.SetAccessorDeclaration:
                        case SyntaxKind.InitAccessorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 38524, 40980);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 39050, 39144);

                            outsideMemberDecl = !f_10930_39071_39143(position, memberDecl);
                            DynAbs.Tracing.TraceSender.TraceBreak(10930, 39170, 39176);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 38524, 40980);

                        case SyntaxKind.ConstructorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 38524, 40980);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 39263, 39326);

                            var
                            constructorDecl = (ConstructorDeclarationSyntax)memberDecl
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 39352, 39567);

                            outsideMemberDecl =
                                                        !f_10930_39402_39473(position, constructorDecl) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 39401, 39566) && !f_10930_39507_39566(position, constructorDecl));
                            DynAbs.Tracing.TraceSender.TraceBreak(10930, 39593, 39599);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 38524, 40980);

                        case SyntaxKind.RecordDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 38524, 40980);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 39712, 39765);

                                var
                                recordDecl = (RecordDeclarationSyntax)memberDecl
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 39797, 40335) || true) && (f_10930_39801_39825(recordDecl) is null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 39797, 40335);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 39899, 39924);

                                    outsideMemberDecl = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 39797, 40335);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 39797, 40335);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 40054, 40125);

                                    var
                                    argumentList = f_10930_40073_40124_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10930_40073_40110(recordDecl), 10930, 40073, 40124)?.ArgumentList)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 40159, 40304);

                                    outsideMemberDecl = argumentList is null || (DynAbs.Tracing.TraceSender.Expression_False(10930, 40179, 40303) || !f_10930_40204_40303(position, f_10930_40245_40272(argumentList), f_10930_40274_40302(argumentList)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 39797, 40335);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10930, 40388, 40394);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 38524, 40980);

                        case SyntaxKind.ConversionOperatorDeclaration:
                        case SyntaxKind.DestructorDeclaration:
                        case SyntaxKind.MethodDeclaration:
                        case SyntaxKind.OperatorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 38524, 40980);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 40662, 40719);

                            var
                            methodDecl = (BaseMethodDeclarationSyntax)memberDecl
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 40745, 40929);

                            outsideMemberDecl =
                                                        !f_10930_40795_40840(position, methodDecl) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 40794, 40928) && !f_10930_40874_40928(position, methodDecl));
                            DynAbs.Tracing.TraceSender.TraceBreak(10930, 40955, 40961);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 38524, 40980);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 38468, 40995);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 41011, 41066);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 41018, 41035) || ((outsideMemberDecl && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 41038, 41042)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 41045, 41065))) ? null : f_10930_41045_41065(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 38104, 41077);

                int
                f_10930_38185_38217(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    this_param.AssertPositionAdjusted(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 38185, 38217);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_38274_38278()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 38274, 38278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10930_38274_38328(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param, int
                position)
                {
                    var return_v = this_param.FindTokenIncludingCrefAndNameAttributes(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 38274, 38328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_38380_38406(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = GetMemberDeclaration((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 38380, 38406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_38532_38549(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 38532, 38549);
                    return return_v;
                }


                bool
                f_10930_39071_39143(int
                position, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                method)
                {
                    var return_v = LookupPosition.IsInBody(position, (Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 39071, 39143);
                    return return_v;
                }


                bool
                f_10930_39402_39473(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                constructorDecl)
                {
                    var return_v = LookupPosition.IsInConstructorParameterScope(position, constructorDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 39402, 39473);
                    return return_v;
                }


                bool
                f_10930_39507_39566(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                methodDecl)
                {
                    var return_v = LookupPosition.IsInParameterList(position, (Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)methodDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 39507, 39566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10930_39801_39825(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 39801, 39825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax?
                f_10930_40073_40110(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.PrimaryConstructorBaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 40073, 40110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax?
                f_10930_40073_40124_M(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 40073, 40124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10930_40245_40272(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.OpenParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 40245, 40272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10930_40274_40302(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                this_param)
                {
                    var return_v = this_param.CloseParenToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 40274, 40302);
                    return return_v;
                }


                bool
                f_10930_40204_40303(int
                position, Microsoft.CodeAnalysis.SyntaxToken
                firstIncluded, Microsoft.CodeAnalysis.SyntaxToken
                firstExcluded)
                {
                    var return_v = LookupPosition.IsBetweenTokens(position, firstIncluded, firstExcluded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 40204, 40303);
                    return return_v;
                }


                bool
                f_10930_40795_40840(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                method)
                {
                    var return_v = LookupPosition.IsInBody(position, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 40795, 40840);
                    return return_v;
                }


                bool
                f_10930_40874_40928(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                methodDecl)
                {
                    var return_v = LookupPosition.IsInParameterList(position, methodDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 40874, 40928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_41045_41065(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 41045, 41065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 38104, 41077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 38104, 41077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override MemberSemanticModel GetMemberModel(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 41235, 48904);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 41602, 41697) || true) && (f_10930_41606_41636(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41602, 41697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 41670, 41682);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41602, 41697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 41713, 41792);

                var
                memberDecl = f_10930_41730_41756(node) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>(10930, 41730, 41791) ?? (node as CompilationUnitSyntax))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 41806, 48865) || true) && (memberDecl != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41806, 48865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 41862, 41883);

                    var
                    span = f_10930_41873_41882(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 41903, 48850);

                    switch (f_10930_41911_41928(memberDecl))
                    {

                        case SyntaxKind.MethodDeclaration:
                        case SyntaxKind.ConversionOperatorDeclaration:
                        case SyntaxKind.OperatorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 42187, 42244);

                                var
                                methodDecl = (BaseMethodDeclarationSyntax)memberDecl
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 42274, 42332);

                                var
                                expressionBody = f_10930_42295_42331(methodDecl)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 42401, 42662);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 42408, 42590) || ((((expressionBody is not null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 42410, 42478) && expressionBody.FullSpan.Contains(span))) || (DynAbs.Tracing.TraceSender.Expression_False(10930, 42409, 42589) || (f_10930_42518_42533(methodDecl) is not null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 42518, 42588) && f_10930_42549_42564(methodDecl).FullSpan.Contains(span))))) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 42629, 42654)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 42657, 42661))) ? f_10930_42629_42654(this, methodDecl) : null;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.ConstructorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 42809, 42897);

                                ConstructorDeclarationSyntax
                                constructorDecl = (ConstructorDeclarationSyntax)memberDecl
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 42927, 42990);

                                var
                                expressionBody = f_10930_42948_42989(constructorDecl)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 43059, 43098);

                                var
                                temp = f_10930_43070_43097(constructorDecl)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 43128, 43498);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 43135, 43421) || ((((temp is not null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 43137, 43185) && temp.FullSpan.Contains(span))) || (DynAbs.Tracing.TraceSender.Expression_False(10930, 43136, 43297) || (expressionBody is not null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 43228, 43296) && expressionBody.FullSpan.Contains(span)))) || (DynAbs.Tracing.TraceSender.Expression_False(10930, 43136, 43420) || (f_10930_43339_43359(constructorDecl) is not null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 43339, 43419) && f_10930_43375_43395(constructorDecl).FullSpan.Contains(span))))) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 43460, 43490)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 43493, 43497))) ? f_10930_43460_43490(this, constructorDecl) : null;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.RecordDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 43640, 43693);

                                var
                                recordDecl = (RecordDeclarationSyntax)memberDecl
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 43723, 44056);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 43730, 44020) || ((f_10930_43730_43754(recordDecl) is object && (DynAbs.Tracing.TraceSender.Expression_True(10930, 43730, 43895) && f_10930_43804_43841(recordDecl) is PrimaryConstructorBaseTypeSyntax baseWithArguments) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 43730, 44020) && (node == baseWithArguments || (DynAbs.Tracing.TraceSender.Expression_False(10930, 43936, 44019) || f_10930_43965_43995(baseWithArguments).FullSpan.Contains(span)))) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 44023, 44048)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 44051, 44055))) ? f_10930_44023_44048(this, memberDecl) : null;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.DestructorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 44202, 44287);

                                DestructorDeclarationSyntax
                                destructorDecl = (DestructorDeclarationSyntax)memberDecl
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 44317, 44379);

                                var
                                expressionBody = f_10930_44338_44378(destructorDecl)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 44448, 44721);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 44455, 44645) || ((((expressionBody is not null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 44457, 44525) && expressionBody.FullSpan.Contains(span))) || (DynAbs.Tracing.TraceSender.Expression_False(10930, 44456, 44644) || (f_10930_44565_44584(destructorDecl) is not null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 44565, 44643) && f_10930_44600_44619(destructorDecl).FullSpan.Contains(span))))) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 44684, 44713)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 44716, 44720))) ? f_10930_44684_44713(this, destructorDecl) : null;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.GetAccessorDeclaration:
                        case SyntaxKind.SetAccessorDeclaration:
                        case SyntaxKind.InitAccessorDeclaration:
                        case SyntaxKind.AddAccessorDeclaration:
                        case SyntaxKind.RemoveAccessorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            // NOTE: not UnknownAccessorDeclaration since there's no corresponding method symbol from which to build a member model.
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 45262, 45319);

                                var
                                accessorDecl = (AccessorDeclarationSyntax)memberDecl
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 45388, 45427);

                                var
                                temp = f_10930_45399_45426(accessorDecl)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 45457, 45704);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 45464, 45630) || ((((temp is not null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 45466, 45514) && temp.FullSpan.Contains(span))) || (DynAbs.Tracing.TraceSender.Expression_False(10930, 45465, 45629) || (f_10930_45554_45571(accessorDecl) is not null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 45554, 45628) && f_10930_45587_45604(accessorDecl).FullSpan.Contains(span))))) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 45669, 45696)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 45699, 45703))) ? f_10930_45669_45696(this, accessorDecl) : null;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.IndexerDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 45847, 45902);

                                var
                                indexerDecl = (IndexerDeclarationSyntax)memberDecl
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 45932, 45997);

                                return f_10930_45939_45996(this, f_10930_45963_45989(indexerDecl), span);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.FieldDeclaration:
                        case SyntaxKind.EventFieldDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 46198, 46253);

                                var
                                fieldDecl = (BaseFieldDeclarationSyntax)memberDecl
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 46283, 46687);
                                    foreach (var variableDecl in f_10930_46312_46343_I(f_10930_46312_46343(f_10930_46312_46333(fieldDecl))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 46283, 46687);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 46409, 46479);

                                        var
                                        binding = f_10930_46423_46478(this, f_10930_46447_46471(variableDecl), span)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 46513, 46656) || true) && (binding != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 46513, 46656);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 46606, 46621);

                                            return binding;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 46513, 46656);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 46283, 46687);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10930, 1, 405);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10930, 1, 405);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10930, 46740, 46746);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.EnumMemberDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 46865, 46920);

                                var
                                enumDecl = (EnumMemberDeclarationSyntax)memberDecl
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 46950, 47115);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 46957, 46987) || (((f_10930_46958_46978(enumDecl) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 47023, 47074)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 47110, 47114))) ? f_10930_47023_47074(this, f_10930_47047_47067(enumDecl), span) : null;
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.PropertyDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 47259, 47316);

                                var
                                propertyDecl = (PropertyDeclarationSyntax)memberDecl
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 47346, 47504);

                                return f_10930_47353_47408(this, f_10930_47377_47401(propertyDecl), span) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>(10930, 47353, 47503) ?? f_10930_47445_47503(this, f_10930_47469_47496(propertyDecl), span));
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.GlobalStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 47613, 47844) || true) && (f_10930_47617_47696(memberDecl))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 47613, 47844);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 47754, 47817);

                                return f_10930_47761_47816(this, (CompilationUnitSyntax?)f_10930_47798_47815(memberDecl));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 47613, 47844);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 47872, 47905);

                            return f_10930_47879_47904(this, memberDecl);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.CompilationUnit:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 47987, 48255) || true) && (f_10930_47991_48127(f_10930_48047_48058(), memberDecl, fallbackToMainEntryPoint: false) is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 47987, 48255);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 48195, 48228);

                                return f_10930_48202_48227(this, memberDecl);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 47987, 48255);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10930, 48281, 48287);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.Attribute:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 48363, 48425);

                            return f_10930_48370_48424(this, memberDecl);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);

                        case SyntaxKind.Parameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 41903, 48850);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 48501, 48831) || true) && (node != memberDecl)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 48501, 48831);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 48581, 48649);

                                return f_10930_48588_48648(this, memberDecl, span);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 48501, 48831);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 48501, 48831);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 48763, 48804);

                                return f_10930_48770_48803(this, f_10930_48785_48802(memberDecl));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 48501, 48831);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41903, 48850);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 41806, 48865);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 48881, 48893);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 41235, 48904);

                bool
                f_10930_41606_41636(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = IsInDocumentationComment(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 41606, 41636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_41730_41756(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = GetMemberDeclaration(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 41730, 41756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_41873_41882(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 41873, 41882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_41911_41928(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 41911, 41928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10930_42295_42331(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                node)
                {
                    var return_v = node.GetExpressionBodySyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 42295, 42331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10930_42518_42533(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 42518, 42533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10930_42549_42564(Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 42549, 42564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_42629_42654(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetOrAddModel((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 42629, 42654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10930_42948_42989(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                node)
                {
                    var return_v = node.GetExpressionBodySyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 42948, 42989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10930_43070_43097(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 43070, 43097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10930_43339_43359(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 43339, 43359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10930_43375_43395(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 43375, 43395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_43460_43490(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetOrAddModel((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 43460, 43490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10930_43730_43754(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 43730, 43754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax?
                f_10930_43804_43841(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.PrimaryConstructorBaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 43804, 43841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax
                f_10930_43965_43995(Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 43965, 43995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_44023_44048(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetOrAddModel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 44023, 44048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10930_44338_44378(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                node)
                {
                    var return_v = node.GetExpressionBodySyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 44338, 44378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10930_44565_44584(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 44565, 44584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10930_44600_44619(Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 44600, 44619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_44684_44713(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DestructorDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetOrAddModel((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 44684, 44713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10930_45399_45426(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 45399, 45426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_10930_45554_45571(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 45554, 45571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax
                f_10930_45587_45604(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 45587, 45604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_45669_45696(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                node)
                {
                    var return_v = this_param.GetOrAddModel((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 45669, 45696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10930_45963_45989(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 45963, 45989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_45939_45996(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                node, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetOrAddModelIfContains((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 45939, 45996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10930_46312_46333(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 46312, 46333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10930_46312_46343(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 46312, 46343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10930_46447_46471(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 46447, 46471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_46423_46478(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                node, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetOrAddModelIfContains((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 46423, 46478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10930_46312_46343_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 46312, 46343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10930_46958_46978(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.EqualsValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 46958, 46978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                f_10930_47047_47067(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.EqualsValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 47047, 47067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_47023_47074(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                node, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetOrAddModelIfContains((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 47023, 47074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10930_47377_47401(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 47377, 47401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_47353_47408(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                node, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetOrAddModelIfContains((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 47353, 47408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                f_10930_47469_47496(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExpressionBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 47469, 47496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_47445_47503(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax?
                node, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetOrAddModelIfContains((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 47445, 47503);
                    return return_v;
                }


                bool
                f_10930_47617_47696(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = SyntaxFacts.IsSimpleProgramTopLevelStatement((Microsoft.CodeAnalysis.CSharp.Syntax.GlobalStatementSyntax)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 47617, 47696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_47798_47815(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 47798, 47815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_47761_47816(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax?
                node)
                {
                    var return_v = this_param.GetOrAddModel((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 47761, 47816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_47879_47904(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetOrAddModel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 47879, 47904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_48047_48058()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 48047, 48058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol?
                f_10930_47991_48127(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                compilationUnit, bool
                fallbackToMainEntryPoint)
                {
                    var return_v = SimpleProgramNamedTypeSymbol.GetSimpleProgramEntryPoint(compilation, (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)compilationUnit, fallbackToMainEntryPoint: fallbackToMainEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 47991, 48127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_48202_48227(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetOrAddModel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 48202, 48227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_48370_48424(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                attribute)
                {
                    var return_v = this_param.GetOrAddModelForAttribute((Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 48370, 48424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_48588_48648(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                paramDecl, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetOrAddModelForParameter((Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax)paramDecl, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 48588, 48648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_48785_48802(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 48785, 48802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_48770_48803(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 48770, 48803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 41235, 48904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 41235, 48904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableDictionary<CSharpSyntaxNode, MemberSemanticModel> TestOnlyMemberModels
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 49097, 49113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 49100, 49113);
                    return _memberModels; DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 49097, 49113);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 49097, 49113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 49097, 49113);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private MemberSemanticModel GetOrAddModelForAttribute(AttributeSyntax attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 49126, 49844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 49231, 49331);

                MemberSemanticModel
                containing = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 49264, 49288) || ((f_10930_49264_49280(attribute) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 49291, 49323)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 49326, 49330))) ? f_10930_49291_49323(this, f_10930_49306_49322(attribute)) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 49347, 49450) || true) && (containing == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 49347, 49450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 49403, 49435);

                    return f_10930_49410_49434(this, attribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 49347, 49450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 49466, 49833);

                return f_10930_49473_49832(ref _memberModels, attribute, (node, binderAndModel) => CreateModelForAttribute(binderAndModel.binder, (AttributeSyntax)node, binderAndModel.model), (binder: f_10930_49761_49811(containing, f_10930_49791_49810(attribute)), model: containing));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 49126, 49844);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_49264_49280(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 49264, 49280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_49306_49322(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 49306, 49322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_49291_49323(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 49291, 49323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_49410_49434(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                node)
                {
                    var return_v = this_param.GetOrAddModel((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 49410, 49434);
                    return return_v;
                }


                int
                f_10930_49791_49810(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 49791, 49810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_49761_49811(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 49761, 49811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_49473_49832(ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>
                location, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                key, System.Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, (Microsoft.CodeAnalysis.CSharp.Binder binder, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel model), Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>
                valueFactory, (Microsoft.CodeAnalysis.CSharp.Binder binder, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel model)
                factoryArgument)
                {
                    var return_v = ImmutableInterlocked.GetOrAdd(ref location, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)key, valueFactory, factoryArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 49473, 49832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 49126, 49844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 49126, 49844);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsInDocumentationComment(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10930, 49856, 50222);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 49958, 49969);
                    for (SyntaxNode
        curr = node
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 49942, 50182) || true) && (curr != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 49985, 50003)
        , curr = f_10930_49992_50003(curr), DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 49942, 50182))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 49942, 50182);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 50037, 50167) || true) && (f_10930_50041_50094(f_10930_50082_50093(curr)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 50037, 50167);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 50136, 50148);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 50037, 50167);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10930, 1, 241);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10930, 1, 241);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 50198, 50211);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10930, 49856, 50222);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10930_49992_50003(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 49992, 50003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_50082_50093(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 50082, 50093);
                    return return_v;
                }


                bool
                f_10930_50041_50094(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsDocumentationCommentTrivia(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 50041, 50094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 49856, 50222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 49856, 50222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberSemanticModel GetOrAddModelForParameter(ParameterSyntax paramDecl, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 50434, 52623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 50554, 50617);

                EqualsValueClauseSyntax
                defaultValueSyntax = f_10930_50599_50616(paramDecl)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 50631, 50731);

                MemberSemanticModel
                containing = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 50664, 50688) || ((f_10930_50664_50680(paramDecl) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 50691, 50723)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 50726, 50730))) ? f_10930_50691_50723(this, f_10930_50706_50722(paramDecl)) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 50747, 50875) || true) && (containing == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 50747, 50875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 50803, 50860);

                    return f_10930_50810_50859(this, defaultValueSyntax, span);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 50747, 50875);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 50891, 52576) || true) && (defaultValueSyntax != null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 50895, 50967) && defaultValueSyntax.FullSpan.Contains(span)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 50891, 52576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 51001, 51092);

                    var
                    parameterSymbol = f_10930_51023_51091(f_10930_51023_51062(containing, paramDecl))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 51110, 52561) || true) && ((object)parameterSymbol != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 51110, 52561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 51187, 52542);

                        return f_10930_51194_52541(ref _memberModels, defaultValueSyntax, (equalsValue, tuple) =>
                                                                                    InitializerSemanticModel.Create(
                                                                                        this,
                                                                                        tuple.paramDecl,
                                                                                        tuple.parameterSymbol,
                                                                                        tuple.containing.GetEnclosingBinder(tuple.paramDecl.SpanStart).
                                                                                            CreateBinderForParameterDefaultValue(tuple.parameterSymbol,
                                                                                                                    (EqualsValueClauseSyntax)equalsValue),
                                                                                        tuple.containing.GetRemappedSymbols()), (compilation: f_10930_52247_52263(this),
                                                                                  paramDecl,
                                                                                  parameterSymbol,
                                                                                  containing));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 51110, 52561);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 50891, 52576);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 52594, 52612);

                return containing;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 50434, 52623);

                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10930_50599_50616(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 50599, 50616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_50664_50680(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 50664, 50680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_50706_50722(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 50706, 50722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_50691_50723(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 50691, 50723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_50810_50859(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                node, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetOrAddModelIfContains((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?)node, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 50810, 50859);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IParameterSymbol
                f_10930_51023_51062(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 51023, 51062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                f_10930_51023_51091(Microsoft.CodeAnalysis.IParameterSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 51023, 51091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_52247_52263(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 52247, 52263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_51194_52541(ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>
                location, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                key, System.Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, (Microsoft.CodeAnalysis.CSharp.CSharpCompilation compilation, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax paramDecl, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol parameterSymbol, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel containing), Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>
                valueFactory, (Microsoft.CodeAnalysis.CSharp.CSharpCompilation compilation, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax paramDecl, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol parameterSymbol, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel containing)
                factoryArgument)
                {
                    var return_v = ImmutableInterlocked.GetOrAdd(ref location, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)key, valueFactory, factoryArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 51194, 52541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 50434, 52623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 50434, 52623);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CSharpSyntaxNode GetMemberDeclaration(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10930, 52635, 52803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 52729, 52792);

                return f_10930_52736_52791(node, s_isMemberDeclarationFunction);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10930, 52635, 52803);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_52736_52791(Microsoft.CodeAnalysis.SyntaxNode
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, bool>
                predicate)
                {
                    var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 52736, 52791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 52635, 52803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 52635, 52803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberSemanticModel GetOrAddModelIfContains(CSharpSyntaxNode node, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 52815, 53090);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 52929, 53053) || true) && (node != null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 52933, 52977) && node.FullSpan.Contains(span)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 52929, 53053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 53011, 53038);

                    return f_10930_53018_53037(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 52929, 53053);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 53067, 53079);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 52815, 53090);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_53018_53037(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetOrAddModel(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 53018, 53037);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 52815, 53090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 52815, 53090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberSemanticModel GetOrAddModel(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 53102, 53433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 53191, 53352);

                var
                createMemberModelFunction = _createMemberModelFunction ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>>(10930, 53223, 53351) ?? (_createMemberModelFunction = this.CreateMemberModel))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 53368, 53422);

                return f_10930_53375_53421(this, node, createMemberModelFunction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 53102, 53433);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_53375_53421(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>
                createMemberModelFunction)
                {
                    var return_v = this_param.GetOrAddModel(node, createMemberModelFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 53375, 53421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 53102, 53433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 53102, 53433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MemberSemanticModel GetOrAddModel(CSharpSyntaxNode node, Func<CSharpSyntaxNode, MemberSemanticModel> createMemberModelFunction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 53445, 53706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 53606, 53695);

                return f_10930_53613_53694(ref _memberModels, node, createMemberModelFunction);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 53445, 53706);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_53613_53694(ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>
                location, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                key, System.Func<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel>
                valueFactory)
                {
                    var return_v = ImmutableInterlocked.GetOrAdd(ref location, key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 53613, 53694);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 53445, 53706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 53445, 53706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MemberSemanticModel CreateMemberModel(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 53999, 63670);

                Binder defaultOuter()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 54114, 54247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 54117, 54247);
                        return f_10930_54117_54247(f_10930_54117_54147(_binderFactory, node), (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 54168, 54193) || ((f_10930_54168_54193(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 54196, 54227)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 54230, 54246))) ? BinderFlags.IgnoreAccessibility : BinderFlags.None); DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 54114, 54247);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 54114, 54247);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 54114, 54247);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 54264, 63105);

                switch (f_10930_54272_54283(node))
                {

                    case SyntaxKind.CompilationUnit:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 54264, 63105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 54371, 54546);

                        return f_10930_54378_54545(node, f_10930_54414_54544(f_10930_54470_54481(), node, fallbackToMainEntryPoint: false));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 54264, 63105);

                    case SyntaxKind.MethodDeclaration:
                    case SyntaxKind.ConversionOperatorDeclaration:
                    case SyntaxKind.OperatorDeclaration:
                    case SyntaxKind.ConstructorDeclaration:
                    case SyntaxKind.DestructorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 54264, 63105);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 54880, 54927);

                            var
                            memberDecl = (MemberDeclarationSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 54953, 55034);

                            var
                            symbol = f_10930_54966_55033(f_10930_54966_54995(this, memberDecl))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 55060, 55117);

                            return f_10930_55067_55116(memberDecl, symbol);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 54264, 63105);

                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 54264, 63105);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 55243, 55347);

                            SynthesizedRecordConstructor
                            symbol = f_10930_55281_55346(this, node)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 55375, 55490) || true) && (symbol is null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 55375, 55490);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 55451, 55463);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 55375, 55490);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 55518, 55569);

                            return f_10930_55525_55568(node, symbol);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 54264, 63105);

                    case SyntaxKind.GetAccessorDeclaration:
                    case SyntaxKind.SetAccessorDeclaration:
                    case SyntaxKind.InitAccessorDeclaration:
                    case SyntaxKind.AddAccessorDeclaration:
                    case SyntaxKind.RemoveAccessorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 54264, 63105);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 55932, 55983);

                            var
                            accessorDecl = (AccessorDeclarationSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 56009, 56092);

                            var
                            symbol = f_10930_56022_56091(f_10930_56022_56053(this, accessorDecl))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 56118, 56177);

                            return f_10930_56125_56176(accessorDecl, symbol);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 54264, 63105);

                    case SyntaxKind.Block:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 54264, 63105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 56325, 56373);

                        f_10930_56325_56372(f_10930_56360_56371(node));
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 56395, 56401);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 54264, 63105);

                    case SyntaxKind.EqualsValueClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 54264, 63105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 56477, 60179);

                        switch (f_10930_56485_56503(f_10930_56485_56496(node)))
                        {

                            case SyntaxKind.VariableDeclarator:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 56477, 60179);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 56653, 56710);

                                    var
                                    variableDecl = (VariableDeclaratorSyntax)f_10930_56698_56709(node)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 56744, 56807);

                                    FieldSymbol
                                    fieldSymbol = f_10930_56770_56806(this, variableDecl)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 56843, 57355);

                                    return f_10930_56850_57354(this, variableDecl, fieldSymbol, f_10930_57263_57353(this, fieldSymbol, f_10930_57312_57326(), f_10930_57328_57352(variableDecl)));
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 56477, 60179);

                            case SyntaxKind.PropertyDeclaration:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 56477, 60179);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 57515, 57573);

                                    var
                                    propertyDecl = (PropertyDeclarationSyntax)f_10930_57561_57572(node)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 57607, 57694);

                                    var
                                    propertySymbol = f_10930_57628_57693(f_10930_57628_57659(this, propertyDecl))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 57728, 58060);

                                    return f_10930_57735_58059(this, propertyDecl, propertySymbol, f_10930_57952_58058(this, f_10930_57988_58015(propertySymbol), f_10930_58017_58031(), f_10930_58033_58057(propertyDecl)));
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 56477, 60179);

                            case SyntaxKind.Parameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 56477, 60179);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 58492, 58553);

                                    ParameterSyntax
                                    parameterDecl = (ParameterSyntax)f_10930_58541_58552(node)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 58587, 58672);

                                    ParameterSymbol
                                    parameterSymbol = f_10930_58621_58671(this, parameterDecl)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 58706, 58792) || true) && ((object)parameterSymbol == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 58706, 58792);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 58780, 58792);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 58706, 58792);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 58828, 59224);

                                    return f_10930_58835_59223(this, parameterDecl, parameterSymbol, f_10930_59054_59153(f_10930_59054_59068(), parameterSymbol, node), parentRemappedSymbolsOpt: null);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 56477, 60179);

                            case SyntaxKind.EnumMemberDeclaration:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 56477, 60179);
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 59386, 59442);

                                    var
                                    enumDecl = (EnumMemberDeclarationSyntax)f_10930_59430_59441(node)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 59476, 59546);

                                    var
                                    enumSymbol = f_10930_59493_59545(f_10930_59493_59520(this, enumDecl))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 59580, 59661) || true) && ((object)enumSymbol == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 59580, 59661);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 59649, 59661);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 59580, 59661);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 59697, 60000);

                                    return f_10930_59704_59999(this, enumDecl, enumSymbol, f_10930_59913_59998(this, enumSymbol, f_10930_59961_59975(), f_10930_59977_59997(enumDecl)));
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 56477, 60179);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 56477, 60179);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 60095, 60156);

                                throw f_10930_60101_60155(f_10930_60136_60154(f_10930_60136_60147(node)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 56477, 60179);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 54264, 63105);

                    case SyntaxKind.ArrowExpressionClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 54264, 63105);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 60286, 60325);

                            SourceMemberMethodSymbol
                            symbol = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 60353, 60402);

                            var
                            exprDecl = (ArrowExpressionClauseSyntax)node
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 60430, 60869) || true) && (f_10930_60434_60445(node) is BasePropertyDeclarationSyntax)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 60430, 60869);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 60536, 60611);

                                symbol = f_10930_60545_60610(f_10930_60545_60572(this, exprDecl));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 60430, 60869);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 60430, 60869);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 60794, 60842);

                                f_10930_60794_60841(f_10930_60829_60840(node));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 60430, 60869);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 60897, 60995);

                            ExecutableCodeBinder
                            binder = f_10930_60927_60994_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(symbol, 10930, 60927, 60994)?.TryGetBodyBinder(_binderFactory, f_10930_60968_60993(this)))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 61023, 61138) || true) && (binder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 61023, 61138);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 61099, 61111);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 61023, 61138);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 61166, 61286);

                            return f_10930_61173_61285(this, symbol, f_10930_61218_61284(exprDecl, binder: binder));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 54264, 63105);

                    case SyntaxKind.GlobalStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 54264, 63105);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 61410, 61435);

                            var
                            parent = f_10930_61423_61434(node)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 61538, 62878) || true) && (f_10930_61542_61555(parent) == SyntaxKind.CompilationUnit && (DynAbs.Tracing.TraceSender.Expression_True(10930, 61542, 61639) && f_10930_61618_61639_M(!this.IsRegularCSharp)) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 61542, 61712) && (object)f_10930_61680_61704(_compilation) != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 61538, 62878);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 61770, 61842);

                                var
                                scriptInitializer = f_10930_61794_61841(f_10930_61794_61818(_compilation))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 61872, 61920);

                                f_10930_61872_61919((object)scriptInitializer != null);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 61950, 62096) || true) && ((object)scriptInitializer == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 61950, 62096);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 62053, 62065);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 61950, 62096);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 62203, 62481) || true) && (_globalStatementLabels == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 62203, 62481);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 62303, 62450);

                                    f_10930_62303_62449(ref _globalStatementLabels, f_10930_62359_62442(scriptInitializer, (CompilationUnitSyntax)parent), null);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 62203, 62481);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 62513, 62851);

                                return f_10930_62520_62850(this, scriptInitializer, f_10930_62676_62849(node, binder: f_10930_62731_62848(node, scriptInitializer, f_10930_62781_62847(_globalStatementLabels, f_10930_62832_62846()))));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 61538, 62878);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 62923, 62929);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 54264, 63105);

                    case SyntaxKind.Attribute:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 54264, 63105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 62997, 63090);

                        return f_10930_63004_63089(this, f_10930_63028_63042(), node, containingModel: null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 54264, 63105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 63121, 63133);

                return null;

                MemberSemanticModel createMethodBodySemanticModel(CSharpSyntaxNode memberDecl, SourceMemberMethodSymbol symbol)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 63149, 63659);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 63293, 63391);

                        ExecutableCodeBinder
                        binder = f_10930_63323_63390_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(symbol, 10930, 63323, 63390)?.TryGetBodyBinder(_binderFactory, f_10930_63364_63389(this)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 63411, 63502) || true) && (binder == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 63411, 63502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 63471, 63483);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 63411, 63502);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 63522, 63644);

                        return f_10930_63529_63643(this, symbol, f_10930_63574_63642(memberDecl, binder: binder));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 63149, 63659);

                        bool
                        f_10930_63364_63389(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                        this_param)
                        {
                            var return_v = this_param.IgnoresAccessibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 63364, 63389);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder?
                        f_10930_63323_63390_I(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 63323, 63390);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState
                        f_10930_63574_63642(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                        syntax, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                        binder)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState(syntax, binder: binder);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 63574, 63642);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                        f_10930_63529_63643(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                        containingSemanticModel, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol?
                        owner, Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState
                        initialState)
                        {
                            var return_v = MethodBodySemanticModel.Create(containingSemanticModel, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?)owner, initialState);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 63529, 63643);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 63149, 63659);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 63149, 63659);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 53999, 63670);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_54117_54147(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 54117, 54147);
                    return return_v;
                }


                bool
                f_10930_54168_54193(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.IgnoresAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 54168, 54193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_54117_54247(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 54117, 54247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_54272_54283(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 54272, 54283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_54470_54481()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 54470, 54481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol?
                f_10930_54414_54544(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                compilationUnit, bool
                fallbackToMainEntryPoint)
                {
                    var return_v = SimpleProgramNamedTypeSymbol.GetSimpleProgramEntryPoint(compilation, (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)compilationUnit, fallbackToMainEntryPoint: fallbackToMainEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 54414, 54544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_54378_54545(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDecl, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol?
                symbol)
                {
                    var return_v = createMethodBodySemanticModel(memberDecl, (Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol?)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 54378, 54545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10930_54966_54995(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 54966, 54995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol?
                f_10930_54966_55033(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 54966, 55033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_55067_55116(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                memberDecl, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                symbol)
                {
                    var return_v = createMethodBodySemanticModel((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)memberDecl, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 55067, 55116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                f_10930_55281_55346(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.TryGetSynthesizedRecordConstructor((Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 55281, 55346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_55525_55568(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDecl, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                symbol)
                {
                    var return_v = createMethodBodySemanticModel(memberDecl, (Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 55525, 55568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_10930_56022_56053(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 56022, 56053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol?
                f_10930_56022_56091(Microsoft.CodeAnalysis.IMethodSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 56022, 56091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_56125_56176(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                memberDecl, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                symbol)
                {
                    var return_v = createMethodBodySemanticModel((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)memberDecl, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 56125, 56176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_56360_56371(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 56360, 56371);
                    return return_v;
                }


                System.Exception
                f_10930_56325_56372(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object?)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 56325, 56372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_56485_56496(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 56485, 56496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_56485_56503(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 56485, 56503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_56698_56709(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 56698, 56709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10930_56770_56806(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                variableDecl)
                {
                    var return_v = this_param.GetDeclaredFieldSymbol(variableDecl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 56770, 56806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_57312_57326()
                {
                    var return_v = defaultOuter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 57312, 57326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10930_57328_57352(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 57328, 57352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_57263_57353(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Binder
                outer, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                initializer)
                {
                    var return_v = this_param.GetFieldOrPropertyInitializerBinder(symbol, outer, initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 57263, 57353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
                f_10930_56850_57354(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                containingSemanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder)
                {
                    var return_v = InitializerSemanticModel.Create(containingSemanticModel, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, fieldSymbol, rootBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 56850, 57354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_57561_57572(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 57561, 57572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol
                f_10930_57628_57659(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 57628, 57659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol?
                f_10930_57628_57693(Microsoft.CodeAnalysis.IPropertySymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 57628, 57693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                f_10930_57988_58015(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param)
                {
                    var return_v = this_param.BackingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 57988, 58015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_58017_58031()
                {
                    var return_v = defaultOuter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 58017, 58031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10930_58033_58057(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 58033, 58057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_57952_58058(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedBackingFieldSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Binder
                outer, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                initializer)
                {
                    var return_v = this_param.GetFieldOrPropertyInitializerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)symbol, outer, initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 57952, 58058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
                f_10930_57735_58059(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                containingSemanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                propertySymbol, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder)
                {
                    var return_v = InitializerSemanticModel.Create(containingSemanticModel, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)propertySymbol, rootBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 57735, 58059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_58541_58552(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 58541, 58552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10930_58621_58671(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredNonLambdaParameterSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 58621, 58671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_59054_59068()
                {
                    var return_v = defaultOuter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 59054, 59068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_59054_59153(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                defaultValueSyntax)
                {
                    var return_v = this_param.CreateBinderForParameterDefaultValue(parameter, (Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax)defaultValueSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 59054, 59153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
                f_10930_58835_59223(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                containingSemanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameterSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                parentRemappedSymbolsOpt)
                {
                    var return_v = InitializerSemanticModel.Create(containingSemanticModel, syntax, parameterSymbol, rootBinder, parentRemappedSymbolsOpt: parentRemappedSymbolsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 58835, 59223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_59430_59441(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 59430, 59441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IFieldSymbol
                f_10930_59493_59520(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 59493, 59520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10930_59493_59545(Microsoft.CodeAnalysis.IFieldSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 59493, 59545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_59961_59975()
                {
                    var return_v = defaultOuter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 59961, 59975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                f_10930_59977_59997(Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.EqualsValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 59977, 59997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_59913_59998(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Binder
                outer, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax?
                initializer)
                {
                    var return_v = this_param.GetFieldOrPropertyInitializerBinder(symbol, outer, initializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 59913, 59998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InitializerSemanticModel
                f_10930_59704_59999(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                containingSemanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder)
                {
                    var return_v = InitializerSemanticModel.Create(containingSemanticModel, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, fieldSymbol, rootBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 59704, 59999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_60136_60147(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 60136, 60147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_60136_60154(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 60136, 60154);
                    return return_v;
                }


                System.Exception
                f_10930_60101_60155(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 60101, 60155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_60434_60445(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 60434, 60445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol
                f_10930_60545_60572(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 60545, 60572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol?
                f_10930_60545_60610(Microsoft.CodeAnalysis.IMethodSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 60545, 60610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_60829_60840(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 60829, 60840);
                    return return_v;
                }


                System.Exception
                f_10930_60794_60841(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object?)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 60794, 60841);
                    return return_v;
                }


                bool
                f_10930_60968_60993(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.IgnoresAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 60968, 60993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder?
                f_10930_60927_60994_I(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 60927, 60994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState
                f_10930_61218_61284(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                binder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, binder: binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 61218, 61284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10930_61173_61285(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                containingSemanticModel, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol?
                owner, Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState
                initialState)
                {
                    var return_v = MethodBodySemanticModel.Create(containingSemanticModel, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?)owner, initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 61173, 61285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_61423_61434(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 61423, 61434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_61542_61555(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 61542, 61555);
                    return return_v;
                }


                bool
                f_10930_61618_61639_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 61618, 61639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10930_61680_61704(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 61680, 61704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_61794_61818(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 61794, 61818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                f_10930_61794_61841(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetScriptInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 61794, 61841);
                    return return_v;
                }


                int
                f_10930_61872_61919(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 61872, 61919);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels
                f_10930_62359_62442(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                scriptInitializer, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels(scriptInitializer, (Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 62359, 62442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels?
                f_10930_62303_62449(ref Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels?
                location1, Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels
                value, Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 62303, 62449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_62832_62846()
                {
                    var return_v = defaultOuter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 62832, 62846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder
                f_10930_62781_62847(Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels
                labels, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder(labels, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 62781, 62847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10930_62731_62848(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                memberSymbol, Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, (Microsoft.CodeAnalysis.CSharp.Binder)next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 62731, 62848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState
                f_10930_62676_62849(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                binder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState(syntax, binder: binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 62676, 62849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel
                f_10930_62520_62850(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                containingSemanticModel, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                owner, Microsoft.CodeAnalysis.CSharp.MethodBodySemanticModel.InitialState
                initialState)
                {
                    var return_v = MethodBodySemanticModel.Create(containingSemanticModel, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)owner, initialState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 62520, 62850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_63028_63042()
                {
                    var return_v = defaultOuter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 63028, 63042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AttributeSemanticModel
                f_10930_63004_63089(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                enclosingBinder, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                attribute, Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                containingModel)
                {
                    var return_v = this_param.CreateModelForAttribute(enclosingBinder, (Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax)attribute, containingModel: containingModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 63004, 63089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 53999, 63670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 53999, 63670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SynthesizedRecordConstructor TryGetSynthesizedRecordConstructor(RecordDeclarationSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 63682, 64125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 63808, 63859);

                NamedTypeSymbol
                recordType = f_10930_63837_63858(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 63873, 63976);

                var
                symbol = f_10930_63886_63975(f_10930_63886_63918(recordType).OfType<SynthesizedRecordConstructor>())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 63992, 64084) || true) && (f_10930_63996_64015_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(symbol, 10930, 63996, 64015)?.GetSyntax()) != node)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 63992, 64084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 64057, 64069);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 63992, 64084);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 64100, 64114);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 63682, 64125);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_63837_63858(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredType((Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 63837, 63858);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10930_63886_63918(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 63886, 63918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                f_10930_63886_63975(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor>
                source)
                {
                    var return_v = source.SingleOrDefault<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 63886, 63975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax?
                f_10930_63996_64015_I(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 63996, 64015);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 63682, 64125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 63682, 64125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private AttributeSemanticModel CreateModelForAttribute(Binder enclosingBinder, AttributeSyntax attribute, MemberSemanticModel containingModel)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 64137, 64862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 64304, 64325);

                AliasSymbol
                aliasOpt
                = default(AliasSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 64339, 64393);

                DiagnosticBag
                discarded = f_10930_64365_64392()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 64407, 64515);

                var
                attributeType = (NamedTypeSymbol)f_10930_64444_64509(enclosingBinder, f_10930_64469_64483(attribute), discarded, out aliasOpt).Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 64529, 64546);

                f_10930_64529_64545(discarded);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 64562, 64851);

                return f_10930_64569_64850(this, attribute, attributeType, aliasOpt, f_10930_64727_64793(enclosingBinder, BinderFlags.AttributeArgument), f_10930_64812_64849_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(containingModel, 10930, 64812, 64849)?.GetRemappedSymbols()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 64137, 64862);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10930_64365_64392()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 64365, 64392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10930_64469_64483(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 64469, 64483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10930_64444_64509(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias)
                {
                    var return_v = this_param.BindType((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)syntax, diagnostics, out alias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 64444, 64509);
                    return return_v;
                }


                int
                f_10930_64529_64545(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 64529, 64545);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_64727_64793(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 64727, 64793);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                f_10930_64812_64849_I(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 64812, 64849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AttributeSemanticModel
                f_10930_64569_64850(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                containingSemanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                attributeType, Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                aliasOpt, Microsoft.CodeAnalysis.CSharp.Binder
                rootBinder, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>?
                parentRemappedSymbolsOpt)
                {
                    var return_v = AttributeSemanticModel.Create(containingSemanticModel, syntax, attributeType, aliasOpt, rootBinder, parentRemappedSymbolsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 64569, 64850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 64137, 64862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 64137, 64862);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FieldSymbol GetDeclaredFieldSymbol(VariableDeclaratorSyntax variableDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 64874, 65532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 64980, 65033);

                var
                declaredSymbol = f_10930_65001_65032(this, variableDecl)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 65049, 65493) || true) && ((object)declaredSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 65049, 65493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 65117, 65478);

                    switch (f_10930_65125_65158(f_10930_65125_65151(f_10930_65125_65144(variableDecl))))
                    {

                        case SyntaxKind.FieldDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 65117, 65478);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 65259, 65306);

                            return f_10930_65266_65305(declaredSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 65117, 65478);

                        case SyntaxKind.EventFieldDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 65117, 65478);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 65394, 65459);

                            return f_10930_65401_65458((f_10930_65402_65441(declaredSymbol)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 65117, 65478);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 65049, 65493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 65509, 65521);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 64874, 65532);

                Microsoft.CodeAnalysis.ISymbol
                f_10930_65001_65032(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 65001, 65032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_65125_65144(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 65125, 65144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_65125_65151(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 65125, 65151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_65125_65158(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 65125, 65158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10930_65266_65305(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 65266, 65305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                f_10930_65402_65441(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 65402, 65441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10930_65401_65458(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 65401, 65458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 64874, 65532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 64874, 65532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Binder GetFieldOrPropertyInitializerBinder(FieldSymbol symbol, Binder outer, EqualsValueClauseSyntax initializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 65544, 66145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 65809, 65956);

                outer = f_10930_65817_65955(outer, symbol, suppressBinderFlagsFieldInitializer: f_10930_65894_65915_M(!this.IsRegularCSharp) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 65894, 65954) && f_10930_65919_65954(f_10930_65919_65940(symbol))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 65972, 66105) || true) && (initializer != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 65972, 66105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 66029, 66090);

                    outer = f_10930_66037_66089(initializer, symbol, outer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 65972, 66105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 66121, 66134);

                return outer;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 65544, 66145);

                bool
                f_10930_65894_65915_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 65894, 65915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_65919_65940(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 65919, 65940);
                    return return_v;
                }


                bool
                f_10930_65919_65954(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 65919, 65954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_65817_65955(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, bool
                suppressBinderFlagsFieldInitializer)
                {
                    var return_v = this_param.GetFieldInitializerBinder(fieldSymbol, suppressBinderFlagsFieldInitializer: suppressBinderFlagsFieldInitializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 65817, 65955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10930_66037_66089(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 66037, 66089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 65544, 66145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 65544, 66145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsMemberDeclaration(CSharpSyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10930, 66157, 66437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 66244, 66426);

                return (node is MemberDeclarationSyntax) || (DynAbs.Tracing.TraceSender.Expression_False(10930, 66251, 66323) || (node is AccessorDeclarationSyntax)) || (DynAbs.Tracing.TraceSender.Expression_False(10930, 66251, 66384) || (f_10930_66348_66359(node) == SyntaxKind.Attribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10930, 66251, 66425) || (f_10930_66389_66400(node) == SyntaxKind.Parameter));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10930, 66157, 66437);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_66348_66359(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 66348, 66359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_66389_66400(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 66389, 66400);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 66157, 66437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 66157, 66437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsRegularCSharp
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 66502, 66615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 66538, 66600);

                    return f_10930_66545_66573(f_10930_66545_66568(f_10930_66545_66560(this))) == SourceCodeKind.Regular;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 66502, 66615);

                    Microsoft.CodeAnalysis.SyntaxTree
                    f_10930_66545_66560(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                    this_param)
                    {
                        var return_v = this_param.SyntaxTree;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 66545, 66560);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ParseOptions
                    f_10930_66545_66568(Microsoft.CodeAnalysis.SyntaxTree
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 66545, 66568);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SourceCodeKind
                    f_10930_66545_66573(Microsoft.CodeAnalysis.ParseOptions
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 66545, 66573);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 66449, 66626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 66449, 66626);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override INamespaceSymbol GetDeclaredSymbol(NamespaceDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 67191, 67505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 67378, 67413);

                f_10930_67378_67412(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 67429, 67494);

                return f_10930_67436_67493(f_10930_67436_67475(this, declarationSyntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 67191, 67505);

                int
                f_10930_67378_67412(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 67378, 67412);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10930_67436_67475(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredNamespace(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 67436, 67475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol?
                f_10930_67436_67493(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 67436, 67493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 67191, 67505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 67191, 67505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceSymbol GetDeclaredNamespace(NamespaceDeclarationSyntax declarationSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 67517, 68621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 67632, 67672);

                f_10930_67632_67671(declarationSyntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 67688, 67720);

                NamespaceOrTypeSymbol
                container
                = default(NamespaceOrTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 67734, 68029) || true) && (f_10930_67738_67769(f_10930_67738_67762(declarationSyntax)) == SyntaxKind.CompilationUnit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 67734, 68029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 67833, 67883);

                    container = f_10930_67845_67882(f_10930_67845_67866(_compilation));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 67734, 68029);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 67734, 68029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 67949, 68014);

                    container = f_10930_67961_68013(this, f_10930_67988_68012(declarationSyntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 67734, 68029);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 68045, 68085);

                f_10930_68045_68084((object)container != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 68231, 68338);

                var
                symbol = (NamespaceSymbol)f_10930_68261_68337(this, container, f_10930_68290_68312(declarationSyntax), f_10930_68314_68336(declarationSyntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 68352, 68389);

                f_10930_68352_68388((object)symbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 68475, 68529);

                symbol = f_10930_68484_68528(_compilation, symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 68543, 68580);

                f_10930_68543_68579((object)symbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 68596, 68610);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 67517, 68621);

                int
                f_10930_67632_67671(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 67632, 67671);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_67738_67762(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 67738, 67762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_67738_67769(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 67738, 67769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10930_67845_67866(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 67845, 67866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10930_67845_67882(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 67845, 67882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_67988_68012(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 67988, 68012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10930_67961_68013(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredNamespaceOrType(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 67961, 68013);
                    return return_v;
                }


                int
                f_10930_68045_68084(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 68045, 68084);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_68290_68312(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 68290, 68312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10930_68314_68336(Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 68314, 68336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_68261_68337(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 68261, 68337);
                    return return_v;
                }


                int
                f_10930_68352_68388(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 68352, 68388);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                f_10930_68484_68528(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                namespaceSymbol)
                {
                    var return_v = this_param.GetCompilationNamespace(namespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 68484, 68528);
                    return return_v;
                }


                int
                f_10930_68543_68579(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 68543, 68579);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 67517, 68621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 67517, 68621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override INamedTypeSymbol GetDeclaredSymbol(BaseTypeDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 69179, 69487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 69365, 69400);

                f_10930_69365_69399(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 69416, 69476);

                return f_10930_69423_69475(f_10930_69423_69457(this, declarationSyntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 69179, 69487);

                int
                f_10930_69365_69399(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 69365, 69399);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_69423_69457(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredType(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 69423, 69457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10930_69423_69475(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 69423, 69475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 69179, 69487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 69179, 69487);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override INamedTypeSymbol GetDeclaredSymbol(DelegateDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 69863, 70171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70049, 70084);

                f_10930_70049_70083(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70100, 70160);

                return f_10930_70107_70159(f_10930_70107_70141(this, declarationSyntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 69863, 70171);

                int
                f_10930_70049_70083(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 70049, 70083);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_70107_70141(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredType(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 70107, 70141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_10930_70107_70159(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 70107, 70159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 69863, 70171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 69863, 70171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetDeclaredType(BaseTypeDeclarationSyntax declarationSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 70183, 70476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70292, 70332);

                f_10930_70292_70331(declarationSyntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70348, 70398);

                var
                name = declarationSyntax.Identifier.ValueText
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70412, 70465);

                return f_10930_70419_70464(this, declarationSyntax, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 70183, 70476);

                int
                f_10930_70292_70331(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 70292, 70331);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_70419_70464(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                declarationSyntax, string
                name)
                {
                    var return_v = this_param.GetDeclaredNamedType((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 70419, 70464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 70183, 70476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 70183, 70476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetDeclaredType(DelegateDeclarationSyntax declarationSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 70488, 70781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70597, 70637);

                f_10930_70597_70636(declarationSyntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70653, 70703);

                var
                name = declarationSyntax.Identifier.ValueText
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70717, 70770);

                return f_10930_70724_70769(this, declarationSyntax, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 70488, 70781);

                int
                f_10930_70597_70636(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 70597, 70636);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_70724_70769(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                declarationSyntax, string
                name)
                {
                    var return_v = this_param.GetDeclaredNamedType((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 70724, 70769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 70488, 70781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 70488, 70781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetDeclaredNamedType(CSharpSyntaxNode declarationSyntax, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 70793, 71280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70911, 70951);

                f_10930_70911_70950(declarationSyntax != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 70967, 71033);

                var
                container = f_10930_70983_71032(this, declarationSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71047, 71087);

                f_10930_71047_71086((object)container != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71184, 71269);

                return f_10930_71191_71249(this, container, f_10930_71220_71242(declarationSyntax), name) as NamedTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 70793, 71280);

                int
                f_10930_70911_70950(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 70911, 70950);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10930_70983_71032(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDeclaration)
                {
                    var return_v = this_param.GetDeclaredTypeMemberContainer(memberDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 70983, 71032);
                    return return_v;
                }


                int
                f_10930_71047_71086(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 71047, 71086);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_71220_71242(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 71220, 71242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_71191_71249(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan, string
                name)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 71191, 71249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 70793, 71280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 70793, 71280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeSymbol GetDeclaredNamespaceOrType(CSharpSyntaxNode declarationSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 71292, 72164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71409, 71490);

                var
                namespaceDeclarationSyntax = declarationSyntax as NamespaceDeclarationSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71504, 71647) || true) && (namespaceDeclarationSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 71504, 71647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71576, 71632);

                    return f_10930_71583_71631(this, namespaceDeclarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 71504, 71647);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71663, 71738);

                var
                typeDeclarationSyntax = declarationSyntax as BaseTypeDeclarationSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71752, 71880) || true) && (typeDeclarationSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 71752, 71880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71819, 71865);

                    return f_10930_71826_71864(this, typeDeclarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 71752, 71880);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71896, 71975);

                var
                delegateDeclarationSyntax = declarationSyntax as DelegateDeclarationSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 71989, 72125) || true) && (delegateDeclarationSyntax != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 71989, 72125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 72060, 72110);

                    return f_10930_72067_72109(this, delegateDeclarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 71989, 72125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 72141, 72153);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 71292, 72164);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10930_71583_71631(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NamespaceDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredNamespace(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 71583, 71631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_71826_71864(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseTypeDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredType(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 71826, 71864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_72067_72109(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredType(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 72067, 72109);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 71292, 72164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 71292, 72164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(MemberDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 73100, 74359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 73275, 73310);

                f_10930_73275_73309(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 73326, 74348);

                switch (f_10930_73334_73358(declarationSyntax))
                {

                    case SyntaxKind.GlobalStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 73326, 74348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 73713, 73725);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 73326, 74348);

                    case SyntaxKind.IncompleteMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 73326, 74348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 73870, 73882);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 73326, 74348);

                    case SyntaxKind.EventFieldDeclaration:
                    case SyntaxKind.FieldDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 73326, 74348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 74152, 74164);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 73326, 74348);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 73326, 74348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 74214, 74333);

                        return f_10930_74221_74332((f_10930_74222_74267(this, declarationSyntax) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>(10930, 74222, 74313) ?? f_10930_74271_74313(this, declarationSyntax))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 73326, 74348);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 73100, 74359);

                int
                f_10930_73275_73309(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 73275, 73309);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_73334_73358(Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 73334, 73358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10930_74222_74267(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredNamespaceOrType((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 74222, 74267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_74271_74313(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredMemberSymbol((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 74271, 74313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_10930_74221_74332(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 74221, 74332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 73100, 74359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 73100, 74359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IMethodSymbol GetDeclaredSymbol(CompilationUnitSyntax declarationSyntax, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 74371, 74739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 74531, 74566);

                f_10930_74531_74565(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 74582, 74728);

                return f_10930_74589_74727(f_10930_74589_74709(f_10930_74645_74656(), declarationSyntax, fallbackToMainEntryPoint: false));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 74371, 74739);

                int
                f_10930_74531_74565(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 74531, 74565);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_74645_74656()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 74645, 74656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol?
                f_10930_74589_74709(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                compilationUnit, bool
                fallbackToMainEntryPoint)
                {
                    var return_v = SimpleProgramNamedTypeSymbol.GetSimpleProgramEntryPoint(compilation, compilationUnit, fallbackToMainEntryPoint: fallbackToMainEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 74589, 74709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10930_74589_74727(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 74589, 74727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 74371, 74739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 74371, 74739);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(LocalFunctionStatementSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 75116, 75461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 75296, 75331);

                f_10930_75296_75330(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 75347, 75450);

                return f_10930_75354_75449_I(f_10930_75354_75392(this, declarationSyntax).GetDeclaredSymbol(declarationSyntax, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 75116, 75461);

                int
                f_10930_75296_75330(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 75296, 75330);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel?
                f_10930_75354_75392(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                node)
                {
                    var return_v = this_param?.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 75354, 75392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_10930_75354_75449_I(Microsoft.CodeAnalysis.ISymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 75354, 75449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 75116, 75461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 75116, 75461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IFieldSymbol GetDeclaredSymbol(EnumMemberDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 75840, 76118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 76024, 76107);

                return f_10930_76031_76106(((FieldSymbol)f_10930_76045_76087(this, declarationSyntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 75840, 76118);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_76045_76087(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EnumMemberDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredMemberSymbol((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 76045, 76087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IFieldSymbol?
                f_10930_76031_76106(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 76031, 76106);
                    return (IFieldSymbol?)return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 75840, 76118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 75840, 76118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IMethodSymbol GetDeclaredSymbol(BaseMethodDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 76688, 76968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 76873, 76957);

                return f_10930_76880_76956(((MethodSymbol)f_10930_76895_76937(this, declarationSyntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 76688, 76968);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_76895_76937(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredMemberSymbol((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 76895, 76937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10930_76880_76956(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 76880, 76956);
                    return (IMethodSymbol?)return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 76688, 76968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 76688, 76968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(BasePropertyDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 77501, 77761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 77682, 77750);

                return f_10930_77689_77749(f_10930_77689_77731(this, declarationSyntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 77501, 77761);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_77689_77731(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BasePropertyDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredMemberSymbol((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 77689, 77731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_10930_77689_77749(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 77689, 77749);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 77501, 77761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 77501, 77761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IPropertySymbol GetDeclaredSymbol(PropertyDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 78173, 78455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 78358, 78444);

                return f_10930_78365_78443(((PropertySymbol)f_10930_78382_78424(this, declarationSyntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 78173, 78455);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_78382_78424(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredMemberSymbol((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 78382, 78424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10930_78365_78443(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 78365, 78443);
                    return (IPropertySymbol?)return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 78173, 78455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 78173, 78455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IPropertySymbol GetDeclaredSymbol(IndexerDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 78846, 79127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 79030, 79116);

                return f_10930_79037_79115(((PropertySymbol)f_10930_79054_79096(this, declarationSyntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 78846, 79127);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_79054_79096(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredMemberSymbol((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 79054, 79096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol?
                f_10930_79037_79115(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 79037, 79115);
                    return (IPropertySymbol?)return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 78846, 79127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 78846, 79127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEventSymbol GetDeclaredSymbol(EventDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 79518, 79791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 79697, 79780);

                return f_10930_79704_79779(((EventSymbol)f_10930_79718_79760(this, declarationSyntax)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 79518, 79791);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_79718_79760(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredMemberSymbol((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 79718, 79760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IEventSymbol?
                f_10930_79704_79779(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 79704, 79779);
                    return (IEventSymbol?)return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 79518, 79791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 79518, 79791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IMethodSymbol GetDeclaredSymbol(AccessorDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 80237, 81727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 80420, 80455);

                f_10930_80420_80454(this, declarationSyntax);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 80471, 80683) || true) && (f_10930_80475_80499(declarationSyntax) == SyntaxKind.UnknownAccessorDeclaration)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 80471, 80683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 80656, 80668);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 80471, 80683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 80699, 80757);

                var
                propertyOrEventDecl = f_10930_80725_80756(f_10930_80725_80749(declarationSyntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 80773, 81716);

                switch (f_10930_80781_80807(propertyOrEventDecl))
                {

                    case SyntaxKind.PropertyDeclaration:
                    case SyntaxKind.IndexerDeclaration:
                    case SyntaxKind.EventDeclaration:
                    case SyntaxKind.EventFieldDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 80773, 81716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 81230, 81298);

                        var
                        container = f_10930_81246_81297(this, propertyOrEventDecl)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 81320, 81360);

                        f_10930_81320_81359((object)container != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 81382, 81459);

                        f_10930_81382_81458(declarationSyntax.Keyword.Kind() != SyntaxKind.IdentifierToken);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 81481, 81582);

                        return f_10930_81488_81581((f_10930_81489_81546(this, container, f_10930_81523_81545(declarationSyntax)) as MethodSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 80773, 81716);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 80773, 81716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 81632, 81701);

                        throw f_10930_81638_81700(f_10930_81673_81699(propertyOrEventDecl));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 80773, 81716);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 80237, 81727);

                int
                f_10930_80420_80454(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 80420, 80454);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_80475_80499(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 80475, 80499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_80725_80749(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 80725, 80749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_80725_80756(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 80725, 80756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_80781_80807(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 80781, 80807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10930_81246_81297(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDeclaration)
                {
                    var return_v = this_param.GetDeclaredTypeMemberContainer(memberDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 81246, 81297);
                    return return_v;
                }


                int
                f_10930_81320_81359(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 81320, 81359);
                    return 0;
                }


                int
                f_10930_81382_81458(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 81382, 81458);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_81523_81545(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 81523, 81545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_81489_81546(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 81489, 81546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10930_81488_81581(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 81488, 81581);
                    return (IMethodSymbol?)return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_81673_81699(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 81673, 81699);
                    return return_v;
                }


                System.Exception
                f_10930_81638_81700(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 81638, 81700);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 80237, 81727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 80237, 81727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IMethodSymbol GetDeclaredSymbol(ArrowExpressionClauseSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 81739, 83000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 81924, 81959);

                f_10930_81924_81958(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 81975, 82029);

                var
                containingMemberSyntax = f_10930_82004_82028(declarationSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 82045, 82077);

                NamespaceOrTypeSymbol
                container
                = default(NamespaceOrTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 82091, 82989);

                switch (f_10930_82099_82128(containingMemberSyntax))
                {

                    case SyntaxKind.PropertyDeclaration:
                    case SyntaxKind.IndexerDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 82091, 82989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 82273, 82340);

                        container = f_10930_82285_82339(this, containingMemberSyntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 82362, 82402);

                        f_10930_82362_82401((object)container != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 82662, 82763);

                        return f_10930_82669_82762((f_10930_82670_82727(this, container, f_10930_82704_82726(declarationSyntax)) as MethodSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 82091, 82989);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 82091, 82989);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 82874, 82940);

                        f_10930_82874_82939(f_10930_82909_82938(containingMemberSyntax));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 82962, 82974);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 82091, 82989);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 81739, 83000);

                int
                f_10930_81924_81958(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 81924, 81958);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_82004_82028(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 82004, 82028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_82099_82128(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 82099, 82128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10930_82285_82339(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDeclaration)
                {
                    var return_v = this_param.GetDeclaredTypeMemberContainer(memberDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 82285, 82339);
                    return return_v;
                }


                int
                f_10930_82362_82401(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 82362, 82401);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_82704_82726(Microsoft.CodeAnalysis.CSharp.Syntax.ArrowExpressionClauseSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 82704, 82726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_82670_82727(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 82670, 82727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_10930_82669_82762(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 82669, 82762);
                    return (IMethodSymbol?)return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_82909_82938(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 82909, 82938);
                    return return_v;
                }


                System.Exception
                f_10930_82874_82939(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 82874, 82939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 81739, 83000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 81739, 83000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDeclarationName(CSharpSyntaxNode declaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 83012, 87001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 83100, 86990);

                switch (f_10930_83108_83126(declaration))
                {

                    case SyntaxKind.MethodDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 83243, 83297);

                            var
                            methodDecl = (MethodDeclarationSyntax)declaration
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 83323, 83434);

                            return f_10930_83330_83433(this, declaration, f_10930_83362_83399(methodDecl), methodDecl.Identifier.ValueText);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.PropertyDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 83562, 83620);

                            var
                            propertyDecl = (PropertyDeclarationSyntax)declaration
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 83646, 83761);

                            return f_10930_83653_83760(this, declaration, f_10930_83685_83724(propertyDecl), propertyDecl.Identifier.ValueText);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.IndexerDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 83888, 83944);

                            var
                            indexerDecl = (IndexerDeclarationSyntax)declaration
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 83970, 84079);

                            return f_10930_83977_84078(this, declaration, f_10930_84009_84047(indexerDecl), WellKnownMemberNames.Indexer);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.EventDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 84204, 84256);

                            var
                            eventDecl = (EventDeclarationSyntax)declaration
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 84282, 84391);

                            return f_10930_84289_84390(this, declaration, f_10930_84321_84357(eventDecl), eventDecl.Identifier.ValueText);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.DelegateDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 84492, 84561);

                        return ((DelegateDeclarationSyntax)declaration).Identifier.ValueText;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.InterfaceDeclaration:
                    case SyntaxKind.StructDeclaration:
                    case SyntaxKind.ClassDeclaration:
                    case SyntaxKind.EnumDeclaration:
                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 84845, 84914);

                        return ((BaseTypeDeclarationSyntax)declaration).Identifier.ValueText;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.VariableDeclarator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 84991, 85059);

                        return ((VariableDeclaratorSyntax)declaration).Identifier.ValueText;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.EnumMemberDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 85139, 85210);

                        return ((EnumMemberDeclarationSyntax)declaration).Identifier.ValueText;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.DestructorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 85290, 85333);

                        return WellKnownMemberNames.DestructorName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.ConstructorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 85414, 85774) || true) && (((ConstructorDeclarationSyntax)declaration).Modifiers.Any(SyntaxKind.StaticKeyword))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 85414, 85774);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 85551, 85601);

                            return WellKnownMemberNames.StaticConstructorName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 85414, 85774);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 85414, 85774);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 85699, 85751);

                            return WellKnownMemberNames.InstanceConstructorName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 85414, 85774);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.OperatorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 85852, 85910);

                        var
                        operatorDecl = (OperatorDeclarationSyntax)declaration
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 85934, 85997);

                        return f_10930_85941_85996(operatorDecl);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.ConversionOperatorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 86085, 86475) || true) && (((ConversionOperatorDeclarationSyntax)declaration).ImplicitOrExplicitKeyword.Kind() == SyntaxKind.ExplicitKeyword)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 86085, 86475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 86252, 86303);

                            return WellKnownMemberNames.ExplicitConversionName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 86085, 86475);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 86085, 86475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 86401, 86452);

                            return WellKnownMemberNames.ImplicitConversionName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 86085, 86475);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.EventFieldDeclaration:
                    case SyntaxKind.FieldDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 86606, 86696);

                        throw f_10930_86612_86695(f_10930_86634_86694());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    case SyntaxKind.IncompleteMember:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 86852, 86864);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 83100, 86990);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 86914, 86975);

                        throw f_10930_86920_86974(f_10930_86955_86973(declaration));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 83100, 86990);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 83012, 87001);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_83108_83126(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 83108, 83126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10930_83362_83399(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 83362, 83399);
                    return return_v;
                }


                string
                f_10930_83330_83433(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declaration, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                explicitInterfaceSpecifierOpt, string
                memberName)
                {
                    var return_v = this_param.GetDeclarationName(declaration, explicitInterfaceSpecifierOpt, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 83330, 83433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10930_83685_83724(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 83685, 83724);
                    return return_v;
                }


                string
                f_10930_83653_83760(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declaration, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                explicitInterfaceSpecifierOpt, string
                memberName)
                {
                    var return_v = this_param.GetDeclarationName(declaration, explicitInterfaceSpecifierOpt, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 83653, 83760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10930_84009_84047(Microsoft.CodeAnalysis.CSharp.Syntax.IndexerDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 84009, 84047);
                    return return_v;
                }


                string
                f_10930_83977_84078(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declaration, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                explicitInterfaceSpecifierOpt, string
                memberName)
                {
                    var return_v = this_param.GetDeclarationName(declaration, explicitInterfaceSpecifierOpt, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 83977, 84078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                f_10930_84321_84357(Microsoft.CodeAnalysis.CSharp.Syntax.EventDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ExplicitInterfaceSpecifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 84321, 84357);
                    return return_v;
                }


                string
                f_10930_84289_84390(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declaration, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax?
                explicitInterfaceSpecifierOpt, string
                memberName)
                {
                    var return_v = this_param.GetDeclarationName(declaration, explicitInterfaceSpecifierOpt, memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 84289, 84390);
                    return return_v;
                }


                string
                f_10930_85941_85996(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                declaration)
                {
                    var return_v = OperatorFacts.OperatorNameFromDeclaration(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 85941, 85996);
                    return return_v;
                }


                string
                f_10930_86634_86694()
                {
                    var return_v = CSharpResources.InvalidGetDeclarationNameMultipleDeclarators;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 86634, 86694);
                    return return_v;
                }


                System.ArgumentException
                f_10930_86612_86695(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 86612, 86695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_86955_86973(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 86955, 86973);
                    return return_v;
                }


                System.Exception
                f_10930_86920_86974(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 86920, 86974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 83012, 87001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 83012, 87001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDeclarationName(CSharpSyntaxNode declaration, ExplicitInterfaceSpecifierSyntax explicitInterfaceSpecifierOpt, string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 87013, 87789);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 87184, 87292) || true) && (explicitInterfaceSpecifierOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 87184, 87292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 87259, 87277);

                    return memberName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 87184, 87292);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 87650, 87778);

                return f_10930_87657_87777(f_10930_87696_87733(_binderFactory, declaration), explicitInterfaceSpecifierOpt, memberName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 87013, 87789);

                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_87696_87733(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 87696, 87733);
                    return return_v;
                }


                string
                f_10930_87657_87777(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExplicitInterfaceSpecifierSyntax
                explicitInterfaceSpecifierOpt, string
                name)
                {
                    var return_v = ExplicitInterfaceHelpers.GetMemberName(binder, explicitInterfaceSpecifierOpt, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 87657, 87777);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 87013, 87789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 87013, 87789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol GetDeclaredMember(NamespaceOrTypeSymbol container, TextSpan declarationSpan, NameSyntax name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 87801, 88964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 87934, 88953);

                switch (f_10930_87942_87953(name))
                {

                    case SyntaxKind.GenericName:
                    case SyntaxKind.IdentifierName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 87934, 88953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 88086, 88186);

                        return f_10930_88093_88185(this, container, declarationSpan, ((SimpleNameSyntax)name).Identifier.ValueText);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 87934, 88953);

                    case SyntaxKind.QualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 87934, 88953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 88258, 88293);

                        var
                        qn = (QualifiedNameSyntax)name
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 88315, 88406);

                        var
                        left = f_10930_88326_88380(this, container, declarationSpan, f_10930_88372_88379(qn)) as NamespaceOrTypeSymbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 88428, 88463);

                        f_10930_88428_88462((object)left != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 88485, 88543);

                        return f_10930_88492_88542(this, left, declarationSpan, f_10930_88533_88541(qn));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 87934, 88953);

                    case SyntaxKind.AliasQualifiedName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 87934, 88953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 88710, 88750);

                        var
                        an = (AliasQualifiedNameSyntax)name
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 88772, 88834);

                        return f_10930_88779_88833(this, container, declarationSpan, f_10930_88825_88832(an));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 87934, 88953);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 87934, 88953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 88884, 88938);

                        throw f_10930_88890_88937(f_10930_88925_88936(name));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 87934, 88953);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 87801, 88964);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_87942_87953(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 87942, 87953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_88093_88185(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan, string
                name)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 88093, 88185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10930_88372_88379(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 88372, 88379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_88326_88380(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 88326, 88380);
                    return return_v;
                }


                int
                f_10930_88428_88462(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 88428, 88462);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10930_88533_88541(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 88533, 88541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_88492_88542(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                name)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan, (Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 88492, 88542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                f_10930_88825_88832(Microsoft.CodeAnalysis.CSharp.Syntax.AliasQualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 88825, 88832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_88779_88833(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan, Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                name)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan, (Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax)name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 88779, 88833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_88925_88936(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 88925, 88936);
                    return return_v;
                }


                System.Exception
                f_10930_88890_88937(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 88890, 88937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 87801, 88964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 87801, 88964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol GetDeclaredMember(NamespaceOrTypeSymbol container, TextSpan declarationSpan, string name = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 89122, 91785);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 89258, 89348) || true) && ((object)container == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 89258, 89348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 89321, 89333);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 89258, 89348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 89431, 89524);

                var
                collection = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 89448, 89460) || ((name != null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 89463, 89489)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 89492, 89523))) ? f_10930_89463_89489(container, name) : f_10930_89492_89523(container)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 89540, 89569);

                Symbol
                zeroWidthMatch = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 89583, 91407);
                    foreach (var symbol in f_10930_89606_89616_I(collection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 89583, 91407);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 89650, 89700);

                        var
                        namedType = symbol as ImplicitNamedTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 89718, 90127) || true) && ((object)namedType != null && (DynAbs.Tracing.TraceSender.Expression_True(10930, 89722, 89776) && f_10930_89751_89776(namedType)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 89718, 90127);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 89908, 89973);

                            var
                            result = f_10930_89921_89972(this, namedType, declarationSpan, name)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 89995, 90108) || true) && ((object)result != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 89995, 90108);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 90071, 90085);

                                return result;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 89995, 90108);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 89718, 90127);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 90147, 90800);
                            foreach (var loc in f_10930_90167_90183_I(f_10930_90167_90183(symbol)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 90147, 90800);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 90225, 90781) || true) && (f_10930_90229_90243(loc) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 90229, 90280) && f_10930_90247_90261(loc) == f_10930_90265_90280(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 90229, 90324) && declarationSpan.Contains(f_10930_90309_90323(loc))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 90225, 90781);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 90374, 90758) || true) && (loc.SourceSpan.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10930, 90378, 90447) && loc.SourceSpan.End == declarationSpan.Start))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 90374, 90758);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 90579, 90603);

                                        zeroWidthMatch = symbol;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 90374, 90758);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 90374, 90758);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 90717, 90731);

                                        return symbol;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 90374, 90758);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 90225, 90781);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 90147, 90800);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10930, 1, 654);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10930, 1, 654);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 90899, 91046);

                        var
                        partial = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 90913, 90945) || ((f_10930_90913_90924(symbol) == SymbolKind.Method
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 90969, 91017)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 91041, 91045))) ? f_10930_90969_91017(((MethodSymbol)symbol)) : null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 91064, 91392) || true) && ((object)partial != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 91064, 91392);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 91133, 91164);

                            var
                            loc = f_10930_91143_91160(partial)[0]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 91186, 91373) || true) && (f_10930_91190_91204(loc) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 91190, 91241) && f_10930_91208_91222(loc) == f_10930_91226_91241(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 91190, 91285) && declarationSpan.Contains(f_10930_91270_91284(loc))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 91186, 91373);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 91335, 91350);

                                return partial;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 91186, 91373);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 91064, 91392);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 89583, 91407);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10930, 1, 1825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10930, 1, 1825);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 91662, 91774);

                return zeroWidthMatch ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10930, 91669, 91773) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(10930, 91705, 91717) || ((name != null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 91720, 91765)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 91768, 91772))) ? f_10930_91720_91765(this, container, declarationSpan) : null));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 89122, 91785);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10930_89463_89489(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 89463, 89489);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10930_89492_89523(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 89492, 89523);
                    return return_v;
                }


                bool
                f_10930_89751_89776(Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 89751, 89776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_89921_89972(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ImplicitNamedTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan, string?
                name)
                {
                    var return_v = this_param.GetDeclaredMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, declarationSpan, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 89921, 89972);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10930_90167_90183(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 90167, 90183);
                    return return_v;
                }


                bool
                f_10930_90229_90243(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 90229, 90243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_90247_90261(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 90247, 90261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_90265_90280(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 90265, 90280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_90309_90323(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 90309, 90323);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10930_90167_90183_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 90167, 90183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10930_90913_90924(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 90913, 90924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10930_90969_91017(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialImplementationPart
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 90969, 91017);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10930_91143_91160(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 91143, 91160);
                    return return_v;
                }


                bool
                f_10930_91190_91204(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 91190, 91204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_91208_91222(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 91208, 91222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_91226_91241(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 91226, 91241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_91270_91284(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 91270, 91284);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10930_89606_89616_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 89606, 89616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_91720_91765(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 91720, 91765);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 89122, 91785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 89122, 91785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(VariableDeclaratorSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 92157, 93147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 92333, 92368);

                f_10930_92333_92367(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 92384, 92500);

                var
                field = (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 92396, 92428) || ((f_10930_92396_92420(declarationSyntax) == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 92431, 92435)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 92438, 92499))) ? null : f_10930_92438_92469(f_10930_92438_92462(declarationSyntax)) as BaseFieldDeclarationSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 92514, 92930) || true) && (field != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 92514, 92930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 92565, 92619);

                    var
                    container = f_10930_92581_92618(this, field)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 92637, 92677);

                    f_10930_92637_92676((object)container != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 92697, 92808);

                    var
                    result = f_10930_92710_92807(this, container, f_10930_92744_92766(declarationSyntax), declarationSyntax.Identifier.ValueText)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 92826, 92863);

                    f_10930_92826_92862((object)result != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 92883, 92915);

                    return f_10930_92890_92914(result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 92514, 92930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 92989, 93046);

                var
                memberModel = f_10930_93007_93045(this, declarationSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 93060, 93136);

                return f_10930_93067_93135_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(memberModel, 10930, 93067, 93135)?.GetDeclaredSymbol(declarationSyntax, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 92157, 93147);

                int
                f_10930_92333_92367(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 92333, 92367);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_92396_92420(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 92396, 92420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_92438_92462(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 92438, 92462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_92438_92469(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 92438, 92469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10930_92581_92618(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                memberDeclaration)
                {
                    var return_v = this_param.GetDeclaredTypeMemberContainer((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)memberDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 92581, 92618);
                    return return_v;
                }


                int
                f_10930_92637_92676(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 92637, 92676);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_92744_92766(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 92744, 92766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_92710_92807(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan, string
                name)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 92710, 92807);
                    return return_v;
                }


                int
                f_10930_92826_92862(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 92826, 92862);
                    return 0;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_10930_92890_92914(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 92890, 92914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_93007_93045(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 93007, 93045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_10930_93067_93135_I(Microsoft.CodeAnalysis.ISymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 93067, 93135);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 92157, 93147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 92157, 93147);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ISymbol GetDeclaredSymbol(SingleVariableDesignationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 93159, 93895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 93385, 93442);

                var
                memberModel = f_10930_93403_93441(this, declarationSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 93456, 93541);

                ISymbol
                local = f_10930_93472_93540_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(memberModel, 10930, 93472, 93540)?.GetDeclaredSymbol(declarationSyntax, cancellationToken))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 93557, 93636) || true) && (local != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 93557, 93636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 93608, 93621);

                    return local;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 93557, 93636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 93685, 93748);

                Binder
                binder = f_10930_93701_93747(this, f_10930_93720_93746(declarationSyntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 93785, 93884);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 93792, 93810) || ((binder is not null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 93813, 93876)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 93879, 93883))) ? f_10930_93813_93876(f_10930_93813_93858(binder, declarationSyntax)) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 93159, 93895);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_93403_93441(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 93403, 93441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_10930_93472_93540_I(Microsoft.CodeAnalysis.ISymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 93472, 93540);
                    return return_v;
                }


                int
                f_10930_93720_93746(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 93720, 93746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_93701_93747(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetEnclosingBinder(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 93701, 93747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10930_93813_93858(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                variableDesignator)
                {
                    var return_v = this_param.LookupDeclaredField(variableDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 93813, 93858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IFieldSymbol?
                f_10930_93813_93876(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 93813, 93876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 93159, 93895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 93159, 93895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override LocalSymbol GetAdjustedLocalSymbol(SourceLocalSymbol originalSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 93907, 94189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 94018, 94074);

                var
                position = originalSymbol.IdentifierToken.SpanStart
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 94088, 94178);

                return f_10930_94095_94159_I(f_10930_94095_94119(this, position).GetAdjustedLocalSymbol(originalSymbol)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?>(10930, 94095, 94177) ?? originalSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 93907, 94189);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel?
                f_10930_94095_94119(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param?.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 94095, 94119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?
                f_10930_94095_94159_I(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 94095, 94159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 93907, 94189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 93907, 94189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ILabelSymbol GetDeclaredSymbol(LabeledStatementSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 94568, 94984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 94747, 94782);

                f_10930_94747_94781(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 94798, 94855);

                var
                memberModel = f_10930_94816_94854(this, declarationSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 94869, 94973);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 94876, 94895) || ((memberModel == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 94898, 94902)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 94905, 94972))) ? null : f_10930_94905_94972(memberModel, declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 94568, 94984);

                int
                f_10930_94747_94781(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 94747, 94781);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_94816_94854(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 94816, 94854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_10930_94905_94972(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LabeledStatementSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 94905, 94972);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 94568, 94984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 94568, 94984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ILabelSymbol GetDeclaredSymbol(SwitchLabelSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 95353, 95764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 95527, 95562);

                f_10930_95527_95561(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 95578, 95635);

                var
                memberModel = f_10930_95596_95634(this, declarationSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 95649, 95753);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 95656, 95675) || ((memberModel == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 95678, 95682)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 95685, 95752))) ? null : f_10930_95685_95752(memberModel, declarationSyntax, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 95353, 95764);

                int
                f_10930_95527_95561(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 95527, 95561);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_95596_95634(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 95596, 95634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ILabelSymbol
                f_10930_95685_95752(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SwitchLabelSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 95685, 95752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 95353, 95764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 95353, 95764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IAliasSymbol GetDeclaredSymbol(
                    UsingDirectiveSyntax declarationSyntax,
                    CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 96451, 97700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 96655, 96690);

                f_10930_96655_96689(this, declarationSyntax);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 96706, 96802) || true) && (f_10930_96710_96733(declarationSyntax) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 96706, 96802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 96775, 96787);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 96706, 96802);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 96818, 96892);

                Binder
                binder = f_10930_96834_96891(_binderFactory, f_10930_96866_96890(declarationSyntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 96906, 96964);

                var
                imports = f_10930_96920_96963(binder, basesBeingResolved: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 96978, 97062);

                var
                alias = f_10930_96990_97061(imports.UsingAliases, f_10930_97011_97039(f_10930_97011_97034(declarationSyntax)).Identifier.ValueText)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 97078, 97689) || true) && ((object)alias.Alias == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 97078, 97689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 97180, 97192);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 97078, 97689);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 97078, 97689);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 97226, 97689) || true) && (f_10930_97230_97265(f_10930_97230_97251(alias.Alias)[0]) == f_10930_97269_97302(f_10930_97269_97297(f_10930_97269_97292(declarationSyntax))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 97226, 97689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 97396, 97433);

                        return f_10930_97403_97432(alias.Alias);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 97226, 97689);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 97226, 97689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 97576, 97674);

                        return f_10930_97583_97673(f_10930_97583_97655(binder, f_10930_97607_97629(declarationSyntax), f_10930_97631_97654(declarationSyntax)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 97226, 97689);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 97078, 97689);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 96451, 97700);

                int
                f_10930_96655_96689(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 96655, 96689);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax?
                f_10930_96710_96733(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 96710, 96733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_96866_96890(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 96866, 96890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_96834_96891(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                unit)
                {
                    var return_v = this_param.GetImportsBinder(unit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 96834, 96891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10930_96920_96963(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetImports(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 96920, 96963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10930_97011_97034(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 97011, 97034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10930_97011_97039(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 97011, 97039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective
                f_10930_96990_97061(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.AliasAndUsingDirective>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 96990, 97061);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10930_97230_97251(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 97230, 97251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_97230_97265(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 97230, 97265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10930_97269_97292(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 97269, 97292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_10930_97269_97297(Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 97269, 97297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_97269_97302(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 97269, 97302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAliasSymbol?
                f_10930_97403_97432(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 97403, 97432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10930_97607_97629(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 97607, 97629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                f_10930_97631_97654(Microsoft.CodeAnalysis.CSharp.Syntax.UsingDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Alias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 97631, 97654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                f_10930_97583_97655(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                name, Microsoft.CodeAnalysis.CSharp.Syntax.NameEqualsSyntax
                alias)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol(binder, name, alias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 97583, 97655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAliasSymbol?
                f_10930_97583_97673(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 97583, 97673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 96451, 97700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 96451, 97700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IAliasSymbol GetDeclaredSymbol(ExternAliasDirectiveSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 98119, 98987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 98302, 98337);

                f_10930_98302_98336(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 98353, 98424);

                var
                binder = f_10930_98366_98423(_binderFactory, f_10930_98398_98422(declarationSyntax))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 98438, 98496);

                var
                imports = f_10930_98452_98495(binder, basesBeingResolved: null)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 98626, 98892);
                    foreach (var alias in f_10930_98648_98669_I(imports.ExternAliases))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 98626, 98892);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 98703, 98877) || true) && (f_10930_98707_98742(f_10930_98707_98728(alias.Alias)[0]) == declarationSyntax.Identifier.Span)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 98703, 98877);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 98821, 98858);

                            return f_10930_98828_98857(alias.Alias);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 98703, 98877);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 98626, 98892);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10930, 1, 267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10930, 1, 267);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 98908, 98976);

                return f_10930_98915_98975(f_10930_98915_98957(binder, declarationSyntax));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 98119, 98987);

                int
                f_10930_98302_98336(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 98302, 98336);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_98398_98422(Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 98398, 98422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10930_98366_98423(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                unit)
                {
                    var return_v = this_param.GetImportsBinder(unit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 98366, 98423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Imports
                f_10930_98452_98495(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetImports(basesBeingResolved: basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 98452, 98495);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10930_98707_98728(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 98707, 98728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_98707_98742(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 98707, 98742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAliasSymbol?
                f_10930_98828_98857(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 98828, 98857);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                f_10930_98648_98669_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.AliasAndExternAliasDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 98648, 98669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                f_10930_98915_98957(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Syntax.ExternAliasDirectiveSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol(binder, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 98915, 98957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IAliasSymbol?
                f_10930_98915_98975(Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 98915, 98975);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 98119, 98987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 98119, 98987);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<ISymbol> GetDeclaredSymbols(BaseFieldDeclarationSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 99389, 100065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 99586, 99621);

                f_10930_99586_99620(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 99637, 99679);

                var
                builder = f_10930_99651_99678()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 99695, 100002);
                    foreach (var declarator in f_10930_99722_99761_I(f_10930_99722_99761(f_10930_99722_99751(declarationSyntax))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 99695, 100002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 99795, 99872);

                        var
                        field = f_10930_99807_99860(this, declarator, cancellationToken) as ISymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 99890, 99987) || true) && (field != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 99890, 99987);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 99949, 99968);

                            f_10930_99949_99967(builder, field);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 99890, 99987);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 99695, 100002);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10930, 1, 308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10930, 1, 308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100018, 100054);

                return f_10930_100025_100053(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 99389, 100065);

                int
                f_10930_99586_99620(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 99586, 99620);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                f_10930_99651_99678()
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 99651, 99678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_10930_99722_99751(Microsoft.CodeAnalysis.CSharp.Syntax.BaseFieldDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 99722, 99751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10930_99722_99761(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 99722, 99761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10930_99807_99860(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 99807, 99860);
                    return return_v;
                }


                int
                f_10930_99949_99967(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                this_param, Microsoft.CodeAnalysis.ISymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 99949, 99967);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                f_10930_99722_99761_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 99722, 99761);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_10930_100025_100053(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 100025, 100053);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 99389, 100065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 99389, 100065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterSymbol GetMethodParameterSymbol(
                    ParameterSyntax parameter,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 100077, 101408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100241, 100273);

                f_10930_100241_100272(parameter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100289, 100345);

                var
                paramList = f_10930_100305_100321(parameter) as ParameterListSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100359, 100441) || true) && (paramList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 100359, 100441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100414, 100426);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 100359, 100441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100457, 100518);

                var
                memberDecl = f_10930_100474_100490(paramList) as MemberDeclarationSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100532, 100615) || true) && (memberDecl == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 100532, 100615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100588, 100600);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 100532, 100615);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100631, 100651);

                MethodSymbol
                method
                = default(MethodSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100667, 101020) || true) && (memberDecl is RecordDeclarationSyntax recordDecl && (DynAbs.Tracing.TraceSender.Expression_True(10930, 100671, 100760) && f_10930_100723_100747(recordDecl) == paramList))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 100667, 101020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100794, 100850);

                    method = f_10930_100803_100849(this, recordDecl);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 100667, 101020);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 100667, 101020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 100916, 101005);

                    method = f_10930_100925_101004((f_10930_100926_100974(this, memberDecl, cancellationToken) as IMethodSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 100667, 101020);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101036, 101123) || true) && ((object)method == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 101036, 101123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101096, 101108);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 101036, 101123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101139, 101397);

                return
                f_10930_101163_101230(this, f_10930_101182_101199(method), parameter, cancellationToken) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(10930, 101163, 101396) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(10930, 101252, 101296) || (((object)f_10930_101260_101288(method) == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 101299, 101303)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 101306, 101395))) ? null : f_10930_101306_101395(this, f_10930_101325_101364(f_10930_101325_101353(method)), parameter, cancellationToken)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 100077, 101408);

                int
                f_10930_100241_100272(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 100241, 100272);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_100305_100321(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 100305, 100321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_100474_100490(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 100474, 100490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10930_100723_100747(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 100723, 100747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                f_10930_100803_100849(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                node)
                {
                    var return_v = this_param.TryGetSynthesizedRecordConstructor(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 100803, 100849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10930_100926_100974(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 100926, 100974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10930_100925_101004(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 100925, 101004);
                    return (MethodSymbol?)return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10930_101182_101199(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 101182, 101199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10930_101163_101230(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetParameterSymbol(parameters, parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 101163, 101230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10930_101260_101288(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 101260, 101288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10930_101325_101353(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 101325, 101353);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10930_101325_101364(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 101325, 101364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10930_101306_101395(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetParameterSymbol(parameters, parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 101306, 101395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 100077, 101408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 100077, 101408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterSymbol GetIndexerParameterSymbol(
                    ParameterSyntax parameter,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 101420, 102288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101585, 101617);

                f_10930_101585_101616(parameter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101633, 101698);

                var
                paramList = f_10930_101649_101665(parameter) as BracketedParameterListSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101712, 101794) || true) && (paramList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 101712, 101794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101767, 101779);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 101712, 101794);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101810, 101871);

                var
                memberDecl = f_10930_101827_101843(paramList) as MemberDeclarationSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101885, 101968) || true) && (memberDecl == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 101885, 101968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101941, 101953);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 101885, 101968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 101984, 102081);

                var
                property = f_10930_101999_102080((f_10930_102000_102048(this, memberDecl, cancellationToken) as IPropertySymbol))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102095, 102184) || true) && ((object)property == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 102095, 102184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102157, 102169);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 102095, 102184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102200, 102277);

                return f_10930_102207_102276(this, f_10930_102226_102245(property), parameter, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 101420, 102288);

                int
                f_10930_101585_101616(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 101585, 101616);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_101649_101665(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 101649, 101665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_101827_101843(Microsoft.CodeAnalysis.CSharp.Syntax.BracketedParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 101827, 101843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10930_102000_102048(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 102000, 102048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                f_10930_101999_102080(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 101999, 102080);
                    return (PropertySymbol?)return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10930_102226_102245(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 102226, 102245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10930_102207_102276(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetParameterSymbol(parameters, parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 102207, 102276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 101420, 102288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 101420, 102288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterSymbol GetDelegateParameterSymbol(
                    ParameterSyntax parameter,
                    CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 102300, 103391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102466, 102498);

                f_10930_102466_102497(parameter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102514, 102570);

                var
                paramList = f_10930_102530_102546(parameter) as ParameterListSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102584, 102666) || true) && (paramList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 102584, 102666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102639, 102651);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 102584, 102666);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102682, 102745);

                var
                memberDecl = f_10930_102699_102715(paramList) as DelegateDeclarationSyntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102759, 102842) || true) && (memberDecl == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 102759, 102842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102815, 102827);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 102759, 102842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102858, 102960);

                var
                delegateType = f_10930_102877_102959((f_10930_102878_102926(this, memberDecl, cancellationToken) as INamedTypeSymbol))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 102974, 103067) || true) && ((object)delegateType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 102974, 103067);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 103040, 103052);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 102974, 103067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 103083, 103138);

                var
                delegateInvoke = f_10930_103104_103137(delegateType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 103152, 103281) || true) && ((object)delegateInvoke == null || (DynAbs.Tracing.TraceSender.Expression_False(10930, 103156, 103220) || f_10930_103190_103220(delegateInvoke)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 103152, 103281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 103254, 103266);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 103152, 103281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 103297, 103380);

                return f_10930_103304_103379(this, f_10930_103323_103348(delegateInvoke), parameter, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 102300, 103391);

                int
                f_10930_102466_102497(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 102466, 102497);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_102530_102546(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 102530, 102546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_102699_102715(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 102699, 102715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_10930_102878_102926(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DelegateDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 102878, 102926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10930_102877_102959(Microsoft.CodeAnalysis.INamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 102877, 102959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10930_103104_103137(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 103104, 103137);
                    return return_v;
                }


                bool
                f_10930_103190_103220(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.HasUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 103190, 103220);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10930_103323_103348(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 103323, 103348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10930_103304_103379(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetParameterSymbol(parameters, parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 103304, 103379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 102300, 103391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 102300, 103391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IParameterSymbol GetDeclaredSymbol(ParameterSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 103774, 104411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 103950, 103985);

                f_10930_103950_103984(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 104001, 104074);

                MemberSemanticModel
                memberModel = f_10930_104035_104073(this, declarationSyntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 104088, 104285) || true) && (memberModel != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 104088, 104285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 104195, 104270);

                    return f_10930_104202_104269(memberModel, declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 104088, 104285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 104301, 104400);

                return f_10930_104308_104399(f_10930_104308_104381(this, declarationSyntax, cancellationToken));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 103774, 104411);

                int
                f_10930_103950_103984(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax)
                {
                    this_param.CheckSyntaxNode((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 103950, 103984);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_104035_104073(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 104035, 104073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IParameterSymbol
                f_10930_104202_104269(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 104202, 104269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10930_104308_104381(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredNonLambdaParameterSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 104308, 104381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IParameterSymbol?
                f_10930_104308_104399(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 104308, 104399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 103774, 104411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 103774, 104411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterSymbol GetDeclaredNonLambdaParameterSymbol(ParameterSyntax declarationSyntax, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 104423, 104875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 104608, 104864);

                return
                f_10930_104632_104694(this, declarationSyntax, cancellationToken) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(10930, 104632, 104863) ?? f_10930_104715_104778(this, declarationSyntax, cancellationToken) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(10930, 104715, 104863) ?? f_10930_104799_104863(this, declarationSyntax, cancellationToken)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 104423, 104875);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10930_104632_104694(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetMethodParameterSymbol(parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 104632, 104694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10930_104715_104778(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetIndexerParameterSymbol(parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 104715, 104778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10930_104799_104863(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                parameter, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDelegateParameterSymbol(parameter, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 104799, 104863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 104423, 104875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 104423, 104875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ITypeParameterSymbol GetDeclaredSymbol(TypeParameterSyntax typeParameter, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 105190, 107160);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 105370, 105499) || true) && (typeParameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 105370, 105499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 105429, 105484);

                    throw f_10930_105435_105483(nameof(typeParameter));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 105370, 105499);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 105515, 105653) || true) && (!f_10930_105520_105543(this, typeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 105515, 105653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 105577, 105638);

                    throw f_10930_105583_105637("typeParameter not within tree");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 105515, 105653);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 105669, 107121) || true) && (f_10930_105673_105693(typeParameter) is TypeParameterListSyntax typeParamList)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 105669, 107121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 105768, 105803);

                    ISymbol
                    parameterizedSymbol = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 105821, 106399);

                    switch (f_10930_105829_105849(typeParamList))
                    {

                        case MemberDeclarationSyntax memberDecl:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 105821, 106399);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 105957, 106028);

                            parameterizedSymbol = f_10930_105979_106027(this, memberDecl, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceBreak(10930, 106054, 106060);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 105821, 106399);

                        case LocalFunctionStatementSyntax localDecl:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 105821, 106399);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 106152, 106222);

                            parameterizedSymbol = f_10930_106174_106221(this, localDecl, cancellationToken);
                            DynAbs.Tracing.TraceSender.TraceBreak(10930, 106248, 106254);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 105821, 106399);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 105821, 106399);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 106310, 106380);

                            throw f_10930_106316_106379(f_10930_106351_106378(f_10930_106351_106371(typeParameter)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 105821, 106399);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 106419, 107106);

                    switch (f_10930_106427_106458(parameterizedSymbol))
                    {

                        case NamedTypeSymbol typeSymbol:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 106419, 107106);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 106558, 106653);

                            return f_10930_106565_106652(f_10930_106565_106634(this, f_10930_106593_106618(typeSymbol), typeParameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 106419, 107106);

                        case MethodSymbol methodSymbol:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 106419, 107106);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 106734, 107087);

                            return f_10930_106741_107086((f_10930_106742_106813(this, f_10930_106770_106797(methodSymbol), typeParameter) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>(10930, 106742, 107067) ?? ((DynAbs.Tracing.TraceSender.Conditional_F1(10930, 106847, 106897) || (((object)f_10930_106855_106889(methodSymbol) == null
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 106933, 106937)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 106973, 107066))) ? null
                            : f_10930_106973_107066(this, f_10930_107001_107050(f_10930_107001_107035(methodSymbol)), typeParameter)))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 106419, 107106);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 105669, 107121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 107137, 107149);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 105190, 107160);

                System.ArgumentNullException
                f_10930_105435_105483(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 105435, 105483);
                    return return_v;
                }


                bool
                f_10930_105520_105543(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                node)
                {
                    var return_v = this_param.IsInTree((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 105520, 105543);
                    return return_v;
                }


                System.ArgumentException
                f_10930_105583_105637(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 105583, 105637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_105673_105693(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 105673, 105693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_105829_105849(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 105829, 105849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10930_105979_106027(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.MemberDeclarationSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 105979, 106027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_10930_106174_106221(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LocalFunctionStatementSyntax
                declarationSyntax, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDeclaredSymbol(declarationSyntax, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 106174, 106221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_106351_106371(Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 106351, 106371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_106351_106378(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 106351, 106378);
                    return return_v;
                }


                System.Exception
                f_10930_106316_106379(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 106316, 106379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10930_106427_106458(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 106427, 106458);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10930_106593_106618(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 106593, 106618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10930_106565_106634(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                parameter)
                {
                    var return_v = this_param.GetTypeParameterSymbol(parameters, parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 106565, 106634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeParameterSymbol?
                f_10930_106565_106652(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 106565, 106652);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10930_106770_106797(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 106770, 106797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10930_106742_106813(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                parameter)
                {
                    var return_v = this_param.GetTypeParameterSymbol(parameters, parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 106742, 106813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10930_106855_106889(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 106855, 106889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10930_107001_107035(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialDefinitionPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 107001, 107035);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10930_107001_107050(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 107001, 107050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10930_106973_107066(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Syntax.TypeParameterSyntax
                parameter)
                {
                    var return_v = this_param.GetTypeParameterSymbol(parameters, parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 106973, 107066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeParameterSymbol?
                f_10930_106741_107086(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 106741, 107086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 105190, 107160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 105190, 107160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeParameterSymbol GetTypeParameterSymbol(ImmutableArray<TypeParameterSymbol> parameters, TypeParameterSyntax parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 107172, 107726);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 107326, 107687);
                    foreach (var symbol in f_10930_107349_107359_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 107326, 107687);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 107393, 107672);
                            foreach (var location in f_10930_107418_107434_I(f_10930_107418_107434(symbol)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 107393, 107672);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 107476, 107653) || true) && (f_10930_107480_107499(location) == f_10930_107503_107518(this) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 107480, 107566) && parameter.Span.Contains(f_10930_107546_107565(location))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 107476, 107653);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 107616, 107630);

                                    return symbol;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 107476, 107653);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 107393, 107672);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10930, 1, 280);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10930, 1, 280);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 107326, 107687);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10930, 1, 362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10930, 1, 362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 107703, 107715);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 107172, 107726);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10930_107418_107434(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 107418, 107434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10930_107480_107499(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 107480, 107499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_107503_107518(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 107503, 107518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_107546_107565(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceSpan;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 107546, 107565);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10930_107418_107434_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 107418, 107434);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10930_107349_107359_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 107349, 107359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 107172, 107726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 107172, 107726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ControlFlowAnalysis AnalyzeControlFlow(StatementSyntax firstStatement, StatementSyntax lastStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 107738, 108120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 107880, 107934);

                f_10930_107880_107933(this, firstStatement, lastStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 107948, 108015);

                var
                context = f_10930_107962_108014(this, firstStatement, lastStatement)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108029, 108081);

                var
                result = f_10930_108042_108080(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108095, 108109);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 107738, 108120);

                int
                f_10930_107880_107933(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                firstStatement, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                lastStatement)
                {
                    this_param.ValidateStatementRange(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 107880, 107933);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
                f_10930_107962_108014(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                firstStatement, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                lastStatement)
                {
                    var return_v = this_param.RegionAnalysisContext(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 107962, 108014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpControlFlowAnalysis
                f_10930_108042_108080(Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpControlFlowAnalysis(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 108042, 108080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 107738, 108120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 107738, 108120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ValidateStatementRange(StatementSyntax firstStatement, StatementSyntax lastStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 108132, 109116);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108255, 108386) || true) && (firstStatement == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 108255, 108386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108315, 108371);

                    throw f_10930_108321_108370(nameof(firstStatement));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 108255, 108386);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108402, 108531) || true) && (lastStatement == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 108402, 108531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108461, 108516);

                    throw f_10930_108467_108515(nameof(lastStatement));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 108402, 108531);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108547, 108683) || true) && (!f_10930_108552_108576(this, firstStatement))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 108547, 108683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108610, 108668);

                    throw f_10930_108616_108667("statements not within tree");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 108547, 108683);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108699, 108907) || true) && (f_10930_108703_108724(firstStatement) == null || (DynAbs.Tracing.TraceSender.Expression_False(10930, 108703, 108781) || f_10930_108736_108757(firstStatement) != f_10930_108761_108781(lastStatement)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 108699, 108907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108815, 108892);

                    throw f_10930_108821_108891("statements not within the same statement list");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 108699, 108907);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 108923, 109105) || true) && (f_10930_108927_108951(firstStatement) > f_10930_108954_108977(lastStatement))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 108923, 109105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109011, 109090);

                    throw f_10930_109017_109089("first statement does not precede last statement");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 108923, 109105);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 108132, 109116);

                System.ArgumentNullException
                f_10930_108321_108370(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 108321, 108370);
                    return return_v;
                }


                System.ArgumentNullException
                f_10930_108467_108515(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 108467, 108515);
                    return return_v;
                }


                bool
                f_10930_108552_108576(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node)
                {
                    var return_v = this_param.IsInTree((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 108552, 108576);
                    return return_v;
                }


                System.ArgumentException
                f_10930_108616_108667(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 108616, 108667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_108703_108724(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 108703, 108724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_108736_108757(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 108736, 108757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_108761_108781(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 108761, 108781);
                    return return_v;
                }


                System.ArgumentException
                f_10930_108821_108891(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 108821, 108891);
                    return return_v;
                }


                int
                f_10930_108927_108951(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 108927, 108951);
                    return return_v;
                }


                int
                f_10930_108954_108977(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 108954, 108977);
                    return return_v;
                }


                System.ArgumentException
                f_10930_109017_109089(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 109017, 109089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 108132, 109116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 108132, 109116);
            }
        }

        public override DataFlowAnalysis AnalyzeDataFlow(ExpressionSyntax expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 109128, 109667);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109230, 109353) || true) && (expression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 109230, 109353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109286, 109338);

                    throw f_10930_109292_109337(nameof(expression));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 109230, 109353);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109369, 109501) || true) && (!f_10930_109374_109394(this, expression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 109369, 109501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109428, 109486);

                    throw f_10930_109434_109485("expression not within tree");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 109369, 109501);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109517, 109565);

                var
                context = f_10930_109531_109564(this, expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109579, 109628);

                var
                result = f_10930_109592_109627(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109642, 109656);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 109128, 109667);

                System.ArgumentNullException
                f_10930_109292_109337(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 109292, 109337);
                    return return_v;
                }


                bool
                f_10930_109374_109394(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = this_param.IsInTree((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 109374, 109394);
                    return return_v;
                }


                System.ArgumentException
                f_10930_109434_109485(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 109434, 109485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
                f_10930_109531_109564(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                expression)
                {
                    var return_v = this_param.RegionAnalysisContext(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 109531, 109564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                f_10930_109592_109627(Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 109592, 109627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 109128, 109667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 109128, 109667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DataFlowAnalysis AnalyzeDataFlow(StatementSyntax firstStatement, StatementSyntax lastStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 109679, 110052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109815, 109869);

                f_10930_109815_109868(this, firstStatement, lastStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109883, 109950);

                var
                context = f_10930_109897_109949(this, firstStatement, lastStatement)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 109964, 110013);

                var
                result = f_10930_109977_110012(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 110027, 110041);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 109679, 110052);

                int
                f_10930_109815_109868(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                firstStatement, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                lastStatement)
                {
                    this_param.ValidateStatementRange(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 109815, 109868);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
                f_10930_109897_109949(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                firstStatement, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                lastStatement)
                {
                    var return_v = this_param.RegionAnalysisContext(firstStatement, lastStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 109897, 109949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis
                f_10930_109977_110012(Microsoft.CodeAnalysis.CSharp.RegionAnalysisContext
                context)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpDataFlowAnalysis(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 109977, 110012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 109679, 110052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 109679, 110052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundNode GetBoundRoot(MemberSemanticModel memberModel, out Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10930, 110064, 110271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 110178, 110212);

                member = f_10930_110187_110211(memberModel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 110226, 110260);

                return f_10930_110233_110259(memberModel);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10930, 110064, 110271);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_110187_110211(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 110187, 110211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10930_110233_110259(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param)
                {
                    var return_v = this_param.GetBoundRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 110233, 110259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 110064, 110271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 110064, 110271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamespaceOrTypeSymbol GetDeclaredTypeMemberContainer(CSharpSyntaxNode memberDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 110283, 112035);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 110404, 111352) || true) && (f_10930_110408_110439(f_10930_110408_110432(memberDeclaration)) == SyntaxKind.CompilationUnit)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 110404, 111352);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 110544, 110713) || true) && (f_10930_110548_110572(memberDeclaration) == SyntaxKind.NamespaceDeclaration)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 110544, 110713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 110649, 110694);

                        return f_10930_110656_110693(f_10930_110656_110677(_compilation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 110544, 110713);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 110802, 110957) || true) && (f_10930_110806_110834(f_10930_110806_110829(f_10930_110806_110821(this))) != SourceCodeKind.Regular)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 110802, 110957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 110902, 110938);

                        return f_10930_110909_110937(f_10930_110909_110925(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 110802, 110957);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111049, 111214) || true) && (f_10930_111053_111108(f_10930_111083_111107(memberDeclaration)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 111049, 111214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111150, 111195);

                        return f_10930_111157_111194(f_10930_111157_111178(_compilation));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 111049, 111214);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111279, 111337);

                    return f_10930_111286_111336(f_10930_111286_111323(f_10930_111286_111307(_compilation)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 110404, 111352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111368, 111437);

                var
                container = f_10930_111384_111436(this, f_10930_111411_111435(memberDeclaration))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111451, 111491);

                f_10930_111451_111490((object)container != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111541, 111633) || true) && (f_10930_111545_111567_M(!container.IsNamespace))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 111541, 111633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111601, 111618);

                    return container;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 111541, 111633);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111724, 111912) || true) && (f_10930_111728_111752(memberDeclaration) == SyntaxKind.NamespaceDeclaration || (DynAbs.Tracing.TraceSender.Expression_False(10930, 111728, 111846) || f_10930_111791_111846(f_10930_111821_111845(memberDeclaration))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 111724, 111912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111880, 111897);

                    return container;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 111724, 111912);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 111975, 112024);

                return f_10930_111982_112023(((NamespaceSymbol)container));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 110283, 112035);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_110408_110432(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 110408, 110432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_110408_110439(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 110408, 110439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_110548_110572(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 110548, 110572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10930_110656_110677(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 110656, 110677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10930_110656_110693(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 110656, 110693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_110806_110821(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 110806, 110821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10930_110806_110829(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 110806, 110829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10930_110806_110834(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 110806, 110834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_110909_110925(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 110909, 110925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10930_110909_110937(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 110909, 110937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_111083_111107(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 111083, 111107);
                    return return_v;
                }


                bool
                f_10930_111053_111108(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsTypeDeclaration(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 111053, 111108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10930_111157_111178(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 111157, 111178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10930_111157_111194(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 111157, 111194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10930_111286_111307(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 111286, 111307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10930_111286_111323(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 111286, 111323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_111286_111336(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ImplicitType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 111286, 111336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_111411_111435(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 111411, 111435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10930_111384_111436(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declarationSyntax)
                {
                    var return_v = this_param.GetDeclaredNamespaceOrType(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 111384, 111436);
                    return return_v;
                }


                int
                f_10930_111451_111490(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 111451, 111490);
                    return 0;
                }


                bool
                f_10930_111545_111567_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 111545, 111567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_111728_111752(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 111728, 111752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10930_111821_111845(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 111821, 111845);
                    return return_v;
                }


                bool
                f_10930_111791_111846(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.IsTypeDeclaration(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 111791, 111846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10930_111982_112023(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ImplicitType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 111982, 112023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 110283, 112035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 110283, 112035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Symbol GetDeclaredMemberSymbol(CSharpSyntaxNode declarationSyntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 112047, 112422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 112146, 112181);

                f_10930_112146_112180(this, declarationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 112197, 112263);

                var
                container = f_10930_112213_112262(this, declarationSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 112277, 112326);

                var
                name = f_10930_112288_112325(this, declarationSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 112340, 112411);

                return f_10930_112347_112410(this, container, f_10930_112381_112403(declarationSyntax), name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 112047, 112422);

                int
                f_10930_112146_112180(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    this_param.CheckSyntaxNode(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 112146, 112180);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10930_112213_112262(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                memberDeclaration)
                {
                    var return_v = this_param.GetDeclaredTypeMemberContainer(memberDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 112213, 112262);
                    return return_v;
                }


                string
                f_10930_112288_112325(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                declaration)
                {
                    var return_v = this_param.GetDeclarationName(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 112288, 112325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10930_112381_112403(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 112381, 112403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_112347_112410(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                container, Microsoft.CodeAnalysis.Text.TextSpan
                declarationSpan, string
                name)
                {
                    var return_v = this_param.GetDeclaredMember(container, declarationSpan, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 112347, 112410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 112047, 112422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 112047, 112422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AwaitExpressionInfo GetAwaitExpressionInfo(AwaitExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 112434, 112726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 112545, 112600);

                MemberSemanticModel
                memberModel = f_10930_112579_112599(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 112614, 112715);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 112621, 112640) || ((memberModel == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 112643, 112671)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 112674, 112714))) ? default(AwaitExpressionInfo) : f_10930_112674_112714(memberModel, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 112434, 112726);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_112579_112599(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 112579, 112599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AwaitExpressionInfo
                f_10930_112674_112714(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AwaitExpressionSyntax
                node)
                {
                    var return_v = this_param.GetAwaitExpressionInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 112674, 112714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 112434, 112726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 112434, 112726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ForEachStatementInfo GetForEachStatementInfo(ForEachStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 112738, 113035);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 112852, 112907);

                MemberSemanticModel
                memberModel = f_10930_112886_112906(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 112921, 113024);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 112928, 112947) || ((memberModel == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 112950, 112979)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 112982, 113023))) ? default(ForEachStatementInfo) : f_10930_112982_113023(memberModel, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 112738, 113035);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_112886_112906(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 112886, 112906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachStatementInfo
                f_10930_112982_113023(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetForEachStatementInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 112982, 113023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 112738, 113035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 112738, 113035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ForEachStatementInfo GetForEachStatementInfo(CommonForEachStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 113047, 113350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 113167, 113222);

                MemberSemanticModel
                memberModel = f_10930_113201_113221(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 113236, 113339);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10930, 113243, 113262) || ((memberModel == null && DynAbs.Tracing.TraceSender.Conditional_F2(10930, 113265, 113294)) || DynAbs.Tracing.TraceSender.Conditional_F3(10930, 113297, 113338))) ? default(ForEachStatementInfo) : f_10930_113297_113338(memberModel, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 113047, 113350);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_113201_113221(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 113201, 113221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ForEachStatementInfo
                f_10930_113297_113338(Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.CommonForEachStatementSyntax
                node)
                {
                    var return_v = this_param.GetForEachStatementInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 113297, 113338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 113047, 113350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 113047, 113350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DeconstructionInfo GetDeconstructionInfo(AssignmentExpressionSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 113362, 113615);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 113476, 113531);

                MemberSemanticModel
                memberModel = f_10930_113510_113530(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 113545, 113604);

                return f_10930_113552_113592_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(memberModel, 10930, 113552, 113592)?.GetDeconstructionInfo(node)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.DeconstructionInfo?>(10930, 113552, 113603) ?? default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 113362, 113615);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_113510_113530(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 113510, 113530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeconstructionInfo?
                f_10930_113552_113592_I(Microsoft.CodeAnalysis.CSharp.DeconstructionInfo?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 113552, 113592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 113362, 113615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 113362, 113615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override DeconstructionInfo GetDeconstructionInfo(ForEachVariableStatementSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 113627, 113884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 113745, 113800);

                MemberSemanticModel
                memberModel = f_10930_113779_113799(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 113814, 113873);

                return f_10930_113821_113861_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(memberModel, 10930, 113821, 113861)?.GetDeconstructionInfo(node)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.DeconstructionInfo?>(10930, 113821, 113872) ?? default);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 113627, 113884);

                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_113779_113799(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ForEachVariableStatementSyntax
                node)
                {
                    var return_v = this_param.GetMemberModel((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 113779, 113799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeconstructionInfo?
                f_10930_113821_113861_I(Microsoft.CodeAnalysis.CSharp.DeconstructionInfo?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 113821, 113861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 113627, 113884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 113627, 113884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Symbol RemapSymbolIfNecessaryCore(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 113896, 114759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 113987, 114098);

                f_10930_113987_114097(symbol is LocalSymbol or ParameterSymbol or MethodSymbol { MethodKind: MethodKind.LambdaMethod });

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 114114, 114214) || true) && (symbol.Locations.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 114114, 114214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 114185, 114199);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 114114, 114214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 114230, 114265);

                var
                location = f_10930_114245_114261(symbol)[0]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 114426, 114531) || true) && (f_10930_114430_114449(location) != f_10930_114453_114468(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 114426, 114531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 114502, 114516);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 114426, 114531);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 114547, 114612);

                var
                position = f_10930_114562_114611(this, location.SourceSpan.Start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 114626, 114669);

                var
                memberModel = f_10930_114644_114668(this, position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 114683, 114748);

                return f_10930_114690_114737_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(memberModel, 10930, 114690, 114737)?.RemapSymbolIfNecessaryCore(symbol)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol?>(10930, 114690, 114747) ?? symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 113896, 114759);

                int
                f_10930_113987_114097(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 113987, 114097);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10930_114245_114261(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 114245, 114261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10930_114430_114449(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 114430, 114449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10930_114453_114468(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 114453, 114468);
                    return return_v;
                }


                int
                f_10930_114562_114611(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.CheckAndAdjustPosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 114562, 114611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MemberSemanticModel
                f_10930_114644_114668(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.GetMemberModel(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 114644, 114668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10930_114690_114737_I(Microsoft.CodeAnalysis.CSharp.Symbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 114690, 114737);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 113896, 114759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 113896, 114759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Func<SyntaxNode, bool> GetSyntaxNodesToAnalyzeFilter(SyntaxNode declaredNode, ISymbol declaredSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10930, 114771, 119743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 114915, 119704);

                switch (declaredNode)
                {

                    case CompilationUnitSyntax unit when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 115001, 115168) || true) && (f_10930_115006_115113(f_10930_115062_115073(), unit, fallbackToMainEntryPoint: false) is SynthesizedSimpleProgramEntryPointSymbol entryPoint) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 115001, 115168) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 114915, 119704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 115191, 116352);

                        switch (f_10930_115199_115218(declaredSymbol))
                        {

                            case SymbolKind.Namespace:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 115191, 116352);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 115324, 115391);

                                f_10930_115324_115390(f_10930_115337_115389(((INamespaceSymbol)declaredSymbol)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 115520, 115602);

                                return (node) => node.Kind() != SyntaxKind.GlobalStatement || node.Parent != unit;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 115191, 116352);

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 115191, 116352);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 115683, 115754);

                                f_10930_115683_115753((object)f_10930_115704_115730(declaredSymbol) == (object)entryPoint);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 115864, 115946);

                                return (node) => node.Parent != unit || node.Kind() == SyntaxKind.GlobalStatement;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 115191, 116352);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 115191, 116352);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 116030, 116118);

                                f_10930_116030_116117((object)f_10930_116051_116077(declaredSymbol) == (object)f_10930_116089_116116(entryPoint));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 116148, 116171);

                                return (node) => false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 115191, 116352);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 115191, 116352);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 116237, 116293);

                                f_10930_116237_116292(f_10930_116272_116291(declaredSymbol));
                                DynAbs.Tracing.TraceSender.TraceBreak(10930, 116323, 116329);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 115191, 116352);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 116374, 116380);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 114915, 119704);

                    case RecordDeclarationSyntax recordDeclaration when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 116447, 116542) || true) && (f_10930_116452_116505(this, recordDeclaration) is SynthesizedRecordConstructor ctor) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 116447, 116542) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 114915, 119704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 116565, 118681);

                        switch (f_10930_116573_116592(declaredSymbol))
                        {

                            case SymbolKind.Method:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 116565, 118681);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 116695, 116760);

                                f_10930_116695_116759((object)f_10930_116716_116742(declaredSymbol) == (object)ctor);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 116790, 117981);

                                return (node) =>
                                                                   {
                                       // Accept only nodes that either match, or above/below of a 'parameter list'/'base arguments list'.
                                       if (node.Parent == recordDeclaration)
                                                                       {
                                                                           return node == recordDeclaration.ParameterList || node == recordDeclaration.BaseList;
                                                                       }
                                                                       else if (node.Parent is BaseListSyntax baseList)
                                                                       {
                                                                           return node == recordDeclaration.PrimaryConstructorBaseType;
                                                                       }
                                                                       else if (node.Parent is PrimaryConstructorBaseTypeSyntax baseType && baseType == recordDeclaration.PrimaryConstructorBaseType)
                                                                       {
                                                                           return node == baseType.ArgumentList;
                                                                       }

                                                                       return true;
                                                                   };
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 116565, 118681);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 116565, 118681);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 118065, 118147);

                                f_10930_118065_118146((object)f_10930_118086_118112(declaredSymbol) == (object)f_10930_118124_118145(ctor));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 118282, 118500);

                                return (node) => node != recordDeclaration.ParameterList &&
                                                                             !(node.Kind() == SyntaxKind.ArgumentList && node == recordDeclaration.PrimaryConstructorBaseType?.ArgumentList);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 116565, 118681);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 116565, 118681);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 118566, 118622);

                                f_10930_118566_118621(f_10930_118601_118620(declaredSymbol));
                                DynAbs.Tracing.TraceSender.TraceBreak(10930, 118652, 118658);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 116565, 118681);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 118703, 118709);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 114915, 119704);

                    case PrimaryConstructorBaseTypeSyntax { Parent: BaseListSyntax { Parent: RecordDeclarationSyntax recordDeclaration } } baseType
                                        when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 118882, 119041) || true) && (f_10930_118887_118931(recordDeclaration) == declaredNode && (DynAbs.Tracing.TraceSender.Expression_True(10930, 118887, 119041) && f_10930_118951_119004(this, recordDeclaration) is SynthesizedRecordConstructor ctor)) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 118882, 119041) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 114915, 119704);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 119064, 119303) || true) && ((object)f_10930_119076_119102(declaredSymbol) == (object)ctor)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 119064, 119303);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 119241, 119280);

                            return (node) => node != baseType.Type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 119064, 119303);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10930, 119325, 119331);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 114915, 119704);

                    case ParameterSyntax param when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 119378, 119545) || true) && (f_10930_119383_119402(declaredSymbol) == SymbolKind.Property && (DynAbs.Tracing.TraceSender.Expression_True(10930, 119383, 119494) && f_10930_119429_119449_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10930_119429_119441(param), 10930, 119429, 119449)?.Parent) is RecordDeclarationSyntax recordDeclaration) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 119383, 119545) && f_10930_119498_119529(recordDeclaration) == f_10930_119533_119545(param))) && (DynAbs.Tracing.TraceSender.Expression_True(10930, 119378, 119545) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10930, 114915, 119704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 119568, 119644);

                        f_10930_119568_119643(f_10930_119581_119607(declaredSymbol) is SynthesizedRecordPropertySymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 119666, 119689);

                        return (node) => false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10930, 114915, 119704);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 119720, 119732);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10930, 114771, 119743);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10930_115062_115073()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 115062, 115073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol?
                f_10930_115006_115113(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                compilationUnit, bool
                fallbackToMainEntryPoint)
                {
                    var return_v = SimpleProgramNamedTypeSymbol.GetSimpleProgramEntryPoint(compilation, compilationUnit, fallbackToMainEntryPoint: fallbackToMainEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 115006, 115113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10930_115199_115218(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 115199, 115218);
                    return return_v;
                }


                bool
                f_10930_115337_115389(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 115337, 115389);
                    return return_v;
                }


                int
                f_10930_115324_115390(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 115324, 115390);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10930_115704_115730(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 115704, 115730);
                    return return_v;
                }


                int
                f_10930_115683_115753(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 115683, 115753);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10930_116051_116077(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 116051, 116077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_116089_116116(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSimpleProgramEntryPointSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 116089, 116116);
                    return return_v;
                }


                int
                f_10930_116030_116117(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 116030, 116117);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10930_116272_116291(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 116272, 116291);
                    return return_v;
                }


                System.Exception
                f_10930_116237_116292(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 116237, 116292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                f_10930_116452_116505(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                node)
                {
                    var return_v = this_param.TryGetSynthesizedRecordConstructor(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 116452, 116505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10930_116573_116592(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 116573, 116592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10930_116716_116742(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 116716, 116742);
                    return return_v;
                }


                int
                f_10930_116695_116759(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 116695, 116759);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10930_118086_118112(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 118086, 118112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10930_118124_118145(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 118124, 118145);
                    return return_v;
                }


                int
                f_10930_118065_118146(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 118065, 118146);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10930_118601_118620(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 118601, 118620);
                    return return_v;
                }


                System.Exception
                f_10930_118566_118621(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 118566, 118621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax?
                f_10930_118887_118931(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.PrimaryConstructorBaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 118887, 118931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                f_10930_118951_119004(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                node)
                {
                    var return_v = this_param.TryGetSynthesizedRecordConstructor(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 118951, 119004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10930_119076_119102(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 119076, 119102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10930_119383_119402(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 119383, 119402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_119429_119441(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 119429, 119441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10930_119429_119449_M(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 119429, 119449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10930_119498_119529(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 119498, 119529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10930_119533_119545(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 119533, 119545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10930_119581_119607(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 119581, 119607);
                    return return_v;
                }


                int
                f_10930_119568_119643(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 119568, 119643);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10930, 114771, 119743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 114771, 119743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxTreeSemanticModel()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10930, 769, 119750);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10930, 1701, 1752);
            s_isMemberDeclarationFunction = IsMemberDeclaration; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10930, 769, 119750);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10930, 769, 119750);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10930, 769, 119750);

        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10930_2073_2089(Microsoft.CodeAnalysis.CSharp.SyntaxTreeSemanticModel
        this_param)
        {
            var return_v = this_param.Compilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 2073, 2089);
            return return_v;
        }


        string
        f_10930_2214_2254()
        {
            var return_v = CSharpResources.TreeNotPartOfCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 2214, 2254);
            return return_v;
        }


        System.ArgumentOutOfRangeException
        f_10930_2162_2255(string
        paramName, string
        message)
        {
            var return_v = new System.ArgumentOutOfRangeException(paramName, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 2162, 2255);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxTree
        f_10930_2333_2343()
        {
            var return_v = SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10930, 2333, 2343);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BinderFactory
        f_10930_2304_2365(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree, bool
        ignoreAccessibility)
        {
            var return_v = this_param.GetBinderFactory(syntaxTree, ignoreAccessibility);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 2304, 2365);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BinderFactory
        f_10930_2658_2705(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        syntaxTree)
        {
            var return_v = this_param.GetBinderFactory(syntaxTree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10930, 2658, 2705);
            return return_v;
        }

    }
}
