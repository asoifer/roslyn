// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;
using Microsoft.Cci;

namespace Microsoft.CodeAnalysis
{

    internal readonly struct IReferenceOrISignature : IEquatable<IReferenceOrISignature>
    {

        private readonly object _item;

        public IReferenceOrISignature(IReference item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21, 1014, 1077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21, 1064, 1076);
                _item = item; DynAbs.Tracing.TraceSender.TraceExitConstructor(21, 1014, 1077);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21, 1014, 1077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21, 1014, 1077);
            }
        }

        public IReferenceOrISignature(ISignature item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21, 1089, 1152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21, 1139, 1151);
                _item = item; DynAbs.Tracing.TraceSender.TraceExitConstructor(21, 1089, 1152);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21, 1089, 1152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21, 1089, 1152);
            }
        }

        public IReferenceOrISignature(IMethodReference item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21, 1260, 1329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21, 1316, 1328);
                _item = item; DynAbs.Tracing.TraceSender.TraceExitConstructor(21, 1260, 1329);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21, 1260, 1329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21, 1260, 1329);
            }
        }

        public bool Equals(IReferenceOrISignature other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21, 1390, 1428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21, 1393, 1428);
                return f_21_1393_1428(_item, other._item); DynAbs.Tracing.TraceSender.TraceExitMethod(21, 1390, 1428);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21, 1390, 1428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21, 1390, 1428);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_21_1393_1428(object
            objA, object
            objB)
            {
                var return_v = ReferenceEquals(objA, objB);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21, 1393, 1428);
                return return_v;
            }

        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21, 1482, 1490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21, 1485, 1490);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(21, 1482, 1490);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21, 1482, 1490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21, 1482, 1490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21, 1537, 1573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21, 1540, 1573);
                return f_21_1540_1573(_item); DynAbs.Tracing.TraceSender.TraceExitMethod(21, 1537, 1573);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21, 1537, 1573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21, 1537, 1573);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_21_1540_1573(object
            o)
            {
                var return_v = RuntimeHelpers.GetHashCode(o);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21, 1540, 1573);
                return return_v;
            }

        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21, 1620, 1649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21, 1623, 1649);
                return f_21_1623_1639(_item) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(21, 1623, 1649) ?? "null"); DynAbs.Tracing.TraceSender.TraceExitMethod(21, 1620, 1649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21, 1620, 1649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21, 1620, 1649);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string?
            f_21_1623_1639(object
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21, 1623, 1639);
                return return_v;
            }

        }

        internal object AsObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(21, 1689, 1697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21, 1692, 1697);
                return _item; DynAbs.Tracing.TraceSender.TraceExitMethod(21, 1689, 1697);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21, 1689, 1697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21, 1689, 1697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static IReferenceOrISignature()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21, 871, 1705);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21, 871, 1705);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21, 871, 1705);
        }
    }
}
