// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;

namespace Roslyn.Utilities
{
    internal partial class SpecializedCollections
    {
        private partial class ReadOnly
        {
            internal class Enumerable<TUnderlying, T> : Enumerable<TUnderlying>, IEnumerable<T>
                           where TUnderlying : IEnumerable<T>
            {
                public Enumerable(TUnderlying underlying)
                : base(f_379_635_645_C<TUnderlying>(underlying))
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(379, 565, 684);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(379, 565, 684);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(379, 565, 684);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(379, 565, 684);
                    }
                }

                public new IEnumerator<T> GetEnumerator()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(379, 704, 844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(379, 786, 825);

                        return f_379_793_824(this.Underlying);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(379, 704, 844);

                        System.Collections.Generic.IEnumerator<T>
                        f_379_793_824(TUnderlying
                        this_param)
                        {
                            var return_v = this_param.GetEnumerator();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(379, 793, 824);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(379, 704, 844);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(379, 704, 844);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static Enumerable()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(379, 397, 859);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(379, 397, 859);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(379, 397, 859);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(379, 397, 859);

                static TUnderlying
                f_379_635_645_C<TUnderlying>(TUnderlying
                i) where TUnderlying : IEnumerable<T>

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceBaseCall(379, 565, 684);
                    return return_v;
                }

            }
        }
    }
}
