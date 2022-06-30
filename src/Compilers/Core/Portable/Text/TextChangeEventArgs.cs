// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{
    public class TextChangeEventArgs : EventArgs
    {
        public TextChangeEventArgs(SourceText oldText, SourceText newText, IEnumerable<TextChangeRange> changes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(730, 893, 1282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(730, 1936, 1970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(730, 2074, 2108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(730, 2219, 2273);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(730, 1022, 1139) || true) && (changes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(730, 1022, 1139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(730, 1075, 1124);

                    throw f_730_1081_1123(nameof(changes));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(730, 1022, 1139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(730, 1155, 1178);

                this.OldText = oldText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(730, 1192, 1215);

                this.NewText = newText;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(730, 1229, 1271);

                this.Changes = f_730_1244_1270(changes);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(730, 893, 1282);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(730, 893, 1282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(730, 893, 1282);
            }
        }

        public TextChangeEventArgs(SourceText oldText, SourceText newText, params TextChangeRange[] changes)
        : this(f_730_1753_1760_C(oldText), newText, (IEnumerable<TextChangeRange>)changes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(730, 1632, 1831);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(730, 1632, 1831);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(730, 1632, 1831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(730, 1632, 1831);
            }
        }

        public SourceText OldText { get; }

        public SourceText NewText { get; }

        public IReadOnlyList<TextChangeRange> Changes { get; }

        static TextChangeEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(730, 494, 2280);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(730, 494, 2280);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(730, 494, 2280);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(730, 494, 2280);

        static System.ArgumentNullException
        f_730_1081_1123(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(730, 1081, 1123);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>
        f_730_1244_1270(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Text.TextChangeRange>
        items)
        {
            var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.Text.TextChangeRange>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(730, 1244, 1270);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Text.SourceText
        f_730_1753_1760_C(Microsoft.CodeAnalysis.Text.SourceText
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(730, 1632, 1831);
            return return_v;
        }

    }
}
