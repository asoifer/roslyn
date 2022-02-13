// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Globalization;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class XmlSyntaxDiagnosticInfo : SyntaxDiagnosticInfo
    {
        static XmlSyntaxDiagnosticInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10619, 433, 603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 490, 592);

                f_10619_490_591(typeof(XmlSyntaxDiagnosticInfo), r => new XmlSyntaxDiagnosticInfo(r));
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10619, 433, 603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10619, 433, 603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10619, 433, 603);
            }
        }

        private readonly XmlParseErrorCode _xmlErrorCode;

        internal XmlSyntaxDiagnosticInfo(XmlParseErrorCode code, params object[] args)
        : this(f_10619_775_776_C(0), 0, code, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10619, 676, 814);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10619, 676, 814);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10619, 676, 814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10619, 676, 814);
            }
        }

        internal XmlSyntaxDiagnosticInfo(int offset, int width, XmlParseErrorCode code, params object[] args)
        : base(f_10619_948_954_C(offset), width, ErrorCode.WRN_XMLParseError, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10619, 826, 1054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 650, 663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1022, 1043);

                _xmlErrorCode = code;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10619, 826, 1054);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10619, 826, 1054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10619, 826, 1054);
            }
        }

        protected override void WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10619, 1099, 1262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1176, 1197);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10619, 1176, 1196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1211, 1251);

                f_10619_1211_1250(writer, _xmlErrorCode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10619, 1099, 1262);

                int
                f_10619_1211_1250(Roslyn.Utilities.ObjectWriter
                this_param, Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                value)
                {
                    this_param.WriteUInt32((uint)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 1211, 1250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10619, 1099, 1262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10619, 1099, 1262);
            }
        }

        private XmlSyntaxDiagnosticInfo(ObjectReader reader)
        : base(f_10619_1347_1353_C(reader))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10619, 1274, 1445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 650, 663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1379, 1434);

                _xmlErrorCode = (XmlParseErrorCode)f_10619_1414_1433(reader);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10619, 1274, 1445);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10619, 1274, 1445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10619, 1274, 1445);
            }
        }

        public override string GetMessage(IFormatProvider formatProvider = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10619, 1479, 2205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1576, 1620);

                var
                culture = formatProvider as CultureInfo
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1636, 1712);

                string
                messagePrefix = f_10619_1659_1711(f_10619_1659_1679(this), f_10619_1692_1701(this), culture)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1726, 1789);

                string
                message = f_10619_1743_1788(_xmlErrorCode, culture)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1805, 1869);

                f_10619_1805_1868(!f_10619_1838_1867(message));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1885, 2051) || true) && (f_10619_1889_1903(this) == null || (DynAbs.Tracing.TraceSender.Expression_False(10619, 1889, 1941) || f_10619_1915_1936(f_10619_1915_1929(this)) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10619, 1885, 2051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 1975, 2036);

                    return f_10619_1982_2035(formatProvider, messagePrefix, message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10619, 1885, 2051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10619, 2067, 2194);

                return f_10619_2074_2193(formatProvider, f_10619_2104_2157(formatProvider, messagePrefix, message), f_10619_2159_2192(this, formatProvider));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10619, 1479, 2205);

                Microsoft.CodeAnalysis.CommonMessageProvider
                f_10619_1659_1679(Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10619, 1659, 1679);
                    return return_v;
                }


                int
                f_10619_1692_1701(Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10619, 1692, 1701);
                    return return_v;
                }


                string
                f_10619_1659_1711(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code, System.Globalization.CultureInfo?
                language)
                {
                    var return_v = this_param.LoadMessage(code, language);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 1659, 1711);
                    return return_v;
                }


                string
                f_10619_1743_1788(Microsoft.CodeAnalysis.CSharp.XmlParseErrorCode
                id, System.Globalization.CultureInfo?
                culture)
                {
                    var return_v = ErrorFacts.GetMessage(id, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 1743, 1788);
                    return return_v;
                }


                bool
                f_10619_1838_1867(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 1838, 1867);
                    return return_v;
                }


                int
                f_10619_1805_1868(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 1805, 1868);
                    return 0;
                }


                object[]
                f_10619_1889_1903(Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10619, 1889, 1903);
                    return return_v;
                }


                object[]
                f_10619_1915_1929(Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10619, 1915, 1929);
                    return return_v;
                }


                int
                f_10619_1915_1936(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10619, 1915, 1936);
                    return return_v;
                }


                string
                f_10619_1982_2035(System.IFormatProvider?
                provider, string
                format, string
                arg0)
                {
                    var return_v = String.Format(provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 1982, 2035);
                    return return_v;
                }


                string
                f_10619_2104_2157(System.IFormatProvider?
                provider, string
                format, string
                arg0)
                {
                    var return_v = String.Format(provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 2104, 2157);
                    return return_v;
                }


                object[]
                f_10619_2159_2192(Microsoft.CodeAnalysis.CSharp.XmlSyntaxDiagnosticInfo
                this_param, System.IFormatProvider?
                formatProvider)
                {
                    var return_v = this_param.GetArgumentsToUse(formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 2159, 2192);
                    return return_v;
                }


                string
                f_10619_2074_2193(System.IFormatProvider?
                provider, string
                format, params object[]
                args)
                {
                    var return_v = String.Format(provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 2074, 2193);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10619, 1479, 2205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10619, 1479, 2205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10619, 348, 2212);

        static int
        f_10619_490_591(System.Type
        type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
        typeReader)
        {
            ObjectBinder.RegisterTypeReader(type, typeReader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 490, 591);
            return 0;
        }


        static int
        f_10619_775_776_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10619, 676, 814);
            return return_v;
        }


        static int
        f_10619_948_954_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10619, 826, 1054);
            return return_v;
        }


        uint
        f_10619_1414_1433(Roslyn.Utilities.ObjectReader
        this_param)
        {
            var return_v = this_param.ReadUInt32();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10619, 1414, 1433);
            return return_v;
        }


        static Roslyn.Utilities.ObjectReader
        f_10619_1347_1353_C(Roslyn.Utilities.ObjectReader
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10619, 1274, 1445);
            return return_v;
        }

    }
}
