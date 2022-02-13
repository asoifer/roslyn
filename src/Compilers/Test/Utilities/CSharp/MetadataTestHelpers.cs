// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    internal static class MetadataTestHelpers
    {
        internal static NamedTypeSymbol GetCorLibType(this ModuleSymbol module, SpecialType typeId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21012, 501, 684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 617, 673);

                return f_21012_624_672(f_21012_624_649(module), typeId);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21012, 501, 684);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21012, 501, 684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21012, 501, 684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblySymbol CorLibrary(this ModuleSymbol module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21012, 696, 843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 788, 832);

                return f_21012_795_831(f_21012_795_820(module));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21012, 696, 843);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21012, 696, 843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21012, 696, 843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblySymbol GetSymbolForReference(MetadataReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21012, 855, 1034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 961, 1023);

                return f_21012_968_1019(mrefs: new[] { reference })[0];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21012, 855, 1034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21012, 855, 1034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21012, 855, 1034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblySymbol[] GetSymbolsForReferences(params MetadataReference[] mrefs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21012, 1046, 1265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 1161, 1254);

                return f_21012_1168_1253(compilations: null, bytes: null, mrefs: mrefs, options: null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21012, 1046, 1265);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21012, 1046, 1265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21012, 1046, 1265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblySymbol[] GetSymbolsForReferences(MetadataReference[] mrefs, Compilation[] compilations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21012, 1277, 1555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 1413, 1544);

                return f_21012_1420_1543(mrefs: f_21012_1469_1542(f_21012_1469_1532(mrefs, f_21012_1482_1531(compilations, c => c.ToMetadataReference()))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21012, 1277, 1555);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21012, 1277, 1555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21012, 1277, 1555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblySymbol[] GetSymbolsForReferences(
                    CSharpCompilation[] compilations = null,
                    byte[][] bytes = null,
                    MetadataReference[] mrefs = null,
                    CSharpCompilationOptions options = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21012, 1567, 2718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 1840, 1881);

                var
                refs = f_21012_1851_1880()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 1897, 2105) || true) && (compilations != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21012, 1897, 2105);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 1955, 2090);
                        foreach (var c in f_21012_1973_1985_I(compilations))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21012, 1955, 2090);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 2027, 2071);

                            f_21012_2027_2070(refs, f_21012_2036_2069(c));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21012, 1955, 2090);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(21012, 1, 136);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(21012, 1, 136);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21012, 1897, 2105);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 2121, 2338) || true) && (bytes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21012, 2121, 2338);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 2172, 2323);
                        foreach (var b in f_21012_2190_2195_I(bytes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(21012, 2172, 2323);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 2237, 2304);

                            f_21012_2237_2303(refs, f_21012_2246_2302(f_21012_2280_2301(b)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(21012, 2172, 2323);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(21012, 1, 152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(21012, 1, 152);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21012, 2121, 2338);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 2354, 2441) || true) && (mrefs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21012, 2354, 2441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 2405, 2426);

                    f_21012_2405_2425(refs, mrefs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21012, 2354, 2441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 2457, 2609);

                var
                tc1 = f_21012_2467_2608(assemblyName: "Dummy", options: options ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions?>(21012, 2524, 2557) ?? TestOptions.ReleaseDll), syntaxTrees: new SyntaxTree[0], references: refs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21012, 2625, 2707);

                return f_21012_2632_2706((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from @ref in refs select tc1.GetReferencedAssemblySymbol(@ref), 21012, 2633, 2695)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21012, 1567, 2718);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21012, 1567, 2718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21012, 1567, 2718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MetadataTestHelpers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21012, 443, 2725);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21012, 443, 2725);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21012, 443, 2725);
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_21012_624_649(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21012, 624, 649);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_21012_624_672(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 624, 672);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_21012_795_820(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        this_param)
        {
            var return_v = this_param.ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21012, 795, 820);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_21012_795_831(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.CorLibrary;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21012, 795, 831);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
        f_21012_968_1019(params Microsoft.CodeAnalysis.MetadataReference[]
        mrefs)
        {
            var return_v = GetSymbolsForReferences(mrefs: mrefs);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 968, 1019);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
        f_21012_1168_1253(Microsoft.CodeAnalysis.CSharp.CSharpCompilation[]
        compilations, byte[][]
        bytes, Microsoft.CodeAnalysis.MetadataReference[]
        mrefs, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        options)
        {
            var return_v = GetSymbolsForReferences(compilations: compilations, bytes: bytes, mrefs: mrefs, options: options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 1168, 1253);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CompilationReference>
        f_21012_1482_1531(Microsoft.CodeAnalysis.Compilation[]
        source, System.Func<Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.CompilationReference>
        selector)
        {
            var return_v = source.Select<Microsoft.CodeAnalysis.Compilation, Microsoft.CodeAnalysis.CompilationReference>(selector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 1482, 1531);
            return return_v;
        }


        static System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
        f_21012_1469_1532(Microsoft.CodeAnalysis.MetadataReference[]
        first, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CompilationReference>
        second)
        {
            var return_v = first.Concat<Microsoft.CodeAnalysis.MetadataReference>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)second);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 1469, 1532);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference[]
        f_21012_1469_1542(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
        source)
        {
            var return_v = source.ToArray<Microsoft.CodeAnalysis.MetadataReference>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 1469, 1542);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
        f_21012_1420_1543(params Microsoft.CodeAnalysis.MetadataReference[]
        mrefs)
        {
            var return_v = GetSymbolsForReferences(mrefs: mrefs);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 1420, 1543);
            return return_v;
        }


        static System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
        f_21012_1851_1880()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 1851, 1880);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
        f_21012_2036_2069(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference(compilation);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 2036, 2069);
            return return_v;
        }


        static int
        f_21012_2027_2070(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilationReference
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.MetadataReference)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 2027, 2070);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation[]
        f_21012_1973_1985_I(Microsoft.CodeAnalysis.CSharp.CSharpCompilation[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 1973, 1985);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<byte>
        f_21012_2280_2301(byte[]
        items)
        {
            var return_v = items.AsImmutableOrNull<byte>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 2280, 2301);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_21012_2246_2302(System.Collections.Immutable.ImmutableArray<byte>
        peImage)
        {
            var return_v = MetadataReference.CreateFromImage(peImage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 2246, 2302);
            return return_v;
        }


        static int
        f_21012_2237_2303(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
        this_param, Microsoft.CodeAnalysis.PortableExecutableReference
        item)
        {
            this_param.Add((Microsoft.CodeAnalysis.MetadataReference)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 2237, 2303);
            return 0;
        }


        static byte[][]
        f_21012_2190_2195_I(byte[][]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 2190, 2195);
            return return_v;
        }


        static int
        f_21012_2405_2425(System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
        this_param, Microsoft.CodeAnalysis.MetadataReference[]
        collection)
        {
            this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 2405, 2425);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_21012_2467_2608(string
        assemblyName, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
        options, Microsoft.CodeAnalysis.SyntaxTree[]
        syntaxTrees, System.Collections.Generic.List<Microsoft.CodeAnalysis.MetadataReference>
        references)
        {
            var return_v = CSharpCompilation.Create(assemblyName: assemblyName, options: options, syntaxTrees: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 2467, 2608);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol[]
        f_21012_2632_2706(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
        source)
        {
            var return_v = source.ToArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21012, 2632, 2706);
            return return_v;
        }

    }
}
