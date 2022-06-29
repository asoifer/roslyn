// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis
{
    internal sealed class AdditionalTextFile : AdditionalText
    {
        private readonly CommandLineSourceFile _sourceFile;

        private readonly CommonCompiler _compiler;

        private readonly Lazy<SourceText?> _text;

        private IList<DiagnosticInfo> _diagnostics;

        public AdditionalTextFile(CommandLineSourceFile sourceFile, CommonCompiler compiler)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1, 763, 1212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 637, 646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 692, 697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 738, 750);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 872, 991) || true) && (compiler == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1, 872, 991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 926, 976);

                    throw f_1_932_975(nameof(compiler));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1, 872, 991);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1007, 1032);

                _sourceFile = sourceFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1046, 1067);

                _compiler = compiler;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1081, 1147);

                _diagnostics = f_1_1096_1146();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1161, 1201);

                _text = f_1_1169_1200(ReadText);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1, 763, 1212);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1, 763, 1212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1, 763, 1212);
            }
        }

        private SourceText? ReadText()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1, 1224, 1482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1279, 1324);

                var
                diagnostics = f_1_1297_1323()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1338, 1404);

                var
                text = f_1_1349_1403(_compiler, _sourceFile, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1418, 1445);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1459, 1471);

                return text;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1, 1224, 1482);

                System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_1_1297_1323()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1, 1297, 1323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText?
                f_1_1349_1403(Microsoft.CodeAnalysis.CommonCompiler
                this_param, Microsoft.CodeAnalysis.CommandLineSourceFile
                file, System.Collections.Generic.List<Microsoft.CodeAnalysis.DiagnosticInfo>
                diagnostics)
                {
                    var return_v = this_param.TryReadFileContent(file, (System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1, 1349, 1403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1, 1224, 1482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1, 1224, 1482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Path
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1, 1600, 1619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1603, 1619);
                    return _sourceFile.Path; DynAbs.Tracing.TraceSender.TraceExitMethod(1, 1600, 1619);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1, 1600, 1619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1, 1600, 1619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SourceText? GetText(CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1, 1909, 1923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 1912, 1923);
                return f_1_1912_1923(_text); DynAbs.Tracing.TraceSender.TraceExitMethod(1, 1909, 1923);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1, 1909, 1923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1, 1909, 1923);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Text.SourceText?
            f_1_1912_1923(System.Lazy<Microsoft.CodeAnalysis.Text.SourceText?>
            this_param)
            {
                var return_v = this_param.Value;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1, 1912, 1923);
                return return_v;
            }

        }

        internal IList<DiagnosticInfo> Diagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1, 2190, 2205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1, 2193, 2205);
                    return _diagnostics; DynAbs.Tracing.TraceSender.TraceExitMethod(1, 2190, 2205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1, 2190, 2205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1, 2190, 2205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static AdditionalTextFile()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1, 470, 2213);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1, 470, 2213);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1, 470, 2213);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1, 470, 2213);

        static System.ArgumentNullException
        f_1_932_975(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1, 932, 975);
            return return_v;
        }


        static System.Collections.Generic.IList<Microsoft.CodeAnalysis.DiagnosticInfo>
        f_1_1096_1146()
        {
            var return_v = SpecializedCollections.EmptyList<DiagnosticInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1, 1096, 1146);
            return return_v;
        }


        static System.Lazy<Microsoft.CodeAnalysis.Text.SourceText?>
        f_1_1169_1200(System.Func<Microsoft.CodeAnalysis.Text.SourceText?>
        valueFactory)
        {
            var return_v = new System.Lazy<Microsoft.CodeAnalysis.Text.SourceText?>(valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1, 1169, 1200);
            return return_v;
        }

    }
}
