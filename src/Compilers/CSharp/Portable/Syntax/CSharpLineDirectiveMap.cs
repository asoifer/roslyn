// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    internal class CSharpLineDirectiveMap : LineDirectiveMap<DirectiveTriviaSyntax>
    {
        public CSharpLineDirectiveMap(SyntaxTree syntaxTree)
        : base(f_10751_620_630_C(syntaxTree))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10751, 547, 653);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10751, 547, 653);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10751, 547, 653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10751, 547, 653);
            }
        }

        protected override bool ShouldAddDirective(DirectiveTriviaSyntax directive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10751, 759, 950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 859, 939);

                return f_10751_866_884(directive) && (DynAbs.Tracing.TraceSender.Expression_True(10751, 866, 938) && f_10751_888_904(directive) == SyntaxKind.LineDirectiveTrivia);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10751, 759, 950);

                bool
                f_10751_866_884(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.IsActive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 866, 884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10751_888_904(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 888, 904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10751, 759, 950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10751, 759, 950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LineMappingEntry GetEntry(DirectiveTriviaSyntax directiveNode, SourceText sourceText, LineMappingEntry previous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10751, 1036, 3626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 1192, 1240);

                f_10751_1192_1239(f_10751_1205_1238(this, directiveNode));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 1254, 1311);

                var
                directive = (LineDirectiveTriviaSyntax)directiveNode
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 1387, 1463);

                var
                directiveLineNumber = f_10751_1413_1458(f_10751_1413_1429(sourceText), f_10751_1438_1457(directive)) + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 1613, 1652);

                var
                unmappedLine = directiveLineNumber
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 1666, 1749);

                var
                mappedLine = previous.MappedLine + directiveLineNumber - previous.UnmappedLine
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 1763, 1806);

                var
                mappedPathOpt = previous.MappedPathOpt
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 1820, 1865);

                PositionState
                state = PositionState.Unmapped
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 1946, 1985);

                SyntaxToken
                lineToken = f_10751_1970_1984(directive)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 1999, 3454) || true) && (f_10751_2003_2023_M(!lineToken.IsMissing))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 1999, 3454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 2057, 3439);

                    switch (lineToken.Kind())
                    {

                        case SyntaxKind.HiddenKeyword:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 2057, 3439);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 2179, 2208);

                            state = PositionState.Hidden;
                            DynAbs.Tracing.TraceSender.TraceBreak(10751, 2234, 2240);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 2057, 3439);

                        case SyntaxKind.DefaultKeyword:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 2057, 3439);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 2321, 2347);

                            mappedLine = unmappedLine;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 2373, 2394);

                            mappedPathOpt = null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 2420, 2451);

                            state = PositionState.Unmapped;
                            DynAbs.Tracing.TraceSender.TraceBreak(10751, 2477, 2483);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 2057, 3439);

                        case SyntaxKind.NumericLiteralToken:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 2057, 3439);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 2672, 3386) || true) && (f_10751_2676_2706_M(!lineToken.ContainsDiagnostics))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 2672, 3386);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 2764, 2796);

                                object?
                                value = lineToken.Value
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 2826, 3063) || true) && (value is int)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 2826, 3063);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 3002, 3032);

                                    mappedLine = ((int)value) - 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 2826, 3063);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 3095, 3296) || true) && (directive.File.Kind() == SyntaxKind.StringLiteralToken)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 3095, 3296);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 3219, 3265);

                                    mappedPathOpt = (string?)directive.File.Value;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 3095, 3296);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 3328, 3359);

                                state = PositionState.Remapped;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 2672, 3386);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10751, 3414, 3420);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 2057, 3439);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 1999, 3454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 3470, 3615);

                return f_10751_3477_3614(unmappedLine, mappedLine, mappedPathOpt, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10751, 1036, 3626);

                bool
                f_10751_1205_1238(Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                directive)
                {
                    var return_v = this_param.ShouldAddDirective(directive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 1205, 1238);
                    return return_v;
                }


                int
                f_10751_1192_1239(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 1192, 1239);
                    return 0;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_10751_1413_1429(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 1413, 1429);
                    return return_v;
                }


                int
                f_10751_1438_1457(Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 1438, 1457);
                    return return_v;
                }


                int
                f_10751_1413_1458(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.IndexOf(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 1413, 1458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10751_1970_1984(Microsoft.CodeAnalysis.CSharp.Syntax.LineDirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 1970, 1984);
                    return return_v;
                }


                bool
                f_10751_2003_2023_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 2003, 2023);
                    return return_v;
                }


                bool
                f_10751_2676_2706_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 2676, 2706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.LineMappingEntry
                f_10751_3477_3614(int
                unmappedLine, int
                mappedLine, string?
                mappedPathOpt, Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.PositionState
                state)
                {
                    var return_v = new Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.LineMappingEntry(unmappedLine, mappedLine, mappedPathOpt, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 3477, 3614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10751, 1036, 3626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10751, 1036, 3626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override LineMappingEntry InitializeFirstEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10751, 3638, 3891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 3816, 3880);

                return f_10751_3823_3879(0, 0, null, PositionState.Unmapped);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10751, 3638, 3891);

                Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.LineMappingEntry
                f_10751_3823_3879(int
                unmappedLine, int
                mappedLine, string?
                mappedPathOpt, Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.PositionState
                state)
                {
                    var return_v = new Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.LineMappingEntry(unmappedLine, mappedLine, mappedPathOpt, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 3823, 3879);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10751, 3638, 3891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10751, 3638, 3891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LineVisibility GetLineVisibility(SourceText sourceText, int position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10751, 3903, 5517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4013, 4074);

                var
                unmappedPos = f_10751_4031_4073(f_10751_4031_4047(sourceText), position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4232, 4409) || true) && (f_10751_4236_4250(Entries) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 4232, 4409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4289, 4346);

                    f_10751_4289_4345(Entries[0].State == PositionState.Unmapped);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4364, 4394);

                    return LineVisibility.Visible;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 4232, 4409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4425, 4470);

                var
                index = f_10751_4437_4469(this, unmappedPos.Line)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4484, 4511);

                var
                entry = Entries[index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4601, 4809);

                f_10751_4601_4808(entry.State != PositionState.Unknown && (DynAbs.Tracing.TraceSender.Expression_True(10751, 4614, 4728) && entry.State != PositionState.RemappedAfterHidden) && (DynAbs.Tracing.TraceSender.Expression_True(10751, 4614, 4807) && entry.State != PositionState.RemappedAfterUnknown));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4825, 5506);

                switch (entry.State)
                {

                    case PositionState.Unmapped:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 4825, 5506);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4928, 5190) || true) && (index == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 4928, 5190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 4992, 5039);

                            return LineVisibility.BeforeFirstLineDirective;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 4928, 5190);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 4928, 5190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 5137, 5167);

                            return LineVisibility.Visible;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 4928, 5190);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 4825, 5506);

                    case PositionState.Remapped:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 4825, 5506);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 5260, 5290);

                        return LineVisibility.Visible;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 4825, 5506);

                    case PositionState.Hidden:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 4825, 5506);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 5358, 5387);

                        return LineVisibility.Hidden;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 4825, 5506);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 4825, 5506);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 5437, 5491);

                        throw f_10751_5443_5490(entry.State);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 4825, 5506);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10751, 3903, 5517);

                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_10751_4031_4047(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 4031, 4047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_10751_4031_4073(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 4031, 4073);
                    return return_v;
                }


                int
                f_10751_4236_4250(Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.LineMappingEntry[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 4236, 4250);
                    return return_v;
                }


                int
                f_10751_4289_4345(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 4289, 4345);
                    return 0;
                }


                int
                f_10751_4437_4469(Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                this_param, int
                lineNumber)
                {
                    var return_v = this_param.FindEntryIndex(lineNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 4437, 4469);
                    return return_v;
                }


                int
                f_10751_4601_4808(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 4601, 4808);
                    return 0;
                }


                System.Exception
                f_10751_5443_5490(Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.PositionState
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 5443, 5490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10751, 3903, 5517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10751, 3903, 5517);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override FileLinePositionSpan TranslateSpanAndVisibility(SourceText sourceText, string treeFilePath, TextSpan span, out bool isHiddenPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10751, 5529, 7008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 5705, 5734);

                var
                lines = f_10751_5717_5733(sourceText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 5748, 5805);

                var
                unmappedStartPos = f_10751_5771_5804(lines, span.Start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 5819, 5872);

                var
                unmappedEndPos = f_10751_5840_5871(lines, span.End)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 5962, 6469) || true) && (f_10751_5966_5985(this.Entries) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10751, 5962, 6469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6024, 6086);

                    f_10751_6024_6085(this.Entries[0].State == PositionState.Unmapped);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6104, 6177);

                    f_10751_6104_6176(this.Entries[0].MappedLine == this.Entries[0].UnmappedLine);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6195, 6241);

                    f_10751_6195_6240(this.Entries[0].MappedLine == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6259, 6311);

                    f_10751_6259_6310(this.Entries[0].MappedPathOpt == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6331, 6356);

                    isHiddenPosition = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6374, 6454);

                    return f_10751_6381_6453(treeFilePath, unmappedStartPos, unmappedEndPos);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10751, 5962, 6469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6485, 6530);

                var
                entry = f_10751_6497_6529(this, unmappedStartPos.Line)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6620, 6834);

                f_10751_6620_6833(entry.State != PositionState.Unknown && (DynAbs.Tracing.TraceSender.Expression_True(10751, 6633, 6750) && entry.State != PositionState.RemappedAfterHidden) && (DynAbs.Tracing.TraceSender.Expression_True(10751, 6633, 6832) && entry.State != PositionState.RemappedAfterUnknown));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6850, 6905);

                isHiddenPosition = entry.State == PositionState.Hidden;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10751, 6921, 6997);

                return f_10751_6928_6996(this, entry, treeFilePath, unmappedStartPos, unmappedEndPos);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10751, 5529, 7008);

                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_10751_5717_5733(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 5717, 5733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_10751_5771_5804(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 5771, 5804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_10751_5840_5871(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 5840, 5871);
                    return return_v;
                }


                int
                f_10751_5966_5985(Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.LineMappingEntry[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10751, 5966, 5985);
                    return return_v;
                }


                int
                f_10751_6024_6085(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 6024, 6085);
                    return 0;
                }


                int
                f_10751_6104_6176(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 6104, 6176);
                    return 0;
                }


                int
                f_10751_6195_6240(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 6195, 6240);
                    return 0;
                }


                int
                f_10751_6259_6310(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 6259, 6310);
                    return 0;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10751_6381_6453(string
                path, Microsoft.CodeAnalysis.Text.LinePosition
                start, Microsoft.CodeAnalysis.Text.LinePosition
                end)
                {
                    var return_v = new Microsoft.CodeAnalysis.FileLinePositionSpan(path, start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 6381, 6453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.LineMappingEntry
                f_10751_6497_6529(Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                this_param, int
                lineNumber)
                {
                    var return_v = this_param.FindEntry(lineNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 6497, 6529);
                    return return_v;
                }


                int
                f_10751_6620_6833(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 6620, 6833);
                    return 0;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10751_6928_6996(Microsoft.CodeAnalysis.CSharp.Syntax.CSharpLineDirectiveMap
                this_param, Microsoft.CodeAnalysis.LineDirectiveMap<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>.LineMappingEntry
                entry, string
                treeFilePath, Microsoft.CodeAnalysis.Text.LinePosition
                unmappedStartPos, Microsoft.CodeAnalysis.Text.LinePosition
                unmappedEndPos)
                {
                    var return_v = this_param.TranslateSpan(entry, treeFilePath, unmappedStartPos, unmappedEndPos);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10751, 6928, 6996);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10751, 5529, 7008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10751, 5529, 7008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpLineDirectiveMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10751, 451, 7015);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10751, 451, 7015);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10751, 451, 7015);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10751, 451, 7015);

        static Microsoft.CodeAnalysis.SyntaxTree
        f_10751_620_630_C(Microsoft.CodeAnalysis.SyntaxTree
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10751, 547, 653);
            return return_v;
        }

    }
}
