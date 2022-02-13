// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CodeAnalysis.CSharp
{
    public sealed class CSharpCommandLineArguments : CommandLineArguments
    {
        public new CSharpCompilationOptions CompilationOptions { get; internal set; }

        public new CSharpParseOptions ParseOptions { get; internal set; }

        protected override ParseOptions ParseOptionsCore
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10970, 1001, 1029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10970, 1007, 1027);

                    return f_10970_1014_1026();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10970, 1001, 1029);

                    Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                    f_10970_1014_1026()
                    {
                        var return_v = ParseOptions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10970, 1014, 1026);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10970, 928, 1040);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10970, 928, 1040);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override CompilationOptions CompilationOptionsCore
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10970, 1137, 1171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10970, 1143, 1169);

                    return f_10970_1150_1168();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10970, 1137, 1171);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10970_1150_1168()
                    {
                        var return_v = CompilationOptions;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10970, 1150, 1168);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10970, 1052, 1182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10970, 1052, 1182);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ShouldIncludeErrorEndLocation { get; set; }

        internal CSharpCommandLineArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10970, 1430, 1633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10970, 641, 718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10970, 851, 916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10970, 1361, 1418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10970, 1560, 1587);

                CompilationOptions = null!;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10970, 1601, 1622);

                ParseOptions = null!;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10970, 1430, 1633);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10970, 1430, 1633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10970, 1430, 1633);
            }
        }

        static CSharpCommandLineArguments()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10970, 369, 1640);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10970, 369, 1640);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10970, 369, 1640);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10970, 369, 1640);
    }
}
