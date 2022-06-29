// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Roslyn.Utilities
{
    internal sealed class SetWithInsertionOrder<T> : IEnumerable<T>, IReadOnlySet<T>
    {
        private HashSet<T>? _set;

        private ArrayBuilder<T>? _elements;

        public bool Add(T value)
        {
            if (_set == null)
            {
                _set = new HashSet<T>();
                _elements = new ArrayBuilder<T>();
            }

            if (!_set.Add(value))
            {
                return false;
            }

            _elements!.Add(value);
            return true;
        }

        public bool Insert(int index, T value)
        {
            if (_set == null)
            {
                if (index > 0)
                {
                    throw new IndexOutOfRangeException();
                }
                Add(value);
            }
            else
            {
                if (!_set.Add(value))
                {
                    return false;
                }

                try
                {
                    _elements!.Insert(index, value);
                }
                catch
                {
                    _set.Remove(value);
                    throw;
                }
            }
            return true;
        }

        public bool Remove(T value)
        {
            if (_set is null)
            {
                return false;
            }

            if (!_set.Remove(value))
            {
                return false;
            }
            _elements!.RemoveAt(_elements.IndexOf(value));
            return true;
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 2212, 2236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2215, 2236);
                    return f_365_2215_2231_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_elements, 365, 2215, 2231)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(365, 2215, 2236) ?? 0); DynAbs.Tracing.TraceSender.TraceExitMethod(365, 2212, 2236);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 2212, 2236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 2212, 2236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Contains(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(365, 2279, 2312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 2282, 2312);
                return f_365_2282_2303_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_set, 365, 2282, 2303)?.Contains(value)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(365, 2282, 2312) ?? false); DynAbs.Tracing.TraceSender.TraceExitMethod(365, 2279, 2312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(365, 2279, 2312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 2279, 2312);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool?
            f_365_2282_2303_I(bool?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(365, 2282, 2303);
                return return_v;
            }

        }

        public IEnumerator<T> GetEnumerator()
            => _elements is null ? SpecializedCollections.EmptyEnumerator<T>() : ((IEnumerable<T>)_elements).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public ImmutableArray<T> AsImmutable() => _elements.ToImmutableArrayOrEmpty();

        public T this[int i] => f_365_2686_2699(_elements!, i);

        public SetWithInsertionOrder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(365, 565, 2707);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 682, 693);
            this._set = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(365, 729, 745);
            this._elements = null; DynAbs.Tracing.TraceSender.TraceExitConstructor(365, 565, 2707);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 565, 2707);
        }


        static SetWithInsertionOrder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(365, 565, 2707);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(365, 565, 2707);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(365, 565, 2707);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(365, 565, 2707);

        int?
        f_365_2215_2231_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(365, 2215, 2231);
            return return_v;
        }


        T?
        f_365_2686_2699(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(365, 2686, 2699);
            return return_v;
        }

    }
}
