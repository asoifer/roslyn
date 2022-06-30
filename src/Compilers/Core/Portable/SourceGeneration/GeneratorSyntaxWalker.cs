// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CodeAnalysis
{
    internal sealed class GeneratorSyntaxWalker : SyntaxWalker
    {
        private readonly ISyntaxContextReceiver _syntaxReceiver;

        private SemanticModel? _semanticModel;

        internal GeneratorSyntaxWalker(ISyntaxContextReceiver syntaxReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(554, 471, 609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 393, 408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 444, 458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 565, 598);

                _syntaxReceiver = syntaxReceiver;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(554, 471, 609);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(554, 471, 609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(554, 471, 609);
            }
        }

        public void VisitWithModel(SemanticModel model, SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(554, 621, 971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 710, 859);

                f_554_710_858(_semanticModel is null
                && (DynAbs.Tracing.TraceSender.Expression_True(554, 723, 792) && model is not null
                ) && (DynAbs.Tracing.TraceSender.Expression_True(554, 723, 857) && f_554_822_838(model) == f_554_842_857(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 875, 898);

                _semanticModel = model;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 912, 924);

                f_554_912_923(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 938, 960);

                _semanticModel = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(554, 621, 971);

                Microsoft.CodeAnalysis.SyntaxTree
                f_554_822_838(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(554, 822, 838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_554_842_857(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(554, 842, 857);
                    return return_v;
                }


                int
                f_554_710_858(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(554, 710, 858);
                    return 0;
                }


                int
                f_554_912_923(Microsoft.CodeAnalysis.GeneratorSyntaxWalker
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(554, 912, 923);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(554, 621, 971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(554, 621, 971);
            }
        }

        public override void Visit(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(554, 983, 1278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 1051, 1138);

                f_554_1051_1137(_semanticModel is object && (DynAbs.Tracing.TraceSender.Expression_True(554, 1064, 1136) && f_554_1092_1117(_semanticModel) == f_554_1121_1136(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 1152, 1236);

                f_554_1152_1235(_syntaxReceiver, f_554_1186_1234(node, _semanticModel));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(554, 1250, 1267);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 554, 1250, 1266);
                DynAbs.Tracing.TraceSender.TraceExitMethod(554, 983, 1278);

                Microsoft.CodeAnalysis.SyntaxTree
                f_554_1092_1117(Microsoft.CodeAnalysis.SemanticModel
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(554, 1092, 1117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_554_1121_1136(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(554, 1121, 1136);
                    return return_v;
                }


                int
                f_554_1051_1137(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(554, 1051, 1137);
                    return 0;
                }


                Microsoft.CodeAnalysis.GeneratorSyntaxContext
                f_554_1186_1234(Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.SemanticModel
                semanticModel)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorSyntaxContext(node, semanticModel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(554, 1186, 1234);
                    return return_v;
                }


                int
                f_554_1152_1235(Microsoft.CodeAnalysis.ISyntaxContextReceiver
                this_param, Microsoft.CodeAnalysis.GeneratorSyntaxContext
                context)
                {
                    this_param.OnVisitSyntaxNode(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(554, 1152, 1235);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(554, 983, 1278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(554, 983, 1278);
            }
        }

        static GeneratorSyntaxWalker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(554, 278, 1285);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(554, 278, 1285);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(554, 278, 1285);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(554, 278, 1285);
    }
}
