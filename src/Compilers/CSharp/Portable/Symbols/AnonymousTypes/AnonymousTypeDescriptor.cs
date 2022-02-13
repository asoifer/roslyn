// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{

    internal readonly struct AnonymousTypeDescriptor : IEquatable<AnonymousTypeDescriptor>
    {

        public readonly Location Location;

        public readonly ImmutableArray<AnonymousTypeField> Fields;

        public readonly string Key;

        public AnonymousTypeDescriptor(ImmutableArray<AnonymousTypeField> fields, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10416, 1284, 1529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 1401, 1422);

                this.Fields = fields;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 1436, 1461);

                this.Location = location;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 1475, 1518);

                this.Key = ComputeKey(fields, f => f.Name);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10416, 1284, 1529);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10416, 1284, 1529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10416, 1284, 1529);
            }
        }

        internal static string ComputeKey<T>(ImmutableArray<T> fields, Func<T, string> getName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10416, 1541, 1919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 1653, 1697);

                var
                key = f_10416_1663_1696<T>()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 1711, 1865);
                    foreach (var field in f_10416_1733_1739_I<T>(fields))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10416, 1711, 1865);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 1773, 1797);

                        f_10416_1773_1796<T>(key.Builder, '|');
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 1815, 1850);

                        f_10416_1815_1849<T>(key.Builder, f_10416_1834_1848<T>(getName, field));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10416, 1711, 1865);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10416, 1, 155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10416, 1, 155);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 1879, 1908);

                return f_10416_1886_1907<T>(key);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10416, 1541, 1919);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10416_1663_1696<T>()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 1663, 1696);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10416_1773_1796<T>(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 1773, 1796);
                    return return_v;
                }


                string
                f_10416_1834_1848<T>(System.Func<T, string>
                this_param, T
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 1834, 1848);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10416_1815_1849<T>(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 1815, 1849);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<T>
                f_10416_1733_1739_I<T>(System.Collections.Immutable.ImmutableArray<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 1733, 1739);
                    return return_v;
                }


                string
                f_10416_1886_1907<T>(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 1886, 1907);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10416, 1541, 1919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10416, 1541, 1919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        internal void AssertIsGood()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10416, 1931, 2183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 2016, 2053);

                f_10416_2016_2052(f_10416_2029_2051_M(!this.Fields.IsDefault));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 2069, 2172);
                    foreach (var field in f_10416_2091_2102_I(this.Fields))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10416, 2069, 2172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 2136, 2157);

                        field.AssertIsGood();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10416, 2069, 2172);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10416, 1, 104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10416, 1, 104);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10416, 1931, 2183);

                bool
                f_10416_2029_2051_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10416, 2029, 2051);
                    return return_v;
                }


                int
                f_10416_2016_2052(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 2016, 2052);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField>
                f_10416_2091_2102_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 2091, 2102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10416, 1931, 2183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10416, 1931, 2183);
            }
        }

        public bool Equals(AnonymousTypeDescriptor desc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10416, 2195, 2340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 2268, 2329);

                return this.Equals(desc, TypeCompareKind.ConsiderEverything);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10416, 2195, 2340);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10416, 2195, 2340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10416, 2195, 2340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Equals(AnonymousTypeDescriptor other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10416, 2511, 3307);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 2695, 2782) || true) && (this.Key != other.Key)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10416, 2695, 2782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 2754, 2767);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10416, 2695, 2782);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 2834, 2892);

                ImmutableArray<AnonymousTypeField>
                myFields = this.Fields
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 2906, 2934);

                int
                count = myFields.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 2948, 3010);

                ImmutableArray<AnonymousTypeField>
                otherFields = other.Fields
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 3033, 3038);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 3024, 3268) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 3051, 3054)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10416, 3024, 3268))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10416, 3024, 3268);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 3088, 3253) || true) && (!myFields[i].TypeWithAnnotations.Equals(otherFields[i].TypeWithAnnotations, comparison))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10416, 3088, 3253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 3221, 3234);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10416, 3088, 3253);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10416, 1, 245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10416, 1, 245);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 3284, 3296);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10416, 2511, 3307);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10416, 2511, 3307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10416, 2511, 3307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10416, 3478, 3672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 3542, 3661);

                return obj is AnonymousTypeDescriptor && (DynAbs.Tracing.TraceSender.Expression_True(10416, 3549, 3660) && 
                    this.Equals((AnonymousTypeDescriptor)obj, TypeCompareKind.ConsiderEverything));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10416, 3478, 3672);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10416, 3478, 3672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10416, 3478, 3672);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10416, 3684, 3783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 3742, 3772);

                return f_10416_3749_3771(this.Key);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10416, 3684, 3783);

                int
                f_10416_3749_3771(string
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 3749, 3771);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10416, 3684, 3783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10416, 3684, 3783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AnonymousTypeDescriptor WithNewFieldsTypes(ImmutableArray<TypeWithAnnotations> newFieldTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10416, 3976, 4455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 4103, 4142);

                f_10416_4103_4141(f_10416_4116_4140_M(!newFieldTypes.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 4156, 4213);

                f_10416_4156_4212(newFieldTypes.Length == this.Fields.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 4229, 4369);

                var
                newFields = this.Fields.SelectAsArray((field, i, types) => new AnonymousTypeField(field.Name, field.Location, types[i]), newFieldTypes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10416, 4383, 4444);

                return f_10416_4390_4443(newFields, this.Location);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10416, 3976, 4455);

                bool
                f_10416_4116_4140_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10416, 4116, 4140);
                    return return_v;
                }


                int
                f_10416_4103_4141(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 4103, 4141);
                    return 0;
                }


                int
                f_10416_4156_4212(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 4156, 4212);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor
                f_10416_4390_4443(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField>
                fields, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeDescriptor(fields, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10416, 4390, 4443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10416, 3976, 4455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10416, 3976, 4455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static AnonymousTypeDescriptor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10416, 503, 4462);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10416, 503, 4462);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10416, 503, 4462);
        }
    }
}
