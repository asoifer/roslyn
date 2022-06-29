// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using System.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{

    internal readonly struct AnalysisContextInfo
    {

        private readonly Compilation? _compilation;

        private readonly IOperation? _operation;

        private readonly ISymbol? _symbol;

        private readonly SourceOrAdditionalFile? _file;

        private readonly SyntaxNode? _node;

        public AnalysisContextInfo(Compilation compilation) : this(compilation: f_207_896_920_C(compilation), operation: null, symbol: null, file: null, node: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(207, 824, 998);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(207, 824, 998);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 824, 998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 824, 998);
            }
        }

        public AnalysisContextInfo(SemanticModel model) : this(f_207_1078_1095_C(f_207_1078_1095(model)), f_207_1097_1141(f_207_1124_1140(model)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(207, 1010, 1164);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(207, 1010, 1164);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 1010, 1164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 1010, 1164);
            }
        }

        public AnalysisContextInfo(Compilation compilation, ISymbol symbol) : this(compilation: f_207_1264_1288_C(compilation), operation: null, symbol: symbol, file: null, node: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(207, 1176, 1368);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(207, 1176, 1368);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 1176, 1368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 1176, 1368);
            }
        }

        public AnalysisContextInfo(Compilation compilation, SourceOrAdditionalFile file) : this(compilation: f_207_1481_1505_C(compilation), operation: null, symbol: null, file: file, node: null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(207, 1380, 1583);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(207, 1380, 1583);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 1380, 1583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 1380, 1583);
            }
        }

        public AnalysisContextInfo(Compilation compilation, SyntaxNode node) : this(compilation: f_207_1684_1708_C(compilation), operation: null, symbol: null, file: f_207_1747_1790(f_207_1774_1789(node)), node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(207, 1595, 1819);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(207, 1595, 1819);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 1595, 1819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 1595, 1819);
            }
        }

        public AnalysisContextInfo(Compilation compilation, IOperation operation) : this(compilation: f_207_1925_1949_C(compilation), operation: operation, symbol: null, file: f_207_1993_2048(f_207_2020_2047(f_207_2020_2036(operation))), node: f_207_2056_2072(operation))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(207, 1831, 2095);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(207, 1831, 2095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 1831, 2095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 1831, 2095);
            }
        }

        public AnalysisContextInfo(Compilation compilation, ISymbol symbol, SyntaxNode node) : this(compilation: f_207_2212_2236_C(compilation), operation: null, symbol: symbol, file: f_207_2277_2320(f_207_2304_2319(node)), node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(207, 2107, 2349);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(207, 2107, 2349);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 2107, 2349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 2107, 2349);
            }
        }

        private AnalysisContextInfo(
                    Compilation? compilation,
                    IOperation? operation,
                    ISymbol? symbol,
                    SourceOrAdditionalFile? file,
                    SyntaxNode? node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(207, 2361, 2898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 2593, 2648);

                f_207_2593_2647(node == null || (DynAbs.Tracing.TraceSender.Expression_False(207, 2606, 2646) || f_207_2622_2638_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(file, 207, 2622, 2638)?.SourceTree) != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 2662, 2722);

                f_207_2662_2721(operation == null || (DynAbs.Tracing.TraceSender.Expression_False(207, 2675, 2720) || f_207_2696_2712_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(file, 207, 2696, 2712)?.SourceTree) != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 2738, 2765);

                _compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 2779, 2802);

                _operation = operation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 2816, 2833);

                _symbol = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 2847, 2860);

                _file = file;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 2874, 2887);

                _node = node;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(207, 2361, 2898);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 2361, 2898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 2361, 2898);
            }
        }

        public string GetContext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(207, 2910, 4972);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 2961, 2990);

                var
                sb = f_207_2970_2989()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3006, 3162) || true) && (f_207_3010_3036_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_compilation, 207, 3010, 3036)?.AssemblyName) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 3006, 3162);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3078, 3147);

                    f_207_3078_3146(sb, $"{nameof(Compilation)}: {f_207_3118_3143(_compilation)}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(207, 3006, 3162);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3178, 3307) || true) && (_operation != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 3178, 3307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3234, 3292);

                    f_207_3234_3291(sb, $"{nameof(IOperation)}: {f_207_3273_3288(_operation)}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(207, 3178, 3307);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3323, 3466) || true) && (f_207_3327_3340_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_symbol, 207, 3327, 3340)?.Name) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 3323, 3466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3382, 3451);

                    f_207_3382_3450(sb, $"{nameof(ISymbol)}: {f_207_3418_3430(_symbol)} ({f_207_3434_3446(_symbol)})");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(207, 3323, 3466);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3482, 3955) || true) && (_file.HasValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 3482, 3955);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3534, 3940) || true) && (_file.Value.SourceTree != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 3534, 3940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3610, 3684);

                        f_207_3610_3683(sb, $"{nameof(SyntaxTree)}: {f_207_3649_3680(_file.Value.SourceTree)}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(207, 3534, 3940);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 3534, 3940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3766, 3821);

                        f_207_3766_3820(_file.Value.AdditionalFile != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3843, 3921);

                        f_207_3843_3920(sb, $"{nameof(AdditionalText)}: {f_207_3886_3917(_file.Value.AdditionalFile)}");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(207, 3534, 3940);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(207, 3482, 3955);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 3971, 4924) || true) && (_node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 3971, 4924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4022, 4057);

                    f_207_4022_4056(_file.HasValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4075, 4126);

                    f_207_4075_4125(_file.Value.SourceTree != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4146, 4190);

                    var
                    text = f_207_4157_4189(_file.Value.SourceTree)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4319, 4382);

                    Text.LinePositionSpan?
                    lineSpan = (Text.LinePositionSpan?)null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4400, 4618) || true) && (text != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 4400, 4618);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4458, 4480);

                        var
                        temp = f_207_4469_4479(text)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4502, 4599) || true) && (temp != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 4502, 4599);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4545, 4599);

                            lineSpan = f_207_4556_4598(f_207_4556_4566(text), f_207_4587_4597(_node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(207, 4502, 4599);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(207, 4400, 4618);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4736, 4909);

                    f_207_4736_4908(
                                    // can't use Kind since that is language specific. instead will output typename.
                                    sb, $"{nameof(SyntaxNode)}: {GetFlattenedNodeText(_node)} [{f_207_4806_4826(f_207_4806_4821(_node))}]@{f_207_4830_4840(_node)} {((DynAbs.Tracing.TraceSender.Conditional_F1(207, 4844, 4861) || ((lineSpan.HasValue && DynAbs.Tracing.TraceSender.Conditional_F2(207, 4864, 4889)) || DynAbs.Tracing.TraceSender.Conditional_F3(207, 4892, 4904))) ? lineSpan.Value.ToString() : string.Empty)}");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(207, 3971, 4924);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 4940, 4961);

                return f_207_4947_4960(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(207, 2910, 4972);

                System.Text.StringBuilder
                f_207_2970_2989()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 2970, 2989);
                    return return_v;
                }


                string?
                f_207_3010_3036_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 3010, 3036);
                    return return_v;
                }


                string
                f_207_3118_3143(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.AssemblyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 3118, 3143);
                    return return_v;
                }


                System.Text.StringBuilder
                f_207_3078_3146(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 3078, 3146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OperationKind
                f_207_3273_3288(Microsoft.CodeAnalysis.IOperation
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 3273, 3288);
                    return return_v;
                }


                System.Text.StringBuilder
                f_207_3234_3291(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 3234, 3291);
                    return return_v;
                }


                string?
                f_207_3327_3340_M(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 3327, 3340);
                    return return_v;
                }


                string
                f_207_3418_3430(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 3418, 3430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_207_3434_3446(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 3434, 3446);
                    return return_v;
                }


                System.Text.StringBuilder
                f_207_3382_3450(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 3382, 3450);
                    return return_v;
                }


                string
                f_207_3649_3680(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 3649, 3680);
                    return return_v;
                }


                System.Text.StringBuilder
                f_207_3610_3683(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 3610, 3683);
                    return return_v;
                }


                int
                f_207_3766_3820(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 3766, 3820);
                    return 0;
                }


                string
                f_207_3886_3917(Microsoft.CodeAnalysis.AdditionalText
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 3886, 3917);
                    return return_v;
                }


                System.Text.StringBuilder
                f_207_3843_3920(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 3843, 3920);
                    return return_v;
                }


                int
                f_207_4022_4056(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 4022, 4056);
                    return 0;
                }


                int
                f_207_4075_4125(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 4075, 4125);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_207_4157_4189(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 4157, 4189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_207_4469_4479(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 4469, 4479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_207_4556_4566(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 4556, 4566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_207_4587_4597(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 4587, 4597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePositionSpan
                f_207_4556_4598(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetLinePositionSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 4556, 4598);
                    return return_v;
                }


                System.Type
                f_207_4806_4821(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 4806, 4821);
                    return return_v;
                }


                string
                f_207_4806_4826(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 4806, 4826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_207_4830_4840(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 4830, 4840);
                    return return_v;
                }


                System.Text.StringBuilder
                f_207_4736_4908(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.AppendLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 4736, 4908);
                    return return_v;
                }


                string
                f_207_4947_4960(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 4947, 4960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 2910, 4972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 2910, 4972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetFlattenedNodeText(SyntaxNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(207, 4984, 5709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5061, 5083);

                const int
                cutoff = 30
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5099, 5129);

                var
                lastEnd = node.Span.Start
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5143, 5172);

                var
                sb = f_207_5152_5171()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5186, 5614);
                    foreach (var token in f_207_5208_5255_I(f_207_5208_5255(node, descendIntoTrivia: false)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 5186, 5614);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5289, 5399) || true) && (token.Span.Start - lastEnd > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 5289, 5399);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5365, 5380);

                            f_207_5365_5379(sb, " ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(207, 5289, 5399);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5419, 5447);

                        f_207_5419_5446(
                                        sb, token.ToString());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5465, 5490);

                        lastEnd = token.Span.End;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5510, 5599) || true) && (f_207_5514_5523(sb) > cutoff)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(207, 5510, 5599);
                            DynAbs.Tracing.TraceSender.TraceBreak(207, 5574, 5580);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(207, 5510, 5599);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(207, 5186, 5614);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(207, 1, 429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(207, 1, 429);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(207, 5630, 5698);

                return f_207_5637_5650(sb) + ((DynAbs.Tracing.TraceSender.Conditional_F1(207, 5654, 5672) || ((f_207_5654_5663(sb) > cutoff && DynAbs.Tracing.TraceSender.Conditional_F2(207, 5675, 5681)) || DynAbs.Tracing.TraceSender.Conditional_F3(207, 5684, 5696))) ? " ..." : string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(207, 4984, 5709);

                System.Text.StringBuilder
                f_207_5152_5171()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 5152, 5171);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_207_5208_5255(Microsoft.CodeAnalysis.SyntaxNode
                this_param, bool
                descendIntoTrivia)
                {
                    var return_v = this_param.DescendantTokens(descendIntoTrivia: descendIntoTrivia);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 5208, 5255);
                    return return_v;
                }


                System.Text.StringBuilder
                f_207_5365_5379(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 5365, 5379);
                    return return_v;
                }


                System.Text.StringBuilder
                f_207_5419_5446(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 5419, 5446);
                    return return_v;
                }


                int
                f_207_5514_5523(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 5514, 5523);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                f_207_5208_5255_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 5208, 5255);
                    return return_v;
                }


                string
                f_207_5637_5650(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 5637, 5650);
                    return return_v;
                }


                int
                f_207_5654_5663(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 5654, 5663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(207, 4984, 5709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 4984, 5709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static AnalysisContextInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(207, 512, 5716);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(207, 512, 5716);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(207, 512, 5716);
        }

        static Microsoft.CodeAnalysis.Compilation
        f_207_896_920_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(207, 824, 998);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_207_1078_1095(Microsoft.CodeAnalysis.SemanticModel
        this_param)
        {
            var return_v = this_param.Compilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 1078, 1095);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_207_1124_1140(Microsoft.CodeAnalysis.SemanticModel
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 1124, 1140);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
        f_207_1097_1141(Microsoft.CodeAnalysis.SyntaxTree
        tree)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 1097, 1141);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_207_1078_1095_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(207, 1010, 1164);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_207_1264_1288_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(207, 1176, 1368);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_207_1481_1505_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(207, 1380, 1583);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_207_1774_1789(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 1774, 1789);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
        f_207_1747_1790(Microsoft.CodeAnalysis.SyntaxTree
        tree)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 1747, 1790);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_207_1684_1708_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(207, 1595, 1819);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_207_2020_2036(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 2020, 2036);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_207_2020_2047(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 2020, 2047);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
        f_207_1993_2048(Microsoft.CodeAnalysis.SyntaxTree
        tree)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 1993, 2048);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_207_2056_2072(Microsoft.CodeAnalysis.IOperation
        this_param)
        {
            var return_v = this_param.Syntax;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 2056, 2072);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_207_1925_1949_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(207, 1831, 2095);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_207_2304_2319(Microsoft.CodeAnalysis.SyntaxNode
        this_param)
        {
            var return_v = this_param.SyntaxTree;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 2304, 2319);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile
        f_207_2277_2320(Microsoft.CodeAnalysis.SyntaxTree
        tree)
        {
            var return_v = new Microsoft.CodeAnalysis.Diagnostics.SourceOrAdditionalFile(tree);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 2277, 2320);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Compilation
        f_207_2212_2236_C(Microsoft.CodeAnalysis.Compilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(207, 2107, 2349);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree?
        f_207_2622_2638_M(Microsoft.CodeAnalysis.SyntaxTree?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 2622, 2638);
            return return_v;
        }


        static int
        f_207_2593_2647(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 2593, 2647);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxTree?
        f_207_2696_2712_M(Microsoft.CodeAnalysis.SyntaxTree?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(207, 2696, 2712);
            return return_v;
        }


        static int
        f_207_2662_2721(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(207, 2662, 2721);
            return 0;
        }

    }
}
