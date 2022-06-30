// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis.Text;
namespace Microsoft.CodeAnalysis
{

    internal readonly struct GeneratedSourceText
    {

        public SourceText Text { get; }

        public string HintName { get; }

        public GeneratedSourceText(string hintName, SourceText text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(546, 609, 761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(546, 694, 711);

                this.Text = text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(546, 725, 750);

                this.HintName = hintName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(546, 609, 761);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(546, 609, 761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(546, 609, 761);
            }
        }
        static GeneratedSourceText()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(546, 462, 768);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(546, 462, 768);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(546, 462, 768);
        }
    }
}
