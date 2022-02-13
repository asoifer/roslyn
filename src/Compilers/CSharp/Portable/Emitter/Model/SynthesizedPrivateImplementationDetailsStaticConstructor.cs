// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedPrivateImplementationDetailsStaticConstructor : SynthesizedGlobalMethodSymbol
    {
        internal SynthesizedPrivateImplementationDetailsStaticConstructor(SourceModuleSymbol containingModule, PrivateImplementationDetails privateImplementationType, NamedTypeSymbol voidType)
        : base(f_10214_822_838_C(containingModule), privateImplementationType, voidType, WellKnownMemberNames.StaticConstructorName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10214, 617, 1014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 945, 1003);

                f_10214_945_1002(this, ImmutableArray<ParameterSymbol>.Empty);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10214, 617, 1014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10214, 617, 1014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10214, 617, 1014);
            }
        }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10214, 1064, 1095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 1067, 1095);
                    return MethodKind.StaticConstructor; DynAbs.Tracing.TraceSender.TraceExitMethod(10214, 1064, 1095);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10214, 1064, 1095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10214, 1064, 1095);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10214, 1146, 1153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 1149, 1153);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10214, 1146, 1153);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10214, 1146, 1153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10214, 1146, 1153);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10214, 1166, 4115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 1298, 1352);

                CSharpSyntaxNode
                syntax = f_10214_1324_1351(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 1366, 1477);

                SyntheticBoundNodeFactory
                factory = f_10214_1402_1476(this, syntax, compilationState, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 1491, 1522);

                factory.CurrentFunction = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 1536, 1615);

                ArrayBuilder<BoundStatement>
                body = f_10214_1572_1614()
                ;

                // Initialize the payload root for each kind of dynamic analysis instrumentation.
                // A payload root is an array of arrays of per-method instrumentation payloads.
                // For each kind of instrumentation:
                //
                //     payloadRoot = new T[MaximumMethodDefIndex + 1][];
                //
                // where T is the type of the payload at each instrumentation point, and MaximumMethodDefIndex is the
                // index portion of the greatest method definition token in the compilation. This guarantees that any
                // method can use the index portion of its own method definition token as an index into the payload array.

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 2359, 3200);
                        foreach (KeyValuePair<int, InstrumentationPayloadRootField> payloadRoot in f_10214_2434_2509_I(f_10214_2434_2509(f_10214_2434_2476())))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10214, 2359, 3200);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 2551, 2586);

                            int
                            analysisKind = payloadRoot.Key
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 2608, 2703);

                            ArrayTypeSymbol
                            payloadArrayType = (ArrayTypeSymbol)f_10214_2660_2702(f_10214_2660_2682(payloadRoot.Value))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 2727, 3127);

                            BoundStatement
                            payloadInitialization =
                            f_10214_2791_3126(factory, f_10214_2840_2906(factory, analysisKind, payloadArrayType), f_10214_2937_3125(factory, f_10214_2951_2979(payloadArrayType), f_10214_2981_3124(factory, BinaryOperatorKind.Addition, f_10214_3025_3070(factory, SpecialType.System_Int32), f_10214_3072_3103(factory), f_10214_3105_3123(factory, 1))))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 3149, 3181);

                            f_10214_3149_3180(body, payloadInitialization);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10214, 2359, 3200);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10214, 1, 842);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10214, 1, 842);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 3452, 3742);

                    f_10214_3452_3741(
                                    // Initialize the module version ID (MVID) field. Dynamic instrumentation requires the MVID of the executing module, and this field makes that accessible.
                                    // MVID = new Guid(ModuleVersionIdString);
                                    body, f_10214_3483_3740(factory, f_10214_3527_3552(factory), f_10214_3578_3739(factory, f_10214_3619_3677(factory, WellKnownMember.System_Guid__ctor), f_10214_3707_3738(factory))));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember missing)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10214, 3771, 3920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 3869, 3905);

                    f_10214_3869_3904(diagnostics, f_10214_3885_3903(missing));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10214, 3771, 3920);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 3936, 3986);

                BoundStatement
                returnStatement = f_10214_3969_3985(factory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 4000, 4026);

                f_10214_4000_4025(body, returnStatement);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10214, 4042, 4104);

                f_10214_4042_4103(
                            factory, f_10214_4062_4102(factory, f_10214_4076_4101(body)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10214, 1166, 4115);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10214_1324_1351(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedPrivateImplementationDetailsStaticConstructor
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 1324, 1351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10214_1402_1476(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedPrivateImplementationDetailsStaticConstructor
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 1402, 1476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10214_1572_1614()
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 1572, 1614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                f_10214_2434_2476()
                {
                    var return_v = ContainingPrivateImplementationDetailsType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10214, 2434, 2476);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>>
                f_10214_2434_2509(Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                this_param)
                {
                    var return_v = this_param.GetInstrumentationPayloadRoots();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 2434, 2509);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10214_2660_2682(Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10214, 2660, 2682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10214_2660_2702(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 2660, 2702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10214_2840_2906(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                analysisKind, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol?
                payloadType)
                {
                    var return_v = this_param.InstrumentationPayloadRoot(analysisKind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)payloadType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 2840, 2906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10214_2951_2979(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10214, 2951, 2979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10214_3025_3070(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3025, 3070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10214_3072_3103(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.MaximumMethodDefIndex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3072, 3103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10214_3105_3123(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3105, 3123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10214_2981_3124(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 2981, 3124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10214_2937_3125(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                elementType, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                length)
                {
                    var return_v = this_param.Array(elementType, (Microsoft.CodeAnalysis.CSharp.BoundExpression)length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 2937, 3125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10214_2791_3126(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Assignment(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 2791, 3126);
                    return return_v;
                }


                int
                f_10214_3149_3180(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3149, 3180);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>>
                f_10214_2434_2509_I(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 2434, 2509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10214_3527_3552(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleVersionId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3527, 3552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10214_3619_3677(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3619, 3677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10214_3707_3738(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleVersionIdString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3707, 3738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10214_3578_3739(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.New(ctor, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3578, 3739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10214_3483_3740(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                right)
                {
                    var return_v = this_param.Assignment(left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3483, 3740);
                    return return_v;
                }


                int
                f_10214_3452_3741(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3452, 3741);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10214_3885_3903(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10214, 3885, 3903);
                    return return_v;
                }


                int
                f_10214_3869_3904(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3869, 3904);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10214_3969_3985(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 3969, 3985);
                    return return_v;
                }


                int
                f_10214_4000_4025(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 4000, 4025);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10214_4076_4101(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 4076, 4101);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10214_4062_4102(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 4062, 4102);
                    return return_v;
                }


                int
                f_10214_4042_4103(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 4042, 4103);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10214, 1166, 4115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10214, 1166, 4115);
            }
        }

        static SynthesizedPrivateImplementationDetailsStaticConstructor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10214, 490, 4122);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10214, 490, 4122);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10214, 490, 4122);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10214, 490, 4122);

        int
        f_10214_945_1002(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedPrivateImplementationDetailsStaticConstructor
        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        parameters)
        {
            this_param.SetParameters(parameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10214, 945, 1002);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        f_10214_822_838_C(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10214, 617, 1014);
            return return_v;
        }

    }
}
