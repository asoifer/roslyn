// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Semantics
{
    public class BindingTests : CompilingTestBase
    {
        [Fact, WorkItem(539872, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/539872")]
        public void NoWRN_UnreachableCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 650, 1051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 808, 982);

                var
                text = @"
public class Cls
{
    public static int Main()
    {
        goto Label2;
    Label1:
        return (1);
    Label2:
        goto Label1;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 996, 1040);

                f_28001_996_1039(f_28001_996_1019(text));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 650, 1051);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_996_1019(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 996, 1019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_996_1039(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 996, 1039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 650, 1051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 650, 1051);
            }
        }

        [Fact]
        public void GenericMethodName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 1063, 1491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 1135, 1420);

                var
                source =
                @"class A
{
    class B
    {
        static void M(System.Action a)
        {
            M(M1);
            M(M2<object>);
            M(M3<int>);
        }
        static void M1() { }
        static void M2<T>() { }
    }
    static void M3<T>() { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 1434, 1480);

                f_28001_1434_1479(f_28001_1434_1459(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 1063, 1491);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_1434_1459(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 1434, 1459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_1434_1479(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 1434, 1479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 1063, 1491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 1063, 1491);
            }
        }

        [Fact]
        public void GenericTypeName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 1503, 1943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 1573, 1872);

                var
                source =
                @"class A
{
    class B
    {
        static void M(System.Type t)
        {
            M(typeof(C<int>));
            M(typeof(S<string, string>));
            M(typeof(C<int, int>));
        }
        class C<T> { }
    }
    struct S<T, U> { }
}
class C<T, U> { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 1886, 1932);

                f_28001_1886_1931(f_28001_1886_1911(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 1503, 1943);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_1886_1911(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 1886, 1911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_1886_1931(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 1886, 1931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 1503, 1943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 1503, 1943);
            }
        }

        [Fact]
        public void GenericTypeParameterName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 1955, 2342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 2034, 2271);

                var
                source =
                @"class A<T>
{
    class B<U>
    {
        static void M<V>()
        {
            N(typeof(V));
            N(typeof(U));
            N(typeof(T));
        }
        static void N(System.Type t) { }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 2285, 2331);

                f_28001_2285_2330(f_28001_2285_2310(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 1955, 2342);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_2285_2310(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 2285, 2310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_2285_2330(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 2285, 2330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 1955, 2342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 1955, 2342);
            }
        }

        [Fact]
        public void WrongMethodArity()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 2354, 4770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 2425, 2798);

                var
                source =
                @"class C
{
    static void M1<T>() { }
    static void M2() { }
    void M3<T>() { }
    void M4() { }
    void M()
    {
        M1<object, object>();
        C.M1<object, object>();
        M2<int>();
        C.M2<int>();
        M3<object, object>();
        this.M3<object, object>();
        M4<int>();
        this.M4<int>();
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 2812, 4759);

                f_28001_2812_4758(f_28001_2812_2837(source), f_28001_2978_3095(f_28001_2978_3076(f_28001_2978_3034(ErrorCode.ERR_BadArity, "M1<object, object>"), "C.M1<T>()", "method", "1"), 9, 9), f_28001_3220_3339(f_28001_3220_3318(f_28001_3220_3276(ErrorCode.ERR_BadArity, "M1<object, object>"), "C.M1<T>()", "method", "1"), 10, 11), f_28001_3467_3571(f_28001_3467_3551(f_28001_3467_3517(ErrorCode.ERR_HasNoTypeVars, "M2<int>"), "C.M2()", "method"), 11, 9), f_28001_3700_3805(f_28001_3700_3784(f_28001_3700_3750(ErrorCode.ERR_HasNoTypeVars, "M2<int>"), "C.M2()", "method"), 12, 11), f_28001_3929_4047(f_28001_3929_4027(f_28001_3929_3985(ErrorCode.ERR_BadArity, "M3<object, object>"), "C.M3<T>()", "method", "1"), 13, 9), f_28001_4172_4291(f_28001_4172_4270(f_28001_4172_4228(ErrorCode.ERR_BadArity, "M3<object, object>"), "C.M3<T>()", "method", "1"), 14, 14), f_28001_4419_4523(f_28001_4419_4503(f_28001_4419_4469(ErrorCode.ERR_HasNoTypeVars, "M4<int>"), "C.M4()", "method"), 15, 9), f_28001_4652_4757(f_28001_4652_4736(f_28001_4652_4702(ErrorCode.ERR_HasNoTypeVars, "M4<int>"), "C.M4()", "method"), 16, 14));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 2354, 4770);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_2812_2837(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 2812, 2837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_2978_3034(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 2978, 3034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_2978_3076(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 2978, 3076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_2978_3095(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 2978, 3095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3220_3276(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3220, 3276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3220_3318(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3220, 3318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3220_3339(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3220, 3339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3467_3517(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3467, 3517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3467_3551(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3467, 3551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3467_3571(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3467, 3571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3700_3750(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3700, 3750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3700_3784(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3700, 3784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3700_3805(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3700, 3805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3929_3985(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3929, 3985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3929_4027(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3929, 4027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_3929_4047(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 3929, 4047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_4172_4228(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 4172, 4228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_4172_4270(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 4172, 4270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_4172_4291(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 4172, 4291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_4419_4469(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 4419, 4469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_4419_4503(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 4419, 4503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_4419_4523(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 4419, 4523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_4652_4702(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 4652, 4702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_4652_4736(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 4652, 4736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_4652_4757(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 4652, 4757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_2812_4758(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 2812, 4758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 2354, 4770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 2354, 4770);
            }
        }

        [Fact]
        public void AmbiguousInaccessibleMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 4782, 6104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 4864, 5206);

                var
                source =
                @"class A
{
    protected void M1() { }
    protected void M1(object o) { }
    protected void M2(string s) { }
    protected void M2(object o) { }
}
class B
{
    static void M(A a)
    {
        a.M1();
        a.M2();
        M(a.M1);
        M(a.M2);
    }
    static void M(System.Action<object> a) { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 5220, 6093);

                f_28001_5220_6092(f_28001_5220_5245(source), f_28001_5378_5464(f_28001_5378_5443(f_28001_5378_5419(ErrorCode.ERR_BadAccess, "M1"), "A.M1()"), 12, 11), f_28001_5585_5677(f_28001_5585_5656(f_28001_5585_5626(ErrorCode.ERR_BadAccess, "M2"), "A.M2(string)"), 13, 11), f_28001_5792_5878(f_28001_5792_5857(f_28001_5792_5833(ErrorCode.ERR_BadAccess, "M1"), "A.M1()"), 14, 13), f_28001_5999_6091(f_28001_5999_6070(f_28001_5999_6040(ErrorCode.ERR_BadAccess, "M2"), "A.M2(string)"), 15, 13));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 4782, 6104);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_5220_5245(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5220, 5245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5378_5419(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5378, 5419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5378_5443(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5378, 5443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5378_5464(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5378, 5464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5585_5626(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5585, 5626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5585_5656(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5585, 5656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5585_5677(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5585, 5677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5792_5833(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5792, 5833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5792_5857(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5792, 5857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5792_5878(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5792, 5878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5999_6040(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5999, 6040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5999_6070(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5999, 6070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_5999_6091(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5999, 6091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_5220_6092(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 5220, 6092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 4782, 6104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 4782, 6104);
            }
        }

        [Fact]
        public void InaccessibleMethodInvalidDelegateUse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 6284, 7262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 6375, 6600);

                var
                source =
                @"class A
{
    protected object F() { return null; }
}
class B
{
    static void M(A a)
    {
        if (a.F != null)
        {
            M(a.F);
            a.F.ToString();
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 6614, 7251);

                f_28001_6614_7250(f_28001_6614_6639(source), f_28001_6770_6853(f_28001_6770_6833(f_28001_6770_6810(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 9, 15), f_28001_6967_7051(f_28001_6967_7030(f_28001_6967_7007(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 11, 17), f_28001_7165_7249(f_28001_7165_7228(f_28001_7165_7205(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 12, 15));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 6284, 7262);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_6614_6639(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 6614, 6639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_6770_6810(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 6770, 6810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_6770_6833(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 6770, 6833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_6770_6853(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 6770, 6853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_6967_7007(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 6967, 7007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_6967_7030(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 6967, 7030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_6967_7051(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 6967, 7051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_7165_7205(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 7165, 7205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_7165_7228(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 7165, 7228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_7165_7249(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 7165, 7249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_6614_7250(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 6614, 7250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 6284, 7262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 6284, 7262);
            }
        }

        [Fact]
        public void InvalidUseOfMethodGroup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 7435, 10868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 7513, 8054);

                var
                source =
                @"class A
{
    internal object E() { return null; }
    private object F() { return null; }
}
class B
{
    static void M(A a)
    {
        object o;
        a.E += a.E;
        if (a.E != null)
        {
            M(a.E);
            a.E.ToString();
            o = !a.E;
            o = a.E ?? a.F;
        }
        a.F += a.F;
        if (a.F != null)
        {
            M(a.F);
            a.F.ToString();
            o = !a.F;
            o = (o != null) ? a.E : a.F;
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 8068, 10857);

                f_28001_8068_10856(f_28001_8068_8093(source), f_28001_8224_8334(f_28001_8224_8314(f_28001_8224_8279(ErrorCode.ERR_AssgReadonlyLocalCause, "a.E"), "E", "method group"), 11, 9), f_28001_8476_8596(f_28001_8476_8575(f_28001_8476_8529(ErrorCode.ERR_BadBinaryOps, "a.E != null"), "!=", "method group", "<null>"), 12, 13), f_28001_8717_8821(f_28001_8717_8800(f_28001_8717_8760(ErrorCode.ERR_BadArgType, "a.E"), "1", "method group", "A"), 14, 15), f_28001_8947_9044(f_28001_8947_9023(f_28001_8947_8990(ErrorCode.ERR_BadSKunknown, "E"), "A.E()", "method"), 15, 15), f_28001_9171_9271(f_28001_9171_9250(f_28001_9171_9215(ErrorCode.ERR_BadUnaryOp, "!a.E"), "!", "method group"), 16, 17), f_28001_9385_9469(f_28001_9385_9448(f_28001_9385_9425(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 17, 26), f_28001_9583_9667(f_28001_9583_9646(f_28001_9583_9623(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 19, 11), f_28001_9781_9865(f_28001_9781_9844(f_28001_9781_9821(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 19, 18), f_28001_9979_10063(f_28001_9979_10042(f_28001_9979_10019(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 20, 15), f_28001_10177_10261(f_28001_10177_10240(f_28001_10177_10217(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 22, 17), f_28001_10375_10459(f_28001_10375_10438(f_28001_10375_10415(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 23, 15), f_28001_10573_10657(f_28001_10573_10636(f_28001_10573_10613(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 24, 20), f_28001_10771_10855(f_28001_10771_10834(f_28001_10771_10811(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 25, 39));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 7435, 10868);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_8068_8093(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8068, 8093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8224_8279(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8224, 8279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8224_8314(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8224, 8314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8224_8334(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8224, 8334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8476_8529(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8476, 8529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8476_8575(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8476, 8575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8476_8596(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8476, 8596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8717_8760(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8717, 8760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8717_8800(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8717, 8800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8717_8821(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8717, 8821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8947_8990(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8947, 8990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8947_9023(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8947, 9023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_8947_9044(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8947, 9044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9171_9215(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9171, 9215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9171_9250(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9171, 9250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9171_9271(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9171, 9271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9385_9425(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9385, 9425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9385_9448(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9385, 9448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9385_9469(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9385, 9469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9583_9623(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9583, 9623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9583_9646(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9583, 9646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9583_9667(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9583, 9667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9781_9821(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9781, 9821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9781_9844(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9781, 9844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9781_9865(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9781, 9865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9979_10019(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9979, 10019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9979_10042(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9979, 10042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_9979_10063(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 9979, 10063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10177_10217(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10177, 10217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10177_10240(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10177, 10240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10177_10261(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10177, 10261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10375_10415(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10375, 10415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10375_10438(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10375, 10438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10375_10459(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10375, 10459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10573_10613(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10573, 10613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10573_10636(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10573, 10636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10573_10657(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10573, 10657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10771_10811(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10771, 10811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10771_10834(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10771, 10834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_10771_10855(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 10771, 10855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_8068_10856(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 8068, 10856);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 7435, 10868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 7435, 10868);
            }
        }

        [WorkItem(528425, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/528425")]
        [Fact(Skip = "528425")]
        public void InaccessibleAndAccessible()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 10880, 12688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 11069, 11584);

                var
                source =
                @"using System;
class A
{
    void F() { }
    internal void F(object o) { }
    static void G() { }
    internal static void G(object o) { }
    void H(object o) { }
}
class B : A
{
    static void M(A a)
    {
        a.F(null);
        a.F();
        A.G();
        M1(a.F);
        M2(a.F);
        Action<object> a1 = a.F;
        Action a2 = a.F;
    }
    void M()
    {
        G();
    }
    static void M1(Action<object> a) { }
    static void M2(Action a) { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 11598, 12677);

                f_28001_11598_12676(f_28001_11598_11623(source), f_28001_11755_11839(f_28001_11755_11818(f_28001_11755_11795(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 15, 11), f_28001_11953_12037(f_28001_11953_12016(f_28001_11953_11993(ErrorCode.ERR_BadAccess, "G"), "A.G()"), 16, 11), f_28001_12165_12281(f_28001_12165_12260(f_28001_12165_12208(ErrorCode.ERR_BadArgType, "a.F"), "1", "method group", "System.Action"), 18, 12), f_28001_12395_12479(f_28001_12395_12458(f_28001_12395_12435(ErrorCode.ERR_BadAccess, "F"), "A.F()"), 20, 23), f_28001_12592_12675(f_28001_12592_12655(f_28001_12592_12632(ErrorCode.ERR_BadAccess, "G"), "A.G()"), 24, 9));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 10880, 12688);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_11598_11623(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 11598, 11623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_11755_11795(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 11755, 11795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_11755_11818(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 11755, 11818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_11755_11839(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 11755, 11839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_11953_11993(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 11953, 11993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_11953_12016(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 11953, 12016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_11953_12037(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 11953, 12037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_12165_12208(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 12165, 12208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_12165_12260(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 12165, 12260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_12165_12281(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 12165, 12281);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_12395_12435(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 12395, 12435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_12395_12458(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 12395, 12458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_12395_12479(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 12395, 12479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_12592_12632(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 12592, 12632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_12592_12655(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 12592, 12655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_12592_12675(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 12592, 12675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_11598_12676(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 11598, 12676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 10880, 12688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 10880, 12688);
            }
        }

        [Fact]
        public void InaccessibleAndAccessibleAndAmbiguous()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 12700, 13967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 12792, 13384);

                var
                source =
                @"class A
{
    void F(string x) { }
    void F(string x, string y) { }
    internal void F(object x, string y) { }
    internal void F(string x, object y) { }
    void G(object x, string y) { }
    internal void G(string x, object y) { }
    static void M(A a, string s)
    {
        a.F(s, s); // no error
    }
}
class B
{
    static void M(A a, string s, object o)
    {
        a.F(s, s); // accessible ambiguous
        a.G(s, s); // accessible and inaccessible ambiguous, no error
        a.G(o, o); // accessible and inaccessible invalid 
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 13398, 13956);

                f_28001_13398_13955(f_28001_13398_13423(source), f_28001_13617_13738(f_28001_13617_13717(f_28001_13617_13657(ErrorCode.ERR_AmbigCall, "F"), "A.F(object, string)", "A.F(string, object)"), 18, 11), f_28001_13853_13954(f_28001_13853_13933(f_28001_13853_13894(ErrorCode.ERR_BadArgType, "o"), "1", "object", "string"), 20, 13));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 12700, 13967);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_13398_13423(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 13398, 13423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_13617_13657(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 13617, 13657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_13617_13717(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 13617, 13717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_13617_13738(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 13617, 13738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_13853_13894(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 13853, 13894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_13853_13933(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 13853, 13933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_13853_13954(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 13853, 13954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_13398_13955(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 13398, 13955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 12700, 13967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 12700, 13967);
            }
        }

        [Fact]
        public void InaccessibleAndAccessibleValid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 13979, 14371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 14064, 14300);

                var
                source =
                @"class A
{
    void F(int i) { }
    internal void F(long l) { }
    static void M(A a)
    {
        a.F(1); // no error
    }
}
class B
{
    static void M(A a)
    {
        a.F(1); // no error
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 14314, 14360);

                f_28001_14314_14359(f_28001_14314_14339(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 13979, 14371);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_14314_14339(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 14314, 14339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_14314_14359(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 14314, 14359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 13979, 14371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 13979, 14371);
            }
        }

        [Fact]
        public void ParenthesizedDelegate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 14383, 14823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 14459, 14616);

                var
                source =
                @"class C
{
    System.Action<object> F = null;
    void M()
    {
        ((this.F))(null);
        (new C().F)(null, null);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 14630, 14812);

                f_28001_14630_14811(f_28001_14630_14655(source), f_28001_14692_14810(f_28001_14692_14791(f_28001_14692_14747(ErrorCode.ERR_BadDelArgCount, "(new C().F)"), "System.Action<object>", "2"), 7, 9));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 14383, 14823);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_14630_14655(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 14630, 14655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_14692_14747(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 14692, 14747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_14692_14791(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 14692, 14791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_14692_14810(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 14692, 14810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_14630_14811(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 14630, 14811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 14383, 14823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 14383, 14823);
            }
        }

        [Fact]
        public void NonMethodsWithArgs()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 15046, 21050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 15119, 15509);

                var
                source =
                @"namespace N
{
    class C<T>
    {
        object F;
        object P { get; set; }
        void M()
        {
            N(a);
            C<string>(b);
            N.C<int>(c);
            N.D(d);
            T(e);
            (typeof(C<int>))(f);
            P(g) = F(h);
            this.F(i) = (this).P(j);
            null.M(k);
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 15523, 21039);

                f_28001_15523_21038(f_28001_15523_15548(source), f_28001_15716_15782(f_28001_15716_15763(ErrorCode.ERR_NameNotInContext, "a"), "a"), f_28001_15928_16013(f_28001_15928_15969(ErrorCode.ERR_BadSKknown, "N"), "N", "namespace", "variable"), f_28001_16172_16238(f_28001_16172_16219(ErrorCode.ERR_NameNotInContext, "b"), "b"), f_28001_16406_16493(f_28001_16406_16469(ErrorCode.ERR_NonInvocableMemberCalled, "C<string>"), "N.C<T>"), f_28001_16651_16717(f_28001_16651_16698(ErrorCode.ERR_NameNotInContext, "c"), "c"), f_28001_16884_16968(f_28001_16884_16944(ErrorCode.ERR_NonInvocableMemberCalled, "C<int>"), "N.C<T>"), f_28001_17121_17187(f_28001_17121_17168(ErrorCode.ERR_NameNotInContext, "d"), "d"), f_28001_17397_17480(f_28001_17397_17456(ErrorCode.ERR_DottedTypeNameNotFoundInNS, "N.D"), "D", "N"), f_28001_17631_17697(f_28001_17631_17678(ErrorCode.ERR_NameNotInContext, "e"), "e"), f_28001_17848_17914(f_28001_17848_17895(ErrorCode.ERR_NameNotInContext, "T"), "T"), f_28001_18080_18146(f_28001_18080_18127(ErrorCode.ERR_NameNotInContext, "f"), "f"), f_28001_18282_18346(ErrorCode.ERR_MethodNameExpected, "(typeof(C<int>))"), f_28001_18504_18570(f_28001_18504_18551(ErrorCode.ERR_NameNotInContext, "g"), "g"), f_28001_18739_18820(f_28001_18739_18794(ErrorCode.ERR_NonInvocableMemberCalled, "P"), "N.C<T>.P"), f_28001_18978_19044(f_28001_18978_19025(ErrorCode.ERR_NameNotInContext, "h"), "h"), f_28001_19213_19294(f_28001_19213_19268(ErrorCode.ERR_NonInvocableMemberCalled, "F"), "N.C<T>.F"), f_28001_19464_19530(f_28001_19464_19511(ErrorCode.ERR_NameNotInContext, "i"), "i"), f_28001_19711_19792(f_28001_19711_19766(ErrorCode.ERR_NonInvocableMemberCalled, "F"), "N.C<T>.F"), f_28001_19962_20028(f_28001_19962_20009(ErrorCode.ERR_NameNotInContext, "j"), "j"), f_28001_20209_20290(f_28001_20209_20264(ErrorCode.ERR_NonInvocableMemberCalled, "P"), "N.C<T>.P"), f_28001_20446_20512(f_28001_20446_20493(ErrorCode.ERR_NameNotInContext, "k"), "k"), f_28001_20676_20751(f_28001_20676_20722(ErrorCode.ERR_BadUnaryOp, "null.M"), ".", "<null>"), f_28001_20935_21023(f_28001_20935_20989(ErrorCode.WRN_UnassignedInternalField, "F"), "N.C<T>.F", "null"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 15046, 21050);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_15523_15548(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 15523, 15548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_15716_15763(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 15716, 15763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_15716_15782(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 15716, 15782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_15928_15969(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 15928, 15969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_15928_16013(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 15928, 16013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_16172_16219(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 16172, 16219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_16172_16238(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 16172, 16238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_16406_16469(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 16406, 16469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_16406_16493(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 16406, 16493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_16651_16698(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 16651, 16698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_16651_16717(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 16651, 16717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_16884_16944(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 16884, 16944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_16884_16968(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 16884, 16968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_17121_17168(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 17121, 17168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_17121_17187(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 17121, 17187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_17397_17456(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 17397, 17456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_17397_17480(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 17397, 17480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_17631_17678(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 17631, 17678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_17631_17697(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 17631, 17697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_17848_17895(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 17848, 17895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_17848_17914(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 17848, 17914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_18080_18127(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 18080, 18127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_18080_18146(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 18080, 18146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_18282_18346(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 18282, 18346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_18504_18551(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 18504, 18551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_18504_18570(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 18504, 18570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_18739_18794(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 18739, 18794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_18739_18820(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 18739, 18820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_18978_19025(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 18978, 19025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_18978_19044(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 18978, 19044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_19213_19268(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 19213, 19268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_19213_19294(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 19213, 19294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_19464_19511(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 19464, 19511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_19464_19530(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 19464, 19530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_19711_19766(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 19711, 19766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_19711_19792(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 19711, 19792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_19962_20009(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 19962, 20009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_19962_20028(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 19962, 20028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_20209_20264(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 20209, 20264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_20209_20290(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 20209, 20290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_20446_20493(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 20446, 20493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_20446_20512(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 20446, 20512);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_20676_20722(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 20676, 20722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_20676_20751(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 20676, 20751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_20935_20989(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 20935, 20989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_20935_21023(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 20935, 21023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_15523_21038(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 15523, 21038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 15046, 21050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 15046, 21050);
            }
        }

        [Fact]
        public void SimpleDelegates()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 21062, 21405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 21132, 21334);

                var
                source =
                @"static class S
{
    public static void F(System.Action a) { }
}
class C
{
    void M()
    {
        S.F(this.M);
        System.Action a = this.M;
        S.F(a);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 21348, 21394);

                f_28001_21348_21393(f_28001_21348_21373(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 21062, 21405);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_21348_21373(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 21348, 21373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_21348_21393(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 21348, 21393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 21062, 21405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 21062, 21405);
            }
        }

        [Fact]
        public void DelegatesFromOverloads()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 21417, 21907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 21494, 21836);

                var
                source =
                @"using System;
class C
{
    static void A(Action<object> a) { }
    static void M(C c)
    {
        A(C.F);
        A(c.G);
        Action<object> a;
        a = C.F;
        a = c.G;
    }
    static void F() { }
    static void F(object o) { }
    void G(object o) { }
    void G(object x, object y) { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 21850, 21896);

                f_28001_21850_21895(f_28001_21850_21875(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 21417, 21907);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_21850_21875(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 21850, 21875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_21850_21895(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 21850, 21895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 21417, 21907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 21417, 21907);
            }
        }

        [Fact]
        public void NonViableDelegates()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 21919, 23611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 21992, 22176);

                var
                source =
                @"using System;
class A
{
    static Action F = null;
    Action G = null;
}
class B
{
    static void M(A a)
    {
        A.F(x);
        a.G(y);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 22190, 23600);

                f_28001_22190_23599(f_28001_22190_22215(source), f_28001_22412_22478(f_28001_22412_22459(ErrorCode.ERR_NameNotInContext, "x"), "x"), f_28001_22626_22687(f_28001_22626_22666(ErrorCode.ERR_BadAccess, "F"), "A.F"), f_28001_22836_22902(f_28001_22836_22883(ErrorCode.ERR_NameNotInContext, "y"), "y"), f_28001_23050_23111(f_28001_23050_23090(ErrorCode.ERR_BadAccess, "G"), "A.G"), f_28001_23278_23351(f_28001_23278_23330(ErrorCode.WRN_UnreferencedFieldAssg, "F"), "A.F"), f_28001_23511_23584(f_28001_23511_23563(ErrorCode.WRN_UnreferencedFieldAssg, "G"), "A.G"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 21919, 23611);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_22190_22215(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 22190, 22215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_22412_22459(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 22412, 22459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_22412_22478(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 22412, 22478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_22626_22666(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 22626, 22666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_22626_22687(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 22626, 22687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_22836_22883(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 22836, 22883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_22836_22902(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 22836, 22902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_23050_23090(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 23050, 23090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_23050_23111(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 23050, 23111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_23278_23330(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 23278, 23330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_23278_23351(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 23278, 23351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_23511_23563(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 23511, 23563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_23511_23584(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 23511, 23584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_22190_23599(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 22190, 23599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 21919, 23611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 21919, 23611);
            }
        }

        [Fact]
        public void ChooseOneMethodIfEquallyInvalid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 23757, 24692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 23843, 24137);

                var
                source =
                @"internal static class S
{
    public static void M(double x, A y) { }
    public static void M(double x, B y) { }
}
class A { }
class B { }
class C
{
    static void M()
    {
        S.M(1.0, null); // ambiguous
        S.M(1.0, 2.0); // equally invalid
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 24151, 24681);

                f_28001_24151_24680(f_28001_24151_24176(source), f_28001_24360_24471(f_28001_24360_24450(f_28001_24360_24400(ErrorCode.ERR_AmbigCall, "M"), "S.M(double, A)", "S.M(double, B)"), 12, 11), f_28001_24581_24679(f_28001_24581_24658(f_28001_24581_24624(ErrorCode.ERR_BadArgType, "2.0"), "2", "double", "A"), 13, 18));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 23757, 24692);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_24151_24176(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 24151, 24176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_24360_24400(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 24360, 24400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_24360_24450(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 24360, 24450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_24360_24471(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 24360, 24471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_24581_24624(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 24581, 24624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_24581_24658(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 24581, 24658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_24581_24679(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 24581, 24679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_24151_24680(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 24151, 24680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 23757, 24692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 23757, 24692);
            }
        }

        [Fact]
        public void ChooseExpandedFormIfBadArgCountAndBadArgument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 24704, 25976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 24804, 24995);

                var
                source =
                @"class C
{
    static void M(object o)
    {
        F();
        F(o);
        F(1, o);
        F(1, 2, o);
    }
    static void F(int i, params int[] args) { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 25009, 25965);

                f_28001_25009_25964(f_28001_25009_25034(source), f_28001_25221_25339(f_28001_25221_25320(f_28001_25221_25275(ErrorCode.ERR_NoCorrespondingArgument, "F"), "i", "C.F(int, params int[])"), 5, 9), f_28001_25450_25547(f_28001_25450_25527(f_28001_25450_25491(ErrorCode.ERR_BadArgType, "o"), "1", "object", "int"), 6, 11), f_28001_25658_25755(f_28001_25658_25735(f_28001_25658_25699(ErrorCode.ERR_BadArgType, "o"), "2", "object", "int"), 7, 14), f_28001_25866_25963(f_28001_25866_25943(f_28001_25866_25907(ErrorCode.ERR_BadArgType, "o"), "3", "object", "int"), 8, 17));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 24704, 25976);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_25009_25034(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25009, 25034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25221_25275(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25221, 25275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25221_25320(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25221, 25320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25221_25339(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25221, 25339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25450_25491(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25450, 25491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25450_25527(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25450, 25527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25450_25547(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25450, 25547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25658_25699(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25658, 25699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25658_25735(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25658, 25735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25658_25755(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25658, 25755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25866_25907(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25866, 25907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25866_25943(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25866, 25943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_25866_25963(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25866, 25963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_25009_25964(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 25009, 25964);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 24704, 25976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 24704, 25976);
            }
        }

        [Fact]
        public void AmbiguousAndBadArgument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 25988, 26814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 26066, 26252);

                var
                source =
                @"class C
{
    static void F(int x, double y) { }
    static void F(double x, int y) { }
    static void M()
    {
        F(1, 2);
        F(1.0, 2.0);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 26266, 26803);

                f_28001_26266_26802(f_28001_26266_26291(source), f_28001_26478_26591(f_28001_26478_26572(f_28001_26478_26518(ErrorCode.ERR_AmbigCall, "F"), "C.F(int, double)", "C.F(double, int)"), 7, 9), f_28001_26702_26801(f_28001_26702_26781(f_28001_26702_26745(ErrorCode.ERR_BadArgType, "1.0"), "1", "double", "int"), 8, 11));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 25988, 26814);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_26266_26291(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 26266, 26291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_26478_26518(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 26478, 26518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_26478_26572(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 26478, 26572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_26478_26591(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 26478, 26591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_26702_26745(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 26702, 26745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_26702_26781(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 26702, 26781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_26702_26801(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 26702, 26801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_26266_26802(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 26266, 26802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 25988, 26814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 25988, 26814);
            }
        }

        [WorkItem(541050, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541050")]
        [Fact]
        public void IncompleteDelegateDecl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 26826, 28031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 26995, 27040);

                var
                source =
                @"namespace nms {

delegate"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 27054, 28020);

                f_28001_27054_28019(f_28001_27054_27079(source), f_28001_27200_27242(ErrorCode.ERR_TypeExpected, ""), f_28001_27351_27399(ErrorCode.ERR_IdentifierExpected, ""), f_28001_27515_27579(f_28001_27515_27556(ErrorCode.ERR_SyntaxError, ""), "(", ""), f_28001_27679_27727(ErrorCode.ERR_CloseParenExpected, ""), f_28001_27827_27874(ErrorCode.ERR_SemicolonExpected, ""), f_28001_27974_28018(ErrorCode.ERR_RbraceExpected, ""));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 26826, 28031);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_27054_27079(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 27054, 27079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_27200_27242(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 27200, 27242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_27351_27399(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 27351, 27399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_27515_27556(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 27515, 27556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_27515_27579(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 27515, 27579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_27679_27727(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 27679, 27727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_27827_27874(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 27827, 27874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_27974_28018(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 27974, 28018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_27054_28019(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 27054, 28019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 26826, 28031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 26826, 28031);
            }
        }

        [WorkItem(541213, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541213")]
        [Fact]
        public void IncompleteElsePartInIfStmt()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 28043, 29289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 28216, 28362);

                var
                source =
                @"public class Test
{
    public static int Main(string [] args)
    {
        if (true)
        {
        }
        else
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 28376, 29278);

                f_28001_28376_29277(f_28001_28376_28401(source), f_28001_28533_28581(ErrorCode.ERR_ExpressionExpected, ""), f_28001_28673_28720(ErrorCode.ERR_SemicolonExpected, ""), f_28001_28812_28856(ErrorCode.ERR_RbraceExpected, ""), f_28001_28948_28992(ErrorCode.ERR_RbraceExpected, ""), f_28001_29173_29258(f_28001_29173_29221(ErrorCode.ERR_ReturnExpected, "Main"), "Test.Main(string[])"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 28043, 29289);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_28376_28401(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 28376, 28401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_28533_28581(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 28533, 28581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_28673_28720(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 28673, 28720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_28812_28856(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 28812, 28856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_28948_28992(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 28948, 28992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_29173_29221(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 29173, 29221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_29173_29258(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 29173, 29258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_28376_29277(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 28376, 29277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 28043, 29289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 28043, 29289);
            }
        }

        [WorkItem(541466, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541466")]
        [Fact]
        public void UseSiteErrorViaAliasTest01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 29301, 30639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 29474, 29637);

                var
                baseAssembly = f_28001_29493_29636(f_28001_29493_29616(@"
namespace BaseAssembly {
    public class BaseClass {
    }
}
", assemblyName: "BaseAssembly1"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 29653, 29978);

                var
                derivedAssembly = f_28001_29675_29977(f_28001_29675_29957(@"
namespace DerivedAssembly {
    public class DerivedClass: BaseAssembly.BaseClass {
        public static int IntField = 123;
    }
}
", assemblyName: "DerivedAssembly1", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_29919_29954(baseAssembly), 28001, 29887, 29956) }))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 29994, 30350);

                var
                testAssembly = f_28001_30013_30349(f_28001_30013_30315(@"
using ClassAlias = DerivedAssembly.DerivedClass; 
public class Test
{
    static void Main()
    {
        int a = ClassAlias.IntField;
        int b = ClassAlias.IntField;
    }
}
", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_30274_30312(derivedAssembly), 28001, 30242, 30314) }))
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 29301, 30639);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_29493_29616(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 29493, 29616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_29493_29636(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 29493, 29636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_29919_29954(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 29919, 29954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_29675_29957(string
                source, string
                assemblyName, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 29675, 29957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_29675_29977(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 29675, 29977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_30274_30312(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 30274, 30312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_30013_30315(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 30013, 30315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_30013_30349(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 30013, 30349);
                    return return_v;
                }


                // NOTE: Dev10 errors:
                // <fine-name>(7,9): error CS0012: The type 'BaseAssembly.BaseClass' is defined in an assembly that is not referenced. You must add a reference to assembly 'BaseAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 29301, 30639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 29301, 30639);
            }
        }

        [WorkItem(541466, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541466")]
        [Fact]
        public void UseSiteErrorViaAliasTest02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 30651, 31997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 30824, 30987);

                var
                baseAssembly = f_28001_30843_30986(f_28001_30843_30966(@"
namespace BaseAssembly {
    public class BaseClass {
    }
}
", assemblyName: "BaseAssembly2"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 31003, 31328);

                var
                derivedAssembly = f_28001_31025_31327(f_28001_31025_31307(@"
namespace DerivedAssembly {
    public class DerivedClass: BaseAssembly.BaseClass {
        public static int IntField = 123;
    }
}
", assemblyName: "DerivedAssembly2", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_31269_31304(baseAssembly), 28001, 31237, 31306) }))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 31344, 31708);

                var
                testAssembly = f_28001_31363_31707(f_28001_31363_31673(@"
using ClassAlias = DerivedAssembly.DerivedClass; 
public class Test
{
    static void Main()
    {
        ClassAlias a = new ClassAlias();
        ClassAlias b = new ClassAlias();
    }
}
", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_31632_31670(derivedAssembly), 28001, 31600, 31672) }))
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 30651, 31997);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_30843_30966(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 30843, 30966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_30843_30986(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 30843, 30986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_31269_31304(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 31269, 31304);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_31025_31307(string
                source, string
                assemblyName, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 31025, 31307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_31025_31327(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 31025, 31327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_31632_31670(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 31632, 31670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_31363_31673(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 31363, 31673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_31363_31707(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 31363, 31707);
                    return return_v;
                }


                // NOTE: Dev10 errors:
                // <fine-name>(6,9): error CS0012: The type 'BaseAssembly.BaseClass' is defined in an assembly that is not referenced. You must add a reference to assembly 'BaseAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 30651, 31997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 30651, 31997);
            }
        }

        [WorkItem(541466, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541466")]
        [Fact]
        public void UseSiteErrorViaAliasTest03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 32009, 33851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 32182, 32345);

                var
                baseAssembly = f_28001_32201_32344(f_28001_32201_32324(@"
namespace BaseAssembly {
    public class BaseClass {
    }
}
", assemblyName: "BaseAssembly3"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 32361, 32686);

                var
                derivedAssembly = f_28001_32383_32685(f_28001_32383_32665(@"
namespace DerivedAssembly {
    public class DerivedClass: BaseAssembly.BaseClass {
        public static int IntField = 123;
    }
}
", assemblyName: "DerivedAssembly3", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_32627_32662(baseAssembly), 28001, 32595, 32664) }))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 32702, 33561);

                var
                testAssembly = f_28001_32721_33560(f_28001_32721_33027(@"
using ClassAlias = DerivedAssembly.DerivedClass; 
public class Test
{
    ClassAlias a = null;
    ClassAlias b = null;
    ClassAlias m() { return null; }
    void m2(ClassAlias p) { }
}", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_32986_33024(derivedAssembly), 28001, 32954, 33026) }), f_28001_33226_33302(f_28001_33226_33278(ErrorCode.WRN_UnreferencedFieldAssg, "a"), "Test.a"), f_28001_33469_33545(f_28001_33469_33521(ErrorCode.WRN_UnreferencedFieldAssg, "b"), "Test.b"))
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 32009, 33851);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_32201_32324(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 32201, 32324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_32201_32344(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 32201, 32344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_32627_32662(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 32627, 32662);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_32383_32665(string
                source, string
                assemblyName, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 32383, 32665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_32383_32685(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 32383, 32685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_32986_33024(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 32986, 33024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_32721_33027(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 32721, 33027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_33226_33278(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 33226, 33278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_33226_33302(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 33226, 33302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_33469_33521(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 33469, 33521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_33469_33545(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 33469, 33545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_32721_33560(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 32721, 33560);
                    return return_v;
                }


                // NOTE: Dev10 errors:
                // <fine-name>(4,16): error CS0012: The type 'BaseAssembly.BaseClass' is defined in an assembly that is not referenced. You must add a reference to assembly 'BaseAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 32009, 33851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 32009, 33851);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_Typical()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 33863, 34607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 34056, 34183);

                string
                scenarioCode = @"
public class ITT
    : IInterfaceBase
{ }
public interface IInterfaceBase
{
    void bar();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 34197, 34248);

                var
                testAssembly = f_28001_34216_34247(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 34262, 34596);

                f_28001_34262_34595(testAssembly, f_28001_34458_34594(f_28001_34458_34575(f_28001_34458_34530(ErrorCode.ERR_UnimplementedInterfaceMember, "IInterfaceBase"), "ITT", "IInterfaceBase.bar()"), 3, 7));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 33863, 34607);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_34216_34247(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 34216, 34247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_34458_34530(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 34458, 34530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_34458_34575(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 34458, 34575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_34458_34594(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 34458, 34594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_34262_34595(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 34262, 34595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 33863, 34607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 33863, 34607);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_FullyQualified()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 34619, 35481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 34863, 35035);

                string
                scenarioCode = @"
public class ITT
    : test.IInterfaceBase
{ }

namespace test
{
    public interface IInterfaceBase
    {
        void bar();
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 35051, 35102);

                var
                testAssembly = f_28001_35070_35101(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 35116, 35470);

                f_28001_35116_35469(testAssembly, f_28001_35322_35468(f_28001_35322_35449(f_28001_35322_35399(ErrorCode.ERR_UnimplementedInterfaceMember, "test.IInterfaceBase"), "ITT", "test.IInterfaceBase.bar()"), 3, 7));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 34619, 35481);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_35070_35101(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 35070, 35101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_35322_35399(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 35322, 35399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_35322_35449(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 35322, 35449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_35322_35468(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 35322, 35468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_35116_35469(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 35116, 35469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 34619, 35481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 34619, 35481);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_WithAlias()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 35493, 36359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 35728, 35919);

                string
                scenarioCode = @"
using a1 = test;

public class ITT
    : a1.IInterfaceBase
{ }

namespace test 
{
    public interface IInterfaceBase
    {
        void bar();
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 35933, 35984);

                var
                testAssembly = f_28001_35952_35983(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 35998, 36348);

                f_28001_35998_36347(testAssembly, f_28001_36202_36346(f_28001_36202_36327(f_28001_36202_36277(ErrorCode.ERR_UnimplementedInterfaceMember, "a1.IInterfaceBase"), "ITT", "test.IInterfaceBase.bar()"), 5, 7));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 35493, 36359);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_35952_35983(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 35952, 35983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_36202_36277(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 36202, 36277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_36202_36327(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 36202, 36327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_36202_36346(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 36202, 36346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_35998_36347(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 35998, 36347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 35493, 36359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 35493, 36359);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 36371, 37823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 36729, 37016);

                string
                scenarioCode = @"
using a1 = test;

public class ITT
    : a1.IInterfaceBase, a1.IInterfaceBase2 
{ }

namespace test 
{
    public interface IInterfaceBase
    {
        void xyz();
    }

    public interface IInterfaceBase2
    {
        void xyz();
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 37032, 37083);

                var
                testAssembly = f_28001_37051_37082(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 37097, 37812);

                f_28001_37097_37811(testAssembly, f_28001_37322_37466(f_28001_37322_37447(f_28001_37322_37397(ErrorCode.ERR_UnimplementedInterfaceMember, "a1.IInterfaceBase"), "ITT", "test.IInterfaceBase.xyz()"), 5, 7), f_28001_37663_37810(f_28001_37663_37790(f_28001_37663_37739(ErrorCode.ERR_UnimplementedInterfaceMember, "a1.IInterfaceBase2"), "ITT", "test.IInterfaceBase2.xyz()"), 5, 26));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 36371, 37823);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_37051_37082(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 37051, 37082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_37322_37397(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 37322, 37397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_37322_37447(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 37322, 37447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_37322_37466(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 37322, 37466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_37663_37739(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 37663, 37739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_37663_37790(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 37663, 37790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_37663_37810(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 37663, 37810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_37097_37811(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 37097, 37811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 36371, 37823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 36371, 37823);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 37833, 38814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 38114, 38370);

                string
                scenarioCode = @"
public class ITT
    : IInterfaceBase, IInterfaceBase2 
{
    void IInterfaceBase2.abc()
    { }
}

public interface IInterfaceBase
{
        void xyz();
}

public interface IInterfaceBase2
{
        void abc();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 38386, 38437);

                var
                testAssembly = f_28001_38405_38436(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 38451, 38803);

                f_28001_38451_38802(testAssembly, f_28001_38665_38801(f_28001_38665_38782(f_28001_38665_38737(ErrorCode.ERR_UnimplementedInterfaceMember, "IInterfaceBase"), "ITT", "IInterfaceBase.xyz()"), 3, 7));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 37833, 38814);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_38405_38436(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 38405, 38436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_38665_38737(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 38665, 38737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_38665_38782(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 38665, 38782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_38665_38801(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 38665, 38801);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_38451_38802(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 38451, 38802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 37833, 38814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 37833, 38814);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 38826, 39800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 39104, 39353);

                string
                scenarioCode = @"
public class ITT
    : IInterfaceBase, IInterfaceBase2 
{
    void IInterfaceBase.xyz()
    { }
}

public interface IInterfaceBase
{
    void xyz();
}

public interface IInterfaceBase2
{
    void abc();
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 39367, 39418);

                var
                testAssembly = f_28001_39386_39417(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 39432, 39789);

                f_28001_39432_39788(testAssembly, f_28001_39648_39787(f_28001_39648_39767(f_28001_39648_39721(ErrorCode.ERR_UnimplementedInterfaceMember, "IInterfaceBase2"), "ITT", "IInterfaceBase2.abc()"), 3, 23));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 38826, 39800);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_39386_39417(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 39386, 39417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_39648_39721(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 39648, 39721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_39648_39767(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 39648, 39767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_39648_39787(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 39648, 39787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_39432_39788(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 39432, 39788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 38826, 39800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 38826, 39800);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 39812, 41079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 40132, 40347);

                string
                scenarioCode = @"
public class ITT
    : IInterfaceBase, 
     IInterfaceBase2 
{ }

public interface IInterfaceBase
{
    void xyz();
}

public interface IInterfaceBase2
{
    void xyz();
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 40361, 40412);

                var
                testAssembly = f_28001_40380_40411(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 40426, 41068);

                f_28001_40426_41067(testAssembly, f_28001_40624_40760(f_28001_40624_40741(f_28001_40624_40696(ErrorCode.ERR_UnimplementedInterfaceMember, "IInterfaceBase"), "ITT", "IInterfaceBase.xyz()"), 3, 7), f_28001_40928_41066(f_28001_40928_41047(f_28001_40928_41001(ErrorCode.ERR_UnimplementedInterfaceMember, "IInterfaceBase2"), "ITT", "IInterfaceBase2.xyz()"), 4, 6));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 39812, 41079);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_40380_40411(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 40380, 40411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_40624_40696(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 40624, 40696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_40624_40741(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 40624, 40741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_40624_40760(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 40624, 40760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_40928_41001(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 40928, 41001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_40928_41047(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 40928, 41047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_40928_41066(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 40928, 41066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_40426_41067(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 40426, 41067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 39812, 41079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 39812, 41079);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 41091, 42466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 41570, 41744);

                string
                scenarioCode = @"
public class ITT: IDerived
{ }

interface IInterfaceBase
{
    void xyzb();
}

interface IDerived : IInterfaceBase
{
    void xyzd();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 41758, 41809);

                var
                testAssembly = f_28001_41777_41808(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 41823, 42455);

                f_28001_41823_42454(testAssembly, f_28001_42021_42147(f_28001_42021_42127(f_28001_42021_42087(ErrorCode.ERR_UnimplementedInterfaceMember, "IDerived"), "ITT", "IDerived.xyzd()"), 2, 19), f_28001_42321_42453(f_28001_42321_42433(f_28001_42321_42387(ErrorCode.ERR_UnimplementedInterfaceMember, "IDerived"), "ITT", "IInterfaceBase.xyzb()"), 2, 19));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 41091, 42466);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_41777_41808(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 41777, 41808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_42021_42087(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 42021, 42087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_42021_42127(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 42021, 42127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_42021_42147(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 42021, 42147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_42321_42387(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 42321, 42387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_42321_42433(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 42321, 42433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_42321_42453(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 42321, 42453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_41823_42454(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 41823, 42454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 41091, 42466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 41091, 42466);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario06()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 42478, 43687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 42740, 42929);

                string
                scenarioCode = @"
public class ITT: IDerived, IInterfaceBase
{ }

interface IInterfaceBase
{
    void xyz();
}

interface IDerived : IInterfaceBase
{
    void xyzd();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 42943, 42994);

                var
                testAssembly = f_28001_42962_42993(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 43008, 43676);

                f_28001_43008_43675(testAssembly, f_28001_43222_43348(f_28001_43222_43328(f_28001_43222_43288(ErrorCode.ERR_UnimplementedInterfaceMember, "IDerived"), "ITT", "IDerived.xyzd()"), 2, 19), f_28001_43537_43674(f_28001_43537_43654(f_28001_43537_43609(ErrorCode.ERR_UnimplementedInterfaceMember, "IInterfaceBase"), "ITT", "IInterfaceBase.xyz()"), 2, 29));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 42478, 43687);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_42962_42993(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 42962, 42993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_43222_43288(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 43222, 43288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_43222_43328(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 43222, 43328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_43222_43348(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 43222, 43348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_43537_43609(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 43537, 43609);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_43537_43654(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 43537, 43654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_43537_43674(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 43537, 43674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_43008_43675(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 43008, 43675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 42478, 43687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 42478, 43687);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario07()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 43699, 44930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 43980, 44170);

                string
                scenarioCode = @"
public class ITT: IInterfaceBase, IDerived 
{ }

interface IDerived : IInterfaceBase
{
    void xyzd();
}
interface IInterfaceBase
{
    void xyz();
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 44184, 44235);

                var
                testAssembly = f_28001_44203_44234(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 44249, 44919);

                f_28001_44249_44918(testAssembly, f_28001_44464_44590(f_28001_44464_44570(f_28001_44464_44530(ErrorCode.ERR_UnimplementedInterfaceMember, "IDerived"), "ITT", "IDerived.xyzd()"), 2, 35), f_28001_44780_44917(f_28001_44780_44897(f_28001_44780_44852(ErrorCode.ERR_UnimplementedInterfaceMember, "IInterfaceBase"), "ITT", "IInterfaceBase.xyz()"), 2, 19));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 43699, 44930);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_44203_44234(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 44203, 44234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_44464_44530(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 44464, 44530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_44464_44570(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 44464, 44570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_44464_44590(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 44464, 44590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_44780_44852(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 44780, 44852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_44780_44897(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 44780, 44897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_44780_44917(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 44780, 44917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_44249_44918(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 44249, 44918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 43699, 44930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 43699, 44930);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario08()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 44942, 46112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 45203, 45394);

                string
                scenarioCode = @"
public class ITT: IDerived2 
{}

interface IBase
{
    void method1();
}
interface IBase2
{
    void Method2();
}
interface IDerived2: IBase, IBase2
{}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 45408, 45459);

                var
                testAssembly = f_28001_45427_45458(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 45473, 46101);

                f_28001_45473_46100(testAssembly, f_28001_45673_45800(f_28001_45673_45780(f_28001_45673_45740(ErrorCode.ERR_UnimplementedInterfaceMember, "IDerived2"), "ITT", "IBase.method1()"), 2, 19), f_28001_45971_46099(f_28001_45971_46079(f_28001_45971_46038(ErrorCode.ERR_UnimplementedInterfaceMember, "IDerived2"), "ITT", "IBase2.Method2()"), 2, 19));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 44942, 46112);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_45427_45458(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 45427, 45458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_45673_45740(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 45673, 45740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_45673_45780(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 45673, 45780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_45673_45800(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 45673, 45800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_45971_46038(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 45971, 46038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_45971_46079(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 45971, 46079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_45971_46099(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 45971, 46099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_45473_46100(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 45473, 46100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 44942, 46112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 44942, 46112);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation13UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario09()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 46124, 47168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 46437, 46751);

                string
                scenarioCode = @"
public class ITT : IDerived
{
    void IBase2.method2()
    { }

    void IDerived.method3()
    { }
}

public interface IBase
{
    void method1();
}

public interface IBase2
{
    void method2();
}
public interface IDerived : IBase, IBase2
{
    void method3();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 46765, 46816);

                var
                testAssembly = f_28001_46784_46815(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 46830, 47157);

                f_28001_46830_47156(testAssembly, f_28001_47029_47155(f_28001_47029_47135(f_28001_47029_47095(ErrorCode.ERR_UnimplementedInterfaceMember, "IDerived"), "ITT", "IBase.method1()"), 2, 20));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 46124, 47168);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_46784_46815(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 46784, 46815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_47029_47095(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 47029, 47095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_47029_47135(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 47029, 47135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_47029_47155(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 47029, 47155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_46830_47156(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 46830, 47156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 46124, 47168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 46124, 47168);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario10()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 47180, 48286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 47442, 47869);

                string
                scenarioCode = @"
public class ITT : IDerived
{
    void IBase2.method2()
    { }    
    void IBase3.method3()
    { }
    void IDerived.method4()
    { }
}

public interface IBase
{
    void method1();
}

public interface IBase2 : IBase
{    
    void method2();
}

public interface IBase3 : IBase
{
    void method3();
}
public interface IDerived : IBase2, IBase3
{
    void method4();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 47883, 47934);

                var
                testAssembly = f_28001_47902_47933(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 47948, 48275);

                f_28001_47948_48274(testAssembly, f_28001_48147_48273(f_28001_48147_48253(f_28001_48147_48213(ErrorCode.ERR_UnimplementedInterfaceMember, "IDerived"), "ITT", "IBase.method1()"), 2, 20));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 47180, 48286);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_47902_47933(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 47902, 47933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_48147_48213(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 48147, 48213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_48147_48253(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 48147, 48253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_48147_48273(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 48147, 48273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_47948_48274(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 47948, 48274);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 47180, 48286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 47180, 48286);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_InterfaceInheritanceScenario11()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 48298, 49483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 48560, 49039);

                string
                scenarioCode = @"
static class Module1
{
    public static void Main()
    {
    }
}

interface Ibase
{
    void method1();
}

interface Ibase2
{
    void method2();
}

interface Iderived : Ibase
{
    void method3();
}

interface Iderived2 : Iderived
{
    void method4();
}

class foo : Iderived2, Iderived, Ibase, Ibase2
{
    void Ibase.method1()
    { }
    void Ibase2.method2()
    { }
    void Iderived2.method4()
    { }
}
 "
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 49053, 49104);

                var
                testAssembly = f_28001_49072_49103(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 49118, 49472);

                f_28001_49118_49471(testAssembly, f_28001_49340_49470(f_28001_49340_49449(f_28001_49340_49406(ErrorCode.ERR_UnimplementedInterfaceMember, "Iderived"), "foo", "Iderived.method3()"), 29, 24));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 48298, 49483);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_49072_49103(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 49072, 49103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_49340_49406(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 49340, 49406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_49340_49449(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 49340, 49449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_49340_49470(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 49340, 49470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_49118_49471(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 49118, 49471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 48298, 49483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 48298, 49483);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_WithPartialClass01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 49495, 50641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 49825, 50216);

                string
                scenarioCode = @"
 public partial class Foo : IBase
{
    void IBase.method1()
    { }

    void IBase2.method2()
    { }
}

public partial class Foo : IBase2
{
}

public partial class Foo : IBase3
{
}

public interface IBase
{
    void method1();
}

public interface IBase2
{    
    void method2();
}

public interface IBase3
{
    void method3();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 50230, 50281);

                var
                testAssembly = f_28001_50249_50280(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 50295, 50630);

                f_28001_50295_50629(testAssembly, f_28001_50502_50628(f_28001_50502_50607(f_28001_50502_50566(ErrorCode.ERR_UnimplementedInterfaceMember, "IBase3"), "Foo", "IBase3.method3()"), 15, 28));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 49495, 50641);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_50249_50280(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 50249, 50280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_50502_50566(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 50502, 50566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_50502_50607(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 50502, 50607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_50502_50628(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 50502, 50628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_50295_50629(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 50295, 50629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 49495, 50641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 49495, 50641);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_WithPartialClass02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 50653, 52120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 51038, 51387);

                string
                scenarioCode = @"
public partial class Foo : IBase, IBase2
{
    void IBase.method1()
    { }

}

public partial class Foo
{
}

public partial class Foo : IBase3
{
}

public interface IBase
{
    void method1();
}

public interface IBase2
{
    void method2();
}

public interface IBase3
{
    void method3();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 51401, 51452);

                var
                testAssembly = f_28001_51420_51451(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 51466, 52109);

                f_28001_51466_52108(testAssembly, f_28001_51679_51804(f_28001_51679_51784(f_28001_51679_51743(ErrorCode.ERR_UnimplementedInterfaceMember, "IBase2"), "Foo", "IBase2.method2()"), 2, 35), f_28001_51981_52107(f_28001_51981_52086(f_28001_51981_52045(ErrorCode.ERR_UnimplementedInterfaceMember, "IBase3"), "Foo", "IBase3.method3()"), 13, 28));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 50653, 52120);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_51420_51451(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 51420, 51451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_51679_51743(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 51679, 51743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_51679_51784(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 51679, 51784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_51679_51804(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 51679, 51804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_51981_52045(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 51981, 52045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_51981_52086(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 51981, 52086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_51981_52107(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 51981, 52107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_51466_52108(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 51466, 52108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 50653, 52120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 50653, 52120);
            }
        }

        [WorkItem(911913, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/911913")]
        [Fact]
        public void UnimplementedInterfaceSquiggleLocation_WithPartialClass03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 52132, 53522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 52468, 52788);

                string
                scenarioCode = @" 
public partial class Foo : IBase, IBase2
{
    void IBase.method1()
    { }

}

public partial class Foo : IBase3
{
}

public interface IBase
{
    void method1();
}

public interface IBase2
{    
    void method2();
}

public interface IBase3
{
    void method3();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 52802, 52853);

                var
                testAssembly = f_28001_52821_52852(scenarioCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 52867, 53511);

                f_28001_52867_53510(testAssembly, f_28001_53080_53205(f_28001_53080_53185(f_28001_53080_53144(ErrorCode.ERR_UnimplementedInterfaceMember, "IBase2"), "Foo", "IBase2.method2()"), 2, 35), f_28001_53381_53506(f_28001_53381_53486(f_28001_53381_53445(ErrorCode.ERR_UnimplementedInterfaceMember, "IBase3"), "Foo", "IBase3.method3()"), 9, 28));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 52132, 53522);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_52821_52852(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 52821, 52852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_53080_53144(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 53080, 53144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_53080_53185(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 53080, 53185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_53080_53205(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 53080, 53205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_53381_53445(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 53381, 53445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_53381_53486(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 53381, 53486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_53381_53506(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 53381, 53506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_52867_53510(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 52867, 53510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 52132, 53522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 52132, 53522);
            }
        }

        [WorkItem(541466, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541466")]
        [Fact]
        public void UseSiteErrorViaAliasTest04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 53532, 55925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 53705, 55668);

                var
                testAssembly = f_28001_53724_55667(f_28001_53724_54010(@"
using ClassAlias = Class1;
public class Test
{
    void m()
    {
        int a = ClassAlias.Class1Foo();
        int b = ClassAlias.Class1Foo();
    }
}", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_53956_54007(), 28001, 53924, 54009) }), f_28001_54358_54560(f_28001_54358_54422(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "Class1"), "System.Collections.Generic.List<FooStruct>", "NoPIAGenerics1-Asm1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), f_28001_54901_55106(f_28001_54901_54968(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "Class1Foo"), "System.Collections.Generic.List<FooStruct>", "NoPIAGenerics1-Asm1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), f_28001_55447_55652(f_28001_55447_55514(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "Class1Foo"), "System.Collections.Generic.List<FooStruct>", "NoPIAGenerics1-Asm1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"))
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 53532, 55925);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_28001_53956_54007()
                {
                    var return_v = TestReferences.SymbolsTests.NoPia.NoPIAGenericsAsm1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 53956, 54007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_53724_54010(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 53724, 54010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_54358_54422(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 54358, 54422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_54358_54560(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 54358, 54560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_54901_54968(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 54901, 54968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_54901_55106(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 54901, 55106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_55447_55514(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 55447, 55514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_55447_55652(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 55447, 55652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_53724_55667(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 53724, 55667);
                    return return_v;
                }


                // NOTE: Dev10 errors:
                // <fine-name>(8,28): error CS0117: 'Class1' does not contain a definition for 'Class1Foo'
                // <fine-name>(9,28): error CS0117: 'Class1' does not contain a definition for 'Class1Foo'
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 53532, 55925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 53532, 55925);
            }
        }

        [WorkItem(541466, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541466")]
        [Fact]
        public void UseSiteErrorViaAliasTest05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 55937, 57208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 56110, 56969);

                var
                testAssembly = f_28001_56129_56968(f_28001_56129_56403(@"
using ClassAlias = Class1;
public class Test
{
    void m()
    {
        var a = new ClassAlias();
        var b = new ClassAlias();
    }
}", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_56349_56400(), 28001, 56317, 56402) }), f_28001_56751_56953(f_28001_56751_56815(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "Class1"), "System.Collections.Generic.List<FooStruct>", "NoPIAGenerics1-Asm1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"))
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 55937, 57208);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_28001_56349_56400()
                {
                    var return_v = TestReferences.SymbolsTests.NoPia.NoPIAGenericsAsm1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 56349, 56400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_56129_56403(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 56129, 56403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_56751_56815(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 56751, 56815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_56751_56953(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 56751, 56953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_56129_56968(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 56129, 56968);
                    return return_v;
                }


                // NOTE: Dev10 errors:
                // <fine-name>(8,17): error CS0143: The type 'Class1' has no constructors defined
                // <fine-name>(9,17): error CS0143: The type 'Class1' has no constructors defined
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 55937, 57208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 55937, 57208);
            }
        }

        [WorkItem(541466, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541466")]
        [Fact]
        public void UseSiteErrorViaAliasTest06()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 57220, 59761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 57393, 58688);

                var
                testAssembly = f_28001_57412_58687(f_28001_57412_57708(@"
using ClassAlias = Class1;
public class Test
{
    ClassAlias a = null;
    ClassAlias b = null;
    ClassAlias m() { return null; }
    void m2(ClassAlias p) { }
}", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_57654_57705(), 28001, 57622, 57707) }), f_28001_58056_58258(f_28001_58056_58120(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "Class1"), "System.Collections.Generic.List<FooStruct>", "NoPIAGenerics1-Asm1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), f_28001_58389_58465(f_28001_58389_58441(ErrorCode.WRN_UnreferencedFieldAssg, "b"), "Test.b"), f_28001_58596_58672(f_28001_58596_58648(ErrorCode.WRN_UnreferencedFieldAssg, "a"), "Test.a"))
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 57220, 59761);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_28001_57654_57705()
                {
                    var return_v = TestReferences.SymbolsTests.NoPia.NoPIAGenericsAsm1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 57654, 57705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_57412_57708(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 57412, 57708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_58056_58120(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 58056, 58120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_58056_58258(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 58056, 58258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_58389_58441(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 58389, 58441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_58389_58465(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 58389, 58465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_58596_58648(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 58596, 58648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_58596_58672(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 58596, 58672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_57412_58687(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 57412, 58687);
                    return return_v;
                }


                // NOTE: Dev10 errors:
                // <fine-name>(4,16): error CS1772: Type 'Class1' from assembly '...\NoPIAGenerics1-Asm1.dll' cannot be used across assembly boundaries because a type in its inheritance hierarchy has a generic type parameter that is an embedded interop type.
                // <fine-name>(5,16): error CS1772: Type 'Class1' from assembly '...\NoPIAGenerics1-Asm1.dll' cannot be used across assembly boundaries because a type in its inheritance hierarchy has a generic type parameter that is an embedded interop type.
                // <fine-name>(6,16): error CS1772: Type 'Class1' from assembly '...\NoPIAGenerics1-Asm1.dll' cannot be used across assembly boundaries because a type in its inheritance hierarchy has a generic type parameter that is an embedded interop type.
                // <fine-name>(7,10): error CS1772: Type 'Class1' from assembly '...\NoPIAGenerics1-Asm1.dll' cannot be used across assembly boundaries because a type in its inheritance hierarchy has a generic type parameter that is an embedded interop type.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 57220, 59761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 57220, 59761);
            }
        }

        [WorkItem(541466, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541466")]
        [Fact]
        public void UseSiteErrorViaAliasTest07()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 59773, 62139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 59946, 62080);

                var
                testAssembly = f_28001_59965_62079(f_28001_59965_60305(@"
using ClassAlias = Class1;
public class Test
{
    void m()
    {
        ClassAlias a = null;
        ClassAlias b = null;
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
    }
}", references: new List<MetadataReference>() { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_28001_60251_60302(), 28001, 60219, 60304) }), f_28001_60689_60891(f_28001_60689_60753(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "Class1"), "System.Collections.Generic.List<FooStruct>", "NoPIAGenerics1-Asm1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), f_28001_61264_61484(f_28001_61264_61346(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "System.Console.WriteLine"), "System.Collections.Generic.List<FooStruct>", "NoPIAGenerics1-Asm1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), f_28001_61858_62078(f_28001_61858_61940(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "System.Console.WriteLine"), "System.Collections.Generic.List<FooStruct>", "NoPIAGenerics1-Asm1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"))
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 59773, 62139);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_28001_60251_60302()
                {
                    var return_v = TestReferences.SymbolsTests.NoPia.NoPIAGenericsAsm1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 60251, 60302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_59965_60305(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 59965, 60305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_60689_60753(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 60689, 60753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_60689_60891(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 60689, 60891);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_61264_61346(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 61264, 61346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_61264_61484(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 61264, 61484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_61858_61940(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 61858, 61940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_61858_62078(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 61858, 62078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_59965_62079(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 59965, 62079);
                    return return_v;
                }


                // NOTE: Dev10 reports NO ERRORS
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 59773, 62139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 59773, 62139);
            }
        }

        [WorkItem(948674, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/948674")]
        [Fact]
        public void UseSiteErrorViaImplementedInterfaceMember_1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 62151, 65078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 62341, 62563);

                var
                source1 = @"
using System;
using System.Runtime.InteropServices;

[assembly: ImportedFromTypeLib(""GeneralPIA.dll"")]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

public struct ImageMoniker
{ }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 62579, 62675);

                CSharpCompilation
                comp1 = f_28001_62605_62674(source1, assemblyName: "Pia948674_1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 62691, 62774);

                var
                source2 = @"
public interface IBar
{
    ImageMoniker? Moniker { get; }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 62790, 62978);

                CSharpCompilation
                comp2 = f_28001_62816_62977(source2, new MetadataReference[] { f_28001_62883_62945(comp1, embedInteropTypes: true) }, assemblyName: "Bar948674_1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 62994, 63129);

                var
                source3 = @"
public class BarImpl : IBar
{
    public ImageMoniker? Moniker    
    {
        get { return null; }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 63145, 63343);

                CSharpCompilation
                comp3 = f_28001_63171_63342(source3, new MetadataReference[] { f_28001_63238_63275(comp2), f_28001_63277_63339(comp1, embedInteropTypes: true) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 63359, 63877);

                f_28001_63359_63876(
                            comp3, f_28001_63674_63857(f_28001_63674_63837(f_28001_63674_63736(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "IBar"), "ImageMoniker?", "Bar948674_1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), 2, 24));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 63893, 64058);

                comp3 = f_28001_63901_64057(source3, new MetadataReference[] { f_28001_63968_63996(comp2), f_28001_63998_64054(f_28001_63998_64026(comp1), true) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 64074, 65067);

                f_28001_64074_65066(
                            comp3, f_28001_64389_64572(f_28001_64389_64552(f_28001_64389_64451(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "IBar"), "ImageMoniker?", "Bar948674_1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), 2, 24), f_28001_64864_65047(f_28001_64864_65027(f_28001_64864_64926(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "IBar"), "ImageMoniker?", "Bar948674_1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), 2, 24));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 62151, 65078);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_62605_62674(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 62605, 62674);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_62883_62945(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 62883, 62945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_62816_62977(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 62816, 62977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_63238_63275(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63238, 63275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_63277_63339(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63277, 63339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_63171_63342(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63171, 63342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_63674_63736(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63674, 63736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_63674_63837(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63674, 63837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_63674_63857(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63674, 63857);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_63359_63876(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63359, 63876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_63968_63996(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63968, 63996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_63998_64026(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63998, 64026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_63998_64054(Microsoft.CodeAnalysis.MetadataReference
                this_param, bool
                value)
                {
                    var return_v = this_param.WithEmbedInteropTypes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63998, 64054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_63901_64057(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 63901, 64057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_64389_64451(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 64389, 64451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_64389_64552(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 64389, 64552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_64389_64572(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 64389, 64572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_64864_64926(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 64864, 64926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_64864_65027(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 64864, 65027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_64864_65047(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 64864, 65047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_64074_65066(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 64074, 65066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 62151, 65078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 62151, 65078);
            }
        }

        [WorkItem(948674, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/948674")]
        [Fact]
        public void UseSiteErrorViaImplementedInterfaceMember_2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 65090, 68088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 65280, 65502);

                var
                source1 = @"
using System;
using System.Runtime.InteropServices;

[assembly: ImportedFromTypeLib(""GeneralPIA.dll"")]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

public struct ImageMoniker
{ }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 65518, 65614);

                CSharpCompilation
                comp1 = f_28001_65544_65613(source1, assemblyName: "Pia948674_2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 65630, 65713);

                var
                source2 = @"
public interface IBar
{
    ImageMoniker? Moniker { get; }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 65729, 65917);

                CSharpCompilation
                comp2 = f_28001_65755_65916(source2, new MetadataReference[] { f_28001_65822_65884(comp1, embedInteropTypes: true) }, assemblyName: "Bar948674_2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 65933, 66066);

                var
                source3 = @"
public class BarImpl : IBar
{
    ImageMoniker? IBar.Moniker    
    {
        get { return null; }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 66082, 66280);

                CSharpCompilation
                comp3 = f_28001_66108_66279(source3, new MetadataReference[] { f_28001_66175_66212(comp2), f_28001_66214_66276(comp1, embedInteropTypes: true) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 66296, 67088);

                f_28001_66296_67087(
                            comp3, f_28001_66480_66593(f_28001_66480_66573(f_28001_66480_66540(ErrorCode.ERR_InterfaceMemberNotFound, "Moniker"), "BarImpl.Moniker"), 4, 24), f_28001_66885_67068(f_28001_66885_67048(f_28001_66885_66947(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "IBar"), "ImageMoniker?", "Bar948674_2, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), 2, 24));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 67104, 67269);

                comp3 = f_28001_67112_67268(source3, new MetadataReference[] { f_28001_67179_67207(comp2), f_28001_67209_67265(f_28001_67209_67237(comp1), true) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 67285, 68077);

                f_28001_67285_68076(
                            comp3, f_28001_67469_67582(f_28001_67469_67562(f_28001_67469_67529(ErrorCode.ERR_InterfaceMemberNotFound, "Moniker"), "BarImpl.Moniker"), 4, 24), f_28001_67874_68057(f_28001_67874_68037(f_28001_67874_67936(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "IBar"), "ImageMoniker?", "Bar948674_2, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), 2, 24));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 65090, 68088);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_65544_65613(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 65544, 65613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_65822_65884(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 65822, 65884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_65755_65916(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 65755, 65916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_66175_66212(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66175, 66212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_66214_66276(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66214, 66276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_66108_66279(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66108, 66279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_66480_66540(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66480, 66540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_66480_66573(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66480, 66573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_66480_66593(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66480, 66593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_66885_66947(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66885, 66947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_66885_67048(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66885, 67048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_66885_67068(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66885, 67068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_66296_67087(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 66296, 67087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_67179_67207(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67179, 67207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_67209_67237(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67209, 67237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_67209_67265(Microsoft.CodeAnalysis.MetadataReference
                this_param, bool
                value)
                {
                    var return_v = this_param.WithEmbedInteropTypes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67209, 67265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_67112_67268(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67112, 67268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_67469_67529(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67469, 67529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_67469_67562(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67469, 67562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_67469_67582(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67469, 67582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_67874_67936(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67874, 67936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_67874_68037(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67874, 68037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_67874_68057(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67874, 68057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_67285_68076(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 67285, 68076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 65090, 68088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 65090, 68088);
            }
        }

        [WorkItem(948674, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/948674")]
        [Fact]
        public void UseSiteErrorViaImplementedInterfaceMember_3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 68100, 70538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 68290, 68512);

                var
                source1 = @"
using System;
using System.Runtime.InteropServices;

[assembly: ImportedFromTypeLib(""GeneralPIA.dll"")]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

public struct ImageMoniker
{ }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 68528, 68624);

                CSharpCompilation
                comp1 = f_28001_68554_68623(source1, assemblyName: "Pia948674_3")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 68640, 68732);

                var
                source2 = @"
public interface IBar
{
    void SetMoniker(ImageMoniker? moniker);
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 68748, 68936);

                CSharpCompilation
                comp2 = f_28001_68774_68935(source2, new MetadataReference[] { f_28001_68841_68903(comp1, embedInteropTypes: true) }, assemblyName: "Bar948674_3")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 68952, 69064);

                var
                source3 = @"
public class BarImpl : IBar
{
    public void SetMoniker(ImageMoniker? moniker)
    {}
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 69080, 69278);

                CSharpCompilation
                comp3 = f_28001_69106_69277(source3, new MetadataReference[] { f_28001_69173_69210(comp2), f_28001_69212_69274(comp1, embedInteropTypes: true) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 69294, 69812);

                f_28001_69294_69811(
                            comp3, f_28001_69609_69792(f_28001_69609_69772(f_28001_69609_69671(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "IBar"), "ImageMoniker?", "Bar948674_3, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), 2, 24));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 69828, 69993);

                comp3 = f_28001_69836_69992(source3, new MetadataReference[] { f_28001_69903_69931(comp2), f_28001_69933_69989(f_28001_69933_69961(comp1), true) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 70009, 70527);

                f_28001_70009_70526(
                            comp3, f_28001_70324_70507(f_28001_70324_70487(f_28001_70324_70386(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "IBar"), "ImageMoniker?", "Bar948674_3, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), 2, 24));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 68100, 70538);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_68554_68623(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 68554, 68623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_68841_68903(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 68841, 68903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_68774_68935(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 68774, 68935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_69173_69210(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69173, 69210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_69212_69274(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69212, 69274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_69106_69277(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69106, 69277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_69609_69671(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69609, 69671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_69609_69772(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69609, 69772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_69609_69792(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69609, 69792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_69294_69811(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69294, 69811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_69903_69931(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69903, 69931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_69933_69961(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69933, 69961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_69933_69989(Microsoft.CodeAnalysis.MetadataReference
                this_param, bool
                value)
                {
                    var return_v = this_param.WithEmbedInteropTypes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69933, 69989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_69836_69992(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 69836, 69992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_70324_70386(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 70324, 70386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_70324_70487(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 70324, 70487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_70324_70507(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 70324, 70507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_70009_70526(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 70009, 70526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 68100, 70538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 68100, 70538);
            }
        }

        [WorkItem(948674, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/948674")]
        [Fact]
        public void UseSiteErrorViaImplementedInterfaceMember_4()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 70550, 73638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 70740, 70962);

                var
                source1 = @"
using System;
using System.Runtime.InteropServices;

[assembly: ImportedFromTypeLib(""GeneralPIA.dll"")]
[assembly: Guid(""f9c2d51d-4f44-45f0-9eda-c9d599b58257"")]

public struct ImageMoniker
{ }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 70978, 71074);

                CSharpCompilation
                comp1 = f_28001_71004_71073(source1, assemblyName: "Pia948674_4")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 71090, 71182);

                var
                source2 = @"
public interface IBar
{
    void SetMoniker(ImageMoniker? moniker);
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 71198, 71386);

                CSharpCompilation
                comp2 = f_28001_71224_71385(source2, new MetadataReference[] { f_28001_71291_71353(comp1, embedInteropTypes: true) }, assemblyName: "Bar948674_4")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 71402, 71512);

                var
                source3 = @"
public class BarImpl : IBar
{
    void IBar.SetMoniker(ImageMoniker? moniker)
    {}
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 71528, 71726);

                CSharpCompilation
                comp3 = f_28001_71554_71725(source3, new MetadataReference[] { f_28001_71621_71658(comp2), f_28001_71660_71722(comp1, embedInteropTypes: true) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 71742, 72586);

                f_28001_71742_72585(
                            comp3, f_28001_71957_72091(f_28001_71957_72071(f_28001_71957_72020(ErrorCode.ERR_InterfaceMemberNotFound, "SetMoniker"), "BarImpl.SetMoniker(ImageMoniker?)"), 4, 15), f_28001_72383_72566(f_28001_72383_72546(f_28001_72383_72445(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "IBar"), "ImageMoniker?", "Bar948674_4, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), 2, 24));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 72602, 72767);

                comp3 = f_28001_72610_72766(source3, new MetadataReference[] { f_28001_72677_72705(comp2), f_28001_72707_72763(f_28001_72707_72735(comp1), true) });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 72783, 73627);

                f_28001_72783_73626(
                            comp3, f_28001_72998_73132(f_28001_72998_73112(f_28001_72998_73061(ErrorCode.ERR_InterfaceMemberNotFound, "SetMoniker"), "BarImpl.SetMoniker(ImageMoniker?)"), 4, 15), f_28001_73424_73607(f_28001_73424_73587(f_28001_73424_73486(ErrorCode.ERR_GenericsUsedAcrossAssemblies, "IBar"), "ImageMoniker?", "Bar948674_4, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"), 2, 24));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 70550, 73638);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_71004_71073(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71004, 71073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_71291_71353(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71291, 71353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_71224_71385(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71224, 71385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_71621_71658(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71621, 71658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_28001_71660_71722(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation, embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71660, 71722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_71554_71725(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71554, 71725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_71957_72020(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71957, 72020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_71957_72071(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71957, 72071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_71957_72091(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71957, 72091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_72383_72445(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72383, 72445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_72383_72546(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72383, 72546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_72383_72566(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72383, 72566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_71742_72585(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 71742, 72585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_72677_72705(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72677, 72705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_72707_72735(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72707, 72735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_28001_72707_72763(Microsoft.CodeAnalysis.MetadataReference
                this_param, bool
                value)
                {
                    var return_v = this_param.WithEmbedInteropTypes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72707, 72763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_72610_72766(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72610, 72766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_72998_73061(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72998, 73061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_72998_73112(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72998, 73112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_72998_73132(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72998, 73132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_73424_73486(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 73424, 73486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_73424_73587(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 73424, 73587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_73424_73607(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 73424, 73607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_72783_73626(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 72783, 73626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 70550, 73638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 70550, 73638);
            }
        }

        [WorkItem(541246, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541246")]
        [Fact]
        public void NamespaceQualifiedGenericTypeName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 73650, 74048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 73830, 73977);

                var
                source =
                @"namespace N
{
    public class A<T>
    {
        public static T F;
    }
}
class B
{
    static int G = N.A<int>.F;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 73991, 74037);

                f_28001_73991_74036(f_28001_73991_74016(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 73650, 74048);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_73991_74016(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 73991, 74016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_73991_74036(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 73991, 74036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 73650, 74048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 73650, 74048);
            }
        }

        [Fact]
        public void NamespaceQualifiedGenericTypeNameWrongArity()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 74060, 75308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 74158, 74549);

                var
                source =
                @"namespace N
{
    public class A<T>
    {
        public static T F;
    }

    public class B 
    { 
        public static int F;
    }
    public class B<T1, T2> 
    { 
        public static System.Tuple<T1, T2> F;
    }
}
class C
{
    static int TooMany = N.A<int, int>.F;
    static int TooFew = N.A.F;
    static int TooIndecisive = N.B<int>;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 74563, 75297);

                f_28001_74563_75296(f_28001_74563_74588(source), f_28001_74749_74835(f_28001_74749_74798(ErrorCode.ERR_BadArity, "A<int, int>"), "N.A<T>", "type", "1"), f_28001_74978_75054(f_28001_74978_75017(ErrorCode.ERR_BadArity, "A"), "N.A<T>", "type", "1"), f_28001_75199_75277(f_28001_75199_75248(ErrorCode.ERR_HasNoTypeVars, "B<int>"), "N.B", "type"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 74060, 75308);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_74563_74588(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 74563, 74588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_74749_74798(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 74749, 74798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_74749_74835(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 74749, 74835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_74978_75017(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 74978, 75017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_74978_75054(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 74978, 75054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_75199_75248(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 75199, 75248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_75199_75277(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 75199, 75277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_74563_75296(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 74563, 75296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 74060, 75308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 74060, 75308);
            }
        }

        [WorkItem(541570, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541570")]
        [Fact]
        public void EnumNotMemberInConstructor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 75320, 75678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 75493, 75607);

                var
                source =
                @"enum E { A }
class C
{
    public C(E e = E.A) { }
    public E E { get { return E.A; } }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 75621, 75667);

                f_28001_75621_75666(f_28001_75621_75646(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 75320, 75678);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_75621_75646(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 75621, 75646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_75621_75666(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 75621, 75666);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 75320, 75678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 75320, 75678);
            }
        }

        [WorkItem(541638, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541638")]
        [Fact]
        public void KeywordAsLabelIdentifier()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 75690, 76238);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 75861, 75998);

                var
                source =
                @"class Program
{
    static void Main(string[] args)
    {
    @int1:
        System.Console.WriteLine();
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 76012, 76227);

                f_28001_76012_76226(f_28001_76012_76037(source), f_28001_76173_76225(ErrorCode.WRN_UnreferencedLabel, "@int1"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 75690, 76238);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_76012_76037(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 76012, 76037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_76173_76225(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 76173, 76225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_76012_76226(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 76012, 76226);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 75690, 76238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 75690, 76238);
            }
        }

        [WorkItem(541677, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/541677")]
        [Fact]
        public void AssignStaticEventToLocalVariable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 76250, 76661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 76429, 76590);

                var
                source =
                @"delegate void Foo();
class driver
{
    public static event Foo e;
    static void Main(string[] args)
    {
        Foo x = e;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 76604, 76650);

                f_28001_76604_76649(f_28001_76604_76629(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 76250, 76661);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_76604_76629(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 76604, 76629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_76604_76649(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 76604, 76649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 76250, 76661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 76250, 76661);
            }
        }

        [WorkItem(528743, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/528743")]
        [Fact]
        public void GenericMethodLocation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 76803, 78489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 76971, 77199);

                var
                source =
                @"interface I
{
    void M1<T>() where T : class;
}
class C : I
{
    public void M1<T>() { }
    void M2<T>(this object o) { }
    sealed void M3<T>() { }
    internal static virtual void M4<T>() { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 77213, 78478);

                f_28001_77213_78477(f_28001_77213_77238(source), f_28001_77411_77476(f_28001_77411_77457(ErrorCode.ERR_BadExtensionAgg, "C"), 5, 7), f_28001_77790_77910(f_28001_77790_77890(f_28001_77790_77840(ErrorCode.ERR_ImplBadConstraints, "M1"), "T", "C.M1<T>()", "T", "I.M1<T>()"), 7, 17), f_28001_78078_78174(f_28001_78078_78154(f_28001_78078_78127(ErrorCode.ERR_SealedNonOverride, "M3"), "C.M3<T>()"), 9, 17), f_28001_78380_78476(f_28001_78380_78455(f_28001_78380_78428(ErrorCode.ERR_StaticNotVirtual, "M4"), "C.M4<T>()"), 10, 34));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 76803, 78489);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_77213_77238(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 77213, 77238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_77411_77457(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 77411, 77457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_77411_77476(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 77411, 77476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_77790_77840(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 77790, 77840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_77790_77890(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 77790, 77890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_77790_77910(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 77790, 77910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_78078_78127(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 78078, 78127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_78078_78154(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 78078, 78154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_78078_78174(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 78078, 78174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_78380_78428(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 78380, 78428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_78380_78455(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 78380, 78455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_78380_78476(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 78380, 78476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_77213_78477(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 77213, 78477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 76803, 78489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 76803, 78489);
            }
        }

        [WorkItem(542391, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/542391")]
        [Fact]
        public void PartialMethodOptionalParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 78501, 79767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 78679, 78947);

                var
                source =
                @"partial class C
{
    partial void M1(object o);
    partial void M1(object o = null) { }
    partial void M2(object o = null);
    partial void M2(object o) { }
    partial void M3(object o = null);
    partial void M3(object o = null) { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 78961, 79756);

                f_28001_78961_79755(f_28001_78961_78986(source), f_28001_79287_79370(f_28001_79287_79351(ErrorCode.WRN_DefaultValueForUnconsumedLocation, "o"), "o"), f_28001_79653_79736(f_28001_79653_79717(ErrorCode.WRN_DefaultValueForUnconsumedLocation, "o"), "o"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 78501, 79767);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_78961_78986(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 78961, 78986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_79287_79351(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 79287, 79351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_79287_79370(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 79287, 79370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_79653_79717(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 79653, 79717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_79653_79736(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 79653, 79736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_78961_79755(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 78961, 79755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 78501, 79767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 78501, 79767);
            }
        }

        [Fact]
        [WorkItem(598043, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/598043")]
        public void PartialMethodParameterNamesFromDefinition1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 79779, 80467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 79968, 80094);

                var
                source = @"
partial class C
{
    partial void F(int i);
}

partial class C
{
    partial void F(int j) { }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 80108, 80456);

                f_28001_80108_80455(this, source, options: f_28001_80142_80217(TestOptions.ReleaseDll, MetadataImportOptions.All), symbolValidator: module =>
                            {
                                var method = module.GlobalNamespace.GetMember<TypeSymbol>("C").GetMember<MethodSymbol>("F");
                                CustomAssert.Equal("i", method.Parameters[0].Name);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 79779, 80467);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_28001_80142_80217(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 80142, 80217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_28001_80108_80455(Microsoft.CodeAnalysis.CSharp.UnitTests.Semantics.BindingTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 80108, 80455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 79779, 80467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 79779, 80467);
            }
        }

        [Fact]
        [WorkItem(598043, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/598043")]
        public void PartialMethodParameterNamesFromDefinition2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 80479, 81167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 80668, 80794);

                var
                source = @"
partial class C
{
    partial void F(int j) { }
}

partial class C
{
    partial void F(int i);
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 80808, 81156);

                f_28001_80808_81155(this, source, options: f_28001_80842_80917(TestOptions.ReleaseDll, MetadataImportOptions.All), symbolValidator: module =>
                            {
                                var method = module.GlobalNamespace.GetMember<TypeSymbol>("C").GetMember<MethodSymbol>("F");
                                CustomAssert.Equal("i", method.Parameters[0].Name);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 80479, 81167);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_28001_80842_80917(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 80842, 80917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_28001_80808_81155(Microsoft.CodeAnalysis.CSharp.UnitTests.Semantics.BindingTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 80808, 81155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 80479, 81167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 80479, 81167);
            }
        }

        [Fact]
        public void ParameterErrorsDefaultPartialMethodStaticType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 81349, 82827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 81449, 81583);

                var
                source =
                @"static class S { }
partial class C
{
    partial void M(S s = new A());
    partial void M(S s = new B()) { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 81597, 82816);

                f_28001_81597_82815(f_28001_81597_81622(source), f_28001_81803_81895(f_28001_81803_81875(f_28001_81803_81856(ErrorCode.ERR_ParameterIsStaticClass, "M"), "S"), 4, 18), f_28001_82061_82153(f_28001_82061_82133(f_28001_82061_82114(ErrorCode.ERR_ParameterIsStaticClass, "M"), "S"), 5, 18), f_28001_82384_82476(f_28001_82384_82456(f_28001_82384_82437(ErrorCode.ERR_SingleTypeNameNotFound, "B"), "B"), 5, 30), f_28001_82704_82796(f_28001_82704_82776(f_28001_82704_82757(ErrorCode.ERR_SingleTypeNameNotFound, "A"), "A"), 4, 30));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 81349, 82827);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_81597_81622(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 81597, 81622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_81803_81856(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 81803, 81856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_81803_81875(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 81803, 81875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_81803_81895(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 81803, 81895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_82061_82114(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 82061, 82114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_82061_82133(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 82061, 82133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_82061_82153(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 82061, 82153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_82384_82437(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 82384, 82437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_82384_82456(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 82384, 82456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_82384_82476(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 82384, 82476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_82704_82757(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 82704, 82757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_82704_82776(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 82704, 82776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_82704_82796(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 82704, 82796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_81597_82815(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 81597, 82815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 81349, 82827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 81349, 82827);
            }
        }

        [WorkItem(543349, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543349")]
        [Fact]
        public void Fixed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 82839, 83878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 82991, 83200);

                var
                source =
                @"class C
{
    unsafe static void M(int[] arg)
    {
        fixed (int* ptr = arg) { }
        fixed (int* ptr = arg) *ptr = 0;
        fixed (int* ptr = arg) object o = null;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 83214, 83867);

                f_28001_83214_83866(f_28001_83214_83278(source, options: TestOptions.UnsafeReleaseDll), f_28001_83489_83570(f_28001_83489_83550(ErrorCode.ERR_BadEmbeddedStmt, "object o = null;"), 7, 32), f_28001_83758_83847(f_28001_83758_83827(f_28001_83758_83808(ErrorCode.WRN_UnreferencedVarAssg, "o"), "o"), 7, 39));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 82839, 83878);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_83214_83278(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 83214, 83278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_83489_83550(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 83489, 83550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_83489_83570(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 83489, 83570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_83758_83808(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 83758, 83808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_83758_83827(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 83758, 83827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_83758_83847(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 83758, 83847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_83214_83866(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 83214, 83866);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 82839, 83878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 82839, 83878);
            }
        }

        [WorkItem(1040171, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1040171")]
        [Fact]
        public void Bug1040171()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 83890, 85093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 84049, 84246);

                const string
                sourceCode = @"
class Program
{
    static void Main(string[] args)
    {
        bool c = true;

        foreach (string s in args)
            label: c = false;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 84260, 84308);

                var
                compilation = f_28001_84278_84307(sourceCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 84322, 85082);

                f_28001_84322_85081(compilation, f_28001_84526_84608(f_28001_84526_84588(ErrorCode.ERR_BadEmbeddedStmt, "label: c = false;"), 9, 13), f_28001_84756_84828(f_28001_84756_84808(ErrorCode.WRN_UnreferencedLabel, "label"), 9, 13), f_28001_84991_85080(f_28001_84991_85060(f_28001_84991_85041(ErrorCode.WRN_UnreferencedVarAssg, "c"), "c"), 6, 14));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 83890, 85093);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_84278_84307(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 84278, 84307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_84526_84588(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 84526, 84588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_84526_84608(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 84526, 84608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_84756_84808(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 84756, 84808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_84756_84828(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 84756, 84828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_84991_85041(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 84991, 85041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_84991_85060(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 84991, 85060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_84991_85080(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 84991, 85080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_84322_85081(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 84322, 85081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 83890, 85093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 83890, 85093);
            }
        }

        [Fact, WorkItem(543426, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543426")]

        private void NestedInterfaceImplementationWithOuterGenericType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 85103, 85592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 85292, 85581);

                f_28001_85292_85580(this, @"
namespace System.ServiceModel
{
    class Pipeline<T>
    {
        interface IStage
        {
            void Process(T context);
        }

        class AsyncStage : IStage
        {
            void IStage.Process(T context) { }
        }
    }
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 85103, 85592);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_28001_85292_85580(Microsoft.CodeAnalysis.CSharp.UnitTests.Semantics.BindingTests
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 85292, 85580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 85103, 85592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 85103, 85592);
            }
        }

        [Fact]
        public void ErrorTypeConst()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 85713, 87092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 85782, 85950);

                var
                source =
                @"class C
{
    const C1 F1 = 0;
    const C2 F2 = null;
    static void M()
    {
        const C3 c3 = 0;
        const C4 c4 = null;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 85964, 87081);

                f_28001_85964_87080(f_28001_85964_85989(source), f_28001_86181_86275(f_28001_86181_86255(f_28001_86181_86235(ErrorCode.ERR_SingleTypeNameNotFound, "C1"), "C1"), 3, 11), f_28001_86449_86543(f_28001_86449_86523(f_28001_86449_86503(ErrorCode.ERR_SingleTypeNameNotFound, "C2"), "C2"), 4, 11), f_28001_86717_86811(f_28001_86717_86791(f_28001_86717_86771(ErrorCode.ERR_SingleTypeNameNotFound, "C3"), "C3"), 7, 15), f_28001_86985_87079(f_28001_86985_87059(f_28001_86985_87039(ErrorCode.ERR_SingleTypeNameNotFound, "C4"), "C4"), 8, 15));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 85713, 87092);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_85964_85989(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 85964, 85989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86181_86235(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86181, 86235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86181_86255(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86181, 86255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86181_86275(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86181, 86275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86449_86503(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86449, 86503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86449_86523(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86449, 86523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86449_86543(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86449, 86543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86717_86771(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86717, 86771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86717_86791(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86717, 86791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86717_86811(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86717, 86811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86985_87039(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86985, 87039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86985_87059(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86985, 87059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_86985_87079(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 86985, 87079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_85964_87080(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 85964, 87080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 85713, 87092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 85713, 87092);
            }
        }

        [WorkItem(543777, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543777")]
        [Fact]
        public void DefaultParameterAtEndOfFile()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 87104, 88847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 87278, 87342);

                var
                source =
                @"class C
{
    static void M(object o = null,"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 87356, 88836);

                f_28001_87356_88835(f_28001_87356_87381(source), f_28001_87529_87571(ErrorCode.ERR_TypeExpected, ""), f_28001_87742_87790(ErrorCode.ERR_IdentifierExpected, ""), f_28001_87917_87965(ErrorCode.ERR_CloseParenExpected, ""), f_28001_88092_88139(ErrorCode.ERR_SemicolonExpected, ""), f_28001_88266_88310(ErrorCode.ERR_RbraceExpected, ""), f_28001_88488_88549(ErrorCode.ERR_DefaultValueBeforeRequiredValue, ""), f_28001_88752_88834(f_28001_88752_88802(ErrorCode.ERR_ConcreteMissingBody, "M"), "C.M(object, ?)"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 87104, 88847);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_87356_87381(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 87356, 87381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_87529_87571(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 87529, 87571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_87742_87790(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 87742, 87790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_87917_87965(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 87917, 87965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_88092_88139(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 88092, 88139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_88266_88310(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 88266, 88310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_88488_88549(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 88488, 88549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_88752_88802(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 88752, 88802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_88752_88834(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 88752, 88834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_87356_88835(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 87356, 88835);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 87104, 88847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 87104, 88847);
            }
        }

        [WorkItem(543814, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543814")]
        [Fact]
        public void DuplicateNamedArgumentNullLiteral()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 88859, 89462);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 89039, 89168);

                var
                source =
                @"class C
{
    static void M()
    {
        M("""",
            arg: 0,
            arg: null);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 89182, 89451);

                f_28001_89182_89450(f_28001_89182_89207(source), f_28001_89364_89449(f_28001_89364_89430(f_28001_89364_89406(ErrorCode.ERR_BadArgCount, "M"), "M", "3"), 5, 9));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 88859, 89462);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_89182_89207(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 89182, 89207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_89364_89406(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 89364, 89406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_89364_89430(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 89364, 89430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_89364_89449(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 89364, 89449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_89182_89450(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 89182, 89450);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 88859, 89462);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 88859, 89462);
            }
        }

        [WorkItem(543820, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543820")]
        [Fact]
        public void GenericAttributeClassWithMultipleParts()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 89474, 90399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 89659, 89726);

                var
                source =
                @"class C<T> { }
class C<T> : System.Attribute { }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 89740, 90388);

                f_28001_89740_90387(f_28001_89740_89765(source), f_28001_89970_90059(f_28001_89970_90018(ErrorCode.ERR_DuplicateNameInNS, "C"), "C", "<global namespace>"), f_28001_90260_90368(f_28001_90260_90334(ErrorCode.ERR_GenericDerivingFromAttribute, "System.Attribute"), "System.Attribute"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 89474, 90399);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_89740_89765(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 89740, 89765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_89970_90018(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 89970, 90018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_89970_90059(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 89970, 90059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_90260_90334(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 90260, 90334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_90260_90368(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 90260, 90368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_89740_90387(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 89740, 90387);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 89474, 90399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 89474, 90399);
            }
        }

        [WorkItem(543822, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543822")]
        [Fact]
        public void InterfaceWithPartialMethodExplicitImplementation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 90411, 91956);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 90606, 90666);

                var
                source =
                @"interface I
{
    partial void I.M();
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 90680, 91945);

                f_28001_90680_91944(f_28001_90680_90786(source, parseOptions: TestOptions.Regular7, targetFramework: TargetFramework.NetCoreApp), f_28001_90975_91050(f_28001_90975_91030(ErrorCode.ERR_PartialMethodNotExplicit, "M"), 3, 20), f_28001_91211_91293(f_28001_91211_91273(ErrorCode.ERR_PartialMethodOnlyInPartialClass, "M"), 3, 20), f_28001_91517_91654(f_28001_91517_91634(f_28001_91517_91577(ErrorCode.ERR_FeatureNotAvailableInVersion7, "M"), "default interface implementation", "8.0"), 3, 20), f_28001_91817_91925(f_28001_91817_91905(f_28001_91817_91877(ErrorCode.ERR_ClassDoesntImplementInterface, "I"), "I.M()", "I"), 3, 18));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 90411, 91956);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_90680_90786(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions, Roslyn.Test.Utilities.TargetFramework
                targetFramework)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions: parseOptions, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 90680, 90786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_90975_91030(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 90975, 91030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_90975_91050(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 90975, 91050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_91211_91273(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 91211, 91273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_91211_91293(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 91211, 91293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_91517_91577(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 91517, 91577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_91517_91634(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 91517, 91634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_91517_91654(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 91517, 91654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_91817_91877(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 91817, 91877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_91817_91905(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 91817, 91905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_91817_91925(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 91817, 91925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_90680_91944(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 90680, 91944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 90411, 91956);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 90411, 91956);
            }
        }

        [WorkItem(543827, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543827")]
        [Fact]
        public void StructConstructor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 91968, 92496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 92132, 92425);

                var
                source =
                @"struct S
{
    private readonly object x;
    private readonly object y;
    S(object x, object y)
    {
        try
        {
            this.x = x;
        }
        finally
        {
            this.y = y;
        }
    }
    S(S o) : this(o.x, o.y) {}
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 92439, 92485);

                f_28001_92439_92484(f_28001_92439_92464(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 91968, 92496);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_92439_92464(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 92439, 92464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_92439_92484(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 92439, 92484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 91968, 92496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 91968, 92496);
            }
        }

        [WorkItem(543827, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543827")]
        [Fact]
        public void StructVersusTryFinally()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 92508, 92986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 92677, 92915);

                var
                source =
                @"struct S
{
    private object x;
    private object y;
    static void M()
    {
        S s1;
        try { s1.x = null; } finally { s1.y = null; }
        S s2 = s1;
        s1.x = s1.y; s1.y = s1.x;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 92929, 92975);

                f_28001_92929_92974(f_28001_92929_92954(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 92508, 92986);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_92929_92954(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 92929, 92954);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_92929_92974(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 92929, 92974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 92508, 92986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 92508, 92986);
            }
        }

        [WorkItem(544513, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/544513")]
        [Fact()]
        public void AnonTypesPropSameNameDiffType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 92998, 93734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 93176, 93369);

                var
                source =
                @"public class Test
{
    public static void Main()
    {
        var p1 = new { Price = 495.00 };
        var p2 = new { Price = ""36.50"" };

        p1 = p2;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 93383, 93723);

                f_28001_93383_93722(f_28001_93383_93408(source), f_28001_93593_93721(f_28001_93593_93639(ErrorCode.ERR_NoImplicitConv, "p2"), "<anonymous type: string Price>", "<anonymous type: double Price>"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 92998, 93734);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_93383_93408(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 93383, 93408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_93593_93639(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 93593, 93639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_93593_93721(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 93593, 93721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_93383_93722(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 93383, 93722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 92998, 93734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 92998, 93734);
            }
        }

        [WorkItem(545869, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/545869")]
        [Fact]
        public void TestSealedOverriddenMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 93746, 94851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 93920, 94840);

                f_28001_93920_94839(f_28001_93920_94819(this, @"using System;

internal abstract class Base
{
    public virtual int Property
    {
        get { return 0; }
        protected set { }
    }
    protected virtual event EventHandler Event
    {
        add { } remove { }
    }
    protected abstract void Method();
}

internal sealed class Derived : Base
{
    public override int Property
    {
        get { return 1; }
        protected set { }
    }
    protected override event EventHandler Event;
    protected override void Method()  { }

    void UseEvent() { Event(null, null); }
}

internal sealed class Derived2 : Base
{
    public override int Property
    {
        get; protected set;
    }
    protected override event EventHandler Event
    {
        add { } remove { }
    }
    protected override void Method() { }
}

class Program
{
    static void Main() { }
}"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 93746, 94851);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_28001_93920_94819(Microsoft.CodeAnalysis.CSharp.UnitTests.Semantics.BindingTests
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 93920, 94819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_28001_93920_94839(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = this_param.VerifyDiagnostics(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 93920, 94839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 93746, 94851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 93746, 94851);
            }
        }

        [Fact, WorkItem(1068547, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1068547")]
        public void Bug1068547_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 94863, 95676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95015, 95163);

                var
                source =
                @"
class Program
{
    [System.Diagnostics.DebuggerDisplay(this)]
    static void Main(string[] args)
    {
        
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95177, 95214);

                var
                comp = f_28001_95188_95213(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95230, 95261);

                var
                tree = f_28001_95241_95257(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95275, 95315);

                var
                model = f_28001_95287_95314(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95329, 95459);

                var
                node = f_28001_95340_95458(f_28001_95340_95449(f_28001_95340_95420(f_28001_95340_95372(f_28001_95340_95354(tree)), n => n.IsKind(SyntaxKind.ThisExpression))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95475, 95518);

                var
                symbolInfo = f_28001_95492_95517(model, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95534, 95571);

                f_28001_95534_95570(symbolInfo.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95585, 95665);

                f_28001_95585_95664(CandidateReason.NotReferencable, symbolInfo.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 94863, 95676);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_95188_95213(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95188, 95213);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_95241_95257(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 95241, 95257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_95287_95314(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95287, 95314);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_95340_95354(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95340, 95354);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_95340_95372(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95340, 95372);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_95340_95420(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95340, 95420);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax>
                f_28001_95340_95449(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Cast<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95340, 95449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax
                f_28001_95340_95458(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95340, 95458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_95492_95517(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95492, 95517);
                    return return_v;
                }


                bool
                f_28001_95534_95570(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95534, 95570);
                    return return_v;
                }


                bool
                f_28001_95585_95664(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95585, 95664);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 94863, 95676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 94863, 95676);
            }
        }

        [Fact, WorkItem(1068547, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1068547")]
        public void Bug1068547_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 95688, 96421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95840, 95908);

                var
                source =
                @"
    [System.Diagnostics.DebuggerDisplay(this)]
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95922, 95959);

                var
                comp = f_28001_95933_95958(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 95975, 96006);

                var
                tree = f_28001_95986_96002(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 96020, 96060);

                var
                model = f_28001_96032_96059(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 96074, 96204);

                var
                node = f_28001_96085_96203(f_28001_96085_96194(f_28001_96085_96165(f_28001_96085_96117(f_28001_96085_96099(tree)), n => n.IsKind(SyntaxKind.ThisExpression))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 96220, 96263);

                var
                symbolInfo = f_28001_96237_96262(model, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 96279, 96316);

                f_28001_96279_96315(symbolInfo.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 96330, 96410);

                f_28001_96330_96409(CandidateReason.NotReferencable, symbolInfo.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 95688, 96421);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_95933_95958(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 95933, 95958);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_95986_96002(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 95986, 96002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_96032_96059(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96032, 96059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_96085_96099(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96085, 96099);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_96085_96117(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96085, 96117);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_96085_96165(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96085, 96165);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax>
                f_28001_96085_96194(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Cast<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96085, 96194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax
                f_28001_96085_96203(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96085, 96203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_96237_96262(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ThisExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96237, 96262);
                    return return_v;
                }


                bool
                f_28001_96279_96315(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96279, 96315);
                    return return_v;
                }


                bool
                f_28001_96330_96409(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96330, 96409);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 95688, 96421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 95688, 96421);
            }
        }

        [Fact]
        public void RefReturningDelegateCreation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 96433, 96792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 96516, 96707);

                var
                text = @"
delegate ref int D();

class C
{
    int field = 0;

    ref int M()
    {
        return ref field;
    }

    void Test()
    {
        new D(M)();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 96723, 96781);

                f_28001_96723_96780(f_28001_96723_96760(text));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 96433, 96792);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_96723_96760(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96723, 96760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_96723_96780(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 96723, 96780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 96433, 96792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 96433, 96792);
            }
        }

        [Fact]
        public void RefReturningDelegateCreationBad()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 96804, 97819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 96890, 97073);

                var
                text = @"
delegate ref int D();

class C
{
    int field = 0;

    int M()
    {
        return field;
    }

    void Test()
    {
        new D(M)();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 97089, 97472);

                f_28001_97089_97471(f_28001_97089_97187(text, parseOptions: TestOptions.WithoutImprovedOverloadCandidates), f_28001_97353_97452(f_28001_97353_97431(f_28001_97353_97403(ErrorCode.ERR_DelegateRefMismatch, "M"), "C.M()", "D"), 15, 15));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 97486, 97808);

                f_28001_97486_97807(f_28001_97486_97523(text), f_28001_97689_97788(f_28001_97689_97767(f_28001_97689_97739(ErrorCode.ERR_DelegateRefMismatch, "M"), "C.M()", "D"), 15, 15));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 96804, 97819);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_97089_97187(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97089, 97187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_97353_97403(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97353, 97403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_97353_97431(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97353, 97431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_97353_97452(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97353, 97452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_97089_97471(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97089, 97471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_97486_97523(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97486, 97523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_97689_97739(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97689, 97739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_97689_97767(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97689, 97767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_97689_97788(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97689, 97788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_97486_97807(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 97486, 97807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 96804, 97819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 96804, 97819);
            }
        }

        [Fact]
        public void RefReturningDelegateArgument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 97831, 98217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 97914, 98132);

                var
                text = @"
delegate ref int D();

class C
{
    int field = 0;

    ref int M()
    {
        return ref field;
    }

    void M(D d)
    {
    }

    void Test()
    {
        M(M);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 98148, 98206);

                f_28001_98148_98205(f_28001_98148_98185(text));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 97831, 98217);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_98148_98185(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 98148, 98185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_98148_98205(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 98148, 98205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 97831, 98217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 97831, 98217);
            }
        }

        [Fact]
        public void RefReturningDelegateArgumentBad()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 98229, 99259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 98315, 98525);

                var
                text = @"
delegate ref int D();

class C
{
    int field = 0;

    int M()
    {
        return field;
    }

    void M(D d)
    {
    }

    void Test()
    {
        M(M);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 98541, 98918);

                f_28001_98541_98917(f_28001_98541_98639(text, parseOptions: TestOptions.WithoutImprovedOverloadCandidates), f_28001_98799_98898(f_28001_98799_98877(f_28001_98799_98849(ErrorCode.ERR_DelegateRefMismatch, "M"), "C.M()", "D"), 19, 11));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 98932, 99248);

                f_28001_98932_99247(f_28001_98932_98969(text), f_28001_99129_99228(f_28001_99129_99207(f_28001_99129_99179(ErrorCode.ERR_DelegateRefMismatch, "M"), "C.M()", "D"), 19, 11));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 98229, 99259);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_98541_98639(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 98541, 98639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_98799_98849(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 98799, 98849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_98799_98877(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 98799, 98877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_98799_98898(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 98799, 98898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_98541_98917(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 98541, 98917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_98932_98969(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 98932, 98969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_99129_99179(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 99129, 99179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_99129_99207(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 99129, 99207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_99129_99228(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 99129, 99228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_98932_99247(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 98932, 99247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 98229, 99259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 98229, 99259);
            }
        }

        [Fact, WorkItem(1078958, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1078958")]
        public void Bug1078958()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 99271, 99852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 99420, 99543);

                const string
                source = @"
class C
{
    static void Foo<T>()
    {
        T();
    }
 
    static void T() { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 99559, 99841);

                f_28001_99559_99840(f_28001_99559_99584(source), f_28001_99750_99839(f_28001_99750_99820(f_28001_99750_99793(ErrorCode.ERR_BadSKunknown, "T"), "T", "type"), 6, 9));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 99271, 99852);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_99559_99584(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 99559, 99584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_99750_99793(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 99750, 99793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_99750_99820(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 99750, 99820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_99750_99839(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 99750, 99839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_99559_99840(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 99559, 99840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 99271, 99852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 99271, 99852);
            }
        }

        [Fact, WorkItem(1078958, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1078958")]
        public void Bug1078958_2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 99864, 100244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 100015, 100171);

                const string
                source = @"
class C
{
    static void Foo<T>()
    {
        T<T>();
    }
 
    static void T() { }

    static void T<U>() { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 100187, 100233);

                f_28001_100187_100232(f_28001_100187_100212(source));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 99864, 100244);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_100187_100212(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 100187, 100212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_100187_100232(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 100187, 100232);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 99864, 100244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 99864, 100244);
            }
        }

        [Fact, WorkItem(1078961, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1078961")]
        public void Bug1078961()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 100256, 100690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 100405, 100616);

                const string
                source = @"
class C
{
    const int T = 42;
    static void Foo<T>(int x = T)
    {
        System.Console.Write(x);
    }

    static void Main()
    {
        Foo<object>();
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 100632, 100679);

                f_28001_100632_100678(this, source, expectedOutput: "42");
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 100256, 100690);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_28001_100632_100678(Microsoft.CodeAnalysis.CSharp.UnitTests.Semantics.BindingTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 100632, 100678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 100256, 100690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 100256, 100690);
            }
        }

        [Fact, WorkItem(1078961, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1078961")]
        public void Bug1078961_2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 100702, 101544);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 100853, 101032);

                const string
                source = @"
class A : System.Attribute
{
    public A(int i) { }
}

class C
{
    const int T = 42;

    static void Foo<T>([A(T)] int x)
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101048, 101085);

                var
                comp = f_28001_101059_101084(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101099, 101124);

                f_28001_101099_101123(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101140, 101198);

                var
                c = f_28001_101148_101188(f_28001_101148_101168(comp), "C").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101212, 101260);

                var
                t = (FieldSymbol)f_28001_101233_101250(c, "T").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101274, 101327);

                var
                foo = (MethodSymbol)f_28001_101298_101317(c, "Foo").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101341, 101367);

                var
                x = f_28001_101349_101363(foo)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101381, 101410);

                var
                a = f_28001_101389_101406(x)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101424, 101464);

                var
                i = f_28001_101432_101463(f_28001_101432_101454(a))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101478, 101533);

                f_28001_101478_101532(i.Value, f_28001_101516_101531(t));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 100702, 101544);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_101059_101084(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101059, 101084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_101099_101123(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101099, 101123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_28001_101148_101168(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 101148, 101168);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_28001_101148_101188(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101148, 101188);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_28001_101233_101250(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101233, 101250);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_28001_101298_101317(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101298, 101317);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_28001_101349_101363(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 101349, 101363);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_28001_101389_101406(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101389, 101406);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
                f_28001_101432_101454(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.ConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 101432, 101454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_28001_101432_101463(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.TypedConstant>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101432, 101463);
                    return return_v;
                }


                object
                f_28001_101516_101531(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 101516, 101531);
                    return return_v;
                }


                bool
                f_28001_101478_101532(object?
                expected, object
                actual)
                {
                    var return_v = CustomAssert.Equal((int)expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101478, 101532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 100702, 101544);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 100702, 101544);
            }
        }

        [Fact, WorkItem(1078961, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1078961")]
        public void Bug1078961_3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 101556, 102365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101707, 101891);

                const string
                source = @"
class A : System.Attribute
{
    public A(int i) { }
}

class C
{
    const int T = 42;

    [A(T)]
    static void Foo<T>(int x)
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101907, 101944);

                var
                comp = f_28001_101918_101943(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101958, 101983);

                f_28001_101958_101982(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 101999, 102057);

                var
                c = f_28001_102007_102047(f_28001_102007_102027(comp), "C").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102071, 102119);

                var
                t = (FieldSymbol)f_28001_102092_102109(c, "T").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102133, 102186);

                var
                foo = (MethodSymbol)f_28001_102157_102176(c, "Foo").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102200, 102231);

                var
                a = f_28001_102208_102227(foo)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102245, 102285);

                var
                i = f_28001_102253_102284(f_28001_102253_102275(a))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102299, 102354);

                f_28001_102299_102353(i.Value, f_28001_102337_102352(t));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 101556, 102365);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_101918_101943(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101918, 101943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_101958_101982(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 101958, 101982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_28001_102007_102027(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 102007, 102027);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_28001_102007_102047(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102007, 102047);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_28001_102092_102109(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102092, 102109);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_28001_102157_102176(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102157, 102176);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_28001_102208_102227(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102208, 102227);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
                f_28001_102253_102275(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.ConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 102253, 102275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_28001_102253_102284(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.TypedConstant>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102253, 102284);
                    return return_v;
                }


                object
                f_28001_102337_102352(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 102337, 102352);
                    return return_v;
                }


                bool
                f_28001_102299_102353(object?
                expected, object
                actual)
                {
                    var return_v = CustomAssert.Equal((int)expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102299, 102353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 101556, 102365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 101556, 102365);
            }
        }

        [Fact, WorkItem(1078961, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1078961")]
        public void Bug1078961_4()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 102377, 103225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102528, 102707);

                const string
                source = @"
class A : System.Attribute
{
    public A(int i) { }
}

class C
{
    const int T = 42;

    static void Foo<[A(T)] T>(int x)
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102723, 102760);

                var
                comp = f_28001_102734_102759(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102774, 102799);

                f_28001_102774_102798(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102815, 102873);

                var
                c = f_28001_102823_102863(f_28001_102823_102843(comp), "C").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102887, 102935);

                var
                t = (FieldSymbol)f_28001_102908_102925(c, "T").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 102949, 103002);

                var
                foo = (MethodSymbol)f_28001_102973_102992(c, "Foo").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 103016, 103047);

                var
                tt = f_28001_103025_103043(foo)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 103061, 103091);

                var
                a = f_28001_103069_103087(tt)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 103105, 103145);

                var
                i = f_28001_103113_103144(f_28001_103113_103135(a))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 103159, 103214);

                f_28001_103159_103213(i.Value, f_28001_103197_103212(t));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 102377, 103225);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_102734_102759(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102734, 102759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_102774_102798(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102774, 102798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_28001_102823_102843(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 102823, 102843);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_28001_102823_102863(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102823, 102863);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_28001_102908_102925(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102908, 102925);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_28001_102973_102992(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 102973, 102992);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_28001_103025_103043(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 103025, 103043);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_28001_103069_103087(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 103069, 103087);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
                f_28001_103113_103135(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.ConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 103113, 103135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_28001_103113_103144(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TypedConstant>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.TypedConstant>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 103113, 103144);
                    return return_v;
                }


                object
                f_28001_103197_103212(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 103197, 103212);
                    return return_v;
                }


                bool
                f_28001_103159_103213(object?
                expected, object
                actual)
                {
                    var return_v = CustomAssert.Equal((int)expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 103159, 103213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 102377, 103225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 102377, 103225);
            }
        }

        [Fact, WorkItem(1078961, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1078961")]
        public void Bug1078961_5()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 103237, 103694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 103388, 103618);

                const string
                source = @"
class C
{
    class T { }

    static void Foo<T>(T x = default(T))
    {
        System.Console.Write((object)x == null);
    }

    static void Main()
    {
        Foo<object>();
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 103634, 103683);

                f_28001_103634_103682(this, source, expectedOutput: "True");
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 103237, 103694);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_28001_103634_103682(Microsoft.CodeAnalysis.CSharp.UnitTests.Semantics.BindingTests
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 103634, 103682);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 103237, 103694);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 103237, 103694);
            }
        }

        [Fact, WorkItem(3096, "https://github.com/dotnet/roslyn/issues/3096")]
        public void CastToDelegate_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 103706, 105833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 103842, 104300);

                var
                sourceText = @"namespace NS
{
    public static class A
    {
        public delegate void Action();

        public static void M()
        {
            RunAction(A.B<string>.M0);
            RunAction((Action)A.B<string>.M1);
        }

        private static void RunAction(Action action) { }

        private class B<T>
        {
            public static void M0() { }
            public static void M1() { }
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 104316, 104395);

                var
                compilation = f_28001_104334_104394(sourceText, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 104411, 104443);

                f_28001_104411_104442(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 104459, 104503);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 104517, 104564);

                var
                model = f_28001_104529_104563(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 104580, 104847);

                var
                identifierNameM0 = f_28001_104603_104846(f_28001_104603_104720(f_28001_104603_104671(f_28001_104603_104635(tree
                ))), x => x.Parent.IsKind(SyntaxKind.SimpleMemberAccessExpression) && x.Identifier.ValueText.Equals("M0"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 104863, 104936);

                f_28001_104863_104935("A.B<string>.M0", f_28001_104900_104934(f_28001_104900_104923(identifierNameM0)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 104950, 105003);

                var
                m0Symbol = f_28001_104965_105002(model, identifierNameM0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 105019, 105112);

                f_28001_105019_105111("void NS.A.B<System.String>.M0()", f_28001_105073_105110(m0Symbol.Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 105126, 105193);

                f_28001_105126_105192(CandidateReason.None, m0Symbol.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 105209, 105476);

                var
                identifierNameM1 = f_28001_105232_105475(f_28001_105232_105349(f_28001_105232_105300(f_28001_105232_105264(tree
                ))), x => x.Parent.IsKind(SyntaxKind.SimpleMemberAccessExpression) && x.Identifier.ValueText.Equals("M1"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 105492, 105565);

                f_28001_105492_105564("A.B<string>.M1", f_28001_105529_105563(f_28001_105529_105552(identifierNameM1)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 105579, 105632);

                var
                m1Symbol = f_28001_105594_105631(model, identifierNameM1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 105648, 105741);

                f_28001_105648_105740("void NS.A.B<System.String>.M1()", f_28001_105702_105739(m1Symbol.Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 105755, 105822);

                f_28001_105755_105821(CandidateReason.None, m1Symbol.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 103706, 105833);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_104334_104394(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104334, 104394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_104411_104442(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104411, 104442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_104529_104563(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104529, 104563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_104603_104635(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104603, 104635);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_104603_104671(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104603, 104671);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                f_28001_104603_104720(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104603, 104720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_28001_104603_104846(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool>
                predicate)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104603, 104846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_28001_104900_104923(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 104900, 104923);
                    return return_v;
                }


                string
                f_28001_104900_104934(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104900, 104934);
                    return return_v;
                }


                bool
                f_28001_104863_104935(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104863, 104935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_104965_105002(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 104965, 105002);
                    return return_v;
                }


                string
                f_28001_105073_105110(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105073, 105110);
                    return return_v;
                }


                bool
                f_28001_105019_105111(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105019, 105111);
                    return return_v;
                }


                bool
                f_28001_105126_105192(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105126, 105192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_105232_105264(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105232, 105264);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_105232_105300(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105232, 105300);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                f_28001_105232_105349(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105232, 105349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_28001_105232_105475(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool>
                predicate)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105232, 105475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_28001_105529_105552(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 105529, 105552);
                    return return_v;
                }


                string
                f_28001_105529_105563(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105529, 105563);
                    return return_v;
                }


                bool
                f_28001_105492_105564(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105492, 105564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_105594_105631(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105594, 105631);
                    return return_v;
                }


                string
                f_28001_105702_105739(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105702, 105739);
                    return return_v;
                }


                bool
                f_28001_105648_105740(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105648, 105740);
                    return return_v;
                }


                bool
                f_28001_105755_105821(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 105755, 105821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 103706, 105833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 103706, 105833);
            }
        }

        [Fact, WorkItem(3096, "https://github.com/dotnet/roslyn/issues/3096")]
        public void CastToDelegate_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 105845, 108062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 105981, 106559);

                var
                sourceText = @"
class A
{
    public delegate void MyDelegate<T>(T a);

    public void Test()
    {
        UseMyDelegate((MyDelegate<int>)MyMethod);
        UseMyDelegate((MyDelegate<long>)MyMethod);
        UseMyDelegate((MyDelegate<float>)MyMethod);
        UseMyDelegate((MyDelegate<double>)MyMethod);
    }

    private void UseMyDelegate<T>(MyDelegate<T> f) { }

    private static void MyMethod(int a) { }
    private static void MyMethod(long a) { }
    private static void MyMethod(float a) { }
    private static void MyMethod(double a) { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 106575, 106654);

                var
                compilation = f_28001_106593_106653(sourceText, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 106670, 106702);

                f_28001_106670_106701(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 106718, 106762);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 106776, 106823);

                var
                model = f_28001_106788_106822(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 106839, 107057);

                var
                identifiers = f_28001_106857_107056(f_28001_106857_107046(f_28001_106857_106974(f_28001_106857_106925(f_28001_106857_106889(tree
                ))), x => x.Identifier.ValueText.Equals("MyMethod")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 107073, 107115);

                f_28001_107073_107114(4, f_28001_107095_107113(identifiers));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 107131, 107213);

                f_28001_107131_107212("(MyDelegate<int>)MyMethod", f_28001_107179_107211(f_28001_107179_107200(identifiers[0])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 107227, 107347);

                f_28001_107227_107346("void A.MyMethod(System.Int32 a)", f_28001_107281_107345(f_28001_107281_107316(model, identifiers[0]).Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 107363, 107446);

                f_28001_107363_107445("(MyDelegate<long>)MyMethod", f_28001_107412_107444(f_28001_107412_107433(identifiers[1])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 107460, 107580);

                f_28001_107460_107579("void A.MyMethod(System.Int64 a)", f_28001_107514_107578(f_28001_107514_107549(model, identifiers[1]).Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 107596, 107680);

                f_28001_107596_107679("(MyDelegate<float>)MyMethod", f_28001_107646_107678(f_28001_107646_107667(identifiers[2])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 107694, 107815);

                f_28001_107694_107814("void A.MyMethod(System.Single a)", f_28001_107749_107813(f_28001_107749_107784(model, identifiers[2]).Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 107831, 107916);

                f_28001_107831_107915("(MyDelegate<double>)MyMethod", f_28001_107882_107914(f_28001_107882_107903(identifiers[3])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 107930, 108051);

                f_28001_107930_108050("void A.MyMethod(System.Double a)", f_28001_107985_108049(f_28001_107985_108020(model, identifiers[3]).Symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 105845, 108062);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_106593_106653(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 106593, 106653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_106670_106701(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 106670, 106701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_106788_106822(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 106788, 106822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_106857_106889(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 106857, 106889);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_106857_106925(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 106857, 106925);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                f_28001_106857_106974(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 106857, 106974);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                f_28001_106857_107046(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 106857, 107046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax[]
                f_28001_106857_107056(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 106857, 107056);
                    return return_v;
                }


                int
                f_28001_107095_107113(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 107095, 107113);
                    return return_v;
                }


                bool
                f_28001_107073_107114(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107073, 107114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_28001_107179_107200(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 107179, 107200);
                    return return_v;
                }


                string
                f_28001_107179_107211(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107179, 107211);
                    return return_v;
                }


                bool
                f_28001_107131_107212(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107131, 107212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_107281_107316(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107281, 107316);
                    return return_v;
                }


                string
                f_28001_107281_107345(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107281, 107345);
                    return return_v;
                }


                bool
                f_28001_107227_107346(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107227, 107346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_28001_107412_107433(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 107412, 107433);
                    return return_v;
                }


                string
                f_28001_107412_107444(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107412, 107444);
                    return return_v;
                }


                bool
                f_28001_107363_107445(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107363, 107445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_107514_107549(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107514, 107549);
                    return return_v;
                }


                string
                f_28001_107514_107578(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107514, 107578);
                    return return_v;
                }


                bool
                f_28001_107460_107579(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107460, 107579);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_28001_107646_107667(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 107646, 107667);
                    return return_v;
                }


                string
                f_28001_107646_107678(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107646, 107678);
                    return return_v;
                }


                bool
                f_28001_107596_107679(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107596, 107679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_107749_107784(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107749, 107784);
                    return return_v;
                }


                string
                f_28001_107749_107813(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107749, 107813);
                    return return_v;
                }


                bool
                f_28001_107694_107814(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107694, 107814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_28001_107882_107903(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 107882, 107903);
                    return return_v;
                }


                string
                f_28001_107882_107914(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107882, 107914);
                    return return_v;
                }


                bool
                f_28001_107831_107915(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107831, 107915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_107985_108020(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107985, 108020);
                    return return_v;
                }


                string
                f_28001_107985_108049(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107985, 108049);
                    return return_v;
                }


                bool
                f_28001_107930_108050(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 107930, 108050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 105845, 108062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 105845, 108062);
            }
        }

        [Fact, WorkItem(3096, "https://github.com/dotnet/roslyn/issues/3096")]
        public void CastToDelegate_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 108074, 110279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 108210, 108709);

                var
                sourceText = @"namespace NS
{
    public static class A
    {
        public delegate void Action();

        public static void M()
        {
            var b = new A.B<string>();
            RunAction(b.M0);
            RunAction((Action)b.M1);
        }

        private static void RunAction(Action action) { }

        public class B<T>
        {
        }

        public static void M0<T>(this B<T> x) { }
        public static void M1<T>(this B<T> x) { }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 108725, 108831);

                var
                compilation = f_28001_108743_108830(sourceText, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 108847, 108879);

                f_28001_108847_108878(
                            compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 108895, 108939);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 108953, 109000);

                var
                model = f_28001_108965_108999(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 109016, 109283);

                var
                identifierNameM0 = f_28001_109039_109282(f_28001_109039_109156(f_28001_109039_109107(f_28001_109039_109071(tree
                ))), x => x.Parent.IsKind(SyntaxKind.SimpleMemberAccessExpression) && x.Identifier.ValueText.Equals("M0"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 109299, 109362);

                f_28001_109299_109361("b.M0", f_28001_109326_109360(f_28001_109326_109349(identifierNameM0)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 109376, 109429);

                var
                m0Symbol = f_28001_109391_109428(model, identifierNameM0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 109445, 109553);

                f_28001_109445_109552("void NS.A.B<System.String>.M0<System.String>()", f_28001_109514_109551(m0Symbol.Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 109567, 109634);

                f_28001_109567_109633(CandidateReason.None, m0Symbol.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 109650, 109917);

                var
                identifierNameM1 = f_28001_109673_109916(f_28001_109673_109790(f_28001_109673_109741(f_28001_109673_109705(tree
                ))), x => x.Parent.IsKind(SyntaxKind.SimpleMemberAccessExpression) && x.Identifier.ValueText.Equals("M1"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 109933, 109996);

                f_28001_109933_109995("b.M1", f_28001_109960_109994(f_28001_109960_109983(identifierNameM1)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 110010, 110063);

                var
                m1Symbol = f_28001_110025_110062(model, identifierNameM1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 110079, 110187);

                f_28001_110079_110186("void NS.A.B<System.String>.M1<System.String>()", f_28001_110148_110185(m1Symbol.Symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 110201, 110268);

                f_28001_110201_110267(CandidateReason.None, m1Symbol.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 108074, 110279);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_108743_108830(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 108743, 108830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_108847_108878(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 108847, 108878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_108965_108999(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 108965, 108999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_109039_109071(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109039, 109071);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_109039_109107(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109039, 109107);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                f_28001_109039_109156(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109039, 109156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_28001_109039_109282(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool>
                predicate)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109039, 109282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_28001_109326_109349(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 109326, 109349);
                    return return_v;
                }


                string
                f_28001_109326_109360(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109326, 109360);
                    return return_v;
                }


                bool
                f_28001_109299_109361(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109299, 109361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_109391_109428(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109391, 109428);
                    return return_v;
                }


                string
                f_28001_109514_109551(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109514, 109551);
                    return return_v;
                }


                bool
                f_28001_109445_109552(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109445, 109552);
                    return return_v;
                }


                bool
                f_28001_109567_109633(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109567, 109633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_109673_109705(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109673, 109705);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_109673_109741(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109673, 109741);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                f_28001_109673_109790(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109673, 109790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_28001_109673_109916(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool>
                predicate)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109673, 109916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_28001_109960_109983(Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 109960, 109983);
                    return return_v;
                }


                string
                f_28001_109960_109994(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109960, 109994);
                    return return_v;
                }


                bool
                f_28001_109933_109995(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 109933, 109995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_110025_110062(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 110025, 110062);
                    return return_v;
                }


                string
                f_28001_110148_110185(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 110148, 110185);
                    return return_v;
                }


                bool
                f_28001_110079_110186(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 110079, 110186);
                    return return_v;
                }


                bool
                f_28001_110201_110267(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 110201, 110267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 108074, 110279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 108074, 110279);
            }
        }

        [Fact, WorkItem(5170, "https://github.com/dotnet/roslyn/issues/5170")]
        public void TypeOfBinderParameter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 110291, 112306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 110431, 110805);

                var
                sourceText = @"
using System.Linq;
using System.Text;

public static class LazyToStringExtension
{
    public static string LazyToString<T>(this T obj) where T : class
    {
        StringBuilder sb = new StringBuilder();
        typeof(T)
            .GetProperties(System.Reflection.BindingFlags.Public)
            .Select(x => x.GetValue(obj))
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 110819, 110953);

                var
                compilation = f_28001_110837_110952(sourceText, new[] { f_28001_110889_110918() }, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 110967, 111840);

                f_28001_110967_111839(compilation, f_28001_111131_111199(f_28001_111131_111178(ErrorCode.ERR_SemicolonExpected, ""), 12, 42), f_28001_111375_111476(f_28001_111375_111455(f_28001_111375_111424(ErrorCode.ERR_BadArgCount, "GetValue"), "GetValue", "1"), 12, 28), f_28001_111704_111838(f_28001_111704_111818(f_28001_111704_111760(ErrorCode.ERR_ReturnExpected, "LazyToString"), "LazyToStringExtension.LazyToString<T>(T)"), 7, 26));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 111854, 111892);

                var
                tree = f_28001_111865_111888(compilation)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 111906, 111953);

                var
                model = f_28001_111918_111952(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 111967, 112076);

                var
                node = f_28001_111978_112075(f_28001_111978_112066(f_28001_111978_112010(f_28001_111978_111992(tree)), n => n.IsKind(SyntaxKind.SimpleLambdaExpression)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 112090, 112172);

                var
                param = f_28001_112102_112171(f_28001_112102_112162(f_28001_112102_112119(node), n => n.IsKind(SyntaxKind.Parameter)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 112186, 112295);

                f_28001_112186_112294("System.Reflection.PropertyInfo x", f_28001_112241_112293(f_28001_112241_112271(model, param)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 110291, 112306);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_28001_110889_110918()
                {
                    var return_v = TestMetadata.Net40.SystemCore;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 110889, 110918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_110837_110952(string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 110837, 110952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_111131_111178(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111131, 111178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_111131_111199(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111131, 111199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_111375_111424(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111375, 111424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_111375_111455(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111375, 111455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_111375_111476(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111375, 111476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_111704_111760(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111704, 111760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_111704_111818(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111704, 111818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_111704_111838(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111704, 111838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_110967_111839(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 110967, 111839);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_111865_111888(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 111865, 111888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_111918_111952(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111918, 111952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_111978_111992(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111978, 111992);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_111978_112010(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111978, 112010);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_111978_112066(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111978, 112066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_111978_112075(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 111978, 112075);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_112102_112119(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112102, 112119);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_112102_112162(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112102, 112162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_112102_112171(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112102, 112171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_28001_112241_112271(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                declaration)
                {
                    var return_v = semanticModel.GetDeclaredSymbol(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112241, 112271);
                    return return_v;
                }


                string
                f_28001_112241_112293(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112241, 112293);
                    return return_v;
                }


                bool
                f_28001_112186_112294(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112186, 112294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 110291, 112306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 110291, 112306);
            }
        }

        [Fact, WorkItem(7520, "https://github.com/dotnet/roslyn/issues/7520")]
        public void DelegateCreationWithIncompleteLambda()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 112318, 114375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 112473, 112599);

                var
                source =
                @"
using System;
class C
{
    public void F()
    {
        var x = new Action<int>(i => i.
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 112613, 112650);

                var
                comp = f_28001_112624_112649(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 112664, 113608);

                f_28001_112664_113607(comp, f_28001_112827_112895(f_28001_112827_112875(ErrorCode.ERR_IdentifierExpected, ""), 7, 40), f_28001_113027_113095(f_28001_113027_113075(ErrorCode.ERR_CloseParenExpected, ""), 7, 40), f_28001_113227_113294(f_28001_113227_113274(ErrorCode.ERR_SemicolonExpected, ""), 7, 40), f_28001_113521_113592(f_28001_113521_113572(ErrorCode.ERR_IllegalStatement, @"i.
"), 7, 38));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 113622, 113653);

                var
                tree = f_28001_113633_113649(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 113667, 113707);

                var
                model = f_28001_113679_113706(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 113721, 113832);

                var
                lambda = f_28001_113734_113831(f_28001_113734_113822(f_28001_113734_113766(f_28001_113734_113748(tree)), n => n.IsKind(SyntaxKind.SimpleLambdaExpression)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 113848, 113932);

                var
                param = f_28001_113860_113931(f_28001_113860_113922(f_28001_113860_113879(lambda), n => n.IsKind(SyntaxKind.Parameter)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 113946, 113991);

                var
                symbol1 = f_28001_113960_113990(model, param)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 114005, 114073);

                f_28001_114005_114072("System.Int32 i", f_28001_114042_114071(symbol1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 114089, 114171);

                var
                id = f_28001_114098_114170(f_28001_114098_114122(lambda), n => n.IsKind(SyntaxKind.IdentifierName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 114185, 114230);

                var
                symbol2 = f_28001_114199_114222(model, id).Symbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 114244, 114312);

                f_28001_114244_114311("System.Int32 i", f_28001_114281_114310(symbol2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 114328, 114364);

                f_28001_114328_114363(symbol1, symbol2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 112318, 114375);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_112624_112649(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112624, 112649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_112827_112875(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112827, 112875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_112827_112895(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112827, 112895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_113027_113075(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113027, 113075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_113027_113095(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113027, 113095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_113227_113274(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113227, 113274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_113227_113294(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113227, 113294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_113521_113572(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113521, 113572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_113521_113592(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113521, 113592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_112664_113607(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 112664, 113607);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_113633_113649(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 113633, 113649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_113679_113706(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113679, 113706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_113734_113748(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113734, 113748);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_113734_113766(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113734, 113766);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_113734_113822(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113734, 113822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_113734_113831(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113734, 113831);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_113860_113879(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113860, 113879);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_113860_113922(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113860, 113922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_113860_113931(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113860, 113931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_28001_113960_113990(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                declaration)
                {
                    var return_v = semanticModel.GetDeclaredSymbol(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 113960, 113990);
                    return return_v;
                }


                string
                f_28001_114042_114071(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114042, 114071);
                    return return_v;
                }


                bool
                f_28001_114005_114072(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114005, 114072);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_114098_114122(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114098, 114122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_114098_114170(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114098, 114170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_114199_114222(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetSymbolInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114199, 114222);
                    return return_v;
                }


                string
                f_28001_114281_114310(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114281, 114310);
                    return return_v;
                }


                bool
                f_28001_114244_114311(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114244, 114311);
                    return return_v;
                }


                bool
                f_28001_114328_114363(Microsoft.CodeAnalysis.ISymbol?
                expected, Microsoft.CodeAnalysis.ISymbol?
                actual)
                {
                    var return_v = CustomAssert.Same((object?)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114328, 114363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 112318, 114375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 112318, 114375);
            }
        }

        [Fact, WorkItem(7520, "https://github.com/dotnet/roslyn/issues/7520")]
        public void ImplicitDelegateCreationWithIncompleteLambda()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 114387, 116220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 114550, 114668);

                var
                source =
                @"
using System;
class C
{
    public void F()
    {
        Action<int> x = i => i.
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 114682, 114719);

                var
                comp = f_28001_114693_114718(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 114733, 115453);

                f_28001_114733_115452(comp, f_28001_114888_114956(f_28001_114888_114936(ErrorCode.ERR_IdentifierExpected, ""), 7, 32), f_28001_115080_115147(f_28001_115080_115127(ErrorCode.ERR_SemicolonExpected, ""), 7, 32), f_28001_115366_115437(f_28001_115366_115417(ErrorCode.ERR_IllegalStatement, @"i.
"), 7, 30));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 115467, 115498);

                var
                tree = f_28001_115478_115494(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 115512, 115552);

                var
                model = f_28001_115524_115551(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 115566, 115677);

                var
                lambda = f_28001_115579_115676(f_28001_115579_115667(f_28001_115579_115611(f_28001_115579_115593(tree)), n => n.IsKind(SyntaxKind.SimpleLambdaExpression)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 115693, 115777);

                var
                param = f_28001_115705_115776(f_28001_115705_115767(f_28001_115705_115724(lambda), n => n.IsKind(SyntaxKind.Parameter)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 115791, 115836);

                var
                symbol1 = f_28001_115805_115835(model, param)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 115850, 115918);

                f_28001_115850_115917("System.Int32 i", f_28001_115887_115916(symbol1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 115934, 116016);

                var
                id = f_28001_115943_116015(f_28001_115943_115967(lambda), n => n.IsKind(SyntaxKind.IdentifierName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 116030, 116075);

                var
                symbol2 = f_28001_116044_116067(model, id).Symbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 116089, 116157);

                f_28001_116089_116156("System.Int32 i", f_28001_116126_116155(symbol2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 116173, 116209);

                f_28001_116173_116208(symbol1, symbol2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 114387, 116220);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_114693_114718(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114693, 114718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_114888_114936(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114888, 114936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_114888_114956(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114888, 114956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_115080_115127(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115080, 115127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_115080_115147(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115080, 115147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_115366_115417(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115366, 115417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_115366_115437(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115366, 115437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_114733_115452(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 114733, 115452);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_115478_115494(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 115478, 115494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_115524_115551(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115524, 115551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_115579_115593(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115579, 115593);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_115579_115611(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115579, 115611);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_115579_115667(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115579, 115667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_115579_115676(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115579, 115676);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_115705_115724(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.ChildNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115705, 115724);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_115705_115767(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115705, 115767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_115705_115776(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115705, 115776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_28001_115805_115835(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                declaration)
                {
                    var return_v = semanticModel.GetDeclaredSymbol(declaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115805, 115835);
                    return return_v;
                }


                string
                f_28001_115887_115916(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115887, 115916);
                    return return_v;
                }


                bool
                f_28001_115850_115917(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115850, 115917);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_115943_115967(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115943, 115967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_115943_116015(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 115943, 116015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_116044_116067(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetSymbolInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 116044, 116067);
                    return return_v;
                }


                string
                f_28001_116126_116155(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 116126, 116155);
                    return return_v;
                }


                bool
                f_28001_116089_116156(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 116089, 116156);
                    return return_v;
                }


                bool
                f_28001_116173_116208(Microsoft.CodeAnalysis.ISymbol?
                expected, Microsoft.CodeAnalysis.ISymbol?
                actual)
                {
                    var return_v = CustomAssert.Same((object?)expected, (object?)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 116173, 116208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 114387, 116220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 114387, 116220);
            }
        }

        [Fact, WorkItem(5128, "https://github.com/dotnet/roslyn/issues/5128")]
        public void GetMemberGroupInsideIncompleteLambda_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 116232, 119854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 116390, 117335);

                var
                source =
                @"
using System;
using System.Threading.Tasks;

public delegate Task RequestDelegate(HttpContext context);

public class AuthenticationResult { }

public abstract class AuthenticationManager
{
    public abstract Task<AuthenticationResult> AuthenticateAsync(string authenticationScheme);
}

public abstract class HttpContext
{
    public abstract AuthenticationManager Authentication { get; }
}

interface IApplicationBuilder
{
    IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
}

static class IApplicationBuilderExtensions
{
    public static IApplicationBuilder Use(this IApplicationBuilder app, Func<HttpContext, Func<Task>, Task> middleware)
    {
        return app;
    }
}

class C
{
    void M(IApplicationBuilder app)
    {
        app.Use(async (ctx, next) =>
        {
            await ctx.Authentication.AuthenticateAsync();
        });
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 117349, 117441);

                var
                comp = f_28001_117360_117440(source, new[] { f_28001_117408_117437() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 117457, 117936);

                f_28001_117457_117935(
                            comp, f_28001_117736_117916(f_28001_117736_117895(f_28001_117736_117806(ErrorCode.ERR_NoCorrespondingArgument, "AuthenticateAsync"), "authenticationScheme", "AuthenticationManager.AuthenticateAsync(string)"), 38, 38));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 117952, 117983);

                var
                tree = f_28001_117963_117979(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 117997, 118037);

                var
                model = f_28001_118009_118036(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 118053, 118221);

                var
                node1 = f_28001_118065_118220(f_28001_118065_118213(f_28001_118065_118204(f_28001_118065_118097(f_28001_118065_118079(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "Use")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 118235, 118283);

                f_28001_118235_118282("app.Use", f_28001_118265_118281(node1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 118297, 118338);

                var
                group1 = f_28001_118310_118337(model, node1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 118352, 118389);

                f_28001_118352_118388(2, group1.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 118403, 118560);

                f_28001_118403_118559("IApplicationBuilder IApplicationBuilder.Use(System.Func<RequestDelegate, RequestDelegate> middleware)", f_28001_118527_118558(group1[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 118574, 118807);

                f_28001_118574_118806("IApplicationBuilder IApplicationBuilder.Use(System.Func<HttpContext, System.Func<System.Threading.Tasks.Task>, System.Threading.Tasks.Task> middleware)", f_28001_118774_118805(group1[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 118823, 118868);

                var
                symbolInfo1 = f_28001_118841_118867(model, node1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 118882, 118920);

                f_28001_118882_118919(symbolInfo1.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 118934, 118993);

                f_28001_118934_118992(1, symbolInfo1.CandidateSymbols.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 119007, 119192);

                f_28001_119007_119191("IApplicationBuilder IApplicationBuilder.Use(System.Func<RequestDelegate, RequestDelegate> middleware)", f_28001_119131_119190(symbolInfo1.CandidateSymbols.Single()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 119206, 119297);

                f_28001_119206_119296(CandidateReason.OverloadResolutionFailure, symbolInfo1.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 119313, 119494);

                var
                node = f_28001_119324_119493(f_28001_119324_119486(f_28001_119324_119477(f_28001_119324_119356(f_28001_119324_119338(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "AuthenticateAsync")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 119510, 119586);

                f_28001_119510_119585("ctx.Authentication.AuthenticateAsync", f_28001_119569_119584(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 119602, 119641);

                var
                group = f_28001_119614_119640(model, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 119657, 119843);

                f_28001_119657_119842("System.Threading.Tasks.Task<AuthenticationResult> AuthenticationManager.AuthenticateAsync(System.String authenticationScheme)", f_28001_119805_119841(group.Single()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 116232, 119854);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_28001_117408_117437()
                {
                    var return_v = TestMetadata.Net40.SystemCore;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 117408, 117437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_117360_117440(string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 117360, 117440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_117736_117806(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 117736, 117806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_117736_117895(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 117736, 117895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_117736_117916(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 117736, 117916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_117457_117935(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 117457, 117935);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_117963_117979(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 117963, 117979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_118009_118036(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118009, 118036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_118065_118079(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118065, 118079);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_118065_118097(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118065, 118097);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_118065_118204(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118065, 118204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_118065_118213(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118065, 118213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_118065_118220(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 118065, 118220);
                    return return_v;
                }


                string
                f_28001_118265_118281(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118265, 118281);
                    return return_v;
                }


                bool
                f_28001_118235_118282(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118235, 118282);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_118310_118337(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberGroup(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118310, 118337);
                    return return_v;
                }


                bool
                f_28001_118352_118388(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118352, 118388);
                    return return_v;
                }


                string
                f_28001_118527_118558(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118527, 118558);
                    return return_v;
                }


                bool
                f_28001_118403_118559(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118403, 118559);
                    return return_v;
                }


                string
                f_28001_118774_118805(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118774, 118805);
                    return return_v;
                }


                bool
                f_28001_118574_118806(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118574, 118806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_118841_118867(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetSymbolInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118841, 118867);
                    return return_v;
                }


                bool
                f_28001_118882_118919(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118882, 118919);
                    return return_v;
                }


                bool
                f_28001_118934_118992(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 118934, 118992);
                    return return_v;
                }


                string
                f_28001_119131_119190(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119131, 119190);
                    return return_v;
                }


                bool
                f_28001_119007_119191(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119007, 119191);
                    return return_v;
                }


                bool
                f_28001_119206_119296(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119206, 119296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_119324_119338(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119324, 119338);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_119324_119356(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119324, 119356);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_119324_119477(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119324, 119477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_119324_119486(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119324, 119486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_119324_119493(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 119324, 119493);
                    return return_v;
                }


                string
                f_28001_119569_119584(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119569, 119584);
                    return return_v;
                }


                bool
                f_28001_119510_119585(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119510, 119585);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_119614_119640(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberGroup(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119614, 119640);
                    return return_v;
                }


                string
                f_28001_119805_119841(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119805, 119841);
                    return return_v;
                }


                bool
                f_28001_119657_119842(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 119657, 119842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 116232, 119854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 116232, 119854);
            }
        }

        [Fact, WorkItem(5128, "https://github.com/dotnet/roslyn/issues/5128")]
        public void GetMemberGroupInsideIncompleteLambda_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 119866, 123538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 120024, 120969);

                var
                source =
                @"
using System;
using System.Threading.Tasks;

public delegate Task RequestDelegate(HttpContext context);

public class AuthenticationResult { }

public abstract class AuthenticationManager
{
    public abstract Task<AuthenticationResult> AuthenticateAsync(string authenticationScheme);
}

public abstract class HttpContext
{
    public abstract AuthenticationManager Authentication { get; }
}

interface IApplicationBuilder
{
    IApplicationBuilder Use(Func<HttpContext, Func<Task>, Task> middleware);
}

static class IApplicationBuilderExtensions
{
    public static IApplicationBuilder Use(this IApplicationBuilder app, Func<RequestDelegate, RequestDelegate> middleware)
    {
        return app;
    }
}

class C
{
    void M(IApplicationBuilder app)
    {
        app.Use(async (ctx, next) =>
        {
            await ctx.Authentication.AuthenticateAsync();
        });
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 120983, 121075);

                var
                comp = f_28001_120994_121074(source, new[] { f_28001_121042_121071() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 121091, 121570);

                f_28001_121091_121569(
                            comp, f_28001_121370_121550(f_28001_121370_121529(f_28001_121370_121440(ErrorCode.ERR_NoCorrespondingArgument, "AuthenticateAsync"), "authenticationScheme", "AuthenticationManager.AuthenticateAsync(string)"), 38, 38));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 121586, 121617);

                var
                tree = f_28001_121597_121613(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 121631, 121671);

                var
                model = f_28001_121643_121670(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 121687, 121855);

                var
                node1 = f_28001_121699_121854(f_28001_121699_121847(f_28001_121699_121838(f_28001_121699_121731(f_28001_121699_121713(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "Use")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 121869, 121917);

                f_28001_121869_121916("app.Use", f_28001_121899_121915(node1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 121931, 121972);

                var
                group1 = f_28001_121944_121971(model, node1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 121986, 122023);

                f_28001_121986_122022(2, group1.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 122037, 122270);

                f_28001_122037_122269("IApplicationBuilder IApplicationBuilder.Use(System.Func<HttpContext, System.Func<System.Threading.Tasks.Task>, System.Threading.Tasks.Task> middleware)", f_28001_122237_122268(group1[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 122284, 122441);

                f_28001_122284_122440("IApplicationBuilder IApplicationBuilder.Use(System.Func<RequestDelegate, RequestDelegate> middleware)", f_28001_122408_122439(group1[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 122457, 122502);

                var
                symbolInfo1 = f_28001_122475_122501(model, node1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 122516, 122554);

                f_28001_122516_122553(symbolInfo1.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 122568, 122627);

                f_28001_122568_122626(1, symbolInfo1.CandidateSymbols.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 122641, 122876);

                f_28001_122641_122875("IApplicationBuilder IApplicationBuilder.Use(System.Func<HttpContext, System.Func<System.Threading.Tasks.Task>, System.Threading.Tasks.Task> middleware)", f_28001_122815_122874(symbolInfo1.CandidateSymbols.Single()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 122890, 122981);

                f_28001_122890_122980(CandidateReason.OverloadResolutionFailure, symbolInfo1.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 122997, 123178);

                var
                node = f_28001_123008_123177(f_28001_123008_123170(f_28001_123008_123161(f_28001_123008_123040(f_28001_123008_123022(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "AuthenticateAsync")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 123194, 123270);

                f_28001_123194_123269("ctx.Authentication.AuthenticateAsync", f_28001_123253_123268(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 123286, 123325);

                var
                group = f_28001_123298_123324(model, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 123341, 123527);

                f_28001_123341_123526("System.Threading.Tasks.Task<AuthenticationResult> AuthenticationManager.AuthenticateAsync(System.String authenticationScheme)", f_28001_123489_123525(group.Single()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 119866, 123538);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_28001_121042_121071()
                {
                    var return_v = TestMetadata.Net40.SystemCore;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 121042, 121071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_120994_121074(string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 120994, 121074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_121370_121440(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121370, 121440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_121370_121529(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121370, 121529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_121370_121550(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121370, 121550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_121091_121569(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121091, 121569);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_121597_121613(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 121597, 121613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_121643_121670(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121643, 121670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_121699_121713(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121699, 121713);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_121699_121731(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121699, 121731);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_121699_121838(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121699, 121838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_121699_121847(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121699, 121847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_121699_121854(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 121699, 121854);
                    return return_v;
                }


                string
                f_28001_121899_121915(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121899, 121915);
                    return return_v;
                }


                bool
                f_28001_121869_121916(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121869, 121916);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_121944_121971(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberGroup(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121944, 121971);
                    return return_v;
                }


                bool
                f_28001_121986_122022(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 121986, 122022);
                    return return_v;
                }


                string
                f_28001_122237_122268(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122237, 122268);
                    return return_v;
                }


                bool
                f_28001_122037_122269(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122037, 122269);
                    return return_v;
                }


                string
                f_28001_122408_122439(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122408, 122439);
                    return return_v;
                }


                bool
                f_28001_122284_122440(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122284, 122440);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_122475_122501(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetSymbolInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122475, 122501);
                    return return_v;
                }


                bool
                f_28001_122516_122553(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122516, 122553);
                    return return_v;
                }


                bool
                f_28001_122568_122626(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122568, 122626);
                    return return_v;
                }


                string
                f_28001_122815_122874(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122815, 122874);
                    return return_v;
                }


                bool
                f_28001_122641_122875(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122641, 122875);
                    return return_v;
                }


                bool
                f_28001_122890_122980(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 122890, 122980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_123008_123022(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 123008, 123022);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_123008_123040(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 123008, 123040);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_123008_123161(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 123008, 123161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_123008_123170(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 123008, 123170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_123008_123177(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 123008, 123177);
                    return return_v;
                }


                string
                f_28001_123253_123268(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 123253, 123268);
                    return return_v;
                }


                bool
                f_28001_123194_123269(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 123194, 123269);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_123298_123324(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberGroup(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 123298, 123324);
                    return return_v;
                }


                string
                f_28001_123489_123525(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 123489, 123525);
                    return return_v;
                }


                bool
                f_28001_123341_123526(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 123341, 123526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 119866, 123538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 119866, 123538);
            }
        }

        [Fact, WorkItem(5128, "https://github.com/dotnet/roslyn/issues/5128")]
        public void GetMemberGroupInsideIncompleteLambda_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 123550, 127224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 123708, 124523);

                var
                source =
                @"
using System;
using System.Threading.Tasks;

public delegate Task RequestDelegate(HttpContext context);

public class AuthenticationResult { }

public abstract class AuthenticationManager
{
    public abstract Task<AuthenticationResult> AuthenticateAsync(string authenticationScheme);
}

public abstract class HttpContext
{
    public abstract AuthenticationManager Authentication { get; }
}

interface IApplicationBuilder
{
    IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
    IApplicationBuilder Use(Func<HttpContext, Func<Task>, Task> middleware);
}

class C
{
    void M(IApplicationBuilder app)
    {
        app.Use(async (ctx, next) =>
        {
            await ctx.Authentication.AuthenticateAsync();
        });
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 124537, 124574);

                var
                comp = f_28001_124548_124573(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 124590, 125069);

                f_28001_124590_125068(
                            comp, f_28001_124869_125049(f_28001_124869_125028(f_28001_124869_124939(ErrorCode.ERR_NoCorrespondingArgument, "AuthenticateAsync"), "authenticationScheme", "AuthenticationManager.AuthenticateAsync(string)"), 31, 38));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 125085, 125116);

                var
                tree = f_28001_125096_125112(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 125130, 125170);

                var
                model = f_28001_125142_125169(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 125186, 125354);

                var
                node1 = f_28001_125198_125353(f_28001_125198_125346(f_28001_125198_125337(f_28001_125198_125230(f_28001_125198_125212(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "Use")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 125368, 125416);

                f_28001_125368_125415("app.Use", f_28001_125398_125414(node1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 125430, 125471);

                var
                group1 = f_28001_125443_125470(model, node1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 125485, 125522);

                f_28001_125485_125521(2, group1.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 125536, 125693);

                f_28001_125536_125692("IApplicationBuilder IApplicationBuilder.Use(System.Func<RequestDelegate, RequestDelegate> middleware)", f_28001_125660_125691(group1[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 125707, 125940);

                f_28001_125707_125939("IApplicationBuilder IApplicationBuilder.Use(System.Func<HttpContext, System.Func<System.Threading.Tasks.Task>, System.Threading.Tasks.Task> middleware)", f_28001_125907_125938(group1[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 125956, 126001);

                var
                symbolInfo1 = f_28001_125974_126000(model, node1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 126015, 126053);

                f_28001_126015_126052(symbolInfo1.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 126067, 126126);

                f_28001_126067_126125(2, symbolInfo1.CandidateSymbols.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 126140, 126319);

                f_28001_126140_126318("IApplicationBuilder IApplicationBuilder.Use(System.Func<RequestDelegate, RequestDelegate> middleware)", f_28001_126264_126317(symbolInfo1.CandidateSymbols[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 126333, 126562);

                f_28001_126333_126561("IApplicationBuilder IApplicationBuilder.Use(System.Func<HttpContext, System.Func<System.Threading.Tasks.Task>, System.Threading.Tasks.Task> middleware)", f_28001_126507_126560(symbolInfo1.CandidateSymbols[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 126576, 126667);

                f_28001_126576_126666(CandidateReason.OverloadResolutionFailure, symbolInfo1.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 126683, 126864);

                var
                node = f_28001_126694_126863(f_28001_126694_126856(f_28001_126694_126847(f_28001_126694_126726(f_28001_126694_126708(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "AuthenticateAsync")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 126880, 126956);

                f_28001_126880_126955("ctx.Authentication.AuthenticateAsync", f_28001_126939_126954(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 126972, 127011);

                var
                group = f_28001_126984_127010(model, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 127027, 127213);

                f_28001_127027_127212("System.Threading.Tasks.Task<AuthenticationResult> AuthenticationManager.AuthenticateAsync(System.String authenticationScheme)", f_28001_127175_127211(group.Single()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 123550, 127224);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_124548_124573(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 124548, 124573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_124869_124939(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 124869, 124939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_124869_125028(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 124869, 125028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_124869_125049(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 124869, 125049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_124590_125068(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 124590, 125068);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_125096_125112(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 125096, 125112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_125142_125169(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125142, 125169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_125198_125212(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125198, 125212);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_125198_125230(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125198, 125230);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_125198_125337(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125198, 125337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_125198_125346(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125198, 125346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_125198_125353(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 125198, 125353);
                    return return_v;
                }


                string
                f_28001_125398_125414(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125398, 125414);
                    return return_v;
                }


                bool
                f_28001_125368_125415(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125368, 125415);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_125443_125470(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberGroup(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125443, 125470);
                    return return_v;
                }


                bool
                f_28001_125485_125521(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125485, 125521);
                    return return_v;
                }


                string
                f_28001_125660_125691(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125660, 125691);
                    return return_v;
                }


                bool
                f_28001_125536_125692(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125536, 125692);
                    return return_v;
                }


                string
                f_28001_125907_125938(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125907, 125938);
                    return return_v;
                }


                bool
                f_28001_125707_125939(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125707, 125939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_125974_126000(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetSymbolInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 125974, 126000);
                    return return_v;
                }


                bool
                f_28001_126015_126052(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126015, 126052);
                    return return_v;
                }


                bool
                f_28001_126067_126125(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126067, 126125);
                    return return_v;
                }


                string
                f_28001_126264_126317(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126264, 126317);
                    return return_v;
                }


                bool
                f_28001_126140_126318(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126140, 126318);
                    return return_v;
                }


                string
                f_28001_126507_126560(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126507, 126560);
                    return return_v;
                }


                bool
                f_28001_126333_126561(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126333, 126561);
                    return return_v;
                }


                bool
                f_28001_126576_126666(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126576, 126666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_126694_126708(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126694, 126708);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_126694_126726(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126694, 126726);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_126694_126847(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126694, 126847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_126694_126856(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126694, 126856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_126694_126863(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 126694, 126863);
                    return return_v;
                }


                string
                f_28001_126939_126954(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126939, 126954);
                    return return_v;
                }


                bool
                f_28001_126880_126955(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126880, 126955);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_126984_127010(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberGroup(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 126984, 127010);
                    return return_v;
                }


                string
                f_28001_127175_127211(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 127175, 127211);
                    return return_v;
                }


                bool
                f_28001_127027_127212(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 127027, 127212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 123550, 127224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 123550, 127224);
            }
        }

        [Fact, WorkItem(5128, "https://github.com/dotnet/roslyn/issues/5128")]
        public void GetMemberGroupInsideIncompleteLambda_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 127236, 131175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 127394, 128419);

                var
                source =
                @"
using System;
using System.Threading.Tasks;

public delegate Task RequestDelegate(HttpContext context);

public class AuthenticationResult { }

public abstract class AuthenticationManager
{
    public abstract Task<AuthenticationResult> AuthenticateAsync(string authenticationScheme);
}

public abstract class HttpContext
{
    public abstract AuthenticationManager Authentication { get; }
}

interface IApplicationBuilder
{
}

static class IApplicationBuilderExtensions
{
    public static IApplicationBuilder Use(this IApplicationBuilder app, Func<RequestDelegate, RequestDelegate> middleware)
    {
        return app;
    }

    public static IApplicationBuilder Use(this IApplicationBuilder app, Func<HttpContext, Func<Task>, Task> middleware)
    {
        return app;
    }
}

class C
{
    void M(IApplicationBuilder app)
    {
        app.Use(async (ctx, next) =>
        {
            await ctx.Authentication.AuthenticateAsync();
        });
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 128433, 128525);

                var
                comp = f_28001_128444_128524(source, new[] { f_28001_128492_128521() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 128541, 129020);

                f_28001_128541_129019(
                            comp, f_28001_128820_129000(f_28001_128820_128979(f_28001_128820_128890(ErrorCode.ERR_NoCorrespondingArgument, "AuthenticateAsync"), "authenticationScheme", "AuthenticationManager.AuthenticateAsync(string)"), 42, 38));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129036, 129067);

                var
                tree = f_28001_129047_129063(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129081, 129121);

                var
                model = f_28001_129093_129120(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129137, 129305);

                var
                node1 = f_28001_129149_129304(f_28001_129149_129297(f_28001_129149_129288(f_28001_129149_129181(f_28001_129149_129163(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "Use")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129319, 129367);

                f_28001_129319_129366("app.Use", f_28001_129349_129365(node1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129381, 129422);

                var
                group1 = f_28001_129394_129421(model, node1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129436, 129473);

                f_28001_129436_129472(2, group1.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129487, 129644);

                f_28001_129487_129643("IApplicationBuilder IApplicationBuilder.Use(System.Func<RequestDelegate, RequestDelegate> middleware)", f_28001_129611_129642(group1[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129658, 129891);

                f_28001_129658_129890("IApplicationBuilder IApplicationBuilder.Use(System.Func<HttpContext, System.Func<System.Threading.Tasks.Task>, System.Threading.Tasks.Task> middleware)", f_28001_129858_129889(group1[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129907, 129952);

                var
                symbolInfo1 = f_28001_129925_129951(model, node1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 129966, 130004);

                f_28001_129966_130003(symbolInfo1.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 130018, 130077);

                f_28001_130018_130076(2, symbolInfo1.CandidateSymbols.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 130091, 130270);

                f_28001_130091_130269("IApplicationBuilder IApplicationBuilder.Use(System.Func<RequestDelegate, RequestDelegate> middleware)", f_28001_130215_130268(symbolInfo1.CandidateSymbols[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 130284, 130513);

                f_28001_130284_130512("IApplicationBuilder IApplicationBuilder.Use(System.Func<HttpContext, System.Func<System.Threading.Tasks.Task>, System.Threading.Tasks.Task> middleware)", f_28001_130458_130511(symbolInfo1.CandidateSymbols[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 130527, 130618);

                f_28001_130527_130617(CandidateReason.OverloadResolutionFailure, symbolInfo1.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 130634, 130815);

                var
                node = f_28001_130645_130814(f_28001_130645_130807(f_28001_130645_130798(f_28001_130645_130677(f_28001_130645_130659(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "AuthenticateAsync")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 130831, 130907);

                f_28001_130831_130906("ctx.Authentication.AuthenticateAsync", f_28001_130890_130905(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 130923, 130962);

                var
                group = f_28001_130935_130961(model, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 130978, 131164);

                f_28001_130978_131163("System.Threading.Tasks.Task<AuthenticationResult> AuthenticationManager.AuthenticateAsync(System.String authenticationScheme)", f_28001_131126_131162(group.Single()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 127236, 131175);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_28001_128492_128521()
                {
                    var return_v = TestMetadata.Net40.SystemCore;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 128492, 128521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_128444_128524(string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 128444, 128524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_128820_128890(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 128820, 128890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_128820_128979(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 128820, 128979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_128820_129000(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 128820, 129000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_128541_129019(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 128541, 129019);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_129047_129063(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 129047, 129063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_129093_129120(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129093, 129120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_129149_129163(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129149, 129163);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_129149_129181(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129149, 129181);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_129149_129288(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129149, 129288);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_129149_129297(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129149, 129297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_129149_129304(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 129149, 129304);
                    return return_v;
                }


                string
                f_28001_129349_129365(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129349, 129365);
                    return return_v;
                }


                bool
                f_28001_129319_129366(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129319, 129366);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_129394_129421(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberGroup(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129394, 129421);
                    return return_v;
                }


                bool
                f_28001_129436_129472(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129436, 129472);
                    return return_v;
                }


                string
                f_28001_129611_129642(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129611, 129642);
                    return return_v;
                }


                bool
                f_28001_129487_129643(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129487, 129643);
                    return return_v;
                }


                string
                f_28001_129858_129889(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129858, 129889);
                    return return_v;
                }


                bool
                f_28001_129658_129890(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129658, 129890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_129925_129951(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetSymbolInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129925, 129951);
                    return return_v;
                }


                bool
                f_28001_129966_130003(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 129966, 130003);
                    return return_v;
                }


                bool
                f_28001_130018_130076(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130018, 130076);
                    return return_v;
                }


                string
                f_28001_130215_130268(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130215, 130268);
                    return return_v;
                }


                bool
                f_28001_130091_130269(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130091, 130269);
                    return return_v;
                }


                string
                f_28001_130458_130511(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130458, 130511);
                    return return_v;
                }


                bool
                f_28001_130284_130512(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130284, 130512);
                    return return_v;
                }


                bool
                f_28001_130527_130617(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130527, 130617);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_130645_130659(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130645, 130659);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_130645_130677(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130645, 130677);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_130645_130798(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130645, 130798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_130645_130807(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130645, 130807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_130645_130814(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 130645, 130814);
                    return return_v;
                }


                string
                f_28001_130890_130905(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130890, 130905);
                    return return_v;
                }


                bool
                f_28001_130831_130906(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130831, 130906);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_130935_130961(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetMemberGroup(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130935, 130961);
                    return return_v;
                }


                string
                f_28001_131126_131162(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 131126, 131162);
                    return return_v;
                }


                bool
                f_28001_130978_131163(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 130978, 131163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 127236, 131175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 127236, 131175);
            }
        }

        [Fact, WorkItem(7101, "https://github.com/dotnet/roslyn/issues/7101")]
        public void UsingStatic_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 131187, 134982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 131320, 132318);

                var
                source =
                @"
using System;
using static ClassWithNonStaticMethod;
using static Extension1;

class Program
{
    static void Main(string[] args)
    {
        var instance = new Program();
        instance.NonStaticMethod();
    }

    private void NonStaticMethod()
    {
        MathMin(0, 1);
        MathMax(0, 1);
        MathMax2(0, 1);
        
        int x;
        x = F1;
        x = F2;

        x.MathMax2(3);
    }
}

class ClassWithNonStaticMethod
{
    public static int MathMax(int a, int b)
    {
        return Math.Max(a, b);
    }

    public int MathMin(int a, int b)
    {
        return Math.Min(a, b);
    }

    public int F2 = 0;
}

static class Extension1
{
    public static int MathMax2(this int a, int b)
    {
        return Math.Max(a, b);
    }

    public static int F1 = 0;
}

static class Extension2
{
    public static int MathMax3(this int a, int b)
    {
        return Math.Max(a, b);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 132332, 132383);

                var
                comp = f_28001_132343_132382(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 132399, 133094);

                f_28001_132399_133093(
                            comp, f_28001_132546_132644(f_28001_132546_132624(f_28001_132546_132599(ErrorCode.ERR_NameNotInContext, "MathMin"), "MathMin"), 16, 9), f_28001_132771_132871(f_28001_132771_132851(f_28001_132771_132825(ErrorCode.ERR_NameNotInContext, "MathMax2"), "MathMax2"), 18, 9), f_28001_132985_133074(f_28001_132985_133053(f_28001_132985_133033(ErrorCode.ERR_NameNotInContext, "F2"), "F2"), 22, 13));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133110, 133141);

                var
                tree = f_28001_133121_133137(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133155, 133195);

                var
                model = f_28001_133167_133194(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133211, 133383);

                var
                node1 = f_28001_133223_133382(f_28001_133223_133375(f_28001_133223_133366(f_28001_133223_133255(f_28001_133223_133237(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "MathMin")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133397, 133451);

                f_28001_133397_133450("MathMin(0, 1)", f_28001_133433_133449(node1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133467, 133514);

                var
                names = f_28001_133479_133513(model, f_28001_133497_133512(node1))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133528, 133574);

                f_28001_133528_133573(f_28001_133547_133572(names, "MathMin"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133588, 133633);

                f_28001_133588_133632(f_28001_133606_133631(names, "MathMax"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133647, 133687);

                f_28001_133647_133686(f_28001_133665_133685(names, "F1"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133701, 133742);

                f_28001_133701_133741(f_28001_133720_133740(names, "F2"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133756, 133803);

                f_28001_133756_133802(f_28001_133775_133801(names, "MathMax2"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133817, 133864);

                f_28001_133817_133863(f_28001_133836_133862(names, "MathMax3"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133880, 133961);

                f_28001_133880_133960(f_28001_133898_133951(model, f_28001_133918_133933(node1), name: "MathMin").IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 133975, 134059);

                f_28001_133975_134058(1, f_28001_133997_134050(model, f_28001_134017_134032(node1), name: "MathMax").Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134073, 134152);

                f_28001_134073_134151(1, f_28001_134095_134143(model, f_28001_134115_134130(node1), name: "F1").Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134166, 134242);

                f_28001_134166_134241(f_28001_134184_134232(model, f_28001_134204_134219(node1), name: "F2").IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134256, 134338);

                f_28001_134256_134337(f_28001_134274_134328(model, f_28001_134294_134309(node1), name: "MathMax2").IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134352, 134434);

                f_28001_134352_134433(f_28001_134370_134424(model, f_28001_134390_134405(node1), name: "MathMax3").IsEmpty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134450, 134501);

                var
                symbols = f_28001_134464_134500(model, f_28001_134484_134499(node1))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134515, 134581);

                f_28001_134515_134580(f_28001_134534_134579(symbols.Where(s => s.Name == "MathMin")));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134595, 134660);

                f_28001_134595_134659(f_28001_134613_134658(symbols.Where(s => s.Name == "MathMax")));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134674, 134734);

                f_28001_134674_134733(f_28001_134692_134732(symbols.Where(s => s.Name == "F1")));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134748, 134809);

                f_28001_134748_134808(f_28001_134767_134807(symbols.Where(s => s.Name == "F2")));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134823, 134890);

                f_28001_134823_134889(f_28001_134842_134888(symbols.Where(s => s.Name == "MathMax2")));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 134904, 134971);

                f_28001_134904_134970(f_28001_134923_134969(symbols.Where(s => s.Name == "MathMax3")));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 131187, 134982);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_132343_132382(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132343, 132382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_132546_132599(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132546, 132599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_132546_132624(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132546, 132624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_132546_132644(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132546, 132644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_132771_132825(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132771, 132825);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_132771_132851(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132771, 132851);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_132771_132871(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132771, 132871);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_132985_133033(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132985, 133033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_132985_133053(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132985, 133053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_132985_133074(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132985, 133074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_132399_133093(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 132399, 133093);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_133121_133137(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 133121, 133137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_133167_133194(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133167, 133194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_133223_133237(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133223, 133237);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_133223_133255(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133223, 133255);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_133223_133366(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133223, 133366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_133223_133375(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133223, 133375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_133223_133382(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 133223, 133382);
                    return return_v;
                }


                string
                f_28001_133433_133449(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133433, 133449);
                    return return_v;
                }


                bool
                f_28001_133397_133450(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133397, 133450);
                    return return_v;
                }


                int
                f_28001_133497_133512(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 133497, 133512);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_28001_133479_133513(Microsoft.CodeAnalysis.SemanticModel
                model, int
                position)
                {
                    var return_v = model.LookupNames(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133479, 133513);
                    return return_v;
                }


                bool
                f_28001_133547_133572(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133547, 133572);
                    return return_v;
                }


                bool
                f_28001_133528_133573(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133528, 133573);
                    return return_v;
                }


                bool
                f_28001_133606_133631(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133606, 133631);
                    return return_v;
                }


                bool
                f_28001_133588_133632(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133588, 133632);
                    return return_v;
                }


                bool
                f_28001_133665_133685(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133665, 133685);
                    return return_v;
                }


                bool
                f_28001_133647_133686(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133647, 133686);
                    return return_v;
                }


                bool
                f_28001_133720_133740(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133720, 133740);
                    return return_v;
                }


                bool
                f_28001_133701_133741(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133701, 133741);
                    return return_v;
                }


                bool
                f_28001_133775_133801(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133775, 133801);
                    return return_v;
                }


                bool
                f_28001_133756_133802(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133756, 133802);
                    return return_v;
                }


                bool
                f_28001_133836_133862(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133836, 133862);
                    return return_v;
                }


                bool
                f_28001_133817_133863(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133817, 133863);
                    return return_v;
                }


                int
                f_28001_133918_133933(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 133918, 133933);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_133898_133951(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupSymbols(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133898, 133951);
                    return return_v;
                }


                bool
                f_28001_133880_133960(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133880, 133960);
                    return return_v;
                }


                int
                f_28001_134017_134032(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 134017, 134032);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_133997_134050(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupSymbols(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133997, 134050);
                    return return_v;
                }


                bool
                f_28001_133975_134058(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 133975, 134058);
                    return return_v;
                }


                int
                f_28001_134115_134130(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 134115, 134130);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_134095_134143(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupSymbols(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134095, 134143);
                    return return_v;
                }


                bool
                f_28001_134073_134151(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134073, 134151);
                    return return_v;
                }


                int
                f_28001_134204_134219(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 134204, 134219);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_134184_134232(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupSymbols(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134184, 134232);
                    return return_v;
                }


                bool
                f_28001_134166_134241(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134166, 134241);
                    return return_v;
                }


                int
                f_28001_134294_134309(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 134294, 134309);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_134274_134328(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupSymbols(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134274, 134328);
                    return return_v;
                }


                bool
                f_28001_134256_134337(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134256, 134337);
                    return return_v;
                }


                int
                f_28001_134390_134405(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 134390, 134405);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_134370_134424(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position, string
                name)
                {
                    var return_v = this_param.LookupSymbols(position, name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134370, 134424);
                    return return_v;
                }


                bool
                f_28001_134352_134433(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134352, 134433);
                    return return_v;
                }


                int
                f_28001_134484_134499(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SpanStart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 134484, 134499);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_28001_134464_134500(Microsoft.CodeAnalysis.SemanticModel
                this_param, int
                position)
                {
                    var return_v = this_param.LookupSymbols(position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134464, 134500);
                    return return_v;
                }


                bool
                f_28001_134534_134579(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134534, 134579);
                    return return_v;
                }


                bool
                f_28001_134515_134580(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134515, 134580);
                    return return_v;
                }


                bool
                f_28001_134613_134658(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134613, 134658);
                    return return_v;
                }


                bool
                f_28001_134595_134659(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134595, 134659);
                    return return_v;
                }


                bool
                f_28001_134692_134732(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134692, 134732);
                    return return_v;
                }


                bool
                f_28001_134674_134733(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134674, 134733);
                    return return_v;
                }


                bool
                f_28001_134767_134807(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134767, 134807);
                    return return_v;
                }


                bool
                f_28001_134748_134808(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134748, 134808);
                    return return_v;
                }


                bool
                f_28001_134842_134888(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134842, 134888);
                    return return_v;
                }


                bool
                f_28001_134823_134889(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134823, 134889);
                    return return_v;
                }


                bool
                f_28001_134923_134969(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                source)
                {
                    var return_v = source.Any<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134923, 134969);
                    return return_v;
                }


                bool
                f_28001_134904_134970(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 134904, 134970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 131187, 134982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 131187, 134982);
            }
        }

        [Fact, WorkItem(30726, "https://github.com/dotnet/roslyn/issues/30726")]
        public void UsingStaticGenericConstraint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 134994, 135952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 135143, 135247);

                var
                code = @"
using static Test<System.String>;

public static class Test<T> where T : struct { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 135261, 135941);

                f_28001_135261_135940(f_28001_135261_135298(code), f_28001_135460_135562(f_28001_135460_135543(ErrorCode.HDN_UnusedUsingDirective, "using static Test<System.String>;"), 2, 1), f_28001_135805_135939(f_28001_135805_135919(f_28001_135805_135879(ErrorCode.ERR_ValConstraintNotSatisfied, "Test<System.String>"), "Test<T>", "T", "string"), 2, 14));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 134994, 135952);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_135261_135298(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 135261, 135298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_135460_135543(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 135460, 135543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_135460_135562(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 135460, 135562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_135805_135879(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 135805, 135879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_135805_135919(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 135805, 135919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_135805_135939(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 135805, 135939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_135261_135940(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 135261, 135940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 134994, 135952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 134994, 135952);
            }
        }

        [Fact, WorkItem(30726, "https://github.com/dotnet/roslyn/issues/30726")]
        public void UsingStaticGenericConstraintNestedType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 135964, 136898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 136123, 136238);

                var
                code = @"
using static A<A<int>[]>.B;

class A<T> where T : class
{
    internal static class B { }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 136252, 136887);

                f_28001_136252_136886(f_28001_136252_136289(code), f_28001_136445_136541(f_28001_136445_136522(ErrorCode.HDN_UnusedUsingDirective, "using static A<A<int>[]>.B;"), 2, 1), f_28001_136763_136885(f_28001_136763_136865(f_28001_136763_136831(ErrorCode.ERR_RefConstraintNotSatisfied, "A<A<int>[]>.B"), "A<T>", "T", "int"), 2, 14));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 135964, 136898);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_136252_136289(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 136252, 136289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_136445_136522(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 136445, 136522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_136445_136541(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 136445, 136541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_136763_136831(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 136763, 136831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_136763_136865(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 136763, 136865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_136763_136885(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 136763, 136885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_136252_136886(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 136252, 136886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 135964, 136898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 135964, 136898);
            }
        }

        [Fact, WorkItem(30726, "https://github.com/dotnet/roslyn/issues/30726")]
        public void UsingStaticMultipleGenericConstraints()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 136910, 138211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 137068, 137174);

                var
                code = @"
using static A<int, string>;
static class A<T, U> where T : class where U : struct { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 137188, 138200);

                f_28001_137188_138199(f_28001_137188_137225(code), f_28001_137382_137479(f_28001_137382_137460(ErrorCode.HDN_UnusedUsingDirective, "using static A<int, string>;"), 2, 1), f_28001_137705_137831(f_28001_137705_137811(f_28001_137705_137774(ErrorCode.ERR_RefConstraintNotSatisfied, "A<int, string>"), "A<T, U>", "T", "int"), 2, 14), f_28001_138069_138198(f_28001_138069_138178(f_28001_138069_138138(ErrorCode.ERR_ValConstraintNotSatisfied, "A<int, string>"), "A<T, U>", "U", "string"), 2, 14));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 136910, 138211);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_137188_137225(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 137188, 137225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_137382_137460(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 137382, 137460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_137382_137479(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 137382, 137479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_137705_137774(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 137705, 137774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_137705_137811(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 137705, 137811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_137705_137831(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 137705, 137831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_138069_138138(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 138069, 138138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_138069_138178(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 138069, 138178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_138069_138198(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 138069, 138198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_137188_138199(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 137188, 138199);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 136910, 138211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 136910, 138211);
            }
        }

        [Fact, WorkItem(8234, "https://github.com/dotnet/roslyn/issues/8234")]
        public void EventAccessInTypeNameContext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 138223, 140361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 138370, 138682);

                var
                source =
                @"
class Program
{
    static void Main() {}

    event System.EventHandler E1;

    void Test(Program x)
    {
        System.Console.WriteLine();
        x.E1.E
        System.Console.WriteLine();
    }

    void Dummy()
    {
        E1 = null;
        var x = E1;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 138696, 138733);

                var
                comp = f_28001_138707_138732(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 138749, 139283);

                f_28001_138749_139282(
                            comp, f_28001_138852_138921(f_28001_138852_138900(ErrorCode.ERR_IdentifierExpected, ""), 11, 15), f_28001_138993_139061(f_28001_138993_139040(ErrorCode.ERR_SemicolonExpected, ""), 11, 15), f_28001_139163_139263(f_28001_139163_139243(f_28001_139163_139204(ErrorCode.ERR_BadSKknown, "x"), "x", "variable", "type"), 11, 9));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139299, 139330);

                var
                tree = f_28001_139310_139326(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139344, 139384);

                var
                model = f_28001_139356_139383(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139400, 139566);

                var
                node1 = f_28001_139412_139565(f_28001_139412_139558(f_28001_139412_139549(f_28001_139412_139444(f_28001_139412_139426(tree)), n => n.IsKind(SyntaxKind.IdentifierName) && ((IdentifierNameSyntax)n).Identifier.ValueText == "E")))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139580, 139627);

                f_28001_139580_139626("x.E1.E", f_28001_139609_139625(node1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139641, 139700);

                f_28001_139641_139699(SyntaxKind.QualifiedName, f_28001_139686_139698(node1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139716, 139762);

                var
                node2 = f_28001_139728_139761(((QualifiedNameSyntax)node1))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139776, 139821);

                f_28001_139776_139820("x.E1", f_28001_139803_139819(node2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139837, 139882);

                var
                symbolInfo2 = f_28001_139855_139881(model, node2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139896, 139934);

                f_28001_139896_139933(symbolInfo2.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 139948, 140068);

                f_28001_139948_140067("event System.EventHandler Program.E1", f_28001_140007_140066(symbolInfo2.CandidateSymbols.Single()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 140082, 140167);

                f_28001_140082_140166(CandidateReason.NotATypeOrNamespace, symbolInfo2.CandidateReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 140183, 140228);

                var
                symbolInfo1 = f_28001_140201_140227(model, node1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 140242, 140280);

                f_28001_140242_140279(symbolInfo1.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 140294, 140350);

                f_28001_140294_140349(symbolInfo1.CandidateSymbols.IsEmpty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 138223, 140361);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_138707_138732(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 138707, 138732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_138852_138900(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 138852, 138900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_138852_138921(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 138852, 138921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_138993_139040(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 138993, 139040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_138993_139061(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 138993, 139061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_139163_139204(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139163, 139204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_139163_139243(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139163, 139243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_139163_139263(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139163, 139263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_138749_139282(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 138749, 139282);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_139310_139326(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 139310, 139326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_139356_139383(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139356, 139383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_139412_139426(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139412, 139426);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_139412_139444(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139412, 139444);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_139412_139549(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.SyntaxNode>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139412, 139549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_139412_139558(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139412, 139558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_28001_139412_139565(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 139412, 139565);
                    return return_v;
                }


                string
                f_28001_139609_139625(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139609, 139625);
                    return return_v;
                }


                bool
                f_28001_139580_139626(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139580, 139626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_28001_139686_139698(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139686, 139698);
                    return return_v;
                }


                bool
                f_28001_139641_139699(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                expected, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139641, 139699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                f_28001_139728_139761(Microsoft.CodeAnalysis.CSharp.Syntax.QualifiedNameSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 139728, 139761);
                    return return_v;
                }


                string
                f_28001_139803_139819(Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139803, 139819);
                    return return_v;
                }


                bool
                f_28001_139776_139820(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139776, 139820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_139855_139881(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.NameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139855, 139881);
                    return return_v;
                }


                bool
                f_28001_139896_139933(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139896, 139933);
                    return return_v;
                }


                string
                f_28001_140007_140066(Microsoft.CodeAnalysis.ISymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 140007, 140066);
                    return return_v;
                }


                bool
                f_28001_139948_140067(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 139948, 140067);
                    return return_v;
                }


                bool
                f_28001_140082_140166(Microsoft.CodeAnalysis.CandidateReason
                expected, Microsoft.CodeAnalysis.CandidateReason
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 140082, 140166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_140201_140227(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = this_param.GetSymbolInfo(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 140201, 140227);
                    return return_v;
                }


                bool
                f_28001_140242_140279(Microsoft.CodeAnalysis.ISymbol?
                @object)
                {
                    var return_v = CustomAssert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 140242, 140279);
                    return return_v;
                }


                bool
                f_28001_140294_140349(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 140294, 140349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 138223, 140361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 138223, 140361);
            }
        }

        [Fact, WorkItem(13617, "https://github.com/dotnet/roslyn/issues/13617")]
        public void MissingTypeArgumentInGenericExtensionMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 140373, 154083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 140537, 142426);

                var
                source =
                @"
public static class FooExtensions
{
    public static object ExtensionMethod0(this object obj) => default(object);
    public static T ExtensionMethod1<T>(this object obj) => default(T);
    public static T1 ExtensionMethod2<T1, T2>(this object obj) => default(T1);
}

public class Class1
{
    public void Test()
    {
        var omittedArg0 = ""string literal"".ExtensionMethod0<>();
        var omittedArg1 = ""string literal"".ExtensionMethod1<>();
        var omittedArg2 = ""string literal"".ExtensionMethod2<>();

        var omittedArgFunc0 = ""string literal"".ExtensionMethod0<>;
        var omittedArgFunc1 = ""string literal"".ExtensionMethod1<>;
        var omittedArgFunc2 = ""string literal"".ExtensionMethod2<>;

        var moreArgs0 = ""string literal"".ExtensionMethod0<int>();
        var moreArgs1 = ""string literal"".ExtensionMethod1<int, bool>();
        var moreArgs2 = ""string literal"".ExtensionMethod2<int, bool, string>();

        var lessArgs1 = ""string literal"".ExtensionMethod1();
        var lessArgs2 = ""string literal"".ExtensionMethod2<int>();

        var nonExistingMethod0 = ""string literal"".ExtensionMethodNotFound0();
        var nonExistingMethod1 = ""string literal"".ExtensionMethodNotFound1<int>();
        var nonExistingMethod2 = ""string literal"".ExtensionMethodNotFound2<int, string>();

        System.Func<object> delegateConversion0 = ""string literal"".ExtensionMethod0<>;
        System.Func<object> delegateConversion1 = ""string literal"".ExtensionMethod1<>;
        System.Func<object> delegateConversion2 = ""string literal"".ExtensionMethod2<>;

        var exactArgs0 = ""string literal"".ExtensionMethod0();
        var exactArgs1 = ""string literal"".ExtensionMethod1<int>();
        var exactArgs2 = ""string literal"".ExtensionMethod2<int, bool>();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 142440, 142511);

                var
                compilation = f_28001_142458_142510(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 142527, 154072);

                f_28001_142527_154071(
                            compilation, f_28001_142780_142888(f_28001_142780_142867(ErrorCode.ERR_OmittedTypeArgument, @"""string literal"".ExtensionMethod0<>"), 13, 27), f_28001_143284_143420(f_28001_143284_143399(f_28001_143284_143355(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod0<>"), "string", "ExtensionMethod0"), 13, 44), f_28001_143644_143752(f_28001_143644_143731(ErrorCode.ERR_OmittedTypeArgument, @"""string literal"".ExtensionMethod1<>"), 14, 27), f_28001_143976_144084(f_28001_143976_144063(ErrorCode.ERR_OmittedTypeArgument, @"""string literal"".ExtensionMethod2<>"), 15, 27), f_28001_144480_144616(f_28001_144480_144595(f_28001_144480_144551(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod2<>"), "string", "ExtensionMethod2"), 15, 44), f_28001_144842_144950(f_28001_144842_144929(ErrorCode.ERR_OmittedTypeArgument, @"""string literal"".ExtensionMethod0<>"), 17, 31), f_28001_145348_145484(f_28001_145348_145463(f_28001_145348_145419(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod0<>"), "string", "ExtensionMethod0"), 17, 48), f_28001_145710_145818(f_28001_145710_145797(ErrorCode.ERR_OmittedTypeArgument, @"""string literal"".ExtensionMethod1<>"), 18, 31), f_28001_146038_146214(f_28001_146038_146193(f_28001_146038_146163(ErrorCode.ERR_ImplicitlyTypedVariableAssignedBadValue, @"omittedArgFunc1 = ""string literal"".ExtensionMethod1<>"), "method group"), 18, 13), f_28001_146440_146548(f_28001_146440_146527(ErrorCode.ERR_OmittedTypeArgument, @"""string literal"".ExtensionMethod2<>"), 19, 31), f_28001_146946_147082(f_28001_146946_147061(f_28001_146946_147017(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod2<>"), "string", "ExtensionMethod2"), 19, 48), f_28001_147479_147618(f_28001_147479_147597(f_28001_147479_147553(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod0<int>"), "string", "ExtensionMethod0"), 21, 42), f_28001_148021_148166(f_28001_148021_148145(f_28001_148021_148101(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod1<int, bool>"), "string", "ExtensionMethod1"), 22, 42), f_28001_148577_148730(f_28001_148577_148709(f_28001_148577_148665(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod2<int, bool, string>"), "string", "ExtensionMethod2"), 23, 42), f_28001_149040_149187(f_28001_149040_149166(f_28001_149040_149107(ErrorCode.ERR_CantInferMethTypeArgs, "ExtensionMethod1"), "FooExtensions.ExtensionMethod1<T>(object)"), 25, 42), f_28001_149584_149723(f_28001_149584_149702(f_28001_149584_149658(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod2<int>"), "string", "ExtensionMethod2"), 26, 42), f_28001_150148_150298(f_28001_150148_150277(f_28001_150148_150225(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethodNotFound0"), "string", "ExtensionMethodNotFound0"), 28, 51), f_28001_150728_150883(f_28001_150728_150862(f_28001_150728_150810(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethodNotFound1<int>"), "string", "ExtensionMethodNotFound1"), 29, 51), f_28001_151321_151484(f_28001_151321_151463(f_28001_151321_151411(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethodNotFound2<int, string>"), "string", "ExtensionMethodNotFound2"), 30, 51), f_28001_151730_151838(f_28001_151730_151817(ErrorCode.ERR_OmittedTypeArgument, @"""string literal"".ExtensionMethod0<>"), 32, 51), f_28001_152256_152392(f_28001_152256_152371(f_28001_152256_152327(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod0<>"), "string", "ExtensionMethod0"), 32, 68), f_28001_152638_152746(f_28001_152638_152725(ErrorCode.ERR_OmittedTypeArgument, @"""string literal"".ExtensionMethod1<>"), 33, 51), f_28001_152999_153162(f_28001_152999_153141(f_28001_152999_153077(ErrorCode.ERR_BadRetType, @"""string literal"".ExtensionMethod1<>"), "FooExtensions.ExtensionMethod1<?>(object)", "?"), 33, 51), f_28001_153408_153516(f_28001_153408_153495(ErrorCode.ERR_OmittedTypeArgument, @"""string literal"".ExtensionMethod2<>"), 34, 51), f_28001_153934_154070(f_28001_153934_154049(f_28001_153934_154005(ErrorCode.ERR_NoSuchMemberOrExtension, "ExtensionMethod2<>"), "string", "ExtensionMethod2"), 34, 68));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 140373, 154083);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_142458_142510(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 142458, 142510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_142780_142867(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 142780, 142867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_142780_142888(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 142780, 142888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_143284_143355(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 143284, 143355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_143284_143399(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 143284, 143399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_143284_143420(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 143284, 143420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_143644_143731(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 143644, 143731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_143644_143752(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 143644, 143752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_143976_144063(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 143976, 144063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_143976_144084(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 143976, 144084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_144480_144551(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 144480, 144551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_144480_144595(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 144480, 144595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_144480_144616(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 144480, 144616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_144842_144929(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 144842, 144929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_144842_144950(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 144842, 144950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_145348_145419(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 145348, 145419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_145348_145463(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 145348, 145463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_145348_145484(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 145348, 145484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_145710_145797(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 145710, 145797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_145710_145818(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 145710, 145818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_146038_146163(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 146038, 146163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_146038_146193(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 146038, 146193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_146038_146214(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 146038, 146214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_146440_146527(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 146440, 146527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_146440_146548(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 146440, 146548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_146946_147017(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 146946, 147017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_146946_147061(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 146946, 147061);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_146946_147082(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 146946, 147082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_147479_147553(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 147479, 147553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_147479_147597(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 147479, 147597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_147479_147618(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 147479, 147618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_148021_148101(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 148021, 148101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_148021_148145(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 148021, 148145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_148021_148166(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 148021, 148166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_148577_148665(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 148577, 148665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_148577_148709(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 148577, 148709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_148577_148730(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 148577, 148730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_149040_149107(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 149040, 149107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_149040_149166(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 149040, 149166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_149040_149187(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 149040, 149187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_149584_149658(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 149584, 149658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_149584_149702(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 149584, 149702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_149584_149723(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 149584, 149723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_150148_150225(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 150148, 150225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_150148_150277(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 150148, 150277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_150148_150298(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 150148, 150298);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_150728_150810(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 150728, 150810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_150728_150862(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 150728, 150862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_150728_150883(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 150728, 150883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_151321_151411(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 151321, 151411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_151321_151463(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 151321, 151463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_151321_151484(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 151321, 151484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_151730_151817(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 151730, 151817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_151730_151838(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 151730, 151838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_152256_152327(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 152256, 152327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_152256_152371(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 152256, 152371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_152256_152392(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 152256, 152392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_152638_152725(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 152638, 152725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_152638_152746(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 152638, 152746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_152999_153077(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 152999, 153077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_152999_153141(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 152999, 153141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_152999_153162(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 152999, 153162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_153408_153495(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 153408, 153495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_153408_153516(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 153408, 153516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_153934_154005(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 153934, 154005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_153934_154049(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 153934, 154049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_153934_154070(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 153934, 154070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_142527_154071(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 142527, 154071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 140373, 154083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 140373, 154083);
            }
        }

        [WorkItem(22757, "https://github.com/dotnet/roslyn/issues/22757")]
        [Fact]
        public void MethodGroupConversionNoReceiver()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 154095, 155497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 154257, 154692);

                var
                source =
                @"using System;
using System.Collections.Generic;
class A
{
    class B
    {
        void F()
        {
            IEnumerable<string> c = null;
            c.S(G);
        }
    }
    object G(string s)
    {
        return null;
    }
}
static class E
{
    internal static IEnumerable<U> S<T, U>(this IEnumerable<T> c, Func<T, U> f)
    {
        throw new NotImplementedException();
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 154708, 154772);

                var
                comp = f_28001_154719_154771(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 154786, 155099);

                f_28001_154786_155098(comp, f_28001_155002_155097(f_28001_155002_155076(f_28001_155002_155047(ErrorCode.ERR_ObjectRequired, "G"), "A.G(string)"), 10, 17));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 155115, 155146);

                var
                tree = f_28001_155126_155142(comp)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 155160, 155200);

                var
                model = f_28001_155172_155199(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 155214, 155329);

                var
                node = f_28001_155225_155328(f_28001_155225_155320(f_28001_155225_155288(f_28001_155225_155257(f_28001_155225_155239(tree))), n => n.ToString() == "G"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 155343, 155380);

                var
                info = f_28001_155354_155379(model, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 155394, 155486);

                f_28001_155394_155485("System.Object A.G(System.String s)", f_28001_155451_155484(info.Symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 154095, 155497);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_154719_154771(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 154719, 154771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_155002_155047(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155002, 155047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_155002_155076(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155002, 155076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_155002_155097(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155002, 155097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_154786_155098(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 154786, 155098);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxTree>
                f_28001_155126_155142(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 155126, 155142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_155172_155199(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155172, 155199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_155225_155239(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155225, 155239);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_155225_155257(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155225, 155257);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                f_28001_155225_155288(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155225, 155288);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                f_28001_155225_155320(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155225, 155320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                f_28001_155225_155328(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>
                source)
                {
                    var return_v = source.First<Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155225, 155328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_28001_155354_155379(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155354, 155379);
                    return return_v;
                }


                string
                f_28001_155451_155484(Microsoft.CodeAnalysis.ISymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155451, 155484);
                    return return_v;
                }


                bool
                f_28001_155394_155485(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155394, 155485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 154095, 155497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 154095, 155497);
            }
        }

        [Fact]
        public void BindingLambdaArguments_DuplicateNamedArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(28001, 155509, 156571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 155610, 156117);

                var
                compilation = f_28001_155628_156116(f_28001_155628_155811(@"
using System;
class X
{
    void M<T>(T arg1, Func<T, T> arg2)
    {
    }
    void N()
    {
        M(arg1: 5, arg2: x => x, arg2: y => y);
    }
}"), f_28001_156016_156115(f_28001_156016_156094(f_28001_156016_156072(ErrorCode.ERR_DuplicateNamedArgument, "arg2"), "arg2"), 10, 34))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 156133, 156177);

                var
                tree = compilation.SyntaxTrees.Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 156191, 156265);

                var
                model = f_28001_156203_156264(compilation, tree, ignoreAccessibility: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 156281, 156414);

                var
                lambda = f_28001_156294_156413(f_28001_156294_156365(f_28001_156294_156326(f_28001_156294_156308(tree))), s => s.Parameter.Identifier.Text == "x")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 156428, 156474);

                var
                typeInfo = f_28001_156443_156473(model, f_28001_156461_156472(lambda))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(28001, 156488, 156560);

                f_28001_156488_156559("System.Int32", f_28001_156523_156558(typeInfo.Type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(28001, 155509, 156571);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_155628_155811(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155628, 155811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_156016_156072(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156016, 156072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_156016_156094(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156016, 156094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_28001_156016_156115(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156016, 156115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_28001_155628_156116(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 155628, 156116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_28001_156203_156264(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, bool
                ignoreAccessibility)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree, ignoreAccessibility: ignoreAccessibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156203, 156264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_28001_156294_156308(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156294, 156308);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_28001_156294_156326(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156294, 156326);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax>
                f_28001_156294_156365(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156294, 156365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                f_28001_156294_156413(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax, bool>
                predicate)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156294, 156413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_28001_156461_156472(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(28001, 156461, 156472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_28001_156443_156473(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetTypeInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156443, 156473);
                    return return_v;
                }


                string
                f_28001_156523_156558(Microsoft.CodeAnalysis.ITypeSymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156523, 156558);
                    return return_v;
                }


                bool
                f_28001_156488_156559(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(28001, 156488, 156559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(28001, 155509, 156571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 155509, 156571);
            }
        }

        public BindingTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(28001, 588, 156578);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(28001, 588, 156578);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 588, 156578);
        }


        static BindingTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(28001, 588, 156578);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(28001, 588, 156578);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(28001, 588, 156578);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(28001, 588, 156578);
    }
}
