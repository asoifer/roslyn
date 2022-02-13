// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public class FlowTests : CSharpTestBase
    {
        private const string
        prefix = @"
using System;

// Need a base class with indexers.
public class DATestBase {
    public int this[int a] { get { return 0; } }
    public int this[int a, int b] { get { return 0; } }
}

// Need a struct with a couple fields.
public struct A {
    public int x;
    public int y;
}

// Need a struct with non-lifted short-circuiting operators.
public struct NLS
{
    public static NLS operator&(NLS a, NLS b) { return new NLS { value = a.value & b.value }; }
    public static NLS operator|(NLS a, NLS b) { return new NLS { value = a.value | b.value }; }
    public static bool operator true(NLS a) { return a.value; }
    public static bool operator false(NLS a) { return !a.value; }

    public bool value;
}

// Need a struct with lifted short-circuiting operators.
public struct LS
{
    public static LS operator&(LS a, LS b) { return new LS { value = a.value & b.value }; }
    public static LS operator|(LS a, LS b) { return new LS { value = a.value | b.value }; }
    public static bool operator true(LS? a) { return a.HasValue && a.Value.value; }
    public static bool operator false(LS? a) { return a.HasValue && !a.Value.value; }

    public bool value;
}

public delegate void D(); public delegate int DI();
public delegate void DefP(int a, ref int b, out int c);

public class DATest : DATestBase {
    public static volatile bool f;
    public static volatile int val;
    public static volatile byte b;
    public const bool fTrue = true;
    public const bool fFalse = false;
    public static int[] arr = { 1, 2, 3 };

    public static bool No() { return f; } // No-op
    public static bool F(int x) { return f; }
    public static bool G(out int x) { x = 0; return f; }
    public static bool Q(bool x) { return f; }
    public static bool S(A x) { return f; }
    public static int NNo() { return val; } // No-op
    public static int NF(int x) { return val; }
    public static int NG(out int x) { x = 0; return val; }
    public static int[] AF(int x) { return arr; }
    public static int[] AG(out int x) { x = 0; return arr; }
    public static int FA(int[] x) { return val; }
    public static int GA(out int[] x) { x = arr; return val; }
    public static IDisposable Res(bool x) { return null; }
    public static bool FP(params int[] x) { return f; }
    public static bool GP(out int x, params int[] y) { x = 0; return f; }
    public static NLS GetNLS() { return new NLS { value = f }; }
    public static NLS GetNLS(out int x) { x = 0; return new NLS { value = f }; }
    public static LS GetLS() { return new LS { value = f }; }
    public static LS? GetLS(out int x) { x = 0; return new LS { value = f }; }

    public class C {
        public C(params int[] x) { }
        public C(out int x, params int[] y) { x = 0; }
    }
"
        ;

        private const string
        suffix = @"
}"
        ;

        [Fact]
        [WorkItem(35011, "https://github.com/dotnet/roslyn/issues/35011")]
        public void SwitchConstantUnreachable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 3553, 6180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 3709, 4615);

                var
                src = @"
class C
{
    const string S = ""abc"";

    public static string M1()
    {
        switch (S)
        {
            case ""abc"":
                return S;
        }
    }

    public static string M2()
    {
        const string S2 = S + """";
        switch (S)
        {
            case S2:
                return S;
        }
    }

    public static string M3()
    {
        const int I = 11;
        switch (I)
        {
            case 11:
                return S;
        }
    }

    public static string M4()
    {
        switch (S)
        {
            case ""def"":
                return S; // 1
            default:
                return S;
        }
    }

    public static string M5()
    {
        switch (S)
        {
            case ""def"":
                return S; // 2
        }
        // error
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 4631, 4665);

                var
                comp = f_28002_4642_4664(src)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 4679, 5376);

                f_28002_4679_5375(comp, f_28002_4842_4914(f_28002_4842_4893(ErrorCode.WRN_UnreachableCode, "return"), 40, 17), f_28002_5070_5161(f_28002_5070_5140(f_28002_5070_5116(ErrorCode.ERR_ReturnExpected, "M5"), "C.M5()"), 46, 26), f_28002_5302_5374(f_28002_5302_5353(ErrorCode.WRN_UnreachableCode, "return"), 51, 17));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 5390, 5458);

                comp = f_28002_5397_5457(src, parseOptions: TestOptions.Regular7_3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 5472, 6169);

                f_28002_5472_6168(comp, f_28002_5635_5707(f_28002_5635_5686(ErrorCode.WRN_UnreachableCode, "return"), 40, 17), f_28002_5863_5954(f_28002_5863_5933(f_28002_5863_5909(ErrorCode.ERR_ReturnExpected, "M5"), "C.M5()"), 46, 26), f_28002_6095_6167(f_28002_6095_6146(ErrorCode.WRN_UnreachableCode, "return"), 51, 17));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 3553, 6180);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_4642_4664(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 4642, 4664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_4842_4893(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 4842, 4893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_4842_4914(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 4842, 4914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5070_5116(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5070, 5116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5070_5140(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5070, 5140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5070_5161(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5070, 5161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5302_5353(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5302, 5353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5302_5374(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5302, 5374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_4679_5375(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 4679, 5375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_5397_5457(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5397, 5457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5635_5686(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5635, 5686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5635_5707(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5635, 5707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5863_5909(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5863, 5909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5863_5933(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5863, 5933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_5863_5954(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5863, 5954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_6095_6146(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 6095, 6146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_6095_6167(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 6095, 6167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_5472_6168(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 5472, 6168);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 3553, 6180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 3553, 6180);
            }
        }

        [Fact]
        public void General()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 6192, 9467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 6254, 7209);

                var
                source = prefix + @"
    // Value params and ref params are definitely assigned. Out params are not.
    public void T000(int a) { F(a); }
    public void T001(ref int a) { F(a); }
    public void T002(out int a) { F(a); G(out a); } // Error

    // Out params must be definitely assigned before leaving.
    public void T010(out int a) { } // Error
    public void T011(out int a) { G(out a); }
    public void T012(out int a) { if (f) G(out a); } // Error
    public void T013(out int a) { if (fTrue) G(out a); }
    public void T014(out int a) { if (f) G(out a); else throw new Exception(); }

    // General.
    public void T020() {
        { int a; F(a); } // Error
        { int a; if (fTrue) F(a); } // Error
        { int a; if (fFalse) F(a); } // Unreachable
        { int a; if (fFalse) F(a); else F(a); } // Error + Unreachable
        { int a; if (fFalse) F(a); else G(out a); F(a); } // Unreachable
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 7225, 9456);

                f_28002_7225_9455(f_28002_7225_7250(source), f_28002_7447_7515(f_28002_7447_7496(ErrorCode.ERR_UseDefViolationOut, "a"), "a"), f_28002_7725_7793(f_28002_7725_7774(ErrorCode.ERR_ParamUnassigned, "T010"), "a"), f_28002_8020_8088(f_28002_8020_8069(ErrorCode.ERR_ParamUnassigned, "T012"), "a"), f_28002_8250_8296(ErrorCode.WRN_UnreachableCode, "F"), f_28002_8477_8523(ErrorCode.WRN_UnreachableCode, "F"), f_28002_8706_8752(ErrorCode.WRN_UnreachableCode, "F"), f_28002_8905_8970(f_28002_8905_8951(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_9134_9199(f_28002_9134_9180(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_9389_9454(f_28002_9389_9435(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 6192, 9467);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_7225_7250(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 7225, 7250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_7447_7496(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 7447, 7496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_7447_7515(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 7447, 7515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_7725_7774(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 7725, 7774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_7725_7793(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 7725, 7793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_8020_8069(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 8020, 8069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_8020_8088(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 8020, 8088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_8250_8296(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 8250, 8296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_8477_8523(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 8477, 8523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_8706_8752(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 8706, 8752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_8905_8951(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 8905, 8951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_8905_8970(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 8905, 8970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_9134_9180(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 9134, 9180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_9134_9199(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 9134, 9199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_9389_9435(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 9389, 9435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_9389_9454(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 9389, 9454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_7225_9455(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 7225, 9455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 6192, 9467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 6192, 9467);
            }
        }

        [Fact]
        public void IfStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 9479, 29723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 9545, 15129);

                var
                source = prefix + @"
    // If statement.
    public void T100() {
        { int a; if (F(a)) No(); } // Error
        { int a; if (F(a)) No(); else No(); } // Error

        { int a; if (f) F(a); } // Error
        { int a; if (f) F(a); else No(); } // Error
        { int a; if (f) No(); else F(a); } // Error

        { int a; if (fFalse) F(a); } // Unreachable
        { int a; if (fFalse) F(a); else No(); } // Unreachable
        { int a; if (fFalse) No(); else F(a); } // Error + Unreachable

        { int a; if (fTrue) F(a); } // Error
        { int a; if (fTrue) F(a); else No(); } // Error + Unreachable
        { int a; if (fTrue) No(); else F(a); } // Unreachable

        { int a; if (G(out a)) F(a); }
        { int a; if (G(out a)) F(a); else No(); }
        { int a; if (G(out a)) No(); else F(a); }
        { int a; if (G(out a)) No(); F(a); }
        { int a; if (G(out a)) No(); else No(); F(a); }

        // Assigned after true.
        { int a; if (f && G(out a)) F(a); }
        { int a; if (f && G(out a)) F(a); else No(); }
        { int a; if (f && G(out a)) No(); else F(a); } // Error
        { int a; if (f && G(out a)) No(); F(a); } // Error
        { int a; if (f && G(out a)) No(); else No(); F(a); } // Error
        { int a; if (f && G(out a)) No(); else G(out a); F(a); }

        // Unassigned due to user-defined operators.
        { int a; if (GetNLS() && GetNLS(out a)) F(a); } // error
        { int a; if (GetLS() && GetLS(out a)) F(a); } // error
        { int a; if (f && G(out a)) F(a); else No(); } // error
        { int a; if (f && G(out a)) F(a); else No(); } // error
        { int a; if (GetNLS() && GetNLS(out a)) No(); else F(a); } // Error
        { int a; if (GetLS() && GetLS(out a)) No(); else F(a); } // Error
        { int a; if (GetNLS() && GetNLS(out a)) No(); F(a); } // Error
        { int a; if (GetLS() && GetLS(out a)) No(); F(a); } // Error
        { int a; if (GetNLS() && GetNLS(out a)) No(); else No(); F(a); } // Error
        { int a; if (GetLS() && GetLS(out a)) No(); else No(); F(a); } // Error
        { int a; if (GetNLS() && GetNLS(out a)) No(); else G(out a); F(a); } // Error
        { int a; if (GetLS() && GetLS(out a)) No(); else G(out a); F(a); } // Error

        // Assigned.
        { int a; if (fTrue && G(out a)) F(a); }
        { int a; if (fTrue && G(out a)) F(a); else No(); }
        { int a; if (fTrue && G(out a)) No(); else F(a); }
        { int a; if (fTrue && G(out a)) No(); F(a); }
        { int a; if (fTrue && G(out a)) No(); else No(); F(a); }

        // Unassigned, consequence and alternative are reachable
        { int a; if (fFalse && G(out a)) F(a); } // Error
        { int a; if (fFalse && G(out a)) F(a); else No(); } // Error
        { int a; if (fFalse && G(out a)) No(); else F(a); } // Error
        { int a; if (fFalse && G(out a)) No(); F(a); } // Error 
        { int a; if (fFalse && G(out a)) No(); else No(); F(a); } // Error

        // Unassigned.  Unreachable expr considered assigned.
        { int a; if (fFalse && F(a)) F(a); } // Error
        { int a; if (fFalse && F(a)) F(a); else No(); }  // Error
        { int a; if (fFalse && F(a)) No(); else F(a); }  // Error
        { int a; if (fFalse && F(a)) No(); F(a); } // Error
        { int a; if (fFalse && F(a)) No(); else No(); F(a); } // Error

        // Assigned after false.
        { int a; if (f || G(out a)) F(a); } // Error
        { int a; if (f || G(out a)) F(a); else No(); } // Error
        { int a; if (f || G(out a)) No(); else F(a); }
        { int a; if (f || G(out a)) No(); F(a); } // Error
        { int a; if (f || G(out a)) No(); else No(); F(a); } // Error
        { int a; if (f || G(out a)) G(out a); else No(); F(a); }

        // Unassigned due to user-defined operators.
        { int a; if (GetNLS() || GetNLS(out a)) F(a); } // Error
        { int a; if (GetLS() || GetLS(out a)) F(a); } // Error
        { int a; if (GetNLS() || GetNLS(out a)) F(a); else No(); } // Error
        { int a; if (GetLS() || GetLS(out a)) F(a); else No(); } // Error
        { int a; if (GetNLS() || GetNLS(out a)) No(); else F(a); } // Error
        { int a; if (GetLS() || GetLS(out a)) No(); else F(a); } // Error
        { int a; if (GetNLS() || GetNLS(out a)) No(); F(a); } // Error
        { int a; if (GetLS() || GetLS(out a)) No(); F(a); } // Error
        { int a; if (GetNLS() || GetNLS(out a)) No(); else No(); F(a); } // Error
        { int a; if (GetLS() || GetLS(out a)) No(); else No(); F(a); } // Error
        { int a; if (GetNLS() || GetNLS(out a)) G(out a); else No(); F(a); } // Error
        { int a; if (GetLS() || GetLS(out a)) G(out a); else No(); F(a); } // Error

        // Unassigned. G(out a) is unreachable expr.
        { int a; if (fTrue || G(out a)) F(a); } // Error
        { int a; if (fTrue || G(out a)) F(a); else No(); } // Error 
        { int a; if (fTrue || G(out a)) No(); else F(a); } // Error
        { int a; if (fTrue || G(out a)) No(); F(a); } // Error
        { int a; if (fTrue || G(out a)) No(); else No(); F(a); } // Error 
        { int a; if (fTrue || G(out a)) G(out a); else No(); F(a); } // Error

        // Assigned.
        { int a; if (fFalse || G(out a)) F(a); }
        { int a; if (fFalse || G(out a)) F(a); else No(); }
        { int a; if (fFalse || G(out a)) No(); else F(a); }
        { int a; if (fFalse || G(out a)) No(); F(a); }
        { int a; if (fFalse || G(out a)) No(); else No(); F(a); }
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 15145, 29712);

                f_28002_15145_29711(f_28002_15145_15170(source), f_28002_15350_15396(ErrorCode.WRN_UnreachableCode, "F"), f_28002_15569_15615(ErrorCode.WRN_UnreachableCode, "F"), f_28002_15796_15843(ErrorCode.WRN_UnreachableCode, "No"), f_28002_16023_16070(ErrorCode.WRN_UnreachableCode, "No"), f_28002_16242_16288(ErrorCode.WRN_UnreachableCode, "F"), f_28002_16451_16516(f_28002_16451_16497(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_16690_16755(f_28002_16690_16736(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_16915_16980(f_28002_16915_16961(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_17151_17216(f_28002_17151_17197(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_17387_17452(f_28002_17387_17433(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_17642_17707(f_28002_17642_17688(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_17871_17936(f_28002_17871_17917(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_18125_18190(f_28002_18125_18171(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_18374_18439(f_28002_18374_18420(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_18618_18683(f_28002_18618_18664(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_18873_18938(f_28002_18873_18919(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_19125_19212(f_28002_19125_19190(f_28002_19125_19171(ErrorCode.ERR_UseDefViolation, "a"), "a"), 106, 51), f_28002_19395_19482(f_28002_19395_19460(f_28002_19395_19441(ErrorCode.ERR_UseDefViolation, "a"), "a"), 107, 49), f_28002_19678_19765(f_28002_19678_19743(f_28002_19678_19724(ErrorCode.ERR_UseDefViolation, "a"), "a"), 110, 62), f_28002_19959_20046(f_28002_19959_20024(f_28002_19959_20005(ErrorCode.ERR_UseDefViolation, "a"), "a"), 111, 60), f_28002_20237_20324(f_28002_20237_20302(f_28002_20237_20283(ErrorCode.ERR_UseDefViolation, "a"), "a"), 112, 57), f_28002_20513_20600(f_28002_20513_20578(f_28002_20513_20559(ErrorCode.ERR_UseDefViolation, "a"), "a"), 113, 55), f_28002_20802_20889(f_28002_20802_20867(f_28002_20802_20848(ErrorCode.ERR_UseDefViolation, "a"), "a"), 114, 68), f_28002_21089_21176(f_28002_21089_21154(f_28002_21089_21135(ErrorCode.ERR_UseDefViolation, "a"), "a"), 115, 66), f_28002_21382_21469(f_28002_21382_21447(f_28002_21382_21428(ErrorCode.ERR_UseDefViolation, "a"), "a"), 116, 72), f_28002_21673_21760(f_28002_21673_21738(f_28002_21673_21719(ErrorCode.ERR_UseDefViolation, "a"), "a"), 117, 70), f_28002_22191_22278(f_28002_22191_22256(f_28002_22191_22237(ErrorCode.ERR_UseDefViolation, "a"), "a"), 129, 55), f_28002_22463_22550(f_28002_22463_22528(f_28002_22463_22509(ErrorCode.ERR_UseDefViolation, "a"), "a"), 130, 50), f_28002_22745_22832(f_28002_22745_22810(f_28002_22745_22791(ErrorCode.ERR_UseDefViolation, "a"), "a"), 131, 61), f_28002_23260_23347(f_28002_23260_23325(f_28002_23260_23306(ErrorCode.ERR_UseDefViolation, "a"), "a"), 136, 51), f_28002_23527_23614(f_28002_23527_23592(f_28002_23527_23573(ErrorCode.ERR_UseDefViolation, "a"), "a"), 137, 46), f_28002_23805_23892(f_28002_23805_23870(f_28002_23805_23851(ErrorCode.ERR_UseDefViolation, "a"), "a"), 138, 57), f_28002_24067_24154(f_28002_24067_24132(f_28002_24067_24113(ErrorCode.ERR_UseDefViolation, "a"), "a"), 141, 39), f_28002_24338_24425(f_28002_24338_24403(f_28002_24338_24384(ErrorCode.ERR_UseDefViolation, "a"), "a"), 142, 39), f_28002_24604_24691(f_28002_24604_24669(f_28002_24604_24650(ErrorCode.ERR_UseDefViolation, "a"), "a"), 144, 45), f_28002_24881_24968(f_28002_24881_24946(f_28002_24881_24927(ErrorCode.ERR_UseDefViolation, "a"), "a"), 145, 56), f_28002_25155_25242(f_28002_25155_25220(f_28002_25155_25201(ErrorCode.ERR_UseDefViolation, "a"), "a"), 149, 51), f_28002_25425_25512(f_28002_25425_25490(f_28002_25425_25471(ErrorCode.ERR_UseDefViolation, "a"), "a"), 150, 49), f_28002_25708_25795(f_28002_25708_25773(f_28002_25708_25754(ErrorCode.ERR_UseDefViolation, "a"), "a"), 151, 51), f_28002_25989_26076(f_28002_25989_26054(f_28002_25989_26035(ErrorCode.ERR_UseDefViolation, "a"), "a"), 152, 49), f_28002_26272_26359(f_28002_26272_26337(f_28002_26272_26318(ErrorCode.ERR_UseDefViolation, "a"), "a"), 153, 62), f_28002_26553_26640(f_28002_26553_26618(f_28002_26553_26599(ErrorCode.ERR_UseDefViolation, "a"), "a"), 154, 60), f_28002_26831_26918(f_28002_26831_26896(f_28002_26831_26877(ErrorCode.ERR_UseDefViolation, "a"), "a"), 155, 57), f_28002_27107_27194(f_28002_27107_27172(f_28002_27107_27153(ErrorCode.ERR_UseDefViolation, "a"), "a"), 156, 55), f_28002_27396_27483(f_28002_27396_27461(f_28002_27396_27442(ErrorCode.ERR_UseDefViolation, "a"), "a"), 157, 68), f_28002_27683_27770(f_28002_27683_27748(f_28002_27683_27729(ErrorCode.ERR_UseDefViolation, "a"), "a"), 158, 66), f_28002_27976_28063(f_28002_27976_28041(f_28002_27976_28022(ErrorCode.ERR_UseDefViolation, "a"), "a"), 159, 72), f_28002_28267_28354(f_28002_28267_28332(f_28002_28267_28313(ErrorCode.ERR_UseDefViolation, "a"), "a"), 160, 70), f_28002_28533_28620(f_28002_28533_28598(f_28002_28533_28579(ErrorCode.ERR_UseDefViolation, "a"), "a"), 163, 43), f_28002_28809_28896(f_28002_28809_28874(f_28002_28809_28855(ErrorCode.ERR_UseDefViolation, "a"), "a"), 164, 43), f_28002_29202_29289(f_28002_29202_29267(f_28002_29202_29248(ErrorCode.ERR_UseDefViolation, "a"), "a"), 166, 49), f_28002_29484_29571(f_28002_29484_29549(f_28002_29484_29530(ErrorCode.ERR_UseDefViolation, "a"), "a"), 167, 60));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 9479, 29723);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_15145_15170(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 15145, 15170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_15350_15396(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 15350, 15396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_15569_15615(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 15569, 15615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_15796_15843(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 15796, 15843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_16023_16070(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 16023, 16070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_16242_16288(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 16242, 16288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_16451_16497(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 16451, 16497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_16451_16516(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 16451, 16516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_16690_16736(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 16690, 16736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_16690_16755(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 16690, 16755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_16915_16961(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 16915, 16961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_16915_16980(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 16915, 16980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_17151_17197(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 17151, 17197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_17151_17216(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 17151, 17216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_17387_17433(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 17387, 17433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_17387_17452(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 17387, 17452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_17642_17688(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 17642, 17688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_17642_17707(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 17642, 17707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_17871_17917(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 17871, 17917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_17871_17936(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 17871, 17936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_18125_18171(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 18125, 18171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_18125_18190(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 18125, 18190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_18374_18420(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 18374, 18420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_18374_18439(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 18374, 18439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_18618_18664(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 18618, 18664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_18618_18683(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 18618, 18683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_18873_18919(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 18873, 18919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_18873_18938(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 18873, 18938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19125_19171(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19125, 19171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19125_19190(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19125, 19190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19125_19212(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19125, 19212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19395_19441(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19395, 19441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19395_19460(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19395, 19460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19395_19482(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19395, 19482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19678_19724(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19678, 19724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19678_19743(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19678, 19743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19678_19765(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19678, 19765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19959_20005(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19959, 20005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19959_20024(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19959, 20024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_19959_20046(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 19959, 20046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_20237_20283(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 20237, 20283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_20237_20302(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 20237, 20302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_20237_20324(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 20237, 20324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_20513_20559(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 20513, 20559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_20513_20578(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 20513, 20578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_20513_20600(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 20513, 20600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_20802_20848(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 20802, 20848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_20802_20867(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 20802, 20867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_20802_20889(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 20802, 20889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_21089_21135(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 21089, 21135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_21089_21154(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 21089, 21154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_21089_21176(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 21089, 21176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_21382_21428(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 21382, 21428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_21382_21447(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 21382, 21447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_21382_21469(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 21382, 21469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_21673_21719(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 21673, 21719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_21673_21738(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 21673, 21738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_21673_21760(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 21673, 21760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_22191_22237(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 22191, 22237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_22191_22256(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 22191, 22256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_22191_22278(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 22191, 22278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_22463_22509(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 22463, 22509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_22463_22528(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 22463, 22528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_22463_22550(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 22463, 22550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_22745_22791(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 22745, 22791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_22745_22810(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 22745, 22810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_22745_22832(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 22745, 22832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_23260_23306(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 23260, 23306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_23260_23325(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 23260, 23325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_23260_23347(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 23260, 23347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_23527_23573(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 23527, 23573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_23527_23592(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 23527, 23592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_23527_23614(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 23527, 23614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_23805_23851(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 23805, 23851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_23805_23870(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 23805, 23870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_23805_23892(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 23805, 23892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24067_24113(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24067, 24113);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24067_24132(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24067, 24132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24067_24154(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24067, 24154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24338_24384(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24338, 24384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24338_24403(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24338, 24403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24338_24425(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24338, 24425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24604_24650(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24604, 24650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24604_24669(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24604, 24669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24604_24691(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24604, 24691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24881_24927(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24881, 24927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24881_24946(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24881, 24946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_24881_24968(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 24881, 24968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25155_25201(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25155, 25201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25155_25220(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25155, 25220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25155_25242(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25155, 25242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25425_25471(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25425, 25471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25425_25490(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25425, 25490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25425_25512(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25425, 25512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25708_25754(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25708, 25754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25708_25773(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25708, 25773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25708_25795(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25708, 25795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25989_26035(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25989, 26035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25989_26054(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25989, 26054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_25989_26076(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 25989, 26076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_26272_26318(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 26272, 26318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_26272_26337(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 26272, 26337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_26272_26359(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 26272, 26359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_26553_26599(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 26553, 26599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_26553_26618(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 26553, 26618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_26553_26640(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 26553, 26640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_26831_26877(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 26831, 26877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_26831_26896(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 26831, 26896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_26831_26918(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 26831, 26918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27107_27153(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27107, 27153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27107_27172(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27107, 27172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27107_27194(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27107, 27194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27396_27442(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27396, 27442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27396_27461(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27396, 27461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27396_27483(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27396, 27483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27683_27729(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27683, 27729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27683_27748(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27683, 27748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27683_27770(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27683, 27770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27976_28022(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27976, 28022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27976_28041(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27976, 28041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_27976_28063(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 27976, 28063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_28267_28313(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 28267, 28313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_28267_28332(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 28267, 28332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_28267_28354(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 28267, 28354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_28533_28579(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 28533, 28579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_28533_28598(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 28533, 28598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_28533_28620(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 28533, 28620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_28809_28855(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 28809, 28855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_28809_28874(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 28809, 28874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_28809_28896(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 28809, 28896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_29202_29248(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 29202, 29248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_29202_29267(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 29202, 29267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_29202_29289(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 29202, 29289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_29484_29530(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 29484, 29530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_29484_29549(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 29484, 29549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_29484_29571(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 29484, 29571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_15145_29711(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 15145, 29711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 9479, 29723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 9479, 29723);
            }
        }

        [Fact]
        public void SwitchStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 29735, 36512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 29805, 34646);

                var
                source = prefix + @"
    // Switch statement.
    public void T110() {
        if (f) { int a; switch (a) { case 0: No(); break; } } // Error
        if (f) { int a; switch (val) { case 0: F(a); break; } } // Error
        if (f) { int a; switch (val) { case 0: G(out a); break; case 1: F(a); break; } } // Error
        if (f) { int a; switch (G(out a)) { case false: F(a); break; case true: No(); break; } }
        if (f) { int a; switch (G(out a)) { case false: No(); break; case true: F(a); break; } }

        // Assigned after false has no affect.
        if (f) { int a; switch (f || G(out a)) { case false: F(a); break; case true: No(); break; } } // Error

        // Assigned after true has no affect.
        if (f) { int a; switch (f && G(out a)) { case false: No(); break; case true: F(a); break; } } // Error

        // Exhaust cases
        if (f) { int a; switch (f) { case false: G(out a); break; case true: G(out a); break; } F(a); }
        if (f) { int a; switch (val) { case 0: goto default; default: G(out a); break; } F(a); }
        if (f) { int a; switch (val) { case 0: G(out a); break; default: goto case 0; } F(a); }
        if (f) { int a; switch (val) { case 0: G(out a); break; default: goto LSkip; } F(a); LSkip: No(); }
        if (f) { int a; switch (val) { case 0: G(out a); goto LHave; default: break; } No(); goto LSkip; LHave: F(a); LSkip: No(); }

        if (f) { int a;
            switch (b) {
            case 0x00: case 0x01: case 0x02: case 0x03: case 0x04: case 0x05: case 0x06: case 0x07: case 0x08: case 0x09: case 0x0A: case 0x0B: case 0x0C: case 0x0D: case 0x0E: case 0x0F:
            case 0x10: case 0x11: case 0x12: case 0x13: case 0x14: case 0x15: case 0x16: case 0x17: case 0x18: case 0x19: case 0x1A: case 0x1B: case 0x1C: case 0x1D: case 0x1E: case 0x1F:
            case 0x20: case 0x21: case 0x22: case 0x23: case 0x24: case 0x25: case 0x26: case 0x27: case 0x28: case 0x29: case 0x2A: case 0x2B: case 0x2C: case 0x2D: case 0x2E: case 0x2F:
            case 0x30: case 0x31: case 0x32: case 0x33: case 0x34: case 0x35: case 0x36: case 0x37: case 0x38: case 0x39: case 0x3A: case 0x3B: case 0x3C: case 0x3D: case 0x3E: case 0x3F:
            case 0x40: case 0x41: case 0x42: case 0x43: case 0x44: case 0x45: case 0x46: case 0x47: case 0x48: case 0x49: case 0x4A: case 0x4B: case 0x4C: case 0x4D: case 0x4E: case 0x4F:
            case 0x50: case 0x51: case 0x52: case 0x53: case 0x54: case 0x55: case 0x56: case 0x57: case 0x58: case 0x59: case 0x5A: case 0x5B: case 0x5C: case 0x5D: case 0x5E: case 0x5F:
            case 0x60: case 0x61: case 0x62: case 0x63: case 0x64: case 0x65: case 0x66: case 0x67: case 0x68: case 0x69: case 0x6A: case 0x6B: case 0x6C: case 0x6D: case 0x6E: case 0x6F:
            case 0x70: case 0x71: case 0x72: case 0x73: case 0x74: case 0x75: case 0x76: case 0x77: case 0x78: case 0x79: case 0x7A: case 0x7B: case 0x7C: case 0x7D: case 0x7E: case 0x7F:
                G(out a);
                break;
            case 0x80: case 0x81: case 0x82: case 0x83: case 0x84: case 0x85: case 0x86: case 0x87: case 0x88: case 0x89: case 0x8A: case 0x8B: case 0x8C: case 0x8D: case 0x8E: case 0x8F:
            case 0x90: case 0x91: case 0x92: case 0x93: case 0x94: case 0x95: case 0x96: case 0x97: case 0x98: case 0x99: case 0x9A: case 0x9B: case 0x9C: case 0x9D: case 0x9E: case 0x9F:
            case 0xA0: case 0xA1: case 0xA2: case 0xA3: case 0xA4: case 0xA5: case 0xA6: case 0xA7: case 0xA8: case 0xA9: case 0xAA: case 0xAB: case 0xAC: case 0xAD: case 0xAE: case 0xAF:
            case 0xB0: case 0xB1: case 0xB2: case 0xB3: case 0xB4: case 0xB5: case 0xB6: case 0xB7: case 0xB8: case 0xB9: case 0xBA: case 0xBB: case 0xBC: case 0xBD: case 0xBE: case 0xBF:
            case 0xC0: case 0xC1: case 0xC2: case 0xC3: case 0xC4: case 0xC5: case 0xC6: case 0xC7: case 0xC8: case 0xC9: case 0xCA: case 0xCB: case 0xCC: case 0xCD: case 0xCE: case 0xCF:
            case 0xD0: case 0xD1: case 0xD2: case 0xD3: case 0xD4: case 0xD5: case 0xD6: case 0xD7: case 0xD8: case 0xD9: case 0xDA: case 0xDB: case 0xDC: case 0xDD: case 0xDE: case 0xDF:
            case 0xE0: case 0xE1: case 0xE2: case 0xE3: case 0xE4: case 0xE5: case 0xE6: case 0xE7: case 0xE8: case 0xE9: case 0xEA: case 0xEB: case 0xEC: case 0xED: case 0xEE: case 0xEF:
            case 0xF0: case 0xF1: case 0xF2: case 0xF3: case 0xF4: case 0xF5: case 0xF6: case 0xF7: case 0xF8: case 0xF9: case 0xFA: case 0xFB: case 0xFC: case 0xFD: case 0xFE: case 0xFF:
                G(out a);
                break;
            }
            F(a); // OK - we consider enumerating values for integral types to be exhaustive
        }

        if (f) { int a; switch (val) { default: goto case 0; case 0: goto default; } F(a); } // Unreachable
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 34662, 36501);

                f_28002_34662_36500(f_28002_34662_34687(source), f_28002_34924_34992(f_28002_34924_34970(ErrorCode.WRN_UnreachableCode, "F"), 121, 86), f_28002_35182_35268(f_28002_35182_35247(f_28002_35182_35228(ErrorCode.ERR_UseDefViolation, "a"), "a"), 76, 33), f_28002_35460_35546(f_28002_35460_35525(f_28002_35460_35506(ErrorCode.ERR_UseDefViolation, "a"), "a"), 77, 50), f_28002_35763_35849(f_28002_35763_35828(f_28002_35763_35809(ErrorCode.ERR_UseDefViolation, "a"), "a"), 78, 75), f_28002_36079_36165(f_28002_36079_36144(f_28002_36079_36125(ErrorCode.ERR_UseDefViolation, "a"), "a"), 83, 64), f_28002_36395_36481(f_28002_36395_36460(f_28002_36395_36441(ErrorCode.ERR_UseDefViolation, "a"), "a"), 86, 88));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 29735, 36512);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_34662_34687(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 34662, 34687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_34924_34970(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 34924, 34970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_34924_34992(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 34924, 34992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_35182_35228(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 35182, 35228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_35182_35247(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 35182, 35247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_35182_35268(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 35182, 35268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_35460_35506(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 35460, 35506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_35460_35525(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 35460, 35525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_35460_35546(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 35460, 35546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_35763_35809(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 35763, 35809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_35763_35828(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 35763, 35828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_35763_35849(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 35763, 35849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_36079_36125(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 36079, 36125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_36079_36144(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 36079, 36144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_36079_36165(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 36079, 36165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_36395_36441(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 36395, 36441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_36395_36460(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 36395, 36460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_36395_36481(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 36395, 36481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_34662_36500(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 34662, 36500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 29735, 36512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 29735, 36512);
            }
        }

        [Fact]
        public void WhileStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 36524, 46130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 36593, 39585);

                var
                source = prefix + @"
    // While statement.
    public void T120() {
        // Unassigned.
        if (f) { int a; while (F(a)) No(); } // Error
        if (f) { int a; while (f) F(a); } // Error
        if (f) { int a; while (f) No(); F(a); } // Error
        if (f) { int a; while (f) G(out a); F(a); } // Error
        if (f) { int a; while (fFalse) F(a); } // Unreachable
        if (f) { int a; while (fTrue) No(); F(a); } // Unreachable

        // Assigned.
        if (f) { int a; while (G(out a)) F(a); }
        if (f) { int a; while (G(out a)) No(); F(a); }

        // Assigned after true.
        if (f) { int a; while (f && G(out a)) F(a); }
        if (f) { int a; while (f && G(out a)) No(); F(a); } // Error

        // Assigned
        if (f) { int a; while (fTrue && G(out a)) F(a); }
        if (f) { int a; while (fTrue && G(out a)) No(); F(a); }

        // Unassigned.
        if (f) { int a; while (fFalse && G(out a)) F(a); } // Error. Unreachable expression, not unreachable statement
        if (f) { int a; while (fFalse && G(out a)) No(); F(a); } // Error. Unreachable expression, not statement

        // Assigned after false.
        if (f) { int a; while (f || G(out a)) F(a); } // Error
        if (f) { int a; while (f || G(out a)) No(); F(a); }

        // Unassigned.
        if (f) { int a; while (fTrue || G(out a)) F(a); } // Error, unreachable expression
        if (f) { int a; while (fTrue || G(out a)) No(); F(a); } // Error, unreachable expression, not statement

        // Assigned 
        if (f) { int a; while (fFalse || G(out a)) F(a); }
        if (f) { int a; while (fFalse || G(out a)) No(); F(a); }
    }

    // While statement with break and continue.
    public void T121() {
        if (f) { int a; while (f) { break; F(a); } } // Unreachable
        if (f) { int a; while (fTrue) { } F(a); } // Unreachable
        if (f) { int a; while (fTrue) { break; } F(a); } // Error
        if (f) { int a; while (f) { G(out a); break; } F(a); } // Error
        if (f) { int a; while (fTrue) { G(out a); break; } F(a); }
        if (f) { int a; while (f) { break; G(out a); } F(a); } // Error + Unreachable
        if (f) { int a; while (fTrue) { break; G(out a); } F(a); } // Error + Unreachable
        if (f) { int a; while (fTrue || G(out a)) break; F(a); } // Error
        if (f) { int a; while (f) { if (f) G(out a); else break; F(a); } }
        if (f) { int a; while (fTrue) { break; G(out a); } F(a); } // Error + Unreachable
        if (f) { int a; while (fTrue) { if (f) break; G(out a); } F(a); } // Error
        if (f) { int a; while (fTrue) { if (fFalse) break; G(out a); break; } F(a); } // Unreachable (break)

        if (f) { int a; while (f) { continue; F(a); } } // Unreachable
        if (f) { int a; while (fTrue) { continue; } F(a); } // Unreachable
        if (f) { int a; while (fTrue) { if (f) continue; G(out a); break; } F(a); }
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 39601, 46119);

                f_28002_39601_46118(f_28002_39601_39626(source), f_28002_39816_39862(ErrorCode.WRN_UnreachableCode, "F"), f_28002_40039_40085(ErrorCode.WRN_UnreachableCode, "F"), f_28002_40258_40323(f_28002_40258_40304(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_40493_40558(f_28002_40493_40539(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_40734_40799(f_28002_40734_40780(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_40979_41044(f_28002_40979_41025(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_41232_41297(f_28002_41232_41278(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_41650_41715(f_28002_41650_41696(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_41897_41962(f_28002_41897_41943(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_42172_42237(f_28002_42172_42218(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_42536_42582(ErrorCode.WRN_UnreachableCode, "F"), f_28002_42757_42803(ErrorCode.WRN_UnreachableCode, "F"), f_28002_42999_43045(ErrorCode.WRN_UnreachableCode, "G"), f_28002_43245_43291(ErrorCode.WRN_UnreachableCode, "G"), f_28002_43491_43537(ErrorCode.WRN_UnreachableCode, "G"), f_28002_43757_43807(ErrorCode.WRN_UnreachableCode, "break"), f_28002_43989_44035(ErrorCode.WRN_UnreachableCode, "F"), f_28002_44221_44267(ErrorCode.WRN_UnreachableCode, "F"), f_28002_44452_44517(f_28002_44452_44498(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_44708_44773(f_28002_44708_44754(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_44978_45043(f_28002_44978_45024(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_45252_45317(f_28002_45252_45298(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_45510_45575(f_28002_45510_45556(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_45784_45849(f_28002_45784_45830(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_46052_46117(f_28002_46052_46098(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 36524, 46130);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_39601_39626(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 39601, 39626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_39816_39862(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 39816, 39862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_40039_40085(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 40039, 40085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_40258_40304(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 40258, 40304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_40258_40323(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 40258, 40323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_40493_40539(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 40493, 40539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_40493_40558(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 40493, 40558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_40734_40780(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 40734, 40780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_40734_40799(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 40734, 40799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_40979_41025(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 40979, 41025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_40979_41044(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 40979, 41044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_41232_41278(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 41232, 41278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_41232_41297(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 41232, 41297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_41650_41696(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 41650, 41696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_41650_41715(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 41650, 41715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_41897_41943(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 41897, 41943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_41897_41962(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 41897, 41962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_42172_42218(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 42172, 42218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_42172_42237(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 42172, 42237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_42536_42582(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 42536, 42582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_42757_42803(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 42757, 42803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_42999_43045(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 42999, 43045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_43245_43291(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 43245, 43291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_43491_43537(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 43491, 43537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_43757_43807(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 43757, 43807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_43989_44035(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 43989, 44035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_44221_44267(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 44221, 44267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_44452_44498(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 44452, 44498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_44452_44517(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 44452, 44517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_44708_44754(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 44708, 44754);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_44708_44773(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 44708, 44773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_44978_45024(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 44978, 45024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_44978_45043(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 44978, 45043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_45252_45298(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 45252, 45298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_45252_45317(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 45252, 45317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_45510_45556(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 45510, 45556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_45510_45575(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 45510, 45575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_45784_45830(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 45784, 45830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_45784_45849(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 45784, 45849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_46052_46098(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 46052, 46098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_46052_46117(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 46052, 46117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_39601_46118(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 39601, 46118);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 36524, 46130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 36524, 46130);
            }
        }

        [WorkItem(529602, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529602")]
        [Fact]
        public void DoWhileStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 46142, 51973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 46305, 48309);

                var
                source = prefix + @"
    // Do statement.
    public void T130() {
        if (f) { int a; do F(a); while (f); } // Error
        if (f) { int a; do No(); while (F(a)); } // Error
        if (f) { int a; do No(); while (f); F(a); } // Error
        if (f) { int a; do G(out a); while (F(a)); }
        if (f) { int a; do G(out a); while (f); F(a); }
        if (f) { int a; do No(); while (G(out a)); F(a); }
        if (f) { int a; do No(); while (fTrue); F(a); } // Unreachable

        // Assigned after true - nothing special
        if (f) { int a; do No(); while (f && G(out a)); F(a); } // Error

        // Assigned
        if (f) { int a; do No(); while (fTrue && G(out a)); F(a); }

        // Unassigned.
        if (f) { int a; do No(); while (fFalse && G(out a)); F(a); } // Error

        // 
        if (f) { int a; do No(); while (f || G(out a)); F(a); } // Assigned after false
        if (f) { int a; do No(); while (fTrue || G(out a)); F(a); } // unreachable expr, unassigned
        if (f) { int a; do No(); while (fFalse || G(out a)); F(a); } // Assigned
    }

    // Do statement with break and continue.
    public void T131() {
        if (f) { int a; do { break; F(a); } while (f); } // Unreachable
        if (f) { int a; do break; while (F(a)); } // Unreachable
        if (f) { int a; do { if (f) break; G(out a); } while (F(a)); }
        if (f) { int a; do { if (f) break; G(out a); } while (f); F(a); } // Error
        if (f) { int a; do { if (f) break; No(); } while (G(out a)); F(a); } // Error
        if (f) { int a; do { if (f) break; } while (fTrue); F(a); } // Error

        if (f) { int a; do { if (f) continue; G(out a); } while (F(a)); } // Error
        if (f) { int a; do { if (f) continue; G(out a); } while (f); F(a); } // Error
        if (f) { int a; do { if (f) continue; No(); } while (G(out a)); F(a); }
        if (f) { int a; do { if (f) continue; } while (fTrue); F(a); } // Unreachable
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 48325, 51962);

                f_28002_48325_51961(f_28002_48325_48350(source), f_28002_48549_48595(ErrorCode.WRN_UnreachableCode, "F"), f_28002_48769_48834(f_28002_48769_48815(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_49011_49076(f_28002_49011_49057(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_49256_49321(f_28002_49256_49302(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_49513_49578(f_28002_49513_49559(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_49775_49840(f_28002_49775_49821(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_50143_50189(ErrorCode.WRN_UnreachableCode, "F"), f_28002_50579_50625(ErrorCode.WRN_UnreachableCode, "F"), f_28002_50827_50892(f_28002_50827_50873(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_51097_51162(f_28002_51097_51143(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_51358_51423(f_28002_51358_51404(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_51625_51690(f_28002_51625_51671(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_51895_51960(f_28002_51895_51941(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 46142, 51973);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_48325_48350(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 48325, 48350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_48549_48595(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 48549, 48595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_48769_48815(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 48769, 48815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_48769_48834(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 48769, 48834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_49011_49057(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 49011, 49057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_49011_49076(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 49011, 49076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_49256_49302(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 49256, 49302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_49256_49321(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 49256, 49321);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_49513_49559(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 49513, 49559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_49513_49578(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 49513, 49578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_49775_49821(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 49775, 49821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_49775_49840(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 49775, 49840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_50143_50189(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 50143, 50189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_50579_50625(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 50579, 50625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_50827_50873(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 50827, 50873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_50827_50892(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 50827, 50892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_51097_51143(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 51097, 51143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_51097_51162(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 51097, 51162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_51358_51404(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 51358, 51404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_51358_51423(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 51358, 51423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_51625_51671(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 51625, 51671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_51625_51690(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 51625, 51690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_51895_51941(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 51895, 51941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_51895_51960(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 51895, 51960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_48325_51961(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 48325, 51961);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 46142, 51973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 46142, 51973);
            }
        }

        [WorkItem(529602, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529602")]
        [Fact]
        public void UnreachableDoWhileCondition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 51985, 52515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 52159, 52279);

                var
                source = @"
class C
{
    bool F()
    {
        do { break; } while (F());
        return true;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 52458, 52504);

                f_28002_52458_52503(f_28002_52458_52483(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 51985, 52515);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_52458_52483(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 52458, 52483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_52458_52503(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 52458, 52503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 51985, 52515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 51985, 52515);
            }
        }

        [Fact]
        public void ForStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 52527, 61088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 52594, 55451);

                var
                source = prefix + @"
    // For statement.
    public void T140() {
        if (f) { int a; for (F(a);;) No(); } // Error
        if (f) { int a; for (;F(a);) No(); } // Error
        if (f) { int a; for (;;F(a)) No(); } // Error
        if (f) { int a; for (;;) F(a); } // Error
        if (f) { int a; for (;;) No(); F(a); } // Unreachable
        if (f) { int a; for (;f;) No(); F(a); } // Error
        if (f) { int a; for (;f;) G(out a); F(a); } // Error
        if (f) { int a; for (;fFalse;) G(out a); F(a); } // Error + Unreachable
        if (f) { int a; for (;fFalse;) F(a); } // Unreachable
        if (f) { int a; for (;;) No(); F(a); } // Unreachable

        // Assigned.
        if (f) { int a; for (G(out a);f;) F(a); }
        if (f) { int a; for (G(out a);f;) No(); F(a); }
        if (f) { int a; for (;G(out a);) F(a); }
        if (f) { int a; for (;G(out a);) No(); F(a); }
        if (f) { int a; for (;f;G(out a)) F(a); } // Error
        if (f) { int a; for (;f;G(out a)) No(); F(a); } // Error
        if (f) { int a; for (;f;F(a)) G(out a); }
        if (f) { int a; for (;f;) G(out a); F(a); } // Error

        // Assigned after true.
        if (f) { int a; for (;f && G(out a);) F(a); }
        if (f) { int a; for (;f && G(out a);) No(); F(a); } // Error

        // Assigned.
        if (f) { int a; for (;fTrue && G(out a);) F(a); }
        if (f) { int a; for (;fTrue && G(out a);) No(); F(a); }

        // Unassigned.
        if (f) { int a; for (;fFalse && G(out a);) F(a); } // Error, unreachable expr, no unreachable stmt
        if (f) { int a; for (;fFalse && G(out a);) No(); F(a); } // Error, unreachable expr

        // Assigned after false.
        if (f) { int a; for (;f || G(out a);) F(a); } // Error
        if (f) { int a; for (;f || G(out a);) No(); F(a); }

        // Unassigned.
        if (f) { int a; for (;fTrue || G(out a);) F(a); } // Error, unreachable expr
        if (f) { int a; for (;fTrue || G(out a);) No(); F(a); } // Unreachable expr, not unreachable code

        // Assigned.
        if (f) { int a; for (;fFalse || G(out a);) F(a); }
        if (f) { int a; for (;fFalse || G(out a);) No(); F(a); }
    }

    // For statement with break and continue.
    public void T141() {
        if (f) { int a; for (;;F(a)) G(out a); }
        if (f) { int a; for (;;F(a)) break; } // Unreachable
        if (f) { int a; for (;;F(a)) { G(out a); if (f) continue; } }
        if (f) { int a; for (;;F(a)) { G(out a); if (f) break; } }
        if (f) { int a; for (;;F(a)) { if (f) continue; G(out a); } } // Error
        if (f) { int a; for (;;) break; F(a); } // Error
        if (f) { int a; for (;;) { if (f) break; No(); } F(a); } // Error
        if (f) { int a; for (;;) { G(out a); if (f) break; } F(a); }
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 55467, 61077);

                f_28002_55467_61076(f_28002_55467_55492(source), f_28002_55682_55728(ErrorCode.WRN_UnreachableCode, "F"), f_28002_55918_55964(ErrorCode.WRN_UnreachableCode, "G"), f_28002_56136_56182(ErrorCode.WRN_UnreachableCode, "F"), f_28002_56354_56400(ErrorCode.WRN_UnreachableCode, "F"), f_28002_56573_56638(f_28002_56573_56619(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_56811_56876(f_28002_56811_56857(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_57049_57114(f_28002_57049_57095(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_57283_57348(f_28002_57283_57329(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_57524_57589(f_28002_57524_57570(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_57769_57834(f_28002_57769_57815(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_58033_58098(f_28002_58033_58079(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_58276_58341(f_28002_58276_58322(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_58525_58590(f_28002_58525_58571(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_58770_58835(f_28002_58770_58816(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_59023_59088(f_28002_59023_59069(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_59405_59470(f_28002_59405_59451(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_59652_59717(f_28002_59652_59698(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_59921_59986(f_28002_59921_59967(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_60264_60310(ErrorCode.WRN_UnreachableCode, "F"), f_28002_60509_60574(f_28002_60509_60555(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_60751_60816(f_28002_60751_60797(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_61010_61075(f_28002_61010_61056(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 52527, 61088);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_55467_55492(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 55467, 55492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_55682_55728(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 55682, 55728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_55918_55964(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 55918, 55964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_56136_56182(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 56136, 56182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_56354_56400(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 56354, 56400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_56573_56619(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 56573, 56619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_56573_56638(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 56573, 56638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_56811_56857(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 56811, 56857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_56811_56876(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 56811, 56876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_57049_57095(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 57049, 57095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_57049_57114(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 57049, 57114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_57283_57329(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 57283, 57329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_57283_57348(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 57283, 57348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_57524_57570(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 57524, 57570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_57524_57589(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 57524, 57589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_57769_57815(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 57769, 57815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_57769_57834(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 57769, 57834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_58033_58079(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 58033, 58079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_58033_58098(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 58033, 58098);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_58276_58322(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 58276, 58322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_58276_58341(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 58276, 58341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_58525_58571(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 58525, 58571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_58525_58590(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 58525, 58590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_58770_58816(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 58770, 58816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_58770_58835(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 58770, 58835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_59023_59069(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 59023, 59069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_59023_59088(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 59023, 59088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_59405_59451(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 59405, 59451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_59405_59470(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 59405, 59470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_59652_59698(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 59652, 59698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_59652_59717(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 59652, 59717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_59921_59967(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 59921, 59967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_59921_59986(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 59921, 59986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_60264_60310(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 60264, 60310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_60509_60555(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 60509, 60555);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_60509_60574(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 60509, 60574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_60751_60797(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 60751, 60797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_60751_60816(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 60751, 60816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_61010_61056(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 61010, 61056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_61010_61075(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 61010, 61075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_55467_61076(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 55467, 61076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 52527, 61088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 52527, 61088);
            }
        }

        [Fact]
        public void ThrowStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 61100, 61954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 61169, 61405);

                var
                source = prefix + @"
    // Throw statement.
    public void T150() {
        if (f) { int a; throw new Exception(F(a).ToString()); }
        if (f) { int a; throw new Exception(""x""); F(a); } // Unreachable
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 61421, 61943);

                f_28002_61421_61942(f_28002_61421_61446(source), f_28002_61647_61693(ErrorCode.WRN_UnreachableCode, "F"), f_28002_61876_61941(f_28002_61876_61922(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 61100, 61954);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_61421_61446(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 61421, 61446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_61647_61693(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 61647, 61693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_61876_61922(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 61876, 61922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_61876_61941(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 61876, 61941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_61421_61942(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 61421, 61942);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 61100, 61954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 61100, 61954);
            }
        }

        [Fact]
        public void ReturnStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 61966, 64218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 62036, 62566);

                var
                source = prefix + @"
    // Return statement.
    public bool T160() { int a; return F(a); } // Error
    public bool T161() { int a; return No(); F(a); } // Unreachable
    public bool T162(out int a) { return F(a); } // Error
    public bool T163(out int a) { return No(); } // Error
    public bool T164(out int a) { try { return No(); } finally { G(out a); } }
    public bool T165(out int a) { return G(out a); }
    public bool T166(out int a) { try { return G(out a); } finally { F(a); } } // Error
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 62582, 64207);

                f_28002_62582_64206(f_28002_62582_62607(source), f_28002_62800_62865(f_28002_62800_62846(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_63043_63089(ErrorCode.WRN_UnreachableCode, "F"), f_28002_63265_63333(f_28002_63265_63314(ErrorCode.ERR_UseDefViolationOut, "a"), "a"), f_28002_63556_63632(f_28002_63556_63613(ErrorCode.ERR_ParamUnassigned, "return F(a);"), "a"), f_28002_63855_63931(f_28002_63855_63912(ErrorCode.ERR_ParamUnassigned, "return No();"), "a"), f_28002_64137_64205(f_28002_64137_64186(ErrorCode.ERR_UseDefViolationOut, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 61966, 64218);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_62582_62607(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 62582, 62607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_62800_62846(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 62800, 62846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_62800_62865(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 62800, 62865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_63043_63089(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 63043, 63089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_63265_63314(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 63265, 63314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_63265_63333(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 63265, 63333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_63556_63613(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 63556, 63613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_63556_63632(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 63556, 63632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_63855_63912(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 63855, 63912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_63855_63931(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 63855, 63931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_64137_64186(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 64137, 64186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_64137_64205(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 64137, 64205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_62582_64206(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 62582, 64206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 61966, 64218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 61966, 64218);
            }
        }

        [Fact]
        public void TryCatchStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 64230, 73128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 64302, 66084);

                var
                source = prefix + @"
    // Try-catch statement.
    public void T170() {
        if (f) { int a; try { F(a); } catch (Exception e) { } finally { } } // Error
        if (f) { int a; try { } catch (Exception e) { F(a); } finally { } } // Error
        if (f) { int a; try { } catch (Exception e) { } finally { F(a); } } // Error
        if (f) { int a; try { } catch (Exception e) { } finally { } F(a); } // Error

        if (f) { int a; try { G(out a); } catch (Exception e) { } F(a); } // Error
        if (f) { int a; try { G(out a); } finally { } F(a); }
        if (f) { int a; try { G(out a); } catch (Exception e) { } finally { } F(a); } // Error

        if (f) { int a; try { G(out a); } catch (Exception e) { G(out a); } F(a); }
        if (f) { int a; try { G(out a); } catch (Exception e) { G(out a); } finally { } F(a); }

        if (f) { int a; try { } finally { G(out a); } F(a); }
        if (f) { int a; try { } catch (Exception e) { } finally { G(out a); } F(a); }

        if (f) { int a; try { G(out a); goto L; } catch (Exception e) { } return; L: F(a); }
        if (f) { int a; try { G(out a); goto L; } finally { } return; L: F(a); }
        if (f) { int a; try { G(out a); goto L; } catch (Exception e) { } finally { } return; L: F(a); }

        if (f) { int a; try { goto L; } finally { G(out a); } return; L: F(a); }
        if (f) { int a; try { goto L; } catch (Exception e) { } finally { G(out a); } return; L: F(a); }

        // Unreachable end of finally.
        if (f) { int a; try { G(out a); } catch (Exception e) { } finally { for (;;) No(); } F(a); } // Unreachable
        if (f) { int a; try { goto L; } catch (Exception e) { } finally { for(;;) No(); } return; L: F(a); } // Unreachable
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 66100, 73117);

                f_28002_66100_73116(f_28002_66100_66125(source), f_28002_66334_66385(ErrorCode.WRN_UnreachableCode, "return"), f_28002_66576_66627(ErrorCode.WRN_UnreachableCode, "return"), f_28002_66853_66899(ErrorCode.WRN_UnreachableCode, "F"), f_28002_67133_67184(ErrorCode.WRN_UnreachableCode, "return"), f_28002_67418_67464(ErrorCode.WRN_UnreachableCode, "L"), f_28002_67668_67733(f_28002_67668_67714(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_67946_68011(f_28002_67946_67992(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_68215_68280(f_28002_68215_68261(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_68493_68558(f_28002_68493_68539(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_68771_68836(f_28002_68771_68817(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_69040_69105(f_28002_69040_69086(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_69318_69383(f_28002_69318_69364(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_69587_69652(f_28002_69587_69633(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_69863_69928(f_28002_69863_69909(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_70130_70195(f_28002_70130_70176(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_70418_70483(f_28002_70418_70464(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_70697_70762(f_28002_70697_70743(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_70974_71039(f_28002_70974_71020(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_71263_71328(f_28002_71263_71309(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_71542_71607(f_28002_71542_71588(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_71828_71893(f_28002_71828_71874(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_72126_72191(f_28002_72126_72172(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_72424_72489(f_28002_72424_72470(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_72733_72798(f_28002_72733_72779(ErrorCode.WRN_UnreferencedVar, "e"), "e"), f_28002_73050_73115(f_28002_73050_73096(ErrorCode.WRN_UnreferencedVar, "e"), "e"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 64230, 73128);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_66100_66125(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 66100, 66125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_66334_66385(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 66334, 66385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_66576_66627(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 66576, 66627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_66853_66899(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 66853, 66899);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_67133_67184(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 67133, 67184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_67418_67464(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 67418, 67464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_67668_67714(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 67668, 67714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_67668_67733(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 67668, 67733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_67946_67992(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 67946, 67992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_67946_68011(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 67946, 68011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_68215_68261(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 68215, 68261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_68215_68280(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 68215, 68280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_68493_68539(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 68493, 68539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_68493_68558(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 68493, 68558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_68771_68817(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 68771, 68817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_68771_68836(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 68771, 68836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_69040_69086(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 69040, 69086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_69040_69105(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 69040, 69105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_69318_69364(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 69318, 69364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_69318_69383(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 69318, 69383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_69587_69633(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 69587, 69633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_69587_69652(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 69587, 69652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_69863_69909(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 69863, 69909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_69863_69928(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 69863, 69928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_70130_70176(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 70130, 70176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_70130_70195(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 70130, 70195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_70418_70464(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 70418, 70464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_70418_70483(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 70418, 70483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_70697_70743(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 70697, 70743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_70697_70762(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 70697, 70762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_70974_71020(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 70974, 71020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_70974_71039(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 70974, 71039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_71263_71309(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 71263, 71309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_71263_71328(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 71263, 71328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_71542_71588(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 71542, 71588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_71542_71607(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 71542, 71607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_71828_71874(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 71828, 71874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_71828_71893(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 71828, 71893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_72126_72172(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 72126, 72172);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_72126_72191(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 72126, 72191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_72424_72470(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 72424, 72470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_72424_72489(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 72424, 72489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_72733_72779(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 72733, 72779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_72733_72798(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 72733, 72798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_73050_73096(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 73050, 73096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_73050_73115(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 73050, 73115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_66100_73116(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 66100, 73116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 64230, 73128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 64230, 73128);
            }
        }

        [Fact]
        public void ForEachStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 73140, 74858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 73211, 73721);

                var
                source = prefix + @"
    // Foreach statement.
    public void T180() {
        if (f) { int a; foreach (char ch in F(a).ToString()) No(); } // Error
        if (f) { int a; foreach (char ch in ""abc"") F(a); } // Error // BUG?: Error in wrong order.
        if (f) { int a; foreach (char ch in G(out a).ToString()) F(a); }
        if (f) { int a; foreach (char ch in ""abc"") No(); F(a); } // Error
        if (f) { int a; foreach (char ch in ""abc"") G(out a); F(a); } // Error
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 73737, 74847);

                f_28002_73737_74846(f_28002_73737_73762(source), f_28002_73977_74042(f_28002_73977_74023(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_74260_74325(f_28002_74260_74306(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_74518_74583(f_28002_74518_74564(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_74780_74845(f_28002_74780_74826(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 73140, 74858);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_73737_73762(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 73737, 73762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_73977_74023(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 73977, 74023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_73977_74042(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 73977, 74042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_74260_74306(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 74260, 74306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_74260_74325(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 74260, 74325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_74518_74564(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 74518, 74564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_74518_74583(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 74518, 74583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_74780_74826(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 74780, 74826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_74780_74845(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 74780, 74845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_73737_74846(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 73737, 74846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 73140, 74858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 73140, 74858);
            }
        }

        [Fact]
        public void UsingAndLockStatements()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 74870, 77187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 74947, 75690);

                var
                source = prefix + @"
    // Using and Lock statements.
    public void T190() {
        { int a; using (Res(F(a))) No(); } // Error
        { int a; using (Res(No())) F(a); } // Error
        { int a; using (Res(No())) No(); F(a); } // Error
        { int a; using (Res(G(out a))) F(a); }
        { int a; using (Res(G(out a))) No(); F(a); }
        { int a; using (Res(No())) G(out a); F(a); }

        { int a; lock (Res(F(a))) No(); } // Error
        { int a; lock (Res(No())) F(a); } // Error
        { int a; lock (Res(No())) No(); F(a); } // Error
        { int a; lock (Res(G(out a))) F(a); }
        { int a; lock (Res(G(out a))) No(); F(a); }
        { int a; lock (Res(No())) G(out a); F(a); }
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 75706, 77176);

                f_28002_75706_77175(f_28002_75706_75731(source), f_28002_75920_75985(f_28002_75920_75966(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_76156_76221(f_28002_76156_76202(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_76398_76463(f_28002_76398_76444(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_76633_76698(f_28002_76633_76679(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_76868_76933(f_28002_76868_76914(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_77109_77174(f_28002_77109_77155(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 74870, 77187);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_75706_75731(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 75706, 75731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_75920_75966(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 75920, 75966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_75920_75985(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 75920, 75985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_76156_76202(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 76156, 76202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_76156_76221(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 76156, 76221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_76398_76444(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 76398, 76444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_76398_76463(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 76398, 76463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_76633_76679(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 76633, 76679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_76633_76698(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 76633, 76698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_76868_76914(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 76868, 76914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_76868_76933(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 76868, 76933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_77109_77155(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 77109, 77155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_77109_77174(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 77109, 77174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_75706_77175(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 75706, 77175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 74870, 77187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 74870, 77187);
            }
        }

        [Fact]
        public void LogicalExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 77199, 97871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 77271, 84548);

                var
                source = prefix + @"
    // Logical and: E -> S && T
    public void T340() {
        // S -> DA then DA -> T and E -> DA
        { int a; Q(G(out a) && F(a)); } // DA -> T
        { int a; Q(G(out a) && No()); F(a); } // E -> DA

        // S -> DAT then DA -> T and E -> DAT
        { int a; Q((f && G(out a)) && F(a)); } // DA -> T
        { int a; Q((f && G(out a)) && No()); F(a); } // Error
        { int a; if ((f && G(out a)) && No()) F(a); } // E -> DAT

        // S -> DAF then DU -> T
        { int a; Q((f || G(out a)) && F(a)); } // Error
        // if T -> DU then E -> DU
        { int a; Q((f || G(out a)) && No()); F(a); } // Error
        { int a; if ((f || G(out a)) && No()) F(a); } // Error
        { int a; if ((f || G(out a)) && No()) No(); else F(a); } // Error
        // if T -> DA then E -> DA
        { int a; Q((f || G(out a)) && G(out a)); F(a); }
        // if T -> DAT then E -> DAT
        { int a; Q((f || G(out a)) && (f && G(out a))); F(a); } // Error
        { int a; if ((f || G(out a)) && (f && G(out a))) F(a); }
        // if T -> DAF then E -> DAF
        { int a; Q((f || G(out a)) && (f || G(out a))); F(a); } // Error
        { int a; if ((f || G(out a)) && (f || G(out a))) No(); else F(a); }

        // S -> DU then DU -> T
        { int a; Q(f && F(a)); } // Error
        // if T -> DA then E -> DAT
        { int a; Q(f && G(out a)); F(a); } // Error
        { int a; if (f && G(out a)) F(a); }
        // if T -> DAT then E -> DAT
        { int a; Q(f && (f && G(out a))); F(a); } // Error
        { int a; if (f && (f && G(out a))) F(a); }
        // if T -> DAF then E -> DU
        { int a; Q(f && (f || G(out a))); F(a); } // Error
        { int a; if (f && (f || G(out a))) F(a); } // Error
        { int a; if (f && (f || G(out a))) No(); else F(a); } // Error
        // if T -> DU then E -> DU
        { int a; Q(f && f); F(a); } // Error
        { int a; if (f && f) F(a); } // Error
        { int a; if (f && f) No(); else F(a); } // Error
    }

    // Logical or: E -> S || T
    public void T350() {
        // S -> DA then DA -> T and E -> DA
        { int a; Q(G(out a) || F(a)); } // DA -> T
        { int a; Q(G(out a) || No()); F(a); } // E -> DA

        // S -> DAF then DA -> T and E -> DAF
        { int a; Q((f || G(out a)) || F(a)); } // DA -> T
        { int a; Q((f || G(out a)) || No()); F(a); } // Error
        { int a; if ((f || G(out a)) || No()) No(); else F(a); } // E -> DAF

        // S -> DAT then DU -> T
        { int a; Q((f && G(out a)) || F(a)); } // Error
        // if T -> DU then E -> DU
        { int a; Q((f && G(out a)) || No()); F(a); } // Error
        { int a; if ((f && G(out a)) || No()) F(a); } // Error
        { int a; if ((f && G(out a)) || No()) No(); else F(a); } // Error
        // if T -> DA then E -> DA
        { int a; Q((f && G(out a)) || G(out a)); F(a); }
        // if T -> DAF then E -> DAF
        { int a; Q((f && G(out a)) || (f || G(out a))); F(a); } // Error
        { int a; if ((f && G(out a)) || (f || G(out a))) No(); else F(a); }
        // if T -> DAT then E -> DAT
        { int a; Q((f && G(out a)) || (f && G(out a))); F(a); } // Error
        { int a; if ((f && G(out a)) || (f && G(out a))) F(a); }

        // S -> DU then DU -> T
        { int a; Q(f || F(a)); } // Error
        // if T -> DA then E -> DAF
        { int a; Q(f || G(out a)); F(a); } // Error
        { int a; if (f || G(out a)) No(); else F(a); }
        // if T -> DAF then E -> DAF
        { int a; Q(f || (f || G(out a))); F(a); } // Error
        { int a; if (f || (f || G(out a))) No(); else F(a); }
        // if T -> DAT then E -> DU
        { int a; Q(f || (f && G(out a))); F(a); } // Error
        { int a; if (f || (f && G(out a))) F(a); } // Error
        { int a; if (f || (f && G(out a))) No(); else F(a); } // Error
        // if T -> DU then E -> DU
        { int a; Q(f || f); F(a); } // Error
        { int a; if (f || f) F(a); } // Error
        { int a; if (f || f) No(); else F(a); } // Error
    }

    // Logical not: E -> !S
    public void T360() {
        { bool a; Q(!a); } // Error

        { int a; Q(!G(out a)); F(a); }
        { int a; Q(!No()); F(a); } // Error

        // S -> DAF : E -> DAT
        { int a; Q(!(f || G(out a))); F(a); } // Error
        { int a; if (!(f || G(out a))) F(a); }

        // S -> DAT : E -> DAF
        { int a; Q(!(f && G(out a))); F(a); } // Error
        { int a; if (!(f && G(out a))) No(); else F(a); }
    }

    // Ternary operator: E -> S ? T : U;
    // For definite assignment purposes, this behaves the same as ""if (S) T; else U;""
    public void T370() {
        { bool a; F(a ? 1 : 2); } // Error

        // S -> DU
        { int a; F(f ? a : 2); } // Error
        { int a; F(f ? 1 : a); } // Error
        { int a; F(f ? 1 : 2); F(a); } // Error

        { int a; F(fFalse ? a : 2); } // no DA error; expr is not reachable
        { int a; F(fFalse ? 1 : a); } // 

        { int a; F(fTrue ? a : 2); } // Error - should it also be unreachable?
        { int a; F(fTrue ? 1 : a); } // BUG: Spec says error. Should this be unreachable?

        // S -> DA then DA -> T, DA -> U, E -> DA
        { int a; F(G(out a) ? a : 2); }
        { int a; F(G(out a) ? 1 : a); }
        { int a; F(G(out a) ? 1 : 2); F(a); }

        // S -> DAT then DA -> T, DU -> U

        // Assigned after true.
        { int a; F(f && G(out a) ? a : 2); }
        { int a; F(f && G(out a) ? 1 : a); } // Error
        { int a; F(f && G(out a) ? 1 : 2); F(a); } // Error
        { int a; F(f && G(out a) ? 1 : NG(out a)); F(a); }

        // Assigned.
        { int a; F(fTrue && G(out a) ? a : 2); }
        { int a; F(fTrue && G(out a) ? 1 : a); }
        { int a; F(fTrue && G(out a) ? 1 : 2); F(a); }

        // Unassigned.
        { int a; F(fFalse && G(out a) ? a : 2); } // Error
        { int a; F(fFalse && G(out a) ? 1 : a); } // Error
        { int a; F(fFalse && G(out a) ? 1 : 2); F(a); } // Error
        { int a; F(fFalse && G(out a) ? 1 : NG(out a)); F(a); } // Error

        // Unassigned.
        { int a; F(fFalse && F(a) ? a : 2); } // Error on a
        { int a; F(fFalse && F(a) ? 1 : a); } // Error on a
        { int a; F(fFalse && F(a) ? 1 : 2); F(a); } // Error on second F(a)
        { int a; F(fFalse && F(a) ? 1 : NG(out a)); F(a); } // Error on second F(a)

        // Assigned after false.
        { int a; F(f || G(out a) ? a : 2); } // Error
        { int a; F(f || G(out a) ? 1 : a); }
        { int a; F(f || G(out a) ? 1 : 2); F(a); } // Error
        { int a; F(f || G(out a) ? NG(out a) : 2); F(a); }

        // Unassigned, unreachable expression.
        { int a; F(fTrue || G(out a) ? a : 2); } // Error
        { int a; F(fTrue || G(out a) ? 1 : a); } // Error
        { int a; F(fTrue || G(out a) ? 1 : 2); F(a); } // Error
        { int a; F(fTrue || G(out a) ? NG(out a) : 2); F(a); } // Error

        // Assigned.
        { int a; F(fFalse || G(out a) ? a : 2); }
        { int a; F(fFalse || G(out a) ? 1 : a); }
        { int a; F(fFalse || G(out a) ? 1 : 2); F(a); }
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 84564, 97860);

                f_28002_84564_97859(f_28002_84564_84589(source), f_28002_84788_84853(f_28002_84788_84834(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_85028_85093(f_28002_85028_85074(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_85274_85339(f_28002_85274_85320(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_85521_85586(f_28002_85521_85567(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_85779_85844(f_28002_85779_85825(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_86036_86101(f_28002_86036_86082(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_86293_86358(f_28002_86293_86339(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_86519_86584(f_28002_86519_86565(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_86755_86820(f_28002_86755_86801(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_86998_87063(f_28002_86998_87044(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_87241_87306(f_28002_87241_87287(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_87485_87550(f_28002_87485_87531(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_87740_87805(f_28002_87740_87786(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_87969_88034(f_28002_87969_88015(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_88199_88264(f_28002_88199_88245(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_88440_88505(f_28002_88440_88486(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_88687_88752(f_28002_88687_88733(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_88928_88993(f_28002_88928_88974(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_89175_89240(f_28002_89175_89221(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_89423_89488(f_28002_89423_89469(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_89682_89747(f_28002_89682_89728(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_89940_90005(f_28002_89940_89986(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_90198_90263(f_28002_90198_90244(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_90425_90490(f_28002_90425_90471(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_90662_90727(f_28002_90662_90708(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_90906_90971(f_28002_90906_90952(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_91150_91215(f_28002_91150_91196(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_91395_91460(f_28002_91395_91441(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_91651_91716(f_28002_91651_91697(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_91881_91946(f_28002_91881_91927(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_92112_92177(f_28002_92112_92158(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_92354_92419(f_28002_92354_92400(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_92575_92640(f_28002_92575_92621(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_92804_92869(f_28002_92804_92850(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_93044_93109(f_28002_93044_93090(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_93284_93349(f_28002_93284_93330(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_93512_93577(f_28002_93512_93558(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_93739_93804(f_28002_93739_93785(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_93966_94031(f_28002_93966_94012(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_94199_94264(f_28002_94199_94245(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_94426_94491(f_28002_94426_94472(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_94690_94755(f_28002_94690_94736(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_94929_94994(f_28002_94929_94975(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_95174_95239(f_28002_95174_95220(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_95526_95591(f_28002_95526_95572(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_95776_95841(f_28002_95776_95822(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_96233_96298(f_28002_96233_96279(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_96494_96559(f_28002_96494_96540(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_96824_96889(f_28002_96824_96870(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_97069_97134(f_28002_97069_97115(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_97312_97377(f_28002_97312_97358(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_97669_97734(f_28002_97669_97715(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 77199, 97871);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_84564_84589(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 84564, 84589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_84788_84834(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 84788, 84834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_84788_84853(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 84788, 84853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_85028_85074(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 85028, 85074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_85028_85093(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 85028, 85093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_85274_85320(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 85274, 85320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_85274_85339(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 85274, 85339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_85521_85567(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 85521, 85567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_85521_85586(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 85521, 85586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_85779_85825(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 85779, 85825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_85779_85844(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 85779, 85844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86036_86082(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86036, 86082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86036_86101(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86036, 86101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86293_86339(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86293, 86339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86293_86358(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86293, 86358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86519_86565(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86519, 86565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86519_86584(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86519, 86584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86755_86801(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86755, 86801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86755_86820(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86755, 86820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86998_87044(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86998, 87044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_86998_87063(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 86998, 87063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_87241_87287(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 87241, 87287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_87241_87306(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 87241, 87306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_87485_87531(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 87485, 87531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_87485_87550(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 87485, 87550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_87740_87786(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 87740, 87786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_87740_87805(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 87740, 87805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_87969_88015(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 87969, 88015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_87969_88034(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 87969, 88034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_88199_88245(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 88199, 88245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_88199_88264(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 88199, 88264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_88440_88486(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 88440, 88486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_88440_88505(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 88440, 88505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_88687_88733(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 88687, 88733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_88687_88752(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 88687, 88752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_88928_88974(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 88928, 88974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_88928_88993(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 88928, 88993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_89175_89221(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 89175, 89221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_89175_89240(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 89175, 89240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_89423_89469(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 89423, 89469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_89423_89488(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 89423, 89488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_89682_89728(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 89682, 89728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_89682_89747(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 89682, 89747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_89940_89986(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 89940, 89986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_89940_90005(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 89940, 90005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_90198_90244(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 90198, 90244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_90198_90263(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 90198, 90263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_90425_90471(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 90425, 90471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_90425_90490(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 90425, 90490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_90662_90708(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 90662, 90708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_90662_90727(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 90662, 90727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_90906_90952(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 90906, 90952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_90906_90971(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 90906, 90971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_91150_91196(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 91150, 91196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_91150_91215(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 91150, 91215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_91395_91441(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 91395, 91441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_91395_91460(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 91395, 91460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_91651_91697(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 91651, 91697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_91651_91716(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 91651, 91716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_91881_91927(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 91881, 91927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_91881_91946(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 91881, 91946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_92112_92158(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 92112, 92158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_92112_92177(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 92112, 92177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_92354_92400(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 92354, 92400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_92354_92419(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 92354, 92419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_92575_92621(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 92575, 92621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_92575_92640(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 92575, 92640);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_92804_92850(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 92804, 92850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_92804_92869(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 92804, 92869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93044_93090(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93044, 93090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93044_93109(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93044, 93109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93284_93330(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93284, 93330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93284_93349(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93284, 93349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93512_93558(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93512, 93558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93512_93577(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93512, 93577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93739_93785(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93739, 93785);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93739_93804(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93739, 93804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93966_94012(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93966, 94012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_93966_94031(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 93966, 94031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_94199_94245(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 94199, 94245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_94199_94264(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 94199, 94264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_94426_94472(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 94426, 94472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_94426_94491(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 94426, 94491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_94690_94736(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 94690, 94736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_94690_94755(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 94690, 94755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_94929_94975(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 94929, 94975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_94929_94994(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 94929, 94994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_95174_95220(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 95174, 95220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_95174_95239(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 95174, 95239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_95526_95572(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 95526, 95572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_95526_95591(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 95526, 95591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_95776_95822(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 95776, 95822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_95776_95841(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 95776, 95841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_96233_96279(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 96233, 96279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_96233_96298(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 96233, 96298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_96494_96540(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 96494, 96540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_96494_96559(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 96494, 96559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_96824_96870(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 96824, 96870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_96824_96889(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 96824, 96889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_97069_97115(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 97069, 97115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_97069_97134(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 97069, 97134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_97312_97358(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 97312, 97358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_97312_97377(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 97312, 97377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_97669_97715(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 97669, 97715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_97669_97734(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 97669, 97734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_84564_97859(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 84564, 97859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 77199, 97871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 77199, 97871);
            }
        }

        [Fact]
        public void WhidbeyBug467493()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 97883, 98884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 97954, 98188);

                var
                source = prefix + @"
    // Whidbey bug #467493
    public static void M4() {
        int x;
        throw new Exception();
        ((DI)(delegate { if (x == 1) return 1; Console.WriteLine(""Bug""); }))();
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 98204, 98873);

                f_28002_98204_98872(f_28002_98204_98229(source), f_28002_98476_98598(f_28002_98476_98577(f_28002_98476_98537(ErrorCode.ERR_AnonymousReturnExpected, "delegate"), "anonymous method", "DI"), 78, 15), f_28002_98787_98853(f_28002_98787_98833(ErrorCode.WRN_UnreachableCode, "("), 78, 9));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 97883, 98884);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_98204_98229(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 98204, 98229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_98476_98537(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 98476, 98537);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_98476_98577(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 98476, 98577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_98476_98598(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 98476, 98598);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_98787_98833(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 98787, 98833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_98787_98853(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 98787, 98853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_98204_98872(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 98204, 98872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 97883, 98884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 97883, 98884);
            }
        }

        [WorkItem(648107, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/648107")]
        [Fact]
        public void WhidbeyBug479106()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 98896, 99911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 99059, 99554);

                var
                source = prefix + @"
    // Whidbey bug #479106
    public unsafe struct SF {
        public int x;
        public fixed int arr[5];
    }
    public unsafe static void M5() {
        SF s;
        s.arr[0]++; // OK

        SF[] rgs = new SF[2];
        fixed (SF * prgs = rgs) {
            int a;
            int b;
            prgs[a].arr[0] = 5; // Error: a
            prgs[b = 1].arr[0] = 5; // No error
            Console.WriteLine(b);
        }
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 99570, 99900);

                f_28002_99570_99899(f_28002_99570_99634(source, options: TestOptions.UnsafeReleaseDll), f_28002_99815_99880(f_28002_99815_99861(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 98896, 99911);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_99570_99634(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 99570, 99634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_99815_99861(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 99815, 99861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_99815_99880(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 99815, 99880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_99570_99899(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 99570, 99899);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 98896, 99911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 98896, 99911);
            }
        }

        [Fact, WorkItem(31370, "https://github.com/dotnet/roslyn/issues/31370")]
        public void WhidbeyBug467493_WithSuppression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 99923, 101064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 100076, 100312);

                var
                source = prefix + @"
    // Whidbey bug #467493
    public static void M4() {
        int x;
        throw new Exception();
        ((DI)(delegate { if (x == 1) return 1; Console.WriteLine(""Bug""); } !))();
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 100384, 101053);

                f_28002_100384_101052(f_28002_100384_100409(source), f_28002_100656_100778(f_28002_100656_100757(f_28002_100656_100717(ErrorCode.ERR_AnonymousReturnExpected, "delegate"), "anonymous method", "DI"), 78, 15), f_28002_100967_101033(f_28002_100967_101013(ErrorCode.WRN_UnreachableCode, "("), 78, 9));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 99923, 101064);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_100384_100409(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 100384, 100409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_100656_100717(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 100656, 100717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_100656_100757(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 100656, 100757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_100656_100778(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 100656, 100778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_100967_101013(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 100967, 101013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_100967_101033(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 100967, 101033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_100384_101052(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 100384, 101052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 99923, 101064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 99923, 101064);
            }
        }

        [Fact]
        public void AccessingFixedFieldUsesTheReceiver()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 101076, 101588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 101165, 101476);

                var
                source = prefix + @"
    // Whidbey bug #479106
    public unsafe struct SF {
        public int x;
        public fixed int arr[5];
    }
    public unsafe struct SF2 {
        public SF z;
    }
    public unsafe static void M5() {
        SF2 s;
        s.z.arr[0]++; // OK
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 101492, 101577);

                f_28002_101492_101576(f_28002_101492_101556(source, options: TestOptions.UnsafeReleaseDll));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 101076, 101588);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_101492_101556(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 101492, 101556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_101492_101576(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 101492, 101576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 101076, 101588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 101076, 101588);
            }
        }

        [WorkItem(529603, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529603")]
        [Fact]
        public void TernaryOperator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 101600, 140036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 101762, 115097);

                var
                source = prefix + @"
    public static void M8()
    {
        int b = 1;
        int c = 1;
        int d = 1;
        bool x = true;
        bool y = false;
        bool z = false;

// ?: operator

// Check for state before exprtrue:

/* NDA --> NDA */       { int a; if (x               ? F(a) : F(b)) b = c; else d = c; } // Error
/* DAT --> DA  */       { int a; if ((x && G(out a)) ? F(a) : F(b)) b = c; else d = c; } // OK
/* DAF --> NDA */       { int a; if ((x || G(out a)) ? F(a) : F(b)) b = c; else d = c; } // Error
/* DA  --> DA  */       { int a; if (G(out a)        ? F(a) : F(b)) b = c; else d = c; } // OK

// Check for state before exprfalse:

/* NDA --> NDA */       { int a; if (x               ? F(b) : F(a)) b = c; else d = c; } // Error
/* DAT --> NDA */       { int a; if ((x && G(out a)) ? F(b) : F(a)) b = c; else d = c; } // Error
/* DAF --> DA  */       { int a; if ((x || G(out a)) ? F(b) : F(a)) b = c; else d = c; } // OK
/* DA  --> DA  */       { int a; if (G(out a)        ? F(b) : F(a)) b = c; else d = c; } // OK

// Check for state after expr:

/* NDA?NDA:NDA-->NDA */ { int a; if (x               ? y               : z)               b = a; else d = c; } // Error
/* NDA?NDA:NDA-->NDA */ { int a; if (x               ? y               : z)               b = c; else d = a; } // Error
/* NDA?NDA:DAT-->NDA */ { int a; if (x               ? y               : (z && G(out a))) b = a; else d = c; } // Error
/* NDA?NDA:DAT-->NDA */ { int a; if (x               ? y               : (z && G(out a))) b = c; else d = a; } // Error
/* NDA?NDA:DAF-->NDA */ { int a; if (x               ? y               : (z || G(out a))) b = a; else d = c; } // Error
/* NDA?NDA:DAF-->NDA */ { int a; if (x               ? y               : (z || G(out a))) b = c; else d = a; } // Error
/* NDA?NDA:DA -->NDA */ { int a; if (x               ? y               : G(out a))        b = a; else d = c; } // Error
/* NDA?NDA:DA -->NDA */ { int a; if (x               ? y               : G(out a))        b = c; else d = a; } // Error
/* NDA?DAT:NDA-->NDA */ { int a; if (x               ? (y && G(out a)) : z)               b = a; else d = c; } // Error
/* NDA?DAT:NDA-->NDA */ { int a; if (x               ? (y && G(out a)) : z)               b = c; else d = a; } // Error
/* NDA?DAT:DAT-->DAT */ { int a; if (x               ? (y && G(out a)) : (z && G(out a))) b = a; else d = c; } // OK
/* NDA?DAT:DAT-->DAT */ { int a; if (x               ? (y && G(out a)) : (z && G(out a))) b = c; else d = a; } // Error
/* NDA?DAT:DAF-->NDA */ { int a; if (x               ? (y && G(out a)) : (z || G(out a))) b = a; else d = c; } // Error
/* NDA?DAT:DAF-->NDA */ { int a; if (x               ? (y && G(out a)) : (z || G(out a))) b = c; else d = a; } // Error
/* NDA?DAT:DA -->DAT */ { int a; if (x               ? (y && G(out a)) : G(out a))        b = a; else d = c; } // OK
/* NDA?DAT:DA -->DAT */ { int a; if (x               ? (y && G(out a)) : G(out a))        b = c; else d = a; } // Error
/* NDA?DAF:NDA-->NDA */ { int a; if (x               ? (y || G(out a)) : z)               b = a; else d = c; } // Error
/* NDA?DAF:NDA-->NDA */ { int a; if (x               ? (y || G(out a)) : z)               b = c; else d = a; } // Error
/* NDA?DAF:DAT-->NDA */ { int a; if (x               ? (y || G(out a)) : (z && G(out a))) b = a; else d = c; } // Error
/* NDA?DAF:DAT-->NDA */ { int a; if (x               ? (y || G(out a)) : (z && G(out a))) b = c; else d = a; } // Error
/* NDA?DAF:DAF-->DAF */ { int a; if (x               ? (y || G(out a)) : (z || G(out a))) b = a; else d = c; } // Error
/* NDA?DAF:DAF-->DAF */ { int a; if (x               ? (y || G(out a)) : (z || G(out a))) b = c; else d = a; } // OK
/* NDA?DAF:DA -->DAF */ { int a; if (x               ? (y || G(out a)) : G(out a))        b = a; else d = c; } // Error
/* NDA?DAF:DA -->DAF */ { int a; if (x               ? (y || G(out a)) : G(out a))        b = c; else d = a; } // OK
/* NDA?DA :NDA-->NDA */ { int a; if (x               ? G(out a)        : z)               b = a; else d = c; } // Error
/* NDA?DA :NDA-->NDA */ { int a; if (x               ? G(out a)        : z)               b = c; else d = a; } // Error
/* NDA?DA :DAT-->DAT */ { int a; if (x               ? G(out a)        : (z && G(out a))) b = a; else d = c; } // OK
/* NDA?DA :DAT-->DAT */ { int a; if (x               ? G(out a)        : (z && G(out a))) b = c; else d = a; } // Error
/* NDA?DA :DAF-->DAF */ { int a; if (x               ? G(out a)        : (z || G(out a))) b = a; else d = c; } // Error
/* NDA?DA :DAF-->DAF */ { int a; if (x               ? G(out a)        : (z || G(out a))) b = c; else d = a; } // OK
/* NDA?DA :DA -->DA  */ { int a; if (x               ? G(out a)        : G(out a))        b = a; else d = a; } // OK
/* DAT?NDA:NDA-->NDA */ { int a; if ((x && G(out a)) ? y               : z)               b = a; else d = c; } // Error
/* DAT?NDA:NDA-->NDA */ { int a; if ((x && G(out a)) ? y               : z)               b = c; else d = a; } // Error
/* DAT?NDA:DAT-->DAT */ { int a; if ((x && G(out a)) ? y               : (z && G(out a))) b = a; else d = c; } // OK
/* DAT?NDA:DAT-->DAT */ { int a; if ((x && G(out a)) ? y               : (z && G(out a))) b = c; else d = a; } // Error
/* DAT?NDA:DAF-->DAF */ { int a; if ((x && G(out a)) ? y               : (z || G(out a))) b = a; else d = c; } // Error
/* DAT?NDA:DAF-->DAF */ { int a; if ((x && G(out a)) ? y               : (z || G(out a))) b = c; else d = a; } // OK
/* DAT?NDA:DA -->DA  */ { int a; if ((x && G(out a)) ? y               : G(out a))        b = a; else d = a; } // OK
/* DAT?DAT:NDA-->NDA */ { int a; if ((x && G(out a)) ? (y && G(out a)) : z)               b = a; else d = c; } // Error
/* DAT?DAT:NDA-->NDA */ { int a; if ((x && G(out a)) ? (y && G(out a)) : z)               b = c; else d = a; } // Error
/* DAT?DAT:DAT-->DAT */ { int a; if ((x && G(out a)) ? (y && G(out a)) : (z && G(out a))) b = a; else d = c; } // OK
/* DAT?DAT:DAT-->DAT */ { int a; if ((x && G(out a)) ? (y && G(out a)) : (z && G(out a))) b = c; else d = a; } // Error
/* DAT?DAT:DAF-->DAF */ { int a; if ((x && G(out a)) ? (y && G(out a)) : (z || G(out a))) b = a; else d = c; } // Error
/* DAT?DAT:DAF-->DAF */ { int a; if ((x && G(out a)) ? (y && G(out a)) : (z || G(out a))) b = c; else d = a; } // OK
/* DAT?DAT:DA -->DA  */ { int a; if ((x && G(out a)) ? (y && G(out a)) : G(out a))        b = a; else d = a; } // OK
/* DAT?DAF:NDA-->NDA */ { int a; if ((x && G(out a)) ? (y || G(out a)) : z)               b = a; else d = c; } // Error
/* DAT?DAF:NDA-->NDA */ { int a; if ((x && G(out a)) ? (y || G(out a)) : z)               b = c; else d = a; } // Error
/* DAT?DAF:DAT-->DAT */ { int a; if ((x && G(out a)) ? (y || G(out a)) : (z && G(out a))) b = a; else d = c; } // OK
/* DAT?DAF:DAT-->DAT */ { int a; if ((x && G(out a)) ? (y || G(out a)) : (z && G(out a))) b = c; else d = a; } // Error
/* DAT?DAF:DAF-->DAF */ { int a; if ((x && G(out a)) ? (y || G(out a)) : (z || G(out a))) b = a; else d = c; } // Error
/* DAT?DAF:DAF-->DAF */ { int a; if ((x && G(out a)) ? (y || G(out a)) : (z || G(out a))) b = c; else d = a; } // OK
/* DAT?DAF:DA -->DA  */ { int a; if ((x && G(out a)) ? (y || G(out a)) : G(out a))        b = a; else d = a; } // OK
/* DAT?DA :NDA-->NDA */ { int a; if ((x && G(out a)) ? G(out a)        : z)               b = a; else d = c; } // Error
/* DAT?DA :NDA-->NDA */ { int a; if ((x && G(out a)) ? G(out a)        : z)               b = c; else d = a; } // Error
/* DAT?DA :DAT-->DAT */ { int a; if ((x && G(out a)) ? G(out a)        : (z && G(out a))) b = a; else d = c; } // OK
/* DAT?DA :DAT-->DAT */ { int a; if ((x && G(out a)) ? G(out a)        : (z && G(out a))) b = c; else d = a; } // Error
/* DAT?DA :DAF-->DAF */ { int a; if ((x && G(out a)) ? G(out a)        : (z || G(out a))) b = a; else d = c; } // Error
/* DAT?DA :DAF-->DAF */ { int a; if ((x && G(out a)) ? G(out a)        : (z || G(out a))) b = c; else d = a; } // OK
/* DAT?DA :DA -->DA  */ { int a; if ((x && G(out a)) ? G(out a)        : G(out a))        b = a; else d = a; } // OK
/* DAF?NDA:NDA-->NDA */ { int a; if ((x || G(out a)) ? y               : z)               b = a; else d = c; } // Error
/* DAF?NDA:NDA-->NDA */ { int a; if ((x || G(out a)) ? y               : z)               b = c; else d = a; } // Error
/* DAF?NDA:DAT-->NDA */ { int a; if ((x || G(out a)) ? y               : (z && G(out a))) b = a; else d = c; } // Error
/* DAF?NDA:DAT-->NDA */ { int a; if ((x || G(out a)) ? y               : (z && G(out a))) b = c; else d = a; } // Error
/* DAF?NDA:DAF-->NDA */ { int a; if ((x || G(out a)) ? y               : (z || G(out a))) b = a; else d = c; } // Error
/* DAF?NDA:DAF-->NDA */ { int a; if ((x || G(out a)) ? y               : (z || G(out a))) b = c; else d = a; } // Error
/* DAF?NDA:DA -->NDA */ { int a; if ((x || G(out a)) ? y               : G(out a))        b = c; else d = a; } // Error
/* DAF?NDA:DA -->NDA */ { int a; if ((x || G(out a)) ? y               : G(out a))        b = c; else d = a; } // Error
/* DAF?DAT:NDA-->DAT */ { int a; if ((x || G(out a)) ? (y && G(out a)) : z)               b = a; else d = c; } // OK
/* DAF?DAT:NDA-->DAT */ { int a; if ((x || G(out a)) ? (y && G(out a)) : z)               b = c; else d = a; } // Error
/* DAF?DAT:DAT-->DAT */ { int a; if ((x || G(out a)) ? (y && G(out a)) : (z && G(out a))) b = a; else d = c; } // OK
/* DAF?DAT:DAT-->DAT */ { int a; if ((x || G(out a)) ? (y && G(out a)) : (z && G(out a))) b = c; else d = a; } // Error
/* DAF?DAT:DAF-->DAT */ { int a; if ((x || G(out a)) ? (y && G(out a)) : (z || G(out a))) b = a; else d = c; } // OK
/* DAF?DAT:DAF-->DAT */ { int a; if ((x || G(out a)) ? (y && G(out a)) : (z || G(out a))) b = c; else d = a; } // Error
/* DAF?DAT:DA -->DAT */ { int a; if ((x || G(out a)) ? (y && G(out a)) : G(out a))        b = a; else d = c; } // OK
/* DAF?DAT:DA -->DAT */ { int a; if ((x || G(out a)) ? (y && G(out a)) : G(out a))        b = c; else d = a; } // Error
/* DAF?DAF:NDA-->DAF */ { int a; if ((x || G(out a)) ? (y || G(out a)) : z)               b = a; else d = c; } // Error
/* DAF?DAF:NDA-->DAF */ { int a; if ((x || G(out a)) ? (y || G(out a)) : z)               b = c; else d = a; } // OK
/* DAF?DAF:DAT-->DAF */ { int a; if ((x || G(out a)) ? (y || G(out a)) : (z && G(out a))) b = a; else d = c; } // Error
/* DAF?DAF:DAT-->DAF */ { int a; if ((x || G(out a)) ? (y || G(out a)) : (z && G(out a))) b = c; else d = a; } // OK
/* DAF?DAF:DAF-->DAF */ { int a; if ((x || G(out a)) ? (y || G(out a)) : (z || G(out a))) b = a; else d = c; } // Error
/* DAF?DAF:DAF-->DAF */ { int a; if ((x || G(out a)) ? (y || G(out a)) : (z || G(out a))) b = c; else d = a; } // OK
/* DAF?DAF:DA -->DAF */ { int a; if ((x || G(out a)) ? (y || G(out a)) : G(out a))        b = a; else d = c; } // Error
/* DAF?DAF:DA -->DAF */ { int a; if ((x || G(out a)) ? (y || G(out a)) : G(out a))        b = c; else d = a; } // OK
/* DAF?DA :NDA-->DA  */ { int a; if ((x || G(out a)) ? G(out a)        : z)               b = a; else d = a; } // OK
/* DAF?DA :DAT-->DA  */ { int a; if ((x || G(out a)) ? G(out a)        : (z && G(out a))) b = a; else d = a; } // OK
/* DAF?DA :DAF-->DA  */ { int a; if ((x || G(out a)) ? G(out a)        : (z || G(out a))) b = a; else d = a; } // OK
/* DAF?DA :DA -->DA  */ { int a; if ((x || G(out a)) ? G(out a)        : G(out a))        b = a; else d = a; } // OK
/* DA ?NDA:NDA-->DA  */ { int a; if (G(out a)        ? y               : z)               b = a; else d = a; } // OK
/* DA ?NDA:DAT-->DA  */ { int a; if (G(out a)        ? y               : (z && G(out a))) b = a; else d = a; } // OK
/* DA ?NDA:DAF-->DA  */ { int a; if (G(out a)        ? y               : (z || G(out a))) b = a; else d = a; } // OK
/* DA ?NDA:DA -->DA  */ { int a; if (G(out a)        ? y               : G(out a))        b = a; else d = a; } // OK
/* DA ?DAT:NDA-->DA  */ { int a; if (G(out a)        ? (y && G(out a)) : z)               b = a; else d = a; } // OK
/* DA ?DAT:DAT-->DA  */ { int a; if (G(out a)        ? (y && G(out a)) : (z && G(out a))) b = a; else d = a; } // OK
/* DA ?DAT:DAF-->DA  */ { int a; if (G(out a)        ? (y && G(out a)) : (z || G(out a))) b = a; else d = a; } // OK
/* DA ?DAT:DA -->DA  */ { int a; if (G(out a)        ? (y && G(out a)) : G(out a))        b = a; else d = a; } // OK
/* DA ?DAF:NDA-->DA  */ { int a; if (G(out a)        ? (y || G(out a)) : z)               b = a; else d = a; } // OK
/* DA ?DAF:DAT-->DA  */ { int a; if (G(out a)        ? (y || G(out a)) : (z && G(out a))) b = a; else d = a; } // OK
/* DA ?DAF:DAF-->DA  */ { int a; if (G(out a)        ? (y || G(out a)) : (z || G(out a))) b = a; else d = a; } // OK
/* DA ?DAF:DA -->DA  */ { int a; if (G(out a)        ? (y || G(out a)) : G(out a))        b = a; else d = a; } // OK
/* DA ?DA :NDA-->DA  */ { int a; if (G(out a)        ? G(out a)        : z)               b = a; else d = a; } // OK
/* DA ?DA :DAT-->DA  */ { int a; if (G(out a)        ? G(out a)        : (z && G(out a))) b = a; else d = a; } // OK
/* DA ?DA :DAF-->DA  */ { int a; if (G(out a)        ? G(out a)        : (z || G(out a))) b = a; else d = a; } // OK
    }
" + suffix
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 115113, 140025);

                f_28002_115113_140024(f_28002_115113_115138(source), f_28002_115373_115438(f_28002_115373_115419(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_115655_115720(f_28002_115655_115701(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_115937_116002(f_28002_115937_115983(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_116219_116284(f_28002_116219_116265(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_116523_116588(f_28002_116523_116569(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_116828_116893(f_28002_116828_116874(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_117132_117197(f_28002_117132_117178(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_117437_117502(f_28002_117437_117483(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_117741_117806(f_28002_117741_117787(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_118046_118111(f_28002_118046_118092(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_118350_118415(f_28002_118350_118396(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_118655_118720(f_28002_118655_118701(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_118959_119024(f_28002_118959_119005(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_119264_119329(f_28002_119264_119310(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_119565_119630(f_28002_119565_119611(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_119870_119935(f_28002_119870_119916(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_120174_120239(f_28002_120174_120220(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_120479_120544(f_28002_120479_120525(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_120780_120845(f_28002_120780_120826(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_121085_121150(f_28002_121085_121131(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_121389_121454(f_28002_121389_121435(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_121694_121759(f_28002_121694_121740(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_121998_122063(f_28002_121998_122044(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_122303_122368(f_28002_122303_122349(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_122607_122672(f_28002_122607_122653(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_122909_122974(f_28002_122909_122955(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_123213_123278(f_28002_123213_123259(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_123515_123580(f_28002_123515_123561(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_123819_123884(f_28002_123819_123865(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_124125_124190(f_28002_124125_124171(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_124427_124492(f_28002_124427_124473(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_124733_124798(f_28002_124733_124779(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_125038_125103(f_28002_125038_125084(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_125341_125406(f_28002_125341_125387(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_125646_125711(f_28002_125646_125692(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_125952_126017(f_28002_125952_125998(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_126254_126319(f_28002_126254_126300(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_126560_126625(f_28002_126560_126606(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_126865_126930(f_28002_126865_126911(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_127168_127233(f_28002_127168_127214(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_127473_127538(f_28002_127473_127519(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_127779_127844(f_28002_127779_127825(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_128081_128146(f_28002_128081_128127(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_128387_128452(f_28002_128387_128433(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_128692_128757(f_28002_128692_128738(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_128995_129060(f_28002_128995_129041(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_129300_129365(f_28002_129300_129346(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_129606_129671(f_28002_129606_129652(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_129908_129973(f_28002_129908_129954(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_130214_130279(f_28002_130214_130260(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_130519_130584(f_28002_130519_130565(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_130822_130887(f_28002_130822_130868(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_131127_131192(f_28002_131127_131173(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_131433_131498(f_28002_131433_131479(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_131735_131800(f_28002_131735_131781(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_132041_132106(f_28002_132041_132087(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_132346_132411(f_28002_132346_132392(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_132649_132714(f_28002_132649_132695(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_132954_133019(f_28002_132954_133000(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_133260_133325(f_28002_133260_133306(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_133565_133630(f_28002_133565_133611(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_133871_133936(f_28002_133871_133917(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_134176_134241(f_28002_134176_134222(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_134482_134547(f_28002_134482_134528(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_134788_134853(f_28002_134788_134834(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_135094_135159(f_28002_135094_135140(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_135396_135461(f_28002_135396_135442(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_135702_135767(f_28002_135702_135748(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_136004_136069(f_28002_136004_136050(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_136310_136375(f_28002_136310_136356(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_136612_136677(f_28002_136612_136658(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_136918_136983(f_28002_136918_136964(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_137220_137285(f_28002_137220_137266(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_137526_137591(f_28002_137526_137572(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_137831_137896(f_28002_137831_137877(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_138134_138199(f_28002_138134_138180(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_138439_138504(f_28002_138439_138485(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_138742_138807(f_28002_138742_138788(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_139047_139112(f_28002_139047_139093(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_139350_139415(f_28002_139350_139396(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_139655_139720(f_28002_139655_139701(ErrorCode.ERR_UseDefViolation, "a"), "a"), f_28002_139958_140023(f_28002_139958_140004(ErrorCode.ERR_UseDefViolation, "a"), "a"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 101600, 140036);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_115113_115138(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 115113, 115138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_115373_115419(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 115373, 115419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_115373_115438(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 115373, 115438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_115655_115701(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 115655, 115701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_115655_115720(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 115655, 115720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_115937_115983(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 115937, 115983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_115937_116002(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 115937, 116002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_116219_116265(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 116219, 116265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_116219_116284(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 116219, 116284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_116523_116569(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 116523, 116569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_116523_116588(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 116523, 116588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_116828_116874(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 116828, 116874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_116828_116893(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 116828, 116893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_117132_117178(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 117132, 117178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_117132_117197(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 117132, 117197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_117437_117483(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 117437, 117483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_117437_117502(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 117437, 117502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_117741_117787(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 117741, 117787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_117741_117806(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 117741, 117806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_118046_118092(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 118046, 118092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_118046_118111(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 118046, 118111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_118350_118396(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 118350, 118396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_118350_118415(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 118350, 118415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_118655_118701(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 118655, 118701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_118655_118720(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 118655, 118720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_118959_119005(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 118959, 119005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_118959_119024(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 118959, 119024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_119264_119310(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 119264, 119310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_119264_119329(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 119264, 119329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_119565_119611(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 119565, 119611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_119565_119630(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 119565, 119630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_119870_119916(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 119870, 119916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_119870_119935(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 119870, 119935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_120174_120220(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 120174, 120220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_120174_120239(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 120174, 120239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_120479_120525(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 120479, 120525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_120479_120544(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 120479, 120544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_120780_120826(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 120780, 120826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_120780_120845(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 120780, 120845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_121085_121131(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 121085, 121131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_121085_121150(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 121085, 121150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_121389_121435(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 121389, 121435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_121389_121454(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 121389, 121454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_121694_121740(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 121694, 121740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_121694_121759(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 121694, 121759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_121998_122044(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 121998, 122044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_121998_122063(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 121998, 122063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_122303_122349(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 122303, 122349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_122303_122368(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 122303, 122368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_122607_122653(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 122607, 122653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_122607_122672(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 122607, 122672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_122909_122955(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 122909, 122955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_122909_122974(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 122909, 122974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_123213_123259(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 123213, 123259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_123213_123278(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 123213, 123278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_123515_123561(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 123515, 123561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_123515_123580(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 123515, 123580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_123819_123865(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 123819, 123865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_123819_123884(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 123819, 123884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_124125_124171(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 124125, 124171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_124125_124190(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 124125, 124190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_124427_124473(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 124427, 124473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_124427_124492(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 124427, 124492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_124733_124779(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 124733, 124779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_124733_124798(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 124733, 124798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_125038_125084(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 125038, 125084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_125038_125103(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 125038, 125103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_125341_125387(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 125341, 125387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_125341_125406(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 125341, 125406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_125646_125692(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 125646, 125692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_125646_125711(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 125646, 125711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_125952_125998(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 125952, 125998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_125952_126017(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 125952, 126017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_126254_126300(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 126254, 126300);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_126254_126319(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 126254, 126319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_126560_126606(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 126560, 126606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_126560_126625(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 126560, 126625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_126865_126911(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 126865, 126911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_126865_126930(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 126865, 126930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_127168_127214(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 127168, 127214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_127168_127233(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 127168, 127233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_127473_127519(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 127473, 127519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_127473_127538(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 127473, 127538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_127779_127825(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 127779, 127825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_127779_127844(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 127779, 127844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_128081_128127(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 128081, 128127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_128081_128146(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 128081, 128146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_128387_128433(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 128387, 128433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_128387_128452(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 128387, 128452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_128692_128738(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 128692, 128738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_128692_128757(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 128692, 128757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_128995_129041(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 128995, 129041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_128995_129060(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 128995, 129060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_129300_129346(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 129300, 129346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_129300_129365(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 129300, 129365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_129606_129652(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 129606, 129652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_129606_129671(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 129606, 129671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_129908_129954(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 129908, 129954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_129908_129973(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 129908, 129973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_130214_130260(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 130214, 130260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_130214_130279(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 130214, 130279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_130519_130565(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 130519, 130565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_130519_130584(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 130519, 130584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_130822_130868(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 130822, 130868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_130822_130887(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 130822, 130887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_131127_131173(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 131127, 131173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_131127_131192(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 131127, 131192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_131433_131479(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 131433, 131479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_131433_131498(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 131433, 131498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_131735_131781(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 131735, 131781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_131735_131800(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 131735, 131800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_132041_132087(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 132041, 132087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_132041_132106(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 132041, 132106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_132346_132392(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 132346, 132392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_132346_132411(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 132346, 132411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_132649_132695(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 132649, 132695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_132649_132714(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 132649, 132714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_132954_133000(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 132954, 133000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_132954_133019(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 132954, 133019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_133260_133306(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 133260, 133306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_133260_133325(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 133260, 133325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_133565_133611(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 133565, 133611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_133565_133630(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 133565, 133630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_133871_133917(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 133871, 133917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_133871_133936(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 133871, 133936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_134176_134222(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 134176, 134222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_134176_134241(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 134176, 134241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_134482_134528(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 134482, 134528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_134482_134547(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 134482, 134547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_134788_134834(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 134788, 134834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_134788_134853(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 134788, 134853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_135094_135140(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 135094, 135140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_135094_135159(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 135094, 135159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_135396_135442(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 135396, 135442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_135396_135461(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 135396, 135461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_135702_135748(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 135702, 135748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_135702_135767(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 135702, 135767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_136004_136050(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 136004, 136050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_136004_136069(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 136004, 136069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_136310_136356(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 136310, 136356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_136310_136375(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 136310, 136375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_136612_136658(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 136612, 136658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_136612_136677(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 136612, 136677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_136918_136964(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 136918, 136964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_136918_136983(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 136918, 136983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_137220_137266(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 137220, 137266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_137220_137285(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 137220, 137285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_137526_137572(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 137526, 137572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_137526_137591(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 137526, 137591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_137831_137877(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 137831, 137877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_137831_137896(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 137831, 137896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_138134_138180(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 138134, 138180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_138134_138199(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 138134, 138199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_138439_138485(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 138439, 138485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_138439_138504(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 138439, 138504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_138742_138788(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 138742, 138788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_138742_138807(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 138742, 138807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_139047_139093(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 139047, 139093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_139047_139112(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 139047, 139112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_139350_139396(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 139350, 139396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_139350_139415(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 139350, 139415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_139655_139701(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 139655, 139701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_139655_139720(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 139655, 139720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_139958_140004(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 139958, 140004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_139958_140023(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 139958, 140023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_115113_140024(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 115113, 140024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 101600, 140036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 101600, 140036);
            }
        }

        [Fact, WorkItem(529603, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529603")]
        public void IfConditionalAnd()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 140048, 140994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 140201, 140610);

                var
                source = @"
class C
{
    static void Main(string[] args)
    {
        bool a = true, b = true, c = true; // values don't matter

        int x;
        if (a ? (b && Set(out x)) : (c && Set(out x)))
        {
            int y = x; // x is definitely assigned if we reach this point
        }
    }

    static bool Set(out int x)
    {
        x = 1;
        return true;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 140680, 140983);

                f_28002_140680_140982(f_28002_140680_140705(source), f_28002_140916_140981(f_28002_140916_140962(ErrorCode.ERR_UseDefViolation, "x"), "x"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 140048, 140994);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_140680_140705(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 140680, 140705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_140916_140962(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 140916, 140962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_140916_140981(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 140916, 140981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_140680_140982(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 140680, 140982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 140048, 140994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 140048, 140994);
            }
        }

        [WorkItem(545352, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/545352")]
        [Fact]
        public void UseDefViolationInDelegateInSwitchWithGoto()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 141006, 142108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 141194, 141515);

                var
                source = @"
public class C
{
    public static void Main()
    {
        switch (5)
        {
            case 1:
                System.Action a = delegate { int b; int c = b; }; // Error on b.
            Lab:
                break;
            case 5:
                goto Lab;
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 141529, 142097);

                f_28002_141529_142096(f_28002_141529_141554(source), f_28002_141762_141813(ErrorCode.WRN_UnreachableCode, "System"), f_28002_142012_142077(f_28002_142012_142058(ErrorCode.ERR_UseDefViolation, "b"), "b"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 141006, 142108);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_141529_141554(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 141529, 141554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_141762_141813(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 141762, 141813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_142012_142058(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 142012, 142058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_142012_142077(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 142012, 142077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_141529_142096(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 141529, 142096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 141006, 142108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 141006, 142108);
            }
        }

        [Fact]
        public void UseDefViolationInUnreachableDelegate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 142120, 142918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 142211, 142385);

                var
                source = @"
class C
{
    static void Main()
    {
        if (false)
        {
            System.Action a = () => { int x; int y = x; };
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 142401, 142907);

                f_28002_142401_142906(f_28002_142401_142426(source), f_28002_142612_142663(ErrorCode.WRN_UnreachableCode, "System"), f_28002_142840_142905(f_28002_142840_142886(ErrorCode.ERR_UseDefViolation, "x"), "x"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 142120, 142918);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_142401_142426(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 142401, 142426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_142612_142663(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 142612, 142663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_142840_142886(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 142840, 142886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_142840_142905(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 142840, 142905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_142401_142906(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 142401, 142906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 142120, 142918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 142120, 142918);
            }
        }

        [Fact]
        public void UseDef_ExceptionFilters1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 142930, 143270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 143009, 143199);

                var
                source = @"
class C
{
    static void Main()
    {
        try
        {
        }
        catch (System.Exception e) when (e.Message == null)
        {
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 143213, 143259);

                f_28002_143213_143258(f_28002_143213_143238(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 142930, 143270);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_143213_143238(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 143213, 143238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_143213_143258(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 143213, 143258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 142930, 143270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 142930, 143270);
            }
        }

        [Fact]
        public void UseDef_ExceptionFilters2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 143282, 143906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 143361, 143577);

                var
                source = @"
class C
{
    static void Main()
    {
        try
        {
        }
        catch (System.Exception e) when (F())
        {
        }
    }

    static bool F() { return true; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 143591, 143895);

                f_28002_143591_143894(f_28002_143591_143616(source), f_28002_143808_143893(f_28002_143808_143873(f_28002_143808_143854(ErrorCode.WRN_UnreferencedVar, "e"), "e"), 9, 33));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 143282, 143906);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_143591_143616(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 143591, 143616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_143808_143854(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 143808, 143854);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_143808_143873(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 143808, 143873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_143808_143893(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 143808, 143893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_143591_143894(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 143591, 143894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 143282, 143906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 143282, 143906);
            }
        }

        [Fact]
        public void UseDef_ExceptionFilters3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 143918, 144323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 143997, 144252);

                var
                source = @"
using System;
class C
{
    static void Main()
    {
        Exception f;

        try
        {
        }
        catch (Exception e) when ((f = e) != null)
        {
            Console.WriteLine(f);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 144266, 144312);

                f_28002_144266_144311(f_28002_144266_144291(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 143918, 144323);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_144266_144291(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 144266, 144291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_144266_144311(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 144266, 144311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 143918, 144323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 143918, 144323);
            }
        }

        [Fact]
        public void UseDef_ExceptionFilters4()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 144335, 144921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 144414, 144625);

                var
                source = @"
using System;
class C
{
    static void Main()
    {
        Exception f;

        try
        {
        }
        catch (Exception e) when (f == e)
        {
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 144639, 144910);

                f_28002_144639_144909(f_28002_144639_144664(source), f_28002_144843_144908(f_28002_144843_144889(ErrorCode.ERR_UseDefViolation, "f"), "f"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 144335, 144921);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_144639_144664(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 144639, 144664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_144843_144889(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 144843, 144889);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_144843_144908(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 144843, 144908);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_144639_144909(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 144639, 144909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 144335, 144921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 144335, 144921);
            }
        }

        [Fact]
        public void UseDef_ExceptionFilters5()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 144933, 145687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 145012, 145297);

                var
                source = @"
using System;
class C
{
    static void Main()
    {
        Exception f;

        try
        {
        }
        catch (Exception e) when ((f = e) != null)
        {
        }
        catch (Exception e) when (f == e)
        {
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 145405, 145676);

                f_28002_145405_145675(f_28002_145405_145430(source), f_28002_145609_145674(f_28002_145609_145655(ErrorCode.ERR_UseDefViolation, "f"), "f"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 144933, 145687);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_145405_145430(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 145405, 145430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_145609_145655(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 145609, 145655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_145609_145674(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 145609, 145674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_145405_145675(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 145405, 145675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 144933, 145687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 144933, 145687);
            }
        }

        [Fact]
        public void UseDef_ExceptionFilters6()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 145699, 146359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 145778, 146071);

                var
                source = @"
using System;
class C
{
    static void Main()
    {
        Exception f, g;

        try
        {
        }
        catch (Exception e) when ((f = e) != null)
        {
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 146085, 146348);

                f_28002_146085_146347(f_28002_146085_146110(source), f_28002_146281_146346(f_28002_146281_146327(ErrorCode.ERR_UseDefViolation, "g"), "g"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 145699, 146359);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_146085_146110(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 146085, 146110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_146281_146327(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 146281, 146327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_146281_146346(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 146281, 146346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_146085_146347(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 146085, 146347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 145699, 146359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 145699, 146359);
            }
        }

        [Fact]
        public void UseDef_CondAccess()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 146371, 147005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 146443, 146709);

                var
                source = @"
class C
{
    C M1(out C arg)
    {
        arg = this;
        return arg;
    }

    static void Main()
    {
        C o;

        var d = new C();
        var v = d ?. M1(out o);

        System.Console.WriteLine(o);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 146723, 146994);

                f_28002_146723_146993(f_28002_146723_146762(source), f_28002_146900_146986(f_28002_146900_146965(f_28002_146900_146946(ErrorCode.ERR_UseDefViolation, "o"), "o"), 17, 34));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 146371, 147005);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_146723_146762(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 146723, 146762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_146900_146946(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 146900, 146946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_146900_146965(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 146900, 146965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_146900_146986(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 146900, 146986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_146723_146993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 146723, 146993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 146371, 147005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 146371, 147005);
            }
        }

        [Fact]
        public void UseDef_CondAccess01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 147017, 147667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 147091, 147371);

                var
                source = @"
class C
{
    C M1(out C arg)
    {
        arg = this;
        return arg;
    }

    static void Main()
    {
        C o;

        var d = new C();
        var v = d ?. M1(out o) ?? (o = null);

        System.Console.WriteLine(o);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 147385, 147656);

                f_28002_147385_147655(f_28002_147385_147424(source), f_28002_147562_147648(f_28002_147562_147627(f_28002_147562_147608(ErrorCode.ERR_UseDefViolation, "o"), "o"), 17, 34));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 147017, 147667);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_147385_147424(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 147385, 147424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_147562_147608(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 147562, 147608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_147562_147627(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 147562, 147627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_147562_147648(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 147562, 147648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_147385_147655(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 147385, 147655);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 147017, 147667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 147017, 147667);
            }
        }

        [Fact]
        public void UseDef_CondAccess02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 147679, 148128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 147753, 148043);

                var
                source = @"
class C
{
    C M1(out C arg)
    {
        arg = this;
        return arg;
    }

    C M2( C arg)
    {
        return arg;
    }

    static void Main()
    {
        C o;

        var d = new C();
        var v = d ?. M1(out o) ?. M2(o);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 148057, 148117);

                f_28002_148057_148116(f_28002_148057_148096(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 147679, 148128);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_148057_148096(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 148057, 148096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_148057_148116(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 148057, 148116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 147679, 148128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 147679, 148128);
            }
        }

        [Fact]
        public void UseDef_CondAccess03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 148140, 148605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 148214, 148514);

                var
                source = @"
class C
{
    C M1(out C arg)
    {
        arg = this;
        return arg;
    }

    C M2( C arg)
    {
        return arg;
    }

    static void Main()
    {
        C o;

        var d = new C();
        var v = d.M1(out o) ?. M1(out o) ?. M2(o);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 148528, 148594);

                f_28002_148528_148593(f_28002_148528_148567(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 148140, 148605);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_148528_148567(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 148528, 148567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_148528_148593(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 148528, 148593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 148140, 148605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 148140, 148605);
            }
        }

        [Fact, WorkItem(14651, "https://github.com/dotnet/roslyn/issues/14651")]
        public void IrrefutablePattern_1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 148617, 149180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 148758, 149095);

                var
                source =
                @"using System;
class C
{
    void TestFunc(int i)
    {
        int x;
        if (i is int j)
        {
            Console.WriteLine(""matched"");
        }
        else
        {
            x = x + 1; // reachable, and x is definitely assigned here
        }

        Console.WriteLine(j);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 149109, 149169);

                f_28002_149109_149168(f_28002_149109_149148(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 148617, 149180);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_149109_149148(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 149109, 149148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_149109_149168(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 149109, 149168);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 148617, 149180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 148617, 149180);
            }
        }

        [Fact]
        public void OutVarConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 149258, 149648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 149329, 149547);

                var
                source =
                @"class C
{
    static object F(bool b)
    {
        return ((bool)(b && G(out var o))) ? o : null;
    }
    static bool G(out object o)
    {
        o = null;
        return true;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 149561, 149598);

                var
                comp = f_28002_149572_149597(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 149612, 149637);

                f_28002_149612_149636(comp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 149258, 149648);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_149572_149597(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 149572, 149597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_149612_149636(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 149612, 149636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 149258, 149648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 149258, 149648);
            }
        }

        [Fact]
        public void IsPatternConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 149726, 150023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 149800, 149922);

                var
                source =
                @"class C
{
    static object F(object o)
    {
        return ((bool)(o is C c)) ? c: null;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 149936, 149973);

                var
                comp = f_28002_149947_149972(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 149987, 150012);

                f_28002_149987_150011(comp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 149726, 150023);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_149947_149972(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 149947, 149972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_149987_150011(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 149987, 150011);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 149726, 150023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 149726, 150023);
            }
        }

        [Fact]
        public void IsPatternBadValueConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 150101, 150987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 150335, 150462);

                var
                source =
                @"class C
{
    static T F<T>(System.ValueType o)
    {
        return o is T t ? t : default(T);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 150476, 150549);

                var
                comp = f_28002_150487_150548(source, parseOptions: TestOptions.Regular7)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 150563, 150976);

                f_28002_150563_150975(comp, f_28002_150838_150974(f_28002_150838_150954(f_28002_150838_150901(ErrorCode.ERR_PatternWrongGenericTypeInVersion, "T"), "System.ValueType", "T", "7.0", "7.1"), 5, 21));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 150101, 150987);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_150487_150548(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 150487, 150548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_150838_150901(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 150838, 150901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_150838_150954(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 150838, 150954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_150838_150974(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 150838, 150974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_150563_150975(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 150563, 150975);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 150101, 150987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 150101, 150987);
            }
        }

        [Fact, WorkItem(19831, "https://github.com/dotnet/roslyn/issues/19831")]
        public void AssignedInFinallyUsedInTry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28002, 150999, 152119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 151146, 151774);

                var
                source =
                @"  
    public class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        public static void Test()
        {
            object obj; 

            try
            {
                goto l3;

                l1:
                goto l2;

                l3:
                goto l1;


                l2:

                // Should be compile error
                // 'obj' is uninitialized
                obj.ToString();
            }
            finally
            {
                obj = 1;
            }
        }
    }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 151788, 152108);

                f_28002_151788_152107(f_28002_151788_151827(source), f_28002_151998_152088(f_28002_151998_152067(f_28002_151998_152046(ErrorCode.ERR_UseDefViolation, "obj"), "obj"), 28, 17));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28002, 150999, 152119);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_151788_151827(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 151788, 151827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_151998_152046(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 151998, 152046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_151998_152067(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 151998, 152067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28002_151998_152088(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 151998, 152088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28002_151788_152107(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28002, 151788, 152107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28002, 150999, 152119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 150999, 152119);
            }
        }

        public FlowTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(28002, 568, 152126);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(28002, 568, 152126);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 568, 152126);
        }


        static FlowTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(28002, 568, 152126);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 645, 3491);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(28002, 3525, 3540);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(28002, 568, 152126);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28002, 568, 152126);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(28002, 568, 152126);
    }
}
