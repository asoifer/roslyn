// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace Microsoft.Cci
{

    internal struct LocalScope
    {

        public readonly int StartOffset;

        public readonly int EndOffset;

        private readonly ImmutableArray<ILocalDefinition> _constants;

        private readonly ImmutableArray<ILocalDefinition> _locals;

        internal LocalScope(int offset, int endOffset, ImmutableArray<ILocalDefinition> constants, ImmutableArray<ILocalDefinition> locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(494, 986, 1494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1142, 1189);

                f_494_1142_1188(!locals.Any(l => l.Name == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1203, 1253);

                f_494_1203_1252(!constants.Any(c => c.Name == null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1267, 1293);

                f_494_1267_1292(offset >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1307, 1340);

                f_494_1307_1339(endOffset > offset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1356, 1377);

                StartOffset = offset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1391, 1413);

                EndOffset = endOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1429, 1452);

                _constants = constants;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1466, 1483);

                _locals = locals;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(494, 986, 1494);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(494, 986, 1494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(494, 986, 1494);
            }
        }

        public int Length
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(494, 1524, 1550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1527, 1550);
                    return EndOffset - StartOffset; DynAbs.Tracing.TraceSender.TraceExitMethod(494, 1524, 1550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(494, 1524, 1550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(494, 1524, 1550);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ILocalDefinition> Constants
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(494, 1756, 1783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1759, 1783);
                    return _constants.NullToEmpty(); DynAbs.Tracing.TraceSender.TraceExitMethod(494, 1756, 1783);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(494, 1756, 1783);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(494, 1756, 1783);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ILocalDefinition> Variables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(494, 1989, 2013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(494, 1992, 2013);
                    return _locals.NullToEmpty(); DynAbs.Tracing.TraceSender.TraceExitMethod(494, 1989, 2013);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(494, 1989, 2013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(494, 1989, 2013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        static LocalScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(494, 465, 2021);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(494, 465, 2021);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(494, 465, 2021);
        }

        static int
        f_494_1142_1188(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(494, 1142, 1188);
            return 0;
        }


        static int
        f_494_1203_1252(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(494, 1203, 1252);
            return 0;
        }


        static int
        f_494_1267_1292(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(494, 1267, 1292);
            return 0;
        }


        static int
        f_494_1307_1339(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(494, 1307, 1339);
            return 0;
        }

    }
}
