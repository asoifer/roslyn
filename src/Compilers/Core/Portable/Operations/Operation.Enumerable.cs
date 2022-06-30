// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections;
using System;
using System.Diagnostics;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class Operation : IOperation
    {
        [NonDefaultable]
        internal readonly struct Enumerable : IEnumerable<IOperation>
        {

            private readonly Operation _operation;

            internal Enumerable(Operation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(466, 1135, 1246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 1208, 1231);

                    _operation = operation;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(466, 1135, 1246);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 1135, 1246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 1135, 1246);
                }
            }

            public Enumerator GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(466, 1296, 1325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 1299, 1325);
                    return f_466_1299_1325(_operation); DynAbs.Tracing.TraceSender.TraceExitMethod(466, 1296, 1325);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 1296, 1325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 1296, 1325);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.Operation.Enumerator
                f_466_1299_1325(Microsoft.CodeAnalysis.Operation
                operation)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operation.Enumerator(operation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(466, 1299, 1325);
                    return return_v;
                }

            }

            public ImmutableArray<IOperation> ToImmutableArray()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(466, 1342, 2181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 1427, 2166);

                    switch (_operation)
                    {

                        case NoneOperation { Children: var children }:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(466, 1427, 2166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 1559, 1575);

                            return children;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(466, 1427, 2166);

                        case InvalidOperation { Children: var children }:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(466, 1427, 2166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 1672, 1688);

                            return children;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(466, 1427, 2166);

                        case var _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 1721, 1753) || true) && (!GetEnumerator().MoveNext()) && (DynAbs.Tracing.TraceSender.Expression_True(466, 1721, 1753) || true)
                    :
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(466, 1427, 2166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 1780, 1820);

                            return ImmutableArray<IOperation>.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(466, 1427, 2166);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(466, 1427, 2166);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 1876, 1929);

                            var
                            builder = f_466_1890_1928()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 1955, 2085);
                                foreach (var child in f_466_1977_1981_I(this))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(466, 1955, 2085);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 2039, 2058);

                                    f_466_2039_2057(builder, child);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(466, 1955, 2085);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(466, 1, 131);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(466, 1, 131);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 2111, 2147);

                            return f_466_2118_2146(builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(466, 1427, 2166);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(466, 1342, 2181);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                    f_466_1890_1928()
                    {
                        var return_v = ArrayBuilder<IOperation>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(466, 1890, 1928);
                        return return_v;
                    }


                    int
                    f_466_2039_2057(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                    this_param, Microsoft.CodeAnalysis.IOperation
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(466, 2039, 2057);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Operation.Enumerable
                    f_466_1977_1981_I(Microsoft.CodeAnalysis.Operation.Enumerable
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(466, 1977, 1981);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                    f_466_2118_2146(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IOperation>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(466, 2118, 2146);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 1342, 2181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 1342, 2181);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator<IOperation> IEnumerable<IOperation>.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(466, 2261, 2284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 2264, 2284);
                    return this.GetEnumerator(); DynAbs.Tracing.TraceSender.TraceExitMethod(466, 2261, 2284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 2261, 2284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 2261, 2284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(466, 2339, 2362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 2342, 2362);
                    return this.GetEnumerator(); DynAbs.Tracing.TraceSender.TraceExitMethod(466, 2339, 2362);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 2339, 2362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 2339, 2362);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static Enumerable()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(466, 969, 2374);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(466, 969, 2374);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 969, 2374);
            }
        }

        [NonDefaultable]
        internal struct Enumerator : IEnumerator<IOperation>
        {

            private readonly Operation _operation;

            private int _currentSlot;

            private int _currentIndex;

            public Enumerator(Operation operation)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(466, 3444, 3626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 3515, 3538);

                    _operation = operation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 3556, 3574);

                    _currentSlot = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 3592, 3611);

                    _currentIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(466, 3444, 3626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 3444, 3626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 3444, 3626);
                }
            }

            public IOperation Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(466, 3700, 3919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 3744, 3820);

                        f_466_3744_3819(_operation != null && (DynAbs.Tracing.TraceSender.Expression_True(466, 3757, 3796) && _currentSlot >= 0) && (DynAbs.Tracing.TraceSender.Expression_True(466, 3757, 3818) && _currentIndex >= 0));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 3842, 3900);

                        return f_466_3849_3899(_operation, _currentSlot, _currentIndex);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(466, 3700, 3919);

                        int
                        f_466_3744_3819(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(466, 3744, 3819);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.IOperation
                        f_466_3849_3899(Microsoft.CodeAnalysis.Operation
                        this_param, int
                        slot, int
                        index)
                        {
                            var return_v = this_param.GetCurrent(slot, index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(466, 3849, 3899);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 3642, 3934);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 3642, 3934);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(466, 3950, 4171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 4005, 4017);

                    bool
                    result
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 4035, 4124);

                    (result, _currentSlot, _currentIndex) = f_466_4075_4123(_operation, _currentSlot, _currentIndex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 4142, 4156);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(466, 3950, 4171);

                    (bool hasNext, int nextSlot, int nextIndex)
                    f_466_4075_4123(Microsoft.CodeAnalysis.Operation
                    this_param, int
                    previousSlot, int
                    previousIndex)
                    {
                        var return_v = this_param.MoveNext(previousSlot, previousIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(466, 4075, 4123);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 3950, 4171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 3950, 4171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            void IEnumerator.Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(466, 4187, 4314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 4244, 4262);

                    _currentSlot = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 4280, 4299);

                    _currentIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(466, 4187, 4314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 4187, 4314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 4187, 4314);
                }
            }

            object? IEnumerator.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(466, 4358, 4373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(466, 4361, 4373);
                        return this.Current; DynAbs.Tracing.TraceSender.TraceExitMethod(466, 4358, 4373);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 4358, 4373);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 4358, 4373);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            void IDisposable.Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(466, 4388, 4418);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(466, 4388, 4418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(466, 4388, 4418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 4388, 4418);
                }
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(466, 3208, 4429);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(466, 3208, 4429);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(466, 3208, 4429);
            }
        }
    }
}
