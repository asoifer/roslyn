// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics.CodeAnalysis;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{

    [SuppressMessage("Performance", "CA1067", Justification = "Equality not actually implemented")]
    internal struct BinaryOperatorAnalysisResult
    {

        public readonly Conversion LeftConversion;

        public readonly Conversion RightConversion;

        public readonly BinaryOperatorSignature Signature;

        public readonly OperatorAnalysisResultKind Kind;

        private BinaryOperatorAnalysisResult(OperatorAnalysisResultKind kind, BinaryOperatorSignature signature, Conversion leftConversion, Conversion rightConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10851, 731, 1088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 915, 932);

                this.Kind = kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 946, 973);

                this.Signature = signature;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 987, 1024);

                this.LeftConversion = leftConversion;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 1038, 1077);

                this.RightConversion = rightConversion;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10851, 731, 1088);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10851, 731, 1088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10851, 731, 1088);
            }
        }

        public bool IsValid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10851, 1144, 1210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 1150, 1208);

                    return this.Kind == OperatorAnalysisResultKind.Applicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10851, 1144, 1210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10851, 1100, 1221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10851, 1100, 1221);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10851, 1278, 1343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 1284, 1341);

                    return this.Kind != OperatorAnalysisResultKind.Undefined;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10851, 1278, 1343);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10851, 1233, 1354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10851, 1233, 1354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10851, 1366, 1514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 1466, 1503);

                throw f_10851_1472_1502();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10851, 1366, 1514);

                System.Exception
                f_10851_1472_1502()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10851, 1472, 1502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10851, 1366, 1514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10851, 1366, 1514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10851, 1526, 1668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 1620, 1657);

                throw f_10851_1626_1656();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10851, 1526, 1668);

                System.Exception
                f_10851_1626_1656()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10851, 1626, 1656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10851, 1526, 1668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10851, 1526, 1668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorAnalysisResult Applicable(BinaryOperatorSignature signature, Conversion leftConversion, Conversion rightConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10851, 1680, 1982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 1848, 1971);

                return f_10851_1855_1970(OperatorAnalysisResultKind.Applicable, signature, leftConversion, rightConversion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10851, 1680, 1982);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult
                f_10851_1855_1970(Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                kind, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                signature, Microsoft.CodeAnalysis.CSharp.Conversion
                leftConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                rightConversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult(kind, signature, leftConversion, rightConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10851, 1855, 1970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10851, 1680, 1982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10851, 1680, 1982);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BinaryOperatorAnalysisResult Inapplicable(BinaryOperatorSignature signature, Conversion leftConversion, Conversion rightConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10851, 1994, 2300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 2164, 2289);

                return f_10851_2171_2288(OperatorAnalysisResultKind.Inapplicable, signature, leftConversion, rightConversion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10851, 1994, 2300);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult
                f_10851_2171_2288(Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                kind, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                signature, Microsoft.CodeAnalysis.CSharp.Conversion
                leftConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                rightConversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult(kind, signature, leftConversion, rightConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10851, 2171, 2288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10851, 1994, 2300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10851, 1994, 2300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BinaryOperatorAnalysisResult Worse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10851, 2312, 2524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10851, 2380, 2513);

                return f_10851_2387_2512(OperatorAnalysisResultKind.Worse, this.Signature, this.LeftConversion, this.RightConversion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10851, 2312, 2524);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult
                f_10851_2387_2512(Microsoft.CodeAnalysis.CSharp.OperatorAnalysisResultKind
                kind, Microsoft.CodeAnalysis.CSharp.BinaryOperatorSignature
                signature, Microsoft.CodeAnalysis.CSharp.Conversion
                leftConversion, Microsoft.CodeAnalysis.CSharp.Conversion
                rightConversion)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BinaryOperatorAnalysisResult(kind, signature, leftConversion, rightConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10851, 2387, 2512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10851, 2312, 2524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10851, 2312, 2524);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static BinaryOperatorAnalysisResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10851, 344, 2531);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10851, 344, 2531);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10851, 344, 2531);
        }
    }
}
