// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Roslyn.Utilities
{

    internal readonly struct ObjectBinderSnapshot
    {

        private readonly Dictionary<Type, int> _typeToIndex;

        private readonly ImmutableArray<Type> _types;

        private readonly ImmutableArray<Func<ObjectReader, IObjectWritable>> _typeReaders;

        public ObjectBinderSnapshot(
                    Dictionary<Type, int> typeToIndex,
                    List<Type> types,
                    List<Func<ObjectReader, IObjectWritable>> typeReaders)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(542, 626, 999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(542, 826, 880);

                _typeToIndex = f_542_841_879(typeToIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(542, 894, 928);

                _types = f_542_903_927(types);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(542, 942, 988);

                _typeReaders = f_542_957_987(typeReaders);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(542, 626, 999);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(542, 626, 999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(542, 626, 999);
            }
        }

        public int GetTypeId(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(542, 1056, 1077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(542, 1059, 1077);
                return f_542_1059_1077(_typeToIndex, type); DynAbs.Tracing.TraceSender.TraceExitMethod(542, 1056, 1077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(542, 1056, 1077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(542, 1056, 1077);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_542_1059_1077(System.Collections.Generic.Dictionary<System.Type, int>
            this_param, System.Type
            i0)
            {
                var return_v = this_param[i0];
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(542, 1059, 1077);
                return return_v;
            }

        }

        public Type GetTypeFromId(int typeId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(542, 1141, 1158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(542, 1144, 1158);
                return _types[typeId]; DynAbs.Tracing.TraceSender.TraceExitMethod(542, 1141, 1158);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(542, 1141, 1158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(542, 1141, 1158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Func<ObjectReader, IObjectWritable> GetTypeReaderFromId(int typeId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(542, 1259, 1282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(542, 1262, 1282);
                return _typeReaders[typeId]; DynAbs.Tracing.TraceSender.TraceExitMethod(542, 1259, 1282);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(542, 1259, 1282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(542, 1259, 1282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static ObjectBinderSnapshot()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(542, 353, 1290);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(542, 353, 1290);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(542, 353, 1290);
        }

        static System.Collections.Generic.Dictionary<System.Type, int>
        f_542_841_879(System.Collections.Generic.Dictionary<System.Type, int>
        dictionary)
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Type, int>((System.Collections.Generic.IDictionary<System.Type, int>)dictionary);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(542, 841, 879);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<System.Type>
        f_542_903_927(System.Collections.Generic.List<System.Type>
        items)
        {
            var return_v = items.ToImmutableArray<System.Type>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(542, 903, 927);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>>
        f_542_957_987(System.Collections.Generic.List<System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>>
        items)
        {
            var return_v = items.ToImmutableArray<System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(542, 957, 987);
            return return_v;
        }

    }
}
