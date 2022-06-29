// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public sealed class UnresolvedAnalyzerReference : AnalyzerReference
    {
        private readonly string _unresolvedPath;

        public UnresolvedAnalyzerReference(string unresolvedPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(276, 679, 952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(276, 651, 666);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(276, 761, 892) || true) && (unresolvedPath == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(276, 761, 892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(276, 821, 877);

                    throw f_276_827_876(nameof(unresolvedPath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(276, 761, 892);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(276, 908, 941);

                _unresolvedPath = unresolvedPath;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(276, 679, 952);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(276, 679, 952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(276, 679, 952);
            }
        }

        public override string Display
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(276, 1019, 1121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(276, 1055, 1106);

                    return f_276_1062_1094() + f_276_1097_1105();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(276, 1019, 1121);

                    string
                    f_276_1062_1094()
                    {
                        var return_v = CodeAnalysisResources.Unresolved;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(276, 1062, 1094);
                        return return_v;
                    }


                    string
                    f_276_1097_1105()
                    {
                        var return_v = FullPath;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(276, 1097, 1105);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(276, 964, 1132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(276, 964, 1132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string FullPath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(276, 1200, 1274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(276, 1236, 1259);

                    return _unresolvedPath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(276, 1200, 1274);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(276, 1144, 1285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(276, 1144, 1285);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Id
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(276, 1347, 1421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(276, 1383, 1406);

                    return _unresolvedPath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(276, 1347, 1421);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(276, 1297, 1432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(276, 1297, 1432);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzersForAllLanguages()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(276, 1444, 1608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(276, 1549, 1597);

                return ImmutableArray<DiagnosticAnalyzer>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(276, 1444, 1608);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(276, 1444, 1608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(276, 1444, 1608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<DiagnosticAnalyzer> GetAnalyzers(string language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(276, 1620, 1784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(276, 1725, 1773);

                return ImmutableArray<DiagnosticAnalyzer>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(276, 1620, 1784);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(276, 1620, 1784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(276, 1620, 1784);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UnresolvedAnalyzerReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(276, 543, 1791);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(276, 543, 1791);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(276, 543, 1791);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(276, 543, 1791);

        static System.ArgumentNullException
        f_276_827_876(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(276, 827, 876);
            return return_v;
        }

    }
}
