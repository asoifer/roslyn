// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{

    internal struct TypeLayout : IEquatable<TypeLayout>
    {

        private readonly byte _kind;

        private readonly short _alignment;

        private readonly int _size;

        public TypeLayout(LayoutKind kind, int size, byte alignment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(651, 619, 1027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 704, 764);

                f_651_704_763(size >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(651, 717, 744) && (int)kind >= 0) && (DynAbs.Tracing.TraceSender.Expression_True(651, 717, 762) && (int)kind <= 3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 870, 911);

                f_651_870_910(LayoutKind.Sequential == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 925, 950);

                _kind = (byte)(kind + 1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 966, 979);

                _size = size;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 993, 1016);

                _alignment = alignment;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(651, 619, 1027);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(651, 619, 1027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(651, 619, 1027);
            }
        }

        public LayoutKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(651, 1186, 1377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 1300, 1362);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(651, 1307, 1317) || ((_kind == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(651, 1320, 1335)) || DynAbs.Tracing.TraceSender.Conditional_F3(651, 1338, 1361))) ? LayoutKind.Auto : (LayoutKind)(_kind - 1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(651, 1186, 1377);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(651, 1139, 1388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(651, 1139, 1388);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public short Alignment
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(651, 1556, 1582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 1562, 1580);

                    return _alignment;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(651, 1556, 1582);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(651, 1509, 1593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(651, 1509, 1593);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Size
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(651, 1723, 1744);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 1729, 1742);

                    return _size;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(651, 1723, 1744);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(651, 1683, 1755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(651, 1683, 1755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Equals(TypeLayout other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(651, 1767, 1959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 1828, 1948);

                return _size == other._size
                && (DynAbs.Tracing.TraceSender.Expression_True(651, 1835, 1906) && _alignment == other._alignment
                ) && (DynAbs.Tracing.TraceSender.Expression_True(651, 1835, 1947) && _kind == other._kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(651, 1767, 1959);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(651, 1767, 1959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(651, 1767, 1959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(651, 1971, 2099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 2036, 2088);

                return obj is TypeLayout && (DynAbs.Tracing.TraceSender.Expression_True(651, 2043, 2087) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(651, 1971, 2099);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(651, 1971, 2099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(651, 1971, 2099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(651, 2111, 2248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(651, 2169, 2237);

                return f_651_2176_2236(f_651_2189_2228(this.Size, this.Alignment), _kind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(651, 2111, 2248);

                int
                f_651_2189_2228(int
                newKey, short
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, (int)currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(651, 2189, 2228);
                    return return_v;
                }


                int
                f_651_2176_2236(int
                newKey, byte
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, (int)currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(651, 2176, 2236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(651, 2111, 2248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(651, 2111, 2248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static TypeLayout()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(651, 430, 2255);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(651, 430, 2255);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(651, 430, 2255);
        }

        static int
        f_651_704_763(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(651, 704, 763);
            return 0;
        }


        static int
        f_651_870_910(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(651, 870, 910);
            return 0;
        }

    }
}
