// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{

    public readonly struct Optional<T>
    {

        private readonly bool _hasValue;

        private readonly T _value;

        public Optional(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(24, 813, 919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24, 862, 879);

                _hasValue = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24, 893, 908);

                _value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(24, 813, 919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24, 813, 919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24, 813, 919);
            }
        }

        public bool HasValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24, 1159, 1184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24, 1165, 1182);

                    return _hasValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24, 1159, 1184);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24, 1114, 1195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24, 1114, 1195);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public T Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(24, 1859, 1881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(24, 1865, 1879);

                    return _value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(24, 1859, 1881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24, 1820, 1892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24, 1820, 1892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Creates a new object initialized to a meaningful value. 
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator Optional<T>(T value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(24, 2063, 2181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24, 2140, 2170);

                return f_24_2147_2169(value);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(24, 2063, 2181);

                Microsoft.CodeAnalysis.Optional<T>
                f_24_2147_2169(T?
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.Optional<T>(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24, 2147, 2169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24, 2063, 2181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24, 2063, 2181);
            }
        }
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(24, 2301, 2564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(24, 2455, 2553);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(24, 2462, 2471) || ((_hasValue
                && DynAbs.Tracing.TraceSender.Conditional_F2(24, 2491, 2519)) || DynAbs.Tracing.TraceSender.Conditional_F3(24, 2539, 2552))) ? f_24_2491_2509_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_value, 24, 2491, 2509)?.ToString()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(24, 2491, 2519) ?? "null"
                ) : "unspecified";
                DynAbs.Tracing.TraceSender.TraceExitMethod(24, 2301, 2564);

                string?
                f_24_2491_2509_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(24, 2491, 2509);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(24, 2301, 2564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24, 2301, 2564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static Optional()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(24, 515, 2571);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(24, 515, 2571);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(24, 515, 2571);
        }
    }
}
