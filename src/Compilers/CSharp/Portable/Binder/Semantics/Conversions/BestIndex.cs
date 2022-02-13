// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp
{
    internal enum BestIndexKind
    {
        None,
        Best,
        Ambiguous
    }

    internal struct BestIndex
    {

        internal readonly BestIndexKind Kind;

        internal readonly int Best;

        internal readonly int Ambiguous1;

        internal readonly int Ambiguous2;

        public static BestIndex None()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10837, 589, 674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10837, 622, 672);

                return f_10837_629_671(BestIndexKind.None, 0, 0, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10837, 589, 674);

                Microsoft.CodeAnalysis.CSharp.BestIndex
                f_10837_629_671(Microsoft.CodeAnalysis.CSharp.BestIndexKind
                kind, int
                best, int
                ambig1, int
                ambig2)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BestIndex(kind, best, ambig1, ambig2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10837, 629, 671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10837, 589, 674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10837, 589, 674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BestIndex HasBest(int best)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10837, 684, 783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10837, 728, 781);

                return f_10837_735_780(BestIndexKind.Best, best, 0, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10837, 684, 783);

                Microsoft.CodeAnalysis.CSharp.BestIndex
                f_10837_735_780(Microsoft.CodeAnalysis.CSharp.BestIndexKind
                kind, int
                best, int
                ambig1, int
                ambig2)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BestIndex(kind, best, ambig1, ambig2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10837, 735, 780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10837, 684, 783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10837, 684, 783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BestIndex IsAmbiguous(int ambig1, int ambig2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10837, 793, 922);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10837, 855, 920);

                return f_10837_862_919(BestIndexKind.Ambiguous, 0, ambig1, ambig2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10837, 793, 922);

                Microsoft.CodeAnalysis.CSharp.BestIndex
                f_10837_862_919(Microsoft.CodeAnalysis.CSharp.BestIndexKind
                kind, int
                best, int
                ambig1, int
                ambig2)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BestIndex(kind, best, ambig1, ambig2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10837, 862, 919);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10837, 793, 922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10837, 793, 922);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BestIndex(BestIndexKind kind, int best, int ambig1, int ambig2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10837, 934, 1167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10837, 1030, 1047);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10837, 1061, 1078);

                this.Best = best;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10837, 1092, 1117);

                this.Ambiguous1 = ambig1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10837, 1131, 1156);

                this.Ambiguous2 = ambig2;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10837, 934, 1167);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10837, 934, 1167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10837, 934, 1167);
            }
        }
        static BestIndex()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10837, 375, 1174);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10837, 375, 1174);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10837, 375, 1174);
        }
    }
}
