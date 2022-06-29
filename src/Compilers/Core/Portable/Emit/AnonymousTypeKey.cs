// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Emit
{

    internal struct AnonymousTypeKeyField : IEquatable<AnonymousTypeKeyField>
    {

        internal readonly string Name;

        internal readonly bool IsKey;

        internal readonly bool IgnoreCase;

        public AnonymousTypeKeyField(string name, bool isKey, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(283, 1022, 1249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 1117, 1144);

                f_283_1117_1143(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 1160, 1172);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 1186, 1200);

                IsKey = isKey;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 1214, 1238);

                IgnoreCase = ignoreCase;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(283, 1022, 1249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(283, 1022, 1249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 1022, 1249);
            }
        }

        public bool Equals(AnonymousTypeKeyField other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(283, 1261, 1547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 1333, 1536);

                return IsKey == other.IsKey && (DynAbs.Tracing.TraceSender.Expression_True(283, 1340, 1414) && IgnoreCase == other.IgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(283, 1340, 1535) && f_283_1438_1535(((DynAbs.Tracing.TraceSender.Conditional_F1(283, 1439, 1449) || ((IgnoreCase && DynAbs.Tracing.TraceSender.Conditional_F2(283, 1452, 1484)) || DynAbs.Tracing.TraceSender.Conditional_F3(283, 1487, 1509))) ? f_283_1452_1484() : f_283_1487_1509()), Name, other.Name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(283, 1261, 1547);

                System.StringComparer
                f_283_1452_1484()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(283, 1452, 1484);
                    return return_v;
                }


                System.StringComparer
                f_283_1487_1509()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(283, 1487, 1509);
                    return return_v;
                }


                bool
                f_283_1438_1535(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 1438, 1535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(283, 1261, 1547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 1261, 1547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(283, 1559, 1676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 1623, 1665);

                return Equals(obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(283, 1559, 1676);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(283, 1559, 1676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 1559, 1676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(283, 1688, 1942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 1746, 1931);

                return f_283_1753_1930(IsKey, f_283_1793_1929(IgnoreCase, f_283_1838_1928(((DynAbs.Tracing.TraceSender.Conditional_F1(283, 1839, 1849) || ((IgnoreCase && DynAbs.Tracing.TraceSender.Conditional_F2(283, 1852, 1884)) || DynAbs.Tracing.TraceSender.Conditional_F3(283, 1887, 1909))) ? f_283_1852_1884() : f_283_1887_1909()), Name)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(283, 1688, 1942);

                System.StringComparer
                f_283_1852_1884()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(283, 1852, 1884);
                    return return_v;
                }


                System.StringComparer
                f_283_1887_1909()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(283, 1887, 1909);
                    return return_v;
                }


                int
                f_283_1838_1928(System.StringComparer
                this_param, string
                obj)
                {
                    var return_v = this_param.GetHashCode(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 1838, 1928);
                    return return_v;
                }


                int
                f_283_1793_1929(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 1793, 1929);
                    return return_v;
                }


                int
                f_283_1753_1930(bool
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 1753, 1930);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(283, 1688, 1942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 1688, 1942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static AnonymousTypeKeyField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(283, 489, 1949);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(283, 489, 1949);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 489, 1949);
        }

        static int
        f_283_1117_1143(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 1117, 1143);
            return 0;
        }

    }

    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    internal struct AnonymousTypeKey : IEquatable<AnonymousTypeKey>
    {

        internal readonly bool IsDelegate;

        internal readonly ImmutableArray<AnonymousTypeKeyField> Fields;

        internal AnonymousTypeKey(ImmutableArray<AnonymousTypeKeyField> fields, bool isDelegate = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(283, 2209, 2405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 2330, 2359);

                this.IsDelegate = isDelegate;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 2373, 2394);

                this.Fields = fields;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(283, 2209, 2405);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(283, 2209, 2405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 2209, 2405);
            }
        }

        public bool Equals(AnonymousTypeKey other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(283, 2417, 2583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 2484, 2572);

                return (this.IsDelegate == other.IsDelegate) && (DynAbs.Tracing.TraceSender.Expression_True(283, 2491, 2571) && this.Fields.SequenceEqual(other.Fields));
                DynAbs.Tracing.TraceSender.TraceExitMethod(283, 2417, 2583);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(283, 2417, 2583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 2417, 2583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(283, 2595, 2712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 2659, 2701);

                return this.Equals(obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(283, 2595, 2712);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(283, 2595, 2712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 2595, 2712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(283, 2724, 2877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 2782, 2866);

                return f_283_2789_2865(f_283_2802_2831(this.IsDelegate), f_283_2833_2864(this.Fields));
                DynAbs.Tracing.TraceSender.TraceExitMethod(283, 2724, 2877);

                int
                f_283_2802_2831(bool
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 2802, 2831);
                    return return_v;
                }


                int
                f_283_2833_2864(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField>
                values)
                {
                    var return_v = Hash.CombineValues(values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 2833, 2864);
                    return return_v;
                }


                int
                f_283_2789_2865(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 2789, 2865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(283, 2724, 2877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 2724, 2877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetDebuggerDisplay()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(283, 2889, 3362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 2949, 3003);

                var
                pooledBuilder = f_283_2969_3002()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 3017, 3053);

                var
                builder = pooledBuilder.Builder
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 3076, 3081);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 3067, 3298) || true) && (i < this.Fields.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 3107, 3110)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(283, 3067, 3298))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(283, 3067, 3298);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 3144, 3234) || true) && (i > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(283, 3144, 3234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 3195, 3215);

                            f_283_3195_3214(builder, "|");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(283, 3144, 3234);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 3252, 3283);

                        f_283_3252_3282(builder, this.Fields[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(283, 1, 232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(283, 1, 232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(283, 3312, 3351);

                return f_283_3319_3350(pooledBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(283, 2889, 3362);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_283_2969_3002()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 2969, 3002);
                    return return_v;
                }


                System.Text.StringBuilder
                f_283_3195_3214(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 3195, 3214);
                    return return_v;
                }


                System.Text.StringBuilder
                f_283_3252_3282(System.Text.StringBuilder
                this_param, Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 3252, 3282);
                    return return_v;
                }


                string
                f_283_3319_3350(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(283, 3319, 3350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(283, 2889, 3362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 2889, 3362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static AnonymousTypeKey()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(283, 1957, 3369);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(283, 1957, 3369);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(283, 1957, 3369);
        }
    }
}
