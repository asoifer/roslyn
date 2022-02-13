// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.Symbols
{
    public class TypeTests : CSharpTestBase
    {
        [Fact]
        [WorkItem(30023, "https://github.com/dotnet/roslyn/issues/30023")]
        public void Bug18280()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 677, 1789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 816, 877);

                string
                brackets = "[][][][][][][][][][][][][][][][][][][][]"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 891, 912);

                brackets += brackets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 932, 953);

                brackets += brackets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 973, 994);

                brackets += brackets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1015, 1036);

                brackets += brackets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1057, 1078);

                brackets += brackets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1099, 1120);

                brackets += brackets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1142, 1163);

                brackets += brackets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1185, 1206);

                brackets += brackets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1228, 1249);

                brackets += brackets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1274, 1328);

                string
                code = "class C {  int " + brackets + @" x; }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1344, 1386);

                var
                compilation = f_27001_1362_1385(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1400, 1459);

                var
                c = f_27001_1408_1455(f_27001_1408_1435(compilation), "C")[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1473, 1523);

                var
                x = f_27001_1481_1498(c, "x").Single() as FieldSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1537, 1554);

                var
                arr = f_27001_1547_1553(x)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1570, 1588);

                f_27001_1570_1587(
                            arr);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 677, 1789);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_1362_1385(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 1362, 1385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_1408_1435(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 1408, 1435);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_1408_1455(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 1408, 1455);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_1481_1498(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 1481, 1498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_1547_1553(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 1547, 1553);
                    return return_v;
                }


                int
                f_27001_1570_1587(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 1570, 1587);
                    return return_v;
                }

                // https://github.com/dotnet/roslyn/issues/30023: StackOverflowException in SetUnknownNullabilityForReferenceTypes.
                //arr.SetUnknownNullabilityForReferenceTypes();
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 677, 1789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 677, 1789);
            }
        }

        [Fact]
        public void AlphaRenaming()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 1801, 2968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1869, 1984);

                var
                code = @"
class A1 : A<int> {}
class A2 : A<int> {}
class A<T> {
  class B<U> {
    A<A<U>> X;
  }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 1998, 2040);

                var
                compilation = f_27001_2016_2039(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 2054, 2129);

                var
                aint1 = f_27001_2066_2128(f_27001_2066_2114(f_27001_2066_2093(compilation), "A1")[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 2154, 2229);

                var
                aint2 = f_27001_2166_2228(f_27001_2166_2214(f_27001_2166_2193(compilation), "A2")[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 2254, 2301);

                var
                b1 = f_27001_2263_2291(aint1, "B", 1).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 2357, 2404);

                var
                b2 = f_27001_2366_2394(aint2, "B", 1).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 2460, 2525);

                f_27001_2460_2524(f_27001_2481_2498(b1)[0], f_27001_2503_2520(b2)[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 2598, 2661);

                f_27001_2598_2660(f_27001_2617_2634(b1)[0], f_27001_2639_2656(b2)[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 2726, 2783);

                var
                xtype1 = f_27001_2739_2782((f_27001_2740_2758(b1, "X")[0] as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 2851, 2908);

                var
                xtype2 = f_27001_2864_2907((f_27001_2865_2883(b2, "X")[0] as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 2922, 2957);

                f_27001_2922_2956(xtype1, xtype2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 1801, 2968);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_2016_2039(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2016, 2039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_2066_2093(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 2066, 2093);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_2066_2114(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2066, 2114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_2066_2128(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2066, 2128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_2166_2193(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 2166, 2193);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_2166_2214(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2166, 2214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_2166_2228(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2166, 2228);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_2263_2291(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2263, 2291);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_2366_2394(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2366, 2394);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_2481_2498(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 2481, 2498);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_2503_2520(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 2503, 2520);
                    return return_v;
                }


                bool
                f_27001_2460_2524(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                actual)
                {
                    var return_v = CustomAssert.NotSame((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2460, 2524);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_2617_2634(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 2617, 2634);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_2639_2656(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 2639, 2656);
                    return return_v;
                }


                bool
                f_27001_2598_2660(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2598, 2660);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_2740_2758(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2740, 2758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_2739_2782(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 2739, 2782);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_2865_2883(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2865, 2883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_2864_2907(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 2864, 2907);
                    return return_v;
                }


                bool
                f_27001_2922_2956(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 2922, 2956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 1801, 2968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 1801, 2968);
            }
        }

        [Fact]
        public void Access1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 2980, 3641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3042, 3107);

                var
                text =
                @"
class A {
}
struct S {
}
interface B {
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3121, 3156);

                var
                comp = f_27001_3132_3155(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3170, 3204);

                var
                global = f_27001_3183_3203(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3218, 3265);

                var
                a = f_27001_3226_3255(global, "A", 0).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3279, 3326);

                var
                b = f_27001_3287_3316(global, "B", 0).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3340, 3384);

                var
                s = f_27001_3348_3374(global, "S").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3398, 3466);

                f_27001_3398_3465(Accessibility.Internal, f_27001_3441_3464(a));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3480, 3548);

                f_27001_3480_3547(Accessibility.Internal, f_27001_3523_3546(b));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3562, 3630);

                f_27001_3562_3629(Accessibility.Internal, f_27001_3605_3628(s));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 2980, 3641);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_3132_3155(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 3132, 3155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_3183_3203(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 3183, 3203);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_3226_3255(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 3226, 3255);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_3287_3316(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 3287, 3316);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_3348_3374(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 3348, 3374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_3441_3464(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 3441, 3464);
                    return return_v;
                }


                bool
                f_27001_3398_3465(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 3398, 3465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_3523_3546(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 3523, 3546);
                    return return_v;
                }


                bool
                f_27001_3480_3547(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 3480, 3547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_3605_3628(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 3605, 3628);
                    return return_v;
                }


                bool
                f_27001_3562_3629(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 3562, 3629);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 2980, 3641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 2980, 3641);
            }
        }

        [Fact]
        public void InheritedTypesCrossTrees()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 3653, 6333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3732, 3858);

                var
                text = @"namespace MT {
    public interface IGoo { void Goo(); }
    public interface IGoo<T, R> { R Goo(T t); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3872, 3963);

                var
                text1 = @"namespace MT {
    public interface IBar<T> : IGoo { void Bar(T t); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 3977, 4267);

                var
                text2 = @"namespace NS {
    using System;
    using MT;
    public class A<T> : IGoo<T, string>, IBar<string> {
        void IGoo.Goo() { }
        void IBar<string>.Bar(string s) { }
        public string Goo(T t) { return null; }
    }

    public class B : A<int> {}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4281, 4343);

                var
                text3 = @"namespace NS {
    public class C : B {}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4359, 4425);

                var
                comp = f_27001_4370_4424(new[] { text, text1, text2, text3 })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4439, 4473);

                var
                global = f_27001_4452_4472(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4487, 4548);

                var
                ns = f_27001_4496_4519(global, "NS").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4564, 4639);

                var
                type1 = f_27001_4576_4601(ns, "C", 0).SingleOrDefault() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4653, 4702);

                f_27001_4653_4701(0, f_27001_4675_4693(type1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4716, 4768);

                f_27001_4716_4767(3, f_27001_4738_4759(type1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4782, 4917);

                var
                sorted = f_27001_4795_4916((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from i in type1.AllInterfaces()
                                                                                                    orderby i.Name
                                                                                                    select i, 27001, 4796, 4905)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4931, 4969);

                var
                i1 = sorted[0] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 4983, 5021);

                var
                i2 = sorted[1] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5035, 5073);

                var
                i3 = sorted[2] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5087, 5158);

                f_27001_5087_5157("MT.IBar<System.String>", f_27001_5132_5156(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5172, 5204);

                f_27001_5172_5203(1, f_27001_5194_5202(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5218, 5303);

                f_27001_5218_5302("MT.IGoo<System.Int32, System.String>", f_27001_5277_5301(i2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5317, 5349);

                f_27001_5317_5348(2, f_27001_5339_5347(i2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5363, 5419);

                f_27001_5363_5418("MT.IGoo", f_27001_5393_5417(i3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5433, 5465);

                f_27001_5433_5464(0, f_27001_5455_5463(i3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5481, 5528);

                f_27001_5481_5527("B", f_27001_5505_5526(f_27001_5505_5521(type1)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5560, 5608);

                var
                type2 = f_27001_5572_5588(type1) as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5622, 5674);

                f_27001_5622_5673(3, f_27001_5644_5665(type2).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5688, 5727);

                f_27001_5688_5726(f_27001_5709_5725(type2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5764, 5812);

                var
                type3 = f_27001_5776_5792(type2) as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5826, 5896);

                f_27001_5826_5895("NS.A<System.Int32>", f_27001_5867_5894(type3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5910, 5959);

                f_27001_5910_5958(2, f_27001_5932_5950(type3).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 5973, 6025);

                f_27001_5973_6024(3, f_27001_5995_6016(type3).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 6041, 6117);

                var
                type33 = f_27001_6054_6079(ns, "A", 1).SingleOrDefault() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 6131, 6191);

                f_27001_6131_6190("NS.A<T>", f_27001_6161_6189(type33));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 6205, 6255);

                f_27001_6205_6254(2, f_27001_6227_6246(type33).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 6269, 6322);

                f_27001_6269_6321(3, f_27001_6291_6313(type33).Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 3653, 6333);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_4370_4424(string[]
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 4370, 4424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_4452_4472(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 4452, 4472);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_4496_4519(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 4496, 4519);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_4576_4601(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 4576, 4601);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_4675_4693(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 4675, 4693);
                    return return_v;
                }


                bool
                f_27001_4653_4701(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 4653, 4701);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_4738_4759(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 4738, 4759);
                    return return_v;
                }


                bool
                f_27001_4716_4767(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 4716, 4767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                f_27001_4795_4916(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 4795, 4916);
                    return return_v;
                }


                string
                f_27001_5132_5156(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5132, 5156);
                    return return_v;
                }


                bool
                f_27001_5087_5157(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5087, 5157);
                    return return_v;
                }


                int
                f_27001_5194_5202(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 5194, 5202);
                    return return_v;
                }


                bool
                f_27001_5172_5203(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5172, 5203);
                    return return_v;
                }


                string
                f_27001_5277_5301(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5277, 5301);
                    return return_v;
                }


                bool
                f_27001_5218_5302(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5218, 5302);
                    return return_v;
                }


                int
                f_27001_5339_5347(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 5339, 5347);
                    return return_v;
                }


                bool
                f_27001_5317_5348(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5317, 5348);
                    return return_v;
                }


                string
                f_27001_5393_5417(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5393, 5417);
                    return return_v;
                }


                bool
                f_27001_5363_5418(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5363, 5418);
                    return return_v;
                }


                int
                f_27001_5455_5463(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 5455, 5463);
                    return return_v;
                }


                bool
                f_27001_5433_5464(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5433, 5464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_5505_5521(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5505, 5521);
                    return return_v;
                }


                string
                f_27001_5505_5526(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 5505, 5526);
                    return return_v;
                }


                bool
                f_27001_5481_5527(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5481, 5527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_5572_5588(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5572, 5588);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_5644_5665(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5644, 5665);
                    return return_v;
                }


                bool
                f_27001_5622_5673(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5622, 5673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_5709_5725(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5709, 5725);
                    return return_v;
                }


                bool
                f_27001_5688_5726(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5688, 5726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_5776_5792(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5776, 5792);
                    return return_v;
                }


                string
                f_27001_5867_5894(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5867, 5894);
                    return return_v;
                }


                bool
                f_27001_5826_5895(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5826, 5895);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_5932_5950(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5932, 5950);
                    return return_v;
                }


                bool
                f_27001_5910_5958(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5910, 5958);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_5995_6016(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5995, 6016);
                    return return_v;
                }


                bool
                f_27001_5973_6024(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 5973, 6024);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_6054_6079(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 6054, 6079);
                    return return_v;
                }


                string
                f_27001_6161_6189(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 6161, 6189);
                    return return_v;
                }


                bool
                f_27001_6131_6190(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 6131, 6190);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_6227_6246(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 6227, 6246);
                    return return_v;
                }


                bool
                f_27001_6205_6254(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 6205, 6254);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_6291_6313(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 6291, 6313);
                    return return_v;
                }


                bool
                f_27001_6269_6321(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 6269, 6321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 3653, 6333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 3653, 6333);
            }
        }

        [WorkItem(537752, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537752")]
        [Fact]
        public void InheritedTypesCrossComps()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 6345, 10018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 6516, 6675);

                var
                text = @"namespace MT {
    public interface IGoo { void Goo(); }
    public interface IGoo<T, R> { R Goo(T t); }
    public interface IEmpty { }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 6689, 6788);

                var
                text1 = @"namespace MT {
    public interface IBar<T> : IGoo, IEmpty { void Bar(T t); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 6802, 7066);

                var
                text2 = @"namespace NS {
    using MT;
    public class A<T> : IGoo<T, string>, IBar<T>, IGoo {
        void IGoo.Goo() { }
        public string Goo(T t) { return null; }
        void IBar<T>.Bar(T t) { }
    }

    public class B : A<ulong> {}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7080, 7142);

                var
                text3 = @"namespace NS {
    public class C : B {}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7156, 7192);

                var
                comp1 = f_27001_7168_7191(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7206, 7259);

                var
                compRef1 = f_27001_7221_7258(comp1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7275, 7442);

                var
                comp2 = f_27001_7287_7441(new string[] { text1, text2 }, assemblyName: "Test1", references: new List<MetadataReference> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => compRef1, 27001, 7400, 7440) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7456, 7509);

                var
                compRef2 = f_27001_7471_7508(comp2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7525, 7677);

                var
                comp = f_27001_7536_7676(text3, assemblyName: "Test2", references: new List<MetadataReference> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => compRef2, 27001, 7625, 7675), compRef1 })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7693, 7747);

                // Lafhis
                var temp1 = f_27001_7715_7737(comp1);
                f_27001_7693_7746(0, f_27001_7715_7745(ref temp1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7761, 7815);

                var temp2 = f_27001_7783_7805(comp2);
                f_27001_7761_7814(0, f_27001_7783_7813(ref temp2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7829, 7882);

                var temp3 = f_27001_7851_7872(comp);
                f_27001_7829_7881(0, f_27001_7851_7880(ref temp3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7898, 7932);

                var
                global = f_27001_7911_7931(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 7946, 8007);

                var
                ns = f_27001_7955_7978(global, "NS").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8023, 8098);

                var
                type1 = f_27001_8035_8060(ns, "C", 0).SingleOrDefault() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8112, 8161);

                f_27001_8112_8160(0, f_27001_8134_8152(type1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8191, 8243);

                f_27001_8191_8242(4, f_27001_8213_8234(type1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8257, 8392);

                var
                sorted = f_27001_8270_8391((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from i in type1.AllInterfaces()
                                                                                                    orderby i.Name
                                                                                                    select i, 27001, 8271, 8380)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8406, 8444);

                var
                i1 = sorted[0] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8458, 8496);

                var
                i2 = sorted[1] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8510, 8548);

                var
                i3 = sorted[2] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8562, 8600);

                var
                i4 = sorted[3] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8614, 8685);

                f_27001_8614_8684("MT.IBar<System.UInt64>", f_27001_8659_8683(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8699, 8731);

                f_27001_8699_8730(1, f_27001_8721_8729(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8745, 8803);

                f_27001_8745_8802("MT.IEmpty", f_27001_8777_8801(i2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8817, 8849);

                f_27001_8817_8848(0, f_27001_8839_8847(i2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8863, 8949);

                f_27001_8863_8948("MT.IGoo<System.UInt64, System.String>", f_27001_8923_8947(i3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 8963, 8995);

                f_27001_8963_8994(2, f_27001_8985_8993(i3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9009, 9065);

                f_27001_9009_9064("MT.IGoo", f_27001_9039_9063(i4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9079, 9111);

                f_27001_9079_9110(0, f_27001_9101_9109(i4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9127, 9174);

                f_27001_9127_9173("B", f_27001_9151_9172(f_27001_9151_9167(type1)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9206, 9254);

                var
                type2 = f_27001_9218_9234(type1) as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9284, 9336);

                f_27001_9284_9335(4, f_27001_9306_9327(type2).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9350, 9389);

                f_27001_9350_9388(f_27001_9371_9387(type2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9428, 9476);

                var
                type3 = f_27001_9440_9456(type2) as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9510, 9581);

                f_27001_9510_9580("NS.A<System.UInt64>", f_27001_9552_9579(type3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9595, 9644);

                f_27001_9595_9643(3, f_27001_9617_9635(type3).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9658, 9710);

                f_27001_9658_9709(4, f_27001_9680_9701(type3).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9726, 9802);

                var
                type33 = f_27001_9739_9764(ns, "A", 1).SingleOrDefault() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9816, 9876);

                f_27001_9816_9875("NS.A<T>", f_27001_9846_9874(type33));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9890, 9940);

                f_27001_9890_9939(3, f_27001_9912_9931(type33).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 9954, 10007);

                f_27001_9954_10006(4, f_27001_9976_9998(type33).Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 6345, 10018);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_7168_7191(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7168, 7191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_27001_7221_7258(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7221, 7258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_7287_7441(string[]
                source, string
                assemblyName, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7287, 7441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_27001_7471_7508(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7471, 7508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_7536_7676(string
                source, string
                assemblyName, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7536, 7676);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_7715_7737(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7715, 7737);
                    return return_v;
                }


                int
                f_27001_7715_7745(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7715, 7745);
                    return return_v;
                }


                bool
                f_27001_7693_7746(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7693, 7746);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_7783_7805(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7783, 7805);
                    return return_v;
                }


                int
                f_27001_7783_7813(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7783, 7813);
                    return return_v;
                }


                bool
                f_27001_7761_7814(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7761, 7814);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_7851_7872(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7851, 7872);
                    return return_v;
                }


                int
                f_27001_7851_7880(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7851, 7880);
                    return return_v;
                }


                bool
                f_27001_7829_7881(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7829, 7881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_7911_7931(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 7911, 7931);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_7955_7978(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 7955, 7978);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_8035_8060(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8035, 8060);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_8134_8152(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8134, 8152);
                    return return_v;
                }


                bool
                f_27001_8112_8160(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8112, 8160);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_8213_8234(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8213, 8234);
                    return return_v;
                }


                bool
                f_27001_8191_8242(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8191, 8242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                f_27001_8270_8391(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8270, 8391);
                    return return_v;
                }


                string
                f_27001_8659_8683(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8659, 8683);
                    return return_v;
                }


                bool
                f_27001_8614_8684(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8614, 8684);
                    return return_v;
                }


                int
                f_27001_8721_8729(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 8721, 8729);
                    return return_v;
                }


                bool
                f_27001_8699_8730(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8699, 8730);
                    return return_v;
                }


                string
                f_27001_8777_8801(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8777, 8801);
                    return return_v;
                }


                bool
                f_27001_8745_8802(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8745, 8802);
                    return return_v;
                }


                int
                f_27001_8839_8847(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 8839, 8847);
                    return return_v;
                }


                bool
                f_27001_8817_8848(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8817, 8848);
                    return return_v;
                }


                string
                f_27001_8923_8947(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8923, 8947);
                    return return_v;
                }


                bool
                f_27001_8863_8948(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8863, 8948);
                    return return_v;
                }


                int
                f_27001_8985_8993(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 8985, 8993);
                    return return_v;
                }


                bool
                f_27001_8963_8994(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 8963, 8994);
                    return return_v;
                }


                string
                f_27001_9039_9063(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9039, 9063);
                    return return_v;
                }


                bool
                f_27001_9009_9064(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9009, 9064);
                    return return_v;
                }


                int
                f_27001_9101_9109(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 9101, 9109);
                    return return_v;
                }


                bool
                f_27001_9079_9110(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9079, 9110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_9151_9167(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9151, 9167);
                    return return_v;
                }


                string
                f_27001_9151_9172(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 9151, 9172);
                    return return_v;
                }


                bool
                f_27001_9127_9173(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9127, 9173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_9218_9234(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9218, 9234);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_9306_9327(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9306, 9327);
                    return return_v;
                }


                bool
                f_27001_9284_9335(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9284, 9335);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_9371_9387(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9371, 9387);
                    return return_v;
                }


                bool
                f_27001_9350_9388(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9350, 9388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_9440_9456(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9440, 9456);
                    return return_v;
                }


                string
                f_27001_9552_9579(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9552, 9579);
                    return return_v;
                }


                bool
                f_27001_9510_9580(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9510, 9580);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_9617_9635(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9617, 9635);
                    return return_v;
                }


                bool
                f_27001_9595_9643(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9595, 9643);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_9680_9701(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9680, 9701);
                    return return_v;
                }


                bool
                f_27001_9658_9709(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9658, 9709);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_9739_9764(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9739, 9764);
                    return return_v;
                }


                string
                f_27001_9846_9874(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9846, 9874);
                    return return_v;
                }


                bool
                f_27001_9816_9875(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9816, 9875);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_9912_9931(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9912, 9931);
                    return return_v;
                }


                bool
                f_27001_9890_9939(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9890, 9939);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_9976_9998(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9976, 9998);
                    return return_v;
                }


                bool
                f_27001_9954_10006(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 9954, 10006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 6345, 10018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 6345, 10018);
            }
        }

        [WorkItem(537746, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537746")]
        [Fact]
        public void NestedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 10030, 12813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 10188, 10651);

                var
                text = @"namespace NS
    using System;
    public class Test
    {
        private void M() {}
        internal class NestedClass {
            internal protected interface INestedGoo {}
        }
        struct NestedStruct {}
    }

    public class Test<T>
    {
        T M() { return default(T); }
        public struct NestedS<V, V1> {
            class NestedC<R> {}
        }
        interface INestedGoo<T1, T2, T3> {}
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 10665, 10700);

                var
                comp = f_27001_10676_10699(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 10714, 10748);

                var
                global = f_27001_10727_10747(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 10762, 10823);

                var
                ns = f_27001_10771_10794(global, "NS").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 10837, 10915);

                var
                type1 = f_27001_10849_10877(ns, "Test", 0).SingleOrDefault() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 10929, 10982);

                f_27001_10929_10981(2, f_27001_10951_10973(type1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 10998, 11074);

                var
                type2 = f_27001_11010_11045(type1, "NestedClass").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11088, 11174);

                var
                type3 = f_27001_11100_11136(type1, "NestedStruct").SingleOrDefault() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11190, 11240);

                f_27001_11190_11239(type1, f_27001_11216_11238(type2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11254, 11326);

                f_27001_11254_11325(Accessibility.Internal, f_27001_11297_11324(type2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11340, 11392);

                f_27001_11340_11391(TypeKind.Struct, f_27001_11376_11390(type3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11426, 11497);

                f_27001_11426_11496(Accessibility.Private, f_27001_11468_11495(type3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11513, 11575);

                var
                type4 = f_27001_11525_11547(type2).First() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11589, 11639);

                f_27001_11589_11638(type2, f_27001_11615_11637(type4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11653, 11736);

                f_27001_11653_11735(Accessibility.ProtectedOrInternal, f_27001_11707_11734(type4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11750, 11805);

                f_27001_11750_11804(TypeKind.Interface, f_27001_11789_11803(type4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11845, 11919);

                type1 = f_27001_11853_11881(ns, "Test", 1).SingleOrDefault() as NamedTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 11933, 11986);

                f_27001_11933_11985(2, f_27001_11955_11977(type1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12002, 12073);

                type2 = f_27001_12010_12044(type1, "NestedS", 2).Single() as NamedTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12087, 12170);

                type3 = f_27001_12095_12132(type1, "INestedGoo", 3).SingleOrDefault() as NamedTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12186, 12236);

                f_27001_12186_12235(type1, f_27001_12212_12234(type2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12250, 12320);

                f_27001_12250_12319(Accessibility.Public, f_27001_12291_12318(type2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12334, 12389);

                f_27001_12334_12388(TypeKind.Interface, f_27001_12373_12387(type3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12423, 12494);

                f_27001_12423_12493(Accessibility.Private, f_27001_12465_12492(type3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12510, 12568);

                type4 = f_27001_12518_12540(type2).First() as NamedTypeSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12582, 12632);

                f_27001_12582_12631(type2, f_27001_12608_12630(type4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12666, 12737);

                f_27001_12666_12736(Accessibility.Private, f_27001_12708_12735(type4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12751, 12802);

                f_27001_12751_12801(TypeKind.Class, f_27001_12786_12800(type4));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 10030, 12813);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_10676_10699(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 10676, 10699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_10727_10747(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 10727, 10747);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_10771_10794(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 10771, 10794);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_10849_10877(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 10849, 10877);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_10951_10973(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 10951, 10973);
                    return return_v;
                }


                bool
                f_27001_10929_10981(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 10929, 10981);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_11010_11045(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11010, 11045);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_11100_11136(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11100, 11136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_11216_11238(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 11216, 11238);
                    return return_v;
                }


                bool
                f_27001_11190_11239(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11190, 11239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_11297_11324(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 11297, 11324);
                    return return_v;
                }


                bool
                f_27001_11254_11325(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11254, 11325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_11376_11390(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 11376, 11390);
                    return return_v;
                }


                bool
                f_27001_11340_11391(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11340, 11391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_11468_11495(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 11468, 11495);
                    return return_v;
                }


                bool
                f_27001_11426_11496(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11426, 11496);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_11525_11547(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11525, 11547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_11615_11637(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 11615, 11637);
                    return return_v;
                }


                bool
                f_27001_11589_11638(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11589, 11638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_11707_11734(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 11707, 11734);
                    return return_v;
                }


                bool
                f_27001_11653_11735(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11653, 11735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_11789_11803(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 11789, 11803);
                    return return_v;
                }


                bool
                f_27001_11750_11804(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11750, 11804);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_11853_11881(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11853, 11881);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_11955_11977(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11955, 11977);
                    return return_v;
                }


                bool
                f_27001_11933_11985(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 11933, 11985);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_12010_12044(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12010, 12044);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_12095_12132(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12095, 12132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_12212_12234(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 12212, 12234);
                    return return_v;
                }


                bool
                f_27001_12186_12235(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12186, 12235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_12291_12318(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 12291, 12318);
                    return return_v;
                }


                bool
                f_27001_12250_12319(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12250, 12319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_12373_12387(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 12373, 12387);
                    return return_v;
                }


                bool
                f_27001_12334_12388(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12334, 12388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_12465_12492(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 12465, 12492);
                    return return_v;
                }


                bool
                f_27001_12423_12493(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12423, 12493);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_12518_12540(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12518, 12540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_12608_12630(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 12608, 12630);
                    return return_v;
                }


                bool
                f_27001_12582_12631(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12582, 12631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_12708_12735(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 12708, 12735);
                    return return_v;
                }


                bool
                f_27001_12666_12736(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12666, 12736);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_12786_12800(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 12786, 12800);
                    return return_v;
                }


                bool
                f_27001_12751_12801(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 12751, 12801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 10030, 12813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 10030, 12813);
            }
        }

        [Fact]
        public void PartialTypeCrossTrees()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 12825, 14264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 12901, 13030);

                var
                text = @"
namespace MT {
    using System.Collections.Generic;
    public partial interface IGoo<T> { void Goo(); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 13044, 13318);

                var
                text1 = @"
namespace MT {
    using System.Collections.Generic;
    public partial interface IGoo<T> { T Goo(T t); }
}

namespace NS {
    using System;
    using MT;

    public partial class A<T> : IGoo<T>
    {
        void IGoo<T>.Goo() { }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 13332, 13489);

                var
                text2 = @"
namespace NS {
    using MT;
    public partial class A<T> : IGoo<T>
    {
        public T Goo(T t) { return default(T); }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 13505, 13564);

                var
                comp = f_27001_13516_13563(new[] { text, text1, text2 })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 13578, 13612);

                var
                global = f_27001_13591_13611(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 13626, 13687);

                var
                ns = f_27001_13635_13658(global, "NS").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 13703, 13778);

                var
                type1 = f_27001_13715_13740(ns, "A", 1).SingleOrDefault() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 13825, 13874);

                f_27001_13825_13873(3, f_27001_13847_13865(type1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 13888, 13937);

                f_27001_13888_13936(1, f_27001_13910_13928(type1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 13951, 13997);

                f_27001_13951_13996(2, type1.Locations.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14013, 14063);

                var
                i1 = f_27001_14022_14040(type1)[0] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14077, 14136);

                f_27001_14077_14135("MT.IGoo<T>", f_27001_14110_14134(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14150, 14196);

                f_27001_14150_14195(2, f_27001_14172_14187(i1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14210, 14253);

                f_27001_14210_14252(2, i1.Locations.Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 12825, 14264);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_13516_13563(string[]
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 13516, 13563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_13591_13611(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 13591, 13611);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_13635_13658(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 13635, 13658);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_13715_13740(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 13715, 13740);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_13847_13865(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 13847, 13865);
                    return return_v;
                }


                bool
                f_27001_13825_13873(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 13825, 13873);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_13910_13928(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 13910, 13928);
                    return return_v;
                }


                bool
                f_27001_13888_13936(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 13888, 13936);
                    return return_v;
                }


                bool
                f_27001_13951_13996(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 13951, 13996);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_14022_14040(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14022, 14040);
                    return return_v;
                }


                string
                f_27001_14110_14134(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14110, 14134);
                    return return_v;
                }


                bool
                f_27001_14077_14135(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14077, 14135);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_14172_14187(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14172, 14187);
                    return return_v;
                }


                bool
                f_27001_14150_14195(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14150, 14195);
                    return return_v;
                }


                bool
                f_27001_14210_14252(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14210, 14252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 12825, 14264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 12825, 14264);
            }
        }

        [WorkItem(537752, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537752")]
        [Fact]
        public void TypeCrossComps()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 14276, 16629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14475, 14549);

                var
                text = @"
    public interface IGoo  {
        void M0();
    }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14565, 14651);

                var
                text1 = @"
    public class Goo : IGoo  {
        public void M0() {}
    }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14665, 14701);

                var
                comp1 = f_27001_14677_14700(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14715, 14768);

                var
                compRef1 = f_27001_14730_14767(comp1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14782, 14895);

                var
                comp = f_27001_14793_14894(text1, references: new List<MetadataReference> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => compRef1, 27001, 14830, 14870) }, assemblyName: "Comp2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 14911, 14964);

                // Lafhis
                var temp1 = f_27001_14933_14954(comp);
                f_27001_14911_14963(0, f_27001_14933_14962(ref temp1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15045, 15115);

                text = @"
    public interface IGoo  {
        void M0();
    }
";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15131, 15209);

                text1 = @"
    public interface IBar : IGoo  {
        void M1();
    }
";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15223, 15255);

                comp1 = f_27001_15231_15254(text);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15269, 15318);

                compRef1 = f_27001_15280_15317(comp1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15332, 15441);

                comp = f_27001_15339_15440(text1, references: new List<MetadataReference> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => compRef1, 27001, 15376, 15416) }, assemblyName: "Comp2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15457, 15510);

                var temp3 = f_27001_15479_15500(comp);
                f_27001_15457_15509(0, f_27001_15479_15508(ref temp3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15587, 15640);

                text = @"
public class A { 
    void M0() {}
}
";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15656, 15714);

                text1 = @"
public class B : A { 
    void M1() {}
}
";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15728, 15760);

                comp1 = f_27001_15736_15759(text);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15774, 15823);

                compRef1 = f_27001_15785_15822(comp1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15837, 15946);

                comp = f_27001_15844_15945(text1, references: new List<MetadataReference> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => compRef1, 27001, 15881, 15921) }, assemblyName: "Comp2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 15962, 16015);

                // Lafhis
                var temp = f_27001_15984_16005(comp);
                f_27001_15962_16014(0, f_27001_15984_16013(ref temp));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 16086, 16181);

                text = @"
public partial interface IBar {
    void M0();
}

public partial class A { }
";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 16197, 16293);

                text1 = @"
public partial interface IBar {
    void M1();
}

public partial class A { }
";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 16307, 16339);

                comp1 = f_27001_16315_16338(text);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 16353, 16402);

                compRef1 = f_27001_16364_16401(comp1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 16416, 16525);

                comp = f_27001_16423_16524(text1, references: new List<MetadataReference> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => compRef1, 27001, 16460, 16500) }, assemblyName: "Comp2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 16541, 16594);

                // Lafhis
                var temp2 = f_27001_16563_16584(comp);
                f_27001_16541_16593(0, f_27001_16563_16592(ref temp2));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 14276, 16629);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_14677_14700(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14677, 14700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_27001_14730_14767(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14730, 14767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_14793_14894(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14793, 14894);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_14933_14954(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14933, 14954);
                    return return_v;
                }


                int
                f_27001_14933_14962(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14933, 14962);
                    return return_v;
                }


                bool
                f_27001_14911_14963(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 14911, 14963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_15231_15254(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15231, 15254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_27001_15280_15317(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15280, 15317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_15339_15440(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15339, 15440);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_15479_15500(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15479, 15500);
                    return return_v;
                }


                int
                f_27001_15479_15508(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15479, 15508);
                    return return_v;
                }


                bool
                f_27001_15457_15509(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15457, 15509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_15736_15759(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15736, 15759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_27001_15785_15822(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15785, 15822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_15844_15945(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15844, 15945);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_15984_16005(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15984, 16005);
                    return return_v;
                }


                int
                f_27001_15984_16013(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15984, 16013);
                    return return_v;
                }


                bool
                f_27001_15962_16014(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 15962, 16014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_16315_16338(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 16315, 16338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_27001_16364_16401(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 16364, 16401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_16423_16524(string
                source, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
                references, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 16423, 16524);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_16563_16584(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 16563, 16584);
                    return return_v;
                }


                int
                f_27001_16563_16592(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 16563, 16592);
                    return return_v;
                }


                bool
                f_27001_16541_16593(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 16541, 16593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 14276, 16629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 14276, 16629);
            }
        }

        [Fact, WorkItem(537233, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537233"), WorkItem(537313, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537313")]
        public void ArrayTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 16641, 20590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 16870, 17185);

                var
                text =
                @"public class Test
{
    static int[,] intAryField;
    internal ulong[][,] ulongAryField;

    public string[,][] MethodWithArray(
        ref Test[, ,] refArray, 
        out object[][][] outArray, 
        params byte[] varArray) 
    { 
        outArray = null;  return null; 
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17201, 17236);

                var
                comp = f_27001_17212_17235(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17250, 17322);

                var
                classTest = f_27001_17266_17312(f_27001_17266_17286(comp), "Test", 0).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17338, 17396);

                var
                field1 = f_27001_17351_17386(classTest, "intAryField").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17410, 17465);

                f_27001_17410_17464(classTest, f_27001_17440_17463(field1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17479, 17529);

                f_27001_17479_17528(SymbolKind.Field, f_27001_17516_17527(field1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17543, 17582);

                f_27001_17543_17581(f_27001_17561_17580(field1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17596, 17631);

                f_27001_17596_17630(f_27001_17614_17629(field1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17645, 17705);

                var
                elemType1 = f_27001_17661_17704((field1 as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17719, 17779);

                f_27001_17719_17778(TypeKind.Array, f_27001_17754_17777(elemType1.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17793, 17869);

                f_27001_17793_17868("System.Int32[,]", f_27001_17831_17867(elemType1.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17922, 17966);

                f_27001_17922_17965(f_27001_17941_17964(elemType1.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 17980, 18026);

                f_27001_17980_18025(f_27001_17999_18024(elemType1.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18040, 18084);

                f_27001_18040_18083(f_27001_18059_18082(elemType1.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18098, 18184);

                f_27001_18098_18183(Accessibility.NotApplicable, f_27001_18146_18182(elemType1.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18200, 18256);

                field1 = f_27001_18209_18246(classTest, "ulongAryField").Single();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18270, 18325);

                f_27001_18270_18324(classTest, f_27001_18300_18323(field1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18339, 18389);

                f_27001_18339_18388(SymbolKind.Field, f_27001_18376_18387(field1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18403, 18442);

                f_27001_18403_18441(f_27001_18421_18440(field1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18456, 18501);

                var
                elemType2 = f_27001_18472_18500((field1 as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18515, 18570);

                f_27001_18515_18569(TypeKind.Array, f_27001_18550_18568(elemType2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18609, 18683);

                f_27001_18609_18682("System.UInt64[][,]", f_27001_18650_18681(elemType2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18697, 18752);

                f_27001_18697_18751("Array", f_27001_18725_18750(f_27001_18725_18745(elemType2)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18768, 18846);

                var
                method = f_27001_18781_18820(classTest, "MethodWithArray").Single() as MethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18860, 18915);

                f_27001_18860_18914(classTest, f_27001_18890_18913(method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18929, 18980);

                f_27001_18929_18979(SymbolKind.Method, f_27001_18967_18978(method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 18994, 19033);

                f_27001_18994_19032(f_27001_19012_19031(method));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19047, 19097);

                var
                retType = f_27001_19061_19096((method as MethodSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19111, 19164);

                f_27001_19111_19163(TypeKind.Array, f_27001_19146_19162(retType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19217, 19271);

                f_27001_19217_19270(0, f_27001_19239_19262(retType).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19324, 19375);

                f_27001_19324_19374(0, f_27001_19346_19366(retType).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19419, 19482);

                f_27001_19419_19481(0, f_27001_19441_19473(retType, string.Empty).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19496, 19551);

                f_27001_19496_19550(0, f_27001_19518_19542(retType).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19604, 19671);

                f_27001_19604_19670(0, f_27001_19626_19662(retType, string.Empty).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19685, 19755);

                f_27001_19685_19754(0, f_27001_19707_19746(retType, string.Empty, 0).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19794, 19866);

                f_27001_19794_19865("System.String[,][]", f_27001_19835_19864(retType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19882, 19934);

                var
                paramList = f_27001_19898_19933((method as MethodSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19948, 19978);

                var
                p1 = f_27001_19957_19974(method)[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 19992, 20022);

                var
                p2 = f_27001_20001_20018(method)[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 20036, 20066);

                var
                p3 = f_27001_20045_20062(method)[2]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 20080, 20124);

                f_27001_20080_20123(RefKind.Ref, f_27001_20112_20122(p1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 20138, 20208);

                f_27001_20138_20207("ref Test[,,] refArray", f_27001_20182_20206(p1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 20222, 20266);

                f_27001_20222_20265(RefKind.Out, f_27001_20254_20264(p2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 20280, 20361);

                f_27001_20280_20360("out System.Object[][][] outArray", f_27001_20335_20359(p2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 20375, 20420);

                f_27001_20375_20419(RefKind.None, f_27001_20408_20418(p3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 20434, 20487);

                f_27001_20434_20486(TypeKind.Array, f_27001_20469_20485(f_27001_20469_20476(p3)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 20501, 20579);

                f_27001_20501_20578("params System.Byte[] varArray", f_27001_20553_20577(p3));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 16641, 20590);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_17212_17235(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17212, 17235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_17266_17286(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 17266, 17286);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_17266_17312(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17266, 17312);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_17351_17386(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17351, 17386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_17440_17463(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 17440, 17463);
                    return return_v;
                }


                bool
                f_27001_17410_17464(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17410, 17464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_17516_17527(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 17516, 17527);
                    return return_v;
                }


                bool
                f_27001_17479_17528(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17479, 17528);
                    return return_v;
                }


                bool
                f_27001_17561_17580(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 17561, 17580);
                    return return_v;
                }


                bool
                f_27001_17543_17581(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17543, 17581);
                    return return_v;
                }


                bool
                f_27001_17614_17629(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 17614, 17629);
                    return return_v;
                }


                bool
                f_27001_17596_17630(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17596, 17630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_27001_17661_17704(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 17661, 17704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_17754_17777(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 17754, 17777);
                    return return_v;
                }


                bool
                f_27001_17719_17778(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17719, 17778);
                    return return_v;
                }


                string
                f_27001_17831_17867(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17831, 17867);
                    return return_v;
                }


                bool
                f_27001_17793_17868(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17793, 17868);
                    return return_v;
                }


                bool
                f_27001_17941_17964(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 17941, 17964);
                    return return_v;
                }


                bool
                f_27001_17922_17965(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17922, 17965);
                    return return_v;
                }


                bool
                f_27001_17999_18024(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 17999, 18024);
                    return return_v;
                }


                bool
                f_27001_17980_18025(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 17980, 18025);
                    return return_v;
                }


                bool
                f_27001_18059_18082(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18059, 18082);
                    return return_v;
                }


                bool
                f_27001_18040_18083(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18040, 18083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_18146_18182(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18146, 18182);
                    return return_v;
                }


                bool
                f_27001_18098_18183(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18098, 18183);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_18209_18246(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18209, 18246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_18300_18323(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18300, 18323);
                    return return_v;
                }


                bool
                f_27001_18270_18324(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18270, 18324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_18376_18387(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18376, 18387);
                    return return_v;
                }


                bool
                f_27001_18339_18388(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18339, 18388);
                    return return_v;
                }


                bool
                f_27001_18421_18440(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18421, 18440);
                    return return_v;
                }


                bool
                f_27001_18403_18441(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18403, 18441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_18472_18500(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18472, 18500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_18550_18568(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18550, 18568);
                    return return_v;
                }


                bool
                f_27001_18515_18569(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18515, 18569);
                    return return_v;
                }


                string
                f_27001_18650_18681(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18650, 18681);
                    return return_v;
                }


                bool
                f_27001_18609_18682(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18609, 18682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_18725_18745(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18725, 18745);
                    return return_v;
                }


                string
                f_27001_18725_18750(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18725, 18750);
                    return return_v;
                }


                bool
                f_27001_18697_18751(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18697, 18751);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_18781_18820(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18781, 18820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_18890_18913(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18890, 18913);
                    return return_v;
                }


                bool
                f_27001_18860_18914(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18860, 18914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_18967_18978(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 18967, 18978);
                    return return_v;
                }


                bool
                f_27001_18929_18979(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18929, 18979);
                    return return_v;
                }


                bool
                f_27001_19012_19031(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 19012, 19031);
                    return return_v;
                }


                bool
                f_27001_18994_19032(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 18994, 19032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_19061_19096(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 19061, 19096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_19146_19162(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 19146, 19162);
                    return return_v;
                }


                bool
                f_27001_19111_19163(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19111, 19163);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_27001_19239_19262(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19239, 19262);
                    return return_v;
                }


                bool
                f_27001_19217_19270(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19217, 19270);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_19346_19366(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19346, 19366);
                    return return_v;
                }


                bool
                f_27001_19324_19374(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19324, 19374);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_19441_19473(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19441, 19473);
                    return return_v;
                }


                bool
                f_27001_19419_19481(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19419, 19481);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_19518_19542(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19518, 19542);
                    return return_v;
                }


                bool
                f_27001_19496_19550(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19496, 19550);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_19626_19662(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19626, 19662);
                    return return_v;
                }


                bool
                f_27001_19604_19670(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19604, 19670);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_19707_19746(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19707, 19746);
                    return return_v;
                }


                bool
                f_27001_19685_19754(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19685, 19754);
                    return return_v;
                }


                string
                f_27001_19835_19864(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19835, 19864);
                    return return_v;
                }


                bool
                f_27001_19794_19865(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 19794, 19865);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_19898_19933(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 19898, 19933);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_19957_19974(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 19957, 19974);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_20001_20018(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 20001, 20018);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_20045_20062(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 20045, 20062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_27001_20112_20122(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 20112, 20122);
                    return return_v;
                }


                bool
                f_27001_20080_20123(Microsoft.CodeAnalysis.RefKind
                expected, Microsoft.CodeAnalysis.RefKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20080, 20123);
                    return return_v;
                }


                string
                f_27001_20182_20206(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20182, 20206);
                    return return_v;
                }


                bool
                f_27001_20138_20207(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20138, 20207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_27001_20254_20264(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 20254, 20264);
                    return return_v;
                }


                bool
                f_27001_20222_20265(Microsoft.CodeAnalysis.RefKind
                expected, Microsoft.CodeAnalysis.RefKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20222, 20265);
                    return return_v;
                }


                string
                f_27001_20335_20359(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20335, 20359);
                    return return_v;
                }


                bool
                f_27001_20280_20360(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20280, 20360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_27001_20408_20418(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 20408, 20418);
                    return return_v;
                }


                bool
                f_27001_20375_20419(Microsoft.CodeAnalysis.RefKind
                expected, Microsoft.CodeAnalysis.RefKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20375, 20419);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_20469_20476(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 20469, 20476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_20469_20485(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 20469, 20485);
                    return return_v;
                }


                bool
                f_27001_20434_20486(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20434, 20486);
                    return return_v;
                }


                string
                f_27001_20553_20577(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20553, 20577);
                    return return_v;
                }


                bool
                f_27001_20501_20578(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 20501, 20578);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 16641, 20590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 16641, 20590);
            }
        }

        [Fact, WorkItem(537300, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537300"), WorkItem(527247, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/527247")]
        public void ArrayTypeInterfaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 20906, 23636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21144, 21244);

                var
                text = @"
public class A {
    static byte[][] AryField;
    static byte[,] AryField2;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21260, 21346);

                var
                compilation = f_27001_21278_21345(text, new[] { f_27001_21315_21342() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21360, 21383);

                int[]
                ary = new int[2]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21399, 21455);

                var
                globalNS = f_27001_21414_21454(f_27001_21414_21438(compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21469, 21542);

                var
                classTest = f_27001_21485_21513(globalNS, "A").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21558, 21632);

                var
                sym1 = f_27001_21569_21631((f_27001_21570_21602(classTest, "AryField").First() as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21646, 21698);

                f_27001_21646_21697(SymbolKind.ArrayType, f_27001_21687_21696(sym1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21728, 21776);

                f_27001_21728_21775(1, f_27001_21750_21767(sym1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21790, 21850);

                f_27001_21790_21849("IList", f_27001_21818_21848(f_27001_21818_21835(sym1).First()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21866, 21917);

                f_27001_21866_21916(9, f_27001_21888_21908(sym1).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 21971, 22036);

                var temp4 = f_27001_21984_22004(sym1);
                var
                sorted = f_27001_21984_22035(f_27001_21984_22025(ref temp4, i => i.Name))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22052, 22090);

                var
                i1 = sorted[0] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22104, 22142);

                var
                i2 = sorted[1] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22156, 22194);

                var
                i3 = sorted[2] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22208, 22246);

                var
                i4 = sorted[3] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22260, 22298);

                var
                i5 = sorted[4] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22312, 22350);

                var
                i6 = sorted[5] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22364, 22402);

                var
                i7 = sorted[6] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22416, 22454);

                var
                i8 = sorted[7] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22468, 22506);

                var
                i9 = sorted[8] as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22520, 22586);

                f_27001_22520_22585("System.ICloneable", f_27001_22560_22584(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22600, 22679);

                f_27001_22600_22678("System.Collections.ICollection", f_27001_22653_22677(i2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22693, 22795);

                f_27001_22693_22794("System.Collections.Generic.ICollection<System.Byte[]>", f_27001_22769_22793(i3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22809, 22911);

                f_27001_22809_22910("System.Collections.Generic.IEnumerable<System.Byte[]>", f_27001_22885_22909(i4));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 22925, 23004);

                f_27001_22925_23003("System.Collections.IEnumerable", f_27001_22978_23002(i5));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23018, 23091);

                f_27001_23018_23090("System.Collections.IList", f_27001_23065_23089(i6));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23105, 23201);

                f_27001_23105_23200("System.Collections.Generic.IList<System.Byte[]>", f_27001_23175_23199(i7));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23215, 23304);

                f_27001_23215_23303("System.Collections.IStructuralComparable", f_27001_23278_23302(i8));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23318, 23406);

                f_27001_23318_23405("System.Collections.IStructuralEquatable", f_27001_23380_23404(i9));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23422, 23497);

                var
                sym2 = f_27001_23433_23496((f_27001_23434_23467(classTest, "AryField2").First() as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23511, 23563);

                f_27001_23511_23562(SymbolKind.ArrayType, f_27001_23552_23561(sym2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23577, 23625);

                f_27001_23577_23624(0, f_27001_23599_23616(sym2).Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 20906, 23636);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_27001_21315_21342()
                {
                    var return_v = TestMetadata.Net40.mscorlib;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 21315, 21342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_21278_21345(string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21278, 21345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_27001_21414_21438(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 21414, 21438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_21414_21454(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 21414, 21454);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_21485_21513(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21485, 21513);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_21570_21602(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21570, 21602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_21569_21631(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 21569, 21631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_21687_21696(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 21687, 21696);
                    return return_v;
                }


                bool
                f_27001_21646_21697(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21646, 21697);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_21750_21767(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21750, 21767);
                    return return_v;
                }


                bool
                f_27001_21728_21775(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21728, 21775);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_21818_21835(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21818, 21835);
                    return return_v;
                }


                string
                f_27001_21818_21848(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 21818, 21848);
                    return return_v;
                }


                bool
                f_27001_21790_21849(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21790, 21849);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_21888_21908(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21888, 21908);
                    return return_v;
                }


                bool
                f_27001_21866_21916(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21866, 21916);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_21984_22004(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21984, 22004);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_21984_22025(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, string>
                keySelector)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21984, 22025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                f_27001_21984_22035(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 21984, 22035);
                    return return_v;
                }


                string
                f_27001_22560_22584(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22560, 22584);
                    return return_v;
                }


                bool
                f_27001_22520_22585(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22520, 22585);
                    return return_v;
                }


                string
                f_27001_22653_22677(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22653, 22677);
                    return return_v;
                }


                bool
                f_27001_22600_22678(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22600, 22678);
                    return return_v;
                }


                string
                f_27001_22769_22793(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22769, 22793);
                    return return_v;
                }


                bool
                f_27001_22693_22794(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22693, 22794);
                    return return_v;
                }


                string
                f_27001_22885_22909(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22885, 22909);
                    return return_v;
                }


                bool
                f_27001_22809_22910(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22809, 22910);
                    return return_v;
                }


                string
                f_27001_22978_23002(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22978, 23002);
                    return return_v;
                }


                bool
                f_27001_22925_23003(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 22925, 23003);
                    return return_v;
                }


                string
                f_27001_23065_23089(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23065, 23089);
                    return return_v;
                }


                bool
                f_27001_23018_23090(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23018, 23090);
                    return return_v;
                }


                string
                f_27001_23175_23199(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23175, 23199);
                    return return_v;
                }


                bool
                f_27001_23105_23200(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23105, 23200);
                    return return_v;
                }


                string
                f_27001_23278_23302(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23278, 23302);
                    return return_v;
                }


                bool
                f_27001_23215_23303(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23215, 23303);
                    return return_v;
                }


                string
                f_27001_23380_23404(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23380, 23404);
                    return return_v;
                }


                bool
                f_27001_23318_23405(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23318, 23405);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_23434_23467(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23434, 23467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_23433_23496(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 23433, 23496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_23552_23561(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 23552, 23561);
                    return return_v;
                }


                bool
                f_27001_23511_23562(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23511, 23562);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_23599_23616(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23599, 23616);
                    return return_v;
                }


                bool
                f_27001_23577_23624(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23577, 23624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 20906, 23636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 20906, 23636);
            }
        }

        [Fact]
        public void ArrayTypeGetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 23648, 24910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23723, 23865);

                var
                text = @"public class A {
    public uint[] AryField1;
    static string[][] AryField2;
    private sbyte[,,] AryField3;
    A(){}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23879, 23921);

                var
                compilation = f_27001_23897_23920(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 23937, 23993);

                var
                globalNS = f_27001_23952_23992(f_27001_23952_23976(compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24007, 24080);

                var
                classTest = f_27001_24023_24051(globalNS, "A").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24096, 24160);

                var
                sym1 = f_27001_24107_24159((f_27001_24108_24130(classTest).First() as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24174, 24226);

                f_27001_24174_24225(SymbolKind.ArrayType, f_27001_24215_24224(sym1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24240, 24268);

                var
                v1 = f_27001_24249_24267(sym1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24282, 24310);

                var
                v2 = f_27001_24291_24309(sym1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24324, 24351);

                f_27001_24324_24350(v1, v2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24367, 24442);

                var
                sym2 = f_27001_24378_24441((f_27001_24379_24412(classTest, "AryField2").First() as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24456, 24508);

                f_27001_24456_24507(SymbolKind.ArrayType, f_27001_24497_24506(sym2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24522, 24546);

                v1 = f_27001_24527_24545(sym2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24560, 24584);

                v2 = f_27001_24565_24583(sym2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24598, 24625);

                f_27001_24598_24624(v1, v2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24641, 24716);

                var
                sym3 = f_27001_24652_24715((f_27001_24653_24686(classTest, "AryField3").First() as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24730, 24782);

                f_27001_24730_24781(SymbolKind.ArrayType, f_27001_24771_24780(sym3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24796, 24820);

                v1 = f_27001_24801_24819(sym3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24834, 24858);

                v2 = f_27001_24839_24857(sym3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 24872, 24899);

                f_27001_24872_24898(v1, v2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 23648, 24910);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_23897_23920(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 23897, 23920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_27001_23952_23976(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 23952, 23976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_23952_23992(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 23952, 23992);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_24023_24051(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24023, 24051);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_24108_24130(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24108, 24130);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_24107_24159(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 24107, 24159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_24215_24224(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 24215, 24224);
                    return return_v;
                }


                bool
                f_27001_24174_24225(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24174, 24225);
                    return return_v;
                }


                int
                f_27001_24249_24267(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24249, 24267);
                    return return_v;
                }


                int
                f_27001_24291_24309(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24291, 24309);
                    return return_v;
                }


                bool
                f_27001_24324_24350(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24324, 24350);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_24379_24412(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24379, 24412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_24378_24441(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 24378, 24441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_24497_24506(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 24497, 24506);
                    return return_v;
                }


                bool
                f_27001_24456_24507(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24456, 24507);
                    return return_v;
                }


                int
                f_27001_24527_24545(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24527, 24545);
                    return return_v;
                }


                int
                f_27001_24565_24583(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24565, 24583);
                    return return_v;
                }


                bool
                f_27001_24598_24624(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24598, 24624);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_24653_24686(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24653, 24686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_24652_24715(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 24652, 24715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_24771_24780(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 24771, 24780);
                    return return_v;
                }


                bool
                f_27001_24730_24781(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24730, 24781);
                    return return_v;
                }


                int
                f_27001_24801_24819(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24801, 24819);
                    return return_v;
                }


                int
                f_27001_24839_24857(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24839, 24857);
                    return return_v;
                }


                bool
                f_27001_24872_24898(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 24872, 24898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 23648, 24910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 23648, 24910);
            }
        }

        [Fact, WorkItem(527114, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/527114")]
        public void DynamicType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 24922, 26938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25070, 25141);

                var
                text =
                @"class A 
{
    object field1;
    dynamic field2;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25157, 25210);

                var
                global = f_27001_25170_25209(f_27001_25170_25193(text))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25224, 25271);

                var
                a = f_27001_25232_25261(global, "A", 0).Single()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25285, 25945);
                    foreach (var m in f_27001_25303_25317_I(f_27001_25303_25317(a)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27001, 25285, 25945);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25351, 25930) || true) && (f_27001_25355_25361(m) == "field1")
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27001, 25351, 25930);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25415, 25448);

                            var
                            f1 = f_27001_25424_25447((m as FieldSymbol))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25470, 25572);

                            f_27001_25470_25571(f1 is ErrorTypeSymbol, f_27001_25512_25535(f_27001_25512_25524(f1)) + " : " + f_27001_25546_25570(f1));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27001, 25351, 25930);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27001, 25351, 25930);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25614, 25930) || true) && (f_27001_25618_25624(m) == "field2")
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27001, 25614, 25930);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25678, 25723);

                                f_27001_25678_25722(SymbolKind.Field, f_27001_25715_25721(m));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27001, 25614, 25930);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27001, 25351, 25930);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27001, 25285, 25945);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(27001, 1, 661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(27001, 1, 661);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 25961, 26003);

                var
                obj = f_27001_25971_25993(a, "field1").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26017, 26061);

                f_27001_26017_26060(a, f_27001_26039_26059(obj));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26075, 26122);

                f_27001_26075_26121(SymbolKind.Field, f_27001_26112_26120(obj));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26136, 26172);

                f_27001_26136_26171(f_27001_26154_26170(obj));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26186, 26226);

                var
                objType = f_27001_26200_26225((obj as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26240, 26357);

                f_27001_26240_26356(objType is ErrorTypeSymbol, f_27001_26287_26315(f_27001_26287_26304(objType)) + " : " + f_27001_26326_26355(objType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26371, 26429);

                f_27001_26371_26428(SymbolKind.ErrorType, f_27001_26415_26427(objType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26445, 26487);

                var
                dyn = f_27001_26455_26477(a, "field2").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26501, 26545);

                f_27001_26501_26544(a, f_27001_26523_26543(dyn));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26559, 26606);

                f_27001_26559_26605(SymbolKind.Field, f_27001_26596_26604(dyn));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26620, 26656);

                f_27001_26620_26655(f_27001_26638_26654(dyn));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26670, 26710);

                var
                dynType = f_27001_26684_26709((obj as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26724, 26841);

                f_27001_26724_26840(dynType is ErrorTypeSymbol, f_27001_26771_26799(f_27001_26771_26788(dynType)) + " : " + f_27001_26810_26839(dynType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 26869, 26927);

                f_27001_26869_26926(SymbolKind.ErrorType, f_27001_26913_26925(dynType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 24922, 26938);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_25170_25193(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25170, 25193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_25170_25209(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 25170, 25209);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_25232_25261(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25232, 25261);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_25303_25317(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25303, 25317);
                    return return_v;
                }


                string
                f_27001_25355_25361(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 25355, 25361);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_25424_25447(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 25424, 25447);
                    return return_v;
                }


                System.Type
                f_27001_25512_25524(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25512, 25524);
                    return return_v;
                }


                string
                f_27001_25512_25535(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25512, 25535);
                    return return_v;
                }


                string
                f_27001_25546_25570(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25546, 25570);
                    return return_v;
                }


                bool
                f_27001_25470_25571(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25470, 25571);
                    return return_v;
                }


                string
                f_27001_25618_25624(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 25618, 25624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_25715_25721(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 25715, 25721);
                    return return_v;
                }


                bool
                f_27001_25678_25722(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25678, 25722);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_25303_25317_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25303, 25317);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_25971_25993(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 25971, 25993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_26039_26059(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26039, 26059);
                    return return_v;
                }


                bool
                f_27001_26017_26060(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26017, 26060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_26112_26120(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26112, 26120);
                    return return_v;
                }


                bool
                f_27001_26075_26121(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26075, 26121);
                    return return_v;
                }


                bool
                f_27001_26154_26170(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26154, 26170);
                    return return_v;
                }


                bool
                f_27001_26136_26171(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26136, 26171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_26200_26225(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26200, 26225);
                    return return_v;
                }


                System.Type
                f_27001_26287_26304(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26287, 26304);
                    return return_v;
                }


                string
                f_27001_26287_26315(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26287, 26315);
                    return return_v;
                }


                string
                f_27001_26326_26355(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26326, 26355);
                    return return_v;
                }


                bool
                f_27001_26240_26356(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26240, 26356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_26415_26427(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26415, 26427);
                    return return_v;
                }


                bool
                f_27001_26371_26428(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26371, 26428);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_26455_26477(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26455, 26477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_26523_26543(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26523, 26543);
                    return return_v;
                }


                bool
                f_27001_26501_26544(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26501, 26544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_26596_26604(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26596, 26604);
                    return return_v;
                }


                bool
                f_27001_26559_26605(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26559, 26605);
                    return return_v;
                }


                bool
                f_27001_26638_26654(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26638, 26654);
                    return return_v;
                }


                bool
                f_27001_26620_26655(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26620, 26655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_26684_26709(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26684, 26709);
                    return return_v;
                }


                System.Type
                f_27001_26771_26788(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26771, 26788);
                    return return_v;
                }


                string
                f_27001_26771_26799(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26771, 26799);
                    return return_v;
                }


                string
                f_27001_26810_26839(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26810, 26839);
                    return return_v;
                }


                bool
                f_27001_26724_26840(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26724, 26840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_26913_26925(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 26913, 26925);
                    return return_v;
                }


                bool
                f_27001_26869_26926(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 26869, 26926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 24922, 26938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 24922, 26938);
            }
        }

        [WorkItem(537187, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537187")]
        [Fact]
        public void EnumFields()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 26950, 27750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27107, 27186);

                var
                text =
                @"public enum MyEnum 
{
    One,
    Two = 2,
    Three,
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27200, 27235);

                var
                comp = f_27001_27211_27234(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27249, 27315);

                var
                v = f_27001_27257_27305(f_27001_27257_27277(comp), "MyEnum", 0).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27329, 27353);

                f_27001_27329_27352(v);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27367, 27433);

                f_27001_27367_27432(Accessibility.Public, f_27001_27408_27431(v));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27449, 27508);

                var
                fields = f_27001_27462_27507(f_27001_27462_27476(v).OfType<FieldSymbol>())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27522, 27558);

                f_27001_27522_27557(3, f_27001_27544_27556(fields));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27574, 27619);

                f_27001_27574_27618(this, f_27001_27585_27594(fields, 0), "One", isStatic: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27633, 27678);

                f_27001_27633_27677(this, f_27001_27644_27653(fields, 1), "Two", isStatic: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27692, 27739);

                f_27001_27692_27738(this, f_27001_27703_27712(fields, 2), "Three", isStatic: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 26950, 27750);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_27211_27234(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27211, 27234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_27257_27277(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 27257, 27277);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_27257_27305(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27257, 27305);
                    return return_v;
                }


                bool
                f_27001_27329_27352(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27329, 27352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_27408_27431(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 27408, 27431);
                    return return_v;
                }


                bool
                f_27001_27367_27432(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27367, 27432);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_27462_27476(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27462, 27476);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_27001_27462_27507(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27462, 27507);
                    return return_v;
                }


                int
                f_27001_27544_27556(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 27544, 27556);
                    return return_v;
                }


                bool
                f_27001_27522_27557(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27522, 27557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_27001_27585_27594(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 27585, 27594);
                    return return_v;
                }


                int
                f_27001_27574_27618(Microsoft.CodeAnalysis.CSharp.UnitTests.Symbols.TypeTests
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, string
                name, bool
                isStatic)
                {
                    this_param.CheckField((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, isStatic: isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27574, 27618);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_27001_27644_27653(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 27644, 27653);
                    return return_v;
                }


                int
                f_27001_27633_27677(Microsoft.CodeAnalysis.CSharp.UnitTests.Symbols.TypeTests
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, string
                name, bool
                isStatic)
                {
                    this_param.CheckField((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, isStatic: isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27633, 27677);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_27001_27703_27712(System.Collections.Generic.List<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 27703, 27712);
                    return return_v;
                }


                int
                f_27001_27692_27738(Microsoft.CodeAnalysis.CSharp.UnitTests.Symbols.TypeTests
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, string
                name, bool
                isStatic)
                {
                    this_param.CheckField((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, name, isStatic: isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27692, 27738);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 26950, 27750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 26950, 27750);
            }
        }

        private void CheckField(Symbol symbol, string name, bool isStatic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 27762, 28026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27853, 27903);

                f_27001_27853_27902(SymbolKind.Field, f_27001_27890_27901(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27917, 27955);

                f_27001_27917_27954(name, f_27001_27942_27953(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 27969, 28015);

                f_27001_27969_28014(isStatic, f_27001_27998_28013(symbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 27762, 28026);

                Microsoft.CodeAnalysis.SymbolKind
                f_27001_27890_27901(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 27890, 27901);
                    return return_v;
                }


                bool
                f_27001_27853_27902(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27853, 27902);
                    return return_v;
                }


                string
                f_27001_27942_27953(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 27942, 27953);
                    return return_v;
                }


                bool
                f_27001_27917_27954(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27917, 27954);
                    return return_v;
                }


                bool
                f_27001_27998_28013(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 27998, 28013);
                    return return_v;
                }


                bool
                f_27001_27969_28014(bool
                expected, bool
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 27969, 28014);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 27762, 28026);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 27762, 28026);
            }
        }

        [WorkItem(542479, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/542479")]
        [WorkItem(538320, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538320")]
        [Fact] // TODO: Dev10 does not report ERR_SameFullNameAggAgg here - source wins.
        public void SourceAndMetadata_SpecialType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 28038, 29298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 28380, 28566);

                var
                text = @"
using System;
 
namespace System
{
    public struct Void
    {
        static void Main()
        {
            System.Void.Equals(1, 1);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 28580, 28622);

                var
                compilation = f_27001_28598_28621(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 28636, 29287);

                f_27001_28636_29286(compilation, f_27001_28968_29100(f_27001_28968_29031(ErrorCode.WRN_SameFullNameThisAggAgg, "System.Void"), "", "System.Void", f_27001_29065_29091(RuntimeCorLibName), "void"), f_27001_29222_29285(ErrorCode.HDN_UnusedUsingDirective, "using System;"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 28038, 29298);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_28598_28621(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 28598, 28621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_28968_29031(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 28968, 29031);
                    return return_v;
                }


                string
                f_27001_29065_29091(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 29065, 29091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_28968_29100(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 28968, 29100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_29222_29285(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 29222, 29285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_28636_29286(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 28636, 29286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 28038, 29298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 28038, 29298);
            }
        }

        [WorkItem(542479, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/542479")]
        [WorkItem(538320, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538320")]
        [Fact] // TODO: Dev10 does not report ERR_SameFullNameAggAgg here - source wins.
        public void SourceAndMetadata_NonSpecialType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 29310, 30762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 29655, 29717);

                var
                refSource = @"
namespace N
{
    public class C {}
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 29733, 29905);

                var
                csharp = @"
using System;
 
namespace N
{
    public struct C
    {
        static void Main()
        {
            N.C.Equals(1, 1);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 29921, 30009);

                var
                refAsm = f_27001_29934_30008(f_27001_29934_29986(refSource, assemblyName: "RefAsm"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 30023, 30097);

                var
                compilation = f_27001_30041_30096(csharp, references: new[] { refAsm })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 30111, 30751);

                f_27001_30111_30750(compilation, f_27001_30412_30564(f_27001_30412_30467(ErrorCode.WRN_SameFullNameThisAggAgg, "N.C"), "", "N.C", "RefAsm, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "N.C"), f_27001_30686_30749(ErrorCode.HDN_UnusedUsingDirective, "using System;"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 29310, 30762);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_29934_29986(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 29934, 29986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_27001_29934_30008(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ToMetadataReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 29934, 30008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_30041_30096(string
                source, Microsoft.CodeAnalysis.CompilationReference[]
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 30041, 30096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_30412_30467(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 30412, 30467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_30412_30564(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 30412, 30564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_30686_30749(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 30686, 30749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_30111_30750(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 30111, 30750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 29310, 30762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 29310, 30762);
            }
        }

        [WorkItem(542479, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/542479")]
        [Fact]
        public void DuplicateType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 30774, 32118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 30934, 31006);

                string
                referenceText = @"
namespace N
{
    public class C { }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 31020, 31091);

                var
                compilation1 = f_27001_31039_31090(referenceText, assemblyName: "A")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 31105, 31138);

                f_27001_31105_31137(compilation1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 31154, 31225);

                var
                compilation2 = f_27001_31173_31224(referenceText, assemblyName: "B")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 31239, 31272);

                f_27001_31239_31271(compilation2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 31288, 31443);

                var
                testText = @"
namespace M
{
    public struct Test
    {
        static void Main()
        {
            N.C.ToString();
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 31459, 31608);

                var
                compilation3 = f_27001_31478_31607(testText, new[] { f_27001_31514_31558(compilation1), f_27001_31560_31604(compilation2) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 31622, 32107);

                f_27001_31622_32106(compilation3, f_27001_31913_32105(f_27001_31913_31964(ErrorCode.ERR_SameFullNameAggAgg, "N.C"), "A, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null", "N.C", "B, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 30774, 32118);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_31039_31090(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31039, 31090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_31105_31137(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31105, 31137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_31173_31224(string
                source, string
                assemblyName)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31173, 31224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_31239_31271(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31239, 31271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_27001_31514_31558(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31514, 31558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
                f_27001_31560_31604(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31560, 31604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_31478_31607(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference[]
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31478, 31607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_31913_31964(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31913, 31964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_31913_32105(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31913, 32105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_31622_32106(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 31622, 32106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 30774, 32118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 30774, 32118);
            }
        }

        [WorkItem(320, "https://github.com/dotnet/cli/issues/320")]
        [Fact]
        public void DuplicateCoreFxPublicTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 32130, 34755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 32280, 32478);

                var
                sysConsoleSrc = @"
[assembly: System.Reflection.AssemblyVersion(""4.0.0.0"")]

namespace System
{
    public static class Console 
    {
        public static void Goo() {} 
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 32492, 32800);

                var
                sysConsoleRef = f_27001_32512_32799(f_27001_32512_32776(sysConsoleSrc, new[] { f_27001_32593_32612() }, f_27001_32633_32726(TestOptions.ReleaseDll, TestResources.TestKeys.PublicKey_b03f5f7f11d50a3a), assemblyName: "System.Console"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 32816, 32868);

                var
                mainSrc = @"
System.Console.Goo(); 
Goo();
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 32884, 33121);

                var
                main1 = f_27001_32896_33120(new[] { f_27001_32945_32988(mainSrc, options: TestOptions.Script) }, new[] { f_27001_33017_33032(), sysConsoleRef }, f_27001_33068_33119(TestOptions.ReleaseDll, "System.Console"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 33137, 34356);

                f_27001_33137_34355(
                            main1, f_27001_33413_33653(f_27001_33413_33457(ErrorCode.ERR_SameFullNameAggAgg), "System.Console, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Console", "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"), f_27001_33913_34171(f_27001_33913_33975(ErrorCode.ERR_SameFullNameAggAgg, "System.Console"), "System.Console, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Console", "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"), f_27001_34284_34354(f_27001_34284_34333(ErrorCode.ERR_NameNotInContext, "Goo"), "Goo"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 34372, 34702);

                var
                main2 = f_27001_34384_34701(new[] { f_27001_34433_34476(mainSrc, options: TestOptions.Script) }, new[] { f_27001_34505_34520(), sysConsoleRef, f_27001_34537_34559() }, f_27001_34580_34700(f_27001_34580_34631(TestOptions.ReleaseDll, "System.Console"), BinderFlags.IgnoreCorLibraryDuplicatedTypes))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 34718, 34744);

                f_27001_34718_34743(
                            main2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 32130, 34755);

                Microsoft.CodeAnalysis.MetadataReference
                f_27001_32593_32612()
                {
                    var return_v = SystemRuntimePP7Ref;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 32593, 32612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_27001_32633_32726(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                value)
                {
                    var return_v = this_param.WithCryptoPublicKey(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 32633, 32726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_32512_32776(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, string
                assemblyName)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 32512, 32776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_27001_32512_32799(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 32512, 32799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_32945_32988(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = Parse(text, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 32945, 32988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_27001_33017_33032()
                {
                    var return_v = MscorlibRef_v46;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 33017, 33032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_27001_33068_33119(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, params string[]
                usings)
                {
                    var return_v = this_param.WithUsings(usings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 33068, 33119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_32896_33120(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 32896, 33120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_33413_33457(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 33413, 33457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_33413_33653(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 33413, 33653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_33913_33975(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 33913, 33975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_33913_34171(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 33913, 34171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_34284_34333(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 34284, 34333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_34284_34354(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 34284, 34354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_33137_34355(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 33137, 34355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_34433_34476(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = Parse(text, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 34433, 34476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_27001_34505_34520()
                {
                    var return_v = MscorlibRef_v46;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 34505, 34520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_27001_34537_34559()
                {
                    var return_v = SystemRuntimeFacadeRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 34537, 34559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_27001_34580_34631(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, params string[]
                usings)
                {
                    var return_v = this_param.WithUsings(usings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 34580, 34631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_27001_34580_34700(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithTopLevelBinderFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 34580, 34700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_34384_34701(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 34384, 34701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_34718_34743(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 34718, 34743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 32130, 34755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 32130, 34755);
            }
        }

        [Fact]
        public void SimpleGeneric()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 34767, 37327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 34835, 34970);

                var
                text =
                @"namespace NS
{
    public interface IGoo<T> {}

    internal class A<V, U> {}

    public struct S<X, Y, Z> {}
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 34986, 35021);

                var
                comp = f_27001_34997_35020(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35035, 35124);

                var
                namespaceNS = f_27001_35053_35090(f_27001_35053_35073(comp), "NS").First() as NamespaceOrTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35138, 35193);

                f_27001_35138_35192(3, f_27001_35160_35184(namespaceNS).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35209, 35263);

                var
                igoo = f_27001_35220_35254(namespaceNS, "IGoo").First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35277, 35332);

                f_27001_35277_35331(namespaceNS, f_27001_35309_35330(igoo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35346, 35398);

                f_27001_35346_35397(SymbolKind.NamedType, f_27001_35387_35396(igoo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35412, 35466);

                f_27001_35412_35465(TypeKind.Interface, f_27001_35451_35464(igoo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35480, 35549);

                f_27001_35480_35548(Accessibility.Public, f_27001_35521_35547(igoo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35563, 35613);

                f_27001_35563_35612(1, igoo.TypeParameters.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35627, 35680);

                f_27001_35627_35679("T", f_27001_35651_35678(f_27001_35651_35670(igoo)[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35694, 35745);

                f_27001_35694_35744(1, f_27001_35716_35736(igoo).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 35949, 36002);

                var
                classA = f_27001_35962_35993(namespaceNS, "A").First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36016, 36073);

                f_27001_36016_36072(namespaceNS, f_27001_36048_36071(classA));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36087, 36141);

                f_27001_36087_36140(SymbolKind.NamedType, f_27001_36128_36139(classA));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36155, 36207);

                f_27001_36155_36206(TypeKind.Class, f_27001_36190_36205(classA));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36221, 36294);

                f_27001_36221_36293(Accessibility.Internal, f_27001_36264_36292(classA));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36308, 36360);

                f_27001_36308_36359(2, classA.TypeParameters.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36374, 36429);

                f_27001_36374_36428("V", f_27001_36398_36427(f_27001_36398_36419(classA)[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36443, 36498);

                f_27001_36443_36497("U", f_27001_36467_36496(f_27001_36467_36488(classA)[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36553, 36606);

                f_27001_36553_36605(2, f_27001_36575_36597(classA).Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36622, 36676);

                var
                structS = f_27001_36636_36667(namespaceNS, "S").First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36690, 36748);

                f_27001_36690_36747(namespaceNS, f_27001_36722_36746(structS));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36762, 36817);

                f_27001_36762_36816(SymbolKind.NamedType, f_27001_36803_36815(structS));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36831, 36885);

                f_27001_36831_36884(TypeKind.Struct, f_27001_36867_36883(structS));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36899, 36971);

                f_27001_36899_36970(Accessibility.Public, f_27001_36940_36969(structS));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 36985, 37038);

                f_27001_36985_37037(3, structS.TypeParameters.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37052, 37108);

                f_27001_37052_37107("X", f_27001_37076_37106(f_27001_37076_37098(structS)[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37122, 37178);

                f_27001_37122_37177("Y", f_27001_37146_37176(f_27001_37146_37168(structS)[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37192, 37248);

                f_27001_37192_37247("Z", f_27001_37216_37246(f_27001_37216_37238(structS)[2]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37262, 37316);

                f_27001_37262_37315(3, f_27001_37284_37307(structS).Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 34767, 37327);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_34997_35020(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 34997, 35020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_35053_35073(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 35053, 35073);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_35053_35090(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35053, 35090);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_35160_35184(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35160, 35184);
                    return return_v;
                }


                bool
                f_27001_35138_35192(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35138, 35192);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_35220_35254(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35220, 35254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_35309_35330(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 35309, 35330);
                    return return_v;
                }


                bool
                f_27001_35277_35331(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35277, 35331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_35387_35396(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 35387, 35396);
                    return return_v;
                }


                bool
                f_27001_35346_35397(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35346, 35397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_35451_35464(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 35451, 35464);
                    return return_v;
                }


                bool
                f_27001_35412_35465(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35412, 35465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_35521_35547(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 35521, 35547);
                    return return_v;
                }


                bool
                f_27001_35480_35548(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35480, 35548);
                    return return_v;
                }


                bool
                f_27001_35563_35612(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35563, 35612);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_35651_35670(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 35651, 35670);
                    return return_v;
                }


                string
                f_27001_35651_35678(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 35651, 35678);
                    return return_v;
                }


                bool
                f_27001_35627_35679(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35627, 35679);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_27001_35716_35736(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.TypeArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35716, 35736);
                    return return_v;
                }


                bool
                f_27001_35694_35744(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35694, 35744);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_35962_35993(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 35962, 35993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_36048_36071(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36048, 36071);
                    return return_v;
                }


                bool
                f_27001_36016_36072(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36016, 36072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_36128_36139(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36128, 36139);
                    return return_v;
                }


                bool
                f_27001_36087_36140(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36087, 36140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_36190_36205(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36190, 36205);
                    return return_v;
                }


                bool
                f_27001_36155_36206(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36155, 36206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_36264_36292(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36264, 36292);
                    return return_v;
                }


                bool
                f_27001_36221_36293(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36221, 36293);
                    return return_v;
                }


                bool
                f_27001_36308_36359(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36308, 36359);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_36398_36419(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36398, 36419);
                    return return_v;
                }


                string
                f_27001_36398_36427(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36398, 36427);
                    return return_v;
                }


                bool
                f_27001_36374_36428(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36374, 36428);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_36467_36488(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36467, 36488);
                    return return_v;
                }


                string
                f_27001_36467_36496(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36467, 36496);
                    return return_v;
                }


                bool
                f_27001_36443_36497(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36443, 36497);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_27001_36575_36597(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.TypeArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36575, 36597);
                    return return_v;
                }


                bool
                f_27001_36553_36605(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36553, 36605);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_36636_36667(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36636, 36667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_36722_36746(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36722, 36746);
                    return return_v;
                }


                bool
                f_27001_36690_36747(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36690, 36747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_36803_36815(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36803, 36815);
                    return return_v;
                }


                bool
                f_27001_36762_36816(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36762, 36816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_36867_36883(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36867, 36883);
                    return return_v;
                }


                bool
                f_27001_36831_36884(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36831, 36884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_27001_36940_36969(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 36940, 36969);
                    return return_v;
                }


                bool
                f_27001_36899_36970(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36899, 36970);
                    return return_v;
                }


                bool
                f_27001_36985_37037(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 36985, 37037);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_37076_37098(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 37076, 37098);
                    return return_v;
                }


                string
                f_27001_37076_37106(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 37076, 37106);
                    return return_v;
                }


                bool
                f_27001_37052_37107(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37052, 37107);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_37146_37168(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 37146, 37168);
                    return return_v;
                }


                string
                f_27001_37146_37176(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 37146, 37176);
                    return return_v;
                }


                bool
                f_27001_37122_37177(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37122, 37177);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_27001_37216_37238(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 37216, 37238);
                    return return_v;
                }


                string
                f_27001_37216_37246(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 37216, 37246);
                    return return_v;
                }


                bool
                f_27001_37192_37247(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37192, 37247);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_27001_37284_37307(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.TypeArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37284, 37307);
                    return return_v;
                }


                bool
                f_27001_37262_37315(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37262, 37315);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 34767, 37327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 34767, 37327);
            }
        }

        [WorkItem(537199, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537199")]
        [Fact]
        public void UseTypeInNetModule()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 37339, 38284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37504, 37647);

                var
                module1Ref = f_27001_37521_37646(f_27001_37521_37600(f_27001_37552_37599()), display: "netModule1.netmodule")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37663, 37716);

                var
                text = @"class Test
{
    Class1 a = null;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37732, 37779);

                var
                tree = f_27001_37743_37778(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37793, 37862);

                var
                comp = f_27001_37804_37861(text, references: new[] { module1Ref })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37878, 37927);

                var
                globalNS = f_27001_37893_37926(f_27001_37893_37910(comp))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 37941, 37997);

                var
                classTest = f_27001_37957_37988(globalNS, "Test").First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38011, 38071);

                var
                varA = f_27001_38022_38047(classTest, "a").First() as FieldSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38085, 38133);

                f_27001_38085_38132(SymbolKind.Field, f_27001_38122_38131(varA));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38147, 38202);

                f_27001_38147_38201(TypeKind.Class, f_27001_38182_38200(f_27001_38182_38191(varA)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38216, 38273);

                f_27001_38216_38272(SymbolKind.NamedType, f_27001_38257_38271(f_27001_38257_38266(varA)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 37339, 38284);

                byte[]
                f_27001_37552_37599()
                {
                    var return_v = TestResources.SymbolsTests.netModule.netModule1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 37552, 37599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_27001_37521_37600(byte[]
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37521, 37600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_27001_37521_37646(Microsoft.CodeAnalysis.ModuleMetadata
                this_param, string
                display)
                {
                    var return_v = this_param.GetReference(display: display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37521, 37646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_37743_37778(string
                text)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37743, 37778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_37804_37861(string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37804, 37861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_27001_37893_37910(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 37893, 37910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_37893_37926(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 37893, 37926);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_37957_37988(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 37957, 37988);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_38022_38047(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38022, 38047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_38122_38131(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 38122, 38131);
                    return return_v;
                }


                bool
                f_27001_38085_38132(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38085, 38132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_38182_38191(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 38182, 38191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_38182_38200(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 38182, 38200);
                    return return_v;
                }


                bool
                f_27001_38147_38201(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38147, 38201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_38257_38266(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 38257, 38266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_38257_38271(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 38257, 38271);
                    return return_v;
                }


                bool
                f_27001_38216_38272(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38216, 38272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 37339, 38284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 37339, 38284);
            }
        }

        [WorkItem(537344, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537344")]
        [Fact]
        public void ClassNameWithPrecedingAtChar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 38296, 38934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38471, 38569);

                var
                text =
                @"using System;

static class @main
{
    public static void @Main() {}

}

"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38583, 38623);

                var
                comp = f_27001_38594_38622(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38637, 38706);

                var
                typeSym = f_27001_38651_38697(f_27001_38651_38680(f_27001_38651_38664(comp))).First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38720, 38778);

                f_27001_38720_38777("main", f_27001_38747_38776(typeSym));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38792, 38840);

                var
                memSym = f_27001_38805_38831(typeSym, "Main").First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 38854, 38923);

                f_27001_38854_38922("void main.Main()", f_27001_38893_38921(memSym));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 38296, 38934);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_38594_38622(string
                source)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38594, 38622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_27001_38651_38664(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 38651, 38664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_38651_38680(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 38651, 38680);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_38651_38697(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38651, 38697);
                    return return_v;
                }


                string
                f_27001_38747_38776(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38747, 38776);
                    return return_v;
                }


                bool
                f_27001_38720_38777(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38720, 38777);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_38805_38831(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38805, 38831);
                    return return_v;
                }


                string
                f_27001_38893_38921(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38893, 38921);
                    return return_v;
                }


                bool
                f_27001_38854_38922(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 38854, 38922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 38296, 38934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 38296, 38934);
            }
        }

        [Fact]
        public void ReturnsVoidWithoutCorlib()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 38946, 39662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 39116, 39279);

                string
                code = @"
                class Test
                {
                    void Main()
                    {
                    }
                }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 39293, 39333);

                var
                comp = f_27001_39304_39332(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 39347, 39461);

                NamedTypeSymbol
                testTypeSymbol = f_27001_39380_39432(f_27001_39380_39409(f_27001_39380_39393(comp)), "Test").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 39475, 39562);

                MethodSymbol
                methodSymbol = f_27001_39503_39536(testTypeSymbol, "Main").Single() as MethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 39576, 39651);

                f_27001_39576_39650("void Test.Main()", f_27001_39615_39649(methodSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 38946, 39662);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_39304_39332(string
                source)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 39304, 39332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_27001_39380_39393(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 39380, 39393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_39380_39409(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 39380, 39409);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_39380_39432(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 39380, 39432);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_39503_39536(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 39503, 39536);
                    return return_v;
                }


                string
                f_27001_39615_39649(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 39615, 39649);
                    return return_v;
                }


                bool
                f_27001_39576_39650(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 39576, 39650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 38946, 39662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 38946, 39662);
            }
        }

        [WorkItem(537437, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537437")]
        [Fact]
        public void ClassWithMultipleConstr()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 39674, 40362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 39844, 39976);

                var
                text =
                @"public class MyClass 
{
    public MyClass() 
    {
    }

    public MyClass(int DummyInt)
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 39990, 40025);

                var
                comp = f_27001_40001_40024(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 40039, 40117);

                var
                typeSym = f_27001_40053_40108(f_27001_40053_40082(f_27001_40053_40066(comp)), "MyClass").First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 40131, 40253);

                var
                actual = f_27001_40144_40252(", ", f_27001_40162_40251(f_27001_40162_40182(typeSym).Select(symbol => symbol.ToTestDisplayString()), name => name))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 40267, 40351);

                f_27001_40267_40350("MyClass..ctor(), MyClass..ctor(System.Int32 DummyInt)", actual);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 39674, 40362);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_40001_40024(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40001, 40024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_27001_40053_40066(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 40053, 40066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_40053_40082(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 40053, 40082);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_40053_40108(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40053, 40108);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_40162_40182(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40162, 40182);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<string>
                f_27001_40162_40251(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, string>
                keySelector)
                {
                    var return_v = source.OrderBy<string, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40162, 40251);
                    return return_v;
                }


                string
                f_27001_40144_40252(string
                separator, System.Linq.IOrderedEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40144, 40252);
                    return return_v;
                }


                bool
                f_27001_40267_40350(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40267, 40350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 39674, 40362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 39674, 40362);
            }
        }

        [WorkItem(537446, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537446")]
        [Fact]
        public void BaseTypeNotDefinedInSrc()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 40374, 40879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 40544, 40595);

                string
                code = @"
public class MyClass : T1
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 40609, 40649);

                var
                comp = f_27001_40620_40648(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 40663, 40780);

                NamedTypeSymbol
                testTypeSymbol = f_27001_40696_40751(f_27001_40696_40725(f_27001_40696_40709(comp)), "MyClass").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 40794, 40868);

                f_27001_40794_40867("T1", f_27001_40819_40866(f_27001_40819_40844(testTypeSymbol)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 40374, 40879);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_40620_40648(string
                source)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40620, 40648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_27001_40696_40709(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 40696, 40709);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_40696_40725(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 40696, 40725);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_40696_40751(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40696, 40751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_40819_40844(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40819, 40844);
                    return return_v;
                }


                string
                f_27001_40819_40866(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40819, 40866);
                    return return_v;
                }


                bool
                f_27001_40794_40867(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 40794, 40867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 40374, 40879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 40374, 40879);
            }
        }

        [WorkItem(537447, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537447")]
        [Fact]
        public void IllegalTypeArgumentInBaseType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 40891, 41429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 41067, 41143);

                string
                code = @"
public class GC1<T> {}
public class X : GC1<BOGUS> {}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 41157, 41197);

                var
                comp = f_27001_41168_41196(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 41211, 41322);

                NamedTypeSymbol
                testTypeSymbol = f_27001_41244_41293(f_27001_41244_41273(f_27001_41244_41257(comp)), "X").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 41336, 41418);

                f_27001_41336_41417("GC1<BOGUS>", f_27001_41369_41416(f_27001_41369_41394(testTypeSymbol)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 40891, 41429);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_41168_41196(string
                source)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 41168, 41196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_27001_41244_41257(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 41244, 41257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_41244_41273(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 41244, 41273);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_41244_41293(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 41244, 41293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_41369_41394(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 41369, 41394);
                    return return_v;
                }


                string
                f_27001_41369_41416(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 41369, 41416);
                    return return_v;
                }


                bool
                f_27001_41336_41417(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 41336, 41417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 40891, 41429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 40891, 41429);
            }
        }

        [WorkItem(537449, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537449")]
        [Fact]
        public void MethodInDerivedGenericClassWithParamOfIllegalGenericType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 41441, 42388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 41644, 41875);

                var
                text =
                @"public class BaseT<T> : GenericClass {}

public class SubGenericClass<T> : BaseT<T>
{        
    public void Meth3(GC1<T> t) 
    { 
    }

    public void Meth4(System.NonexistentType t)
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 41889, 41924);

                var
                comp = f_27001_41900_41923(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 41938, 42024);

                var
                typeSym = f_27001_41952_42015(f_27001_41952_41981(f_27001_41952_41965(comp)), "SubGenericClass").First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 42038, 42079);

                var
                actualSymbols = f_27001_42058_42078(typeSym)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 42093, 42208);

                var
                actual = f_27001_42106_42207(", ", f_27001_42124_42206(actualSymbols.Select(symbol => symbol.ToTestDisplayString()), name => name))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 42222, 42377);

                f_27001_42222_42376("SubGenericClass<T>..ctor(), void SubGenericClass<T>.Meth3(GC1<T> t), void SubGenericClass<T>.Meth4(System.NonexistentType t)", actual);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 41441, 42388);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_41900_41923(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 41900, 41923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_27001_41952_41965(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 41952, 41965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_41952_41981(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 41952, 41981);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_41952_42015(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 41952, 42015);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_42058_42078(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42058, 42078);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<string>
                f_27001_42124_42206(System.Collections.Generic.IEnumerable<string>
                source, System.Func<string, string>
                keySelector)
                {
                    var return_v = source.OrderBy<string, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42124, 42206);
                    return return_v;
                }


                string
                f_27001_42106_42207(string
                separator, System.Linq.IOrderedEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42106, 42207);
                    return return_v;
                }


                bool
                f_27001_42222_42376(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42222, 42376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 41441, 42388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 41441, 42388);
            }
        }

        [WorkItem(537449, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537449")]
        [Fact]
        public void TestAllInterfaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 42400, 43305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 42564, 42699);

                var
                text =
                @"
interface I1 {}
interface I2 : I1 {}
interface I3 : I1, I2 {}
interface I4 : I2, I3 {}
interface I5 : I3, I4 {}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 42713, 42748);

                var
                comp = f_27001_42724_42747(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 42762, 42796);

                var
                global = f_27001_42775_42795(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 42810, 42883);

                var
                interfaces = f_27001_42827_42882(f_27001_42827_42857(global, "I5", 0).Single())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 42897, 42938);

                f_27001_42897_42937(4, interfaces.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 42952, 43027);

                f_27001_42952_43026(f_27001_42971_43001(global, "I4", 0).Single(), interfaces[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 43041, 43116);

                f_27001_43041_43115(f_27001_43060_43090(global, "I3", 0).Single(), interfaces[1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 43130, 43205);

                f_27001_43130_43204(f_27001_43149_43179(global, "I2", 0).Single(), interfaces[2]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 43219, 43294);

                f_27001_43219_43293(f_27001_43238_43268(global, "I1", 0).Single(), interfaces[3]);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 42400, 43305);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_42724_42747(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42724, 42747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_42775_42795(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 42775, 42795);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_42827_42857(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42827, 42857);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_42827_42882(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.AllInterfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42827, 42882);
                    return return_v;
                }


                bool
                f_27001_42897_42937(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42897, 42937);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_42971_43001(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42971, 43001);
                    return return_v;
                }


                bool
                f_27001_42952_43026(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 42952, 43026);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_43060_43090(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43060, 43090);
                    return return_v;
                }


                bool
                f_27001_43041_43115(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43041, 43115);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_43149_43179(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43149, 43179);
                    return return_v;
                }


                bool
                f_27001_43130_43204(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43130, 43204);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_43238_43268(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43238, 43268);
                    return return_v;
                }


                bool
                f_27001_43219_43293(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43219, 43293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 42400, 43305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 42400, 43305);
            }
        }

        [WorkItem(2750, "DevDiv_Projects/Roslyn")]
        [Fact]
        public void NamespaceSameNameAsMetadataClass()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 43317, 43898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 43456, 43586);

                var
                text = @"
using System;

namespace Convert
{
    class Test
    {
        protected int M() { return 0; }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 43600, 43635);

                var
                comp = f_27001_43611_43634(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 43649, 43683);

                var
                global = f_27001_43662_43682(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 43697, 43763);

                var
                ns = f_27001_43706_43734(global, "Convert").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 43777, 43843);

                var
                type1 = f_27001_43789_43814(ns, "Test").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 43857, 43887);

                var
                mems = f_27001_43868_43886(type1)
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 43317, 43898);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_43611_43634(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43611, 43634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_43662_43682(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 43662, 43682);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_43706_43734(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43706, 43734);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_43789_43814(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43789, 43814);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_43868_43886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 43868, 43886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 43317, 43898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 43317, 43898);
            }
        }

        [WorkItem(537685, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537685")]
        [Fact]
        public void NamespaceMemberArity()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 43910, 44592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44077, 44257);

                var
                text = @"
namespace NS1.NS2
{
    internal class A<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11> {}
    internal proteced class B<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, T11, T12> {}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44271, 44306);

                var
                comp = f_27001_44282_44305(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44320, 44354);

                var
                global = f_27001_44333_44353(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44368, 44431);

                var
                ns1 = f_27001_44378_44402(global, "NS1").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44445, 44505);

                var
                ns2 = f_27001_44455_44476(ns1, "NS2").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44519, 44547);

                var
                mems = f_27001_44530_44546(ns2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44561, 44581);

                var
                x = mems.Length
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 43910, 44592);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_44282_44305(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 44282, 44305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_44333_44353(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 44333, 44353);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_44378_44402(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 44378, 44402);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_44455_44476(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 44455, 44476);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_44530_44546(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 44530, 44546);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 43910, 44592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 43910, 44592);
            }
        }

        [WorkItem(3178, "DevDiv_Projects/Roslyn")]
        [Fact]
        public void NamespaceSameNameAsMetadataNamespace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 44604, 45226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44747, 44907);

                var
                text = @"
using System;
using System.Collections.Generic;

namespace Collections {
    class Test<T> 	{
        List<T> itemList = null;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44921, 44956);

                var
                comp = f_27001_44932_44955(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 44970, 45004);

                var
                global = f_27001_44983_45003(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45018, 45088);

                var
                ns = f_27001_45027_45059(global, "Collections").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45102, 45171);

                var
                type1 = f_27001_45114_45142(ns, "Test", 1).Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45185, 45215);

                var
                mems = f_27001_45196_45214(type1)
                ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 44604, 45226);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_44932_44955(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 44932, 44955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_44983_45003(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 44983, 45003);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_45027_45059(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 45027, 45059);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_45114_45142(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param, string
                name, int
                arity)
                {
                    var return_v = this_param.GetTypeMembers(name, arity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 45114, 45142);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_45196_45214(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 45196, 45214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 44604, 45226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 44604, 45226);
            }
        }

        [WorkItem(537957, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537957")]
        [Fact]
        public void EmptyNameErrorSymbolErr()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 45238, 45881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45408, 45480);

                var
                text = @"
namespace NS
{
  class A { }
  class B : A[] {}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45494, 45529);

                var
                comp = f_27001_45505_45528(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45543, 45577);

                var
                global = f_27001_45556_45576(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45591, 45653);

                var
                ns1 = f_27001_45601_45624(global, "NS").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45667, 45726);

                var
                syma = f_27001_45678_45697(ns1, "A").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45740, 45818);

                var
                bt = f_27001_45749_45817((f_27001_45750_45769(ns1, "B").FirstOrDefault() as NamedTypeSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 45832, 45870);

                f_27001_45832_45869("Object", f_27001_45861_45868(bt));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 45238, 45881);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_45505_45528(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 45505, 45528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_45556_45576(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 45556, 45576);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_45601_45624(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 45601, 45624);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_45678_45697(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 45678, 45697);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_45750_45769(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 45750, 45769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_45749_45817(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 45749, 45817);
                    return return_v;
                }


                string
                f_27001_45861_45868(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 45861, 45868);
                    return return_v;
                }


                bool
                f_27001_45832_45869(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 45832, 45869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 45238, 45881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 45238, 45881);
            }
        }

        [WorkItem(538210, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538210")]
        [Fact]
        public void NestedTypeAccessibility01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 45893, 46317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 46065, 46142);

                var
                text = @"
using System;

class A
{
    public class B : A { }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 46156, 46179);

                var
                tree = f_27001_46167_46178(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 46193, 46228);

                var
                comp = f_27001_46204_46227(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 46242, 46306);

                var temp = f_27001_46264_46296(comp);
                f_27001_46242_46305(0, f_27001_46264_46304(ref temp));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 45893, 46317);

                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_46167_46178(string
                text)
                {
                    var return_v = Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46167, 46178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_46204_46227(Microsoft.CodeAnalysis.SyntaxTree
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46204, 46227);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_46264_46296(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDeclarationDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46264, 46296);
                    return return_v;
                }


                int
                f_27001_46264_46304(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46264, 46304);
                    return return_v;
                }


                bool
                f_27001_46242_46305(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46242, 46305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 45893, 46317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 45893, 46317);
            }
        }

        [WorkItem(538242, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538242")]
        [Fact]
        public void PartialClassWithBaseType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 46329, 46758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 46500, 46583);

                var
                text = @"
class C1 { }
partial class C2 : C1 {}
partial class C2 : C1 {}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 46597, 46620);

                var
                tree = f_27001_46608_46619(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 46634, 46669);

                var
                comp = f_27001_46645_46668(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 46683, 46747);

                var temp2 = f_27001_46705_46737(comp);
                f_27001_46683_46746(0, f_27001_46705_46745(ref temp2));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 46329, 46758);

                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_46608_46619(string
                text)
                {
                    var return_v = Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46608, 46619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_46645_46668(Microsoft.CodeAnalysis.SyntaxTree
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46645, 46668);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_46705_46737(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDeclarationDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46705, 46737);
                    return return_v;
                }


                int
                f_27001_46705_46745(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46705, 46745);
                    return return_v;
                }


                bool
                f_27001_46683_46746(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 46683, 46746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 46329, 46758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 46329, 46758);
            }
        }

        [WorkItem(537873, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537873")]
        [Fact]
        public void InaccessibleTypesSkipped()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 46770, 47597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 46941, 47114);

                var
                text = @"
class B
{
    public class A
    {
        public class X { }
    }
}
class C : B
{
    class A { } /* private */
}
class D : C
{
    A.X x;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47128, 47151);

                var
                tree = f_27001_47139_47150(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47165, 47200);

                var
                comp = f_27001_47176_47199(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47214, 47329);

                f_27001_47214_47328(0, f_27001_47236_47268(comp).Count(diag => !ErrorFacts.IsWarning((ErrorCode)diag.Code)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47343, 47377);

                var
                global = f_27001_47356_47376(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47391, 47450);

                var
                d = f_27001_47399_47421(global, "D").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47464, 47514);

                var
                x = f_27001_47472_47489(d, "x").Single() as FieldSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47528, 47586);

                f_27001_47528_47585("B.A.X", f_27001_47556_47584(f_27001_47556_47562(x)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 46770, 47597);

                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_47139_47150(string
                text)
                {
                    var return_v = Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47139, 47150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_47176_47199(Microsoft.CodeAnalysis.SyntaxTree
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47176, 47199);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_47236_47268(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDeclarationDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47236, 47268);
                    return return_v;
                }


                bool
                f_27001_47214_47328(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47214, 47328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_47356_47376(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 47356, 47376);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_47399_47421(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47399, 47421);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_47472_47489(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47472, 47489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_47556_47562(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 47556, 47562);
                    return return_v;
                }


                string
                f_27001_47556_47584(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47556, 47584);
                    return return_v;
                }


                bool
                f_27001_47528_47585(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47528, 47585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 46770, 47597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 46770, 47597);
            }
        }

        [WorkItem(537970, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537970")]
        [Fact]
        public void ImportedVersusSource()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 47609, 48564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47776, 47884);

                var
                text = @"
namespace System
{
    public class String { }
    public class MyString : String { }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47898, 47921);

                var
                tree = f_27001_47909_47920(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47935, 47970);

                var
                comp = f_27001_47946_47969(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 47984, 48091);

                f_27001_47984_48090(0, f_27001_48006_48038(comp).Count(e => e.Severity >= DiagnosticSeverity.Error));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 48105, 48139);

                var
                global = f_27001_48118_48138(comp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 48153, 48222);

                var
                system = f_27001_48166_48193(global, "System").Single() as NamespaceSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 48236, 48309);

                var
                mystring = f_27001_48251_48280(system, "MyString").Single() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 48323, 48362);

                var
                sourceString = f_27001_48342_48361(mystring)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 48376, 48553);

                f_27001_48376_48552(0, f_27001_48415_48440(sourceString).Count(m => !(m is MethodSymbol) || (m as MethodSymbol).MethodKind != MethodKind.Constructor));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 47609, 48564);

                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_47909_47920(string
                text)
                {
                    var return_v = Parse(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47909, 47920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_47946_47969(Microsoft.CodeAnalysis.SyntaxTree
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47946, 47969);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_48006_48038(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDeclarationDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 48006, 48038);
                    return return_v;
                }


                bool
                f_27001_47984_48090(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 47984, 48090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_48118_48138(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 48118, 48138);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_48166_48193(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 48166, 48193);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_48251_48280(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 48251, 48280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_48342_48361(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 48342, 48361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_48415_48440(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 48415, 48440);
                    return return_v;
                }


                bool
                f_27001_48376_48552(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 48376, 48552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 47609, 48564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 47609, 48564);
            }
        }

        [Fact, WorkItem(538012, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538012"), WorkItem(538580, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538580")]
        public void ErrorTypeSymbolWithArity()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 48576, 50924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 48819, 49272);

                var
                text = @"
namespace N
{
    public interface IGoo<T, V, U> {}
    public interface IBar<T> {}

    public class A : NotExist<int, int>
    {
        public class BB {}
        public class B : BB, IGoo<string, byte>
        {
        }
    }

    public class C : IBar<char, string>
    {
        // NotExist is binding error, Not error symbol
        public class D : IGoo<char, ulong, NotExist>
        {
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49288, 49323);

                var
                comp = f_27001_49299_49322(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49337, 49390);

                var temp3 = f_27001_49359_49380(comp);
                f_27001_49337_49389(4, f_27001_49359_49388(ref temp3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49406, 49453);

                var
                global = f_27001_49419_49452(f_27001_49419_49436(comp))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49467, 49515);

                var
                ns = f_27001_49476_49514(global, "N")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49531, 49578);

                var
                typeA = f_27001_49543_49577(ns, "A")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49592, 49622);

                var
                typeAb = f_27001_49605_49621(typeA)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49636, 49690);

                f_27001_49636_49689(SymbolKind.ErrorType, f_27001_49677_49688(typeAb));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49704, 49740);

                f_27001_49704_49739(2, f_27001_49726_49738(typeAb));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49756, 49806);

                var
                typeB = f_27001_49768_49805(typeA, "B")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49820, 49868);

                f_27001_49820_49867("BB", f_27001_49845_49866(f_27001_49845_49861(typeB)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49882, 49923);

                var
                typeBi = f_27001_49895_49913(typeB).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49937, 49977);

                f_27001_49937_49976("IGoo", f_27001_49964_49975(typeBi));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 49991, 50045);

                f_27001_49991_50044(SymbolKind.ErrorType, f_27001_50032_50043(typeBi));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50059, 50095);

                f_27001_50059_50094(2, f_27001_50081_50093(typeBi));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50166, 50213);

                var
                typeC = f_27001_50178_50212(ns, "C")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50227, 50303);

                f_27001_50227_50302(SpecialType.System_Object, f_27001_50273_50301(f_27001_50273_50289(typeC)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50317, 50358);

                var
                typeCi = f_27001_50330_50348(typeC).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50372, 50412);

                f_27001_50372_50411("IBar", f_27001_50399_50410(typeCi));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50426, 50480);

                f_27001_50426_50479(SymbolKind.ErrorType, f_27001_50467_50478(typeCi));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50494, 50530);

                f_27001_50494_50529(2, f_27001_50516_50528(typeCi));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50601, 50651);

                var
                typeD = f_27001_50613_50650(typeC, "D")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50665, 50706);

                var
                typeDi = f_27001_50678_50696(typeD).Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50720, 50760);

                f_27001_50720_50759("IGoo", f_27001_50747_50758(typeDi));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50774, 50826);

                f_27001_50774_50825(3, typeDi.TypeParameters.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 50840, 50913);

                f_27001_50840_50912(SymbolKind.ErrorType, f_27001_50881_50911(f_27001_50881_50903(typeDi)[2]));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 48576, 50924);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_49299_49322(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49299, 49322);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_49359_49380(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49359, 49380);
                    return return_v;
                }


                int
                f_27001_49359_49388(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                source)
                {
                    var return_v = source.Count<Microsoft.CodeAnalysis.Diagnostic>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49359, 49388);
                    return return_v;
                }


                bool
                f_27001_49337_49389(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49337, 49389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_27001_49419_49436(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 49419, 49436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_49419_49452(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 49419, 49452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_49476_49514(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49476, 49514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_49543_49577(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49543, 49577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_49605_49621(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49605, 49621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_49677_49688(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 49677, 49688);
                    return return_v;
                }


                bool
                f_27001_49636_49689(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49636, 49689);
                    return return_v;
                }


                int
                f_27001_49726_49738(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 49726, 49738);
                    return return_v;
                }


                bool
                f_27001_49704_49739(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49704, 49739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_49768_49805(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49768, 49805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_49845_49861(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49845, 49861);
                    return return_v;
                }


                string
                f_27001_49845_49866(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 49845, 49866);
                    return return_v;
                }


                bool
                f_27001_49820_49867(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49820, 49867);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_49895_49913(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49895, 49913);
                    return return_v;
                }


                string
                f_27001_49964_49975(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 49964, 49975);
                    return return_v;
                }


                bool
                f_27001_49937_49976(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49937, 49976);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_50032_50043(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 50032, 50043);
                    return return_v;
                }


                bool
                f_27001_49991_50044(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 49991, 50044);
                    return return_v;
                }


                int
                f_27001_50081_50093(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 50081, 50093);
                    return return_v;
                }


                bool
                f_27001_50059_50094(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50059, 50094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_50178_50212(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50178, 50212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_50273_50289(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50273, 50289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_27001_50273_50301(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 50273, 50301);
                    return return_v;
                }


                bool
                f_27001_50227_50302(Microsoft.CodeAnalysis.SpecialType
                expected, Microsoft.CodeAnalysis.SpecialType
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50227, 50302);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_50330_50348(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50330, 50348);
                    return return_v;
                }


                string
                f_27001_50399_50410(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 50399, 50410);
                    return return_v;
                }


                bool
                f_27001_50372_50411(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50372, 50411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_50467_50478(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 50467, 50478);
                    return return_v;
                }


                bool
                f_27001_50426_50479(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50426, 50479);
                    return return_v;
                }


                int
                f_27001_50516_50528(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 50516, 50528);
                    return return_v;
                }


                bool
                f_27001_50494_50529(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50494, 50529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_50613_50650(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50613, 50650);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_50678_50696(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50678, 50696);
                    return return_v;
                }


                string
                f_27001_50747_50758(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 50747, 50758);
                    return return_v;
                }


                bool
                f_27001_50720_50759(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50720, 50759);
                    return return_v;
                }


                bool
                f_27001_50774_50825(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50774, 50825);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_27001_50881_50903(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.TypeArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50881, 50903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_50881_50911(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 50881, 50911);
                    return return_v;
                }


                bool
                f_27001_50840_50912(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 50840, 50912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 48576, 50924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 48576, 50924);
            }
        }

        [Fact]
        public void ErrorWithoutInterfaceGuess()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 50936, 55565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 51017, 52127);

                var
                text = @"
class Base<T> { }
interface Interface1<T> { }
interface Interface2<T> { }

//all one on part
partial class Derived0 : Base<int, int>, Interface1<int, int> { } 
partial class Derived0 { }

//all one on part, order reversed
partial class Derived1 : Interface1<int, int>, Base<int, int> { } 
partial class Derived1 { }

//interface on first part, base type on second
partial class Derived2 : Interface1<int, int> { } 
partial class Derived2 : Base<int, int> { }

//base type on first part, interface on second
partial class Derived3 : Base<int, int> { }
partial class Derived3 : Interface1<int, int> { } 

//interfaces on both parts
partial class Derived4 : Interface1<int, int> { }
partial class Derived4 : Interface2<int, int> { } 

//interfaces on both parts, base type on first
partial class Derived5 : Base<int, int>, Interface1<int, int> { }
partial class Derived5 : Interface2<int, int> { } 

//interfaces on both parts, base type on second
partial class Derived6 : Interface2<int, int> { } 
partial class Derived6 : Base<int, int>, Interface1<int, int> { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 52143, 52178);

                var
                comp = f_27001_52154_52177(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 52192, 52239);

                var
                global = f_27001_52205_52238(f_27001_52205_52222(comp))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 52255, 52312);

                var
                baseType = f_27001_52270_52311(global, "Base")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 52326, 52391);

                var
                interface1 = f_27001_52343_52390(global, "Interface1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 52405, 52470);

                var
                interface2 = f_27001_52422_52469(global, "Interface2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 52486, 52540);

                f_27001_52486_52539(TypeKind.Class, f_27001_52521_52538(baseType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 52554, 52614);

                f_27001_52554_52613(TypeKind.Interface, f_27001_52593_52612(interface1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 52628, 52688);

                f_27001_52628_52687(TypeKind.Interface, f_27001_52667_52686(interface2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 52799, 53302);

                var
                derivedTypes = new[]
                            {
f_27001_52856_52901(                global, "Derived0"),
f_27001_52920_52965(                global, "Derived1"),
f_27001_52984_53029(                global, "Derived2"),
f_27001_53048_53093(                global, "Derived3"),
f_27001_53112_53157(                global, "Derived4"),
f_27001_53176_53221(                global, "Derived5"),
f_27001_53240_53285(                global, "Derived6"),
                            }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 53318, 53755);
                    foreach (var derived in f_27001_53342_53354_I(derivedTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(27001, 53318, 53755);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 53388, 53576) || true) && (f_27001_53392_53422(f_27001_53392_53410(derived)) != SpecialType.System_Object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(27001, 53388, 53576);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 53493, 53557);

                            f_27001_53493_53556(TypeKind.Error, f_27001_53528_53555(f_27001_53528_53546(derived)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(27001, 53388, 53576);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 53594, 53740);
                            foreach (var i in f_27001_53612_53632_I(f_27001_53612_53632(derived)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(27001, 53594, 53740);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 53674, 53721);

                                f_27001_53674_53720(TypeKind.Error, f_27001_53709_53719(i));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(27001, 53594, 53740);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(27001, 1, 147);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(27001, 1, 147);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(27001, 53318, 53755);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(27001, 1, 438);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(27001, 1, 438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 53771, 53846);

                f_27001_53771_53845(baseType, f_27001_53799_53844(f_27001_53817_53843(derivedTypes[0])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 53860, 53948);

                f_27001_53860_53947(interface1, f_27001_53890_53946(f_27001_53908_53936(derivedTypes[0]).Single()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54032, 54118);

                f_27001_54032_54117(SpecialType.System_Object, f_27001_54078_54116(f_27001_54078_54104(derivedTypes[1])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54132, 54214);

                f_27001_54132_54213(interface1, f_27001_54162_54212(f_27001_54180_54208(derivedTypes[1])[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54228, 54308);

                f_27001_54228_54307(baseType, f_27001_54256_54306(f_27001_54274_54302(derivedTypes[1])[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54324, 54399);

                f_27001_54324_54398(baseType, f_27001_54352_54397(f_27001_54370_54396(derivedTypes[2])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54413, 54501);

                f_27001_54413_54500(interface1, f_27001_54443_54499(f_27001_54461_54489(derivedTypes[2]).Single()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54517, 54592);

                f_27001_54517_54591(baseType, f_27001_54545_54590(f_27001_54563_54589(derivedTypes[3])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54606, 54694);

                f_27001_54606_54693(interface1, f_27001_54636_54692(f_27001_54654_54682(derivedTypes[3]).Single()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54710, 54796);

                f_27001_54710_54795(SpecialType.System_Object, f_27001_54756_54794(f_27001_54756_54782(derivedTypes[4])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54810, 54892);

                f_27001_54810_54891(interface1, f_27001_54840_54890(f_27001_54858_54886(derivedTypes[4])[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 54906, 54988);

                f_27001_54906_54987(interface2, f_27001_54936_54986(f_27001_54954_54982(derivedTypes[4])[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 55004, 55079);

                f_27001_55004_55078(baseType, f_27001_55032_55077(f_27001_55050_55076(derivedTypes[5])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 55093, 55175);

                f_27001_55093_55174(interface1, f_27001_55123_55173(f_27001_55141_55169(derivedTypes[5])[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 55189, 55271);

                f_27001_55189_55270(interface2, f_27001_55219_55269(f_27001_55237_55265(derivedTypes[5])[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 55287, 55362);

                f_27001_55287_55361(baseType, f_27001_55315_55360(f_27001_55333_55359(derivedTypes[6])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 55376, 55458);

                f_27001_55376_55457(interface1, f_27001_55406_55456(f_27001_55424_55452(derivedTypes[6])[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 55472, 55554);

                f_27001_55472_55553(interface2, f_27001_55502_55552(f_27001_55520_55548(derivedTypes[6])[0]));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 50936, 55565);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_52154_52177(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52154, 52177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_27001_52205_52222(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 52205, 52222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_52205_52238(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 52205, 52238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_52270_52311(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52270, 52311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_52343_52390(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52343, 52390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_52422_52469(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52422, 52469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_52521_52538(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 52521, 52538);
                    return return_v;
                }


                bool
                f_27001_52486_52539(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52486, 52539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_52593_52612(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 52593, 52612);
                    return return_v;
                }


                bool
                f_27001_52554_52613(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52554, 52613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_52667_52686(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 52667, 52686);
                    return return_v;
                }


                bool
                f_27001_52628_52687(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52628, 52687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_52856_52901(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52856, 52901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_52920_52965(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52920, 52965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_52984_53029(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 52984, 53029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_53048_53093(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53048, 53093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_53112_53157(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53112, 53157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_53176_53221(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53176, 53221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_53240_53285(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53240, 53285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_53392_53410(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53392, 53410);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_27001_53392_53422(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 53392, 53422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_53528_53546(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53528, 53546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_53528_53555(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 53528, 53555);
                    return return_v;
                }


                bool
                f_27001_53493_53556(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53493, 53556);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_53612_53632(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53612, 53632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_53709_53719(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 53709, 53719);
                    return return_v;
                }


                bool
                f_27001_53674_53720(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53674, 53720);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_53612_53632_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53612, 53632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                f_27001_53342_53354_I(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53342, 53354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_53817_53843(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53817, 53843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_53799_53844(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53799, 53844);
                    return return_v;
                }


                bool
                f_27001_53771_53845(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53771, 53845);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_53908_53936(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53908, 53936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_53890_53946(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53890, 53946);
                    return return_v;
                }


                bool
                f_27001_53860_53947(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 53860, 53947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_54078_54104(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54078, 54104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_27001_54078_54116(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 54078, 54116);
                    return return_v;
                }


                bool
                f_27001_54032_54117(Microsoft.CodeAnalysis.SpecialType
                expected, Microsoft.CodeAnalysis.SpecialType
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54032, 54117);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_54180_54208(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54180, 54208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_54162_54212(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54162, 54212);
                    return return_v;
                }


                bool
                f_27001_54132_54213(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54132, 54213);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_54274_54302(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54274, 54302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_54256_54306(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54256, 54306);
                    return return_v;
                }


                bool
                f_27001_54228_54307(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54228, 54307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_54370_54396(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54370, 54396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_54352_54397(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54352, 54397);
                    return return_v;
                }


                bool
                f_27001_54324_54398(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54324, 54398);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_54461_54489(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54461, 54489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_54443_54499(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54443, 54499);
                    return return_v;
                }


                bool
                f_27001_54413_54500(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54413, 54500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_54563_54589(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54563, 54589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_54545_54590(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54545, 54590);
                    return return_v;
                }


                bool
                f_27001_54517_54591(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54517, 54591);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_54654_54682(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54654, 54682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_54636_54692(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54636, 54692);
                    return return_v;
                }


                bool
                f_27001_54606_54693(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54606, 54693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_54756_54782(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54756, 54782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_27001_54756_54794(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 54756, 54794);
                    return return_v;
                }


                bool
                f_27001_54710_54795(Microsoft.CodeAnalysis.SpecialType
                expected, Microsoft.CodeAnalysis.SpecialType
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54710, 54795);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_54858_54886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54858, 54886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_54840_54890(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54840, 54890);
                    return return_v;
                }


                bool
                f_27001_54810_54891(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54810, 54891);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_54954_54982(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54954, 54982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_54936_54986(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54936, 54986);
                    return return_v;
                }


                bool
                f_27001_54906_54987(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 54906, 54987);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_55050_55076(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55050, 55076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_55032_55077(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55032, 55077);
                    return return_v;
                }


                bool
                f_27001_55004_55078(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55004, 55078);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_55141_55169(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55141, 55169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_55123_55173(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55123, 55173);
                    return return_v;
                }


                bool
                f_27001_55093_55174(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55093, 55174);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_55237_55265(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55237, 55265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_55219_55269(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55219, 55269);
                    return return_v;
                }


                bool
                f_27001_55189_55270(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55189, 55270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_55333_55359(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55333, 55359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_55315_55360(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55315, 55360);
                    return return_v;
                }


                bool
                f_27001_55287_55361(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55287, 55361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_55424_55452(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55424, 55452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_55406_55456(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55406, 55456);
                    return return_v;
                }


                bool
                f_27001_55376_55457(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55376, 55457);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_55520_55548(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.Interfaces();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55520, 55548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_55502_55552(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = ExtractErrorGuess(typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55502, 55552);
                    return return_v;
                }


                bool
                f_27001_55472_55553(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55472, 55553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 50936, 55565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 50936, 55565);
            }
        }

        private static TypeSymbol ExtractErrorGuess(NamedTypeSymbol typeSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(27001, 55577, 55791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 55673, 55729);

                f_27001_55673_55728(TypeKind.Error, f_27001_55708_55727(typeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 55743, 55780);

                return f_27001_55750_55779(typeSymbol);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(27001, 55577, 55791);

                Microsoft.CodeAnalysis.TypeKind
                f_27001_55708_55727(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 55708, 55727);
                    return return_v;
                }


                bool
                f_27001_55673_55728(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55673, 55728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_27001_55750_55779(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetNonErrorGuess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 55750, 55779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 55577, 55791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 55577, 55791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [WorkItem(2195, "DevDiv_Projects/Roslyn")]
        [Fact]
        public void CircularNestedInterfaceDeclaration()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 55803, 56549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 55944, 56104);

                var
                text = @"
class Bar : Bar.IGoo
{
    public interface IGoo { Goo GetGoo(); }

    public class Goo { }

    public Goo GetGoo() { return null; }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 56118, 56153);

                var
                comp = f_27001_56129_56152(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 56167, 56209);

                f_27001_56167_56208(f_27001_56186_56207(comp));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 56223, 56267);

                var
                bar = f_27001_56233_56266(comp, "Bar")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 56281, 56367);

                var
                iGooGetGoo = f_27001_56298_56357(f_27001_56298_56336(comp, "Bar+IGoo"), "GetGoo").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 56381, 56470);

                MethodSymbol
                getGoo = (MethodSymbol)f_27001_56417_56469(bar, iGooGetGoo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 56484, 56538);

                f_27001_56484_56537("Bar.GetGoo()", f_27001_56519_56536(getGoo));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 55803, 56549);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_56129_56152(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56129, 56152);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_56186_56207(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56186, 56207);
                    return return_v;
                }


                bool
                f_27001_56167_56208(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56167, 56208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_27001_56233_56266(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56233, 56266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_27001_56298_56336(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56298, 56336);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_56298_56357(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56298, 56357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_27001_56417_56469(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                interfaceMember)
                {
                    var return_v = this_param.FindImplementationForInterfaceMember(interfaceMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56417, 56469);
                    return return_v;
                }


                string
                f_27001_56519_56536(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56519, 56536);
                    return return_v;
                }


                bool
                f_27001_56484_56537(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56484, 56537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 55803, 56549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 55803, 56549);
            }
        }

        [WorkItem(3684, "DevDiv_Projects/Roslyn")]
        [Fact]
        public void ExplicitlyImplementGenericInterface()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 56561, 56940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 56703, 56824);

                var
                text = @"
public interface I<Q>
{
    void Goo();
}
public class Test1<Q> : I<Q>
{
    void I<Q>.Goo() {}
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 56838, 56873);

                var
                comp = f_27001_56849_56872(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 56887, 56929);

                f_27001_56887_56928(f_27001_56906_56927(comp));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 56561, 56940);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_56849_56872(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56849, 56872);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_56906_56927(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56906, 56927);
                    return return_v;
                }


                bool
                f_27001_56887_56928(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 56887, 56928);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 56561, 56940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 56561, 56940);
            }
        }

        [Fact]
        public void MetadataNameOfGenericTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 56952, 57924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57033, 57117);

                var
                compilation = f_27001_57051_57116(@"
class Gen1<T,U,V>
{}
class NonGen
{}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57133, 57176);

                var
                globalNS = f_27001_57148_57175(compilation)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57190, 57261);

                var
                gen1Class = ((NamedTypeSymbol)f_27001_57224_57251(globalNS, "Gen1").First())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57275, 57318);

                f_27001_57275_57317("Gen1", f_27001_57302_57316(gen1Class));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57332, 57385);

                f_27001_57332_57384("Gen1`3", f_27001_57361_57383(gen1Class));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57399, 57474);

                var
                nonGenClass = ((NamedTypeSymbol)f_27001_57435_57464(globalNS, "NonGen").First())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57488, 57535);

                f_27001_57488_57534("NonGen", f_27001_57517_57533(nonGenClass));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57549, 57604);

                f_27001_57549_57603("NonGen", f_27001_57578_57602(nonGenClass));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57618, 57688);

                var
                system = ((NamespaceSymbol)f_27001_57649_57678(globalNS, "System").First())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57702, 57777);

                var
                equatable = ((NamedTypeSymbol)f_27001_57736_57767(system, "IEquatable").First())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57791, 57840);

                f_27001_57791_57839("IEquatable", f_27001_57824_57838(equatable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 57854, 57913);

                f_27001_57854_57912("IEquatable`1", f_27001_57889_57911(equatable));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 56952, 57924);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_57051_57116(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57051, 57116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_57148_57175(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 57148, 57175);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_57224_57251(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57224, 57251);
                    return return_v;
                }


                string
                f_27001_57302_57316(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 57302, 57316);
                    return return_v;
                }


                bool
                f_27001_57275_57317(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57275, 57317);
                    return return_v;
                }


                string
                f_27001_57361_57383(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 57361, 57383);
                    return return_v;
                }


                bool
                f_27001_57332_57384(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57332, 57384);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_57435_57464(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57435, 57464);
                    return return_v;
                }


                string
                f_27001_57517_57533(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 57517, 57533);
                    return return_v;
                }


                bool
                f_27001_57488_57534(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57488, 57534);
                    return return_v;
                }


                string
                f_27001_57578_57602(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 57578, 57602);
                    return return_v;
                }


                bool
                f_27001_57549_57603(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57549, 57603);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_57649_57678(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57649, 57678);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_57736_57767(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57736, 57767);
                    return return_v;
                }


                string
                f_27001_57824_57838(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 57824, 57838);
                    return return_v;
                }


                bool
                f_27001_57791_57839(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57791, 57839);
                    return return_v;
                }


                string
                f_27001_57889_57911(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 57889, 57911);
                    return return_v;
                }


                bool
                f_27001_57854_57912(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 57854, 57912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 56952, 57924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 56952, 57924);
            }
        }

        [WorkItem(545154, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/545154")]
        [ClrOnlyFact]
        public void MultiDimArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 57936, 58401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 58103, 58211);

                var
                r = f_27001_58111_58210(f_27001_58145_58209(f_27001_58145_58189()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 58225, 58338);

                var
                source = @"
class Program
{
    static void Main()
    {
        MultiDimArrays.Foo(null);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 58352, 58390);

                f_27001_58352_58389(this, source, new[] { r });
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 57936, 58401);

                byte[]
                f_27001_58145_58189()
                {
                    var return_v = TestResources.SymbolsTests.Methods.CSMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 58145, 58189);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_27001_58145_58209(byte[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<byte>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58145, 58209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_27001_58111_58210(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = MetadataReference.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58111, 58210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_27001_58352_58389(Microsoft.CodeAnalysis.CSharp.UnitTests.Symbols.TypeTests
                this_param, string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58352, 58389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 57936, 58401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 57936, 58401);
            }
        }

        [Fact, WorkItem(530171, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/530171")]
        public void ErrorTypeTest01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 58413, 59058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 58565, 58630);

                var
                comp = f_27001_58576_58629(@"public void TopLevelMethod() {}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 58646, 58745);

                var
                errSymbol = f_27001_58662_58708(f_27001_58662_58695(f_27001_58662_58679(comp))).FirstOrDefault() as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 58759, 58791);

                f_27001_58759_58790(errSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 58805, 58899);

                f_27001_58805_58898(WellKnownMemberNames.TopLevelStatementsEntryPointTypeName, f_27001_58883_58897(errSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 58913, 58970);

                f_27001_58913_58969(f_27001_58932_58955(errSymbol), "ErrorType");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 58984, 59047);

                f_27001_58984_59046(f_27001_59003_59028(errSymbol), "ImplicitClass");
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 58413, 59058);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_58576_58629(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58576, 58629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_27001_58662_58679(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 58662, 58679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_58662_58695(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 58662, 58695);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_58662_58708(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58662, 58708);
                    return return_v;
                }


                bool
                f_27001_58759_58790(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                @object)
                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58759, 58790);
                    return return_v;
                }


                string
                f_27001_58883_58897(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 58883, 58897);
                    return return_v;
                }


                bool
                f_27001_58805_58898(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58805, 58898);
                    return return_v;
                }


                bool
                f_27001_58932_58955(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58932, 58955);
                    return return_v;
                }


                bool
                f_27001_58913_58969(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58913, 58969);
                    return return_v;
                }


                bool
                f_27001_59003_59028(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 59003, 59028);
                    return return_v;
                }


                bool
                f_27001_58984_59046(bool
                condition, string
                userMessage)
                {
                    var return_v = CustomAssert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 58984, 59046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 58413, 59058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 58413, 59058);
            }
        }

        [Fact, WorkItem(537195, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/537195")]
        public void SimpleNullable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 59100, 59823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 59251, 59344);

                var
                text =
                @"namespace NS
{
    public class A 
    {
        int? x = null;
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 59360, 59395);

                var
                comp = f_27001_59371_59394(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 59409, 59498);

                var
                namespaceNS = f_27001_59427_59464(f_27001_59427_59447(comp), "NS").First() as NamespaceOrTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 59512, 59565);

                var
                classA = f_27001_59525_59556(namespaceNS, "A").First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 59579, 59636);

                var
                varX = f_27001_59590_59612(classA, "x").First() as FieldSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 59650, 59698);

                f_27001_59650_59697(SymbolKind.Field, f_27001_59687_59696(varX));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 59712, 59812);

                f_27001_59712_59811(f_27001_59730_59780(comp, SpecialType.System_Nullable_T), f_27001_59782_59810(f_27001_59782_59791(varX)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 59100, 59823);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_59371_59394(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 59371, 59394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_59427_59447(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 59427, 59447);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_59427_59464(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 59427, 59464);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_59525_59556(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol?
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 59525, 59556);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_59590_59612(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 59590, 59612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_27001_59687_59696(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 59687, 59696);
                    return return_v;
                }


                bool
                f_27001_59650_59697(Microsoft.CodeAnalysis.SymbolKind
                expected, Microsoft.CodeAnalysis.SymbolKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 59650, 59697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_59730_59780(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 59730, 59780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_59782_59791(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 59782, 59791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_59782_59810(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 59782, 59810);
                    return return_v;
                }


                bool
                f_27001_59712_59811(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 59712, 59811);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 59100, 59823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 59100, 59823);
            }
        }

        [Fact]
        public void BuiltInTypeNullableTest01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 59835, 65190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 59915, 60396);

                var
                text = @"
public class NullableTest
{
    // As Field Type
    static sbyte? field01 = null;
    protected byte? field02 = (byte)(field01 ?? 1);

    // As Property Type
    public char? Prop01 { get; private set; }
    internal short? this[ushort? p1, uint? p2 = null] { set { } }

    private static int? Method01(ref long? p1, out ulong? p2) { p2 = null; return null; }
    public decimal? Method02(double? p1 = null, params float?[] ary) { return null; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 60412, 60447);

                var
                comp = f_27001_60423_60446(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 60461, 60557);

                var
                topType = f_27001_60475_60539(f_27001_60475_60508(f_27001_60475_60492(comp)), "NullableTest").FirstOrDefault()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 60618, 60667);

                var
                mem = f_27001_60628_60657(topType, "field01").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 60681, 60721);

                var
                memType = f_27001_60695_60720((mem as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 60735, 60833);

                f_27001_60735_60832(f_27001_60753_60803(comp, SpecialType.System_Nullable_T), f_27001_60805_60831(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 60847, 60894);

                f_27001_60847_60893(f_27001_60865_60892(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 60910, 60962);

                var
                underType = f_27001_60926_60961(memType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 60976, 61030);

                f_27001_60976_61029(f_27001_60994_61028(underType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61044, 61120);

                f_27001_61044_61119(f_27001_61062_61107(comp, SpecialType.System_SByte), underType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61181, 61226);

                mem = f_27001_61187_61216(topType, "field02").Single();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61240, 61276);

                memType = f_27001_61250_61275((mem as FieldSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61290, 61334);

                f_27001_61290_61333(f_27001_61308_61332(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61348, 61389);

                f_27001_61348_61388(f_27001_61367_61387(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61405, 61440);

                underType = f_27001_61417_61439(memType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61454, 61529);

                f_27001_61454_61528(f_27001_61472_61516(comp, SpecialType.System_Byte), underType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61543, 61609);

                f_27001_61543_61608(underType, f_27001_61572_61607(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61670, 61714);

                mem = f_27001_61676_61704(topType, "Prop01").Single();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61728, 61767);

                memType = f_27001_61738_61766((mem as PropertySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61781, 61879);

                f_27001_61781_61878(f_27001_61799_61849(comp, SpecialType.System_Nullable_T), f_27001_61851_61877(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61893, 61940);

                f_27001_61893_61939(f_27001_61911_61938(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 61956, 61991);

                underType = f_27001_61968_61990(memType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62005, 62080);

                f_27001_62005_62079(f_27001_62023_62067(comp, SpecialType.System_Char), underType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62094, 62160);

                f_27001_62094_62159(underType, f_27001_62123_62158(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62221, 62285);

                mem = f_27001_62227_62275(topType, WellKnownMemberNames.Indexer).Single();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62299, 62338);

                memType = f_27001_62309_62337((mem as PropertySymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62352, 62399);

                f_27001_62352_62398(f_27001_62370_62397(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62413, 62454);

                f_27001_62413_62453(f_27001_62432_62452(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62470, 62518);

                underType = f_27001_62482_62517(memType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62532, 62586);

                f_27001_62532_62585(f_27001_62550_62584(underType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62600, 62676);

                f_27001_62600_62675(f_27001_62618_62663(comp, SpecialType.System_Int16), underType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62692, 62724);

                var
                paras = f_27001_62704_62723(mem)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62738, 62774);

                f_27001_62738_62773(2, paras.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62788, 62812);

                memType = f_27001_62798_62811(paras[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62826, 62929);

                f_27001_62826_62928(f_27001_62844_62890(comp, SpecialType.System_UInt16), f_27001_62892_62927(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62943, 62967);

                memType = f_27001_62953_62966(paras[1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 62981, 63084);

                f_27001_62981_63083(f_27001_62999_63045(comp, SpecialType.System_UInt32), f_27001_63047_63082(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63145, 63191);

                mem = f_27001_63151_63181(topType, "Method01").Single();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63205, 63248);

                memType = f_27001_63215_63247((mem as MethodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63262, 63360);

                f_27001_63262_63359(f_27001_63280_63330(comp, SpecialType.System_Nullable_T), f_27001_63332_63358(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63374, 63421);

                f_27001_63374_63420(f_27001_63392_63419(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63435, 63470);

                underType = f_27001_63447_63469(memType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63484, 63560);

                f_27001_63484_63559(f_27001_63502_63547(comp, SpecialType.System_Int32), underType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63574, 63640);

                f_27001_63574_63639(underType, f_27001_63603_63638(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63656, 63684);

                paras = f_27001_63664_63683(mem);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63698, 63748);

                f_27001_63698_63747(RefKind.Ref, f_27001_63730_63746(paras[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63762, 63812);

                f_27001_63762_63811(RefKind.Out, f_27001_63794_63810(paras[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63826, 63850);

                memType = f_27001_63836_63849(paras[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63864, 63966);

                f_27001_63864_63965(f_27001_63882_63927(comp, SpecialType.System_Int64), f_27001_63929_63964(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 63980, 64004);

                memType = f_27001_63990_64003(paras[1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64018, 64121);

                f_27001_64018_64120(f_27001_64036_64082(comp, SpecialType.System_UInt64), f_27001_64084_64119(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64182, 64228);

                mem = f_27001_64188_64218(topType, "Method02").Single();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64242, 64285);

                memType = f_27001_64252_64284((mem as MethodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64299, 64343);

                f_27001_64299_64342(f_27001_64317_64341(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64357, 64405);

                underType = f_27001_64369_64404(memType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64419, 64473);

                f_27001_64419_64472(f_27001_64437_64471(underType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64487, 64565);

                f_27001_64487_64564(f_27001_64505_64552(comp, SpecialType.System_Decimal), underType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64579, 64637);

                f_27001_64579_64636("decimal?", f_27001_64610_64635(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64653, 64681);

                paras = f_27001_64661_64680(mem);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64695, 64734);

                f_27001_64695_64733(f_27001_64713_64732(paras[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64748, 64785);

                f_27001_64748_64784(f_27001_64766_64783(paras[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64799, 64823);

                memType = f_27001_64809_64822(paras[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64837, 64940);

                f_27001_64837_64939(f_27001_64855_64901(comp, SpecialType.System_Double), f_27001_64903_64938(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64954, 64978);

                memType = f_27001_64964_64977(paras[1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 64992, 65029);

                f_27001_64992_65028(f_27001_65010_65027(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 65043, 65179);

                f_27001_65043_65178(f_27001_65061_65107(comp, SpecialType.System_Single), f_27001_65109_65177(f_27001_65109_65149((memType as ArrayTypeSymbol))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 59835, 65190);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_60423_60446(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60423, 60446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_27001_60475_60492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 60475, 60492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_60475_60508(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 60475, 60508);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_60475_60539(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60475, 60539);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_60628_60657(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60628, 60657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_60695_60720(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 60695, 60720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_60753_60803(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60753, 60803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_60805_60831(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 60805, 60831);
                    return return_v;
                }


                bool
                f_27001_60735_60832(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60735, 60832);
                    return return_v;
                }


                bool
                f_27001_60865_60892(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanBeAssignedNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60865, 60892);
                    return return_v;
                }


                bool
                f_27001_60847_60893(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60847, 60893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_60926_60961(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60926, 60961);
                    return return_v;
                }


                bool
                f_27001_60994_61028(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60994, 61028);
                    return return_v;
                }


                bool
                f_27001_60976_61029(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 60976, 61029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_61062_61107(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61062, 61107);
                    return return_v;
                }


                bool
                f_27001_61044_61119(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61044, 61119);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_61187_61216(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61187, 61216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_61250_61275(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 61250, 61275);
                    return return_v;
                }


                bool
                f_27001_61308_61332(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61308, 61332);
                    return return_v;
                }


                bool
                f_27001_61290_61333(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61290, 61333);
                    return return_v;
                }


                bool
                f_27001_61367_61387(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.CanBeConst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61367, 61387);
                    return return_v;
                }


                bool
                f_27001_61348_61388(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61348, 61388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_61417_61439(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61417, 61439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_61472_61516(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61472, 61516);
                    return return_v;
                }


                bool
                f_27001_61454_61528(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61454, 61528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_61572_61607(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61572, 61607);
                    return return_v;
                }


                bool
                f_27001_61543_61608(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61543, 61608);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_61676_61704(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61676, 61704);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_61738_61766(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 61738, 61766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_61799_61849(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61799, 61849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_61851_61877(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 61851, 61877);
                    return return_v;
                }


                bool
                f_27001_61781_61878(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61781, 61878);
                    return return_v;
                }


                bool
                f_27001_61911_61938(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanBeAssignedNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61911, 61938);
                    return return_v;
                }


                bool
                f_27001_61893_61939(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61893, 61939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_61968_61990(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 61968, 61990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_62023_62067(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62023, 62067);
                    return return_v;
                }


                bool
                f_27001_62005_62079(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62005, 62079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_62123_62158(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62123, 62158);
                    return return_v;
                }


                bool
                f_27001_62094_62159(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62094, 62159);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_62227_62275(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62227, 62275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_62309_62337(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 62309, 62337);
                    return return_v;
                }


                bool
                f_27001_62370_62397(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanBeAssignedNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62370, 62397);
                    return return_v;
                }


                bool
                f_27001_62352_62398(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62352, 62398);
                    return return_v;
                }


                bool
                f_27001_62432_62452(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.CanBeConst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62432, 62452);
                    return return_v;
                }


                bool
                f_27001_62413_62453(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62413, 62453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_62482_62517(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62482, 62517);
                    return return_v;
                }


                bool
                f_27001_62550_62584(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62550, 62584);
                    return return_v;
                }


                bool
                f_27001_62532_62585(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62532, 62585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_62618_62663(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62618, 62663);
                    return return_v;
                }


                bool
                f_27001_62600_62675(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62600, 62675);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_62704_62723(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62704, 62723);
                    return return_v;
                }


                bool
                f_27001_62738_62773(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62738, 62773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_62798_62811(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 62798, 62811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_62844_62890(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62844, 62890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_62892_62927(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62892, 62927);
                    return return_v;
                }


                bool
                f_27001_62826_62928(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62826, 62928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_62953_62966(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 62953, 62966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_62999_63045(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62999, 63045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_63047_63082(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63047, 63082);
                    return return_v;
                }


                bool
                f_27001_62981_63083(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 62981, 63083);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_63151_63181(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63151, 63181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_63215_63247(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 63215, 63247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_63280_63330(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63280, 63330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_63332_63358(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 63332, 63358);
                    return return_v;
                }


                bool
                f_27001_63262_63359(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63262, 63359);
                    return return_v;
                }


                bool
                f_27001_63392_63419(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanBeAssignedNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63392, 63419);
                    return return_v;
                }


                bool
                f_27001_63374_63420(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63374, 63420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_63447_63469(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63447, 63469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_63502_63547(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63502, 63547);
                    return return_v;
                }


                bool
                f_27001_63484_63559(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63484, 63559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_63603_63638(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63603, 63638);
                    return return_v;
                }


                bool
                f_27001_63574_63639(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63574, 63639);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_63664_63683(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63664, 63683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_27001_63730_63746(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 63730, 63746);
                    return return_v;
                }


                bool
                f_27001_63698_63747(Microsoft.CodeAnalysis.RefKind
                expected, Microsoft.CodeAnalysis.RefKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63698, 63747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_27001_63794_63810(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 63794, 63810);
                    return return_v;
                }


                bool
                f_27001_63762_63811(Microsoft.CodeAnalysis.RefKind
                expected, Microsoft.CodeAnalysis.RefKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63762, 63811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_63836_63849(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 63836, 63849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_63882_63927(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63882, 63927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_63929_63964(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63929, 63964);
                    return return_v;
                }


                bool
                f_27001_63864_63965(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 63864, 63965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_63990_64003(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 63990, 64003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_64036_64082(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64036, 64082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_64084_64119(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64084, 64119);
                    return return_v;
                }


                bool
                f_27001_64018_64120(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64018, 64120);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_64188_64218(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64188, 64218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_64252_64284(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 64252, 64284);
                    return return_v;
                }


                bool
                f_27001_64317_64341(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64317, 64341);
                    return return_v;
                }


                bool
                f_27001_64299_64342(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64299, 64342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_64369_64404(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64369, 64404);
                    return return_v;
                }


                bool
                f_27001_64437_64471(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64437, 64471);
                    return return_v;
                }


                bool
                f_27001_64419_64472(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64419, 64472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_64505_64552(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64505, 64552);
                    return return_v;
                }


                bool
                f_27001_64487_64564(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64487, 64564);
                    return return_v;
                }


                string
                f_27001_64610_64635(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64610, 64635);
                    return return_v;
                }


                bool
                f_27001_64579_64636(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64579, 64636);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_64661_64680(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64661, 64680);
                    return return_v;
                }


                bool
                f_27001_64713_64732(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 64713, 64732);
                    return return_v;
                }


                bool
                f_27001_64695_64733(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64695, 64733);
                    return return_v;
                }


                bool
                f_27001_64766_64783(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 64766, 64783);
                    return return_v;
                }


                bool
                f_27001_64748_64784(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64748, 64784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_64809_64822(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 64809, 64822);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_64855_64901(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64855, 64901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_64903_64938(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64903, 64938);
                    return return_v;
                }


                bool
                f_27001_64837_64939(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64837, 64939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_64964_64977(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 64964, 64977);
                    return return_v;
                }


                bool
                f_27001_65010_65027(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 65010, 65027);
                    return return_v;
                }


                bool
                f_27001_64992_65028(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 64992, 65028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_65061_65107(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 65061, 65107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_65109_65149(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol?
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 65109, 65149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_65109_65177(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 65109, 65177);
                    return return_v;
                }


                bool
                f_27001_65043_65178(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 65043, 65178);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 59835, 65190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 59835, 65190);
            }
        }

        [Fact]
        public void EnumStructNullableTest01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 65202, 68140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 65281, 65650);

                var
                text = @"
public enum E {    Zero, One, Two    }

public struct S
{
    public struct Nested { }

    public delegate S? Dele(S? p1, E? p2 = E.Zero);
    event Dele efield;

    public static implicit operator Nested?(S? p)
    {
        return null;
    }

    public static E? operator +(S? p1, Nested? p)
    {
        return null;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 65666, 65701);

                var
                comp = f_27001_65677_65700(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 65715, 65800);

                var
                topType = f_27001_65729_65782(f_27001_65729_65762(f_27001_65729_65746(comp)), "S").FirstOrDefault()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 65814, 65873);

                var
                nestedType = f_27001_65831_65863(topType, "Nested").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 65887, 65965);

                var
                enumType = f_27001_65902_65955(f_27001_65902_65935(f_27001_65902_65919(comp)), "E").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66026, 66074);

                var
                mem = f_27001_66036_66064(topType, "efield").Single()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66088, 66129);

                var
                deleType = f_27001_66103_66128((mem as EventSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66143, 66188);

                f_27001_66143_66187(f_27001_66161_66186(deleType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66202, 66259);

                var
                memType = f_27001_66216_66258(f_27001_66216_66247(deleType))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66273, 66371);

                f_27001_66273_66370(f_27001_66291_66341(comp, SpecialType.System_Nullable_T), f_27001_66343_66369(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66387, 66429);

                var
                paras = f_27001_66399_66428(deleType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66443, 66483);

                f_27001_66443_66482(f_27001_66462_66481(paras[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66497, 66536);

                f_27001_66497_66535(f_27001_66515_66534(paras[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66550, 66574);

                memType = f_27001_66560_66573(paras[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66588, 66652);

                f_27001_66588_66651(topType, f_27001_66615_66650(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66666, 66690);

                memType = f_27001_66676_66689(paras[1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66704, 66769);

                f_27001_66704_66768(enumType, f_27001_66732_66767(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66783, 66835);

                f_27001_66783_66834("E?", f_27001_66808_66833(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66896, 66975);

                mem = f_27001_66902_66965(topType, WellKnownMemberNames.ImplicitConversionName).Single();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 66989, 67032);

                memType = f_27001_66999_67031((mem as MethodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67046, 67090);

                f_27001_67046_67089(f_27001_67064_67088(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67104, 67145);

                f_27001_67104_67144(f_27001_67123_67143(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67161, 67213);

                var
                underType = f_27001_67177_67212(memType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67227, 67281);

                f_27001_67227_67280(f_27001_67245_67279(underType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67295, 67336);

                f_27001_67295_67335(nestedType, underType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67352, 67398);

                paras = f_27001_67360_67397((mem as MethodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67412, 67482);

                f_27001_67412_67481(topType, f_27001_67439_67480(f_27001_67439_67452(paras[0])));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67543, 67620);

                mem = f_27001_67549_67610(topType, WellKnownMemberNames.AdditionOperatorName).Single();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67634, 67677);

                memType = f_27001_67644_67676((mem as MethodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67691, 67789);

                f_27001_67691_67788(f_27001_67709_67759(comp, SpecialType.System_Nullable_T), f_27001_67761_67787(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67803, 67850);

                f_27001_67803_67849(f_27001_67821_67848(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67866, 67894);

                paras = f_27001_67874_67893(mem);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67908, 67932);

                memType = f_27001_67918_67931(paras[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 67946, 68010);

                f_27001_67946_68009(topType, f_27001_67973_68008(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 68024, 68048);

                memType = f_27001_68034_68047(paras[1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 68062, 68129);

                f_27001_68062_68128(nestedType, f_27001_68092_68127(memType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 65202, 68140);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_65677_65700(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 65677, 65700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_27001_65729_65746(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 65729, 65746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_65729_65762(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 65729, 65762);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_65729_65782(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 65729, 65782);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_65831_65863(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 65831, 65863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_27001_65902_65919(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 65902, 65919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_65902_65935(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 65902, 65935);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_65902_65955(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 65902, 65955);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_66036_66064(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66036, 66064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_66103_66128(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 66103, 66128);
                    return return_v;
                }


                bool
                f_27001_66161_66186(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66161, 66186);
                    return return_v;
                }


                bool
                f_27001_66143_66187(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66143, 66187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_27001_66216_66247(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.DelegateInvokeMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66216, 66247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_66216_66258(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 66216, 66258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_66291_66341(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66291, 66341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_66343_66369(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 66343, 66369);
                    return return_v;
                }


                bool
                f_27001_66273_66370(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66273, 66370);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_66399_66428(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.DelegateParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66399, 66428);
                    return return_v;
                }


                bool
                f_27001_66462_66481(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 66462, 66481);
                    return return_v;
                }


                bool
                f_27001_66443_66482(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66443, 66482);
                    return return_v;
                }


                bool
                f_27001_66515_66534(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsOptional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 66515, 66534);
                    return return_v;
                }


                bool
                f_27001_66497_66535(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66497, 66535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_66560_66573(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 66560, 66573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_66615_66650(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66615, 66650);
                    return return_v;
                }


                bool
                f_27001_66588_66651(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66588, 66651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_66676_66689(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 66676, 66689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_66732_66767(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66732, 66767);
                    return return_v;
                }


                bool
                f_27001_66704_66768(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66704, 66768);
                    return return_v;
                }


                string
                f_27001_66808_66833(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66808, 66833);
                    return return_v;
                }


                bool
                f_27001_66783_66834(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66783, 66834);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_66902_66965(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 66902, 66965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_66999_67031(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 66999, 67031);
                    return return_v;
                }


                bool
                f_27001_67064_67088(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67064, 67088);
                    return return_v;
                }


                bool
                f_27001_67046_67089(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67046, 67089);
                    return return_v;
                }


                bool
                f_27001_67123_67143(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.CanBeConst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67123, 67143);
                    return return_v;
                }


                bool
                f_27001_67104_67144(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67104, 67144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_67177_67212(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67177, 67212);
                    return return_v;
                }


                bool
                f_27001_67245_67279(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67245, 67279);
                    return return_v;
                }


                bool
                f_27001_67227_67280(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67227, 67280);
                    return return_v;
                }


                bool
                f_27001_67295_67335(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67295, 67335);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_67360_67397(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67360, 67397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_67439_67452(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 67439, 67452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_67439_67480(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67439, 67480);
                    return return_v;
                }


                bool
                f_27001_67412_67481(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67412, 67481);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_67549_67610(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67549, 67610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_67644_67676(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 67644, 67676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_67709_67759(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67709, 67759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_67761_67787(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 67761, 67787);
                    return return_v;
                }


                bool
                f_27001_67691_67788(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67691, 67788);
                    return return_v;
                }


                bool
                f_27001_67821_67848(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanBeAssignedNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67821, 67848);
                    return return_v;
                }


                bool
                f_27001_67803_67849(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67803, 67849);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_27001_67874_67893(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67874, 67893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_67918_67931(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 67918, 67931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_67973_68008(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67973, 68008);
                    return return_v;
                }


                bool
                f_27001_67946_68009(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 67946, 68009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_68034_68047(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 68034, 68047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_68092_68127(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 68092, 68127);
                    return return_v;
                }


                bool
                f_27001_68062_68128(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 68062, 68128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 65202, 68140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 65202, 68140);
            }
        }

        [Fact]
        public void LocalNullableTest01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 68152, 71767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 68226, 68694);

                var
                text = @"
using System;
using System.Collections;

class A
{
    static void M(DictionaryEntry? p = null)
    {
        System.IO.FileAccess? local01 = null;
        Action<char?, PlatformID?> local02 = delegate(char? p1, PlatformID? p2) { ; };
        Func<decimal?> local03 = () => 0.123m;
        var local04 = new { p0 = local01, p1 = new { p1 = local02, local03 }, p };

        // NYI - PlatformID?[] { PlatformID.MacOSX, null, 0 }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 68710, 68757);

                var
                tree = f_27001_68721_68756(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 68771, 68819);

                var
                comp = (Compilation)f_27001_68795_68818(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 68833, 68873);

                var
                model = f_27001_68845_68872(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 68889, 68983);

                var
                mnode = (MethodDeclarationSyntax)f_27001_68926_68982(tree, SyntaxKind.MethodDeclaration)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 68997, 69065);

                var
                localvars = f_27001_69013_69064(f_27001_69013_69046(model, f_27001_69035_69045(mnode)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69079, 69148);

                var
                locals = f_27001_69092_69147(f_27001_69092_69137(f_27001_69092_69122(ref localvars, s => s.Name), s => s))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69205, 69242);

                f_27001_69205_69241(6, f_27001_69227_69240(locals));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69280, 69333);

                var
                anonymousType = f_27001_69300_69332((locals[3] as ILocalSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69347, 69396);

                f_27001_69347_69395(f_27001_69365_69394(anonymousType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69473, 69539);

                var
                memType = f_27001_69487_69538(f_27001_69487_69533(anonymousType, "p0"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69553, 69651);

                f_27001_69553_69650(f_27001_69571_69621(comp, SpecialType.System_Nullable_T), f_27001_69623_69649(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69665, 69770);

                f_27001_69665_69769(f_27001_69684_69716((locals[0] as ILocalSymbol)), memType, SymbolEqualityComparer.ConsiderEverything);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69823, 69892);

                var
                nestedType = f_27001_69840_69891(f_27001_69840_69886(anonymousType, "p1"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69906, 69952);

                f_27001_69906_69951(f_27001_69924_69950(nestedType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 69990, 70049);

                memType = f_27001_70000_70048(f_27001_70000_70043(nestedType, "p1"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70063, 70107);

                f_27001_70063_70106(f_27001_70081_70105(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70121, 70182);

                f_27001_70121_70181(f_27001_70139_70171((locals[1] as ILocalSymbol)), memType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70213, 70285);

                var
                paras = f_27001_70225_70284(f_27001_70225_70273(((INamedTypeSymbol)memType)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70299, 70323);

                memType = f_27001_70309_70322(paras[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70337, 70381);

                f_27001_70337_70380(f_27001_70355_70379(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70395, 70448);

                f_27001_70395_70447(f_27001_70414_70446(f_27001_70414_70433(memType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70462, 70486);

                memType = f_27001_70472_70485(paras[1]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70500, 70598);

                f_27001_70500_70597(f_27001_70518_70568(comp, SpecialType.System_Nullable_T), f_27001_70570_70596(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70612, 70692);

                f_27001_70612_70691(TypeKind.Enum, f_27001_70646_70690(f_27001_70646_70681(memType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70706, 70774);

                f_27001_70706_70773("System.PlatformID?", f_27001_70747_70772(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70814, 70878);

                memType = f_27001_70824_70877(f_27001_70824_70872(nestedType, "local03"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70892, 70953);

                f_27001_70892_70952(f_27001_70910_70942((locals[2] as ILocalSymbol)), memType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 70967, 71011);

                f_27001_70967_71010(f_27001_70985_71009(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 71053, 71123);

                memType = f_27001_71063_71122(f_27001_71063_71111(((INamedTypeSymbol)memType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 71137, 71181);

                f_27001_71137_71180(f_27001_71155_71179(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 71195, 71254);

                f_27001_71195_71253(f_27001_71213_71252(f_27001_71213_71232(memType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 71345, 71429);

                var
                compType = f_27001_71360_71428(f_27001_71360_71420((f_27001_71361_71391(model, mnode) as IMethodSymbol))[0])
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 71443, 71504);

                memType = f_27001_71453_71503(f_27001_71453_71498(anonymousType, "p"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 71518, 71599);

                f_27001_71518_71598(compType, memType, SymbolEqualityComparer.ConsiderEverything);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 71613, 71657);

                f_27001_71613_71656(f_27001_71631_71655(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 71671, 71756);

                f_27001_71671_71755("System.Collections.DictionaryEntry?", f_27001_71729_71754(memType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 68152, 71767);

                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_68721_68756(string
                text)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 68721, 68756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_68795_68818(Microsoft.CodeAnalysis.SyntaxTree
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 68795, 68818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_27001_68845_68872(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 68845, 68872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_27001_68926_68982(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = syntaxTree.FindNodeOrTokenByKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 68926, 68982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                f_27001_69035_69045(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax?
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69035, 69045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DataFlowAnalysis
                f_27001_69013_69046(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax?
                statementOrExpression)
                {
                    var return_v = this_param.AnalyzeDataFlow((Microsoft.CodeAnalysis.SyntaxNode?)statementOrExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69013, 69046);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                f_27001_69013_69064(Microsoft.CodeAnalysis.DataFlowAnalysis
                this_param)
                {
                    var return_v = this_param.VariablesDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69013, 69064);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.ISymbol>
                f_27001_69092_69122(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                source, System.Func<Microsoft.CodeAnalysis.ISymbol, string>
                keySelector)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.ISymbol, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69092, 69122);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                f_27001_69092_69137(System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.ISymbol>
                source, System.Func<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.ISymbol>
                selector)
                {
                    var return_v = source.Select<Microsoft.CodeAnalysis.ISymbol, Microsoft.CodeAnalysis.ISymbol>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69092, 69137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol[]
                f_27001_69092_69147(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                source)
                {
                    var return_v = source.ToArray<Microsoft.CodeAnalysis.ISymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69092, 69147);
                    return return_v;
                }


                int
                f_27001_69227_69240(Microsoft.CodeAnalysis.ISymbol[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69227, 69240);
                    return return_v;
                }


                bool
                f_27001_69205_69241(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69205, 69241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_69300_69332(Microsoft.CodeAnalysis.ILocalSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69300, 69332);
                    return return_v;
                }


                bool
                f_27001_69365_69394(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69365, 69394);
                    return return_v;
                }


                bool
                f_27001_69347_69395(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69347, 69395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol
                f_27001_69487_69533(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.IPropertySymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69487, 69533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_69487_69538(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69487, 69538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_27001_69571_69621(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69571, 69621);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_69623_69649(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69623, 69649);
                    return return_v;
                }


                bool
                f_27001_69553_69650(Microsoft.CodeAnalysis.INamedTypeSymbol
                expected, Microsoft.CodeAnalysis.ITypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69553, 69650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_69684_69716(Microsoft.CodeAnalysis.ILocalSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69684, 69716);
                    return return_v;
                }


                bool
                f_27001_69665_69769(Microsoft.CodeAnalysis.ITypeSymbol
                expected, Microsoft.CodeAnalysis.ITypeSymbol
                actual, Microsoft.CodeAnalysis.SymbolEqualityComparer
                equalityComparer)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.ISymbol)expected, (Microsoft.CodeAnalysis.ISymbol)actual, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.ISymbol>)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69665, 69769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol
                f_27001_69840_69886(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.IPropertySymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69840, 69886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_69840_69891(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69840, 69891);
                    return return_v;
                }


                bool
                f_27001_69924_69950(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 69924, 69950);
                    return return_v;
                }


                bool
                f_27001_69906_69951(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 69906, 69951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol
                f_27001_70000_70043(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.IPropertySymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70000, 70043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_70000_70048(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70000, 70048);
                    return return_v;
                }


                bool
                f_27001_70081_70105(Microsoft.CodeAnalysis.ITypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70081, 70105);
                    return return_v;
                }


                bool
                f_27001_70063_70106(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70063, 70106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_70139_70171(Microsoft.CodeAnalysis.ILocalSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70139, 70171);
                    return return_v;
                }


                bool
                f_27001_70121_70181(Microsoft.CodeAnalysis.ITypeSymbol
                expected, Microsoft.CodeAnalysis.ITypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70121, 70181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_27001_70225_70273(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70225, 70273);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                f_27001_70225_70284(Microsoft.CodeAnalysis.IMethodSymbol?
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70225, 70284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_70309_70322(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70309, 70322);
                    return return_v;
                }


                bool
                f_27001_70355_70379(Microsoft.CodeAnalysis.ITypeSymbol
                typeOpt)
                {
                    var return_v = typeOpt.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70355, 70379);
                    return return_v;
                }


                bool
                f_27001_70337_70380(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70337, 70380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_27001_70414_70433(Microsoft.CodeAnalysis.ITypeSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70414, 70433);
                    return return_v;
                }


                bool
                f_27001_70414_70446(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.CanBeConst();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70414, 70446);
                    return return_v;
                }


                bool
                f_27001_70395_70447(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70395, 70447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_70472_70485(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70472, 70485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_27001_70518_70568(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70518, 70568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_70570_70596(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70570, 70596);
                    return return_v;
                }


                bool
                f_27001_70500_70597(Microsoft.CodeAnalysis.INamedTypeSymbol
                expected, Microsoft.CodeAnalysis.ITypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70500, 70597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_70646_70681(Microsoft.CodeAnalysis.ITypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70646, 70681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_70646_70690(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70646, 70690);
                    return return_v;
                }


                bool
                f_27001_70612_70691(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70612, 70691);
                    return return_v;
                }


                string
                f_27001_70747_70772(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70747, 70772);
                    return return_v;
                }


                bool
                f_27001_70706_70773(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70706, 70773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol
                f_27001_70824_70872(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.IPropertySymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70824, 70872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_70824_70877(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70824, 70877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_70910_70942(Microsoft.CodeAnalysis.ILocalSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 70910, 70942);
                    return return_v;
                }


                bool
                f_27001_70892_70952(Microsoft.CodeAnalysis.ITypeSymbol
                expected, Microsoft.CodeAnalysis.ITypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70892, 70952);
                    return return_v;
                }


                bool
                f_27001_70985_71009(Microsoft.CodeAnalysis.ITypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70985, 71009);
                    return return_v;
                }


                bool
                f_27001_70967_71010(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 70967, 71010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_27001_71063_71111(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 71063, 71111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_71063_71122(Microsoft.CodeAnalysis.IMethodSymbol?
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 71063, 71122);
                    return return_v;
                }


                bool
                f_27001_71155_71179(Microsoft.CodeAnalysis.ITypeSymbol
                typeOpt)
                {
                    var return_v = typeOpt.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71155, 71179);
                    return return_v;
                }


                bool
                f_27001_71137_71180(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71137, 71180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_27001_71213_71232(Microsoft.CodeAnalysis.ITypeSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71213, 71232);
                    return return_v;
                }


                bool
                f_27001_71213_71252(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CanBeAssignedNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71213, 71252);
                    return return_v;
                }


                bool
                f_27001_71195_71253(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71195, 71253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_27001_71361_71391(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                declarationSyntax)
                {
                    var return_v = semanticModel.GetDeclaredSymbol((Microsoft.CodeAnalysis.CSharp.Syntax.BaseMethodDeclarationSyntax)declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71361, 71391);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                f_27001_71360_71420(Microsoft.CodeAnalysis.IMethodSymbol?
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 71360, 71420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_71360_71428(Microsoft.CodeAnalysis.IParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 71360, 71428);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IPropertySymbol
                f_27001_71453_71498(Microsoft.CodeAnalysis.ITypeSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.IPropertySymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71453, 71498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_71453_71503(Microsoft.CodeAnalysis.IPropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 71453, 71503);
                    return return_v;
                }


                bool
                f_27001_71518_71598(Microsoft.CodeAnalysis.ITypeSymbol
                expected, Microsoft.CodeAnalysis.ITypeSymbol
                actual, Microsoft.CodeAnalysis.SymbolEqualityComparer
                equalityComparer)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.ISymbol)expected, (Microsoft.CodeAnalysis.ISymbol)actual, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.ISymbol>)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71518, 71598);
                    return return_v;
                }


                bool
                f_27001_71631_71655(Microsoft.CodeAnalysis.ITypeSymbol
                typeOpt)
                {
                    var return_v = typeOpt.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71631, 71655);
                    return return_v;
                }


                bool
                f_27001_71613_71656(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71613, 71656);
                    return return_v;
                }


                string
                f_27001_71729_71754(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71729, 71754);
                    return return_v;
                }


                bool
                f_27001_71671_71755(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 71671, 71755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 68152, 71767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 68152, 71767);
            }
        }

        [Fact]
        public void TypeParameterNullableTest01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 71779, 74395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 71861, 72527);

                var
                text = @"
using System;
using System.Collections.Generic;

namespace NS
{
    interface IGoo<T, R> where T : struct where R: struct
    {
        R? M<V>(ref T? p1, V? p2) where V: struct;
    }

    struct SGoo<T> : IGoo<T, PlatformID> where T : struct
    {
        PlatformID? IGoo<T, PlatformID>.M<V>(ref T? p1, V? p2) { return null; }
    }

    class CGoo
    {
        static void Main() 
        {
            IGoo<float, PlatformID> obj = new SGoo<float>();
            float? f = null;
            var ret = /*<bind0>*/obj/*</bind0>*/.M<decimal>(ref /*<bind1>*/f/*</bind1>*/, /*<bind2>*/null/*</bind2>*/);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 72543, 72590);

                var
                tree = f_27001_72554_72589(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 72604, 72652);

                var
                comp = (Compilation)f_27001_72628_72651(tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 72666, 72706);

                var
                model = f_27001_72678_72705(comp, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 72722, 72835);

                var
                node1 = (LocalDeclarationStatementSyntax)f_27001_72767_72834(tree, SyntaxKind.LocalDeclarationStatement, 3)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 72849, 72895);

                var
                loc = f_27001_72859_72876(node1).Variables.First()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 72909, 72996);

                var
                sym = f_27001_72919_72979(model, f_27001_72943_72960(node1).Variables.First()) as ILocalSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73066, 73089);

                var
                memType = f_27001_73080_73088(sym)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73103, 73201);

                f_27001_73103_73200(f_27001_73121_73171(comp, SpecialType.System_Nullable_T), f_27001_73173_73199(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73215, 73283);

                f_27001_73215_73282("System.PlatformID?", f_27001_73256_73281(memType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73299, 73354);

                var
                nodes = f_27001_73311_73353(f_27001_73311_73344(this, comp))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73368, 73432);

                var
                tinfo = f_27001_73380_73431(model, f_27001_73398_73406(nodes, 0) as IdentifierNameSyntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73491, 73524);

                f_27001_73491_73523(tinfo.Type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73538, 73613);

                f_27001_73538_73612(TypeKind.Interface, f_27001_73577_73611(((ITypeSymbol)tinfo.Type)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73627, 73713);

                f_27001_73627_73712("NS.IGoo<float, System.PlatformID>", f_27001_73683_73711(tinfo.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73759, 73819);

                tinfo = f_27001_73767_73818(model, f_27001_73785_73793(nodes, 1) as IdentifierNameSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73833, 73895);

                f_27001_73833_73894(f_27001_73851_73893(((ITypeSymbol)tinfo.Type)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 73909, 73968);

                f_27001_73909_73967("float?", f_27001_73938_73966(tinfo.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74007, 74070);

                tinfo = f_27001_74015_74069(model, f_27001_74033_74041(nodes, 2) as LiteralExpressionSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74084, 74155);

                f_27001_74084_74154(f_27001_74102_74153(((ITypeSymbol)tinfo.ConvertedType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74169, 74300);

                f_27001_74169_74299(f_27001_74187_74234(comp, SpecialType.System_Decimal), f_27001_74236_74298(((ITypeSymbol)tinfo.ConvertedType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74314, 74384);

                f_27001_74314_74383("decimal?", f_27001_74345_74382(tinfo.ConvertedType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 71779, 74395);

                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_72554_72589(string
                text)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 72554, 72589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_72628_72651(Microsoft.CodeAnalysis.SyntaxTree
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 72628, 72651);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_27001_72678_72705(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 72678, 72705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNodeOrToken
                f_27001_72767_72834(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, int
                occurrence)
                {
                    var return_v = syntaxTree.FindNodeOrTokenByKind(kind, occurrence);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 72767, 72834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_27001_72859_72876(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax?
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 72859, 72876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclarationSyntax
                f_27001_72943_72960(Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax
                this_param)
                {
                    var return_v = this_param.Declaration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 72943, 72960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol?
                f_27001_72919_72979(Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDeclaratorSyntax
                declarationSyntax)
                {
                    var return_v = semanticModel.GetDeclaredSymbol(declarationSyntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 72919, 72979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_73080_73088(Microsoft.CodeAnalysis.ILocalSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 73080, 73088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_27001_73121_73171(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73121, 73171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_73173_73199(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 73173, 73199);
                    return return_v;
                }


                bool
                f_27001_73103_73200(Microsoft.CodeAnalysis.INamedTypeSymbol
                expected, Microsoft.CodeAnalysis.ITypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73103, 73200);
                    return return_v;
                }


                string
                f_27001_73256_73281(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73256, 73281);
                    return return_v;
                }


                bool
                f_27001_73215_73282(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73215, 73282);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxNode>
                f_27001_73311_73344(Microsoft.CodeAnalysis.CSharp.UnitTests.Symbols.TypeTests
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = this_param.GetBindingNodes<Microsoft.CodeAnalysis.SyntaxNode>(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73311, 73344);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                f_27001_73311_73353(System.Collections.Generic.IList<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.ToList<Microsoft.CodeAnalysis.SyntaxNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73311, 73353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_27001_73398_73406(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 73398, 73406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_27001_73380_73431(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax?
                node)
                {
                    var return_v = this_param.GetTypeInfo((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73380, 73431);
                    return return_v;
                }


                bool
                f_27001_73491_73523(Microsoft.CodeAnalysis.ITypeSymbol?
                @object)
                {
                    var return_v = CustomAssert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73491, 73523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_27001_73577_73611(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 73577, 73611);
                    return return_v;
                }


                bool
                f_27001_73538_73612(Microsoft.CodeAnalysis.TypeKind
                expected, Microsoft.CodeAnalysis.TypeKind
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73538, 73612);
                    return return_v;
                }


                string
                f_27001_73683_73711(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73683, 73711);
                    return return_v;
                }


                bool
                f_27001_73627_73712(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73627, 73712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_27001_73785_73793(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 73785, 73793);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_27001_73767_73818(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.IdentifierNameSyntax?
                node)
                {
                    var return_v = this_param.GetTypeInfo((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73767, 73818);
                    return return_v;
                }


                bool
                f_27001_73851_73893(Microsoft.CodeAnalysis.ITypeSymbol?
                typeOpt)
                {
                    var return_v = typeOpt.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73851, 73893);
                    return return_v;
                }


                bool
                f_27001_73833_73894(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73833, 73894);
                    return return_v;
                }


                string
                f_27001_73938_73966(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73938, 73966);
                    return return_v;
                }


                bool
                f_27001_73909_73967(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 73909, 73967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_27001_74033_74041(System.Collections.Generic.List<Microsoft.CodeAnalysis.SyntaxNode>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 74033, 74041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeInfo
                f_27001_74015_74069(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax?
                node)
                {
                    var return_v = this_param.GetTypeInfo((Microsoft.CodeAnalysis.SyntaxNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74015, 74069);
                    return return_v;
                }


                bool
                f_27001_74102_74153(Microsoft.CodeAnalysis.ITypeSymbol?
                typeOpt)
                {
                    var return_v = typeOpt.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74102, 74153);
                    return return_v;
                }


                bool
                f_27001_74084_74154(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74084, 74154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_27001_74187_74234(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74187, 74234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ITypeSymbol
                f_27001_74236_74298(Microsoft.CodeAnalysis.ITypeSymbol?
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74236, 74298);
                    return return_v;
                }


                bool
                f_27001_74169_74299(Microsoft.CodeAnalysis.INamedTypeSymbol
                expected, Microsoft.CodeAnalysis.ITypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Same((object)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74169, 74299);
                    return return_v;
                }


                string
                f_27001_74345_74382(Microsoft.CodeAnalysis.ITypeSymbol?
                this_param)
                {
                    var return_v = this_param.ToDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74345, 74382);
                    return return_v;
                }


                bool
                f_27001_74314_74383(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74314, 74383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 71779, 74395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 71779, 74395);
            }
        }

        [Fact]
        public void DynamicVersusObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 74429, 75796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74503, 74625);

                var
                code = @"
using System;
class Goo {
    dynamic X;
    object Y;
    Func<dynamic> Z;
    Func<object> W;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74639, 74681);

                var
                compilation = f_27001_74657_74680(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74695, 74758);

                var
                Goo = f_27001_74705_74754(f_27001_74705_74732(compilation), "Goo")[0]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74772, 74831);

                var
                Dynamic = f_27001_74786_74830((f_27001_74787_74806(Goo, "X")[0] as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74845, 74903);

                var
                Object = f_27001_74858_74902((f_27001_74859_74878(Goo, "Y")[0] as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74917, 74981);

                var
                Func_Dynamic = f_27001_74936_74980((f_27001_74937_74956(Goo, "Z")[0] as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 74995, 75058);

                var
                Func_Object = f_27001_75013_75057((f_27001_75014_75033(Goo, "W")[0] as FieldSymbol))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75074, 75169);

                var
                comparator = CSharp.Symbols.SymbolEqualityComparer.IgnoringDynamicTupleNamesAndNullability
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75183, 75222);

                f_27001_75183_75221(Object, Dynamic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75236, 75320);

                f_27001_75236_75319(f_27001_75255_75286(comparator, Dynamic), f_27001_75288_75318(comparator, Object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75334, 75388);

                f_27001_75334_75387(f_27001_75352_75386(comparator, Dynamic, Object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75402, 75456);

                f_27001_75402_75455(f_27001_75420_75454(comparator, Object, Dynamic));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75472, 75521);

                f_27001_75472_75520(Func_Object, Func_Dynamic);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75535, 75629);

                f_27001_75535_75628(f_27001_75554_75590(comparator, Func_Dynamic), f_27001_75592_75627(comparator, Func_Object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75643, 75707);

                f_27001_75643_75706(f_27001_75661_75705(comparator, Func_Dynamic, Func_Object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75721, 75785);

                f_27001_75721_75784(f_27001_75739_75783(comparator, Func_Object, Func_Dynamic));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 74429, 75796);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_74657_74680(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74657, 74680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_74705_74732(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 74705, 74732);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_27001_74705_74754(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74705, 74754);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_74787_74806(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74787, 74806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_74786_74830(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 74786, 74830);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_74859_74878(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74859, 74878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_74858_74902(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 74858, 74902);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_74937_74956(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 74937, 74956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_74936_74980(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 74936, 74980);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_27001_75014_75033(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75014, 75033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_27001_75013_75057(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 75013, 75057);
                    return return_v;
                }


                bool
                f_27001_75183_75221(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75183, 75221);
                    return return_v;
                }


                int
                f_27001_75255_75286(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                obj)
                {
                    var return_v = this_param.GetHashCode((Microsoft.CodeAnalysis.CSharp.Symbol)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75255, 75286);
                    return return_v;
                }


                int
                f_27001_75288_75318(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                obj)
                {
                    var return_v = this_param.GetHashCode((Microsoft.CodeAnalysis.CSharp.Symbol)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75288, 75318);
                    return return_v;
                }


                bool
                f_27001_75236_75319(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75236, 75319);
                    return return_v;
                }


                bool
                f_27001_75352_75386(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                x, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                y)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)x, (Microsoft.CodeAnalysis.CSharp.Symbol)y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75352, 75386);
                    return return_v;
                }


                bool
                f_27001_75334_75387(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75334, 75387);
                    return return_v;
                }


                bool
                f_27001_75420_75454(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                x, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                y)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)x, (Microsoft.CodeAnalysis.CSharp.Symbol)y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75420, 75454);
                    return return_v;
                }


                bool
                f_27001_75402_75455(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75402, 75455);
                    return return_v;
                }


                bool
                f_27001_75472_75520(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                actual)
                {
                    var return_v = CustomAssert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75472, 75520);
                    return return_v;
                }


                int
                f_27001_75554_75590(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                obj)
                {
                    var return_v = this_param.GetHashCode((Microsoft.CodeAnalysis.CSharp.Symbol)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75554, 75590);
                    return return_v;
                }


                int
                f_27001_75592_75627(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                obj)
                {
                    var return_v = this_param.GetHashCode((Microsoft.CodeAnalysis.CSharp.Symbol)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75592, 75627);
                    return return_v;
                }


                bool
                f_27001_75535_75628(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75535, 75628);
                    return return_v;
                }


                bool
                f_27001_75661_75705(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                x, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                y)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)x, (Microsoft.CodeAnalysis.CSharp.Symbol)y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75661, 75705);
                    return return_v;
                }


                bool
                f_27001_75643_75706(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75643, 75706);
                    return return_v;
                }


                bool
                f_27001_75739_75783(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                x, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                y)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)x, (Microsoft.CodeAnalysis.CSharp.Symbol)y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75739, 75783);
                    return return_v;
                }


                bool
                f_27001_75721_75784(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75721, 75784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 74429, 75796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 74429, 75796);
            }
        }

        [Fact]
        public void UnboundGenericTypeEquality()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 75808, 76315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75889, 75924);

                var
                code = @"
class C<T>
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75938, 75980);

                var
                compilation = f_27001_75956_75979(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 75994, 76079);

                var
                originalDefinition = f_27001_76019_76078(f_27001_76019_76046(compilation), "C")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76095, 76159);

                var
                unboundGeneric1 = f_27001_76117_76158(originalDefinition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76173, 76237);

                var
                unboundGeneric2 = f_27001_76195_76236(originalDefinition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76251, 76304);

                f_27001_76251_76303(unboundGeneric1, unboundGeneric2);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 75808, 76315);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_75956_75979(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 75956, 75979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_27001_76019_76046(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 76019, 76046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_76019_76078(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76019, 76078);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_76117_76158(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.AsUnboundGenericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76117, 76158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_76195_76236(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.AsUnboundGenericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76195, 76236);
                    return return_v;
                }


                bool
                f_27001_76251_76303(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76251, 76303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 75808, 76315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 75808, 76315);
            }
        }

        [Fact]
        public void SymbolInfoForUnboundGenericTypeObjectCreation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 76327, 77361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76427, 76528);

                var
                code = @"
class C<T>
{
    static void Main()
    {
        var c = new C<>();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76542, 76597);

                var
                compilation = (Compilation)f_27001_76573_76596(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76611, 76655);

                var
                tree = f_27001_76622_76654(f_27001_76622_76645(compilation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76669, 76716);

                var
                model = f_27001_76681_76715(compilation, tree)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76732, 76843);

                var
                syntax = f_27001_76745_76842(f_27001_76745_76833(f_27001_76745_76792(tree.GetCompilationUnitRoot())))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76859, 76898);

                var
                info = f_27001_76870_76897(model, syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76912, 76937);

                var
                symbol = info.Symbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 76951, 77037);

                var
                originalDefinition = f_27001_76976_77036(f_27001_76976_77003(compilation), "C")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77053, 77149);

                f_27001_77053_77148(originalDefinition.InstanceConstructors.Single(), f_27001_77122_77147(symbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77163, 77226);

                f_27001_77163_77225(f_27001_77182_77224(f_27001_77182_77203(symbol)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77240, 77350);

                f_27001_77240_77349(f_27001_77292_77348(f_27001_77292_77313(symbol).TypeArguments.Single()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 76327, 77361);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_76573_76596(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76573, 76596);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_27001_76622_76645(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 76622, 76645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_27001_76622_76654(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.SyntaxTree>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76622, 76654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_27001_76681_76715(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76681, 76715);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                f_27001_76745_76792(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                this_param)
                {
                    var return_v = this_param.DescendantNodes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76745, 76792);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax>
                f_27001_76745_76833(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                source)
                {
                    var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76745, 76833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax
                f_27001_76745_76842(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76745, 76842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolInfo
                f_27001_76870_76897(Microsoft.CodeAnalysis.SemanticModel
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ObjectCreationExpressionSyntax
                node)
                {
                    var return_v = this_param.GetSymbolInfo((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76870, 76897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol
                f_27001_76976_77003(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 76976, 77003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_27001_76976_77036(Microsoft.CodeAnalysis.INamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.INamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 76976, 77036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_27001_77122_77147(Microsoft.CodeAnalysis.ISymbol?
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 77122, 77147);
                    return return_v;
                }


                bool
                f_27001_77053_77148(Microsoft.CodeAnalysis.IMethodSymbol
                expected, Microsoft.CodeAnalysis.ISymbol
                actual)
                {
                    var return_v = CustomAssert.Equal((Microsoft.CodeAnalysis.ISymbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77053, 77148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_27001_77182_77203(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 77182, 77203);
                    return return_v;
                }


                bool
                f_27001_77182_77224(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 77182, 77224);
                    return return_v;
                }


                bool
                f_27001_77163_77225(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77163, 77225);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol
                f_27001_77292_77313(Microsoft.CodeAnalysis.ISymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 77292, 77313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_27001_77292_77348(Microsoft.CodeAnalysis.ITypeSymbol
                symbol)
                {
                    var return_v = symbol.GetSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77292, 77348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.UnboundArgumentErrorTypeSymbol
                f_27001_77240_77349(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                @object)
                {
                    var return_v = CustomAssert.IsType<UnboundArgumentErrorTypeSymbol>((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77240, 77349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 76327, 77361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 76327, 77361);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 77373, 78024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77467, 77568);

                var
                code = @"
using System.Runtime.InteropServices;

[TypeIdentifier]
public interface I1
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77582, 77624);

                var
                compilation = f_27001_77600_77623(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77638, 77702);

                var
                i1 = f_27001_77647_77701(f_27001_77647_77673(compilation), "I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77718, 77777);

                f_27001_77718_77776(f_27001_77736_77775(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77793, 77831);

                compilation = f_27001_77807_77830(code);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77845, 77905);

                i1 = f_27001_77850_77904(f_27001_77850_77876(compilation), "I1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77919, 77938);

                f_27001_77919_77937(i1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 77954, 78013);

                f_27001_77954_78012(f_27001_77972_78011(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 77373, 78024);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_77600_77623(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77600, 77623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_77647_77673(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 77647, 77673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_77647_77701(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77647, 77701);
                    return return_v;
                }


                bool
                f_27001_77736_77775(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 77736, 77775);
                    return return_v;
                }


                bool
                f_27001_77718_77776(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77718, 77776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_77807_77830(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77807, 77830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_77850_77876(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 77850, 77876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_77850_77904(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77850, 77904);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_27001_77919_77937(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77919, 77937);
                    return return_v;
                }


                bool
                f_27001_77972_78011(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 77972, 78011);
                    return return_v;
                }


                bool
                f_27001_77954_78012(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 77954, 78012);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 77373, 78024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 77373, 78024);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 78036, 78460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 78130, 78240);

                var
                code = @"
using System.Runtime.InteropServices;

[TypeIdentifierAttribute]
public interface I1
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 78254, 78296);

                var
                compilation = f_27001_78272_78295(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 78310, 78374);

                var
                i1 = f_27001_78319_78373(f_27001_78319_78345(compilation), "I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 78390, 78449);

                f_27001_78390_78448(f_27001_78408_78447(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 78036, 78460);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_78272_78295(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 78272, 78295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_78319_78345(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 78319, 78345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_78319_78373(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 78319, 78373);
                    return return_v;
                }


                bool
                f_27001_78408_78447(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 78408, 78447);
                    return return_v;
                }


                bool
                f_27001_78390_78448(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 78390, 78448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 78036, 78460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 78036, 78460);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 78472, 79883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 78566, 78735);

                var
                code = @"
using System.Runtime.InteropServices;

namespace NS1
{
    using alias1 = TypeIdentifier; 

    [alias1]
    public interface I1
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 78749, 78791);

                var
                compilation = f_27001_78767_78790(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 78805, 78873);

                var
                i1 = f_27001_78814_78872(f_27001_78814_78840(compilation), "NS1.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 78889, 78949);

                f_27001_78889_78948(f_27001_78908_78947(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 78965, 79633);

                f_27001_78965_79004(
                            compilation).Verify(f_27001_79253_79371(f_27001_79253_79351(f_27001_79253_79319(ErrorCode.ERR_SingleTypeNameNotFound, "TypeIdentifier"), "TypeIdentifier"), 6, 20), f_27001_79507_79613(f_27001_79507_79594(f_27001_79507_79562(ErrorCode.ERR_NotAnAttributeClass, "alias1"), "TypeIdentifier"), 8, 6));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 79649, 79687);

                compilation = f_27001_79663_79686(code);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 79701, 79765);

                i1 = f_27001_79706_79764(f_27001_79706_79732(compilation), "NS1.I1");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 79779, 79798);

                f_27001_79779_79797(i1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 79812, 79872);

                f_27001_79812_79871(f_27001_79831_79870(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 78472, 79883);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_78767_78790(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 78767, 78790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_78814_78840(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 78814, 78840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_78814_78872(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 78814, 78872);
                    return return_v;
                }


                bool
                f_27001_78908_78947(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 78908, 78947);
                    return return_v;
                }


                bool
                f_27001_78889_78948(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 78889, 78948);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_78965_79004(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDeclarationDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 78965, 79004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_79253_79319(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79253, 79319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_79253_79351(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79253, 79351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_79253_79371(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79253, 79371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_79507_79562(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79507, 79562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_79507_79594(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79507, 79594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_79507_79613(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79507, 79613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_79663_79686(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79663, 79686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_79706_79732(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 79706, 79732);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_79706_79764(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79706, 79764);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_27001_79779_79797(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79779, 79797);
                    return return_v;
                }


                bool
                f_27001_79831_79870(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 79831, 79870);
                    return return_v;
                }


                bool
                f_27001_79812_79871(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 79812, 79871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 78472, 79883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 78472, 79883);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 79895, 81546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 79989, 80167);

                var
                code = @"
using System.Runtime.InteropServices;

namespace NS1
{
    using alias1 = TypeIdentifier; 

    [alias1Attribute]
    public interface I1
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 80181, 80223);

                var
                compilation = f_27001_80199_80222(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 80237, 80305);

                var
                i1 = f_27001_80246_80304(f_27001_80246_80272(compilation), "NS1.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 80321, 80381);

                f_27001_80321_80380(f_27001_80340_80379(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 80397, 81535);

                f_27001_80397_80436(
                            compilation).Verify(f_27001_80685_80803(f_27001_80685_80783(f_27001_80685_80751(ErrorCode.ERR_SingleTypeNameNotFound, "TypeIdentifier"), "TypeIdentifier"), 6, 20), f_27001_81040_81168(f_27001_81040_81149(f_27001_81040_81107(ErrorCode.ERR_SingleTypeNameNotFound, "alias1Attribute"), "alias1AttributeAttribute"), 8, 6), f_27001_81396_81515(f_27001_81396_81496(f_27001_81396_81463(ErrorCode.ERR_SingleTypeNameNotFound, "alias1Attribute"), "alias1Attribute"), 8, 6));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 79895, 81546);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_80199_80222(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 80199, 80222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_80246_80272(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 80246, 80272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_80246_80304(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 80246, 80304);
                    return return_v;
                }


                bool
                f_27001_80340_80379(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 80340, 80379);
                    return return_v;
                }


                bool
                f_27001_80321_80380(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 80321, 80380);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_80397_80436(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDeclarationDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 80397, 80436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_80685_80751(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 80685, 80751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_80685_80783(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 80685, 80783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_80685_80803(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 80685, 80803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_81040_81107(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 81040, 81107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_81040_81149(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 81040, 81149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_81040_81168(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 81040, 81168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_81396_81463(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 81396, 81463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_81396_81496(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 81396, 81496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_81396_81515(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 81396, 81515);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 79895, 81546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 79895, 81546);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 81558, 82054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 81652, 81830);

                var
                code = @"
using System.Runtime.InteropServices;

namespace NS1
{
    using alias1 = TypeIdentifierAttribute; 

    [alias1]
    public interface I1
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 81844, 81886);

                var
                compilation = f_27001_81862_81885(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 81900, 81968);

                var
                i1 = f_27001_81909_81967(f_27001_81909_81935(compilation), "NS1.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 81984, 82043);

                f_27001_81984_82042(f_27001_82002_82041(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 81558, 82054);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_81862_81885(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 81862, 81885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_81909_81935(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 81909, 81935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_81909_81967(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 81909, 81967);
                    return return_v;
                }


                bool
                f_27001_82002_82041(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 82002, 82041);
                    return return_v;
                }


                bool
                f_27001_81984_82042(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 81984, 82042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 81558, 82054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 81558, 82054);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_06()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 82066, 82571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 82160, 82347);

                var
                code = @"
using System.Runtime.InteropServices;

namespace NS1
{
    using alias1Attribute = TypeIdentifierAttribute; 

    [alias1]
    public interface I1
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 82361, 82403);

                var
                compilation = f_27001_82379_82402(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 82417, 82485);

                var
                i1 = f_27001_82426_82484(f_27001_82426_82452(compilation), "NS1.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 82501, 82560);

                f_27001_82501_82559(f_27001_82519_82558(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 82066, 82571);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_82379_82402(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 82379, 82402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_82426_82452(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 82426, 82452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_82426_82484(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 82426, 82484);
                    return return_v;
                }


                bool
                f_27001_82519_82558(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 82519, 82558);
                    return return_v;
                }


                bool
                f_27001_82501_82559(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 82501, 82559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 82066, 82571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 82066, 82571);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_07()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 82583, 83097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 82677, 82873);

                var
                code = @"
using System.Runtime.InteropServices;

namespace NS1
{
    using alias1Attribute = TypeIdentifierAttribute; 

    [alias1Attribute]
    public interface I1
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 82887, 82929);

                var
                compilation = f_27001_82905_82928(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 82943, 83011);

                var
                i1 = f_27001_82952_83010(f_27001_82952_82978(compilation), "NS1.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 83027, 83086);

                f_27001_83027_83085(f_27001_83045_83084(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 82583, 83097);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_82905_82928(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 82905, 82928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_82952_82978(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 82952, 82978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_82952_83010(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 82952, 83010);
                    return return_v;
                }


                bool
                f_27001_83045_83084(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 83045, 83084);
                    return return_v;
                }


                bool
                f_27001_83027_83085(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 83027, 83085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 82583, 83097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 82583, 83097);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_08()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 83109, 83632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 83203, 83408);

                var
                code = @"
using System.Runtime.InteropServices;

namespace NS1
{
    using alias1AttributeAttribute = TypeIdentifierAttribute; 

    [alias1Attribute]
    public interface I1
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 83422, 83464);

                var
                compilation = f_27001_83440_83463(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 83478, 83546);

                var
                i1 = f_27001_83487_83545(f_27001_83487_83513(compilation), "NS1.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 83562, 83621);

                f_27001_83562_83620(f_27001_83580_83619(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 83109, 83632);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_83440_83463(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 83440, 83463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_83487_83513(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 83487, 83513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_83487_83545(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 83487, 83545);
                    return return_v;
                }


                bool
                f_27001_83580_83619(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 83580, 83619);
                    return return_v;
                }


                bool
                f_27001_83562_83620(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 83562, 83620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 83109, 83632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 83109, 83632);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_09()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 83644, 84227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 83738, 83999);

                var
                code = @"
using System.Runtime.InteropServices;

namespace NS1
{
    using alias1 = TypeIdentifierAttribute; 

    namespace NS2
    {
        using alias2 = alias1;

        [alias2]
        public interface I1
        {
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 84013, 84055);

                var
                compilation = f_27001_84031_84054(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 84069, 84141);

                var
                i1 = f_27001_84078_84140(f_27001_84078_84104(compilation), "NS1.NS2.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 84157, 84216);

                f_27001_84157_84215(f_27001_84175_84214(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 83644, 84227);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_84031_84054(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 84031, 84054);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_84078_84104(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 84078, 84104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_84078_84140(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 84078, 84140);
                    return return_v;
                }


                bool
                f_27001_84175_84214(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 84175, 84214);
                    return return_v;
                }


                bool
                f_27001_84157_84215(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 84157, 84215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 83644, 84227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 83644, 84227);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_10()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 84239, 84788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 84333, 84560);

                var
                code = @"
using System.Runtime.InteropServices;

namespace NS1
{
    using alias1 = TypeIdentifierAttribute; 

    namespace NS2
    {
        [alias1]
        public interface I1
        {
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 84574, 84616);

                var
                compilation = f_27001_84592_84615(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 84630, 84702);

                var
                i1 = f_27001_84639_84701(f_27001_84639_84665(compilation), "NS1.NS2.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 84718, 84777);

                f_27001_84718_84776(f_27001_84736_84775(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 84239, 84788);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_84592_84615(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 84592, 84615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_84639_84665(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 84639, 84665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_84639_84701(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 84639, 84701);
                    return return_v;
                }


                bool
                f_27001_84736_84775(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 84736, 84775);
                    return return_v;
                }


                bool
                f_27001_84718_84776(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 84718, 84776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 84239, 84788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 84239, 84788);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_11()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 84800, 85379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 84894, 85151);

                var
                code = @"
using System.Runtime.InteropServices;

namespace NS1
{
    using alias1 = TypeIdentifierAttribute; 

    namespace NS2
    {
        using alias2 = I1;

        [alias1]
        public interface I1
        {
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 85165, 85207);

                var
                compilation = f_27001_85183_85206(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 85221, 85293);

                var
                i1 = f_27001_85230_85292(f_27001_85230_85256(compilation), "NS1.NS2.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 85309, 85368);

                f_27001_85309_85367(f_27001_85327_85366(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 84800, 85379);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_85183_85206(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 85183, 85206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_85230_85256(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 85230, 85256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_85230_85292(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 85230, 85292);
                    return return_v;
                }


                bool
                f_27001_85327_85366(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 85327, 85366);
                    return return_v;
                }


                bool
                f_27001_85309_85367(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 85309, 85367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 84800, 85379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 84800, 85379);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_12()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 85391, 86503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 85485, 86115);

                var
                code = @"
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace NS1
{
    namespace NS2
    {
        using alias1 = TypeIdentifierAttribute; 

        [alias1]
        partial public interface I1
        {
        }

        [CompilerGenerated]
        partial public interface I2
        {
        }
    }
}

namespace NS1
{
    namespace NS2
    {
        using alias1 = ComImportAttribute; 

        [alias1]
        partial public interface I1
        {
        }

        [alias1]
        partial public interface I2
        {
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 86129, 86171);

                var
                compilation = f_27001_86147_86170(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 86185, 86257);

                var
                i1 = f_27001_86194_86256(f_27001_86194_86220(compilation), "NS1.NS2.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 86271, 86343);

                var
                i2 = f_27001_86280_86342(f_27001_86280_86306(compilation), "NS1.NS2.I2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 86359, 86418);

                f_27001_86359_86417(f_27001_86377_86416(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 86432, 86492);

                f_27001_86432_86491(f_27001_86451_86490(i2));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 85391, 86503);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_86147_86170(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 86147, 86170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_86194_86220(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 86194, 86220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_86194_86256(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 86194, 86256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_86280_86306(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 86280, 86306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_86280_86342(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 86280, 86342);
                    return return_v;
                }


                bool
                f_27001_86377_86416(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 86377, 86416);
                    return return_v;
                }


                bool
                f_27001_86359_86417(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 86359, 86417);
                    return return_v;
                }


                bool
                f_27001_86451_86490(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 86451, 86490);
                    return return_v;
                }


                bool
                f_27001_86432_86491(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 86432, 86491);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 85391, 86503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 85391, 86503);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_13()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 86515, 87627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 86609, 87239);

                var
                code = @"
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace NS1
{
    namespace NS2
    {
        using alias1 = ComImportAttribute; 

        [alias1]
        partial public interface I1
        {
        }

        [alias1]
        partial public interface I2
        {
        }
    }
}

namespace NS1
{
    namespace NS2
    {
        using alias1 = TypeIdentifierAttribute; 

        [alias1]
        partial public interface I1
        {
        }

        [CompilerGenerated]
        partial public interface I2
        {
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 87253, 87295);

                var
                compilation = f_27001_87271_87294(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 87309, 87381);

                var
                i1 = f_27001_87318_87380(f_27001_87318_87344(compilation), "NS1.NS2.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 87395, 87467);

                var
                i2 = f_27001_87404_87466(f_27001_87404_87430(compilation), "NS1.NS2.I2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 87483, 87542);

                f_27001_87483_87541(f_27001_87501_87540(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 87556, 87616);

                f_27001_87556_87615(f_27001_87575_87614(i2));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 86515, 87627);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_87271_87294(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 87271, 87294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_87318_87344(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 87318, 87344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_87318_87380(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 87318, 87380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_87404_87430(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 87404, 87430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_87404_87466(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 87404, 87466);
                    return return_v;
                }


                bool
                f_27001_87501_87540(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 87501, 87540);
                    return return_v;
                }


                bool
                f_27001_87483_87541(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 87483, 87541);
                    return return_v;
                }


                bool
                f_27001_87575_87614(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 87575, 87614);
                    return return_v;
                }


                bool
                f_27001_87556_87615(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 87556, 87615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 86515, 87627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 86515, 87627);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_14()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 87639, 88458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 87733, 87877);

                var
                code = @"
namespace NS1
{
    using alias1 = System.Runtime.InteropServices; 

    [alias1]
    public interface I1
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 87891, 87933);

                var
                compilation = f_27001_87909_87932(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 87947, 88015);

                var
                i1 = f_27001_87956_88014(f_27001_87956_87982(compilation), "NS1.I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 88031, 88091);

                f_27001_88031_88090(f_27001_88050_88089(i1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 88107, 88447);

                f_27001_88107_88146(
                            compilation).Verify(f_27001_88305_88427(f_27001_88305_88408(f_27001_88305_88360(ErrorCode.ERR_NotAnAttributeClass, "alias1"), "System.Runtime.InteropServices"), 6, 6));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 87639, 88458);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_87909_87932(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 87909, 87932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_87956_87982(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 87956, 87982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_87956_88014(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 87956, 88014);
                    return return_v;
                }


                bool
                f_27001_88050_88089(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 88050, 88089);
                    return return_v;
                }


                bool
                f_27001_88031_88090(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 88031, 88090);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_27001_88107_88146(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetDeclarationDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 88107, 88146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_88305_88360(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 88305, 88360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_88305_88408(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 88305, 88408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_27001_88305_88427(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 88305, 88427);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 87639, 88458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 87639, 88458);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_15()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 88470, 88875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 88564, 88655);

                var
                code = @"
[System.Runtime.InteropServices.TypeIdentifier]
public interface I1
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 88669, 88711);

                var
                compilation = f_27001_88687_88710(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 88725, 88789);

                var
                i1 = f_27001_88734_88788(f_27001_88734_88760(compilation), "I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 88805, 88864);

                f_27001_88805_88863(f_27001_88823_88862(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 88470, 88875);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_88687_88710(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 88687, 88710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_88734_88760(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 88734, 88760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_88734_88788(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 88734, 88788);
                    return return_v;
                }


                bool
                f_27001_88823_88862(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 88823, 88862);
                    return return_v;
                }


                bool
                f_27001_88805_88863(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 88805, 88863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 88470, 88875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 88470, 88875);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_16()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 88887, 89301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 88981, 89081);

                var
                code = @"
[System.Runtime.InteropServices.TypeIdentifierAttribute]
public interface I1
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 89095, 89137);

                var
                compilation = f_27001_89113_89136(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 89151, 89215);

                var
                i1 = f_27001_89160_89214(f_27001_89160_89186(compilation), "I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 89231, 89290);

                f_27001_89231_89289(f_27001_89249_89288(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 88887, 89301);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_89113_89136(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 89113, 89136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_89160_89186(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 89160, 89186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_89160_89214(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 89160, 89214);
                    return return_v;
                }


                bool
                f_27001_89249_89288(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 89249, 89288);
                    return return_v;
                }


                bool
                f_27001_89231_89289(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 89231, 89289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 88887, 89301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 88887, 89301);
            }
        }

        [Fact]
        public void IsExplicitDefinitionOfNoPiaLocalType_17()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 89313, 89753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 89407, 89533);

                var
                code = @"
using alias1 = System.Runtime.InteropServices.TypeIdentifierAttribute;

[alias1]
public interface I1
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 89547, 89589);

                var
                compilation = f_27001_89565_89588(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 89603, 89667);

                var
                i1 = f_27001_89612_89666(f_27001_89612_89638(compilation), "I1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 89683, 89742);

                f_27001_89683_89741(f_27001_89701_89740(i1));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 89313, 89753);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_89565_89588(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 89565, 89588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_27001_89612_89638(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 89612, 89638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_27001_89612_89666(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 89612, 89666);
                    return return_v;
                }


                bool
                f_27001_89701_89740(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 89701, 89740);
                    return return_v;
                }


                bool
                f_27001_89683_89741(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 89683, 89741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 89313, 89753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 89313, 89753);
            }
        }

        [Fact]
        [WorkItem(41501, "https://github.com/dotnet/roslyn/issues/41501")]
        public void ImplementNestedInterface_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 89765, 90166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 89923, 90053);

                var
                text = @"
public struct TestStruct : TestStruct.IInnerInterface
{
    public interface IInnerInterface
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 90067, 90109);

                var
                compilation = f_27001_90085_90108(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 90123, 90155);

                f_27001_90123_90154(compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 89765, 90166);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_90085_90108(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 90085, 90108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_90123_90154(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 90123, 90154);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 89765, 90166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 89765, 90166);
            }
        }

        [Fact]
        [WorkItem(41501, "https://github.com/dotnet/roslyn/issues/41501")]
        public void ImplementNestedInterface_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 90178, 90576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 90336, 90463);

                var
                text = @"
public class TestClass : TestClass.IInnerInterface
{
    public interface IInnerInterface
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 90477, 90519);

                var
                compilation = f_27001_90495_90518(text)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 90533, 90565);

                f_27001_90533_90564(compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 90178, 90576);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_90495_90518(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 90495, 90518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_90533_90564(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 90533, 90564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 90178, 90576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 90178, 90576);
            }
        }

        [Fact]
        public void CallingConventionOnMethods_FromSource()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 90588, 91723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 90680, 90818);

                var
                sourceComp = f_27001_90697_90817(@"
class C
{
    void M1() { }
    void M2(params object[] p) { }
    void M3(__arglist) { }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 90834, 90865);

                f_27001_90834_90864(
                            sourceComp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 90879, 90943);

                var
                c = f_27001_90887_90942(f_27001_90887_90924(sourceComp, "C"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 90957, 90999);

                var
                m1 = (IMethodSymbol)f_27001_90981_90998(c, "M1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91013, 91038);

                f_27001_91013_91037(m1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91052, 91129);

                f_27001_91052_91128(SignatureCallingConvention.Default, f_27001_91107_91127(m1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91143, 91198);

                f_27001_91143_91197(f_27001_91162_91196(m1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91214, 91256);

                var
                m2 = (IMethodSymbol)f_27001_91238_91255(c, "M2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91270, 91295);

                f_27001_91270_91294(m2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91309, 91386);

                f_27001_91309_91385(SignatureCallingConvention.Default, f_27001_91364_91384(m2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91400, 91455);

                f_27001_91400_91454(f_27001_91419_91453(m2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91471, 91513);

                var
                m3 = (IMethodSymbol)f_27001_91495_91512(c, "M3")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91527, 91552);

                f_27001_91527_91551(m3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91566, 91643);

                f_27001_91566_91642(SignatureCallingConvention.VarArgs, f_27001_91621_91641(m3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91657, 91712);

                f_27001_91657_91711(f_27001_91676_91710(m3));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 90588, 91723);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_90697_90817(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 90697, 90817);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_90834_90864(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 90834, 90864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_27001_90887_90924(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 90887, 90924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_27001_90887_90942(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 90887, 90942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_27001_90981_90998(Microsoft.CodeAnalysis.INamedTypeSymbol?
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 90981, 90998);
                    return return_v;
                }


                bool
                f_27001_91013_91037(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91013, 91037);
                    return return_v;
                }


                System.Reflection.Metadata.SignatureCallingConvention
                f_27001_91107_91127(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 91107, 91127);
                    return return_v;
                }


                bool
                f_27001_91052_91128(System.Reflection.Metadata.SignatureCallingConvention
                expected, System.Reflection.Metadata.SignatureCallingConvention
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91052, 91128);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_27001_91162_91196(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.UnmanagedCallingConventionTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 91162, 91196);
                    return return_v;
                }


                bool
                f_27001_91143_91197(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91143, 91197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_27001_91238_91255(Microsoft.CodeAnalysis.INamedTypeSymbol?
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91238, 91255);
                    return return_v;
                }


                bool
                f_27001_91270_91294(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91270, 91294);
                    return return_v;
                }


                System.Reflection.Metadata.SignatureCallingConvention
                f_27001_91364_91384(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 91364, 91384);
                    return return_v;
                }


                bool
                f_27001_91309_91385(System.Reflection.Metadata.SignatureCallingConvention
                expected, System.Reflection.Metadata.SignatureCallingConvention
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91309, 91385);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_27001_91419_91453(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.UnmanagedCallingConventionTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 91419, 91453);
                    return return_v;
                }


                bool
                f_27001_91400_91454(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91400, 91454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_27001_91495_91512(Microsoft.CodeAnalysis.INamedTypeSymbol?
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91495, 91512);
                    return return_v;
                }


                bool
                f_27001_91527_91551(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91527, 91551);
                    return return_v;
                }


                System.Reflection.Metadata.SignatureCallingConvention
                f_27001_91621_91641(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 91621, 91641);
                    return return_v;
                }


                bool
                f_27001_91566_91642(System.Reflection.Metadata.SignatureCallingConvention
                expected, System.Reflection.Metadata.SignatureCallingConvention
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91566, 91642);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_27001_91676_91710(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.UnmanagedCallingConventionTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 91676, 91710);
                    return return_v;
                }


                bool
                f_27001_91657_91711(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91657, 91711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 90588, 91723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 90588, 91723);
            }
        }

        [Fact]
        public void CallingConventionOnMethods_FromMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(27001, 91735, 93477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 91829, 92568);

                var
                metadataComp = f_27001_91848_92567("", ilSource: @"
.class public auto ansi beforefieldinit C extends [mscorlib]System.Object
{
    .method public hidebysig instance void M1 () cil managed 
    {
        ret
    }

    .method public hidebysig instance void M2 (object[] p) cil managed 
    {
        .param [1] .custom instance void [mscorlib]System.ParamArrayAttribute::.ctor() = ( 01 00 00 00 )
        ret
    }

    .method public hidebysig instance vararg void M3 () cil managed 
    {
        ret
    }

    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        ldarg.0
        call instance void [mscorlib]System.Object::.ctor()
        ret
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 92584, 92617);

                f_27001_92584_92616(
                            metadataComp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 92631, 92697);

                var
                c = f_27001_92639_92696(f_27001_92639_92678(metadataComp, "C"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 92711, 92753);

                var
                m1 = (IMethodSymbol)f_27001_92735_92752(c, "M1")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 92767, 92792);

                f_27001_92767_92791(m1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 92806, 92883);

                f_27001_92806_92882(SignatureCallingConvention.Default, f_27001_92861_92881(m1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 92897, 92952);

                f_27001_92897_92951(f_27001_92916_92950(m1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 92968, 93010);

                var
                m2 = (IMethodSymbol)f_27001_92992_93009(c, "M2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 93024, 93049);

                f_27001_93024_93048(m2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 93063, 93140);

                f_27001_93063_93139(SignatureCallingConvention.Default, f_27001_93118_93138(m2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 93154, 93209);

                f_27001_93154_93208(f_27001_93173_93207(m2));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 93225, 93267);

                var
                m3 = (IMethodSymbol)f_27001_93249_93266(c, "M3")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 93281, 93306);

                f_27001_93281_93305(m3);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 93320, 93397);

                f_27001_93320_93396(SignatureCallingConvention.VarArgs, f_27001_93375_93395(m3));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(27001, 93411, 93466);

                f_27001_93411_93465(f_27001_93430_93464(m3));
                DynAbs.Tracing.TraceSender.TraceExitMethod(27001, 91735, 93477);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_91848_92567(string
                source, string
                ilSource)
                {
                    var return_v = CreateCompilationWithIL((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, ilSource: ilSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 91848, 92567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_27001_92584_92616(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 92584, 92616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_27001_92639_92678(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 92639, 92678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamedTypeSymbol?
                f_27001_92639_92696(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 92639, 92696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_27001_92735_92752(Microsoft.CodeAnalysis.INamedTypeSymbol?
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 92735, 92752);
                    return return_v;
                }


                bool
                f_27001_92767_92791(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 92767, 92791);
                    return return_v;
                }


                System.Reflection.Metadata.SignatureCallingConvention
                f_27001_92861_92881(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 92861, 92881);
                    return return_v;
                }


                bool
                f_27001_92806_92882(System.Reflection.Metadata.SignatureCallingConvention
                expected, System.Reflection.Metadata.SignatureCallingConvention
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 92806, 92882);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_27001_92916_92950(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.UnmanagedCallingConventionTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 92916, 92950);
                    return return_v;
                }


                bool
                f_27001_92897_92951(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 92897, 92951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_27001_92992_93009(Microsoft.CodeAnalysis.INamedTypeSymbol?
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 92992, 93009);
                    return return_v;
                }


                bool
                f_27001_93024_93048(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 93024, 93048);
                    return return_v;
                }


                System.Reflection.Metadata.SignatureCallingConvention
                f_27001_93118_93138(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 93118, 93138);
                    return return_v;
                }


                bool
                f_27001_93063_93139(System.Reflection.Metadata.SignatureCallingConvention
                expected, System.Reflection.Metadata.SignatureCallingConvention
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 93063, 93139);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_27001_93173_93207(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.UnmanagedCallingConventionTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 93173, 93207);
                    return return_v;
                }


                bool
                f_27001_93154_93208(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 93154, 93208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISymbol
                f_27001_93249_93266(Microsoft.CodeAnalysis.INamedTypeSymbol?
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 93249, 93266);
                    return return_v;
                }


                bool
                f_27001_93281_93305(Microsoft.CodeAnalysis.IMethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 93281, 93305);
                    return return_v;
                }


                System.Reflection.Metadata.SignatureCallingConvention
                f_27001_93375_93395(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 93375, 93395);
                    return return_v;
                }


                bool
                f_27001_93320_93396(System.Reflection.Metadata.SignatureCallingConvention
                expected, System.Reflection.Metadata.SignatureCallingConvention
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 93320, 93396);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                f_27001_93430_93464(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.UnmanagedCallingConventionTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(27001, 93430, 93464);
                    return return_v;
                }


                bool
                f_27001_93411_93465(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.INamedTypeSymbol>
                enumerable)
                {
                    var return_v = CustomAssert.Empty((System.Collections.IEnumerable)enumerable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(27001, 93411, 93465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(27001, 91735, 93477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 91735, 93477);
            }
        }

        public TypeTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(27001, 621, 93484);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(27001, 621, 93484);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 621, 93484);
        }


        static TypeTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(27001, 621, 93484);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(27001, 621, 93484);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(27001, 621, 93484);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(27001, 621, 93484);
    }
}
