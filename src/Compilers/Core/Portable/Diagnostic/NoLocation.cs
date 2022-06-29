// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis
{
    internal sealed class NoLocation : Location
    {
        public static readonly Location Singleton;

        private NoLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(197, 559, 601);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(197, 559, 601);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(197, 559, 601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(197, 559, 601);
            }
        }

        public override LocationKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(197, 671, 704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(197, 677, 702);

                    return LocationKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(197, 671, 704);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(197, 613, 715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(197, 613, 715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(197, 727, 830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(197, 792, 819);

                return (object)this == obj;
                DynAbs.Tracing.TraceSender.TraceExitMethod(197, 727, 830);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(197, 727, 830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(197, 727, 830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(197, 842, 996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(197, 967, 985);

                return 0x16487756;
                DynAbs.Tracing.TraceSender.TraceExitMethod(197, 842, 996);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(197, 842, 996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(197, 842, 996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NoLocation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(197, 426, 1003);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(197, 518, 546);
            Singleton = f_197_530_546(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(197, 426, 1003);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(197, 426, 1003);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(197, 426, 1003);

        static Microsoft.CodeAnalysis.NoLocation
        f_197_530_546()
        {
            var return_v = new Microsoft.CodeAnalysis.NoLocation();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(197, 530, 546);
            return return_v;
        }

    }
}
