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
        internal class SyntaxIdentifierWithTrivia : SyntaxIdentifierExtended
        {
            private readonly GreenNode _leading;

            private readonly GreenNode _trailing;

            internal SyntaxIdentifierWithTrivia(
                            SyntaxKind contextualKind,
                            string text,
                            string valueText,
                            GreenNode leading,
                            GreenNode trailing)
            : base(f_10831_831_845_C(contextualKind), text, valueText)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10831, 588, 1243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 512, 520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 562, 571);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 896, 1051) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10831, 896, 1051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 957, 991);

                        f_10831_957_990(this, leading);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1013, 1032);

                        _leading = leading;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10831, 896, 1051);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1069, 1228) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10831, 1069, 1228);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1131, 1166);

                        f_10831_1131_1165(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1188, 1209);

                        _trailing = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10831, 1069, 1228);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10831, 588, 1243);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 588, 1243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 588, 1243);
                }
            }

            internal SyntaxIdentifierWithTrivia(
                            SyntaxKind contextualKind,
                            string text,
                            string valueText,
                            GreenNode leading,
                            GreenNode trailing,
                            DiagnosticInfo[] diagnostics,
                            SyntaxAnnotation[] annotations)
            : base(f_10831_1598_1612_C(contextualKind), text, valueText, diagnostics, annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10831, 1259, 2036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 512, 520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 562, 571);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1689, 1844) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10831, 1689, 1844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1750, 1784);

                        f_10831_1750_1783(this, leading);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1806, 1825);

                        _leading = leading;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10831, 1689, 1844);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1862, 2021) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10831, 1862, 2021);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1924, 1959);

                        f_10831_1924_1958(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 1981, 2002);

                        _trailing = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10831, 1862, 2021);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10831, 1259, 2036);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 1259, 2036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 1259, 2036);
                }
            }

            internal SyntaxIdentifierWithTrivia(ObjectReader reader)
            : base(f_10831_2133_2139_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10831, 2052, 2645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 512, 520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 562, 571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2173, 2217);

                    var
                    leading = (GreenNode)f_10831_2198_2216(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2235, 2390) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10831, 2235, 2390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2296, 2330);

                        f_10831_2296_2329(this, leading);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2352, 2371);

                        _leading = leading;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10831, 2235, 2390);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2408, 2453);

                    var
                    trailing = (GreenNode)f_10831_2434_2452(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2471, 2630) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10831, 2471, 2630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2533, 2554);

                        _trailing = trailing;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2576, 2611);

                        f_10831_2576_2610(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10831, 2471, 2630);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10831, 2052, 2645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 2052, 2645);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 2052, 2645);
                }
            }

            static SyntaxIdentifierWithTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10831, 2661, 2852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2729, 2837);

                    f_10831_2729_2836(typeof(SyntaxIdentifierWithTrivia), r => new SyntaxIdentifierWithTrivia(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10831, 2661, 2852);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 2661, 2852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 2661, 2852);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10831, 2868, 3081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2952, 2973);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10831, 2952, 2972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 2991, 3019);

                    f_10831_2991_3018(writer, _leading);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 3037, 3066);

                    f_10831_3037_3065(writer, _trailing);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10831, 2868, 3081);

                    int
                    f_10831_2991_3018(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 2991, 3018);
                        return 0;
                    }


                    int
                    f_10831_3037_3065(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 3037, 3065);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 2868, 3081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 2868, 3081);
                }
            }

            public override GreenNode GetLeadingTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10831, 3097, 3205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 3174, 3190);

                    return _leading;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10831, 3097, 3205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 3097, 3205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 3097, 3205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override GreenNode GetTrailingTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10831, 3221, 3331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 3299, 3316);

                    return _trailing;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10831, 3221, 3331);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 3221, 3331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 3221, 3331);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10831, 3347, 3619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 3448, 3604);

                    return f_10831_3455_3603(this.contextualKind, this.TextField, this.valueText, trivia, _trailing, f_10831_3558_3579(this), f_10831_3581_3602(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10831, 3347, 3619);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10831_3558_3579(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 3558, 3579);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10831_3581_3602(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 3581, 3602);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    f_10831_3455_3603(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 3455, 3603);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 3347, 3619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 3347, 3619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10831, 3635, 3907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 3737, 3892);

                    return f_10831_3744_3891(this.contextualKind, this.TextField, this.valueText, _leading, trivia, f_10831_3846_3867(this), f_10831_3869_3890(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10831, 3635, 3907);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10831_3846_3867(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 3846, 3867);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10831_3869_3890(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 3869, 3890);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    f_10831_3744_3891(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 3744, 3891);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 3635, 3907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 3635, 3907);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[] diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10831, 3923, 4191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 4028, 4176);

                    return f_10831_4035_4175(this.contextualKind, this.TextField, this.valueText, _leading, _trailing, diagnostics, f_10831_4153_4174(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10831, 3923, 4191);

                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10831_4153_4174(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 4153, 4174);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    f_10831_4035_4175(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 4035, 4175);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 3923, 4191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 3923, 4191);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[] annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10831, 4207, 4477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10831, 4314, 4462);

                    return f_10831_4321_4461(this.contextualKind, this.TextField, this.valueText, _leading, _trailing, f_10831_4426_4447(this), annotations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10831, 4207, 4477);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10831_4426_4447(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 4426, 4447);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    f_10831_4321_4461(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 4321, 4461);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10831, 4207, 4477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10831, 4207, 4477);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10831, 392, 4488);

            int
            f_10831_957_990(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 957, 990);
                return 0;
            }


            int
            f_10831_1131_1165(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 1131, 1165);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10831_831_845_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10831, 588, 1243);
                return return_v;
            }


            int
            f_10831_1750_1783(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 1750, 1783);
                return 0;
            }


            int
            f_10831_1924_1958(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 1924, 1958);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10831_1598_1612_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10831, 1259, 2036);
                return return_v;
            }


            object
            f_10831_2198_2216(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 2198, 2216);
                return return_v;
            }


            int
            f_10831_2296_2329(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 2296, 2329);
                return 0;
            }


            object
            f_10831_2434_2452(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 2434, 2452);
                return return_v;
            }


            int
            f_10831_2576_2610(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 2576, 2610);
                return 0;
            }


            static Roslyn.Utilities.ObjectReader
            f_10831_2133_2139_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10831, 2052, 2645);
                return return_v;
            }


            static int
            f_10831_2729_2836(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10831, 2729, 2836);
                return 0;
            }

        }
    }
}
