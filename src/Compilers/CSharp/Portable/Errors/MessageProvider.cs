// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class MessageProvider : CommonMessageProvider, IObjectWritable
    {
        public static readonly MessageProvider Instance;

        static MessageProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10617, 680, 812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 635, 667);
                Instance = f_10617_646_667(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 729, 801);

                f_10617_729_800(typeof(MessageProvider), r => Instance);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10617, 680, 812);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 680, 812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 680, 812);
            }
        }

        private MessageProvider()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10617, 824, 871);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10617, 824, 871);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 824, 871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 824, 871);
            }
        }

        bool IObjectWritable.ShouldReuseInSerialization
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 931, 938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 934, 938);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 931, 938);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 931, 938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 931, 938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void IObjectWritable.WriteTo(ObjectWriter writer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 951, 1097);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 951, 1097);
                // write nothing, always read/deserialized as global Instance
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 951, 1097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 951, 1097);
            }
        }

        public override DiagnosticSeverity GetSeverity(int code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 1109, 1248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 1190, 1237);

                return f_10617_1197_1236(code);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 1109, 1248);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10617_1197_1236(int
                code)
                {
                    var return_v = ErrorFacts.GetSeverity((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 1197, 1236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 1109, 1248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 1109, 1248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string LoadMessage(int code, CultureInfo language)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 1260, 1418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 1351, 1407);

                return f_10617_1358_1406(code, language);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 1260, 1418);

                string
                f_10617_1358_1406(int
                code, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = ErrorFacts.GetMessage((Microsoft.CodeAnalysis.CSharp.ErrorCode)code, culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 1358, 1406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 1260, 1418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 1260, 1418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LocalizableString GetMessageFormat(int code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 1430, 1578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 1515, 1567);

                return f_10617_1522_1566(code);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 1430, 1578);

                Microsoft.CodeAnalysis.LocalizableResourceString
                f_10617_1522_1566(int
                code)
                {
                    var return_v = ErrorFacts.GetMessageFormat((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 1522, 1566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 1430, 1578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 1430, 1578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LocalizableString GetDescription(int code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 1590, 1734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 1673, 1723);

                return f_10617_1680_1722(code);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 1590, 1734);

                Microsoft.CodeAnalysis.LocalizableResourceString
                f_10617_1680_1722(int
                code)
                {
                    var return_v = ErrorFacts.GetDescription((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 1680, 1722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 1590, 1734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 1590, 1734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LocalizableString GetTitle(int code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 1746, 1878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 1823, 1867);

                return f_10617_1830_1866(code);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 1746, 1878);

                Microsoft.CodeAnalysis.LocalizableResourceString
                f_10617_1830_1866(int
                code)
                {
                    var return_v = ErrorFacts.GetTitle((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 1830, 1866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 1746, 1878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 1746, 1878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetHelpLink(int code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 1890, 2017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 1959, 2006);

                return f_10617_1966_2005(code);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 1890, 2017);

                string
                f_10617_1966_2005(int
                code)
                {
                    var return_v = ErrorFacts.GetHelpLink((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 1966, 2005);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 1890, 2017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 1890, 2017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetCategory(int code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 2029, 2156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 2098, 2145);

                return f_10617_2105_2144(code);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 2029, 2156);

                string
                f_10617_2105_2144(int
                code)
                {
                    var return_v = ErrorFacts.GetCategory((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 2105, 2144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 2029, 2156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 2029, 2156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string CodePrefix
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 2226, 2289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 2262, 2274);

                    return "CS";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 2226, 2289);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 2168, 2300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 2168, 2300);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetMessagePrefix(string id, DiagnosticSeverity severity, bool isWarningAsError, CultureInfo culture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 2499, 2817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 2647, 2806);

                return f_10617_2654_2805(culture, "{0} {1}", (DynAbs.Tracing.TraceSender.Conditional_F1(10617, 2705, 2761) || ((severity == DiagnosticSeverity.Error || (DynAbs.Tracing.TraceSender.Expression_False(10617, 2705, 2761) || isWarningAsError) && DynAbs.Tracing.TraceSender.Conditional_F2(10617, 2764, 2771)) || DynAbs.Tracing.TraceSender.Conditional_F3(10617, 2774, 2783))) ? "error" : "warning", id);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 2499, 2817);

                string
                f_10617_2654_2805(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = String.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 2654, 2805);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 2499, 2817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 2499, 2817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetWarningLevel(int code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 2829, 2961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 2899, 2950);

                return f_10617_2906_2949(code);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 2829, 2961);

                int
                f_10617_2906_2949(int
                code)
                {
                    var return_v = ErrorFacts.GetWarningLevel((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 2906, 2949);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 2829, 2961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 2829, 2961);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Type ErrorCodeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 3032, 3065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 3038, 3063);

                    return typeof(ErrorCode);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 3032, 3065);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 2973, 3076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 2973, 3076);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Diagnostic CreateDiagnostic(int code, Location location, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 3088, 3389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 3207, 3324);

                var
                info = f_10617_3218_3323(code, args, ImmutableArray<Symbol>.Empty, ImmutableArray<Location>.Empty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 3338, 3378);

                return f_10617_3345_3377(info, location);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 3088, 3389);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_3218_3323(int
                code, object[]
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo((Microsoft.CodeAnalysis.CSharp.ErrorCode)code, args, symbols, additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 3218, 3323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10617_3345_3377(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 3345, 3377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 3088, 3389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 3088, 3389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Diagnostic CreateDiagnostic(DiagnosticInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 3401, 3546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 3490, 3535);

                return f_10617_3497_3534(info, f_10617_3520_3533());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 3401, 3546);

                Microsoft.CodeAnalysis.Location
                f_10617_3520_3533()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 3520, 3533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10617_3497_3534(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 3497, 3534);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 3401, 3546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 3401, 3546);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string GetErrorDisplayString(ISymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 3558, 4013);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 3739, 3890) || true) && (f_10617_3743_3754(symbol) == SymbolKind.Assembly || (DynAbs.Tracing.TraceSender.Expression_False(10617, 3743, 3816) || f_10617_3781_3792(symbol) == SymbolKind.Namespace))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10617, 3739, 3890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 3850, 3875);

                    return f_10617_3857_3874(symbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10617, 3739, 3890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 3906, 4002);

                return f_10617_3913_4001(symbol, f_10617_3951_4000());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 3558, 4013);

                Microsoft.CodeAnalysis.SymbolKind
                f_10617_3743_3754(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 3743, 3754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10617_3781_3792(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 3781, 3792);
                    return return_v;
                }


                string?
                f_10617_3857_3874(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 3857, 3874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10617_3951_4000()
                {
                    var return_v = SymbolDisplayFormat.CSharpShortErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 3951, 4000);
                    return return_v;
                }


                string
                f_10617_3913_4001(Microsoft.CodeAnalysis.ISymbol
                symbol, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = SymbolDisplay.ToDisplayString(symbol, format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 3913, 4001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 3558, 4013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 3558, 4013);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ReportDiagnostic GetDiagnosticReport(DiagnosticInfo diagnosticInfo, CompilationOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 4025, 5484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 4161, 4187);

                bool
                hasPragmaSuppression
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 4201, 5473);

                return f_10617_4208_5472(f_10617_4251_4274(diagnosticInfo), true, f_10617_4408_4440(diagnosticInfo), f_10617_4505_4532(diagnosticInfo), f_10617_4597_4610(), f_10617_4675_4698(diagnosticInfo), f_10617_4763_4783(options), f_10617_4848_4906(((CSharpCompilationOptions)options)), f_10617_4971_5002(options), f_10617_5067_5100(options), f_10617_5165_5198(options), CancellationToken.None, out hasPragmaSuppression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 4025, 5484);

                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10617_4251_4274(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 4251, 4274);
                    return return_v;
                }


                string
                f_10617_4408_4440(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.MessageIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 4408, 4440);
                    return return_v;
                }


                int
                f_10617_4505_4532(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 4505, 4532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10617_4597_4610()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 4597, 4610);
                    return return_v;
                }


                string
                f_10617_4675_4698(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Category;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 4675, 4698);
                    return return_v;
                }


                int
                f_10617_4763_4783(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.WarningLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 4763, 4783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_10617_4848_4906(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 4848, 4906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_10617_4971_5002(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.GeneralDiagnosticOption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 4971, 5002);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                f_10617_5067_5100(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SpecificDiagnosticOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 5067, 5100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                f_10617_5165_5198(Microsoft.CodeAnalysis.CompilationOptions
                this_param)
                {
                    var return_v = this_param.SyntaxTreeOptionsProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 5165, 5198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ReportDiagnostic
                f_10617_4208_5472(Microsoft.CodeAnalysis.DiagnosticSeverity
                severity, bool
                isEnabledByDefault, string
                id, int
                diagnosticWarningLevel, Microsoft.CodeAnalysis.Location
                location, string
                category, int
                warningLevelOption, Microsoft.CodeAnalysis.NullableContextOptions
                nullableOption, Microsoft.CodeAnalysis.ReportDiagnostic
                generalDiagnosticOption, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>
                specificDiagnosticOptions, Microsoft.CodeAnalysis.SyntaxTreeOptionsProvider?
                syntaxTreeOptions, System.Threading.CancellationToken
                cancellationToken, out bool
                hasPragmaSuppression)
                {
                    var return_v = CSharpDiagnosticFilter.GetDiagnosticReport(severity, isEnabledByDefault, id, diagnosticWarningLevel, location, category, warningLevelOption, nullableOption, generalDiagnosticOption, (System.Collections.Generic.IDictionary<string, Microsoft.CodeAnalysis.ReportDiagnostic>)specificDiagnosticOptions, syntaxTreeOptions, cancellationToken, out hasPragmaSuppression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 4208, 5472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 4025, 5484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 4025, 5484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int ERR_FailedToCreateTempFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 5543, 5581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 5546, 5581);
                    return (int)ErrorCode.ERR_CantMakeTempFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 5543, 5581);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 5543, 5581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 5543, 5581);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_MultipleAnalyzerConfigsInSameDir
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 5649, 5703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 5652, 5703);
                    return (int)ErrorCode.ERR_MultipleAnalyzerConfigsInSameDir; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 5649, 5703);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 5649, 5703);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 5649, 5703);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_ExpectedSingleScript
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 5787, 5829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 5790, 5829);
                    return (int)ErrorCode.ERR_ExpectedSingleScript; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 5787, 5829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 5787, 5829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 5787, 5829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_OpenResponseFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 5881, 5919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 5884, 5919);
                    return (int)ErrorCode.ERR_OpenResponseFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 5881, 5919);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 5881, 5919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 5881, 5919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidPathMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 5969, 6005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 5972, 6005);
                    return (int)ErrorCode.ERR_InvalidPathMap; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 5969, 6005);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 5969, 6005);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 5969, 6005);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int FTL_InvalidInputFileName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6061, 6103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6064, 6103);
                    return (int)ErrorCode.FTL_InvalidInputFileName; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6061, 6103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6061, 6103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6061, 6103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_FileNotFound
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6151, 6185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6154, 6185);
                    return (int)ErrorCode.ERR_FileNotFound; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6151, 6185);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6151, 6185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6151, 6185);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_NoSourceFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6233, 6267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6236, 6267);
                    return (int)ErrorCode.ERR_NoSourceFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6233, 6267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6233, 6267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6233, 6267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_CantOpenFileWrite
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6320, 6359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6323, 6359);
                    return (int)ErrorCode.ERR_CantOpenFileWrite; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6320, 6359);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6320, 6359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6320, 6359);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_OutputWriteFailed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6412, 6451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6415, 6451);
                    return (int)ErrorCode.ERR_OutputWriteFailed; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6412, 6451);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6412, 6451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6412, 6451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int WRN_NoConfigNotOnCommandLine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6511, 6557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6514, 6557);
                    return (int)ErrorCode.WRN_NoConfigNotOnCommandLine; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6511, 6557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6511, 6557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6511, 6557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_BinaryFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6603, 6635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6606, 6635);
                    return (int)ErrorCode.ERR_BinaryFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6603, 6635);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6603, 6635);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6603, 6635);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int WRN_AnalyzerCannotBeCreated
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6694, 6739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6697, 6739);
                    return (int)ErrorCode.WRN_AnalyzerCannotBeCreated; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6694, 6739);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6694, 6739);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6694, 6739);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int WRN_NoAnalyzerInAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6795, 6837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6798, 6837);
                    return (int)ErrorCode.WRN_NoAnalyzerInAssembly; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6795, 6837);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6795, 6837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6795, 6837);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int WRN_UnableToLoadAnalyzer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6893, 6935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 6896, 6935);
                    return (int)ErrorCode.WRN_UnableToLoadAnalyzer; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6893, 6935);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6893, 6935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6893, 6935);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int WRN_AnalyzerReferencesFramework
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 6998, 7047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 7001, 7047);
                    return (int)ErrorCode.WRN_AnalyzerReferencesFramework; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 6998, 7047);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 6998, 7047);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 6998, 7047);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int INF_UnableToLoadSomeTypesInAnalyzer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 7114, 7167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 7117, 7167);
                    return (int)ErrorCode.INF_UnableToLoadSomeTypesInAnalyzer; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 7114, 7167);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 7114, 7167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 7114, 7167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_CantReadRulesetFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 7222, 7263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 7225, 7263);
                    return (int)ErrorCode.ERR_CantReadRulesetFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 7222, 7263);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 7222, 7263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 7222, 7263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_CompileCancelled
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 7315, 7353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 7318, 7353);
                    return (int)ErrorCode.ERR_CompileCancelled; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 7315, 7353);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 7315, 7353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 7315, 7353);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_BadSourceCodeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 7435, 7474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 7438, 7474);
                    return (int)ErrorCode.ERR_BadSourceCodeKind; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 7435, 7474);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 7435, 7474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 7435, 7474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_BadDocumentationMode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 7530, 7572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 7533, 7572);
                    return (int)ErrorCode.ERR_BadDocumentationMode; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 7530, 7572);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 7530, 7572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 7530, 7572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_BadCompilationOptionValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 7668, 7715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 7671, 7715);
                    return (int)ErrorCode.ERR_BadCompilationOptionValue; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 7668, 7715);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 7668, 7715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 7668, 7715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_MutuallyExclusiveOptions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 7775, 7821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 7778, 7821);
                    return (int)ErrorCode.ERR_MutuallyExclusiveOptions; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 7775, 7821);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 7775, 7821);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 7775, 7821);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidDebugInformationFormat
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 7914, 7965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 7917, 7965);
                    return (int)ErrorCode.ERR_InvalidDebugInformationFormat; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 7914, 7965);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 7914, 7965);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 7914, 7965);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidOutputName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8018, 8057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8021, 8057);
                    return (int)ErrorCode.ERR_InvalidOutputName; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8018, 8057);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8018, 8057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8018, 8057);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidFileAlignment
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8113, 8155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8116, 8155);
                    return (int)ErrorCode.ERR_InvalidFileAlignment; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8113, 8155);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8113, 8155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8113, 8155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidSubsystemVersion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8214, 8259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8217, 8259);
                    return (int)ErrorCode.ERR_InvalidSubsystemVersion; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8214, 8259);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8214, 8259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8214, 8259);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidInstrumentationKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8321, 8369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8324, 8369);
                    return (int)ErrorCode.ERR_InvalidInstrumentationKind; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8321, 8369);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8321, 8369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8321, 8369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidHashAlgorithmName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8429, 8475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8432, 8475);
                    return (int)ErrorCode.ERR_InvalidHashAlgorithmName; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8429, 8475);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8429, 8475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8429, 8475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_MetadataFileNotAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8567, 8606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8570, 8606);
                    return (int)ErrorCode.ERR_ImportNonAssembly; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8567, 8606);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8567, 8606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8567, 8606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_MetadataFileNotModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8663, 8702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8666, 8702);
                    return (int)ErrorCode.ERR_AddModuleAssembly; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8663, 8702);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8663, 8702);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8663, 8702);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidAssemblyMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8761, 8803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8764, 8803);
                    return (int)ErrorCode.FTL_MetadataCantOpenFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8761, 8803);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8761, 8803);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8761, 8803);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidModuleMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8860, 8902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8863, 8902);
                    return (int)ErrorCode.FTL_MetadataCantOpenFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8860, 8902);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8860, 8902);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8860, 8902);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_ErrorOpeningAssemblyFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 8962, 9004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 8965, 9004);
                    return (int)ErrorCode.FTL_MetadataCantOpenFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 8962, 9004);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 8962, 9004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 8962, 9004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_ErrorOpeningModuleFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 9062, 9104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 9065, 9104);
                    return (int)ErrorCode.FTL_MetadataCantOpenFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 9062, 9104);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 9062, 9104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 9062, 9104);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_MetadataFileNotFound
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 9160, 9196);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 9163, 9196);
                    return (int)ErrorCode.ERR_NoMetadataFile; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 9160, 9196);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 9160, 9196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 9160, 9196);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_MetadataReferencesNotSupported
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 9262, 9314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 9265, 9314);
                    return (int)ErrorCode.ERR_MetadataReferencesNotSupported; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 9262, 9314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 9262, 9314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 9262, 9314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_LinkedNetmoduleMetadataMustProvideFullPEImage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 9395, 9462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 9398, 9462);
                    return (int)ErrorCode.ERR_LinkedNetmoduleMetadataMustProvideFullPEImage; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 9395, 9462);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 9395, 9462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 9395, 9462);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void ReportDuplicateMetadataReferenceStrong(DiagnosticBag diagnostics, Location location, MetadataReference reference, AssemblyIdentity identity, MetadataReference equivalentReference, AssemblyIdentity equivalentIdentity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 9475, 9955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 9737, 9944);

                f_10617_9737_9943(diagnostics, ErrorCode.ERR_DuplicateImport, location, f_10617_9811_9828(reference) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10617, 9811, 9857) ?? f_10617_9832_9857(identity)), f_10617_9876_9903(equivalentReference) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10617, 9876, 9942) ?? f_10617_9907_9942(equivalentIdentity)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 9475, 9955);

                string?
                f_10617_9811_9828(Microsoft.CodeAnalysis.MetadataReference
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 9811, 9828);
                    return return_v;
                }


                string
                f_10617_9832_9857(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 9832, 9857);
                    return return_v;
                }


                string?
                f_10617_9876_9903(Microsoft.CodeAnalysis.MetadataReference
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 9876, 9903);
                    return return_v;
                }


                string
                f_10617_9907_9942(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 9907, 9942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_9737_9943(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 9737, 9943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 9475, 9955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 9475, 9955);
            }
        }

        public override void ReportDuplicateMetadataReferenceWeak(DiagnosticBag diagnostics, Location location, MetadataReference reference, AssemblyIdentity identity, MetadataReference equivalentReference, AssemblyIdentity equivalentIdentity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 9967, 10398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 10227, 10387);

                f_10617_10227_10386(diagnostics, ErrorCode.ERR_DuplicateImportSimple, location, f_10617_10307_10320(identity), f_10617_10339_10356(reference) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10617, 10339, 10385) ?? f_10617_10360_10385(identity)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 9967, 10398);

                string
                f_10617_10307_10320(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 10307, 10320);
                    return return_v;
                }


                string?
                f_10617_10339_10356(Microsoft.CodeAnalysis.MetadataReference
                this_param)
                {
                    var return_v = this_param.Display;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 10339, 10356);
                    return return_v;
                }


                string
                f_10617_10360_10385(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.GetDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 10360, 10385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_10227_10386(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 10227, 10386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 9967, 10398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 9967, 10398);
            }
        }

        public override int ERR_PublicKeyFileFailure
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 10476, 10518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 10479, 10518);
                    return (int)ErrorCode.ERR_PublicKeyFileFailure; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 10476, 10518);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 10476, 10518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 10476, 10518);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_PublicKeyContainerFailure
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 10579, 10626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 10582, 10626);
                    return (int)ErrorCode.ERR_PublicKeyContainerFailure; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 10579, 10626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 10579, 10626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 10579, 10626);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_OptionMustBeAbsolutePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 10686, 10732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 10689, 10732);
                    return (int)ErrorCode.ERR_OptionMustBeAbsolutePath; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 10686, 10732);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 10686, 10732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 10686, 10732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_CantReadResource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 10809, 10847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 10812, 10847);
                    return (int)ErrorCode.ERR_CantReadResource; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 10809, 10847);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 10809, 10847);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 10809, 10847);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_CantOpenWin32Resource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 10904, 10942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 10907, 10942);
                    return (int)ErrorCode.ERR_CantOpenWin32Res; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 10904, 10942);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 10904, 10942);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 10904, 10942);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_CantOpenWin32Manifest
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 10999, 11042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11002, 11042);
                    return (int)ErrorCode.ERR_CantOpenWin32Manifest; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 10999, 11042);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 10999, 11042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 10999, 11042);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_CantOpenWin32Icon
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 11095, 11129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11098, 11129);
                    return (int)ErrorCode.ERR_CantOpenIcon; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 11095, 11129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 11095, 11129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 11095, 11129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_ErrorBuildingWin32Resource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 11191, 11240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11194, 11240);
                    return (int)ErrorCode.ERR_ErrorBuildingWin32Resources; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 11191, 11240);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 11191, 11240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 11191, 11240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_BadWin32Resource
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 11292, 11325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11295, 11325);
                    return (int)ErrorCode.ERR_BadWin32Res; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 11292, 11325);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 11292, 11325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 11292, 11325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_ResourceFileNameNotUnique
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 11386, 11433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11389, 11433);
                    return (int)ErrorCode.ERR_ResourceFileNameNotUnique; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 11386, 11433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 11386, 11433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 11386, 11433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_ResourceNotUnique
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 11486, 11525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11489, 11525);
                    return (int)ErrorCode.ERR_ResourceNotUnique; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 11486, 11525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 11486, 11525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 11486, 11525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_ResourceInModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 11577, 11614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11580, 11614);
                    return (int)ErrorCode.ERR_CantRefResource; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 11577, 11614);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 11577, 11614);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 11577, 11614);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_PermissionSetAttributeFileReadError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 11725, 11782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11728, 11782);
                    return (int)ErrorCode.ERR_PermissionSetAttributeFileReadError; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 11725, 11782);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 11725, 11782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 11725, 11782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_EncodinglessSyntaxTree
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 11866, 11910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11869, 11910);
                    return (int)ErrorCode.ERR_EncodinglessSyntaxTree; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 11866, 11910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 11866, 11910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 11866, 11910);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int WRN_PdbUsingNameTooLong
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 11965, 12007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 11968, 12007);
                    return (int)ErrorCode.WRN_DebugFullNameTooLong; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 11965, 12007);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 11965, 12007);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 11965, 12007);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int WRN_PdbLocalNameTooLong
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 12062, 12103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 12065, 12103);
                    return (int)ErrorCode.WRN_PdbLocalNameTooLong; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 12062, 12103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 12062, 12103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 12062, 12103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_PdbWritingFailed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 12155, 12193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 12158, 12193);
                    return (int)ErrorCode.FTL_DebugEmitFailure; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 12155, 12193);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 12155, 12193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 12155, 12193);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_MetadataNameTooLong
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 12273, 12314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 12276, 12314);
                    return (int)ErrorCode.ERR_MetadataNameTooLong; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 12273, 12314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 12273, 12314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 12273, 12314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_EncReferenceToAddedMember
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 12375, 12422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 12378, 12422);
                    return (int)ErrorCode.ERR_EncReferenceToAddedMember; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 12375, 12422);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 12375, 12422);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 12375, 12422);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_TooManyUserStrings
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 12476, 12516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 12479, 12516);
                    return (int)ErrorCode.ERR_TooManyUserStrings; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 12476, 12516);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 12476, 12516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 12476, 12516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_PeWritingFailure
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 12568, 12606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 12571, 12606);
                    return (int)ErrorCode.ERR_PeWritingFailure; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 12568, 12606);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 12568, 12606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 12568, 12606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_ModuleEmitFailure
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 12659, 12698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 12662, 12698);
                    return (int)ErrorCode.ERR_ModuleEmitFailure; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 12659, 12698);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 12659, 12698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 12659, 12698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_EncUpdateFailedMissingAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 12765, 12818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 12768, 12818);
                    return (int)ErrorCode.ERR_EncUpdateFailedMissingAttribute; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 12765, 12818);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 12765, 12818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 12765, 12818);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ERR_InvalidDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 12870, 12908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 12873, 12908);
                    return (int)ErrorCode.ERR_InvalidDebugInfo; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 12870, 12908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 12870, 12908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 12870, 12908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int WRN_GeneratorFailedDuringInitialization
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 13005, 13062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 13008, 13062);
                    return (int)ErrorCode.WRN_GeneratorFailedDuringInitialization; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 13005, 13062);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 13005, 13062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 13005, 13062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int WRN_GeneratorFailedDuringGeneration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 13129, 13182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 13132, 13182);
                    return (int)ErrorCode.WRN_GeneratorFailedDuringGeneration; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 13129, 13182);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 13129, 13182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 13129, 13182);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void ReportInvalidAttributeArgument(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int parameterIndex, AttributeData attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 13195, 13674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 13371, 13415);

                var
                node = (AttributeSyntax)attributeSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 13429, 13531);

                CSharpSyntaxNode
                attributeArgumentSyntax = f_10617_13472_13530(attribute, parameterIndex, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 13545, 13663);

                f_10617_13545_13662(diagnostics, ErrorCode.ERR_InvalidAttributeArgument, f_10617_13601_13633(attributeArgumentSyntax), f_10617_13635_13661(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 13195, 13674);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10617_13472_13530(Microsoft.CodeAnalysis.AttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 13472, 13530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10617_13601_13633(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 13601, 13633);
                    return return_v;
                }


                string
                f_10617_13635_13661(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.GetErrorDisplayName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 13635, 13661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_13545_13662(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 13545, 13662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 13195, 13674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 13195, 13674);
            }
        }

        public override void ReportInvalidNamedArgument(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int namedArgumentIndex, ITypeSymbol attributeClass, string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 13686, 14081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 13887, 13931);

                var
                node = (AttributeSyntax)attributeSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 13945, 14070);

                f_10617_13945_14069(diagnostics, ErrorCode.ERR_InvalidNamedArgument, f_10617_13997_14053(f_10617_13997_14024(f_10617_13997_14014(node))[namedArgumentIndex]), parameterName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 13686, 14081);

                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10617_13997_14014(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 13997, 14014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10617_13997_14024(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 13997, 14024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10617_13997_14053(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 13997, 14053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_13945_14069(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 13945, 14069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 13686, 14081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 13686, 14081);
            }
        }

        public override void ReportParameterNotValidForType(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int namedArgumentIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 14093, 14431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 14248, 14292);

                var
                node = (AttributeSyntax)attributeSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 14306, 14420);

                f_10617_14306_14419(diagnostics, ErrorCode.ERR_ParameterNotValidForType, f_10617_14362_14418(f_10617_14362_14389(f_10617_14362_14379(node))[namedArgumentIndex]));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 14093, 14431);

                Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                f_10617_14362_14379(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 14362, 14379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax>
                f_10617_14362_14389(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentListSyntax?
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 14362, 14389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10617_14362_14418(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 14362, 14418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_14306_14419(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 14306, 14419);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 14093, 14431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 14093, 14431);
            }
        }

        public override void ReportMarshalUnmanagedTypeNotValidForFields(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int parameterIndex, string unmanagedTypeName, AttributeData attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 14443, 14965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 14658, 14702);

                var
                node = (AttributeSyntax)attributeSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 14716, 14818);

                CSharpSyntaxNode
                attributeArgumentSyntax = f_10617_14759_14817(attribute, parameterIndex, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 14832, 14954);

                f_10617_14832_14953(diagnostics, ErrorCode.ERR_MarshalUnmanagedTypeNotValidForFields, f_10617_14901_14933(attributeArgumentSyntax), unmanagedTypeName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 14443, 14965);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10617_14759_14817(Microsoft.CodeAnalysis.AttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 14759, 14817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10617_14901_14933(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 14901, 14933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_14832_14953(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 14832, 14953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 14443, 14965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 14443, 14965);
            }
        }

        public override void ReportMarshalUnmanagedTypeOnlyValidForFields(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, int parameterIndex, string unmanagedTypeName, AttributeData attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 14977, 15501);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 15193, 15237);

                var
                node = (AttributeSyntax)attributeSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 15251, 15353);

                CSharpSyntaxNode
                attributeArgumentSyntax = f_10617_15294_15352(attribute, parameterIndex, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 15367, 15490);

                f_10617_15367_15489(diagnostics, ErrorCode.ERR_MarshalUnmanagedTypeOnlyValidForFields, f_10617_15437_15469(attributeArgumentSyntax), unmanagedTypeName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 14977, 15501);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10617_15294_15352(Microsoft.CodeAnalysis.AttributeData
                attribute, int
                parameterIndex, Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                attributeSyntax)
                {
                    var return_v = attribute.GetAttributeArgumentSyntax(parameterIndex, attributeSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 15294, 15352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10617_15437_15469(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 15437, 15469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_15367_15489(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 15367, 15489);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 14977, 15501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 14977, 15501);
            }
        }

        public override void ReportAttributeParameterRequired(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 15513, 15831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 15668, 15712);

                var
                node = (AttributeSyntax)attributeSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 15726, 15820);

                f_10617_15726_15819(diagnostics, ErrorCode.ERR_AttributeParameterRequired1, f_10617_15785_15803(f_10617_15785_15794(node)), parameterName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 15513, 15831);

                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10617_15785_15794(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 15785, 15794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10617_15785_15803(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 15785, 15803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_15726_15819(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 15726, 15819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 15513, 15831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 15513, 15831);
            }
        }

        public override void ReportAttributeParameterRequired(DiagnosticBag diagnostics, SyntaxNode attributeSyntax, string parameterName1, string parameterName2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 15843, 16202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 16022, 16066);

                var
                node = (AttributeSyntax)attributeSyntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 16080, 16191);

                f_10617_16080_16190(diagnostics, ErrorCode.ERR_AttributeParameterRequired2, f_10617_16139_16157(f_10617_16139_16148(node)), parameterName1, parameterName2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 15843, 16202);

                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_10617_16139_16148(Microsoft.CodeAnalysis.CSharp.Syntax.AttributeSyntax
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 16139, 16148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10617_16139_16157(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10617, 16139, 16157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10617_16080_16190(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 16080, 16190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 15843, 16202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 15843, 16202);
            }
        }

        public override int ERR_BadAssemblyName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10617, 16254, 16291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10617, 16257, 16291);
                    return (int)ErrorCode.ERR_BadAssemblyName; DynAbs.Tracing.TraceSender.TraceExitMethod(10617, 16254, 16291);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10617, 16254, 16291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10617, 16254, 16291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10617, 501, 16299);

        static Microsoft.CodeAnalysis.CSharp.MessageProvider
        f_10617_646_667()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.MessageProvider();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 646, 667);
            return return_v;
        }


        static int
        f_10617_729_800(System.Type
        type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
        typeReader)
        {
            ObjectBinder.RegisterTypeReader(type, typeReader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10617, 729, 800);
            return 0;
        }

    }
}
