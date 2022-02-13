// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.Utilities;
using Roslyn.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public class EmitMetadata : EmitMetadataTestBase
    {
        [Fact]
        public void InstantiatedGenerics()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 982, 3020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 1057, 1661);

                string
                source = @"
public class A<T>
{
    public class B : A<T>
    {
        internal class C : B
        {}

        protected B y1;
        protected A<D>.B y2;
    }

    public class H<S>
    {
        public class I : A<T>.H<S>
        {}
    }

    internal A<T> x1;
    internal A<D> x2;
}

public class D
{
    public class K<T>
    {
        public class L : K<T>
        {}
    }
}

namespace NS1
{
    class E : D
    {}
}

class F : A<D>
{}

class G : A<NS1.E>.B
{}

class J : A<D>.H<D>
{}

public class M
{}

public class N : D.K<M>
{}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 1677, 3009);

                f_23114_1677_3008(this, source, symbolValidator: module =>
                            {
                                var dump = DumpTypeInfo(module).ToString();

                                AssertEx.AssertEqualToleratingWhitespaceDifferences(@"
<Global>
  <type name=""&lt;Module&gt;"" />
  <type name=""A"" Of=""T"" base=""System.Object"">
    <field name=""x1"" type=""A&lt;T&gt;"" />
    <field name=""x2"" type=""A&lt;D&gt;"" />
    <type name=""B"" base=""A&lt;T&gt;"">
      <field name=""y1"" type=""A&lt;T&gt;.B"" />
      <field name=""y2"" type=""A&lt;D&gt;.B"" />
      <type name=""C"" base=""A&lt;T&gt;.B"" />
    </type>
    <type name=""H"" Of=""S"" base=""System.Object"">
      <type name=""I"" base=""A&lt;T&gt;.H&lt;S&gt;"" />
    </type>
  </type>
  <type name=""D"" base=""System.Object"">
    <type name=""K"" Of=""T"" base=""System.Object"">
      <type name=""L"" base=""D.K&lt;T&gt;"" />
    </type>
  </type>
  <type name=""F"" base=""A&lt;D&gt;"" />
  <type name=""G"" base=""A&lt;NS1.E&gt;.B"" />
  <type name=""J"" base=""A&lt;D&gt;.H&lt;D&gt;"" />
  <type name=""M"" base=""System.Object"" />
  <type name=""N"" base=""D.K&lt;M&gt;"" />
  <NS1>
    <type name=""E"" base=""D"" />
  </NS1>
</Global>
", dump);
                            }, options: f_23114_2927_3007(TestOptions.ReleaseDll, MetadataImportOptions.Internal));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 982, 3020);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_2927_3007(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 2927, 3007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_1677_3008(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator: symbolValidator, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 1677, 3008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 982, 3020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 982, 3020);
            }
        }

        [Fact]
        public void StringArrays()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 3032, 3572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 3099, 3458);

                string
                source = @"

public class D
{
    public D()
    {}

    public static void Main()
    {
        System.Console.WriteLine(65536);

        arrayField = new string[] {""string1"", ""string2""};
        System.Console.WriteLine(arrayField[1]);
        System.Console.WriteLine(arrayField[0]);
    }

    static string[] arrayField;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 3474, 3561);

                f_23114_3474_3560(this, source, expectedOutput: @"
65536
string2
string1
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 3032, 3572);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_3474_3560(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 3474, 3560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 3032, 3572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 3032, 3572);
            }
        }

        [WorkItem(9229, "DevDiv_Projects/Roslyn")]
        [Fact]
        public void FieldRVA()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 3584, 4053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 3699, 3960);

                string
                source = @"

public class D
{
    public D()
    {}

    public static void Main()
    {
        byte[] a = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        System.Console.WriteLine(a[0]);
        System.Console.WriteLine(a[8]);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 3974, 4042);

                f_23114_3974_4041(this, source, expectedOutput: @"
1
9
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 3584, 4053);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_3974_4041(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 3974, 4041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 3584, 4053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 3584, 4053);
            }
        }

        [Fact]
        public void AssemblyRefs1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 4065, 4849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 4133, 4195);

                var
                metadataTestLib1 = f_23114_4156_4194()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 4209, 4271);

                var
                metadataTestLib2 = f_23114_4232_4270()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 4287, 4341);

                string
                source = @"
public class Test : C107
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 4357, 4838);

                f_23114_4357_4837(this, source, new[] { metadataTestLib1, metadataTestLib2 }, assemblyValidator: (assembly) =>
                            {
                                var refs = assembly.Modules[0].ReferencedAssemblies.OrderBy(r => r.Name).ToArray();
                                Assert.Equal(2, refs.Length);
                                Assert.Equal("MDTestLib1", refs[0].Name, StringComparer.OrdinalIgnoreCase);
                                Assert.Equal("mscorlib", refs[1].Name, StringComparer.OrdinalIgnoreCase);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 4065, 4849);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_23114_4156_4194()
                {
                    var return_v = TestReferences.SymbolsTests.MDTestLib1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 4156, 4194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_23114_4232_4270()
                {
                    var return_v = TestReferences.SymbolsTests.MDTestLib2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 4232, 4270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_4357_4837(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references, System.Action<Microsoft.CodeAnalysis.PEAssembly>
                assemblyValidator)
                {
                    var return_v = this_param.CompileAndVerifyWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyValidator: assemblyValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 4357, 4837);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 4065, 4849);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 4065, 4849);
            }
        }

        [Fact]
        public void AssemblyRefs2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 4861, 5731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 4929, 4986);

                string
                sources = @"
public class Test : Class2
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 5000, 5720);

                f_23114_5000_5719(this, sources, new[] { f_23114_5048_5096() }, assemblyValidator: (assembly) =>
                             {
                                 var refs2 = assembly.Modules[0].ReferencedAssemblies.Select(r => r.Name);
                                 Assert.Equal(2, refs2.Count());
                                 Assert.Contains("MultiModule", refs2, StringComparer.OrdinalIgnoreCase);
                                 Assert.Contains("mscorlib", refs2, StringComparer.OrdinalIgnoreCase);

                                 var peFileReader = assembly.GetMetadataReader();

                                 Assert.Equal(0, peFileReader.GetTableRowCount(TableIndex.File));
                                 Assert.Equal(0, peFileReader.GetTableRowCount(TableIndex.ModuleRef));
                             });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 4861, 5731);

                Microsoft.CodeAnalysis.PortableExecutableReference
                f_23114_5048_5096()
                {
                    var return_v = TestReferences.SymbolsTests.MultiModule.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 5048, 5096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_5000_5719(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references, System.Action<Microsoft.CodeAnalysis.PEAssembly>
                assemblyValidator)
                {
                    var return_v = this_param.CompileAndVerifyWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyValidator: assemblyValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 5000, 5719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 4861, 5731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 4861, 5731);
            }
        }

        [WorkItem(687434, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/687434")]
        [Fact()]
        public void Bug687434()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 5743, 6099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 5901, 6088);

                f_23114_5901_6087(this, "public class C { }", verify: Verification.Fails, options: f_23114_6029_6086(TestOptions.DebugDll, OutputKind.NetModule));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 5743, 6099);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_6029_6086(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = this_param.WithOutputKind(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 6029, 6086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_5901_6087(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, verify: verify, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 5901, 6087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 5743, 6099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 5743, 6099);
            }
        }

        [Fact, WorkItem(529006, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/529006")]
        public void AddModule()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 6111, 8567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 6257, 6419);

                var
                netModule1 = f_23114_6274_6418(f_23114_6274_6353(f_23114_6305_6352()), filePath: f_23114_6377_6417("netModule1.netmodule"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 6433, 6595);

                var
                netModule2 = f_23114_6450_6594(f_23114_6450_6529(f_23114_6481_6528()), filePath: f_23114_6553_6593("netModule2.netmodule"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 6611, 6667);

                string
                source = @"
public class Test : Class1
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 6731, 8556);

                f_23114_6731_8555(this, source, new[] { netModule1, netModule2 }, assemblyValidator: (assembly) =>
                            {
                                Assert.Equal(3, assembly.Modules.Length);

                                var reader = assembly.GetMetadataReader();

                                Assert.Equal(2, reader.GetTableRowCount(TableIndex.File));

                                var file1 = reader.GetAssemblyFile(MetadataTokens.AssemblyFileHandle(1));
                                var file2 = reader.GetAssemblyFile(MetadataTokens.AssemblyFileHandle(2));
                                Assert.Equal("netModule1.netmodule", reader.GetString(file1.Name));
                                Assert.Equal("netModule2.netmodule", reader.GetString(file2.Name));

                                Assert.False(file1.HashValue.IsNil);
                                Assert.False(file2.HashValue.IsNil);

                                Assert.Equal(1, reader.GetTableRowCount(TableIndex.ModuleRef));
                                var moduleRefName = reader.GetModuleReference(MetadataTokens.ModuleReferenceHandle(1)).Name;
                                Assert.Equal("netModule1.netmodule", reader.GetString(moduleRefName));

                                var actual = from h in reader.ExportedTypes
                                             let et = reader.GetExportedType(h)
                                             select $"{reader.GetString(et.NamespaceDefinition)}.{reader.GetString(et.Name)} 0x{MetadataTokens.GetToken(et.Implementation):X8} ({et.Implementation.Kind}) 0x{(int)et.Attributes:X4}";

                                AssertEx.Equal(new[]
                                {
                    ".Class1 0x26000001 (AssemblyFile) 0x0001",
                    ".Class3 0x27000001 (ExportedType) 0x0002",
                    "NS1.Class4 0x26000001 (AssemblyFile) 0x0001",
                    ".Class7 0x27000003 (ExportedType) 0x0002",
                    ".Class2 0x26000002 (AssemblyFile) 0x0001"
                                }, actual);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 6111, 8567);

                byte[]
                f_23114_6305_6352()
                {
                    var return_v = TestResources.SymbolsTests.netModule.netModule1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 6305, 6352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_23114_6274_6353(byte[]
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 6274, 6353);
                    return return_v;
                }


                string
                f_23114_6377_6417(string
                path)
                {
                    var return_v = Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 6377, 6417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_23114_6274_6418(Microsoft.CodeAnalysis.ModuleMetadata
                this_param, string
                filePath)
                {
                    var return_v = this_param.GetReference(filePath: filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 6274, 6418);
                    return return_v;
                }


                byte[]
                f_23114_6481_6528()
                {
                    var return_v = TestResources.SymbolsTests.netModule.netModule2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 6481, 6528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_23114_6450_6529(byte[]
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage((System.Collections.Generic.IEnumerable<byte>)peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 6450, 6529);
                    return return_v;
                }


                string
                f_23114_6553_6593(string
                path)
                {
                    var return_v = Path.GetFullPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 6553, 6593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PortableExecutableReference
                f_23114_6450_6594(Microsoft.CodeAnalysis.ModuleMetadata
                this_param, string
                filePath)
                {
                    var return_v = this_param.GetReference(filePath: filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 6450, 6594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_6731_8555(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.PortableExecutableReference[]
                references, System.Action<Microsoft.CodeAnalysis.PEAssembly>
                assemblyValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyValidator: assemblyValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 6731, 8555);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 6111, 8567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 6111, 8567);
            }
        }

        [Fact]
        public void ImplementingAnInterface()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 8579, 10129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 8657, 8929);

                string
                source = @"
public interface I1
{}

public class A : I1
{
}

public interface I2
{
    void M2();
}

public interface I3
{
    void M3();
}

abstract public class B : I2, I3
{
    public abstract void M2();
    public abstract void M3();
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 8945, 10118);

                f_23114_8945_10117(this, source, symbolValidator: module =>
                            {
                                var classA = module.GlobalNamespace.GetMember<NamedTypeSymbol>("A");
                                var classB = module.GlobalNamespace.GetMember<NamedTypeSymbol>("B");
                                var i1 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I1");
                                var i2 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I2");
                                var i3 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I3");

                                Assert.Equal(TypeKind.Interface, i1.TypeKind);
                                Assert.Equal(TypeKind.Interface, i2.TypeKind);
                                Assert.Equal(TypeKind.Interface, i3.TypeKind);
                                Assert.Equal(TypeKind.Class, classA.TypeKind);
                                Assert.Equal(TypeKind.Class, classB.TypeKind);

                                Assert.Same(i1, classA.Interfaces().Single());

                                var interfaces = classB.Interfaces();
                                Assert.Same(i2, interfaces[0]);
                                Assert.Same(i3, interfaces[1]);

                                Assert.Equal(1, i2.GetMembers("M2").Length);
                                Assert.Equal(1, i3.GetMembers("M3").Length);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 8579, 10129);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_8945_10117(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 8945, 10117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 8579, 10129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 8579, 10129);
            }
        }

        [Fact]
        public void InterfaceOrder()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 10141, 11978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 10210, 10405);

                string
                source = @"
interface I1 : I2, I5 { }
interface I2 : I3, I4 { }
interface I3 { }
interface I4 { }
interface I5 : I6, I7 { }
interface I6 { }
interface I7 { }

class C : I1 { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 10421, 11967);

                f_23114_10421_11966(this, source, symbolValidator: module =>
                            {
                                var i1 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I1");
                                var i2 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I2");
                                var i3 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I3");
                                var i4 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I4");
                                var i5 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I5");
                                var i6 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I6");
                                var i7 = module.GlobalNamespace.GetMember<NamedTypeSymbol>("I7");
                                var c = module.GlobalNamespace.GetMember<NamedTypeSymbol>("C");

                // Order is important - should be pre-order depth-first with declaration order at each level
                Assert.True(i1.Interfaces().SequenceEqual(ImmutableArray.Create<NamedTypeSymbol>(i2, i3, i4, i5, i6, i7)));
                                Assert.True(i2.Interfaces().SequenceEqual(ImmutableArray.Create<NamedTypeSymbol>(i3, i4)));
                                Assert.False(i3.Interfaces().Any());
                                Assert.False(i4.Interfaces().Any());
                                Assert.True(i5.Interfaces().SequenceEqual(ImmutableArray.Create<NamedTypeSymbol>(i6, i7)));
                                Assert.False(i6.Interfaces().Any());
                                Assert.False(i7.Interfaces().Any());

                                Assert.True(c.Interfaces().SequenceEqual(ImmutableArray.Create<NamedTypeSymbol>(i1, i2, i3, i4, i5, i6, i7)));
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 10141, 11978);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_10421_11966(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 10421, 11966);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 10141, 11978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 10141, 11978);
            }
        }

        [Fact]
        public void ExplicitGenericInterfaceImplementation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 11990, 12347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 12083, 12336);

                f_23114_12083_12335(this, @"
class S
{
    class C<T>
    {
        public interface I
        {
            void m(T x);
        }
    }
    abstract public class D : C<int>.I
    {
        void C<int>.I.m(int x)
        {
        }
    }
}
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 11990, 12347);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_12083_12335(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 12083, 12335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 11990, 12347);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 11990, 12347);
            }
        }

        [Fact]
        public void TypeWithAbstractMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 12359, 16671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 12436, 13057);

                string
                source = @"
abstract public class A
{
    public abstract A[] M1(ref System.Array p1);
    public abstract A[,] M2(System.Boolean p2);
    public abstract A[,,] M3(System.Char p3);
    public abstract void M4(System.SByte p4,
        System.Single p5,
        System.Double p6,
        System.Int16 p7,
        System.Int32 p8,
        System.Int64 p9,
        System.IntPtr p10,
        System.String p11,
        System.Byte p12,
        System.UInt16 p13,
        System.UInt32 p14,
        System.UInt64 p15,
        System.UIntPtr p16);
    public abstract void M5<T, S>(T p17, S p18);
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 13073, 16660);

                f_23114_13073_16659(this, source, options: TestOptions.ReleaseDll, symbolValidator: module =>
                            {
                                var classA = module.GlobalNamespace.GetTypeMembers("A").Single();

                                var m1 = classA.GetMembers("M1").OfType<MethodSymbol>().Single();
                                var m2 = classA.GetMembers("M2").OfType<MethodSymbol>().Single();
                                var m3 = classA.GetMembers("M3").OfType<MethodSymbol>().Single();
                                var m4 = classA.GetMembers("M4").OfType<MethodSymbol>().Single();
                                var m5 = classA.GetMembers("M5").OfType<MethodSymbol>().Single();

                                var method1Ret = (ArrayTypeSymbol)m1.ReturnType;
                                var method2Ret = (ArrayTypeSymbol)m2.ReturnType;
                                var method3Ret = (ArrayTypeSymbol)m3.ReturnType;

                                Assert.True(method1Ret.IsSZArray);
                                Assert.Same(classA, method1Ret.ElementType);
                                Assert.Equal(2, method2Ret.Rank);
                                Assert.Same(classA, method2Ret.ElementType);
                                Assert.Equal(3, method3Ret.Rank);
                                Assert.Same(classA, method3Ret.ElementType);

                                Assert.True(classA.IsAbstract);
                                Assert.Equal(Accessibility.Public, classA.DeclaredAccessibility);

                                var parameter1 = m1.Parameters.Single();
                                var parameter1Type = parameter1.Type;

                                Assert.Equal(RefKind.Ref, parameter1.RefKind);
                                Assert.Same(module.GetCorLibType(SpecialType.System_Array), parameter1Type);
                                Assert.Same(module.GetCorLibType(SpecialType.System_Boolean), m2.Parameters.Single().Type);
                                Assert.Same(module.GetCorLibType(SpecialType.System_Char), m3.Parameters.Single().Type);

                                var method4ParamTypes = m4.Parameters.Select(p => p.Type).ToArray();

                                Assert.Same(module.GetCorLibType(SpecialType.System_Void), m4.ReturnType);
                                Assert.Same(module.GetCorLibType(SpecialType.System_SByte), method4ParamTypes[0]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_Single), method4ParamTypes[1]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_Double), method4ParamTypes[2]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_Int16), method4ParamTypes[3]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_Int32), method4ParamTypes[4]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_Int64), method4ParamTypes[5]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_IntPtr), method4ParamTypes[6]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_String), method4ParamTypes[7]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_Byte), method4ParamTypes[8]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_UInt16), method4ParamTypes[9]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_UInt32), method4ParamTypes[10]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_UInt64), method4ParamTypes[11]);
                                Assert.Same(module.GetCorLibType(SpecialType.System_UIntPtr), method4ParamTypes[12]);

                                Assert.True(m5.IsGenericMethod);
                                Assert.Same(m5.TypeParameters[0], m5.Parameters[0].Type);
                                Assert.Same(m5.TypeParameters[1], m5.Parameters[1].Type);

                                Assert.Equal(6, ((PEModuleSymbol)module).Module.GetMetadataReader().TypeReferences.Count);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 12359, 16671);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_13073_16659(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 13073, 16659);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 12359, 16671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 12359, 16671);
            }
        }

        [Fact]
        public void Types()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 16683, 18932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 16743, 16961);

                string
                source = @"
sealed internal class B
{}

static class C
{
    public class D{}
    internal class E{}
    protected class F{}
    private class G{}
    protected internal class H{}
    class K{}
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 16975, 18774);

                Func<bool, Action<ModuleSymbol>>
                validator = isFromSource => module =>
                            {
                                var classB = module.GlobalNamespace.GetTypeMembers("B").Single();
                                Assert.True(classB.IsSealed);
                                Assert.Equal(Accessibility.Internal, classB.DeclaredAccessibility);

                                var classC = module.GlobalNamespace.GetTypeMembers("C").Single();
                                Assert.True(classC.IsStatic);
                                Assert.Equal(Accessibility.Internal, classC.DeclaredAccessibility);

                                var classD = classC.GetTypeMembers("D").Single();
                                var classE = classC.GetTypeMembers("E").Single();
                                var classF = classC.GetTypeMembers("F").Single();
                                var classH = classC.GetTypeMembers("H").Single();

                                Assert.Equal(Accessibility.Public, classD.DeclaredAccessibility);
                                Assert.Equal(Accessibility.Internal, classE.DeclaredAccessibility);
                                Assert.Equal(Accessibility.Protected, classF.DeclaredAccessibility);
                                Assert.Equal(Accessibility.ProtectedOrInternal, classH.DeclaredAccessibility);

                                if (isFromSource)
                                {
                                    var classG = classC.GetTypeMembers("G").Single();
                                    var classK = classC.GetTypeMembers("K").Single();
                                    Assert.Equal(Accessibility.Private, classG.DeclaredAccessibility);
                                    Assert.Equal(Accessibility.Private, classK.DeclaredAccessibility);
                                }

                                var peModuleSymbol = module as PEModuleSymbol;
                                if (peModuleSymbol != null)
                                {
                                    Assert.Equal(5, peModuleSymbol.Module.GetMetadataReader().TypeReferences.Count);
                                }
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 18788, 18921);

                f_23114_18788_18920(this, source, options: TestOptions.ReleaseDll, sourceSymbolValidator: f_23114_18869_18884(validator, true), symbolValidator: f_23114_18903_18919(validator, false));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 16683, 18932);

                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_18869_18884(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 18869, 18884);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_18903_18919(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 18903, 18919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_18788_18920(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 18788, 18920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 16683, 18932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 16683, 18932);
            }
        }

        [Fact]
        public void Fields()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 18944, 21195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 19005, 19196);

                string
                source = @"
public class A
{
    public int F1;
    internal volatile int F2;
    protected internal string F3;
    protected float F4;
    private double F5;
    char F6;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 19210, 20977);

                Func<bool, Action<ModuleSymbol>>
                validator = isFromSource => module =>
                            {
                                var classA = module.GlobalNamespace.GetTypeMembers("A").Single();

                                var f1 = classA.GetMembers("F1").OfType<FieldSymbol>().Single();
                                var f2 = classA.GetMembers("F2").OfType<FieldSymbol>().Single();
                                var f3 = classA.GetMembers("F3").OfType<FieldSymbol>().Single();
                                var f4 = classA.GetMembers("F4").OfType<FieldSymbol>().Single();

                                Assert.False(f1.IsVolatile);
                                Assert.Equal(0, f1.TypeWithAnnotations.CustomModifiers.Length);

                                Assert.True(f2.IsVolatile);
                                Assert.Equal(1, f2.TypeWithAnnotations.CustomModifiers.Length);

                                CustomModifier mod = f2.TypeWithAnnotations.CustomModifiers[0];

                                Assert.Equal(Accessibility.Public, f1.DeclaredAccessibility);
                                Assert.Equal(Accessibility.Internal, f2.DeclaredAccessibility);
                                Assert.Equal(Accessibility.ProtectedOrInternal, f3.DeclaredAccessibility);
                                Assert.Equal(Accessibility.Protected, f4.DeclaredAccessibility);

                                if (isFromSource)
                                {
                                    var f5 = classA.GetMembers("F5").OfType<FieldSymbol>().Single();
                                    var f6 = classA.GetMembers("F6").OfType<FieldSymbol>().Single();
                                    Assert.Equal(Accessibility.Private, f5.DeclaredAccessibility);
                                    Assert.Equal(Accessibility.Private, f6.DeclaredAccessibility);
                                }

                                Assert.False(mod.IsOptional);
                                Assert.Equal("System.Runtime.CompilerServices.IsVolatile", mod.Modifier.ToTestDisplayString());
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 20993, 21184);

                f_23114_20993_21183(this, source, sourceSymbolValidator: f_23114_21041_21056(validator, true), symbolValidator: f_23114_21075_21091(validator, false), options: f_23114_21102_21182(TestOptions.ReleaseDll, MetadataImportOptions.Internal));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 18944, 21195);

                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_21041_21056(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 21041, 21056);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_21075_21091(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 21075, 21091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_21102_21182(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 21102, 21182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_20993_21183(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 20993, 21183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 18944, 21195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 18944, 21195);
            }
        }

        [Fact]
        public void Constructors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 21207, 24368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 21274, 21397);

                string
                source =
                @"namespace N
{
    abstract class C
    {
        static C() {}
        protected C() {}
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 21411, 24243);

                Func<bool, Action<ModuleSymbol>>
                validator = isFromSource => module =>
                            {
                                var type = module.GlobalNamespace.GetMember<NamedTypeSymbol>("N.C");
                                var ctor = (MethodSymbol)type.GetMembers(".ctor").SingleOrDefault();
                                var cctor = (MethodSymbol)type.GetMembers(".cctor").SingleOrDefault();

                                Assert.NotNull(ctor);
                                Assert.Equal(WellKnownMemberNames.InstanceConstructorName, ctor.Name);
                                Assert.Equal(MethodKind.Constructor, ctor.MethodKind);
                                Assert.Equal(Accessibility.Protected, ctor.DeclaredAccessibility);
                                Assert.True(ctor.IsDefinition);
                                Assert.False(ctor.IsStatic);
                                Assert.False(ctor.IsAbstract);
                                Assert.False(ctor.IsSealed);
                                Assert.False(ctor.IsVirtual);
                                Assert.False(ctor.IsOverride);
                                Assert.False(ctor.IsGenericMethod);
                                Assert.False(ctor.IsExtensionMethod);
                                Assert.True(ctor.ReturnsVoid);
                                Assert.False(ctor.IsVararg);
                // Bug - 2067
                Assert.Equal("N.C." + WellKnownMemberNames.InstanceConstructorName + "()", ctor.ToTestDisplayString());
                                Assert.Equal(0, ctor.TypeParameters.Length);
                                Assert.Equal("Void", ctor.ReturnTypeWithAnnotations.Type.Name);

                                if (isFromSource)
                                {
                                    Assert.NotNull(cctor);
                                    Assert.Equal(WellKnownMemberNames.StaticConstructorName, cctor.Name);
                                    Assert.Equal(MethodKind.StaticConstructor, cctor.MethodKind);
                                    Assert.Equal(Accessibility.Private, cctor.DeclaredAccessibility);
                                    Assert.True(cctor.IsDefinition);
                                    Assert.True(cctor.IsStatic);
                                    Assert.False(cctor.IsAbstract);
                                    Assert.False(cctor.IsSealed);
                                    Assert.False(cctor.IsVirtual);
                                    Assert.False(cctor.IsOverride);
                                    Assert.False(cctor.IsGenericMethod);
                                    Assert.False(cctor.IsExtensionMethod);
                                    Assert.True(cctor.ReturnsVoid);
                                    Assert.False(cctor.IsVararg);
                    // Bug - 2067
                    Assert.Equal("N.C." + WellKnownMemberNames.StaticConstructorName + "()", cctor.ToTestDisplayString());
                                    Assert.Equal(0, cctor.TypeArgumentsWithAnnotations.Length);
                                    Assert.Equal(0, cctor.Parameters.Length);
                                    Assert.Equal("Void", cctor.ReturnTypeWithAnnotations.Type.Name);
                                }
                                else
                                {
                                    Assert.Null(cctor);
                                }
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 24257, 24357);

                f_23114_24257_24356(this, source, sourceSymbolValidator: f_23114_24305_24320(validator, true), symbolValidator: f_23114_24339_24355(validator, false));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 21207, 24368);

                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_24305_24320(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 24305, 24320);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_24339_24355(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 24339, 24355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_24257_24356(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 24257, 24356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 21207, 24368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 21207, 24368);
            }
        }

        [Fact]
        public void ConstantFields()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 24380, 25560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 24449, 24635);

                string
                source =
                @"class C
{
    private const int I = -1;
    internal const int J = I;
    protected internal const object O = null;
    public const string S = ""string"";
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 24649, 25334);

                Func<bool, Action<ModuleSymbol>>
                validator = isFromSource => module =>
                            {
                                var type = module.GlobalNamespace.GetTypeMembers("C").Single();
                                if (isFromSource)
                                {
                                    CheckConstantField(type, "I", Accessibility.Private, SpecialType.System_Int32, -1);
                                }
                                CheckConstantField(type, "J", Accessibility.Internal, SpecialType.System_Int32, -1);
                                CheckConstantField(type, "O", Accessibility.ProtectedOrInternal, SpecialType.System_Object, null);
                                CheckConstantField(type, "S", Accessibility.Public, SpecialType.System_String, "string");
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 25350, 25549);

                f_23114_25350_25548(this, source: source, sourceSymbolValidator: f_23114_25406_25421(validator, true), symbolValidator: f_23114_25440_25456(validator, false), options: f_23114_25467_25547(TestOptions.ReleaseDll, MetadataImportOptions.Internal));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 24380, 25560);

                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_25406_25421(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 25406, 25421);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_25440_25456(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 25440, 25456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_25467_25547(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 25467, 25547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_25350_25548(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 25350, 25548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 24380, 25560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 24380, 25560);
            }
        }

        private void CheckConstantField(NamedTypeSymbol type, string name, Accessibility declaredAccessibility, SpecialType fieldType, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 25572, 26130);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 25737, 25804);

                var
                field = f_23114_25749_25770(type, name).SingleOrDefault() as FieldSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 25818, 25840);

                f_23114_25818_25839(field);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 25854, 25882);

                f_23114_25854_25881(f_23114_25866_25880(field));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 25896, 25923);

                f_23114_25896_25922(f_23114_25908_25921(field));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 25937, 26002);

                f_23114_25937_26001(f_23114_25950_25977(field), declaredAccessibility);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 26016, 26064);

                f_23114_26016_26063(f_23114_26029_26051(f_23114_26029_26039(field)), fieldType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 26078, 26119);

                f_23114_26078_26118(f_23114_26091_26110(field), value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 25572, 26130);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_25749_25770(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 25749, 25770);
                    return return_v;
                }


                int
                f_23114_25818_25839(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 25818, 25839);
                    return 0;
                }


                bool
                f_23114_25866_25880(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 25866, 25880);
                    return return_v;
                }


                int
                f_23114_25854_25881(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 25854, 25881);
                    return 0;
                }


                bool
                f_23114_25908_25921(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 25908, 25921);
                    return return_v;
                }


                int
                f_23114_25896_25922(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 25896, 25922);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_23114_25950_25977(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 25950, 25977);
                    return return_v;
                }


                int
                f_23114_25937_26001(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 25937, 26001);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_23114_26029_26039(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 26029, 26039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_23114_26029_26051(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 26029, 26051);
                    return return_v;
                }


                int
                f_23114_26016_26063(Microsoft.CodeAnalysis.SpecialType
                expected, Microsoft.CodeAnalysis.SpecialType
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 26016, 26063);
                    return 0;
                }


                object
                f_23114_26091_26110(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 26091, 26110);
                    return return_v;
                }


                int
                f_23114_26078_26118(object
                expected, object
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 26078, 26118);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 25572, 26130);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 25572, 26130);
            }
        }

        [Fact]
        public void DoNotImportPrivateMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 26210, 28368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 26290, 27287);

                string
                source =
                @"namespace Namespace
{
    public class Public { }
    internal class Internal { }
}
class Types
{
    public class Public { }
    internal class Internal { }
    protected class Protected { }
    protected internal class ProtectedInternal { }
    private class Private { }
}
class Fields
{
    public object Public = null;
    internal object Internal = null;
    protected object Protected = null;
    protected internal object ProtectedInternal = null;
    private object Private = null;
}
class Methods
{
    public void Public() { }
    internal void Internal() { }
    protected void Protected() { }
    protected internal void ProtectedInternal() { }
    private void Private() { }
}
class Properties
{
    public object Public { get; set; }
    internal object Internal { get; set; }
    protected object Protected { get; set; }
    protected internal object ProtectedInternal { get; set; }
    private object Private { get; set; }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 27301, 28142);

                Func<bool, Action<ModuleSymbol>>
                validator = isFromSource => module =>
                            {
                                var nmspace = module.GlobalNamespace.GetMember<NamespaceSymbol>("Namespace");
                                Assert.NotNull(nmspace.GetTypeMembers("Public").SingleOrDefault());
                                Assert.NotNull(nmspace.GetTypeMembers("Internal").SingleOrDefault());

                                CheckPrivateMembers(module.GlobalNamespace.GetTypeMembers("Types").Single(), isFromSource, true);
                                CheckPrivateMembers(module.GlobalNamespace.GetTypeMembers("Fields").Single(), isFromSource, false);
                                CheckPrivateMembers(module.GlobalNamespace.GetTypeMembers("Methods").Single(), isFromSource, false);
                                CheckPrivateMembers(module.GlobalNamespace.GetTypeMembers("Properties").Single(), isFromSource, false);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28158, 28357);

                f_23114_28158_28356(this, source: source, sourceSymbolValidator: f_23114_28214_28229(validator, true), symbolValidator: f_23114_28248_28264(validator, false), options: f_23114_28275_28355(TestOptions.ReleaseDll, MetadataImportOptions.Internal));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 26210, 28368);

                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_28214_28229(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28214, 28229);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_28248_28264(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28248, 28264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_28275_28355(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28275, 28355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_28158_28356(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28158, 28356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 26210, 28368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 26210, 28368);
            }
        }

        private void CheckPrivateMembers(NamedTypeSymbol type, bool isFromSource, bool importPrivates)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 28380, 29230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28499, 28513);

                Symbol
                member
                = default(Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28527, 28580);

                member = f_23114_28536_28561(type, "Public").SingleOrDefault();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28594, 28617);

                f_23114_28594_28616(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28631, 28686);

                member = f_23114_28640_28667(type, "Internal").SingleOrDefault();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28700, 28723);

                f_23114_28700_28722(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28737, 28793);

                member = f_23114_28746_28774(type, "Protected").SingleOrDefault();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28807, 28830);

                f_23114_28807_28829(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28844, 28908);

                member = f_23114_28853_28889(type, "ProtectedInternal").SingleOrDefault();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28922, 28945);

                f_23114_28922_28944(member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 28959, 29013);

                member = f_23114_28968_28994(type, "Private").SingleOrDefault();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 29027, 29219) || true) && (isFromSource || (DynAbs.Tracing.TraceSender.Expression_False(23114, 29031, 29061) || importPrivates))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 29027, 29219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 29095, 29118);

                    f_23114_29095_29117(member);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 29027, 29219);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 29027, 29219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 29184, 29204);

                    f_23114_29184_29203(member);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 29027, 29219);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 28380, 29230);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_28536_28561(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28536, 28561);
                    return return_v;
                }


                int
                f_23114_28594_28616(Microsoft.CodeAnalysis.CSharp.Symbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28594, 28616);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_28640_28667(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28640, 28667);
                    return return_v;
                }


                int
                f_23114_28700_28722(Microsoft.CodeAnalysis.CSharp.Symbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28700, 28722);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_28746_28774(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28746, 28774);
                    return return_v;
                }


                int
                f_23114_28807_28829(Microsoft.CodeAnalysis.CSharp.Symbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28807, 28829);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_28853_28889(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28853, 28889);
                    return return_v;
                }


                int
                f_23114_28922_28944(Microsoft.CodeAnalysis.CSharp.Symbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28922, 28944);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_28968_28994(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 28968, 28994);
                    return return_v;
                }


                int
                f_23114_29095_29117(Microsoft.CodeAnalysis.CSharp.Symbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 29095, 29117);
                    return 0;
                }


                int
                f_23114_29184_29203(Microsoft.CodeAnalysis.CSharp.Symbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 29184, 29203);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 28380, 29230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 28380, 29230);
            }
        }

        [Fact]
        public void GenericBaseTypeResolution()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 29242, 30168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 29322, 29405);

                string
                source =
                @"class Base<T, U>
{
}
class Derived<T, U> : Base<T, U>
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 29419, 30048);

                Action<ModuleSymbol>
                validator = module =>
                            {
                                var derivedType = module.GlobalNamespace.GetTypeMembers("Derived").Single();
                                Assert.Equal(2, derivedType.Arity);

                                var baseType = derivedType.BaseType();
                                Assert.Equal("Base", baseType.Name);
                                Assert.Equal(2, baseType.Arity);

                                Assert.Equal(derivedType.BaseType(), baseType);
                                Assert.Same(baseType.TypeArguments()[0], derivedType.TypeParameters[0]);
                                Assert.Same(baseType.TypeArguments()[1], derivedType.TypeParameters[1]);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 30062, 30157);

                f_23114_30062_30156(this, source: source, sourceSymbolValidator: validator, symbolValidator: validator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 29242, 30168);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_30062_30156(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 30062, 30156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 29242, 30168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 29242, 30168);
            }
        }

        [Fact]
        public void ImportExplicitImplementations()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 30180, 31492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 30264, 30438);

                string
                source =
                @"interface I
{
    void Method();
    object Property { get; set; }
}
class C : I
{
    void I.Method() { }
    object I.Property { get; set; }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 30452, 31372);

                Action<ModuleSymbol>
                validator = module =>
                            {
                // Interface
                var type = module.GlobalNamespace.GetTypeMembers("I").Single();
                                var method = (MethodSymbol)type.GetMembers("Method").Single();
                                Assert.NotNull(method);
                                var property = (PropertySymbol)type.GetMembers("Property").Single();
                                Assert.NotNull(property.GetMethod);
                                Assert.NotNull(property.SetMethod);

                // Implementation
                type = module.GlobalNamespace.GetTypeMembers("C").Single();
                                method = (MethodSymbol)type.GetMembers("I.Method").Single();
                                Assert.NotNull(method);
                                property = (PropertySymbol)type.GetMembers("I.Property").Single();
                                Assert.NotNull(property.GetMethod);
                                Assert.NotNull(property.SetMethod);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 31386, 31481);

                f_23114_31386_31480(this, source: source, sourceSymbolValidator: validator, symbolValidator: validator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 30180, 31492);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_31386_31480(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 31386, 31480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 30180, 31492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 30180, 31492);
            }
        }

        [Fact]
        public void Properties()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 31504, 35580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 31569, 32184);

                string
                source =
                @"public class C
{
    public int P1 { get { return 0; } set { } }
    internal int P2 { get { return 0; } }
    protected internal int P3 { get { return 0; } }
    protected int P4 { get { return 0; } }
    private int P5 { set { } }
    int P6 { get { return 0; } }
    public int P7 { private get { return 0; } set { } }
    internal int P8 { get { return 0; } private set { } }
    protected int P9 { get { return 0; } private set { } }
    protected internal int P10 { protected get { return 0; } set { } }
    protected internal int P11 { internal get { return 0; } set { } }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 32198, 35354);

                Func<bool, Action<ModuleSymbol>>
                validator = isFromSource => module =>
                            {
                                var type = module.GlobalNamespace.GetTypeMembers("C").Single();
                                var members = type.GetMembers();

                // Ensure member names are unique.
                var memberNames = members.Select(member => member.Name).Distinct().ToList();
                                Assert.Equal(memberNames.Count, members.Length);

                                var c = members.First(member => member.Name == ".ctor");
                                Assert.NotNull(c);

                                var p1 = (PropertySymbol)members.First(member => member.Name == "P1");
                                var p2 = (PropertySymbol)members.First(member => member.Name == "P2");
                                var p3 = (PropertySymbol)members.First(member => member.Name == "P3");
                                var p4 = (PropertySymbol)members.First(member => member.Name == "P4");
                                var p7 = (PropertySymbol)members.First(member => member.Name == "P7");
                                var p8 = (PropertySymbol)members.First(member => member.Name == "P8");
                                var p9 = (PropertySymbol)members.First(member => member.Name == "P9");
                                var p10 = (PropertySymbol)members.First(member => member.Name == "P10");
                                var p11 = (PropertySymbol)members.First(member => member.Name == "P11");

                                var privateOrNotApplicable = isFromSource ? Accessibility.Private : Accessibility.NotApplicable;

                                CheckPropertyAccessibility(p1, Accessibility.Public, Accessibility.Public, Accessibility.Public);
                                CheckPropertyAccessibility(p2, Accessibility.Internal, Accessibility.Internal, Accessibility.NotApplicable);
                                CheckPropertyAccessibility(p3, Accessibility.ProtectedOrInternal, Accessibility.ProtectedOrInternal, Accessibility.NotApplicable);
                                CheckPropertyAccessibility(p4, Accessibility.Protected, Accessibility.Protected, Accessibility.NotApplicable);
                                CheckPropertyAccessibility(p7, Accessibility.Public, privateOrNotApplicable, Accessibility.Public);
                                CheckPropertyAccessibility(p8, Accessibility.Internal, Accessibility.Internal, privateOrNotApplicable);
                                CheckPropertyAccessibility(p9, Accessibility.Protected, Accessibility.Protected, privateOrNotApplicable);
                                CheckPropertyAccessibility(p10, Accessibility.ProtectedOrInternal, Accessibility.Protected, Accessibility.ProtectedOrInternal);
                                CheckPropertyAccessibility(p11, Accessibility.ProtectedOrInternal, Accessibility.Internal, Accessibility.ProtectedOrInternal);

                                if (isFromSource)
                                {
                                    var p5 = (PropertySymbol)members.First(member => member.Name == "P5");
                                    var p6 = (PropertySymbol)members.First(member => member.Name == "P6");
                                    CheckPropertyAccessibility(p5, Accessibility.Private, Accessibility.NotApplicable, Accessibility.Private);
                                    CheckPropertyAccessibility(p6, Accessibility.Private, Accessibility.Private, Accessibility.NotApplicable);
                                }
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 35370, 35569);

                f_23114_35370_35568(this, source: source, sourceSymbolValidator: f_23114_35426_35441(validator, true), symbolValidator: f_23114_35460_35476(validator, false), options: f_23114_35487_35567(TestOptions.ReleaseDll, MetadataImportOptions.Internal));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 31504, 35580);

                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_35426_35441(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 35426, 35441);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_35460_35476(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 35460, 35476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_35487_35567(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 35487, 35567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_35370_35568(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 35370, 35568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 31504, 35580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 31504, 35580);
            }
        }

        [Fact]
        public void SetGetOnlyAutopropsInConstructors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 35592, 36154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 35680, 36080);

                var
                comp = f_23114_35691_36079(@"using System;
class C
{
    public int P1 { get; }
    public static int P2 { get; }

    public C()
    {
        P1 = 10;
    }

    static C()
    {
        P2 = 11;
    }
    
    static void Main()
    {
        Console.Write(C.P2);
        var c = new C();
        Console.Write(c.P1);
    }
}", options: TestOptions.DebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 36096, 36143);

                f_23114_36096_36142(this, comp, expectedOutput: "1110");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 35592, 36154);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_35691_36079(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 35691, 36079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_36096_36142(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 36096, 36142);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 35592, 36154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 35592, 36154);
            }
        }

        [Fact]
        public void AutoPropInitializersClass()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 36166, 38288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 36246, 36785);

                var
                comp = f_23114_36257_36784(@"using System;
class C
{
    public int P { get; set; } = 1;
    public string Q { get; set; } = ""test"";
    public decimal R { get; } = 300;
    public static char S { get; } = 'S';

    static void Main()
    {
        var c = new C();
        Console.Write(c.P);
        Console.Write(c.Q);
        Console.Write(c.R);
        Console.Write(C.S);
    }
}", parseOptions: TestOptions.Regular, options: f_23114_36703_36783(TestOptions.ReleaseExe, MetadataImportOptions.Internal))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 36799, 38123);

                Action<ModuleSymbol>
                validator = module =>
                            {
                                var type = module.GlobalNamespace.GetMember<NamedTypeSymbol>("C");

                                var p = type.GetMember<SourcePropertySymbol>("P");
                                var pBack = p.BackingField;
                                Assert.False(pBack.IsReadOnly);
                                Assert.False(pBack.IsStatic);
                                Assert.Equal(SpecialType.System_Int32, pBack.Type.SpecialType);

                                var q = type.GetMember<SourcePropertySymbol>("Q");
                                var qBack = q.BackingField;
                                Assert.False(qBack.IsReadOnly);
                                Assert.False(qBack.IsStatic);
                                Assert.Equal(SpecialType.System_String, qBack.Type.SpecialType);

                                var r = type.GetMember<SourcePropertySymbol>("R");
                                var rBack = r.BackingField;
                                Assert.True(rBack.IsReadOnly);
                                Assert.False(rBack.IsStatic);
                                Assert.Equal(SpecialType.System_Decimal, rBack.Type.SpecialType);

                                var s = type.GetMember<SourcePropertySymbol>("S");
                                var sBack = s.BackingField;
                                Assert.True(sBack.IsReadOnly);
                                Assert.True(sBack.IsStatic);
                                Assert.Equal(SpecialType.System_Char, sBack.Type.SpecialType);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 38139, 38277);

                f_23114_38139_38276(this, comp, sourceSymbolValidator: validator, expectedOutput: "1test300S");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 36166, 38288);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_36703_36783(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 36703, 36783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_36257_36784(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions: parseOptions, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 36257, 36784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_38139_38276(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, sourceSymbolValidator: sourceSymbolValidator, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 38139, 38276);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 36166, 38288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 36166, 38288);
            }
        }

        [Fact]
        public void AutoPropInitializersStruct()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 38300, 40642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 38381, 39137);

                var
                comp = f_23114_38392_39136(@"
using System;
struct S
{
    public readonly int P;
    public string Q { get; }
    public decimal R { get; }
    public static char T { get; } = 'T';

    public S(int p)
    {
        P = p;
        Q = ""test"";
        R = 300;
    }

    static void Main()
    {
        var s = new S(1);
        Console.Write(s.P);
        Console.Write(s.Q);
        Console.Write(s.R);
        Console.Write(S.T);

        s = new S();
        Console.Write(s.P);
        Console.Write(s.Q ?? ""null"");
        Console.Write(s.R);
        Console.Write(S.T);
    }
}", parseOptions: TestOptions.Regular, options: f_23114_39055_39135(TestOptions.ReleaseExe, MetadataImportOptions.Internal))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 39153, 40470);

                Action<ModuleSymbol>
                validator = module =>
                            {
                                var type = module.GlobalNamespace.GetMember<NamedTypeSymbol>("S");

                                var p = type.GetMember<SourceMemberFieldSymbol>("P");
                                Assert.False(p.HasInitializer);
                                Assert.True(p.IsReadOnly);
                                Assert.False(p.IsStatic);
                                Assert.Equal(SpecialType.System_Int32, p.Type.SpecialType);

                                var q = type.GetMember<SourcePropertySymbol>("Q");
                                var qBack = q.BackingField;
                                Assert.True(qBack.IsReadOnly);
                                Assert.False(qBack.IsStatic);
                                Assert.Equal(SpecialType.System_String, qBack.Type.SpecialType);

                                var r = type.GetMember<SourcePropertySymbol>("R");
                                var rBack = r.BackingField;
                                Assert.True(rBack.IsReadOnly);
                                Assert.False(rBack.IsStatic);
                                Assert.Equal(SpecialType.System_Decimal, rBack.Type.SpecialType);

                                var s = type.GetMember<SourcePropertySymbol>("T");
                                var sBack = s.BackingField;
                                Assert.True(sBack.IsReadOnly);
                                Assert.True(sBack.IsStatic);
                                Assert.Equal(SpecialType.System_Char, sBack.Type.SpecialType);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 40486, 40631);

                f_23114_40486_40630(this, comp, sourceSymbolValidator: validator, expectedOutput: "1test300T0null0T");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 38300, 40642);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_39055_39135(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 39055, 39135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_38392_39136(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, parseOptions: parseOptions, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 38392, 39136);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_40486_40630(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, sourceSymbolValidator: sourceSymbolValidator, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 40486, 40630);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 38300, 40642);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 38300, 40642);
            }
        }

        [Fact]
        public void PrivatePropertyAccessorNotVirtual()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 40777, 45129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 40865, 41309);

                string
                source = @"
class C
{
    public virtual int P { get; private set; }
    public virtual int Q { get; internal set; }
}
class D : C
{
    public override int Q { internal set { } }
}
class E : D
{
    public override int Q { get { return 0; } }
}
class F : E
{
    public override int P { get { return 0; } }
    public override int Q { internal set { } }
}
class Program
{
    static void Main()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 41323, 44996);

                Func<bool, Action<ModuleSymbol>>
                validator = isFromSource => module =>
                            {
                                var type = module.GlobalNamespace.GetTypeMembers("C").Single();
                                bool checkValidProperties = (type is PENamedTypeSymbol);

                                var propertyP = (PropertySymbol)type.GetMembers("P").Single();
                                if (isFromSource)
                                {
                                    CheckPropertyAccessibility(propertyP, Accessibility.Public, Accessibility.Public, Accessibility.Private);
                                    Assert.False(propertyP.SetMethod.IsVirtual);
                                    Assert.False(propertyP.SetMethod.IsOverride);
                                }
                                else
                                {
                                    CheckPropertyAccessibility(propertyP, Accessibility.Public, Accessibility.Public, Accessibility.NotApplicable);
                                    Assert.Null(propertyP.SetMethod);
                                }
                                Assert.True(propertyP.GetMethod.IsVirtual);
                                Assert.False(propertyP.GetMethod.IsOverride);
                                var propertyQ = (PropertySymbol)type.GetMembers("Q").Single();
                                CheckPropertyAccessibility(propertyQ, Accessibility.Public, Accessibility.Public, Accessibility.Internal);
                                Assert.True(propertyQ.GetMethod.IsVirtual);
                                Assert.False(propertyQ.GetMethod.IsOverride);
                                Assert.True(propertyQ.SetMethod.IsVirtual);
                                Assert.False(propertyQ.SetMethod.IsOverride);
                                Assert.False(propertyQ.IsReadOnly);
                                Assert.False(propertyQ.IsWriteOnly);
                                if (checkValidProperties)
                                {
                                    Assert.False(propertyP.MustCallMethodsDirectly);
                                    Assert.False(propertyQ.MustCallMethodsDirectly);
                                }

                                type = module.GlobalNamespace.GetTypeMembers("F").Single();
                                propertyP = (PropertySymbol)type.GetMembers("P").Single();
                                CheckPropertyAccessibility(propertyP, Accessibility.Public, Accessibility.Public, Accessibility.NotApplicable);
                                Assert.False(propertyP.GetMethod.IsVirtual);
                                Assert.True(propertyP.GetMethod.IsOverride);
                                propertyQ = (PropertySymbol)type.GetMembers("Q").Single();
                // Derived property should be public even though the only
                // declared accessor on the derived property is internal.
                CheckPropertyAccessibility(propertyQ, Accessibility.Public, Accessibility.NotApplicable, Accessibility.Internal);
                                Assert.False(propertyQ.SetMethod.IsVirtual);
                                Assert.True(propertyQ.SetMethod.IsOverride);
                                Assert.False(propertyQ.IsReadOnly);
                                Assert.False(propertyQ.IsWriteOnly);
                                if (checkValidProperties)
                                {
                                    Assert.False(propertyP.MustCallMethodsDirectly);
                                    Assert.False(propertyQ.MustCallMethodsDirectly);
                                }
                // Overridden property should be E but overridden
                // accessor should be D.set_Q.
                var overriddenProperty = module.GlobalNamespace.GetTypeMembers("E").Single().GetMembers("Q").Single();
                                Assert.NotNull(overriddenProperty);
                                Assert.Same(overriddenProperty, propertyQ.OverriddenProperty);
                                var overriddenAccessor = module.GlobalNamespace.GetTypeMembers("D").Single().GetMembers("set_Q").Single();
                                Assert.NotNull(overriddenProperty);
                                Assert.Same(overriddenAccessor, propertyQ.SetMethod.OverriddenMethod);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 45010, 45118);

                f_23114_45010_45117(this, source: source, sourceSymbolValidator: f_23114_45066_45081(validator, true), symbolValidator: f_23114_45100_45116(validator, false));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 40777, 45129);

                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_45066_45081(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 45066, 45081);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_45100_45116(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 45100, 45116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_45010_45117(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 45010, 45117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 40777, 45129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 40777, 45129);
            }
        }

        [Fact]
        public void InterfaceProperties()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 45141, 45893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 45215, 45348);

                string
                source = @"
interface I
{
    int P { get; set; }
}
public class C : I
{
    int I.P { get { return 0; } set { } }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 45362, 45773);

                Action<ModuleSymbol>
                validator = module =>
                            {
                                var type = module.GlobalNamespace.GetTypeMembers("C").Single();
                                var members = type.GetMembers();
                                var ip = (PropertySymbol)members.First(member => member.Name == "I.P");
                                CheckPropertyAccessibility(ip, Accessibility.Private, Accessibility.Private, Accessibility.Private);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 45787, 45882);

                f_23114_45787_45881(this, source: source, sourceSymbolValidator: validator, symbolValidator: validator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 45141, 45893);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_45787_45881(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 45787, 45881);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 45141, 45893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 45141, 45893);
            }
        }

        private static void CheckPropertyAccessibility(PropertySymbol property, Accessibility propertyAccessibility, Accessibility getterAccessibility, Accessibility setterAccessibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23114, 45905, 46579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 46108, 46148);

                var
                type = f_23114_46119_46147(property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 46162, 46240);

                f_23114_46162_46239(Microsoft.Cci.PrimitiveTypeCode.Void, type.PrimitiveTypeCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 46254, 46322);

                f_23114_46254_46321(propertyAccessibility, f_23114_46290_46320(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 46336, 46445);

                f_23114_46336_46444(property, propertyAccessibility, f_23114_46404_46422(property), getterAccessibility);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 46459, 46568);

                f_23114_46459_46567(property, propertyAccessibility, f_23114_46527_46545(property), setterAccessibility);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23114, 45905, 46579);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_23114_46119_46147(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 46119, 46147);
                    return return_v;
                }


                int
                f_23114_46162_46239(Microsoft.Cci.PrimitiveTypeCode
                expected, Microsoft.Cci.PrimitiveTypeCode
                actual)
                {
                    Assert.NotEqual(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 46162, 46239);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_23114_46290_46320(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 46290, 46320);
                    return return_v;
                }


                int
                f_23114_46254_46321(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 46254, 46321);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23114_46404_46422(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 46404, 46422);
                    return return_v;
                }


                int
                f_23114_46336_46444(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property, Microsoft.CodeAnalysis.Accessibility
                propertyAccessibility, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor, Microsoft.CodeAnalysis.Accessibility
                accessorAccessibility)
                {
                    CheckPropertyAccessorAccessibility(property, propertyAccessibility, accessor, accessorAccessibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 46336, 46444);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23114_46527_46545(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 46527, 46545);
                    return return_v;
                }


                int
                f_23114_46459_46567(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property, Microsoft.CodeAnalysis.Accessibility
                propertyAccessibility, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor, Microsoft.CodeAnalysis.Accessibility
                accessorAccessibility)
                {
                    CheckPropertyAccessorAccessibility(property, propertyAccessibility, accessor, accessorAccessibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 46459, 46567);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 45905, 46579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 45905, 46579);
            }
        }

        private static void CheckPropertyAccessorAccessibility(PropertySymbol property, Accessibility propertyAccessibility, MethodSymbol accessor, Accessibility accessorAccessibility)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23114, 46591, 47478);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 46792, 47467) || true) && (accessor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 46792, 47467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 46846, 46911);

                    f_23114_46846_46910(Accessibility.NotApplicable, accessorAccessibility);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 46792, 47467);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 46792, 47467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 46977, 47022);

                    var
                    containingType = f_23114_46998_47021(property)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 47040, 47090);

                    f_23114_47040_47089(property, f_23114_47063_47088(accessor));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 47108, 47162);

                    f_23114_47108_47161(containingType, f_23114_47137_47160(accessor));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 47180, 47236);

                    f_23114_47180_47235(containingType, f_23114_47209_47234(accessor));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 47254, 47317);

                    var
                    method = f_23114_47267_47307(containingType, f_23114_47293_47306(accessor)).Single()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 47335, 47366);

                    f_23114_47335_47365(method, accessor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 47384, 47452);

                    f_23114_47384_47451(accessorAccessibility, f_23114_47420_47450(accessor));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 46792, 47467);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23114, 46591, 47478);

                int
                f_23114_46846_46910(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 46846, 46910);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23114_46998_47021(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 46998, 47021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_23114_47063_47088(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 47063, 47088);
                    return return_v;
                }


                int
                f_23114_47040_47089(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    Assert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 47040, 47089);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23114_47137_47160(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 47137, 47160);
                    return return_v;
                }


                int
                f_23114_47108_47161(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 47108, 47161);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_23114_47209_47234(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 47209, 47234);
                    return return_v;
                }


                int
                f_23114_47180_47235(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbol
                actual)
                {
                    Assert.Equal((Microsoft.CodeAnalysis.CSharp.Symbol)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 47180, 47235);
                    return 0;
                }


                string
                f_23114_47293_47306(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 47293, 47306);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_47267_47307(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 47267, 47307);
                    return return_v;
                }


                int
                f_23114_47335_47365(Microsoft.CodeAnalysis.CSharp.Symbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                actual)
                {
                    Assert.Equal(expected, (Microsoft.CodeAnalysis.CSharp.Symbol)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 47335, 47365);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_23114_47420_47450(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 47420, 47450);
                    return return_v;
                }


                int
                f_23114_47384_47451(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 47384, 47451);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 46591, 47478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 46591, 47478);
            }
        }

        [WorkItem(538720, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538720")]
        [Fact]
        public void TestPropertyOverrideGet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 47693, 48332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 47863, 48086);

                f_23114_47863_48085(this, @"
class A
{
    public virtual int P { get { return 0; } }
}
class B : A
{
    public virtual int get_P() { return 0; }
}
class C : B
{
    public override int P { get { return 0; } }
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 48100, 48321);

                f_23114_48100_48320(this, @"
class A
{
    public virtual int get_P() { return 0; }
}
class B : A
{
    public virtual int P { get { return 0; } }
}
class C : B
{
    public override int get_P() { return 0; }
}
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 47693, 48332);

                int
                f_23114_47863_48085(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    this_param.PropertyOverrideGet(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 47863, 48085);
                    return 0;
                }


                int
                f_23114_48100_48320(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    this_param.PropertyOverrideGet(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 48100, 48320);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 47693, 48332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 47693, 48332);
            }
        }

        private void PropertyOverrideGet(string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 48344, 49398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 48416, 49278);

                Action<ModuleSymbol>
                validator = module =>
                            {
                                var typeA = module.GlobalNamespace.GetTypeMembers("A").Single();
                                Assert.NotNull(typeA);
                                var getMethodA = (MethodSymbol)typeA.GetMembers("get_P").Single();
                                Assert.NotNull(getMethodA);
                                Assert.True(getMethodA.IsVirtual);
                                Assert.False(getMethodA.IsOverride);

                                var typeC = module.GlobalNamespace.GetTypeMembers("C").Single();
                                Assert.NotNull(typeC);
                                var getMethodC = (MethodSymbol)typeC.GetMembers("get_P").Single();
                                Assert.NotNull(getMethodC);
                                Assert.False(getMethodC.IsVirtual);
                                Assert.True(getMethodC.IsOverride);

                                Assert.Same(getMethodC.OverriddenMethod, getMethodA);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 49292, 49387);

                f_23114_49292_49386(this, source: source, sourceSymbolValidator: validator, symbolValidator: validator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 48344, 49398);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_49292_49386(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 49292, 49386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 48344, 49398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 48344, 49398);
            }
        }

        [Fact]
        public void AutoProperties()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 49410, 50693);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 49479, 49677);

                string
                source = @"
class A
{
    public int P { get; private set; }
    internal int Q { get; set; }
}
class B<T>
{
    protected internal T P { get; set; }
}
class C : B<string>
{
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 49691, 50411);

                Func<bool, Action<ModuleSymbol>>
                validator = isFromSource => module =>
                            {
                                var classA = module.GlobalNamespace.GetTypeMember("A");
                                var p = classA.GetProperty("P");
                                VerifyAutoProperty(p, isFromSource);
                                var q = classA.GetProperty("Q");
                                VerifyAutoProperty(q, isFromSource);

                                var classC = module.GlobalNamespace.GetTypeMembers("C").Single();
                                p = classC.BaseType().GetProperty("P");
                                VerifyAutoProperty(p, isFromSource);
                                Assert.Equal(SpecialType.System_String, p.Type.SpecialType);
                                Assert.Equal(p.GetMethod.AssociatedSymbol, p);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 50427, 50682);

                f_23114_50427_50681(this, source, sourceSymbolValidator: f_23114_50510_50525(validator, true), symbolValidator: f_23114_50561_50577(validator, false), options: f_23114_50605_50680(TestOptions.ReleaseDll, MetadataImportOptions.All));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 49410, 50693);

                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_50510_50525(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 50510, 50525);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_50561_50577(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 50561, 50577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_50605_50680(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 50605, 50680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_50427_50681(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 50427, 50681);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 49410, 50693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 49410, 50693);
            }
        }

        private static void VerifyAutoProperty(PropertySymbol property, bool isFromSource)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23114, 50705, 51661);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 50812, 51506) || true) && (isFromSource)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 50812, 51506);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 50862, 51032) || true) && (property is SourcePropertySymbol sourceProperty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 50862, 51032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 50955, 51013);

                        f_23114_50955_51012(f_23114_50967_51011(sourceProperty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 50862, 51032);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 50812, 51506);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 50812, 51506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51098, 51202);

                    var
                    backingField = f_23114_51117_51201(f_23114_51117_51140(property), f_23114_51150_51200(f_23114_51186_51199(property)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51220, 51274);

                    var
                    attribute = f_23114_51236_51264(backingField).Single()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51294, 51417);

                    f_23114_51294_51416("System.Runtime.CompilerServices.CompilerGeneratedAttribute", f_23114_51369_51415(f_23114_51369_51393(attribute)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51435, 51491);

                    f_23114_51435_51490(f_23114_51448_51489(f_23114_51448_51478(attribute)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 50812, 51506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51522, 51579);

                f_23114_51522_51578(property, f_23114_51559_51577(property));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51593, 51650);

                f_23114_51593_51649(property, f_23114_51630_51648(property));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23114, 50705, 51661);

                bool
                f_23114_50967_51011(Microsoft.CodeAnalysis.CSharp.Symbols.SourcePropertySymbol
                this_param)
                {
                    var return_v = this_param.IsAutoPropertyWithGetAccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 50967, 51011);
                    return return_v;
                }


                int
                f_23114_50955_51012(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 50955, 51012);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23114_51117_51140(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51117, 51140);
                    return return_v;
                }


                string
                f_23114_51186_51199(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51186, 51199);
                    return return_v;
                }


                string
                f_23114_51150_51200(string
                propertyName)
                {
                    var return_v = GeneratedNames.MakeBackingFieldName(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51150, 51200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_23114_51117_51201(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, string
                name)
                {
                    var return_v = symbol.GetField(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51117, 51201);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_23114_51236_51264(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51236, 51264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_23114_51369_51393(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51369, 51393);
                    return return_v;
                }


                string
                f_23114_51369_51415(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol)
                {
                    var return_v = symbol.ToTestDisplayString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51369, 51415);
                    return return_v;
                }


                int
                f_23114_51294_51416(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51294, 51416);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_23114_51448_51478(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                this_param)
                {
                    var return_v = this_param.AttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51448, 51478);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_23114_51448_51489(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51448, 51489);
                    return return_v;
                }


                int
                f_23114_51435_51490(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                collection)
                {
                    Assert.Empty((System.Collections.IEnumerable)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51435, 51490);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23114_51559_51577(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51559, 51577);
                    return return_v;
                }


                int
                f_23114_51522_51578(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor)
                {
                    VerifyAutoPropertyAccessor(property, accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51522, 51578);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23114_51630_51648(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51630, 51648);
                    return return_v;
                }


                int
                f_23114_51593_51649(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor)
                {
                    VerifyAutoPropertyAccessor(property, accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51593, 51649);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 50705, 51661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 50705, 51661);
            }
        }

        private static void VerifyAutoPropertyAccessor(PropertySymbol property, MethodSymbol accessor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(23114, 51673, 52204);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51792, 52193) || true) && (accessor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 51792, 52193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51846, 51918);

                    var
                    method = f_23114_51859_51908(f_23114_51859_51882(property), f_23114_51894_51907(accessor)).Single()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51936, 51967);

                    f_23114_51936_51966(method, accessor);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 51985, 52035);

                    f_23114_51985_52034(f_23114_51998_52023(accessor), property);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 52053, 52178);

                    f_23114_52053_52177(f_23114_52066_52095(accessor), "MethodSymbol.IsImplicitlyDeclared should be false for auto property accessors");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 51792, 52193);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(23114, 51673, 52204);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23114_51859_51882(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51859, 51882);
                    return return_v;
                }


                string
                f_23114_51894_51907(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51894, 51907);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_51859_51908(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51859, 51908);
                    return return_v;
                }


                int
                f_23114_51936_51966(Microsoft.CodeAnalysis.CSharp.Symbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                actual)
                {
                    Assert.Equal(expected, (Microsoft.CodeAnalysis.CSharp.Symbol)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51936, 51966);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_23114_51998_52023(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 51998, 52023);
                    return return_v;
                }


                int
                f_23114_51985_52034(Microsoft.CodeAnalysis.CSharp.Symbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                actual)
                {
                    Assert.Equal(expected, (Microsoft.CodeAnalysis.CSharp.Symbol)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 51985, 52034);
                    return 0;
                }


                bool
                f_23114_52066_52095(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 52066, 52095);
                    return return_v;
                }


                int
                f_23114_52053_52177(bool
                condition, string
                userMessage)
                {
                    Assert.False(condition, userMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 52053, 52177);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 51673, 52204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 51673, 52204);
            }
        }

        [Fact]
        public void EmptyEnum()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 52216, 52744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 52280, 52308);

                string
                source = "enum E {}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 52322, 52624);

                Action<ModuleSymbol>
                validator = module =>
                            {
                                var type = module.GlobalNamespace.GetTypeMembers("E").Single();
                                CheckEnumType(type, Accessibility.Internal, SpecialType.System_Int32);
                                Assert.Equal(1, type.GetMembers().Length);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 52638, 52733);

                f_23114_52638_52732(this, source: source, sourceSymbolValidator: validator, symbolValidator: validator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 52216, 52744);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_52638_52732(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 52638, 52732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 52216, 52744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 52216, 52744);
            }
        }

        [Fact]
        public void NonEmptyEnum()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 52756, 53778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 52823, 52941);

                string
                source =
                @"enum E : short
{
    A,
    B = 0x02,
    C,
    D,
    E = B | D,
    F = C,
    G,
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 52955, 53658);

                Action<ModuleSymbol>
                validator = module =>
                            {
                                var type = module.GlobalNamespace.GetTypeMembers("E").Single();
                                CheckEnumType(type, Accessibility.Internal, SpecialType.System_Int16);

                                Assert.Equal(8, type.GetMembers().Length);
                                CheckEnumConstant(type, "A", (short)0);
                                CheckEnumConstant(type, "B", (short)2);
                                CheckEnumConstant(type, "C", (short)3);
                                CheckEnumConstant(type, "D", (short)4);
                                CheckEnumConstant(type, "E", (short)6);
                                CheckEnumConstant(type, "F", (short)3);
                                CheckEnumConstant(type, "G", (short)4);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 53672, 53767);

                f_23114_53672_53766(this, source: source, sourceSymbolValidator: validator, symbolValidator: validator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 52756, 53778);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_53672_53766(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 53672, 53766);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 52756, 53778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 52756, 53778);
            }
        }

        private void CheckEnumConstant(NamedTypeSymbol type, string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 53790, 54706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 53894, 53961);

                var
                field = f_23114_53906_53927(type, name).SingleOrDefault() as FieldSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 53975, 53997);

                f_23114_53975_53996(field);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54011, 54039);

                f_23114_54011_54038(f_23114_54023_54037(field));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54053, 54080);

                f_23114_54053_54079(f_23114_54065_54078(field));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54250, 54281);

                f_23114_54250_54280(f_23114_54263_54273(field), type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54295, 54336);

                f_23114_54295_54335(f_23114_54308_54327(field), value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54352, 54399);

                var
                sourceType = type as SourceNamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54413, 54695) || true) && ((object)sourceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 54413, 54695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54477, 54553);

                    var
                    fieldDefinition = (Microsoft.Cci.IFieldDefinition)f_23114_54531_54552(field)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54571, 54615);

                    f_23114_54571_54614(f_23114_54584_54613(fieldDefinition));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54633, 54680);

                    f_23114_54633_54679(f_23114_54646_54678(fieldDefinition));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 54413, 54695);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 53790, 54706);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_53906_53927(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 53906, 53927);
                    return return_v;
                }


                int
                f_23114_53975_53996(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 53975, 53996);
                    return 0;
                }


                bool
                f_23114_54023_54037(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 54023, 54037);
                    return return_v;
                }


                int
                f_23114_54011_54038(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54011, 54038);
                    return 0;
                }


                bool
                f_23114_54065_54078(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 54065, 54078);
                    return return_v;
                }


                int
                f_23114_54053_54079(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54053, 54079);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_23114_54263_54273(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 54263, 54273);
                    return return_v;
                }


                int
                f_23114_54250_54280(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                actual)
                {
                    Assert.Equal(expected, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54250, 54280);
                    return 0;
                }


                object
                f_23114_54308_54327(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 54308, 54327);
                    return return_v;
                }


                int
                f_23114_54295_54335(object
                expected, object
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54295, 54335);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_23114_54531_54552(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54531, 54552);
                    return return_v;
                }


                bool
                f_23114_54584_54613(Microsoft.Cci.IFieldDefinition
                this_param)
                {
                    var return_v = this_param.IsSpecialName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 54584, 54613);
                    return return_v;
                }


                int
                f_23114_54571_54614(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54571, 54614);
                    return 0;
                }


                bool
                f_23114_54646_54678(Microsoft.Cci.IFieldDefinition
                this_param)
                {
                    var return_v = this_param.IsRuntimeSpecial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 54646, 54678);
                    return return_v;
                }


                int
                f_23114_54633_54679(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54633, 54679);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 53790, 54706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 53790, 54706);
            }
        }

        private void CheckEnumType(NamedTypeSymbol type, Accessibility declaredAccessibility, SpecialType underlyingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 54718, 56990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54856, 54923);

                f_23114_54856_54922(SpecialType.System_Enum, f_23114_54894_54921(f_23114_54894_54909(type)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 54937, 55003);

                f_23114_54937_55002(f_23114_54950_54985(f_23114_54950_54973(type)), underlyingType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55017, 55081);

                f_23114_55017_55080(f_23114_55030_55056(type), declaredAccessibility);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55095, 55122);

                f_23114_55095_55121(f_23114_55107_55120(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55310, 55414);

                var
                field = f_23114_55322_55380(type, WellKnownMemberNames.EnumBackingFieldName).SingleOrDefault() as FieldSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55428, 55447);

                f_23114_55428_55446(field);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55463, 55510);

                var
                sourceType = type as SourceNamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55524, 56979) || true) && ((object)sourceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 55524, 56979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55588, 55622);

                    field = f_23114_55596_55621(sourceType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55640, 55662);

                    f_23114_55640_55661(field);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55680, 55748);

                    f_23114_55680_55747(f_23114_55693_55703(field), WellKnownMemberNames.EnumBackingFieldName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55766, 55795);

                    f_23114_55766_55794(f_23114_55779_55793(field));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55813, 55841);

                    f_23114_55813_55840(f_23114_55826_55839(field));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55859, 55890);

                    f_23114_55859_55889(f_23114_55872_55888(field));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 55908, 55972);

                    f_23114_55908_55971(Accessibility.Public, f_23114_55943_55970(field));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 56018, 56068);

                    f_23114_56018_56067(f_23114_56031_56041(field), f_23114_56043_56066(type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 56088, 56364);

                    var
                    module = f_23114_56101_56363((SourceAssemblySymbol)f_23114_56145_56174(sourceType), EmitOptions.Default, OutputKind.DynamicallyLinkedLibrary, f_23114_56255_56299(), f_23114_56301_56362())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 56384, 56499);

                    var
                    context = f_23114_56398_56498(module, null, f_23114_56428_56447(), metadataOnly: false, includePrivateMembers: true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 56519, 56592);

                    var
                    typeDefinition = (Microsoft.Cci.ITypeDefinition)f_23114_56571_56591(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 56610, 56674);

                    var
                    fieldDefinition = f_23114_56632_56673(f_23114_56632_56665(typeDefinition, context))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 56692, 56748);

                    f_23114_56692_56747(f_23114_56704_56739(fieldDefinition), field);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 56810, 56853);

                    f_23114_56810_56852(f_23114_56822_56851(fieldDefinition));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 56871, 56917);

                    f_23114_56871_56916(f_23114_56883_56915(fieldDefinition));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 56935, 56964);

                    f_23114_56935_56963(context.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 55524, 56979);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 54718, 56990);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23114_54894_54909(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = symbol.BaseType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54894, 54909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_23114_54894_54921(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 54894, 54921);
                    return return_v;
                }


                int
                f_23114_54856_54922(Microsoft.CodeAnalysis.SpecialType
                expected, Microsoft.CodeAnalysis.SpecialType
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54856, 54922);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23114_54950_54973(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 54950, 54973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_23114_54950_54985(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 54950, 54985);
                    return return_v;
                }


                int
                f_23114_54937_55002(Microsoft.CodeAnalysis.SpecialType
                expected, Microsoft.CodeAnalysis.SpecialType
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 54937, 55002);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_23114_55030_55056(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 55030, 55056);
                    return return_v;
                }


                int
                f_23114_55017_55080(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55017, 55080);
                    return 0;
                }


                bool
                f_23114_55107_55120(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSealed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 55107, 55120);
                    return return_v;
                }


                int
                f_23114_55095_55121(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55095, 55121);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_55322_55380(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55322, 55380);
                    return return_v;
                }


                int
                f_23114_55428_55446(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55428, 55446);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_23114_55596_55621(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumValueField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 55596, 55621);
                    return return_v;
                }


                int
                f_23114_55640_55661(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                @object)
                {
                    Assert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55640, 55661);
                    return 0;
                }


                string
                f_23114_55693_55703(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 55693, 55703);
                    return return_v;
                }


                int
                f_23114_55680_55747(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55680, 55747);
                    return 0;
                }


                bool
                f_23114_55779_55793(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 55779, 55793);
                    return return_v;
                }


                int
                f_23114_55766_55794(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55766, 55794);
                    return 0;
                }


                bool
                f_23114_55826_55839(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 55826, 55839);
                    return return_v;
                }


                int
                f_23114_55813_55840(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55813, 55840);
                    return 0;
                }


                bool
                f_23114_55872_55888(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 55872, 55888);
                    return return_v;
                }


                int
                f_23114_55859_55889(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55859, 55889);
                    return 0;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_23114_55943_55970(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 55943, 55970);
                    return return_v;
                }


                int
                f_23114_55908_55971(Microsoft.CodeAnalysis.Accessibility
                expected, Microsoft.CodeAnalysis.Accessibility
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 55908, 55971);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_23114_56031_56041(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 56031, 56041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23114_56043_56066(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.EnumUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 56043, 56066);
                    return return_v;
                }


                int
                f_23114_56018_56067(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                actual)
                {
                    Assert.Equal(expected, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56018, 56067);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23114_56145_56174(Microsoft.CodeAnalysis.CSharp.Symbols.SourceNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 56145, 56174);
                    return return_v;
                }


                Microsoft.Cci.ModulePropertiesForSerialization
                f_23114_56255_56299()
                {
                    var return_v = GetDefaultModulePropertiesForSerialization();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56255, 56299);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                f_23114_56301_56362()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<ResourceDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56301, 56362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilder
                f_23114_56101_56363(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                sourceAssembly, Microsoft.CodeAnalysis.Emit.EmitOptions
                emitOptions, Microsoft.CodeAnalysis.OutputKind
                outputKind, Microsoft.Cci.ModulePropertiesForSerialization
                serializationProperties, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>
                manifestResources)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilder((Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol)sourceAssembly, emitOptions, outputKind, serializationProperties, manifestResources);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56101, 56363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_23114_56428_56447()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56428, 56447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitContext
                f_23114_56398_56498(Microsoft.CodeAnalysis.CSharp.Emit.PEAssemblyBuilder
                module, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                metadataOnly, bool
                includePrivateMembers)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitContext((Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder)module, syntaxNodeOpt, diagnostics, metadataOnly: metadataOnly, includePrivateMembers: includePrivateMembers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56398, 56498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_23114_56571_56591(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56571, 56591);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                f_23114_56632_56665(Microsoft.Cci.ITypeDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetFields(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56632, 56665);
                    return return_v;
                }


                Microsoft.Cci.IFieldDefinition
                f_23114_56632_56673(System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                source)
                {
                    var return_v = source.First<Microsoft.Cci.IFieldDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56632, 56673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_23114_56704_56739(Microsoft.Cci.IFieldDefinition
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56704, 56739);
                    return return_v;
                }


                int
                f_23114_56692_56747(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                expected, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                actual)
                {
                    Assert.Same((object?)expected, (object)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56692, 56747);
                    return 0;
                }


                bool
                f_23114_56822_56851(Microsoft.Cci.IFieldDefinition
                this_param)
                {
                    var return_v = this_param.IsSpecialName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 56822, 56851);
                    return return_v;
                }


                int
                f_23114_56810_56852(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56810, 56852);
                    return 0;
                }


                bool
                f_23114_56883_56915(Microsoft.Cci.IFieldDefinition
                this_param)
                {
                    var return_v = this_param.IsRuntimeSpecial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 56883, 56915);
                    return return_v;
                }


                int
                f_23114_56871_56916(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56871, 56916);
                    return 0;
                }


                int
                f_23114_56935_56963(Microsoft.CodeAnalysis.DiagnosticBag
                actual, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    actual.Verify(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 56935, 56963);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 54718, 56990);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 54718, 56990);
            }
        }

        [Fact]
        public void GenericMethods()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 57002, 57610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 57071, 57520);

                string
                source = @"
public class A
{
    public static void Main()
    {
        System.Console.WriteLine(""GenericMethods"");
        //B.Test<int>();
        //C<int>.Test<int>();
    }
}

public class B
{
    public static void Test<T>()
    {
        System.Console.WriteLine(""Test<T>"");
    }
}

public class C<T>
{
    public static void Test<S>()
    {
        System.Console.WriteLine(""C<T>.Test<S>"");
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 57536, 57599);

                f_23114_57536_57598(this, source, expectedOutput: "GenericMethods\r\n");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 57002, 57610);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_57536_57598(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 57536, 57598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 57002, 57610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 57002, 57610);
            }
        }

        [Fact]
        public void GenericMethods2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 57622, 60353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 57692, 58836);

                string
                source = @"
class A
{
    public static void Main()
    {
        TC1 x = new TC1();
        System.Console.WriteLine(x.GetType());
        TC2<byte> y = new TC2<byte>();
        System.Console.WriteLine(y.GetType());
        TC3<byte>.TC4 z = new TC3<byte>.TC4();
        System.Console.WriteLine(z.GetType());
    }
}

class TC1
{
    void TM1<T1>()
    {
        TM1<T1>();
    }

    void TM2<T2>()
    {
        TM2<int>();
    }
}

class TC2<T3>
{
    void TM3<T4>()
    {
        TM3<T4>();
        TM3<T4>();
    }

    void TM4<T5>()
    {
        TM4<int>();
        TM4<int>();
    }

    static void TM5<T6>(T6 x)
    {
        TC2<int>.TM5(x);
    }

    static void TM6<T7>(T7 x)
    {
        TC2<int>.TM6(1);
    }

    void TM9()
    {
        TM9();
        TM9();
    }

}

class TC3<T8>
{
    public class TC4
    {
        void TM7<T9>()
        {
            TM7<T9>();
            TM7<int>();
        }

        static void TM8<T10>(T10 x)
        {
            TC3<int>.TC4.TM8(x);
            TC3<int>.TC4.TM8(1);
        }
    }
}

"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 58852, 58996);

                var
                verifier = f_23114_58867_58995(this, source, options: TestOptions.ReleaseExe, expectedOutput:
                @"TC1
TC2`1[System.Byte]
TC3`1+TC4[System.Byte]
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 59012, 59189);

                f_23114_59012_59188(
                            verifier, "TC1.TM1<T1>", @"{
  // Code size        7 (0x7)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  call       ""void TC1.TM1<T1>()""
  IL_0006:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 59205, 59383);

                f_23114_59205_59382(
                            verifier, "TC1.TM2<T2>", @"{
  // Code size        7 (0x7)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  call       ""void TC1.TM2<int>()""
  IL_0006:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 59399, 59656);

                f_23114_59399_59655(
                            verifier, "TC2<T3>.TM3<T4>", @"{
  // Code size       13 (0xd)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  call       ""void TC2<T3>.TM3<T4>()""
  IL_0006:  ldarg.0
  IL_0007:  call       ""void TC2<T3>.TM3<T4>()""
  IL_000c:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 59672, 59931);

                f_23114_59672_59930(
                            verifier, "TC2<T3>.TM4<T5>", @"{
  // Code size       13 (0xd)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  call       ""void TC2<T3>.TM4<int>()""
  IL_0006:  ldarg.0
  IL_0007:  call       ""void TC2<T3>.TM4<int>()""
  IL_000c:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 59947, 60135);

                f_23114_59947_60134(
                            verifier, "TC2<T3>.TM5<T6>", @"{
  // Code size        7 (0x7)
  .maxstack  1
  IL_0000:  ldarg.0
  IL_0001:  call       ""void TC2<int>.TM5<T6>(T6)""
  IL_0006:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 60151, 60342);

                f_23114_60151_60341(
                            verifier, "TC2<T3>.TM6<T7>", @"{
  // Code size        7 (0x7)
  .maxstack  1
  IL_0000:  ldc.i4.1
  IL_0001:  call       ""void TC2<int>.TM6<int>(int)""
  IL_0006:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 57622, 60353);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_58867_58995(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 58867, 58995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_59012_59188(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 59012, 59188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_59205_59382(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 59205, 59382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_59399_59655(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 59399, 59655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_59672_59930(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 59672, 59930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_59947_60134(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 59947, 60134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_60151_60341(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 60151, 60341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 57622, 60353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 57622, 60353);
            }
        }

        [Fact]
        public void Generics3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 60365, 62887);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 60429, 62837);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        C1<Byte, Byte> x1 = new C1<Byte, Byte>();
        C1<Byte, Byte>.C2<Byte, Byte> x2 = new C1<Byte, Byte>.C2<Byte, Byte>();
        C1<Byte, Byte>.C2<Byte, Byte>.C3<Byte, Byte> x3 = new C1<Byte, Byte>.C2<Byte, Byte>.C3<Byte, Byte>();
        C1<Byte, Byte>.C2<Byte, Byte>.C3<Byte, Byte>.C4<Byte> x4 = new C1<Byte, Byte>.C2<Byte, Byte>.C3<Byte, Byte>.C4<Byte>();
        C1<Byte, Byte>.C5 x5 = new C1<Byte, Byte>.C5();
    }
}


class C1<C1T1, C1T2>
{
    public class C2<C2T1, C2T2>
    {
        public class C3<C3T1, C3T2> where C3T2 : C1T1
        {
            public class C4<C4T1>
            {
            }
        }

        public C1<int, C2T2>.C5 V1;
        public C1<C2T1, C2T2>.C5 V2;
        public C1<int, int>.C5 V3;

        public C2<Byte, Byte> V4;

        public C1<C1T2, C1T1>.C2<C2T1, C2T2> V5;
        public C1<C1T2, C1T1>.C2<C2T2, C2T1> V6;
        public C1<C1T2, C1T1>.C2<Byte, int> V7;
        public C2<C2T1, C2T2> V8;
        public C2<Byte, C2T2> V9;

        void Test12(C2<int, int> x)
        {
            C1<C1T1, C1T2>.C2<Byte, int> y = x.V9;
        }

        void Test11(C1<int, int>.C2<Byte, Byte> x)
        {
            C1<int, int>.C2<Byte, Byte> y = x.V8;
        }

        void Test6(C1<C1T2, C1T1>.C2<C2T1, C2T2> x)
        {
            C1<C1T1, C1T2>.C2<C2T1, C2T2> y = x.V5;
        }

        void Test7(C1<C1T2, C1T1>.C2<C2T2, C2T1> x)
        {
            C1<C1T1, C1T2>.C2<C2T1, C2T2> y = x.V6;
        }

        void Test8(C1<C1T2, C1T1>.C2<C2T2, C2T1> x)
        {
            C1<C1T1, C1T2>.C2<Byte, int> y = x.V7;
        }

        void Test9(C1<int, Byte>.C2<C2T2, C2T1> x)
        {
            C1<Byte, int>.C2<Byte, int> y = x.V7;
        }

        void Test10(C1<C1T1, C1T2>.C2<C2T2, C2T1> x)
        {
            C1<C1T2, C1T1>.C2<Byte, int> y = x.V7;
        }
    }

    public class C5
    {
    }

    void Test1(C2<C1T1, int> x)
    {
        C1<int, int>.C5 y = x.V1;
    }

    void Test2(C2<C1T1, C1T2> x)
    {
        C5 y = x.V2;
    }

    void Test3(C2<C1T2, C1T1> x)
    {
        C1<int, int>.C5 y = x.V3;
    }

    void Test4(C1<int, int>.C2<C1T1, C1T2> x)
    {
        C1<int, int>.C2<Byte, Byte> y = x.V4;
    }
}

"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 62851, 62876);

                f_23114_62851_62875(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 60365, 62887);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_62851_62875(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 62851, 62875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 60365, 62887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 60365, 62887);
            }
        }

        [Fact]
        public void RefEmit_UnsupportedOrdering1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 62899, 63131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 62982, 63120);

                f_23114_62982_63119(this, @"
public class E
{
  public struct N2
  { 
    public N3 n1;
  }
  public struct N3
  { 
  }
  N2 n2; 
}
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 62899, 63131);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_62982_63119(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 62982, 63119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 62899, 63131);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 62899, 63131);
            }
        }

        [Fact]
        public void RefEmit_UnsupportedOrdering1_EP()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 63143, 63514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 63229, 63437);

                string
                source = @"
public class E
{
  public struct N2
  { 
    public N3 n1;
  }
  public struct N3
  { 
  }
  N2 n2; 

  public static void Main()
  {
    System.Console.Write(1234);
  }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 63453, 63503);

                f_23114_63453_63502(this, source, expectedOutput: @"1234");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 63143, 63514);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_63453_63502(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 63453, 63502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 63143, 63514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 63143, 63514);
            }
        }

        [Fact]
        public void RefEmit_UnsupportedOrdering2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 63526, 63690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 63609, 63679);

                f_23114_63609_63678(this, @"
class B<T> where T : A {}
class A : B<A> {}
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 63526, 63690);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_63609_63678(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 63609, 63678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 63526, 63690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 63526, 63690);
            }
        }

        [Fact]
        public void RefEmit_MembersOfOpenGenericType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 63702, 63986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 63789, 63975);

                f_23114_63789_63974(this, @"
class C<T> 
{
    void goo() 
    {
        System.Collections.Generic.Dictionary<int, T> d = new System.Collections.Generic.Dictionary<int, T>();
    }
}
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 63702, 63986);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_63789_63974(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 63789, 63974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 63702, 63986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 63702, 63986);
            }
        }

        [Fact]
        public void RefEmit_ListOfValueTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 63998, 64237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 64077, 64185);

                string
                source = @"
using System.Collections.Generic;

class A
{
    struct S { }

    List<S> f;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 64201, 64226);

                f_23114_64201_64225(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 63998, 64237);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_64201_64225(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 64201, 64225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 63998, 64237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 63998, 64237);
            }
        }

        [Fact]
        public void RefEmit_SpecializedNestedSelfReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 64249, 64473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 64342, 64421);

                string
                source = @"
class A<T>
{
    class B {
    }

    A<int>.B x;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 64437, 64462);

                f_23114_64437_64461(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 64249, 64473);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_64437_64461(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 64437, 64461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 64249, 64473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 64249, 64473);
            }
        }

        [Fact]
        public void RefEmit_SpecializedNestedGenericSelfReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 64485, 64792);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 64585, 64740);

                string
                source = @"
class A<T>
{
    public class B<S> {
        public class C<U,V> {
        }
    }

    A<int>.B<double>.C<string, bool> x;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 64756, 64781);

                f_23114_64756_64780(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 64485, 64792);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_64756_64780(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 64756, 64780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 64485, 64792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 64485, 64792);
            }
        }

        [Fact]
        public void RefEmit_Cycle()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 64804, 65025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 64872, 64975);

                string
                source = @"
public class B : I<C> { }
public class C : I<B> { }
public interface I<T> { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 64989, 65014);

                f_23114_64989_65013(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 64804, 65025);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_64989_65013(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 64989, 65013);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 64804, 65025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 64804, 65025);
            }
        }

        [Fact]
        public void RefEmit_SpecializedMemberReference()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 65037, 65415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 65126, 65363);

                string
                source = @"
class A<T>
{
    public A() 
    {
        A<int>.method();
        int a = A<string>.field;
        new A<double>();
    }

    public static void method() 
    {
    }

    public static int field;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 65379, 65404);

                f_23114_65379_65403(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 65037, 65415);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_65379_65403(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 65379, 65403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 65037, 65415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 65037, 65415);
            }
        }

        [Fact]
        public void RefEmit_NestedGenericTypeReferences()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 65427, 65672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 65517, 65620);

                string
                source = @"
class A<T>
{
    public class H<S>
    {
        A<T>.H<S> x;      
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 65636, 65661);

                f_23114_65636_65660(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 65427, 65672);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_65636_65660(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 65636, 65660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 65427, 65672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 65427, 65672);
            }
        }

        [Fact]
        public void RefEmit_Ordering2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 65684, 66091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 65848, 66039);

                string
                source = @"
public class E
{
   public class C {
     public struct N2
     { 
        public N3 n1;
     }
   }
   C.N2 n2; 
}
public struct N3
{ 
   E f;
   int g;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 66055, 66080);

                f_23114_66055_66079(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 65684, 66091);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_66055_66079(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 66055, 66079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 65684, 66091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 65684, 66091);
            }
        }

        [Fact]
        public void RefEmit_Ordering3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 66103, 66500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 66175, 66448);

                string
                source = @"
using System.Collections.Generic;

public class E
{
  public struct N2
  { 
    public List<N3> n1;        // E.N2 doesn't depend on E.N3 since List<> isn't a value type
  }
  public struct N3
  { 
  }
  N2 n2;                           
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 66464, 66489);

                f_23114_66464_66488(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 66103, 66500);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_66464_66488(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 66464, 66488);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 66103, 66500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 66103, 66500);
            }
        }

        [Fact]
        public void RefEmit_IL1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 66512, 67308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 66578, 67297);

                f_23114_66578_67296(this, @"
class C 
{ 
    public static void Main() 
    { 
        int i = 0, j, k = 2147483647;
        long l = 0, m = 9200000000000000000L;
        int b = -10;
        byte c = 200;
        float f = 3.14159F;
        double d = 2.71828;
        string s = ""abcdef"";
        bool x = true;

        System.Console.WriteLine(i);
        System.Console.WriteLine(k);
        System.Console.WriteLine(b);
        System.Console.WriteLine(c);
        System.Console.WriteLine(f);
        System.Console.WriteLine(d);
        System.Console.WriteLine(s);
        System.Console.WriteLine(x);
    }
}
", expectedOutput: @"
0
2147483647
-10
200
3.14159
2.71828
abcdef
True
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 66512, 67308);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_66578_67296(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 66578, 67296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 66512, 67308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 66512, 67308);
            }
        }

        [WorkItem(540581, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/540581")]
        [Fact]
        public void RefEmit_DependencyGraphAndCachedTypeReferences()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 67320, 68270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 67513, 67969);

                var
                source = @"
using System;

interface I1<T>
{
    void Method(T x);
}

interface I2<U>
{
    void Method(U x);
}

interface I3<W> : I1<W>, I2<W>
{
    void Method(W x);
}

class Implicit2 : I3<string>                            // Implicit2 depends on I3<string> 
{
    public void Method(string x) {  }
}

class Test
{
    public static void Main()
    {
        I3<string> i = new Implicit2();                 
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 68234, 68259);

                f_23114_68234_68258(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 67320, 68270);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_68234_68258(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 68234, 68258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 67320, 68270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 67320, 68270);
            }
        }

        [Fact]
        public void CheckRef()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 68282, 68982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 68345, 68455);

                string
                source = @"
public abstract class C
{
    public abstract int M(int x, ref int y, out int z);
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 68471, 68971);

                f_23114_68471_68970(this, source, symbolValidator: module =>
                            {
                                var global = module.GlobalNamespace;

                                var c = global.GetTypeMembers("C", 0).Single() as NamedTypeSymbol;
                                var m = c.GetMembers("M").Single() as MethodSymbol;
                                Assert.Equal(RefKind.None, m.Parameters[0].RefKind);
                                Assert.Equal(RefKind.Ref, m.Parameters[1].RefKind);
                                Assert.Equal(RefKind.Out, m.Parameters[2].RefKind);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 68282, 68982);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_68471_68970(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 68471, 68970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 68282, 68982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 68282, 68982);
            }
        }

        [Fact]
        public void OutArgument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 68994, 69217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 69060, 69167);

                string
                source = @"
class C 
{
    static void Main() { double d; double.TryParse(null, out d); } 
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 69181, 69206);

                f_23114_69181_69205(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 68994, 69217);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_69181_69205(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 69181, 69205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 68994, 69217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 68994, 69217);
            }
        }

        [Fact]
        public void CreateInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 69229, 69455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 69298, 69405);

                string
                source = @"
class C 
{
    static void Main() { System.Activator.CreateInstance<int>(); } 
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 69419, 69444);

                f_23114_69419_69443(this, source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 69229, 69455);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_69419_69443(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 69419, 69443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 69229, 69455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 69229, 69455);
            }
        }

        [Fact]
        public void DelegateRoundTrip()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 69467, 71936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 69539, 69765);

                string
                source = @"delegate int MyDel(
                int x,
                // ref int y, // commented out until 4264 is fixed.
                // out int z, // commented out until 4264 is fixed.
                int w);"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 69781, 71925);

                f_23114_69781_71924(this, source, symbolValidator: module =>
                            {
                                var global = module.GlobalNamespace;

                                var myDel = global.GetTypeMembers("MyDel", 0).Single() as NamedTypeSymbol;

                                var invoke = myDel.DelegateInvokeMethod;

                                var beginInvoke = myDel.GetMembers("BeginInvoke").Single() as MethodSymbol;
                                Assert.Equal(invoke.Parameters.Length + 2, beginInvoke.Parameters.Length);
                                Assert.Equal(TypeKind.Interface, beginInvoke.ReturnType.TypeKind);
                                Assert.Equal("System.IAsyncResult", beginInvoke.ReturnType.ToTestDisplayString());
                                for (int i = 0; i < invoke.Parameters.Length; i++)
                                {
                                    Assert.Equal(invoke.Parameters[i].Type, beginInvoke.Parameters[i].Type);
                                    Assert.Equal(invoke.Parameters[i].RefKind, beginInvoke.Parameters[i].RefKind);
                                }
                                Assert.Equal("System.AsyncCallback", beginInvoke.Parameters[invoke.Parameters.Length].Type.ToTestDisplayString());
                                Assert.Equal("System.Object", beginInvoke.Parameters[invoke.Parameters.Length + 1].Type.ToTestDisplayString());

                                var invokeReturn = invoke.ReturnType;
                                var endInvoke = myDel.GetMembers("EndInvoke").Single() as MethodSymbol;
                                var endInvokeReturn = endInvoke.ReturnType;
                                Assert.Equal(invokeReturn, endInvokeReturn);
                                int k = 0;
                                for (int i = 0; i < invoke.Parameters.Length; i++)
                                {
                                    if (invoke.Parameters[i].RefKind != RefKind.None)
                                    {
                                        Assert.Equal(invoke.Parameters[i].TypeWithAnnotations, endInvoke.Parameters[k].TypeWithAnnotations);
                                        Assert.Equal(invoke.Parameters[i].RefKind, endInvoke.Parameters[k++].RefKind);
                                    }
                                }
                                Assert.Equal("System.IAsyncResult", endInvoke.Parameters[k++].Type.ToTestDisplayString());
                                Assert.Equal(k, endInvoke.Parameters.Length);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 69467, 71936);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_69781_71924(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 69781, 71924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 69467, 71936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 69467, 71936);
            }
        }

        [Fact]
        public void StaticClassRoundTrip()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 71948, 73105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 72023, 72268);

                string
                source = @"
public static class C
{
    private static string msg = ""Hello"";

    private static void Goo()
    {
        System.Console.WriteLine(msg);
    }

    public static void Main()
    {
        Goo();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 72284, 73094);

                f_23114_72284_73093(this, source, symbolValidator: module =>
                            {
                                var global = module.GlobalNamespace;
                                var classC = global.GetMember<NamedTypeSymbol>("C");
                                Assert.True(classC.IsStatic, "Expected C to be static");
                                Assert.False(classC.IsAbstract, "Expected C to be non-abstract"); //even though it is abstract in metadata
                Assert.False(classC.IsSealed, "Expected C to be non-sealed"); //even though it is sealed in metadata
                Assert.Equal(0, classC.GetMembers(WellKnownMemberNames.InstanceConstructorName).Length); //since C is static
                Assert.Equal(0, classC.GetMembers(WellKnownMemberNames.StaticConstructorName).Length); //since we don't import private members
            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 71948, 73105);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_72284_73093(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 72284, 73093);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 71948, 73105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 71948, 73105);
            }
        }

        [Fact]
        public void DoNotImportInternalMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 73117, 73855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 73198, 73387);

                string
                sources =
                @"public class Fields
{
    public int Public;
    internal int Internal;
}
public class Methods
{
    public void Public() {}
    internal void Internal() {}
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 73403, 73727);

                Func<bool, Action<ModuleSymbol>>
                validator = isFromSource => (ModuleSymbol m) =>
                            {
                                CheckInternalMembers(m.GlobalNamespace.GetTypeMembers("Fields").Single(), isFromSource);
                                CheckInternalMembers(m.GlobalNamespace.GetTypeMembers("Methods").Single(), isFromSource);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 73743, 73844);

                f_23114_73743_73843(this, sources, sourceSymbolValidator: f_23114_73792_73807(validator, true), symbolValidator: f_23114_73826_73842(validator, false));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 73117, 73855);

                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_73792_73807(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 73792, 73807);
                    return return_v;
                }


                System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_23114_73826_73842(System.Func<bool, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>>
                this_param, bool
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 73826, 73842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_73743_73843(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 73743, 73843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 73117, 73855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 73117, 73855);
            }
        }

        [Fact]
        public void Issue4695()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 73867, 74723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 73931, 74651);

                string
                source = @"
using System;

class Program
{
    sealed class Cache
    {
        abstract class BucketwiseBase<TArg> where TArg : class
        {
            internal abstract void Default(TArg arg);
        }

        class BucketwiseBase<TAccumulator, TArg> : BucketwiseBase<TArg> where TArg : class
        {
            internal override void Default(TArg arg = null) { }
        }

        public string GetAll()
        {
            new BucketwiseBase<object, object>().Default(); // Bad image format thrown here on legacy compiler 
            return ""OK"";
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(new Cache().GetAll());
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 74665, 74712);

                f_23114_74665_74711(this, source, expectedOutput: "OK");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 73867, 74723);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_74665_74711(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 74665, 74711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 73867, 74723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 73867, 74723);
            }
        }

        private void CheckInternalMembers(NamedTypeSymbol type, bool isFromSource)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 74735, 75106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 74834, 74894);

                f_23114_74834_74893(f_23114_74849_74874(type, "Public").SingleOrDefault());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 74908, 74967);

                var
                member = f_23114_74921_74948(type, "Internal").SingleOrDefault()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 74981, 75095) || true) && (isFromSource)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 74981, 75095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75016, 75039);

                    f_23114_75016_75038(member);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 74981, 75095);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(23114, 74981, 75095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75075, 75095);

                    f_23114_75075_75094(member);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(23114, 74981, 75095);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 74735, 75106);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_74849_74874(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 74849, 74874);
                    return return_v;
                }


                int
                f_23114_74834_74893(Microsoft.CodeAnalysis.CSharp.Symbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 74834, 74893);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_23114_74921_74948(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 74921, 74948);
                    return return_v;
                }


                int
                f_23114_75016_75038(Microsoft.CodeAnalysis.CSharp.Symbol?
                @object)
                {
                    Assert.NotNull((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75016, 75038);
                    return 0;
                }


                int
                f_23114_75075_75094(Microsoft.CodeAnalysis.CSharp.Symbol?
                @object)
                {
                    Assert.Null((object?)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75075, 75094);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 74735, 75106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 74735, 75106);
            }
        }

        [WorkItem(90, "https://github.com/dotnet/roslyn/issues/90")]
        [Fact]
        public void EmitWithNoResourcesAllPlatforms()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 75118, 75812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75274, 75344);

                var
                comp = f_23114_75285_75343("class Test { static void Main() { } }")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75360, 75409);

                f_23114_75360_75408(this, comp, Platform.AnyCpu);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75423, 75486);

                f_23114_75423_75485(this, comp, Platform.AnyCpu32BitPreferred);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75500, 75546);

                f_23114_75500_75545(this, comp, Platform.Arm);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75585, 75635);

                f_23114_75585_75634(this, comp, Platform.Itanium);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75670, 75716);

                f_23114_75670_75715(this, comp, Platform.X64);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75755, 75801);

                f_23114_75755_75800(this, comp, Platform.X86);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 75118, 75812);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_75285_75343(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75285, 75343);
                    return return_v;
                }


                int
                f_23114_75360_75408(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp, Microsoft.CodeAnalysis.Platform
                platform)
                {
                    this_param.VerifyEmitWithNoResources(comp, platform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75360, 75408);
                    return 0;
                }


                int
                f_23114_75423_75485(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp, Microsoft.CodeAnalysis.Platform
                platform)
                {
                    this_param.VerifyEmitWithNoResources(comp, platform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75423, 75485);
                    return 0;
                }


                int
                f_23114_75500_75545(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp, Microsoft.CodeAnalysis.Platform
                platform)
                {
                    this_param.VerifyEmitWithNoResources(comp, platform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75500, 75545);
                    return 0;
                }


                int
                f_23114_75585_75634(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp, Microsoft.CodeAnalysis.Platform
                platform)
                {
                    this_param.VerifyEmitWithNoResources(comp, platform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75585, 75634);
                    return 0;
                }


                int
                f_23114_75670_75715(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp, Microsoft.CodeAnalysis.Platform
                platform)
                {
                    this_param.VerifyEmitWithNoResources(comp, platform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75670, 75715);
                    return 0;
                }


                int
                f_23114_75755_75800(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp, Microsoft.CodeAnalysis.Platform
                platform)
                {
                    this_param.VerifyEmitWithNoResources(comp, platform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75755, 75800);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 75118, 75812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 75118, 75812);
            }
        }

        private void VerifyEmitWithNoResources(CSharpCompilation comp, Platform platform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 75824, 76134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 75930, 75990);

                var
                options = f_23114_75944_75989(TestOptions.ReleaseExe, platform)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76004, 76123);

                f_23114_76004_76122(this, f_23114_76021_76121(f_23114_76021_76100(comp, "EmitWithNoResourcesAllPlatforms_" + f_23114_76080_76099(platform)), options));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 75824, 76134);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_75944_75989(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.Platform
                platform)
                {
                    var return_v = this_param.WithPlatform(platform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 75944, 75989);
                    return return_v;
                }


                string
                f_23114_76080_76099(Microsoft.CodeAnalysis.Platform
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76080, 76099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_76021_76100(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, string
                assemblyName)
                {
                    var return_v = this_param.WithAssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76021, 76100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_76021_76121(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.WithOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76021, 76121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_76004_76122(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76004, 76122);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 75824, 76134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 75824, 76134);
            }
        }

        [Fact]
        public unsafe void PEHeaders1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 76146, 87609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76218, 76278);

                var
                options = f_23114_76232_76277(EmitOptions.Default, 0x2000)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76292, 76371);

                var
                syntax = f_23114_76305_76370(@"class C {}", TestOptions.Regular)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76387, 76627);

                var
                peStream = f_23114_76402_76626(f_23114_76402_76604(syntax, options: f_23114_76486_76532(TestOptions.ReleaseDll, true), assemblyName: "46B9C2B2-B7A0-45C5-9EF9-28DDF739FD9E"), options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76643, 76665);

                peStream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76679, 76717);

                var
                peReader = f_23114_76694_76716(peStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76733, 76768);

                var
                peHeaders = f_23114_76749_76767(peReader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76782, 76816);

                var
                peHeader = f_23114_76797_76815(peHeaders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76830, 76868);

                var
                coffHeader = f_23114_76847_76867(peHeaders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76882, 76918);

                var
                corHeader = f_23114_76898_76917(peHeaders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76934, 76977);

                f_23114_76934_76976(PEMagic.PE32, f_23114_76961_76975(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 76991, 77046);

                f_23114_76991_77045(0x0000237E, f_23114_77016_77044(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77060, 77106);

                f_23114_77060_77105(0x00002000, f_23114_77085_77104(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77120, 77166);

                f_23114_77120_77165(0x00004000, f_23114_77145_77164(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77180, 77229);

                f_23114_77180_77228(0x00002000, f_23114_77205_77227(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77243, 77289);

                f_23114_77243_77288(0x00002000, f_23114_77268_77287(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77303, 77356);

                f_23114_77303_77355(0x00001000u, f_23114_77329_77354(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77370, 77424);

                f_23114_77370_77423(0x00100000u, f_23114_77396_77422(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77438, 77485);

                f_23114_77438_77484(0x00006000, f_23114_77463_77483(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77499, 77556);

                f_23114_77499_77555(0x00002000, f_23114_77524_77554(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77570, 77624);

                f_23114_77570_77623(0x00001000u, f_23114_77596_77622(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77638, 77693);

                f_23114_77638_77692(0x00100000u, f_23114_77664_77691(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77707, 77757);

                f_23114_77707_77756(0, f_23114_77723_77755(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77771, 77826);

                f_23114_77771_77825(Subsystem.WindowsCui, f_23114_77806_77824(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 77840, 78016);

                f_23114_77840_78015(DllCharacteristics.DynamicBase | DllCharacteristics.NxCompatible | DllCharacteristics.NoSeh | DllCharacteristics.TerminalServerAware, f_23114_77987_78014(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78030, 78066);

                f_23114_78030_78065(0u, f_23114_78047_78064(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78080, 78125);

                f_23114_78080_78124(0x2000, f_23114_78101_78123(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78139, 78185);

                f_23114_78139_78184(0x10000000u, f_23114_78165_78183(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78199, 78247);

                f_23114_78199_78246(0x2000, f_23114_78220_78245(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78261, 78305);

                f_23114_78261_78304(0, f_23114_78277_78303(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78319, 78363);

                f_23114_78319_78362(0, f_23114_78335_78361(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78377, 78425);

                f_23114_78377_78424(0x30, f_23114_78396_78423(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78439, 78484);

                f_23114_78439_78483(0, f_23114_78455_78482(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78498, 78552);

                f_23114_78498_78551(4, f_23114_78514_78550(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78566, 78620);

                f_23114_78566_78619(0, f_23114_78582_78618(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78634, 78682);

                f_23114_78634_78681(4, f_23114_78650_78680(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78696, 78744);

                f_23114_78696_78743(0, f_23114_78712_78742(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78758, 78805);

                f_23114_78758_78804(16, f_23114_78775_78803(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78819, 78864);

                f_23114_78819_78863(0x2000, f_23114_78840_78862(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78880, 78963);

                f_23114_78880_78962(0x4000, peHeader.BaseRelocationTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 78977, 79039);

                f_23114_78977_79038(0xc, peHeader.BaseRelocationTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79053, 79128);

                f_23114_79053_79127(0, peHeader.BoundImportTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79142, 79199);

                f_23114_79142_79198(0, peHeader.BoundImportTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79213, 79288);

                f_23114_79213_79287(0, peHeader.CertificateTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79302, 79359);

                f_23114_79302_79358(0, peHeader.CertificateTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79373, 79446);

                f_23114_79373_79445(0, peHeader.CopyrightTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79460, 79515);

                f_23114_79460_79514(0, peHeader.CopyrightTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79529, 79607);

                f_23114_79529_79606(0x2008, peHeader.CorHeaderTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79621, 79679);

                f_23114_79621_79678(0x48, peHeader.CorHeaderTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79693, 79767);

                f_23114_79693_79766(0x2310, peHeader.DebugTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79781, 79835);

                f_23114_79781_79834(0x1C, peHeader.DebugTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79849, 79922);

                f_23114_79849_79921(0, peHeader.ExceptionTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 79936, 79991);

                f_23114_79936_79990(0, peHeader.ExceptionTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80005, 80075);

                f_23114_80005_80074(0, peHeader.ExportTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80089, 80141);

                f_23114_80089_80140(0, peHeader.ExportTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80155, 80237);

                f_23114_80155_80236(0x2000, peHeader.ImportAddressTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80251, 80312);

                f_23114_80251_80311(0x8, peHeader.ImportAddressTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80326, 80401);

                f_23114_80326_80400(0x232C, peHeader.ImportTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80415, 80470);

                f_23114_80415_80469(0x4f, peHeader.ImportTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80484, 80558);

                f_23114_80484_80557(0, peHeader.LoadConfigTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80572, 80628);

                f_23114_80572_80627(0, peHeader.LoadConfigTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80642, 80714);

                f_23114_80642_80713(0, peHeader.ResourceTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80728, 80782);

                f_23114_80728_80781(0, peHeader.ResourceTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80796, 80878);

                f_23114_80796_80877(0, peHeader.ThreadLocalStorageTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80892, 80956);

                f_23114_80892_80955(0, peHeader.ThreadLocalStorageTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 80972, 81010);

                int
                importAddressTableDirectoryOffset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81024, 81146);

                f_23114_81024_81145(f_23114_81036_81144(peHeaders, f_23114_81068_81104(peHeader), out importAddressTableDirectoryOffset));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81160, 81216);

                f_23114_81160_81215(0x2000, importAddressTableDirectoryOffset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81232, 81323);

                var
                importAddressTableDirectoryBytes = new byte[peHeader.ImportAddressTableDirectory.Size]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81337, 81391);

                peStream.Position = importAddressTableDirectoryOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81405, 81497);

                f_23114_81405_81496(peStream, importAddressTableDirectoryBytes, 0, f_23114_81456_81495(importAddressTableDirectoryBytes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81511, 81683);

                f_23114_81511_81682(new byte[]
                            {
                0x60, 0x23, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00
                            }, importAddressTableDirectoryBytes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81699, 81730);

                int
                importTableDirectoryOffset
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81744, 81852);

                f_23114_81744_81851(f_23114_81756_81850(peHeaders, f_23114_81788_81817(peHeader), out importTableDirectoryOffset));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81866, 81915);

                f_23114_81866_81914(0x232C, importTableDirectoryOffset);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 81931, 82008);

                var
                importTableDirectoryBytes = new byte[peHeader.ImportTableDirectory.Size]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 82022, 82069);

                peStream.Position = importTableDirectoryOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 82083, 82161);

                f_23114_82083_82160(peStream, importTableDirectoryBytes, 0, f_23114_82127_82159(importTableDirectoryBytes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 82175, 83227);

                f_23114_82175_83226(new byte[]
                            {
                0x54, 0x23, 0x00, 0x00, // RVA
                0x00, 0x00, 0x00, 0x00, // 0
                0x00, 0x00, 0x00, 0x00, // 0
                0x6E, 0x23, 0x00, 0x00, // name RVA
                0x00, 0x20, 0x00, 0x00, // ImportAddressTableDirectory RVA
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x60, 0x23, 0x00, 0x00, // hint RVA
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00,             // hint
                (byte)'_', (byte)'C', (byte)'o', (byte)'r', (byte)'D', (byte)'l', (byte)'l', (byte)'M', (byte)'a', (byte)'i', (byte)'n', 0x00,
                (byte)'m', (byte)'s', (byte)'c', (byte)'o', (byte)'r', (byte)'e', (byte)'e', (byte)'.', (byte)'d', (byte)'l', (byte)'l', 0x00,
                0x00
                            }, importTableDirectoryBytes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 83243, 83338);

                var
                entryPointSectionIndex = f_23114_83272_83337(peHeaders, f_23114_83308_83336(peHeader))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 83352, 83392);

                f_23114_83352_83391(0, entryPointSectionIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 83408, 83549);

                peStream.Position = f_23114_83428_83452(peHeaders)[0].PointerToRawData + f_23114_83475_83503(peHeader) - f_23114_83506_83530(peHeaders)[0].VirtualAddress;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 83563, 83596);

                byte[]
                startupStub = new byte[8]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 83610, 83660);

                f_23114_83610_83659(peStream, startupStub, 0, f_23114_83640_83658(startupStub));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 83674, 83765);

                f_23114_83674_83764(new byte[] { 0xFF, 0x25, 0x00, 0x20, 0x00, 0x10, 0x00, 0x00 }, startupStub);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 83781, 83913);

                f_23114_83781_83912(Characteristics.Dll | Characteristics.LargeAddressAware | Characteristics.ExecutableImage, f_23114_83885_83911(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 83927, 83974);

                f_23114_83927_83973(Machine.I386, f_23114_83954_83972(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 83988, 84033);

                f_23114_83988_84032(2, f_23114_84004_84031(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84047, 84091);

                f_23114_84047_84090(0, f_23114_84063_84089(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84105, 84154);

                f_23114_84105_84153(0, f_23114_84121_84152(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84168, 84220);

                f_23114_84168_84219(0xe0, f_23114_84187_84218(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84234, 84285);

                f_23114_84234_84284(-609278808, f_23114_84259_84283(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84301, 84368);

                f_23114_84301_84367(0, f_23114_84317_84366(corHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84382, 84429);

                f_23114_84382_84428(CorFlags.ILOnly, f_23114_84412_84427(corHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84443, 84490);

                f_23114_84443_84489(2, f_23114_84459_84488(corHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84504, 84551);

                f_23114_84504_84550(5, f_23114_84520_84549(corHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84567, 84643);

                f_23114_84567_84642(0, corHeader.CodeManagerTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84657, 84715);

                f_23114_84657_84714(0, corHeader.CodeManagerTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84729, 84812);

                f_23114_84729_84811(0, corHeader.ExportAddressTableJumpsDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84826, 84891);

                f_23114_84826_84890(0, corHeader.ExportAddressTableJumpsDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84905, 84984);

                f_23114_84905_84983(0, corHeader.ManagedNativeHeaderDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 84998, 85059);

                f_23114_84998_85058(0, corHeader.ManagedNativeHeaderDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85073, 85146);

                f_23114_85073_85145(0x2058, corHeader.MetadataDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85160, 85215);

                f_23114_85160_85214(0x02b8, corHeader.MetadataDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85229, 85298);

                f_23114_85229_85297(0, corHeader.ResourcesDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85312, 85363);

                f_23114_85312_85362(0, corHeader.ResourcesDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85377, 85456);

                f_23114_85377_85455(0, corHeader.StrongNameSignatureDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85470, 85531);

                f_23114_85470_85530(0, corHeader.StrongNameSignatureDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85545, 85617);

                f_23114_85545_85616(0, corHeader.VtableFixupsDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85631, 85685);

                f_23114_85631_85684(0, corHeader.VtableFixupsDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85701, 85741);

                var
                sections = f_23114_85716_85740(peHeaders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85755, 85788);

                f_23114_85755_85787(2, sections.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85804, 85844);

                f_23114_85804_85843(".text", sections[0].Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85858, 85907);

                f_23114_85858_85906(0, sections[0].NumberOfLineNumbers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85921, 85970);

                f_23114_85921_85969(0, sections[0].NumberOfRelocations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 85984, 86034);

                f_23114_85984_86033(0, sections[0].PointerToLineNumbers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86048, 86099);

                f_23114_86048_86098(0x2000, sections[0].PointerToRawData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86113, 86163);

                f_23114_86113_86162(0, sections[0].PointerToRelocations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86177, 86332);

                f_23114_86177_86331(SectionCharacteristics.ContainsCode | SectionCharacteristics.MemExecute | SectionCharacteristics.MemRead, sections[0].SectionCharacteristics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86346, 86394);

                f_23114_86346_86393(0x2000, sections[0].SizeOfRawData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86408, 86457);

                f_23114_86408_86456(0x2000, sections[0].VirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86471, 86514);

                f_23114_86471_86513(900, sections[0].VirtualSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86530, 86571);

                f_23114_86530_86570(".reloc", sections[1].Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86585, 86634);

                f_23114_86585_86633(0, sections[1].NumberOfLineNumbers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86648, 86697);

                f_23114_86648_86696(0, sections[1].NumberOfRelocations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86711, 86761);

                f_23114_86711_86760(0, sections[1].PointerToLineNumbers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86775, 86826);

                f_23114_86775_86825(0x4000, sections[1].PointerToRawData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86840, 86890);

                f_23114_86840_86889(0, sections[1].PointerToRelocations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 86904, 87074);

                f_23114_86904_87073(SectionCharacteristics.ContainsInitializedData | SectionCharacteristics.MemDiscardable | SectionCharacteristics.MemRead, sections[1].SectionCharacteristics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 87088, 87136);

                f_23114_87088_87135(0x2000, sections[1].SizeOfRawData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 87150, 87199);

                f_23114_87150_87198(0x4000, sections[1].VirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 87213, 87255);

                f_23114_87213_87254(12, sections[1].VirtualSize);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 87271, 87340);

                var
                relocBlock = f_23114_87288_87339(peReader, sections[1].VirtualAddress)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 87354, 87405);

                var
                relocBytes = new byte[sections[1].VirtualSize]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 87419, 87494);

                f_23114_87419_87493(relocBlock.Pointer, relocBytes, 0, f_23114_87475_87492(relocBytes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 87508, 87598);

                f_23114_87508_87597(new byte[] { 0, 0x20, 0, 0, 0x0c, 0, 0, 0, 0x80, 0x33, 0, 0 }, relocBytes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 76146, 87609);

                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23114_76232_76277(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, int
                value)
                {
                    var return_v = this_param.WithFileAlignment(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76232, 76277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23114_76305_76370(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, (Microsoft.CodeAnalysis.ParseOptions)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76305, 76370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_76486_76532(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                deterministic)
                {
                    var return_v = this_param.WithDeterministic(deterministic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76486, 76532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_76402_76604(Microsoft.CodeAnalysis.SyntaxTree
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76402, 76604);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23114_76402_76626(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitOptions
                options)
                {
                    var return_v = compilation.EmitToStream(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76402, 76626);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_23114_76694_76716(System.IO.MemoryStream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader((System.IO.Stream)peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76694, 76716);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeaders
                f_23114_76749_76767(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.PEHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 76749, 76767);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeader?
                f_23114_76797_76815(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 76797, 76815);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_23114_76847_76867(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 76847, 76867);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CorHeader?
                f_23114_76898_76917(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CorHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 76898, 76917);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEMagic
                f_23114_76961_76975(System.Reflection.PortableExecutable.PEHeader?
                this_param)
                {
                    var return_v = this_param.Magic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 76961, 76975);
                    return return_v;
                }


                int
                f_23114_76934_76976(System.Reflection.PortableExecutable.PEMagic
                expected, System.Reflection.PortableExecutable.PEMagic
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76934, 76976);
                    return 0;
                }


                int
                f_23114_77016_77044(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.AddressOfEntryPoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77016, 77044);
                    return return_v;
                }


                int
                f_23114_76991_77045(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 76991, 77045);
                    return 0;
                }


                int
                f_23114_77085_77104(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.BaseOfCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77085, 77104);
                    return return_v;
                }


                int
                f_23114_77060_77105(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77060, 77105);
                    return 0;
                }


                int
                f_23114_77145_77164(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.BaseOfData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77145, 77164);
                    return return_v;
                }


                int
                f_23114_77120_77165(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77120, 77165);
                    return 0;
                }


                int
                f_23114_77205_77227(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77205, 77227);
                    return return_v;
                }


                int
                f_23114_77180_77228(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77180, 77228);
                    return 0;
                }


                int
                f_23114_77268_77287(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77268, 77287);
                    return return_v;
                }


                int
                f_23114_77243_77288(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77243, 77288);
                    return 0;
                }


                ulong
                f_23114_77329_77354(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfHeapCommit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77329, 77354);
                    return return_v;
                }


                int
                f_23114_77303_77355(uint
                expected, ulong
                actual)
                {
                    Assert.Equal((ulong)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77303, 77355);
                    return 0;
                }


                ulong
                f_23114_77396_77422(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfHeapReserve;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77396, 77422);
                    return return_v;
                }


                int
                f_23114_77370_77423(uint
                expected, ulong
                actual)
                {
                    Assert.Equal((ulong)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77370, 77423);
                    return 0;
                }


                int
                f_23114_77463_77483(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfImage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77463, 77483);
                    return return_v;
                }


                int
                f_23114_77438_77484(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77438, 77484);
                    return 0;
                }


                int
                f_23114_77524_77554(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfInitializedData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77524, 77554);
                    return return_v;
                }


                int
                f_23114_77499_77555(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77499, 77555);
                    return 0;
                }


                ulong
                f_23114_77596_77622(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfStackCommit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77596, 77622);
                    return return_v;
                }


                int
                f_23114_77570_77623(uint
                expected, ulong
                actual)
                {
                    Assert.Equal((ulong)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77570, 77623);
                    return 0;
                }


                ulong
                f_23114_77664_77691(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfStackReserve;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77664, 77691);
                    return return_v;
                }


                int
                f_23114_77638_77692(uint
                expected, ulong
                actual)
                {
                    Assert.Equal((ulong)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77638, 77692);
                    return 0;
                }


                int
                f_23114_77723_77755(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfUninitializedData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77723, 77755);
                    return return_v;
                }


                int
                f_23114_77707_77756(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77707, 77756);
                    return 0;
                }


                System.Reflection.PortableExecutable.Subsystem
                f_23114_77806_77824(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.Subsystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77806, 77824);
                    return return_v;
                }


                int
                f_23114_77771_77825(System.Reflection.PortableExecutable.Subsystem
                expected, System.Reflection.PortableExecutable.Subsystem
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77771, 77825);
                    return 0;
                }


                System.Reflection.PortableExecutable.DllCharacteristics
                f_23114_77987_78014(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.DllCharacteristics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 77987, 78014);
                    return return_v;
                }


                int
                f_23114_77840_78015(System.Reflection.PortableExecutable.DllCharacteristics
                expected, System.Reflection.PortableExecutable.DllCharacteristics
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 77840, 78015);
                    return 0;
                }


                uint
                f_23114_78047_78064(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.CheckSum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78047, 78064);
                    return return_v;
                }


                int
                f_23114_78030_78065(uint
                expected, uint
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78030, 78065);
                    return 0;
                }


                int
                f_23114_78101_78123(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78101, 78123);
                    return return_v;
                }


                int
                f_23114_78080_78124(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78080, 78124);
                    return 0;
                }


                ulong
                f_23114_78165_78183(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.ImageBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78165, 78183);
                    return return_v;
                }


                int
                f_23114_78139_78184(uint
                expected, ulong
                actual)
                {
                    Assert.Equal((ulong)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78139, 78184);
                    return 0;
                }


                int
                f_23114_78220_78245(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SectionAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78220, 78245);
                    return return_v;
                }


                int
                f_23114_78199_78246(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78199, 78246);
                    return 0;
                }


                ushort
                f_23114_78277_78303(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MajorImageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78277, 78303);
                    return return_v;
                }


                int
                f_23114_78261_78304(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78261, 78304);
                    return 0;
                }


                ushort
                f_23114_78335_78361(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MinorImageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78335, 78361);
                    return return_v;
                }


                int
                f_23114_78319_78362(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78319, 78362);
                    return 0;
                }


                byte
                f_23114_78396_78423(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MajorLinkerVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78396, 78423);
                    return return_v;
                }


                int
                f_23114_78377_78424(int
                expected, byte
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78377, 78424);
                    return 0;
                }


                byte
                f_23114_78455_78482(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MinorLinkerVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78455, 78482);
                    return return_v;
                }


                int
                f_23114_78439_78483(int
                expected, byte
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78439, 78483);
                    return 0;
                }


                ushort
                f_23114_78514_78550(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MajorOperatingSystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78514, 78550);
                    return return_v;
                }


                int
                f_23114_78498_78551(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78498, 78551);
                    return 0;
                }


                ushort
                f_23114_78582_78618(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MinorOperatingSystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78582, 78618);
                    return return_v;
                }


                int
                f_23114_78566_78619(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78566, 78619);
                    return 0;
                }


                ushort
                f_23114_78650_78680(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MajorSubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78650, 78680);
                    return return_v;
                }


                int
                f_23114_78634_78681(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78634, 78681);
                    return 0;
                }


                ushort
                f_23114_78712_78742(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MinorSubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78712, 78742);
                    return return_v;
                }


                int
                f_23114_78696_78743(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78696, 78743);
                    return 0;
                }


                int
                f_23114_78775_78803(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.NumberOfRvaAndSizes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78775, 78803);
                    return return_v;
                }


                int
                f_23114_78758_78804(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78758, 78804);
                    return 0;
                }


                int
                f_23114_78840_78862(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 78840, 78862);
                    return return_v;
                }


                int
                f_23114_78819_78863(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78819, 78863);
                    return 0;
                }


                int
                f_23114_78880_78962(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78880, 78962);
                    return 0;
                }


                int
                f_23114_78977_79038(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 78977, 79038);
                    return 0;
                }


                int
                f_23114_79053_79127(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79053, 79127);
                    return 0;
                }


                int
                f_23114_79142_79198(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79142, 79198);
                    return 0;
                }


                int
                f_23114_79213_79287(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79213, 79287);
                    return 0;
                }


                int
                f_23114_79302_79358(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79302, 79358);
                    return 0;
                }


                int
                f_23114_79373_79445(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79373, 79445);
                    return 0;
                }


                int
                f_23114_79460_79514(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79460, 79514);
                    return 0;
                }


                int
                f_23114_79529_79606(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79529, 79606);
                    return 0;
                }


                int
                f_23114_79621_79678(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79621, 79678);
                    return 0;
                }


                int
                f_23114_79693_79766(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79693, 79766);
                    return 0;
                }


                int
                f_23114_79781_79834(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79781, 79834);
                    return 0;
                }


                int
                f_23114_79849_79921(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79849, 79921);
                    return 0;
                }


                int
                f_23114_79936_79990(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 79936, 79990);
                    return 0;
                }


                int
                f_23114_80005_80074(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80005, 80074);
                    return 0;
                }


                int
                f_23114_80089_80140(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80089, 80140);
                    return 0;
                }


                int
                f_23114_80155_80236(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80155, 80236);
                    return 0;
                }


                int
                f_23114_80251_80311(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80251, 80311);
                    return 0;
                }


                int
                f_23114_80326_80400(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80326, 80400);
                    return 0;
                }


                int
                f_23114_80415_80469(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80415, 80469);
                    return 0;
                }


                int
                f_23114_80484_80557(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80484, 80557);
                    return 0;
                }


                int
                f_23114_80572_80627(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80572, 80627);
                    return 0;
                }


                int
                f_23114_80642_80713(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80642, 80713);
                    return 0;
                }


                int
                f_23114_80728_80781(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80728, 80781);
                    return 0;
                }


                int
                f_23114_80796_80877(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80796, 80877);
                    return 0;
                }


                int
                f_23114_80892_80955(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 80892, 80955);
                    return 0;
                }


                System.Reflection.PortableExecutable.DirectoryEntry
                f_23114_81068_81104(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.ImportAddressTableDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 81068, 81104);
                    return return_v;
                }


                bool
                f_23114_81036_81144(System.Reflection.PortableExecutable.PEHeaders
                this_param, System.Reflection.PortableExecutable.DirectoryEntry
                directory, out int
                offset)
                {
                    var return_v = this_param.TryGetDirectoryOffset(directory, out offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 81036, 81144);
                    return return_v;
                }


                int
                f_23114_81024_81145(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 81024, 81145);
                    return 0;
                }


                int
                f_23114_81160_81215(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 81160, 81215);
                    return 0;
                }


                int
                f_23114_81456_81495(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 81456, 81495);
                    return return_v;
                }


                int
                f_23114_81405_81496(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 81405, 81496);
                    return return_v;
                }


                bool
                f_23114_81511_81682(byte[]
                expected, byte[]
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<byte>)expected, (System.Collections.Generic.IEnumerable<byte>)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 81511, 81682);
                    return return_v;
                }


                System.Reflection.PortableExecutable.DirectoryEntry
                f_23114_81788_81817(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.ImportTableDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 81788, 81817);
                    return return_v;
                }


                bool
                f_23114_81756_81850(System.Reflection.PortableExecutable.PEHeaders
                this_param, System.Reflection.PortableExecutable.DirectoryEntry
                directory, out int
                offset)
                {
                    var return_v = this_param.TryGetDirectoryOffset(directory, out offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 81756, 81850);
                    return return_v;
                }


                int
                f_23114_81744_81851(bool
                condition)
                {
                    Assert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 81744, 81851);
                    return 0;
                }


                int
                f_23114_81866_81914(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 81866, 81914);
                    return 0;
                }


                int
                f_23114_82127_82159(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 82127, 82159);
                    return return_v;
                }


                int
                f_23114_82083_82160(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 82083, 82160);
                    return return_v;
                }


                bool
                f_23114_82175_83226(byte[]
                expected, byte[]
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<byte>)expected, (System.Collections.Generic.IEnumerable<byte>)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 82175, 83226);
                    return return_v;
                }


                int
                f_23114_83308_83336(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.AddressOfEntryPoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 83308, 83336);
                    return return_v;
                }


                int
                f_23114_83272_83337(System.Reflection.PortableExecutable.PEHeaders
                this_param, int
                relativeVirtualAddress)
                {
                    var return_v = this_param.GetContainingSectionIndex(relativeVirtualAddress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 83272, 83337);
                    return return_v;
                }


                int
                f_23114_83352_83391(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 83352, 83391);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                f_23114_83428_83452(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.SectionHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 83428, 83452);
                    return return_v;
                }


                int
                f_23114_83475_83503(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.AddressOfEntryPoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 83475, 83503);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                f_23114_83506_83530(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.SectionHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 83506, 83530);
                    return return_v;
                }


                int
                f_23114_83640_83658(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 83640, 83658);
                    return return_v;
                }


                int
                f_23114_83610_83659(System.IO.MemoryStream
                this_param, byte[]
                buffer, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(buffer, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 83610, 83659);
                    return return_v;
                }


                bool
                f_23114_83674_83764(byte[]
                expected, byte[]
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<byte>)expected, (System.Collections.Generic.IEnumerable<byte>)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 83674, 83764);
                    return return_v;
                }


                System.Reflection.PortableExecutable.Characteristics
                f_23114_83885_83911(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.Characteristics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 83885, 83911);
                    return return_v;
                }


                int
                f_23114_83781_83912(System.Reflection.PortableExecutable.Characteristics
                expected, System.Reflection.PortableExecutable.Characteristics
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 83781, 83912);
                    return 0;
                }


                System.Reflection.PortableExecutable.Machine
                f_23114_83954_83972(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.Machine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 83954, 83972);
                    return return_v;
                }


                int
                f_23114_83927_83973(System.Reflection.PortableExecutable.Machine
                expected, System.Reflection.PortableExecutable.Machine
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 83927, 83973);
                    return 0;
                }


                short
                f_23114_84004_84031(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.NumberOfSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 84004, 84031);
                    return return_v;
                }


                int
                f_23114_83988_84032(int
                expected, short
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 83988, 84032);
                    return 0;
                }


                int
                f_23114_84063_84089(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.NumberOfSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 84063, 84089);
                    return return_v;
                }


                int
                f_23114_84047_84090(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84047, 84090);
                    return 0;
                }


                int
                f_23114_84121_84152(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.PointerToSymbolTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 84121, 84152);
                    return return_v;
                }


                int
                f_23114_84105_84153(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84105, 84153);
                    return 0;
                }


                short
                f_23114_84187_84218(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.SizeOfOptionalHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 84187, 84218);
                    return return_v;
                }


                int
                f_23114_84168_84219(int
                expected, short
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84168, 84219);
                    return 0;
                }


                int
                f_23114_84259_84283(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.TimeDateStamp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 84259, 84283);
                    return return_v;
                }


                int
                f_23114_84234_84284(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84234, 84284);
                    return 0;
                }


                int
                f_23114_84317_84366(System.Reflection.PortableExecutable.CorHeader?
                this_param)
                {
                    var return_v = this_param.EntryPointTokenOrRelativeVirtualAddress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 84317, 84366);
                    return return_v;
                }


                int
                f_23114_84301_84367(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84301, 84367);
                    return 0;
                }


                System.Reflection.PortableExecutable.CorFlags
                f_23114_84412_84427(System.Reflection.PortableExecutable.CorHeader
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 84412, 84427);
                    return return_v;
                }


                int
                f_23114_84382_84428(System.Reflection.PortableExecutable.CorFlags
                expected, System.Reflection.PortableExecutable.CorFlags
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84382, 84428);
                    return 0;
                }


                ushort
                f_23114_84459_84488(System.Reflection.PortableExecutable.CorHeader
                this_param)
                {
                    var return_v = this_param.MajorRuntimeVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 84459, 84488);
                    return return_v;
                }


                int
                f_23114_84443_84489(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84443, 84489);
                    return 0;
                }


                ushort
                f_23114_84520_84549(System.Reflection.PortableExecutable.CorHeader
                this_param)
                {
                    var return_v = this_param.MinorRuntimeVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 84520, 84549);
                    return return_v;
                }


                int
                f_23114_84504_84550(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84504, 84550);
                    return 0;
                }


                int
                f_23114_84567_84642(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84567, 84642);
                    return 0;
                }


                int
                f_23114_84657_84714(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84657, 84714);
                    return 0;
                }


                int
                f_23114_84729_84811(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84729, 84811);
                    return 0;
                }


                int
                f_23114_84826_84890(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84826, 84890);
                    return 0;
                }


                int
                f_23114_84905_84983(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84905, 84983);
                    return 0;
                }


                int
                f_23114_84998_85058(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 84998, 85058);
                    return 0;
                }


                int
                f_23114_85073_85145(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85073, 85145);
                    return 0;
                }


                int
                f_23114_85160_85214(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85160, 85214);
                    return 0;
                }


                int
                f_23114_85229_85297(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85229, 85297);
                    return 0;
                }


                int
                f_23114_85312_85362(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85312, 85362);
                    return 0;
                }


                int
                f_23114_85377_85455(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85377, 85455);
                    return 0;
                }


                int
                f_23114_85470_85530(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85470, 85530);
                    return 0;
                }


                int
                f_23114_85545_85616(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85545, 85616);
                    return 0;
                }


                int
                f_23114_85631_85684(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85631, 85684);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                f_23114_85716_85740(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.SectionHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 85716, 85740);
                    return return_v;
                }


                int
                f_23114_85755_85787(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85755, 85787);
                    return 0;
                }


                int
                f_23114_85804_85843(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85804, 85843);
                    return 0;
                }


                int
                f_23114_85858_85906(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85858, 85906);
                    return 0;
                }


                int
                f_23114_85921_85969(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85921, 85969);
                    return 0;
                }


                int
                f_23114_85984_86033(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 85984, 86033);
                    return 0;
                }


                int
                f_23114_86048_86098(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86048, 86098);
                    return 0;
                }


                int
                f_23114_86113_86162(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86113, 86162);
                    return 0;
                }


                int
                f_23114_86177_86331(System.Reflection.PortableExecutable.SectionCharacteristics
                expected, System.Reflection.PortableExecutable.SectionCharacteristics
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86177, 86331);
                    return 0;
                }


                int
                f_23114_86346_86393(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86346, 86393);
                    return 0;
                }


                int
                f_23114_86408_86456(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86408, 86456);
                    return 0;
                }


                int
                f_23114_86471_86513(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86471, 86513);
                    return 0;
                }


                int
                f_23114_86530_86570(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86530, 86570);
                    return 0;
                }


                int
                f_23114_86585_86633(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86585, 86633);
                    return 0;
                }


                int
                f_23114_86648_86696(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86648, 86696);
                    return 0;
                }


                int
                f_23114_86711_86760(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86711, 86760);
                    return 0;
                }


                int
                f_23114_86775_86825(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86775, 86825);
                    return 0;
                }


                int
                f_23114_86840_86889(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86840, 86889);
                    return 0;
                }


                int
                f_23114_86904_87073(System.Reflection.PortableExecutable.SectionCharacteristics
                expected, System.Reflection.PortableExecutable.SectionCharacteristics
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 86904, 87073);
                    return 0;
                }


                int
                f_23114_87088_87135(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87088, 87135);
                    return 0;
                }


                int
                f_23114_87150_87198(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87150, 87198);
                    return 0;
                }


                int
                f_23114_87213_87254(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87213, 87254);
                    return 0;
                }


                System.Reflection.PortableExecutable.PEMemoryBlock
                f_23114_87288_87339(System.Reflection.PortableExecutable.PEReader
                this_param, int
                relativeVirtualAddress)
                {
                    var return_v = this_param.GetSectionData(relativeVirtualAddress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87288, 87339);
                    return return_v;
                }


                int
                f_23114_87475_87492(byte[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 87475, 87492);
                    return return_v;
                }


                unsafe int
                f_23114_87419_87493(byte*
                source, byte[]
                destination, int
                startIndex, int
                length)
                {
                    Marshal.Copy((System.IntPtr)source, destination, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87419, 87493);
                    return 0;
                }


                bool
                f_23114_87508_87597(byte[]
                expected, byte[]
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<byte>)expected, (System.Collections.Generic.IEnumerable<byte>)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87508, 87597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 76146, 87609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 76146, 87609);
            }
        }

        [Fact]
        public void PEHeaders2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 87621, 95165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 87686, 87940);

                var
                options = f_23114_87700_87939(f_23114_87700_87872(f_23114_87700_87813(f_23114_87700_87760(EmitOptions.Default, 512), 0x123456789ABCDEF), true), SubsystemVersion.WindowsXP)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 87956, 88059);

                var
                syntax = f_23114_87969_88058(@"class C { static void Main() { } }", TestOptions.Regular)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88075, 88340);

                var
                peStream = f_23114_88090_88339(f_23114_88090_88317(syntax, options: f_23114_88174_88245(f_23114_88174_88221(TestOptions.DebugExe, Platform.X64), true), assemblyName: "B37A4FCD-ED76-4924-A2AD-298836056E00"), options)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88356, 88378);

                peStream.Position = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88392, 88432);

                var
                peHeaders = f_23114_88408_88431(peStream)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88448, 88482);

                var
                peHeader = f_23114_88463_88481(peHeaders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88496, 88534);

                var
                coffHeader = f_23114_88513_88533(peHeaders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88548, 88584);

                var
                corHeader = f_23114_88564_88583(peHeaders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88600, 88647);

                f_23114_88600_88646(PEMagic.PE32Plus, f_23114_88631_88645(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88661, 88716);

                f_23114_88661_88715(0x00000000, f_23114_88686_88714(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88730, 88776);

                f_23114_88730_88775(0x00002000, f_23114_88755_88774(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88790, 88836);

                f_23114_88790_88835(0x00000000, f_23114_88815_88834(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88850, 88899);

                f_23114_88850_88898(0x00000200, f_23114_88875_88897(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88913, 88959);

                f_23114_88913_88958(0x00000400, f_23114_88938_88957(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 88973, 89026);

                f_23114_88973_89025(0x00002000u, f_23114_88999_89024(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89040, 89094);

                f_23114_89040_89093(0x00100000u, f_23114_89066_89092(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89108, 89155);

                f_23114_89108_89154(0x00004000, f_23114_89133_89153(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89169, 89226);

                f_23114_89169_89225(0x00000000, f_23114_89194_89224(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89240, 89294);

                f_23114_89240_89293(0x00004000u, f_23114_89266_89292(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89308, 89362);

                f_23114_89308_89361(0x0400000u, f_23114_89333_89360(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89376, 89426);

                f_23114_89376_89425(0, f_23114_89392_89424(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89440, 89495);

                f_23114_89440_89494(Subsystem.WindowsCui, f_23114_89475_89493(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89509, 89545);

                f_23114_89509_89544(0u, f_23114_89526_89543(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89559, 89603);

                f_23114_89559_89602(0x200, f_23114_89579_89601(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89617, 89671);

                f_23114_89617_89670(0x0123456789ac0000u, f_23114_89651_89669(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89685, 89733);

                f_23114_89685_89732(0x2000, f_23114_89706_89731(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89747, 89791);

                f_23114_89747_89790(0, f_23114_89763_89789(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89805, 89849);

                f_23114_89805_89848(0, f_23114_89821_89847(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89863, 89911);

                f_23114_89863_89910(0x30, f_23114_89882_89909(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89925, 89970);

                f_23114_89925_89969(0, f_23114_89941_89968(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 89984, 90038);

                f_23114_89984_90037(4, f_23114_90000_90036(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90052, 90106);

                f_23114_90052_90105(0, f_23114_90068_90104(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90120, 90168);

                f_23114_90120_90167(5, f_23114_90136_90166(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90182, 90230);

                f_23114_90182_90229(1, f_23114_90198_90228(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90244, 90291);

                f_23114_90244_90290(16, f_23114_90261_90289(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90305, 90349);

                f_23114_90305_90348(0x200, f_23114_90325_90347(peHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90365, 90443);

                f_23114_90365_90442(0, peHeader.BaseRelocationTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90457, 90517);

                f_23114_90457_90516(0, peHeader.BaseRelocationTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90531, 90606);

                f_23114_90531_90605(0, peHeader.BoundImportTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90620, 90677);

                f_23114_90620_90676(0, peHeader.BoundImportTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90691, 90766);

                f_23114_90691_90765(0, peHeader.CertificateTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90780, 90837);

                f_23114_90780_90836(0, peHeader.CertificateTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90851, 90924);

                f_23114_90851_90923(0, peHeader.CopyrightTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 90938, 90993);

                f_23114_90938_90992(0, peHeader.CopyrightTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91007, 91085);

                f_23114_91007_91084(0x2000, peHeader.CorHeaderTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91099, 91157);

                f_23114_91099_91156(0x48, peHeader.CorHeaderTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91171, 91245);

                f_23114_91171_91244(0x2324, peHeader.DebugTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91259, 91313);

                f_23114_91259_91312(0x1C, peHeader.DebugTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91327, 91400);

                f_23114_91327_91399(0, peHeader.ExceptionTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91414, 91469);

                f_23114_91414_91468(0, peHeader.ExceptionTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91483, 91553);

                f_23114_91483_91552(0, peHeader.ExportTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91567, 91619);

                f_23114_91567_91618(0, peHeader.ExportTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91633, 91710);

                f_23114_91633_91709(0, peHeader.ImportAddressTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91724, 91783);

                f_23114_91724_91782(0, peHeader.ImportAddressTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91797, 91867);

                f_23114_91797_91866(0, peHeader.ImportTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91881, 91933);

                f_23114_91881_91932(0, peHeader.ImportTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 91947, 92021);

                f_23114_91947_92020(0, peHeader.LoadConfigTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92035, 92091);

                f_23114_92035_92090(0, peHeader.LoadConfigTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92105, 92177);

                f_23114_92105_92176(0, peHeader.ResourceTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92191, 92245);

                f_23114_92191_92244(0, peHeader.ResourceTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92259, 92341);

                f_23114_92259_92340(0, peHeader.ThreadLocalStorageTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92355, 92419);

                f_23114_92355_92418(0, peHeader.ThreadLocalStorageTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92435, 92545);

                f_23114_92435_92544(Characteristics.LargeAddressAware | Characteristics.ExecutableImage, f_23114_92517_92543(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92559, 92607);

                f_23114_92559_92606(Machine.Amd64, f_23114_92587_92605(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92621, 92666);

                f_23114_92621_92665(1, f_23114_92637_92664(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92680, 92724);

                f_23114_92680_92723(0, f_23114_92696_92722(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92738, 92787);

                f_23114_92738_92786(0, f_23114_92754_92785(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92801, 92852);

                f_23114_92801_92851(240, f_23114_92819_92850(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92866, 92918);

                f_23114_92866_92917(-1823671907, f_23114_92892_92916(coffHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 92934, 93010);

                f_23114_92934_93009(0x06000001, f_23114_92959_93008(corHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93024, 93071);

                f_23114_93024_93070(CorFlags.ILOnly, f_23114_93054_93069(corHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93085, 93132);

                f_23114_93085_93131(2, f_23114_93101_93130(corHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93146, 93193);

                f_23114_93146_93192(5, f_23114_93162_93191(corHeader));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93209, 93285);

                f_23114_93209_93284(0, corHeader.CodeManagerTableDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93299, 93357);

                f_23114_93299_93356(0, corHeader.CodeManagerTableDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93371, 93454);

                f_23114_93371_93453(0, corHeader.ExportAddressTableJumpsDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93468, 93533);

                f_23114_93468_93532(0, corHeader.ExportAddressTableJumpsDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93547, 93626);

                f_23114_93547_93625(0, corHeader.ManagedNativeHeaderDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93640, 93701);

                f_23114_93640_93700(0, corHeader.ManagedNativeHeaderDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93715, 93788);

                f_23114_93715_93787(0x2054, corHeader.MetadataDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93802, 93857);

                f_23114_93802_93856(0x02d0, corHeader.MetadataDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93871, 93940);

                f_23114_93871_93939(0, corHeader.ResourcesDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 93954, 94005);

                f_23114_93954_94004(0, corHeader.ResourcesDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94019, 94098);

                f_23114_94019_94097(0, corHeader.StrongNameSignatureDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94112, 94173);

                f_23114_94112_94172(0, corHeader.StrongNameSignatureDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94187, 94259);

                f_23114_94187_94258(0, corHeader.VtableFixupsDirectory.RelativeVirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94273, 94327);

                f_23114_94273_94326(0, corHeader.VtableFixupsDirectory.Size);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94343, 94383);

                var
                sections = f_23114_94358_94382(peHeaders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94397, 94430);

                f_23114_94397_94429(1, sections.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94446, 94486);

                f_23114_94446_94485(".text", sections[0].Name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94500, 94549);

                f_23114_94500_94548(0, sections[0].NumberOfLineNumbers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94563, 94612);

                f_23114_94563_94611(0, sections[0].NumberOfRelocations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94626, 94676);

                f_23114_94626_94675(0, sections[0].PointerToLineNumbers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94690, 94740);

                f_23114_94690_94739(0x200, sections[0].PointerToRawData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94754, 94804);

                f_23114_94754_94803(0, sections[0].PointerToRelocations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94818, 94973);

                f_23114_94818_94972(SectionCharacteristics.ContainsCode | SectionCharacteristics.MemExecute | SectionCharacteristics.MemRead, sections[0].SectionCharacteristics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 94987, 95034);

                f_23114_94987_95033(0x400, sections[0].SizeOfRawData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 95048, 95097);

                f_23114_95048_95096(0x2000, sections[0].VirtualAddress);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 95111, 95154);

                f_23114_95111_95153(832, sections[0].VirtualSize);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 87621, 95165);

                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23114_87700_87760(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, int
                value)
                {
                    var return_v = this_param.WithFileAlignment(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87700, 87760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23114_87700_87813(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, long
                value)
                {
                    var return_v = this_param.WithBaseAddress((ulong)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87700, 87813);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23114_87700_87872(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, bool
                value)
                {
                    var return_v = this_param.WithHighEntropyVirtualAddressSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87700, 87872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23114_87700_87939(Microsoft.CodeAnalysis.Emit.EmitOptions
                this_param, Microsoft.CodeAnalysis.SubsystemVersion
                subsystemVersion)
                {
                    var return_v = this_param.WithSubsystemVersion(subsystemVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87700, 87939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23114_87969_88058(string
                text, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                options)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, (Microsoft.CodeAnalysis.ParseOptions)options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 87969, 88058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_88174_88221(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.Platform
                platform)
                {
                    var return_v = this_param.WithPlatform(platform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88174, 88221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_88174_88245(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                deterministic)
                {
                    var return_v = this_param.WithDeterministic(deterministic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88174, 88245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_88090_88317(Microsoft.CodeAnalysis.SyntaxTree
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, string
                assemblyName)
                {
                    var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, assemblyName: assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88090, 88317);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23114_88090_88339(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitOptions
                options)
                {
                    var return_v = compilation.EmitToStream(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88090, 88339);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeaders
                f_23114_88408_88431(System.IO.MemoryStream
                peStream)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEHeaders((System.IO.Stream)peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88408, 88431);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeader?
                f_23114_88463_88481(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.PEHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88463, 88481);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CoffHeader
                f_23114_88513_88533(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CoffHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88513, 88533);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CorHeader?
                f_23114_88564_88583(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CorHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88564, 88583);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEMagic
                f_23114_88631_88645(System.Reflection.PortableExecutable.PEHeader?
                this_param)
                {
                    var return_v = this_param.Magic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88631, 88645);
                    return return_v;
                }


                int
                f_23114_88600_88646(System.Reflection.PortableExecutable.PEMagic
                expected, System.Reflection.PortableExecutable.PEMagic
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88600, 88646);
                    return 0;
                }


                int
                f_23114_88686_88714(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.AddressOfEntryPoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88686, 88714);
                    return return_v;
                }


                int
                f_23114_88661_88715(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88661, 88715);
                    return 0;
                }


                int
                f_23114_88755_88774(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.BaseOfCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88755, 88774);
                    return return_v;
                }


                int
                f_23114_88730_88775(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88730, 88775);
                    return 0;
                }


                int
                f_23114_88815_88834(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.BaseOfData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88815, 88834);
                    return return_v;
                }


                int
                f_23114_88790_88835(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88790, 88835);
                    return 0;
                }


                int
                f_23114_88875_88897(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88875, 88897);
                    return return_v;
                }


                int
                f_23114_88850_88898(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88850, 88898);
                    return 0;
                }


                int
                f_23114_88938_88957(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88938, 88957);
                    return return_v;
                }


                int
                f_23114_88913_88958(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88913, 88958);
                    return 0;
                }


                ulong
                f_23114_88999_89024(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfHeapCommit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 88999, 89024);
                    return return_v;
                }


                int
                f_23114_88973_89025(uint
                expected, ulong
                actual)
                {
                    Assert.Equal((ulong)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 88973, 89025);
                    return 0;
                }


                ulong
                f_23114_89066_89092(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfHeapReserve;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89066, 89092);
                    return return_v;
                }


                int
                f_23114_89040_89093(uint
                expected, ulong
                actual)
                {
                    Assert.Equal((ulong)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89040, 89093);
                    return 0;
                }


                int
                f_23114_89133_89153(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfImage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89133, 89153);
                    return return_v;
                }


                int
                f_23114_89108_89154(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89108, 89154);
                    return 0;
                }


                int
                f_23114_89194_89224(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfInitializedData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89194, 89224);
                    return return_v;
                }


                int
                f_23114_89169_89225(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89169, 89225);
                    return 0;
                }


                ulong
                f_23114_89266_89292(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfStackCommit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89266, 89292);
                    return return_v;
                }


                int
                f_23114_89240_89293(uint
                expected, ulong
                actual)
                {
                    Assert.Equal((ulong)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89240, 89293);
                    return 0;
                }


                ulong
                f_23114_89333_89360(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfStackReserve;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89333, 89360);
                    return return_v;
                }


                int
                f_23114_89308_89361(uint
                expected, ulong
                actual)
                {
                    Assert.Equal((ulong)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89308, 89361);
                    return 0;
                }


                int
                f_23114_89392_89424(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfUninitializedData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89392, 89424);
                    return return_v;
                }


                int
                f_23114_89376_89425(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89376, 89425);
                    return 0;
                }


                System.Reflection.PortableExecutable.Subsystem
                f_23114_89475_89493(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.Subsystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89475, 89493);
                    return return_v;
                }


                int
                f_23114_89440_89494(System.Reflection.PortableExecutable.Subsystem
                expected, System.Reflection.PortableExecutable.Subsystem
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89440, 89494);
                    return 0;
                }


                uint
                f_23114_89526_89543(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.CheckSum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89526, 89543);
                    return return_v;
                }


                int
                f_23114_89509_89544(uint
                expected, uint
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89509, 89544);
                    return 0;
                }


                int
                f_23114_89579_89601(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.FileAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89579, 89601);
                    return return_v;
                }


                int
                f_23114_89559_89602(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89559, 89602);
                    return 0;
                }


                ulong
                f_23114_89651_89669(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.ImageBase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89651, 89669);
                    return return_v;
                }


                int
                f_23114_89617_89670(ulong
                expected, ulong
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89617, 89670);
                    return 0;
                }


                int
                f_23114_89706_89731(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SectionAlignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89706, 89731);
                    return return_v;
                }


                int
                f_23114_89685_89732(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89685, 89732);
                    return 0;
                }


                ushort
                f_23114_89763_89789(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MajorImageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89763, 89789);
                    return return_v;
                }


                int
                f_23114_89747_89790(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89747, 89790);
                    return 0;
                }


                ushort
                f_23114_89821_89847(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MinorImageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89821, 89847);
                    return return_v;
                }


                int
                f_23114_89805_89848(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89805, 89848);
                    return 0;
                }


                byte
                f_23114_89882_89909(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MajorLinkerVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89882, 89909);
                    return return_v;
                }


                int
                f_23114_89863_89910(int
                expected, byte
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89863, 89910);
                    return 0;
                }


                byte
                f_23114_89941_89968(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MinorLinkerVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 89941, 89968);
                    return return_v;
                }


                int
                f_23114_89925_89969(int
                expected, byte
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89925, 89969);
                    return 0;
                }


                ushort
                f_23114_90000_90036(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MajorOperatingSystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 90000, 90036);
                    return return_v;
                }


                int
                f_23114_89984_90037(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 89984, 90037);
                    return 0;
                }


                ushort
                f_23114_90068_90104(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MinorOperatingSystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 90068, 90104);
                    return return_v;
                }


                int
                f_23114_90052_90105(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90052, 90105);
                    return 0;
                }


                ushort
                f_23114_90136_90166(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MajorSubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 90136, 90166);
                    return return_v;
                }


                int
                f_23114_90120_90167(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90120, 90167);
                    return 0;
                }


                ushort
                f_23114_90198_90228(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.MinorSubsystemVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 90198, 90228);
                    return return_v;
                }


                int
                f_23114_90182_90229(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90182, 90229);
                    return 0;
                }


                int
                f_23114_90261_90289(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.NumberOfRvaAndSizes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 90261, 90289);
                    return return_v;
                }


                int
                f_23114_90244_90290(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90244, 90290);
                    return 0;
                }


                int
                f_23114_90325_90347(System.Reflection.PortableExecutable.PEHeader
                this_param)
                {
                    var return_v = this_param.SizeOfHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 90325, 90347);
                    return return_v;
                }


                int
                f_23114_90305_90348(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90305, 90348);
                    return 0;
                }


                int
                f_23114_90365_90442(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90365, 90442);
                    return 0;
                }


                int
                f_23114_90457_90516(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90457, 90516);
                    return 0;
                }


                int
                f_23114_90531_90605(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90531, 90605);
                    return 0;
                }


                int
                f_23114_90620_90676(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90620, 90676);
                    return 0;
                }


                int
                f_23114_90691_90765(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90691, 90765);
                    return 0;
                }


                int
                f_23114_90780_90836(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90780, 90836);
                    return 0;
                }


                int
                f_23114_90851_90923(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90851, 90923);
                    return 0;
                }


                int
                f_23114_90938_90992(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 90938, 90992);
                    return 0;
                }


                int
                f_23114_91007_91084(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91007, 91084);
                    return 0;
                }


                int
                f_23114_91099_91156(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91099, 91156);
                    return 0;
                }


                int
                f_23114_91171_91244(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91171, 91244);
                    return 0;
                }


                int
                f_23114_91259_91312(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91259, 91312);
                    return 0;
                }


                int
                f_23114_91327_91399(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91327, 91399);
                    return 0;
                }


                int
                f_23114_91414_91468(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91414, 91468);
                    return 0;
                }


                int
                f_23114_91483_91552(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91483, 91552);
                    return 0;
                }


                int
                f_23114_91567_91618(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91567, 91618);
                    return 0;
                }


                int
                f_23114_91633_91709(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91633, 91709);
                    return 0;
                }


                int
                f_23114_91724_91782(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91724, 91782);
                    return 0;
                }


                int
                f_23114_91797_91866(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91797, 91866);
                    return 0;
                }


                int
                f_23114_91881_91932(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91881, 91932);
                    return 0;
                }


                int
                f_23114_91947_92020(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 91947, 92020);
                    return 0;
                }


                int
                f_23114_92035_92090(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92035, 92090);
                    return 0;
                }


                int
                f_23114_92105_92176(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92105, 92176);
                    return 0;
                }


                int
                f_23114_92191_92244(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92191, 92244);
                    return 0;
                }


                int
                f_23114_92259_92340(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92259, 92340);
                    return 0;
                }


                int
                f_23114_92355_92418(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92355, 92418);
                    return 0;
                }


                System.Reflection.PortableExecutable.Characteristics
                f_23114_92517_92543(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.Characteristics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 92517, 92543);
                    return return_v;
                }


                int
                f_23114_92435_92544(System.Reflection.PortableExecutable.Characteristics
                expected, System.Reflection.PortableExecutable.Characteristics
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92435, 92544);
                    return 0;
                }


                System.Reflection.PortableExecutable.Machine
                f_23114_92587_92605(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.Machine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 92587, 92605);
                    return return_v;
                }


                int
                f_23114_92559_92606(System.Reflection.PortableExecutable.Machine
                expected, System.Reflection.PortableExecutable.Machine
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92559, 92606);
                    return 0;
                }


                short
                f_23114_92637_92664(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.NumberOfSections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 92637, 92664);
                    return return_v;
                }


                int
                f_23114_92621_92665(int
                expected, short
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92621, 92665);
                    return 0;
                }


                int
                f_23114_92696_92722(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.NumberOfSymbols;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 92696, 92722);
                    return return_v;
                }


                int
                f_23114_92680_92723(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92680, 92723);
                    return 0;
                }


                int
                f_23114_92754_92785(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.PointerToSymbolTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 92754, 92785);
                    return return_v;
                }


                int
                f_23114_92738_92786(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92738, 92786);
                    return 0;
                }


                short
                f_23114_92819_92850(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.SizeOfOptionalHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 92819, 92850);
                    return return_v;
                }


                int
                f_23114_92801_92851(int
                expected, short
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92801, 92851);
                    return 0;
                }


                int
                f_23114_92892_92916(System.Reflection.PortableExecutable.CoffHeader
                this_param)
                {
                    var return_v = this_param.TimeDateStamp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 92892, 92916);
                    return return_v;
                }


                int
                f_23114_92866_92917(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92866, 92917);
                    return 0;
                }


                int
                f_23114_92959_93008(System.Reflection.PortableExecutable.CorHeader?
                this_param)
                {
                    var return_v = this_param.EntryPointTokenOrRelativeVirtualAddress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 92959, 93008);
                    return return_v;
                }


                int
                f_23114_92934_93009(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 92934, 93009);
                    return 0;
                }


                System.Reflection.PortableExecutable.CorFlags
                f_23114_93054_93069(System.Reflection.PortableExecutable.CorHeader
                this_param)
                {
                    var return_v = this_param.Flags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 93054, 93069);
                    return return_v;
                }


                int
                f_23114_93024_93070(System.Reflection.PortableExecutable.CorFlags
                expected, System.Reflection.PortableExecutable.CorFlags
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93024, 93070);
                    return 0;
                }


                ushort
                f_23114_93101_93130(System.Reflection.PortableExecutable.CorHeader
                this_param)
                {
                    var return_v = this_param.MajorRuntimeVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 93101, 93130);
                    return return_v;
                }


                int
                f_23114_93085_93131(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93085, 93131);
                    return 0;
                }


                ushort
                f_23114_93162_93191(System.Reflection.PortableExecutable.CorHeader
                this_param)
                {
                    var return_v = this_param.MinorRuntimeVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 93162, 93191);
                    return return_v;
                }


                int
                f_23114_93146_93192(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93146, 93192);
                    return 0;
                }


                int
                f_23114_93209_93284(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93209, 93284);
                    return 0;
                }


                int
                f_23114_93299_93356(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93299, 93356);
                    return 0;
                }


                int
                f_23114_93371_93453(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93371, 93453);
                    return 0;
                }


                int
                f_23114_93468_93532(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93468, 93532);
                    return 0;
                }


                int
                f_23114_93547_93625(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93547, 93625);
                    return 0;
                }


                int
                f_23114_93640_93700(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93640, 93700);
                    return 0;
                }


                int
                f_23114_93715_93787(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93715, 93787);
                    return 0;
                }


                int
                f_23114_93802_93856(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93802, 93856);
                    return 0;
                }


                int
                f_23114_93871_93939(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93871, 93939);
                    return 0;
                }


                int
                f_23114_93954_94004(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 93954, 94004);
                    return 0;
                }


                int
                f_23114_94019_94097(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94019, 94097);
                    return 0;
                }


                int
                f_23114_94112_94172(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94112, 94172);
                    return 0;
                }


                int
                f_23114_94187_94258(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94187, 94258);
                    return 0;
                }


                int
                f_23114_94273_94326(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94273, 94326);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<System.Reflection.PortableExecutable.SectionHeader>
                f_23114_94358_94382(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.SectionHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 94358, 94382);
                    return return_v;
                }


                int
                f_23114_94397_94429(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94397, 94429);
                    return 0;
                }


                int
                f_23114_94446_94485(string
                expected, string
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94446, 94485);
                    return 0;
                }


                int
                f_23114_94500_94548(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94500, 94548);
                    return 0;
                }


                int
                f_23114_94563_94611(int
                expected, ushort
                actual)
                {
                    Assert.Equal(expected, (int)actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94563, 94611);
                    return 0;
                }


                int
                f_23114_94626_94675(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94626, 94675);
                    return 0;
                }


                int
                f_23114_94690_94739(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94690, 94739);
                    return 0;
                }


                int
                f_23114_94754_94803(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94754, 94803);
                    return 0;
                }


                int
                f_23114_94818_94972(System.Reflection.PortableExecutable.SectionCharacteristics
                expected, System.Reflection.PortableExecutable.SectionCharacteristics
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94818, 94972);
                    return 0;
                }


                int
                f_23114_94987_95033(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 94987, 95033);
                    return 0;
                }


                int
                f_23114_95048_95096(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 95048, 95096);
                    return 0;
                }


                int
                f_23114_95111_95153(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 95111, 95153);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 87621, 95165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 87621, 95165);
            }
        }

        [Fact]
        public void InParametersShouldHaveMetadataIn_TypeMethods()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 95177, 96003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 95276, 95409);

                var
                text = @"
using System.Runtime.InteropServices;
class T
{
    public void M(in int a, [In]in int b, [In]int c, int d) {}
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 95425, 95893);

                Action<ModuleSymbol>
                verifier = module =>
                            {
                                var parameters = module.GlobalNamespace.GetTypeMember("T").GetMethod("M").GetParameters();
                                Assert.Equal(4, parameters.Length);

                                Assert.True(parameters[0].IsMetadataIn);
                                Assert.True(parameters[1].IsMetadataIn);
                                Assert.True(parameters[2].IsMetadataIn);
                                Assert.False(parameters[3].IsMetadataIn);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 95909, 95992);

                f_23114_95909_95991(this, text, sourceSymbolValidator: verifier, symbolValidator: verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 95177, 96003);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_95909_95991(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 95909, 95991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 95177, 96003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 95177, 96003);
            }
        }

        [Fact]
        public void InParametersShouldHaveMetadataIn_IndexerMethods()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 96015, 96856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 96117, 96255);

                var
                text = @"
using System.Runtime.InteropServices;
class T
{
    public int this[in int a, [In]in int b, [In]int c, int d] => 0;
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 96271, 96746);

                Action<ModuleSymbol>
                verifier = module =>
                            {
                                var parameters = module.GlobalNamespace.GetTypeMember("T").GetMethod("get_Item").GetParameters();
                                Assert.Equal(4, parameters.Length);

                                Assert.True(parameters[0].IsMetadataIn);
                                Assert.True(parameters[1].IsMetadataIn);
                                Assert.True(parameters[2].IsMetadataIn);
                                Assert.False(parameters[3].IsMetadataIn);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 96762, 96845);

                f_23114_96762_96844(this, text, sourceSymbolValidator: verifier, symbolValidator: verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 96015, 96856);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_96762_96844(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 96762, 96844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 96015, 96856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 96015, 96856);
            }
        }

        [Fact]
        public void InParametersShouldHaveMetadataIn_Delegates()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 96868, 98952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 96965, 97232);

                var
                text = @"
using System.Runtime.InteropServices;
public delegate void D(in int a, [In]in int b, [In]int c, int d);
public class C
{
    public void M()
    {
        N((in int a, in int b, int c, int d) => {});
    }
    public void N(D lambda) { }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 97248, 98941);

                f_23114_97248_98940(this, text, options: f_23114_97297_97372(TestOptions.ReleaseDll, MetadataImportOptions.All), sourceSymbolValidator: module =>
                                {
                                    var parameters = module.ContainingAssembly.GetTypeByMetadataName("D").DelegateInvokeMethod.Parameters;
                                    Assert.Equal(4, parameters.Length);

                                    Assert.True(parameters[0].IsMetadataIn);
                                    Assert.True(parameters[1].IsMetadataIn);
                                    Assert.True(parameters[2].IsMetadataIn);
                                    Assert.False(parameters[3].IsMetadataIn);
                                }, symbolValidator: module =>
                                {
                                    var delegateParameters = module.ContainingAssembly.GetTypeByMetadataName("D").DelegateInvokeMethod.Parameters;
                                    Assert.Equal(4, delegateParameters.Length);

                                    Assert.True(delegateParameters[0].IsMetadataIn);
                                    Assert.True(delegateParameters[1].IsMetadataIn);
                                    Assert.True(delegateParameters[2].IsMetadataIn);
                                    Assert.False(delegateParameters[3].IsMetadataIn);

                                    var lambdaParameters = module.GlobalNamespace.GetTypeMember("C").GetTypeMember("<>c").GetMethod("<M>b__0_0").Parameters;
                                    Assert.Equal(4, lambdaParameters.Length);

                                    Assert.True(lambdaParameters[0].IsMetadataIn);
                                    Assert.True(lambdaParameters[1].IsMetadataIn);
                                    Assert.False(lambdaParameters[2].IsMetadataIn);
                                    Assert.False(lambdaParameters[3].IsMetadataIn);
                                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 96868, 98952);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_97297_97372(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 97297, 97372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_97248_98940(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 97248, 98940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 96868, 98952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 96868, 98952);
            }
        }

        [Fact]
        public void InParametersShouldHaveMetadataIn_LocalFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 98964, 99708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 99066, 99220);

                var
                text = @"
using System.Runtime.InteropServices;
public class C
{
    public void M()
    {
        void local(in int a, int c) { }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 99236, 99697);

                f_23114_99236_99696(this, text, options: f_23114_99268_99343(TestOptions.ReleaseDll, MetadataImportOptions.All), symbolValidator: module =>
                            {
                                var parameters = module.GlobalNamespace.GetTypeMember("C").GetMember("<M>g__local|0_0").GetParameters();
                                Assert.Equal(2, parameters.Length);

                                Assert.True(parameters[0].IsMetadataIn);
                                Assert.False(parameters[1].IsMetadataIn);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 98964, 99708);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_99268_99343(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 99268, 99343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_99236_99696(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 99236, 99696);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 98964, 99708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 98964, 99708);
            }
        }

        [Fact]
        public void InParametersShouldHaveMetadataIn_ExternMethods()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 99720, 100592);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 99821, 99998);

                var
                text = @"
using System.Runtime.InteropServices;
class T
{
    [DllImport(""Other.dll"")]
    public static extern void M(in int a, [In]in int b, [In]int c, int d);
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 100014, 100482);

                Action<ModuleSymbol>
                verifier = module =>
                            {
                                var parameters = module.GlobalNamespace.GetTypeMember("T").GetMethod("M").GetParameters();
                                Assert.Equal(4, parameters.Length);

                                Assert.True(parameters[0].IsMetadataIn);
                                Assert.True(parameters[1].IsMetadataIn);
                                Assert.True(parameters[2].IsMetadataIn);
                                Assert.False(parameters[3].IsMetadataIn);
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 100498, 100581);

                f_23114_100498_100580(this, text, sourceSymbolValidator: verifier, symbolValidator: verifier);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 99720, 100592);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_100498_100580(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                sourceSymbolValidator, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, sourceSymbolValidator: sourceSymbolValidator, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 100498, 100580);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 99720, 100592);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 99720, 100592);
            }
        }

        [Fact]
        public void InParametersShouldHaveMetadataIn_NoPIA()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 100604, 102456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 100697, 101059);

                var
                comAssembly = f_23114_100715_101058(@"
using System;
using System.Runtime.InteropServices;
[assembly: ImportedFromTypeLib(""test.dll"")]
[assembly: Guid(""6681dcd6-9c3e-4c3a-b04a-aef3ee85c2cf"")]
[ComImport()]
[Guid(""6681dcd6-9c3e-4c3a-b04a-aef3ee85c2cf"")]
public interface T
{
    void M(in int a, [In]in int b, [In]int c, int d);
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 101075, 101559);

                f_23114_101075_101558(this, comAssembly, symbolValidator: module =>
                            {
                                var parameters = module.GlobalNamespace.GetTypeMember("T").GetMethod("M").GetParameters();
                                Assert.Equal(4, parameters.Length);

                                Assert.True(parameters[0].IsMetadataIn);
                                Assert.True(parameters[1].IsMetadataIn);
                                Assert.True(parameters[2].IsMetadataIn);
                                Assert.False(parameters[3].IsMetadataIn);
                            });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 101575, 101676);

                var
                code = @"
class User
{
    public void M(T obj)
    {
        obj.M(1, 2, 3, 4);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 101694, 102445);

                f_23114_101694_102444(this, source: code, options: f_23114_101769_101842(TestOptions.DebugDll, MetadataImportOptions.All), references: new[] { f_23114_101881_101938(comAssembly, embedInteropTypes: true) }, symbolValidator: module =>
                                 {
                                     var parameters = module.GlobalNamespace.GetTypeMember("T").GetMethod("M").GetParameters();
                                     Assert.Equal(4, parameters.Length);

                                     Assert.True(parameters[0].IsMetadataIn);
                                     Assert.True(parameters[1].IsMetadataIn);
                                     Assert.True(parameters[2].IsMetadataIn);
                                     Assert.False(parameters[3].IsMetadataIn);
                                 });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 100604, 102456);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_100715_101058(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib40((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 100715, 101058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_101075_101558(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 101075, 101558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_101769_101842(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 101769, 101842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23114_101881_101938(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp, bool
                embedInteropTypes)
                {
                    var return_v = comp.EmitToImageReference(embedInteropTypes: embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 101881, 101938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_101694_102444(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 101694, 102444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 100604, 102456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 100604, 102456);
            }
        }

        [Fact]
        public void ExtendingInParametersFromParentWithoutInAttributeWorksWithoutErrors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 102468, 106514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 102590, 104967);

                var
                reference = f_23114_102606_104966(@"
.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute extends [mscorlib]System.Attribute
{
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (01 00 00 00)
    .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = (01 00 00 00)

    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        .maxstack 8
        IL_0000: ldarg.0
        IL_0001: call instance void [mscorlib]System.Attribute::.ctor()
        IL_0006: nop
        IL_0007: ret
    }
}

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.IsReadOnlyAttribute extends [mscorlib]System.Attribute
{
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = (01 00 00 00)
    .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = (01 00 00 00)

    .method public hidebysig specialname rtspecialname instance void .ctor () cil managed 
    {
        .maxstack 8
        IL_0000: ldarg.0
        IL_0001: call instance void [mscorlib]System.Attribute::.ctor()
        IL_0006: nop
        IL_0007: ret
    }
}

.class public auto ansi beforefieldinit Parent extends [mscorlib]System.Object
{
    .method public hidebysig newslot virtual instance void M (
            int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute)  a,
            int32& modreq([mscorlib]System.Runtime.InteropServices.InAttribute)  b,
            int32 c,
            int32 d) cil managed 
    {
        .param [1] .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = (01 00 00 00)
        .param [2] .custom instance void System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = (01 00 00 00)
        .maxstack 8
        IL_0000: nop
        IL_0001: ldstr ""Parent called""
        IL_0006: call void [mscorlib]System.Console::WriteLine(string)
        IL_000b: nop
        IL_000c: ret
    }

    .method public hidebysig specialname rtspecialname instance void .ctor() cil managed
    {
        .maxstack 8
        IL_0000: ldarg.0
        IL_0001: call instance void[mscorlib] System.Object::.ctor()
        IL_0006: nop
        IL_0007: ret
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 104983, 105454);

                var
                comp = f_23114_104994_105453(@"
using System;
using System.Runtime.InteropServices;

public class Child : Parent
{
    public override void M(in int a, [In]in int b, [In]int c, int d)
    {
        base.M(a, b, c, d);

        Console.WriteLine(""Child called"");
    }
}
public static class Program
{
    public static void Main()
    {
        var obj = new Child();
        obj.M(1, 2, 3, 4);
    }
}", new[] { reference }, TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 105470, 105561);

                var
                parentParameters = f_23114_105493_105560(f_23114_105493_105544(f_23114_105493_105529(comp, "Parent"), "M"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 105575, 105616);

                f_23114_105575_105615(4, parentParameters.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 105632, 105679);

                f_23114_105632_105678(f_23114_105645_105677(parentParameters[0]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 105693, 105740);

                f_23114_105693_105739(f_23114_105706_105738(parentParameters[1]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 105754, 105801);

                f_23114_105754_105800(f_23114_105767_105799(parentParameters[2]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 105815, 105862);

                f_23114_105815_105861(f_23114_105828_105860(parentParameters[3]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 105880, 105933);

                var
                expectedOutput =
                @"Parent called
Child called"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 105949, 106503);

                f_23114_105949_106502(this, comp, expectedOutput: expectedOutput, symbolValidator: module =>
                            {
                                var childParameters = module.ContainingAssembly.GetTypeByMetadataName("Child").GetMethod("M").GetParameters();
                                Assert.Equal(4, childParameters.Length);

                                Assert.True(childParameters[0].IsMetadataIn);
                                Assert.True(childParameters[1].IsMetadataIn);
                                Assert.True(childParameters[2].IsMetadataIn);
                                Assert.False(childParameters[3].IsMetadataIn);
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 102468, 106514);

                Microsoft.CodeAnalysis.MetadataReference
                f_23114_102606_104966(string
                ilSource)
                {
                    var return_v = CompileIL(ilSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 102606, 104966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_104994_105453(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 104994, 105453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_23114_105493_105529(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, string
                fullyQualifiedMetadataName)
                {
                    var return_v = this_param.GetTypeByMetadataName(fullyQualifiedMetadataName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 105493, 105529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23114_105493_105544(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                symbol, string
                name)
                {
                    var return_v = symbol.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 105493, 105544);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_23114_105493_105560(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 105493, 105560);
                    return return_v;
                }


                int
                f_23114_105575_105615(int
                expected, int
                actual)
                {
                    Assert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 105575, 105615);
                    return 0;
                }


                bool
                f_23114_105645_105677(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 105645, 105677);
                    return return_v;
                }


                int
                f_23114_105632_105678(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 105632, 105678);
                    return 0;
                }


                bool
                f_23114_105706_105738(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 105706, 105738);
                    return return_v;
                }


                int
                f_23114_105693_105739(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 105693, 105739);
                    return 0;
                }


                bool
                f_23114_105767_105799(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 105767, 105799);
                    return return_v;
                }


                int
                f_23114_105754_105800(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 105754, 105800);
                    return 0;
                }


                bool
                f_23114_105828_105860(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23114, 105828, 105860);
                    return return_v;
                }


                int
                f_23114_105815_105861(bool
                condition)
                {
                    Assert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 105815, 105861);
                    return 0;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_105949_106502(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOutput, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 105949, 106502);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 102468, 106514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 102468, 106514);
            }
        }

        [Fact]
        public void GeneratingProxyForVirtualMethodInParentCopiesMetadataBitsCorrectly_OutAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 106526, 108520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 106660, 106825);

                var
                reference = f_23114_106676_106824(@"
using System.Runtime.InteropServices;

public class Parent
{
    public void M(out int a, [Out] int b) => throw null;
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 106841, 107261);

                f_23114_106841_107260(this, reference, symbolValidator: module =>
                            {
                                var sourceParentParameters = module.GlobalNamespace.GetTypeMember("Parent").GetMethod("M").GetParameters();
                                Assert.Equal(2, sourceParentParameters.Length);

                                Assert.True(sourceParentParameters[0].IsMetadataOut);
                                Assert.True(sourceParentParameters[1].IsMetadataOut);
                            });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 107277, 107450);

                var
                source = @"
using System.Runtime.InteropServices;

public interface IParent
{
    void M(out int a, [Out] int b);
}

public class Child : Parent, IParent
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 107466, 108509);

                f_23114_107466_108508(this, source: source, references: new[] { f_23114_107554_107586(reference) }, options: f_23114_107616_107691(TestOptions.ReleaseDll, MetadataImportOptions.All), symbolValidator: module =>
                                 {
                                     var interfaceParameters = module.GlobalNamespace.GetTypeMember("IParent").GetMethod("M").GetParameters();
                                     Assert.Equal(2, interfaceParameters.Length);

                                     Assert.True(interfaceParameters[0].IsMetadataOut);
                                     Assert.True(interfaceParameters[1].IsMetadataOut);

                                     var proxyChildParameters = module.GlobalNamespace.GetTypeMember("Child").GetMethod("IParent.M").GetParameters();
                                     Assert.Equal(2, proxyChildParameters.Length);

                                     Assert.True(proxyChildParameters[0].IsMetadataOut);
                                     Assert.False(proxyChildParameters[1].IsMetadataOut); // User placed attributes are not copied.
                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 106526, 108520);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_106676_106824(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 106676, 106824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_106841_107260(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 106841, 107260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23114_107554_107586(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 107554, 107586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_107616_107691(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 107616, 107691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_107466_108508(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 107466, 108508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 106526, 108520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 106526, 108520);
            }
        }

        [Fact]
        public void GeneratingProxyForVirtualMethodInParentCopiesMetadataBitsCorrectly_InAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23114, 108532, 110515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 108665, 108828);

                var
                reference = f_23114_108681_108827(@"
using System.Runtime.InteropServices;

public class Parent
{
    public void M(in int a, [In] int b) => throw null;
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 108844, 109262);

                f_23114_108844_109261(this, reference, symbolValidator: module =>
                            {
                                var sourceParentParameters = module.GlobalNamespace.GetTypeMember("Parent").GetMethod("M").GetParameters();
                                Assert.Equal(2, sourceParentParameters.Length);

                                Assert.True(sourceParentParameters[0].IsMetadataIn);
                                Assert.True(sourceParentParameters[1].IsMetadataIn);
                            });
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 109278, 109449);

                var
                source = @"
using System.Runtime.InteropServices;

public interface IParent
{
    void M(in int a, [In] int b);
}

public class Child : Parent, IParent
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23114, 109465, 110504);

                f_23114_109465_110503(this, source: source, references: new[] { f_23114_109553_109585(reference) }, options: f_23114_109615_109690(TestOptions.ReleaseDll, MetadataImportOptions.All), symbolValidator: module =>
                                 {
                                     var interfaceParameters = module.GlobalNamespace.GetTypeMember("IParent").GetMethod("M").GetParameters();
                                     Assert.Equal(2, interfaceParameters.Length);

                                     Assert.True(interfaceParameters[0].IsMetadataIn);
                                     Assert.True(interfaceParameters[1].IsMetadataIn);

                                     var proxyChildParameters = module.GlobalNamespace.GetTypeMember("Child").GetMethod("IParent.M").GetParameters();
                                     Assert.Equal(2, proxyChildParameters.Length);

                                     Assert.True(proxyChildParameters[0].IsMetadataIn);
                                     Assert.False(proxyChildParameters[1].IsMetadataIn); // User placed attributes are not copied.
                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23114, 108532, 110515);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23114_108681_108827(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 108681, 108827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_108844_109261(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 108844, 109261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23114_109553_109585(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 109553, 109585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23114_109615_109690(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.MetadataImportOptions
                value)
                {
                    var return_v = this_param.WithMetadataImportOptions(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 109615, 109690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23114_109465_110503(Microsoft.CodeAnalysis.CSharp.UnitTests.EmitMetadata
                this_param, string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, System.Action<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                symbolValidator)
                {
                    var return_v = this_param.CompileAndVerify(source: (Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options, symbolValidator: symbolValidator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23114, 109465, 110503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23114, 108532, 110515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 108532, 110515);
            }
        }

        public EmitMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(23114, 917, 110522);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(23114, 917, 110522);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 917, 110522);
        }


        static EmitMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23114, 917, 110522);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23114, 917, 110522);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23114, 917, 110522);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23114, 917, 110522);
    }
}
