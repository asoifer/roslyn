// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection.Metadata;
using Roslyn.Utilities;
using static System.Linq.ImmutableArrayExtensions;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal partial class ILBuilder
    {
        internal void AdjustStack(int stackAdjustment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 534, 656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 605, 645);

                _emitState.AdjustStack(stackAdjustment);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 534, 656);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 534, 656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 534, 656);
            }
        }

        internal bool IsStackEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 719, 759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 725, 757);

                    return _emitState.CurStack == 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(58, 719, 759);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 668, 770);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 668, 770);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void EmitOpCode(ILOpCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 782, 904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 846, 893);

                f_58_846_892(this, code, f_58_868_891(code));
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 782, 904);

                int
                f_58_868_891(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = opcode.NetStackBehavior();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 868, 891);
                    return return_v;
                }


                int
                f_58_846_892(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 846, 892);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 782, 904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 782, 904);
            }
        }

        internal void EmitOpCode(ILOpCode code, int stackAdjustment)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 916, 1331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 1001, 1161);

                f_58_1001_1160(!f_58_1015_1039(code), "Control transferring opcodes should not be emitted directly. Use special methods such as EmitRet().");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 1177, 1220);

                f_58_1177_1219(f_58_1189_1212(this), code);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 1236, 1276);

                _emitState.AdjustStack(stackAdjustment);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 1290, 1320);

                _emitState.InstructionAdded();
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 916, 1331);

                bool
                f_58_1015_1039(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = opcode.IsControlTransfer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 1015, 1039);
                    return return_v;
                }


                int
                f_58_1001_1160(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 1001, 1160);
                    return 0;
                }


                System.Reflection.Metadata.BlobBuilder
                f_58_1189_1212(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 1189, 1212);
                    return return_v;
                }


                int
                f_58_1177_1219(System.Reflection.Metadata.BlobBuilder
                writer, System.Reflection.Metadata.ILOpCode
                code)
                {
                    WriteOpCode(writer, code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 1177, 1219);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 916, 1331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 916, 1331);
            }
        }

        internal void EmitToken(string value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 1343, 1535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 1405, 1467);

                uint
                token = f_58_1418_1456_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(module, 58, 1418, 1456)?.GetFakeStringTokenForIL(value)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<uint?>(58, 1418, 1466) ?? 0xFFFF)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 1481, 1524);

                f_58_1481_1523(f_58_1481_1504(this), token);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 1343, 1535);

                uint?
                f_58_1418_1456_I(uint?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 1418, 1456);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_58_1481_1504(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 1481, 1504);
                    return return_v;
                }


                int
                f_58_1481_1523(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 1481, 1523);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 1343, 1535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 1343, 1535);
            }
        }

        internal void EmitToken(Cci.IReference value, SyntaxNode syntaxNode, DiagnosticBag diagnostics, bool encodeAsRawToken = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 1547, 2117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 1698, 1785);

                uint
                token = f_58_1711_1774_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(module, 58, 1711, 1774)?.GetFakeSymbolTokenForIL(value, syntaxNode, diagnostics)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<uint?>(58, 1711, 1784) ?? 0xFFFF)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 1923, 2049) || true) && (encodeAsRawToken)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 1923, 2049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 1977, 2034);

                    token |= Cci.MetadataWriter.LiteralMethodDefinitionToken;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 1923, 2049);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 2063, 2106);

                f_58_2063_2105(f_58_2063_2086(this), token);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 1547, 2117);

                uint?
                f_58_1711_1774_I(uint?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 1711, 1774);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_58_2063_2086(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 2063, 2086);
                    return return_v;
                }


                int
                f_58_2063_2105(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 2063, 2105);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 1547, 2117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 1547, 2117);
            }
        }

        internal void EmitToken(Cci.ISignature value, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 2129, 2404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 2249, 2336);

                uint
                token = f_58_2262_2325_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(module, 58, 2262, 2325)?.GetFakeSymbolTokenForIL(value, syntaxNode, diagnostics)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<uint?>(58, 2262, 2335) ?? 0xFFFF)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 2350, 2393);

                f_58_2350_2392(f_58_2350_2373(this), token);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 2129, 2404);

                uint?
                f_58_2262_2325_I(uint?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 2262, 2325);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_58_2350_2373(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 2350, 2373);
                    return return_v;
                }


                int
                f_58_2350_2392(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 2350, 2392);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 2129, 2404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 2129, 2404);
            }
        }

        internal void EmitGreatestMethodToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 2416, 2713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 2609, 2702);

                f_58_2609_2701(f_58_2609_2632(            // A magic value indicates that the token value is to be the literal value of the greatest method definition token.
                            this), Cci.MetadataWriter.LiteralGreatestMethodDefinitionToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 2416, 2713);

                System.Reflection.Metadata.BlobBuilder
                f_58_2609_2632(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 2609, 2632);
                    return return_v;
                }


                int
                f_58_2609_2701(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 2609, 2701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 2416, 2713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 2416, 2713);
            }
        }

        internal void EmitModuleVersionIdStringToken()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 2725, 3031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 2937, 3020);

                f_58_2937_3019(f_58_2937_2960(            // A magic value indicates that the token value is to refer to a string constant for the spelling of the current module's MVID.
                            this), Cci.MetadataWriter.ModuleVersionIdStringToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 2725, 3031);

                System.Reflection.Metadata.BlobBuilder
                f_58_2937_2960(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 2937, 2960);
                    return return_v;
                }


                int
                f_58_2937_3019(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 2937, 3019);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 2725, 3031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 2725, 3031);
            }
        }

        internal void EmitSourceDocumentIndexToken(Cci.DebugSourceDocument document)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 3043, 3291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 3144, 3280);

                f_58_3144_3279(f_58_3144_3167(this), (f_58_3181_3226_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(module, 58, 3181, 3226)?.GetSourceDocumentIndexForIL(document)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<uint?>(58, 3181, 3236) ?? 0xFFFF)) | Cci.MetadataWriter.SourceDocumentIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 3043, 3291);

                System.Reflection.Metadata.BlobBuilder
                f_58_3144_3167(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3144, 3167);
                    return return_v;
                }


                uint?
                f_58_3181_3226_I(uint?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3181, 3226);
                    return return_v;
                }


                int
                f_58_3144_3279(System.Reflection.Metadata.BlobBuilder
                this_param, uint
                value)
                {
                    this_param.WriteUInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3144, 3279);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 3043, 3291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 3043, 3291);
            }
        }

        internal void EmitArrayBlockInitializer(ImmutableArray<byte> data, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 3303, 4013);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 3472, 3522);

                var
                initializeArray = f_58_3494_3521(module)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 3619, 3685);

                var
                field = f_58_3631_3684(module, data, syntaxNode, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 3741, 3766);

                f_58_3741_3765(this, ILOpCode.Dup);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 3794, 3823);

                f_58_3794_3822(this, ILOpCode.Ldtoken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 3837, 3879);

                f_58_3837_3878(this, field, syntaxNode, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 3906, 3936);

                f_58_3906_3935(this, ILOpCode.Call, -2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 3950, 4002);

                f_58_3950_4001(this, initializeArray, syntaxNode, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 3303, 4013);

                Microsoft.Cci.IMethodReference
                f_58_3494_3521(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param)
                {
                    var return_v = this_param.GetInitArrayHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3494, 3521);
                    return return_v;
                }


                Microsoft.Cci.IFieldReference
                f_58_3631_3684(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                data, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetFieldForData(data, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3631, 3684);
                    return return_v;
                }


                int
                f_58_3741_3765(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3741, 3765);
                    return 0;
                }


                int
                f_58_3794_3822(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3794, 3822);
                    return 0;
                }


                int
                f_58_3837_3878(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IFieldReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.IReference)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3837, 3878);
                    return 0;
                }


                int
                f_58_3906_3935(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3906, 3935);
                    return 0;
                }


                int
                f_58_3950_4001(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IMethodReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.ISignature)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 3950, 4001);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 3303, 4013);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 3303, 4013);
            }
        }

        internal void EmitStackAllocBlockInitializer(ImmutableArray<byte> data, SyntaxNode syntaxNode, bool emitInitBlock, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 4025, 4886);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4191, 4875) || true) && (emitInitBlock)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 4191, 4875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4314, 4339);

                    f_58_4314_4338(this, ILOpCode.Dup);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4357, 4382);

                    f_58_4357_4381(this, data[0]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4400, 4429);

                    f_58_4400_4428(this, data.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4447, 4480);

                    f_58_4447_4479(this, ILOpCode.Initblk, -3);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 4191, 4875);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 4191, 4875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4546, 4612);

                    var
                    field = f_58_4558_4611(module, data, syntaxNode, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4632, 4657);

                    f_58_4632_4656(this, ILOpCode.Dup);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4675, 4704);

                    f_58_4675_4703(this, ILOpCode.Ldsflda);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4722, 4764);

                    f_58_4722_4763(this, field, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4782, 4811);

                    f_58_4782_4810(this, data.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 4829, 4860);

                    f_58_4829_4859(this, ILOpCode.Cpblk, -3);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 4191, 4875);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 4025, 4886);

                int
                f_58_4314_4338(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4314, 4338);
                    return 0;
                }


                int
                f_58_4357_4381(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, byte
                value)
                {
                    this_param.EmitIntConstant((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4357, 4381);
                    return 0;
                }


                int
                f_58_4400_4428(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4400, 4428);
                    return 0;
                }


                int
                f_58_4447_4479(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4447, 4479);
                    return 0;
                }


                Microsoft.Cci.IFieldReference
                f_58_4558_4611(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                data, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetFieldForData(data, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4558, 4611);
                    return return_v;
                }


                int
                f_58_4632_4656(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4632, 4656);
                    return 0;
                }


                int
                f_58_4675_4703(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4675, 4703);
                    return 0;
                }


                int
                f_58_4722_4763(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IFieldReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.IReference)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4722, 4763);
                    return 0;
                }


                int
                f_58_4782_4810(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4782, 4810);
                    return 0;
                }


                int
                f_58_4829_4859(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 4829, 4859);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 4025, 4886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 4025, 4886);
            }
        }

        internal void EmitArrayBlockFieldRef(ImmutableArray<byte> data, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 4898, 5283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 5105, 5171);

                var
                field = f_58_5117_5170(module, data, syntaxNode, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 5187, 5216);

                f_58_5187_5215(this, ILOpCode.Ldsflda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 5230, 5272);

                f_58_5230_5271(this, field, syntaxNode, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 4898, 5283);

                Microsoft.Cci.IFieldReference
                f_58_5117_5170(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                data, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetFieldForData(data, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 5117, 5170);
                    return return_v;
                }


                int
                f_58_5187_5215(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 5187, 5215);
                    return 0;
                }


                int
                f_58_5230_5271(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.Cci.IFieldReference
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.IReference)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 5230, 5271);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 4898, 5283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 4898, 5283);
            }
        }

        internal void MarkLabel(object label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 5393, 8586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 5455, 5466);

                f_58_5455_5465(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 5482, 5517);

                var
                block = f_58_5494_5516(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 6345, 6365);

                LabelInfo
                labelInfo
                = default(LabelInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 6379, 8497) || true) && (f_58_6383_6428(_labelInfos, label, out labelInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 6379, 8497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 6462, 6525);

                    f_58_6462_6524(labelInfo.bb == null, "duplicate use of a label");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 6543, 6576);

                    int
                    labelStack = labelInfo.stack
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 6596, 6631);

                    var
                    curStack = _emitState.CurStack
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 7260, 7360);

                    f_58_7260_7359(curStack == labelStack, "forward branches and fall-through must agree on stack depth");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 7380, 7432);

                    _labelInfos[label] = labelInfo.WithNewTarget(block);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 6379, 8497);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 6379, 8497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 8370, 8405);

                    var
                    curStack = _emitState.CurStack
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 8423, 8482);

                    _labelInfos[label] = f_58_8444_8481(block, curStack, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 6379, 8497);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 8513, 8575);

                _instructionCountAtLastLabel = _emitState.InstructionsEmitted;
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 5393, 8586);

                int
                f_58_5455_5465(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 5455, 5465);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_58_5494_5516(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 5494, 5516);
                    return return_v;
                }


                bool
                f_58_6383_6428(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                this_param, object
                key, out Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 6383, 6428);
                    return return_v;
                }


                int
                f_58_6462_6524(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 6462, 6524);
                    return 0;
                }


                int
                f_58_7260_7359(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 7260, 7359);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                f_58_8444_8481(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                bb, int
                stack, bool
                targetOfConditionalBranches)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo(bb, stack, targetOfConditionalBranches);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 8444, 8481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 5393, 8586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 5393, 8586);
            }
        }

        internal void EmitBranch(ILOpCode code, object label, ILOpCode revOpCode = ILOpCode.Nop)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 8598, 9966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 8711, 8772);

                bool
                validOpCode = (code == ILOpCode.Nop) || (DynAbs.Tracing.TraceSender.Expression_False(58, 8730, 8771) || f_58_8756_8771(code))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 8788, 8814);

                f_58_8788_8813(validOpCode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 8828, 8892);

                f_58_8828_8891(revOpCode == ILOpCode.Nop || (DynAbs.Tracing.TraceSender.Expression_False(58, 8841, 8890) || f_58_8870_8890(revOpCode)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 8906, 8953);

                f_58_8906_8952(!f_58_8920_8951(code));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 8969, 9017);

                _emitState.AdjustStack(f_58_8992_9015(code));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9033, 9081);

                bool
                isConditional = f_58_9054_9080(code)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9097, 9117);

                LabelInfo
                labelInfo
                = default(LabelInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9131, 9471) || true) && (!f_58_9136_9181(_labelInfos, label, out labelInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 9131, 9471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9215, 9289);

                    f_58_9215_9288(_labelInfos, label, f_58_9238_9287(_emitState.CurStack, isConditional));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 9131, 9471);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 9131, 9471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9355, 9456);

                    f_58_9355_9455(labelInfo.stack == _emitState.CurStack, "branches to same label with different stacks");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 9131, 9471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9487, 9522);

                var
                block = f_58_9499_9521(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9675, 9748);

                f_58_9675_9747((code != ILOpCode.Nop) || (DynAbs.Tracing.TraceSender.Expression_False(58, 9688, 9746) || (block == _labelInfos[label].bb)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9764, 9804);

                f_58_9764_9803(
                            block, label, code, revOpCode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9820, 9923) || true) && (code != ILOpCode.Nop)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 9820, 9923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9878, 9908);

                    _emitState.InstructionAdded();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 9820, 9923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 9939, 9955);

                f_58_9939_9954(
                            this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 8598, 9966);

                bool
                f_58_8756_8771(System.Reflection.Metadata.ILOpCode
                opCode)
                {
                    var return_v = opCode.IsBranch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 8756, 8771);
                    return return_v;
                }


                int
                f_58_8788_8813(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 8788, 8813);
                    return 0;
                }


                bool
                f_58_8870_8890(System.Reflection.Metadata.ILOpCode
                opCode)
                {
                    var return_v = opCode.IsBranch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 8870, 8890);
                    return return_v;
                }


                int
                f_58_8828_8891(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 8828, 8891);
                    return 0;
                }


                bool
                f_58_8920_8951(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = opcode.HasVariableStackBehavior();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 8920, 8951);
                    return return_v;
                }


                int
                f_58_8906_8952(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 8906, 8952);
                    return 0;
                }


                int
                f_58_8992_9015(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = opcode.NetStackBehavior();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 8992, 9015);
                    return return_v;
                }


                bool
                f_58_9054_9080(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = opcode.IsConditionalBranch();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 9054, 9080);
                    return return_v;
                }


                bool
                f_58_9136_9181(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                this_param, object
                key, out Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 9136, 9181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                f_58_9238_9287(int
                stack, bool
                targetOfConditionalBranches)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo(stack, targetOfConditionalBranches);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 9238, 9287);
                    return return_v;
                }


                int
                f_58_9215_9288(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                this_param, object
                key, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 9215, 9288);
                    return 0;
                }


                int
                f_58_9355_9455(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 9355, 9455);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_58_9499_9521(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 9499, 9521);
                    return return_v;
                }


                int
                f_58_9675_9747(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 9675, 9747);
                    return 0;
                }


                int
                f_58_9764_9803(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, object
                newLabel, System.Reflection.Metadata.ILOpCode
                branchCode, System.Reflection.Metadata.ILOpCode
                revBranchCode)
                {
                    this_param.SetBranch(newLabel, branchCode, revBranchCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 9764, 9803);
                    return 0;
                }


                int
                f_58_9939_9954(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 9939, 9954);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 8598, 9966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 8598, 9966);
            }
        }

        internal void EmitStringSwitchJumpTable(
                    KeyValuePair<ConstantValue, object>[] caseLabels,
                    object fallThroughLabel,
                    LocalOrParameter key,
                    LocalDefinition? keyHash,
                    SwitchStringJumpTableEmitter.EmitStringCompareAndBranch emitStringCondBranchDelegate,
                    SwitchStringJumpTableEmitter.GetStringHashCode computeStringHashcodeDelegate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 11026, 11837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 11456, 11492);

                f_58_11456_11491(f_58_11469_11486(caseLabels) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 11508, 11786);

                var
                emitter = f_58_11522_11785(this, key, caseLabels, fallThroughLabel, keyHash, emitStringCondBranchDelegate, computeStringHashcodeDelegate)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 11802, 11826);

                emitter.EmitJumpTable();
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 11026, 11837);

                int
                f_58_11469_11486(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 11469, 11486);
                    return return_v;
                }


                int
                f_58_11456_11491(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 11456, 11491);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.SwitchStringJumpTableEmitter
                f_58_11522_11785(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                key, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                caseLabels, object
                fallThroughLabel, Microsoft.CodeAnalysis.CodeGen.LocalDefinition?
                keyHash, Microsoft.CodeAnalysis.CodeGen.SwitchStringJumpTableEmitter.EmitStringCompareAndBranch
                emitStringCondBranchDelegate, Microsoft.CodeAnalysis.CodeGen.SwitchStringJumpTableEmitter.GetStringHashCode
                computeStringHashcodeDelegate)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SwitchStringJumpTableEmitter(builder, key, caseLabels, fallThroughLabel, keyHash, emitStringCondBranchDelegate, computeStringHashcodeDelegate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 11522, 11785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 11026, 11837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 11026, 11837);
            }
        }

        internal void EmitIntegerSwitchJumpTable(
                    KeyValuePair<ConstantValue, object>[] caseLabels,
                    object fallThroughLabel,
                    LocalOrParameter key,
                    Cci.PrimitiveTypeCode keyTypeCode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 12380, 13266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 12630, 12666);

                f_58_12630_12665(f_58_12643_12660(caseLabels) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 12680, 12738);

                f_58_12680_12737(keyTypeCode != Cci.PrimitiveTypeCode.String);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13114, 13217);

                var
                emitter = f_58_13128_13216(this, caseLabels, fallThroughLabel, keyTypeCode, key)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13231, 13255);

                emitter.EmitJumpTable();
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 12380, 13266);

                int
                f_58_12643_12660(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 12643, 12660);
                    return return_v;
                }


                int
                f_58_12630_12665(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 12630, 12665);
                    return 0;
                }


                int
                f_58_12680_12737(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 12680, 12737);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter
                f_58_13128_13216(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                builder, System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.ConstantValue, object>[]
                caseLabels, object
                fallThroughLabel, Microsoft.Cci.PrimitiveTypeCode
                keyTypeCode, Microsoft.CodeAnalysis.CodeGen.LocalOrParameter
                key)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SwitchIntegralJumpTableEmitter(builder, caseLabels, fallThroughLabel, keyTypeCode, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 13128, 13216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 12380, 13266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 12380, 13266);
            }
        }

        internal void EmitSwitch(object[] labels)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 13336, 14273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13402, 13429);

                _emitState.AdjustStack(-1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13443, 13478);

                int
                curStack = _emitState.CurStack
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13494, 14117);
                    foreach (object label in f_58_13519_13525_I(labels))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 13494, 14117);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13559, 13572);

                        LabelInfo
                        ld
                        = default(LabelInfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13590, 14102) || true) && (!f_58_13595_13633(_labelInfos, label, out ld))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 13590, 14102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13675, 13729);

                            f_58_13675_13728(_labelInfos, label, f_58_13698_13727(curStack, true));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(58, 13590, 14102);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 13590, 14102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13811, 13894);

                            f_58_13811_13893(ld.stack == curStack, "branches to same label with different stacks");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 13918, 14083) || true) && (!ld.targetOfConditionalBranches)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 13918, 14083);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14003, 14060);

                                _labelInfos[label] = ld.SetTargetOfConditionalBranches();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(58, 13918, 14083);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(58, 13590, 14102);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 13494, 14117);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(58, 1, 624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(58, 1, 624);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14133, 14184);

                SwitchBlock
                switchBlock = f_58_14159_14183(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14198, 14232);

                switchBlock.BranchLabels = labels;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14246, 14262);

                f_58_14246_14261(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 13336, 14273);

                bool
                f_58_13595_13633(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                this_param, object
                key, out Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 13595, 13633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                f_58_13698_13727(int
                stack, bool
                targetOfConditionalBranches)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo(stack, targetOfConditionalBranches);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 13698, 13727);
                    return return_v;
                }


                int
                f_58_13675_13728(Microsoft.CodeAnalysis.SmallDictionary<object, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo>
                this_param, object
                key, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LabelInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 13675, 13728);
                    return 0;
                }


                int
                f_58_13811_13893(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 13811, 13893);
                    return 0;
                }


                object[]
                f_58_13519_13525_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 13519, 13525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                f_58_14159_14183(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.CreateSwitchBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 14159, 14183);
                    return return_v;
                }


                int
                f_58_14246_14261(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 14246, 14261);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 13336, 14273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 13336, 14273);
            }
        }

        internal void EmitRet(bool isVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 14285, 14736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14408, 14447);

                f_58_14408_14446(f_58_14421_14445_M(!this.InExceptionHandler));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14463, 14550) || true) && (!isVoid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 14463, 14550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14508, 14535);

                    _emitState.AdjustStack(-1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 14463, 14550);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14566, 14601);

                var
                block = f_58_14578_14600(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14615, 14649);

                f_58_14615_14648(block, ILOpCode.Ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14665, 14695);

                _emitState.InstructionAdded();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14709, 14725);

                f_58_14709_14724(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 14285, 14736);

                bool
                f_58_14421_14445_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 14421, 14445);
                    return return_v;
                }


                int
                f_58_14408_14446(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 14408, 14446);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_58_14578_14600(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 14578, 14600);
                    return return_v;
                }


                int
                f_58_14615_14648(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, System.Reflection.Metadata.ILOpCode
                newBranchCode)
                {
                    this_param.SetBranchCode(newBranchCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 14615, 14648);
                    return 0;
                }


                int
                f_58_14709_14724(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 14709, 14724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 14285, 14736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 14285, 14736);
            }
        }

        internal void EmitThrow(bool isRethrow)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 14748, 15195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14812, 14847);

                var
                block = f_58_14824_14846(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14861, 15108) || true) && (isRethrow)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 14861, 15108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 14908, 14946);

                    f_58_14908_14945(block, ILOpCode.Rethrow);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 14861, 15108);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 14861, 15108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15012, 15048);

                    f_58_15012_15047(block, ILOpCode.Throw);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15066, 15093);

                    _emitState.AdjustStack(-1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 14861, 15108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15124, 15154);

                _emitState.InstructionAdded();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15168, 15184);

                f_58_15168_15183(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 14748, 15195);

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_58_14824_14846(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 14824, 14846);
                    return return_v;
                }


                int
                f_58_14908_14945(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, System.Reflection.Metadata.ILOpCode
                newBranchCode)
                {
                    this_param.SetBranchCode(newBranchCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 14908, 14945);
                    return 0;
                }


                int
                f_58_15012_15047(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, System.Reflection.Metadata.ILOpCode
                newBranchCode)
                {
                    this_param.SetBranchCode(newBranchCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 15012, 15047);
                    return 0;
                }


                int
                f_58_15168_15183(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 15168, 15183);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 14748, 15195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 14748, 15195);
            }
        }

        private void EmitEndFinally()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 15207, 15392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15261, 15296);

                var
                block = f_58_15273_15295(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15310, 15351);

                f_58_15310_15350(block, ILOpCode.Endfinally);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15365, 15381);

                f_58_15365_15380(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 15207, 15392);

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_58_15273_15295(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 15273, 15295);
                    return return_v;
                }


                int
                f_58_15310_15350(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, System.Reflection.Metadata.ILOpCode
                newBranchCode)
                {
                    this_param.SetBranchCode(newBranchCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 15310, 15350);
                    return 0;
                }


                int
                f_58_15365_15380(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 15365, 15380);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 15207, 15392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 15207, 15392);
            }
        }

        private BasicBlock FinishFilterCondition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 15596, 15822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15663, 15698);

                var
                block = f_58_15675_15697(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15712, 15752);

                f_58_15712_15751(block, ILOpCode.Endfilter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15766, 15782);

                f_58_15766_15781(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 15798, 15811);

                return block;
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 15596, 15822);

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_58_15675_15697(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 15675, 15697);
                    return return_v;
                }


                int
                f_58_15712_15751(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param, System.Reflection.Metadata.ILOpCode
                newBranchCode)
                {
                    this_param.SetBranchCode(newBranchCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 15712, 15751);
                    return 0;
                }


                int
                f_58_15766_15781(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 15766, 15781);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 15596, 15822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 15596, 15822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void EmitArrayCreation(Microsoft.Cci.IArrayTypeReference arrayType, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 15960, 16458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 16111, 16198);

                f_58_16111_16197(f_58_16124_16144_M(!arrayType.IsSZArray), "should be used only with multidimensional arrays");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 16214, 16276);

                var
                ctor = f_58_16225_16275(f_58_16225_16244(module), arrayType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 16329, 16387);

                f_58_16329_16386(
                            // idx1, idx2 --> array
                            this, ILOpCode.Newobj, 1 - (int)f_58_16371_16385(arrayType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 16401, 16447);

                f_58_16401_16446(this, ctor, syntaxNode, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 15960, 16458);

                bool
                f_58_16124_16144_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 16124, 16144);
                    return return_v;
                }


                int
                f_58_16111_16197(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 16111, 16197);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                f_58_16225_16244(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param)
                {
                    var return_v = this_param.ArrayMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 16225, 16244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                f_58_16225_16275(Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayType)
                {
                    var return_v = this_param.GetArrayConstructor(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 16225, 16275);
                    return return_v;
                }


                int
                f_58_16371_16385(Microsoft.Cci.IArrayTypeReference
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 16371, 16385);
                    return return_v;
                }


                int
                f_58_16329_16386(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 16329, 16386);
                    return 0;
                }


                int
                f_58_16401_16446(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.ISignature)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 16401, 16446);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 15960, 16458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 15960, 16458);
            }
        }

        internal void EmitArrayElementLoad(Microsoft.Cci.IArrayTypeReference arrayType, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 16595, 17089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 16749, 16836);

                f_58_16749_16835(f_58_16762_16782_M(!arrayType.IsSZArray), "should be used only with multidimensional arrays");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 16852, 16906);

                var
                load = f_58_16863_16905(f_58_16863_16882(module), arrayType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 16965, 17018);

                f_58_16965_17017(
                            // this, idx1, idx2 --> value
                            this, ILOpCode.Call, -(int)f_58_17002_17016(arrayType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 17032, 17078);

                f_58_17032_17077(this, load, syntaxNode, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 16595, 17089);

                bool
                f_58_16762_16782_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 16762, 16782);
                    return return_v;
                }


                int
                f_58_16749_16835(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 16749, 16835);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                f_58_16863_16882(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param)
                {
                    var return_v = this_param.ArrayMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 16863, 16882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                f_58_16863_16905(Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayType)
                {
                    var return_v = this_param.GetArrayGet(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 16863, 16905);
                    return return_v;
                }


                int
                f_58_17002_17016(Microsoft.Cci.IArrayTypeReference
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 17002, 17016);
                    return return_v;
                }


                int
                f_58_16965_17017(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 16965, 17017);
                    return 0;
                }


                int
                f_58_17032_17077(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.ISignature)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 17032, 17077);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 16595, 17089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 16595, 17089);
            }
        }

        internal void EmitArrayElementAddress(Microsoft.Cci.IArrayTypeReference arrayType, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 17241, 17749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 17398, 17485);

                f_58_17398_17484(f_58_17411_17431_M(!arrayType.IsSZArray), "should be used only with multidimensional arrays");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 17501, 17562);

                var
                address = f_58_17515_17561(f_58_17515_17534(module), arrayType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 17622, 17675);

                f_58_17622_17674(
                            // this, idx1, idx2 --> &value
                            this, ILOpCode.Call, -(int)f_58_17659_17673(arrayType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 17689, 17738);

                f_58_17689_17737(this, address, syntaxNode, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 17241, 17749);

                bool
                f_58_17411_17431_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 17411, 17431);
                    return return_v;
                }


                int
                f_58_17398_17484(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 17398, 17484);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                f_58_17515_17534(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param)
                {
                    var return_v = this_param.ArrayMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 17515, 17534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                f_58_17515_17561(Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayType)
                {
                    var return_v = this_param.GetArrayAddress(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 17515, 17561);
                    return return_v;
                }


                int
                f_58_17659_17673(Microsoft.Cci.IArrayTypeReference
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 17659, 17673);
                    return return_v;
                }


                int
                f_58_17622_17674(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 17622, 17674);
                    return 0;
                }


                int
                f_58_17689_17737(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.ISignature)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 17689, 17737);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 17241, 17749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 17241, 17749);
            }
        }

        internal void EmitArrayElementStore(Cci.IArrayTypeReference arrayType, SyntaxNode syntaxNode, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 17888, 18387);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18033, 18120);

                f_58_18033_18119(f_58_18046_18066_M(!arrayType.IsSZArray), "should be used only with multidimensional arrays");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18136, 18191);

                var
                store = f_58_18148_18190(f_58_18148_18167(module), arrayType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18256, 18315);

                f_58_18256_18314(
                            // this, idx1, idx2, value --> void
                            this, ILOpCode.Call, -(2 + (int)f_58_18298_18312(arrayType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18329, 18376);

                f_58_18329_18375(this, store, syntaxNode, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 17888, 18387);

                bool
                f_58_18046_18066_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 18046, 18066);
                    return return_v;
                }


                int
                f_58_18033_18119(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 18033, 18119);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                f_58_18148_18167(Microsoft.CodeAnalysis.CodeGen.ITokenDeferral
                this_param)
                {
                    var return_v = this_param.ArrayMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 18148, 18167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                f_58_18148_18190(Microsoft.CodeAnalysis.CodeGen.ArrayMethods
                this_param, Microsoft.Cci.IArrayTypeReference
                arrayType)
                {
                    var return_v = this_param.GetArraySet(arrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 18148, 18190);
                    return return_v;
                }


                int
                f_58_18298_18312(Microsoft.Cci.IArrayTypeReference
                this_param)
                {
                    var return_v = this_param.Rank;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 18298, 18312);
                    return return_v;
                }


                int
                f_58_18256_18314(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code, int
                stackAdjustment)
                {
                    this_param.EmitOpCode(code, stackAdjustment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 18256, 18314);
                    return 0;
                }


                int
                f_58_18329_18375(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.ArrayMethod
                value, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.EmitToken((Microsoft.Cci.ISignature)value, syntaxNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 18329, 18375);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 17888, 18387);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 17888, 18387);
            }
        }

        internal void EmitLoad(LocalOrParameter localOrParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 18399, 18735);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18481, 18724) || true) && (localOrParameter.Local != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 18481, 18724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18549, 18587);

                    f_58_18549_18586(this, localOrParameter.Local);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 18481, 18724);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 18481, 18724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18653, 18709);

                    f_58_18653_18708(this, localOrParameter.ParameterIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 18481, 18724);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 18399, 18735);

                int
                f_58_18549_18586(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 18549, 18586);
                    return 0;
                }


                int
                f_58_18653_18708(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                argNumber)
                {
                    this_param.EmitLoadArgumentOpcode(argNumber);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 18653, 18708);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 18399, 18735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 18399, 18735);
            }
        }

        internal void EmitLocalLoad(LocalDefinition local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 18818, 19655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18893, 18920);

                var
                slot = f_58_18904_18919(local)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18934, 19644);

                switch (slot)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 18934, 19644);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 18988, 19017);

                        f_58_18988_19016(this, ILOpCode.Ldloc_0);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 19018, 19024);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 18934, 19644);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 18934, 19644);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19050, 19079);

                        f_58_19050_19078(this, ILOpCode.Ldloc_1);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 19080, 19086);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 18934, 19644);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 18934, 19644);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19112, 19141);

                        f_58_19112_19140(this, ILOpCode.Ldloc_2);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 19142, 19148);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 18934, 19644);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 18934, 19644);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19174, 19203);

                        f_58_19174_19202(this, ILOpCode.Ldloc_3);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 19204, 19210);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 18934, 19644);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 18934, 19644);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19258, 19601) || true) && (slot < 0xFF)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 19258, 19601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19323, 19352);

                            f_58_19323_19351(this, ILOpCode.Ldloc_s);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19378, 19411);

                            f_58_19378_19410(this, unchecked((sbyte)slot));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(58, 19258, 19601);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 19258, 19601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19509, 19536);

                            f_58_19509_19535(this, ILOpCode.Ldloc);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19562, 19578);

                            f_58_19562_19577(this, slot);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(58, 19258, 19601);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 19623, 19629);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 18934, 19644);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 18818, 19655);

                int
                f_58_18904_18919(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 18904, 18919);
                    return return_v;
                }


                int
                f_58_18988_19016(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 18988, 19016);
                    return 0;
                }


                int
                f_58_19050_19078(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 19050, 19078);
                    return 0;
                }


                int
                f_58_19112_19140(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 19112, 19140);
                    return 0;
                }


                int
                f_58_19174_19202(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 19174, 19202);
                    return 0;
                }


                int
                f_58_19323_19351(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 19323, 19351);
                    return 0;
                }


                int
                f_58_19378_19410(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int8)
                {
                    this_param.EmitInt8((sbyte)int8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 19378, 19410);
                    return 0;
                }


                int
                f_58_19509_19535(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 19509, 19535);
                    return 0;
                }


                int
                f_58_19562_19577(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int32)
                {
                    this_param.EmitInt32(int32);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 19562, 19577);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 18818, 19655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 18818, 19655);
            }
        }

        internal void EmitLocalStore(LocalDefinition local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 19739, 20577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19815, 19842);

                var
                slot = f_58_19826_19841(local)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19856, 20566);

                switch (slot)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 19856, 20566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19910, 19939);

                        f_58_19910_19938(this, ILOpCode.Stloc_0);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 19940, 19946);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 19856, 20566);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 19856, 20566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 19972, 20001);

                        f_58_19972_20000(this, ILOpCode.Stloc_1);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 20002, 20008);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 19856, 20566);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 19856, 20566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20034, 20063);

                        f_58_20034_20062(this, ILOpCode.Stloc_2);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 20064, 20070);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 19856, 20566);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 19856, 20566);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20096, 20125);

                        f_58_20096_20124(this, ILOpCode.Stloc_3);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 20126, 20132);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 19856, 20566);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 19856, 20566);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20180, 20523) || true) && (slot < 0xFF)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 20180, 20523);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20245, 20274);

                            f_58_20245_20273(this, ILOpCode.Stloc_s);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20300, 20333);

                            f_58_20300_20332(this, unchecked((sbyte)slot));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(58, 20180, 20523);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 20180, 20523);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20431, 20458);

                            f_58_20431_20457(this, ILOpCode.Stloc);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20484, 20500);

                            f_58_20484_20499(this, slot);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(58, 20180, 20523);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 20545, 20551);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 19856, 20566);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 19739, 20577);

                int
                f_58_19826_19841(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 19826, 19841);
                    return return_v;
                }


                int
                f_58_19910_19938(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 19910, 19938);
                    return 0;
                }


                int
                f_58_19972_20000(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 19972, 20000);
                    return 0;
                }


                int
                f_58_20034_20062(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 20034, 20062);
                    return 0;
                }


                int
                f_58_20096_20124(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 20096, 20124);
                    return 0;
                }


                int
                f_58_20245_20273(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 20245, 20273);
                    return 0;
                }


                int
                f_58_20300_20332(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int8)
                {
                    this_param.EmitInt8((sbyte)int8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 20300, 20332);
                    return 0;
                }


                int
                f_58_20431_20457(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 20431, 20457);
                    return 0;
                }


                int
                f_58_20484_20499(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int32)
                {
                    this_param.EmitInt32(int32);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 20484, 20499);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 19739, 20577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 19739, 20577);
            }
        }

        internal void EmitLocalAddress(LocalDefinition local)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 20589, 21191);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20667, 21180) || true) && (f_58_20671_20688(local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 20667, 21180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20722, 20743);

                    f_58_20722_20742(this, local);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 20667, 21180);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 20667, 21180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20809, 20836);

                    int
                    slot = f_58_20820_20835(local)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20856, 21165) || true) && (slot < 0xFF)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 20856, 21165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20913, 20943);

                        f_58_20913_20942(this, ILOpCode.Ldloca_s);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 20965, 20998);

                        f_58_20965_20997(this, unchecked((sbyte)slot));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 20856, 21165);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 20856, 21165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21080, 21108);

                        f_58_21080_21107(this, ILOpCode.Ldloca);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21130, 21146);

                        f_58_21130_21145(this, slot);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 20856, 21165);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 20667, 21180);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 20589, 21191);

                bool
                f_58_20671_20688(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.IsReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 20671, 20688);
                    return return_v;
                }


                int
                f_58_20722_20742(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                local)
                {
                    this_param.EmitLocalLoad(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 20722, 20742);
                    return 0;
                }


                int
                f_58_20820_20835(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                this_param)
                {
                    var return_v = this_param.SlotIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 20820, 20835);
                    return return_v;
                }


                int
                f_58_20913_20942(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 20913, 20942);
                    return 0;
                }


                int
                f_58_20965_20997(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int8)
                {
                    this_param.EmitInt8((sbyte)int8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 20965, 20997);
                    return 0;
                }


                int
                f_58_21080_21107(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 21080, 21107);
                    return 0;
                }


                int
                f_58_21130_21145(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int32)
                {
                    this_param.EmitInt32(int32);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 21130, 21145);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 20589, 21191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 20589, 21191);
            }
        }

        internal void EmitLoadArgumentOpcode(int argNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 21281, 22098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21357, 22087);

                switch (argNumber)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 21357, 22087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21416, 21445);

                        f_58_21416_21444(this, ILOpCode.Ldarg_0);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 21446, 21452);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 21357, 22087);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 21357, 22087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21478, 21507);

                        f_58_21478_21506(this, ILOpCode.Ldarg_1);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 21508, 21514);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 21357, 22087);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 21357, 22087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21540, 21569);

                        f_58_21540_21568(this, ILOpCode.Ldarg_2);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 21570, 21576);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 21357, 22087);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 21357, 22087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21602, 21631);

                        f_58_21602_21630(this, ILOpCode.Ldarg_3);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 21632, 21638);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 21357, 22087);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 21357, 22087);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21686, 22044) || true) && (argNumber < 0xFF)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 21686, 22044);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21756, 21785);

                            f_58_21756_21784(this, ILOpCode.Ldarg_s);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21811, 21849);

                            f_58_21811_21848(this, unchecked((sbyte)argNumber));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(58, 21686, 22044);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 21686, 22044);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 21947, 21974);

                            f_58_21947_21973(this, ILOpCode.Ldarg);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22000, 22021);

                            f_58_22000_22020(this, argNumber);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(58, 21686, 22044);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 22066, 22072);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 21357, 22087);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 21281, 22098);

                int
                f_58_21416_21444(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 21416, 21444);
                    return 0;
                }


                int
                f_58_21478_21506(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 21478, 21506);
                    return 0;
                }


                int
                f_58_21540_21568(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 21540, 21568);
                    return 0;
                }


                int
                f_58_21602_21630(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 21602, 21630);
                    return 0;
                }


                int
                f_58_21756_21784(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 21756, 21784);
                    return 0;
                }


                int
                f_58_21811_21848(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int8)
                {
                    this_param.EmitInt8((sbyte)int8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 21811, 21848);
                    return 0;
                }


                int
                f_58_21947_21973(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 21947, 21973);
                    return 0;
                }


                int
                f_58_22000_22020(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int32)
                {
                    this_param.EmitInt32(int32);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 22000, 22020);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 21281, 22098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 21281, 22098);
            }
        }

        internal void EmitLoadArgumentAddrOpcode(int argNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 22110, 22489);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22190, 22478) || true) && (argNumber < 0xFF)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 22190, 22478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22244, 22274);

                    f_58_22244_22273(this, ILOpCode.Ldarga_s);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22292, 22330);

                    f_58_22292_22329(this, unchecked((sbyte)argNumber));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 22190, 22478);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 22190, 22478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22396, 22424);

                    f_58_22396_22423(this, ILOpCode.Ldarga);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22442, 22463);

                    f_58_22442_22462(this, argNumber);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 22190, 22478);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 22110, 22489);

                int
                f_58_22244_22273(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 22244, 22273);
                    return 0;
                }


                int
                f_58_22292_22329(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int8)
                {
                    this_param.EmitInt8((sbyte)int8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 22292, 22329);
                    return 0;
                }


                int
                f_58_22396_22423(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 22396, 22423);
                    return 0;
                }


                int
                f_58_22442_22462(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int32)
                {
                    this_param.EmitInt32(int32);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 22442, 22462);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 22110, 22489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 22110, 22489);
            }
        }

        internal void EmitStoreArgumentOpcode(int argNumber)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 22580, 22954);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22657, 22943) || true) && (argNumber < 0xFF)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 22657, 22943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22711, 22740);

                    f_58_22711_22739(this, ILOpCode.Starg_s);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22758, 22796);

                    f_58_22758_22795(this, unchecked((sbyte)argNumber));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 22657, 22943);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 22657, 22943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22862, 22889);

                    f_58_22862_22888(this, ILOpCode.Starg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 22907, 22928);

                    f_58_22907_22927(this, argNumber);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 22657, 22943);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 22580, 22954);

                int
                f_58_22711_22739(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 22711, 22739);
                    return 0;
                }


                int
                f_58_22758_22795(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int8)
                {
                    this_param.EmitInt8((sbyte)int8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 22758, 22795);
                    return 0;
                }


                int
                f_58_22862_22888(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 22862, 22888);
                    return 0;
                }


                int
                f_58_22907_22927(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int32)
                {
                    this_param.EmitInt32(int32);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 22907, 22927);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 22580, 22954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 22580, 22954);
            }
        }

        internal void EmitConstantValue(ConstantValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 22966, 25457);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 23043, 23110);

                ConstantValueTypeDiscriminator
                discriminator = f_58_23090_23109(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 23126, 25446);

                switch (discriminator)
                {

                    case ConstantValueTypeDiscriminator.Null:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 23244, 23263);

                        f_58_23244_23262(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 23285, 23291);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 23373, 23409);

                        f_58_23373_23408(this, f_58_23391_23407(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 23431, 23437);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 23518, 23552);

                        f_58_23518_23551(this, f_58_23535_23550(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 23574, 23580);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 23663, 23701);

                        f_58_23663_23700(this, f_58_23682_23699(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 23723, 23729);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 23810, 23846);

                        f_58_23810_23845(this, f_58_23829_23844(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 23868, 23874);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 23956, 23992);

                        f_58_23956_23991(this, f_58_23974_23990(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 24014, 24020);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.Int32:
                    case ConstantValueTypeDiscriminator.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 24163, 24197);

                        f_58_24163_24196(this, f_58_24179_24195(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 24219, 24225);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.Int64:
                    case ConstantValueTypeDiscriminator.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 24368, 24403);

                        f_58_24368_24402(this, f_58_24385_24401(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 24425, 24431);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.NInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 24512, 24552);

                        f_58_24512_24551(this, f_58_24534_24550(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 24574, 24580);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.NUInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 24662, 24703);

                        f_58_24662_24702(this, f_58_24684_24701(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 24725, 24731);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 24814, 24852);

                        f_58_24814_24851(this, f_58_24833_24850(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 24874, 24880);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 24963, 25001);

                        f_58_24963_25000(this, f_58_24982_24999(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 25023, 25029);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.String:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25112, 25150);

                        f_58_25112_25149(this, f_58_25131_25148(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 25172, 25178);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    case ConstantValueTypeDiscriminator.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25262, 25299);

                        f_58_25262_25298(this, f_58_25279_25297(value));
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 25321, 25327);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 23126, 25446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25375, 25431);

                        throw f_58_25381_25430(discriminator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 23126, 25446);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 22966, 25457);

                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_58_23090_23109(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 23090, 23109);
                    return return_v;
                }


                int
                f_58_23244_23262(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EmitNullConstant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 23244, 23262);
                    return 0;
                }


                sbyte
                f_58_23391_23407(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 23391, 23407);
                    return return_v;
                }


                int
                f_58_23373_23408(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, sbyte
                value)
                {
                    this_param.EmitSByteConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 23373, 23408);
                    return 0;
                }


                byte
                f_58_23535_23550(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.ByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 23535, 23550);
                    return return_v;
                }


                int
                f_58_23518_23551(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, byte
                value)
                {
                    this_param.EmitByteConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 23518, 23551);
                    return 0;
                }


                ushort
                f_58_23682_23699(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 23682, 23699);
                    return return_v;
                }


                int
                f_58_23663_23700(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, ushort
                value)
                {
                    this_param.EmitUShortConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 23663, 23700);
                    return 0;
                }


                char
                f_58_23829_23844(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.CharValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 23829, 23844);
                    return return_v;
                }


                int
                f_58_23810_23845(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, char
                value)
                {
                    this_param.EmitUShortConstant((ushort)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 23810, 23845);
                    return 0;
                }


                short
                f_58_23974_23990(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 23974, 23990);
                    return return_v;
                }


                int
                f_58_23956_23991(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, short
                value)
                {
                    this_param.EmitShortConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 23956, 23991);
                    return 0;
                }


                int
                f_58_24179_24195(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 24179, 24195);
                    return return_v;
                }


                int
                f_58_24163_24196(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 24163, 24196);
                    return 0;
                }


                long
                f_58_24385_24401(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 24385, 24401);
                    return return_v;
                }


                int
                f_58_24368_24402(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, long
                value)
                {
                    this_param.EmitLongConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 24368, 24402);
                    return 0;
                }


                int
                f_58_24534_24550(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 24534, 24550);
                    return return_v;
                }


                int
                f_58_24512_24551(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitNativeIntConstant((long)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 24512, 24551);
                    return 0;
                }


                uint
                f_58_24684_24701(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 24684, 24701);
                    return return_v;
                }


                int
                f_58_24662_24702(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, uint
                value)
                {
                    this_param.EmitNativeIntConstant((long)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 24662, 24702);
                    return 0;
                }


                float
                f_58_24833_24850(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SingleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 24833, 24850);
                    return return_v;
                }


                int
                f_58_24814_24851(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, float
                value)
                {
                    this_param.EmitSingleConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 24814, 24851);
                    return 0;
                }


                double
                f_58_24982_24999(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DoubleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 24982, 24999);
                    return return_v;
                }


                int
                f_58_24963_25000(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, double
                value)
                {
                    this_param.EmitDoubleConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 24963, 25000);
                    return 0;
                }


                string?
                f_58_25131_25148(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.StringValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 25131, 25148);
                    return return_v;
                }


                int
                f_58_25112_25149(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, string?
                value)
                {
                    this_param.EmitStringConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 25112, 25149);
                    return 0;
                }


                bool
                f_58_25279_25297(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.BooleanValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 25279, 25297);
                    return return_v;
                }


                int
                f_58_25262_25298(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, bool
                value)
                {
                    this_param.EmitBoolConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 25262, 25298);
                    return 0;
                }


                System.Exception
                f_58_25381_25430(Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 25381, 25430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 22966, 25457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 22966, 25457);
            }
        }

        internal void EmitIntConstant(int value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 25544, 26793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25609, 25638);

                ILOpCode
                code = ILOpCode.Nop
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25652, 26278);

                switch (value)
                {

                    case -1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25708, 25734);

                        code = ILOpCode.Ldc_i4_m1;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 25735, 25741);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25767, 25792);

                        code = ILOpCode.Ldc_i4_0;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 25793, 25799);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25825, 25850);

                        code = ILOpCode.Ldc_i4_1;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 25851, 25857);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25883, 25908);

                        code = ILOpCode.Ldc_i4_2;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 25909, 25915);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25941, 25966);

                        code = ILOpCode.Ldc_i4_3;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 25967, 25973);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 25999, 26024);

                        code = ILOpCode.Ldc_i4_4;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 26025, 26031);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);

                    case 5:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26057, 26082);

                        code = ILOpCode.Ldc_i4_5;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 26083, 26089);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);

                    case 6:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26115, 26140);

                        code = ILOpCode.Ldc_i4_6;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 26141, 26147);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);

                    case 7:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26173, 26198);

                        code = ILOpCode.Ldc_i4_7;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 26199, 26205);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);

                    case 8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 25652, 26278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26231, 26256);

                        code = ILOpCode.Ldc_i4_8;
                        DynAbs.Tracing.TraceSender.TraceBreak(58, 26257, 26263);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 25652, 26278);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26294, 26782) || true) && (code != ILOpCode.Nop)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 26294, 26782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26352, 26369);

                    f_58_26352_26368(this, code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 26294, 26782);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 26294, 26782);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26435, 26767) || true) && (unchecked((sbyte)value == value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 26435, 26767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26513, 26543);

                        f_58_26513_26542(this, ILOpCode.Ldc_i4_s);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26565, 26599);

                        f_58_26565_26598(this, unchecked((sbyte)value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 26435, 26767);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 26435, 26767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26681, 26709);

                        f_58_26681_26708(this, ILOpCode.Ldc_i4);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26731, 26748);

                        f_58_26731_26747(this, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 26435, 26767);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 26294, 26782);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 25544, 26793);

                int
                f_58_26352_26368(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 26352, 26368);
                    return 0;
                }


                int
                f_58_26513_26542(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 26513, 26542);
                    return 0;
                }


                int
                f_58_26565_26598(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int8)
                {
                    this_param.EmitInt8((sbyte)int8);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 26565, 26598);
                    return 0;
                }


                int
                f_58_26681_26708(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 26681, 26708);
                    return 0;
                }


                int
                f_58_26731_26747(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                int32)
                {
                    this_param.EmitInt32(int32);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 26731, 26747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 25544, 26793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 25544, 26793);
            }
        }

        internal void EmitBoolConstant(bool value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 26805, 26914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26872, 26903);

                f_58_26872_26902(this, (DynAbs.Tracing.TraceSender.Conditional_F1(58, 26888, 26893) || ((value && DynAbs.Tracing.TraceSender.Conditional_F2(58, 26896, 26897)) || DynAbs.Tracing.TraceSender.Conditional_F3(58, 26900, 26901))) ? 1 : 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 26805, 26914);

                int
                f_58_26872_26902(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, int
                value)
                {
                    this_param.EmitIntConstant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 26872, 26902);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 26805, 26914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 26805, 26914);
            }
        }

        internal void EmitByteConstant(byte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 26926, 27032);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 26993, 27021);

                f_58_26993_27020(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 26926, 27032);

                int
                f_58_26993_27020(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, byte
                value)
                {
                    this_param.EmitIntConstant((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 26993, 27020);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 26926, 27032);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 26926, 27032);
            }
        }

        internal void EmitSByteConstant(sbyte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 27044, 27152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27113, 27141);

                f_58_27113_27140(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 27044, 27152);

                int
                f_58_27113_27140(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, sbyte
                value)
                {
                    this_param.EmitIntConstant((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 27113, 27140);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 27044, 27152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 27044, 27152);
            }
        }

        internal void EmitShortConstant(short value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 27164, 27272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27233, 27261);

                f_58_27233_27260(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 27164, 27272);

                int
                f_58_27233_27260(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, short
                value)
                {
                    this_param.EmitIntConstant((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 27233, 27260);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 27164, 27272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 27164, 27272);
            }
        }

        internal void EmitUShortConstant(ushort value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 27284, 27394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27355, 27383);

                f_58_27355_27382(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 27284, 27394);

                int
                f_58_27355_27382(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, ushort
                value)
                {
                    this_param.EmitIntConstant((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 27355, 27382);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 27284, 27394);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 27284, 27394);
            }
        }

        internal void EmitLongConstant(long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 27406, 27993);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27473, 27982) || true) && (value >= int.MinValue && (DynAbs.Tracing.TraceSender.Expression_True(58, 27477, 27523) && value <= int.MaxValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 27473, 27982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27557, 27585);

                    f_58_27557_27584(this, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27603, 27632);

                    f_58_27603_27631(this, ILOpCode.Conv_i8);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 27473, 27982);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 27473, 27982);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27666, 27982) || true) && (value >= uint.MinValue && (DynAbs.Tracing.TraceSender.Expression_True(58, 27670, 27718) && value <= uint.MaxValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 27666, 27982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27752, 27791);

                        f_58_27752_27790(this, unchecked((int)value));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27809, 27838);

                        f_58_27809_27837(this, ILOpCode.Conv_u8);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 27666, 27982);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 27666, 27982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27904, 27932);

                        f_58_27904_27931(this, ILOpCode.Ldc_i8);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 27950, 27967);

                        f_58_27950_27966(this, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 27666, 27982);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 27473, 27982);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 27406, 27993);

                int
                f_58_27557_27584(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, long
                value)
                {
                    this_param.EmitIntConstant((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 27557, 27584);
                    return 0;
                }


                int
                f_58_27603_27631(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 27603, 27631);
                    return 0;
                }


                int
                f_58_27752_27790(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, long
                value)
                {
                    this_param.EmitIntConstant((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 27752, 27790);
                    return 0;
                }


                int
                f_58_27809_27837(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 27809, 27837);
                    return 0;
                }


                int
                f_58_27904_27931(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 27904, 27931);
                    return 0;
                }


                int
                f_58_27950_27966(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, long
                int64)
                {
                    this_param.EmitInt64(int64);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 27950, 27966);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 27406, 27993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 27406, 27993);
            }
        }

        internal void EmitNativeIntConstant(long value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 28005, 28580);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28077, 28569) || true) && (value >= int.MinValue && (DynAbs.Tracing.TraceSender.Expression_True(58, 28081, 28127) && value <= int.MaxValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 28077, 28569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28161, 28189);

                    f_58_28161_28188(this, value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28207, 28235);

                    f_58_28207_28234(this, ILOpCode.Conv_i);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 28077, 28569);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 28077, 28569);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28269, 28569) || true) && (value >= uint.MinValue && (DynAbs.Tracing.TraceSender.Expression_True(58, 28273, 28321) && value <= uint.MaxValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 28269, 28569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28355, 28394);

                        f_58_28355_28393(this, unchecked((int)value));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28412, 28440);

                        f_58_28412_28439(this, ILOpCode.Conv_u);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 28269, 28569);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 28269, 28569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28506, 28554);

                        throw f_58_28512_28553(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(58, 28269, 28569);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 28077, 28569);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 28005, 28580);

                int
                f_58_28161_28188(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, long
                value)
                {
                    this_param.EmitIntConstant((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28161, 28188);
                    return 0;
                }


                int
                f_58_28207_28234(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28207, 28234);
                    return 0;
                }


                int
                f_58_28355_28393(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, long
                value)
                {
                    this_param.EmitIntConstant((int)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28355, 28393);
                    return 0;
                }


                int
                f_58_28412_28439(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28412, 28439);
                    return 0;
                }


                System.Exception
                f_58_28512_28553(long
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28512, 28553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 28005, 28580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 28005, 28580);
            }
        }

        internal void EmitSingleConstant(float value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 28592, 28732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28662, 28690);

                f_58_28662_28689(this, ILOpCode.Ldc_r4);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28704, 28721);

                f_58_28704_28720(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 28592, 28732);

                int
                f_58_28662_28689(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28662, 28689);
                    return 0;
                }


                int
                f_58_28704_28720(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, float
                floatValue)
                {
                    this_param.EmitFloat(floatValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28704, 28720);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 28592, 28732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 28592, 28732);
            }
        }

        internal void EmitDoubleConstant(double value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 28744, 28886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28815, 28843);

                f_58_28815_28842(this, ILOpCode.Ldc_r8);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28857, 28875);

                f_58_28857_28874(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 28744, 28886);

                int
                f_58_28815_28842(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28815, 28842);
                    return 0;
                }


                int
                f_58_28857_28874(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, double
                doubleValue)
                {
                    this_param.EmitDouble(doubleValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28857, 28874);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 28744, 28886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 28744, 28886);
            }
        }

        internal void EmitNullConstant()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 28898, 28994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 28955, 28983);

                f_58_28955_28982(this, ILOpCode.Ldnull);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 28898, 28994);

                int
                f_58_28955_28982(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 28955, 28982);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 28898, 28994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 28898, 28994);
            }
        }

        internal void EmitStringConstant(string? value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 29006, 29302);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29078, 29291) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 29078, 29291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29129, 29148);

                    f_58_29129_29147(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 29078, 29291);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 29078, 29291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29214, 29241);

                    f_58_29214_29240(this, ILOpCode.Ldstr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29259, 29276);

                    f_58_29259_29275(this, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 29078, 29291);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 29006, 29302);

                int
                f_58_29129_29147(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    this_param.EmitNullConstant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29129, 29147);
                    return 0;
                }


                int
                f_58_29214_29240(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                code)
                {
                    this_param.EmitOpCode(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29214, 29240);
                    return 0;
                }


                int
                f_58_29259_29275(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param, string
                value)
                {
                    this_param.EmitToken(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29259, 29275);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 29006, 29302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 29006, 29302);
            }
        }

        private void EmitInt8(sbyte int8)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 29314, 29424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29372, 29413);

                f_58_29372_29412(f_58_29372_29395(this), int8);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 29314, 29424);

                System.Reflection.Metadata.BlobBuilder
                f_58_29372_29395(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29372, 29395);
                    return return_v;
                }


                int
                f_58_29372_29412(System.Reflection.Metadata.BlobBuilder
                this_param, sbyte
                value)
                {
                    this_param.WriteSByte(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29372, 29412);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 29314, 29424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 29314, 29424);
            }
        }

        private void EmitInt32(int int32)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 29436, 29547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29494, 29536);

                f_58_29494_29535(f_58_29494_29517(this), int32);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 29436, 29547);

                System.Reflection.Metadata.BlobBuilder
                f_58_29494_29517(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29494, 29517);
                    return return_v;
                }


                int
                f_58_29494_29535(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29494, 29535);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 29436, 29547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 29436, 29547);
            }
        }

        private void EmitInt64(long int64)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 29559, 29671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29618, 29660);

                f_58_29618_29659(f_58_29618_29641(this), int64);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 29559, 29671);

                System.Reflection.Metadata.BlobBuilder
                f_58_29618_29641(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29618, 29641);
                    return return_v;
                }


                int
                f_58_29618_29659(System.Reflection.Metadata.BlobBuilder
                this_param, long
                value)
                {
                    this_param.WriteInt64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29618, 29659);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 29559, 29671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 29559, 29671);
            }
        }

        private void EmitFloat(float floatValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 29683, 29886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29748, 29819);

                int
                int32 = f_58_29760_29818(f_58_29781_29814(floatValue), 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29833, 29875);

                f_58_29833_29874(f_58_29833_29856(this), int32);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 29683, 29886);

                byte[]
                f_58_29781_29814(float
                value)
                {
                    var return_v = BitConverter.GetBytes(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29781, 29814);
                    return return_v;
                }


                int
                f_58_29760_29818(byte[]
                value, int
                startIndex)
                {
                    var return_v = BitConverter.ToInt32(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29760, 29818);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_58_29833_29856(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29833, 29856);
                    return return_v;
                }


                int
                f_58_29833_29874(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29833, 29874);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 29683, 29886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 29683, 29886);
            }
        }

        private void EmitDouble(double doubleValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 29898, 30090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 29966, 30023);

                long
                int64 = f_58_29979_30022(doubleValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 30037, 30079);

                f_58_30037_30078(f_58_30037_30060(this), int64);
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 29898, 30090);

                long
                f_58_29979_30022(double
                value)
                {
                    var return_v = BitConverter.DoubleToInt64Bits(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 29979, 30022);
                    return return_v;
                }


                System.Reflection.Metadata.BlobBuilder
                f_58_30037_30060(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentWriter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 30037, 30060);
                    return return_v;
                }


                int
                f_58_30037_30078(System.Reflection.Metadata.BlobBuilder
                this_param, long
                value)
                {
                    this_param.WriteInt64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 30037, 30078);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 29898, 30090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 29898, 30090);
            }
        }

        private static void WriteOpCode(BlobBuilder writer, ILOpCode code)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(58, 30102, 30803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 30193, 30216);

                var
                size = f_58_30204_30215(code)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 30230, 30792) || true) && (size == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 30230, 30792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 30277, 30306);

                    f_58_30277_30305(writer, code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 30230, 30792);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(58, 30230, 30792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 30627, 30651);

                    f_58_30627_30650(size == 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 30669, 30713);

                    f_58_30669_30712(writer, ((ushort)code >> 8));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 30731, 30777);

                    f_58_30731_30776(writer, ((ushort)code & 0xff));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(58, 30230, 30792);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(58, 30102, 30803);

                int
                f_58_30204_30215(System.Reflection.Metadata.ILOpCode
                opcode)
                {
                    var return_v = opcode.Size();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 30204, 30215);
                    return return_v;
                }


                int
                f_58_30277_30305(System.Reflection.Metadata.BlobBuilder
                this_param, System.Reflection.Metadata.ILOpCode
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 30277, 30305);
                    return 0;
                }


                int
                f_58_30627_30650(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 30627, 30650);
                    return 0;
                }


                int
                f_58_30669_30712(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 30669, 30712);
                    return 0;
                }


                int
                f_58_30731_30776(System.Reflection.Metadata.BlobBuilder
                this_param, int
                value)
                {
                    this_param.WriteByte((byte)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 30731, 30776);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 30102, 30803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 30102, 30803);
            }
        }

        private BlobBuilder GetCurrentWriter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(58, 30815, 30926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(58, 30878, 30915);

                return f_58_30885_30914(f_58_30885_30907(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(58, 30815, 30926);

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                f_58_30885_30907(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                this_param)
                {
                    var return_v = this_param.GetCurrentBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(58, 30885, 30907);
                    return return_v;
                }


                Microsoft.Cci.PooledBlobBuilder
                f_58_30885_30914(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                this_param)
                {
                    var return_v = this_param.Writer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(58, 30885, 30914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(58, 30815, 30926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(58, 30815, 30926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
