// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;

namespace Roslyn.Utilities
{

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal readonly struct EnumField
    {

        public static readonly IComparer<EnumField> Comparer;

        public readonly string Name;

        public readonly ulong Value;

        public readonly object? IdentityOpt;

        public EnumField(string name, ulong value, object? identityOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(325, 702, 950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 797, 830);

                f_325_797_829(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 844, 861);

                this.Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 875, 894);

                this.Value = value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 908, 939);

                this.IdentityOpt = identityOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(325, 702, 950);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(325, 702, 950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(325, 702, 950);
            }
        }

        public bool IsDefault
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(325, 1008, 1041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1014, 1039);

                    return this.Name == null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(325, 1008, 1041);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(325, 962, 1052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(325, 962, 1052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(325, 1064, 1196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1124, 1185);

                return f_325_1131_1184("{{{0} = {1}}}", this.Name, this.Value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(325, 1064, 1196);

                string
                f_325_1131_1184(string
                format, string
                arg0, ulong
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(325, 1131, 1184);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(325, 1064, 1196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(325, 1064, 1196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static EnumField FindValue(ArrayBuilder<EnumField> sortedFields, ulong value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(325, 1208, 2192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1319, 1333);

                int
                start = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1347, 1376);

                int
                end = f_325_1357_1375(sortedFields)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1392, 2139) || true) && (start < end)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(325, 1392, 2139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1444, 1480);

                        int
                        mid = start + (end - start) / 2
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1500, 1567);

                        long
                        diff = unchecked((long)value - (long)sortedFields[mid].Value)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1629, 2124) || true) && (diff == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(325, 1629, 2124);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1684, 1818) || true) && (mid >= start && (DynAbs.Tracing.TraceSender.Expression_True(325, 1691, 1739) && sortedFields[mid].Value == value))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(325, 1684, 1818);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1789, 1795);

                                    mid--;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(325, 1684, 1818);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(325, 1684, 1818);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(325, 1684, 1818);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1840, 1869);

                            return f_325_1847_1868(sortedFields, mid + 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(325, 1629, 2124);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(325, 1629, 2124);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1911, 2124) || true) && (diff > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(325, 1911, 2124);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 1965, 1975);

                                end = mid;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(325, 1911, 2124);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(325, 1911, 2124);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 2073, 2089);

                                start = mid + 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(325, 1911, 2124);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(325, 1629, 2124);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(325, 1392, 2139);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(325, 1392, 2139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(325, 1392, 2139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 2155, 2181);

                return default(EnumField);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(325, 1208, 2192);

                int
                f_325_1357_1375(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(325, 1357, 1375);
                    return return_v;
                }


                Roslyn.Utilities.EnumField
                f_325_1847_1868(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Roslyn.Utilities.EnumField>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(325, 1847, 1868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(325, 1208, 2192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(325, 1208, 2192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class EnumFieldComparer : IComparer<EnumField>
        {
            int IComparer<EnumField>.Compare(EnumField field1, EnumField field2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(325, 2283, 2679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 2457, 2530);

                    int
                    diff = unchecked(f_325_2478_2528(((long)field2.Value), field1.Value))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 2548, 2664);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(325, 2555, 2564) || ((diff == 0
                    && DynAbs.Tracing.TraceSender.Conditional_F2(325, 2588, 2635)) || DynAbs.Tracing.TraceSender.Conditional_F3(325, 2659, 2663))) ? f_325_2588_2635(field1.Name, field2.Name) : diff;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(325, 2283, 2679);

                    int
                    f_325_2478_2528(long
                    this_param, ulong
                    value)
                    {
                        var return_v = this_param.CompareTo((long)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(325, 2478, 2528);
                        return return_v;
                    }


                    int
                    f_325_2588_2635(string
                    strA, string
                    strB)
                    {
                        var return_v = string.CompareOrdinal(strA, strB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(325, 2588, 2635);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(325, 2283, 2679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(325, 2283, 2679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EnumFieldComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(325, 2204, 2690);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(325, 2204, 2690);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(325, 2204, 2690);
            }


            static EnumFieldComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(325, 2204, 2690);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(325, 2204, 2690);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(325, 2204, 2690);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(325, 2204, 2690);
        }
        static EnumField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(325, 383, 2697);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(325, 531, 565);
            Comparer = f_325_542_565(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(325, 383, 2697);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(325, 383, 2697);
        }

        static Roslyn.Utilities.EnumField.EnumFieldComparer
        f_325_542_565()
        {
            var return_v = new Roslyn.Utilities.EnumField.EnumFieldComparer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(325, 542, 565);
            return return_v;
        }


        static int
        f_325_797_829(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(325, 797, 829);
            return 0;
        }

    }
}
