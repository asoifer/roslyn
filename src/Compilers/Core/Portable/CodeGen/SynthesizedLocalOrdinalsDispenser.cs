// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class SynthesizedLocalOrdinalsDispenser
    {
        private PooledDictionary<long, int>? _lazyMap;

        private static long MakeKey(SynthesizedLocalKind localKind, int syntaxOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(87, 729, 891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 831, 880);

                return (long)syntaxOffset << 8 | (long)localKind;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(87, 729, 891);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(87, 729, 891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(87, 729, 891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(87, 903, 1076);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 946, 1065) || true) && (_lazyMap != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(87, 946, 1065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 1000, 1016);

                    f_87_1000_1015(_lazyMap);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 1034, 1050);

                    _lazyMap = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(87, 946, 1065);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(87, 903, 1076);

                int
                f_87_1000_1015(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<long, int>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(87, 1000, 1015);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(87, 903, 1076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(87, 903, 1076);
            }
        }

        public int AssignLocalOrdinal(SynthesizedLocalKind localKind, int syntaxOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(87, 1088, 2190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 1502, 1514);

                int
                ordinal
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 1528, 1572);

                long
                key = f_87_1539_1571(localKind, syntaxOffset)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 1741, 2016) || true) && (_lazyMap == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(87, 1741, 2016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 1795, 1848);

                    _lazyMap = f_87_1806_1847();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 1866, 1878);

                    ordinal = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(87, 1741, 2016);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(87, 1741, 2016);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 1912, 2016) || true) && (!f_87_1917_1955(_lazyMap, key, out ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(87, 1912, 2016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 1989, 2001);

                        ordinal = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(87, 1912, 2016);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(87, 1741, 2016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 2032, 2060);

                _lazyMap[key] = ordinal + 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 2074, 2150);

                f_87_2074_2149(ordinal == 0 || (DynAbs.Tracing.TraceSender.Expression_False(87, 2087, 2148) || localKind != SynthesizedLocalKind.UserDefined));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 2164, 2179);

                return ordinal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(87, 1088, 2190);

                long
                f_87_1539_1571(Microsoft.CodeAnalysis.SynthesizedLocalKind
                localKind, int
                syntaxOffset)
                {
                    var return_v = MakeKey(localKind, syntaxOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(87, 1539, 1571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<long, int>
                f_87_1806_1847()
                {
                    var return_v = PooledDictionary<long, int>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(87, 1806, 1847);
                    return return_v;
                }


                bool
                f_87_1917_1955(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<long, int>
                this_param, long
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(87, 1917, 1955);
                    return return_v;
                }


                int
                f_87_2074_2149(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(87, 2074, 2149);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(87, 1088, 2190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(87, 1088, 2190);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SynthesizedLocalOrdinalsDispenser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(87, 525, 2197);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(87, 708, 716);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(87, 525, 2197);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(87, 525, 2197);
        }


        static SynthesizedLocalOrdinalsDispenser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(87, 525, 2197);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(87, 525, 2197);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(87, 525, 2197);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(87, 525, 2197);
    }
}
