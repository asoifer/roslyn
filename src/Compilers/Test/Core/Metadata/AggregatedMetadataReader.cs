// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace Roslyn.Test.MetadataUtilities
{
    public sealed class AggregatedMetadataReader
    {
        private readonly MetadataAggregator _aggregator;

        public readonly MetadataReader Last;

        public ImmutableArray<MetadataReader> Readers { get; }

        public AggregatedMetadataReader(params MetadataReader[] readers)
        : this(f_25101_780_816_C((IEnumerable<MetadataReader>)readers))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25101, 695, 839);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25101, 695, 839);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25101, 695, 839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25101, 695, 839);
            }
        }

        public AggregatedMetadataReader(IEnumerable<MetadataReader> readers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(25101, 851, 1132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25101, 561, 572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25101, 614, 618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25101, 944, 990);

                Readers = f_25101_954_989(readers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25101, 1004, 1026);

                Last = f_25101_1011_1018().Last();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25101, 1040, 1121);

                _aggregator = f_25101_1054_1120(f_25101_1077_1092(readers), f_25101_1094_1119(f_25101_1094_1109(readers, 1)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(25101, 851, 1132);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25101, 851, 1132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25101, 851, 1132);
            }
        }

        private TEntity GetValue<TEntity>(Handle handle, Func<MetadataReader, Handle, TEntity> getter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25101, 1144, 1410);
                int generation = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25101, 1263, 1339);

                var
                genHandle = f_25101_1279_1338(_aggregator, handle, out generation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25101, 1353, 1399);

                return f_25101_1360_1398(getter, f_25101_1367_1374()[generation], genHandle);
                DynAbs.Tracing.TraceSender.TraceExitMethod(25101, 1144, 1410);

                System.Reflection.Metadata.Handle
                f_25101_1279_1338(System.Reflection.Metadata.Ecma335.MetadataAggregator
                this_param, System.Reflection.Metadata.Handle
                handle, out int
                generation)
                {
                    var return_v = this_param.GetGenerationHandle(handle, out generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25101, 1279, 1338);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.MetadataReader>
                f_25101_1367_1374()
                {
                    var return_v = Readers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25101, 1367, 1374);
                    return return_v;
                }


                TEntity
                f_25101_1360_1398(System.Func<System.Reflection.Metadata.MetadataReader, System.Reflection.Metadata.Handle, TEntity>
                this_param, System.Reflection.Metadata.MetadataReader
                arg1, System.Reflection.Metadata.Handle
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(25101, 1360, 1398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25101, 1144, 1410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25101, 1144, 1410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<AssemblyReference> GetAssemblyReferences()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25101, 1484, 1584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25101, 1500, 1584);
                // LAFHIS
                var temp = f_25101_1500_1507();
                return f_25101_1500_1584(ref temp, r => r.AssemblyReferences.Select(h => r.GetAssemblyReference(h))); 
                DynAbs.Tracing.TraceSender.TraceExitMethod(25101, 1484, 1584);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25101, 1484, 1584);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25101, 1484, 1584);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.MetadataReader>
            f_25101_1500_1507()
            {
                var return_v = Readers;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25101, 1500, 1507);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<System.Reflection.Metadata.AssemblyReference>
            f_25101_1500_1584(ref System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.MetadataReader>
            source, System.Func<System.Reflection.Metadata.MetadataReader, System.Collections.Generic.IEnumerable<System.Reflection.Metadata.AssemblyReference>>
            selector)
            {
                var return_v = source.SelectMany<System.Reflection.Metadata.MetadataReader, System.Reflection.Metadata.AssemblyReference>(selector);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25101, 1500, 1584);
                return return_v;
            }

        }

        public string GetString(StringHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(25101, 1642, 1701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(25101, 1645, 1701);
                return f_25101_1645_1701(this, handle, (r, h) => r.GetString((StringHandle)h)); DynAbs.Tracing.TraceSender.TraceExitMethod(25101, 1642, 1701);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(25101, 1642, 1701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25101, 1642, 1701);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_25101_1645_1701(Roslyn.Test.MetadataUtilities.AggregatedMetadataReader
            this_param, System.Reflection.Metadata.StringHandle
            handle, System.Func<System.Reflection.Metadata.MetadataReader, System.Reflection.Metadata.Handle, string>
            getter)
            {
                var return_v = this_param.GetValue<string>((System.Reflection.Metadata.Handle)handle, getter);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(25101, 1645, 1701);
                return return_v;
            }

        }

        static AggregatedMetadataReader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(25101, 464, 1709);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(25101, 464, 1709);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(25101, 464, 1709);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(25101, 464, 1709);

        static System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
        f_25101_780_816_C(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(25101, 695, 839);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.MetadataReader>
        f_25101_954_989(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
        items)
        {
            var return_v = ImmutableArray.CreateRange(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25101, 954, 989);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<System.Reflection.Metadata.MetadataReader>
        f_25101_1011_1018()
        {
            var return_v = Readers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(25101, 1011, 1018);
            return return_v;
        }


        static System.Reflection.Metadata.MetadataReader
        f_25101_1077_1092(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
        source)
        {
            var return_v = source.First<System.Reflection.Metadata.MetadataReader>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25101, 1077, 1092);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
        f_25101_1094_1109(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
        source, int
        count)
        {
            var return_v = source.Skip<System.Reflection.Metadata.MetadataReader>(count);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25101, 1094, 1109);
            return return_v;
        }


        static System.Reflection.Metadata.MetadataReader[]
        f_25101_1094_1119(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.MetadataReader>
        source)
        {
            var return_v = source.ToArray<System.Reflection.Metadata.MetadataReader>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25101, 1094, 1119);
            return return_v;
        }


        static System.Reflection.Metadata.Ecma335.MetadataAggregator
        f_25101_1054_1120(System.Reflection.Metadata.MetadataReader
        baseReader, System.Reflection.Metadata.MetadataReader[]
        deltaReaders)
        {
            var return_v = new System.Reflection.Metadata.Ecma335.MetadataAggregator(baseReader, (System.Collections.Generic.IReadOnlyList<System.Reflection.Metadata.MetadataReader>)deltaReaders);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(25101, 1054, 1120);
            return return_v;
        }

    }
}
