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
        internal class SyntaxTokenWithTrivia : SyntaxToken
        {
            static SyntaxTokenWithTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10834, 467, 643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 530, 628);

                    f_10834_530_627(typeof(SyntaxTokenWithTrivia), r => new SyntaxTokenWithTrivia(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10834, 467, 643);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 467, 643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 467, 643);
                }
            }

            protected readonly GreenNode LeadingField;

            protected readonly GreenNode TrailingField;

            internal SyntaxTokenWithTrivia(SyntaxKind kind, GreenNode leading, GreenNode trailing)
            : base(f_10834_885_889_C(kind))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10834, 774, 1288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 688, 700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 744, 757);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 923, 1087) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10834, 923, 1087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 984, 1018);

                        f_10834_984_1017(this, leading);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1040, 1068);

                        this.LeadingField = leading;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10834, 923, 1087);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1105, 1273) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10834, 1105, 1273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1167, 1202);

                        f_10834_1167_1201(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1224, 1254);

                        this.TrailingField = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10834, 1105, 1273);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10834, 774, 1288);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 774, 1288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 774, 1288);
                }
            }

            internal SyntaxTokenWithTrivia(SyntaxKind kind, GreenNode leading, GreenNode trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
            : base(f_10834_1477_1481_C(kind), diagnostics, annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10834, 1304, 1906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 688, 700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 744, 757);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1541, 1705) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10834, 1541, 1705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1602, 1636);

                        f_10834_1602_1635(this, leading);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1658, 1686);

                        this.LeadingField = leading;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10834, 1541, 1705);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1723, 1891) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10834, 1723, 1891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1785, 1820);

                        f_10834_1785_1819(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 1842, 1872);

                        this.TrailingField = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10834, 1723, 1891);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10834, 1304, 1906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 1304, 1906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 1304, 1906);
                }
            }

            internal SyntaxTokenWithTrivia(ObjectReader reader)
            : base(f_10834_1998_2004_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10834, 1922, 2528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 688, 700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 744, 757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2038, 2082);

                    var
                    leading = (GreenNode)f_10834_2063_2081(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2100, 2264) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10834, 2100, 2264);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2161, 2195);

                        f_10834_2161_2194(this, leading);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2217, 2245);

                        this.LeadingField = leading;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10834, 2100, 2264);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2282, 2327);

                    var
                    trailing = (GreenNode)f_10834_2308_2326(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2345, 2513) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10834, 2345, 2513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2407, 2442);

                        f_10834_2407_2441(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2464, 2494);

                        this.TrailingField = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10834, 2345, 2513);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10834, 1922, 2528);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 1922, 2528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 1922, 2528);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10834, 2544, 2775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2628, 2649);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10834, 2628, 2648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2667, 2704);

                    f_10834_2667_2703(writer, this.LeadingField);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2722, 2760);

                    f_10834_2722_2759(writer, this.TrailingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10834, 2544, 2775);

                    int
                    f_10834_2667_2703(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 2667, 2703);
                        return 0;
                    }


                    int
                    f_10834_2722_2759(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 2722, 2759);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 2544, 2775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 2544, 2775);
                }
            }

            public override GreenNode GetLeadingTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10834, 2791, 2908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 2868, 2893);

                    return this.LeadingField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10834, 2791, 2908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 2791, 2908);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 2791, 2908);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override GreenNode GetTrailingTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10834, 2924, 3043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 3002, 3028);

                    return this.TrailingField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10834, 2924, 3043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 2924, 3043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 2924, 3043);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10834, 3059, 3293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 3160, 3278);

                    return f_10834_3167_3277(f_10834_3193_3202(this), trivia, this.TrailingField, f_10834_3232_3253(this), f_10834_3255_3276(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10834, 3059, 3293);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10834_3193_3202(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10834, 3193, 3202);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10834_3232_3253(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 3232, 3253);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10834_3255_3276(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 3255, 3276);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    f_10834_3167_3277(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 3167, 3277);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 3059, 3293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 3059, 3293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10834, 3309, 3543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 3411, 3528);

                    return f_10834_3418_3527(f_10834_3444_3453(this), this.LeadingField, trivia, f_10834_3482_3503(this), f_10834_3505_3526(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10834, 3309, 3543);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10834_3444_3453(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10834, 3444, 3453);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10834_3482_3503(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 3482, 3503);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10834_3505_3526(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 3505, 3526);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    f_10834_3418_3527(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 3418, 3527);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 3309, 3543);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 3309, 3543);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[] diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10834, 3559, 3798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 3664, 3783);

                    return f_10834_3671_3782(f_10834_3697_3706(this), this.LeadingField, this.TrailingField, diagnostics, f_10834_3760_3781(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10834, 3559, 3798);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10834_3697_3706(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10834, 3697, 3706);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10834_3760_3781(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 3760, 3781);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    f_10834_3671_3782(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 3671, 3782);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 3559, 3798);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 3559, 3798);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[] annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10834, 3814, 4055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10834, 3921, 4040);

                    return f_10834_3928_4039(f_10834_3954_3963(this), this.LeadingField, this.TrailingField, f_10834_4004_4025(this), annotations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10834, 3814, 4055);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10834_3954_3963(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10834, 3954, 3963);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10834_4004_4025(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 4004, 4025);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
                    f_10834_3928_4039(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 3928, 4039);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10834, 3814, 4055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10834, 3814, 4055);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10834, 392, 4066);

            static int
            f_10834_530_627(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 530, 627);
                return 0;
            }


            int
            f_10834_984_1017(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 984, 1017);
                return 0;
            }


            int
            f_10834_1167_1201(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 1167, 1201);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10834_885_889_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10834, 774, 1288);
                return return_v;
            }


            int
            f_10834_1602_1635(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 1602, 1635);
                return 0;
            }


            int
            f_10834_1785_1819(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 1785, 1819);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10834_1477_1481_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10834, 1304, 1906);
                return return_v;
            }


            object
            f_10834_2063_2081(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 2063, 2081);
                return return_v;
            }


            int
            f_10834_2161_2194(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 2161, 2194);
                return 0;
            }


            object
            f_10834_2308_2326(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 2308, 2326);
                return return_v;
            }


            int
            f_10834_2407_2441(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10834, 2407, 2441);
                return 0;
            }


            static Roslyn.Utilities.ObjectReader
            f_10834_1998_2004_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10834, 1922, 2528);
                return return_v;
            }

        }
    }
}
