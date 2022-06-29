// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private partial class Empty
        {
            internal class Enumerable<T> : IEnumerable<T>
            {
                private readonly IEnumerator<T> _enumerator;

                public IEnumerator<T> GetEnumerator()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(372, 837, 953);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(372, 915, 934);

                        return _enumerator;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(372, 837, 953);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(372, 837, 953);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(372, 837, 953);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
                {
                    return GetEnumerator();
                }

                public Enumerable()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(372, 394, 1148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(372, 780, 816);
                    this._enumerator = Enumerator<T>.Instance; DynAbs.Tracing.TraceSender.TraceExitConstructor(372, 394, 1148);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(372, 394, 1148);
                }


                static Enumerable()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(372, 394, 1148);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(372, 394, 1148);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(372, 394, 1148);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(372, 394, 1148);
            }
        }
    }
}
