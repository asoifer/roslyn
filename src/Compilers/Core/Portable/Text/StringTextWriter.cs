// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Text
{
    internal class StringTextWriter : SourceTextWriter
    {
        private readonly StringBuilder _builder;

        private readonly Encoding? _encoding;

        private readonly SourceHashAlgorithm _checksumAlgorithm;

        public StringTextWriter(Encoding? encoding, SourceHashAlgorithm checksumAlgorithm, int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(727, 710, 969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 576, 584);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 622, 631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 679, 697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 831, 870);

                _builder = f_727_842_869(capacity);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 884, 905);

                _encoding = encoding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 919, 958);

                _checksumAlgorithm = checksumAlgorithm;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(727, 710, 969);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(727, 710, 969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(727, 710, 969);
            }
        }

        public override Encoding Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(727, 1097, 1123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 1103, 1121);

                    return _encoding!;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(727, 1097, 1123);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(727, 1039, 1134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(727, 1039, 1134);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SourceText ToSourceText()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(727, 1146, 1316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 1212, 1305);

                return f_727_1219_1304(f_727_1234_1253(_builder), _encoding, checksumAlgorithm: _checksumAlgorithm);
                DynAbs.Tracing.TraceSender.TraceExitMethod(727, 1146, 1316);

                string
                f_727_1234_1253(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(727, 1234, 1253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.StringText
                f_727_1219_1304(string
                source, System.Text.Encoding?
                encodingOpt, Microsoft.CodeAnalysis.Text.SourceHashAlgorithm
                checksumAlgorithm)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.StringText(source, encodingOpt, checksumAlgorithm: checksumAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(727, 1219, 1304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(727, 1146, 1316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(727, 1146, 1316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Write(char value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(727, 1328, 1425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 1391, 1414);

                f_727_1391_1413(_builder, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(727, 1328, 1425);

                System.Text.StringBuilder
                f_727_1391_1413(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(727, 1391, 1413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(727, 1328, 1425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(727, 1328, 1425);
            }
        }

        public override void Write(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(727, 1437, 1537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 1503, 1526);

                f_727_1503_1525(_builder, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(727, 1437, 1537);

                System.Text.StringBuilder
                f_727_1503_1525(System.Text.StringBuilder
                this_param, string?
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(727, 1503, 1525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(727, 1437, 1537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(727, 1437, 1537);
            }
        }

        public override void Write(char[] buffer, int index, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(727, 1549, 1686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(727, 1637, 1675);

                f_727_1637_1674(_builder, buffer, index, count);
                DynAbs.Tracing.TraceSender.TraceExitMethod(727, 1549, 1686);

                System.Text.StringBuilder
                f_727_1637_1674(System.Text.StringBuilder
                this_param, char[]
                value, int
                startIndex, int
                charCount)
                {
                    var return_v = this_param.Append(value, startIndex, charCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(727, 1637, 1674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(727, 1549, 1686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(727, 1549, 1686);
            }
        }

        static StringTextWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(727, 478, 1693);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(727, 478, 1693);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(727, 478, 1693);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(727, 478, 1693);

        static System.Text.StringBuilder
        f_727_842_869(int
        capacity)
        {
            var return_v = new System.Text.StringBuilder(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(727, 842, 869);
            return return_v;
        }

    }
}
