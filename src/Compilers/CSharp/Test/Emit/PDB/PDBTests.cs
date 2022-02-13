// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Text;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Test.Utilities;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Test.Utilities;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Test.PdbUtilities;
using Roslyn.Test.Utilities;
using Xunit;
using Microsoft.DiaSymReader;

namespace Microsoft.CodeAnalysis.CSharp.UnitTests.PDB
{
    public class PDBTests : CSharpPDBTestBase
    {
        private static readonly MetadataReference[] s_valueTupleRefs;

        [Fact]
        public void EmitDebugInfoForSourceTextWithoutEncoding1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 1030, 2327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 1127, 1216);

                var
                tree1 = f_23129_1139_1215("class A { }", encoding: null, path: "Foo.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 1230, 1313);

                var
                tree2 = f_23129_1242_1312("class B { }", encoding: null, path: "")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 1327, 1433);

                var
                tree3 = f_23129_1339_1432(f_23129_1369_1415("class C { }", encoding: null), path: "Bar.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 1447, 1545);

                var
                tree4 = f_23129_1459_1544("class D { }", encoding: f_23129_1514_1527(), path: "Baz.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 1561, 1706);

                var
                comp = f_23129_1572_1705("Compilation", new[] { tree1, tree2, tree3, tree4 }, new[] { f_23129_1658_1669() }, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 1722, 1796);

                var
                result = f_23129_1735_1795(comp, f_23129_1745_1763(), pdbStream: f_23129_1776_1794())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 1810, 2265);

                result.Diagnostics.Verify(f_23129_1967_2049(f_23129_1967_2030(ErrorCode.ERR_EncodinglessSyntaxTree, "class A { }"), 1, 1), f_23129_2181_2263(f_23129_2181_2244(ErrorCode.ERR_EncodinglessSyntaxTree, "class C { }"), 1, 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 2281, 2316);

                f_23129_2281_2315(f_23129_2300_2314(result));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 1030, 2327);

                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_1139_1215(string
                text, System.Text.Encoding?
                encoding, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, encoding: encoding, path: path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1139, 1215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_1242_1312(string
                text, System.Text.Encoding?
                encoding, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, encoding: encoding, path: path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1242, 1312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_23129_1369_1415(string
                text, System.Text.Encoding?
                encoding)
                {
                    var return_v = SourceText.From(text, encoding: encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1369, 1415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_1339_1432(Microsoft.CodeAnalysis.Text.SourceText
                text, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, path: path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1339, 1432);
                    return return_v;
                }


                System.Text.Encoding
                f_23129_1514_1527()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 1514, 1527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_1459_1544(string
                text, System.Text.Encoding
                encoding, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, encoding: encoding, path: path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1459, 1544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_1658_1669()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 1658, 1669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_1572_1705(string
                assemblyName, Microsoft.CodeAnalysis.SyntaxTree[]
                syntaxTrees, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CSharpCompilation.Create(assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1572, 1705);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_1745_1763()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1745, 1763);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_1776_1794()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1776, 1794);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_1735_1795(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.MemoryStream
                pdbStream)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, pdbStream: (System.IO.Stream)pdbStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1735, 1795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_1967_2030(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1967, 2030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_1967_2049(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 1967, 2049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_2181_2244(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2181, 2244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_2181_2263(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2181, 2263);
                    return return_v;
                }


                bool
                f_23129_2300_2314(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 2300, 2314);
                    return return_v;
                }


                bool
                f_23129_2281_2315(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2281, 2315);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 1030, 2327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 1030, 2327);
            }
        }

        [Fact]
        public void EmitDebugInfoForSourceTextWithoutEncoding2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 2339, 4328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 2436, 2557);

                var
                tree1 = f_23129_2448_2556("class A { public void F() { } }", encoding: f_23129_2523_2539(), path: "Foo.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 2571, 2674);

                var
                tree2 = f_23129_2583_2673("class B { public void F() { } }", encoding: null, path: "")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 2688, 2822);

                var
                tree3 = f_23129_2700_2821("class C { public void F() { } }", encoding: f_23129_2775_2804(true, false), path: "Bar.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 2836, 2978);

                var
                tree4 = f_23129_2848_2977(f_23129_2878_2960("class D { public void F() { } }", f_23129_2929_2959(false, false)), path: "Baz.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 2994, 3139);

                var
                comp = f_23129_3005_3138("Compilation", new[] { tree1, tree2, tree3, tree4 }, new[] { f_23129_3091_3102() }, options: TestOptions.ReleaseDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 3155, 3229);

                var
                result = f_23129_3168_3228(comp, f_23129_3178_3196(), pdbStream: f_23129_3209_3227())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 3243, 3271);

                result.Diagnostics.Verify();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 3285, 3319);

                f_23129_3285_3318(f_23129_3303_3317(result));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 3335, 3452);

                var
                hash1 = f_23129_3347_3441(f_23129_3385_3440(f_23129_3385_3401(), f_23129_3423_3439(tree1))).ToArray()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 3466, 3596);

                var
                hash3 = f_23129_3478_3585(f_23129_3516_3584(f_23129_3516_3545(true, false), f_23129_3567_3583(tree3))).ToArray()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 3610, 3741);

                var
                hash4 = f_23129_3622_3730(f_23129_3660_3729(f_23129_3660_3690(false, false), f_23129_3712_3728(tree4))).ToArray()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 3757, 4317);

                f_23129_3757_4316(
                            comp, @"
<symbols>
  <files>
    <file id=""1"" name=""Foo.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""" + f_23129_3891_3919(hash1) + @""" />
    <file id=""2"" name="""" language=""C#"" />
    <file id=""3"" name=""Bar.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""" + f_23129_4073_4101(hash3) + @""" />
    <file id=""4"" name=""Baz.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""" + f_23129_4206_4234(hash4) + @""" />
  </files>
</symbols>", options: PdbValidationOptions.ExcludeMethods);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 2339, 4328);

                System.Text.Encoding
                f_23129_2523_2539()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 2523, 2539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_2448_2556(string
                text, System.Text.Encoding
                encoding, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, encoding: encoding, path: path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2448, 2556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_2583_2673(string
                text, System.Text.Encoding?
                encoding, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, encoding: encoding, path: path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2583, 2673);
                    return return_v;
                }


                System.Text.UTF8Encoding
                f_23129_2775_2804(bool
                encoderShouldEmitUTF8Identifier, bool
                throwOnInvalidBytes)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier, throwOnInvalidBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2775, 2804);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_2700_2821(string
                text, System.Text.UTF8Encoding
                encoding, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, encoding: (System.Text.Encoding)encoding, path: path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2700, 2821);
                    return return_v;
                }


                System.Text.UTF8Encoding
                f_23129_2929_2959(bool
                encoderShouldEmitUTF8Identifier, bool
                throwOnInvalidBytes)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier, throwOnInvalidBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2929, 2959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.SourceText
                f_23129_2878_2960(string
                text, System.Text.UTF8Encoding
                encoding)
                {
                    var return_v = SourceText.From(text, (System.Text.Encoding)encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2878, 2960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_2848_2977(Microsoft.CodeAnalysis.Text.SourceText
                text, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, path: path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 2848, 2977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_3091_3102()
                {
                    var return_v = MscorlibRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 3091, 3102);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_3005_3138(string
                assemblyName, Microsoft.CodeAnalysis.SyntaxTree[]
                syntaxTrees, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CSharpCompilation.Create(assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3005, 3138);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_3178_3196()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3178, 3196);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_3209_3227()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3209, 3227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_3168_3228(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.MemoryStream
                pdbStream)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, pdbStream: (System.IO.Stream)pdbStream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3168, 3228);
                    return return_v;
                }


                bool
                f_23129_3303_3317(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 3303, 3317);
                    return return_v;
                }


                bool
                f_23129_3285_3318(bool
                condition)
                {
                    var return_v = CustomAssert.True(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3285, 3318);
                    return return_v;
                }


                System.Text.Encoding
                f_23129_3385_3401()
                {
                    var return_v = Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 3385, 3401);
                    return return_v;
                }


                string
                f_23129_3423_3439(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3423, 3439);
                    return return_v;
                }


                byte[]
                f_23129_3385_3440(System.Text.Encoding
                encoding, string
                text)
                {
                    var return_v = encoding.GetBytesWithPreamble(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3385, 3440);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_23129_3347_3441(byte[]
                bytes)
                {
                    var return_v = CryptographicHashProvider.ComputeSha1(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3347, 3441);
                    return return_v;
                }


                System.Text.UTF8Encoding
                f_23129_3516_3545(bool
                encoderShouldEmitUTF8Identifier, bool
                throwOnInvalidBytes)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier, throwOnInvalidBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3516, 3545);
                    return return_v;
                }


                string
                f_23129_3567_3583(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3567, 3583);
                    return return_v;
                }


                byte[]
                f_23129_3516_3584(System.Text.UTF8Encoding
                encoding, string
                text)
                {
                    var return_v = encoding.GetBytesWithPreamble(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3516, 3584);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_23129_3478_3585(byte[]
                bytes)
                {
                    var return_v = CryptographicHashProvider.ComputeSha1(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3478, 3585);
                    return return_v;
                }


                System.Text.UTF8Encoding
                f_23129_3660_3690(bool
                encoderShouldEmitUTF8Identifier, bool
                throwOnInvalidBytes)
                {
                    var return_v = new System.Text.UTF8Encoding(encoderShouldEmitUTF8Identifier, throwOnInvalidBytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3660, 3690);
                    return return_v;
                }


                string
                f_23129_3712_3728(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3712, 3728);
                    return return_v;
                }


                byte[]
                f_23129_3660_3729(System.Text.UTF8Encoding
                encoding, string
                text)
                {
                    var return_v = encoding.GetBytesWithPreamble(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3660, 3729);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_23129_3622_3730(byte[]
                bytes)
                {
                    var return_v = CryptographicHashProvider.ComputeSha1(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3622, 3730);
                    return return_v;
                }


                string
                f_23129_3891_3919(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3891, 3919);
                    return return_v;
                }


                string
                f_23129_4073_4101(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 4073, 4101);
                    return return_v;
                }


                string
                f_23129_4206_4234(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 4206, 4234);
                    return return_v;
                }


                bool
                f_23129_3757_4316(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 3757, 4316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 2339, 4328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 2339, 4328);
            }
        }

        [WorkItem(846584, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/846584")]
        [ConditionalFact(typeof(WindowsOnly))]
        public void RelativePathForExternalSource_Sha1_Windows()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 4340, 6197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 4561, 4876);

                var
                text1 = f_23129_4573_4875(@"
#pragma checksum ""..\Test2.cs"" ""{406ea660-64cf-4c82-b6f0-42d48172a799}"" ""BA8CBEA9C2EFABD90D53B616FB80A081""

public class C
{
    public void InitializeComponent() {
        #line 4 ""..\Test2.cs""
        InitializeComponent();
        #line default
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 4892, 5106);

                var
                compilation = f_23129_4910_5105(new[] { f_23129_4954_4998(text1, @"C:\Folder1\Folder2\Test1.cs") }, options: f_23129_5028_5104(TestOptions.DebugDll, f_23129_5077_5103()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 5122, 6186);

                f_23129_5122_6185(
                            compilation, @"
<symbols>
  <files>
    <file id=""1"" name=""C:\Folder1\Folder2\Test1.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""40-A6-20-02-2E-60-7D-4F-2D-A8-F4-A6-ED-2E-0E-49-8D-9F-D7-EB"" />
    <file id=""2"" name=""C:\Folder1\Test2.cs"" language=""C#"" checksumAlgorithm=""406ea660-64cf-4c82-b6f0-42d48172a799"" checksum=""BA-8C-BE-A9-C2-EF-AB-D9-0D-53-B6-16-FB-80-A0-81"" />
  </files>
  <methods>
    <method containingType=""C"" name=""InitializeComponent"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""39"" endLine=""6"" endColumn=""40"" document=""1"" />
        <entry offset=""0x1"" startLine=""4"" startColumn=""9"" endLine=""4"" endColumn=""31"" document=""2"" />
        <entry offset=""0x8"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 4340, 6197);

                string
                f_23129_4573_4875(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 4573, 4875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_4954_4998(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 4954, 4998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceFileResolver
                f_23129_5077_5103()
                {
                    var return_v = SourceFileResolver.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 5077, 5103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23129_5028_5104(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.SourceFileResolver
                resolver)
                {
                    var return_v = this_param.WithSourceReferenceResolver((Microsoft.CodeAnalysis.SourceReferenceResolver)resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 5028, 5104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_4910_5105(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 4910, 5105);
                    return return_v;
                }


                bool
                f_23129_5122_6185(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 5122, 6185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 4340, 6197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 4340, 6197);
            }
        }

        [WorkItem(846584, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/846584")]
        [ConditionalFact(typeof(UnixLikeOnly))]
        public void RelativePathForExternalSource_Sha1_Unix()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 6209, 8058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 6428, 6743);

                var
                text1 = f_23129_6440_6742(@"
#pragma checksum ""../Test2.cs"" ""{406ea660-64cf-4c82-b6f0-42d48172a799}"" ""BA8CBEA9C2EFABD90D53B616FB80A081""

public class C
{
    public void InitializeComponent() {
        #line 4 ""../Test2.cs""
        InitializeComponent();
        #line default
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 6759, 6971);

                var
                compilation = f_23129_6777_6970(new[] { f_23129_6821_6863(text1, @"/Folder1/Folder2/Test1.cs") }, options: f_23129_6893_6969(TestOptions.DebugDll, f_23129_6942_6968()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 6987, 8047);

                f_23129_6987_8046(
                            compilation, @"
<symbols>
  <files>
    <file id=""1"" name=""/Folder1/Folder2/Test1.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""82-08-07-BA-BA-52-02-D8-1D-1F-7C-E7-95-8A-6C-04-64-FF-50-31"" />
    <file id=""2"" name=""/Folder1/Test2.cs"" language=""C#"" checksumAlgorithm=""406ea660-64cf-4c82-b6f0-42d48172a799"" checksum=""BA-8C-BE-A9-C2-EF-AB-D9-0D-53-B6-16-FB-80-A0-81"" />
  </files>
  <methods>
    <method containingType=""C"" name=""InitializeComponent"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""39"" endLine=""6"" endColumn=""40"" document=""1"" />
        <entry offset=""0x1"" startLine=""4"" startColumn=""9"" endLine=""4"" endColumn=""31"" document=""2"" />
        <entry offset=""0x8"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 6209, 8058);

                string
                f_23129_6440_6742(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 6440, 6742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_6821_6863(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 6821, 6863);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceFileResolver
                f_23129_6942_6968()
                {
                    var return_v = SourceFileResolver.Default;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 6942, 6968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23129_6893_6969(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, Microsoft.CodeAnalysis.SourceFileResolver
                resolver)
                {
                    var return_v = this_param.WithSourceReferenceResolver((Microsoft.CodeAnalysis.SourceReferenceResolver)resolver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 6893, 6969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_6777_6970(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 6777, 6970);
                    return return_v;
                }


                bool
                f_23129_6987_8046(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 6987, 8046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 6209, 8058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 6209, 8058);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void SymWriterErrors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 8070, 9369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 8229, 8261);

                var
                source0 =
                @"class C
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 8275, 8351);

                var
                compilation = f_23129_8293_8350(source0, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 8428, 9030);

                // LAFHIS: we're going to send the end invocation trace before end invocation of the object creation expression in the stmt
                //var
                //result = f_23129_8441_9029(compilation, peStream: f_23129_8486_8504(), metadataPEStream: null, pdbStream: f_23129_8575_8593(), xmlDocumentationStream: null, cancellationToken: default, win32Resources: null, manifestResources: null, options: null, debugEntryPoint: null, sourceLinkStream: null, embeddedTexts: null, testData: new CompilationTestData() { SymWriterFactory = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (_ => new MockSymUnmanagedWriter()), 23129, 8946, 9028) })
                //;
                var
                result = f_23129_8441_9029(compilation, peStream: f_23129_8486_8504(), metadataPEStream: null, pdbStream: f_23129_8575_8593(), xmlDocumentationStream: null, cancellationToken: default, win32Resources: null, manifestResources: null, options: null, debugEntryPoint: null, sourceLinkStream: null, embeddedTexts: null, testData: new CompilationTestData() { SymWriterFactory = (_ => new MockSymUnmanagedWriter()) })
                ;
                
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 9046, 9307);

                result.Diagnostics.Verify(f_23129_9209_9305(f_23129_9209_9251(ErrorCode.FTL_DebugEmitFailure), "MockSymUnmanagedWriter error message"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 9323, 9358);

                f_23129_9323_9357(f_23129_9342_9356(result));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 8070, 9369);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_8293_8350(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 8293, 8350);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_8486_8504()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 8486, 8504);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_8575_8593()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 8575, 8593);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_8441_9029(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.Stream?
                metadataPEStream, System.IO.MemoryStream
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.Threading.CancellationToken
                cancellationToken, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions?
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData)
                {
                    var return_v = this_param.Emit(peStream: (System.IO.Stream)peStream, metadataPEStream: metadataPEStream, pdbStream: (System.IO.Stream)pdbStream, xmlDocumentationStream: xmlDocumentationStream, cancellationToken: cancellationToken, win32Resources: win32Resources, manifestResources: manifestResources, options: options, debugEntryPoint: debugEntryPoint, sourceLinkStream: sourceLinkStream, embeddedTexts: embeddedTexts, testData: testData);
                    // LAFHIS
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 8946, 9028);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 8441, 9029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_9209_9251(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 9209, 9251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_9209_9305(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 9209, 9305);
                    return return_v;
                }


                bool
                f_23129_9342_9356(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 9342, 9356);
                    return return_v;
                }


                bool
                f_23129_9323_9357(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 9323, 9357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 8070, 9369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 8070, 9369);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void SymWriterErrors2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 9381, 10766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 9541, 9573);

                var
                source0 =
                @"class C
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 9587, 9663);

                var
                compilation = f_23129_9605_9662(source0, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 9740, 10347);

                var
                result = f_23129_9753_10346(compilation, peStream: f_23129_9798_9816(), metadataPEStream: null, pdbStream: f_23129_9887_9905(), xmlDocumentationStream: null, cancellationToken: default, win32Resources: null, manifestResources: null, options: null, debugEntryPoint: null, sourceLinkStream: null, embeddedTexts: null, testData: new CompilationTestData() { SymWriterFactory = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => SymWriterTestUtilities.ThrowingFactory, 23129, 10258, 10345) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 10363, 10704);

                result.Diagnostics.Verify(f_23129_10560_10702(f_23129_10560_10602(ErrorCode.FTL_DebugEmitFailure), f_23129_10617_10701(f_23129_10631_10686(), "<lib name>")));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 10720, 10755);

                f_23129_10720_10754(f_23129_10739_10753(result));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 9381, 10766);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_9605_9662(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 9605, 9662);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_9798_9816()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 9798, 9816);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_9887_9905()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 9887, 9905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_9753_10346(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.Stream?
                metadataPEStream, System.IO.MemoryStream
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.Threading.CancellationToken
                cancellationToken, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions?
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData)
                {
                    var return_v = this_param.Emit(peStream: (System.IO.Stream)peStream, metadataPEStream: metadataPEStream, pdbStream: (System.IO.Stream)pdbStream, xmlDocumentationStream: xmlDocumentationStream, cancellationToken: cancellationToken, win32Resources: win32Resources, manifestResources: manifestResources, options: options, debugEntryPoint: debugEntryPoint, sourceLinkStream: sourceLinkStream, embeddedTexts: embeddedTexts, testData: testData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 9753, 10346);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_10560_10602(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 10560, 10602);
                    return return_v;
                }


                string
                f_23129_10631_10686()
                {
                    var return_v = CodeAnalysisResources.SymWriterOlderVersionThanRequired;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 10631, 10686);
                    return return_v;
                }


                string
                f_23129_10617_10701(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 10617, 10701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_10560_10702(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 10560, 10702);
                    return return_v;
                }


                bool
                f_23129_10739_10753(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 10739, 10753);
                    return return_v;
                }


                bool
                f_23129_10720_10754(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 10720, 10754);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 9381, 10766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 9381, 10766);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void SymWriterErrors3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 10778, 12183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 10938, 10970);

                var
                source0 =
                @"class C
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 10984, 11084);

                var
                compilation = f_23129_11002_11083(source0, options: f_23129_11038_11082(TestOptions.DebugDll, true))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 11161, 11768);

                var
                result = f_23129_11174_11767(compilation, peStream: f_23129_11219_11237(), metadataPEStream: null, pdbStream: f_23129_11308_11326(), xmlDocumentationStream: null, cancellationToken: default, win32Resources: null, manifestResources: null, options: null, debugEntryPoint: null, sourceLinkStream: null, embeddedTexts: null, testData: new CompilationTestData() { SymWriterFactory = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => SymWriterTestUtilities.ThrowingFactory, 23129, 11679, 11766) })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 11784, 12121);

                result.Diagnostics.Verify(f_23129_11985_12119(f_23129_11985_12027(ErrorCode.FTL_DebugEmitFailure), f_23129_12042_12118(f_23129_12056_12103(), "<lib name>")));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 12137, 12172);

                f_23129_12137_12171(f_23129_12156_12170(result));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 10778, 12183);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23129_11038_11082(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                deterministic)
                {
                    var return_v = this_param.WithDeterministic(deterministic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 11038, 11082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_11002_11083(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 11002, 11083);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_11219_11237()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 11219, 11237);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_11308_11326()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 11308, 11326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_11174_11767(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.Stream?
                metadataPEStream, System.IO.MemoryStream
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.Threading.CancellationToken
                cancellationToken, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions?
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData)
                {
                    var return_v = this_param.Emit(peStream: (System.IO.Stream)peStream, metadataPEStream: metadataPEStream, pdbStream: (System.IO.Stream)pdbStream, xmlDocumentationStream: xmlDocumentationStream, cancellationToken: cancellationToken, win32Resources: win32Resources, manifestResources: manifestResources, options: options, debugEntryPoint: debugEntryPoint, sourceLinkStream: sourceLinkStream, embeddedTexts: embeddedTexts, testData: testData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 11174, 11767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_11985_12027(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 11985, 12027);
                    return return_v;
                }


                string
                f_23129_12056_12103()
                {
                    var return_v = CodeAnalysisResources.SymWriterNotDeterministic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 12056, 12103);
                    return return_v;
                }


                string
                f_23129_12042_12118(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 12042, 12118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_11985_12119(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 11985, 12119);
                    return return_v;
                }


                bool
                f_23129_12156_12170(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 12156, 12170);
                    return return_v;
                }


                bool
                f_23129_12137_12171(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 12137, 12171);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 10778, 12183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 10778, 12183);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void SymWriterErrors4()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 12195, 13407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 12355, 12387);

                var
                source0 =
                @"class C
{
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 12401, 12446);

                var
                compilation = f_23129_12419_12445(source0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 12523, 13134);

                // LAFHIS : The same as another previous case
                var
                result = f_23129_12536_13133(compilation, peStream: f_23129_12581_12599(), metadataPEStream: null, pdbStream: f_23129_12670_12688(), xmlDocumentationStream: null, cancellationToken: default, win32Resources: null, manifestResources: null, options: null, debugEntryPoint: null, sourceLinkStream: null, embeddedTexts: null, testData: new CompilationTestData() { SymWriterFactory = (_ => throw new DllNotFoundException("xxx")) })
                ;
                
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 13150, 13345);

                result.Diagnostics.Verify(f_23129_13280_13343(f_23129_13280_13322(ErrorCode.FTL_DebugEmitFailure), "xxx"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 13361, 13396);

                f_23129_13361_13395(f_23129_13380_13394(result));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 12195, 13407);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_12419_12445(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 12419, 12445);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_12581_12599()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 12581, 12599);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_12670_12688()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 12670, 12688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_12536_13133(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.Stream?
                metadataPEStream, System.IO.MemoryStream
                pdbStream, System.IO.Stream?
                xmlDocumentationStream, System.Threading.CancellationToken
                cancellationToken, System.IO.Stream?
                win32Resources, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ResourceDescription>?
                manifestResources, Microsoft.CodeAnalysis.Emit.EmitOptions?
                options, Microsoft.CodeAnalysis.IMethodSymbol?
                debugEntryPoint, System.IO.Stream?
                sourceLinkStream, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.EmbeddedText>?
                embeddedTexts, Microsoft.CodeAnalysis.CodeGen.CompilationTestData
                testData)
                {
                    var return_v = this_param.Emit(peStream: (System.IO.Stream)peStream, metadataPEStream: metadataPEStream, pdbStream: (System.IO.Stream)pdbStream, xmlDocumentationStream: xmlDocumentationStream, cancellationToken: cancellationToken, win32Resources: win32Resources, manifestResources: manifestResources, options: options, debugEntryPoint: debugEntryPoint, sourceLinkStream: sourceLinkStream, embeddedTexts: embeddedTexts, testData: testData);
                    // Lafhis
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 13041, 13132);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 12536, 13133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_13280_13322(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 13280, 13322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_13280_13343(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 13280, 13343);
                    return return_v;
                }


                bool
                f_23129_13380_13394(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 13380, 13394);
                    return return_v;
                }


                bool
                f_23129_13361_13395(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 13361, 13395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 12195, 13407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 12195, 13407);
            }
        }

        [WorkItem(1067635, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1067635")]
        [Fact]
        public void SuppressDynamicAndEncCDIForWinRT()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 13419, 18088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 13600, 13839);

                var
                source = @"
public class C
{
    public static void F()
    {
        dynamic a = 1;
        int b = 2;
        foreach (var x in new[] { 1,2,3 })
        {
            System.Console.WriteLine(a * b);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 13855, 13947);

                var
                debug = f_23129_13867_13946(source, new[] { f_23129_13901_13910() }, options: TestOptions.DebugWinMD)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 13961, 16275);

                f_23129_13961_16274(debug, @"
<symbols>
    <files>
      <file id=""1"" name="""" language=""C#"" />
    </files>
    <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""23"" document=""1"" />
        <entry offset=""0x8"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""19"" document=""1"" />
        <entry offset=""0xa"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""16"" document=""1"" />
        <entry offset=""0xb"" startLine=""8"" startColumn=""27"" endLine=""8"" endColumn=""42"" document=""1"" />
        <entry offset=""0x1f"" hidden=""true"" document=""1"" />
        <entry offset=""0x24"" startLine=""8"" startColumn=""18"" endLine=""8"" endColumn=""23"" document=""1"" />
        <entry offset=""0x29"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2a"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""45"" document=""1"" />
        <entry offset=""0xe6"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0xe7"" hidden=""true"" document=""1"" />
        <entry offset=""0xeb"" startLine=""8"" startColumn=""24"" endLine=""8"" endColumn=""26"" document=""1"" />
        <entry offset=""0xf4"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xf5"">
        <local name=""a"" il_index=""0"" il_start=""0x0"" il_end=""0xf5"" attributes=""0"" />
        <local name=""b"" il_index=""1"" il_start=""0x0"" il_end=""0xf5"" attributes=""0"" />
        <scope startOffset=""0x24"" endOffset=""0xe7"">
          <local name=""x"" il_index=""4"" il_start=""0x24"" il_end=""0xe7"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>", format: DebugInformationFormat.Pdb, options: PdbValidationOptions.SkipConversionValidation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 16291, 16387);

                var
                release = f_23129_16305_16386(source, new[] { f_23129_16339_16348() }, options: TestOptions.ReleaseWinMD)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 16401, 18077);

                f_23129_16401_18076(release, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""23"" document=""1"" />
        <entry offset=""0x7"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""19"" document=""1"" />
        <entry offset=""0x9"" startLine=""8"" startColumn=""27"" endLine=""8"" endColumn=""42"" document=""1"" />
        <entry offset=""0x1d"" hidden=""true"" document=""1"" />
        <entry offset=""0x22"" startLine=""8"" startColumn=""18"" endLine=""8"" endColumn=""23"" document=""1"" />
        <entry offset=""0x26"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""45"" document=""1"" />
        <entry offset=""0xdd"" hidden=""true"" document=""1"" />
        <entry offset=""0xe1"" startLine=""8"" startColumn=""24"" endLine=""8"" endColumn=""26"" document=""1"" />
        <entry offset=""0xea"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xeb"">
        <local name=""a"" il_index=""0"" il_start=""0x0"" il_end=""0xeb"" attributes=""0"" />
        <local name=""b"" il_index=""1"" il_start=""0x0"" il_end=""0xeb"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>", format: DebugInformationFormat.Pdb, options: PdbValidationOptions.SkipConversionValidation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 13419, 18088);

                Microsoft.CodeAnalysis.MetadataReference
                f_23129_13901_13910()
                {
                    var return_v = CSharpRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 13901, 13910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_13867_13946(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 13867, 13946);
                    return return_v;
                }


                bool
                f_23129_13961_16274(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, format: format, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 13961, 16274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_16339_16348()
                {
                    var return_v = CSharpRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 16339, 16348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_16305_16386(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 16305, 16386);
                    return return_v;
                }


                bool
                f_23129_16401_18076(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, format: format, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 16401, 18076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 13419, 18088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 13419, 18088);
            }
        }

        [WorkItem(1067635, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/1067635")]
        [Fact]
        public void SuppressTupleElementNamesCDIForWinRT()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 18100, 20168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 18285, 18387);

                var
                source =
                @"class C
{
    static void F()
    {
        (int A, int B) o = (1, 2);
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 18403, 18474);

                var
                debug = f_23129_18415_18473(source, options: TestOptions.DebugWinMD)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 18488, 19464);

                f_23129_18488_19463(debug, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""5"" startColumn=""9"" endLine=""5"" endColumn=""35"" document=""1"" />
        <entry offset=""0x9"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xa"">
        <local name=""o"" il_index=""0"" il_start=""0x0"" il_end=""0xa"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>", format: DebugInformationFormat.Pdb, options: PdbValidationOptions.SkipConversionValidation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 19480, 19555);

                var
                release = f_23129_19494_19554(source, options: TestOptions.ReleaseWinMD)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 19569, 20157);

                f_23129_19569_20156(release, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>", format: DebugInformationFormat.Pdb, options: PdbValidationOptions.SkipConversionValidation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 18100, 20168);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_18415_18473(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 18415, 18473);
                    return return_v;
                }


                bool
                f_23129_18488_19463(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, format: format, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 18488, 19463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_19494_19554(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 19494, 19554);
                    return return_v;
                }


                bool
                f_23129_19569_20156(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, format: format, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 19569, 20156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 18100, 20168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 18100, 20168);
            }
        }

        [Fact]
        public void DuplicateDocuments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 20180, 21561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 20253, 20302);

                var
                source1 = @"class C { static void F() { } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 20316, 20365);

                var
                source2 = @"class D { static void F() { } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 20381, 20419);

                var
                tree1 = f_23129_20393_20418(source1, @"foo.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 20433, 20471);

                var
                tree2 = f_23129_20445_20470(source2, @"foo.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 20487, 20540);

                var
                comp = f_23129_20498_20539(new[] { tree1, tree2 })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 20613, 21550);

                f_23129_20613_21549(
                            // the first file wins (checksum CB 22 ...)
                            comp, @"
<symbols>
  <files>
    <file id=""1"" name=""foo.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""CB-22-D8-03-D3-27-32-64-2C-BC-7D-67-5D-E3-CB-AC-D1-64-25-83"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""1"" startColumn=""29"" endLine=""1"" endColumn=""30"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""D"" name=""F"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""1"" startColumn=""29"" endLine=""1"" endColumn=""30"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 20180, 21561);

                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_20393_20418(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 20393, 20418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_20445_20470(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 20445, 20470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_20498_20539(Microsoft.CodeAnalysis.SyntaxTree[]
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 20498, 20539);
                    return return_v;
                }


                bool
                f_23129_20613_21549(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 20613, 21549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 20180, 21561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 20180, 21561);
            }
        }

        [Fact]
        public void CustomDebugEntryPoint_DLL()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 21573, 22487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 21653, 21701);

                var
                source = @"class C { static void F() { } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 21717, 21782);

                var
                c = f_23129_21725_21781(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 21796, 21837);

                var
                f = f_23129_21804_21836(c, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 21853, 22215);

                f_23129_21853_22214(
                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <entryPoint declaringType=""C"" methodName=""F"" />
  <methods/>
</symbols>", debugEntryPoint: f_23129_22051_22070(f), options: PdbValidationOptions.ExcludeScopes | PdbValidationOptions.ExcludeSequencePoints | PdbValidationOptions.ExcludeCustomDebugInformation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 22231, 22312);

                var
                peReader = f_23129_22246_22311(f_23129_22259_22310(c, debugEntryPoint: f_23129_22290_22309(f)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 22326, 22419);

                int
                peEntryPointToken = f_23129_22350_22418(f_23129_22350_22378(f_23129_22350_22368(peReader)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 22435, 22476);

                f_23129_22435_22475(0, peEntryPointToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 21573, 22487);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_21725_21781(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 21725, 21781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23129_21804_21836(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 21804, 21836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_23129_22051_22070(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 22051, 22070);
                    return return_v;
                }


                bool
                f_23129_21853_22214(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, debugEntryPoint: debugEntryPoint, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 21853, 22214);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_23129_22290_22309(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 22290, 22309);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_23129_22259_22310(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint)
                {
                    var return_v = compilation.EmitToArray(debugEntryPoint: debugEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 22259, 22310);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_23129_22246_22311(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 22246, 22311);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeaders
                f_23129_22350_22368(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.PEHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 22350, 22368);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CorHeader?
                f_23129_22350_22378(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CorHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 22350, 22378);
                    return return_v;
                }


                int
                f_23129_22350_22418(System.Reflection.PortableExecutable.CorHeader?
                this_param)
                {
                    var return_v = this_param.EntryPointTokenOrRelativeVirtualAddress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 22350, 22418);
                    return return_v;
                }


                bool
                f_23129_22435_22475(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 22435, 22475);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 21573, 22487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 21573, 22487);
            }
        }

        [Fact]
        public void CustomDebugEntryPoint_EXE()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 22499, 23656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 22579, 22665);

                var
                source = @"class M { static void Main() { } } class C { static void F<S>() { } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 22681, 22746);

                var
                c = f_23129_22689_22745(source, options: TestOptions.DebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 22760, 22801);

                var
                f = f_23129_22768_22800(c, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 22817, 23179);

                f_23129_22817_23178(
                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <entryPoint declaringType=""C"" methodName=""F"" />
  <methods/>
</symbols>", debugEntryPoint: f_23129_23015_23034(f), options: PdbValidationOptions.ExcludeScopes | PdbValidationOptions.ExcludeSequencePoints | PdbValidationOptions.ExcludeCustomDebugInformation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 23195, 23276);

                var
                peReader = f_23129_23210_23275(f_23129_23223_23274(c, debugEntryPoint: f_23129_23254_23273(f)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 23290, 23383);

                int
                peEntryPointToken = f_23129_23314_23382(f_23129_23314_23342(f_23129_23314_23332(peReader)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 23399, 23443);

                var
                mdReader = f_23129_23414_23442(peReader)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 23457, 23568);

                var
                methodDef = f_23129_23473_23567(mdReader, f_23129_23526_23566(peEntryPointToken))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 23582, 23645);

                f_23129_23582_23644("Main", f_23129_23609_23643(mdReader, methodDef.Name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 22499, 23656);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_22689_22745(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 22689, 22745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23129_22768_22800(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 22768, 22800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_23129_23015_23034(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23015, 23034);
                    return return_v;
                }


                bool
                f_23129_22817_23178(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, debugEntryPoint: debugEntryPoint, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 22817, 23178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_23129_23254_23273(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23254, 23273);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_23129_23223_23274(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint)
                {
                    var return_v = compilation.EmitToArray(debugEntryPoint: debugEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23223, 23274);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEReader
                f_23129_23210_23275(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = new System.Reflection.PortableExecutable.PEReader(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23210, 23275);
                    return return_v;
                }


                System.Reflection.PortableExecutable.PEHeaders
                f_23129_23314_23332(System.Reflection.PortableExecutable.PEReader
                this_param)
                {
                    var return_v = this_param.PEHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 23314, 23332);
                    return return_v;
                }


                System.Reflection.PortableExecutable.CorHeader?
                f_23129_23314_23342(System.Reflection.PortableExecutable.PEHeaders
                this_param)
                {
                    var return_v = this_param.CorHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 23314, 23342);
                    return return_v;
                }


                int
                f_23129_23314_23382(System.Reflection.PortableExecutable.CorHeader?
                this_param)
                {
                    var return_v = this_param.EntryPointTokenOrRelativeVirtualAddress;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 23314, 23382);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_23129_23414_23442(System.Reflection.PortableExecutable.PEReader
                peReader)
                {
                    var return_v = peReader.GetMetadataReader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23414, 23442);
                    return return_v;
                }


                System.Reflection.Metadata.Handle
                f_23129_23526_23566(int
                token)
                {
                    var return_v = MetadataTokens.Handle(token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23526, 23566);
                    return return_v;
                }


                System.Reflection.Metadata.MethodDefinition
                f_23129_23473_23567(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.Handle
                handle)
                {
                    var return_v = this_param.GetMethodDefinition((System.Reflection.Metadata.MethodDefinitionHandle)handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23473, 23567);
                    return return_v;
                }


                string
                f_23129_23609_23643(System.Reflection.Metadata.MetadataReader
                this_param, System.Reflection.Metadata.StringHandle
                handle)
                {
                    var return_v = this_param.GetString(handle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23609, 23643);
                    return return_v;
                }


                bool
                f_23129_23582_23644(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23582, 23644);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 22499, 23656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 22499, 23656);
            }
        }

        [Fact]
        public void CustomDebugEntryPoint_Errors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 23668, 26201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 23751, 23837);

                var
                source1 = @"class C { static void F() { } } class D<T> { static void G<S>() {} }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 23851, 23900);

                var
                source2 = @"class C { static void F() { } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 23916, 23983);

                var
                c1 = f_23129_23925_23982(source1, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 23997, 24064);

                var
                c2 = f_23129_24006_24063(source2, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24080, 24123);

                var
                f1 = f_23129_24089_24122(c1, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24137, 24180);

                var
                f2 = f_23129_24146_24179(c2, "C.F")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24194, 24236);

                var
                g = f_23129_24202_24235(c1, "D.G")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24250, 24293);

                var
                d = f_23129_24258_24292(c1, "D")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24307, 24332);

                f_23129_24307_24331(f1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24346, 24371);

                f_23129_24346_24370(f2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24385, 24409);

                f_23129_24385_24408(g);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24423, 24447);

                f_23129_24423_24446(d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24463, 24519);

                var
                stInt = f_23129_24475_24518(c1, SpecialType.System_Int32)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24533, 24568);

                var
                d_t_g_int = f_23129_24549_24567(g, stInt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24582, 24613);

                var
                d_int = f_23129_24594_24612(d, stInt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24627, 24676);

                var
                d_int_g = f_23129_24641_24675(d_int, "G")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24690, 24733);

                var
                d_int_g_int = f_23129_24708_24732(d_int_g, stInt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24749, 24849);

                var
                result = f_23129_24762_24848(c1, f_23129_24770_24788(), f_23129_24790_24808(), debugEntryPoint: f_23129_24827_24847(f2))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 24863, 25095);

                result.Diagnostics.Verify(f_23129_25027_25093(ErrorCode.ERR_DebugEntryPointNotSourceMethodDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 25111, 25214);

                result = f_23129_25120_25213(c1, f_23129_25128_25146(), f_23129_25148_25166(), debugEntryPoint: f_23129_25185_25212(d_t_g_int));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 25228, 25460);

                result.Diagnostics.Verify(f_23129_25392_25458(ErrorCode.ERR_DebugEntryPointNotSourceMethodDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 25476, 25577);

                result = f_23129_25485_25576(c1, f_23129_25493_25511(), f_23129_25513_25531(), debugEntryPoint: f_23129_25550_25575(d_int_g));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 25591, 25823);

                result.Diagnostics.Verify(f_23129_25755_25821(ErrorCode.ERR_DebugEntryPointNotSourceMethodDefinition));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 25839, 25944);

                result = f_23129_25848_25943(c1, f_23129_25856_25874(), f_23129_25876_25894(), debugEntryPoint: f_23129_25913_25942(d_int_g_int));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 25958, 26190);

                result.Diagnostics.Verify(f_23129_26122_26188(ErrorCode.ERR_DebugEntryPointNotSourceMethodDefinition));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 23668, 26201);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_23925_23982(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 23925, 23982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_24006_24063(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24006, 24063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23129_24089_24122(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24089, 24122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23129_24146_24179(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24146, 24179);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23129_24202_24235(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24202, 24235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23129_24258_24292(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedName)
                {
                    var return_v = compilation.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24258, 24292);
                    return return_v;
                }


                bool
                f_23129_24307_24331(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24307, 24331);
                    return return_v;
                }


                bool
                f_23129_24346_24370(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24346, 24370);
                    return return_v;
                }


                bool
                f_23129_24385_24408(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24385, 24408);
                    return return_v;
                }


                bool
                f_23129_24423_24446(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                @object)
                {
                    var return_v = CustomAssert.NotNull((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24423, 24446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23129_24475_24518(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24475, 24518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23129_24549_24567(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24549, 24567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_23129_24594_24612(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24594, 24612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23129_24641_24675(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, string
                qualifiedName)
                {
                    var return_v = symbol.GetMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(qualifiedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24641, 24675);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_23129_24708_24732(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24708, 24732);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_24770_24788()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24770, 24788);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_24790_24808()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24790, 24808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_23129_24827_24847(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24827, 24847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_24762_24848(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.MemoryStream
                pdbStream, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, (System.IO.Stream)pdbStream, debugEntryPoint: debugEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 24762, 24848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_25027_25093(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25027, 25093);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_25128_25146()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25128, 25146);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_25148_25166()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25148, 25166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_23129_25185_25212(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25185, 25212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_25120_25213(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.MemoryStream
                pdbStream, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, (System.IO.Stream)pdbStream, debugEntryPoint: debugEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25120, 25213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_25392_25458(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25392, 25458);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_25493_25511()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25493, 25511);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_25513_25531()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25513, 25531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_23129_25550_25575(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25550, 25575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_25485_25576(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.MemoryStream
                pdbStream, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, (System.IO.Stream)pdbStream, debugEntryPoint: debugEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25485, 25576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_25755_25821(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25755, 25821);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_25856_25874()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25856, 25874);
                    return return_v;
                }


                System.IO.MemoryStream
                f_23129_25876_25894()
                {
                    var return_v = new System.IO.MemoryStream();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25876, 25894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.IMethodSymbol?
                f_23129_25913_25942(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = symbol.GetPublicSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25913, 25942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_25848_25943(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.MemoryStream
                peStream, System.IO.MemoryStream
                pdbStream, Microsoft.CodeAnalysis.IMethodSymbol
                debugEntryPoint)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, (System.IO.Stream)pdbStream, debugEntryPoint: debugEntryPoint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 25848, 25943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_26122_26188(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 26122, 26188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 23668, 26201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 23668, 26201);
            }
        }

        [Fact]
        [WorkItem(768862, "https://devdiv.visualstudio.com/DevDiv/_workitems/edit/768862")]
        public void TestLargeLineDelta()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 26213, 27983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 26379, 26444);

                var
                verbatim = f_23129_26394_26443("\r\n", f_23129_26414_26442("x", 1000))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 26460, 26567);

                var
                source = $@"
class C {{ public static void Main() => System.Console.WriteLine(@""{verbatim}""); }}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 26581, 26673);

                var
                c = f_23129_26589_26672(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 26687, 27240);

                f_23129_26687_27239(c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""2"" startColumn=""40"" endLine=""1001"" endColumn=""4"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
", format: DebugInformationFormat.PortablePdb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 27428, 27972);

                f_23129_27428_27971(
                            // Native PDBs only support spans with line delta <= 127 (7 bit)
                            // https://github.com/Microsoft/microsoft-pdb/blob/master/include/cvinfo.h#L4621
                            c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""2"" startColumn=""40"" endLine=""129"" endColumn=""4"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
", format: DebugInformationFormat.Pdb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 26213, 27983);

                System.Collections.Generic.IEnumerable<string>
                f_23129_26414_26442(string
                element, int
                count)
                {
                    var return_v = Enumerable.Repeat(element, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 26414, 26442);
                    return return_v;
                }


                string
                f_23129_26394_26443(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 26394, 26443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_26589_26672(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 26589, 26672);
                    return return_v;
                }


                bool
                f_23129_26687_27239(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 26687, 27239);
                    return return_v;
                }


                bool
                f_23129_27428_27971(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 27428, 27971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 26213, 27983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 26213, 27983);
            }
        }

        [Fact]
        [WorkItem(20118, "https://github.com/dotnet/roslyn/issues/20118")]
        public void TestLargeStartAndEndColumn_SameLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 27995, 28991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 28161, 28199);

                var
                spaces = f_23129_28174_28198(' ', 0x10000)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 28215, 28347);

                var
                source = $@"
class C 
{{ 
    public static void Main() => 
        {spaces}System.Console.WriteLine(""{spaces}""); 
}}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 28361, 28453);

                var
                c = f_23129_28369_28452(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 28467, 28980);

                f_23129_28467_28979(c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""65533"" endLine=""5"" endColumn=""65534"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 27995, 28991);

                string
                f_23129_28174_28198(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 28174, 28198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_28369_28452(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 28369, 28452);
                    return return_v;
                }


                bool
                f_23129_28467_28979(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 28467, 28979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 27995, 28991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 27995, 28991);
            }
        }

        [Fact]
        [WorkItem(20118, "https://github.com/dotnet/roslyn/issues/20118")]
        public void TestLargeStartAndEndColumn_DifferentLine()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 29003, 30014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 29174, 29212);

                var
                spaces = f_23129_29187_29211(' ', 0x10000)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 29228, 29370);

                var
                source = $@"
class C 
{{ 
    public static void Main() => 
        {spaces}System.Console.WriteLine(
        ""{spaces}""); 
}}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 29384, 29476);

                var
                c = f_23129_29392_29475(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 29490, 30003);

                f_23129_29490_30002(c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""65534"" endLine=""6"" endColumn=""65534"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 29003, 30014);

                string
                f_23129_29187_29211(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 29187, 29211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_29392_29475(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 29392, 29475);
                    return return_v;
                }


                bool
                f_23129_29490_30002(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 29490, 30002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 29003, 30014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 29003, 30014);
            }
        }

        [Fact]
        public void TestBasic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 30081, 31469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 30145, 30316);

                var
                source = f_23129_30158_30315(@"
class Program
{
    Program() { }

    static void Main(string[] args)
    {
        Program p = new Program();
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 30332, 30424);

                var
                c = f_23129_30340_30423(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 30438, 31458);

                f_23129_30438_31457(c, "Program.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Main"" parameterNames=""args"">
      <customDebugInfo>
        <forward declaringType=""Program"" methodName="".ctor"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""19"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""35"" document=""1"" />
        <entry offset=""0x7"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x8"">
        <local name=""p"" il_index=""0"" il_start=""0x0"" il_end=""0x8"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 30081, 31469);

                string
                f_23129_30158_30315(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 30158, 30315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_30340_30423(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 30340, 30423);
                    return return_v;
                }


                bool
                f_23129_30438_31457(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 30438, 31457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 30081, 31469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 30081, 31469);
            }
        }

        [Fact]
        public void TestSimpleLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 31481, 35190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 31552, 32198);

                var
                source = f_23129_31565_32197(@"
class C 
{ 
    void Method()
    {   //local at method scope
        object version = 6;
        System.Console.WriteLine(""version {0}"", version);
        {
            //a scope that defines no locals
            {
                //a nested local
                object foob = 1;
                System.Console.WriteLine(""foob {0}"", foob);
            }
            {
                //a nested local
                int foob1 = 1;
                System.Console.WriteLine(""foob1 {0}"", foob1);
            }
            System.Console.WriteLine(""Eva"");
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 32212, 32304);

                var
                c = f_23129_32220_32303(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 32318, 35179);

                f_23129_32318_35178(c, "C.Method", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Method"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""44"" />
          <slot kind=""0"" offset=""246"" />
          <slot kind=""0"" offset=""402"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""28"" document=""1"" />
        <entry offset=""0x8"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""58"" document=""1"" />
        <entry offset=""0x14"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""10"" document=""1"" />
        <entry offset=""0x15"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""14"" document=""1"" />
        <entry offset=""0x16"" startLine=""12"" startColumn=""17"" endLine=""12"" endColumn=""33"" document=""1"" />
        <entry offset=""0x1d"" startLine=""13"" startColumn=""17"" endLine=""13"" endColumn=""60"" document=""1"" />
        <entry offset=""0x29"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""14"" document=""1"" />
        <entry offset=""0x2a"" startLine=""15"" startColumn=""13"" endLine=""15"" endColumn=""14"" document=""1"" />
        <entry offset=""0x2b"" startLine=""17"" startColumn=""17"" endLine=""17"" endColumn=""31"" document=""1"" />
        <entry offset=""0x2d"" startLine=""18"" startColumn=""17"" endLine=""18"" endColumn=""62"" document=""1"" />
        <entry offset=""0x3e"" startLine=""19"" startColumn=""13"" endLine=""19"" endColumn=""14"" document=""1"" />
        <entry offset=""0x3f"" startLine=""20"" startColumn=""13"" endLine=""20"" endColumn=""45"" document=""1"" />
        <entry offset=""0x4a"" startLine=""21"" startColumn=""9"" endLine=""21"" endColumn=""10"" document=""1"" />
        <entry offset=""0x4b"" startLine=""22"" startColumn=""5"" endLine=""22"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x4c"">
        <local name=""version"" il_index=""0"" il_start=""0x0"" il_end=""0x4c"" attributes=""0"" />
        <scope startOffset=""0x15"" endOffset=""0x2a"">
          <local name=""foob"" il_index=""1"" il_start=""0x15"" il_end=""0x2a"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x2a"" endOffset=""0x3f"">
          <local name=""foob1"" il_index=""2"" il_start=""0x2a"" il_end=""0x3f"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 31481, 35190);

                string
                f_23129_31565_32197(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 31565, 32197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_32220_32303(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 32220, 32303);
                    return return_v;
                }


                bool
                f_23129_32318_35178(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 32318, 35178);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 31481, 35190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 31481, 35190);
            }
        }

        [Fact]
        [WorkItem(7244, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/7244")]
        public void ConstructorsWithoutInitializers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 35202, 37768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 35376, 35527);

                var
                source = f_23129_35389_35526(@"class C
{
    C()
    {
        object o;
    }
    C(object x)
    {
        object y = x;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 35541, 35633);

                var
                c = f_23129_35549_35632(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 35647, 37757);

                f_23129_35647_37756(c, "C..ctor", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""18"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""3"" startColumn=""5"" endLine=""3"" endColumn=""8"" document=""1"" />
        <entry offset=""0x7"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""6"" document=""1"" />
        <entry offset=""0x8"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x9"">
        <scope startOffset=""0x7"" endOffset=""0x9"">
          <local name=""o"" il_index=""0"" il_start=""0x7"" il_end=""0x9"" attributes=""0"" />
        </scope>
      </scope>
    </method>
    <method containingType=""C"" name="".ctor"" parameterNames=""x"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".ctor"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""18"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""16"" document=""1"" />
        <entry offset=""0x7"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""1"" />
        <entry offset=""0x8"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""22"" document=""1"" />
        <entry offset=""0xa"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xb"">
        <scope startOffset=""0x7"" endOffset=""0xb"">
          <local name=""y"" il_index=""0"" il_start=""0x7"" il_end=""0xb"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 35202, 37768);

                string
                f_23129_35389_35526(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 35389, 35526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_35549_35632(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 35549, 35632);
                    return return_v;
                }


                bool
                f_23129_35647_37756(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 35647, 37756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 35202, 37768);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 35202, 37768);
            }
        }

        [WorkItem(7244, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/7244")]
        [Fact]
        public void ConstructorsWithInitializers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 37780, 40635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 37951, 38147);

                var
                source = f_23129_37964_38146(@"class C
{
    static object G = 1;
    object F = G;
    C()
    {
        object o;
    }
    C(object x)
    {
        object y = x;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 38161, 38253);

                var
                c = f_23129_38169_38252(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 38267, 40624);

                f_23129_38267_40623(c, "C..ctor", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""18"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""18"" document=""1"" />
        <entry offset=""0xb"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""8"" document=""1"" />
        <entry offset=""0x12"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
        <entry offset=""0x13"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x14"">
        <scope startOffset=""0x12"" endOffset=""0x14"">
          <local name=""o"" il_index=""0"" il_start=""0x12"" il_end=""0x14"" attributes=""0"" />
        </scope>
      </scope>
    </method>
    <method containingType=""C"" name="".ctor"" parameterNames=""x"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".ctor"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""18"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""18"" document=""1"" />
        <entry offset=""0xb"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""16"" document=""1"" />
        <entry offset=""0x12"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
        <entry offset=""0x13"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""22"" document=""1"" />
        <entry offset=""0x15"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x16"">
        <scope startOffset=""0x12"" endOffset=""0x16"">
          <local name=""y"" il_index=""0"" il_start=""0x12"" il_end=""0x16"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 37780, 40635);

                string
                f_23129_37964_38146(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 37964, 38146);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_38169_38252(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 38169, 38252);
                    return return_v;
                }


                bool
                f_23129_38267_40623(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 38267, 40623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 37780, 40635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 37780, 40635);
            }
        }

        [Fact]
        public void MethodsWithDebuggerAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 41377, 45207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 41461, 41931);

                var
                source = f_23129_41474_41930(@"
using System;
using System.Diagnostics;

class Program
{
    [DebuggerHidden]
    static void Hidden()
    {
        int x = 1;
        Console.WriteLine(x);
    }

    [DebuggerStepThrough]
    static void StepThrough()
    {
        int y = 1;
        Console.WriteLine(y);
    }

    [DebuggerNonUserCode]
    static void NonUserCode()
    {
        int z = 1;
        Console.WriteLine(z);
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 41945, 42037);

                var
                c = f_23129_41953_42036(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 42051, 45196);

                f_23129_42051_45195(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Hidden"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""2"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""19"" document=""1"" />
        <entry offset=""0x3"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""30"" document=""1"" />
        <entry offset=""0xa"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xb"">
        <namespace name=""System"" />
        <namespace name=""System.Diagnostics"" />
        <local name=""x"" il_index=""0"" il_start=""0x0"" il_end=""0xb"" attributes=""0"" />
      </scope>
    </method>
    <method containingType=""Program"" name=""StepThrough"">
      <customDebugInfo>
        <forward declaringType=""Program"" methodName=""Hidden"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""16"" startColumn=""5"" endLine=""16"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""17"" startColumn=""9"" endLine=""17"" endColumn=""19"" document=""1"" />
        <entry offset=""0x3"" startLine=""18"" startColumn=""9"" endLine=""18"" endColumn=""30"" document=""1"" />
        <entry offset=""0xa"" startLine=""19"" startColumn=""5"" endLine=""19"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xb"">
        <local name=""y"" il_index=""0"" il_start=""0x0"" il_end=""0xb"" attributes=""0"" />
      </scope>
    </method>
    <method containingType=""Program"" name=""NonUserCode"">
      <customDebugInfo>
        <forward declaringType=""Program"" methodName=""Hidden"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""23"" startColumn=""5"" endLine=""23"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""24"" startColumn=""9"" endLine=""24"" endColumn=""19"" document=""1"" />
        <entry offset=""0x3"" startLine=""25"" startColumn=""9"" endLine=""25"" endColumn=""30"" document=""1"" />
        <entry offset=""0xa"" startLine=""26"" startColumn=""5"" endLine=""26"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xb"">
        <local name=""z"" il_index=""0"" il_start=""0x0"" il_end=""0xb"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 41377, 45207);

                string
                f_23129_41474_41930(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 41474, 41930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_41953_42036(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 41953, 42036);
                    return return_v;
                }


                bool
                f_23129_42051_45195(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 42051, 45195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 41377, 45207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 41377, 45207);
            }
        }

        [WorkItem(804681, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/804681")]
        [Fact]
        public void SequencePointAtOffset0()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 45434, 49734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 45603, 45869);

                string
                source = f_23129_45619_45868(@"using System;
class C
{
    static Func<object, int> F = x =>
    {
        Func<object, int> f = o => 1;
        Func<Func<object, int>, Func<object, int>> g = h => y => h(y);
        return g(f)(null);
    };
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 45883, 45975);

                var
                c = f_23129_45891_45974(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 45989, 49723);

                f_23129_45989_49722(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".cctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLambdaMap>
          <methodOrdinal>2</methodOrdinal>
          <closure offset=""-45"" />
          <lambda offset=""-147"" />
          <lambda offset=""-109"" />
          <lambda offset=""-45"" />
          <lambda offset=""-40"" closure=""0"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""9"" endColumn=""7"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x16"">
        <namespace name=""System"" />
      </scope>
    </method>
    <method containingType=""C+&lt;&gt;c__DisplayClass2_0"" name=""&lt;.cctor&gt;b__3"" parameterNames=""y"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".cctor"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""66"" endLine=""7"" endColumn=""70"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C+&lt;&gt;c"" name=""&lt;.cctor&gt;b__2_0"" parameterNames=""x"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".cctor"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""-118"" />
          <slot kind=""0"" offset=""-54"" />
          <slot kind=""21"" offset=""-147"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""38"" document=""1"" />
        <entry offset=""0x21"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""71"" document=""1"" />
        <entry offset=""0x41"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""27"" document=""1"" />
        <entry offset=""0x51"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x53"">
        <local name=""f"" il_index=""0"" il_start=""0x0"" il_end=""0x53"" attributes=""0"" />
        <local name=""g"" il_index=""1"" il_start=""0x0"" il_end=""0x53"" attributes=""0"" />
      </scope>
    </method>
    <method containingType=""C+&lt;&gt;c"" name=""&lt;.cctor&gt;b__2_1"" parameterNames=""o"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".cctor"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""36"" endLine=""6"" endColumn=""37"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C+&lt;&gt;c"" name=""&lt;.cctor&gt;b__2_2"" parameterNames=""h"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".cctor"" />
        <encLocalSlotMap>
          <slot kind=""30"" offset=""-45"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0xd"" startLine=""7"" startColumn=""61"" endLine=""7"" endColumn=""70"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x1a"">
        <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0x1a"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 45434, 49734);

                string
                f_23129_45619_45868(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 45619, 45868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_45891_45974(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 45891, 45974);
                    return return_v;
                }


                bool
                f_23129_45989_49722(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 45989, 49722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 45434, 49734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 45434, 49734);
            }
        }

        [Fact]
        public void SyntaxOffsetInPresenceOfTrivia_Methods()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 49859, 52179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 49952, 50161);

                string
                source = @"
class C
{
    public static void Main1() /*Comment1*/{/*Comment2*/int a = 1;/*Comment3*/}/*Comment4*/
    public static void Main2() {/*Comment2*/int a = 2;/*Comment3*/}/*Comment4*/
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 50175, 50267);

                var
                c = f_23129_50183_50266(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 50344, 52168);

                f_23129_50344_52167(
                            // verify that both syntax offsets are the same
                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main1"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""17"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""44"" endLine=""4"" endColumn=""45"" document=""1"" />
        <entry offset=""0x1"" startLine=""4"" startColumn=""57"" endLine=""4"" endColumn=""67"" document=""1"" />
        <entry offset=""0x3"" startLine=""4"" startColumn=""79"" endLine=""4"" endColumn=""80"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x4"">
        <local name=""a"" il_index=""0"" il_start=""0x0"" il_end=""0x4"" attributes=""0"" />
      </scope>
    </method>
    <method containingType=""C"" name=""Main2"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""Main1"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""17"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""32"" endLine=""5"" endColumn=""33"" document=""1"" />
        <entry offset=""0x1"" startLine=""5"" startColumn=""45"" endLine=""5"" endColumn=""55"" document=""1"" />
        <entry offset=""0x3"" startLine=""5"" startColumn=""67"" endLine=""5"" endColumn=""68"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x4"">
        <local name=""a"" il_index=""0"" il_start=""0x0"" il_end=""0x4"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 49859, 52179);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_50183_50266(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 50183, 50266);
                    return return_v;
                }


                bool
                f_23129_50344_52167(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 50344, 52167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 49859, 52179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 49859, 52179);
            }
        }

        [Fact]
        public void SyntaxOffsetInPresenceOfTrivia_Initializers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 52318, 54981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 52416, 52773);

                string
                source = @"
using System;
class C1
{
    public static Func<int> e=() => 0;
    public static Func<int> f/*Comment0*/=/*Comment1*/() => 1;/*Comment2*/
    public static Func<int> g=() => 2;
}
class C2
{
    public static Func<int> e=() => 0;
    public static Func<int> f=/*Comment1*/() => 1;
    public static Func<int> g=() => 2;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 52787, 52879);

                var
                c = f_23129_52795_52878(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 52968, 54019);

                f_23129_52968_54018(
                            // verify that syntax offsets of both .cctor's are the same
                            c, "C1..cctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C1"" name="".cctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLambdaMap>
          <methodOrdinal>4</methodOrdinal>
          <lambda offset=""-29"" />
          <lambda offset=""-9"" />
          <lambda offset=""-1"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""39"" document=""1"" />
        <entry offset=""0x15"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""63"" document=""1"" />
        <entry offset=""0x2a"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""39"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x40"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 54035, 54970);

                f_23129_54035_54969(
                            c, "C2..cctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C2"" name="".cctor"">
      <customDebugInfo>
        <forward declaringType=""C1"" methodName="".cctor"" />
        <encLambdaMap>
          <methodOrdinal>4</methodOrdinal>
          <lambda offset=""-29"" />
          <lambda offset=""-9"" />
          <lambda offset=""-1"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""39"" document=""1"" />
        <entry offset=""0x15"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""51"" document=""1"" />
        <entry offset=""0x2a"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""39"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 52318, 54981);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_52795_52878(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 52795, 52878);
                    return return_v;
                }


                bool
                f_23129_52968_54018(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 52968, 54018);
                    return return_v;
                }


                bool
                f_23129_54035_54969(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 54035, 54969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 52318, 54981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 52318, 54981);
            }
        }

        [Fact]
        public void Return_Method1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 55050, 56730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 55119, 55238);

                var
                source = f_23129_55132_55237(@"
class Program
{
    static int Main()
    {
        return 1;
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 55254, 55318);

                var
                v = f_23129_55262_55317(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 55588, 55861);

                f_23129_55588_55860(
                            // In order to place a breakpoint on the closing brace we need to save the return expression value to 
                            // a local and then load it again (since sequence point needs an empty stack). This variable has to be marked as long-lived.
                            v, "Program.Main", @"
{
  // Code size        7 (0x7)
  .maxstack  1
  .locals init (int V_0)
 -IL_0000:  nop
 -IL_0001:  ldc.i4.1
  IL_0002:  stloc.0
  IL_0003:  br.s       IL_0005
 -IL_0005:  ldloc.0
  IL_0006:  ret
}", sequencePoints: "Program.Main");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 55877, 56719);

                f_23129_55877_56718(
                            v, "Program.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""18"" document=""1"" />
        <entry offset=""0x5"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 55050, 56730);

                string
                f_23129_55132_55237(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 55132, 55237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_55262_55317(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 55262, 55317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_55588_55860(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 55588, 55860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_55877_56718(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 55877, 56718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 55050, 56730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 55050, 56730);
            }
        }

        [Fact]
        public void Return_Property1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 56742, 58406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 56813, 56929);

                var
                source = f_23129_56826_56928(@"
class C
{
    static int P
    {
        get { return 1; }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 56945, 57009);

                var
                v = f_23129_56953_57008(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 57279, 57542);

                f_23129_57279_57541(
                            // In order to place a breakpoint on the closing brace we need to save the return expression value to 
                            // a local and then load it again (since sequence point needs an empty stack). This variable has to be marked as long-lived.
                            v, "C.P.get", @"
{
  // Code size        7 (0x7)
  .maxstack  1
  .locals init (int V_0)
 -IL_0000:  nop
 -IL_0001:  ldc.i4.1
  IL_0002:  stloc.0
  IL_0003:  br.s       IL_0005
 -IL_0005:  ldloc.0
  IL_0006:  ret
}", sequencePoints: "C.get_P");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 57558, 58395);

                f_23129_57558_58394(
                            v, "C.get_P", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""get_P"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""13"" endLine=""6"" endColumn=""14"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""15"" endLine=""6"" endColumn=""24"" document=""1"" />
        <entry offset=""0x5"" startLine=""6"" startColumn=""25"" endLine=""6"" endColumn=""26"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 56742, 58406);

                string
                f_23129_56826_56928(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 56826, 56928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_56953_57008(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 56953, 57008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_57279_57541(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 57279, 57541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_57558_58394(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 57558, 58394);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 56742, 58406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 56742, 58406);
            }
        }

        [Fact]
        public void Return_Void1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 58418, 58870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 58485, 58580);

                var
                source = @"
class Program
{
    static void Main()
    {
        return;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 58596, 58660);

                var
                v = f_23129_58604_58659(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 58676, 58859);

                f_23129_58676_58858(
                            v, "Program.Main", @"
{
  // Code size        4 (0x4)
  .maxstack  0
 -IL_0000:  nop
 -IL_0001:  br.s       IL_0003
 -IL_0003:  ret
}", sequencePoints: "Program.Main");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 58418, 58870);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_58604_58659(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 58604, 58659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_58676_58858(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 58676, 58858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 58418, 58870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 58418, 58870);
            }
        }

        [Fact]
        public void Return_ExpressionBodied1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 58882, 59293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 58961, 59030);

                var
                source = @"
class Program
{
    static int Main() => 1;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 59046, 59110);

                var
                v = f_23129_59054_59109(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 59126, 59282);

                f_23129_59126_59281(
                            v, "Program.Main", @"
{
  // Code size        2 (0x2)
  .maxstack  1
 -IL_0000:  ldc.i4.1
  IL_0001:  ret
}", sequencePoints: "Program.Main");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 58882, 59293);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_59054_59109(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 59054, 59109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_59126_59281(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 59126, 59281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 58882, 59293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 58882, 59293);
            }
        }

        [Fact]
        public void Return_FromExceptionHandler1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 59305, 61881);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 59388, 59670);

                var
                source = f_23129_59401_59669(@"
using System;

class Program
{
    static int Main() 
    {
        try
        {
            Console.WriteLine();
            return 1;
        }
        catch (Exception)
        {
            return 2;
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 59684, 59748);

                var
                v = f_23129_59692_59747(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 59764, 60317);

                f_23129_59764_60316(
                            v, "Program.Main", @"
{
  // Code size       20 (0x14)
  .maxstack  1
  .locals init (int V_0)
 -IL_0000:  nop
  .try
  {
   -IL_0001:  nop
   -IL_0002:  call       ""void System.Console.WriteLine()""
    IL_0007:  nop
   -IL_0008:  ldc.i4.1
    IL_0009:  stloc.0
    IL_000a:  leave.s    IL_0012
  }
  catch System.Exception
  {
   -IL_000c:  pop
   -IL_000d:  nop
   -IL_000e:  ldc.i4.2
    IL_000f:  stloc.0
    IL_0010:  leave.s    IL_0012
  }
 -IL_0012:  ldloc.0
  IL_0013:  ret
}", sequencePoints: "Program.Main");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 60333, 61870);

                f_23129_60333_61869(
                            v, "Program.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""33"" document=""1"" />
        <entry offset=""0x8"" startLine=""11"" startColumn=""13"" endLine=""11"" endColumn=""22"" document=""1"" />
        <entry offset=""0xc"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""26"" document=""1"" />
        <entry offset=""0xd"" startLine=""14"" startColumn=""9"" endLine=""14"" endColumn=""10"" document=""1"" />
        <entry offset=""0xe"" startLine=""15"" startColumn=""13"" endLine=""15"" endColumn=""22"" document=""1"" />
        <entry offset=""0x12"" startLine=""17"" startColumn=""5"" endLine=""17"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x14"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 59305, 61881);

                string
                f_23129_59401_59669(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 59401, 59669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_59692_59747(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 59692, 59747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_59764_60316(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 59764, 60316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_60333_61869(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 60333, 61869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 59305, 61881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 59305, 61881);
            }
        }

        [Fact]
        public void IfStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 61946, 67005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 62012, 62577);

                var
                source = f_23129_62025_62576(@"
class C 
{ 
    void Method()
    {   
        bool b = true;
        if (b)
        {
            string s = ""true"";
            System.Console.WriteLine(s);
        } 
        else 
        {
            string s = ""false"";
            int i = 1;

            while (i < 100)
            {
                int j = i, k = 1;
                System.Console.WriteLine(j);  
                i = j + k;                
            }         
            
            i = i + 1;
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 62591, 62683);

                var
                c = f_23129_62599_62682(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 62697, 66994);

                f_23129_62697_66993(c, "C.Method", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Method"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""19"" />
          <slot kind=""1"" offset=""38"" />
          <slot kind=""0"" offset=""76"" />
          <slot kind=""0"" offset=""188"" />
          <slot kind=""0"" offset=""218"" />
          <slot kind=""0"" offset=""292"" />
          <slot kind=""0"" offset=""299"" />
          <slot kind=""1"" offset=""240"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""23"" document=""1"" />
        <entry offset=""0x3"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""15"" document=""1"" />
        <entry offset=""0x5"" hidden=""true"" document=""1"" />
        <entry offset=""0x8"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""10"" document=""1"" />
        <entry offset=""0x9"" startLine=""9"" startColumn=""13"" endLine=""9"" endColumn=""31"" document=""1"" />
        <entry offset=""0xf"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""41"" document=""1"" />
        <entry offset=""0x16"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0x17"" hidden=""true"" document=""1"" />
        <entry offset=""0x19"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1a"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""32"" document=""1"" />
        <entry offset=""0x20"" startLine=""15"" startColumn=""13"" endLine=""15"" endColumn=""23"" document=""1"" />
        <entry offset=""0x23"" hidden=""true"" document=""1"" />
        <entry offset=""0x25"" startLine=""18"" startColumn=""13"" endLine=""18"" endColumn=""14"" document=""1"" />
        <entry offset=""0x26"" startLine=""19"" startColumn=""17"" endLine=""19"" endColumn=""26"" document=""1"" />
        <entry offset=""0x2a"" startLine=""19"" startColumn=""28"" endLine=""19"" endColumn=""33"" document=""1"" />
        <entry offset=""0x2d"" startLine=""20"" startColumn=""17"" endLine=""20"" endColumn=""45"" document=""1"" />
        <entry offset=""0x35"" startLine=""21"" startColumn=""17"" endLine=""21"" endColumn=""27"" document=""1"" />
        <entry offset=""0x3c"" startLine=""22"" startColumn=""13"" endLine=""22"" endColumn=""14"" document=""1"" />
        <entry offset=""0x3d"" startLine=""17"" startColumn=""13"" endLine=""17"" endColumn=""28"" document=""1"" />
        <entry offset=""0x45"" hidden=""true"" document=""1"" />
        <entry offset=""0x49"" startLine=""24"" startColumn=""13"" endLine=""24"" endColumn=""23"" document=""1"" />
        <entry offset=""0x4f"" startLine=""25"" startColumn=""9"" endLine=""25"" endColumn=""10"" document=""1"" />
        <entry offset=""0x50"" startLine=""26"" startColumn=""5"" endLine=""26"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x51"">
        <local name=""b"" il_index=""0"" il_start=""0x0"" il_end=""0x51"" attributes=""0"" />
        <scope startOffset=""0x8"" endOffset=""0x17"">
          <local name=""s"" il_index=""2"" il_start=""0x8"" il_end=""0x17"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x19"" endOffset=""0x50"">
          <local name=""s"" il_index=""3"" il_start=""0x19"" il_end=""0x50"" attributes=""0"" />
          <local name=""i"" il_index=""4"" il_start=""0x19"" il_end=""0x50"" attributes=""0"" />
          <scope startOffset=""0x25"" endOffset=""0x3d"">
            <local name=""j"" il_index=""5"" il_start=""0x25"" il_end=""0x3d"" attributes=""0"" />
            <local name=""k"" il_index=""6"" il_start=""0x25"" il_end=""0x3d"" attributes=""0"" />
          </scope>
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 61946, 67005);

                string
                f_23129_62025_62576(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 62025, 62576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_62599_62682(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 62599, 62682);
                    return return_v;
                }


                bool
                f_23129_62697_66993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 62697, 66993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 61946, 67005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 61946, 67005);
            }
        }

        [WorkItem(538299, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538299")]
        [Fact]
        public void WhileStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 67073, 71324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 67234, 67978);

                var
                source = @"using System;

public class SeqPointForWhile
{
    public static void Main()
    {
        SeqPointForWhile obj = new SeqPointForWhile();
        obj.While(234);
    }

    int field;
    public void While(int p)
    {
        while (p > 0) // SeqPt should be generated at the end of loop
        {
            p = (int)(p / 2);

            if (p > 100)
            {
                continue;
            }
            else if (p > 10)
            {
                int x = p;
                field = x;
            }
            else
            {
                int x = p;
                Console.WriteLine(x);
                break;
            }
        }
        field = -1;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 67994, 68088);

                var
                c = f_23129_68002_68087(source, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 68453, 71313);

                f_23129_68453_71312(
                            // Offset 0x01 should be:
                            //  <entry offset=""0x1"" hidden=""true"" document=""1"" />
                            // Move original offset 0x01 to 0x33
                            //  <entry offset=""0x33"" startLine=""14"" startColumn=""9"" endLine=""14"" endColumn=""22"" document=""1"" />
                            // 
                            // Note: 16707566 == 0x00FEEFEE
                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <entryPoint declaringType=""SeqPointForWhile"" methodName=""Main"" />
  <methods>
    <method containingType=""SeqPointForWhile"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""55"" document=""1"" />
        <entry offset=""0x5"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""24"" document=""1"" />
        <entry offset=""0xf"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x10"">
        <namespace name=""System"" />
      </scope>
    </method>
    <method containingType=""SeqPointForWhile"" name=""While"" parameterNames=""p"">
      <customDebugInfo>
        <forward declaringType=""SeqPointForWhile"" methodName=""Main"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x2"" startLine=""16"" startColumn=""13"" endLine=""16"" endColumn=""30"" document=""1"" />
        <entry offset=""0x7"" startLine=""18"" startColumn=""13"" endLine=""18"" endColumn=""25"" document=""1"" />
        <entry offset=""0xc"" startLine=""22"" startColumn=""18"" endLine=""22"" endColumn=""29"" document=""1"" />
        <entry offset=""0x11"" startLine=""24"" startColumn=""17"" endLine=""24"" endColumn=""27"" document=""1"" />
        <entry offset=""0x13"" startLine=""25"" startColumn=""17"" endLine=""25"" endColumn=""27"" document=""1"" />
        <entry offset=""0x1a"" hidden=""true"" document=""1"" />
        <entry offset=""0x1c"" startLine=""29"" startColumn=""17"" endLine=""29"" endColumn=""27"" document=""1"" />
        <entry offset=""0x1d"" startLine=""30"" startColumn=""17"" endLine=""30"" endColumn=""38"" document=""1"" />
        <entry offset=""0x22"" startLine=""31"" startColumn=""17"" endLine=""31"" endColumn=""23"" document=""1"" />
        <entry offset=""0x24"" startLine=""14"" startColumn=""9"" endLine=""14"" endColumn=""22"" document=""1"" />
        <entry offset=""0x28"" startLine=""34"" startColumn=""9"" endLine=""34"" endColumn=""20"" document=""1"" />
        <entry offset=""0x2f"" startLine=""35"" startColumn=""5"" endLine=""35"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x30"">
        <scope startOffset=""0x11"" endOffset=""0x1a"">
          <local name=""x"" il_index=""0"" il_start=""0x11"" il_end=""0x1a"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 67073, 71324);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_68002_68087(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 68002, 68087);
                    return return_v;
                }


                bool
                f_23129_68453_71312(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 68453, 71312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 67073, 71324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 67073, 71324);
            }
        }

        [Fact]
        public void ForStatement1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 71390, 73686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 71458, 71728);

                var
                source = f_23129_71471_71727(@"
class C
{
    static bool F(int i) { return true; }
    static void G(int i) { }
    
    static void M()
    {
        for (int i = 1; F(i); G(i))
        {
            System.Console.WriteLine(1);
        }
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 71742, 71834);

                var
                c = f_23129_71750_71833(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 71848, 73675);

                f_23129_71848_73674(c, "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" parameterNames=""i"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""20"" />
          <slot kind=""1"" offset=""11"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""9"" startColumn=""14"" endLine=""9"" endColumn=""23"" document=""1"" />
        <entry offset=""0x3"" hidden=""true"" document=""1"" />
        <entry offset=""0x5"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""10"" document=""1"" />
        <entry offset=""0x6"" startLine=""11"" startColumn=""13"" endLine=""11"" endColumn=""41"" document=""1"" />
        <entry offset=""0xd"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""10"" document=""1"" />
        <entry offset=""0xe"" startLine=""9"" startColumn=""31"" endLine=""9"" endColumn=""35"" document=""1"" />
        <entry offset=""0x15"" startLine=""9"" startColumn=""25"" endLine=""9"" endColumn=""29"" document=""1"" />
        <entry offset=""0x1c"" hidden=""true"" document=""1"" />
        <entry offset=""0x1f"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x20"">
        <scope startOffset=""0x1"" endOffset=""0x1f"">
          <local name=""i"" il_index=""0"" il_start=""0x1"" il_end=""0x1f"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 71390, 73686);

                string
                f_23129_71471_71727(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 71471, 71727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_71750_71833(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 71750, 71833);
                    return return_v;
                }


                bool
                f_23129_71848_73674(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 71848, 73674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 71390, 73686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 71390, 73686);
            }
        }

        [Fact]
        public void ForStatement2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 73698, 75018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 73766, 73915);

                var
                source = @"
class C
{
    static void M()
    {
        for (;;)
        {
            System.Console.WriteLine(1);
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 73929, 74021);

                var
                c = f_23129_73937_74020(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 74035, 75007);

                f_23129_74035_75006(c, "C.M", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" hidden=""true"" document=""1"" />
        <entry offset=""0x3"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""10"" document=""1"" />
        <entry offset=""0x4"" startLine=""8"" startColumn=""13"" endLine=""8"" endColumn=""41"" document=""1"" />
        <entry offset=""0xb"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0xc"" hidden=""true"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 73698, 75018);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_73937_74020(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 73937, 74020);
                    return return_v;
                }


                bool
                f_23129_74035_75006(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 74035, 75006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 73698, 75018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 73698, 75018);
            }
        }

        [Fact]
        public void ForStatement3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 75030, 76889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 75098, 75293);

                var
                source = f_23129_75111_75292(@"
class C
{
    static void M()
    {
        int i = 0;
        for (;;i++)
        {
            System.Console.WriteLine(i);
        }
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 75307, 75399);

                var
                c = f_23129_75315_75398(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 75413, 76878);

                f_23129_75413_76877(c, "C.M", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""19"" document=""1"" />
        <entry offset=""0x3"" hidden=""true"" document=""1"" />
        <entry offset=""0x5"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""10"" document=""1"" />
        <entry offset=""0x6"" startLine=""9"" startColumn=""13"" endLine=""9"" endColumn=""41"" document=""1"" />
        <entry offset=""0xd"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""10"" document=""1"" />
        <entry offset=""0xe"" startLine=""7"" startColumn=""16"" endLine=""7"" endColumn=""19"" document=""1"" />
        <entry offset=""0x12"" hidden=""true"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x14"">
        <local name=""i"" il_index=""0"" il_start=""0x0"" il_end=""0x14"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 75030, 76889);

                string
                f_23129_75111_75292(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 75111, 75292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_75315_75398(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 75315, 75398);
                    return return_v;
                }


                bool
                f_23129_75413_76877(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 75413, 76877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 75030, 76889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 75030, 76889);
            }
        }

        [Fact]
        public void ForEachStatement_String()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 76959, 78952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 77037, 77225);

                var
                source = @"
public class C
{
    public static void Main()
    {
        foreach (var c in ""hello"")
        {
            System.Console.WriteLine(c);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 77239, 77333);

                var
                c = f_23129_77247_77332(source, options: TestOptions.ReleaseExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 77794, 78941);

                f_23129_77794_78940(
                            // Sequence points:
                            // 1) Open brace at start of method
                            // 2) 'foreach'
                            // 3) '"hello"'
                            // 4) Hidden initial jump (of for loop)
                            // 5) 'var c'
                            // 6) Open brace of loop
                            // 7) Loop body
                            // 8) Close brace of loop
                            // 9) Hidden index increment.
                            // 10) 'in'
                            // 11) Close brace at end of method

                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <entryPoint declaringType=""C"" methodName=""Main"" />
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""27"" endLine=""6"" endColumn=""34"" document=""1"" />
        <entry offset=""0x8"" hidden=""true"" document=""1"" />
        <entry offset=""0xa"" startLine=""6"" startColumn=""18"" endLine=""6"" endColumn=""23"" document=""1"" />
        <entry offset=""0x11"" startLine=""8"" startColumn=""13"" endLine=""8"" endColumn=""41"" document=""1"" />
        <entry offset=""0x16"" hidden=""true"" document=""1"" />
        <entry offset=""0x1a"" startLine=""6"" startColumn=""24"" endLine=""6"" endColumn=""26"" document=""1"" />
        <entry offset=""0x23"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 76959, 78952);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_77247_77332(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 77247, 77332);
                    return return_v;
                }


                bool
                f_23129_77794_78940(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 77794, 78940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 76959, 78952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 76959, 78952);
            }
        }

        [Fact]
        public void ForEachStatement_Array()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 78964, 81813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 79041, 79253);

                var
                source = f_23129_79054_79252(@"
public class C
{
    public static void Main()
    {
        foreach (var x in new int[2])
        {
            System.Console.WriteLine(x);
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 79269, 79361);

                var
                c = f_23129_79277_79360(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 79825, 81802);

                f_23129_79825_81801(
                            // Sequence points:
                            // 1) Open brace at start of method
                            // 2) 'foreach'
                            // 3) 'new int[2]'
                            // 4) Hidden initial jump (of for loop)
                            // 5) 'var c'
                            // 6) Open brace of loop
                            // 7) Loop body
                            // 8) Close brace of loop
                            // 9) Hidden index increment.
                            // 10) 'in'
                            // 11) Close brace at end of method

                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""6"" offset=""11"" />
          <slot kind=""8"" offset=""11"" />
          <slot kind=""0"" offset=""11"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""16"" document=""1"" />
        <entry offset=""0x2"" startLine=""6"" startColumn=""27"" endLine=""6"" endColumn=""37"" document=""1"" />
        <entry offset=""0xb"" hidden=""true"" document=""1"" />
        <entry offset=""0xd"" startLine=""6"" startColumn=""18"" endLine=""6"" endColumn=""23"" document=""1"" />
        <entry offset=""0x11"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""10"" document=""1"" />
        <entry offset=""0x12"" startLine=""8"" startColumn=""13"" endLine=""8"" endColumn=""41"" document=""1"" />
        <entry offset=""0x19"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1a"" hidden=""true"" document=""1"" />
        <entry offset=""0x1e"" startLine=""6"" startColumn=""24"" endLine=""6"" endColumn=""26"" document=""1"" />
        <entry offset=""0x24"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x25"">
        <scope startOffset=""0xd"" endOffset=""0x1a"">
          <local name=""x"" il_index=""2"" il_start=""0xd"" il_end=""0x1a"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 78964, 81813);

                string
                f_23129_79054_79252(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 79054, 79252);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_79277_79360(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 79277, 79360);
                    return return_v;
                }


                bool
                f_23129_79825_81801(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 79825, 81801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 78964, 81813);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 78964, 81813);
            }
        }

        [WorkItem(544937, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/544937")]
        [Fact]
        public void ForEachStatement_MultiDimensionalArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 81825, 84339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 82010, 82202);

                var
                source = @"
public class C
{
    public static void Main()
    {
        foreach (var x in new int[2, 3])
        {
            System.Console.WriteLine(x);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 82216, 82280);

                var
                v = f_23129_82224_82279(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 82703, 84328);

                f_23129_82703_84327(
                            // Sequence points:
                            // 1) Open brace at start of method
                            // 2) 'foreach'
                            // 3) 'new int[2, 3]'
                            // 4) Hidden initial jump (of for loop)
                            // 5) 'var c'
                            // 6) Open brace of loop
                            // 7) Loop body
                            // 8) Close brace of loop
                            // 9) 'in'
                            // 10) Close brace at end of method

                            v, "C.Main", @"
{
  // Code size       88 (0x58)
  .maxstack  3
  .locals init (int[,] V_0,
                int V_1,
                int V_2,
                int V_3,
                int V_4,
                int V_5) //x
 -IL_0000:  nop
 -IL_0001:  nop
 -IL_0002:  ldc.i4.2
  IL_0003:  ldc.i4.3
  IL_0004:  newobj     ""int[*,*]..ctor""
  IL_0009:  stloc.0
  IL_000a:  ldloc.0
  IL_000b:  ldc.i4.0
  IL_000c:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_0011:  stloc.1
  IL_0012:  ldloc.0
  IL_0013:  ldc.i4.1
  IL_0014:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_0019:  stloc.2
  IL_001a:  ldloc.0
  IL_001b:  ldc.i4.0
  IL_001c:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_0021:  stloc.3
 ~IL_0022:  br.s       IL_0053
  IL_0024:  ldloc.0
  IL_0025:  ldc.i4.1
  IL_0026:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_002b:  stloc.s    V_4
 ~IL_002d:  br.s       IL_004a
 -IL_002f:  ldloc.0
  IL_0030:  ldloc.3
  IL_0031:  ldloc.s    V_4
  IL_0033:  call       ""int[*,*].Get""
  IL_0038:  stloc.s    V_5
 -IL_003a:  nop
 -IL_003b:  ldloc.s    V_5
  IL_003d:  call       ""void System.Console.WriteLine(int)""
  IL_0042:  nop
 -IL_0043:  nop
 ~IL_0044:  ldloc.s    V_4
  IL_0046:  ldc.i4.1
  IL_0047:  add
  IL_0048:  stloc.s    V_4
 -IL_004a:  ldloc.s    V_4
  IL_004c:  ldloc.2
  IL_004d:  ble.s      IL_002f
 ~IL_004f:  ldloc.3
  IL_0050:  ldc.i4.1
  IL_0051:  add
  IL_0052:  stloc.3
 -IL_0053:  ldloc.3
  IL_0054:  ldloc.1
  IL_0055:  ble.s      IL_0024
 -IL_0057:  ret
}
", sequencePoints: "C.Main");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 81825, 84339);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_82224_82279(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 82224, 82279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_82703_84327(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 82703, 84327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 81825, 84339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 81825, 84339);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void ConditionalInAsyncMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 84351, 89132);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 84506, 84732);

                var
                source = f_23129_84519_84731(@"
using System;

class Program
{
    public static async void Test()
    {
        int i = 0;

        if (i != 0)
            Console
                .WriteLine();
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 84746, 84810);

                var
                v = f_23129_84754_84809(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 84826, 86956);

                f_23129_84826_86955(
                            v, "Program.<Test>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()", @"
{
  // Code size       81 (0x51)
  .maxstack  2
  .locals init (int V_0,
                bool V_1,
                System.Exception V_2)
  // sequence point: <hidden>
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int Program.<Test>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: {
    IL_0007:  nop
    // sequence point: int i = 0;
    IL_0008:  ldarg.0
    IL_0009:  ldc.i4.0
    IL_000a:  stfld      ""int Program.<Test>d__0.<i>5__1""
    // sequence point: if (i != 0)
    IL_000f:  ldarg.0
    IL_0010:  ldfld      ""int Program.<Test>d__0.<i>5__1""
    IL_0015:  ldc.i4.0
    IL_0016:  cgt.un
    IL_0018:  stloc.1
    // sequence point: <hidden>
    IL_0019:  ldloc.1
    IL_001a:  brfalse.s  IL_0022
    // sequence point: Console ... .WriteLine()
    IL_001c:  call       ""void System.Console.WriteLine()""
    IL_0021:  nop
    // sequence point: <hidden>
    IL_0022:  leave.s    IL_003c
  }
  catch System.Exception
  {
    // async: catch handler, sequence point: <hidden>
    IL_0024:  stloc.2
    IL_0025:  ldarg.0
    IL_0026:  ldc.i4.s   -2
    IL_0028:  stfld      ""int Program.<Test>d__0.<>1__state""
    IL_002d:  ldarg.0
    IL_002e:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
    IL_0033:  ldloc.2
    IL_0034:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetException(System.Exception)""
    IL_0039:  nop
    IL_003a:  leave.s    IL_0050
  }
  // sequence point: }
  IL_003c:  ldarg.0
  IL_003d:  ldc.i4.s   -2
  IL_003f:  stfld      ""int Program.<Test>d__0.<>1__state""
  // sequence point: <hidden>
  IL_0044:  ldarg.0
  IL_0045:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
  IL_004a:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetResult()""
  IL_004f:  nop
  IL_0050:  ret
}
", sequencePoints: "Program+<Test>d__0.MoveNext", source: source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 86972, 89121);

                f_23129_86972_89120(
                            v, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Test"">
      <customDebugInfo>
        <forwardIterator name=""&lt;Test&gt;d__0"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
      </customDebugInfo>
    </method>
    <method containingType=""Program+&lt;Test&gt;d__0"" name=""MoveNext"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <hoistedLocalScopes>
          <slot startOffset=""0x0"" endOffset=""0x51"" />
        </hoistedLocalScopes>
        <encLocalSlotMap>
          <slot kind=""27"" offset=""0"" />
          <slot kind=""1"" offset=""33"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x7"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x8"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""19"" document=""1"" />
        <entry offset=""0xf"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""20"" document=""1"" />
        <entry offset=""0x19"" hidden=""true"" document=""1"" />
        <entry offset=""0x1c"" startLine=""11"" startColumn=""13"" endLine=""12"" endColumn=""30"" document=""1"" />
        <entry offset=""0x22"" hidden=""true"" document=""1"" />
        <entry offset=""0x24"" hidden=""true"" document=""1"" />
        <entry offset=""0x3c"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""6"" document=""1"" />
        <entry offset=""0x44"" hidden=""true"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x51"">
        <namespace name=""System"" />
      </scope>
      <asyncInfo>
        <catchHandler offset=""0x24"" />
        <kickoffMethod declaringType=""Program"" methodName=""Test"" />
      </asyncInfo>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 84351, 89132);

                string
                f_23129_84519_84731(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 84519, 84731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_84754_84809(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 84754, 84809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_84826_86955(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 84826, 86955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_86972_89120(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 86972, 89120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 84351, 89132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 84351, 89132);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void ConditionalBeforeLocalFunction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 89144, 90496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 89305, 89560);

                var
                source = @"
class C
{
    void M()
    {
        int i = 0;
        if (i != 0)
        {
            return;
        }

        string local()
        {
            throw null;
        }

        System.Console.Write(1);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 89574, 89638);

                var
                v = f_23129_89582_89637(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 89654, 90485);

                f_23129_89654_90484(
                            v, "C.M", @"
{
  // Code size       23 (0x17)
  .maxstack  2
  .locals init (int V_0, //i
                bool V_1)
  // sequence point: {
  IL_0000:  nop
  // sequence point: int i = 0;
  IL_0001:  ldc.i4.0
  IL_0002:  stloc.0
  // sequence point: if (i != 0)
  IL_0003:  ldloc.0
  IL_0004:  ldc.i4.0
  IL_0005:  cgt.un
  IL_0007:  stloc.1
  // sequence point: <hidden>
  IL_0008:  ldloc.1
  IL_0009:  brfalse.s  IL_000e
  // sequence point: {
  IL_000b:  nop
  // sequence point: return;
  IL_000c:  br.s       IL_0016
  // sequence point: <hidden>
  IL_000e:  nop
  // sequence point: System.Console.Write(1);
  IL_000f:  ldc.i4.1
  IL_0010:  call       ""void System.Console.Write(int)""
  IL_0015:  nop
  // sequence point: }
  IL_0016:  ret
}
", sequencePoints: "C.M", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 89144, 90496);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_89582_89637(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 89582, 89637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_89654_90484(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 89654, 90484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 89144, 90496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 89144, 90496);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void ConditionalInAsyncMethodWithExplicitReturn()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 90508, 93137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 90681, 90903);

                var
                source = @"
using System;

class Program
{
    public static async void Test()
    {
        int i = 0;

        if (i != 0)
            Console
                .WriteLine();

        return;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 90917, 90981);

                var
                v = f_23129_90925_90980(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 90997, 93126);

                f_23129_90997_93125(
                            v, "Program.<Test>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()", @"
{
  // Code size       81 (0x51)
  .maxstack  2
  .locals init (int V_0,
                bool V_1,
                System.Exception V_2)
  // sequence point: <hidden>
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int Program.<Test>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: {
    IL_0007:  nop
    // sequence point: int i = 0;
    IL_0008:  ldarg.0
    IL_0009:  ldc.i4.0
    IL_000a:  stfld      ""int Program.<Test>d__0.<i>5__1""
    // sequence point: if (i != 0)
    IL_000f:  ldarg.0
    IL_0010:  ldfld      ""int Program.<Test>d__0.<i>5__1""
    IL_0015:  ldc.i4.0
    IL_0016:  cgt.un
    IL_0018:  stloc.1
    // sequence point: <hidden>
    IL_0019:  ldloc.1
    IL_001a:  brfalse.s  IL_0022
    // sequence point: Console ... .WriteLine()
    IL_001c:  call       ""void System.Console.WriteLine()""
    IL_0021:  nop
    // sequence point: return;
    IL_0022:  leave.s    IL_003c
  }
  catch System.Exception
  {
    // async: catch handler, sequence point: <hidden>
    IL_0024:  stloc.2
    IL_0025:  ldarg.0
    IL_0026:  ldc.i4.s   -2
    IL_0028:  stfld      ""int Program.<Test>d__0.<>1__state""
    IL_002d:  ldarg.0
    IL_002e:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
    IL_0033:  ldloc.2
    IL_0034:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetException(System.Exception)""
    IL_0039:  nop
    IL_003a:  leave.s    IL_0050
  }
  // sequence point: }
  IL_003c:  ldarg.0
  IL_003d:  ldc.i4.s   -2
  IL_003f:  stfld      ""int Program.<Test>d__0.<>1__state""
  // sequence point: <hidden>
  IL_0044:  ldarg.0
  IL_0045:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
  IL_004a:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetResult()""
  IL_004f:  nop
  IL_0050:  ret
}
", sequencePoints: "Program+<Test>d__0.MoveNext", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 90508, 93137);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_90925_90980(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 90925, 90980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_90997_93125(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 90997, 93125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 90508, 93137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 90508, 93137);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void ConditionalInSimpleMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 93149, 94264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 93305, 93484);

                var
                source = @"
using System;

class Program
{
    public static void Test()
    {
        int i = 0;

        if (i != 0)
            Console.WriteLine();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 93498, 93562);

                var
                v = f_23129_93506_93561(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 93578, 94253);

                f_23129_93578_94252(
                            v, "Program.Test()", @"
{
  // Code size       18 (0x12)
  .maxstack  2
  .locals init (int V_0, //i
                bool V_1)
  // sequence point: {
  IL_0000:  nop
  // sequence point: int i = 0;
  IL_0001:  ldc.i4.0
  IL_0002:  stloc.0
  // sequence point: if (i != 0)
  IL_0003:  ldloc.0
  IL_0004:  ldc.i4.0
  IL_0005:  cgt.un
  IL_0007:  stloc.1
  // sequence point: <hidden>
  IL_0008:  ldloc.1
  IL_0009:  brfalse.s  IL_0011
  // sequence point: Console.WriteLine();
  IL_000b:  call       ""void System.Console.WriteLine()""
  IL_0010:  nop
  // sequence point: }
  IL_0011:  ret
}
", sequencePoints: "Program.Test", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 93149, 94264);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_93506_93561(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 93506, 93561);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_93578_94252(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 93578, 94252);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 93149, 94264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 93149, 94264);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void ElseConditionalInAsyncMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 94276, 99578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 94435, 94707);

                var
                source = f_23129_94448_94706(@"
using System;

class Program
{
    public static async void Test()
    {
        int i = 0;

        if (i != 0)
            Console.WriteLine(""one"");
        else
            Console.WriteLine(""other"");
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 94721, 94785);

                var
                v = f_23129_94729_94784(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 94801, 97218);

                f_23129_94801_97217(
                            v, "Program.<Test>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()", @"
{
  // Code size       99 (0x63)
  .maxstack  2
  .locals init (int V_0,
                bool V_1,
                System.Exception V_2)
  // sequence point: <hidden>
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int Program.<Test>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: {
    IL_0007:  nop
    // sequence point: int i = 0;
    IL_0008:  ldarg.0
    IL_0009:  ldc.i4.0
    IL_000a:  stfld      ""int Program.<Test>d__0.<i>5__1""
    // sequence point: if (i != 0)
    IL_000f:  ldarg.0
    IL_0010:  ldfld      ""int Program.<Test>d__0.<i>5__1""
    IL_0015:  ldc.i4.0
    IL_0016:  cgt.un
    IL_0018:  stloc.1
    // sequence point: <hidden>
    IL_0019:  ldloc.1
    IL_001a:  brfalse.s  IL_0029
    // sequence point: Console.WriteLine(""one"");
    IL_001c:  ldstr      ""one""
    IL_0021:  call       ""void System.Console.WriteLine(string)""
    IL_0026:  nop
    // sequence point: <hidden>
    IL_0027:  br.s       IL_0034
    // sequence point: Console.WriteLine(""other"");
    IL_0029:  ldstr      ""other""
    IL_002e:  call       ""void System.Console.WriteLine(string)""
    IL_0033:  nop
    // sequence point: <hidden>
    IL_0034:  leave.s    IL_004e
  }
  catch System.Exception
  {
    // async: catch handler, sequence point: <hidden>
    IL_0036:  stloc.2
    IL_0037:  ldarg.0
    IL_0038:  ldc.i4.s   -2
    IL_003a:  stfld      ""int Program.<Test>d__0.<>1__state""
    IL_003f:  ldarg.0
    IL_0040:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
    IL_0045:  ldloc.2
    IL_0046:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetException(System.Exception)""
    IL_004b:  nop
    IL_004c:  leave.s    IL_0062
  }
  // sequence point: }
  IL_004e:  ldarg.0
  IL_004f:  ldc.i4.s   -2
  IL_0051:  stfld      ""int Program.<Test>d__0.<>1__state""
  // sequence point: <hidden>
  IL_0056:  ldarg.0
  IL_0057:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
  IL_005c:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetResult()""
  IL_0061:  nop
  IL_0062:  ret
}
", sequencePoints: "Program+<Test>d__0.MoveNext", source: source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 97234, 99567);

                f_23129_97234_99566(
                            v, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Test"">
      <customDebugInfo>
        <forwardIterator name=""&lt;Test&gt;d__0"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
      </customDebugInfo>
    </method>
    <method containingType=""Program+&lt;Test&gt;d__0"" name=""MoveNext"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <hoistedLocalScopes>
          <slot startOffset=""0x0"" endOffset=""0x63"" />
        </hoistedLocalScopes>
        <encLocalSlotMap>
          <slot kind=""27"" offset=""0"" />
          <slot kind=""1"" offset=""33"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x7"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x8"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""19"" document=""1"" />
        <entry offset=""0xf"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""20"" document=""1"" />
        <entry offset=""0x19"" hidden=""true"" document=""1"" />
        <entry offset=""0x1c"" startLine=""11"" startColumn=""13"" endLine=""11"" endColumn=""38"" document=""1"" />
        <entry offset=""0x27"" hidden=""true"" document=""1"" />
        <entry offset=""0x29"" startLine=""13"" startColumn=""13"" endLine=""13"" endColumn=""40"" document=""1"" />
        <entry offset=""0x34"" hidden=""true"" document=""1"" />
        <entry offset=""0x36"" hidden=""true"" document=""1"" />
        <entry offset=""0x4e"" startLine=""14"" startColumn=""5"" endLine=""14"" endColumn=""6"" document=""1"" />
        <entry offset=""0x56"" hidden=""true"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x63"">
        <namespace name=""System"" />
      </scope>
      <asyncInfo>
        <catchHandler offset=""0x36"" />
        <kickoffMethod declaringType=""Program"" methodName=""Test"" />
      </asyncInfo>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 94276, 99578);

                string
                f_23129_94448_94706(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 94448, 94706);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_94729_94784(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 94729, 94784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_94801_97217(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 94801, 97217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_97234_99566(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 97234, 99566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 94276, 99578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 94276, 99578);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void ConditionalInTry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 99590, 103206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 99737, 100005);

                var
                source = f_23129_99750_100004(@"
using System;

class Program
{
    public static void Test()
    {
        try
        {
            int i = 0;

            if (i != 0)
                Console.WriteLine();
        }
        catch { }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 100019, 100083);

                var
                v = f_23129_100027_100082(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 100099, 101141);

                f_23129_100099_101140(
                            v, "Program.Test", @"
{
  // Code size       27 (0x1b)
  .maxstack  2
  .locals init (int V_0, //i
                bool V_1)
  // sequence point: {
  IL_0000:  nop
  .try
  {
    // sequence point: {
    IL_0001:  nop
    // sequence point: int i = 0;
    IL_0002:  ldc.i4.0
    IL_0003:  stloc.0
    // sequence point: if (i != 0)
    IL_0004:  ldloc.0
    IL_0005:  ldc.i4.0
    IL_0006:  cgt.un
    IL_0008:  stloc.1
    // sequence point: <hidden>
    IL_0009:  ldloc.1
    IL_000a:  brfalse.s  IL_0012
    // sequence point: Console.WriteLine();
    IL_000c:  call       ""void System.Console.WriteLine()""
    IL_0011:  nop
    // sequence point: }
    IL_0012:  nop
    IL_0013:  leave.s    IL_001a
  }
  catch object
  {
    // sequence point: catch
    IL_0015:  pop
    // sequence point: {
    IL_0016:  nop
    // sequence point: }
    IL_0017:  nop
    IL_0018:  leave.s    IL_001a
  }
  // sequence point: }
  IL_001a:  ret
}
", sequencePoints: "Program.Test", source: source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 101157, 103195);

                f_23129_101157_103194(
                            v, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Test"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""43"" />
          <slot kind=""1"" offset=""65"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""23"" document=""1"" />
        <entry offset=""0x4"" startLine=""12"" startColumn=""13"" endLine=""12"" endColumn=""24"" document=""1"" />
        <entry offset=""0x9"" hidden=""true"" document=""1"" />
        <entry offset=""0xc"" startLine=""13"" startColumn=""17"" endLine=""13"" endColumn=""37"" document=""1"" />
        <entry offset=""0x12"" startLine=""14"" startColumn=""9"" endLine=""14"" endColumn=""10"" document=""1"" />
        <entry offset=""0x15"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""14"" document=""1"" />
        <entry offset=""0x16"" startLine=""15"" startColumn=""15"" endLine=""15"" endColumn=""16"" document=""1"" />
        <entry offset=""0x17"" startLine=""15"" startColumn=""17"" endLine=""15"" endColumn=""18"" document=""1"" />
        <entry offset=""0x1a"" startLine=""16"" startColumn=""5"" endLine=""16"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x1b"">
        <namespace name=""System"" />
        <scope startOffset=""0x1"" endOffset=""0x13"">
          <local name=""i"" il_index=""0"" il_start=""0x1"" il_end=""0x13"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 99590, 103206);

                string
                f_23129_99750_100004(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 99750, 100004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_100027_100082(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 100027, 100082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_100099_101140(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 100099, 101140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_101157_103194(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 101157, 103194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 99590, 103206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 99590, 103206);
            }
        }

        [WorkItem(544937, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/544937")]
        [Fact]
        public void ForEachStatement_MultiDimensionalArrayBreakAndContinue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 103218, 107258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 103419, 103794);

                var
                source = @"
using System;

class C
{
    static void Main()
    {
        int[, ,] array = new[,,]
        {
            { {1, 2}, {3, 4} },
            { {5, 6}, {7, 8} },
        };

        foreach (int i in array)
        {
            if (i % 2 == 1) continue;
            if (i > 4) break;
            Console.WriteLine(i);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 103808, 103897);

                var
                v = f_23129_103816_103896(this, source, options: f_23129_103850_103895(TestOptions.DebugDll, "MODULE"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 104107, 107247);

                f_23129_104107_107246(
                            // Stepping:
                            //   After "continue", step to "in".
                            //   After "break", step to first sequence point following loop body (in this case, method close brace).
                            v, "C.Main", @"
{
  // Code size      169 (0xa9)
  .maxstack  4
  .locals init (int[,,] V_0, //array
                int[,,] V_1,
                int V_2,
                int V_3,
                int V_4,
                int V_5,
                int V_6,
                int V_7,
                int V_8, //i
                bool V_9,
                bool V_10)
 -IL_0000:  nop
 -IL_0001:  ldc.i4.2
  IL_0002:  ldc.i4.2
  IL_0003:  ldc.i4.2
  IL_0004:  newobj     ""int[*,*,*]..ctor""
  IL_0009:  dup
  IL_000a:  ldtoken    ""<PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>.8B4B2444E57AED8C2D05A1293255DA1B048C63224317D4666230760935FA4A18""
  IL_000f:  call       ""void System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(System.Array, System.RuntimeFieldHandle)""
  IL_0014:  stloc.0
 -IL_0015:  nop
 -IL_0016:  ldloc.0
  IL_0017:  stloc.1
  IL_0018:  ldloc.1
  IL_0019:  ldc.i4.0
  IL_001a:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_001f:  stloc.2
  IL_0020:  ldloc.1
  IL_0021:  ldc.i4.1
  IL_0022:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_0027:  stloc.3
  IL_0028:  ldloc.1
  IL_0029:  ldc.i4.2
  IL_002a:  callvirt   ""int System.Array.GetUpperBound(int)""
  IL_002f:  stloc.s    V_4
  IL_0031:  ldloc.1
  IL_0032:  ldc.i4.0
  IL_0033:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_0038:  stloc.s    V_5
 ~IL_003a:  br.s       IL_00a3
  IL_003c:  ldloc.1
  IL_003d:  ldc.i4.1
  IL_003e:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_0043:  stloc.s    V_6
 ~IL_0045:  br.s       IL_0098
  IL_0047:  ldloc.1
  IL_0048:  ldc.i4.2
  IL_0049:  callvirt   ""int System.Array.GetLowerBound(int)""
  IL_004e:  stloc.s    V_7
 ~IL_0050:  br.s       IL_008c
 -IL_0052:  ldloc.1
  IL_0053:  ldloc.s    V_5
  IL_0055:  ldloc.s    V_6
  IL_0057:  ldloc.s    V_7
  IL_0059:  call       ""int[*,*,*].Get""
  IL_005e:  stloc.s    V_8
 -IL_0060:  nop
 -IL_0061:  ldloc.s    V_8
  IL_0063:  ldc.i4.2
  IL_0064:  rem
  IL_0065:  ldc.i4.1
  IL_0066:  ceq
  IL_0068:  stloc.s    V_9
 ~IL_006a:  ldloc.s    V_9
  IL_006c:  brfalse.s  IL_0070
 -IL_006e:  br.s       IL_0086
 -IL_0070:  ldloc.s    V_8
  IL_0072:  ldc.i4.4
  IL_0073:  cgt
  IL_0075:  stloc.s    V_10
 ~IL_0077:  ldloc.s    V_10
  IL_0079:  brfalse.s  IL_007d
 -IL_007b:  br.s       IL_00a8
 -IL_007d:  ldloc.s    V_8
  IL_007f:  call       ""void System.Console.WriteLine(int)""
  IL_0084:  nop
 -IL_0085:  nop
 ~IL_0086:  ldloc.s    V_7
  IL_0088:  ldc.i4.1
  IL_0089:  add
  IL_008a:  stloc.s    V_7
 -IL_008c:  ldloc.s    V_7
  IL_008e:  ldloc.s    V_4
  IL_0090:  ble.s      IL_0052
 ~IL_0092:  ldloc.s    V_6
  IL_0094:  ldc.i4.1
  IL_0095:  add
  IL_0096:  stloc.s    V_6
 -IL_0098:  ldloc.s    V_6
  IL_009a:  ldloc.3
  IL_009b:  ble.s      IL_0047
 ~IL_009d:  ldloc.s    V_5
  IL_009f:  ldc.i4.1
  IL_00a0:  add
  IL_00a1:  stloc.s    V_5
 -IL_00a3:  ldloc.s    V_5
  IL_00a5:  ldloc.2
  IL_00a6:  ble.s      IL_003c
 -IL_00a8:  ret
}
", sequencePoints: "C.Main");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 103218, 107258);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23129_103850_103895(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, string
                moduleName)
                {
                    var return_v = this_param.WithModuleName(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 103850, 103895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_103816_103896(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 103816, 103896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_104107_107246(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 104107, 107246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 103218, 107258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 103218, 107258);
            }
        }

        [Fact]
        public void ForEachStatement_Enumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 107270, 109420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 107352, 107573);

                var
                source = @"
public class C
{
    public static void Main()
    {
        foreach (var x in new System.Collections.Generic.List<int>())
        {
            System.Console.WriteLine(x);
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 107589, 107653);

                var
                v = f_23129_107597_107652(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 108151, 109409);

                f_23129_108151_109408(
                            // Sequence points:
                            // 1) Open brace at start of method
                            // 2) 'foreach'
                            // 3) 'new System.Collections.Generic.List<int>()'
                            // 4) Hidden initial jump (of while loop)
                            // 5) 'var c'
                            // 6) Open brace of loop
                            // 7) Loop body
                            // 8) Close brace of loop
                            // 9) 'in'
                            // 10) hidden point in Finally
                            // 11) Close brace at end of method

                            v, "C.Main", @"
{
  // Code size       59 (0x3b)
  .maxstack  1
  .locals init (System.Collections.Generic.List<int>.Enumerator V_0,
                int V_1) //x
 -IL_0000:  nop
 -IL_0001:  nop
 -IL_0002:  newobj     ""System.Collections.Generic.List<int>..ctor()""
  IL_0007:  call       ""System.Collections.Generic.List<int>.Enumerator System.Collections.Generic.List<int>.GetEnumerator()""
  IL_000c:  stloc.0
  .try
  {
   ~IL_000d:  br.s       IL_0020
   -IL_000f:  ldloca.s   V_0
    IL_0011:  call       ""int System.Collections.Generic.List<int>.Enumerator.Current.get""
    IL_0016:  stloc.1
   -IL_0017:  nop
   -IL_0018:  ldloc.1
    IL_0019:  call       ""void System.Console.WriteLine(int)""
    IL_001e:  nop
   -IL_001f:  nop
   -IL_0020:  ldloca.s   V_0
    IL_0022:  call       ""bool System.Collections.Generic.List<int>.Enumerator.MoveNext()""
    IL_0027:  brtrue.s   IL_000f
    IL_0029:  leave.s    IL_003a
  }
  finally
  {
   ~IL_002b:  ldloca.s   V_0
    IL_002d:  constrained. ""System.Collections.Generic.List<int>.Enumerator""
    IL_0033:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0038:  nop
    IL_0039:  endfinally
  }
 -IL_003a:  ret
}
", sequencePoints: "C.Main");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 107270, 109420);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_107597_107652(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 107597, 107652);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_108151_109408(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 108151, 109408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 107270, 109420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 107270, 109420);
            }
        }

        [WorkItem(718501, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/718501")]
        [Fact]
        public void ForEachNops()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 109432, 113566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 109590, 110227);

                string
                source = f_23129_109606_110226(@"
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<List<int>> l = new List<List<int>>();

    static void Main(string[] args)
        {
            foreach (var i in l.AsEnumerable())
            {
                switch (i.Count)
                {
                    case 1:
                        break;

                    default:
                        if (i.Count != 0)
                        {
                        }

                        break;
                }
            }
        }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 110313, 110405);

                var
                c = f_23129_110321_110404(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 110419, 113555);

                f_23129_110419_113554(c, "Program.Main", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Main"" parameterNames=""args"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""3"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""5"" offset=""15"" />
          <slot kind=""0"" offset=""15"" />
          <slot kind=""35"" offset=""83"" />
          <slot kind=""1"" offset=""83"" />
          <slot kind=""1"" offset=""237"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1"" startLine=""12"" startColumn=""13"" endLine=""12"" endColumn=""20"" document=""1"" />
        <entry offset=""0x2"" startLine=""12"" startColumn=""31"" endLine=""12"" endColumn=""47"" document=""1"" />
        <entry offset=""0x12"" hidden=""true"" document=""1"" />
        <entry offset=""0x14"" startLine=""12"" startColumn=""22"" endLine=""12"" endColumn=""27"" document=""1"" />
        <entry offset=""0x1b"" startLine=""13"" startColumn=""13"" endLine=""13"" endColumn=""14"" document=""1"" />
        <entry offset=""0x1c"" startLine=""14"" startColumn=""17"" endLine=""14"" endColumn=""33"" document=""1"" />
        <entry offset=""0x23"" hidden=""true"" document=""1"" />
        <entry offset=""0x25"" hidden=""true"" document=""1"" />
        <entry offset=""0x2b"" startLine=""17"" startColumn=""25"" endLine=""17"" endColumn=""31"" document=""1"" />
        <entry offset=""0x2d"" startLine=""20"" startColumn=""25"" endLine=""20"" endColumn=""42"" document=""1"" />
        <entry offset=""0x38"" hidden=""true"" document=""1"" />
        <entry offset=""0x3c"" startLine=""21"" startColumn=""25"" endLine=""21"" endColumn=""26"" document=""1"" />
        <entry offset=""0x3d"" startLine=""22"" startColumn=""25"" endLine=""22"" endColumn=""26"" document=""1"" />
        <entry offset=""0x3e"" startLine=""24"" startColumn=""25"" endLine=""24"" endColumn=""31"" document=""1"" />
        <entry offset=""0x40"" startLine=""26"" startColumn=""13"" endLine=""26"" endColumn=""14"" document=""1"" />
        <entry offset=""0x41"" startLine=""12"" startColumn=""28"" endLine=""12"" endColumn=""30"" document=""1"" />
        <entry offset=""0x4b"" hidden=""true"" document=""1"" />
        <entry offset=""0x55"" hidden=""true"" document=""1"" />
        <entry offset=""0x56"" startLine=""27"" startColumn=""9"" endLine=""27"" endColumn=""10"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x57"">
        <namespace name=""System"" />
        <namespace name=""System.Collections.Generic"" />
        <namespace name=""System.Linq"" />
        <scope startOffset=""0x14"" endOffset=""0x41"">
          <local name=""i"" il_index=""1"" il_start=""0x14"" il_end=""0x41"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 109432, 113566);

                string
                f_23129_109606_110226(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 109606, 110226);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_110321_110404(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 110321, 110404);
                    return return_v;
                }


                bool
                f_23129_110419_113554(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 110419, 113554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 109432, 113566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 109432, 113566);
            }
        }

        [Fact]
        public void ForEachStatement_Deconstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 113578, 118688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 113664, 113959);

                var
                source = f_23129_113677_113958(@"
public class C
{
    public static (int, (bool, double))[] F() => new[] { (1, (true, 2.0)) };

    public static void Main()
    {
        foreach (var (c, (d, e)) in F())
        {
            System.Console.WriteLine(c);
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 113973, 114038);

                var
                c = f_23129_113981_114037(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 114052, 114080);

                var
                v = f_23129_114060_114079(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 114096, 116028);

                f_23129_114096_116027(
                            v, "C.Main", @"
{
  // Code size       70 (0x46)
  .maxstack  2
  .locals init (System.ValueTuple<int, System.ValueTuple<bool, double>>[] V_0,
                int V_1,
                int V_2, //c
                bool V_3, //d
                double V_4, //e
                System.ValueTuple<bool, double> V_5)
  // sequence point: {
  IL_0000:  nop
  // sequence point: foreach
  IL_0001:  nop
  // sequence point: F()
  IL_0002:  call       ""System.ValueTuple<int, System.ValueTuple<bool, double>>[] C.F()""
  IL_0007:  stloc.0
  IL_0008:  ldc.i4.0
  IL_0009:  stloc.1
  // sequence point: <hidden>
  IL_000a:  br.s       IL_003f
  // sequence point: var (c, (d, e))
  IL_000c:  ldloc.0
  IL_000d:  ldloc.1
  IL_000e:  ldelem     ""System.ValueTuple<int, System.ValueTuple<bool, double>>""
  IL_0013:  dup
  IL_0014:  ldfld      ""System.ValueTuple<bool, double> System.ValueTuple<int, System.ValueTuple<bool, double>>.Item2""
  IL_0019:  stloc.s    V_5
  IL_001b:  ldfld      ""int System.ValueTuple<int, System.ValueTuple<bool, double>>.Item1""
  IL_0020:  stloc.2
  IL_0021:  ldloc.s    V_5
  IL_0023:  ldfld      ""bool System.ValueTuple<bool, double>.Item1""
  IL_0028:  stloc.3
  IL_0029:  ldloc.s    V_5
  IL_002b:  ldfld      ""double System.ValueTuple<bool, double>.Item2""
  IL_0030:  stloc.s    V_4
  // sequence point: {
  IL_0032:  nop
  // sequence point: System.Console.WriteLine(c);
  IL_0033:  ldloc.2
  IL_0034:  call       ""void System.Console.WriteLine(int)""
  IL_0039:  nop
  // sequence point: }
  IL_003a:  nop
  // sequence point: <hidden>
  IL_003b:  ldloc.1
  IL_003c:  ldc.i4.1
  IL_003d:  add
  IL_003e:  stloc.1
  // sequence point: in
  IL_003f:  ldloc.1
  IL_0040:  ldloc.0
  IL_0041:  ldlen
  IL_0042:  conv.i4
  IL_0043:  blt.s      IL_000c
  // sequence point: }
  IL_0045:  ret
}
", sequencePoints: "C.Main", source: source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 116044, 118677);

                f_23129_116044_118676(
                            v, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""50"" endLine=""4"" endColumn=""76"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""F"" />
        <encLocalSlotMap>
          <slot kind=""6"" offset=""11"" />
          <slot kind=""8"" offset=""11"" />
          <slot kind=""0"" offset=""25"" />
          <slot kind=""0"" offset=""29"" />
          <slot kind=""0"" offset=""32"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""16"" document=""1"" />
        <entry offset=""0x2"" startLine=""8"" startColumn=""37"" endLine=""8"" endColumn=""40"" document=""1"" />
        <entry offset=""0xa"" hidden=""true"" document=""1"" />
        <entry offset=""0xc"" startLine=""8"" startColumn=""18"" endLine=""8"" endColumn=""33"" document=""1"" />
        <entry offset=""0x32"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x33"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""41"" document=""1"" />
        <entry offset=""0x3a"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0x3b"" hidden=""true"" document=""1"" />
        <entry offset=""0x3f"" startLine=""8"" startColumn=""34"" endLine=""8"" endColumn=""36"" document=""1"" />
        <entry offset=""0x45"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x46"">
        <scope startOffset=""0xc"" endOffset=""0x3b"">
          <local name=""c"" il_index=""2"" il_start=""0xc"" il_end=""0x3b"" attributes=""0"" />
          <local name=""d"" il_index=""3"" il_start=""0xc"" il_end=""0x3b"" attributes=""0"" />
          <local name=""e"" il_index=""4"" il_start=""0xc"" il_end=""0x3b"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 113578, 118688);

                string
                f_23129_113677_113958(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 113677, 113958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_113981_114037(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 113981, 114037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_114060_114079(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 114060, 114079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_114096_116027(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 114096, 116027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_116044_118676(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 116044, 118676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 113578, 118688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 113578, 118688);
            }
        }

        [Fact]
        public void SwitchWithPattern_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 118748, 122600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 118823, 119773);

                string
                source = f_23129_118839_119772(@"
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<List<int>> l = new List<List<int>>();

    static void Main(string[] args)
    {
        Student s = new Student();
        s.Name = ""Bozo"";
        s.GPA = 2.3;
        Operate(s);  
    }

    static string Operate(Person p)
    {
        switch (p)
        {
            case Student s when s.GPA > 3.5:
                return $""Student {s.Name} ({s.GPA:N1})"";
            case Student s:
                return $""Student {s.Name} ({s.GPA:N1})"";
            case Teacher t:
                return $""Teacher {t.Name} of {t.Subject}"";
            default:
                return $""Person {p.Name}"";
        }
    }
}

class Person { public string Name; }
class Teacher : Person { public string Subject; }
class Student : Person { public double GPA; }
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 119859, 119951);

                var
                c = f_23129_119867_119950(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 119965, 122589);

                f_23129_119965_122588(c, "Program.Operate", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Operate"" parameterNames=""p"">
      <customDebugInfo>
        <forward declaringType=""Program"" methodName=""Main"" parameterNames=""args"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""59"" />
          <slot kind=""0"" offset=""163"" />
          <slot kind=""0"" offset=""250"" />
          <slot kind=""35"" offset=""11"" />
          <slot kind=""1"" offset=""11"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""19"" startColumn=""5"" endLine=""19"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""20"" startColumn=""9"" endLine=""20"" endColumn=""19"" document=""1"" />
        <entry offset=""0x4"" hidden=""true"" document=""1"" />
        <entry offset=""0x7"" hidden=""true"" document=""1"" />
        <entry offset=""0x1d"" startLine=""22"" startColumn=""28"" endLine=""22"" endColumn=""44"" document=""1"" />
        <entry offset=""0x2e"" hidden=""true"" document=""1"" />
        <entry offset=""0x30"" startLine=""23"" startColumn=""17"" endLine=""23"" endColumn=""57"" document=""1"" />
        <entry offset=""0x4f"" hidden=""true"" document=""1"" />
        <entry offset=""0x53"" startLine=""25"" startColumn=""17"" endLine=""25"" endColumn=""57"" document=""1"" />
        <entry offset=""0x72"" hidden=""true"" document=""1"" />
        <entry offset=""0x74"" startLine=""27"" startColumn=""17"" endLine=""27"" endColumn=""59"" document=""1"" />
        <entry offset=""0x93"" startLine=""29"" startColumn=""17"" endLine=""29"" endColumn=""43"" document=""1"" />
        <entry offset=""0xa7"" startLine=""31"" startColumn=""5"" endLine=""31"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xaa"">
        <scope startOffset=""0x1d"" endOffset=""0x4f"">
          <local name=""s"" il_index=""0"" il_start=""0x1d"" il_end=""0x4f"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x4f"" endOffset=""0x72"">
          <local name=""s"" il_index=""1"" il_start=""0x4f"" il_end=""0x72"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x72"" endOffset=""0x93"">
          <local name=""t"" il_index=""2"" il_start=""0x72"" il_end=""0x93"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 118748, 122600);

                string
                f_23129_118839_119772(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 118839, 119772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_119867_119950(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 119867, 119950);
                    return return_v;
                }


                bool
                f_23129_119965_122588(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 119965, 122588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 118748, 122600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 118748, 122600);
            }
        }

        [Fact]
        public void SwitchWithPattern_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 122612, 126628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 122687, 123674);

                string
                source = f_23129_122703_123673(@"
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<List<int>> l = new List<List<int>>();

    static void Main(string[] args)
    {
        Student s = new Student();
        s.Name = ""Bozo"";
        s.GPA = 2.3;
        Operate(s);  
    }

    static System.Func<string> Operate(Person p)
    {
        switch (p)
        {
            case Student s when s.GPA > 3.5:
                return () => $""Student {s.Name} ({s.GPA:N1})"";
            case Student s:
                return () => $""Student {s.Name} ({s.GPA:N1})"";
            case Teacher t:
                return () => $""Teacher {t.Name} of {t.Subject}"";
            default:
                return () => $""Person {p.Name}"";
        }
    }
}

class Person { public string Name; }
class Teacher : Person { public string Subject; }
class Student : Person { public double GPA; }
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 123760, 123852);

                var
                c = f_23129_123768_123851(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 123866, 126617);

                f_23129_123866_126616(c, "Program.Operate", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Operate"" parameterNames=""p"">
      <customDebugInfo>
        <forward declaringType=""Program"" methodName=""Main"" parameterNames=""args"" />
        <encLocalSlotMap>
          <slot kind=""30"" offset=""0"" />
          <slot kind=""30"" offset=""11"" />
          <slot kind=""35"" offset=""11"" />
          <slot kind=""1"" offset=""11"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
        <encLambdaMap>
          <methodOrdinal>2</methodOrdinal>
          <closure offset=""0"" />
          <closure offset=""11"" />
          <lambda offset=""109"" closure=""1"" />
          <lambda offset=""202"" closure=""1"" />
          <lambda offset=""295"" closure=""1"" />
          <lambda offset=""383"" closure=""0"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0xd"" startLine=""19"" startColumn=""5"" endLine=""19"" endColumn=""6"" document=""1"" />
        <entry offset=""0xe"" hidden=""true"" document=""1"" />
        <entry offset=""0x1b"" hidden=""true"" document=""1"" />
        <entry offset=""0x1d"" hidden=""true"" document=""1"" />
        <entry offset=""0x47"" startLine=""22"" startColumn=""28"" endLine=""22"" endColumn=""44"" document=""1"" />
        <entry offset=""0x5d"" hidden=""true"" document=""1"" />
        <entry offset=""0x5f"" startLine=""23"" startColumn=""17"" endLine=""23"" endColumn=""63"" document=""1"" />
        <entry offset=""0x6f"" hidden=""true"" document=""1"" />
        <entry offset=""0x7d"" startLine=""25"" startColumn=""17"" endLine=""25"" endColumn=""63"" document=""1"" />
        <entry offset=""0x8d"" hidden=""true"" document=""1"" />
        <entry offset=""0x8f"" startLine=""27"" startColumn=""17"" endLine=""27"" endColumn=""65"" document=""1"" />
        <entry offset=""0x9f"" startLine=""29"" startColumn=""17"" endLine=""29"" endColumn=""49"" document=""1"" />
        <entry offset=""0xaf"" startLine=""31"" startColumn=""5"" endLine=""31"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xb2"">
        <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0xb2"" attributes=""0"" />
        <scope startOffset=""0xe"" endOffset=""0xaf"">
          <local name=""CS$&lt;&gt;8__locals1"" il_index=""1"" il_start=""0xe"" il_end=""0xaf"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 122612, 126628);

                string
                f_23129_122703_123673(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 122703, 123673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_123768_123851(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 123768, 123851);
                    return return_v;
                }


                bool
                f_23129_123866_126616(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 123866, 126616);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 122612, 126628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 122612, 126628);
            }
        }

        [Fact]
        public void SwitchWithPatternAndLocalFunctions()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 126640, 130857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 126729, 127836);

                string
                source = f_23129_126745_127835(@"
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<List<int>> l = new List<List<int>>();

    static void Main(string[] args)
    {
        Student s = new Student();
        s.Name = ""Bozo"";
        s.GPA = 2.3;
        Operate(s);  
    }

    static System.Func<string> Operate(Person p)
    {
        switch (p)
        {
            case Student s when s.GPA > 3.5:
                string f1() => $""Student {s.Name} ({s.GPA:N1})"";
                return f1;
            case Student s:
                string f2() => $""Student {s.Name} ({s.GPA:N1})"";
                return f2;
            case Teacher t:
                string f3() => $""Teacher {t.Name} of {t.Subject}"";
                return f3;
            default:
                string f4() => $""Person {p.Name}"";
                return f4;
        }
    }
}

class Person { public string Name; }
class Teacher : Person { public string Subject; }
class Student : Person { public double GPA; }
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 127922, 128014);

                var
                c = f_23129_127930_128013(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 128028, 130846);

                f_23129_128028_130845(c, "Program.Operate", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Operate"" parameterNames=""p"">
      <customDebugInfo>
        <forward declaringType=""Program"" methodName=""Main"" parameterNames=""args"" />
        <encLocalSlotMap>
          <slot kind=""30"" offset=""0"" />
          <slot kind=""30"" offset=""11"" />
          <slot kind=""35"" offset=""11"" />
          <slot kind=""1"" offset=""11"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
        <encLambdaMap>
          <methodOrdinal>2</methodOrdinal>
          <closure offset=""0"" />
          <closure offset=""11"" />
          <lambda offset=""111"" closure=""1"" />
          <lambda offset=""234"" closure=""1"" />
          <lambda offset=""357"" closure=""1"" />
          <lambda offset=""475"" closure=""0"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0xd"" startLine=""19"" startColumn=""5"" endLine=""19"" endColumn=""6"" document=""1"" />
        <entry offset=""0xe"" hidden=""true"" document=""1"" />
        <entry offset=""0x1b"" hidden=""true"" document=""1"" />
        <entry offset=""0x1d"" hidden=""true"" document=""1"" />
        <entry offset=""0x47"" startLine=""22"" startColumn=""28"" endLine=""22"" endColumn=""44"" document=""1"" />
        <entry offset=""0x5d"" hidden=""true"" document=""1"" />
        <entry offset=""0x60"" startLine=""24"" startColumn=""17"" endLine=""24"" endColumn=""27"" document=""1"" />
        <entry offset=""0x70"" hidden=""true"" document=""1"" />
        <entry offset=""0x7f"" startLine=""27"" startColumn=""17"" endLine=""27"" endColumn=""27"" document=""1"" />
        <entry offset=""0x8f"" hidden=""true"" document=""1"" />
        <entry offset=""0x92"" startLine=""30"" startColumn=""17"" endLine=""30"" endColumn=""27"" document=""1"" />
        <entry offset=""0xa2"" hidden=""true"" document=""1"" />
        <entry offset=""0xa3"" startLine=""33"" startColumn=""17"" endLine=""33"" endColumn=""27"" document=""1"" />
        <entry offset=""0xb3"" startLine=""35"" startColumn=""5"" endLine=""35"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xb6"">
        <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0xb6"" attributes=""0"" />
        <scope startOffset=""0xe"" endOffset=""0xb3"">
          <local name=""CS$&lt;&gt;8__locals1"" il_index=""1"" il_start=""0xe"" il_end=""0xb3"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 126640, 130857);

                string
                f_23129_126745_127835(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 126745, 127835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_127930_128013(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 127930, 128013);
                    return return_v;
                }


                bool
                f_23129_128028_130845(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 128028, 130845);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 126640, 130857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 126640, 130857);
            }
        }

        [WorkItem(17090, "https://github.com/dotnet/roslyn/issues/17090"), WorkItem(19731, "https://github.com/dotnet/roslyn/issues/19731")]
        [Fact]
        public void SwitchWithConstantPattern()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 130869, 134180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 131091, 131805);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        M1();
        M2();
    }

    static void M1()
    {
        switch
            (1)
        {
            case 0 when true:
                ;
            case 1:
                Console.Write(1);
                break;
            case 2:
                ;
        }
    }

    static void M2()
    {
        switch
            (nameof(M2))
        {
            case nameof(M1) when true:
                ;
            case nameof(M2):
                Console.Write(nameof(M2));
                break;
            case nameof(Main):
                ;
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 131819, 131911);

                var
                c = f_23129_131827_131910(source, options: TestOptions.DebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 131925, 131947);

                f_23129_131925_131946(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 131961, 132019);

                var
                verifier = f_23129_131976_132018(this, c, expectedOutput: "1M2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 132035, 132732);

                f_23129_132035_132731(
                            verifier, qualifiedMethodName: "Program.M1", sequencePoints: "Program.M1", source: source, expectedIL: @"{
  // Code size       17 (0x11)
  .maxstack  1
  .locals init (int V_0,
                int V_1)
  // sequence point: {
  IL_0000:  nop
  // sequence point: switch ...           (1
  IL_0001:  ldc.i4.1
  IL_0002:  stloc.1
  IL_0003:  ldc.i4.1
  IL_0004:  stloc.0
  // sequence point: <hidden>
  IL_0005:  br.s       IL_0007
  // sequence point: Console.Write(1);
  IL_0007:  ldc.i4.1
  IL_0008:  call       ""void System.Console.Write(int)""
  IL_000d:  nop
  // sequence point: break;
  IL_000e:  br.s       IL_0010
  // sequence point: }
  IL_0010:  ret
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 132746, 133488);

                f_23129_132746_133487(verifier, qualifiedMethodName: "Program.M2", sequencePoints: "Program.M2", source: source, expectedIL: @"{
  // Code size       29 (0x1d)
  .maxstack  1
  .locals init (string V_0,
                string V_1)
  // sequence point: {
  IL_0000:  nop
  // sequence point: switch ...  (nameof(M2)
  IL_0001:  ldstr      ""M2""
  IL_0006:  stloc.1
  IL_0007:  ldstr      ""M2""
  IL_000c:  stloc.0
  // sequence point: <hidden>
  IL_000d:  br.s       IL_000f
  // sequence point: Console.Write(nameof(M2));
  IL_000f:  ldstr      ""M2""
  IL_0014:  call       ""void System.Console.Write(string)""
  IL_0019:  nop
  // sequence point: break;
  IL_001a:  br.s       IL_001c
  // sequence point: }
  IL_001c:  ret
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 133559, 133649);

                c = f_23129_133563_133648(source, options: TestOptions.ReleaseExe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 133663, 133685);

                f_23129_133663_133684(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 133699, 133753);

                verifier = f_23129_133710_133752(this, c, expectedOutput: "1M2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 133769, 133956);

                f_23129_133769_133955(
                            verifier, "Program.M1", @"{
  // Code size        7 (0x7)
  .maxstack  1
  IL_0000:  ldc.i4.1
  IL_0001:  call       ""void System.Console.Write(int)""
  IL_0006:  ret
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 133970, 134169);

                f_23129_133970_134168(verifier, "Program.M2", @"{
  // Code size       11 (0xb)
  .maxstack  1
  IL_0000:  ldstr      ""M2""
  IL_0005:  call       ""void System.Console.Write(string)""
  IL_000a:  ret
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 130869, 134180);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_131827_131910(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 131827, 131910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_131925_131946(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 131925, 131946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_131976_132018(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 131976, 132018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_132035_132731(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName: qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 132035, 132731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_132746_133487(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName: qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 132746, 133487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_133563_133648(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 133563, 133648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_133663_133684(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 133663, 133684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_133710_133752(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 133710, 133752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_133769_133955(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 133769, 133955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_133970_134168(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 133970, 134168);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 130869, 134180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 130869, 134180);
            }
        }

        [WorkItem(19734, "https://github.com/dotnet/roslyn/issues/19734")]
        [Fact]
        public void SwitchWithConstantGenericPattern_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 134192, 139313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 134358, 135134);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        M1<int>();    // 1
        M1<long>();   // 2
        M2<string>(); // 3
        M2<int>();    // 4
    }

    static void M1<T>()
    {
        switch (1)
        {
            case T t:
                Console.Write(1);
                break;
            case int i:
                Console.Write(2);
                break;
        }
    }

    static void M2<T>()
    {
        switch (nameof(M2))
        {
            case T t:
                Console.Write(3);
                break;
            case string s:
                Console.Write(4);
                break;
            case null:
                ;
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 135148, 135278);

                var
                c = f_23129_135156_135277(source, options: TestOptions.DebugExe, parseOptions: TestOptions.Regular7_1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 135292, 135314);

                f_23129_135292_135313(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 135328, 135387);

                var
                verifier = f_23129_135343_135386(this, c, expectedOutput: "1234")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 135403, 136727);

                f_23129_135403_136726(
                            verifier, qualifiedMethodName: "Program.M1<T>", sequencePoints: "Program.M1", source: source, expectedIL: @"{
  // Code size       60 (0x3c)
  .maxstack  1
  .locals init (T V_0, //t
                int V_1, //i
                int V_2)
  // sequence point: {
  IL_0000:  nop
  // sequence point: switch (1)
  IL_0001:  ldc.i4.1
  IL_0002:  stloc.2
  IL_0003:  ldc.i4.1
  IL_0004:  stloc.1
  // sequence point: <hidden>
  IL_0005:  ldloc.1
  IL_0006:  box        ""int""
  IL_000b:  isinst     ""T""
  IL_0010:  brfalse.s  IL_0030
  IL_0012:  ldloc.1
  IL_0013:  box        ""int""
  IL_0018:  isinst     ""T""
  IL_001d:  unbox.any  ""T""
  IL_0022:  stloc.0
  // sequence point: <hidden>
  IL_0023:  br.s       IL_0025
  // sequence point: <hidden>
  IL_0025:  br.s       IL_0027
  // sequence point: Console.Write(1);
  IL_0027:  ldc.i4.1
  IL_0028:  call       ""void System.Console.Write(int)""
  IL_002d:  nop
  // sequence point: break;
  IL_002e:  br.s       IL_003b
  // sequence point: <hidden>
  IL_0030:  br.s       IL_0032
  // sequence point: Console.Write(2);
  IL_0032:  ldc.i4.2
  IL_0033:  call       ""void System.Console.Write(int)""
  IL_0038:  nop
  // sequence point: break;
  IL_0039:  br.s       IL_003b
  // sequence point: }
  IL_003b:  ret
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 136741, 138034);

                f_23129_136741_138033(verifier, qualifiedMethodName: "Program.M2<T>", sequencePoints: "Program.M2", source: source, expectedIL: @"{
  // Code size       58 (0x3a)
  .maxstack  1
  .locals init (T V_0, //t
                string V_1, //s
                string V_2)
  // sequence point: {
  IL_0000:  nop
  // sequence point: switch (nameof(M2))
  IL_0001:  ldstr      ""M2""
  IL_0006:  stloc.2
  IL_0007:  ldstr      ""M2""
  IL_000c:  stloc.1
  // sequence point: <hidden>
  IL_000d:  ldloc.1
  IL_000e:  isinst     ""T""
  IL_0013:  brfalse.s  IL_002e
  IL_0015:  ldloc.1
  IL_0016:  isinst     ""T""
  IL_001b:  unbox.any  ""T""
  IL_0020:  stloc.0
  // sequence point: <hidden>
  IL_0021:  br.s       IL_0023
  // sequence point: <hidden>
  IL_0023:  br.s       IL_0025
  // sequence point: Console.Write(3);
  IL_0025:  ldc.i4.3
  IL_0026:  call       ""void System.Console.Write(int)""
  IL_002b:  nop
  // sequence point: break;
  IL_002c:  br.s       IL_0039
  // sequence point: <hidden>
  IL_002e:  br.s       IL_0030
  // sequence point: Console.Write(4);
  IL_0030:  ldc.i4.4
  IL_0031:  call       ""void System.Console.Write(int)""
  IL_0036:  nop
  // sequence point: break;
  IL_0037:  br.s       IL_0039
  // sequence point: }
  IL_0039:  ret
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 138105, 138233);

                c = f_23129_138109_138232(source, options: TestOptions.ReleaseExe, parseOptions: TestOptions.Regular7_1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 138247, 138269);

                f_23129_138247_138268(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 138283, 138338);

                verifier = f_23129_138294_138337(this, c, expectedOutput: "1234");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 138354, 138831);

                f_23129_138354_138830(
                            verifier, "Program.M1<T>", @"{
  // Code size       29 (0x1d)
  .maxstack  1
  .locals init (int V_0) //i
  IL_0000:  ldc.i4.1
  IL_0001:  stloc.0
  IL_0002:  ldloc.0
  IL_0003:  box        ""int""
  IL_0008:  isinst     ""T""
  IL_000d:  brfalse.s  IL_0016
  IL_000f:  ldc.i4.1
  IL_0010:  call       ""void System.Console.Write(int)""
  IL_0015:  ret
  IL_0016:  ldc.i4.2
  IL_0017:  call       ""void System.Console.Write(int)""
  IL_001c:  ret
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 138845, 139302);

                f_23129_138845_139301(verifier, "Program.M2<T>", @"{
  // Code size       28 (0x1c)
  .maxstack  1
  .locals init (string V_0) //s
  IL_0000:  ldstr      ""M2""
  IL_0005:  stloc.0
  IL_0006:  ldloc.0
  IL_0007:  isinst     ""T""
  IL_000c:  brfalse.s  IL_0015
  IL_000e:  ldc.i4.3
  IL_000f:  call       ""void System.Console.Write(int)""
  IL_0014:  ret
  IL_0015:  ldc.i4.4
  IL_0016:  call       ""void System.Console.Write(int)""
  IL_001b:  ret
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 134192, 139313);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_135156_135277(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 135156, 135277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_135292_135313(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 135292, 135313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_135343_135386(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 135343, 135386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_135403_136726(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName: qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 135403, 136726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_136741_138033(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName: qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 136741, 138033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_138109_138232(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 138109, 138232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_138247_138268(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 138247, 138268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_138294_138337(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 138294, 138337);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_138354_138830(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 138354, 138830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_138845_139301(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 138845, 139301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 134192, 139313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 134192, 139313);
            }
        }

        [WorkItem(19734, "https://github.com/dotnet/roslyn/issues/19734")]
        [Fact]
        public void SwitchWithConstantGenericPattern_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 139325, 141481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 139491, 139945);

                string
                source = @"
using System;

class Program
{
    static void Main(string[] args)
    {
        M2<string>(); // 6
        M2<int>();    // 6
    }

    static void M2<T>()
    {
        const string x = null;
        switch (x)
        {
            case T t:
                ;
            case string s:
                ;
            case null:
                Console.Write(6);
                break;
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 139959, 140089);

                var
                c = f_23129_139967_140088(source, options: TestOptions.DebugExe, parseOptions: TestOptions.Regular7_1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 140103, 140125);

                f_23129_140103_140124(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 140139, 140196);

                var
                verifier = f_23129_140154_140195(this, c, expectedOutput: "66")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 140212, 140962);

                f_23129_140212_140961(
                            verifier, qualifiedMethodName: "Program.M2<T>", sequencePoints: "Program.M2", source: source, expectedIL: @"{
  // Code size       17 (0x11)
  .maxstack  1
  .locals init (T V_0, //t
                string V_1, //s
                string V_2,
                string V_3)
  // sequence point: {
  IL_0000:  nop
  // sequence point: switch (x)
  IL_0001:  ldnull
  IL_0002:  stloc.3
  IL_0003:  ldnull
  IL_0004:  stloc.2
  // sequence point: <hidden>
  IL_0005:  br.s       IL_0007
  // sequence point: Console.Write(6);
  IL_0007:  ldc.i4.6
  IL_0008:  call       ""void System.Console.Write(int)""
  IL_000d:  nop
  // sequence point: break;
  IL_000e:  br.s       IL_0010
  // sequence point: }
  IL_0010:  ret
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 141033, 141161);

                c = f_23129_141037_141160(source, options: TestOptions.ReleaseExe, parseOptions: TestOptions.Regular7_1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 141175, 141197);

                f_23129_141175_141196(c);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 141211, 141264);

                verifier = f_23129_141222_141263(this, c, expectedOutput: "66");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 141280, 141470);

                f_23129_141280_141469(
                            verifier, "Program.M2<T>", @"{
  // Code size        7 (0x7)
  .maxstack  1
  IL_0000:  ldc.i4.6
  IL_0001:  call       ""void System.Console.Write(int)""
  IL_0006:  ret
}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 139325, 141481);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_139967_140088(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 139967, 140088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_140103_140124(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 140103, 140124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_140154_140195(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 140154, 140195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_140212_140961(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName: qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 140212, 140961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_141037_141160(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, parseOptions: parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 141037, 141160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_141175_141196(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 141175, 141196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_141222_141263(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedOutput)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, expectedOutput: expectedOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 141222, 141263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_141280_141469(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 141280, 141469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 139325, 141481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 139325, 141481);
            }
        }

        [Fact]
        [WorkItem(31665, "https://github.com/dotnet/roslyn/issues/31665")]
        public void TestSequencePoints_31665()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 141493, 143860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 141648, 142145);

                var
                source = @"
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var s = ""1"";
        if (true)
            switch (s)
            {
                case ""1"":
                    Console.Out.WriteLine(""Input was 1"");
                    break;
                default:
                    throw new Exception(""Default case"");
            }
        else
            Console.Out.WriteLine(""Too many inputs"");
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 142159, 142223);

                var
                v = f_23129_142167_142222(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 142239, 143849);

                f_23129_142239_143848(
                            v, "Program.Main(string[])", @"
    {
      // Code size       60 (0x3c)
      .maxstack  2
      .locals init (string V_0, //s
                    bool V_1,
                    string V_2,
                    string V_3)
      // sequence point: {
      IL_0000:  nop
      // sequence point: var s = ""1"";
      IL_0001:  ldstr      ""1""
      IL_0006:  stloc.0
      // sequence point: if (true)
      IL_0007:  ldc.i4.1
      IL_0008:  stloc.1
      // sequence point: switch (s)
      IL_0009:  ldloc.0
      IL_000a:  stloc.3
      // sequence point: <hidden>
      IL_000b:  ldloc.3
      IL_000c:  stloc.2
      // sequence point: <hidden>
      IL_000d:  ldloc.2
      IL_000e:  ldstr      ""1""
      IL_0013:  call       ""bool string.op_Equality(string, string)""
      IL_0018:  brtrue.s   IL_001c
      IL_001a:  br.s       IL_002e
      // sequence point: Console.Out.WriteLine(""Input was 1"");
      IL_001c:  call       ""System.IO.TextWriter System.Console.Out.get""
      IL_0021:  ldstr      ""Input was 1""
      IL_0026:  callvirt   ""void System.IO.TextWriter.WriteLine(string)""
      IL_002b:  nop
      // sequence point: break;
      IL_002c:  br.s       IL_0039
      // sequence point: throw new Exception(""Default case"");
      IL_002e:  ldstr      ""Default case""
      IL_0033:  newobj     ""System.Exception..ctor(string)""
      IL_0038:  throw
      // sequence point: <hidden>
      IL_0039:  br.s       IL_003b
      // sequence point: }
      IL_003b:  ret
    }
", sequencePoints: "Program.Main", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 141493, 143860);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_142167_142222(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 142167, 142222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_142239_143848(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 142239, 143848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 141493, 143860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 141493, 143860);
            }
        }

        [Fact]
        [WorkItem(17076, "https://github.com/dotnet/roslyn/issues/17076")]
        public void TestSequencePoints_17076()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 143872, 154336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 144027, 144697);

                var
                source = @"
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        M(new Node()).GetAwaiter().GetResult();
    }

    static async Task M(Node node)
    {
        while (node != null)
        {
            if (node is A a)
            {
                await Task.Yield();
                return;
            }
            else if (node is B b)
            {
                await Task.Yield();
                return;
            }

            node = node.Parent;
        }
    }
}

class Node
{
    public Node Parent = null;
}
class A : Node { }
class B : Node { }
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 144711, 144775);

                var
                v = f_23129_144719_144774(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 144791, 154325);

                f_23129_144791_154324(
                            v, "Program.<M>d__1.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()", @"
    {
      // Code size      403 (0x193)
      .maxstack  3
      .locals init (int V_0,
                    bool V_1,
                    System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter V_2,
                    System.Runtime.CompilerServices.YieldAwaitable V_3,
                    Program.<M>d__1 V_4,
                    bool V_5,
                    System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter V_6,
                    bool V_7,
                    System.Exception V_8)
      // sequence point: <hidden>
      IL_0000:  ldarg.0
      IL_0001:  ldfld      ""int Program.<M>d__1.<>1__state""
      IL_0006:  stloc.0
      .try
      {
        // sequence point: <hidden>
        IL_0007:  ldloc.0
        IL_0008:  brfalse.s  IL_0012
        IL_000a:  br.s       IL_000c
        IL_000c:  ldloc.0
        IL_000d:  ldc.i4.1
        IL_000e:  beq.s      IL_0014
        IL_0010:  br.s       IL_0019
        IL_0012:  br.s       IL_007e
        IL_0014:  br         IL_0109
        // sequence point: {
        IL_0019:  nop
        // sequence point: <hidden>
        IL_001a:  br         IL_0150
        // sequence point: {
        IL_001f:  nop
        // sequence point: if (node is A a)
        IL_0020:  ldarg.0
        IL_0021:  ldarg.0
        IL_0022:  ldfld      ""Node Program.<M>d__1.node""
        IL_0027:  isinst     ""A""
        IL_002c:  stfld      ""A Program.<M>d__1.<a>5__1""
        IL_0031:  ldarg.0
        IL_0032:  ldfld      ""A Program.<M>d__1.<a>5__1""
        IL_0037:  ldnull
        IL_0038:  cgt.un
        IL_003a:  stloc.1
        // sequence point: <hidden>
        IL_003b:  ldloc.1
        IL_003c:  brfalse.s  IL_00a7
        // sequence point: {
        IL_003e:  nop
        // sequence point: await Task.Yield();
        IL_003f:  call       ""System.Runtime.CompilerServices.YieldAwaitable System.Threading.Tasks.Task.Yield()""
        IL_0044:  stloc.3
        IL_0045:  ldloca.s   V_3
        IL_0047:  call       ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter System.Runtime.CompilerServices.YieldAwaitable.GetAwaiter()""
        IL_004c:  stloc.2
        // sequence point: <hidden>
        IL_004d:  ldloca.s   V_2
        IL_004f:  call       ""bool System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter.IsCompleted.get""
        IL_0054:  brtrue.s   IL_009a
        IL_0056:  ldarg.0
        IL_0057:  ldc.i4.0
        IL_0058:  dup
        IL_0059:  stloc.0
        IL_005a:  stfld      ""int Program.<M>d__1.<>1__state""
        // async: yield
        IL_005f:  ldarg.0
        IL_0060:  ldloc.2
        IL_0061:  stfld      ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter Program.<M>d__1.<>u__1""
        IL_0066:  ldarg.0
        IL_0067:  stloc.s    V_4
        IL_0069:  ldarg.0
        IL_006a:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder Program.<M>d__1.<>t__builder""
        IL_006f:  ldloca.s   V_2
        IL_0071:  ldloca.s   V_4
        IL_0073:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter, Program.<M>d__1>(ref System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter, ref Program.<M>d__1)""
        IL_0078:  nop
        IL_0079:  leave      IL_0192
        // async: resume
        IL_007e:  ldarg.0
        IL_007f:  ldfld      ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter Program.<M>d__1.<>u__1""
        IL_0084:  stloc.2
        IL_0085:  ldarg.0
        IL_0086:  ldflda     ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter Program.<M>d__1.<>u__1""
        IL_008b:  initobj    ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter""
        IL_0091:  ldarg.0
        IL_0092:  ldc.i4.m1
        IL_0093:  dup
        IL_0094:  stloc.0
        IL_0095:  stfld      ""int Program.<M>d__1.<>1__state""
        IL_009a:  ldloca.s   V_2
        IL_009c:  call       ""void System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter.GetResult()""
        IL_00a1:  nop
        // sequence point: return;
        IL_00a2:  leave      IL_017e
        // sequence point: if (node is B b)
        IL_00a7:  ldarg.0
        IL_00a8:  ldarg.0
        IL_00a9:  ldfld      ""Node Program.<M>d__1.node""
        IL_00ae:  isinst     ""B""
        IL_00b3:  stfld      ""B Program.<M>d__1.<b>5__2""
        IL_00b8:  ldarg.0
        IL_00b9:  ldfld      ""B Program.<M>d__1.<b>5__2""
        IL_00be:  ldnull
        IL_00bf:  cgt.un
        IL_00c1:  stloc.s    V_5
        // sequence point: <hidden>
        IL_00c3:  ldloc.s    V_5
        IL_00c5:  brfalse.s  IL_0130
        // sequence point: {
        IL_00c7:  nop
        // sequence point: await Task.Yield();
        IL_00c8:  call       ""System.Runtime.CompilerServices.YieldAwaitable System.Threading.Tasks.Task.Yield()""
        IL_00cd:  stloc.3
        IL_00ce:  ldloca.s   V_3
        IL_00d0:  call       ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter System.Runtime.CompilerServices.YieldAwaitable.GetAwaiter()""
        IL_00d5:  stloc.s    V_6
        // sequence point: <hidden>
        IL_00d7:  ldloca.s   V_6
        IL_00d9:  call       ""bool System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter.IsCompleted.get""
        IL_00de:  brtrue.s   IL_0126
        IL_00e0:  ldarg.0
        IL_00e1:  ldc.i4.1
        IL_00e2:  dup
        IL_00e3:  stloc.0
        IL_00e4:  stfld      ""int Program.<M>d__1.<>1__state""
        // async: yield
        IL_00e9:  ldarg.0
        IL_00ea:  ldloc.s    V_6
        IL_00ec:  stfld      ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter Program.<M>d__1.<>u__1""
        IL_00f1:  ldarg.0
        IL_00f2:  stloc.s    V_4
        IL_00f4:  ldarg.0
        IL_00f5:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder Program.<M>d__1.<>t__builder""
        IL_00fa:  ldloca.s   V_6
        IL_00fc:  ldloca.s   V_4
        IL_00fe:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter, Program.<M>d__1>(ref System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter, ref Program.<M>d__1)""
        IL_0103:  nop
        IL_0104:  leave      IL_0192
        // async: resume
        IL_0109:  ldarg.0
        IL_010a:  ldfld      ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter Program.<M>d__1.<>u__1""
        IL_010f:  stloc.s    V_6
        IL_0111:  ldarg.0
        IL_0112:  ldflda     ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter Program.<M>d__1.<>u__1""
        IL_0117:  initobj    ""System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter""
        IL_011d:  ldarg.0
        IL_011e:  ldc.i4.m1
        IL_011f:  dup
        IL_0120:  stloc.0
        IL_0121:  stfld      ""int Program.<M>d__1.<>1__state""
        IL_0126:  ldloca.s   V_6
        IL_0128:  call       ""void System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter.GetResult()""
        IL_012d:  nop
        // sequence point: return;
        IL_012e:  leave.s    IL_017e
        // sequence point: <hidden>
        IL_0130:  ldarg.0
        IL_0131:  ldnull
        IL_0132:  stfld      ""B Program.<M>d__1.<b>5__2""
        // sequence point: node = node.Parent;
        IL_0137:  ldarg.0
        IL_0138:  ldarg.0
        IL_0139:  ldfld      ""Node Program.<M>d__1.node""
        IL_013e:  ldfld      ""Node Node.Parent""
        IL_0143:  stfld      ""Node Program.<M>d__1.node""
        // sequence point: }
        IL_0148:  nop
        IL_0149:  ldarg.0
        IL_014a:  ldnull
        IL_014b:  stfld      ""A Program.<M>d__1.<a>5__1""
        // sequence point: while (node != null)
        IL_0150:  ldarg.0
        IL_0151:  ldfld      ""Node Program.<M>d__1.node""
        IL_0156:  ldnull
        IL_0157:  cgt.un
        IL_0159:  stloc.s    V_7
        // sequence point: <hidden>
        IL_015b:  ldloc.s    V_7
        IL_015d:  brtrue     IL_001f
        IL_0162:  leave.s    IL_017e
      }
      catch System.Exception
      {
        // sequence point: <hidden>
        IL_0164:  stloc.s    V_8
        IL_0166:  ldarg.0
        IL_0167:  ldc.i4.s   -2
        IL_0169:  stfld      ""int Program.<M>d__1.<>1__state""
        IL_016e:  ldarg.0
        IL_016f:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder Program.<M>d__1.<>t__builder""
        IL_0174:  ldloc.s    V_8
        IL_0176:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.SetException(System.Exception)""
        IL_017b:  nop
        IL_017c:  leave.s    IL_0192
      }
      // sequence point: }
      IL_017e:  ldarg.0
      IL_017f:  ldc.i4.s   -2
      IL_0181:  stfld      ""int Program.<M>d__1.<>1__state""
      // sequence point: <hidden>
      IL_0186:  ldarg.0
      IL_0187:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder Program.<M>d__1.<>t__builder""
      IL_018c:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.SetResult()""
      IL_0191:  nop
      IL_0192:  ret
    }
", sequencePoints: "Program+<M>d__1.MoveNext", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 143872, 154336);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_144719_144774(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 144719, 144774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_144791_154324(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 144791, 154324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 143872, 154336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 143872, 154336);
            }
        }

        [Fact]
        [WorkItem(28288, "https://github.com/dotnet/roslyn/issues/28288")]
        public void TestSequencePoints_28288()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 154348, 158923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 154503, 154955);

                var
                source = @"
using System.Threading.Tasks;

public class C
{
    public static async Task Main()
    {
        object o = new C();
        switch (o)
        {
            case C c:
                System.Console.Write(1);
                break;
            default:
                return;
        }

        if (M() != null)
        {
        }
    }

    private static object M()
    {
        return new C();
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 154969, 155033);

                var
                v = f_23129_154977_155032(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 155049, 158912);

                f_23129_155049_158911(
                            v, "C.<Main>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()", @"
    {
      // Code size      162 (0xa2)
      .maxstack  2
      .locals init (int V_0,
                    object V_1,
                    bool V_2,
                    System.Exception V_3)
      // sequence point: <hidden>
      IL_0000:  ldarg.0
      IL_0001:  ldfld      ""int C.<Main>d__0.<>1__state""
      IL_0006:  stloc.0
      .try
      {
        // sequence point: {
        IL_0007:  nop
        // sequence point: object o = new C();
        IL_0008:  ldarg.0
        IL_0009:  newobj     ""C..ctor()""
        IL_000e:  stfld      ""object C.<Main>d__0.<o>5__1""
        // sequence point: switch (o)
        IL_0013:  ldarg.0
        IL_0014:  ldarg.0
        IL_0015:  ldfld      ""object C.<Main>d__0.<o>5__1""
        IL_001a:  stloc.1
        // sequence point: <hidden>
        IL_001b:  ldloc.1
        IL_001c:  stfld      ""object C.<Main>d__0.<>s__3""
        // sequence point: <hidden>
        IL_0021:  ldarg.0
        IL_0022:  ldarg.0
        IL_0023:  ldfld      ""object C.<Main>d__0.<>s__3""
        IL_0028:  isinst     ""C""
        IL_002d:  stfld      ""C C.<Main>d__0.<c>5__2""
        IL_0032:  ldarg.0
        IL_0033:  ldfld      ""C C.<Main>d__0.<c>5__2""
        IL_0038:  brtrue.s   IL_003c
        IL_003a:  br.s       IL_0047
        // sequence point: <hidden>
        IL_003c:  br.s       IL_003e
        // sequence point: System.Console.Write(1);
        IL_003e:  ldc.i4.1
        IL_003f:  call       ""void System.Console.Write(int)""
        IL_0044:  nop
        // sequence point: break;
        IL_0045:  br.s       IL_0049
        // sequence point: return;
        IL_0047:  leave.s    IL_0086
        // sequence point: <hidden>
        IL_0049:  ldarg.0
        IL_004a:  ldnull
        IL_004b:  stfld      ""C C.<Main>d__0.<c>5__2""
        IL_0050:  ldarg.0
        IL_0051:  ldnull
        IL_0052:  stfld      ""object C.<Main>d__0.<>s__3""
        // sequence point: if (M() != null)
        IL_0057:  call       ""object C.M()""
        IL_005c:  ldnull
        IL_005d:  cgt.un
        IL_005f:  stloc.2
        // sequence point: <hidden>
        IL_0060:  ldloc.2
        IL_0061:  brfalse.s  IL_0065
        // sequence point: {
        IL_0063:  nop
        // sequence point: }
        IL_0064:  nop
        // sequence point: <hidden>
        IL_0065:  leave.s    IL_0086
      }
      catch System.Exception
      {
        // sequence point: <hidden>
        IL_0067:  stloc.3
        IL_0068:  ldarg.0
        IL_0069:  ldc.i4.s   -2
        IL_006b:  stfld      ""int C.<Main>d__0.<>1__state""
        IL_0070:  ldarg.0
        IL_0071:  ldnull
        IL_0072:  stfld      ""object C.<Main>d__0.<o>5__1""
        IL_0077:  ldarg.0
        IL_0078:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder C.<Main>d__0.<>t__builder""
        IL_007d:  ldloc.3
        IL_007e:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.SetException(System.Exception)""
        IL_0083:  nop
        IL_0084:  leave.s    IL_00a1
      }
      // sequence point: }
      IL_0086:  ldarg.0
      IL_0087:  ldc.i4.s   -2
      IL_0089:  stfld      ""int C.<Main>d__0.<>1__state""
      // sequence point: <hidden>
      IL_008e:  ldarg.0
      IL_008f:  ldnull
      IL_0090:  stfld      ""object C.<Main>d__0.<o>5__1""
      IL_0095:  ldarg.0
      IL_0096:  ldflda     ""System.Runtime.CompilerServices.AsyncTaskMethodBuilder C.<Main>d__0.<>t__builder""
      IL_009b:  call       ""void System.Runtime.CompilerServices.AsyncTaskMethodBuilder.SetResult()""
      IL_00a0:  nop
      IL_00a1:  ret
    }
", sequencePoints: "C+<Main>d__0.MoveNext", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 154348, 158923);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_154977_155032(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 154977, 155032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_155049_158911(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 155049, 158911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 154348, 158923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 154348, 158923);
            }
        }

        [Fact]
        public void DoStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 158988, 163635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 159054, 159736);

                var
                source = f_23129_159067_159735(@"using System;

public class SeqPointForWhile
{
    public static void Main()
    {
        SeqPointForWhile obj = new SeqPointForWhile();
        obj.While(234);
    }

    int field;
    public void While(int p)
    {
        do
        {
            p = (int)(p / 2);

            if (p > 100)
            {
                continue;
            }
            else if (p > 10)
            {
                field = 1;
            }
            else
            {
                break;
            }
        } while (p > 0); // SeqPt should be generated for [while (p > 0);]

        field = -1;
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 159752, 159844);

                var
                c = f_23129_159760_159843(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 159860, 163624);

                f_23129_159860_163623(
                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""SeqPointForWhile"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""28"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""55"" document=""1"" />
        <entry offset=""0x7"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""24"" document=""1"" />
        <entry offset=""0x13"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x14"">
        <namespace name=""System"" />
        <local name=""obj"" il_index=""0"" il_start=""0x0"" il_end=""0x14"" attributes=""0"" />
      </scope>
    </method>
    <method containingType=""SeqPointForWhile"" name=""While"" parameterNames=""p"">
      <customDebugInfo>
        <forward declaringType=""SeqPointForWhile"" methodName=""Main"" />
        <encLocalSlotMap>
          <slot kind=""1"" offset=""71"" />
          <slot kind=""1"" offset=""159"" />
          <slot kind=""1"" offset=""11"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2"" startLine=""16"" startColumn=""13"" endLine=""16"" endColumn=""30"" document=""1"" />
        <entry offset=""0x7"" startLine=""18"" startColumn=""13"" endLine=""18"" endColumn=""25"" document=""1"" />
        <entry offset=""0xd"" hidden=""true"" document=""1"" />
        <entry offset=""0x10"" startLine=""19"" startColumn=""13"" endLine=""19"" endColumn=""14"" document=""1"" />
        <entry offset=""0x11"" startLine=""20"" startColumn=""17"" endLine=""20"" endColumn=""26"" document=""1"" />
        <entry offset=""0x13"" startLine=""22"" startColumn=""18"" endLine=""22"" endColumn=""29"" document=""1"" />
        <entry offset=""0x19"" hidden=""true"" document=""1"" />
        <entry offset=""0x1c"" startLine=""23"" startColumn=""13"" endLine=""23"" endColumn=""14"" document=""1"" />
        <entry offset=""0x1d"" startLine=""24"" startColumn=""17"" endLine=""24"" endColumn=""27"" document=""1"" />
        <entry offset=""0x24"" startLine=""25"" startColumn=""13"" endLine=""25"" endColumn=""14"" document=""1"" />
        <entry offset=""0x25"" hidden=""true"" document=""1"" />
        <entry offset=""0x27"" startLine=""27"" startColumn=""13"" endLine=""27"" endColumn=""14"" document=""1"" />
        <entry offset=""0x28"" startLine=""28"" startColumn=""17"" endLine=""28"" endColumn=""23"" document=""1"" />
        <entry offset=""0x2a"" startLine=""30"" startColumn=""9"" endLine=""30"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2b"" startLine=""30"" startColumn=""11"" endLine=""30"" endColumn=""25"" document=""1"" />
        <entry offset=""0x30"" hidden=""true"" document=""1"" />
        <entry offset=""0x33"" startLine=""32"" startColumn=""9"" endLine=""32"" endColumn=""20"" document=""1"" />
        <entry offset=""0x3a"" startLine=""33"" startColumn=""5"" endLine=""33"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 158988, 163635);

                string
                f_23129_159067_159735(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 159067, 159735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_159760_159843(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 159760, 159843);
                    return return_v;
                }


                bool
                f_23129_159860_163623(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 159860, 163623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 158988, 163635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 158988, 163635);
            }
        }

        [WorkItem(538317, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538317")]
        [Fact]
        public void ConstructorSequencePoints1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 163700, 169762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 163873, 164529);

                var
                source = f_23129_163886_164528(@"namespace NS
{
    public class MyClass
    {
        int intTest;
        public MyClass()
        {
            intTest = 123;
        }

        public MyClass(params int[] values)
        {
            intTest = values[0] + values[1] + values[2];
        }

        public static int Main()
        {
            int intI = 1, intJ = 8;
            int intK = 3;

            // Can't step into Ctor
            MyClass mc = new MyClass();

            // Can't step into Ctor
            mc = new MyClass(intI, intJ, intK);

            return mc.intTest - 12;
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 164545, 164637);

                var
                c = f_23129_164553_164636(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 166203, 169751);

                f_23129_166203_169750(
                            // Dev10 vs. Roslyn
                            // 
                            // Default Ctor (no param)
                            //    Dev10                                                 Roslyn
                            // ======================================================================================
                            //  Code size       18 (0x12)                               // Code size       16 (0x10)
                            //  .maxstack  8                                            .maxstack  8
                            //* IL_0000:  ldarg.0                                      *IL_0000:  ldarg.0
                            //  IL_0001:  call                                          IL_0001:  callvirt
                            //      instance void [mscorlib]System.Object::.ctor()         instance void [mscorlib]System.Object::.ctor()
                            //  IL_0006:  nop                                          *IL_0006:  nop
                            //* IL_0007:  nop
                            //* IL_0008:  ldarg.0                                      *IL_0007:  ldarg.0
                            //  IL_0009:  ldc.i4.s   123                                IL_0008:  ldc.i4.s   123
                            //  IL_000b:  stfld      int32 NS.MyClass::intTest          IL_000a:  stfld      int32 NS.MyClass::intTest
                            //  IL_0010:  nop                                           
                            //* IL_0011:  ret                                          *IL_000f:  ret
                            //  -----------------------------------------------------------------------------------------
                            //  SeqPoint: 0, 7 ,8, 0x10                                 0, 6, 7, 0xf

                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""NS.MyClass"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""25"" document=""1"" />
        <entry offset=""0x7"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""10"" document=""1"" />
        <entry offset=""0x8"" startLine=""8"" startColumn=""13"" endLine=""8"" endColumn=""27"" document=""1"" />
        <entry offset=""0x10"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""NS.MyClass"" name="".ctor"" parameterNames=""values"">
      <customDebugInfo>
        <forward declaringType=""NS.MyClass"" methodName="".ctor"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""44"" document=""1"" />
        <entry offset=""0x7"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""10"" document=""1"" />
        <entry offset=""0x8"" startLine=""13"" startColumn=""13"" endLine=""13"" endColumn=""57"" document=""1"" />
        <entry offset=""0x19"" startLine=""14"" startColumn=""9"" endLine=""14"" endColumn=""10"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""NS.MyClass"" name=""Main"">
      <customDebugInfo>
        <forward declaringType=""NS.MyClass"" methodName="".ctor"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""19"" />
          <slot kind=""0"" offset=""29"" />
          <slot kind=""0"" offset=""56"" />
          <slot kind=""0"" offset=""126"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""17"" startColumn=""9"" endLine=""17"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1"" startLine=""18"" startColumn=""13"" endLine=""18"" endColumn=""25"" document=""1"" />
        <entry offset=""0x3"" startLine=""18"" startColumn=""27"" endLine=""18"" endColumn=""35"" document=""1"" />
        <entry offset=""0x5"" startLine=""19"" startColumn=""13"" endLine=""19"" endColumn=""26"" document=""1"" />
        <entry offset=""0x7"" startLine=""22"" startColumn=""13"" endLine=""22"" endColumn=""40"" document=""1"" />
        <entry offset=""0xd"" startLine=""25"" startColumn=""13"" endLine=""25"" endColumn=""48"" document=""1"" />
        <entry offset=""0x25"" startLine=""27"" startColumn=""13"" endLine=""27"" endColumn=""36"" document=""1"" />
        <entry offset=""0x32"" startLine=""28"" startColumn=""9"" endLine=""28"" endColumn=""10"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x35"">
        <local name=""intI"" il_index=""0"" il_start=""0x0"" il_end=""0x35"" attributes=""0"" />
        <local name=""intJ"" il_index=""1"" il_start=""0x0"" il_end=""0x35"" attributes=""0"" />
        <local name=""intK"" il_index=""2"" il_start=""0x0"" il_end=""0x35"" attributes=""0"" />
        <local name=""mc"" il_index=""3"" il_start=""0x0"" il_end=""0x35"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 163700, 169762);

                string
                f_23129_163886_164528(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 163886, 164528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_164553_164636(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 164553, 164636);
                    return return_v;
                }


                bool
                f_23129_166203_169750(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 166203, 169750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 163700, 169762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 163700, 169762);
            }
        }

        [Fact]
        public void ConstructorSequencePoints2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 169774, 170635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 169855, 169976);

                f_23129_169855_169975(@"using System;

class D
{
    public D() : [|base()|]
    {
    }
}", TestOptions.DebugDll);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 169992, 170104);

                f_23129_169992_170103(@"using System;

class D
{
    static D()
    [|{|]
    }
}", TestOptions.DebugDll);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 170120, 170272);

                f_23129_170120_170271(@"using System;
class A : Attribute {}
class D
{
    [A]
    public D() : [|base()|]
    {
    }
}", TestOptions.DebugDll);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 170288, 170450);

                f_23129_170288_170449(@"using System;
class A : Attribute {}
class D
{
    [A]
    public D() 
        : [|base()|]
    {
    }
}", TestOptions.DebugDll);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 170466, 170624);

                f_23129_170466_170623(@"using System;

class A : Attribute {}
class C { }
class D
{
    [A]
    [|public D()|]
    {
    }
}", TestOptions.DebugDll);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 169774, 170635);

                int
                f_23129_169855_169975(string
                markup, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions)
                {
                    TestSequencePoints(markup, compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 169855, 169975);
                    return 0;
                }


                int
                f_23129_169992_170103(string
                markup, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions)
                {
                    TestSequencePoints(markup, compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 169992, 170103);
                    return 0;
                }


                int
                f_23129_170120_170271(string
                markup, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions)
                {
                    TestSequencePoints(markup, compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 170120, 170271);
                    return 0;
                }


                int
                f_23129_170288_170449(string
                markup, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions)
                {
                    TestSequencePoints(markup, compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 170288, 170449);
                    return 0;
                }


                int
                f_23129_170466_170623(string
                markup, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions)
                {
                    TestSequencePoints(markup, compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 170466, 170623);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 169774, 170635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 169774, 170635);
            }
        }

        [Fact]
        public void Destructors()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 170699, 172993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 170765, 170980);

                var
                source = @"
using System;

public class Base
{
    ~Base()
    {
        Console.WriteLine();
    }
}

public class Derived : Base
{
    ~Derived()
    {
        Console.WriteLine();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 170994, 171086);

                var
                c = f_23129_171002_171085(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 171100, 172982);

                f_23129_171100_172981(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Base"" name=""Finalize"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x2"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""29"" document=""1"" />
        <entry offset=""0xa"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x12"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x13"">
        <namespace name=""System"" />
      </scope>
    </method>
    <method containingType=""Derived"" name=""Finalize"">
      <customDebugInfo>
        <forward declaringType=""Base"" methodName=""Finalize"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""15"" startColumn=""5"" endLine=""15"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""15"" startColumn=""5"" endLine=""15"" endColumn=""6"" document=""1"" />
        <entry offset=""0x2"" startLine=""16"" startColumn=""9"" endLine=""16"" endColumn=""29"" document=""1"" />
        <entry offset=""0xa"" startLine=""17"" startColumn=""5"" endLine=""17"" endColumn=""6"" document=""1"" />
        <entry offset=""0x12"" startLine=""17"" startColumn=""5"" endLine=""17"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 170699, 172993);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_171002_171085(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 171002, 171085);
                    return return_v;
                }


                bool
                f_23129_171100_172981(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 171100, 172981);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 170699, 172993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 170699, 172993);
            }
        }

        [Fact]
        [WorkItem(50611, "https://github.com/dotnet/roslyn/issues/50611")]
        public void TestPartialClassFieldInitializers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 173078, 175631);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 173242, 173329);

                var
                text1 = f_23129_173254_173328(@"
public partial class C
{
    int x = 1;
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 173345, 173496);

                var
                text2 = f_23129_173357_173495(@"
public partial class C
{
    int y = 1;

    static void Main()
    {
        C c = new C();
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 173777, 173878);

                var
                compilation = f_23129_173795_173877(new SyntaxTree[] { f_23129_173832_173852(text1, "a.cs"), f_23129_173854_173874(text2, "b.cs") })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 173894, 174801);

                f_23129_173894_174800(
                            compilation, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name=""b.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""BB-7A-A6-D2-B2-32-59-43-8C-98-7F-E1-98-8D-F0-94-68-E9-EB-80"" />
    <file id=""2"" name=""a.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""B4-EA-18-73-D2-0E-7F-15-51-4C-68-86-40-DF-E3-C3-97-9D-F6-B7"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""Main"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""15"" document=""2"" />
        <entry offset=""0x7"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""15"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>", format: DebugInformationFormat.Pdb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 174817, 175620);

                f_23129_174817_175619(
                            compilation, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name=""a.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""B4-EA-18-73-D2-0E-7F-15-51-4C-68-86-40-DF-E3-C3-97-9D-F6-B7"" />
    <file id=""2"" name=""b.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""BB-7A-A6-D2-B2-32-59-43-8C-98-7F-E1-98-8D-F0-94-68-E9-EB-80"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""15"" document=""1"" />
        <entry offset=""0x7"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""15"" document=""2"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>", format: DebugInformationFormat.PortablePdb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 173078, 175631);

                string
                f_23129_173254_173328(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 173254, 173328);
                    return return_v;
                }


                string
                f_23129_173357_173495(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 173357, 173495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_173832_173852(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 173832, 173852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_173854_173874(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 173854, 173874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_173795_173877(Microsoft.CodeAnalysis.SyntaxTree[]
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 173795, 173877);
                    return return_v;
                }


                bool
                f_23129_173894_174800(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 173894, 174800);
                    return return_v;
                }


                bool
                f_23129_174817_175619(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 174817, 175619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 173078, 175631);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 173078, 175631);
            }
        }

        [Fact]
        [WorkItem(50611, "https://github.com/dotnet/roslyn/issues/50611")]
        public void TestPartialClassFieldInitializersWithLineDirectives()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 175643, 180058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 175825, 176146);

                var
                text1 = f_23129_175837_176145(@"
using System;
public partial class C
{
    int x = 1;
#line 12 ""foo.cs""
    int z = Math.Abs(-3);
    int w = Math.Abs(4);
#line 17 ""bar.cs""
    double zed = Math.Sin(5);
}

#pragma checksum ""mah.cs"" ""{406EA660-64CF-4C82-B6F0-42D48172A799}"" ""ab007f1d23d9""

")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 176162, 176358);

                var
                text2 = f_23129_176174_176357(@"
using System;
public partial class C
{
    int y = 1;
    int x2 = 1;
#line 12 ""foo2.cs""
    int z2 = Math.Abs(-3);
    int w2 = Math.Abs(4);
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 176374, 176739);

                var
                text3 = f_23129_176386_176738(@"
using System;
public partial class C
{
#line 112 ""mah.cs""
    int y3 = 1;
    int x3 = 1;
    int z3 = Math.Abs(-3);
#line default
    int w3 = Math.Abs(4);
    double zed3 = Math.Sin(5);

    C() {
        Console.WriteLine(""hi"");
    } 

    static void Main()
    {
        C c = new C();
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 177019, 177162);

                var
                compilation = f_23129_177037_177161(new[] { f_23129_177063_177083(text1, "a.cs"), f_23129_177085_177105(text2, "b.cs"), f_23129_177107_177127(text3, "a.cs") }, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 177176, 180047);

                f_23129_177176_180046(compilation, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name=""a.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""E2-3B-47-02-DC-E4-8D-B4-FF-00-67-90-31-68-74-C0-06-D7-39-0E"" />
    <file id=""2"" name=""b.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""DB-CE-E5-E9-CB-53-E5-EF-C1-7F-2C-53-EC-02-FE-5C-34-2C-EF-94"" />
    <file id=""3"" name=""foo.cs"" language=""C#"" />
    <file id=""4"" name=""bar.cs"" language=""C#"" />
    <file id=""5"" name=""foo2.cs"" language=""C#"" />
    <file id=""6"" name=""mah.cs"" language=""C#"" checksumAlgorithm=""406ea660-64cf-4c82-b6f0-42d48172a799"" checksum=""AB-00-7F-1D-23-D9"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""15"" document=""1"" />
        <entry offset=""0x7"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""26"" document=""3"" />
        <entry offset=""0x14"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""25"" document=""3"" />
        <entry offset=""0x20"" startLine=""17"" startColumn=""5"" endLine=""17"" endColumn=""30"" document=""4"" />
        <entry offset=""0x34"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""15"" document=""2"" />
        <entry offset=""0x3b"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""16"" document=""2"" />
        <entry offset=""0x42"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""27"" document=""5"" />
        <entry offset=""0x4f"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""26"" document=""5"" />
        <entry offset=""0x5b"" startLine=""112"" startColumn=""5"" endLine=""112"" endColumn=""16"" document=""6"" />
        <entry offset=""0x62"" startLine=""113"" startColumn=""5"" endLine=""113"" endColumn=""16"" document=""6"" />
        <entry offset=""0x69"" startLine=""114"" startColumn=""5"" endLine=""114"" endColumn=""27"" document=""6"" />
        <entry offset=""0x76"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""26"" document=""1"" />
        <entry offset=""0x82"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""31"" document=""1"" />
        <entry offset=""0x96"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""8"" document=""1"" />
        <entry offset=""0x9d"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""10"" document=""1"" />
        <entry offset=""0x9e"" startLine=""14"" startColumn=""9"" endLine=""14"" endColumn=""33"" document=""1"" />
        <entry offset=""0xa9"" startLine=""15"" startColumn=""5"" endLine=""15"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>", format: DebugInformationFormat.PortablePdb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 175643, 180058);

                string
                f_23129_175837_176145(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 175837, 176145);
                    return return_v;
                }


                string
                f_23129_176174_176357(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 176174, 176357);
                    return return_v;
                }


                string
                f_23129_176386_176738(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 176386, 176738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_177063_177083(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 177063, 177083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_177085_177105(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 177085, 177105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_177107_177127(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 177107, 177127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_177037_177161(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 177037, 177161);
                    return return_v;
                }


                bool
                f_23129_177176_180046(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 177176, 180046);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 175643, 180058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 175643, 180058);
            }
        }

        [WorkItem(543313, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/543313")]
        [Fact]
        public void TestFieldInitializerExpressionLambda()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 180070, 181478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 180253, 180338);

                var
                source = @"
class C
{
    int x = ((System.Func<int, int>)(z => z))(1);
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 180352, 180444);

                var
                c = f_23129_180360_180443(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 180458, 181467);

                f_23129_180458_181466(c, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLambdaMap>
          <methodOrdinal>1</methodOrdinal>
          <lambda offset=""-6"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""50"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C+&lt;&gt;c"" name=""&lt;.ctor&gt;b__1_0"" parameterNames=""z"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".ctor"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""43"" endLine=""4"" endColumn=""44"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 180070, 181478);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_180360_180443(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 180360, 180443);
                    return return_v;
                }


                bool
                f_23129_180458_181466(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 180458, 181466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 180070, 181478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 180070, 181478);
            }
        }

        [Fact]
        public void FieldInitializerSequencePointSpans()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 181490, 182377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 181579, 181636);

                var
                source = @"
class C
{
    int x = 1, y = 2;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 181650, 181742);

                var
                c = f_23129_181658_181741(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 181756, 182366);

                f_23129_181756_182365(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""14"" document=""1"" />
        <entry offset=""0x7"" startLine=""4"" startColumn=""16"" endLine=""4"" endColumn=""21"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 181490, 182377);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_181658_181741(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 181658, 181741);
                    return return_v;
                }


                bool
                f_23129_181756_182365(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 181756, 182365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 181490, 182377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 181490, 182377);
            }
        }

        [WorkItem(820806, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/820806")]
        [Fact]
        public void BreakpointForAutoImplementedProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 182444, 184578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 182627, 182828);

                var
                source = @"
public class C
{
    public static int AutoProp1 { get; private set; }
    internal string AutoProp2 { get; set; }
    internal protected C AutoProp3 { internal get; set;  }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 182844, 182912);

                var
                comp = f_23129_182855_182911(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 182928, 184567);

                f_23129_182928_184566(
                            comp, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""get_AutoProp1"">
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""35"" endLine=""4"" endColumn=""39"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""set_AutoProp1"" parameterNames=""value"">
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""40"" endLine=""4"" endColumn=""52"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""get_AutoProp2"">
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""33"" endLine=""5"" endColumn=""37"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""set_AutoProp2"" parameterNames=""value"">
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""38"" endLine=""5"" endColumn=""42"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""get_AutoProp3"">
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""38"" endLine=""6"" endColumn=""51"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""set_AutoProp3"" parameterNames=""value"">
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""52"" endLine=""6"" endColumn=""56"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 182444, 184578);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_182855_182911(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 182855, 182911);
                    return return_v;
                }


                bool
                f_23129_182928_184566(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 182928, 184566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 182444, 184578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 182444, 184578);
            }
        }

        [Fact]
        public void PropertyDeclaration()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 184590, 185224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 184664, 184778);

                f_23129_184664_184777(@"using System;

public class C
{
    int P { [|get;|] set; }
}", TestOptions.DebugDll);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 184794, 184908);

                f_23129_184794_184907(@"using System;

public class C
{
    int P { get; [|set;|] }
}", TestOptions.DebugDll);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 184924, 185046);

                f_23129_184924_185045(@"using System;

public class C
{
    int P { get [|{|] return 0; } }
}", TestOptions.DebugDll);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 185062, 185213);

                f_23129_185062_185212(@"using System;

public class C
{
    int P { get; } = [|int.Parse(""42"")|];
}", TestOptions.DebugDll, TestOptions.Regular);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 184590, 185224);

                int
                f_23129_184664_184777(string
                markup, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions)
                {
                    TestSequencePoints(markup, compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 184664, 184777);
                    return 0;
                }


                int
                f_23129_184794_184907(string
                markup, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions)
                {
                    TestSequencePoints(markup, compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 184794, 184907);
                    return 0;
                }


                int
                f_23129_184924_185045(string
                markup, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions)
                {
                    TestSequencePoints(markup, compilationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 184924, 185045);
                    return 0;
                }


                int
                f_23129_185062_185212(string
                markup, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                compilationOptions, Microsoft.CodeAnalysis.CSharp.CSharpParseOptions
                parseOptions)
                {
                    TestSequencePoints(markup, compilationOptions, parseOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 185062, 185212);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 184590, 185224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 184590, 185224);
            }
        }

        [Fact]
        public void Return_Implicit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 185293, 186182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 185363, 185433);

                var
                source = @"class C
{
    static void Main()
    {
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 185449, 185541);

                var
                c = f_23129_185457_185540(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 185555, 186171);

                f_23129_185555_186170(c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 185293, 186182);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_185457_185540(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 185457, 185540);
                    return return_v;
                }


                bool
                f_23129_185555_186170(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 185555, 186170);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 185293, 186182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 185293, 186182);
            }
        }

        [Fact]
        public void Return_Explicit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 186194, 187214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 186264, 186351);

                var
                source = @"class C
{
    static void Main()
    {
        return;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 186367, 186459);

                var
                c = f_23129_186375_186458(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 186473, 187203);

                f_23129_186473_187202(c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""5"" startColumn=""9"" endLine=""5"" endColumn=""16"" document=""1"" />
        <entry offset=""0x3"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 186194, 187214);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_186375_186458(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 186375, 186458);
                    return return_v;
                }


                bool
                f_23129_186473_187202(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 186473, 187202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 186194, 187214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 186194, 187214);
            }
        }

        [WorkItem(538298, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/538298")]
        [Fact]
        public void RegressSeqPtEndOfMethodAfterReturn()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 187226, 195774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 187407, 188442);

                var
                source = f_23129_187420_188441(@"using System;

public class SeqPointAfterReturn
{
    public static int Main()
    {
        int ret = 0;
        ReturnVoid(100);
        if (field != ""Even"")
            ret = 1;

        ReturnVoid(99);
        if (field != ""Odd"")
            ret = ret + 1;

        string rets = ReturnValue(101);
        if (rets != ""Odd"")
            ret = ret + 1;

        rets = ReturnValue(102);
        if (rets != ""Even"")
            ret = ret + 1;

        return ret;
    }

    static string field;
    public static void ReturnVoid(int p)
    {
        int x = (int)(p % 2);
        if (x == 0)
        {
            field = ""Even"";
        }
        else
        {
            field = ""Odd"";
        }
    }

    public static string ReturnValue(int p)
    {
        int x = (int)(p % 2);
        if (x == 0)
        {
            return ""Even"";
        }
        else
        {
            return ""Odd"";
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 188458, 188550);

                var
                c = f_23129_188466_188549(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 189027, 195763);

                f_23129_189027_195762(
                            // Expected are current actual output plus Two extra expected SeqPt:
                            //  <entry offset=""0x73"" startLine=""25"" startColumn=""5"" endLine=""25"" endColumn=""6"" document=""1"" />
                            //  <entry offset=""0x22"" startLine=""52"" startColumn=""5"" endLine=""52"" endColumn=""6"" document=""1"" />
                            // 
                            // Note: NOT include other differences between Roslyn and Dev10, as they are filed in separated bugs
                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""SeqPointAfterReturn"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
          <slot kind=""0"" offset=""204"" />
          <slot kind=""1"" offset=""59"" />
          <slot kind=""1"" offset=""138"" />
          <slot kind=""1"" offset=""238"" />
          <slot kind=""1"" offset=""330"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""21"" document=""1"" />
        <entry offset=""0x3"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""25"" document=""1"" />
        <entry offset=""0xb"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""29"" document=""1"" />
        <entry offset=""0x1b"" hidden=""true"" document=""1"" />
        <entry offset=""0x1e"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""21"" document=""1"" />
        <entry offset=""0x20"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""24"" document=""1"" />
        <entry offset=""0x28"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""28"" document=""1"" />
        <entry offset=""0x38"" hidden=""true"" document=""1"" />
        <entry offset=""0x3b"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""27"" document=""1"" />
        <entry offset=""0x3f"" startLine=""16"" startColumn=""9"" endLine=""16"" endColumn=""40"" document=""1"" />
        <entry offset=""0x47"" startLine=""17"" startColumn=""9"" endLine=""17"" endColumn=""27"" document=""1"" />
        <entry offset=""0x54"" hidden=""true"" document=""1"" />
        <entry offset=""0x58"" startLine=""18"" startColumn=""13"" endLine=""18"" endColumn=""27"" document=""1"" />
        <entry offset=""0x5c"" startLine=""20"" startColumn=""9"" endLine=""20"" endColumn=""33"" document=""1"" />
        <entry offset=""0x64"" startLine=""21"" startColumn=""9"" endLine=""21"" endColumn=""28"" document=""1"" />
        <entry offset=""0x71"" hidden=""true"" document=""1"" />
        <entry offset=""0x75"" startLine=""22"" startColumn=""13"" endLine=""22"" endColumn=""27"" document=""1"" />
        <entry offset=""0x79"" startLine=""24"" startColumn=""9"" endLine=""24"" endColumn=""20"" document=""1"" />
        <entry offset=""0x7e"" startLine=""25"" startColumn=""5"" endLine=""25"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x81"">
        <namespace name=""System"" />
        <local name=""ret"" il_index=""0"" il_start=""0x0"" il_end=""0x81"" attributes=""0"" />
        <local name=""rets"" il_index=""1"" il_start=""0x0"" il_end=""0x81"" attributes=""0"" />
      </scope>
    </method>
    <method containingType=""SeqPointAfterReturn"" name=""ReturnVoid"" parameterNames=""p"">
      <customDebugInfo>
        <forward declaringType=""SeqPointAfterReturn"" methodName=""Main"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
          <slot kind=""1"" offset=""42"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""29"" startColumn=""5"" endLine=""29"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""30"" startColumn=""9"" endLine=""30"" endColumn=""30"" document=""1"" />
        <entry offset=""0x5"" startLine=""31"" startColumn=""9"" endLine=""31"" endColumn=""20"" document=""1"" />
        <entry offset=""0xa"" hidden=""true"" document=""1"" />
        <entry offset=""0xd"" startLine=""32"" startColumn=""9"" endLine=""32"" endColumn=""10"" document=""1"" />
        <entry offset=""0xe"" startLine=""33"" startColumn=""13"" endLine=""33"" endColumn=""28"" document=""1"" />
        <entry offset=""0x18"" startLine=""34"" startColumn=""9"" endLine=""34"" endColumn=""10"" document=""1"" />
        <entry offset=""0x19"" hidden=""true"" document=""1"" />
        <entry offset=""0x1b"" startLine=""36"" startColumn=""9"" endLine=""36"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1c"" startLine=""37"" startColumn=""13"" endLine=""37"" endColumn=""27"" document=""1"" />
        <entry offset=""0x26"" startLine=""38"" startColumn=""9"" endLine=""38"" endColumn=""10"" document=""1"" />
        <entry offset=""0x27"" startLine=""39"" startColumn=""5"" endLine=""39"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x28"">
        <local name=""x"" il_index=""0"" il_start=""0x0"" il_end=""0x28"" attributes=""0"" />
      </scope>
    </method>
    <method containingType=""SeqPointAfterReturn"" name=""ReturnValue"" parameterNames=""p"">
      <customDebugInfo>
        <forward declaringType=""SeqPointAfterReturn"" methodName=""Main"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
          <slot kind=""1"" offset=""42"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""42"" startColumn=""5"" endLine=""42"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""43"" startColumn=""9"" endLine=""43"" endColumn=""30"" document=""1"" />
        <entry offset=""0x5"" startLine=""44"" startColumn=""9"" endLine=""44"" endColumn=""20"" document=""1"" />
        <entry offset=""0xa"" hidden=""true"" document=""1"" />
        <entry offset=""0xd"" startLine=""45"" startColumn=""9"" endLine=""45"" endColumn=""10"" document=""1"" />
        <entry offset=""0xe"" startLine=""46"" startColumn=""13"" endLine=""46"" endColumn=""27"" document=""1"" />
        <entry offset=""0x16"" startLine=""49"" startColumn=""9"" endLine=""49"" endColumn=""10"" document=""1"" />
        <entry offset=""0x17"" startLine=""50"" startColumn=""13"" endLine=""50"" endColumn=""26"" document=""1"" />
        <entry offset=""0x1f"" startLine=""52"" startColumn=""5"" endLine=""52"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x21"">
        <local name=""x"" il_index=""0"" il_start=""0x0"" il_end=""0x21"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 187226, 195774);

                string
                f_23129_187420_188441(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 187420, 188441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_188466_188549(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 188466, 188549);
                    return return_v;
                }


                bool
                f_23129_189027_195762(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 189027, 195762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 187226, 195774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 187226, 195774);
            }
        }

        [WorkItem(542064, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/542064")]
        [Fact]
        public void ExceptionHandling()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 195846, 199552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 196010, 196543);

                var
                source = f_23129_196023_196542(@"
class Test
{
    static int Main()
    {
        int ret = 0; // stop 1
        try
        { // stop 2
            throw new System.Exception(); // stop 3
        }
        catch (System.Exception e) // stop 4
        { // stop 5
            ret = 1; // stop 6
        }

        try
        { // stop 7
            throw new System.Exception(); // stop 8
        }
        catch // stop 9
        { // stop 10
            return ret; // stop 11
        }

    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 196820, 196912);

                var
                c = f_23129_196828_196911(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 196926, 199541);

                f_23129_196926_199540(c, "Test.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Test"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
          <slot kind=""0"" offset=""147"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""21"" document=""1"" />
        <entry offset=""0x3"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""10"" document=""1"" />
        <entry offset=""0x4"" startLine=""9"" startColumn=""13"" endLine=""9"" endColumn=""42"" document=""1"" />
        <entry offset=""0xa"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""35"" document=""1"" />
        <entry offset=""0xb"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""10"" document=""1"" />
        <entry offset=""0xc"" startLine=""13"" startColumn=""13"" endLine=""13"" endColumn=""21"" document=""1"" />
        <entry offset=""0xe"" startLine=""14"" startColumn=""9"" endLine=""14"" endColumn=""10"" document=""1"" />
        <entry offset=""0x11"" hidden=""true"" document=""1"" />
        <entry offset=""0x12"" startLine=""17"" startColumn=""9"" endLine=""17"" endColumn=""10"" document=""1"" />
        <entry offset=""0x13"" startLine=""18"" startColumn=""13"" endLine=""18"" endColumn=""42"" document=""1"" />
        <entry offset=""0x19"" startLine=""20"" startColumn=""9"" endLine=""20"" endColumn=""14"" document=""1"" />
        <entry offset=""0x1a"" startLine=""21"" startColumn=""9"" endLine=""21"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1b"" startLine=""22"" startColumn=""13"" endLine=""22"" endColumn=""24"" document=""1"" />
        <entry offset=""0x1f"" startLine=""25"" startColumn=""5"" endLine=""25"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x21"">
        <local name=""ret"" il_index=""0"" il_start=""0x0"" il_end=""0x21"" attributes=""0"" />
        <scope startOffset=""0xa"" endOffset=""0x11"">
          <local name=""e"" il_index=""1"" il_start=""0xa"" il_end=""0x11"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 195846, 199552);

                string
                f_23129_196023_196542(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 196023, 196542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_196828_196911(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 196828, 196911);
                    return return_v;
                }


                bool
                f_23129_196926_199540(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 196926, 199540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 195846, 199552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 195846, 199552);
            }
        }

        [WorkItem(2911, "https://github.com/dotnet/roslyn/issues/2911")]
        [Fact]
        public void ExceptionHandling_Filter_Debug1()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 199564, 205055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 199724, 200243);

                var
                source = f_23129_199737_200242(@"
using System;
using System.IO;

class Test
{
    static string filter(Exception e)
    {
        return null;
    }

    static void Main()
    {
        try
        {
            throw new InvalidOperationException();
        }
        catch (IOException e) when (filter(e) != null)
        {
            Console.WriteLine();
        }
        catch (Exception e) when (filter(e) != null)
        {
            Console.WriteLine();
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 200257, 200367);

                var
                v = f_23129_200265_200366(this, f_23129_200282_200365(source, options: TestOptions.DebugDll))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 200383, 202170);

                f_23129_200383_202169(
                            v, "Test.Main", @"
{
  // Code size       89 (0x59)
  .maxstack  2
  .locals init (System.IO.IOException V_0, //e
                bool V_1,
                System.Exception V_2, //e
                bool V_3)
 -IL_0000:  nop
  .try
  {
   -IL_0001:  nop
   -IL_0002:  newobj     ""System.InvalidOperationException..ctor()""
    IL_0007:  throw
  }
  filter
  {
   ~IL_0008:  isinst     ""System.IO.IOException""
    IL_000d:  dup
    IL_000e:  brtrue.s   IL_0014
    IL_0010:  pop
    IL_0011:  ldc.i4.0
    IL_0012:  br.s       IL_0023
    IL_0014:  stloc.0
   -IL_0015:  ldloc.0
    IL_0016:  call       ""string Test.filter(System.Exception)""
    IL_001b:  ldnull
    IL_001c:  cgt.un
    IL_001e:  stloc.1
   ~IL_001f:  ldloc.1
    IL_0020:  ldc.i4.0
    IL_0021:  cgt.un
    IL_0023:  endfilter
  }  // end filter
  {  // handler
   ~IL_0025:  pop
   -IL_0026:  nop
   -IL_0027:  call       ""void System.Console.WriteLine()""
    IL_002c:  nop
   -IL_002d:  nop
    IL_002e:  leave.s    IL_0058
  }
  filter
  {
   ~IL_0030:  isinst     ""System.Exception""
    IL_0035:  dup
    IL_0036:  brtrue.s   IL_003c
    IL_0038:  pop
    IL_0039:  ldc.i4.0
    IL_003a:  br.s       IL_004b
    IL_003c:  stloc.2
   -IL_003d:  ldloc.2
    IL_003e:  call       ""string Test.filter(System.Exception)""
    IL_0043:  ldnull
    IL_0044:  cgt.un
    IL_0046:  stloc.3
   ~IL_0047:  ldloc.3
    IL_0048:  ldc.i4.0
    IL_0049:  cgt.un
    IL_004b:  endfilter
  }  // end filter
  {  // handler
   ~IL_004d:  pop
   -IL_004e:  nop
   -IL_004f:  call       ""void System.Console.WriteLine()""
    IL_0054:  nop
   -IL_0055:  nop
    IL_0056:  leave.s    IL_0058
  }
 -IL_0058:  ret
}
", sequencePoints: "Test.Main");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 202186, 205044);

                f_23129_202186_205043(
                            v, "Test.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Test"" name=""Main"">
      <customDebugInfo>
        <forward declaringType=""Test"" methodName=""filter"" parameterNames=""e"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""104"" />
          <slot kind=""1"" offset=""120"" />
          <slot kind=""0"" offset=""216"" />
          <slot kind=""1"" offset=""230"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2"" startLine=""16"" startColumn=""13"" endLine=""16"" endColumn=""51"" document=""1"" />
        <entry offset=""0x8"" hidden=""true"" document=""1"" />
        <entry offset=""0x15"" startLine=""18"" startColumn=""31"" endLine=""18"" endColumn=""55"" document=""1"" />
        <entry offset=""0x1f"" hidden=""true"" document=""1"" />
        <entry offset=""0x25"" hidden=""true"" document=""1"" />
        <entry offset=""0x26"" startLine=""19"" startColumn=""9"" endLine=""19"" endColumn=""10"" document=""1"" />
        <entry offset=""0x27"" startLine=""20"" startColumn=""13"" endLine=""20"" endColumn=""33"" document=""1"" />
        <entry offset=""0x2d"" startLine=""21"" startColumn=""9"" endLine=""21"" endColumn=""10"" document=""1"" />
        <entry offset=""0x30"" hidden=""true"" document=""1"" />
        <entry offset=""0x3d"" startLine=""22"" startColumn=""29"" endLine=""22"" endColumn=""53"" document=""1"" />
        <entry offset=""0x47"" hidden=""true"" document=""1"" />
        <entry offset=""0x4d"" hidden=""true"" document=""1"" />
        <entry offset=""0x4e"" startLine=""23"" startColumn=""9"" endLine=""23"" endColumn=""10"" document=""1"" />
        <entry offset=""0x4f"" startLine=""24"" startColumn=""13"" endLine=""24"" endColumn=""33"" document=""1"" />
        <entry offset=""0x55"" startLine=""25"" startColumn=""9"" endLine=""25"" endColumn=""10"" document=""1"" />
        <entry offset=""0x58"" startLine=""26"" startColumn=""5"" endLine=""26"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x59"">
        <scope startOffset=""0x8"" endOffset=""0x30"">
          <local name=""e"" il_index=""0"" il_start=""0x8"" il_end=""0x30"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x30"" endOffset=""0x58"">
          <local name=""e"" il_index=""2"" il_start=""0x30"" il_end=""0x58"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 199564, 205055);

                string
                f_23129_199737_200242(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 199737, 200242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_200282_200365(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 200282, 200365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_200265_200366(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 200265, 200366);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_200383_202169(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 200383, 202169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_202186_205043(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 202186, 205043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 199564, 205055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 199564, 205055);
            }
        }

        [WorkItem(2911, "https://github.com/dotnet/roslyn/issues/2911")]
        [Fact]
        public void ExceptionHandling_Filter_Debug2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 205067, 208039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 205227, 205560);

                var
                source = f_23129_205240_205559(@"
class Test
{
    static void Main()
    {
        try
        {
            throw new System.Exception();
        }
        catch when (F())
        { 
            System.Console.WriteLine();
        }
    }

    private static bool F()
    {
        return true;
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 205574, 205684);

                var
                v = f_23129_205582_205683(this, f_23129_205599_205682(source, options: TestOptions.DebugDll))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 205698, 206395);

                f_23129_205698_206394(v, "Test.Main", @"
{
  // Code size       33 (0x21)
  .maxstack  2
  .locals init (bool V_0)
 -IL_0000:  nop
  .try
  {
   -IL_0001:  nop
   -IL_0002:  newobj     ""System.Exception..ctor()""
    IL_0007:  throw
  }
  filter
  {
   ~IL_0008:  pop
   -IL_0009:  call       ""bool Test.F()""
    IL_000e:  stloc.0
   ~IL_000f:  ldloc.0
    IL_0010:  ldc.i4.0
    IL_0011:  cgt.un
    IL_0013:  endfilter
  }  // end filter
  {  // handler
   ~IL_0015:  pop
   -IL_0016:  nop
   -IL_0017:  call       ""void System.Console.WriteLine()""
    IL_001c:  nop
   -IL_001d:  nop
    IL_001e:  leave.s    IL_0020
  }
 -IL_0020:  ret
}
", sequencePoints: "Test.Main");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 206411, 208028);

                f_23129_206411_208027(
                            v, "Test.Main", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Test"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""1"" offset=""95"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2"" startLine=""8"" startColumn=""13"" endLine=""8"" endColumn=""42"" document=""1"" />
        <entry offset=""0x8"" hidden=""true"" document=""1"" />
        <entry offset=""0x9"" startLine=""10"" startColumn=""15"" endLine=""10"" endColumn=""25"" document=""1"" />
        <entry offset=""0xf"" hidden=""true"" document=""1"" />
        <entry offset=""0x15"" hidden=""true"" document=""1"" />
        <entry offset=""0x16"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0x17"" startLine=""12"" startColumn=""13"" endLine=""12"" endColumn=""40"" document=""1"" />
        <entry offset=""0x1d"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""10"" document=""1"" />
        <entry offset=""0x20"" startLine=""14"" startColumn=""5"" endLine=""14"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 205067, 208039);

                string
                f_23129_205240_205559(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 205240, 205559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_205599_205682(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 205599, 205682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_205582_205683(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 205582, 205683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_205698_206394(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 205698, 206394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_206411_208027(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 206411, 208027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 205067, 208039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 205067, 208039);
            }
        }

        [WorkItem(2911, "https://github.com/dotnet/roslyn/issues/2911")]
        [Fact]
        public void ExceptionHandling_Filter_Debug3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 208051, 210983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 208211, 208504);

                var
                source = f_23129_208224_208503(@"
class Test
{
    static bool a = true;

    static void Main()
    {
        try
        {
            throw new System.Exception();
        }
        catch when (a)
        { 
            System.Console.WriteLine();
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 208518, 208628);

                var
                v = f_23129_208526_208627(this, f_23129_208543_208626(source, options: TestOptions.DebugDll))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 208642, 209337);

                f_23129_208642_209336(v, "Test.Main", @"
{
  // Code size       33 (0x21)
  .maxstack  2
  .locals init (bool V_0)
 -IL_0000:  nop
  .try
  {
   -IL_0001:  nop
   -IL_0002:  newobj     ""System.Exception..ctor()""
    IL_0007:  throw
  }
  filter
  {
   ~IL_0008:  pop
   -IL_0009:  ldsfld     ""bool Test.a""
    IL_000e:  stloc.0
   ~IL_000f:  ldloc.0
    IL_0010:  ldc.i4.0
    IL_0011:  cgt.un
    IL_0013:  endfilter
  }  // end filter
  {  // handler
   ~IL_0015:  pop
   -IL_0016:  nop
   -IL_0017:  call       ""void System.Console.WriteLine()""
    IL_001c:  nop
   -IL_001d:  nop
    IL_001e:  leave.s    IL_0020
  }
 -IL_0020:  ret
}
", sequencePoints: "Test.Main");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 209353, 210972);

                f_23129_209353_210971(
                            v, "Test.Main", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Test"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""1"" offset=""95"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""42"" document=""1"" />
        <entry offset=""0x8"" hidden=""true"" document=""1"" />
        <entry offset=""0x9"" startLine=""12"" startColumn=""15"" endLine=""12"" endColumn=""23"" document=""1"" />
        <entry offset=""0xf"" hidden=""true"" document=""1"" />
        <entry offset=""0x15"" hidden=""true"" document=""1"" />
        <entry offset=""0x16"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""10"" document=""1"" />
        <entry offset=""0x17"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""40"" document=""1"" />
        <entry offset=""0x1d"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""10"" document=""1"" />
        <entry offset=""0x20"" startLine=""16"" startColumn=""5"" endLine=""16"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 208051, 210983);

                string
                f_23129_208224_208503(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 208224, 208503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_208543_208626(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 208543, 208626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_208526_208627(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 208526, 208627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_208642_209336(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 208642, 209336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_209353_210971(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 209353, 210971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 208051, 210983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 208051, 210983);
            }
        }

        [WorkItem(2911, "https://github.com/dotnet/roslyn/issues/2911")]
        [Fact]
        public void ExceptionHandling_Filter_Release3()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 210995, 213233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 211157, 211427);

                var
                source = @"
class Test
{
    static bool a = true;

    static void Main()
    {
        try
        {
            throw new System.Exception();
        }
        catch when (a)
        { 
            System.Console.WriteLine();
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 211441, 211553);

                var
                v = f_23129_211449_211552(this, f_23129_211466_211551(source, options: TestOptions.ReleaseDll))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 211567, 212096);

                f_23129_211567_212095(v, "Test.Main", @"
{
  // Code size       26 (0x1a)
  .maxstack  2
  .try
  {
   -IL_0000:  newobj     ""System.Exception..ctor()""
    IL_0005:  throw
  }
  filter
  {
   ~IL_0006:  pop
   -IL_0007:  ldsfld     ""bool Test.a""
    IL_000c:  ldc.i4.0
    IL_000d:  cgt.un
    IL_000f:  endfilter
  }  // end filter
  {  // handler
   ~IL_0011:  pop
   -IL_0012:  call       ""void System.Console.WriteLine()""
   -IL_0017:  leave.s    IL_0019
  }
 -IL_0019:  ret
}
", sequencePoints: "Test.Main");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 212112, 213222);

                f_23129_212112_213221(
                            v, "Test.Main", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Test"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""42"" document=""1"" />
        <entry offset=""0x6"" hidden=""true"" document=""1"" />
        <entry offset=""0x7"" startLine=""12"" startColumn=""15"" endLine=""12"" endColumn=""23"" document=""1"" />
        <entry offset=""0x11"" hidden=""true"" document=""1"" />
        <entry offset=""0x12"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""40"" document=""1"" />
        <entry offset=""0x17"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""10"" document=""1"" />
        <entry offset=""0x19"" startLine=""16"" startColumn=""5"" endLine=""16"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 210995, 213233);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_211466_211551(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 211466, 211551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_211449_211552(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 211449, 211552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_211567_212095(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 211567, 212095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_212112_213221(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 212112, 213221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 210995, 213233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 210995, 213233);
            }
        }

        [WorkItem(778655, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/778655")]
        [Fact]
        public void BranchToStartOfTry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 213245, 216731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 213410, 213932);

                string
                source = f_23129_213426_213931(@"
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string str = null;
        bool isEmpty = string.IsNullOrEmpty(str);
        // isEmpty is always true here, so it should never go thru this if statement.
        if (!isEmpty)
        {
            throw new Exception();
        }
        try
        {
            Console.WriteLine();
        }
        catch
        {
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 214003, 214095);

                var
                c = f_23129_214011_214094(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 214109, 216720);

                f_23129_214109_216719(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Main"" parameterNames=""args"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""2"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""18"" />
          <slot kind=""0"" offset=""44"" />
          <slot kind=""1"" offset=""177"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""27"" document=""1"" />
        <entry offset=""0x3"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""50"" document=""1"" />
        <entry offset=""0xa"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""22"" document=""1"" />
        <entry offset=""0xf"" hidden=""true"" document=""1"" />
        <entry offset=""0x12"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""10"" document=""1"" />
        <entry offset=""0x13"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""35"" document=""1"" />
        <entry offset=""0x19"" hidden=""true"" document=""1"" />
        <entry offset=""0x1a"" startLine=""17"" startColumn=""9"" endLine=""17"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1b"" startLine=""18"" startColumn=""13"" endLine=""18"" endColumn=""33"" document=""1"" />
        <entry offset=""0x21"" startLine=""19"" startColumn=""9"" endLine=""19"" endColumn=""10"" document=""1"" />
        <entry offset=""0x24"" startLine=""20"" startColumn=""9"" endLine=""20"" endColumn=""14"" document=""1"" />
        <entry offset=""0x25"" startLine=""21"" startColumn=""9"" endLine=""21"" endColumn=""10"" document=""1"" />
        <entry offset=""0x26"" startLine=""22"" startColumn=""9"" endLine=""22"" endColumn=""10"" document=""1"" />
        <entry offset=""0x29"" startLine=""23"" startColumn=""5"" endLine=""23"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x2a"">
        <namespace name=""System"" />
        <namespace name=""System.Collections.Generic"" />
        <local name=""str"" il_index=""0"" il_start=""0x0"" il_end=""0x2a"" attributes=""0"" />
        <local name=""isEmpty"" il_index=""1"" il_start=""0x0"" il_end=""0x2a"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 213245, 216731);

                string
                f_23129_213426_213931(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 213426, 213931);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_214011_214094(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 214011, 214094);
                    return return_v;
                }


                bool
                f_23129_214109_216719(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 214109, 216719);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 213245, 216731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 213245, 216731);
            }
        }

        [Fact]
        public void UsingStatement_EmbeddedStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 216799, 220801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 216886, 217248);

                var
                source = f_23129_216899_217247(@"
public class DisposableClass : System.IDisposable
{
    public DisposableClass(int a) { }
    public void Dispose() { }
}

class C
{
    static void Main()
    {
        using (DisposableClass a = new DisposableClass(1), b = new DisposableClass(2))
            System.Console.WriteLine(""First"");
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 217262, 217327);

                var
                c = f_23129_217270_217326(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 217341, 217369);

                var
                v = f_23129_217349_217368(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 217385, 218969);

                f_23129_217385_218968(
                            v, "C.Main", sequencePoints: "C.Main", source: source, expectedIL: @"
 {
   // Code size       53 (0x35)
   .maxstack  1
   .locals init (DisposableClass V_0, //a
                 DisposableClass V_1) //b
   // sequence point: {
   IL_0000:  nop
   // sequence point: DisposableClass a = new DisposableClass(1)
   IL_0001:  ldc.i4.1
   IL_0002:  newobj     ""DisposableClass..ctor(int)""
   IL_0007:  stloc.0
   .try
   {
     // sequence point: b = new DisposableClass(2)
     IL_0008:  ldc.i4.2
     IL_0009:  newobj     ""DisposableClass..ctor(int)""
     IL_000e:  stloc.1
     .try
     {
       // sequence point: System.Console.WriteLine(""First"");
       IL_000f:  ldstr      ""First""
       IL_0014:  call       ""void System.Console.WriteLine(string)""
       IL_0019:  nop
       IL_001a:  leave.s    IL_0027
     }
     finally
     {
       // sequence point: <hidden>
       IL_001c:  ldloc.1
       IL_001d:  brfalse.s  IL_0026
       IL_001f:  ldloc.1
       IL_0020:  callvirt   ""void System.IDisposable.Dispose()""
       IL_0025:  nop
       // sequence point: <hidden>
       IL_0026:  endfinally
     }
     // sequence point: <hidden>
     IL_0027:  leave.s    IL_0034
   }
   finally
   {
     // sequence point: <hidden>
     IL_0029:  ldloc.0
     IL_002a:  brfalse.s  IL_0033
     IL_002c:  ldloc.0
     IL_002d:  callvirt   ""void System.IDisposable.Dispose()""
     IL_0032:  nop
     // sequence point: <hidden>
     IL_0033:  endfinally
   }
   // sequence point: }
   IL_0034:  ret
 }
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 218985, 220790);

                f_23129_218985_220789(
                            c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <forward declaringType=""DisposableClass"" methodName="".ctor"" parameterNames=""a"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""34"" />
          <slot kind=""0"" offset=""62"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""12"" startColumn=""16"" endLine=""12"" endColumn=""58"" document=""1"" />
        <entry offset=""0x8"" startLine=""12"" startColumn=""60"" endLine=""12"" endColumn=""86"" document=""1"" />
        <entry offset=""0xf"" startLine=""13"" startColumn=""13"" endLine=""13"" endColumn=""47"" document=""1"" />
        <entry offset=""0x1c"" hidden=""true"" document=""1"" />
        <entry offset=""0x26"" hidden=""true"" document=""1"" />
        <entry offset=""0x27"" hidden=""true"" document=""1"" />
        <entry offset=""0x29"" hidden=""true"" document=""1"" />
        <entry offset=""0x33"" hidden=""true"" document=""1"" />
        <entry offset=""0x34"" startLine=""14"" startColumn=""5"" endLine=""14"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x35"">
        <scope startOffset=""0x1"" endOffset=""0x34"">
          <local name=""a"" il_index=""0"" il_start=""0x1"" il_end=""0x34"" attributes=""0"" />
          <local name=""b"" il_index=""1"" il_start=""0x1"" il_end=""0x34"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 216799, 220801);

                string
                f_23129_216899_217247(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 216899, 217247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_217270_217326(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 217270, 217326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_217349_217368(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 217349, 217368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_217385_218968(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 217385, 218968);
                    return return_v;
                }


                bool
                f_23129_218985_220789(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 218985, 220789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 216799, 220801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 216799, 220801);
            }
        }

        [Fact]
        public void UsingStatement_Block()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 220813, 225107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 220888, 221273);

                var
                source = f_23129_220901_221272(@"
public class DisposableClass : System.IDisposable
{
    public DisposableClass(int a) { }
    public void Dispose() { }
}

class C
{
    static void Main()
    {
        using (DisposableClass c = new DisposableClass(3), d = new DisposableClass(4))
        {
            System.Console.WriteLine(""Second"");
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 221287, 221352);

                var
                c = f_23129_221295_221351(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 221366, 221394);

                var
                v = f_23129_221374_221393(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 221410, 223043);

                f_23129_221410_223042(
                            v, "C.Main", sequencePoints: "C.Main", source: source, expectedIL: @"
{
  // Code size       55 (0x37)
  .maxstack  1
  .locals init (DisposableClass V_0, //c
                DisposableClass V_1) //d
  // sequence point: {
  IL_0000:  nop
  // sequence point: DisposableClass c = new DisposableClass(3)
  IL_0001:  ldc.i4.3
  IL_0002:  newobj     ""DisposableClass..ctor(int)""
  IL_0007:  stloc.0
  .try
  {
    // sequence point: d = new DisposableClass(4)
    IL_0008:  ldc.i4.4
    IL_0009:  newobj     ""DisposableClass..ctor(int)""
    IL_000e:  stloc.1
    .try
    {
      // sequence point: {
      IL_000f:  nop
      // sequence point: System.Console.WriteLine(""Second"");
      IL_0010:  ldstr      ""Second""
      IL_0015:  call       ""void System.Console.WriteLine(string)""
      IL_001a:  nop
      // sequence point: }
      IL_001b:  nop
      IL_001c:  leave.s    IL_0029
    }
    finally
    {
      // sequence point: <hidden>
      IL_001e:  ldloc.1
      IL_001f:  brfalse.s  IL_0028
      IL_0021:  ldloc.1
      IL_0022:  callvirt   ""void System.IDisposable.Dispose()""
      IL_0027:  nop
      // sequence point: <hidden>
      IL_0028:  endfinally
    }
    // sequence point: <hidden>
    IL_0029:  leave.s    IL_0036
  }
  finally
  {
    // sequence point: <hidden>
    IL_002b:  ldloc.0
    IL_002c:  brfalse.s  IL_0035
    IL_002e:  ldloc.0
    IL_002f:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0034:  nop
    // sequence point: <hidden>
    IL_0035:  endfinally
  }
  // sequence point: }
  IL_0036:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 223057, 225096);

                f_23129_223057_225095(c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <forward declaringType=""DisposableClass"" methodName="".ctor"" parameterNames=""a"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""34"" />
          <slot kind=""0"" offset=""62"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""12"" startColumn=""16"" endLine=""12"" endColumn=""58"" document=""1"" />
        <entry offset=""0x8"" startLine=""12"" startColumn=""60"" endLine=""12"" endColumn=""86"" document=""1"" />
        <entry offset=""0xf"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""10"" document=""1"" />
        <entry offset=""0x10"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""48"" document=""1"" />
        <entry offset=""0x1b"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1e"" hidden=""true"" document=""1"" />
        <entry offset=""0x28"" hidden=""true"" document=""1"" />
        <entry offset=""0x29"" hidden=""true"" document=""1"" />
        <entry offset=""0x2b"" hidden=""true"" document=""1"" />
        <entry offset=""0x35"" hidden=""true"" document=""1"" />
        <entry offset=""0x36"" startLine=""16"" startColumn=""5"" endLine=""16"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x37"">
        <scope startOffset=""0x1"" endOffset=""0x36"">
          <local name=""c"" il_index=""0"" il_start=""0x1"" il_end=""0x36"" attributes=""0"" />
          <local name=""d"" il_index=""1"" il_start=""0x1"" il_end=""0x36"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 220813, 225107);

                string
                f_23129_220901_221272(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 220901, 221272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_221295_221351(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 221295, 221351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_221374_221393(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 221374, 221393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_221410_223042(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 221410, 223042);
                    return return_v;
                }


                bool
                f_23129_223057_225095(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 223057, 225095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 220813, 225107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 220813, 225107);
            }
        }

        [WorkItem(18844, "https://github.com/dotnet/roslyn/issues/18844")]
        [Fact]
        public void UsingStatement_EmbeddedConditional()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 225119, 227473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 225284, 225614);

                var
                source = @"
class C
{
    bool F()
    {
        bool x = true;
        bool value = false;
        using (var stream = new System.IO.MemoryStream())
            if (x)
            {
                value = true;
            }
            else
                value = false;

        return value;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 225630, 225722);

                var
                c = f_23129_225638_225721(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 225736, 225764);

                var
                v = f_23129_225744_225763(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 225778, 227462);

                f_23129_225778_227461(v, "C.F", @"
{
  // Code size       45 (0x2d)
  .maxstack  1
  .locals init (bool V_0, //x
                bool V_1, //value
                System.IO.MemoryStream V_2, //stream
                bool V_3,
                bool V_4)
  // sequence point: {
  IL_0000:  nop
  // sequence point: bool x = true;
  IL_0001:  ldc.i4.1
  IL_0002:  stloc.0
  // sequence point: bool value = false;
  IL_0003:  ldc.i4.0
  IL_0004:  stloc.1
  // sequence point: var stream = new System.IO.MemoryStream()
  IL_0005:  newobj     ""System.IO.MemoryStream..ctor()""
  IL_000a:  stloc.2
  .try
  {
    // sequence point: if (x)
    IL_000b:  ldloc.0
    IL_000c:  stloc.3
    // sequence point: <hidden>
    IL_000d:  ldloc.3
    IL_000e:  brfalse.s  IL_0016
    // sequence point: {
    IL_0010:  nop
    // sequence point: value = true;
    IL_0011:  ldc.i4.1
    IL_0012:  stloc.1
    // sequence point: }
    IL_0013:  nop
    // sequence point: <hidden>
    IL_0014:  br.s       IL_0018
    // sequence point: value = false;
    IL_0016:  ldc.i4.0
    IL_0017:  stloc.1
    // sequence point: <hidden>
    IL_0018:  leave.s    IL_0025
  }
  finally
  {
    // sequence point: <hidden>
    IL_001a:  ldloc.2
    IL_001b:  brfalse.s  IL_0024
    IL_001d:  ldloc.2
    IL_001e:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0023:  nop
    // sequence point: <hidden>
    IL_0024:  endfinally
  }
  // sequence point: return value;
  IL_0025:  ldloc.1
  IL_0026:  stloc.s    V_4
  IL_0028:  br.s       IL_002a
  // sequence point: }
  IL_002a:  ldloc.s    V_4
  IL_002c:  ret
}
", sequencePoints: "C.F", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 225119, 227473);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_225638_225721(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 225638, 225721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_225744_225763(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 225744, 225763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_225778_227461(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 225778, 227461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 225119, 227473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 225119, 227473);
            }
        }

        [WorkItem(18844, "https://github.com/dotnet/roslyn/issues/18844")]
        [Fact]
        public void UsingStatement_EmbeddedConditional2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 227485, 229960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 227651, 228011);

                var
                source = @"
class C
{
    bool F()
    {
        bool x = true;
        bool value = false;
        using (var stream = new System.IO.MemoryStream())
            if (x)
            {
                value = true;
            }
            else
            {
                value = false;
            }

        return value;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 228027, 228119);

                var
                c = f_23129_228035_228118(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 228133, 228161);

                var
                v = f_23129_228141_228160(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 228175, 229949);

                f_23129_228175_229948(v, "C.F", @"
{
  // Code size       47 (0x2f)
  .maxstack  1
  .locals init (bool V_0, //x
                bool V_1, //value
                System.IO.MemoryStream V_2, //stream
                bool V_3,
                bool V_4)
  // sequence point: {
  IL_0000:  nop
  // sequence point: bool x = true;
  IL_0001:  ldc.i4.1
  IL_0002:  stloc.0
  // sequence point: bool value = false;
  IL_0003:  ldc.i4.0
  IL_0004:  stloc.1
  // sequence point: var stream = new System.IO.MemoryStream()
  IL_0005:  newobj     ""System.IO.MemoryStream..ctor()""
  IL_000a:  stloc.2
  .try
  {
    // sequence point: if (x)
    IL_000b:  ldloc.0
    IL_000c:  stloc.3
    // sequence point: <hidden>
    IL_000d:  ldloc.3
    IL_000e:  brfalse.s  IL_0016
    // sequence point: {
    IL_0010:  nop
    // sequence point: value = true;
    IL_0011:  ldc.i4.1
    IL_0012:  stloc.1
    // sequence point: }
    IL_0013:  nop
    // sequence point: <hidden>
    IL_0014:  br.s       IL_001a
    // sequence point: {
    IL_0016:  nop
    // sequence point: value = false;
    IL_0017:  ldc.i4.0
    IL_0018:  stloc.1
    // sequence point: }
    IL_0019:  nop
    // sequence point: <hidden>
    IL_001a:  leave.s    IL_0027
  }
  finally
  {
    // sequence point: <hidden>
    IL_001c:  ldloc.2
    IL_001d:  brfalse.s  IL_0026
    IL_001f:  ldloc.2
    IL_0020:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0025:  nop
    // sequence point: <hidden>
    IL_0026:  endfinally
  }
  // sequence point: return value;
  IL_0027:  ldloc.1
  IL_0028:  stloc.s    V_4
  IL_002a:  br.s       IL_002c
  // sequence point: }
  IL_002c:  ldloc.s    V_4
  IL_002e:  ret
}
", sequencePoints: "C.F", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 227485, 229960);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_228035_228118(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 228035, 228118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_228141_228160(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 228141, 228160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_228175_229948(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 228175, 229948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 227485, 229960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 227485, 229960);
            }
        }

        [WorkItem(18844, "https://github.com/dotnet/roslyn/issues/18844")]
        [Fact]
        public void UsingStatement_EmbeddedWhile()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 229972, 231563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 230131, 230309);

                var
                source = @"
class C
{
    void F(bool x)
    {
        using (var stream = new System.IO.MemoryStream())
            while (x)
                x = false;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 230325, 230417);

                var
                c = f_23129_230333_230416(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 230431, 230459);

                var
                v = f_23129_230439_230458(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 230473, 231552);

                f_23129_230473_231551(v, "C.F", @"
{
  // Code size       31 (0x1f)
  .maxstack  1
  .locals init (System.IO.MemoryStream V_0, //stream
                bool V_1)
  // sequence point: {
  IL_0000:  nop
  // sequence point: var stream = new System.IO.MemoryStream()
  IL_0001:  newobj     ""System.IO.MemoryStream..ctor()""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: <hidden>
    IL_0007:  br.s       IL_000c
    // sequence point: x = false;
    IL_0009:  ldc.i4.0
    IL_000a:  starg.s    V_1
    // sequence point: while (x)
    IL_000c:  ldarg.1
    IL_000d:  stloc.1
    // sequence point: <hidden>
    IL_000e:  ldloc.1
    IL_000f:  brtrue.s   IL_0009
    IL_0011:  leave.s    IL_001e
  }
  finally
  {
    // sequence point: <hidden>
    IL_0013:  ldloc.0
    IL_0014:  brfalse.s  IL_001d
    IL_0016:  ldloc.0
    IL_0017:  callvirt   ""void System.IDisposable.Dispose()""
    IL_001c:  nop
    // sequence point: <hidden>
    IL_001d:  endfinally
  }
  // sequence point: }
  IL_001e:  ret
}
", sequencePoints: "C.F", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 229972, 231563);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_230333_230416(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 230333, 230416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_230439_230458(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 230439, 230458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_230473_231551(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 230473, 231551);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 229972, 231563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 229972, 231563);
            }
        }

        [WorkItem(18844, "https://github.com/dotnet/roslyn/issues/18844")]
        [Fact]
        public void UsingStatement_EmbeddedFor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 231575, 233175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 231732, 231921);

                var
                source = @"
class C
{
    void F(bool x)
    {
        using (var stream = new System.IO.MemoryStream())
            for ( ; x == true; )
                x = false;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 231937, 232029);

                var
                c = f_23129_231945_232028(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 232043, 232071);

                var
                v = f_23129_232051_232070(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 232085, 233164);

                f_23129_232085_233163(v, "C.F", @"
{
  // Code size       31 (0x1f)
  .maxstack  1
  .locals init (System.IO.MemoryStream V_0, //stream
                bool V_1)
  // sequence point: {
  IL_0000:  nop
  // sequence point: var stream = new System.IO.MemoryStream()
  IL_0001:  newobj     ""System.IO.MemoryStream..ctor()""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: <hidden>
    IL_0007:  br.s       IL_000c
    // sequence point: x = false;
    IL_0009:  ldc.i4.0
    IL_000a:  starg.s    V_1
    // sequence point: x == true
    IL_000c:  ldarg.1
    IL_000d:  stloc.1
    // sequence point: <hidden>
    IL_000e:  ldloc.1
    IL_000f:  brtrue.s   IL_0009
    IL_0011:  leave.s    IL_001e
  }
  finally
  {
    // sequence point: <hidden>
    IL_0013:  ldloc.0
    IL_0014:  brfalse.s  IL_001d
    IL_0016:  ldloc.0
    IL_0017:  callvirt   ""void System.IDisposable.Dispose()""
    IL_001c:  nop
    // sequence point: <hidden>
    IL_001d:  endfinally
  }
  // sequence point: }
  IL_001e:  ret
}
", sequencePoints: "C.F", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 231575, 233175);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_231945_232028(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 231945, 232028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_232051_232070(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 232051, 232070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_232085_233163(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 232085, 233163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 231575, 233175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 231575, 233175);
            }
        }

        [WorkItem(18844, "https://github.com/dotnet/roslyn/issues/18844")]
        [Fact]
        public void LockStatement_EmbeddedIf()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 233187, 235383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 233342, 233577);

                var
                source = @"
class C
{
    void F(bool x)
    {
        string y = """";
        lock (y)
            if (!x)
                System.Console.Write(1);
            else
                System.Console.Write(2);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 233593, 233685);

                var
                c = f_23129_233601_233684(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 233699, 233727);

                var
                v = f_23129_233707_233726(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 233741, 235372);

                f_23129_233741_235371(v, "C.F", @"
{
  // Code size       58 (0x3a)
  .maxstack  2
  .locals init (string V_0, //y
                string V_1,
                bool V_2,
                bool V_3)
  // sequence point: {
  IL_0000:  nop
  // sequence point: string y = """";
  IL_0001:  ldstr      """"
  IL_0006:  stloc.0
  // sequence point: lock (y)
  IL_0007:  ldloc.0
  IL_0008:  stloc.1
  IL_0009:  ldc.i4.0
  IL_000a:  stloc.2
  .try
  {
    IL_000b:  ldloc.1
    IL_000c:  ldloca.s   V_2
    IL_000e:  call       ""void System.Threading.Monitor.Enter(object, ref bool)""
    IL_0013:  nop
    // sequence point: if (!x)
    IL_0014:  ldarg.1
    IL_0015:  ldc.i4.0
    IL_0016:  ceq
    IL_0018:  stloc.3
    // sequence point: <hidden>
    IL_0019:  ldloc.3
    IL_001a:  brfalse.s  IL_0025
    // sequence point: System.Console.Write(1);
    IL_001c:  ldc.i4.1
    IL_001d:  call       ""void System.Console.Write(int)""
    IL_0022:  nop
    // sequence point: <hidden>
    IL_0023:  br.s       IL_002c
    // sequence point: System.Console.Write(2);
    IL_0025:  ldc.i4.2
    IL_0026:  call       ""void System.Console.Write(int)""
    IL_002b:  nop
    // sequence point: <hidden>
    IL_002c:  leave.s    IL_0039
  }
  finally
  {
    // sequence point: <hidden>
    IL_002e:  ldloc.2
    IL_002f:  brfalse.s  IL_0038
    IL_0031:  ldloc.1
    IL_0032:  call       ""void System.Threading.Monitor.Exit(object)""
    IL_0037:  nop
    // sequence point: <hidden>
    IL_0038:  endfinally
  }
  // sequence point: }
  IL_0039:  ret
}
", sequencePoints: "C.F", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 233187, 235383);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_233601_233684(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 233601, 233684);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_233707_233726(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 233707, 233726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_233741_235371(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 233741, 235371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 233187, 235383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 233187, 235383);
            }
        }

        [WorkItem(37417, "https://github.com/dotnet/roslyn/issues/37417")]
        [Fact]
        public void UsingDeclaration_BodyBlockScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 235454, 239395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 235616, 235851);

                var
                source = f_23129_235629_235850(@"
using System;
using System.IO;
class C
{
    static void Main()
    {
        using MemoryStream m = new MemoryStream(), n = new MemoryStream();
        Console.WriteLine(1);
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 235865, 235930);

                var
                c = f_23129_235873_235929(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 235944, 235972);

                var
                v = f_23129_235952_235971(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 236106, 237539);

                f_23129_236106_237538(
                            // TODO: https://github.com/dotnet/roslyn/issues/37417
                            // Duplicate sequence point at `}`

                            v, "C.Main", sequencePoints: "C.Main", source: source, expectedIL: @"
{
  // Code size       45 (0x2d)
  .maxstack  1
  .locals init (System.IO.MemoryStream V_0, //m
                System.IO.MemoryStream V_1) //n
  // sequence point: {
  IL_0000:  nop
  // sequence point: using MemoryStream m = new MemoryStream()
  IL_0001:  newobj     ""System.IO.MemoryStream..ctor()""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: n = new MemoryStream()
    IL_0007:  newobj     ""System.IO.MemoryStream..ctor()""
    IL_000c:  stloc.1
    .try
    {
      // sequence point: Console.WriteLine(1);
      IL_000d:  ldc.i4.1
      IL_000e:  call       ""void System.Console.WriteLine(int)""
      IL_0013:  nop
      // sequence point: }
      IL_0014:  leave.s    IL_002c
    }
    finally
    {
      // sequence point: <hidden>
      IL_0016:  ldloc.1
      IL_0017:  brfalse.s  IL_0020
      IL_0019:  ldloc.1
      IL_001a:  callvirt   ""void System.IDisposable.Dispose()""
      IL_001f:  nop
      // sequence point: <hidden>
      IL_0020:  endfinally
    }
  }
  finally
  {
    // sequence point: <hidden>
    IL_0021:  ldloc.0
    IL_0022:  brfalse.s  IL_002b
    IL_0024:  ldloc.0
    IL_0025:  callvirt   ""void System.IDisposable.Dispose()""
    IL_002a:  nop
    // sequence point: <hidden>
    IL_002b:  endfinally
  }
  // sequence point: }
  IL_002c:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 237555, 239384);

                f_23129_237555_239383(
                            c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""2"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""30"" />
          <slot kind=""0"" offset=""54"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""50"" document=""1"" />
        <entry offset=""0x7"" startLine=""8"" startColumn=""52"" endLine=""8"" endColumn=""74"" document=""1"" />
        <entry offset=""0xd"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""30"" document=""1"" />
        <entry offset=""0x14"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
        <entry offset=""0x16"" hidden=""true"" document=""1"" />
        <entry offset=""0x20"" hidden=""true"" document=""1"" />
        <entry offset=""0x21"" hidden=""true"" document=""1"" />
        <entry offset=""0x2b"" hidden=""true"" document=""1"" />
        <entry offset=""0x2c"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x2d"">
        <namespace name=""System"" />
        <namespace name=""System.IO"" />
        <local name=""m"" il_index=""0"" il_start=""0x0"" il_end=""0x2d"" attributes=""0"" />
        <local name=""n"" il_index=""1"" il_start=""0x0"" il_end=""0x2d"" attributes=""0"" />
      </scope>
    </method>
  </methods>
 </symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 235454, 239395);

                string
                f_23129_235629_235850(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 235629, 235850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_235873_235929(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 235873, 235929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_235952_235971(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 235952, 235971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_236106_237538(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 236106, 237538);
                    return return_v;
                }


                bool
                f_23129_237555_239383(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 237555, 239383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 235454, 239395);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 235454, 239395);
            }
        }

        [WorkItem(37417, "https://github.com/dotnet/roslyn/issues/37417")]
        [Fact]
        public void UsingDeclaration_BodyBlockScopeWithReturn()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 239407, 242598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 239579, 239808);

                var
                source = f_23129_239592_239807(@"
using System;
using System.IO;
class C
{
    static int Main()
    {
        using MemoryStream m = new MemoryStream();
        Console.WriteLine(1);
        return 1;
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 239822, 239887);

                var
                c = f_23129_239830_239886(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 239901, 239929);

                var
                v = f_23129_239909_239928(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 240063, 241085);

                f_23129_240063_241084(
                            // TODO: https://github.com/dotnet/roslyn/issues/37417
                            // Duplicate sequence point at `}`

                            v, "C.Main", sequencePoints: "C.Main", source: source, expectedIL: @"
{
  // Code size       31 (0x1f)
  .maxstack  1
  .locals init (System.IO.MemoryStream V_0, //m
                int V_1)
  // sequence point: {
  IL_0000:  nop
  // sequence point: using MemoryStream m = new MemoryStream();
  IL_0001:  newobj     ""System.IO.MemoryStream..ctor()""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: Console.WriteLine(1);
    IL_0007:  ldc.i4.1
    IL_0008:  call       ""void System.Console.WriteLine(int)""
    IL_000d:  nop
    // sequence point: return 1;
    IL_000e:  ldc.i4.1
    IL_000f:  stloc.1
    IL_0010:  leave.s    IL_001d
  }
  finally
  {
    // sequence point: <hidden>
    IL_0012:  ldloc.0
    IL_0013:  brfalse.s  IL_001c
    IL_0015:  ldloc.0
    IL_0016:  callvirt   ""void System.IDisposable.Dispose()""
    IL_001b:  nop
    // sequence point: <hidden>
    IL_001c:  endfinally
  }
  // sequence point: }
  IL_001d:  ldloc.1
  IL_001e:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 241101, 242587);

                f_23129_241101_242586(
                            c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""2"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""30"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""51"" document=""1"" />
        <entry offset=""0x7"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""30"" document=""1"" />
        <entry offset=""0xe"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""18"" document=""1"" />
        <entry offset=""0x12"" hidden=""true"" document=""1"" />
        <entry offset=""0x1c"" hidden=""true"" document=""1"" />
        <entry offset=""0x1d"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x1f"">
        <namespace name=""System"" />
        <namespace name=""System.IO"" />
        <local name=""m"" il_index=""0"" il_start=""0x0"" il_end=""0x1f"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 239407, 242598);

                string
                f_23129_239592_239807(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 239592, 239807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_239830_239886(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 239830, 239886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_239909_239928(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 239909, 239928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_240063_241084(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 240063, 241084);
                    return return_v;
                }


                bool
                f_23129_241101_242586(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 241101, 242586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 239407, 242598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 239407, 242598);
            }
        }

        [WorkItem(37417, "https://github.com/dotnet/roslyn/issues/37417")]
        [Fact]
        public void UsingDeclaration_IfBodyScope()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 242610, 246682);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 242769, 243090);

                var
                source = f_23129_242782_243089(@"
using System;
using System.IO;
class C
{
    public static bool G() => true;

    static void Main()
    {
        if (G()) 
        {
            using var m = new MemoryStream();
            Console.WriteLine(1);
        }
        Console.WriteLine(2);
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 243104, 243169);

                var
                c = f_23129_243112_243168(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 243183, 243211);

                var
                v = f_23129_243191_243210(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 243455, 244770);

                f_23129_243455_244769(
                            // TODO: https://github.com/dotnet/roslyn/issues/37417
                            // In this case the sequence point `}` is not emitted on the leave instruction,
                            // but to a nop instruction following the disposal.

                            v, "C.Main", sequencePoints: "C.Main", source: source, expectedIL: @"
{
  // Code size       46 (0x2e)
  .maxstack  1
  .locals init (bool V_0,
                System.IO.MemoryStream V_1) //m
  // sequence point: {
  IL_0000:  nop
  // sequence point: if (G())
  IL_0001:  call       ""bool C.G()""
  IL_0006:  stloc.0
  // sequence point: <hidden>
  IL_0007:  ldloc.0
  IL_0008:  brfalse.s  IL_0026
  // sequence point: {
  IL_000a:  nop
  // sequence point: using var m = new MemoryStream();
  IL_000b:  newobj     ""System.IO.MemoryStream..ctor()""
  IL_0010:  stloc.1
  .try
  {
    // sequence point: Console.WriteLine(1);
    IL_0011:  ldc.i4.1
    IL_0012:  call       ""void System.Console.WriteLine(int)""
    IL_0017:  nop
    IL_0018:  leave.s    IL_0025
  }
  finally
  {
    // sequence point: <hidden>
    IL_001a:  ldloc.1
    IL_001b:  brfalse.s  IL_0024
    IL_001d:  ldloc.1
    IL_001e:  callvirt   ""void System.IDisposable.Dispose()""
    IL_0023:  nop
    // sequence point: <hidden>
    IL_0024:  endfinally
  }
  // sequence point: }
  IL_0025:  nop
  // sequence point: Console.WriteLine(2);
  IL_0026:  ldc.i4.2
  IL_0027:  call       ""void System.Console.WriteLine(int)""
  IL_002c:  nop
  // sequence point: }
  IL_002d:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 244786, 246671);

                f_23129_244786_246670(
                            c, "C.Main", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""G"" />
        <encLocalSlotMap>
          <slot kind=""1"" offset=""11"" />
          <slot kind=""0"" offset=""55"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""17"" document=""1"" />
        <entry offset=""0x7"" hidden=""true"" document=""1"" />
        <entry offset=""0xa"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0xb"" startLine=""12"" startColumn=""13"" endLine=""12"" endColumn=""46"" document=""1"" />
        <entry offset=""0x11"" startLine=""13"" startColumn=""13"" endLine=""13"" endColumn=""34"" document=""1"" />
        <entry offset=""0x1a"" hidden=""true"" document=""1"" />
        <entry offset=""0x24"" hidden=""true"" document=""1"" />
        <entry offset=""0x25"" startLine=""14"" startColumn=""9"" endLine=""14"" endColumn=""10"" document=""1"" />
        <entry offset=""0x26"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""30"" document=""1"" />
        <entry offset=""0x2d"" startLine=""16"" startColumn=""5"" endLine=""16"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x2e"">
        <scope startOffset=""0xa"" endOffset=""0x26"">
          <local name=""m"" il_index=""1"" il_start=""0xa"" il_end=""0x26"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
 </symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 242610, 246682);

                string
                f_23129_242782_243089(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 242782, 243089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_243112_243168(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 243112, 243168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_243191_243210(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 243191, 243210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_243455_244769(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 243455, 244769);
                    return return_v;
                }


                bool
                f_23129_244786_246670(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 244786, 246670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 242610, 246682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 242610, 246682);
            }
        }

        [Fact]
        public void AnonymousType_Empty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 246800, 248157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 246874, 247013);

                var
                source = f_23129_246887_247012(@"
class Program
{
    static void Main(string[] args)
    {
        var o = new {};
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 247027, 247119);

                var
                c = f_23129_247035_247118(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 247133, 248146);

                f_23129_247133_248145(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Main"" parameterNames=""args"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""24"" document=""1"" />
        <entry offset=""0x7"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x8"">
        <local name=""o"" il_index=""0"" il_start=""0x0"" il_end=""0x8"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 246800, 248157);

                string
                f_23129_246887_247012(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 246887, 247012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_247035_247118(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 247035, 247118);
                    return return_v;
                }


                bool
                f_23129_247133_248145(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 247133, 248145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 246800, 248157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 246800, 248157);
            }
        }

        [Fact]
        public void AnonymousType_NonEmpty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 248169, 249536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 248246, 248392);

                var
                source = f_23129_248259_248391(@"
class Program
{
    static void Main(string[] args)
    {
        var o = new { a = 1 };
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 248406, 248498);

                var
                c = f_23129_248414_248497(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 248512, 249525);

                f_23129_248512_249524(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Main"" parameterNames=""args"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""31"" document=""1"" />
        <entry offset=""0x8"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x9"">
        <local name=""o"" il_index=""0"" il_start=""0x0"" il_end=""0x9"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 248169, 249536);

                string
                f_23129_248259_248391(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 248259, 248391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_248414_248497(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 248414, 248497);
                    return return_v;
                }


                bool
                f_23129_248512_249524(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 248512, 249524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 248169, 249536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 248169, 249536);
            }
        }

        [Fact]
        public void FixedStatementSingleAddress()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 249604, 252091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 249686, 249954);

                var
                source = f_23129_249699_249953(@"
using System;

unsafe class C
{
    int x;
    
    static void Main()
    {
        C c = new C();
        fixed (int* p = &c.x)
        {
            *p = 1;
        }
        Console.WriteLine(c.x);
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 249968, 250066);

                var
                c = f_23129_249976_250065(source, options: TestOptions.UnsafeDebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 250080, 252080);

                f_23129_250080_252079(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <entryPoint declaringType=""C"" methodName=""Main"" />
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""13"" />
          <slot kind=""0"" offset=""47"" />
          <slot kind=""9"" offset=""47"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""23"" document=""1"" />
        <entry offset=""0xe"" startLine=""11"" startColumn=""16"" endLine=""11"" endColumn=""29"" document=""1"" />
        <entry offset=""0x11"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""10"" document=""1"" />
        <entry offset=""0x12"" startLine=""13"" startColumn=""13"" endLine=""13"" endColumn=""20"" document=""1"" />
        <entry offset=""0x15"" startLine=""14"" startColumn=""9"" endLine=""14"" endColumn=""10"" document=""1"" />
        <entry offset=""0x16"" hidden=""true"" document=""1"" />
        <entry offset=""0x19"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""32"" document=""1"" />
        <entry offset=""0x25"" startLine=""16"" startColumn=""5"" endLine=""16"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x26"">
        <namespace name=""System"" />
        <local name=""c"" il_index=""0"" il_start=""0x0"" il_end=""0x26"" attributes=""0"" />
        <scope startOffset=""0x7"" endOffset=""0x19"">
          <local name=""p"" il_index=""1"" il_start=""0x7"" il_end=""0x19"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 249604, 252091);

                string
                f_23129_249699_249953(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 249699, 249953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_249976_250065(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 249976, 250065);
                    return return_v;
                }


                bool
                f_23129_250080_252079(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 250080, 252079);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 249604, 252091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 249604, 252091);
            }
        }

        [Fact]
        public void FixedStatementSingleString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 252103, 254100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 252184, 252398);

                var
                source = f_23129_252197_252397(@"
using System;

unsafe class C
{
    static void Main()
    {
        fixed (char* p = ""hello"")
        {
            Console.WriteLine(*p);
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 252412, 252510);

                var
                c = f_23129_252420_252509(source, options: TestOptions.UnsafeDebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 252524, 254089);

                f_23129_252524_254088(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""24"" />
          <slot kind=""9"" offset=""24"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x7"" startLine=""8"" startColumn=""16"" endLine=""8"" endColumn=""33"" document=""1"" />
        <entry offset=""0x15"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x16"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""35"" document=""1"" />
        <entry offset=""0x1e"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1f"" hidden=""true"" document=""1"" />
        <entry offset=""0x21"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x22"">
        <namespace name=""System"" />
        <scope startOffset=""0x1"" endOffset=""0x21"">
          <local name=""p"" il_index=""0"" il_start=""0x1"" il_end=""0x21"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 252103, 254100);

                string
                f_23129_252197_252397(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 252197, 252397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_252420_252509(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 252420, 252509);
                    return return_v;
                }


                bool
                f_23129_252524_254088(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 252524, 254088);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 252103, 254100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 252103, 254100);
            }
        }

        [Fact]
        public void FixedStatementSingleArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 254112, 257086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 254192, 254501);

                var
                source = f_23129_254205_254500(@"
using System;

unsafe class C
{
    int[] a = new int[1];

    static void Main()
    {
        C c = new C();
        Console.Write(c.a[0]);
        fixed (int* p = c.a)
        {
            (*p)++;
        }
        Console.Write(c.a[0]);
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 254515, 254613);

                var
                c = f_23129_254523_254612(source, options: TestOptions.UnsafeDebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 254627, 257075);

                f_23129_254627_257074(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <entryPoint declaringType=""C"" methodName=""Main"" />
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""13"" />
          <slot kind=""0"" offset=""79"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""23"" document=""1"" />
        <entry offset=""0x7"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""31"" document=""1"" />
        <entry offset=""0x15"" startLine=""12"" startColumn=""16"" endLine=""12"" endColumn=""28"" document=""1"" />
        <entry offset=""0x32"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""10"" document=""1"" />
        <entry offset=""0x33"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""20"" document=""1"" />
        <entry offset=""0x39"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""10"" document=""1"" />
        <entry offset=""0x3a"" hidden=""true"" document=""1"" />
        <entry offset=""0x3c"" startLine=""16"" startColumn=""9"" endLine=""16"" endColumn=""31"" document=""1"" />
        <entry offset=""0x4a"" startLine=""17"" startColumn=""5"" endLine=""17"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x4b"">
        <namespace name=""System"" />
        <local name=""c"" il_index=""0"" il_start=""0x0"" il_end=""0x4b"" attributes=""0"" />
        <scope startOffset=""0x15"" endOffset=""0x3c"">
          <local name=""p"" il_index=""1"" il_start=""0x15"" il_end=""0x3c"" attributes=""0"" />
        </scope>
      </scope>
    </method>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""Main"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""26"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 254112, 257086);

                string
                f_23129_254205_254500(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 254205, 254500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_254523_254612(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 254523, 254612);
                    return return_v;
                }


                bool
                f_23129_254627_257074(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 254627, 257074);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 254112, 257086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 254112, 257086);
            }
        }

        [Fact]
        public void FixedStatementMultipleAddresses()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 257098, 260110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 257184, 257501);

                var
                source = f_23129_257197_257500(@"
using System;

unsafe class C
{
    int x;
    int y;
    
    static void Main()
    {
        C c = new C();
        fixed (int* p = &c.x, q = &c.y)
        {
            *p = 1;
            *q = 2;
        }
        Console.WriteLine(c.x + c.y);
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 257562, 257660);

                var
                c = f_23129_257570_257659(source, options: TestOptions.UnsafeDebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 257674, 260099);

                f_23129_257674_260098(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <entryPoint declaringType=""C"" methodName=""Main"" />
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""13"" />
          <slot kind=""0"" offset=""47"" />
          <slot kind=""0"" offset=""57"" />
          <slot kind=""9"" offset=""47"" />
          <slot kind=""9"" offset=""57"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""23"" document=""1"" />
        <entry offset=""0xe"" startLine=""12"" startColumn=""16"" endLine=""12"" endColumn=""29"" document=""1"" />
        <entry offset=""0x19"" startLine=""12"" startColumn=""31"" endLine=""12"" endColumn=""39"" document=""1"" />
        <entry offset=""0x1d"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1e"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""20"" document=""1"" />
        <entry offset=""0x21"" startLine=""15"" startColumn=""13"" endLine=""15"" endColumn=""20"" document=""1"" />
        <entry offset=""0x24"" startLine=""16"" startColumn=""9"" endLine=""16"" endColumn=""10"" document=""1"" />
        <entry offset=""0x25"" hidden=""true"" document=""1"" />
        <entry offset=""0x2c"" startLine=""17"" startColumn=""9"" endLine=""17"" endColumn=""38"" document=""1"" />
        <entry offset=""0x3f"" startLine=""18"" startColumn=""5"" endLine=""18"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x40"">
        <namespace name=""System"" />
        <local name=""c"" il_index=""0"" il_start=""0x0"" il_end=""0x40"" attributes=""0"" />
        <scope startOffset=""0x7"" endOffset=""0x2c"">
          <local name=""p"" il_index=""1"" il_start=""0x7"" il_end=""0x2c"" attributes=""0"" />
          <local name=""q"" il_index=""2"" il_start=""0x7"" il_end=""0x2c"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 257098, 260110);

                string
                f_23129_257197_257500(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 257197, 257500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_257570_257659(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 257570, 257659);
                    return return_v;
                }


                bool
                f_23129_257674_260098(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 257674, 260098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 257098, 260110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 257098, 260110);
            }
        }

        [Fact]
        public void FixedStatementMultipleStrings()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 260122, 262635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 260206, 260465);

                var
                source = f_23129_260219_260464(@"
using System;

unsafe class C
{
    static void Main()
    {
        fixed (char* p = ""hello"", q = ""goodbye"")
        {
            Console.Write(*p);
            Console.Write(*q);
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 260526, 260624);

                var
                c = f_23129_260534_260623(source, options: TestOptions.UnsafeDebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 260638, 262624);

                f_23129_260638_262623(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""24"" />
          <slot kind=""0"" offset=""37"" />
          <slot kind=""9"" offset=""24"" />
          <slot kind=""9"" offset=""37"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x7"" startLine=""8"" startColumn=""16"" endLine=""8"" endColumn=""33"" document=""1"" />
        <entry offset=""0x1b"" startLine=""8"" startColumn=""35"" endLine=""8"" endColumn=""48"" document=""1"" />
        <entry offset=""0x29"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x2a"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""31"" document=""1"" />
        <entry offset=""0x32"" startLine=""11"" startColumn=""13"" endLine=""11"" endColumn=""31"" document=""1"" />
        <entry offset=""0x3a"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""10"" document=""1"" />
        <entry offset=""0x3b"" hidden=""true"" document=""1"" />
        <entry offset=""0x3f"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x40"">
        <namespace name=""System"" />
        <scope startOffset=""0x1"" endOffset=""0x3f"">
          <local name=""p"" il_index=""0"" il_start=""0x1"" il_end=""0x3f"" attributes=""0"" />
          <local name=""q"" il_index=""1"" il_start=""0x1"" il_end=""0x3f"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 260122, 262635);

                string
                f_23129_260219_260464(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 260219, 260464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_260534_260623(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 260534, 260623);
                    return return_v;
                }


                bool
                f_23129_260638_262623(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 260638, 262623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 260122, 262635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 260122, 262635);
            }
        }

        [Fact]
        public void FixedStatementMultipleArrays()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 262647, 266510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 262730, 263160);

                var
                source = f_23129_262743_263159(@"
using System;

unsafe class C
{
    int[] a = new int[1];
    int[] b = new int[1];

    static void Main()
    {
        C c = new C();
        Console.Write(c.a[0]);
        Console.Write(c.b[0]);
        fixed (int* p = c.a, q = c.b)
        {
            *p = 1;
            *q = 2;
        }
        Console.Write(c.a[0]);
        Console.Write(c.b[0]);
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 263174, 263272);

                var
                c = f_23129_263182_263271(source, options: TestOptions.UnsafeDebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 263286, 266499);

                f_23129_263286_266498(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <entryPoint declaringType=""C"" methodName=""Main"" />
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""13"" />
          <slot kind=""0"" offset=""111"" />
          <slot kind=""0"" offset=""120"" />
          <slot kind=""temp"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""23"" document=""1"" />
        <entry offset=""0x7"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""31"" document=""1"" />
        <entry offset=""0x15"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""31"" document=""1"" />
        <entry offset=""0x23"" startLine=""14"" startColumn=""16"" endLine=""14"" endColumn=""28"" document=""1"" />
        <entry offset=""0x40"" startLine=""14"" startColumn=""30"" endLine=""14"" endColumn=""37"" document=""1"" />
        <entry offset=""0x60"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""10"" document=""1"" />
        <entry offset=""0x61"" startLine=""16"" startColumn=""13"" endLine=""16"" endColumn=""20"" document=""1"" />
        <entry offset=""0x64"" startLine=""17"" startColumn=""13"" endLine=""17"" endColumn=""20"" document=""1"" />
        <entry offset=""0x67"" startLine=""18"" startColumn=""9"" endLine=""18"" endColumn=""10"" document=""1"" />
        <entry offset=""0x68"" hidden=""true"" document=""1"" />
        <entry offset=""0x6d"" startLine=""19"" startColumn=""9"" endLine=""19"" endColumn=""31"" document=""1"" />
        <entry offset=""0x7b"" startLine=""20"" startColumn=""9"" endLine=""20"" endColumn=""31"" document=""1"" />
        <entry offset=""0x89"" startLine=""21"" startColumn=""5"" endLine=""21"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x8a"">
        <namespace name=""System"" />
        <local name=""c"" il_index=""0"" il_start=""0x0"" il_end=""0x8a"" attributes=""0"" />
        <scope startOffset=""0x23"" endOffset=""0x6d"">
          <local name=""p"" il_index=""1"" il_start=""0x23"" il_end=""0x6d"" attributes=""0"" />
          <local name=""q"" il_index=""2"" il_start=""0x23"" il_end=""0x6d"" attributes=""0"" />
        </scope>
      </scope>
    </method>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""Main"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""26"" document=""1"" />
        <entry offset=""0xc"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""26"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 262647, 266510);

                string
                f_23129_262743_263159(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 262743, 263159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_263182_263271(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 263182, 263271);
                    return return_v;
                }


                bool
                f_23129_263286_266498(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 263286, 266498);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 262647, 266510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 262647, 266510);
            }
        }

        [Fact]
        public void FixedStatementMultipleMixed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 266522, 270237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 266604, 266986);

                var
                source = f_23129_266617_266985(@"
using System;

unsafe class C
{
    char c = 'a';
    char[] a = new char[1];

    static void Main()
    {
        C c = new C();
        fixed (char* p = &c.c, q = c.a, r = ""hello"")
        {
            Console.Write((int)*p);
            Console.Write((int)*q);
            Console.Write((int)*r);
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 267000, 267098);

                var
                c = f_23129_267008_267097(source, options: TestOptions.UnsafeDebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 267112, 270226);

                f_23129_267112_270225(c, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""13"" />
          <slot kind=""0"" offset=""48"" />
          <slot kind=""0"" offset=""58"" />
          <slot kind=""0"" offset=""67"" />
          <slot kind=""9"" offset=""48"" />
          <slot kind=""temp"" />
          <slot kind=""9"" offset=""67"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""23"" document=""1"" />
        <entry offset=""0xf"" startLine=""12"" startColumn=""16"" endLine=""12"" endColumn=""30"" document=""1"" />
        <entry offset=""0x13"" startLine=""12"" startColumn=""32"" endLine=""12"" endColumn=""39"" document=""1"" />
        <entry offset=""0x3a"" startLine=""12"" startColumn=""41"" endLine=""12"" endColumn=""52"" document=""1"" />
        <entry offset=""0x49"" startLine=""13"" startColumn=""9"" endLine=""13"" endColumn=""10"" document=""1"" />
        <entry offset=""0x4a"" startLine=""14"" startColumn=""13"" endLine=""14"" endColumn=""36"" document=""1"" />
        <entry offset=""0x52"" startLine=""15"" startColumn=""13"" endLine=""15"" endColumn=""36"" document=""1"" />
        <entry offset=""0x5a"" startLine=""16"" startColumn=""13"" endLine=""16"" endColumn=""36"" document=""1"" />
        <entry offset=""0x62"" startLine=""17"" startColumn=""9"" endLine=""17"" endColumn=""10"" document=""1"" />
        <entry offset=""0x63"" hidden=""true"" document=""1"" />
        <entry offset=""0x6d"" startLine=""18"" startColumn=""5"" endLine=""18"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x6e"">
        <namespace name=""System"" />
        <local name=""c"" il_index=""0"" il_start=""0x0"" il_end=""0x6e"" attributes=""0"" />
        <scope startOffset=""0x7"" endOffset=""0x6d"">
          <local name=""p"" il_index=""1"" il_start=""0x7"" il_end=""0x6d"" attributes=""0"" />
          <local name=""q"" il_index=""2"" il_start=""0x7"" il_end=""0x6d"" attributes=""0"" />
          <local name=""r"" il_index=""3"" il_start=""0x7"" il_end=""0x6d"" attributes=""0"" />
        </scope>
      </scope>
    </method>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""Main"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""18"" document=""1"" />
        <entry offset=""0x8"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""28"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 266522, 270237);

                string
                f_23129_266617_266985(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 266617, 266985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_267008_267097(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 267008, 267097);
                    return return_v;
                }


                bool
                f_23129_267112_270225(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 267112, 270225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 266522, 270237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 266522, 270237);
            }
        }

        [Fact]
        public void LineDirective()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 270306, 271555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 270374, 270520);

                var
                source = @"
#line 50 ""foo.cs""

using System;

unsafe class C
{
    static void Main()
    {
        Console.Write(1);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 270534, 270632);

                var
                c = f_23129_270542_270631(source, options: TestOptions.UnsafeDebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 270646, 271544);

                f_23129_270646_271543(c, @"
<symbols>
  <files>
    <file id=""1"" name=""foo.cs"" language=""C#"" />
  </files>
  <entryPoint declaringType=""C"" methodName=""Main"" />
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""56"" startColumn=""5"" endLine=""56"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""57"" startColumn=""9"" endLine=""57"" endColumn=""26"" document=""1"" />
        <entry offset=""0x8"" startLine=""58"" startColumn=""5"" endLine=""58"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x9"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 270306, 271555);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_270542_270631(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 270542, 270631);
                    return return_v;
                }


                bool
                f_23129_270646_271543(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 270646, 271543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 270306, 271555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 270306, 271555);
            }
        }

        [WorkItem(544917, "http://vstfdevdiv:8080/DevDiv2/DevDiv/_workitems/edit/544917")]
        [Fact]
        public void DisabledLineDirective()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 271567, 272929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 271735, 271900);

                var
                source = @"
#if false
#line 50 ""foo.cs""
#endif

using System;

unsafe class C
{
    static void Main()
    {
        Console.Write(1);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 271914, 272012);

                var
                c = f_23129_271922_272011(source, options: TestOptions.UnsafeDebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 272026, 272918);

                f_23129_272026_272917(c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <entryPoint declaringType=""C"" methodName=""Main"" />
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""26"" document=""1"" />
        <entry offset=""0x8"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x9"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 271567, 272929);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_271922_272011(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 271922, 272011);
                    return return_v;
                }


                bool
                f_23129_272026_272917(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 272026, 272917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 271567, 272929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 271567, 272929);
            }
        }

        [Fact]
        public void TestLineDirectivesHidden()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 272941, 277815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 273020, 273498);

                var
                text1 = f_23129_273032_273497(@"
using System;
public class C
{
    public void Foo()
    {
        foreach (var x in new int[] { 1, 2, 3, 4 })
        {
            Console.WriteLine(x);
        }

#line hidden
        foreach (var x in new int[] { 1, 2, 3, 4 })
        {
            Console.WriteLine(x);
        }
#line default

        foreach (var x in new int[] { 1, 2, 3, 4 })
        {
            Console.WriteLine(x);
        }
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 273514, 273588);

                var
                compilation = f_23129_273532_273587(text1, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 273602, 277804);

                f_23129_273602_277803(compilation, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Foo"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""6"" offset=""11"" />
          <slot kind=""8"" offset=""11"" />
          <slot kind=""0"" offset=""11"" />
          <slot kind=""6"" offset=""137"" />
          <slot kind=""8"" offset=""137"" />
          <slot kind=""0"" offset=""137"" />
          <slot kind=""6"" offset=""264"" />
          <slot kind=""8"" offset=""264"" />
          <slot kind=""0"" offset=""264"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""16"" document=""1"" />
        <entry offset=""0x2"" startLine=""7"" startColumn=""27"" endLine=""7"" endColumn=""51"" document=""1"" />
        <entry offset=""0x16"" hidden=""true"" document=""1"" />
        <entry offset=""0x18"" startLine=""7"" startColumn=""18"" endLine=""7"" endColumn=""23"" document=""1"" />
        <entry offset=""0x1c"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1d"" startLine=""9"" startColumn=""13"" endLine=""9"" endColumn=""34"" document=""1"" />
        <entry offset=""0x24"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""10"" document=""1"" />
        <entry offset=""0x25"" hidden=""true"" document=""1"" />
        <entry offset=""0x29"" startLine=""7"" startColumn=""24"" endLine=""7"" endColumn=""26"" document=""1"" />
        <entry offset=""0x2f"" hidden=""true"" document=""1"" />
        <entry offset=""0x30"" hidden=""true"" document=""1"" />
        <entry offset=""0x45"" hidden=""true"" document=""1"" />
        <entry offset=""0x47"" hidden=""true"" document=""1"" />
        <entry offset=""0x4d"" hidden=""true"" document=""1"" />
        <entry offset=""0x4e"" hidden=""true"" document=""1"" />
        <entry offset=""0x56"" hidden=""true"" document=""1"" />
        <entry offset=""0x57"" hidden=""true"" document=""1"" />
        <entry offset=""0x5d"" hidden=""true"" document=""1"" />
        <entry offset=""0x64"" startLine=""19"" startColumn=""9"" endLine=""19"" endColumn=""16"" document=""1"" />
        <entry offset=""0x65"" startLine=""19"" startColumn=""27"" endLine=""19"" endColumn=""51"" document=""1"" />
        <entry offset=""0x7b"" hidden=""true"" document=""1"" />
        <entry offset=""0x7d"" startLine=""19"" startColumn=""18"" endLine=""19"" endColumn=""23"" document=""1"" />
        <entry offset=""0x84"" startLine=""20"" startColumn=""9"" endLine=""20"" endColumn=""10"" document=""1"" />
        <entry offset=""0x85"" startLine=""21"" startColumn=""13"" endLine=""21"" endColumn=""34"" document=""1"" />
        <entry offset=""0x8d"" startLine=""22"" startColumn=""9"" endLine=""22"" endColumn=""10"" document=""1"" />
        <entry offset=""0x8e"" hidden=""true"" document=""1"" />
        <entry offset=""0x94"" startLine=""19"" startColumn=""24"" endLine=""19"" endColumn=""26"" document=""1"" />
        <entry offset=""0x9c"" startLine=""23"" startColumn=""5"" endLine=""23"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x9d"">
        <namespace name=""System"" />
        <scope startOffset=""0x18"" endOffset=""0x25"">
          <local name=""x"" il_index=""2"" il_start=""0x18"" il_end=""0x25"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x47"" endOffset=""0x57"">
          <local name=""x"" il_index=""5"" il_start=""0x47"" il_end=""0x57"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x7d"" endOffset=""0x8e"">
          <local name=""x"" il_index=""8"" il_start=""0x7d"" il_end=""0x8e"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 272941, 277815);

                string
                f_23129_273032_273497(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 273032, 273497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_273532_273587(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 273532, 273587);
                    return return_v;
                }


                bool
                f_23129_273602_277803(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 273602, 277803);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 272941, 277815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 272941, 277815);
            }
        }

        [Fact]
        public void HiddenMethods()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 277827, 279384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 277895, 278351);

                var
                src = @"
using System;

class C
{
#line hidden
    public static void H()
    {
        F();
    }

#line default
    public static void G()
    {
        F();
    }

#line hidden
    public static void F()
    {
        {
            const int z = 1;
            var (x, y) = (1,2);
            Console.WriteLine(x + z);
        }
        {
            dynamic x = 1;
            Console.WriteLine(x);
        }
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 278365, 278526);

                var
                c = f_23129_278373_278525(src, references: new[] { f_23129_278443_278452(), f_23129_278454_278467(), f_23129_278469_278491() }, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 278542, 279373);

                f_23129_278542_279372(
                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""G"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""14"" startColumn=""5"" endLine=""14"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""15"" startColumn=""9"" endLine=""15"" endColumn=""13"" document=""1"" />
        <entry offset=""0x7"" startLine=""16"" startColumn=""5"" endLine=""16"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x8"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 277827, 279384);

                Microsoft.CodeAnalysis.MetadataReference
                f_23129_278443_278452()
                {
                    var return_v = CSharpRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 278443, 278452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_278454_278467()
                {
                    var return_v = ValueTupleRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 278454, 278467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_278469_278491()
                {
                    var return_v = SystemRuntimeFacadeRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 278469, 278491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_278373_278525(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 278373, 278525);
                    return return_v;
                }


                bool
                f_23129_278542_279372(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 278542, 279372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 277827, 279384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 277827, 279384);
            }
        }

        [Fact]
        public void HiddenEntryPoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 279396, 280723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 279467, 279555);

                var
                src = @"
class C
{
#line hidden
    public static void Main()
    {
    }
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 279569, 279730);

                var
                c = f_23129_279577_279729(src, references: new[] { f_23129_279647_279656(), f_23129_279658_279671(), f_23129_279673_279695() }, options: TestOptions.DebugExe)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 280126, 280712);

                f_23129_280126_280711(
                            // Note: Dev10 emitted a hidden sequence point to #line hidden method, 
                            // which enabled the debugger to locate the first user visible sequence point starting from the entry point.
                            // Roslyn does not emit such sequence point. We could potentially synthesize one but that would defeat the purpose of 
                            // #line hidden directive. 
                            c, @"
<symbols>
  <entryPoint declaringType=""C"" methodName=""Main"" />
  <methods>
    <method containingType=""C"" name=""Main"" format=""windows"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
    </method>
  </methods>
</symbols>", options: PdbValidationOptions.SkipConversionValidation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 279396, 280723);

                Microsoft.CodeAnalysis.MetadataReference
                f_23129_279647_279656()
                {
                    var return_v = CSharpRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 279647, 279656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_279658_279671()
                {
                    var return_v = ValueTupleRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 279658, 279671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_279673_279695()
                {
                    var return_v = SystemRuntimeFacadeRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 279673, 279695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_279577_279729(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 279577, 279729);
                    return return_v;
                }


                bool
                f_23129_280126_280711(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Test.Utilities.PdbValidationOptions
                options)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 280126, 280711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 279396, 280723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 279396, 280723);
            }
        }

        [Fact]
        public void HiddenIterator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 280735, 282930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 280804, 281273);

                var
                src = f_23129_280814_281272(@"
using System;
using System.Collections.Generic;

class C
{
    public static void Main()
    {
        F();
    }

#line hidden
    public static IEnumerable<int> F()
    {
        {
            const int z = 1;
            var (x, y) = (1,2);
            Console.WriteLine(x + z);
        }
        {
            dynamic x = 1;
            Console.WriteLine(x);
        }

        yield return 1;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 281287, 281448);

                var
                c = f_23129_281295_281447(src, references: new[] { f_23129_281365_281374(), f_23129_281376_281389(), f_23129_281391_281413() }, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 281675, 282919);

                f_23129_281675_282918(
                            // We don't really need the debug info for kickoff method when the entire iterator method is hidden, 
                            // but it doesn't hurt and removing it would need extra effort that's unnecessary.
                            c, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""2"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""13"" document=""1"" />
        <entry offset=""0x7"" startLine=""10"" startColumn=""5"" endLine=""10"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x8"">
        <namespace name=""System"" />
        <namespace name=""System.Collections.Generic"" />
      </scope>
    </method>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <forwardIterator name=""&lt;F&gt;d__1"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""61"" />
          <slot kind=""0"" offset=""64"" />
          <slot kind=""0"" offset=""158"" />
        </encLocalSlotMap>
      </customDebugInfo>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 280735, 282930);

                string
                f_23129_280814_281272(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 280814, 281272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_281365_281374()
                {
                    var return_v = CSharpRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 281365, 281374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_281376_281389()
                {
                    var return_v = ValueTupleRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 281376, 281389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_281391_281413()
                {
                    var return_v = SystemRuntimeFacadeRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 281391, 281413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_281295_281447(string
                source, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 281295, 281447);
                    return return_v;
                }


                bool
                f_23129_281675_282918(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 281675, 282918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 280735, 282930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 280735, 282930);
            }
        }

        [Fact]
        public void NestedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 282996, 284301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 283062, 283306);

                string
                source = f_23129_283078_283305(@"
using System;

namespace N
{
	public class C
	{
		public class D<T>
		{
			public class E 
			{
				public static void f(int a) 
				{
					Console.WriteLine();
				}
			}
		}
	}
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 283320, 283382);

                var
                c = f_23129_283328_283381(f_23129_283346_283380(source, filename: "file.cs"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 283396, 284290);

                f_23129_283396_284289(c, @"
<symbols>
  <files>
    <file id=""1"" name=""file.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""F7-03-46-2C-11-16-DE-85-F9-DD-5C-76-F6-55-D9-13-E0-95-DE-14"" />
  </files>
  <methods>
    <method containingType=""N.C+D`1+E"" name=""f"" parameterNames=""a"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""14"" startColumn=""6"" endLine=""14"" endColumn=""26"" document=""1"" />
        <entry offset=""0x5"" startLine=""15"" startColumn=""5"" endLine=""15"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x6"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 282996, 284301);

                string
                f_23129_283078_283305(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 283078, 283305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_283346_283380(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename: filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 283346, 283380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_283328_283381(Microsoft.CodeAnalysis.SyntaxTree
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 283328, 283381);
                    return return_v;
                }


                bool
                f_23129_283396_284289(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 283396, 284289);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 282996, 284301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 282996, 284301);
            }
        }

        [Fact]
        public void ExpressionBodiedProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 284380, 285558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 284459, 284593);

                var
                source = f_23129_284472_284592(@"
class C
{
    public int P => M();
    public int M()
    {
        return 2;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 284607, 284658);

                var
                comp = f_23129_284618_284657(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 284672, 284697);

                f_23129_284672_284696(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 284711, 285547);

                f_23129_284711_285546(comp, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""get_P"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""21"" endLine=""4"" endColumn=""24"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""get_P"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""18"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 284380, 285558);

                string
                f_23129_284472_284592(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 284472, 284592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_284618_284657(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 284618, 284657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_284672_284696(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 284672, 284696);
                    return return_v;
                }


                bool
                f_23129_284711_285546(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 284711, 285546);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 284380, 285558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 284380, 285558);
            }
        }

        [Fact]
        public void ExpressionBodiedIndexer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 285570, 286877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 285648, 285819);

                var
                comp = f_23129_285659_285818(@"
using System;

class C
{
    public int this[Int32 i] => M();
    public int M()
    {
        return 2;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 285833, 285858);

                f_23129_285833_285857(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 285874, 286866);

                f_23129_285874_286865(
                            comp, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""get_Item"" parameterNames=""i"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""33"" endLine=""6"" endColumn=""36"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x7"">
        <namespace name=""System"" />
      </scope>
    </method>
    <method containingType=""C"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""get_Item"" parameterNames=""i"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""18"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 285570, 286877);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_285659_285818(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 285659, 285818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_285833_285857(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 285833, 285857);
                    return return_v;
                }


                bool
                f_23129_285874_286865(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 285874, 286865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 285570, 286877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 285570, 286877);
            }
        }

        [Fact]
        public void ExpressionBodiedMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 286889, 287745);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 286966, 287072);

                var
                comp = f_23129_286977_287071(@"
using System;

class C
{
    public Int32 P => 2;
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 287086, 287111);

                f_23129_287086_287110(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 287127, 287734);

                f_23129_287127_287733(
                            comp, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""get_P"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""23"" endLine=""6"" endColumn=""24"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x2"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 286889, 287745);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_286977_287071(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 286977, 287071);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_287086_287110(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 287086, 287110);
                    return return_v;
                }


                bool
                f_23129_287127_287733(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 287127, 287733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 286889, 287745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 286889, 287745);
            }
        }

        [Fact]
        public void ExpressionBodiedOperator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 287757, 288536);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 287836, 287943);

                var
                comp = f_23129_287847_287942(@"
class C
{
    public static C operator ++(C c) => c;
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 287957, 287982);

                f_23129_287957_287981(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 287998, 288525);

                f_23129_287998_288524(
                            comp, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""op_Increment"" parameterNames=""c"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""41"" endLine=""4"" endColumn=""42"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 287757, 288536);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_287847_287942(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 287847, 287942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_287957_287981(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 287957, 287981);
                    return return_v;
                }


                bool
                f_23129_287998_288524(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 287998, 288524);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 287757, 288536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 287757, 288536);
            }
        }

        [Fact]
        public void ExpressionBodiedConversion()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 288548, 289469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 288629, 288769);

                var
                comp = f_23129_288640_288768(@"
using System;

class C
{
    public static explicit operator C(Int32 i) => new C();
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 288783, 288808);

                f_23129_288783_288807(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 288824, 289458);

                f_23129_288824_289457(
                            comp, @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""op_Explicit"" parameterNames=""i"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""51"" endLine=""6"" endColumn=""58"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x6"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 288548, 289469);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_288640_288768(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 288640, 288768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_288783_288807(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 288783, 288807);
                    return return_v;
                }


                bool
                f_23129_288824_289457(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 288824, 289457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 288548, 289469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 288548, 289469);
            }
        }

        [WorkItem(14438, "https://github.com/dotnet/roslyn/issues/14438")]
        [Fact]
        public void ExpressionBodiedConstructor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 289481, 290577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 289639, 289771);

                var
                comp = f_23129_289650_289770(@"
using System;

class C
{
    public int X;
    public C(Int32 x) => X = x;
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 289785, 289810);

                f_23129_289785_289809(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 289826, 290566);

                f_23129_289826_290565(
                            comp, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"" parameterNames=""x"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""22"" document=""1"" />
        <entry offset=""0x6"" startLine=""7"" startColumn=""26"" endLine=""7"" endColumn=""31"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xe"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 289481, 290577);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_289650_289770(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 289650, 289770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_289785_289809(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 289785, 289809);
                    return return_v;
                }


                bool
                f_23129_289826_290565(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 289826, 290565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 289481, 290577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 289481, 290577);
            }
        }

        [WorkItem(14438, "https://github.com/dotnet/roslyn/issues/14438")]
        [Fact]
        public void ExpressionBodiedDestructor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 290589, 291545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 290746, 290848);

                var
                comp = f_23129_290757_290847(@"
class C
{
    public int X;
    ~C() => X = 0;
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 290862, 290887);

                f_23129_290862_290886(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 290903, 291534);

                f_23129_290903_291533(
                            comp, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Finalize"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""13"" endLine=""5"" endColumn=""18"" document=""1"" />
        <entry offset=""0x9"" hidden=""true"" document=""1"" />
        <entry offset=""0x10"" hidden=""true"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 290589, 291545);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_290757_290847(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 290757, 290847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_290862_290886(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 290862, 290886);
                    return return_v;
                }


                bool
                f_23129_290903_291533(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 290903, 291533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 290589, 291545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 290589, 291545);
            }
        }

        [WorkItem(14438, "https://github.com/dotnet/roslyn/issues/14438")]
        [Fact]
        public void ExpressionBodiedAccessor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 291557, 293640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 291712, 291969);

                var
                comp = f_23129_291723_291968(@"
class C
{
    public int x;
    public int X
    {
        get => x;
        set => x = value;
    }
    public event System.Action E
    {
        add => x = 1;
        remove => x = 0;
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 291983, 292008);

                f_23129_291983_292007(comp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 292024, 293629);

                f_23129_292024_293628(
                            comp, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""get_X"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""16"" endLine=""7"" endColumn=""17"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""set_X"" parameterNames=""value"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""get_X"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""8"" startColumn=""16"" endLine=""8"" endColumn=""25"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""add_E"" parameterNames=""value"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""get_X"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""12"" startColumn=""16"" endLine=""12"" endColumn=""21"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""C"" name=""remove_E"" parameterNames=""value"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""get_X"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""13"" startColumn=""19"" endLine=""13"" endColumn=""24"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 291557, 293640);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_291723_291968(string
                source)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 291723, 291968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_291983_292007(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 291983, 292007);
                    return return_v;
                }


                bool
                f_23129_292024_293628(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 292024, 293628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 291557, 293640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 291557, 293640);
            }
        }

        [Fact]
        public void ImportsInLambda()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 293713, 295353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 293783, 294069);

                var
                source = f_23129_293796_294068(@"using System.Collections.Generic;
using System.Linq;
class C
{
    static void M()
    {
        System.Action f = () =>
        {
            var c = new[] { 1, 2, 3 };
            c.Select(i => i);
        };
        f();
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 294083, 294199);

                var
                c = f_23129_294091_294198(source, options: TestOptions.DebugDll, references: new[] { f_23129_294182_294195() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 294213, 295342);

                f_23129_294213_295341(c, "C+<>c.<M>b__0_0", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c"" name=""&lt;M&gt;b__0_0"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""M"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""63"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1"" startLine=""9"" startColumn=""13"" endLine=""9"" endColumn=""39"" document=""1"" />
        <entry offset=""0x13"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""30"" document=""1"" />
        <entry offset=""0x39"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x3a"">
        <local name=""c"" il_index=""0"" il_start=""0x0"" il_end=""0x3a"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 293713, 295353);

                string
                f_23129_293796_294068(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 293796, 294068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_294182_294195()
                {
                    var return_v = SystemCoreRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 294182, 294195);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_294091_294198(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 294091, 294198);
                    return return_v;
                }


                bool
                f_23129_294213_295341(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 294213, 295341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 293713, 295353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 293713, 295353);
            }
        }

        [Fact]
        public void ImportsInIterator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 295365, 298085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 295437, 295729);

                var
                source = f_23129_295450_295728(@"using System.Collections.Generic;
using System.Linq;
class C
{
    static IEnumerable<object> F()
    {
        var c = new[] { 1, 2, 3 };
        foreach (var i in c.Select(i => i))
        {
            yield return i;
        }
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 295743, 295859);

                var
                c = f_23129_295751_295858(source, options: TestOptions.DebugDll, references: new[] { f_23129_295842_295855() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 295873, 298074);

                f_23129_295873_298073(c, "C+<F>d__0.MoveNext", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;F&gt;d__0"" name=""MoveNext"">
      <customDebugInfo>
        <forward declaringType=""C+&lt;&gt;c"" methodName=""&lt;F&gt;b__0_0"" parameterNames=""i"" />
        <hoistedLocalScopes>
          <slot startOffset=""0x27"" endOffset=""0xd5"" />
          <slot />
          <slot startOffset=""0x7f"" endOffset=""0xb6"" />
        </hoistedLocalScopes>
        <encLocalSlotMap>
          <slot kind=""temp"" />
          <slot kind=""27"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x27"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
        <entry offset=""0x28"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""35"" document=""1"" />
        <entry offset=""0x3f"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""16"" document=""1"" />
        <entry offset=""0x40"" startLine=""8"" startColumn=""27"" endLine=""8"" endColumn=""43"" document=""1"" />
        <entry offset=""0x7d"" hidden=""true"" document=""1"" />
        <entry offset=""0x7f"" startLine=""8"" startColumn=""18"" endLine=""8"" endColumn=""23"" document=""1"" />
        <entry offset=""0x90"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x91"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""28"" document=""1"" />
        <entry offset=""0xad"" hidden=""true"" document=""1"" />
        <entry offset=""0xb5"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
        <entry offset=""0xb6"" startLine=""8"" startColumn=""24"" endLine=""8"" endColumn=""26"" document=""1"" />
        <entry offset=""0xd1"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
        <entry offset=""0xd5"" hidden=""true"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 295365, 298085);

                string
                f_23129_295450_295728(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 295450, 295728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_295842_295855()
                {
                    var return_v = SystemCoreRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 295842, 295855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_295751_295858(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 295751, 295858);
                    return return_v;
                }


                bool
                f_23129_295873_298073(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 295873, 298073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 295365, 298085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 295365, 298085);
            }
        }

        [Fact]
        public void ImportsInAsync()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 298097, 299986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 298166, 298376);

                var
                source = f_23129_298179_298375(@"using System.Linq;
using System.Threading.Tasks;
class C
{
    static async Task F()
    {
        var c = new[] { 1, 2, 3 };
        c.Select(i => i);
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 298390, 298506);

                var
                c = f_23129_298398_298505(source, options: TestOptions.DebugDll, references: new[] { f_23129_298489_298502() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 298520, 299975);

                f_23129_298520_299974(c, "C+<F>d__0.MoveNext", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;F&gt;d__0"" name=""MoveNext"">
      <customDebugInfo>
        <forward declaringType=""C+&lt;&gt;c"" methodName=""&lt;F&gt;b__0_0"" parameterNames=""i"" />
        <hoistedLocalScopes>
          <slot startOffset=""0x0"" endOffset=""0x87"" />
        </hoistedLocalScopes>
        <encLocalSlotMap>
          <slot kind=""27"" offset=""0"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x7"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
        <entry offset=""0x8"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""35"" document=""1"" />
        <entry offset=""0x1f"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""26"" document=""1"" />
        <entry offset=""0x4c"" hidden=""true"" document=""1"" />
        <entry offset=""0x6b"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x73"" hidden=""true"" document=""1"" />
      </sequencePoints>
      <asyncInfo>
        <kickoffMethod declaringType=""C"" methodName=""F"" />
      </asyncInfo>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 298097, 299986);

                string
                f_23129_298179_298375(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 298179, 298375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_298489_298502()
                {
                    var return_v = SystemCoreRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 298489, 298502);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_298398_298505(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 298398, 298505);
                    return return_v;
                }


                bool
                f_23129_298520_299974(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 298520, 299974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 298097, 299986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 298097, 299986);
            }
        }

        [WorkItem(2501, "https://github.com/dotnet/roslyn/issues/2501")]
        [Fact]
        public void ImportsInAsyncLambda()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 299998, 302528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 300147, 300390);

                var
                source = f_23129_300160_300389(@"using System.Linq;
class C
{
    static void M()
    {
        System.Action f = async () =>
        {
            var c = new[] { 1, 2, 3 };
            c.Select(i => i);
        };
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 300404, 300520);

                var
                c = f_23129_300412_300519(source, options: TestOptions.DebugDll, references: new[] { f_23129_300503_300516() })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 300534, 300990);

                f_23129_300534_300989(c, "C+<>c.<M>b__0_0", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c"" name=""&lt;M&gt;b__0_0"">
      <customDebugInfo>
        <forwardIterator name=""&lt;&lt;M&gt;b__0_0&gt;d"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""69"" />
        </encLocalSlotMap>
      </customDebugInfo>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 301004, 302517);

                f_23129_301004_302516(c, "C+<>c+<<M>b__0_0>d.MoveNext", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c+&lt;&lt;M&gt;b__0_0&gt;d"" name=""MoveNext"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""M"" />
        <hoistedLocalScopes>
          <slot startOffset=""0x0"" endOffset=""0x87"" />
        </hoistedLocalScopes>
        <encLocalSlotMap>
          <slot kind=""27"" offset=""50"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x7"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""10"" document=""1"" />
        <entry offset=""0x8"" startLine=""8"" startColumn=""13"" endLine=""8"" endColumn=""39"" document=""1"" />
        <entry offset=""0x1f"" startLine=""9"" startColumn=""13"" endLine=""9"" endColumn=""30"" document=""1"" />
        <entry offset=""0x4c"" hidden=""true"" document=""1"" />
        <entry offset=""0x6b"" startLine=""10"" startColumn=""9"" endLine=""10"" endColumn=""10"" document=""1"" />
        <entry offset=""0x73"" hidden=""true"" document=""1"" />
      </sequencePoints>
      <asyncInfo>
        <catchHandler offset=""0x4c"" />
        <kickoffMethod declaringType=""C+&lt;&gt;c"" methodName=""&lt;M&gt;b__0_0"" />
      </asyncInfo>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 299998, 302528);

                string
                f_23129_300160_300389(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 300160, 300389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_300503_300516()
                {
                    var return_v = SystemCoreRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 300503, 300516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_300412_300519(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib45((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 300412, 300519);
                    return return_v;
                }


                bool
                f_23129_300534_300989(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 300534, 300989);
                    return return_v;
                }


                bool
                f_23129_301004_302516(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 301004, 302516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 299998, 302528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 299998, 302528);
            }
        }

        [Fact]
        public void SyntaxOffset_IsPattern()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 302590, 303666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 302667, 302750);

                var
                source = @"class C { bool F(object o) => o is int i && o is 3 && o is bool; }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 302764, 302856);

                var
                c = f_23129_302772_302855(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 302872, 303655);

                f_23129_302872_303654(
                            c, "C.F", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"" parameterNames=""o"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""12"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""1"" startColumn=""31"" endLine=""1"" endColumn=""64"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x2d"">
        <local name=""i"" il_index=""0"" il_start=""0x0"" il_end=""0x2d"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 302590, 303666);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_302772_302855(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 302772, 302855);
                    return return_v;
                }


                bool
                f_23129_302872_303654(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 302872, 303654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 302590, 303666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 302590, 303666);
            }
        }

        [WorkItem(37172, "https://github.com/dotnet/roslyn/issues/37172")]
        [Fact]
        public void Patterns_SwitchStatement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 303678, 319728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 303833, 305002);

                string
                source = f_23129_303849_305001(@"
class C
{
    public void Deconstruct() { }
    public void Deconstruct(out int x) { x = 1; }
    public void Deconstruct(out int x, out object y) { x = 2; y = new C(); }
}

class D
{
    public int P { get; set; }
    public D Q { get; set; }
    public C R { get; set; }
}

class Program
{
    static object F() => new C();
    static bool B() => true;
    static int G(int x) => x;

    static int Main()
    {
        switch (F())
        {
            // declaration pattern
            case int x when G(x) > 10: return 1;

            // discard pattern
            case bool _: return 2;

            // var pattern
            case var (y, z): return 3;

            // constant pattern
            case 4.0: return 4;

            // positional patterns
            case C() when B(): return 5;
            case (): return 6;
            case C(int p, C(int q)): return 7;
            case C(x: int p): return 8;

            // property pattern
            case D { P: 1, Q: D { P: 2 }, R: C(int z) }: return 9;

            default: return 10;
        };
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 305016, 305126);

                var
                c = f_23129_305024_305125(source, options: TestOptions.DebugDll, targetFramework: TargetFramework.NetCoreApp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 305140, 305205);

                var
                verifier = f_23129_305155_305204(this, c, verify: Verification.Skipped)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 305221, 313163);

                f_23129_305221_313162(
                            verifier, "Program.Main", sequencePoints: "Program.Main", expectedIL: @"
    {
      // Code size      432 (0x1b0)
      .maxstack  3
      .locals init (int V_0, //x
                    object V_1, //y
                    object V_2, //z
                    int V_3, //p
                    int V_4, //q
                    int V_5, //p
                    int V_6, //z
                    object V_7,
                    System.Runtime.CompilerServices.ITuple V_8,
                    int V_9,
                    double V_10,
                    C V_11,
                    object V_12,
                    C V_13,
                    D V_14,
                    int V_15,
                    D V_16,
                    int V_17,
                    C V_18,
                    object V_19,
                    int V_20)
      // sequence point: {
      IL_0000:  nop
      // sequence point: switch (F())
      IL_0001:  call       ""object Program.F()""
      IL_0006:  stloc.s    V_19
      // sequence point: <hidden>
      IL_0008:  ldloc.s    V_19
      IL_000a:  stloc.s    V_7
      // sequence point: <hidden>
      IL_000c:  ldloc.s    V_7
      IL_000e:  isinst     ""int""
      IL_0013:  brfalse.s  IL_0022
      IL_0015:  ldloc.s    V_7
      IL_0017:  unbox.any  ""int""
      IL_001c:  stloc.0
      // sequence point: <hidden>
      IL_001d:  br         IL_014d
      IL_0022:  ldloc.s    V_7
      IL_0024:  isinst     ""bool""
      IL_0029:  brtrue     IL_015e
      IL_002e:  ldloc.s    V_7
      IL_0030:  isinst     ""System.Runtime.CompilerServices.ITuple""
      IL_0035:  stloc.s    V_8
      IL_0037:  ldloc.s    V_8
      IL_0039:  brfalse.s  IL_0080
      IL_003b:  ldloc.s    V_8
      IL_003d:  callvirt   ""int System.Runtime.CompilerServices.ITuple.Length.get""
      IL_0042:  stloc.s    V_9
      // sequence point: <hidden>
      IL_0044:  ldloc.s    V_9
      IL_0046:  ldc.i4.2
      IL_0047:  bne.un.s   IL_0060
      IL_0049:  ldloc.s    V_8
      IL_004b:  ldc.i4.0
      IL_004c:  callvirt   ""object System.Runtime.CompilerServices.ITuple.this[int].get""
      IL_0051:  stloc.1
      // sequence point: <hidden>
      IL_0052:  ldloc.s    V_8
      IL_0054:  ldc.i4.1
      IL_0055:  callvirt   ""object System.Runtime.CompilerServices.ITuple.this[int].get""
      IL_005a:  stloc.2
      // sequence point: <hidden>
      IL_005b:  br         IL_0163
      IL_0060:  ldloc.s    V_7
      IL_0062:  isinst     ""C""
      IL_0067:  brtrue     IL_016f
      IL_006c:  br.s       IL_0077
      IL_006e:  ldloc.s    V_9
      IL_0070:  brfalse    IL_018c
      IL_0075:  br.s       IL_00b5
      IL_0077:  ldloc.s    V_9
      IL_0079:  brfalse    IL_018c
      IL_007e:  br.s       IL_00f5
      IL_0080:  ldloc.s    V_7
      IL_0082:  isinst     ""double""
      IL_0087:  brfalse.s  IL_00a7
      IL_0089:  ldloc.s    V_7
      IL_008b:  unbox.any  ""double""
      IL_0090:  stloc.s    V_10
      // sequence point: <hidden>
      IL_0092:  ldloc.s    V_10
      IL_0094:  ldc.r8     4
      IL_009d:  beq        IL_016a
      IL_00a2:  br         IL_01a7
      IL_00a7:  ldloc.s    V_7
      IL_00a9:  isinst     ""C""
      IL_00ae:  brtrue     IL_017b
      IL_00b3:  br.s       IL_00f5
      IL_00b5:  ldloc.s    V_7
      IL_00b7:  castclass  ""C""
      IL_00bc:  stloc.s    V_11
      // sequence point: <hidden>
      IL_00be:  ldloc.s    V_11
      IL_00c0:  ldloca.s   V_3
      IL_00c2:  ldloca.s   V_12
      IL_00c4:  callvirt   ""void C.Deconstruct(out int, out object)""
      IL_00c9:  nop
      // sequence point: <hidden>
      IL_00ca:  ldloc.s    V_12
      IL_00cc:  isinst     ""C""
      IL_00d1:  stloc.s    V_13
      IL_00d3:  ldloc.s    V_13
      IL_00d5:  brfalse.s  IL_00e6
      IL_00d7:  ldloc.s    V_13
      IL_00d9:  ldloca.s   V_4
      IL_00db:  callvirt   ""void C.Deconstruct(out int)""
      IL_00e0:  nop
      // sequence point: <hidden>
      IL_00e1:  br         IL_0191
      IL_00e6:  ldloc.s    V_11
      IL_00e8:  ldloca.s   V_5
      IL_00ea:  callvirt   ""void C.Deconstruct(out int)""
      IL_00ef:  nop
      // sequence point: <hidden>
      IL_00f0:  br         IL_0198
      IL_00f5:  ldloc.s    V_7
      IL_00f7:  isinst     ""D""
      IL_00fc:  stloc.s    V_14
      IL_00fe:  ldloc.s    V_14
      IL_0100:  brfalse    IL_01a7
      IL_0105:  ldloc.s    V_14
      IL_0107:  callvirt   ""int D.P.get""
      IL_010c:  stloc.s    V_15
      // sequence point: <hidden>
      IL_010e:  ldloc.s    V_15
      IL_0110:  ldc.i4.1
      IL_0111:  bne.un     IL_01a7
      IL_0116:  ldloc.s    V_14
      IL_0118:  callvirt   ""D D.Q.get""
      IL_011d:  stloc.s    V_16
      // sequence point: <hidden>
      IL_011f:  ldloc.s    V_16
      IL_0121:  brfalse    IL_01a7
      IL_0126:  ldloc.s    V_16
      IL_0128:  callvirt   ""int D.P.get""
      IL_012d:  stloc.s    V_17
      // sequence point: <hidden>
      IL_012f:  ldloc.s    V_17
      IL_0131:  ldc.i4.2
      IL_0132:  bne.un.s   IL_01a7
      IL_0134:  ldloc.s    V_14
      IL_0136:  callvirt   ""C D.R.get""
      IL_013b:  stloc.s    V_18
      // sequence point: <hidden>
      IL_013d:  ldloc.s    V_18
      IL_013f:  brfalse.s  IL_01a7
      IL_0141:  ldloc.s    V_18
      IL_0143:  ldloca.s   V_6
      IL_0145:  callvirt   ""void C.Deconstruct(out int)""
      IL_014a:  nop
      // sequence point: <hidden>
      IL_014b:  br.s       IL_019f
      // sequence point: when G(x) > 10
      IL_014d:  ldloc.0
      IL_014e:  call       ""int Program.G(int)""
      IL_0153:  ldc.i4.s   10
      IL_0155:  bgt.s      IL_0159
      // sequence point: <hidden>
      IL_0157:  br.s       IL_01a7
      // sequence point: return 1;
      IL_0159:  ldc.i4.1
      IL_015a:  stloc.s    V_20
      IL_015c:  br.s       IL_01ad
      // sequence point: return 2;
      IL_015e:  ldc.i4.2
      IL_015f:  stloc.s    V_20
      IL_0161:  br.s       IL_01ad
      // sequence point: <hidden>
      IL_0163:  br.s       IL_0165
      // sequence point: return 3;
      IL_0165:  ldc.i4.3
      IL_0166:  stloc.s    V_20
      IL_0168:  br.s       IL_01ad
      // sequence point: return 4;
      IL_016a:  ldc.i4.4
      IL_016b:  stloc.s    V_20
      IL_016d:  br.s       IL_01ad
      // sequence point: when B()
      IL_016f:  call       ""bool Program.B()""
      IL_0174:  brtrue.s   IL_0187
      // sequence point: <hidden>
      IL_0176:  br         IL_006e
      // sequence point: when B()
      IL_017b:  call       ""bool Program.B()""
      IL_0180:  brtrue.s   IL_0187
      // sequence point: <hidden>
      IL_0182:  br         IL_00b5
      // sequence point: return 5;
      IL_0187:  ldc.i4.5
      IL_0188:  stloc.s    V_20
      IL_018a:  br.s       IL_01ad
      // sequence point: return 6;
      IL_018c:  ldc.i4.6
      IL_018d:  stloc.s    V_20
      IL_018f:  br.s       IL_01ad
      // sequence point: <hidden>
      IL_0191:  br.s       IL_0193
      // sequence point: return 7;
      IL_0193:  ldc.i4.7
      IL_0194:  stloc.s    V_20
      IL_0196:  br.s       IL_01ad
      // sequence point: <hidden>
      IL_0198:  br.s       IL_019a
      // sequence point: return 8;
      IL_019a:  ldc.i4.8
      IL_019b:  stloc.s    V_20
      IL_019d:  br.s       IL_01ad
      // sequence point: <hidden>
      IL_019f:  br.s       IL_01a1
      // sequence point: return 9;
      IL_01a1:  ldc.i4.s   9
      IL_01a3:  stloc.s    V_20
      IL_01a5:  br.s       IL_01ad
      // sequence point: return 10;
      IL_01a7:  ldc.i4.s   10
      IL_01a9:  stloc.s    V_20
      IL_01ab:  br.s       IL_01ad
      // sequence point: }
      IL_01ad:  ldloc.s    V_20
      IL_01af:  ret
    }
", source: source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 313179, 319717);

                f_23129_313179_319716(
                            verifier, "Program.Main", @"   
    <symbols>
      <files>
        <file id=""1"" name="""" language=""C#"" />
      </files>
      <methods>
        <method containingType=""Program"" name=""Main"">
          <customDebugInfo>
            <forward declaringType=""C"" methodName=""Deconstruct"" />
            <encLocalSlotMap>
              <slot kind=""0"" offset=""93"" />
              <slot kind=""0"" offset=""244"" />
              <slot kind=""0"" offset=""247"" />
              <slot kind=""0"" offset=""465"" />
              <slot kind=""0"" offset=""474"" />
              <slot kind=""0"" offset=""516"" />
              <slot kind=""0"" offset=""617"" />
              <slot kind=""35"" offset=""11"" />
              <slot kind=""35"" offset=""11"" ordinal=""1"" />
              <slot kind=""35"" offset=""11"" ordinal=""2"" />
              <slot kind=""35"" offset=""11"" ordinal=""3"" />
              <slot kind=""35"" offset=""11"" ordinal=""4"" />
              <slot kind=""35"" offset=""11"" ordinal=""5"" />
              <slot kind=""35"" offset=""11"" ordinal=""6"" />
              <slot kind=""35"" offset=""11"" ordinal=""7"" />
              <slot kind=""35"" offset=""11"" ordinal=""8"" />
              <slot kind=""35"" offset=""11"" ordinal=""9"" />
              <slot kind=""35"" offset=""11"" ordinal=""10"" />
              <slot kind=""35"" offset=""11"" ordinal=""11"" />
              <slot kind=""1"" offset=""11"" />
              <slot kind=""21"" offset=""0"" />
            </encLocalSlotMap>
          </customDebugInfo>
          <sequencePoints>
            <entry offset=""0x0"" startLine=""23"" startColumn=""5"" endLine=""23"" endColumn=""6"" document=""1"" />
            <entry offset=""0x1"" startLine=""24"" startColumn=""9"" endLine=""24"" endColumn=""21"" document=""1"" />
            <entry offset=""0x8"" hidden=""true"" document=""1"" />
            <entry offset=""0xc"" hidden=""true"" document=""1"" />
            <entry offset=""0x1d"" hidden=""true"" document=""1"" />
            <entry offset=""0x44"" hidden=""true"" document=""1"" />
            <entry offset=""0x52"" hidden=""true"" document=""1"" />
            <entry offset=""0x5b"" hidden=""true"" document=""1"" />
            <entry offset=""0x92"" hidden=""true"" document=""1"" />
            <entry offset=""0xbe"" hidden=""true"" document=""1"" />
            <entry offset=""0xca"" hidden=""true"" document=""1"" />
            <entry offset=""0xe1"" hidden=""true"" document=""1"" />
            <entry offset=""0xf0"" hidden=""true"" document=""1"" />
            <entry offset=""0x10e"" hidden=""true"" document=""1"" />
            <entry offset=""0x11f"" hidden=""true"" document=""1"" />
            <entry offset=""0x12f"" hidden=""true"" document=""1"" />
            <entry offset=""0x13d"" hidden=""true"" document=""1"" />
            <entry offset=""0x14b"" hidden=""true"" document=""1"" />
            <entry offset=""0x14d"" startLine=""27"" startColumn=""24"" endLine=""27"" endColumn=""38"" document=""1"" />
            <entry offset=""0x157"" hidden=""true"" document=""1"" />
            <entry offset=""0x159"" startLine=""27"" startColumn=""40"" endLine=""27"" endColumn=""49"" document=""1"" />
            <entry offset=""0x15e"" startLine=""30"" startColumn=""26"" endLine=""30"" endColumn=""35"" document=""1"" />
            <entry offset=""0x163"" hidden=""true"" document=""1"" />
            <entry offset=""0x165"" startLine=""33"" startColumn=""30"" endLine=""33"" endColumn=""39"" document=""1"" />
            <entry offset=""0x16a"" startLine=""36"" startColumn=""23"" endLine=""36"" endColumn=""32"" document=""1"" />
            <entry offset=""0x16f"" startLine=""39"" startColumn=""22"" endLine=""39"" endColumn=""30"" document=""1"" />
            <entry offset=""0x176"" hidden=""true"" document=""1"" />
            <entry offset=""0x17b"" startLine=""39"" startColumn=""22"" endLine=""39"" endColumn=""30"" document=""1"" />
            <entry offset=""0x182"" hidden=""true"" document=""1"" />
            <entry offset=""0x187"" startLine=""39"" startColumn=""32"" endLine=""39"" endColumn=""41"" document=""1"" />
            <entry offset=""0x18c"" startLine=""40"" startColumn=""22"" endLine=""40"" endColumn=""31"" document=""1"" />
            <entry offset=""0x191"" hidden=""true"" document=""1"" />
            <entry offset=""0x193"" startLine=""41"" startColumn=""38"" endLine=""41"" endColumn=""47"" document=""1"" />
            <entry offset=""0x198"" hidden=""true"" document=""1"" />
            <entry offset=""0x19a"" startLine=""42"" startColumn=""31"" endLine=""42"" endColumn=""40"" document=""1"" />
            <entry offset=""0x19f"" hidden=""true"" document=""1"" />
            <entry offset=""0x1a1"" startLine=""45"" startColumn=""58"" endLine=""45"" endColumn=""67"" document=""1"" />
            <entry offset=""0x1a7"" startLine=""47"" startColumn=""22"" endLine=""47"" endColumn=""32"" document=""1"" />
            <entry offset=""0x1ad"" startLine=""49"" startColumn=""5"" endLine=""49"" endColumn=""6"" document=""1"" />
          </sequencePoints>
          <scope startOffset=""0x0"" endOffset=""0x1b0"">
            <scope startOffset=""0x14d"" endOffset=""0x15e"">
              <local name=""x"" il_index=""0"" il_start=""0x14d"" il_end=""0x15e"" attributes=""0"" />
            </scope>
            <scope startOffset=""0x163"" endOffset=""0x16a"">
              <local name=""y"" il_index=""1"" il_start=""0x163"" il_end=""0x16a"" attributes=""0"" />
              <local name=""z"" il_index=""2"" il_start=""0x163"" il_end=""0x16a"" attributes=""0"" />
            </scope>
            <scope startOffset=""0x191"" endOffset=""0x198"">
              <local name=""p"" il_index=""3"" il_start=""0x191"" il_end=""0x198"" attributes=""0"" />
              <local name=""q"" il_index=""4"" il_start=""0x191"" il_end=""0x198"" attributes=""0"" />
            </scope>
            <scope startOffset=""0x198"" endOffset=""0x19f"">
              <local name=""p"" il_index=""5"" il_start=""0x198"" il_end=""0x19f"" attributes=""0"" />
            </scope>
            <scope startOffset=""0x19f"" endOffset=""0x1a7"">
              <local name=""z"" il_index=""6"" il_start=""0x19f"" il_end=""0x1a7"" attributes=""0"" />
            </scope>
          </scope>
        </method>
      </methods>
    </symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 303678, 319728);

                string
                f_23129_303849_305001(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 303849, 305001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_305024_305125(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 305024, 305125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_305155_305204(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, verify: verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 305155, 305204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_305221_313162(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                expectedIL, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, expectedIL: expectedIL, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 305221, 313162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_313179_319716(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 313179, 319716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 303678, 319728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 303678, 319728);
            }
        }

        [WorkItem(37172, "https://github.com/dotnet/roslyn/issues/37172")]
        [Fact]
        public void Patterns_SwitchExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 319740, 335746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 319896, 320972);

                string
                source = f_23129_319912_320971(@"
class C
{
    public void Deconstruct() { }
    public void Deconstruct(out int x) { x = 1; }
    public void Deconstruct(out int x, out object y) { x = 2; y = new C(); }
}

class D
{
    public int P { get; set; }
    public D Q { get; set; }
    public C R { get; set; }
}

class Program
{
    static object F() => new C();
    static bool B() => true;
    static int G(int x) => x;

    static void Main()
    {
        var a = F() switch
        {
            // declaration pattern
            int x when G(x) > 10 => 1,

            // discard pattern
            bool _ => 2,

            // var pattern
            var (y, z) => 3,

            // constant pattern
            4.0 => 4,

            // positional patterns
            C() when B() => 5,
            () => 6,
            C(int p, C(int q)) => 7,
            C(x: int p) => 8,

            // property pattern
            D { P: 1, Q: D { P: 2 }, R: C (int z) } => 9,

            _ => 10,
        };
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 320986, 321096);

                var
                c = f_23129_320994_321095(source, options: TestOptions.DebugDll, targetFramework: TargetFramework.NetCoreApp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 321110, 321175);

                var
                verifier = f_23129_321125_321174(this, c, verify: Verification.Skipped)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 321270, 327948);

                f_23129_321270_327947(
                            // note no sequence points emitted within the switch expression

                            verifier, "Program.Main", sequencePoints: "Program.Main", expectedIL: @"
    {
      // Code size      437 (0x1b5)
      .maxstack  3
      .locals init (int V_0, //a
                    int V_1, //x
                    object V_2, //y
                    object V_3, //z
                    int V_4, //p
                    int V_5, //q
                    int V_6, //p
                    int V_7, //z
                    int V_8,
                    object V_9,
                    System.Runtime.CompilerServices.ITuple V_10,
                    int V_11,
                    double V_12,
                    C V_13,
                    object V_14,
                    C V_15,
                    D V_16,
                    int V_17,
                    D V_18,
                    int V_19,
                    C V_20)
     -IL_0000:  nop
     -IL_0001:  call       ""object Program.F()""
      IL_0006:  stloc.s    V_9
      IL_0008:  ldc.i4.1
      IL_0009:  brtrue.s   IL_000c
     -IL_000b:  nop
     ~IL_000c:  ldloc.s    V_9
      IL_000e:  isinst     ""int""
      IL_0013:  brfalse.s  IL_0022
      IL_0015:  ldloc.s    V_9
      IL_0017:  unbox.any  ""int""
      IL_001c:  stloc.1
     ~IL_001d:  br         IL_014d
      IL_0022:  ldloc.s    V_9
      IL_0024:  isinst     ""bool""
      IL_0029:  brtrue     IL_015e
      IL_002e:  ldloc.s    V_9
      IL_0030:  isinst     ""System.Runtime.CompilerServices.ITuple""
      IL_0035:  stloc.s    V_10
      IL_0037:  ldloc.s    V_10
      IL_0039:  brfalse.s  IL_0080
      IL_003b:  ldloc.s    V_10
      IL_003d:  callvirt   ""int System.Runtime.CompilerServices.ITuple.Length.get""
      IL_0042:  stloc.s    V_11
     ~IL_0044:  ldloc.s    V_11
      IL_0046:  ldc.i4.2
      IL_0047:  bne.un.s   IL_0060
      IL_0049:  ldloc.s    V_10
      IL_004b:  ldc.i4.0
      IL_004c:  callvirt   ""object System.Runtime.CompilerServices.ITuple.this[int].get""
      IL_0051:  stloc.2
     ~IL_0052:  ldloc.s    V_10
      IL_0054:  ldc.i4.1
      IL_0055:  callvirt   ""object System.Runtime.CompilerServices.ITuple.this[int].get""
      IL_005a:  stloc.3
     ~IL_005b:  br         IL_0163
      IL_0060:  ldloc.s    V_9
      IL_0062:  isinst     ""C""
      IL_0067:  brtrue     IL_016f
      IL_006c:  br.s       IL_0077
      IL_006e:  ldloc.s    V_11
      IL_0070:  brfalse    IL_018c
      IL_0075:  br.s       IL_00b5
      IL_0077:  ldloc.s    V_11
      IL_0079:  brfalse    IL_018c
      IL_007e:  br.s       IL_00f5
      IL_0080:  ldloc.s    V_9
      IL_0082:  isinst     ""double""
      IL_0087:  brfalse.s  IL_00a7
      IL_0089:  ldloc.s    V_9
      IL_008b:  unbox.any  ""double""
      IL_0090:  stloc.s    V_12
     ~IL_0092:  ldloc.s    V_12
      IL_0094:  ldc.r8     4
      IL_009d:  beq        IL_016a
      IL_00a2:  br         IL_01a7
      IL_00a7:  ldloc.s    V_9
      IL_00a9:  isinst     ""C""
      IL_00ae:  brtrue     IL_017b
      IL_00b3:  br.s       IL_00f5
      IL_00b5:  ldloc.s    V_9
      IL_00b7:  castclass  ""C""
      IL_00bc:  stloc.s    V_13
     ~IL_00be:  ldloc.s    V_13
      IL_00c0:  ldloca.s   V_4
      IL_00c2:  ldloca.s   V_14
      IL_00c4:  callvirt   ""void C.Deconstruct(out int, out object)""
      IL_00c9:  nop
     ~IL_00ca:  ldloc.s    V_14
      IL_00cc:  isinst     ""C""
      IL_00d1:  stloc.s    V_15
      IL_00d3:  ldloc.s    V_15
      IL_00d5:  brfalse.s  IL_00e6
      IL_00d7:  ldloc.s    V_15
      IL_00d9:  ldloca.s   V_5
      IL_00db:  callvirt   ""void C.Deconstruct(out int)""
      IL_00e0:  nop
     ~IL_00e1:  br         IL_0191
      IL_00e6:  ldloc.s    V_13
      IL_00e8:  ldloca.s   V_6
      IL_00ea:  callvirt   ""void C.Deconstruct(out int)""
      IL_00ef:  nop
     ~IL_00f0:  br         IL_0198
      IL_00f5:  ldloc.s    V_9
      IL_00f7:  isinst     ""D""
      IL_00fc:  stloc.s    V_16
      IL_00fe:  ldloc.s    V_16
      IL_0100:  brfalse    IL_01a7
      IL_0105:  ldloc.s    V_16
      IL_0107:  callvirt   ""int D.P.get""
      IL_010c:  stloc.s    V_17
     ~IL_010e:  ldloc.s    V_17
      IL_0110:  ldc.i4.1
      IL_0111:  bne.un     IL_01a7
      IL_0116:  ldloc.s    V_16
      IL_0118:  callvirt   ""D D.Q.get""
      IL_011d:  stloc.s    V_18
     ~IL_011f:  ldloc.s    V_18
      IL_0121:  brfalse    IL_01a7
      IL_0126:  ldloc.s    V_18
      IL_0128:  callvirt   ""int D.P.get""
      IL_012d:  stloc.s    V_19
     ~IL_012f:  ldloc.s    V_19
      IL_0131:  ldc.i4.2
      IL_0132:  bne.un.s   IL_01a7
      IL_0134:  ldloc.s    V_16
      IL_0136:  callvirt   ""C D.R.get""
      IL_013b:  stloc.s    V_20
     ~IL_013d:  ldloc.s    V_20
      IL_013f:  brfalse.s  IL_01a7
      IL_0141:  ldloc.s    V_20
      IL_0143:  ldloca.s   V_7
      IL_0145:  callvirt   ""void C.Deconstruct(out int)""
      IL_014a:  nop
     ~IL_014b:  br.s       IL_019f
     -IL_014d:  ldloc.1
      IL_014e:  call       ""int Program.G(int)""
      IL_0153:  ldc.i4.s   10
      IL_0155:  bgt.s      IL_0159
     ~IL_0157:  br.s       IL_01a7
     -IL_0159:  ldc.i4.1
      IL_015a:  stloc.s    V_8
      IL_015c:  br.s       IL_01ad
     -IL_015e:  ldc.i4.2
      IL_015f:  stloc.s    V_8
      IL_0161:  br.s       IL_01ad
     ~IL_0163:  br.s       IL_0165
     -IL_0165:  ldc.i4.3
      IL_0166:  stloc.s    V_8
      IL_0168:  br.s       IL_01ad
     -IL_016a:  ldc.i4.4
      IL_016b:  stloc.s    V_8
      IL_016d:  br.s       IL_01ad
     -IL_016f:  call       ""bool Program.B()""
      IL_0174:  brtrue.s   IL_0187
     ~IL_0176:  br         IL_006e
     -IL_017b:  call       ""bool Program.B()""
      IL_0180:  brtrue.s   IL_0187
     ~IL_0182:  br         IL_00b5
     -IL_0187:  ldc.i4.5
      IL_0188:  stloc.s    V_8
      IL_018a:  br.s       IL_01ad
     -IL_018c:  ldc.i4.6
      IL_018d:  stloc.s    V_8
      IL_018f:  br.s       IL_01ad
     ~IL_0191:  br.s       IL_0193
     -IL_0193:  ldc.i4.7
      IL_0194:  stloc.s    V_8
      IL_0196:  br.s       IL_01ad
     ~IL_0198:  br.s       IL_019a
     -IL_019a:  ldc.i4.8
      IL_019b:  stloc.s    V_8
      IL_019d:  br.s       IL_01ad
     ~IL_019f:  br.s       IL_01a1
     -IL_01a1:  ldc.i4.s   9
      IL_01a3:  stloc.s    V_8
      IL_01a5:  br.s       IL_01ad
     -IL_01a7:  ldc.i4.s   10
      IL_01a9:  stloc.s    V_8
      IL_01ab:  br.s       IL_01ad
     ~IL_01ad:  ldc.i4.1
      IL_01ae:  brtrue.s   IL_01b1
     -IL_01b0:  nop
     ~IL_01b1:  ldloc.s    V_8
      IL_01b3:  stloc.0
     -IL_01b4:  ret
    }
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 327964, 335735);

                f_23129_327964_335734(
                            verifier, "Program.Main", @"
    <symbols>
      <files>
        <file id=""1"" name="""" language=""C#"" />
      </files>
      <methods>
        <method containingType=""Program"" name=""Main"">
          <customDebugInfo>
            <forward declaringType=""C"" methodName=""Deconstruct"" />
            <encLocalSlotMap>
              <slot kind=""0"" offset=""15"" />
              <slot kind=""0"" offset=""94"" />
              <slot kind=""0"" offset=""225"" />
              <slot kind=""0"" offset=""228"" />
              <slot kind=""0"" offset=""406"" />
              <slot kind=""0"" offset=""415"" />
              <slot kind=""0"" offset=""447"" />
              <slot kind=""0"" offset=""539"" />
              <slot kind=""temp"" />
              <slot kind=""35"" offset=""23"" />
              <slot kind=""35"" offset=""23"" ordinal=""1"" />
              <slot kind=""35"" offset=""23"" ordinal=""2"" />
              <slot kind=""35"" offset=""23"" ordinal=""3"" />
              <slot kind=""35"" offset=""23"" ordinal=""4"" />
              <slot kind=""35"" offset=""23"" ordinal=""5"" />
              <slot kind=""35"" offset=""23"" ordinal=""6"" />
              <slot kind=""35"" offset=""23"" ordinal=""7"" />
              <slot kind=""35"" offset=""23"" ordinal=""8"" />
              <slot kind=""35"" offset=""23"" ordinal=""9"" />
              <slot kind=""35"" offset=""23"" ordinal=""10"" />
              <slot kind=""35"" offset=""23"" ordinal=""11"" />
            </encLocalSlotMap>
          </customDebugInfo>
          <sequencePoints>
            <entry offset=""0x0"" startLine=""23"" startColumn=""5"" endLine=""23"" endColumn=""6"" document=""1"" />
            <entry offset=""0x1"" startLine=""24"" startColumn=""9"" endLine=""48"" endColumn=""11"" document=""1"" />
            <entry offset=""0xb"" startLine=""24"" startColumn=""21"" endLine=""48"" endColumn=""10"" document=""1"" />
            <entry offset=""0xc"" hidden=""true"" document=""1"" />
            <entry offset=""0x1d"" hidden=""true"" document=""1"" />
            <entry offset=""0x44"" hidden=""true"" document=""1"" />
            <entry offset=""0x52"" hidden=""true"" document=""1"" />
            <entry offset=""0x5b"" hidden=""true"" document=""1"" />
            <entry offset=""0x92"" hidden=""true"" document=""1"" />
            <entry offset=""0xbe"" hidden=""true"" document=""1"" />
            <entry offset=""0xca"" hidden=""true"" document=""1"" />
            <entry offset=""0xe1"" hidden=""true"" document=""1"" />
            <entry offset=""0xf0"" hidden=""true"" document=""1"" />
            <entry offset=""0x10e"" hidden=""true"" document=""1"" />
            <entry offset=""0x11f"" hidden=""true"" document=""1"" />
            <entry offset=""0x12f"" hidden=""true"" document=""1"" />
            <entry offset=""0x13d"" hidden=""true"" document=""1"" />
            <entry offset=""0x14b"" hidden=""true"" document=""1"" />
            <entry offset=""0x14d"" startLine=""27"" startColumn=""19"" endLine=""27"" endColumn=""33"" document=""1"" />
            <entry offset=""0x157"" hidden=""true"" document=""1"" />
            <entry offset=""0x159"" startLine=""27"" startColumn=""37"" endLine=""27"" endColumn=""38"" document=""1"" />
            <entry offset=""0x15e"" startLine=""30"" startColumn=""23"" endLine=""30"" endColumn=""24"" document=""1"" />
            <entry offset=""0x163"" hidden=""true"" document=""1"" />
            <entry offset=""0x165"" startLine=""33"" startColumn=""27"" endLine=""33"" endColumn=""28"" document=""1"" />
            <entry offset=""0x16a"" startLine=""36"" startColumn=""20"" endLine=""36"" endColumn=""21"" document=""1"" />
            <entry offset=""0x16f"" startLine=""39"" startColumn=""17"" endLine=""39"" endColumn=""25"" document=""1"" />
            <entry offset=""0x176"" hidden=""true"" document=""1"" />
            <entry offset=""0x17b"" startLine=""39"" startColumn=""17"" endLine=""39"" endColumn=""25"" document=""1"" />
            <entry offset=""0x182"" hidden=""true"" document=""1"" />
            <entry offset=""0x187"" startLine=""39"" startColumn=""29"" endLine=""39"" endColumn=""30"" document=""1"" />
            <entry offset=""0x18c"" startLine=""40"" startColumn=""19"" endLine=""40"" endColumn=""20"" document=""1"" />
            <entry offset=""0x191"" hidden=""true"" document=""1"" />
            <entry offset=""0x193"" startLine=""41"" startColumn=""35"" endLine=""41"" endColumn=""36"" document=""1"" />
            <entry offset=""0x198"" hidden=""true"" document=""1"" />
            <entry offset=""0x19a"" startLine=""42"" startColumn=""28"" endLine=""42"" endColumn=""29"" document=""1"" />
            <entry offset=""0x19f"" hidden=""true"" document=""1"" />
            <entry offset=""0x1a1"" startLine=""45"" startColumn=""56"" endLine=""45"" endColumn=""57"" document=""1"" />
            <entry offset=""0x1a7"" startLine=""47"" startColumn=""18"" endLine=""47"" endColumn=""20"" document=""1"" />
            <entry offset=""0x1ad"" hidden=""true"" document=""1"" />
            <entry offset=""0x1b0"" startLine=""24"" startColumn=""9"" endLine=""48"" endColumn=""11"" document=""1"" />
            <entry offset=""0x1b1"" hidden=""true"" document=""1"" />
            <entry offset=""0x1b4"" startLine=""49"" startColumn=""5"" endLine=""49"" endColumn=""6"" document=""1"" />
          </sequencePoints>
          <scope startOffset=""0x0"" endOffset=""0x1b5"">
            <local name=""a"" il_index=""0"" il_start=""0x0"" il_end=""0x1b5"" attributes=""0"" />
            <scope startOffset=""0x1"" endOffset=""0x1b4"">
              <local name=""x"" il_index=""1"" il_start=""0x1"" il_end=""0x1b4"" attributes=""0"" />
              <local name=""y"" il_index=""2"" il_start=""0x1"" il_end=""0x1b4"" attributes=""0"" />
              <local name=""z"" il_index=""3"" il_start=""0x1"" il_end=""0x1b4"" attributes=""0"" />
              <local name=""p"" il_index=""4"" il_start=""0x1"" il_end=""0x1b4"" attributes=""0"" />
              <local name=""q"" il_index=""5"" il_start=""0x1"" il_end=""0x1b4"" attributes=""0"" />
              <local name=""p"" il_index=""6"" il_start=""0x1"" il_end=""0x1b4"" attributes=""0"" />
              <local name=""z"" il_index=""7"" il_start=""0x1"" il_end=""0x1b4"" attributes=""0"" />
              <scope startOffset=""0x14d"" endOffset=""0x15e"">
                <local name=""x"" il_index=""1"" il_start=""0x14d"" il_end=""0x15e"" attributes=""0"" />
              </scope>
              <scope startOffset=""0x163"" endOffset=""0x16a"">
                <local name=""y"" il_index=""2"" il_start=""0x163"" il_end=""0x16a"" attributes=""0"" />
                <local name=""z"" il_index=""3"" il_start=""0x163"" il_end=""0x16a"" attributes=""0"" />
              </scope>
              <scope startOffset=""0x191"" endOffset=""0x198"">
                <local name=""p"" il_index=""4"" il_start=""0x191"" il_end=""0x198"" attributes=""0"" />
                <local name=""q"" il_index=""5"" il_start=""0x191"" il_end=""0x198"" attributes=""0"" />
              </scope>
              <scope startOffset=""0x198"" endOffset=""0x19f"">
                <local name=""p"" il_index=""6"" il_start=""0x198"" il_end=""0x19f"" attributes=""0"" />
              </scope>
              <scope startOffset=""0x19f"" endOffset=""0x1a7"">
                <local name=""z"" il_index=""7"" il_start=""0x19f"" il_end=""0x1a7"" attributes=""0"" />
              </scope>
            </scope>
          </scope>
        </method>
      </methods>
    </symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 319740, 335746);

                string
                f_23129_319912_320971(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 319912, 320971);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_320994_321095(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 320994, 321095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_321125_321174(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, verify: verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 321125, 321174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_321270_327947(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 321270, 327947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_327964_335734(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 327964, 335734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 319740, 335746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 319740, 335746);
            }
        }

        [WorkItem(37172, "https://github.com/dotnet/roslyn/issues/37172")]
        [Fact]
        public void Patterns_IsPattern()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 335758, 343840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 335907, 336962);

                string
                source = f_23129_335923_336961(@"
class C
{
    public void Deconstruct() { }
    public void Deconstruct(out int x) { x = 1; }
    public void Deconstruct(out int x, out object y) { x = 2; y = new C(); }
}

class D
{
    public int P { get; set; }
    public D Q { get; set; }
    public C R { get; set; }
}

class Program
{
    static object F() => new C();
    static bool B() => true;
    static int G(int x) => x;

    static bool M()
    {
        object obj = F();
        return 
            // declaration pattern
            obj is int x ||

            // discard pattern
            obj is bool _ ||

            // var pattern
            obj is var (y, z1) ||

            // constant pattern
            obj is 4.0 ||

            // positional patterns
            obj is C() ||
            obj is () ||
            obj is C(int p1, C(int q)) ||
            obj is C(x: int p2) ||

            // property pattern
            obj is D { P: 1, Q: D { P: 2 }, R: C(int z2) };
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 336976, 337086);

                var
                c = f_23129_336984_337085(source, options: TestOptions.DebugDll, targetFramework: TargetFramework.NetCoreApp)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 337100, 337165);

                var
                verifier = f_23129_337115_337164(this, c, verify: Verification.Skipped)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 337181, 341434);

                f_23129_337181_341433(
                            verifier, "Program.M", sequencePoints: "Program.M", expectedIL: @"
{
  // Code size      301 (0x12d)
  .maxstack  3
  .locals init (object V_0, //obj
                int V_1, //x
                object V_2, //y
                object V_3, //z1
                int V_4, //p1
                int V_5, //q
                int V_6, //p2
                int V_7, //z2
                System.Runtime.CompilerServices.ITuple V_8,
                C V_9,
                object V_10,
                C V_11,
                D V_12,
                D V_13,
                bool V_14)
 -IL_0000:  nop
 -IL_0001:  call       ""object Program.F()""
  IL_0006:  stloc.0
 -IL_0007:  ldloc.0
  IL_0008:  isinst     ""int""
  IL_000d:  brfalse.s  IL_001b
  IL_000f:  ldloc.0
  IL_0010:  unbox.any  ""int""
  IL_0015:  stloc.1
  IL_0016:  br         IL_0125
  IL_001b:  ldloc.0
  IL_001c:  isinst     ""bool""
  IL_0021:  brtrue     IL_0125
  IL_0026:  ldloc.0
  IL_0027:  isinst     ""System.Runtime.CompilerServices.ITuple""
  IL_002c:  stloc.s    V_8
  IL_002e:  ldloc.s    V_8
  IL_0030:  brfalse.s  IL_0053
  IL_0032:  ldloc.s    V_8
  IL_0034:  callvirt   ""int System.Runtime.CompilerServices.ITuple.Length.get""
  IL_0039:  ldc.i4.2
  IL_003a:  bne.un.s   IL_0053
  IL_003c:  ldloc.s    V_8
  IL_003e:  ldc.i4.0
  IL_003f:  callvirt   ""object System.Runtime.CompilerServices.ITuple.this[int].get""
  IL_0044:  stloc.2
  IL_0045:  ldloc.s    V_8
  IL_0047:  ldc.i4.1
  IL_0048:  callvirt   ""object System.Runtime.CompilerServices.ITuple.this[int].get""
  IL_004d:  stloc.3
  IL_004e:  br         IL_0125
  IL_0053:  ldloc.0
  IL_0054:  isinst     ""double""
  IL_0059:  brfalse.s  IL_006f
  IL_005b:  ldloc.0
  IL_005c:  unbox.any  ""double""
  IL_0061:  ldc.r8     4
  IL_006a:  beq        IL_0125
  IL_006f:  ldloc.0
  IL_0070:  isinst     ""C""
  IL_0075:  brtrue     IL_0125
  IL_007a:  ldloc.0
  IL_007b:  isinst     ""System.Runtime.CompilerServices.ITuple""
  IL_0080:  stloc.s    V_8
  IL_0082:  ldloc.s    V_8
  IL_0084:  brfalse.s  IL_0092
  IL_0086:  ldloc.s    V_8
  IL_0088:  callvirt   ""int System.Runtime.CompilerServices.ITuple.Length.get""
  IL_008d:  brfalse    IL_0125
  IL_0092:  ldloc.0
  IL_0093:  isinst     ""C""
  IL_0098:  stloc.s    V_9
  IL_009a:  ldloc.s    V_9
  IL_009c:  brfalse.s  IL_00c3
  IL_009e:  ldloc.s    V_9
  IL_00a0:  ldloca.s   V_4
  IL_00a2:  ldloca.s   V_10
  IL_00a4:  callvirt   ""void C.Deconstruct(out int, out object)""
  IL_00a9:  nop
  IL_00aa:  ldloc.s    V_10
  IL_00ac:  isinst     ""C""
  IL_00b1:  stloc.s    V_11
  IL_00b3:  ldloc.s    V_11
  IL_00b5:  brfalse.s  IL_00c3
  IL_00b7:  ldloc.s    V_11
  IL_00b9:  ldloca.s   V_5
  IL_00bb:  callvirt   ""void C.Deconstruct(out int)""
  IL_00c0:  nop
  IL_00c1:  br.s       IL_0125
  IL_00c3:  ldloc.0
  IL_00c4:  isinst     ""C""
  IL_00c9:  stloc.s    V_11
  IL_00cb:  ldloc.s    V_11
  IL_00cd:  brfalse.s  IL_00db
  IL_00cf:  ldloc.s    V_11
  IL_00d1:  ldloca.s   V_6
  IL_00d3:  callvirt   ""void C.Deconstruct(out int)""
  IL_00d8:  nop
  IL_00d9:  br.s       IL_0125
  IL_00db:  ldloc.0
  IL_00dc:  isinst     ""D""
  IL_00e1:  stloc.s    V_12
  IL_00e3:  ldloc.s    V_12
  IL_00e5:  brfalse.s  IL_0122
  IL_00e7:  ldloc.s    V_12
  IL_00e9:  callvirt   ""int D.P.get""
  IL_00ee:  ldc.i4.1
  IL_00ef:  bne.un.s   IL_0122
  IL_00f1:  ldloc.s    V_12
  IL_00f3:  callvirt   ""D D.Q.get""
  IL_00f8:  stloc.s    V_13
  IL_00fa:  ldloc.s    V_13
  IL_00fc:  brfalse.s  IL_0122
  IL_00fe:  ldloc.s    V_13
  IL_0100:  callvirt   ""int D.P.get""
  IL_0105:  ldc.i4.2
  IL_0106:  bne.un.s   IL_0122
  IL_0108:  ldloc.s    V_12
  IL_010a:  callvirt   ""C D.R.get""
  IL_010f:  stloc.s    V_11
  IL_0111:  ldloc.s    V_11
  IL_0113:  brfalse.s  IL_0122
  IL_0115:  ldloc.s    V_11
  IL_0117:  ldloca.s   V_7
  IL_0119:  callvirt   ""void C.Deconstruct(out int)""
  IL_011e:  nop
  IL_011f:  ldc.i4.1
  IL_0120:  br.s       IL_0123
  IL_0122:  ldc.i4.0
  IL_0123:  br.s       IL_0126
  IL_0125:  ldc.i4.1
  IL_0126:  stloc.s    V_14
  IL_0128:  br.s       IL_012a
 -IL_012a:  ldloc.s    V_14
  IL_012c:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 341450, 343829);

                f_23129_341450_343828(
                            verifier, "Program.M", @"   
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""M"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""Deconstruct"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""18"" />
          <slot kind=""0"" offset=""106"" />
          <slot kind=""0"" offset=""230"" />
          <slot kind=""0"" offset=""233"" />
          <slot kind=""0"" offset=""419"" />
          <slot kind=""0"" offset=""429"" />
          <slot kind=""0"" offset=""465"" />
          <slot kind=""0"" offset=""561"" />
          <slot kind=""temp"" />
          <slot kind=""temp"" />
          <slot kind=""temp"" />
          <slot kind=""temp"" />
          <slot kind=""temp"" />
          <slot kind=""temp"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""23"" startColumn=""5"" endLine=""23"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""24"" startColumn=""9"" endLine=""24"" endColumn=""26"" document=""1"" />
        <entry offset=""0x7"" startLine=""25"" startColumn=""9"" endLine=""45"" endColumn=""60"" document=""1"" />
        <entry offset=""0x12a"" startLine=""46"" startColumn=""5"" endLine=""46"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x12d"">
        <local name=""obj"" il_index=""0"" il_start=""0x0"" il_end=""0x12d"" attributes=""0"" />
        <local name=""x"" il_index=""1"" il_start=""0x0"" il_end=""0x12d"" attributes=""0"" />
        <local name=""y"" il_index=""2"" il_start=""0x0"" il_end=""0x12d"" attributes=""0"" />
        <local name=""z1"" il_index=""3"" il_start=""0x0"" il_end=""0x12d"" attributes=""0"" />
        <local name=""p1"" il_index=""4"" il_start=""0x0"" il_end=""0x12d"" attributes=""0"" />
        <local name=""q"" il_index=""5"" il_start=""0x0"" il_end=""0x12d"" attributes=""0"" />
        <local name=""p2"" il_index=""6"" il_start=""0x0"" il_end=""0x12d"" attributes=""0"" />
        <local name=""z2"" il_index=""7"" il_start=""0x0"" il_end=""0x12d"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 335758, 343840);

                string
                f_23129_335923_336961(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 335923, 336961);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_336984_337085(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Roslyn.Test.Utilities.TargetFramework
                targetFramework)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, targetFramework: targetFramework);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 336984, 337085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_337115_337164(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Test.Utilities.Verification
                verify)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation, verify: verify);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 337115, 337164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_337181_341433(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 337181, 341433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_341450_343828(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 341450, 343828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 335758, 343840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 335758, 343840);
            }
        }

        [WorkItem(37172, "https://github.com/dotnet/roslyn/issues/37172")]
        [WorkItem(37232, "https://github.com/dotnet/roslyn/issues/37232")]
        [WorkItem(37237, "https://github.com/dotnet/roslyn/issues/37237")]
        [Fact]
        public void Patterns_SwitchExpression_Closures()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 343852, 362176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 344169, 344958);

                string
                source = f_23129_344185_344957(@"
using System;
public class C
{
    static int M() 
    {
        return F() switch 
        {
            1 => F() switch
                 {
                     C { P: int p, Q: C { P: int q } } => G(() => p + q),
                     _ => 10
                 },
            2 => F() switch
                 {
                     C { P: int r } => G(() => r),
                     _ => 20
                 },
            C { Q: int s } => G(() => s),
            _ => 0
        }
        switch 
        {
            var t when t > 0 => G(() => t),
            _ => 0
        };
    }

    object P { get; set; }
    object Q { get; set; }
    static object F() => null;
    static int G(Func<int> f) => 0;
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 344972, 345037);

                var
                c = f_23129_344980_345036(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 345051, 345086);

                var
                verifier = f_23129_345066_345085(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 345100, 354439);

                f_23129_345100_354438(verifier, "C.M", sequencePoints: "C.M", source: source, expectedIL: @"
    {
      // Code size      472 (0x1d8)
      .maxstack  2
      .locals init (C.<>c__DisplayClass0_0 V_0, //CS$<>8__locals0
                    int V_1,
                    C.<>c__DisplayClass0_1 V_2, //CS$<>8__locals1
                    int V_3,
                    object V_4,
                    int V_5,
                    C V_6,
                    object V_7,
                    C.<>c__DisplayClass0_2 V_8, //CS$<>8__locals2
                    int V_9,
                    object V_10,
                    C V_11,
                    object V_12,
                    object V_13,
                    C V_14,
                    object V_15,
                    C.<>c__DisplayClass0_3 V_16, //CS$<>8__locals3
                    object V_17,
                    C V_18,
                    object V_19,
                    int V_20)
      // sequence point: {
      IL_0000:  nop
      // sequence point: <hidden>
      IL_0001:  newobj     ""C.<>c__DisplayClass0_0..ctor()""
      IL_0006:  stloc.0
      // sequence point: <hidden>
      IL_0007:  newobj     ""C.<>c__DisplayClass0_1..ctor()""
      IL_000c:  stloc.2
      IL_000d:  call       ""object C.F()""
      IL_0012:  stloc.s    V_4
      IL_0014:  ldc.i4.1
      IL_0015:  brtrue.s   IL_0018
      // sequence point: switch  ...         }
      IL_0017:  nop
      // sequence point: <hidden>
      IL_0018:  ldloc.s    V_4
      IL_001a:  isinst     ""int""
      IL_001f:  brfalse.s  IL_003e
      IL_0021:  ldloc.s    V_4
      IL_0023:  unbox.any  ""int""
      IL_0028:  stloc.s    V_5
      // sequence point: <hidden>
      IL_002a:  ldloc.s    V_5
      IL_002c:  ldc.i4.1
      IL_002d:  beq.s      IL_0075
      IL_002f:  br.s       IL_0031
      IL_0031:  ldloc.s    V_5
      IL_0033:  ldc.i4.2
      IL_0034:  beq        IL_0116
      IL_0039:  br         IL_0194
      IL_003e:  ldloc.s    V_4
      IL_0040:  isinst     ""C""
      IL_0045:  stloc.s    V_6
      IL_0047:  ldloc.s    V_6
      IL_0049:  brfalse    IL_0194
      IL_004e:  ldloc.s    V_6
      IL_0050:  callvirt   ""object C.Q.get""
      IL_0055:  stloc.s    V_7
      // sequence point: <hidden>
      IL_0057:  ldloc.s    V_7
      IL_0059:  isinst     ""int""
      IL_005e:  brfalse    IL_0194
      IL_0063:  ldloc.2
      IL_0064:  ldloc.s    V_7
      IL_0066:  unbox.any  ""int""
      IL_006b:  stfld      ""int C.<>c__DisplayClass0_1.<s>5__3""
      // sequence point: <hidden>
      IL_0070:  br         IL_017e
      // sequence point: <hidden>
      IL_0075:  newobj     ""C.<>c__DisplayClass0_2..ctor()""
      IL_007a:  stloc.s    V_8
      IL_007c:  call       ""object C.F()""
      IL_0081:  stloc.s    V_10
      IL_0083:  ldc.i4.1
      IL_0084:  brtrue.s   IL_0087
      // sequence point: switch ...             
      IL_0086:  nop
      // sequence point: <hidden>
      IL_0087:  ldloc.s    V_10
      IL_0089:  isinst     ""C""
      IL_008e:  stloc.s    V_11
      IL_0090:  ldloc.s    V_11
      IL_0092:  brfalse.s  IL_0104
      IL_0094:  ldloc.s    V_11
      IL_0096:  callvirt   ""object C.P.get""
      IL_009b:  stloc.s    V_12
      // sequence point: <hidden>
      IL_009d:  ldloc.s    V_12
      IL_009f:  isinst     ""int""
      IL_00a4:  brfalse.s  IL_0104
      IL_00a6:  ldloc.s    V_8
      IL_00a8:  ldloc.s    V_12
      IL_00aa:  unbox.any  ""int""
      IL_00af:  stfld      ""int C.<>c__DisplayClass0_2.<p>5__4""
      // sequence point: <hidden>
      IL_00b4:  ldloc.s    V_11
      IL_00b6:  callvirt   ""object C.Q.get""
      IL_00bb:  stloc.s    V_13
      // sequence point: <hidden>
      IL_00bd:  ldloc.s    V_13
      IL_00bf:  isinst     ""C""
      IL_00c4:  stloc.s    V_14
      IL_00c6:  ldloc.s    V_14
      IL_00c8:  brfalse.s  IL_0104
      IL_00ca:  ldloc.s    V_14
      IL_00cc:  callvirt   ""object C.P.get""
      IL_00d1:  stloc.s    V_15
      // sequence point: <hidden>
      IL_00d3:  ldloc.s    V_15
      IL_00d5:  isinst     ""int""
      IL_00da:  brfalse.s  IL_0104
      IL_00dc:  ldloc.s    V_8
      IL_00de:  ldloc.s    V_15
      IL_00e0:  unbox.any  ""int""
      IL_00e5:  stfld      ""int C.<>c__DisplayClass0_2.<q>5__5""
      // sequence point: <hidden>
      IL_00ea:  br.s       IL_00ec
      // sequence point: <hidden>
      IL_00ec:  br.s       IL_00ee
      // sequence point: G(() => p + q)
      IL_00ee:  ldloc.s    V_8
      IL_00f0:  ldftn      ""int C.<>c__DisplayClass0_2.<M>b__2()""
      IL_00f6:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
      IL_00fb:  call       ""int C.G(System.Func<int>)""
      IL_0100:  stloc.s    V_9
      IL_0102:  br.s       IL_010a
      // sequence point: 10
      IL_0104:  ldc.i4.s   10
      IL_0106:  stloc.s    V_9
      IL_0108:  br.s       IL_010a
      // sequence point: <hidden>
      IL_010a:  ldc.i4.1
      IL_010b:  brtrue.s   IL_010e
      // sequence point: switch  ...         }
      IL_010d:  nop
      // sequence point: F() switch ...             
      IL_010e:  ldloc.s    V_9
      IL_0110:  stloc.3
      IL_0111:  br         IL_0198
      // sequence point: <hidden>
      IL_0116:  newobj     ""C.<>c__DisplayClass0_3..ctor()""
      IL_011b:  stloc.s    V_16
      IL_011d:  call       ""object C.F()""
      IL_0122:  stloc.s    V_17
      IL_0124:  ldc.i4.1
      IL_0125:  brtrue.s   IL_0128
      // sequence point: switch ...             
      IL_0127:  nop
      // sequence point: <hidden>
      IL_0128:  ldloc.s    V_17
      IL_012a:  isinst     ""C""
      IL_012f:  stloc.s    V_18
      IL_0131:  ldloc.s    V_18
      IL_0133:  brfalse.s  IL_016f
      IL_0135:  ldloc.s    V_18
      IL_0137:  callvirt   ""object C.P.get""
      IL_013c:  stloc.s    V_19
      // sequence point: <hidden>
      IL_013e:  ldloc.s    V_19
      IL_0140:  isinst     ""int""
      IL_0145:  brfalse.s  IL_016f
      IL_0147:  ldloc.s    V_16
      IL_0149:  ldloc.s    V_19
      IL_014b:  unbox.any  ""int""
      IL_0150:  stfld      ""int C.<>c__DisplayClass0_3.<r>5__6""
      // sequence point: <hidden>
      IL_0155:  br.s       IL_0157
      // sequence point: <hidden>
      IL_0157:  br.s       IL_0159
      // sequence point: G(() => r)
      IL_0159:  ldloc.s    V_16
      IL_015b:  ldftn      ""int C.<>c__DisplayClass0_3.<M>b__3()""
      IL_0161:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
      IL_0166:  call       ""int C.G(System.Func<int>)""
      IL_016b:  stloc.s    V_9
      IL_016d:  br.s       IL_0175
      // sequence point: 20
      IL_016f:  ldc.i4.s   20
      IL_0171:  stloc.s    V_9
      IL_0173:  br.s       IL_0175
      // sequence point: <hidden>
      IL_0175:  ldc.i4.1
      IL_0176:  brtrue.s   IL_0179
      // sequence point: F() switch ...             
      IL_0178:  nop
      // sequence point: F() switch ...             
      IL_0179:  ldloc.s    V_9
      IL_017b:  stloc.3
      IL_017c:  br.s       IL_0198
      // sequence point: <hidden>
      IL_017e:  br.s       IL_0180
      // sequence point: G(() => s)
      IL_0180:  ldloc.2
      IL_0181:  ldftn      ""int C.<>c__DisplayClass0_1.<M>b__1()""
      IL_0187:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
      IL_018c:  call       ""int C.G(System.Func<int>)""
      IL_0191:  stloc.3
      IL_0192:  br.s       IL_0198
      // sequence point: 0
      IL_0194:  ldc.i4.0
      IL_0195:  stloc.3
      IL_0196:  br.s       IL_0198
      // sequence point: <hidden>
      IL_0198:  ldc.i4.1
      IL_0199:  brtrue.s   IL_019c
      // sequence point: return F() s ...         };
      IL_019b:  nop
      // sequence point: <hidden>
      IL_019c:  ldloc.0
      IL_019d:  ldloc.3
      IL_019e:  stfld      ""int C.<>c__DisplayClass0_0.<t>5__2""
      IL_01a3:  ldc.i4.1
      IL_01a4:  brtrue.s   IL_01a7
      // sequence point: switch  ...         }
      IL_01a6:  nop
      // sequence point: <hidden>
      IL_01a7:  br.s       IL_01a9
      // sequence point: when t > 0
      IL_01a9:  ldloc.0
      IL_01aa:  ldfld      ""int C.<>c__DisplayClass0_0.<t>5__2""
      IL_01af:  ldc.i4.0
      IL_01b0:  bgt.s      IL_01b4
      // sequence point: <hidden>
      IL_01b2:  br.s       IL_01c8
      // sequence point: G(() => t)
      IL_01b4:  ldloc.0
      IL_01b5:  ldftn      ""int C.<>c__DisplayClass0_0.<M>b__0()""
      IL_01bb:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
      IL_01c0:  call       ""int C.G(System.Func<int>)""
      IL_01c5:  stloc.1
      IL_01c6:  br.s       IL_01cc
      // sequence point: 0
      IL_01c8:  ldc.i4.0
      IL_01c9:  stloc.1
      IL_01ca:  br.s       IL_01cc
      // sequence point: <hidden>
      IL_01cc:  ldc.i4.1
      IL_01cd:  brtrue.s   IL_01d0
      // sequence point: return F() s ...         };
      IL_01cf:  nop
      // sequence point: <hidden>
      IL_01d0:  ldloc.1
      IL_01d1:  stloc.s    V_20
      IL_01d3:  br.s       IL_01d5
      // sequence point: }
      IL_01d5:  ldloc.s    V_20
      IL_01d7:  ret
    }
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 354453, 362165);

                f_23129_354453_362164(verifier, "C.M", @"
    <symbols>
      <files>
        <file id=""1"" name="""" language=""C#"" />
      </files>
      <methods>
        <method containingType=""C"" name=""M"">
          <customDebugInfo>
            <using>
              <namespace usingCount=""1"" />
            </using>
            <encLocalSlotMap>
              <slot kind=""30"" offset=""238"" />
              <slot kind=""temp"" />
              <slot kind=""30"" offset=""238"" ordinal=""1"" />
              <slot kind=""temp"" />
              <slot kind=""35"" offset=""22"" />
              <slot kind=""35"" offset=""22"" ordinal=""1"" />
              <slot kind=""35"" offset=""22"" ordinal=""2"" />
              <slot kind=""35"" offset=""22"" ordinal=""3"" />
              <slot kind=""30"" offset=""63"" />
              <slot kind=""temp"" />
              <slot kind=""35"" offset=""63"" />
              <slot kind=""35"" offset=""63"" ordinal=""1"" />
              <slot kind=""35"" offset=""63"" ordinal=""2"" />
              <slot kind=""35"" offset=""63"" ordinal=""3"" />
              <slot kind=""35"" offset=""63"" ordinal=""4"" />
              <slot kind=""35"" offset=""63"" ordinal=""5"" />
              <slot kind=""30"" offset=""238"" ordinal=""2"" />
              <slot kind=""35"" offset=""238"" />
              <slot kind=""35"" offset=""238"" ordinal=""1"" />
              <slot kind=""35"" offset=""238"" ordinal=""2"" />
              <slot kind=""21"" offset=""0"" />
            </encLocalSlotMap>
            <encLambdaMap>
              <methodOrdinal>0</methodOrdinal>
              <closure offset=""238"" />
              <closure offset=""238"" />
              <closure offset=""63"" />
              <closure offset=""238"" />
              <lambda offset=""511"" closure=""0"" />
              <lambda offset=""407"" closure=""1"" />
              <lambda offset=""157"" closure=""2"" />
              <lambda offset=""313"" closure=""3"" />
            </encLambdaMap>
          </customDebugInfo>
          <sequencePoints>
            <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
            <entry offset=""0x1"" hidden=""true"" document=""1"" />
            <entry offset=""0x7"" hidden=""true"" document=""1"" />
            <entry offset=""0x17"" startLine=""7"" startColumn=""20"" endLine=""21"" endColumn=""10"" document=""1"" />
            <entry offset=""0x18"" hidden=""true"" document=""1"" />
            <entry offset=""0x2a"" hidden=""true"" document=""1"" />
            <entry offset=""0x57"" hidden=""true"" document=""1"" />
            <entry offset=""0x70"" hidden=""true"" document=""1"" />
            <entry offset=""0x75"" hidden=""true"" document=""1"" />
            <entry offset=""0x86"" startLine=""9"" startColumn=""22"" endLine=""13"" endColumn=""19"" document=""1"" />
            <entry offset=""0x87"" hidden=""true"" document=""1"" />
            <entry offset=""0x9d"" hidden=""true"" document=""1"" />
            <entry offset=""0xb4"" hidden=""true"" document=""1"" />
            <entry offset=""0xbd"" hidden=""true"" document=""1"" />
            <entry offset=""0xd3"" hidden=""true"" document=""1"" />
            <entry offset=""0xea"" hidden=""true"" document=""1"" />
            <entry offset=""0xec"" hidden=""true"" document=""1"" />
            <entry offset=""0xee"" startLine=""11"" startColumn=""59"" endLine=""11"" endColumn=""73"" document=""1"" />
            <entry offset=""0x104"" startLine=""12"" startColumn=""27"" endLine=""12"" endColumn=""29"" document=""1"" />
            <entry offset=""0x10a"" hidden=""true"" document=""1"" />
            <entry offset=""0x10d"" startLine=""7"" startColumn=""20"" endLine=""21"" endColumn=""10"" document=""1"" />
            <entry offset=""0x10e"" startLine=""9"" startColumn=""18"" endLine=""13"" endColumn=""19"" document=""1"" />
            <entry offset=""0x116"" hidden=""true"" document=""1"" />
            <entry offset=""0x127"" startLine=""14"" startColumn=""22"" endLine=""18"" endColumn=""19"" document=""1"" />
            <entry offset=""0x128"" hidden=""true"" document=""1"" />
            <entry offset=""0x13e"" hidden=""true"" document=""1"" />
            <entry offset=""0x155"" hidden=""true"" document=""1"" />
            <entry offset=""0x157"" hidden=""true"" document=""1"" />
            <entry offset=""0x159"" startLine=""16"" startColumn=""40"" endLine=""16"" endColumn=""50"" document=""1"" />
            <entry offset=""0x16f"" startLine=""17"" startColumn=""27"" endLine=""17"" endColumn=""29"" document=""1"" />
            <entry offset=""0x175"" hidden=""true"" document=""1"" />
            <entry offset=""0x178"" startLine=""9"" startColumn=""18"" endLine=""13"" endColumn=""19"" document=""1"" />
            <entry offset=""0x179"" startLine=""14"" startColumn=""18"" endLine=""18"" endColumn=""19"" document=""1"" />
            <entry offset=""0x17e"" hidden=""true"" document=""1"" />
            <entry offset=""0x180"" startLine=""19"" startColumn=""31"" endLine=""19"" endColumn=""41"" document=""1"" />
            <entry offset=""0x194"" startLine=""20"" startColumn=""18"" endLine=""20"" endColumn=""19"" document=""1"" />
            <entry offset=""0x198"" hidden=""true"" document=""1"" />
            <entry offset=""0x19b"" startLine=""7"" startColumn=""9"" endLine=""26"" endColumn=""11"" document=""1"" />
            <entry offset=""0x19c"" hidden=""true"" document=""1"" />
            <entry offset=""0x1a6"" startLine=""22"" startColumn=""9"" endLine=""26"" endColumn=""10"" document=""1"" />
            <entry offset=""0x1a7"" hidden=""true"" document=""1"" />
            <entry offset=""0x1a9"" startLine=""24"" startColumn=""19"" endLine=""24"" endColumn=""29"" document=""1"" />
            <entry offset=""0x1b2"" hidden=""true"" document=""1"" />
            <entry offset=""0x1b4"" startLine=""24"" startColumn=""33"" endLine=""24"" endColumn=""43"" document=""1"" />
            <entry offset=""0x1c8"" startLine=""25"" startColumn=""18"" endLine=""25"" endColumn=""19"" document=""1"" />
            <entry offset=""0x1cc"" hidden=""true"" document=""1"" />
            <entry offset=""0x1cf"" startLine=""7"" startColumn=""9"" endLine=""26"" endColumn=""11"" document=""1"" />
            <entry offset=""0x1d0"" hidden=""true"" document=""1"" />
            <entry offset=""0x1d5"" startLine=""27"" startColumn=""5"" endLine=""27"" endColumn=""6"" document=""1"" />
          </sequencePoints>
          <scope startOffset=""0x0"" endOffset=""0x1d8"">
            <namespace name=""System"" />
            <scope startOffset=""0x1"" endOffset=""0x1d5"">
              <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x1"" il_end=""0x1d5"" attributes=""0"" />
              <scope startOffset=""0x7"" endOffset=""0x1a3"">
                <local name=""CS$&lt;&gt;8__locals1"" il_index=""2"" il_start=""0x7"" il_end=""0x1a3"" attributes=""0"" />
                <scope startOffset=""0x75"" endOffset=""0x111"">
                  <local name=""CS$&lt;&gt;8__locals2"" il_index=""8"" il_start=""0x75"" il_end=""0x111"" attributes=""0"" />
                </scope>
                <scope startOffset=""0x116"" endOffset=""0x17c"">
                  <local name=""CS$&lt;&gt;8__locals3"" il_index=""16"" il_start=""0x116"" il_end=""0x17c"" attributes=""0"" />
                </scope>
              </scope>
            </scope>
          </scope>
        </method>
      </methods>
    </symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 343852, 362176);

                string
                f_23129_344185_344957(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 344185, 344957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_344980_345036(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 344980, 345036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_345066_345085(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 345066, 345085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_345100_354438(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 345100, 354438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_354453_362164(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 354453, 362164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 343852, 362176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 343852, 362176);
            }
        }

        [WorkItem(37261, "https://github.com/dotnet/roslyn/issues/37261")]
        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void SwitchExpression_MethodBody()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 362188, 369214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 362435, 362765);

                string
                source = @"
using System;
public class C
{
    static int M() => F() switch
    {
        1 => 1,
        C { P: int p, Q: C { P: int q } } => G(() => p + q),
        _ => 0
    };

    object P { get; set; }
    object Q { get; set; }
    static object F() => null;
    static int G(Func<int> f) => 0;
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 362779, 362844);

                var
                c = f_23129_362787_362843(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 362858, 362893);

                var
                verifier = f_23129_362873_362892(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 362909, 366348);

                f_23129_362909_366347(
                            verifier, "C.M", sequencePoints: "C.M", source: source, expectedIL: @"
    {
      // Code size      171 (0xab)
      .maxstack  2
      .locals init (C.<>c__DisplayClass0_0 V_0, //CS$<>8__locals0
                    int V_1,
                    object V_2,
                    int V_3,
                    C V_4,
                    object V_5,
                    object V_6,
                    C V_7,
                    object V_8)
      // sequence point: <hidden>
      IL_0000:  newobj     ""C.<>c__DisplayClass0_0..ctor()""
      IL_0005:  stloc.0
      IL_0006:  call       ""object C.F()""
      IL_000b:  stloc.2
      IL_000c:  ldc.i4.1
      IL_000d:  brtrue.s   IL_0010
      // sequence point: switch ...     }
      IL_000f:  nop
      // sequence point: <hidden>
      IL_0010:  ldloc.2
      IL_0011:  isinst     ""int""
      IL_0016:  brfalse.s  IL_0025
      IL_0018:  ldloc.2
      IL_0019:  unbox.any  ""int""
      IL_001e:  stloc.3
      // sequence point: <hidden>
      IL_001f:  ldloc.3
      IL_0020:  ldc.i4.1
      IL_0021:  beq.s      IL_0087
      IL_0023:  br.s       IL_00a1
      IL_0025:  ldloc.2
      IL_0026:  isinst     ""C""
      IL_002b:  stloc.s    V_4
      IL_002d:  ldloc.s    V_4
      IL_002f:  brfalse.s  IL_00a1
      IL_0031:  ldloc.s    V_4
      IL_0033:  callvirt   ""object C.P.get""
      IL_0038:  stloc.s    V_5
      // sequence point: <hidden>
      IL_003a:  ldloc.s    V_5
      IL_003c:  isinst     ""int""
      IL_0041:  brfalse.s  IL_00a1
      IL_0043:  ldloc.0
      IL_0044:  ldloc.s    V_5
      IL_0046:  unbox.any  ""int""
      IL_004b:  stfld      ""int C.<>c__DisplayClass0_0.<p>5__2""
      // sequence point: <hidden>
      IL_0050:  ldloc.s    V_4
      IL_0052:  callvirt   ""object C.Q.get""
      IL_0057:  stloc.s    V_6
      // sequence point: <hidden>
      IL_0059:  ldloc.s    V_6
      IL_005b:  isinst     ""C""
      IL_0060:  stloc.s    V_7
      IL_0062:  ldloc.s    V_7
      IL_0064:  brfalse.s  IL_00a1
      IL_0066:  ldloc.s    V_7
      IL_0068:  callvirt   ""object C.P.get""
      IL_006d:  stloc.s    V_8
      // sequence point: <hidden>
      IL_006f:  ldloc.s    V_8
      IL_0071:  isinst     ""int""
      IL_0076:  brfalse.s  IL_00a1
      IL_0078:  ldloc.0
      IL_0079:  ldloc.s    V_8
      IL_007b:  unbox.any  ""int""
      IL_0080:  stfld      ""int C.<>c__DisplayClass0_0.<q>5__3""
      // sequence point: <hidden>
      IL_0085:  br.s       IL_008b
      // sequence point: 1
      IL_0087:  ldc.i4.1
      IL_0088:  stloc.1
      IL_0089:  br.s       IL_00a5
      // sequence point: <hidden>
      IL_008b:  br.s       IL_008d
      // sequence point: G(() => p + q)
      IL_008d:  ldloc.0
      IL_008e:  ldftn      ""int C.<>c__DisplayClass0_0.<M>b__0()""
      IL_0094:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
      IL_0099:  call       ""int C.G(System.Func<int>)""
      IL_009e:  stloc.1
      IL_009f:  br.s       IL_00a5
      // sequence point: 0
      IL_00a1:  ldc.i4.0
      IL_00a2:  stloc.1
      IL_00a3:  br.s       IL_00a5
      // sequence point: <hidden>
      IL_00a5:  ldc.i4.1
      IL_00a6:  brtrue.s   IL_00a9
      // sequence point: F() switch ...     }
      IL_00a8:  nop
      // sequence point: <hidden>
      IL_00a9:  ldloc.1
      IL_00aa:  ret
    }
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 366362, 369203);

                f_23129_366362_369202(verifier, "C.M", @"
    <symbols>
      <files>
        <file id=""1"" name="""" language=""C#"" />
      </files>
      <methods>
        <method containingType=""C"" name=""M"">
          <customDebugInfo>
            <using>
              <namespace usingCount=""1"" />
            </using>
            <encLocalSlotMap>
              <slot kind=""30"" offset=""7"" />
              <slot kind=""temp"" />
              <slot kind=""35"" offset=""7"" />
              <slot kind=""35"" offset=""7"" ordinal=""1"" />
              <slot kind=""35"" offset=""7"" ordinal=""2"" />
              <slot kind=""35"" offset=""7"" ordinal=""3"" />
              <slot kind=""35"" offset=""7"" ordinal=""4"" />
              <slot kind=""35"" offset=""7"" ordinal=""5"" />
              <slot kind=""35"" offset=""7"" ordinal=""6"" />
            </encLocalSlotMap>
            <encLambdaMap>
              <methodOrdinal>0</methodOrdinal>
              <closure offset=""7"" />
              <lambda offset=""92"" closure=""0"" />
            </encLambdaMap>
          </customDebugInfo>
          <sequencePoints>
            <entry offset=""0x0"" hidden=""true"" document=""1"" />
            <entry offset=""0xf"" startLine=""5"" startColumn=""27"" endLine=""10"" endColumn=""6"" document=""1"" />
            <entry offset=""0x10"" hidden=""true"" document=""1"" />
            <entry offset=""0x1f"" hidden=""true"" document=""1"" />
            <entry offset=""0x3a"" hidden=""true"" document=""1"" />
            <entry offset=""0x50"" hidden=""true"" document=""1"" />
            <entry offset=""0x59"" hidden=""true"" document=""1"" />
            <entry offset=""0x6f"" hidden=""true"" document=""1"" />
            <entry offset=""0x85"" hidden=""true"" document=""1"" />
            <entry offset=""0x87"" startLine=""7"" startColumn=""14"" endLine=""7"" endColumn=""15"" document=""1"" />
            <entry offset=""0x8b"" hidden=""true"" document=""1"" />
            <entry offset=""0x8d"" startLine=""8"" startColumn=""46"" endLine=""8"" endColumn=""60"" document=""1"" />
            <entry offset=""0xa1"" startLine=""9"" startColumn=""14"" endLine=""9"" endColumn=""15"" document=""1"" />
            <entry offset=""0xa5"" hidden=""true"" document=""1"" />
            <entry offset=""0xa8"" startLine=""5"" startColumn=""23"" endLine=""10"" endColumn=""6"" document=""1"" />
            <entry offset=""0xa9"" hidden=""true"" document=""1"" />
          </sequencePoints>
          <scope startOffset=""0x0"" endOffset=""0xab"">
            <namespace name=""System"" />
            <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0xab"" attributes=""0"" />
          </scope>
        </method>
      </methods>
    </symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 362188, 369214);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_362787_362843(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 362787, 362843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_362873_362892(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 362873, 362892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_362909_366347(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 362909, 366347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_366362_369202(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 366362, 369202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 362188, 369214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 362188, 369214);
            }
        }

        [WorkItem(37261, "https://github.com/dotnet/roslyn/issues/37261")]
        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void SwitchExpression_MethodBody_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 369226, 374843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 369476, 369653);

                string
                source = @"
using System;
public class C
{
    static Action M1(int x) => () => { _ = x; };
    static Action M2(int x) => x switch { _ => () => { _ = x; } };
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 369667, 369732);

                var
                c = f_23129_369675_369731(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 369746, 369781);

                var
                verifier = f_23129_369761_369780(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 369797, 370488);

                f_23129_369797_370487(
                            verifier, "C.M1", sequencePoints: "C.M1", source: source, expectedIL: @"
    {
      // Code size       26 (0x1a)
      .maxstack  2
      .locals init (C.<>c__DisplayClass0_0 V_0) //CS$<>8__locals0
      // sequence point: <hidden>
      IL_0000:  newobj     ""C.<>c__DisplayClass0_0..ctor()""
      IL_0005:  stloc.0
      IL_0006:  ldloc.0
      IL_0007:  ldarg.0
      IL_0008:  stfld      ""int C.<>c__DisplayClass0_0.x""
      // sequence point: () => { _ = x; }
      IL_000d:  ldloc.0
      IL_000e:  ldftn      ""void C.<>c__DisplayClass0_0.<M1>b__0()""
      IL_0014:  newobj     ""System.Action..ctor(object, System.IntPtr)""
      IL_0019:  ret
    }
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 370502, 371807);

                f_23129_370502_371806(verifier, "C.M2", sequencePoints: "C.M2", source: source, expectedIL: @"
    {
      // Code size       40 (0x28)
      .maxstack  2
      .locals init (C.<>c__DisplayClass1_0 V_0, //CS$<>8__locals0
                    System.Action V_1)
      // sequence point: <hidden>
      IL_0000:  newobj     ""C.<>c__DisplayClass1_0..ctor()""
      IL_0005:  stloc.0
      IL_0006:  ldloc.0
      IL_0007:  ldarg.0
      IL_0008:  stfld      ""int C.<>c__DisplayClass1_0.x""
      // sequence point: x switch { _ => () => { _ = x; } }
      IL_000d:  ldc.i4.1
      IL_000e:  brtrue.s   IL_0011
      // sequence point: switch { _ => () => { _ = x; } }
      IL_0010:  nop
      // sequence point: <hidden>
      IL_0011:  br.s       IL_0013
      // sequence point: () => { _ = x; }
      IL_0013:  ldloc.0
      IL_0014:  ldftn      ""void C.<>c__DisplayClass1_0.<M2>b__0()""
      IL_001a:  newobj     ""System.Action..ctor(object, System.IntPtr)""
      IL_001f:  stloc.1
      IL_0020:  br.s       IL_0022
      // sequence point: <hidden>
      IL_0022:  ldc.i4.1
      IL_0023:  brtrue.s   IL_0026
      // sequence point: x switch { _ => () => { _ = x; } }
      IL_0025:  nop
      // sequence point: <hidden>
      IL_0026:  ldloc.1
      IL_0027:  ret
    }
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 371821, 373039);

                f_23129_371821_373038(verifier, "C.M1", @"
    <symbols>
      <files>
        <file id=""1"" name="""" language=""C#"" />
      </files>
      <methods>
        <method containingType=""C"" name=""M1"" parameterNames=""x"">
          <customDebugInfo>
            <using>
              <namespace usingCount=""1"" />
            </using>
            <encLocalSlotMap>
              <slot kind=""30"" offset=""0"" />
            </encLocalSlotMap>
            <encLambdaMap>
              <methodOrdinal>0</methodOrdinal>
              <closure offset=""0"" />
              <lambda offset=""9"" closure=""0"" />
            </encLambdaMap>
          </customDebugInfo>
          <sequencePoints>
            <entry offset=""0x0"" hidden=""true"" document=""1"" />
            <entry offset=""0xd"" startLine=""5"" startColumn=""32"" endLine=""5"" endColumn=""48"" document=""1"" />
          </sequencePoints>
          <scope startOffset=""0x0"" endOffset=""0x1a"">
            <namespace name=""System"" />
            <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0x1a"" attributes=""0"" />
          </scope>
        </method>
      </methods>
    </symbols>
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 373053, 374832);

                f_23129_373053_374831(verifier, "C.M2", @"
    <symbols>
      <files>
        <file id=""1"" name="""" language=""C#"" />
      </files>
      <methods>
        <method containingType=""C"" name=""M2"" parameterNames=""x"">
          <customDebugInfo>
            <forward declaringType=""C"" methodName=""M1"" parameterNames=""x"" />
            <encLocalSlotMap>
              <slot kind=""30"" offset=""0"" />
              <slot kind=""temp"" />
            </encLocalSlotMap>
            <encLambdaMap>
              <methodOrdinal>1</methodOrdinal>
              <closure offset=""0"" />
              <lambda offset=""25"" closure=""0"" />
            </encLambdaMap>
          </customDebugInfo>
          <sequencePoints>
            <entry offset=""0x0"" hidden=""true"" document=""1"" />
            <entry offset=""0xd"" startLine=""6"" startColumn=""32"" endLine=""6"" endColumn=""66"" document=""1"" />
            <entry offset=""0x10"" startLine=""6"" startColumn=""34"" endLine=""6"" endColumn=""66"" document=""1"" />
            <entry offset=""0x11"" hidden=""true"" document=""1"" />
            <entry offset=""0x13"" startLine=""6"" startColumn=""48"" endLine=""6"" endColumn=""64"" document=""1"" />
            <entry offset=""0x22"" hidden=""true"" document=""1"" />
            <entry offset=""0x25"" startLine=""6"" startColumn=""32"" endLine=""6"" endColumn=""66"" document=""1"" />
            <entry offset=""0x26"" hidden=""true"" document=""1"" />
          </sequencePoints>
          <scope startOffset=""0x0"" endOffset=""0x28"">
            <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0x28"" attributes=""0"" />
          </scope>
        </method>
      </methods>
    </symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 369226, 374843);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_369675_369731(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 369675, 369731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_369761_369780(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 369761, 369780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_369797_370487(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 369797, 370487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_370502_371806(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 370502, 371806);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_371821_373038(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 371821, 373038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_373053_374831(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                verifier, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = verifier.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 373053, 374831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 369226, 374843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 369226, 374843);
            }
        }

        [ConditionalFact(typeof(WindowsOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        public void SyntaxOffset_OutVarInInitializers_SwitchExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 374855, 377645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 375049, 375260);

                var
                source =
                @"class C
{ 
    static int G(out int x) => throw null;
    static int F(System.Func<int> x) => throw null;
    C() { }

    int y1 = G(out var z) switch { _ => F(() => z) }; // line 7
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 375276, 375368);

                var
                c = f_23129_375284_375367(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 375384, 377634);

                f_23129_375384_377633(
                            c, "C..ctor", @"
    <symbols>
      <files>
        <file id=""1"" name="""" language=""C#"" />
      </files>
      <methods>
        <method containingType=""C"" name="".ctor"">
          <customDebugInfo>
            <forward declaringType=""C"" methodName=""G"" parameterNames=""x"" />
            <encLocalSlotMap>
              <slot kind=""30"" offset=""-26"" />
              <slot kind=""temp"" />
              <slot kind=""35"" offset=""-26"" />
            </encLocalSlotMap>
            <encLambdaMap>
              <methodOrdinal>2</methodOrdinal>
              <closure offset=""-26"" />
              <lambda offset=""-4"" closure=""0"" />
            </encLambdaMap>
          </customDebugInfo>
          <sequencePoints>
            <entry offset=""0x0"" hidden=""true"" document=""1"" />
            <entry offset=""0x6"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""54"" document=""1"" />
            <entry offset=""0x15"" startLine=""7"" startColumn=""27"" endLine=""7"" endColumn=""53"" document=""1"" />
            <entry offset=""0x16"" hidden=""true"" document=""1"" />
            <entry offset=""0x18"" startLine=""7"" startColumn=""41"" endLine=""7"" endColumn=""51"" document=""1"" />
            <entry offset=""0x2c"" hidden=""true"" document=""1"" />
            <entry offset=""0x2f"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""54"" document=""1"" />
            <entry offset=""0x30"" hidden=""true"" document=""1"" />
            <entry offset=""0x37"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""8"" document=""1"" />
            <entry offset=""0x3e"" startLine=""5"" startColumn=""9"" endLine=""5"" endColumn=""10"" document=""1"" />
            <entry offset=""0x3f"" startLine=""5"" startColumn=""11"" endLine=""5"" endColumn=""12"" document=""1"" />
          </sequencePoints>
          <scope startOffset=""0x0"" endOffset=""0x40"">
            <scope startOffset=""0x0"" endOffset=""0x37"">
              <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0x37"" attributes=""0"" />
            </scope>
          </scope>
        </method>
      </methods>
    </symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 374855, 377645);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_375284_375367(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 375284, 375367);
                    return return_v;
                }


                bool
                f_23129_375384_377633(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 375384, 377633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 374855, 377645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 374855, 377645);
            }
        }

        [WorkItem(43468, "https://github.com/dotnet/roslyn/issues/43468")]
        [Fact]
        public void HiddenSequencePointAtSwitchExpressionFinalMergePoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 377657, 379496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 377840, 378022);

                var
                source =
                @"class C
{
    static int M(int x)
    {
        var y = x switch
        {
            1 => 2,
            _ => 3,
        };
        return y;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 378036, 378101);

                var
                c = f_23129_378044_378100(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 378115, 378150);

                var
                verifier = f_23129_378130_378149(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 378164, 379485);

                f_23129_378164_379484(verifier, "C.M", sequencePoints: "C.M", source: source, expectedIL: @"
    {
      // Code size       31 (0x1f)
      .maxstack  2
      .locals init (int V_0, //y
                    int V_1,
                    int V_2)
      // sequence point: {
      IL_0000:  nop
      // sequence point: var y = x sw ...         };
      IL_0001:  ldc.i4.1
      IL_0002:  brtrue.s   IL_0005
      // sequence point: switch ...         }
      IL_0004:  nop
      // sequence point: <hidden>
      IL_0005:  ldarg.0
      IL_0006:  ldc.i4.1
      IL_0007:  beq.s      IL_000b
      IL_0009:  br.s       IL_000f
      // sequence point: 2
      IL_000b:  ldc.i4.2
      IL_000c:  stloc.1
      IL_000d:  br.s       IL_0013
      // sequence point: 3
      IL_000f:  ldc.i4.3
      IL_0010:  stloc.1
      IL_0011:  br.s       IL_0013
      // sequence point: <hidden>
      IL_0013:  ldc.i4.1
      IL_0014:  brtrue.s   IL_0017
      // sequence point: var y = x sw ...         };
      IL_0016:  nop
      // sequence point: <hidden>
      IL_0017:  ldloc.1
      IL_0018:  stloc.0
      // sequence point: return y;
      IL_0019:  ldloc.0
      IL_001a:  stloc.2
      IL_001b:  br.s       IL_001d
      // sequence point: }
      IL_001d:  ldloc.2
      IL_001e:  ret
    }
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 377657, 379496);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_378044_378100(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 378044, 378100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_378130_378149(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 378130, 378149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_378164_379484(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 378164, 379484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 377657, 379496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 377657, 379496);
            }
        }

        [WorkItem(12378, "https://github.com/dotnet/roslyn/issues/12378")]
        [WorkItem(13971, "https://github.com/dotnet/roslyn/issues/13971")]
        [Fact]
        public void Patterns_SwitchStatement_Constant()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 379508, 386943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 379748, 380443);

                string
                source = f_23129_379764_380442(@"class Program
{
    static void M(object o)
    {
        switch (o)
        {
            case 1 when o == null:
            case 4:
            case 2 when o == null:
                break;
            case 1 when o != null:
            case 5:
            case 3 when o != null:
                break;
            default:
                break;
            case 1:
                break;
        }
        switch (o)
        {
            case 1:
                break;
            default:
                break;
        }
        switch (o)
        {
            default:
                break;
        }
    }
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 380457, 380549);

                var
                c = f_23129_380465_380548(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 380563, 383400);

                f_23129_380563_383399(f_23129_380563_380582(this, c), qualifiedMethodName: "Program.M", sequencePoints: "Program.M", source: source, expectedIL: @"{
  // Code size      123 (0x7b)
  .maxstack  2
  .locals init (object V_0,
                int V_1,
                object V_2,
                object V_3,
                int V_4,
                object V_5,
                object V_6,
                object V_7)
  // sequence point: {
  IL_0000:  nop
  // sequence point: switch (o)
  IL_0001:  ldarg.0
  IL_0002:  stloc.2
  // sequence point: <hidden>
  IL_0003:  ldloc.2
  IL_0004:  stloc.0
  // sequence point: <hidden>
  IL_0005:  ldloc.0
  IL_0006:  isinst     ""int""
  IL_000b:  brfalse.s  IL_004a
  IL_000d:  ldloc.0
  IL_000e:  unbox.any  ""int""
  IL_0013:  stloc.1
  // sequence point: <hidden>
  IL_0014:  ldloc.1
  IL_0015:  ldc.i4.1
  IL_0016:  sub
  IL_0017:  switch    (
        IL_0032,
        IL_0037,
        IL_0043,
        IL_003c,
        IL_0048)
  IL_0030:  br.s       IL_004a
  // sequence point: when o == null
  IL_0032:  ldarg.0
  IL_0033:  brfalse.s  IL_003c
  // sequence point: <hidden>
  IL_0035:  br.s       IL_003e
  // sequence point: when o == null
  IL_0037:  ldarg.0
  IL_0038:  brfalse.s  IL_003c
  // sequence point: <hidden>
  IL_003a:  br.s       IL_004a
  // sequence point: break;
  IL_003c:  br.s       IL_004e
  // sequence point: when o != null
  IL_003e:  ldarg.0
  IL_003f:  brtrue.s   IL_0048
  // sequence point: <hidden>
  IL_0041:  br.s       IL_004c
  // sequence point: when o != null
  IL_0043:  ldarg.0
  IL_0044:  brtrue.s   IL_0048
  // sequence point: <hidden>
  IL_0046:  br.s       IL_004a
  // sequence point: break;
  IL_0048:  br.s       IL_004e
  // sequence point: break;
  IL_004a:  br.s       IL_004e
  // sequence point: break;
  IL_004c:  br.s       IL_004e
  // sequence point: switch (o)
  IL_004e:  ldarg.0
  IL_004f:  stloc.s    V_5
  // sequence point: <hidden>
  IL_0051:  ldloc.s    V_5
  IL_0053:  stloc.3
  // sequence point: <hidden>
  IL_0054:  ldloc.3
  IL_0055:  isinst     ""int""
  IL_005a:  brfalse.s  IL_006d
  IL_005c:  ldloc.3
  IL_005d:  unbox.any  ""int""
  IL_0062:  stloc.s    V_4
  // sequence point: <hidden>
  IL_0064:  ldloc.s    V_4
  IL_0066:  ldc.i4.1
  IL_0067:  beq.s      IL_006b
  IL_0069:  br.s       IL_006d
  // sequence point: break;
  IL_006b:  br.s       IL_006f
  // sequence point: break;
  IL_006d:  br.s       IL_006f
  // sequence point: switch (o)
  IL_006f:  ldarg.0
  IL_0070:  stloc.s    V_7
  // sequence point: <hidden>
  IL_0072:  ldloc.s    V_7
  IL_0074:  stloc.s    V_6
  // sequence point: <hidden>
  IL_0076:  br.s       IL_0078
  // sequence point: break;
  IL_0078:  br.s       IL_007a
  // sequence point: }
  IL_007a:  ret
}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 383414, 386932);

                f_23129_383414_386931(c, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""M"" parameterNames=""o"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""35"" offset=""11"" />
          <slot kind=""35"" offset=""11"" ordinal=""1"" />
          <slot kind=""1"" offset=""11"" />
          <slot kind=""35"" offset=""378"" />
          <slot kind=""35"" offset=""378"" ordinal=""1"" />
          <slot kind=""1"" offset=""378"" />
          <slot kind=""35"" offset=""511"" />
          <slot kind=""1"" offset=""511"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""5"" startColumn=""9"" endLine=""5"" endColumn=""19"" document=""1"" />
        <entry offset=""0x3"" hidden=""true"" document=""1"" />
        <entry offset=""0x5"" hidden=""true"" document=""1"" />
        <entry offset=""0x14"" hidden=""true"" document=""1"" />
        <entry offset=""0x32"" startLine=""7"" startColumn=""20"" endLine=""7"" endColumn=""34"" document=""1"" />
        <entry offset=""0x35"" hidden=""true"" document=""1"" />
        <entry offset=""0x37"" startLine=""9"" startColumn=""20"" endLine=""9"" endColumn=""34"" document=""1"" />
        <entry offset=""0x3a"" hidden=""true"" document=""1"" />
        <entry offset=""0x3c"" startLine=""10"" startColumn=""17"" endLine=""10"" endColumn=""23"" document=""1"" />
        <entry offset=""0x3e"" startLine=""11"" startColumn=""20"" endLine=""11"" endColumn=""34"" document=""1"" />
        <entry offset=""0x41"" hidden=""true"" document=""1"" />
        <entry offset=""0x43"" startLine=""13"" startColumn=""20"" endLine=""13"" endColumn=""34"" document=""1"" />
        <entry offset=""0x46"" hidden=""true"" document=""1"" />
        <entry offset=""0x48"" startLine=""14"" startColumn=""17"" endLine=""14"" endColumn=""23"" document=""1"" />
        <entry offset=""0x4a"" startLine=""16"" startColumn=""17"" endLine=""16"" endColumn=""23"" document=""1"" />
        <entry offset=""0x4c"" startLine=""18"" startColumn=""17"" endLine=""18"" endColumn=""23"" document=""1"" />
        <entry offset=""0x4e"" startLine=""20"" startColumn=""9"" endLine=""20"" endColumn=""19"" document=""1"" />
        <entry offset=""0x51"" hidden=""true"" document=""1"" />
        <entry offset=""0x54"" hidden=""true"" document=""1"" />
        <entry offset=""0x64"" hidden=""true"" document=""1"" />
        <entry offset=""0x6b"" startLine=""23"" startColumn=""17"" endLine=""23"" endColumn=""23"" document=""1"" />
        <entry offset=""0x6d"" startLine=""25"" startColumn=""17"" endLine=""25"" endColumn=""23"" document=""1"" />
        <entry offset=""0x6f"" startLine=""27"" startColumn=""9"" endLine=""27"" endColumn=""19"" document=""1"" />
        <entry offset=""0x72"" hidden=""true"" document=""1"" />
        <entry offset=""0x76"" hidden=""true"" document=""1"" />
        <entry offset=""0x78"" startLine=""30"" startColumn=""17"" endLine=""30"" endColumn=""23"" document=""1"" />
        <entry offset=""0x7a"" startLine=""32"" startColumn=""5"" endLine=""32"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 379508, 386943);

                string
                f_23129_379764_380442(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 379764, 380442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_380465_380548(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 380465, 380548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_380563_380582(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 380563, 380582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_380563_383399(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                source, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName: qualifiedMethodName, sequencePoints: sequencePoints, source: source, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 380563, 383399);
                    return return_v;
                }


                bool
                f_23129_383414_386931(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 383414, 386931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 379508, 386943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 379508, 386943);
            }
        }

        [WorkItem(37172, "https://github.com/dotnet/roslyn/issues/37172")]
        [Fact]
        public void Patterns_SwitchStatement_Tuple()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 386955, 390853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 387116, 387379);

                string
                source = f_23129_387132_387378(@"
public class C
{
    static int F(int i)
    {
        switch (G())
        {
            case (1, 2): return 3;
            default: return 0;
        };
    }

    static (object, object) G() => (2, 3);
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 387393, 387515);

                var
                c = f_23129_387401_387514(source, options: TestOptions.DebugDll, references: s_valueTupleRefs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 387529, 387558);

                var
                cv = f_23129_387538_387557(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 387574, 389021);

                f_23129_387574_389020(
                            cv, "C.F", @"
{
  // Code size       80 (0x50)
  .maxstack  2
  .locals init (System.ValueTuple<object, object> V_0,
                object V_1,
                int V_2,
                object V_3,
                int V_4,
                System.ValueTuple<object, object> V_5,
                int V_6)
  IL_0000:  nop
  IL_0001:  call       ""System.ValueTuple<object, object> C.G()""
  IL_0006:  stloc.s    V_5
  IL_0008:  ldloc.s    V_5
  IL_000a:  stloc.0
  IL_000b:  ldloc.0
  IL_000c:  ldfld      ""object System.ValueTuple<object, object>.Item1""
  IL_0011:  stloc.1
  IL_0012:  ldloc.1
  IL_0013:  isinst     ""int""
  IL_0018:  brfalse.s  IL_0048
  IL_001a:  ldloc.1
  IL_001b:  unbox.any  ""int""
  IL_0020:  stloc.2
  IL_0021:  ldloc.2
  IL_0022:  ldc.i4.1
  IL_0023:  bne.un.s   IL_0048
  IL_0025:  ldloc.0
  IL_0026:  ldfld      ""object System.ValueTuple<object, object>.Item2""
  IL_002b:  stloc.3
  IL_002c:  ldloc.3
  IL_002d:  isinst     ""int""
  IL_0032:  brfalse.s  IL_0048
  IL_0034:  ldloc.3
  IL_0035:  unbox.any  ""int""
  IL_003a:  stloc.s    V_4
  IL_003c:  ldloc.s    V_4
  IL_003e:  ldc.i4.2
  IL_003f:  beq.s      IL_0043
  IL_0041:  br.s       IL_0048
  IL_0043:  ldc.i4.3
  IL_0044:  stloc.s    V_6
  IL_0046:  br.s       IL_004d
  IL_0048:  ldc.i4.0
  IL_0049:  stloc.s    V_6
  IL_004b:  br.s       IL_004d
  IL_004d:  ldloc.s    V_6
  IL_004f:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 389037, 390842);

                f_23129_389037_390841(
                            c, "C.F", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"" parameterNames=""i"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""35"" offset=""11"" />
          <slot kind=""35"" offset=""11"" ordinal=""1"" />
          <slot kind=""35"" offset=""11"" ordinal=""2"" />
          <slot kind=""35"" offset=""11"" ordinal=""3"" />
          <slot kind=""35"" offset=""11"" ordinal=""4"" />
          <slot kind=""1"" offset=""11"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""21"" document=""1"" />
        <entry offset=""0x8"" hidden=""true"" document=""1"" />
        <entry offset=""0xb"" hidden=""true"" document=""1"" />
        <entry offset=""0x12"" hidden=""true"" document=""1"" />
        <entry offset=""0x21"" hidden=""true"" document=""1"" />
        <entry offset=""0x2c"" hidden=""true"" document=""1"" />
        <entry offset=""0x3c"" hidden=""true"" document=""1"" />
        <entry offset=""0x43"" startLine=""8"" startColumn=""26"" endLine=""8"" endColumn=""35"" document=""1"" />
        <entry offset=""0x48"" startLine=""9"" startColumn=""22"" endLine=""9"" endColumn=""31"" document=""1"" />
        <entry offset=""0x4d"" startLine=""11"" startColumn=""5"" endLine=""11"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 386955, 390853);

                string
                f_23129_387132_387378(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 387132, 387378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_387401_387514(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 387401, 387514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_387538_387557(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 387538, 387557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_387574_389020(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 387574, 389020);
                    return return_v;
                }


                bool
                f_23129_389037_390841(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 389037, 390841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 386955, 390853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 386955, 390853);
            }
        }

        [Fact]
        public void SyntaxOffset_TupleDeconstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 390913, 392540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 391000, 391089);

                var
                source = @"class C { int F() { (int a, (_, int c)) = (1, (2, 3)); return a + c; } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 391103, 391225);

                var
                c = f_23129_391111_391224(source, options: TestOptions.DebugDll, references: s_valueTupleRefs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 391241, 392529);

                f_23129_391241_392528(
                            c, "C.F", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""7"" />
          <slot kind=""0"" offset=""18"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""1"" startColumn=""19"" endLine=""1"" endColumn=""20"" document=""1"" />
        <entry offset=""0x1"" startLine=""1"" startColumn=""21"" endLine=""1"" endColumn=""55"" document=""1"" />
        <entry offset=""0x5"" startLine=""1"" startColumn=""56"" endLine=""1"" endColumn=""69"" document=""1"" />
        <entry offset=""0xb"" startLine=""1"" startColumn=""70"" endLine=""1"" endColumn=""71"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xd"">
        <local name=""a"" il_index=""0"" il_start=""0x0"" il_end=""0xd"" attributes=""0"" />
        <local name=""c"" il_index=""1"" il_start=""0x0"" il_end=""0xd"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 390913, 392540);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_391111_391224(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 391111, 391224);
                    return return_v;
                }


                bool
                f_23129_391241_392528(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 391241, 392528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 390913, 392540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 390913, 392540);
            }
        }

        [Fact]
        public void TestDeconstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 392552, 393739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 392625, 392842);

                var
                source = @"
public class C
{
    public static (int, int) F() => (1, 2);

    public static void Main()
    {
        int x, y;
        (x, y) = F();
        System.Console.WriteLine(x + y);
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 392856, 392921);

                var
                c = f_23129_392864_392920(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 392935, 392963);

                var
                v = f_23129_392943_392962(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 392979, 393728);

                f_23129_392979_393727(
                            v, "C.Main", @"
{
  // Code size       29 (0x1d)
  .maxstack  2
  .locals init (int V_0, //x
                int V_1) //y
  // sequence point: {
  IL_0000:  nop
  // sequence point: (x, y) = F();
  IL_0001:  call       ""System.ValueTuple<int, int> C.F()""
  IL_0006:  dup
  IL_0007:  ldfld      ""int System.ValueTuple<int, int>.Item1""
  IL_000c:  stloc.0
  IL_000d:  ldfld      ""int System.ValueTuple<int, int>.Item2""
  IL_0012:  stloc.1
  // sequence point: System.Console.WriteLine(x + y);
  IL_0013:  ldloc.0
  IL_0014:  ldloc.1
  IL_0015:  add
  IL_0016:  call       ""void System.Console.WriteLine(int)""
  IL_001b:  nop
  // sequence point: }
  IL_001c:  ret
}
", sequencePoints: "C.Main", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 392552, 393739);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_392864_392920(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 392864, 392920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_392943_392962(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 392943, 392962);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_392979_393727(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 392979, 393727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 392552, 393739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 392552, 393739);
            }
        }

        [Fact]
        public void SyntaxOffset_TupleParenthesized()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 393751, 395282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 393837, 393960);

                var
                source = @"class C { int F() { (int, (int, int)) x = (1, (2, 3)); return x.Item1 + x.Item2.Item1 + x.Item2.Item2; } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 393974, 394096);

                var
                c = f_23129_393982_394095(source, options: TestOptions.DebugDll, references: s_valueTupleRefs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 394112, 395271);

                f_23129_394112_395270(
                            c, "C.F", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""20"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""1"" startColumn=""19"" endLine=""1"" endColumn=""20"" document=""1"" />
        <entry offset=""0x1"" startLine=""1"" startColumn=""21"" endLine=""1"" endColumn=""55"" document=""1"" />
        <entry offset=""0x10"" startLine=""1"" startColumn=""56"" endLine=""1"" endColumn=""103"" document=""1"" />
        <entry offset=""0x31"" startLine=""1"" startColumn=""104"" endLine=""1"" endColumn=""105"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x33"">
        <local name=""x"" il_index=""0"" il_start=""0x0"" il_end=""0x33"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 393751, 395282);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_393982_394095(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 393982, 394095);
                    return return_v;
                }


                bool
                f_23129_394112_395270(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 394112, 395270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 393751, 395282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 393751, 395282);
            }
        }

        [Fact]
        public void SyntaxOffset_TupleVarDefined()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 395294, 396774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 395377, 395459);

                var
                source = @"class C { int F() { var x = (1, 2); return x.Item1 + x.Item2; } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 395473, 395595);

                var
                c = f_23129_395481_395594(source, options: TestOptions.DebugDll, references: s_valueTupleRefs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 395611, 396763);

                f_23129_395611_396762(
                            c, "C.F", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""6"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""1"" startColumn=""19"" endLine=""1"" endColumn=""20"" document=""1"" />
        <entry offset=""0x1"" startLine=""1"" startColumn=""21"" endLine=""1"" endColumn=""36"" document=""1"" />
        <entry offset=""0xa"" startLine=""1"" startColumn=""37"" endLine=""1"" endColumn=""62"" document=""1"" />
        <entry offset=""0x1a"" startLine=""1"" startColumn=""63"" endLine=""1"" endColumn=""64"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x1c"">
        <local name=""x"" il_index=""0"" il_start=""0x0"" il_end=""0x1c"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 395294, 396774);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_395481_395594(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 395481, 395594);
                    return return_v;
                }


                bool
                f_23129_395611_396762(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 395611, 396762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 395294, 396774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 395294, 396774);
            }
        }

        [Fact]
        public void SyntaxOffset_TupleIgnoreDeconstructionIfVariableDeclared()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 396786, 398476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 396897, 396990);

                var
                source = @"class C { int F() { (int x, int y) a = (1, 2); return a.Item1 + a.Item2; } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 397004, 397126);

                var
                c = f_23129_397012_397125(source, options: TestOptions.DebugDll, references: s_valueTupleRefs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 397142, 398465);

                f_23129_397142_398464(
                            c, "C.F", @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""F"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <tupleElementNames>
          <local elementNames=""|x|y"" slotIndex=""0"" localName=""a"" scopeStart=""0x0"" scopeEnd=""0x0"" />
        </tupleElementNames>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""17"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""1"" startColumn=""19"" endLine=""1"" endColumn=""20"" document=""1"" />
        <entry offset=""0x1"" startLine=""1"" startColumn=""21"" endLine=""1"" endColumn=""47"" document=""1"" />
        <entry offset=""0x9"" startLine=""1"" startColumn=""48"" endLine=""1"" endColumn=""73"" document=""1"" />
        <entry offset=""0x19"" startLine=""1"" startColumn=""74"" endLine=""1"" endColumn=""75"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x1b"">
        <local name=""a"" il_index=""0"" il_start=""0x0"" il_end=""0x1b"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 396786, 398476);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_397012_397125(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options, Microsoft.CodeAnalysis.MetadataReference[]
                references)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options, references: (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 397012, 397125);
                    return return_v;
                }


                bool
                f_23129_397142_398464(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 397142, 398464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 396786, 398476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 396786, 398476);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInConstructor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 398536, 399645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 398623, 398918);

                var
                source = @"
class B
{
    B(out int z) { z = 2; } 
}

class C
{
    int F = G(out var v1);    
    int P => G(out var v2);    

    C() 
    : base(out var v3)
    { 
        G(out var v4);
    }

    int G(out int x) 
    {
        x = 1;
        return 2;
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 398934, 399026);

                var
                c = f_23129_398942_399025(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 399040, 399634);

                f_23129_399040_399633(c, f_23129_399265_399367(f_23129_399265_399347(f_23129_399265_399317(ErrorCode.ERR_FieldInitRefNonstatic, "G"), "C.G(out int)"), 9, 13), f_23129_399534_399632(f_23129_399534_399612(f_23129_399534_399583(ErrorCode.ERR_BadCtorArgCount, "base"), "object", "1"), 13, 7));
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 398536, 399645);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_398942_399025(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 398942, 399025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_399265_399317(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 399265, 399317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_399265_399347(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 399265, 399347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_399265_399367(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 399265, 399367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_399534_399583(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, string
                squiggledText)
                {
                    var return_v = Diagnostic((object)code, squiggledText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 399534, 399583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_399534_399612(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 399534, 399612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_399534_399632(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 399534, 399632);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_399040_399633(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                c, params Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription[]
                expected)
                {
                    var return_v = c.VerifyDiagnostics<Microsoft.CodeAnalysis.CSharp.CSharpCompilation>(expected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 399040, 399633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 398536, 399645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 398536, 399645);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 399657, 401696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 399739, 399841);

                var
                source = @"class C { int G(out int x) { int z = 1; G(out var y); G(out var w); return x = y; } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 399857, 399949);

                var
                c = f_23129_399865_399948(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 399963, 401685);

                f_23129_399963_401684(c, "C.G", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name=""G"" parameterNames=""x"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""6"" />
          <slot kind=""0"" offset=""23"" />
          <slot kind=""0"" offset=""37"" />
          <slot kind=""temp"" />
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""1"" startColumn=""28"" endLine=""1"" endColumn=""29"" document=""1"" />
        <entry offset=""0x1"" startLine=""1"" startColumn=""30"" endLine=""1"" endColumn=""40"" document=""1"" />
        <entry offset=""0x3"" startLine=""1"" startColumn=""41"" endLine=""1"" endColumn=""54"" document=""1"" />
        <entry offset=""0xc"" startLine=""1"" startColumn=""55"" endLine=""1"" endColumn=""68"" document=""1"" />
        <entry offset=""0x15"" startLine=""1"" startColumn=""69"" endLine=""1"" endColumn=""82"" document=""1"" />
        <entry offset=""0x1f"" startLine=""1"" startColumn=""83"" endLine=""1"" endColumn=""84"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x22"">
        <local name=""z"" il_index=""0"" il_start=""0x0"" il_end=""0x22"" attributes=""0"" />
        <local name=""y"" il_index=""1"" il_start=""0x0"" il_end=""0x22"" attributes=""0"" />
        <local name=""w"" il_index=""2"" il_start=""0x0"" il_end=""0x22"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 399657, 401696);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_399865_399948(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 399865, 399948);
                    return return_v;
                }


                bool
                f_23129_399963_401684(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 399963, 401684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 399657, 401696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 399657, 401696);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInInitializers_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 401708, 403955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 401799, 402080);

                var
                source = f_23129_401812_402079(@"
class C : A
{ 
    int x = G(out var x);
    int y {get;} = G(out var y);

    C() : base(G(out var z))
    { 
    } 

    static int G(out int x) 
    {
        throw null;
    }
}

class A
{
    public A(int x) {}
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 402096, 402188);

                var
                c = f_23129_402104_402187(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 402202, 403944);

                f_23129_402202_403943(c, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""-36"" />
          <slot kind=""0"" offset=""-22"" />
          <slot kind=""0"" offset=""-3"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""26"" document=""1"" />
        <entry offset=""0xd"" startLine=""5"" startColumn=""20"" endLine=""5"" endColumn=""32"" document=""1"" />
        <entry offset=""0x1a"" startLine=""7"" startColumn=""11"" endLine=""7"" endColumn=""29"" document=""1"" />
        <entry offset=""0x28"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""1"" />
        <entry offset=""0x29"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x2a"">
        <scope startOffset=""0x0"" endOffset=""0xd"">
          <local name=""x"" il_index=""0"" il_start=""0x0"" il_end=""0xd"" attributes=""0"" />
        </scope>
        <scope startOffset=""0xd"" endOffset=""0x1a"">
          <local name=""y"" il_index=""1"" il_start=""0xd"" il_end=""0x1a"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x1a"" endOffset=""0x2a"">
          <local name=""z"" il_index=""2"" il_start=""0x1a"" il_end=""0x2a"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 401708, 403955);

                string
                f_23129_401812_402079(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 401812, 402079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_402104_402187(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 402104, 402187);
                    return return_v;
                }


                bool
                f_23129_402202_403943(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 402202, 403943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 401708, 403955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 401708, 403955);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInInitializers_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 403967, 405889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 404058, 404310);

                var
                source = f_23129_404071_404309(@"
class C : A
{ 
    C() : base(G(out var x))
    { 
        int y = 1;
        y++;
    } 

    static int G(out int x) 
    {
        throw null;
    }
}

class A
{
    public A(int x) {}
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 404326, 404418);

                var
                c = f_23129_404334_404417(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 404432, 405878);

                f_23129_404432_405877(c, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""-3"" />
          <slot kind=""0"" offset=""16"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""11"" endLine=""4"" endColumn=""29"" document=""1"" />
        <entry offset=""0xe"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0xf"" startLine=""6"" startColumn=""9"" endLine=""6"" endColumn=""19"" document=""1"" />
        <entry offset=""0x11"" startLine=""7"" startColumn=""9"" endLine=""7"" endColumn=""13"" document=""1"" />
        <entry offset=""0x15"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x16"">
        <local name=""x"" il_index=""0"" il_start=""0x0"" il_end=""0x16"" attributes=""0"" />
        <scope startOffset=""0xe"" endOffset=""0x16"">
          <local name=""y"" il_index=""1"" il_start=""0xe"" il_end=""0x16"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 403967, 405889);

                string
                f_23129_404071_404309(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 404071, 404309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_404334_404417(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 404334, 404417);
                    return return_v;
                }


                bool
                f_23129_404432_405877(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 404432, 405877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 403967, 405889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 403967, 405889);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInInitializers_03()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 405901, 407453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 405992, 406216);

                var
                source = f_23129_406005_406215(@"
class C : A
{ 
    C() : base(G(out var x))
    => G(out var y);

    static int G(out int x) 
    {
        throw null;
    }
}

class A
{
    public A(int x) {}
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 406232, 406324);

                var
                c = f_23129_406240_406323(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 406338, 407442);

                f_23129_406338_407441(c, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""-3"" />
          <slot kind=""0"" offset=""13"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""11"" endLine=""4"" endColumn=""29"" document=""1"" />
        <entry offset=""0xe"" startLine=""5"" startColumn=""8"" endLine=""5"" endColumn=""20"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x17"">
        <local name=""x"" il_index=""0"" il_start=""0x0"" il_end=""0x17"" attributes=""0"" />
        <scope startOffset=""0xe"" endOffset=""0x17"">
          <local name=""y"" il_index=""1"" il_start=""0xe"" il_end=""0x17"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 405901, 407453);

                string
                f_23129_406005_406215(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 406005, 406215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_406240_406323(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 406240, 406323);
                    return return_v;
                }


                bool
                f_23129_406338_407441(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 406338, 407441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 405901, 407453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 405901, 407453);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInInitializers_04()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 407465, 410043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 407556, 407836);

                var
                source = f_23129_407569_407835(@"
class C
{ 
    static int G(out int x) 
    {
        throw null;
    }
    static int F(System.Func<int> x) 
    {
        throw null;
    }

    C() 
    {
    }

#line 2000
    int y1 = G(out var z) + F(() => z);
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 407852, 407944);

                var
                c = f_23129_407860_407943(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 407960, 409433);

                f_23129_407960_409432(
                            c, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""G"" parameterNames=""x"" />
        <encLocalSlotMap>
          <slot kind=""30"" offset=""-25"" />
        </encLocalSlotMap>
        <encLambdaMap>
          <methodOrdinal>2</methodOrdinal>
          <closure offset=""-25"" />
          <lambda offset=""-2"" closure=""0"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x6"" startLine=""2000"" startColumn=""5"" endLine=""2000"" endColumn=""40"" document=""1"" />
        <entry offset=""0x29"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""8"" document=""1"" />
        <entry offset=""0x30"" startLine=""14"" startColumn=""5"" endLine=""14"" endColumn=""6"" document=""1"" />
        <entry offset=""0x31"" startLine=""15"" startColumn=""5"" endLine=""15"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x32"">
        <scope startOffset=""0x0"" endOffset=""0x29"">
          <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0x29"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 409449, 410032);

                f_23129_409449_410031(
                            c, "C+<>c__DisplayClass2_0.<.ctor>b__0", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c__DisplayClass2_0"" name=""&lt;.ctor&gt;b__0"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""G"" parameterNames=""x"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""2000"" startColumn=""37"" endLine=""2000"" endColumn=""38"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 407465, 410043);

                string
                f_23129_407569_407835(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 407569, 407835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_407860_407943(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 407860, 407943);
                    return return_v;
                }


                bool
                f_23129_407960_409432(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 407960, 409432);
                    return return_v;
                }


                bool
                f_23129_409449_410031(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 409449, 410031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 407465, 410043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 407465, 410043);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInInitializers_05()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 410055, 412269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 410146, 410409);

                var
                source = f_23129_410159_410408(@"
class C
{ 
    static int G(out int x) 
    {
        throw null;
    }
    static int F(System.Func<int> x) 
    {
        throw null;
    }

#line 2000
    int y1 { get; } = G(out var z) + F(() => z);
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 410425, 410517);

                var
                c = f_23129_410433_410516(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 410533, 411659);

                f_23129_410533_411658(
                            c, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""G"" parameterNames=""x"" />
        <encLocalSlotMap>
          <slot kind=""30"" offset=""-25"" />
        </encLocalSlotMap>
        <encLambdaMap>
          <methodOrdinal>5</methodOrdinal>
          <closure offset=""-25"" />
          <lambda offset=""-2"" closure=""0"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x6"" startLine=""2000"" startColumn=""23"" endLine=""2000"" endColumn=""48"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x31"">
        <scope startOffset=""0x0"" endOffset=""0x29"">
          <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0x29"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 411675, 412258);

                f_23129_411675_412257(
                            c, "C+<>c__DisplayClass5_0.<.ctor>b__0", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c__DisplayClass5_0"" name=""&lt;.ctor&gt;b__0"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""G"" parameterNames=""x"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""2000"" startColumn=""46"" endLine=""2000"" endColumn=""47"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 410055, 412269);

                string
                f_23129_410159_410408(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 410159, 410408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_410433_410516(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 410433, 410516);
                    return return_v;
                }


                bool
                f_23129_410533_411658(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 410533, 411658);
                    return return_v;
                }


                bool
                f_23129_411675_412257(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 411675, 412257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 410055, 412269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 410055, 412269);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInInitializers_06()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 412281, 417029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 412372, 412658);

                var
                source = f_23129_412385_412657(@"
class C
{ 
    static int G(out int x) 
    {
        throw null;
    }
    static int F(System.Func<int> x) 
    {
        throw null;
    }

#line 2000
    int y1 = G(out var z) + F(() => z), y2 = G(out var u) + F(() => u);
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 412674, 412766);

                var
                c = f_23129_412682_412765(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 412782, 412810);

                var
                v = f_23129_412790_412809(this, c)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 412824, 414162);

                f_23129_412824_414161(v, "C..ctor", sequencePoints: "C..ctor", expectedIL: @"
{
  // Code size       90 (0x5a)
  .maxstack  4
  .locals init (C.<>c__DisplayClass4_0 V_0, //CS$<>8__locals0
                C.<>c__DisplayClass4_1 V_1) //CS$<>8__locals1
 ~IL_0000:  newobj     ""C.<>c__DisplayClass4_0..ctor()""
  IL_0005:  stloc.0
 -IL_0006:  ldarg.0
  IL_0007:  ldloc.0
  IL_0008:  ldflda     ""int C.<>c__DisplayClass4_0.z""
  IL_000d:  call       ""int C.G(out int)""
  IL_0012:  ldloc.0
  IL_0013:  ldftn      ""int C.<>c__DisplayClass4_0.<.ctor>b__0()""
  IL_0019:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
  IL_001e:  call       ""int C.F(System.Func<int>)""
  IL_0023:  add
  IL_0024:  stfld      ""int C.y1""
 ~IL_0029:  newobj     ""C.<>c__DisplayClass4_1..ctor()""
  IL_002e:  stloc.1
 -IL_002f:  ldarg.0
  IL_0030:  ldloc.1
  IL_0031:  ldflda     ""int C.<>c__DisplayClass4_1.u""
  IL_0036:  call       ""int C.G(out int)""
  IL_003b:  ldloc.1
  IL_003c:  ldftn      ""int C.<>c__DisplayClass4_1.<.ctor>b__1()""
  IL_0042:  newobj     ""System.Func<int>..ctor(object, System.IntPtr)""
  IL_0047:  call       ""int C.F(System.Func<int>)""
  IL_004c:  add
  IL_004d:  stfld      ""int C.y2""
  IL_0052:  ldarg.0
  IL_0053:  call       ""object..ctor()""
  IL_0058:  nop
  IL_0059:  ret
}
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 414178, 415820);

                f_23129_414178_415819(
                            c, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""G"" parameterNames=""x"" />
        <encLocalSlotMap>
          <slot kind=""30"" offset=""-52"" />
          <slot kind=""30"" offset=""-25"" />
        </encLocalSlotMap>
        <encLambdaMap>
          <methodOrdinal>4</methodOrdinal>
          <closure offset=""-52"" />
          <closure offset=""-25"" />
          <lambda offset=""-29"" closure=""0"" />
          <lambda offset=""-2"" closure=""1"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x6"" startLine=""2000"" startColumn=""5"" endLine=""2000"" endColumn=""39"" document=""1"" />
        <entry offset=""0x29"" hidden=""true"" document=""1"" />
        <entry offset=""0x2f"" startLine=""2000"" startColumn=""41"" endLine=""2000"" endColumn=""71"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x5a"">
        <scope startOffset=""0x0"" endOffset=""0x29"">
          <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0x29"" attributes=""0"" />
        </scope>
        <scope startOffset=""0x29"" endOffset=""0x52"">
          <local name=""CS$&lt;&gt;8__locals1"" il_index=""1"" il_start=""0x29"" il_end=""0x52"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 415836, 416419);

                f_23129_415836_416418(
                            c, "C+<>c__DisplayClass4_0.<.ctor>b__0", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c__DisplayClass4_0"" name=""&lt;.ctor&gt;b__0"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""G"" parameterNames=""x"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""2000"" startColumn=""37"" endLine=""2000"" endColumn=""38"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 416435, 417018);

                f_23129_416435_417017(
                            c, "C+<>c__DisplayClass4_1.<.ctor>b__1", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c__DisplayClass4_1"" name=""&lt;.ctor&gt;b__1"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName=""G"" parameterNames=""x"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""2000"" startColumn=""69"" endLine=""2000"" endColumn=""70"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 412281, 417029);

                string
                f_23129_412385_412657(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 412385, 412657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_412682_412765(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 412682, 412765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_412790_412809(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.Compilation)compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 412790, 412809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_412824_414161(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                sequencePoints, string
                expectedIL)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, sequencePoints: sequencePoints, expectedIL: expectedIL);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 412824, 414161);
                    return return_v;
                }


                bool
                f_23129_414178_415819(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 414178, 415819);
                    return return_v;
                }


                bool
                f_23129_415836_416418(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 415836, 416418);
                    return return_v;
                }


                bool
                f_23129_416435_417017(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 416435, 417017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 412281, 417029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 412281, 417029);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInInitializers_07()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 417041, 419449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 417132, 417448);

                var
                source = f_23129_417145_417447(@"
class C : A
{ 
#line 2000
    C() : base(G(out var z)+ F(() => z))
    { 
    } 

    static int G(out int x) 
    {
        throw null;
    }
    static int F(System.Func<int> x) 
    {
        throw null;
    }
}

class A
{
    public A(int x) {}
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 417464, 417556);

                var
                c = f_23129_417472_417555(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 417570, 418856);

                f_23129_417570_418855(c, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""30"" offset=""-1"" />
        </encLocalSlotMap>
        <encLambdaMap>
          <methodOrdinal>0</methodOrdinal>
          <closure offset=""-1"" />
          <lambda offset=""-3"" closure=""0"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x6"" startLine=""2000"" startColumn=""11"" endLine=""2000"" endColumn=""41"" document=""1"" />
        <entry offset=""0x2a"" startLine=""2001"" startColumn=""5"" endLine=""2001"" endColumn=""6"" document=""1"" />
        <entry offset=""0x2b"" startLine=""2002"" startColumn=""5"" endLine=""2002"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x2c"">
        <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0x2c"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 418872, 419438);

                f_23129_418872_419437(
                            c, "C+<>c__DisplayClass0_0.<.ctor>b__0", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c__DisplayClass0_0"" name=""&lt;.ctor&gt;b__0"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".ctor"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""2000"" startColumn=""38"" endLine=""2000"" endColumn=""39"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 417041, 419449);

                string
                f_23129_417145_417447(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 417145, 417447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_417472_417555(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 417472, 417555);
                    return return_v;
                }


                bool
                f_23129_417570_418855(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 417570, 418855);
                    return return_v;
                }


                bool
                f_23129_418872_419437(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 418872, 419437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 417041, 419449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 417041, 419449);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInQuery_01()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 419461, 422181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 419545, 419850);

                var
                source = f_23129_419558_419849(@"
using System.Linq;

class C
{ 
    C()
    {
        var q = from a in new [] {1} 
                where 
                      G(out var x1) > a  
                select a;
    }

    static int G(out int x) 
    {
        throw null;
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 419866, 419958);

                var
                c = f_23129_419874_419957(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 419972, 421337);

                f_23129_419972_421336(c, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
        <encLambdaMap>
          <methodOrdinal>0</methodOrdinal>
          <lambda offset=""88"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""8"" document=""1"" />
        <entry offset=""0x7"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x8"" startLine=""8"" startColumn=""9"" endLine=""11"" endColumn=""26"" document=""1"" />
        <entry offset=""0x37"" startLine=""12"" startColumn=""5"" endLine=""12"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x38"">
        <namespace name=""System.Linq"" />
        <scope startOffset=""0x7"" endOffset=""0x38"">
          <local name=""q"" il_index=""0"" il_start=""0x7"" il_end=""0x38"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 421353, 422170);

                f_23129_421353_422169(
                            c, "C+<>c.<.ctor>b__0_0", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c"" name=""&lt;.ctor&gt;b__0_0"" parameterNames=""a"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".ctor"" />
        <encLocalSlotMap>
          <slot kind=""0"" offset=""98"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""10"" startColumn=""23"" endLine=""10"" endColumn=""40"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0xb"">
        <local name=""x1"" il_index=""0"" il_start=""0x0"" il_end=""0xb"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 419461, 422181);

                string
                f_23129_419558_419849(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 419558, 419849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_419874_419957(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 419874, 419957);
                    return return_v;
                }


                bool
                f_23129_419972_421336(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 419972, 421336);
                    return return_v;
                }


                bool
                f_23129_421353_422169(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 421353, 422169);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 419461, 422181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 419461, 422181);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInQuery_02()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 422193, 425785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 422277, 422678);

                var
                source = f_23129_422290_422677(@"
using System.Linq;

class C
{ 
    C()
#line 2000
    {
        var q = from a in new [] {1} 
                where 
                      G(out var x1) > F(() => x1)  
                select a;
    }

    static int G(out int x) 
    {
        throw null;
    }
    static int F(System.Func<int> x) 
    {
        throw null;
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 422694, 422786);

                var
                c = f_23129_422702_422785(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 422800, 424268);

                f_23129_422800_424267(c, "C..ctor", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""0"" offset=""15"" />
        </encLocalSlotMap>
        <encLambdaMap>
          <methodOrdinal>0</methodOrdinal>
          <closure offset=""88"" />
          <lambda offset=""88"" />
          <lambda offset=""112"" closure=""0"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""8"" document=""1"" />
        <entry offset=""0x7"" startLine=""2000"" startColumn=""5"" endLine=""2000"" endColumn=""6"" document=""1"" />
        <entry offset=""0x8"" startLine=""2001"" startColumn=""9"" endLine=""2004"" endColumn=""26"" document=""1"" />
        <entry offset=""0x37"" startLine=""2005"" startColumn=""5"" endLine=""2005"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x38"">
        <namespace name=""System.Linq"" />
        <scope startOffset=""0x7"" endOffset=""0x38"">
          <local name=""q"" il_index=""0"" il_start=""0x7"" il_end=""0x38"" attributes=""0"" />
        </scope>
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 424284, 425192);

                f_23129_424284_425191(
                            c, "C+<>c.<.ctor>b__0_0", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c"" name=""&lt;.ctor&gt;b__0_0"" parameterNames=""a"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".ctor"" />
        <encLocalSlotMap>
          <slot kind=""30"" offset=""88"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x6"" startLine=""2003"" startColumn=""23"" endLine=""2003"" endColumn=""50"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x25"">
        <local name=""CS$&lt;&gt;8__locals0"" il_index=""0"" il_start=""0x0"" il_end=""0x25"" attributes=""0"" />
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 425208, 425774);

                f_23129_425208_425773(
                            c, "C+<>c__DisplayClass0_0.<.ctor>b__1", @"
<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""C+&lt;&gt;c__DisplayClass0_0"" name=""&lt;.ctor&gt;b__1"">
      <customDebugInfo>
        <forward declaringType=""C"" methodName="".ctor"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""2003"" startColumn=""47"" endLine=""2003"" endColumn=""49"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 422193, 425785);

                string
                f_23129_422290_422677(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 422290, 422677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_422702_422785(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 422702, 422785);
                    return return_v;
                }


                bool
                f_23129_422800_424267(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 422800, 424267);
                    return return_v;
                }


                bool
                f_23129_424284_425191(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 424284, 425191);
                    return return_v;
                }


                bool
                f_23129_425208_425773(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 425208, 425773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 422193, 425785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 422193, 425785);
            }
        }

        [Fact]
        public void SyntaxOffset_OutVarInSwitchExpression()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 425797, 428553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 425889, 426058);

                var
                source = @"class C { static object G() => N(out var x) switch { null => x switch {1 =>  1, _ => 2 }, _ => 1 }; static object N(out int x) { x = 1; return null; } }"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 426074, 426166);

                var
                c = f_23129_426082_426165(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 426180, 428542);

                f_23129_426180_428541(c, "C.G", @"
    <symbols>
      <files>
        <file id=""1"" name="""" language=""C#"" />
      </files>
      <methods>
        <method containingType=""C"" name=""G"">
          <customDebugInfo>
            <using>
              <namespace usingCount=""0"" />
            </using>
            <encLocalSlotMap>
              <slot kind=""0"" offset=""13"" />
              <slot kind=""temp"" />
              <slot kind=""35"" offset=""16"" />
              <slot kind=""temp"" />
            </encLocalSlotMap>
          </customDebugInfo>
          <sequencePoints>
            <entry offset=""0x0"" startLine=""1"" startColumn=""32"" endLine=""1"" endColumn=""99"" document=""1"" />
            <entry offset=""0xb"" startLine=""1"" startColumn=""45"" endLine=""1"" endColumn=""99"" document=""1"" />
            <entry offset=""0xc"" hidden=""true"" document=""1"" />
            <entry offset=""0x11"" hidden=""true"" document=""1"" />
            <entry offset=""0x14"" startLine=""1"" startColumn=""64"" endLine=""1"" endColumn=""89"" document=""1"" />
            <entry offset=""0x15"" hidden=""true"" document=""1"" />
            <entry offset=""0x1b"" startLine=""1"" startColumn=""78"" endLine=""1"" endColumn=""79"" document=""1"" />
            <entry offset=""0x1f"" startLine=""1"" startColumn=""86"" endLine=""1"" endColumn=""87"" document=""1"" />
            <entry offset=""0x23"" hidden=""true"" document=""1"" />
            <entry offset=""0x26"" startLine=""1"" startColumn=""45"" endLine=""1"" endColumn=""99"" document=""1"" />
            <entry offset=""0x27"" startLine=""1"" startColumn=""62"" endLine=""1"" endColumn=""89"" document=""1"" />
            <entry offset=""0x2b"" startLine=""1"" startColumn=""96"" endLine=""1"" endColumn=""97"" document=""1"" />
            <entry offset=""0x2f"" hidden=""true"" document=""1"" />
            <entry offset=""0x32"" startLine=""1"" startColumn=""32"" endLine=""1"" endColumn=""99"" document=""1"" />
            <entry offset=""0x33"" hidden=""true"" document=""1"" />
          </sequencePoints>
          <scope startOffset=""0x0"" endOffset=""0x3a"">
            <local name=""x"" il_index=""0"" il_start=""0x0"" il_end=""0x3a"" attributes=""0"" />
          </scope>
        </method>
      </methods>
    </symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 425797, 428553);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_426082_426165(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 426082, 426165);
                    return return_v;
                }


                bool
                f_23129_426180_428541(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                qualifiedMethodName, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(qualifiedMethodName, expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 426180, 428541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 425797, 428553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 425797, 428553);
            }
        }

        [WorkItem(4370, "https://github.com/dotnet/roslyn/issues/4370")]
        [Fact]
        public void HeadingHiddenSequencePointsPickUpDocumentFromVisibleSequencePoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 428587, 432417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 428781, 429069);

                var
                source = f_23129_428794_429068(@"#line 1 ""C:\Async.cs""
#pragma checksum ""C:\Async.cs"" ""{ff1816ec-aa5e-4d10-87f7-6f4963833460}"" ""DBEB2A067B2F0E0D678A002C587A2806056C3DCE""

using System.Threading.Tasks;

public class C
{
    public async void M1()
    {
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 429085, 429178);

                var
                tree = f_23129_429096_429177(source, encoding: f_23129_429144_429157(), path: "HIDDEN.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 429192, 429338);

                var
                c = f_23129_429200_429337("Compilation", new[] { tree }, new[] { f_23129_429264_429279() }, options: f_23129_429292_429336(TestOptions.DebugDll, true))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 429354, 431053);

                f_23129_429354_431052(
                            c, @"<symbols>
  <files>
    <file id=""1"" name=""C:\Async.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""DB-EB-2A-06-7B-2F-0E-0D-67-8A-00-2C-58-7A-28-06-05-6C-3D-CE"" />
    <file id=""2"" name=""HIDDEN.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""8A-92-EE-2F-D6-6F-C0-69-F4-A8-54-CB-11-BE-A3-06-76-2C-9C-98"" />
  </files>
  <methods>
    <method containingType=""C"" name=""M1"">
      <customDebugInfo>
        <forwardIterator name=""&lt;M1&gt;d__0"" />
      </customDebugInfo>
    </method>
    <method containingType=""C+&lt;M1&gt;d__0"" name=""MoveNext"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""27"" offset=""0"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x7"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""1"" />
        <entry offset=""0xa"" hidden=""true"" document=""1"" />
        <entry offset=""0x22"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
        <entry offset=""0x2a"" hidden=""true"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x37"">
        <namespace name=""System.Threading.Tasks"" />
      </scope>
      <asyncInfo>
        <catchHandler offset=""0xa"" />
        <kickoffMethod declaringType=""C"" methodName=""M1"" />
      </asyncInfo>
    </method>
  </methods>
</symbols>
", format: DebugInformationFormat.Pdb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 431069, 432406);

                f_23129_431069_432405(
                            c, @"
<symbols>
  <files>
    <file id=""1"" name=""HIDDEN.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""8A-92-EE-2F-D6-6F-C0-69-F4-A8-54-CB-11-BE-A3-06-76-2C-9C-98"" />
    <file id=""2"" name=""C:\Async.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""DB-EB-2A-06-7B-2F-0E-0D-67-8A-00-2C-58-7A-28-06-05-6C-3D-CE"" />
  </files>
  <methods>
    <method containingType=""C+&lt;M1&gt;d__0"" name=""MoveNext"">
      <customDebugInfo>
        <encLocalSlotMap>
          <slot kind=""27"" offset=""0"" />
          <slot kind=""temp"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""2"" />
        <entry offset=""0x7"" startLine=""8"" startColumn=""5"" endLine=""8"" endColumn=""6"" document=""2"" />
        <entry offset=""0xa"" hidden=""true"" document=""2"" />
        <entry offset=""0x22"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""2"" />
        <entry offset=""0x2a"" hidden=""true"" document=""2"" />
      </sequencePoints>
      <asyncInfo>
        <catchHandler offset=""0xa"" />
        <kickoffMethod declaringType=""C"" methodName=""M1"" />
      </asyncInfo>
    </method>
  </methods>
</symbols>", format: DebugInformationFormat.PortablePdb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 428587, 432417);

                string
                f_23129_428794_429068(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 428794, 429068);
                    return return_v;
                }


                System.Text.Encoding
                f_23129_429144_429157()
                {
                    var return_v = Encoding.UTF8;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 429144, 429157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_429096_429177(string
                text, System.Text.Encoding
                encoding, string
                path)
                {
                    var return_v = SyntaxFactory.ParseSyntaxTree(text, encoding: encoding, path: path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 429096, 429177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataReference
                f_23129_429264_429279()
                {
                    var return_v = MscorlibRef_v46;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 429264, 429279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_23129_429292_429336(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param, bool
                debugPlusMode)
                {
                    var return_v = this_param.WithDebugPlusMode(debugPlusMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 429292, 429336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_429200_429337(string
                assemblyName, Microsoft.CodeAnalysis.SyntaxTree[]
                syntaxTrees, Microsoft.CodeAnalysis.MetadataReference[]
                references, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CSharpCompilation.Create(assemblyName, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)syntaxTrees, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.MetadataReference>)references, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 429200, 429337);
                    return return_v;
                }


                bool
                f_23129_429354_431052(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 429354, 431052);
                    return return_v;
                }


                bool
                f_23129_431069_432405(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 431069, 432405);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 428587, 432417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 428587, 432417);
            }
        }

        [WorkItem(12923, "https://github.com/dotnet/roslyn/issues/12923")]
        [Fact]
        public void SequencePointsForConstructorWithHiddenInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 432429, 435166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 432609, 432719);

                string
                initializerSource = f_23129_432636_432718(@"
#line hidden
partial class C
{
    int i = 42;
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 432735, 432837);

                string
                constructorSource = f_23129_432762_432836(@"
partial class C
{
    C()
    {
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 432853, 433043);

                var
                c = f_23129_432861_433042(new[] { f_23129_432905_432947(initializerSource, "initializer.cs"), f_23129_432949_432991(constructorSource, "constructor.cs") }, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 433059, 434160);

                f_23129_433059_434159(
                            c, @"
<symbols>
  <files>
    <file id=""1"" name=""constructor.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""EA-D6-0A-16-6C-6A-BC-C1-5D-98-0F-B7-4B-78-13-93-FB-C7-C2-5A"" />
    <file id=""2"" name=""initializer.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""84-32-24-D7-FE-32-63-BA-41-D5-17-A2-D5-90-23-B8-12-3C-AF-D5"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""1"" />
        <entry offset=""0x8"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""8"" document=""1"" />
        <entry offset=""0xf"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""1"" />
        <entry offset=""0x10"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>
", format: DebugInformationFormat.Pdb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 434176, 435155);

                f_23129_434176_435154(
                            c, @"
<symbols>
  <files>
    <file id=""1"" name=""initializer.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""84-32-24-D7-FE-32-63-BA-41-D5-17-A2-D5-90-23-B8-12-3C-AF-D5"" />
    <file id=""2"" name=""constructor.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""EA-D6-0A-16-6C-6A-BC-C1-5D-98-0F-B7-4B-78-13-93-FB-C7-C2-5A"" />
  </files>
  <methods>
    <method containingType=""C"" name="".ctor"">
      <sequencePoints>
        <entry offset=""0x0"" hidden=""true"" document=""2"" />
        <entry offset=""0x8"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""8"" document=""2"" />
        <entry offset=""0xf"" startLine=""5"" startColumn=""5"" endLine=""5"" endColumn=""6"" document=""2"" />
        <entry offset=""0x10"" startLine=""6"" startColumn=""5"" endLine=""6"" endColumn=""6"" document=""2"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>", format: DebugInformationFormat.PortablePdb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 432429, 435166);

                string
                f_23129_432636_432718(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 432636, 432718);
                    return return_v;
                }


                string
                f_23129_432762_432836(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 432762, 432836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_432905_432947(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 432905, 432947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_432949_432991(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 432949, 432991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_432861_433042(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 432861, 433042);
                    return return_v;
                }


                bool
                f_23129_433059_434159(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 433059, 434159);
                    return return_v;
                }


                bool
                f_23129_434176_435154(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                format)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 434176, 435154);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 432429, 435166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 432429, 435166);
            }
        }

        [WorkItem(14437, "https://github.com/dotnet/roslyn/issues/14437")]
        [Fact]
        public void LocalFunctionSequencePoints()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 435178, 438256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 435336, 435933);

                string
                source = f_23129_435352_435932(@"class Program
{
    static int Main(string[] args)
    {                                                // 4
        int Local1(string[] a)
            =>
            a.Length;                                // 7
        int Local2(string[] a)
        {                                            // 9
            return a.Length;                         // 10
        }                                            // 11
        return Local1(args) + Local2(args);          // 12
    }                                                // 13
}")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 435947, 436039);

                var
                c = f_23129_435955_436038(source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 436053, 438245);

                f_23129_436053_438244(c, @"<symbols>
  <files>
    <file id=""1"" name="""" language=""C#"" />
  </files>
  <methods>
    <method containingType=""Program"" name=""Main"" parameterNames=""args"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""0"" />
        </using>
        <encLocalSlotMap>
          <slot kind=""21"" offset=""0"" />
        </encLocalSlotMap>
        <encLambdaMap>
          <methodOrdinal>0</methodOrdinal>
          <lambda offset=""115"" />
          <lambda offset=""202"" />
        </encLambdaMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""4"" startColumn=""5"" endLine=""4"" endColumn=""6"" document=""1"" />
        <entry offset=""0x3"" startLine=""12"" startColumn=""9"" endLine=""12"" endColumn=""44"" document=""1"" />
        <entry offset=""0x13"" startLine=""13"" startColumn=""5"" endLine=""13"" endColumn=""6"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""Program"" name=""&lt;Main&gt;g__Local1|0_0"" parameterNames=""a"">
      <customDebugInfo>
        <forward declaringType=""Program"" methodName=""Main"" parameterNames=""args"" />
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""13"" endLine=""7"" endColumn=""21"" document=""1"" />
      </sequencePoints>
    </method>
    <method containingType=""Program"" name=""&lt;Main&gt;g__Local2|0_1"" parameterNames=""a"">
      <customDebugInfo>
        <forward declaringType=""Program"" methodName=""Main"" parameterNames=""args"" />
        <encLocalSlotMap>
          <slot kind=""21"" offset=""202"" />
        </encLocalSlotMap>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""9"" startColumn=""9"" endLine=""9"" endColumn=""10"" document=""1"" />
        <entry offset=""0x1"" startLine=""10"" startColumn=""13"" endLine=""10"" endColumn=""29"" document=""1"" />
        <entry offset=""0x7"" startLine=""11"" startColumn=""9"" endLine=""11"" endColumn=""10"" document=""1"" />
      </sequencePoints>
    </method>
  </methods>
</symbols>");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 435178, 438256);

                string
                f_23129_435352_435932(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 435352, 435932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_435955_436038(string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilationWithMscorlib40AndSystemCore((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 435955, 436038);
                    return return_v;
                }


                bool
                f_23129_436053_438244(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 436053, 438244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 435178, 438256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 435178, 438256);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void SwitchInAsyncMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 438268, 441012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 438418, 438635);

                var
                source = @"
using System;

class Program
{
    public static async void Test()
    {
        int i = 0;

        switch (i)
        {
            case 1:
                break;
        }
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 438649, 438713);

                var
                v = f_23129_438657_438712(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 438729, 441001);

                f_23129_438729_441000(
                            v, "Program.<Test>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()", @"
{
  // Code size       89 (0x59)
  .maxstack  2
  .locals init (int V_0,
                int V_1,
                System.Exception V_2)
  // sequence point: <hidden>
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int Program.<Test>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: {
    IL_0007:  nop
    // sequence point: int i = 0;
    IL_0008:  ldarg.0
    IL_0009:  ldc.i4.0
    IL_000a:  stfld      ""int Program.<Test>d__0.<i>5__1""
    // sequence point: switch (i)
    IL_000f:  ldarg.0
    IL_0010:  ldarg.0
    IL_0011:  ldfld      ""int Program.<Test>d__0.<i>5__1""
    IL_0016:  stloc.1
    // sequence point: <hidden>
    IL_0017:  ldloc.1
    IL_0018:  stfld      ""int Program.<Test>d__0.<>s__2""
    // sequence point: <hidden>
    IL_001d:  ldarg.0
    IL_001e:  ldfld      ""int Program.<Test>d__0.<>s__2""
    IL_0023:  ldc.i4.1
    IL_0024:  beq.s      IL_0028
    IL_0026:  br.s       IL_002a
    // sequence point: break;
    IL_0028:  br.s       IL_002a
    // sequence point: <hidden>
    IL_002a:  leave.s    IL_0044
  }
  catch System.Exception
  {
    // async: catch handler, sequence point: <hidden>
    IL_002c:  stloc.2
    IL_002d:  ldarg.0
    IL_002e:  ldc.i4.s   -2
    IL_0030:  stfld      ""int Program.<Test>d__0.<>1__state""
    IL_0035:  ldarg.0
    IL_0036:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
    IL_003b:  ldloc.2
    IL_003c:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetException(System.Exception)""
    IL_0041:  nop
    IL_0042:  leave.s    IL_0058
  }
  // sequence point: }
  IL_0044:  ldarg.0
  IL_0045:  ldc.i4.s   -2
  IL_0047:  stfld      ""int Program.<Test>d__0.<>1__state""
  // sequence point: <hidden>
  IL_004c:  ldarg.0
  IL_004d:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
  IL_0052:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetResult()""
  IL_0057:  nop
  IL_0058:  ret
}", sequencePoints: "Program+<Test>d__0.MoveNext", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 438268, 441012);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_438657_438712(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 438657, 438712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_438729_441000(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 438729, 441000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 438268, 441012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 438268, 441012);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void WhileInAsyncMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 441024, 443624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 441173, 441359);

                var
                source = @"
using System;

class Program
{
    public static async void Test()
    {
        int i = 0;
        while (i == 1)
            Console.WriteLine();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 441373, 441437);

                var
                v = f_23129_441381_441436(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 441453, 443613);

                f_23129_441453_443612(
                            v, "Program.<Test>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()", @"
{
  // Code size       83 (0x53)
  .maxstack  2
  .locals init (int V_0,
                bool V_1,
                System.Exception V_2)
  // sequence point: <hidden>
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int Program.<Test>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: {
    IL_0007:  nop
    // sequence point: int i = 0;
    IL_0008:  ldarg.0
    IL_0009:  ldc.i4.0
    IL_000a:  stfld      ""int Program.<Test>d__0.<i>5__1""
    // sequence point: <hidden>
    IL_000f:  br.s       IL_0017
    // sequence point: Console.WriteLine();
    IL_0011:  call       ""void System.Console.WriteLine()""
    IL_0016:  nop
    // sequence point: while (i == 1)
    IL_0017:  ldarg.0
    IL_0018:  ldfld      ""int Program.<Test>d__0.<i>5__1""
    IL_001d:  ldc.i4.1
    IL_001e:  ceq
    IL_0020:  stloc.1
    // sequence point: <hidden>
    IL_0021:  ldloc.1
    IL_0022:  brtrue.s   IL_0011
    IL_0024:  leave.s    IL_003e
  }
  catch System.Exception
  {
    // async: catch handler, sequence point: <hidden>
    IL_0026:  stloc.2
    IL_0027:  ldarg.0
    IL_0028:  ldc.i4.s   -2
    IL_002a:  stfld      ""int Program.<Test>d__0.<>1__state""
    IL_002f:  ldarg.0
    IL_0030:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
    IL_0035:  ldloc.2
    IL_0036:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetException(System.Exception)""
    IL_003b:  nop
    IL_003c:  leave.s    IL_0052
  }
  // sequence point: }
  IL_003e:  ldarg.0
  IL_003f:  ldc.i4.s   -2
  IL_0041:  stfld      ""int Program.<Test>d__0.<>1__state""
  // sequence point: <hidden>
  IL_0046:  ldarg.0
  IL_0047:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
  IL_004c:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetResult()""
  IL_0051:  nop
  IL_0052:  ret
}
", sequencePoints: "Program+<Test>d__0.MoveNext", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 441024, 443624);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_441381_441436(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 441381, 441436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_441453_443612(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 441453, 443612);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 441024, 443624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 441024, 443624);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void ForInAsyncMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 443636, 446528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 443783, 443962);

                var
                source = @"
using System;

class Program
{
    public static async void Test()
    {
        for (int i = 0; i > 1; i--)
            Console.WriteLine();
    }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 443976, 444040);

                var
                v = f_23129_443984_444039(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 444056, 446517);

                f_23129_444056_446516(
                            v, "Program.<Test>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()", @"
{
  // Code size       99 (0x63)
  .maxstack  3
  .locals init (int V_0,
                int V_1,
                bool V_2,
                System.Exception V_3)
  // sequence point: <hidden>
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int Program.<Test>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: {
    IL_0007:  nop
    // sequence point: int i = 0
    IL_0008:  ldarg.0
    IL_0009:  ldc.i4.0
    IL_000a:  stfld      ""int Program.<Test>d__0.<i>5__1""
    // sequence point: <hidden>
    IL_000f:  br.s       IL_0027
    // sequence point: Console.WriteLine();
    IL_0011:  call       ""void System.Console.WriteLine()""
    IL_0016:  nop
    // sequence point: i--
    IL_0017:  ldarg.0
    IL_0018:  ldfld      ""int Program.<Test>d__0.<i>5__1""
    IL_001d:  stloc.1
    IL_001e:  ldarg.0
    IL_001f:  ldloc.1
    IL_0020:  ldc.i4.1
    IL_0021:  sub
    IL_0022:  stfld      ""int Program.<Test>d__0.<i>5__1""
    // sequence point: i > 1
    IL_0027:  ldarg.0
    IL_0028:  ldfld      ""int Program.<Test>d__0.<i>5__1""
    IL_002d:  ldc.i4.1
    IL_002e:  cgt
    IL_0030:  stloc.2
    // sequence point: <hidden>
    IL_0031:  ldloc.2
    IL_0032:  brtrue.s   IL_0011
    IL_0034:  leave.s    IL_004e
  }
  catch System.Exception
  {
    // async: catch handler, sequence point: <hidden>
    IL_0036:  stloc.3
    IL_0037:  ldarg.0
    IL_0038:  ldc.i4.s   -2
    IL_003a:  stfld      ""int Program.<Test>d__0.<>1__state""
    IL_003f:  ldarg.0
    IL_0040:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
    IL_0045:  ldloc.3
    IL_0046:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetException(System.Exception)""
    IL_004b:  nop
    IL_004c:  leave.s    IL_0062
  }
  // sequence point: }
  IL_004e:  ldarg.0
  IL_004f:  ldc.i4.s   -2
  IL_0051:  stfld      ""int Program.<Test>d__0.<>1__state""
  // sequence point: <hidden>
  IL_0056:  ldarg.0
  IL_0057:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
  IL_005c:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetResult()""
  IL_0061:  nop
  IL_0062:  ret
}
", sequencePoints: "Program+<Test>d__0.MoveNext", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 443636, 446528);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_443984_444039(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 443984, 444039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_444056_446516(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 444056, 446516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 443636, 446528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 443636, 446528);
            }
        }

        [Fact]
        [WorkItem(12564, "https://github.com/dotnet/roslyn/issues/12564")]
        public void ForWithInnerLocalsInAsyncMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 446540, 449639);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 446702, 446949);

                var
                source = @"
using System;

class Program
{
    public static async void Test()
    {
        for (int i = M(out var x); i > 1; i--)
            Console.WriteLine();
    }
    public static int M(out int x) { x = 0; return 0; }
}
"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 446963, 447027);

                var
                v = f_23129_446971_447026(this, source, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 447043, 449628);

                f_23129_447043_449627(
                            v, "Program.<Test>d__0.System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()", @"
{
  // Code size      109 (0x6d)
  .maxstack  3
  .locals init (int V_0,
                int V_1,
                bool V_2,
                System.Exception V_3)
  // sequence point: <hidden>
  IL_0000:  ldarg.0
  IL_0001:  ldfld      ""int Program.<Test>d__0.<>1__state""
  IL_0006:  stloc.0
  .try
  {
    // sequence point: {
    IL_0007:  nop
    // sequence point: int i = M(out var x)
    IL_0008:  ldarg.0
    IL_0009:  ldarg.0
    IL_000a:  ldflda     ""int Program.<Test>d__0.<x>5__2""
    IL_000f:  call       ""int Program.M(out int)""
    IL_0014:  stfld      ""int Program.<Test>d__0.<i>5__1""
    // sequence point: <hidden>
    IL_0019:  br.s       IL_0031
    // sequence point: Console.WriteLine();
    IL_001b:  call       ""void System.Console.WriteLine()""
    IL_0020:  nop
    // sequence point: i--
    IL_0021:  ldarg.0
    IL_0022:  ldfld      ""int Program.<Test>d__0.<i>5__1""
    IL_0027:  stloc.1
    IL_0028:  ldarg.0
    IL_0029:  ldloc.1
    IL_002a:  ldc.i4.1
    IL_002b:  sub
    IL_002c:  stfld      ""int Program.<Test>d__0.<i>5__1""
    // sequence point: i > 1
    IL_0031:  ldarg.0
    IL_0032:  ldfld      ""int Program.<Test>d__0.<i>5__1""
    IL_0037:  ldc.i4.1
    IL_0038:  cgt
    IL_003a:  stloc.2
    // sequence point: <hidden>
    IL_003b:  ldloc.2
    IL_003c:  brtrue.s   IL_001b
    IL_003e:  leave.s    IL_0058
  }
  catch System.Exception
  {
    // async: catch handler, sequence point: <hidden>
    IL_0040:  stloc.3
    IL_0041:  ldarg.0
    IL_0042:  ldc.i4.s   -2
    IL_0044:  stfld      ""int Program.<Test>d__0.<>1__state""
    IL_0049:  ldarg.0
    IL_004a:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
    IL_004f:  ldloc.3
    IL_0050:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetException(System.Exception)""
    IL_0055:  nop
    IL_0056:  leave.s    IL_006c
  }
  // sequence point: }
  IL_0058:  ldarg.0
  IL_0059:  ldc.i4.s   -2
  IL_005b:  stfld      ""int Program.<Test>d__0.<>1__state""
  // sequence point: <hidden>
  IL_0060:  ldarg.0
  IL_0061:  ldflda     ""System.Runtime.CompilerServices.AsyncVoidMethodBuilder Program.<Test>d__0.<>t__builder""
  IL_0066:  call       ""void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.SetResult()""
  IL_006b:  nop
  IL_006c:  ret
}
", sequencePoints: "Program+<Test>d__0.MoveNext", source: source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 446540, 449639);

                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_446971_447026(Microsoft.CodeAnalysis.CSharp.UnitTests.PDB.PDBTests
                this_param, string
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = this_param.CompileAndVerify((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 446971, 447026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                f_23129_447043_449627(Microsoft.CodeAnalysis.Test.Utilities.CompilationVerifier
                this_param, string
                qualifiedMethodName, string
                expectedIL, string
                sequencePoints, string
                source)
                {
                    var return_v = this_param.VerifyIL(qualifiedMethodName, expectedIL, sequencePoints: sequencePoints, source: source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 447043, 449627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 446540, 449639);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 446540, 449639);
            }
        }

        [ConditionalFact(typeof(WindowsDesktopOnly), Reason = ConditionalSkipReason.NativePdbRequiresDesktop)]
        [WorkItem(23525, "https://github.com/dotnet/roslyn/issues/23525")]
        public void InvalidCharacterInPdbPath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 449651, 450604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 449903, 450593);
                using (var
                outStream = f_23129_449926_449950(f_23129_449926_449943(f_23129_449926_449930()))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 449984, 450024);

                    var
                    compilation = f_23129_450002_450023("")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 450042, 450194);

                    var
                    result = f_23129_450055_450193(compilation, outStream, options: f_23129_450092_450192(pdbFilePath: "test\\?.pdb", debugInformationFormat: DebugInformationFormat.Embedded))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 450214, 450249);

                    f_23129_450214_450248(f_23129_450233_450247(result));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 450267, 450578);

                    result.Diagnostics.Verify(f_23129_450482_450576(f_23129_450482_450557(f_23129_450482_450528(ErrorCode.FTL_InvalidInputFileName), "test\\?.pdb"), 1, 1));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(23129, 449903, 450593);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 449651, 450604);

                Microsoft.CodeAnalysis.Test.Utilities.TempRoot
                f_23129_449926_449930()
                {
                    var return_v = Temp;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 449926, 449930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.TempFile
                f_23129_449926_449943(Microsoft.CodeAnalysis.Test.Utilities.TempRoot
                this_param)
                {
                    var return_v = this_param.CreateFile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 449926, 449943);
                    return return_v;
                }


                System.IO.FileStream
                f_23129_449926_449950(Microsoft.CodeAnalysis.Test.Utilities.TempFile
                this_param)
                {
                    var return_v = this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 449926, 449950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_450002_450023(string
                source)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 450002, 450023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitOptions
                f_23129_450092_450192(string
                pdbFilePath, Microsoft.CodeAnalysis.Emit.DebugInformationFormat
                debugInformationFormat)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.EmitOptions(pdbFilePath: pdbFilePath, debugInformationFormat: debugInformationFormat);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 450092, 450192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitResult
                f_23129_450055_450193(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.IO.FileStream
                peStream, Microsoft.CodeAnalysis.Emit.EmitOptions
                options)
                {
                    var return_v = this_param.Emit((System.IO.Stream)peStream, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 450055, 450193);
                    return return_v;
                }


                bool
                f_23129_450233_450247(Microsoft.CodeAnalysis.Emit.EmitResult
                this_param)
                {
                    var return_v = this_param.Success;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 450233, 450247);
                    return return_v;
                }


                bool
                f_23129_450214_450248(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 450214, 450248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_450482_450528(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = Diagnostic((object)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 450482, 450528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_450482_450557(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.WithArguments(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 450482, 450557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                f_23129_450482_450576(Microsoft.CodeAnalysis.Test.Utilities.DiagnosticDescription
                this_param, int
                line, int
                column)
                {
                    var return_v = this_param.WithLocation(line, column);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 450482, 450576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 449651, 450604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 449651, 450604);
            }
        }

        [Fact]
        [WorkItem(38954, "https://github.com/dotnet/roslyn/issues/38954")]
        public void FilesOneWithNoMethodBody()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 450616, 452355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 450771, 450924);

                string
                source1 = f_23129_450788_450923(@"
using System;

class C
{
    public static void Main()
    {
        Console.WriteLine();
    }
}
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 450938, 450996);

                string
                source2 = f_23129_450955_450995(@"
// no code
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 451012, 451058);

                var
                tree1 = f_23129_451024_451057(source1, "f:/build/goo.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 451072, 451121);

                var
                tree2 = f_23129_451084_451120(source2, "f:/build/nocode.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 451135, 451216);

                var
                c = f_23129_451143_451215(new[] { tree1, tree2 }, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 451232, 452344);

                f_23129_451232_452343(
                            c, @"
<symbols>
  <files>
    <file id=""1"" name=""f:/build/goo.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""5D-7D-CF-1B-79-12-0E-0A-80-13-E0-98-7E-5C-AA-3B-63-D8-7E-4F"" />
    <file id=""2"" name=""f:/build/nocode.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""8B-1D-3F-75-E0-A8-8F-90-B2-D3-52-CF-71-9B-17-29-3C-70-7A-42"" />
  </files>
  <methods>
    <method containingType=""C"" name=""Main"">
      <customDebugInfo>
        <using>
          <namespace usingCount=""1"" />
        </using>
      </customDebugInfo>
      <sequencePoints>
        <entry offset=""0x0"" startLine=""7"" startColumn=""5"" endLine=""7"" endColumn=""6"" document=""1"" />
        <entry offset=""0x1"" startLine=""8"" startColumn=""9"" endLine=""8"" endColumn=""29"" document=""1"" />
        <entry offset=""0x7"" startLine=""9"" startColumn=""5"" endLine=""9"" endColumn=""6"" document=""1"" />
      </sequencePoints>
      <scope startOffset=""0x0"" endOffset=""0x8"">
        <namespace name=""System"" />
      </scope>
    </method>
  </methods>
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 450616, 452355);

                string
                f_23129_450788_450923(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 450788, 450923);
                    return return_v;
                }


                string
                f_23129_450955_450995(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 450955, 450995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_451024_451057(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 451024, 451057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_451084_451120(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 451084, 451120);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_451143_451215(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 451143, 451215);
                    return return_v;
                }


                bool
                f_23129_451232_452343(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 451232, 452343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 450616, 452355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 450616, 452355);
            }
        }

        [Fact]
        [WorkItem(38954, "https://github.com/dotnet/roslyn/issues/38954")]
        public void SingleFileWithNoMethodBody()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(23129, 452367, 453005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 452524, 452581);

                string
                source = f_23129_452540_452580(@"
// no code
")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 452597, 452644);

                var
                tree = f_23129_452608_452643(source, "f:/build/nocode.cs")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 452658, 452731);

                var
                c = f_23129_452666_452730(new[] { tree }, options: TestOptions.DebugDll)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 452747, 452994);

                f_23129_452747_452993(
                            c, @"
<symbols>
  <files>
    <file id=""1"" name=""f:/build/nocode.cs"" language=""C#"" checksumAlgorithm=""SHA1"" checksum=""8B-1D-3F-75-E0-A8-8F-90-B2-D3-52-CF-71-9B-17-29-3C-70-7A-42"" />
  </files>
  <methods />
</symbols>
");
                DynAbs.Tracing.TraceSender.TraceExitMethod(23129, 452367, 453005);

                string
                f_23129_452540_452580(string
                source)
                {
                    var return_v = WithWindowsLineBreaks(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 452540, 452580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_23129_452608_452643(string
                text, string
                filename)
                {
                    var return_v = Parse(text, filename);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 452608, 452643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_23129_452666_452730(Microsoft.CodeAnalysis.SyntaxTree[]
                source, Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                options)
                {
                    var return_v = CreateCompilation((Microsoft.CodeAnalysis.CSharp.Test.Utilities.CSharpTestSource)source, options: options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 452666, 452730);
                    return return_v;
                }


                bool
                f_23129_452747_452993(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                expectedPdb)
                {
                    var return_v = compilation.VerifyPdb(expectedPdb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(23129, 452747, 452993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(23129, 452367, 453005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 452367, 453005);
            }
        }

        public PDBTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(23129, 822, 453012);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(23129, 822, 453012);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 822, 453012);
        }


        static PDBTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(23129, 822, 453012);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(23129, 924, 990);
            s_valueTupleRefs = new[] { f_23129_951_973(), f_23129_975_988() }; DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(23129, 822, 453012);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(23129, 822, 453012);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(23129, 822, 453012);

        static Microsoft.CodeAnalysis.MetadataReference
        f_23129_951_973()
        {
            var return_v = SystemRuntimeFacadeRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 951, 973);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataReference
        f_23129_975_988()
        {
            var return_v = ValueTupleRef;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(23129, 975, 988);
            return return_v;
        }

    }
}
