// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis
{
    internal abstract partial class CommonCompiler
    {
        internal sealed class LoggingSourceFileResolver : SourceFileResolver
        {
            private readonly TouchedFileLogger? _logger;

            public LoggingSourceFileResolver(
                            ImmutableArray<string> searchPaths,
                            string? baseDirectory,
                            ImmutableArray<KeyValuePair<string, string>> pathMap,
                            TouchedFileLogger? logger)
            : base(f_130_805_816_C(searchPaths), baseDirectory, pathMap)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(130, 539, 906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(130, 515, 522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(130, 874, 891);

                    _logger = logger;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(130, 539, 906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(130, 539, 906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(130, 539, 906);
                }
            }

            protected override bool FileExists(string? fullPath)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(130, 922, 1183);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(130, 1007, 1115) || true) && (fullPath != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(130, 1007, 1115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(130, 1069, 1096);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_logger, 130, 1069, 1095)?.AddRead(fullPath), 130, 1077, 1095);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(130, 1007, 1115);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(130, 1135, 1168);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.FileExists(fullPath), 130, 1142, 1167);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(130, 922, 1183);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(130, 922, 1183);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(130, 922, 1183);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LoggingSourceFileResolver WithBaseDirectory(string value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(130, 1264, 1385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(130, 1284, 1385);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(130, 1284, 1308) || (((f_130_1285_1298() == value) && DynAbs.Tracing.TraceSender.Conditional_F2(130, 1311, 1315)) || DynAbs.Tracing.TraceSender.Conditional_F3(130, 1318, 1385))) ? this : f_130_1318_1385(f_130_1348_1359(), value, f_130_1368_1375(), _logger); DynAbs.Tracing.TraceSender.TraceExitMethod(130, 1264, 1385);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(130, 1264, 1385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(130, 1264, 1385);
                }
                throw new System.Exception("Slicer error: unreachable code");

                string?
                f_130_1285_1298()
                {
                    var return_v = BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(130, 1285, 1298);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_130_1348_1359()
                {
                    var return_v = SearchPaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(130, 1348, 1359);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                f_130_1368_1375()
                {
                    var return_v = PathMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(130, 1368, 1375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.LoggingSourceFileResolver
                f_130_1318_1385(System.Collections.Immutable.ImmutableArray<string>
                searchPaths, string
                baseDirectory, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                pathMap, Microsoft.CodeAnalysis.TouchedFileLogger?
                logger)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.LoggingSourceFileResolver(searchPaths, baseDirectory, pathMap, logger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(130, 1318, 1385);
                    return return_v;
                }

            }

            public LoggingSourceFileResolver WithSearchPaths(ImmutableArray<string> value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(130, 1481, 1602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(130, 1501, 1602);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(130, 1501, 1523) || (((f_130_1502_1513() == value) && DynAbs.Tracing.TraceSender.Conditional_F2(130, 1526, 1530)) || DynAbs.Tracing.TraceSender.Conditional_F3(130, 1533, 1602))) ? this : f_130_1533_1602(value, f_130_1570_1583(), f_130_1585_1592(), _logger); DynAbs.Tracing.TraceSender.TraceExitMethod(130, 1481, 1602);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(130, 1481, 1602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(130, 1481, 1602);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Collections.Immutable.ImmutableArray<string>
                f_130_1502_1513()
                {
                    var return_v = SearchPaths;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(130, 1502, 1513);
                    return return_v;
                }


                string?
                f_130_1570_1583()
                {
                    var return_v = BaseDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(130, 1570, 1583);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                f_130_1585_1592()
                {
                    var return_v = PathMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(130, 1585, 1592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonCompiler.LoggingSourceFileResolver
                f_130_1533_1602(System.Collections.Immutable.ImmutableArray<string>
                searchPaths, string?
                baseDirectory, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, string>>
                pathMap, Microsoft.CodeAnalysis.TouchedFileLogger?
                logger)
                {
                    var return_v = new Microsoft.CodeAnalysis.CommonCompiler.LoggingSourceFileResolver(searchPaths, baseDirectory, pathMap, logger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(130, 1533, 1602);
                    return return_v;
                }

            }

            static LoggingSourceFileResolver()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(130, 386, 1614);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(130, 386, 1614);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(130, 386, 1614);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(130, 386, 1614);

            static System.Collections.Immutable.ImmutableArray<string>
            f_130_805_816_C(System.Collections.Immutable.ImmutableArray<string>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(130, 539, 906);
                return return_v;
            }

        }
    }
}
