// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    public abstract class DiagnosticAnalyzer
    {
        public abstract ImmutableArray<DiagnosticDescriptor> SupportedDiagnostics { get; }

        public abstract void Initialize(AnalysisContext context);

        public sealed override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(258, 964, 1075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(258, 1036, 1064);

                return (object?)this == obj;
                DynAbs.Tracing.TraceSender.TraceExitMethod(258, 964, 1075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(258, 964, 1075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(258, 964, 1075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(258, 1087, 1214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(258, 1152, 1203);

                return f_258_1159_1202(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(258, 1087, 1214);

                int
                f_258_1159_1202(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                a)
                {
                    var return_v = ReferenceEqualityComparer.GetHashCode((object)a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(258, 1159, 1202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(258, 1087, 1214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(258, 1087, 1214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(258, 1226, 1335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(258, 1291, 1324);

                return f_258_1298_1323(f_258_1298_1312(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(258, 1226, 1335);

                System.Type
                f_258_1298_1312(Microsoft.CodeAnalysis.Diagnostics.DiagnosticAnalyzer
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(258, 1298, 1312);
                    return return_v;
                }


                string
                f_258_1298_1323(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(258, 1298, 1323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(258, 1226, 1335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(258, 1226, 1335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DiagnosticAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(258, 413, 1342);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(258, 413, 1342);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(258, 413, 1342);
        }


        static DiagnosticAnalyzer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(258, 413, 1342);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(258, 413, 1342);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(258, 413, 1342);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(258, 413, 1342);
    }
}
