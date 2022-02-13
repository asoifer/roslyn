// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct UnaryOperatorAnalysisResult
    {

        public readonly UnaryOperatorSignature Signature;

        public readonly Conversion Conversion;

        public readonly OperatorAnalysisResultKind Kind;

        private UnaryOperatorAnalysisResult(OperatorAnalysisResultKind kind, UnaryOperatorSignature signature, Conversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10860, 633, 895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10860, 783, 800);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10860, 814, 841);

                this.Signature = signature;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10860, 855, 884);

                this.Conversion = conversion;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10860, 633, 895);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10860, 633, 895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10860, 633, 895);
            }
        }

        public bool IsValid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10860, 951, 1017);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10860, 957, 1015);

                    return this.Kind == OperatorAnalysisResultKind.Applicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10860, 951, 1017);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10860, 907, 1028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10860, 907, 1028);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10860, 1085, 1150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10860, 1091, 1148);

                    return this.Kind != OperatorAnalysisResultKind.Undefined;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10860, 1085, 1150);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10860, 1040, 1161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10860, 1040, 1161);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public static UnaryOperatorAnalysisResult Applicable(UnaryOperatorSignature signature, Conversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10860, 1173, 1419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10860, 1307, 1408);

                return f_10860_1314_1407(OperatorAnalysisResultKind.Applicable, signature, conversion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10860, 1173, 1419);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult
                f_10860_1314_1407(Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                kind, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                signature, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult(kind, signature, conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10860, 1314, 1407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10860, 1173, 1419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10860, 1173, 1419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static UnaryOperatorAnalysisResult Inapplicable(UnaryOperatorSignature signature, Conversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10860, 1431, 1681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10860, 1567, 1670);

                return f_10860_1574_1669(OperatorAnalysisResultKind.Inapplicable, signature, conversion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10860, 1431, 1681);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult
                f_10860_1574_1669(Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                kind, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                signature, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult(kind, signature, conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10860, 1574, 1669);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10860, 1431, 1681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10860, 1431, 1681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public UnaryOperatorAnalysisResult Worse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10860, 1693, 1877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10860, 1760, 1866);

                return f_10860_1767_1865(OperatorAnalysisResultKind.Worse, this.Signature, this.Conversion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10860, 1693, 1877);

                Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult
                f_10860_1767_1865(Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                kind, Microsoft.CodeAnalysis.CSharp.UnaryOperatorSignature
                signature, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnaryOperatorAnalysisResult(kind, signature, conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10860, 1767, 1865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10860, 1693, 1877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10860, 1693, 1877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static UnaryOperatorAnalysisResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10860, 406, 1884);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10860, 406, 1884);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10860, 406, 1884);
        }
    }
}
