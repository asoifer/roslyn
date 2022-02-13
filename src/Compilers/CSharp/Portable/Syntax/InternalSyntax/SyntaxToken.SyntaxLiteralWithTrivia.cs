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
        internal class SyntaxTokenWithValueAndTrivia<T> : SyntaxTokenWithValue<T>
        {
            static SyntaxTokenWithValueAndTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10833, 490, 696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 561, 681);

                    f_10833_561_680(typeof(SyntaxTokenWithValueAndTrivia<T>), r => new SyntaxTokenWithValueAndTrivia<T>(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10833, 490, 696);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 490, 696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 490, 696);
                }
            }

            private readonly GreenNode _leading;

            private readonly GreenNode _trailing;

            internal SyntaxTokenWithValueAndTrivia(SyntaxKind kind, string text, T value, GreenNode leading, GreenNode trailing)
            : base(f_10833_956_960_C(kind), text, value)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10833, 815, 1354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 739, 747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 789, 798);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1007, 1162) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10833, 1007, 1162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1068, 1102);

                        f_10833_1068_1101(this, leading);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1124, 1143);

                        _leading = leading;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10833, 1007, 1162);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1180, 1339) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10833, 1180, 1339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1242, 1277);

                        f_10833_1242_1276(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1299, 1320);

                        _trailing = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10833, 1180, 1339);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10833, 815, 1354);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 815, 1354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 815, 1354);
                }
            }

            internal SyntaxTokenWithValueAndTrivia(
                            SyntaxKind kind,
                            string text,
                            T value,
                            GreenNode leading,
                            GreenNode trailing,
                            DiagnosticInfo[] diagnostics,
                            SyntaxAnnotation[] annotations)
            : base(f_10833_1693_1697_C(kind), text, value, diagnostics, annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10833, 1370, 2117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 739, 747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 789, 798);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1770, 1925) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10833, 1770, 1925);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1831, 1865);

                        f_10833_1831_1864(this, leading);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1887, 1906);

                        _leading = leading;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10833, 1770, 1925);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 1943, 2102) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10833, 1943, 2102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2005, 2040);

                        f_10833_2005_2039(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2062, 2083);

                        _trailing = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10833, 1943, 2102);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10833, 1370, 2117);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 1370, 2117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 1370, 2117);
                }
            }

            internal SyntaxTokenWithValueAndTrivia(ObjectReader reader)
            : base(f_10833_2217_2223_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10833, 2133, 2729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 739, 747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 789, 798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2257, 2301);

                    var
                    leading = (GreenNode)f_10833_2282_2300(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2319, 2474) || true) && (leading != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10833, 2319, 2474);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2380, 2414);

                        f_10833_2380_2413(this, leading);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2436, 2455);

                        _leading = leading;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10833, 2319, 2474);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2492, 2537);

                    var
                    trailing = (GreenNode)f_10833_2518_2536(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2555, 2714) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10833, 2555, 2714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2617, 2652);

                        f_10833_2617_2651(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2674, 2695);

                        _trailing = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10833, 2555, 2714);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10833, 2133, 2729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 2133, 2729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 2133, 2729);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10833, 2745, 2958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2829, 2850);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10833, 2829, 2849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2868, 2896);

                    f_10833_2868_2895(writer, _leading);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 2914, 2943);

                    f_10833_2914_2942(writer, _trailing);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10833, 2745, 2958);

                    int
                    f_10833_2868_2895(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 2868, 2895);
                        return 0;
                    }


                    int
                    f_10833_2914_2942(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 2914, 2942);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 2745, 2958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 2745, 2958);
                }
            }

            public override GreenNode GetLeadingTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10833, 2974, 3082);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 3051, 3067);

                    return _leading;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10833, 2974, 3082);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 2974, 3082);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 2974, 3082);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override GreenNode GetTrailingTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10833, 3098, 3208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 3176, 3193);

                    return _trailing;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10833, 3098, 3208);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 3098, 3208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 3098, 3208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10833, 3224, 3493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 3325, 3478);

                    return f_10833_3332_3477(f_10833_3369_3378(this), this.TextField, this.ValueField, trivia, _trailing, f_10833_3432_3453(this), f_10833_3455_3476(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10833, 3224, 3493);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10833_3369_3378(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10833, 3369, 3378);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10833_3432_3453(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 3432, 3453);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10833_3455_3476(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 3455, 3476);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    f_10833_3332_3477(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, string
                    text, T
                    value, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 3332, 3477);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 3224, 3493);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 3224, 3493);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10833, 3509, 3778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 3611, 3763);

                    return f_10833_3618_3762(f_10833_3655_3664(this), this.TextField, this.ValueField, _leading, trivia, f_10833_3717_3738(this), f_10833_3740_3761(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10833, 3509, 3778);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10833_3655_3664(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10833, 3655, 3664);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10833_3717_3738(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 3717, 3738);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10833_3740_3761(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 3740, 3761);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    f_10833_3618_3762(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, string
                    text, T
                    value, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 3618, 3762);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 3509, 3778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 3509, 3778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[] diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10833, 3794, 4059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 3899, 4044);

                    return f_10833_3906_4043(f_10833_3943_3952(this), this.TextField, this.ValueField, _leading, _trailing, diagnostics, f_10833_4021_4042(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10833, 3794, 4059);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10833_3943_3952(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10833, 3943, 3952);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10833_4021_4042(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 4021, 4042);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    f_10833_3906_4043(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, string
                    text, T
                    value, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 3906, 4043);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 3794, 4059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 3794, 4059);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[] annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10833, 4075, 4342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10833, 4182, 4327);

                    return f_10833_4189_4326(f_10833_4226_4235(this), this.TextField, this.ValueField, _leading, _trailing, f_10833_4291_4312(this), annotations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10833, 4075, 4342);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10833_4226_4235(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10833, 4226, 4235);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10833_4291_4312(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 4291, 4312);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    f_10833_4189_4326(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, string
                    text, T
                    value, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 4189, 4326);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10833, 4075, 4342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10833, 4075, 4342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10833, 392, 4353);

            static int
            f_10833_561_680(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 561, 680);
                return 0;
            }


            int
            f_10833_1068_1101(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 1068, 1101);
                return 0;
            }


            int
            f_10833_1242_1276(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 1242, 1276);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10833_956_960_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10833, 815, 1354);
                return return_v;
            }


            int
            f_10833_1831_1864(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 1831, 1864);
                return 0;
            }


            int
            f_10833_2005_2039(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 2005, 2039);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10833_1693_1697_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10833, 1370, 2117);
                return return_v;
            }


            object
            f_10833_2282_2300(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 2282, 2300);
                return return_v;
            }


            int
            f_10833_2380_2413(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 2380, 2413);
                return 0;
            }


            object
            f_10833_2518_2536(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 2518, 2536);
                return return_v;
            }


            int
            f_10833_2617_2651(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10833, 2617, 2651);
                return 0;
            }


            static Roslyn.Utilities.ObjectReader
            f_10833_2217_2223_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10833, 2133, 2729);
                return return_v;
            }

        }
    }
}
