// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{

    internal struct LocalDebugId : IEquatable<LocalDebugId>
    {

        public readonly int SyntaxOffset;

        public readonly int Ordinal;

        public static readonly LocalDebugId None;

        private LocalDebugId(bool isNone)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(66, 2586, 2747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 2644, 2665);

                f_66_2644_2664(isNone);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 2681, 2704);

                this.SyntaxOffset = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 2718, 2736);

                this.Ordinal = -1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(66, 2586, 2747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(66, 2586, 2747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(66, 2586, 2747);
            }
        }

        public LocalDebugId(int syntaxOffset, int ordinal = 0)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(66, 2759, 2962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 2838, 2865);

                f_66_2838_2864(ordinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 2881, 2914);

                this.SyntaxOffset = syntaxOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 2928, 2951);

                this.Ordinal = ordinal;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(66, 2759, 2962);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(66, 2759, 2962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(66, 2759, 2962);
            }
        }

        public bool IsNone
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(66, 3017, 3089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 3053, 3074);

                    return Ordinal == -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(66, 3017, 3089);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(66, 2974, 3100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(66, 2974, 3100);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool Equals(LocalDebugId other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(66, 3112, 3273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 3175, 3262);

                return SyntaxOffset == other.SyntaxOffset
                && (DynAbs.Tracing.TraceSender.Expression_True(66, 3182, 3261) && Ordinal == other.Ordinal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(66, 3112, 3273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(66, 3112, 3273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(66, 3112, 3273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(66, 3285, 3397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 3343, 3386);

                return f_66_3350_3385(SyntaxOffset, Ordinal);
                DynAbs.Tracing.TraceSender.TraceExitMethod(66, 3285, 3397);

                int
                f_66_3350_3385(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(66, 3350, 3385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(66, 3285, 3397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(66, 3285, 3397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(66, 3409, 3541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 3474, 3530);

                return obj is LocalDebugId && (DynAbs.Tracing.TraceSender.Expression_True(66, 3481, 3529) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(66, 3409, 3541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(66, 3409, 3541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(66, 3409, 3541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(66, 3553, 3658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 3611, 3647);

                // LAFHIS
                // return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (SyntaxOffset).ToString(), 66, 3618, 3630) + ":" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (Ordinal).ToString(), 66, 3639, 3646);

                var temp1 = (SyntaxOffset).ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(66, 3618, 3630);

                var temp2 = (Ordinal).ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(66, 3639, 3646);

                return temp1 + ":" + temp2;

                DynAbs.Tracing.TraceSender.TraceExitMethod(66, 3553, 3658);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(66, 3553, 3658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(66, 3553, 3658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static LocalDebugId()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(66, 640, 3665);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(66, 2536, 2573);
            None = f_66_2543_2573(isNone: true); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(66, 640, 3665);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(66, 640, 3665);
        }

        static Microsoft.CodeAnalysis.CodeGen.LocalDebugId
        f_66_2543_2573(bool
        isNone)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalDebugId(isNone: isNone);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(66, 2543, 2573);
            return return_v;
        }


        static int
        f_66_2644_2664(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(66, 2644, 2664);
            return 0;
        }


        static int
        f_66_2838_2864(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(66, 2838, 2864);
            return 0;
        }

    }
}
