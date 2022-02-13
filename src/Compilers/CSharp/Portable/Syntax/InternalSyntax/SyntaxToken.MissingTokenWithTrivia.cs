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
        internal class MissingTokenWithTrivia : SyntaxTokenWithTrivia
        {
            internal MissingTokenWithTrivia(SyntaxKind kind, GreenNode leading, GreenNode trailing)
            : base(f_10827_590_594_C(kind), leading, trailing)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10827, 478, 700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 647, 685);

                    this.flags &= ~NodeFlags.IsNotMissing;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10827, 478, 700);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 478, 700);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 478, 700);
                }
            }

            internal MissingTokenWithTrivia(SyntaxKind kind, GreenNode leading, GreenNode trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
            : base(f_10827_890_894_C(kind), leading, trailing, diagnostics, annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10827, 716, 1026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 973, 1011);

                    this.flags &= ~NodeFlags.IsNotMissing;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10827, 716, 1026);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 716, 1026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 716, 1026);
                }
            }

            internal MissingTokenWithTrivia(ObjectReader reader)
            : base(f_10827_1119_1125_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10827, 1042, 1212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 1159, 1197);

                    this.flags &= ~NodeFlags.IsNotMissing;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10827, 1042, 1212);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 1042, 1212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 1042, 1212);
                }
            }

            static MissingTokenWithTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10827, 1228, 1407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 1292, 1392);

                    f_10827_1292_1391(typeof(MissingTokenWithTrivia), r => new MissingTokenWithTrivia(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10827, 1228, 1407);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 1228, 1407);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 1228, 1407);
                }
            }

            public override string Text
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10827, 1483, 1511);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 1489, 1509);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10827, 1483, 1511);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 1423, 1526);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 1423, 1526);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10827, 1603, 1914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 1647, 1895);

                        switch (f_10827_1655_1664(this))
                        {

                            case SyntaxKind.IdentifierToken:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10827, 1647, 1895);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 1776, 1796);

                                return string.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10827, 1647, 1895);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10827, 1647, 1895);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 1860, 1872);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10827, 1647, 1895);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10827, 1603, 1914);

                        Microsoft.CodeAnalysis.CSharp.SyntaxKind
                        f_10827_1655_1664(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10827, 1655, 1664);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 1542, 1929);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 1542, 1929);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override SyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10827, 1945, 2180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 2046, 2165);

                    return f_10827_2053_2164(f_10827_2080_2089(this), trivia, this.TrailingField, f_10827_2119_2140(this), f_10827_2142_2163(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10827, 1945, 2180);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10827_2080_2089(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10827, 2080, 2089);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10827_2119_2140(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2119, 2140);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10827_2142_2163(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2142, 2163);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    f_10827_2053_2164(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2053, 2164);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 1945, 2180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 1945, 2180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10827, 2196, 2431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 2298, 2416);

                    return f_10827_2305_2415(f_10827_2332_2341(this), this.LeadingField, trivia, f_10827_2370_2391(this), f_10827_2393_2414(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10827, 2196, 2431);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10827_2332_2341(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10827, 2332, 2341);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10827_2370_2391(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2370, 2391);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10827_2393_2414(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2393, 2414);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    f_10827_2305_2415(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2305, 2415);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 2196, 2431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 2196, 2431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[] diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10827, 2447, 2687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 2552, 2672);

                    return f_10827_2559_2671(f_10827_2586_2595(this), this.LeadingField, this.TrailingField, diagnostics, f_10827_2649_2670(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10827, 2447, 2687);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10827_2586_2595(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10827, 2586, 2595);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10827_2649_2670(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2649, 2670);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    f_10827_2559_2671(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2559, 2671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 2447, 2687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 2447, 2687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[] annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10827, 2703, 2945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10827, 2810, 2930);

                    return f_10827_2817_2929(f_10827_2844_2853(this), this.LeadingField, this.TrailingField, f_10827_2894_2915(this), annotations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10827, 2703, 2945);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10827_2844_2853(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10827, 2844, 2853);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10827_2894_2915(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2894, 2915);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia
                    f_10827_2817_2929(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.MissingTokenWithTrivia(kind, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 2817, 2929);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10827, 2703, 2945);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10827, 2703, 2945);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10827, 392, 2956);

            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10827_590_594_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10827, 478, 700);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10827_890_894_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10827, 716, 1026);
                return return_v;
            }


            static Roslyn.Utilities.ObjectReader
            f_10827_1119_1125_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10827, 1042, 1212);
                return return_v;
            }


            static int
            f_10827_1292_1391(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10827, 1292, 1391);
                return 0;
            }

        }
    }
}
