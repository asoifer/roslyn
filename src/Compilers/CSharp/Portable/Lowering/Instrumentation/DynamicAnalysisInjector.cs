// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class DynamicAnalysisInjector : CompoundInstrumenter
    {
        private readonly MethodSymbol _method;

        private readonly BoundStatement _methodBody;

        private readonly MethodSymbol _createPayloadForMethodsSpanningSingleFile;

        private readonly MethodSymbol _createPayloadForMethodsSpanningMultipleFiles;

        private readonly ArrayBuilder<SourceSpan> _spansBuilder;

        private ImmutableArray<SourceSpan> _dynamicAnalysisSpans;

        private readonly BoundStatement _methodEntryInstrumentation;

        private readonly ArrayTypeSymbol _payloadType;

        private readonly LocalSymbol _methodPayload;

        private readonly DiagnosticBag _diagnostics;

        private readonly DebugDocumentProvider _debugDocumentProvider;

        private readonly SyntheticBoundNodeFactory _methodBodyFactory;

        public static DynamicAnalysisInjector TryCreate(
                    MethodSymbol method,
                    BoundStatement methodBody,
                    SyntheticBoundNodeFactory methodBodyFactory,
                    DiagnosticBag diagnostics,
                    DebugDocumentProvider debugDocumentProvider,
                    Instrumenter previous)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 1705, 4329);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 2225, 2350) || true) && (f_10463_2229_2256(method) && (DynAbs.Tracing.TraceSender.Expression_True(10463, 2229, 2289) && f_10463_2260_2289_M(!method.IsImplicitConstructor)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 2225, 2350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 2323, 2335);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 2225, 2350);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 2469, 2568) || true) && (f_10463_2473_2507(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 2469, 2568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 2541, 2553);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 2469, 2568);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 2584, 2905);

                MethodSymbol
                createPayloadForMethodsSpanningSingleFile = f_10463_2641_2904(f_10463_2684_2713(methodBodyFactory), WellKnownMember.Microsoft_CodeAnalysis_Runtime_Instrumentation__CreatePayloadForMethodsSpanningSingleFile, methodBody.Syntax, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 2921, 3248);

                MethodSymbol
                createPayloadForMethodsSpanningMultipleFiles = f_10463_2981_3247(f_10463_3024_3053(methodBodyFactory), WellKnownMember.Microsoft_CodeAnalysis_Runtime_Instrumentation__CreatePayloadForMethodsSpanningMultipleFiles, methodBody.Syntax, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 3343, 3529) || true) && ((object)createPayloadForMethodsSpanningSingleFile == null || (DynAbs.Tracing.TraceSender.Expression_False(10463, 3347, 3468) || (object)createPayloadForMethodsSpanningMultipleFiles == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 3343, 3529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 3502, 3514);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 3343, 3529);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 3772, 3956) || true) && (f_10463_3776_3832(method, createPayloadForMethodsSpanningSingleFile) || (DynAbs.Tracing.TraceSender.Expression_False(10463, 3776, 3895) || f_10463_3836_3895(method, createPayloadForMethodsSpanningMultipleFiles)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 3772, 3956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 3929, 3941);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 3772, 3956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 3972, 4318);

                return f_10463_3979_4317(method, methodBody, methodBodyFactory, createPayloadForMethodsSpanningSingleFile, createPayloadForMethodsSpanningMultipleFiles, diagnostics, debugDocumentProvider, previous);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 1705, 4329);

                bool
                f_10463_2229_2256(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 2229, 2256);
                    return return_v;
                }


                bool
                f_10463_2260_2289_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 2260, 2289);
                    return return_v;
                }


                bool
                f_10463_2473_2507(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = IsExcludedFromCodeCoverage(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 2473, 2507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10463_2684_2713(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 2684, 2713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10463_2641_2904(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                overload, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetCreatePayloadOverload(compilation, overload, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 2641, 2904);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10463_3024_3053(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 3024, 3053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10463_2981_3247(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                overload, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = GetCreatePayloadOverload(compilation, overload, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 2981, 3247);
                    return return_v;
                }


                bool
                f_10463_3776_3832(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 3776, 3832);
                    return return_v;
                }


                bool
                f_10463_3836_3895(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 3836, 3895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                f_10463_3979_4317(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundStatement
                methodBody, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                methodBodyFactory, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                createPayloadForMethodsSpanningSingleFile, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                createPayloadForMethodsSpanningMultipleFiles, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, Microsoft.CodeAnalysis.CSharp.Instrumenter
                previous)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector(method, methodBody, methodBodyFactory, createPayloadForMethodsSpanningSingleFile, createPayloadForMethodsSpanningMultipleFiles, diagnostics, debugDocumentProvider, previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 3979, 4317);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 1705, 4329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 1705, 4329);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DynamicAnalysisInjector(
                    MethodSymbol method,
                    BoundStatement methodBody,
                    SyntheticBoundNodeFactory methodBodyFactory,
                    MethodSymbol createPayloadForMethodsSpanningSingleFile,
                    MethodSymbol createPayloadForMethodsSpanningMultipleFiles,
                    DiagnosticBag diagnostics,
                    DebugDocumentProvider debugDocumentProvider,
                    Instrumenter previous) : base(f_10463_4788_4796_C(previous))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10463, 4341, 6473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 916, 923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 966, 977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1018, 1060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1101, 1146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1199, 1212);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1258, 1314);
                this._dynamicAnalysisSpans = ImmutableArray<SourceSpan>.Empty; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1357, 1384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1428, 1440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1480, 1494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1536, 1548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1598, 1620);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 1674, 1692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 4822, 4909);

                _createPayloadForMethodsSpanningSingleFile = createPayloadForMethodsSpanningSingleFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 4923, 5016);

                _createPayloadForMethodsSpanningMultipleFiles = createPayloadForMethodsSpanningMultipleFiles;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5030, 5047);

                _method = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5061, 5086);

                _methodBody = methodBody;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5100, 5155);

                _spansBuilder = f_10463_5116_5154();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5169, 5259);

                TypeSymbol
                payloadElementType = f_10463_5201_5258(methodBodyFactory, SpecialType.System_Boolean)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5273, 5410);

                _payloadType = f_10463_5288_5409(f_10463_5322_5360(f_10463_5322_5351(methodBodyFactory)), TypeWithAnnotations.Create(payloadElementType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5424, 5451);

                _diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5465, 5512);

                _debugDocumentProvider = debugDocumentProvider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5526, 5565);

                _methodBodyFactory = methodBodyFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5662, 5712);

                var
                oldMethod = f_10463_5678_5711(methodBodyFactory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5726, 5769);

                methodBodyFactory.CurrentFunction = method;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 5785, 5929);

                _methodPayload = f_10463_5802_5928(methodBodyFactory, _payloadType, kind: SynthesizedLocalKind.InstrumentationPayload, syntax: methodBody.Syntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6050, 6118);

                SyntaxNode
                syntax = f_10463_6070_6117(methodBody.Syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6132, 6368) || true) && (f_10463_6136_6164_M(!method.IsImplicitlyDeclared) && (DynAbs.Tracing.TraceSender.Expression_True(10463, 6136, 6221) && !(method is SynthesizedSimpleProgramEntryPointSymbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 6132, 6368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6255, 6353);

                    _methodEntryInstrumentation = f_10463_6285_6352(this, syntax, f_10463_6310_6332(syntax), methodBodyFactory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 6132, 6368);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6416, 6462);

                methodBodyFactory.CurrentFunction = oldMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10463, 4341, 6473);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 4341, 6473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 4341, 6473);
            }
        }

        private static bool IsExcludedFromCodeCoverage(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 6485, 7432);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6577, 6690);

                f_10463_6577_6689(f_10463_6590_6607(method) != MethodKind.LocalFunction && (DynAbs.Tracing.TraceSender.Expression_True(10463, 6590, 6688) && f_10463_6639_6656(method) != MethodKind.AnonymousFunction));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6706, 6749);

                var
                containingType = f_10463_6727_6748(method)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6763, 7042) || true) && ((object)containingType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 6763, 7042);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6834, 6960) || true) && (f_10463_6838_6887(containingType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 6834, 6960);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6929, 6941);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 6834, 6960);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 6980, 7027);

                        containingType = f_10463_6997_7026(containingType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 6763, 7042);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10463, 6763, 7042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10463, 6763, 7042);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 7058, 7421);

                return method switch
                {
                    { IsDirectlyExcludedFromCodeCoverage: true } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 7111, 7163) && DynAbs.Tracing.TraceSender.Expression_True(10463, 7111, 7163))
    => true,
                    { AssociatedSymbol: PropertySymbol { IsDirectlyExcludedFromCodeCoverage: true } } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 7182, 7271) && DynAbs.Tracing.TraceSender.Expression_True(10463, 7182, 7271))
    => true,
                    { AssociatedSymbol: EventSymbol { IsDirectlyExcludedFromCodeCoverage: true } } when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 7290, 7376) && DynAbs.Tracing.TraceSender.Expression_True(10463, 7290, 7376))
    => true,
                    _ when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 7395, 7405) && DynAbs.Tracing.TraceSender.Expression_True(10463, 7395, 7405))
    => false
                };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 6485, 7432);

                Microsoft.CodeAnalysis.MethodKind
                f_10463_6590_6607(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 6590, 6607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10463_6639_6656(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 6639, 6656);
                    return return_v;
                }


                int
                f_10463_6577_6689(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 6577, 6689);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10463_6727_6748(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 6727, 6748);
                    return return_v;
                }


                bool
                f_10463_6838_6887(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDirectlyExcludedFromCodeCoverage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 6838, 6887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10463_6997_7026(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 6997, 7026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 6485, 7432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 6485, 7432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpressionStatement GetCreatePayloadStatement(
                    ImmutableArray<SourceSpan> dynamicAnalysisSpans,
                    SyntaxNode methodBodySyntax,
                    LocalSymbol methodPayload,
                    MethodSymbol createPayloadForMethodsSpanningSingleFile,
                    MethodSymbol createPayloadForMethodsSpanningMultipleFiles,
                    BoundExpression mvid,
                    BoundExpression methodToken,
                    BoundExpression payloadSlot,
                    SyntheticBoundNodeFactory methodBodyFactory,
                    DebugDocumentProvider debugDocumentProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 7444, 10762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 8055, 8090);

                MethodSymbol
                createPayloadOverload
                = default(MethodSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 8104, 8147);

                BoundExpression
                fileIndexOrIndicesArgument
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 8163, 10307) || true) && (dynamicAnalysisSpans.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 8163, 10307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 8229, 8295);

                    createPayloadOverload = createPayloadForMethodsSpanningSingleFile;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 8521, 8595);

                    var
                    document = f_10463_8536_8594(debugDocumentProvider, methodBodySyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 8613, 8690);

                    fileIndexOrIndicesArgument = f_10463_8642_8689(methodBodyFactory, document);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 8163, 10307);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 8163, 10307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 8756, 8821);

                    var
                    documents = f_10463_8772_8820()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 8839, 8901);

                    var
                    fileIndices = f_10463_8857_8900()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 8921, 9239);
                        foreach (var span in f_10463_8942_8962_I(dynamicAnalysisSpans))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 8921, 9239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 9004, 9033);

                            var
                            document = span.Document
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 9055, 9220) || true) && (f_10463_9059_9082(documents, document))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 9055, 9220);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 9132, 9197);

                                f_10463_9132_9196(fileIndices, f_10463_9148_9195(methodBodyFactory, document));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 9055, 9220);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 8921, 9239);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10463, 1, 319);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10463, 1, 319);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 9259, 9276);

                    f_10463_9259_9275(
                                    documents);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 9496, 10253) || true) && (f_10463_9500_9517(fileIndices) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 9496, 10253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 9564, 9630);

                        createPayloadOverload = createPayloadForMethodsSpanningSingleFile;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 9652, 9702);

                        fileIndexOrIndicesArgument = f_10463_9681_9701(fileIndices);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 9496, 10253);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 9496, 10253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 9784, 9853);

                        createPayloadOverload = createPayloadForMethodsSpanningMultipleFiles;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 10071, 10234);

                        fileIndexOrIndicesArgument = f_10463_10100_10233(methodBodyFactory, f_10463_10150_10205(methodBodyFactory, SpecialType.System_Int32), f_10463_10207_10232(fileIndices));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 9496, 10253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 10273, 10292);

                    f_10463_10273_10291(
                                    fileIndices);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 8163, 10307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 10323, 10751);

                return f_10463_10330_10750(methodBodyFactory, f_10463_10377_10415(methodBodyFactory, methodPayload), f_10463_10434_10749(methodBodyFactory, null, createPayloadOverload, mvid, methodToken, fileIndexOrIndicesArgument, payloadSlot, f_10463_10694_10748(methodBodyFactory, dynamicAnalysisSpans.Length)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 7444, 10762);

                Microsoft.Cci.DebugSourceDocument
                f_10463_8536_8594(Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = GetSourceDocument(debugDocumentProvider, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 8536, 8594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_8642_8689(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.Cci.DebugSourceDocument
                document)
                {
                    var return_v = this_param.SourceDocumentIndex(document);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 8642, 8689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.Cci.DebugSourceDocument>
                f_10463_8772_8820()
                {
                    var return_v = PooledHashSet<DebugSourceDocument>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 8772, 8820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10463_8857_8900()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 8857, 8900);
                    return return_v;
                }


                bool
                f_10463_9059_9082(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.Cci.DebugSourceDocument>
                this_param, Microsoft.Cci.DebugSourceDocument
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 9059, 9082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_9148_9195(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.Cci.DebugSourceDocument
                document)
                {
                    var return_v = this_param.SourceDocumentIndex(document);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 9148, 9195);
                    return return_v;
                }


                int
                f_10463_9132_9196(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 9132, 9196);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                f_10463_8942_8962_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 8942, 8962);
                    return return_v;
                }


                int
                f_10463_9259_9275(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.Cci.DebugSourceDocument>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 9259, 9275);
                    return 0;
                }


                int
                f_10463_9500_9517(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 9500, 9517);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_9681_9701(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                source)
                {
                    var return_v = source.Single<Microsoft.CodeAnalysis.CSharp.BoundExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 9681, 9701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10463_10150_10205(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 10150, 10205);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10463_10207_10232(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 10207, 10232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_10100_10233(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.Array((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 10100, 10233);
                    return return_v;
                }


                int
                f_10463_10273_10291(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 10273, 10291);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10463_10377_10415(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 10377, 10415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10463_10694_10748(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 10694, 10748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10463_10434_10749(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.Call(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 10434, 10749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10463_10330_10750(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundCall
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 10330, 10750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 7444, 10762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 7444, 10762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement? CreateBlockPrologue(BoundBlock original, out LocalSymbol? synthesizedLocal)
        {
            try
#nullable disable
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 10792, 14717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 10943, 11034);

                // LAFHIS
                //BoundStatement previousPrologue = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.CreateBlockPrologue(original, out synthesizedLocal), 10463, 10977, 11033);

                BoundStatement previousPrologue = base.CreateBlockPrologue(original, out synthesizedLocal);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 10977, 11033);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 11048, 14666) || true) && (_methodBody == original)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 11048, 14666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 11109, 11168);

                    _dynamicAnalysisSpans = f_10463_11133_11167(_spansBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 11259, 11286);

                    const int
                    analysisKind = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 11306, 11480);

                    ArrayTypeSymbol
                    modulePayloadType =
                    f_10463_11363_11479(f_10463_11397_11436(f_10463_11397_11427(_methodBodyFactory)), TypeWithAnnotations.Create(_payloadType))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 11907, 12328);

                    BoundStatement
                    payloadInitialization =
                    f_10463_11967_12327(_methodBodyFactory, f_10463_12023_12063(_methodBodyFactory, _methodPayload), f_10463_12090_12326(_methodBodyFactory, f_10463_12151_12229(_methodBodyFactory, analysisKind, modulePayloadType), f_10463_12260_12325(f_10463_12282_12324(_methodBodyFactory, _method))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 12348, 12408);

                    BoundExpression
                    mvid = f_10463_12371_12407(_methodBodyFactory)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 12426, 12499);

                    BoundExpression
                    methodToken = f_10463_12456_12498(_methodBodyFactory, _method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 12519, 12799);

                    BoundExpression
                    payloadSlot =
                    f_10463_12570_12798(_methodBodyFactory, f_10463_12627_12705(_methodBodyFactory, analysisKind, modulePayloadType), f_10463_12732_12797(f_10463_12754_12796(_methodBodyFactory, _method)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 12819, 13378);

                    BoundStatement
                    createPayloadCall =
                    f_10463_12875_13377(_dynamicAnalysisSpans, _methodBody.Syntax, _methodPayload, _createPayloadForMethodsSpanningSingleFile, _createPayloadForMethodsSpanningMultipleFiles, mvid, methodToken, payloadSlot, _methodBodyFactory, _debugDocumentProvider)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 13398, 13753);

                    BoundExpression
                    payloadNullTest =
                    f_10463_13453_13752(_methodBodyFactory, BinaryOperatorKind.ObjectEqual, f_10463_13562_13620(_methodBodyFactory, SpecialType.System_Boolean), f_10463_13647_13687(_methodBodyFactory, _methodPayload), f_10463_13714_13751(_methodBodyFactory, _payloadType))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 13773, 13858);

                    BoundStatement
                    payloadIf = f_10463_13800_13857(_methodBodyFactory, payloadNullTest, createPayloadCall)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 13878, 13917);

                    f_10463_13878_13916(synthesizedLocal == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 13935, 13969);

                    synthesizedLocal = _methodPayload;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 13989, 14114);

                    ArrayBuilder<BoundStatement>
                    prologueStatements = f_10463_14039_14113((DynAbs.Tracing.TraceSender.Conditional_F1(10463, 14080, 14104) || ((previousPrologue == null && DynAbs.Tracing.TraceSender.Conditional_F2(10463, 14107, 14108)) || DynAbs.Tracing.TraceSender.Conditional_F3(10463, 14111, 14112))) ? 3 : 4)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14132, 14178);

                    f_10463_14132_14177(prologueStatements, payloadInitialization);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14196, 14230);

                    f_10463_14196_14229(prologueStatements, payloadIf);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14248, 14400) || true) && (_methodEntryInstrumentation != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 14248, 14400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14329, 14381);

                        f_10463_14329_14380(prologueStatements, _methodEntryInstrumentation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 14248, 14400);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14420, 14550) || true) && (previousPrologue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 14420, 14550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14490, 14531);

                        f_10463_14490_14530(prologueStatements, previousPrologue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 14420, 14550);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14570, 14651);

                    return f_10463_14577_14650(_methodBodyFactory, f_10463_14610_14649(prologueStatements));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 11048, 14666);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14682, 14706);

                return previousPrologue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 10792, 14717);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                f_10463_11133_11167(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 11133, 11167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10463_11397_11427(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 11397, 11427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10463_11397_11436(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 11397, 11436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10463_11363_11479(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementTypeWithAnnotations)
                {
                    var return_v = ArrayTypeSymbol.CreateCSharpArray(declaringAssembly, elementTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 11363, 11479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10463_12023_12063(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12023, 12063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_12151_12229(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                analysisKind, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                payloadType)
                {
                    var return_v = this_param.InstrumentationPayloadRoot(analysisKind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)payloadType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12151, 12229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_12282_12324(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodDefIndex(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12282, 12324);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10463_12260_12325(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12260, 12325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10463_12090_12326(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices)
                {
                    var return_v = this_param.ArrayAccess(array, indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12090, 12326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10463_11967_12327(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 11967, 12327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_12371_12407(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ModuleVersionId();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12371, 12407);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_12456_12498(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodDefIndex(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12456, 12498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_12627_12705(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                analysisKind, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                payloadType)
                {
                    var return_v = this_param.InstrumentationPayloadRoot(analysisKind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)payloadType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12627, 12705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_12754_12796(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodDefIndex(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12754, 12796);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10463_12732_12797(Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12732, 12797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10463_12570_12798(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                array, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                indices)
                {
                    var return_v = this_param.ArrayAccess(array, indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12570, 12798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10463_12875_13377(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                dynamicAnalysisSpans, Microsoft.CodeAnalysis.SyntaxNode
                methodBodySyntax, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                methodPayload, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                createPayloadForMethodsSpanningSingleFile, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                createPayloadForMethodsSpanningMultipleFiles, Microsoft.CodeAnalysis.CSharp.BoundExpression
                mvid, Microsoft.CodeAnalysis.CSharp.BoundExpression
                methodToken, Microsoft.CodeAnalysis.CSharp.BoundExpression
                payloadSlot, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                methodBodyFactory, Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider)
                {
                    var return_v = GetCreatePayloadStatement(dynamicAnalysisSpans, methodBodySyntax, methodPayload, createPayloadForMethodsSpanningSingleFile, createPayloadForMethodsSpanningMultipleFiles, mvid, methodToken, payloadSlot, methodBodyFactory, debugDocumentProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 12875, 13377);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10463_13562_13620(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 13562, 13620);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10463_13647_13687(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 13647, 13687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_13714_13751(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 13714, 13751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10463_13453_13752(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 13453, 13752);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_13800_13857(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement
                thenClause)
                {
                    var return_v = this_param.If(condition, thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 13800, 13857);
                    return return_v;
                }


                int
                f_10463_13878_13916(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 13878, 13916);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10463_14039_14113(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundStatement>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 14039, 14113);
                    return return_v;
                }


                int
                f_10463_14132_14177(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 14132, 14177);
                    return 0;
                }


                int
                f_10463_14196_14229(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 14196, 14229);
                    return 0;
                }


                int
                f_10463_14329_14380(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 14329, 14380);
                    return 0;
                }


                int
                f_10463_14490_14530(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 14490, 14530);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10463_14610_14649(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 14610, 14649);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10463_14577_14650(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.StatementList(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 14577, 14650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 10792, 14717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 10792, 14717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<SourceSpan> DynamicAnalysisSpans
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 14784, 14808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14787, 14808);
                    return _dynamicAnalysisSpans; DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 14784, 14808);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 14784, 14808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 14784, 14808);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override BoundStatement InstrumentNoOpStatement(BoundNoOpStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 14821, 15053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 14955, 15042);

                return f_10463_14962_15041(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentNoOpStatement(original, rewritten), 10463, 14991, 15040));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 14821, 15053);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_14962_15041(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 14962, 15041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 14821, 15053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 14821, 15053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentBreakStatement(BoundBreakStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 15065, 15300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 15201, 15289);

                return f_10463_15208_15288(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentBreakStatement(original, rewritten), 10463, 15237, 15287));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 15065, 15300);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_15208_15288(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBreakStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 15208, 15288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 15065, 15300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 15065, 15300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentContinueStatement(BoundContinueStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 15312, 15556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 15454, 15545);

                return f_10463_15461_15544(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentContinueStatement(original, rewritten), 10463, 15490, 15543));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 15312, 15556);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_15461_15544(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundContinueStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 15461, 15544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 15312, 15556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 15312, 15556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentExpressionStatement(BoundExpressionStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 15568, 15818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 15714, 15807);

                return f_10463_15721_15806(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentExpressionStatement(original, rewritten), 10463, 15750, 15805));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 15568, 15818);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_15721_15806(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 15721, 15806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 15568, 15818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 15568, 15818);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentFieldOrPropertyInitializer(BoundStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 15830, 16084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 15973, 16073);

                return f_10463_15980_16072(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentFieldOrPropertyInitializer(original, rewritten), 10463, 16009, 16071));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 15830, 16084);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_15980_16072(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 15980, 16072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 15830, 16084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 15830, 16084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentGotoStatement(BoundGotoStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 16096, 16328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 16230, 16317);

                return f_10463_16237_16316(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentGotoStatement(original, rewritten), 10463, 16266, 16315));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 16096, 16328);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_16237_16316(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 16237, 16316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 16096, 16328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 16096, 16328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentThrowStatement(BoundThrowStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 16340, 16575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 16476, 16564);

                return f_10463_16483_16563(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentThrowStatement(original, rewritten), 10463, 16512, 16562));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 16340, 16575);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_16483_16563(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThrowStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 16483, 16563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 16340, 16575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 16340, 16575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentYieldBreakStatement(BoundYieldBreakStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 16587, 16837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 16733, 16826);

                return f_10463_16740_16825(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentYieldBreakStatement(original, rewritten), 10463, 16769, 16824));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 16587, 16837);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_16740_16825(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundYieldBreakStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 16740, 16825);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 16587, 16837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 16587, 16837);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentYieldReturnStatement(BoundYieldReturnStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 16849, 17102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 16997, 17091);

                return f_10463_17004_17090(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentYieldReturnStatement(original, rewritten), 10463, 17033, 17089));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 16849, 17102);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_17004_17090(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundYieldReturnStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 17004, 17090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 16849, 17102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 16849, 17102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatementIterationVarDeclaration(BoundForEachStatement original, BoundStatement iterationVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 17114, 17415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 17284, 17404);

                return f_10463_17291_17403(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentForEachStatementIterationVarDeclaration(original, iterationVarDecl), 10463, 17320, 17402));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 17114, 17415);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_17291_17403(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 17291, 17403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 17114, 17415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 17114, 17415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentForEachStatementDeconstructionVariablesDeclaration(BoundForEachStatement original, BoundStatement iterationVarDecl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 17427, 17750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 17608, 17739);

                return f_10463_17615_17738(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentForEachStatementDeconstructionVariablesDeclaration(original, iterationVarDecl), 10463, 17644, 17737));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 17427, 17750);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_17615_17738(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 17615, 17738);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 17427, 17750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 17427, 17750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentIfStatement(BoundIfStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 17762, 17988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 17892, 17977);

                return f_10463_17899_17976(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentIfStatement(original, rewritten), 10463, 17928, 17975));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 17762, 17988);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_17899_17976(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 17899, 17976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 17762, 17988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 17762, 17988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentWhileStatementConditionalGotoStartOrBreak(BoundWhileStatement original, BoundStatement ifConditionGotoStart)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 18000, 18311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 18174, 18300);

                return f_10463_18181_18299(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentWhileStatementConditionalGotoStartOrBreak(original, ifConditionGotoStart), 10463, 18210, 18298));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 18000, 18311);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_18181_18299(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 18181, 18299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 18000, 18311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 18000, 18311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentLocalInitialization(BoundLocalDeclaration original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 18323, 18570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 18466, 18559);

                return f_10463_18473_18558(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentLocalInitialization(original, rewritten), 10463, 18502, 18557));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 18323, 18570);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_18473_18558(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 18473, 18558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 18323, 18570);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 18323, 18570);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentLockTargetCapture(BoundLockStatement original, BoundStatement lockTargetCapture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 18582, 18838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 18728, 18827);

                return f_10463_18735_18826(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentLockTargetCapture(original, lockTargetCapture), 10463, 18764, 18825));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 18582, 18838);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_18735_18826(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLockStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 18735, 18826);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 18582, 18838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 18582, 18838);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentReturnStatement(BoundReturnStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 18850, 19866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 18988, 19052);

                rewritten = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentReturnStatement(original, rewritten), 10463, 19000, 19051);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 19489, 19792) || true) && (f_10463_19493_19546(original))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 19489, 19792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 19726, 19777);

                    return f_10463_19733_19776(this, original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 19489, 19792);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 19808, 19855);

                return f_10463_19815_19854(this, original, rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 18850, 19866);

                bool
                f_10463_19493_19546(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                returnStatement)
                {
                    var return_v = ReturnsValueWithinExpressionBodiedConstruct(returnStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 19493, 19546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_19733_19776(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.CollectDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 19733, 19776);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_19815_19854(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 19815, 19854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 18850, 19866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 18850, 19866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ReturnsValueWithinExpressionBodiedConstruct(BoundReturnStatement returnStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 19878, 20633);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 20004, 20593) || true) && (f_10463_20008_20044(returnStatement) && (DynAbs.Tracing.TraceSender.Expression_True(10463, 20008, 20102) && f_10463_20065_20094(returnStatement) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10463, 20008, 20167) && f_10463_20123_20152(returnStatement).Syntax != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 20004, 20593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 20201, 20276);

                    SyntaxKind
                    parentKind = f_10463_20225_20275(f_10463_20225_20268(f_10463_20225_20254(returnStatement).Syntax))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 20294, 20578);

                    switch (parentKind)
                    {

                        case SyntaxKind.ParenthesizedLambdaExpression:
                        case SyntaxKind.SimpleLambdaExpression:
                        case SyntaxKind.ArrowExpressionClause:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 20294, 20578);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 20547, 20559);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 20294, 20578);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 20004, 20593);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 20609, 20622);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 19878, 20633);

                bool
                f_10463_20008_20044(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 20008, 20044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10463_20065_20094(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 20065, 20094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_20123_20152(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 20123, 20152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_20225_20254(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 20225, 20254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode?
                f_10463_20225_20268(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 20225, 20268);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10463_20225_20275(Microsoft.CodeAnalysis.SyntaxNode?
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 20225, 20275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 19878, 20633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 19878, 20633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentSwitchStatement(BoundSwitchStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 20645, 20883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 20783, 20872);

                return f_10463_20790_20871(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentSwitchStatement(original, rewritten), 10463, 20819, 20870));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 20645, 20883);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_20790_20871(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 20790, 20871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 20645, 20883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 20645, 20883);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentSwitchWhenClauseConditionalGotoBody(BoundExpression original, BoundStatement ifConditionGotoBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 20895, 21821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 21058, 21162);

                ifConditionGotoBody = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentSwitchWhenClauseConditionalGotoBody(original, ifConditionGotoBody), 10463, 21080, 21161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 21176, 21262);

                WhenClauseSyntax
                whenClause = f_10463_21206_21261(original.Syntax)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 21276, 21309);

                f_10463_21276_21308(whenClause != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 21480, 21627);

                SyntheticBoundNodeFactory
                statementFactory = f_10463_21525_21626(_method, whenClause, f_10463_21576_21611(_methodBodyFactory), _diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 21703, 21810);

                return f_10463_21710_21809(statementFactory, f_10463_21741_21787(this, whenClause, statementFactory), ifConditionGotoBody);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 20895, 21821);

                Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax?
                f_10463_21206_21261(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.FirstAncestorOrSelf<Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 21206, 21261);
                    return return_v;
                }


                int
                f_10463_21276_21308(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 21276, 21308);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10463_21576_21611(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 21576, 21611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10463_21525_21626(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 21525, 21626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_21741_21787(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.WhenClauseSyntax
                syntaxForSpan, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                statementFactory)
                {
                    var return_v = this_param.AddAnalysisPoint((Microsoft.CodeAnalysis.SyntaxNode)syntaxForSpan, statementFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 21741, 21787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10463_21710_21809(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                first, Microsoft.CodeAnalysis.CSharp.BoundStatement
                second)
                {
                    var return_v = this_param.StatementList(first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 21710, 21809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 20895, 21821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 20895, 21821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundStatement InstrumentUsingTargetCapture(BoundUsingStatement original, BoundStatement usingTargetCapture)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 21833, 22094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 21982, 22083);

                return f_10463_21989_22082(this, original, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InstrumentUsingTargetCapture(original, usingTargetCapture), 10463, 22018, 22081));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 21833, 22094);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_21989_22082(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.AddDynamicAnalysis((Microsoft.CodeAnalysis.CSharp.BoundStatement)original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 21989, 22082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 21833, 22094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 21833, 22094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement AddDynamicAnalysis(BoundStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 22106, 22637);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 22223, 22593) || true) && (f_10463_22227_22257_M(!original.WasCompilerGenerated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 22223, 22593);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 22363, 22578) || true) && (!f_10463_22368_22403(original) || (DynAbs.Tracing.TraceSender.Expression_False(10463, 22367, 22466) || f_10463_22407_22429(original.Syntax) != SyntaxKind.ConstructorDeclaration))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 22363, 22578);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 22508, 22559);

                        return f_10463_22515_22558(this, original, rewritten);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 22363, 22578);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 22223, 22593);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 22609, 22626);

                return rewritten;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 22106, 22637);

                bool
                f_10463_22227_22257_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 22227, 22257);
                    return return_v;
                }


                bool
                f_10463_22368_22403(Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = statement.IsConstructorInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 22368, 22403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10463_22407_22429(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 22407, 22429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_22515_22558(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                original, Microsoft.CodeAnalysis.CSharp.BoundStatement
                rewritten)
                {
                    var return_v = this_param.CollectDynamicAnalysis(original, rewritten);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 22515, 22558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 22106, 22637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 22106, 22637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement CollectDynamicAnalysis(BoundStatement original, BoundStatement rewritten)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 22649, 23218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 22931, 23083);

                SyntheticBoundNodeFactory
                statementFactory = f_10463_22976_23082(_method, original.Syntax, f_10463_23032_23067(_methodBodyFactory), _diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 23097, 23207);

                return f_10463_23104_23206(statementFactory, f_10463_23135_23194(this, f_10463_23152_23175(original), statementFactory), rewritten);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 22649, 23218);

                Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                f_10463_23032_23067(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CompilationState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 23032, 23067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10463_22976_23082(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethod, node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 22976, 23082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10463_23152_23175(Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = SyntaxForSpan(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 23152, 23175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_23135_23194(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntaxForSpan, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                statementFactory)
                {
                    var return_v = this_param.AddAnalysisPoint(syntaxForSpan, statementFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 23135, 23194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList
                f_10463_23104_23206(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                first, Microsoft.CodeAnalysis.CSharp.BoundStatement
                second)
                {
                    var return_v = this_param.StatementList(first, second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 23104, 23206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 22649, 23218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 22649, 23218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Cci.DebugSourceDocument GetSourceDocument(DebugDocumentProvider debugDocumentProvider, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 23230, 23484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 23375, 23473);

                return f_10463_23382_23472(debugDocumentProvider, syntax, f_10463_23431_23471(f_10463_23431_23451(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 23230, 23484);

                Microsoft.CodeAnalysis.Location
                f_10463_23431_23451(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 23431, 23451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10463_23431_23471(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetMappedLineSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 23431, 23471);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_10463_23382_23472(Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.FileLinePositionSpan
                span)
                {
                    var return_v = GetSourceDocument(debugDocumentProvider, syntax, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 23382, 23472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 23230, 23484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 23230, 23484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Cci.DebugSourceDocument GetSourceDocument(DebugDocumentProvider debugDocumentProvider, SyntaxNode syntax, FileLinePositionSpan span)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 23496, 23991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 23668, 23692);

                string
                path = span.Path
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 23805, 23908) || true) && (f_10463_23809_23820(path) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 23805, 23908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 23859, 23893);

                    path = f_10463_23866_23892(f_10463_23866_23883(syntax));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 23805, 23908);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 23924, 23980);

                return f_10463_23931_23979(debugDocumentProvider, path, basePath: "");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 23496, 23991);

                int
                f_10463_23809_23820(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 23809, 23820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10463_23866_23883(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 23866, 23883);
                    return return_v;
                }


                string
                f_10463_23866_23892(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 23866, 23892);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_10463_23931_23979(Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                this_param, string
                path, string
                basePath)
                {
                    var return_v = this_param.Invoke(path, basePath: basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 23931, 23979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 23496, 23991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 23496, 23991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement AddAnalysisPoint(SyntaxNode syntaxForSpan, Text.TextSpan alternateSpan, SyntheticBoundNodeFactory statementFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 24003, 24293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 24166, 24282);

                return f_10463_24173_24281(this, syntaxForSpan, f_10463_24205_24262(f_10463_24205_24229(syntaxForSpan), alternateSpan), statementFactory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 24003, 24293);

                Microsoft.CodeAnalysis.SyntaxTree
                f_10463_24205_24229(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 24205, 24229);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10463_24205_24262(Microsoft.CodeAnalysis.SyntaxTree
                this_param, Microsoft.CodeAnalysis.Text.TextSpan
                span)
                {
                    var return_v = this_param.GetMappedLineSpan(span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 24205, 24262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_24173_24281(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntaxForSpan, Microsoft.CodeAnalysis.FileLinePositionSpan
                span, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                statementFactory)
                {
                    var return_v = this_param.AddAnalysisPoint(syntaxForSpan, span, statementFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 24173, 24281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 24003, 24293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 24003, 24293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement AddAnalysisPoint(SyntaxNode syntaxForSpan, SyntheticBoundNodeFactory statementFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 24305, 24556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 24439, 24545);

                return f_10463_24446_24544(this, syntaxForSpan, f_10463_24478_24525(f_10463_24478_24505(syntaxForSpan)), statementFactory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 24305, 24556);

                Microsoft.CodeAnalysis.Location
                f_10463_24478_24505(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetLocation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 24478, 24505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10463_24478_24525(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetMappedLineSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 24478, 24525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10463_24446_24544(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntaxForSpan, Microsoft.CodeAnalysis.FileLinePositionSpan
                span, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                statementFactory)
                {
                    var return_v = this_param.AddAnalysisPoint(syntaxForSpan, span, statementFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 24446, 24544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 24305, 24556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 24305, 24556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundStatement AddAnalysisPoint(SyntaxNode syntaxForSpan, FileLinePositionSpan span, SyntheticBoundNodeFactory statementFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10463, 24568, 25512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 24778, 24815);

                int
                spansIndex = f_10463_24795_24814(_spansBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 24829, 25135);

                f_10463_24829_25134(_spansBuilder, f_10463_24847_25133(f_10463_24880_24942(_debugDocumentProvider, syntaxForSpan, span), span.StartLinePosition.Line, span.StartLinePosition.Character, span.EndLinePosition.Line, span.EndLinePosition.Character));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 25207, 25405);

                BoundArrayAccess
                payloadCell =
                f_10463_25255_25404(statementFactory, f_10463_25306_25344(statementFactory, _methodPayload), f_10463_25367_25403(statementFactory, spansIndex))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 25421, 25501);

                return f_10463_25428_25500(statementFactory, payloadCell, f_10463_25469_25499(statementFactory, true));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10463, 24568, 25512);

                int
                f_10463_24795_24814(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 24795, 24814);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_10463_24880_24942(Microsoft.CodeAnalysis.CodeGen.DebugDocumentProvider
                debugDocumentProvider, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.FileLinePositionSpan
                span)
                {
                    var return_v = GetSourceDocument(debugDocumentProvider, syntax, span);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 24880, 24942);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.SourceSpan
                f_10463_24847_25133(Microsoft.Cci.DebugSourceDocument
                document, int
                startLine, int
                startColumn, int
                endLine, int
                endColumn)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.SourceSpan(document, startLine, startColumn, endLine, endColumn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 24847, 25133);
                    return return_v;
                }


                int
                f_10463_24829_25134(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
                this_param, Microsoft.CodeAnalysis.CodeGen.SourceSpan
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 24829, 25134);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10463_25306_25344(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 25306, 25344);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10463_25367_25403(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 25367, 25403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                f_10463_25255_25404(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                array, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                indices)
                {
                    var return_v = this_param.ArrayAccess((Microsoft.CodeAnalysis.CSharp.BoundExpression)array, indices);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 25255, 25404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10463_25469_25499(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 25469, 25499);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10463_25428_25500(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 25428, 25500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 24568, 25512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 24568, 25512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxNode SyntaxForSpan(BoundStatement statement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 25524, 27354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 25614, 25639);

                SyntaxNode
                syntaxForSpan
                = default(SyntaxNode);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 25655, 27306);

                switch (f_10463_25663_25677(statement))
                {

                    case BoundKind.IfStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 25655, 27306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 25760, 25823);

                        syntaxForSpan = f_10463_25776_25815(((BoundIfStatement)statement)).Syntax;
                        DynAbs.Tracing.TraceSender.TraceBreak(10463, 25845, 25851);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 25655, 27306);

                    case BoundKind.WhileStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 25655, 27306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 25921, 25987);

                        syntaxForSpan = f_10463_25937_25979(((BoundWhileStatement)statement)).Syntax;
                        DynAbs.Tracing.TraceSender.TraceBreak(10463, 26009, 26015);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 25655, 27306);

                    case BoundKind.ForEachStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 25655, 27306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 26087, 26156);

                        syntaxForSpan = f_10463_26103_26148(((BoundForEachStatement)statement)).Syntax;
                        DynAbs.Tracing.TraceSender.TraceBreak(10463, 26178, 26184);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 25655, 27306);

                    case BoundKind.DoStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 25655, 27306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 26251, 26314);

                        syntaxForSpan = f_10463_26267_26306(((BoundDoStatement)statement)).Syntax;
                        DynAbs.Tracing.TraceSender.TraceBreak(10463, 26336, 26342);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 25655, 27306);

                    case BoundKind.UsingStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 25655, 27306);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 26439, 26507);

                            BoundUsingStatement
                            usingStatement = (BoundUsingStatement)statement
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 26533, 26632);

                            syntaxForSpan = ((BoundNode)f_10463_26561_26589(usingStatement) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundNode?>(10463, 26550, 26623) ?? f_10463_26593_26623(usingStatement))).Syntax;
                            DynAbs.Tracing.TraceSender.TraceBreak(10463, 26658, 26664);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 25655, 27306);

                    case BoundKind.FixedStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 25655, 27306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 26757, 26826);

                        syntaxForSpan = f_10463_26773_26818(((BoundFixedStatement)statement)).Syntax;
                        DynAbs.Tracing.TraceSender.TraceBreak(10463, 26848, 26854);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 25655, 27306);

                    case BoundKind.LockStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 25655, 27306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 26923, 26987);

                        syntaxForSpan = f_10463_26939_26979(((BoundLockStatement)statement)).Syntax;
                        DynAbs.Tracing.TraceSender.TraceBreak(10463, 27009, 27015);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 25655, 27306);

                    case BoundKind.SwitchStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 25655, 27306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 27086, 27154);

                        syntaxForSpan = f_10463_27102_27146(((BoundSwitchStatement)statement)).Syntax;
                        DynAbs.Tracing.TraceSender.TraceBreak(10463, 27176, 27182);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 25655, 27306);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 25655, 27306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 27230, 27263);

                        syntaxForSpan = statement.Syntax;
                        DynAbs.Tracing.TraceSender.TraceBreak(10463, 27285, 27291);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 25655, 27306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 27322, 27343);

                return syntaxForSpan;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 25524, 27354);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10463_25663_25677(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 25663, 25677);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_25776_25815(Microsoft.CodeAnalysis.CSharp.BoundIfStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 25776, 25815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_25937_25979(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 25937, 25979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_26103_26148(Microsoft.CodeAnalysis.CSharp.BoundForEachStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 26103, 26148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_26267_26306(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 26267, 26306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10463_26561_26589(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 26561, 26589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations?
                f_10463_26593_26623(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.DeclarationsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 26593, 26623);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations
                f_10463_26773_26818(Microsoft.CodeAnalysis.CSharp.BoundFixedStatement
                this_param)
                {
                    var return_v = this_param.Declarations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 26773, 26818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_26939_26979(Microsoft.CodeAnalysis.CSharp.BoundLockStatement
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 26939, 26979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10463_27102_27146(Microsoft.CodeAnalysis.CSharp.BoundSwitchStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 27102, 27146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 25524, 27354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 25524, 27354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodSymbol GetCreatePayloadOverload(CSharpCompilation compilation, WellKnownMember overload, SyntaxNode syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 27366, 27660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 27546, 27649);

                return (MethodSymbol)f_10463_27567_27648(compilation, overload, diagnostics, syntax: syntax);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 27366, 27660);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10463_27567_27648(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.WellKnownMember
                member, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = Binder.GetWellKnownTypeMember(compilation, member, diagnostics, syntax: syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 27567, 27648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 27366, 27660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 27366, 27660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SyntaxNode MethodDeclarationIfAvailable(SyntaxNode body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 27672, 28441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 27768, 27800);

                SyntaxNode
                parent = f_10463_27788_27799(body)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 27816, 28402) || true) && (parent != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 27816, 28402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 27868, 28387);

                    switch (f_10463_27876_27889(parent))
                    {

                        case SyntaxKind.MethodDeclaration:
                        case SyntaxKind.PropertyDeclaration:
                        case SyntaxKind.GetAccessorDeclaration:
                        case SyntaxKind.SetAccessorDeclaration:
                        case SyntaxKind.InitAccessorDeclaration:
                        case SyntaxKind.ConstructorDeclaration:
                        case SyntaxKind.OperatorDeclaration:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 27868, 28387);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 28354, 28368);

                            return parent;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 27868, 28387);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 27816, 28402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 28418, 28430);

                return body;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 27672, 28441);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10463_27788_27799(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 27788, 27799);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10463_27876_27889(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 27876, 27889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 27672, 28441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 27672, 28441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Text.TextSpan SkipAttributes(SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 28579, 30400);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 28666, 30354);

                switch (f_10463_28674_28687(syntax))
                {

                    case SyntaxKind.MethodDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 28666, 30354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 28777, 28848);

                        MethodDeclarationSyntax
                        methodSyntax = (MethodDeclarationSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 28870, 29000);

                        return f_10463_28877_28999(syntax, f_10463_28900_28927(methodSyntax), f_10463_28929_28951(methodSyntax), default(SyntaxToken), f_10463_28975_28998(methodSyntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 28666, 30354);

                    case SyntaxKind.PropertyDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 28666, 30354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 29078, 29155);

                        PropertyDeclarationSyntax
                        propertySyntax = (PropertyDeclarationSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 29177, 29307);

                        return f_10463_29184_29306(syntax, f_10463_29207_29236(propertySyntax), f_10463_29238_29262(propertySyntax), default(SyntaxToken), f_10463_29286_29305(propertySyntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 28666, 30354);

                    case SyntaxKind.GetAccessorDeclaration:
                    case SyntaxKind.SetAccessorDeclaration:
                    case SyntaxKind.InitAccessorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 28666, 30354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 29503, 29580);

                        AccessorDeclarationSyntax
                        accessorSyntax = (AccessorDeclarationSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 29602, 29719);

                        return f_10463_29609_29718(syntax, f_10463_29632_29661(accessorSyntax), f_10463_29663_29687(accessorSyntax), f_10463_29689_29711(accessorSyntax), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 28666, 30354);

                    case SyntaxKind.ConstructorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 28666, 30354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 29800, 29886);

                        ConstructorDeclarationSyntax
                        constructorSyntax = (ConstructorDeclarationSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 29908, 30037);

                        return f_10463_29915_30036(syntax, f_10463_29938_29970(constructorSyntax), f_10463_29972_29999(constructorSyntax), f_10463_30001_30029(constructorSyntax), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 28666, 30354);

                    case SyntaxKind.OperatorDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 28666, 30354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 30115, 30192);

                        OperatorDeclarationSyntax
                        operatorSyntax = (OperatorDeclarationSyntax)syntax
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 30214, 30339);

                        return f_10463_30221_30338(syntax, f_10463_30244_30273(operatorSyntax), f_10463_30275_30299(operatorSyntax), f_10463_30301_30331(operatorSyntax), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 28666, 30354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 30370, 30389);

                return f_10463_30377_30388(syntax);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 28579, 30400);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10463_28674_28687(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 28674, 28687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10463_28900_28927(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 28900, 28927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10463_28929_28951(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 28929, 28951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10463_28975_28998(Microsoft.CodeAnalysis.CSharp.Syntax.MethodDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 28975, 28998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10463_28877_28999(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributes, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                keyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type)
                {
                    var return_v = SkipAttributes(syntax, attributes, modifiers, keyword, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 28877, 28999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10463_29207_29236(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 29207, 29236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10463_29238_29262(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 29238, 29262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10463_29286_29305(Microsoft.CodeAnalysis.CSharp.Syntax.PropertyDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 29286, 29305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10463_29184_29306(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributes, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                keyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type)
                {
                    var return_v = SkipAttributes(syntax, attributes, modifiers, keyword, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 29184, 29306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10463_29632_29661(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 29632, 29661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10463_29663_29687(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 29663, 29687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10463_29689_29711(Microsoft.CodeAnalysis.CSharp.Syntax.AccessorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Keyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 29689, 29711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10463_29609_29718(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributes, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                keyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type)
                {
                    var return_v = SkipAttributes(syntax, attributes, modifiers, keyword, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 29609, 29718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10463_29938_29970(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 29938, 29970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10463_29972_29999(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 29972, 29999);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10463_30001_30029(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 30001, 30029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10463_29915_30036(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributes, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                keyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type)
                {
                    var return_v = SkipAttributes(syntax, attributes, modifiers, keyword, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 29915, 30036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                f_10463_30244_30273(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.AttributeLists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 30244, 30273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTokenList
                f_10463_30275_30299(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Modifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 30275, 30299);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10463_30301_30331(Microsoft.CodeAnalysis.CSharp.Syntax.OperatorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.OperatorKeyword;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 30301, 30331);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10463_30221_30338(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.AttributeListSyntax>
                attributes, Microsoft.CodeAnalysis.SyntaxTokenList
                modifiers, Microsoft.CodeAnalysis.SyntaxToken
                keyword, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                type)
                {
                    var return_v = SkipAttributes(syntax, attributes, modifiers, keyword, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 30221, 30338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10463_30377_30388(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 30377, 30388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 28579, 30400);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 28579, 30400);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Text.TextSpan SkipAttributes(SyntaxNode syntax, SyntaxList<AttributeListSyntax> attributes, SyntaxTokenList modifiers, SyntaxToken keyword, TypeSyntax type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10463, 30412, 31023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 30608, 30649);

                Text.TextSpan
                originalSpan = f_10463_30637_30648(syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 30663, 30976) || true) && (attributes.Count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10463, 30663, 30976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 30721, 30839);

                    Text.TextSpan
                    startSpan = (DynAbs.Tracing.TraceSender.Conditional_F1(10463, 30747, 30769) || ((modifiers.Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(10463, 30772, 30786)) || DynAbs.Tracing.TraceSender.Conditional_F3(10463, 30789, 30838))) ? modifiers.Span : ((DynAbs.Tracing.TraceSender.Conditional_F1(10463, 30790, 30810) || ((keyword.Node != null && DynAbs.Tracing.TraceSender.Conditional_F2(10463, 30813, 30825)) || DynAbs.Tracing.TraceSender.Conditional_F3(10463, 30828, 30837))) ? keyword.Span : f_10463_30828_30837(type))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 30857, 30961);

                    return f_10463_30864_30960(startSpan.Start, originalSpan.Length - (startSpan.Start - originalSpan.Start));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10463, 30663, 30976);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10463, 30992, 31012);

                return originalSpan;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10463, 30412, 31023);

                Microsoft.CodeAnalysis.Text.TextSpan
                f_10463_30637_30648(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 30637, 30648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10463_30828_30837(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 30828, 30837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10463_30864_30960(int
                start, int
                length)
                {
                    var return_v = new Microsoft.CodeAnalysis.Text.TextSpan(start, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 30864, 30960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10463, 30412, 31023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 30412, 31023);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicAnalysisInjector()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10463, 801, 31030);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10463, 801, 31030);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10463, 801, 31030);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10463, 801, 31030);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SourceSpan>
        f_10463_5116_5154()
        {
            var return_v = ArrayBuilder<SourceSpan>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 5116, 5154);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10463_5201_5258(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.SpecialType
        st)
        {
            var return_v = this_param.SpecialType(st);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 5201, 5258);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10463_5322_5351(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.Compilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 5322, 5351);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10463_5322_5360(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        this_param)
        {
            var return_v = this_param.Assembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 5322, 5360);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        f_10463_5288_5409(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        elementTypeWithAnnotations)
        {
            var return_v = ArrayTypeSymbol.CreateCSharpArray(declaringAssembly, elementTypeWithAnnotations);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 5288, 5409);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        f_10463_5678_5711(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param)
        {
            var return_v = this_param.CurrentFunction;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 5678, 5711);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
        f_10463_5802_5928(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
        type, Microsoft.CodeAnalysis.SynthesizedLocalKind
        kind, Microsoft.CodeAnalysis.SyntaxNode
        syntax)
        {
            var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, kind: kind, syntax: syntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 5802, 5928);
            return return_v;
        }


        Microsoft.CodeAnalysis.SyntaxNode
        f_10463_6070_6117(Microsoft.CodeAnalysis.SyntaxNode
        body)
        {
            var return_v = MethodDeclarationIfAvailable(body);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 6070, 6117);
            return return_v;
        }


        bool
        f_10463_6136_6164_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10463, 6136, 6164);
            return return_v;
        }


        Microsoft.CodeAnalysis.Text.TextSpan
        f_10463_6310_6332(Microsoft.CodeAnalysis.SyntaxNode
        syntax)
        {
            var return_v = SkipAttributes(syntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 6310, 6332);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.BoundStatement
        f_10463_6285_6352(Microsoft.CodeAnalysis.CSharp.DynamicAnalysisInjector
        this_param, Microsoft.CodeAnalysis.SyntaxNode
        syntaxForSpan, Microsoft.CodeAnalysis.Text.TextSpan
        alternateSpan, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        statementFactory)
        {
            var return_v = this_param.AddAnalysisPoint(syntaxForSpan, alternateSpan, statementFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10463, 6285, 6352);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Instrumenter
        f_10463_4788_4796_C(Microsoft.CodeAnalysis.CSharp.Instrumenter
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10463, 4341, 6473);
            return return_v;
        }

    }
}
