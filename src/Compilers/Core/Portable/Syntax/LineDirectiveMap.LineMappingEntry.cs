// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    internal partial class LineDirectiveMap<TDirective>
    {        /// <summary>
             /// Enum that describes the state related to the #line or #externalsource directives at a position in source.
             /// </summary>
        public enum PositionState : byte
        {
            /// <summary>
            /// Used in VB when the position is not hidden, but it's not known yet that there is a (nonempty) #ExternalSource
            /// following.
            /// </summary>
            Unknown,

            /// <summary>
            /// Used in C# for spans outside of #line directives
            /// </summary>
            Unmapped,

            /// <summary>
            /// Used in C# for spans inside of "#line linenumber" directive
            /// </summary>
            Remapped,

            /// <summary>
            /// Used in VB for spans inside of a "#ExternalSource" directive that followed an unknown span
            /// </summary>
            RemappedAfterUnknown,

            /// <summary>
            /// Used in VB for spans inside of a "#ExternalSource" directive that followed a hidden span
            /// </summary>
            RemappedAfterHidden,

            /// <summary>
            /// Used in C# and VB for spans that are inside of #line hidden (C#) or outside of #ExternalSource (VB) 
            /// directives
            /// </summary>
            Hidden
        }

        protected readonly struct LineMappingEntry : IComparable<LineMappingEntry>
        {

            public readonly int UnmappedLine;

            public readonly int MappedLine;

            public readonly string? MappedPathOpt;

            public readonly PositionState State;

            public LineMappingEntry(int unmappedLine)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(667, 2370, 2639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(667, 2444, 2477);

                    this.UnmappedLine = unmappedLine;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(667, 2495, 2526);

                    this.MappedLine = unmappedLine;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(667, 2544, 2570);

                    this.MappedPathOpt = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(667, 2588, 2624);

                    this.State = PositionState.Unmapped;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(667, 2370, 2639);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(667, 2370, 2639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(667, 2370, 2639);
                }
            }

            public LineMappingEntry(
                            int unmappedLine,
                            int mappedLine,
                            string? mappedPathOpt,
                            PositionState state)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(667, 2655, 3043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(667, 2858, 2891);

                    this.UnmappedLine = unmappedLine;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(667, 2909, 2938);

                    this.MappedLine = mappedLine;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(667, 2956, 2991);

                    this.MappedPathOpt = mappedPathOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(667, 3009, 3028);

                    this.State = state;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(667, 2655, 3043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(667, 2655, 3043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(667, 2655, 3043);
                }
            }

            public int CompareTo(LineMappingEntry other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(667, 3059, 3206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(667, 3136, 3191);

                    return f_667_3143_3190(this.UnmappedLine, other.UnmappedLine);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(667, 3059, 3206);

                    int
                    f_667_3143_3190(int
                    this_param, int
                    value)
                    {
                        var return_v = this_param.CompareTo(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(667, 3143, 3190);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(667, 3059, 3206);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(667, 3059, 3206);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static LineMappingEntry()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(667, 1875, 3217);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(667, 1875, 3217);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(667, 1875, 3217);
            }
        }
    }
}
