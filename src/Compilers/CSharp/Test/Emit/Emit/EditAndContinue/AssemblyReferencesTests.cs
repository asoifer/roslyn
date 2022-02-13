// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.CSharp.UnitTests;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Roslyn.Test.MetadataUtilities;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests
{
    public class AssemblyReferencesTests : EditAndContinueTestBase
    {
        private static readonly CSharpCompilationOptions s_signedDll;

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void CompilationReferences_Less()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23104, 1362, 3903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 1855, 1932);

                var
                references = new[] { f_23104_1880_1901(), f_23104_1903_1914(), f_23104_1916_1929() }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 1948, 2158);

                string
                src1 = @"
using System;
using System.Threading.Tasks;

class C 
{ 
    public Task<int> F() { Console.WriteLine(123); return null; }
    public static void Main() { Console.WriteLine(1); } 
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2172, 2381);

                string
                src2 = @"
using System;
using System.Threading.Tasks;

class C 
{ 
    public Task<int> F() { Console.WriteLine(123); return null; }
    public static void Main() { Console.WriteLine(2); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2397, 2447);

                var
                c1 = f_23104_2406_2446(src1, references)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2461, 2490);

                var
                c2 = f_23104_2470_2489(c1, src2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2504, 2567);

                var
                md1 = f_23104_2514_2566(f_23104_2548_2565(c1))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2581, 2710);

                var
                baseline = f_23104_2596_2709(f_23104_2631_2647(md1)[0], handle => default(EditAndContinueMethodDebugInformation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2726, 2760);

                var
                mdStream = f_23104_2741_2759()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2774, 2808);

                var
                ilStream = f_23104_2789_2807()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2822, 2857);

                var
                pdbStream = f_23104_2838_2856()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2871, 2927);

                var
                updatedMethods = f_23104_2892_2926()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 2943, 3257);

                var
                edits = new[]
                            {
                SemanticEdit.Create(                    SemanticEditKind.Update,f_23104_3081_3149(f_23104_3081_3131(f_23104_3081_3099(c1), "C"), "Main"),f_23104_3172_3240(f_23104_3172_3222(f_23104_3172_3190(c2), "C"), "Main"))            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 3273, 3355);

                f_23104_3273_3354(
                            c2, baseline, edits, mdStream, ilStream, pdbStream, updatedMethods);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 3371, 3442);

                var
                actualIL = f_23104_3386_3427(f_23104_3408_3426(ilStream)).GetMethodIL()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 3456, 3604);

                var
                expectedIL = @"
{
  // Code size        7 (0x7)
  .maxstack  8
  IL_0000:  ldc.i4.2
  IL_0001:  call       0x0A000006
  IL_0006:  ret
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 3818, 3892);

                f_23104_3818_3891(expectedIL, actualIL);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23104, 1362, 3903);

                Microsoft.CodeAnalysis.MetadataReference
                f_23104_1880_1901()
                {
                    var return_v = SystemWindowsFormsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 1880, 1901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_1903_1914()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 1903, 1914);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_1916_1929()
                {
                    var return_v = SystemCoreRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 1916, 1929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_2406_2446(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2406, 2446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_2470_2489(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                newSource)
                {
                    var return_v = compilation.WithSource(newSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2470, 2489);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23104_2548_2565(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = compilation.EmitToStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2548, 2565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_23104_2514_2566(System.IO.MemoryStream
                peStream)
                {
                    var return_v = AssemblyMetadata.CreateFromStream((System.IO.Stream)peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2514, 2566);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                f_23104_2631_2647(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetModules();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2631, 2647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_2596_2709(Microsoft.CodeAnalysis.ModuleMetadata
                module, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
                debugInformationProvider)
                {
                    var return_v = EmitBaseline.CreateInitialBaseline(module, debugInformationProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2596, 2709);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23104_2741_2759()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2741, 2759);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23104_2789_2807()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2789, 2807);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23104_2838_2856()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2838, 2856);
                    return return_v;
                }


                System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>
                f_23104_2892_2926()
                {
                    var return_v = new System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 2892, 2926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_23104_3081_3099(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 3081, 3099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23104_3081_3131(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 3081, 3131);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_23104_3081_3149(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 3081, 3149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_23104_3172_3190(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 3172, 3190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23104_3172_3222(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 3172, 3222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_23104_3172_3240(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 3172, 3240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
                f_23104_3273_3354(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, Microsoft.CodeAnalysis.Emit.SemanticEdit[]
                edits, System.IO.MemoryStream
                metadataStream, System.IO.MemoryStream
                ilStream, System.IO.MemoryStream
                pdbStream, System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>
                updatedMethods)
                {
                    var return_v = this_param.EmitDifference(baseline, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>)edits, (System.IO.Stream)metadataStream, (System.IO.Stream)ilStream, (System.IO.Stream)pdbStream, (System.Collections.Generic.ICollection<System.Reflection.Metadata.MethodDefinitionHandle>)updatedMethods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 3273, 3354);
                    return return_v;
                }


                byte[]
                f_23104_3408_3426(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 3408, 3426);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_23104_3386_3427(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 3386, 3427);
                    return return_v;
                }


                bool
                f_23104_3818_3891(string
                expected, string
                actual)
                {
                    var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 3818, 3891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23104, 1362, 3903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 1362, 3903);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void CompilationReferences_More()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23104, 4140, 6528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 4310, 4475);

                string
                src1 = @"
using System;
class C 
{ 
    public static int F(object a) { return 1; }
    public static void Main() { Console.WriteLine(F(null)); } 
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 4489, 4634);

                string
                src2 = @"
using System;
class C 
{ 
    public static int F(object a) { return 1; }
    public static void Main() { F(null); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 4781, 4998);

                string
                srcPE = @"
using System;
class C 
{ 
    public static int F(System.Diagnostics.Process a) { return 2; }
    public static int F(object a) { return 1; }

    public static void Main() { F(null); }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5012, 5136);

                var
                md1 = f_23104_5022_5135(f_23104_5056_5134(f_23104_5056_5119(srcPE, new[] { f_23104_5094_5105(), f_23104_5107_5116() })))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5152, 5213);

                var
                c1 = f_23104_5161_5212(src1, new[] { f_23104_5198_5209() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5227, 5256);

                var
                c2 = f_23104_5236_5255(c1, src2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5270, 5399);

                var
                baseline = f_23104_5285_5398(f_23104_5320_5336(md1)[0], handle => default(EditAndContinueMethodDebugInformation))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5415, 5449);

                var
                mdStream = f_23104_5430_5448()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5463, 5497);

                var
                ilStream = f_23104_5478_5496()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5511, 5546);

                var
                pdbStream = f_23104_5527_5545()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5560, 5616);

                var
                updatedMethods = f_23104_5581_5615()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5632, 5946);

                var
                edits = new[]
                            {
                SemanticEdit.Create(                    SemanticEditKind.Update,f_23104_5770_5838(f_23104_5770_5820(f_23104_5770_5788(c1), "C"), "Main"),f_23104_5861_5929(f_23104_5861_5911(f_23104_5861_5879(c2), "C"), "Main"))            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 5962, 6044);

                f_23104_5962_6043(
                            c2, baseline, edits, mdStream, ilStream, pdbStream, updatedMethods);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 6060, 6131);

                var
                actualIL = f_23104_6075_6116(f_23104_6097_6115(ilStream)).GetMethodIL()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 6266, 6429);

                var
                expectedIL = @"
{
  // Code size        8 (0x8)
  .maxstack  8
  IL_0000:  ldnull
  IL_0001:  call       0x06000002
  IL_0006:  pop
  IL_0007:  ret
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 6443, 6517);

                f_23104_6443_6516(expectedIL, actualIL);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23104, 4140, 6528);

                Microsoft.CodeAnalysis.MetadataReference
                f_23104_5094_5105()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 5094, 5105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_5107_5116()
                {
                    var return_v = SystemRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 5107, 5116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_5056_5119(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5056, 5119);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23104_5056_5134(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = compilation.EmitToStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5056, 5134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_23104_5022_5135(System.IO.MemoryStream
                peStream)
                {
                    var return_v = AssemblyMetadata.CreateFromStream((System.IO.Stream)peStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5022, 5135);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_5198_5209()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 5198, 5209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_5161_5212(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5161, 5212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_5236_5255(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                newSource)
                {
                    var return_v = compilation.WithSource(newSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5236, 5255);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                f_23104_5320_5336(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetModules();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5320, 5336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_5285_5398(Microsoft.CodeAnalysis.ModuleMetadata
                module, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
                debugInformationProvider)
                {
                    var return_v = EmitBaseline.CreateInitialBaseline(module, debugInformationProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5285, 5398);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23104_5430_5448()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5430, 5448);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23104_5478_5496()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5478, 5496);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23104_5527_5545()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5527, 5545);
                    return return_v;
                }


                System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>
                f_23104_5581_5615()
                {
                    var return_v = new System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5581, 5615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_23104_5770_5788(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 5770, 5788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23104_5770_5820(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5770, 5820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_23104_5770_5838(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5770, 5838);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_23104_5861_5879(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 5861, 5879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23104_5861_5911(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5861, 5911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_23104_5861_5929(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, string
                qualifiedName)
                {
                    var return_v = container.GetMember(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5861, 5929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitDifferenceResult
                f_23104_5962_6043(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, Microsoft.CodeAnalysis.Emit.SemanticEdit[]
                edits, System.IO.MemoryStream
                metadataStream, System.IO.MemoryStream
                ilStream, System.IO.MemoryStream
                pdbStream, System.Collections.Generic.List<System.Reflection.Metadata.MethodDefinitionHandle>
                updatedMethods)
                {
                    var return_v = this_param.EmitDifference(baseline, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Emit.SemanticEdit>)edits, (System.IO.Stream)metadataStream, (System.IO.Stream)ilStream, (System.IO.Stream)pdbStream, (System.Collections.Generic.ICollection<System.Reflection.Metadata.MethodDefinitionHandle>)updatedMethods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 5962, 6043);
                    return return_v;
                }


                byte[]
                f_23104_6097_6115(System.IO.MemoryStream
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 6097, 6115);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_23104_6075_6116(params byte[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 6075, 6116);
                    return return_v;
                }


                bool
                f_23104_6443_6516(string
                expected, string
                actual)
                {
                    var return_v = AssertEx.AssertEqualToleratingWhitespaceDifferences(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 6443, 6516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23104, 4140, 6528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 4140, 6528);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void ChangingCompilationDependencies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23104, 6700, 9110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 6875, 6917);

                string
                srcLib = @"
public class D { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 6933, 7014);

                string
                src0 = @"
class C 
{ 
    public static int F(D a) { return 1; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7028, 7109);

                string
                src1 = @"
class C 
{ 
    public static int F(D a) { return 2; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7123, 7204);

                string
                src2 = @"
class C 
{ 
    public static int F(D a) { return 3; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7218, 7307);

                var
                lib0 = f_23104_7229_7306(srcLib, assemblyName: "Lib", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7321, 7346);

                f_23104_7321_7345(lib0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7362, 7451);

                var
                lib1 = f_23104_7373_7450(srcLib, assemblyName: "Lib", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7465, 7490);

                f_23104_7465_7489(lib1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7506, 7595);

                var
                lib2 = f_23104_7517_7594(srcLib, assemblyName: "Lib", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7609, 7634);

                f_23104_7609_7633(lib2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7650, 7799);

                var
                compilation0 = f_23104_7669_7798(src0, new[] { f_23104_7706_7717(), f_23104_7719_7745(lib0) }, assemblyName: "C", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7813, 7928);

                var
                compilation1 = f_23104_7832_7927(f_23104_7832_7861(compilation0, src1), new[] { f_23104_7885_7896(), f_23104_7898_7924(lib1) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 7942, 8057);

                var
                compilation2 = f_23104_7961_8056(f_23104_7961_7990(compilation1, src2), new[] { f_23104_8014_8025(), f_23104_8027_8053(lib2) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8073, 8113);

                var
                v0 = f_23104_8082_8112(this, compilation0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8127, 8167);

                var
                v1 = f_23104_8136_8166(this, compilation1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8181, 8221);

                var
                v2 = f_23104_8190_8220(this, compilation2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8237, 8290);

                var
                f0 = f_23104_8246_8289(compilation0, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8304, 8357);

                var
                f1 = f_23104_8313_8356(compilation1, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8371, 8424);

                var
                f2 = f_23104_8380_8423(compilation2, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8440, 8505);

                var
                md0 = f_23104_8450_8504(v0.EmittedAssemblyData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8519, 8598);

                var
                generation0 = f_23104_8537_8597(md0, EmptyLocalsProvider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8614, 8779);

                var
                diff1 = f_23104_8626_8778(compilation1, generation0, f_23104_8702_8777(SemanticEdit.Create(SemanticEditKind.Update, f0, f1)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8795, 8833);

                diff1.EmitResult.Diagnostics.Verify();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 8849, 9045);

                var
                diff2 = f_23104_8861_9044(compilation2, f_23104_8907_8927(diff1), f_23104_8946_9043(SemanticEdit.Create(SemanticEditKind.Update, f1, f2)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 9061, 9099);

                diff2.EmitResult.Diagnostics.Verify();
                DynAbs.Tracing.TraceSender.TraceExitMethod(23104, 6700, 9110);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7229_7306(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7229, 7306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7321_7345(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7321, 7345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7373_7450(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7373, 7450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7465_7489(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7465, 7489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7517_7594(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7517, 7594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7609_7633(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7609, 7633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_7706_7717()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 7706, 7717);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_7719_7745(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ToMetadataReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7719, 7745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7669_7798(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7669, 7798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7832_7861(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                newSource)
                {
                    var return_v = compilation.WithSource(newSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7832, 7861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_7885_7896()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 7885, 7896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_7898_7924(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ToMetadataReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7898, 7924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7832_7927(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.WithReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7832, 7927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7961_7990(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                newSource)
                {
                    var return_v = compilation.WithSource(newSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7961, 7990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_8014_8025()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 8014, 8025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_8027_8053(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ToMetadataReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8027, 8053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_7961_8056(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.WithReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 7961, 8056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_8082_8112(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8082, 8112);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_8136_8166(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8136, 8166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_8190_8220(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8190, 8220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_8246_8289(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8246, 8289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_8313_8356(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8313, 8356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_8380_8423(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8380, 8423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_23104_8450_8504(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8450, 8504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_8537_8597(Microsoft.CodeAnalysis.ModuleMetadata
                module, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
                debugInformationProvider)
                {
                    var return_v = EmitBaseline.CreateInitialBaseline(module, debugInformationProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8537, 8597);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                f_23104_8702_8777(Microsoft.CodeAnalysis.Emit.SemanticEdit
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8702, 8777);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_23104_8626_8778(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits)
                {
                    var return_v = compilation.EmitDifference(baseline, edits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8626, 8778);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_8907_8927(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param)
                {
                    var return_v = this_param.NextGeneration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 8907, 8927);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                f_23104_8946_9043(Microsoft.CodeAnalysis.Emit.SemanticEdit
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8946, 9043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_23104_8861_9044(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits)
                {
                    var return_v = compilation.EmitDifference(baseline, edits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 8861, 9044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23104, 6700, 9110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 6700, 9110);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void DependencyVersionWildcards_Compilation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23104, 9122, 10395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 9304, 9508);

                f_23104_9304_9507(this, "1.0.0.*", f_23104_9381_9410(1, 0, 2000, 1001), f_23104_9429_9458(1, 0, 2000, 1001), f_23104_9477_9506(1, 0, 2000, 1002));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 9524, 9728);

                f_23104_9524_9727(this, "1.0.0.*", f_23104_9601_9630(1, 0, 2000, 1001), f_23104_9649_9678(1, 0, 2000, 1002), f_23104_9697_9726(1, 0, 2000, 1002));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 9744, 9948);

                f_23104_9744_9947(this, "1.0.0.*", f_23104_9821_9850(1, 0, 2000, 1003), f_23104_9869_9898(1, 0, 2000, 1002), f_23104_9917_9946(1, 0, 2000, 1001));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 9964, 10166);

                f_23104_9964_10165(this, "1.0.*", f_23104_10039_10068(1, 0, 2000, 1001), f_23104_10087_10116(1, 0, 2000, 1002), f_23104_10135_10164(1, 0, 2000, 1003));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 10182, 10384);

                f_23104_10182_10383(this, "1.0.*", f_23104_10257_10286(1, 0, 2000, 1001), f_23104_10305_10334(1, 0, 2000, 1005), f_23104_10353_10382(1, 0, 2000, 1002));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23104, 9122, 10395);

                System.Version
                f_23104_9381_9410(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9381, 9410);
                    return return_v;
                }


                System.Version
                f_23104_9429_9458(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9429, 9458);
                    return return_v;
                }


                System.Version
                f_23104_9477_9506(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9477, 9506);
                    return return_v;
                }


                int
                f_23104_9304_9507(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, string
                sourceVersion, System.Version
                version0, System.Version
                version1, System.Version
                version2)
                {
                    this_param.TestDependencyVersionWildcards(sourceVersion, version0, version1, version2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9304, 9507);
                    return 0;
                }


                System.Version
                f_23104_9601_9630(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9601, 9630);
                    return return_v;
                }


                System.Version
                f_23104_9649_9678(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9649, 9678);
                    return return_v;
                }


                System.Version
                f_23104_9697_9726(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9697, 9726);
                    return return_v;
                }


                int
                f_23104_9524_9727(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, string
                sourceVersion, System.Version
                version0, System.Version
                version1, System.Version
                version2)
                {
                    this_param.TestDependencyVersionWildcards(sourceVersion, version0, version1, version2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9524, 9727);
                    return 0;
                }


                System.Version
                f_23104_9821_9850(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9821, 9850);
                    return return_v;
                }


                System.Version
                f_23104_9869_9898(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9869, 9898);
                    return return_v;
                }


                System.Version
                f_23104_9917_9946(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9917, 9946);
                    return return_v;
                }


                int
                f_23104_9744_9947(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, string
                sourceVersion, System.Version
                version0, System.Version
                version1, System.Version
                version2)
                {
                    this_param.TestDependencyVersionWildcards(sourceVersion, version0, version1, version2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9744, 9947);
                    return 0;
                }


                System.Version
                f_23104_10039_10068(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 10039, 10068);
                    return return_v;
                }


                System.Version
                f_23104_10087_10116(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 10087, 10116);
                    return return_v;
                }


                System.Version
                f_23104_10135_10164(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 10135, 10164);
                    return return_v;
                }


                int
                f_23104_9964_10165(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, string
                sourceVersion, System.Version
                version0, System.Version
                version1, System.Version
                version2)
                {
                    this_param.TestDependencyVersionWildcards(sourceVersion, version0, version1, version2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 9964, 10165);
                    return 0;
                }


                System.Version
                f_23104_10257_10286(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 10257, 10286);
                    return return_v;
                }


                System.Version
                f_23104_10305_10334(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 10305, 10334);
                    return return_v;
                }


                System.Version
                f_23104_10353_10382(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 10353, 10382);
                    return return_v;
                }


                int
                f_23104_10182_10383(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, string
                sourceVersion, System.Version
                version0, System.Version
                version1, System.Version
                version2)
                {
                    this_param.TestDependencyVersionWildcards(sourceVersion, version0, version1, version2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 10182, 10383);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23104, 9122, 10395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 9122, 10395);
            }
        }

        private void TestDependencyVersionWildcards(string sourceVersion, Version version0, Version version1, Version version2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23104, 10407, 13930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 10551, 10666);

                string
                srcLib = $@"
[assembly: System.Reflection.AssemblyVersion(""{sourceVersion}"")]

public class D {{ }}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 10682, 10763);

                string
                src0 = @"
class C 
{ 
    public static int F(D a) { return 1; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 10777, 10858);

                string
                src1 = @"
class C 
{ 
    public static int F(D a) { return 2; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 10872, 10997);

                string
                src2 = @"
class C 
{ 
    public static int F(D a) { return 3; }
    public static int G(D a) { return 4; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11011, 11100);

                var
                lib0 = f_23104_11022_11099(srcLib, assemblyName: "Lib", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11116, 11215);

                ((SourceAssemblySymbol)f_23104_11139_11152(lib0)).lazyAssemblyIdentity = f_23104_11177_11214("Lib", version0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11229, 11254);

                f_23104_11229_11253(lib0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11270, 11359);

                var
                lib1 = f_23104_11281_11358(srcLib, assemblyName: "Lib", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11373, 11472);

                ((SourceAssemblySymbol)f_23104_11396_11409(lib1)).lazyAssemblyIdentity = f_23104_11434_11471("Lib", version1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11486, 11511);

                f_23104_11486_11510(lib1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11527, 11616);

                var
                lib2 = f_23104_11538_11615(srcLib, assemblyName: "Lib", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11630, 11729);

                ((SourceAssemblySymbol)f_23104_11653_11666(lib2)).lazyAssemblyIdentity = f_23104_11691_11728("Lib", version2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11745, 11770);

                f_23104_11745_11769(
                            lib2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11786, 11935);

                var
                compilation0 = f_23104_11805_11934(src0, new[] { f_23104_11842_11853(), f_23104_11855_11881(lib0) }, assemblyName: "C", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 11949, 12064);

                var
                compilation1 = f_23104_11968_12063(f_23104_11968_11997(compilation0, src1), new[] { f_23104_12021_12032(), f_23104_12034_12060(lib1) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12078, 12193);

                var
                compilation2 = f_23104_12097_12192(f_23104_12097_12126(compilation1, src2), new[] { f_23104_12150_12161(), f_23104_12163_12189(lib2) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12209, 12249);

                var
                v0 = f_23104_12218_12248(this, compilation0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12263, 12303);

                var
                v1 = f_23104_12272_12302(this, compilation1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12317, 12357);

                var
                v2 = f_23104_12326_12356(this, compilation2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12373, 12426);

                var
                f0 = f_23104_12382_12425(compilation0, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12440, 12493);

                var
                f1 = f_23104_12449_12492(compilation1, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12507, 12560);

                var
                f2 = f_23104_12516_12559(compilation2, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12574, 12627);

                var
                g2 = f_23104_12583_12626(compilation2, "C.G")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12643, 12708);

                var
                md0 = f_23104_12653_12707(v0.EmittedAssemblyData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12722, 12801);

                var
                generation0 = f_23104_12740_12800(md0, EmptyLocalsProvider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12817, 12982);

                var
                diff1 = f_23104_12829_12981(compilation1, generation0, f_23104_12905_12980(SemanticEdit.Create(SemanticEditKind.Update, f0, f1)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 12998, 13271);

                var
                diff2 = f_23104_13010_13270(compilation2, f_23104_13056_13076(diff1), f_23104_13095_13269(SemanticEdit.Create(SemanticEditKind.Update, f1, f2), SemanticEdit.Create(SemanticEditKind.Insert, null, g2)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 13287, 13317);

                var
                md1 = f_23104_13297_13316(diff1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 13331, 13361);

                var
                md2 = f_23104_13341_13360(diff2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 13377, 13466);

                var
                aggReader = f_23104_13393_13465(f_23104_13422_13440(md0), md1.Reader, md2.Reader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 13555, 13919);

                f_23104_13555_13918(this, aggReader, new[]
                            {
                "mscorlib, 4.0.0.0",
                "Lib, " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_23104_13677_13707(f_23104_13677_13699(f_23104_13677_13690(lib0)))).ToString(),23104,13677,13707),
                "mscorlib, 4.0.0.0",
                "Lib, " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_23104_13774_13804(f_23104_13774_13796(f_23104_13774_13787(lib0)))).ToString(),23104,13774,13804),
                "mscorlib, 4.0.0.0",
                "Lib, " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_23104_13871_13901(f_23104_13871_13893(f_23104_13871_13884(lib0)))).ToString(),23104,13871,13901),
            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(23104, 10407, 13930);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_11022_11099(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11022, 11099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23104_11139_11152(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 11139, 11152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_23104_11177_11214(string
                name, System.Version
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11177, 11214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_11229_11253(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11229, 11253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_11281_11358(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11281, 11358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23104_11396_11409(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 11396, 11409);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_23104_11434_11471(string
                name, System.Version
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11434, 11471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_11486_11510(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11486, 11510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_11538_11615(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11538, 11615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23104_11653_11666(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 11653, 11666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_23104_11691_11728(string
                name, System.Version
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11691, 11728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_11745_11769(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11745, 11769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_11842_11853()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 11842, 11853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_11855_11881(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ToMetadataReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11855, 11881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_11805_11934(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11805, 11934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_11968_11997(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                newSource)
                {
                    var return_v = compilation.WithSource(newSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11968, 11997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_12021_12032()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 12021, 12032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_12034_12060(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ToMetadataReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12034, 12060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_11968_12063(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.WithReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 11968, 12063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_12097_12126(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                newSource)
                {
                    var return_v = compilation.WithSource(newSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12097, 12126);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_12150_12161()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 12150, 12161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_12163_12189(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ToMetadataReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12163, 12189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_12097_12192(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.WithReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12097, 12192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_12218_12248(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12218, 12248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_12272_12302(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12272, 12302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_12326_12356(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12326, 12356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_12382_12425(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12382, 12425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_12449_12492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12449, 12492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_12516_12559(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12516, 12559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_12583_12626(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12583, 12626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_23104_12653_12707(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12653, 12707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_12740_12800(Microsoft.CodeAnalysis.ModuleMetadata
                module, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
                debugInformationProvider)
                {
                    var return_v = EmitBaseline.CreateInitialBaseline(module, debugInformationProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12740, 12800);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                f_23104_12905_12980(Microsoft.CodeAnalysis.Emit.SemanticEdit
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12905, 12980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_23104_12829_12981(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits)
                {
                    var return_v = compilation.EmitDifference(baseline, edits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 12829, 12981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_13056_13076(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param)
                {
                    var return_v = this_param.NextGeneration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13056, 13076);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                f_23104_13095_13269(Microsoft.CodeAnalysis.Emit.SemanticEdit
                item1, Microsoft.CodeAnalysis.Emit.SemanticEdit
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 13095, 13269);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_23104_13010_13270(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits)
                {
                    var return_v = compilation.EmitDifference(baseline, edits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 13010, 13270);
                    return return_v;
                }


                Roslyn.Test.Utilities.PinnedMetadata
                f_23104_13297_13316(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param)
                {
                    var return_v = this_param.GetMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 13297, 13316);
                    return return_v;
                }


                Roslyn.Test.Utilities.PinnedMetadata
                f_23104_13341_13360(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param)
                {
                    var return_v = this_param.GetMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 13341, 13360);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_23104_13422_13440(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13422, 13440);
                    return return_v;
                }


                Roslyn.Test.MetadataUtilities.AggregatedMetadataReader
                f_23104_13393_13465(params System.Reflection.Metadata.MetadataReader[]
                readers)
                {
                    var return_v = new Roslyn.Test.MetadataUtilities.AggregatedMetadataReader(readers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 13393, 13465);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23104_13677_13690(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13677, 13690);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_23104_13677_13699(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13677, 13699);
                    return return_v;
                }


                System.Version
                f_23104_13677_13707(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13677, 13707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23104_13774_13787(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13774, 13787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_23104_13774_13796(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13774, 13796);
                    return return_v;
                }


                System.Version
                f_23104_13774_13804(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13774, 13804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23104_13871_13884(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13871, 13884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_23104_13871_13893(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13871, 13893);
                    return return_v;
                }


                System.Version
                f_23104_13871_13901(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 13871, 13901);
                    return return_v;
                }


                int
                f_23104_13555_13918(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Roslyn.Test.MetadataUtilities.AggregatedMetadataReader
                reader, string[]
                expected)
                {
                    this_param.VerifyAssemblyReferences(reader, expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 13555, 13918);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23104, 10407, 13930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 10407, 13930);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void DependencyVersionWildcards_Metadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23104, 13942, 17241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 14121, 14223);

                string
                srcLib = @"
[assembly: System.Reflection.AssemblyVersion(""1.0.*"")]

public class D { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 14239, 14320);

                string
                src0 = @"
class C 
{ 
    public static int F(D a) { return 1; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 14334, 14415);

                string
                src1 = @"
class C 
{ 
    public static int F(D a) { return 2; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 14429, 14554);

                string
                src2 = @"
class C 
{ 
    public static int F(D a) { return 3; }
    public static int G(D a) { return 4; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 14568, 14657);

                var
                lib0 = f_23104_14579_14656(srcLib, assemblyName: "Lib", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 14671, 14791);

                ((SourceAssemblySymbol)f_23104_14694_14707(lib0)).lazyAssemblyIdentity = f_23104_14732_14790("Lib", f_23104_14760_14789(1, 0, 2000, 1001));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 14805, 14830);

                f_23104_14805_14829(lib0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 14846, 14935);

                var
                lib1 = f_23104_14857_14934(srcLib, assemblyName: "Lib", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 14949, 15069);

                ((SourceAssemblySymbol)f_23104_14972_14985(lib1)).lazyAssemblyIdentity = f_23104_15010_15068("Lib", f_23104_15038_15067(1, 0, 2000, 1002));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15083, 15108);

                f_23104_15083_15107(lib1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15124, 15213);

                var
                lib2 = f_23104_15135_15212(srcLib, assemblyName: "Lib", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15227, 15347);

                ((SourceAssemblySymbol)f_23104_15250_15263(lib2)).lazyAssemblyIdentity = f_23104_15288_15346("Lib", f_23104_15316_15345(1, 0, 2000, 1003));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15361, 15386);

                f_23104_15361_15385(lib2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15402, 15552);

                var
                compilation0 = f_23104_15421_15551(src0, new[] { f_23104_15458_15469(), f_23104_15471_15498(lib0) }, assemblyName: "C", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15566, 15682);

                var
                compilation1 = f_23104_15585_15681(f_23104_15585_15614(compilation0, src1), new[] { f_23104_15638_15649(), f_23104_15651_15678(lib1) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15696, 15812);

                var
                compilation2 = f_23104_15715_15811(f_23104_15715_15744(compilation1, src2), new[] { f_23104_15768_15779(), f_23104_15781_15808(lib2) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15828, 15868);

                var
                v0 = f_23104_15837_15867(this, compilation0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15882, 15922);

                var
                v1 = f_23104_15891_15921(this, compilation1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15936, 15976);

                var
                v2 = f_23104_15945_15975(this, compilation2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 15992, 16045);

                var
                f0 = f_23104_16001_16044(compilation0, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 16059, 16112);

                var
                f1 = f_23104_16068_16111(compilation1, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 16126, 16179);

                var
                f2 = f_23104_16135_16178(compilation2, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 16193, 16246);

                var
                g2 = f_23104_16202_16245(compilation2, "C.G")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 16262, 16327);

                var
                md0 = f_23104_16272_16326(v0.EmittedAssemblyData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 16341, 16420);

                var
                generation0 = f_23104_16359_16419(md0, EmptyLocalsProvider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 16436, 16601);

                var
                diff1 = f_23104_16448_16600(compilation1, generation0, f_23104_16524_16599(SemanticEdit.Create(SemanticEditKind.Update, f0, f1)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 16617, 17230);

                diff1.EmitResult.Diagnostics.Verify(f_23104_16935_17228(f_23104_16935_16978(ErrorCode.ERR_ModuleEmitFailure), "C", f_23104_17019_17227(f_23104_17033_17116(), "Lib, Version=1.0.2000.1001, Culture=neutral, PublicKeyToken=null", "1.0.2000.1002")));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23104, 13942, 17241);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_14579_14656(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 14579, 14656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23104_14694_14707(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 14694, 14707);
                    return return_v;
                }


                System.Version
                f_23104_14760_14789(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 14760, 14789);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_23104_14732_14790(string
                name, System.Version
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 14732, 14790);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_14805_14829(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 14805, 14829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_14857_14934(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 14857, 14934);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23104_14972_14985(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 14972, 14985);
                    return return_v;
                }


                System.Version
                f_23104_15038_15067(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15038, 15067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_23104_15010_15068(string
                name, System.Version
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15010, 15068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_15083_15107(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15083, 15107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_15135_15212(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15135, 15212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_23104_15250_15263(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 15250, 15263);
                    return return_v;
                }


                System.Version
                f_23104_15316_15345(int
                major, int
                minor, int
                build, int
                revision)
                {
                    var return_v = new System.Version(major, minor, build, revision);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15316, 15345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_23104_15288_15346(string
                name, System.Version
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name, version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15288, 15346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_15361_15385(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15361, 15385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_15458_15469()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 15458, 15469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_15471_15498(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15471, 15498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_15421_15551(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15421, 15551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_15585_15614(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                newSource)
                {
                    var return_v = compilation.WithSource(newSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15585, 15614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_15638_15649()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 15638, 15649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_15651_15678(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15651, 15678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_15585_15681(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.WithReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15585, 15681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_15715_15744(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                newSource)
                {
                    var return_v = compilation.WithSource(newSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15715, 15744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_15768_15779()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 15768, 15779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_15781_15808(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                comp)
                {
                    var return_v = comp.EmitToImageReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15781, 15808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_15715_15811(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.WithReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15715, 15811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_15837_15867(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15837, 15867);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_15891_15921(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15891, 15921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_15945_15975(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 15945, 15975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_16001_16044(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16001, 16044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_16068_16111(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16068, 16111);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_16135_16178(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16135, 16178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_16202_16245(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16202, 16245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_23104_16272_16326(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16272, 16326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_16359_16419(Microsoft.CodeAnalysis.ModuleMetadata
                module, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
                debugInformationProvider)
                {
                    var return_v = EmitBaseline.CreateInitialBaseline(module, debugInformationProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16359, 16419);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                f_23104_16524_16599(Microsoft.CodeAnalysis.Emit.SemanticEdit
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16524, 16599);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_23104_16448_16600(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits)
                {
                    var return_v = compilation.EmitDifference(baseline, edits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16448, 16600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23104_16935_16978(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16935, 16978);
                    return return_v;
                }


                string
                f_23104_17033_17116()
                {
                    var return_v = CodeAnalysisResources.ChangingVersionOfAssemblyReferenceIsNotAllowedDuringDebugging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 17033, 17116);
                    return return_v;
                }


                string
                f_23104_17019_17227(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 17019, 17227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23104_16935_17228(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 16935, 17228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23104, 13942, 17241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 13942, 17241);
            }
        }

        [WorkItem(9004, "https://github.com/dotnet/roslyn/issues/9004")]
        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void DependencyVersionWildcardsCollisions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23104, 17253, 20492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 17507, 17613);

                string
                srcLib01 = @"
[assembly: System.Reflection.AssemblyVersion(""1.0.0.1"")]

public class D { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 17627, 17733);

                string
                srcLib02 = @"
[assembly: System.Reflection.AssemblyVersion(""1.0.0.2"")]

public class D { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 17749, 17855);

                string
                srcLib11 = @"
[assembly: System.Reflection.AssemblyVersion(""1.0.1.1"")]

public class D { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 17869, 17975);

                string
                srcLib12 = @"
[assembly: System.Reflection.AssemblyVersion(""1.0.1.2"")]

public class D { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 17991, 18115);

                string
                src0 = @"
extern alias L0;
extern alias L1;

class C 
{ 
    public static int F(L0::D a, L1::D b) => 1;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 18129, 18253);

                string
                src1 = @"
extern alias L0;
extern alias L1;

class C 
{ 
    public static int F(L0::D a, L1::D b) => 2;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 18267, 18370);

                var
                lib01 = f_23104_18279_18369(f_23104_18279_18349(srcLib01, assemblyName: "Lib", options: s_signedDll))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 18384, 18451);

                var
                ref01 = f_23104_18396_18450(lib01, f_23104_18422_18449("L0"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 18467, 18570);

                var
                lib02 = f_23104_18479_18569(f_23104_18479_18549(srcLib02, assemblyName: "Lib", options: s_signedDll))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 18584, 18651);

                var
                ref02 = f_23104_18596_18650(lib02, f_23104_18622_18649("L0"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 18667, 18770);

                var
                lib11 = f_23104_18679_18769(f_23104_18679_18749(srcLib11, assemblyName: "Lib", options: s_signedDll))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 18784, 18851);

                var
                ref11 = f_23104_18796_18850(lib11, f_23104_18822_18849("L1"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 18867, 18970);

                var
                lib12 = f_23104_18879_18969(f_23104_18879_18949(srcLib12, assemblyName: "Lib", options: s_signedDll))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 18984, 19051);

                var
                ref12 = f_23104_18996_19050(lib12, f_23104_19022_19049("L1"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 19067, 19202);

                var
                compilation0 = f_23104_19086_19201(src0, new[] { f_23104_19123_19134(), ref01, ref11 }, assemblyName: "C", options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 19216, 19317);

                var
                compilation1 = f_23104_19235_19316(f_23104_19235_19264(compilation0, src1), new[] { f_23104_19288_19299(), ref02, ref12 })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 19333, 19373);

                var
                v0 = f_23104_19342_19372(this, compilation0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 19389, 19442);

                var
                f0 = f_23104_19398_19441(compilation0, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 19456, 19509);

                var
                f1 = f_23104_19465_19508(compilation1, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 19525, 19590);

                var
                md0 = f_23104_19535_19589(v0.EmittedAssemblyData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 19604, 19683);

                var
                generation0 = f_23104_19622_19682(md0, EmptyLocalsProvider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 19699, 19864);

                var
                diff1 = f_23104_19711_19863(compilation1, generation0, f_23104_19787_19862(SemanticEdit.Create(SemanticEditKind.Update, f0, f1)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 19880, 20481);

                diff1.EmitResult.Diagnostics.Verify(f_23104_20186_20479(f_23104_20186_20229(ErrorCode.ERR_ModuleEmitFailure), "C", f_23104_20270_20478(f_23104_20284_20367(), "Lib, Version=1.0.0.1, Culture=neutral, PublicKeyToken=ce65828c82a341f2", "1.0.0.2")));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23104, 17253, 20492);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_18279_18349(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18279, 18349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_18279_18369(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18279, 18369);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_23104_18422_18449(string
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18422, 18449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_18396_18450(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.Collections.Immutable.ImmutableArray<string>
                aliases)
                {
                    var return_v = this_param.ToMetadataReference(aliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18396, 18450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_18479_18549(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18479, 18549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_18479_18569(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18479, 18569);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_23104_18622_18649(string
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18622, 18649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_18596_18650(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.Collections.Immutable.ImmutableArray<string>
                aliases)
                {
                    var return_v = this_param.ToMetadataReference(aliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18596, 18650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_18679_18749(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18679, 18749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_18679_18769(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18679, 18769);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_23104_18822_18849(string
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18822, 18849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_18796_18850(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.Collections.Immutable.ImmutableArray<string>
                aliases)
                {
                    var return_v = this_param.ToMetadataReference(aliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18796, 18850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_18879_18949(string
                source, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18879, 18949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_18879_18969(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18879, 18969);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_23104_19022_19049(string
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19022, 19049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CompilationReference
                f_23104_18996_19050(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.Collections.Immutable.ImmutableArray<string>
                aliases)
                {
                    var return_v = this_param.ToMetadataReference(aliases);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 18996, 19050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_19123_19134()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 19123, 19134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_19086_19201(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, string
                assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateEmptyCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, assemblyName: assemblyName, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19086, 19201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_19235_19264(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                newSource)
                {
                    var return_v = compilation.WithSource(newSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19235, 19264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23104_19288_19299()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 19288, 19299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_19235_19316(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, params Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = this_param.WithReferences(references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19235, 19316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_19342_19372(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19342, 19372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_19398_19441(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19398, 19441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_19465_19508(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19465, 19508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_23104_19535_19589(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19535, 19589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_19622_19682(Microsoft.CodeAnalysis.ModuleMetadata
                module, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
                debugInformationProvider)
                {
                    var return_v = EmitBaseline.CreateInitialBaseline(module, debugInformationProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19622, 19682);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                f_23104_19787_19862(Microsoft.CodeAnalysis.Emit.SemanticEdit
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19787, 19862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_23104_19711_19863(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits)
                {
                    var return_v = compilation.EmitDifference(baseline, edits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 19711, 19863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23104_20186_20229(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 20186, 20229);
                    return return_v;
                }


                string
                f_23104_20284_20367()
                {
                    var return_v = CodeAnalysisResources.ChangingVersionOfAssemblyReferenceIsNotAllowedDuringDebugging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 20284, 20367);
                    return return_v;
                }


                string
                f_23104_20270_20478(string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 20270, 20478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23104_20186_20479(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 20186, 20479);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23104, 17253, 20492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 17253, 20492);
            }
        }

        private void VerifyAssemblyReferences(AggregatedMetadataReader reader, string[] expected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23104, 20504, 20751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 20618, 20740);

                f_23104_20618_20739(expected, f_23104_20643_20738(f_23104_20643_20673(reader), aref => $"{reader.GetString(aref.Name)}, {aref.Version}"));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23104, 20504, 20751);

                System.Collections.Generic.IEnumerable<System.Reflection.Metadata.AssemblyReference>
                f_23104_20643_20673(Roslyn.Test.MetadataUtilities.AggregatedMetadataReader
                this_param)
                {
                    var return_v = this_param.GetAssemblyReferences();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 20643, 20673);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_23104_20643_20738(System.Collections.Generic.IEnumerable<System.Reflection.Metadata.AssemblyReference>
                source, System.Func<System.Reflection.Metadata.AssemblyReference, string>
                selector)
                {
                    var return_v = source.Select<System.Reflection.Metadata.AssemblyReference, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 20643, 20738);
                    return return_v;
                }


                bool
                f_23104_20618_20739(string[]
                expected, System.Collections.Generic.IEnumerable<string>
                actual)
                {
                    var return_v = AssertEx.Equal((System.Collections.Generic.IEnumerable<string>)expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 20618, 20739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23104, 20504, 20751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 20504, 20751);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        [WorkItem(202017, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/202017")]
        public void CurrentCompilationVersionWildcards()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23104, 20763, 25873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 21033, 21303);

                var
                source0 = f_23104_21047_21302(@"
using System;
[assembly: System.Reflection.AssemblyVersion(""1.0.0.*"")]

class C
{
    static void M()
    {
        new Action(<N:0>() => { Console.WriteLine(1); }</N:0>).Invoke();
    }

    static void F()
    {
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 21317, 21661);

                var
                source1 = f_23104_21331_21660(@"
using System;
[assembly: System.Reflection.AssemblyVersion(""1.0.0.*"")]

class C
{
    static void M()
    {
        new Action(<N:0>() => { Console.WriteLine(1); }</N:0>).Invoke();
        new Action(<N:1>() => { Console.WriteLine(2); }</N:1>).Invoke();
    }

    static void F()
    {
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 21675, 22050);

                var
                source2 = f_23104_21689_22049(@"
using System;
[assembly: System.Reflection.AssemblyVersion(""1.0.0.*"")]

class C
{
    static void M()
    {
        new Action(<N:0>() => { Console.WriteLine(1); }</N:0>).Invoke();
        new Action(<N:1>() => { Console.WriteLine(2); }</N:1>).Invoke();
    }

    static void F()
    {
        Console.WriteLine(1);
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 22064, 22587);

                var
                source3 = f_23104_22078_22586(@"
using System;
[assembly: System.Reflection.AssemblyVersion(""1.0.0.*"")]

class C
{
    static void M()
    {
        new Action(<N:0>() => { Console.WriteLine(1); }</N:0>).Invoke();
        new Action(<N:1>() => { Console.WriteLine(2); }</N:1>).Invoke();
        new Action(<N:2>() => { Console.WriteLine(3); }</N:2>).Invoke();
        new Action(<N:3>() => { Console.WriteLine(4); }</N:3>).Invoke();
    }

    static void F()
    {
        Console.WriteLine(1);
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 22603, 22704);

                var
                options = f_23104_22617_22703(ComSafeDebugDll, TestResources.TestKeys.PublicKey_ce65828c82a341f2)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 22720, 22845);

                var
                compilation0 = f_23104_22739_22844(source0.Tree, options: f_23104_22780_22843(options, f_23104_22809_22842(2016, 1, 1, 1, 0, 0)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 22859, 22994);

                var
                compilation1 = f_23104_22878_22993(f_23104_22878_22915(compilation0, source1.Tree), f_23104_22928_22992(options, f_23104_22957_22991(2016, 1, 1, 1, 0, 10)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23008, 23143);

                var
                compilation2 = f_23104_23027_23142(f_23104_23027_23064(compilation1, source2.Tree), f_23104_23077_23141(options, f_23104_23106_23140(2016, 1, 1, 1, 0, 20)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23157, 23292);

                var
                compilation3 = f_23104_23176_23291(f_23104_23176_23213(compilation2, source3.Tree), f_23104_23226_23290(options, f_23104_23255_23289(2016, 1, 1, 1, 0, 30)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23308, 23377);

                var
                v0 = f_23104_23317_23376(this, compilation0, verify: Verification.Passes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23391, 23456);

                var
                md0 = f_23104_23401_23455(v0.EmittedAssemblyData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23470, 23503);

                var
                reader0 = f_23104_23484_23502(md0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23519, 23572);

                var
                m0 = f_23104_23528_23571(compilation0, "C.M")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23586, 23639);

                var
                m1 = f_23104_23595_23638(compilation1, "C.M")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23653, 23706);

                var
                m2 = f_23104_23662_23705(compilation2, "C.M")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23720, 23773);

                var
                m3 = f_23104_23729_23772(compilation3, "C.M")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23789, 23842);

                var
                f1 = f_23104_23798_23841(compilation1, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23856, 23909);

                var
                f2 = f_23104_23865_23908(compilation2, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 23925, 24027);

                var
                generation0 = f_23104_23943_24026(md0, f_23104_23983_24003(v0).GetEncMethodDebugInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 24123, 24361);

                var
                diff1 = f_23104_24135_24360(compilation1, generation0, f_23104_24211_24359(SemanticEdit.Create(SemanticEditKind.Update, m0, m1, f_23104_24286_24327(source0, source1), preserveLocalVariables: true)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 24377, 24512);

                f_23104_24377_24511(
                            diff1, "C: {<>c}", "C.<>c: {<>9__0_0, <>9__0_1#1, <M>b__0_0, <M>b__0_1#1}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 24619, 24866);

                var
                diff2 = f_23104_24631_24865(compilation2, f_23104_24677_24697(diff1), f_23104_24716_24864(SemanticEdit.Create(SemanticEditKind.Update, f1, f2, f_23104_24791_24832(source1, source2), preserveLocalVariables: true)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 24882, 25017);

                f_23104_24882_25016(
                            diff2, "C: {<>c}", "C.<>c: {<>9__0_0, <>9__0_1#1, <M>b__0_0, <M>b__0_1#1}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 25414, 25661);

                var
                diff3 = f_23104_25426_25660(compilation3, f_23104_25472_25492(diff2), f_23104_25511_25659(SemanticEdit.Create(SemanticEditKind.Update, m2, m3, f_23104_25586_25627(source2, source3), preserveLocalVariables: true)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 25677, 25862);

                f_23104_25677_25861(
                            diff3, "C: {<>c}", "C.<>c: {<>9__0_0, <>9__0_1#1, <>9__0_2#3, <>9__0_3#3, <M>b__0_0, <M>b__0_1#1, <M>b__0_2#3, <M>b__0_3#3}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23104, 20763, 25873);

                Roslyn.Test.Utilities.SourceWithMarkedNodes
                f_23104_21047_21302(string
                markedSource)
                {
                    var return_v = MarkedSource(markedSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 21047, 21302);
                    return return_v;
                }


                Roslyn.Test.Utilities.SourceWithMarkedNodes
                f_23104_21331_21660(string
                markedSource)
                {
                    var return_v = MarkedSource(markedSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 21331, 21660);
                    return return_v;
                }


                Roslyn.Test.Utilities.SourceWithMarkedNodes
                f_23104_21689_22049(string
                markedSource)
                {
                    var return_v = MarkedSource(markedSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 21689, 22049);
                    return return_v;
                }


                Roslyn.Test.Utilities.SourceWithMarkedNodes
                f_23104_22078_22586(string
                markedSource)
                {
                    var return_v = MarkedSource(markedSource);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 22078, 22586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23104_22617_22703(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                value)
                {
                    var return_v = this_param.WithCryptoPublicKey(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 22617, 22703);
                    return return_v;
                }


                System.DateTime
                f_23104_22809_22842(int
                year, int
                month, int
                day, int
                hour, int
                minute, int
                second)
                {
                    var return_v = new System.DateTime(year, month, day, hour, minute, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 22809, 22842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23104_22780_22843(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, System.DateTime
                value)
                {
                    var return_v = this_param.WithCurrentLocalTime(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 22780, 22843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_22739_22844(Microsoft.CodeAnalysis.SyntaxTree
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 22739, 22844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_22878_22915(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SyntaxTree
                newTree)
                {
                    var return_v = compilation.WithSource(newTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 22878, 22915);
                    return return_v;
                }


                System.DateTime
                f_23104_22957_22991(int
                year, int
                month, int
                day, int
                hour, int
                minute, int
                second)
                {
                    var return_v = new System.DateTime(year, month, day, hour, minute, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 22957, 22991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23104_22928_22992(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, System.DateTime
                value)
                {
                    var return_v = this_param.WithCurrentLocalTime(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 22928, 22992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_22878_22993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.WithOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 22878, 22993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_23027_23064(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SyntaxTree
                newTree)
                {
                    var return_v = compilation.WithSource(newTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23027, 23064);
                    return return_v;
                }


                System.DateTime
                f_23104_23106_23140(int
                year, int
                month, int
                day, int
                hour, int
                minute, int
                second)
                {
                    var return_v = new System.DateTime(year, month, day, hour, minute, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23106, 23140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23104_23077_23141(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, System.DateTime
                value)
                {
                    var return_v = this_param.WithCurrentLocalTime(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23077, 23141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_23027_23142(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.WithOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23027, 23142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_23176_23213(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SyntaxTree
                newTree)
                {
                    var return_v = compilation.WithSource(newTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23176, 23213);
                    return return_v;
                }


                System.DateTime
                f_23104_23255_23289(int
                year, int
                month, int
                day, int
                hour, int
                minute, int
                second)
                {
                    var return_v = new System.DateTime(year, month, day, hour, minute, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23255, 23289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23104_23226_23290(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, System.DateTime
                value)
                {
                    var return_v = this_param.WithCurrentLocalTime(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23226, 23290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23104_23176_23291(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.WithOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23176, 23291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23104_23317_23376(Microsoft.CodeAnalysis.CSharp.EditAndContinue.UnitTests.AssemblyReferencesTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, verify: verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23317, 23376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_23104_23401_23455(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23401, 23455);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_23104_23484_23502(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 23484, 23502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_23528_23571(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23528, 23571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_23595_23638(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23595, 23638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_23662_23705(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23662, 23705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_23729_23772(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23729, 23772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_23798_23841(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23798, 23841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23104_23865_23908(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23865, 23908);
                    return return_v;
                }


                Microsoft.DiaSymReader.ISymUnmanagedReader3
                f_23104_23983_24003(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier)
                {
                    var return_v = verifier.CreateSymReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23983, 24003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_23943_24026(Microsoft.CodeAnalysis.ModuleMetadata
                module, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
                debugInformationProvider)
                {
                    var return_v = EmitBaseline.CreateInitialBaseline(module, debugInformationProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 23943, 24026);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
                f_23104_24286_24327(Roslyn.Test.Utilities.SourceWithMarkedNodes
                source0, Roslyn.Test.Utilities.SourceWithMarkedNodes
                source1)
                {
                    var return_v = GetSyntaxMapFromMarkers(source0, source1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 24286, 24327);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                f_23104_24211_24359(Microsoft.CodeAnalysis.Emit.SemanticEdit
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 24211, 24359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_23104_24135_24360(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits)
                {
                    var return_v = compilation.EmitDifference(baseline, edits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 24135, 24360);
                    return return_v;
                }


                int
                f_23104_24377_24511(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param, params string[]
                expectedSynthesizedTypesAndMemberCounts)
                {
                    this_param.VerifySynthesizedMembers(expectedSynthesizedTypesAndMemberCounts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 24377, 24511);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_24677_24697(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param)
                {
                    var return_v = this_param.NextGeneration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 24677, 24697);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
                f_23104_24791_24832(Roslyn.Test.Utilities.SourceWithMarkedNodes
                source0, Roslyn.Test.Utilities.SourceWithMarkedNodes
                source1)
                {
                    var return_v = GetSyntaxMapFromMarkers(source0, source1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 24791, 24832);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                f_23104_24716_24864(Microsoft.CodeAnalysis.Emit.SemanticEdit
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 24716, 24864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_23104_24631_24865(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits)
                {
                    var return_v = compilation.EmitDifference(baseline, edits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 24631, 24865);
                    return return_v;
                }


                int
                f_23104_24882_25016(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param, params string[]
                expectedSynthesizedTypesAndMemberCounts)
                {
                    this_param.VerifySynthesizedMembers(expectedSynthesizedTypesAndMemberCounts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 24882, 25016);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_23104_25472_25492(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param)
                {
                    var return_v = this_param.NextGeneration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23104, 25472, 25492);
                    return return_v;
                }


                System.Func<Microsoft.CodeAnalysis.SyntaxNode, Microsoft.CodeAnalysis.SyntaxNode>
                f_23104_25586_25627(Roslyn.Test.Utilities.SourceWithMarkedNodes
                source0, Roslyn.Test.Utilities.SourceWithMarkedNodes
                source1)
                {
                    var return_v = GetSyntaxMapFromMarkers(source0, source1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 25586, 25627);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                f_23104_25511_25659(Microsoft.CodeAnalysis.Emit.SemanticEdit
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 25511, 25659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                f_23104_25426_25660(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Emit.EmitBaseline
                baseline, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.SemanticEdit>
                edits)
                {
                    var return_v = compilation.EmitDifference(baseline, edits);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 25426, 25660);
                    return return_v;
                }


                int
                f_23104_25677_25861(Microsoft.CodeAnalysis.Test.Utilities.CompilationDifference
                this_param, params string[]
                expectedSynthesizedTypesAndMemberCounts)
                {
                    this_param.VerifySynthesizedMembers(expectedSynthesizedTypesAndMemberCounts);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 25677, 25861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23104, 20763, 25873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 20763, 25873);
            }
        }

        public AssemblyReferencesTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(23104, 871, 25880);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(23104, 871, 25880);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 871, 25880);
        }


        static AssemblyReferencesTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23104, 871, 25880);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23104, 999, 1119);
            s_signedDll = f_23104_1026_1119(TestOptions.ReleaseDll, TestResources.TestKeys.PublicKey_ce65828c82a341f2); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23104, 871, 25880);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23104, 871, 25880);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23104, 871, 25880);

        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        f_23104_1026_1119(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        this_param, System.Collections.Immutable.ImmutableArray<byte>
        value)
        {
            var return_v = this_param.WithCryptoPublicKey(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(23104, 1026, 1119);
            return return_v;
        }

    }
}
