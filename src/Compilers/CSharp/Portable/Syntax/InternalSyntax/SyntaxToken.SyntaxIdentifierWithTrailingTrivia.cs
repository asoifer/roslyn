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
        internal class SyntaxIdentifierWithTrailingTrivia : SyntaxIdentifier
        {
            private readonly GreenNode _trailing;

            internal SyntaxIdentifierWithTrailingTrivia(string text, GreenNode trailing)
            : base(f_10830_639_643_C(text))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10830, 538, 851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 512, 521);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 677, 836) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10830, 677, 836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 739, 774);

                        f_10830_739_773(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 796, 817);

                        _trailing = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10830, 677, 836);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10830, 538, 851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 538, 851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 538, 851);
                }
            }

            internal SyntaxIdentifierWithTrailingTrivia(string text, GreenNode trailing, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
            : base(f_10830_1030_1034_C(text), diagnostics, annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10830, 867, 1268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 512, 521);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 1094, 1253) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10830, 1094, 1253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 1156, 1191);

                        f_10830_1156_1190(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 1213, 1234);

                        _trailing = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10830, 1094, 1253);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10830, 867, 1268);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 867, 1268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 867, 1268);
                }
            }

            internal SyntaxIdentifierWithTrailingTrivia(ObjectReader reader)
            : base(f_10830_1373_1379_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10830, 1284, 1650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 512, 521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 1413, 1458);

                    var
                    trailing = (GreenNode)f_10830_1439_1457(reader)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 1476, 1635) || true) && (trailing != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10830, 1476, 1635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 1538, 1573);

                        f_10830_1538_1572(this, trailing);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 1595, 1616);

                        _trailing = trailing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10830, 1476, 1635);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10830, 1284, 1650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 1284, 1650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 1284, 1650);
                }
            }

            static SyntaxIdentifierWithTrailingTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10830, 1666, 1881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 1742, 1866);

                    f_10830_1742_1865(typeof(SyntaxIdentifierWithTrailingTrivia), r => new SyntaxIdentifierWithTrailingTrivia(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10830, 1666, 1881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 1666, 1881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 1666, 1881);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10830, 1897, 2064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 1981, 2002);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10830, 1981, 2001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 2020, 2049);

                    f_10830_2020_2048(writer, _trailing);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10830, 1897, 2064);

                    int
                    f_10830_2020_2048(Roslyn.Utilities.ObjectWriter
                    this_param, Microsoft.CodeAnalysis.GreenNode
                    value)
                    {
                        this_param.WriteValue((Roslyn.Utilities.IObjectWritable)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 2020, 2048);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 1897, 2064);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 1897, 2064);
                }
            }

            public override GreenNode GetTrailingTrivia()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10830, 2080, 2190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 2158, 2175);

                    return _trailing;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10830, 2080, 2190);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 2080, 2190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 2080, 2190);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10830, 2206, 2468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 2307, 2453);

                    return f_10830_2314_2452(f_10830_2345_2354(this), this.TextField, this.TextField, trivia, _trailing, f_10830_2407_2428(this), f_10830_2430_2451(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10830, 2206, 2468);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10830_2345_2354(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10830, 2345, 2354);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10830_2407_2428(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 2407, 2428);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10830_2430_2451(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 2430, 2451);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia
                    f_10830_2314_2452(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    contextualKind, string
                    text, string
                    valueText, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrivia(contextualKind, text, valueText, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 2314, 2452);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 2206, 2468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 2206, 2468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10830, 2484, 2717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 2586, 2702);

                    return f_10830_2593_2701(this.TextField, trivia, f_10830_2656_2677(this), f_10830_2679_2700(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10830, 2484, 2717);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10830_2656_2677(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 2656, 2677);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10830_2679_2700(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 2679, 2700);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    f_10830_2593_2701(string
                    text, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia(text, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 2593, 2701);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 2484, 2717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 2484, 2717);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[] diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10830, 2733, 2962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 2838, 2947);

                    return f_10830_2845_2946(this.TextField, _trailing, diagnostics, f_10830_2924_2945(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10830, 2733, 2962);

                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10830_2924_2945(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 2924, 2945);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    f_10830_2845_2946(string
                    text, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia(text, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 2845, 2946);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 2733, 2962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 2733, 2962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[] annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10830, 2978, 3209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10830, 3085, 3194);

                    return f_10830_3092_3193(this.TextField, _trailing, f_10830_3158_3179(this), annotations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10830, 2978, 3209);

                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10830_3158_3179(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 3158, 3179);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
                    f_10830_3092_3193(string
                    text, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia(text, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 3092, 3193);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10830, 2978, 3209);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10830, 2978, 3209);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10830, 392, 3220);

            int
            f_10830_739_773(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 739, 773);
                return 0;
            }


            static string
            f_10830_639_643_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10830, 538, 851);
                return return_v;
            }


            int
            f_10830_1156_1190(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 1156, 1190);
                return 0;
            }


            static string
            f_10830_1030_1034_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10830, 867, 1268);
                return return_v;
            }


            object
            f_10830_1439_1457(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 1439, 1457);
                return return_v;
            }


            int
            f_10830_1538_1572(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxIdentifierWithTrailingTrivia
            this_param, Microsoft.CodeAnalysis.GreenNode
            node)
            {
                this_param.AdjustFlagsAndWidth(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 1538, 1572);
                return 0;
            }


            static Roslyn.Utilities.ObjectReader
            f_10830_1373_1379_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10830, 1284, 1650);
                return return_v;
            }


            static int
            f_10830_1742_1865(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10830, 1742, 1865);
                return 0;
            }

        }
    }
}
