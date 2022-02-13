// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal partial class SyntaxToken
    {
        internal class SyntaxIdentifierExtended : SyntaxIdentifier
        {
            protected readonly SyntaxKind contextualKind;

            protected readonly string valueText;

            internal SyntaxIdentifierExtended(SyntaxKind contextualKind, string text, string valueText)
            : base(f_10829_702_706_C(text))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10829, 586, 837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 505, 519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 560, 569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 740, 777);

                    this.contextualKind = contextualKind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 795, 822);

                    this.valueText = valueText;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10829, 586, 837);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 586, 837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 586, 837);
                }
            }

            internal SyntaxIdentifierExtended(SyntaxKind contextualKind, string text, string valueText, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
            : base(f_10829_1031_1035_C(text), diagnostics, annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10829, 853, 1192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 505, 519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 560, 569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 1095, 1132);

                    this.contextualKind = contextualKind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 1150, 1177);

                    this.valueText = valueText;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10829, 853, 1192);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 853, 1192);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 853, 1192);
                }
            }

            internal SyntaxIdentifierExtended(ObjectReader reader)
            : base(f_10829_1287_1293_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10829, 1208, 1450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 505, 519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 560, 569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 1327, 1380);

                    this.contextualKind = (SyntaxKind)f_10829_1361_1379(reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 1398, 1435);

                    this.valueText = f_10829_1415_1434(reader);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10829, 1208, 1450);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 1208, 1450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 1208, 1450);
                }
            }

            static SyntaxIdentifierExtended()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10829, 1466, 1651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 1532, 1636);

                    f_10829_1532_1635(typeof(SyntaxIdentifierExtended), r => new SyntaxIdentifierExtended(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10829, 1466, 1651);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 1466, 1651);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 1466, 1651);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10829, 1667, 1904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 1751, 1772);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10829, 1751, 1771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 1790, 1836);

                    f_10829_1790_1835(writer, this.contextualKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 1854, 1889);

                    f_10829_1854_1888(writer, this.valueText);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10829, 1667, 1904);

                    int
                    f_10829_1790_1835(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    value)
                    {
                        this_param.WriteInt16((short)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 1790, 1835);
                        return 0;
                    }


                    int
                    f_10829_1854_1888(Roslyn.Utilities.ObjectWriter
                    this_param, string
                    value)
                    {
                        this_param.WriteString(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 1854, 1888);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 1667, 1904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 1667, 1904);
                }
            }

            public override SyntaxKind ContextualKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10829, 1994, 2029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 2000, 2027);

                        return this.contextualKind;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10829, 1994, 2029);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 1920, 2044);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 1920, 2044);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string ValueText
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10829, 2125, 2155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 2131, 2153);

                        return this.valueText;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10829, 2125, 2155);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 2060, 2170);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 2060, 2170);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override object Value
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10829, 2247, 2277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 2253, 2275);

                        return this.valueText;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10829, 2247, 2277);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 2186, 2292);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 2186, 2292);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override SyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10829, 2308, 2575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 2409, 2560);

                    return f_10829_2416_2559(this.contextualKind, this.TextField, this.valueText, trivia, null, f_10829_2514_2535(this), f_10829_2537_2558(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10829, 2308, 2575);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10829_2514_2535(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 2514, 2535);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10829_2537_2558(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 2537, 2558);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    f_10829_2416_2559(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 2416, 2559);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 2308, 2575);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 2308, 2575);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10829, 2591, 2859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 2693, 2844);

                    return f_10829_2700_2843(this.contextualKind, this.TextField, this.valueText, null, trivia, f_10829_2798_2819(this), f_10829_2821_2842(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10829, 2591, 2859);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10829_2798_2819(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 2798, 2819);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10829_2821_2842(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 2821, 2842);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    f_10829_2700_2843(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 2700, 2843);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 2591, 2859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 2591, 2859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[] diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10829, 2875, 3120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 2980, 3105);

                    return f_10829_2987_3104(this.contextualKind, this.TextField, this.valueText, diagnostics, f_10829_3082_3103(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10829, 2875, 3120);

                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10829_3082_3103(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 3082, 3103);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended
                    f_10829_2987_3104(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended(contextualKind, text, valueText, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 2987, 3104);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 2875, 3120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 2875, 3120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[] annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10829, 3136, 3383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10829, 3243, 3368);

                    return f_10829_3250_3367(this.contextualKind, this.TextField, this.valueText, f_10829_3332_3353(this), annotations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10829, 3136, 3383);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10829_3332_3353(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 3332, 3353);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended
                    f_10829_3250_3367(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierExtended(contextualKind, text, valueText, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 3250, 3367);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10829, 3136, 3383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10829, 3136, 3383);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10829, 392, 3394);

            static string
            f_10829_702_706_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10829, 586, 837);
                return return_v;
            }


            static string
            f_10829_1031_1035_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10829, 853, 1192);
                return return_v;
            }


            short
            f_10829_1361_1379(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadInt16();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 1361, 1379);
                return return_v;
            }


            string
            f_10829_1415_1434(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 1415, 1434);
                return return_v;
            }


            static Roslyn.Utilities.ObjectReader
            f_10829_1287_1293_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10829, 1208, 1450);
                return return_v;
            }


            static int
            f_10829_1532_1635(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10829, 1532, 1635);
                return 0;
            }

        }
    }
}
