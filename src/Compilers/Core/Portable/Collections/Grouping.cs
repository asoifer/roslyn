// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis
{
    internal class Grouping<TKey, TElement> : IGrouping<TKey, TElement>
            where TKey : notnull
    {
        public TKey Key { get; }

        private readonly IEnumerable<TElement> _elements;

        public Grouping(TKey key, IEnumerable<TElement> elements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(101, 665, 808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(101, 570, 594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(101, 643, 652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(101, 747, 762);

                this.Key = key;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(101, 776, 797);

                _elements = elements;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(101, 665, 808);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(101, 665, 808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(101, 665, 808);
            }
        }

        public Grouping(KeyValuePair<TKey, IEnumerable<TElement>> pair)
        : this(f_101_904_912_C<TKey>(pair.Key), pair.Value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(101, 820, 947);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(101, 820, 947);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(101, 820, 947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(101, 820, 947);
            }
        }

        public IEnumerator<TElement> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(101, 959, 1072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(101, 1028, 1061);

                return f_101_1035_1060(_elements);
                DynAbs.Tracing.TraceSender.TraceExitMethod(101, 959, 1072);

                System.Collections.Generic.IEnumerator<TElement>
                f_101_1035_1060(System.Collections.Generic.IEnumerable<TElement>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(101, 1035, 1060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(101, 959, 1072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(101, 959, 1072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(101, 1084, 1182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(101, 1148, 1171);

                return f_101_1155_1170(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(101, 1084, 1182);

                System.Collections.Generic.IEnumerator<TElement>
                f_101_1155_1170(Microsoft.CodeAnalysis.Grouping<TKey, TElement>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(101, 1155, 1170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(101, 1084, 1182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(101, 1084, 1182);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static Grouping()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(101, 456, 1189);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(101, 456, 1189);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(101, 456, 1189);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(101, 456, 1189);

        static TKey
        f_101_904_912_C<TKey>(TKey
        i) where TKey : notnull

        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(101, 820, 947);
            return return_v;
        }

    }
}
