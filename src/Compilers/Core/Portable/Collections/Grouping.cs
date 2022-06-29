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
            return _elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
