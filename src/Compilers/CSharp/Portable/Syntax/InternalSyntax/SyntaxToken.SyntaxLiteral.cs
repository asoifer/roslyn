// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Roslyn.Utilities;
using System.Globalization;

namespace Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax
{
    internal partial class SyntaxToken
    {
        internal class SyntaxTokenWithValue<T> : SyntaxToken
        {
            protected readonly string TextField;

            protected readonly T ValueField;

            internal SyntaxTokenWithValue(SyntaxKind kind, string text, T value)
            : base(f_10832_689_693_C(kind), f_10832_695_706(text))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10832, 596, 819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 524, 533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 569, 579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 740, 762);

                    this.TextField = text;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 780, 804);

                    this.ValueField = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10832, 596, 819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 596, 819);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 596, 819);
                }
            }

            internal SyntaxTokenWithValue(SyntaxKind kind, string text, T value, DiagnosticInfo[] diagnostics, SyntaxAnnotation[] annotations)
            : base(f_10832_990_994_C(kind), f_10832_996_1007(text), diagnostics, annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10832, 835, 1146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 524, 533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 569, 579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 1067, 1089);

                    this.TextField = text;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 1107, 1131);

                    this.ValueField = value;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10832, 835, 1146);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 835, 1146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 835, 1146);
                }
            }

            internal SyntaxTokenWithValue(ObjectReader reader)
            : base(f_10832_1237_1243_C(reader))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10832, 1162, 1444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 524, 533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 569, 579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 1277, 1314);

                    this.TextField = f_10832_1294_1313(reader);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 1332, 1371);

                    this.FullWidth = f_10832_1349_1370(this.TextField);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 1389, 1429);

                    this.ValueField = (T)f_10832_1410_1428(reader);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10832, 1162, 1444);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 1162, 1444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 1162, 1444);
                }
            }

            static SyntaxTokenWithValue()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10832, 1460, 1639);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 1522, 1624);

                    f_10832_1522_1623(typeof(SyntaxTokenWithValue<T>), r => new SyntaxTokenWithValue<T>(r));
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10832, 1460, 1639);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 1460, 1639);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 1460, 1639);
                }
            }

            internal override void WriteTo(ObjectWriter writer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10832, 1655, 1881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 1739, 1760);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.WriteTo(writer), 10832, 1739, 1759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 1778, 1813);

                    f_10832_1778_1812(writer, this.TextField);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 1831, 1866);

                    f_10832_1831_1865(writer, this.ValueField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10832, 1655, 1881);

                    int
                    f_10832_1778_1812(Roslyn.Utilities.ObjectWriter
                    this_param, string
                    value)
                    {
                        this_param.WriteString(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 1778, 1812);
                        return 0;
                    }


                    int
                    f_10832_1831_1865(Roslyn.Utilities.ObjectWriter
                    this_param, T
                    value)
                    {
                        this_param.WriteValue((object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 1831, 1865);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 1655, 1881);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 1655, 1881);
                }
            }

            public override string Text
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10832, 1957, 2042);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 2001, 2023);

                        return this.TextField;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10832, 1957, 2042);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 1897, 2057);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 1897, 2057);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10832, 2134, 2220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 2178, 2201);

                        return this.ValueField;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10832, 2134, 2220);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 2073, 2235);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 2073, 2235);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10832, 2316, 2450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 2360, 2431);

                        return f_10832_2367_2430(this.ValueField, f_10832_2401_2429());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10832, 2316, 2450);

                        System.Globalization.CultureInfo
                        f_10832_2401_2429()
                        {
                            var return_v = CultureInfo.InvariantCulture;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10832, 2401, 2429);
                            return return_v;
                        }


                        string?
                        f_10832_2367_2430(T
                        value, System.Globalization.CultureInfo
                        provider)
                        {
                            var return_v = Convert.ToString((object)value, (System.IFormatProvider)provider);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 2367, 2430);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 2251, 2465);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 2251, 2465);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override SyntaxToken TokenWithLeadingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10832, 2481, 2745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 2582, 2730);

                    return f_10832_2589_2729(f_10832_2626_2635(this), this.TextField, this.ValueField, trivia, null, f_10832_2684_2705(this), f_10832_2707_2728(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10832, 2481, 2745);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10832_2626_2635(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10832, 2626, 2635);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10832_2684_2705(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 2684, 2705);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10832_2707_2728(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 2707, 2728);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    f_10832_2589_2729(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, string
                    text, T
                    value, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 2589, 2729);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 2481, 2745);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 2481, 2745);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override SyntaxToken TokenWithTrailingTrivia(GreenNode trivia)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10832, 2761, 3026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 2863, 3011);

                    return f_10832_2870_3010(f_10832_2907_2916(this), this.TextField, this.ValueField, null, trivia, f_10832_2965_2986(this), f_10832_2988_3009(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10832, 2761, 3026);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10832_2907_2916(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10832, 2907, 2916);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10832_2965_2986(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 2965, 2986);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10832_2988_3009(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 2988, 3009);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>
                    f_10832_2870_3010(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, string
                    text, T
                    value, Microsoft.CodeAnalysis.GreenNode
                    leading, Microsoft.CodeAnalysis.GreenNode
                    trailing, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValueAndTrivia<T>(kind, text, value, leading, trailing, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 2870, 3010);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 2761, 3026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 2761, 3026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetDiagnostics(DiagnosticInfo[] diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10832, 3042, 3277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 3147, 3262);

                    return f_10832_3154_3261(f_10832_3182_3191(this), this.TextField, this.ValueField, diagnostics, f_10832_3239_3260(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10832, 3042, 3277);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10832_3182_3191(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10832, 3182, 3191);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    f_10832_3239_3260(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.GetAnnotations();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 3239, 3260);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    f_10832_3154_3261(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, string
                    text, T
                    value, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>(kind, text, value, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 3154, 3261);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 3042, 3277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 3042, 3277);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override GreenNode SetAnnotations(SyntaxAnnotation[] annotations)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10832, 3293, 3530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10832, 3400, 3515);

                    return f_10832_3407_3514(f_10832_3435_3444(this), this.TextField, this.ValueField, f_10832_3479_3500(this), annotations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10832, 3293, 3530);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10832_3435_3444(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10832, 3435, 3444);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo[]
                    f_10832_3479_3500(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    this_param)
                    {
                        var return_v = this_param.GetDiagnostics();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 3479, 3500);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>
                    f_10832_3407_3514(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    kind, string
                    text, T
                    value, Microsoft.CodeAnalysis.DiagnosticInfo[]
                    diagnostics, Microsoft.CodeAnalysis.SyntaxAnnotation[]
                    annotations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken.SyntaxTokenWithValue<T>(kind, text, value, diagnostics, annotations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 3407, 3514);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10832, 3293, 3530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10832, 3293, 3530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10832, 421, 3541);

            static int
            f_10832_695_706(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10832, 695, 706);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10832_689_693_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10832, 596, 819);
                return return_v;
            }


            static int
            f_10832_996_1007(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10832, 996, 1007);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.SyntaxKind
            f_10832_990_994_C(Microsoft.CodeAnalysis.CSharp.SyntaxKind
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10832, 835, 1146);
                return return_v;
            }


            string
            f_10832_1294_1313(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 1294, 1313);
                return return_v;
            }


            int
            f_10832_1349_1370(string
            this_param)
            {
                var return_v = this_param.Length;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10832, 1349, 1370);
                return return_v;
            }


            object
            f_10832_1410_1428(Roslyn.Utilities.ObjectReader
            this_param)
            {
                var return_v = this_param.ReadValue();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 1410, 1428);
                return return_v;
            }


            static Roslyn.Utilities.ObjectReader
            f_10832_1237_1243_C(Roslyn.Utilities.ObjectReader
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10832, 1162, 1444);
                return return_v;
            }


            static int
            f_10832_1522_1623(System.Type
            type, System.Func<Roslyn.Utilities.ObjectReader, Roslyn.Utilities.IObjectWritable>
            typeReader)
            {
                ObjectBinder.RegisterTypeReader(type, typeReader);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10832, 1522, 1623);
                return 0;
            }

        }
    }
}
