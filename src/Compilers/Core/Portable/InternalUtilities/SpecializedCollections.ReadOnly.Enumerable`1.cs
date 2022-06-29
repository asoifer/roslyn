// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private partial class ReadOnly
        {
            internal class Enumerable<TUnderlying> : IEnumerable
                           where TUnderlying : IEnumerable
            {
                protected readonly TUnderlying Underlying;

                public Enumerable(TUnderlying underlying)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(378, 585, 715);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(378, 554, 564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(378, 667, 696);

                        this.Underlying = underlying;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(378, 585, 715);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(378, 585, 715);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(378, 585, 715);
                    }
                }

                public IEnumerator GetEnumerator()
                {
                    return this.Underlying.GetEnumerator();
                }

                static Enumerable()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(378, 389, 883);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(378, 389, 883);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(378, 389, 883);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(378, 389, 883);
            }
        }
    }
}
