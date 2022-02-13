// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.VisualBasic;
using Roslyn.Test.Utilities;
using Microsoft.CodeAnalysis.Test.Utilities;
using static Microsoft.CodeAnalysis.CodeGen.CompilationTestData;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests
{
    public static class BasicCompilationUtils
    {
        public static MetadataReference CompileToMetadata(string source, string assemblyName = null, IEnumerable<MetadataReference> references = null, Verification verify = Verification.Passes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21000, 582, 1189);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 792, 907) || true) && (references == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21000, 792, 907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 848, 892);

                    references = new[] { f_21000_869_889() };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21000, 792, 907);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 921, 1003);

                var
                compilation = f_21000_939_1002(source, assemblyName, references)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 1017, 1093);

                var
                verifier = f_21000_1032_1092(f_21000_1032_1040(), compilation, verify: verify)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 1107, 1178);

                return f_21000_1114_1177(verifier.EmittedAssemblyData);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21000, 582, 1189);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21000, 582, 1189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21000, 582, 1189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static VisualBasicCompilation CreateCompilationWithMscorlib(string source, string assemblyName, IEnumerable<MetadataReference> references)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(21000, 1201, 1808);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 1372, 1485) || true) && (assemblyName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(21000, 1372, 1485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 1430, 1470);

                    assemblyName = f_21000_1445_1469();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(21000, 1372, 1485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 1499, 1550);

                var
                tree = f_21000_1510_1549(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 1564, 1695);

                var
                options = f_21000_1578_1694(OutputKind.DynamicallyLinkedLibrary, optimizationLevel: OptimizationLevel.Release)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 1709, 1797);

                return f_21000_1716_1796(assemblyName, new[] { tree }, references, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(21000, 1201, 1808);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21000, 1201, 1808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21000, 1201, 1808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BasicTestBase s_instance;

        private static BasicTestBase Instance
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(21000, 1910, 1961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 1913, 1961);
                    return s_instance ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.UnitTests.BasicCompilationUtils.BasicTestBase>(21000, 1913, 1961) ?? (s_instance = f_21000_1941_1960())); DynAbs.Tracing.TraceSender.TraceExitMethod(21000, 1910, 1961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21000, 1910, 1961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21000, 1910, 1961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
        private sealed class BasicTestBase : CommonTestBase
        {
            internal override string VisualizeRealIL(IModuleSymbol peModule, MethodData methodData, IReadOnlyDictionary<int, string> markers, bool areLocalsZeroed)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(21000, 2050, 2285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 2234, 2270);

                    throw f_21000_2240_2269();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(21000, 2050, 2285);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(21000, 2050, 2285);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21000, 2050, 2285);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public BasicTestBase()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(21000, 1974, 2296);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(21000, 1974, 2296);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21000, 1974, 2296);
            }


            static BasicTestBase()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21000, 1974, 2296);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21000, 1974, 2296);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21000, 1974, 2296);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(21000, 1974, 2296);

            System.NotImplementedException
            f_21000_2240_2269()
            {
                var return_v = new System.NotImplementedException();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(21000, 2240, 2269);
                return return_v;
            }

        }

        static BasicCompilationUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(21000, 524, 2303);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(21000, 1849, 1859);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(21000, 524, 2303);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(21000, 524, 2303);
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_21000_869_889()
        {
            var return_v = TestBase.MscorlibRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21000, 869, 889);
            return return_v;
        }


        static Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
        f_21000_939_1002(string
        source, string?
        assemblyName, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
        references)
        {
            var return_v = CreateCompilationWithMscorlib(source, assemblyName, references);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21000, 939, 1002);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.UnitTests.BasicCompilationUtils.BasicTestBase
        f_21000_1032_1040()
        {
            var return_v = Instance;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(21000, 1032, 1040);
            return return_v;
        }


        static Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
        f_21000_1032_1092(Microsoft.CodeAnalysis.CSharp.UnitTests.BasicCompilationUtils.BasicTestBase
        this_param, Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
        compilation, Microsoft.CodeAnalysis.Test.Utilities.Verification
        verify)
        {
            var return_v = this_param.CompileAndVerifyCommon((Microsoft.CodeAnalysis.Compilation)compilation, verify: verify);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21000, 1032, 1092);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PortableExecutableReference
        f_21000_1114_1177(System.Collections.Immutable.ImmutableArray<byte>
        peImage)
        {
            var return_v = MetadataReference.CreateFromImage(peImage);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21000, 1114, 1177);
            return return_v;
        }


        static string
        f_21000_1445_1469()
        {
            var return_v = TestBase.GetUniqueName();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21000, 1445, 1469);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SyntaxTree
        f_21000_1510_1549(string
        text)
        {
            var return_v = VisualBasicSyntaxTree.ParseText(text);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21000, 1510, 1549);
            return return_v;
        }


        static Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions
        f_21000_1578_1694(Microsoft.CodeAnalysis.OutputKind
        outputKind, Microsoft.CodeAnalysis.OptimizationLevel
        optimizationLevel)
        {
            var return_v = new Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions(outputKind, optimizationLevel: optimizationLevel);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21000, 1578, 1694);
            return return_v;
        }


        static Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation
        f_21000_1716_1796(string
        assemblyName, Microsoft.CodeAnalysis.SyntaxTree[]
        syntaxTrees, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>
        references, Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions
        options)
        {
            var return_v = VisualBasicCompilation.Create(assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, references, options);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21000, 1716, 1796);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.UnitTests.BasicCompilationUtils.BasicTestBase
        f_21000_1941_1960()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.UnitTests.BasicCompilationUtils.BasicTestBase();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(21000, 1941, 1960);
            return return_v;
        }

    }
}
