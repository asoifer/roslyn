// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class LineDirectiveMap<TDirective>
            where TDirective : SyntaxNode
    {
        protected readonly LineMappingEntry[] Entries;

        protected abstract bool ShouldAddDirective(TDirective directive);

        protected abstract LineMappingEntry GetEntry(TDirective directive, SourceText sourceText, LineMappingEntry previous);

        protected abstract LineMappingEntry InitializeFirstEntry();

        protected LineDirectiveMap(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(666, 1606, 2081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 1074, 1081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 1748, 1805);

                var
                syntaxRoot = (SyntaxNodeOrToken)f_666_1784_1804(syntaxTree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 1819, 1915);

                IList<TDirective>
                directives = syntaxRoot.GetDirectives<TDirective>(filter: ShouldAddDirective)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 1929, 1962);

                f_666_1929_1961(directives != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 2016, 2070);

                this.Entries = f_666_2031_2069(this, syntaxTree, directives);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(666, 1606, 2081);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(666, 1606, 2081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(666, 1606, 2081);
            }
        }

        // Given a span and a default file name, return a FileLinePositionSpan that is the mapped
        // span, taking into account line directives.
        public FileLinePositionSpan TranslateSpan(SourceText sourceText, string treeFilePath, TextSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(666, 2247, 2680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 2372, 2440);

                var
                unmappedStartPos = f_666_2395_2439(f_666_2395_2411(sourceText), span.Start)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 2454, 2518);

                var
                unmappedEndPos = f_666_2475_2517(f_666_2475_2491(sourceText), span.End)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 2532, 2577);

                var
                entry = f_666_2544_2576(this, unmappedStartPos.Line)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 2593, 2669);

                return f_666_2600_2668(this, entry, treeFilePath, unmappedStartPos, unmappedEndPos);
                DynAbs.Tracing.TraceSender.TraceExitMethod(666, 2247, 2680);

                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_666_2395_2411(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(666, 2395, 2411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_666_2395_2439(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 2395, 2439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextLineCollection
                f_666_2475_2491(Microsoft.CodeAnalysis.Text.SourceText
                this_param)
                {
                    var return_v = this_param.Lines;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(666, 2475, 2491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_666_2475_2517(Microsoft.CodeAnalysis.Text.TextLineCollection
                this_param, int
                position)
                {
                    var return_v = this_param.GetLinePosition(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 2475, 2517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry
                f_666_2544_2576(Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>
                this_param, int
                lineNumber)
                {
                    var return_v = this_param.FindEntry(lineNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 2544, 2576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_666_2600_2668(Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>
                this_param, Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry
                entry, string
                treeFilePath, Microsoft.CodeAnalysis.Text.LinePosition
                unmappedStartPos, Microsoft.CodeAnalysis.Text.LinePosition
                unmappedEndPos)
                {
                    var return_v = this_param.TranslateSpan(entry, treeFilePath, unmappedStartPos, unmappedEndPos);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 2600, 2668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(666, 2247, 2680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(666, 2247, 2680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected FileLinePositionSpan TranslateSpan(LineMappingEntry entry, string treeFilePath, LinePosition unmappedStartPos, LinePosition unmappedEndPos)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(666, 2692, 3598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 2866, 2916);

                string
                path = entry.MappedPathOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(666, 2880, 2915) ?? treeFilePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 2930, 3014);

                int
                mappedStartLine = unmappedStartPos.Line - entry.UnmappedLine + entry.MappedLine
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 3028, 3108);

                int
                mappedEndLine = unmappedEndPos.Line - entry.UnmappedLine + entry.MappedLine
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 3124, 3587);

                return f_666_3131_3586(path, f_666_3197_3524((DynAbs.Tracing.TraceSender.Conditional_F1(666, 3240, 3263) || (((mappedStartLine == -1) && DynAbs.Tracing.TraceSender.Conditional_F2(666, 3266, 3310)) || DynAbs.Tracing.TraceSender.Conditional_F3(666, 3313, 3374))) ? f_666_3266_3310(unmappedStartPos.Character) : f_666_3313_3374(mappedStartLine, unmappedStartPos.Character), (DynAbs.Tracing.TraceSender.Conditional_F1(666, 3397, 3418) || (((mappedEndLine == -1) && DynAbs.Tracing.TraceSender.Conditional_F2(666, 3421, 3463)) || DynAbs.Tracing.TraceSender.Conditional_F3(666, 3466, 3523))) ? f_666_3421_3463(unmappedEndPos.Character) : f_666_3466_3523(mappedEndLine, unmappedEndPos.Character)), hasMappedPath: entry.MappedPathOpt != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(666, 2692, 3598);

                Microsoft.CodeAnalysis.Text.LinePosition
                f_666_3266_3310(int
                character)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LinePosition(character);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 3266, 3310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_666_3313_3374(int
                line, int
                character)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LinePosition(line, character);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 3313, 3374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_666_3421_3463(int
                character)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LinePosition(character);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 3421, 3463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePosition
                f_666_3466_3523(int
                line, int
                character)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LinePosition(line, character);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 3466, 3523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.LinePositionSpan
                f_666_3197_3524(Microsoft.CodeAnalysis.Text.LinePosition
                start, Microsoft.CodeAnalysis.Text.LinePosition
                end)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.LinePositionSpan(start, end);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 3197, 3524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_666_3131_3586(string
                path, Microsoft.CodeAnalysis.Text.LinePositionSpan
                span, bool
                hasMappedPath)
                {
                    var return_v = new Microsoft.CodeAnalysis.FileLinePositionSpan(path, span, hasMappedPath: hasMappedPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 3131, 3586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(666, 2692, 3598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(666, 2692, 3598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract LineVisibility GetLineVisibility(SourceText sourceText, int position);

        internal abstract FileLinePositionSpan TranslateSpanAndVisibility(SourceText sourceText, string treeFilePath, TextSpan span, out bool isHiddenPosition);

        public bool HasAnyHiddenRegions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(666, 4371, 4502);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 4429, 4491);

                return f_666_4436_4490(this.Entries, e => e.State == PositionState.Hidden);
                DynAbs.Tracing.TraceSender.TraceExitMethod(666, 4371, 4502);

                bool
                f_666_4436_4490(Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry[]
                source, System.Func<Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry, bool>
                predicate)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 4436, 4490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(666, 4371, 4502);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(666, 4371, 4502);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        // Find the line mapped entry with the largest unmapped line number <= lineNumber.
        protected LineMappingEntry FindEntry(int lineNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(666, 4606, 4768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 4683, 4718);

                int
                r = f_666_4691_4717(this, lineNumber)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 4734, 4757);

                return this.Entries[r];
                DynAbs.Tracing.TraceSender.TraceExitMethod(666, 4606, 4768);

                int
                f_666_4691_4717(Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>
                this_param, int
                lineNumber)
                {
                    var return_v = this_param.FindEntryIndex(lineNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 4691, 4717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(666, 4606, 4768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(666, 4606, 4768);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected int FindEntryIndex(int lineNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(666, 4885, 5085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 4954, 5029);

                int
                r = f_666_4962_5028(this.Entries, f_666_4995_5027(lineNumber))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5043, 5074);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(666, 5050, 5056) || ((r >= 0 && DynAbs.Tracing.TraceSender.Conditional_F2(666, 5059, 5060)) || DynAbs.Tracing.TraceSender.Conditional_F3(666, 5063, 5073))) ? r : ((~r) - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(666, 4885, 5085);

                Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry
                f_666_4995_5027(int
                unmappedLine)
                {
                    var return_v = new Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry(unmappedLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 4995, 5027);
                    return return_v;
                }


                int
                f_666_4962_5028(Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry[]
                array, Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry
                value)
                {
                    var return_v = Array.BinarySearch(array, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 4962, 5028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(666, 4885, 5085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(666, 4885, 5085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        // Given the ordered list of all directives in the file, return the ordered line mapping
        // entry for the file. This always starts with the null mapped that maps line 0 to line 0.
        private LineMappingEntry[] CreateEntryMap(SyntaxTree tree, IList<TDirective> directives)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(666, 5295, 6237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5408, 5465);

                var
                entries = new LineMappingEntry[f_666_5443_5459(directives) + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5479, 5516);

                var
                current = f_666_5493_5515(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5530, 5544);

                var
                index = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5558, 5583);

                entries[index] = current;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5599, 5947) || true) && (f_666_5603_5619(directives) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(666, 5599, 5947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5657, 5689);

                    var
                    sourceText = f_666_5674_5688(tree)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5707, 5932);
                        foreach (var directive in f_666_5733_5743_I(directives))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(666, 5707, 5932);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5785, 5836);

                            current = f_666_5795_5835(this, directive, sourceText, current);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5858, 5866);

                            ++index;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 5888, 5913);

                            entries[index] = current;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(666, 5707, 5932);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(666, 1, 226);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(666, 1, 226);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(666, 5599, 5947);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 6049, 6054);

                    // Make sure the entries array is correctly sorted. 
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 6040, 6187) || true) && (i < f_666_6060_6074(entries) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 6080, 6083)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(666, 6040, 6187))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(666, 6040, 6187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 6117, 6172);

                        f_666_6117_6171(entries[i].CompareTo(entries[i + 1]) < 0);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(666, 1, 148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(666, 1, 148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(666, 6211, 6226);

                return entries;
                DynAbs.Tracing.TraceSender.TraceExitMethod(666, 5295, 6237);

                int
                f_666_5443_5459(System.Collections.Generic.IList<TDirective>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(666, 5443, 5459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry
                f_666_5493_5515(Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>
                this_param)
                {
                    var return_v = this_param.InitializeFirstEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 5493, 5515);
                    return return_v;
                }


                int
                f_666_5603_5619(System.Collections.Generic.IList<TDirective>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(666, 5603, 5619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_666_5674_5688(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 5674, 5688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry
                f_666_5795_5835(Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>
                this_param, TDirective
                directive, Microsoft.CodeAnalysis.Text.SourceText
                sourceText, Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry
                previous)
                {
                    var return_v = this_param.GetEntry(directive, sourceText, previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 5795, 5835);
                    return return_v;
                }


                System.Collections.Generic.IList<TDirective>
                f_666_5733_5743_I(System.Collections.Generic.IList<TDirective>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 5733, 5743);
                    return return_v;
                }


                int
                f_666_6060_6074(Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(666, 6060, 6074);
                    return return_v;
                }


                int
                f_666_6117_6171(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 6117, 6171);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(666, 5295, 6237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(666, 5295, 6237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LineDirectiveMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(666, 920, 6244);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(666, 920, 6244);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(666, 920, 6244);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(666, 920, 6244);

        static Microsoft.CodeAnalysis.SyntaxNode
        f_666_1784_1804(Microsoft.CodeAnalysis.SyntaxTree
        this_param)
        {
            var return_v = this_param.GetRoot();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 1784, 1804);
            return return_v;
        }


        static int
        f_666_1929_1961(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 1929, 1961);
            return 0;
        }


        static Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>.LineMappingEntry[]
        f_666_2031_2069<TDirective>(Microsoft.CodeAnalysis.LineDirectiveMap<TDirective>
        this_param, Microsoft.CodeAnalysis.SyntaxTree
        tree, System.Collections.Generic.IList<TDirective>
        directives) where TDirective : SyntaxNode

        {
            var return_v = this_param.CreateEntryMap(tree, directives);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(666, 2031, 2069);
            return return_v;
        }

    }
}
