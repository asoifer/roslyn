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
            var unmappedStartPos = sourceText.Lines.GetLinePosition(span.Start);
            var unmappedEndPos = sourceText.Lines.GetLinePosition(span.End);
            var entry = FindEntry(unmappedStartPos.Line);

            return TranslateSpan(entry, treeFilePath, unmappedStartPos, unmappedEndPos);
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
            int r = FindEntryIndex(lineNumber);

            return this.Entries[r];
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
            var entries = new LineMappingEntry[directives.Count + 1];
            var current = InitializeFirstEntry();
            var index = 0;
            entries[index] = current;

            if (directives.Count > 0)
            {
                var sourceText = tree.GetText();
                foreach (var directive in directives)
                {
                    current = GetEntry(directive, sourceText, current);
                    ++index;
                    entries[index] = current;
                }
            }

#if DEBUG
            // Make sure the entries array is correctly sorted. 
            for (int i = 0; i < entries.Length - 1; ++i)
            {
                Debug.Assert(entries[i].CompareTo(entries[i + 1]) < 0);
            }
#endif

            return entries;
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
