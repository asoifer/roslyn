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
        internal class SyntaxIdentifier : SyntaxToken
        {
            static SyntaxIdentifier()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10828, 462, 623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 520, 608);

                    f_10828_520_607(typeof(SyntaxIdentifier), r => new SyntaxIdentifier(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10828, 462, 623);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 462, 623);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 462, 623);
                }
            }

            protected readonly string TextField;

            internal SyntaxIdentifier(string text)
            : base(f_10828_754_780_C(SyntaxKind.IdentifierToken), f_10828_782_793(text))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10828, 691, 864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 665, 674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 827, 849);

                    this.TextField = text;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10828, 691, 864);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 691, 864);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 691, 864);
                }
            }

            internal SyntaxIdentifier(string text, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
            : base(f_10828_1005_1031_C(SyntaxKind.IdentifierToken), f_10828_1033_1044(text), diagnostics, annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10828, 880, 1141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 665, 674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 1104, 1126);

                    this.TextField = text;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10828, 880, 1141);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 880, 1141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 880, 1141);
                }
            }

            internal SyntaxIdentifier(ObjectReader reader)
            : base(f_10828_1228_1234_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10828, 1157, 1377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 665, 674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 1268, 1305);

                    this.TextField = f_10828_1285_1304(reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 1323, 1362);

                    this.FullWidth = f_10828_1340_1361(this.TextField);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10828, 1157, 1377);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 1157, 1377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 1157, 1377);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10828, 1393, 1566);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 1477, 1498);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10828, 1477, 1497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 1516, 1551);

                    f_10828_1516_1550(writer, this.TextField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10828, 1393, 1566);

                    int
                    f_10828_1516_1550(Roslyn.Utilities.ObjectWriter
                    this_param, string
                    value)
                    {
                        this_param.WriteString(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 1516, 1550);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 1393, 1566);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 1393, 1566);
                }
            }

            public override string Text
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10828, 1642, 1672);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 1648, 1670);

                        return this.TextField;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10828, 1642, 1672);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 1582, 1687);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 1582, 1687);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10828, 1764, 1794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 1770, 1792);

                        return this.TextField;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10828, 1764, 1794);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 1703, 1809);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 1703, 1809);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10828, 1890, 1920);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 1896, 1918);

                        return this.TextField;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10828, 1890, 1920);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 1825, 1935);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 1825, 1935);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override SyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10828, 1951, 2208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 2052, 2193);

                    return f_10828_2059_2192(f_10828_2090_2099(this), this.TextField, this.TextField, trivia, null, f_10828_2147_2168(this), f_10828_2170_2191(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10828, 1951, 2208);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10828_2090_2099(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10828, 2090, 2099);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10828_2147_2168(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2147, 2168);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10828_2170_2191(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2170, 2191);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    f_10828_2059_2192(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2059, 2192);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 1951, 2208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 1951, 2208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10828, 2224, 2482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 2326, 2467);

                    return f_10828_2333_2466(f_10828_2364_2373(this), this.TextField, this.TextField, null, trivia, f_10828_2421_2442(this), f_10828_2444_2465(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10828, 2224, 2482);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10828_2364_2373(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10828, 2364, 2373);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10828_2421_2442(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2421, 2442);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10828_2444_2465(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2444, 2465);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    f_10828_2333_2466(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2333, 2466);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 2224, 2482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 2224, 2482);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[] diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10828, 2498, 2693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 2603, 2678);

                    return f_10828_2610_2677(f_10828_2631_2640(this), diagnostics, f_10828_2655_2676(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10828, 2498, 2693);

                    string
                    f_10828_2631_2640(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10828, 2631, 2640);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10828_2655_2676(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2655, 2676);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    f_10828_2610_2677(string
                    text, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier(text, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2610, 2677);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 2498, 2693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 2498, 2693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[] annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10828, 2709, 2906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10828, 2816, 2891);

                    return f_10828_2823_2890(f_10828_2844_2853(this), f_10828_2855_2876(this), annotations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10828, 2709, 2906);

                    string
                    f_10828_2844_2853(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.Text;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10828, 2844, 2853);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10828_2855_2876(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2855, 2876);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier
                    f_10828_2823_2890(string
                    text, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifier(text, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 2823, 2890);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10828, 2709, 2906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10828, 2709, 2906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10828, 392, 2917);

            static int
            f_10828_520_607(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 520, 607);
                return 0;
            }


            static int
            f_10828_782_793(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10828, 782, 793);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10828_754_780_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10828, 691, 864);
                return return_v;
            }


            static int
            f_10828_1033_1044(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10828, 1033, 1044);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10828_1005_1031_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10828, 880, 1141);
                return return_v;
            }


            string
            f_10828_1285_1304(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10828, 1285, 1304);
                return return_v;
            }


            int
            f_10828_1340_1361(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10828, 1340, 1361);
                return return_v;
            }


            static Roslyn.Utilities.ObjectReader
            f_10828_1228_1234_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10828, 1157, 1377);
                return return_v;
            }

        }
    }
}
