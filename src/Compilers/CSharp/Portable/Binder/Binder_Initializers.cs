// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal struct ProcessedFieldInitializers
        {

            internal ImmutableArray<BoundInitializer> BoundInitializers { get; set; }

            internal BoundStatement? LoweredInitializers { get; set; }

            internal NullableWalker.VariableState AfterInitializersState;

            internal bool HasErrors { get; set; }

            internal ImportChain? FirstImportChain { get; set; }
            static ProcessedFieldInitializers()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10308, 549, 964);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10308, 549, 964);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10308, 549, 964);
            }
        }

        internal static void BindFieldInitializers(
                    CSharpCompilation compilation,
                    SynthesizedInteractiveInitializerMethod? scriptInitializerOpt,
                    ImmutableArray<ImmutableArray<FieldOrPropertyInitializer>> fieldInitializers,
                    DiagnosticBag diagnostics,
                    ref ProcessedFieldInitializers processedInitializers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10308, 976, 1943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 1362, 1425);

                var
                diagsForInstanceInitializers = f_10308_1397_1424()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 1439, 1469);

                ImportChain?
                firstImportChain
                = default(ImportChain?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 1483, 1653);

                processedInitializers.BoundInitializers = f_10308_1525_1652(compilation, scriptInitializerOpt, fieldInitializers, diagsForInstanceInitializers, out firstImportChain);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 1667, 1745);

                processedInitializers.HasErrors = f_10308_1701_1744(diagsForInstanceInitializers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 1759, 1817);

                processedInitializers.FirstImportChain = firstImportChain;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 1831, 1882);

                f_10308_1831_1881(diagnostics, diagsForInstanceInitializers);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 1896, 1932);

                f_10308_1896_1931(diagsForInstanceInitializers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10308, 976, 1943);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10308_1397_1424()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 1397, 1424);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                f_10308_1525_1652(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod?
                scriptInitializerOpt, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                initializers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.ImportChain?
                firstImportChain)
                {
                    var return_v = BindFieldInitializers(compilation, scriptInitializerOpt, initializers, diagnostics, out firstImportChain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 1525, 1652);
                    return return_v;
                }


                bool
                f_10308_1701_1744(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 1701, 1744);
                    return return_v;
                }


                int
                f_10308_1831_1881(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 1831, 1881);
                    return 0;
                }


                int
                f_10308_1896_1931(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 1896, 1931);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10308, 976, 1943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10308, 976, 1943);
            }
        }

        internal static ImmutableArray<BoundInitializer> BindFieldInitializers(
                    CSharpCompilation compilation,
                    SynthesizedInteractiveInitializerMethod? scriptInitializerOpt,
                    ImmutableArray<ImmutableArray<FieldOrPropertyInitializer>> initializers,
                    DiagnosticBag diagnostics,
                    out ImportChain? firstImportChain)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10308, 1955, 3070);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 2345, 2506) || true) && (initializers.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 2345, 2506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 2403, 2427);

                    firstImportChain = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 2445, 2491);

                    return ImmutableArray<BoundInitializer>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 2345, 2506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 2522, 2591);

                var
                boundInitializers = f_10308_2546_2590()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 2605, 2999) || true) && (scriptInitializerOpt is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 2605, 2999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 2671, 2787);

                    f_10308_2671_2786(compilation, initializers, boundInitializers, diagnostics, out firstImportChain);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 2605, 2999);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 2605, 2999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 2853, 2984);

                    f_10308_2853_2983(compilation, scriptInitializerOpt, initializers, boundInitializers, diagnostics, out firstImportChain);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 2605, 2999);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 3013, 3059);

                return f_10308_3020_3058(boundInitializers);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10308, 1955, 3070);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                f_10308_2546_2590()
                {
                    var return_v = ArrayBuilder<BoundInitializer>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 2546, 2590);
                    return return_v;
                }


                int
                f_10308_2671_2786(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                initializers, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                boundInitializers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.ImportChain?
                firstDebugImports)
                {
                    BindRegularCSharpFieldInitializers(compilation, initializers, boundInitializers, diagnostics, out firstDebugImports);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 2671, 2786);
                    return 0;
                }


                int
                f_10308_2853_2983(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                scriptInitializer, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                initializers, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                boundInitializers, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out Microsoft.CodeAnalysis.CSharp.ImportChain?
                firstDebugImports)
                {
                    BindScriptFieldInitializers(compilation, scriptInitializer, initializers, boundInitializers, diagnostics, out firstDebugImports);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 2853, 2983);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                f_10308_3020_3058(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 3020, 3058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10308, 1955, 3070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10308, 1955, 3070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void BindRegularCSharpFieldInitializers(
                    CSharpCompilation compilation,
                    ImmutableArray<ImmutableArray<FieldOrPropertyInitializer>> initializers,
                    ArrayBuilder<BoundInitializer> boundInitializers,
                    DiagnosticBag diagnostics,
                    out ImportChain? firstDebugImports)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10308, 3284, 7401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 3647, 3672);

                firstDebugImports = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 3688, 7390);
                    foreach (ImmutableArray<FieldOrPropertyInitializer> siblingInitializers in f_10308_3763_3775_I(initializers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 3688, 7390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 4130, 4166);

                        BinderFactory?
                        binderFactory = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 4186, 7375);
                            foreach (FieldOrPropertyInitializer initializer in f_10308_4237_4256_I(siblingInitializers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 4186, 7375);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 4298, 4345);

                                FieldSymbol
                                fieldSymbol = initializer.FieldOpt
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 4367, 4409);

                                f_10308_4367_4408((object)fieldSymbol != null);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 4693, 7356) || true) && (f_10308_4697_4728_M(!fieldSymbol.IsMetadataConstant))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 4693, 7356);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 4913, 4960);

                                    SyntaxReference
                                    syntaxRef = initializer.Syntax
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 4988, 7333);

                                    switch (f_10308_4996_5017(syntaxRef))
                                    {

                                        case EqualsValueClauseSyntax initializerNode:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 4988, 7333);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 5154, 5355) || true) && (binderFactory == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 5154, 5355);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 5253, 5320);

                                                binderFactory = f_10308_5269_5319(compilation, f_10308_5298_5318(syntaxRef));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 5154, 5355);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 5391, 5454);

                                            Binder
                                            parentBinder = f_10308_5413_5453(binderFactory, initializerNode)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 5490, 5673) || true) && (firstDebugImports == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 5490, 5673);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 5593, 5638);

                                                firstDebugImports = f_10308_5613_5637(parentBinder);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 5490, 5673);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 5709, 5776);

                                            parentBinder = f_10308_5724_5775(parentBinder, fieldSymbol);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 5812, 5931);

                                            BoundFieldEqualsValue
                                            boundInitializer = f_10308_5853_5930(parentBinder, fieldSymbol, initializerNode, diagnostics)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 5965, 6005);

                                            f_10308_5965_6004(boundInitializers, boundInitializer);
                                            DynAbs.Tracing.TraceSender.TraceBreak(10308, 6039, 6045);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 4988, 7333);

                                        case ParameterSyntax parameterSyntax: // Initializer for a generated property based on record parameters
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 4988, 7333);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 6217, 6681) || true) && (firstDebugImports == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 6217, 6681);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 6320, 6533) || true) && (binderFactory == null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 6320, 6533);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 6427, 6494);

                                                    binderFactory = f_10308_6443_6493(compilation, f_10308_6472_6492(syntaxRef));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 6320, 6533);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 6573, 6646);

                                                firstDebugImports = f_10308_6593_6645(f_10308_6593_6633(binderFactory, parameterSyntax));
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 6217, 6681);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 6717, 7155);

                                            f_10308_6717_7154(
                                                                            boundInitializers, f_10308_6739_7153(parameterSyntax, fieldSymbol, ImmutableArray<LocalSymbol>.Empty, f_10308_6911_7152(f_10308_6911_7128(parameterSyntax, f_10308_7047_7127(((SynthesizedRecordPropertySymbol)f_10308_7081_7109(fieldSymbol)))))));
                                            DynAbs.Tracing.TraceSender.TraceBreak(10308, 7189, 7195);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 4988, 7333);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 4988, 7333);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 7269, 7306);

                                            throw f_10308_7275_7305();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 4988, 7333);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 4693, 7356);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 4186, 7375);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10308, 1, 3190);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10308, 1, 3190);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 3688, 7390);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10308, 1, 3703);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10308, 1, 3703);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10308, 3284, 7401);

                int
                f_10308_4367_4408(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 4367, 4408);
                    return 0;
                }


                bool
                f_10308_4697_4728_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 4697, 4728);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10308_4996_5017(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 4996, 5017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10308_5298_5318(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 5298, 5318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10308_5269_5319(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 5269, 5319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10308_5413_5453(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 5413, 5453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ImportChain?
                f_10308_5613_5637(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ImportChain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 5613, 5637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10308_5724_5775(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol)
                {
                    var return_v = this_param.GetFieldInitializerBinder(fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 5724, 5775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                f_10308_5853_5930(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                equalsValueClauseNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = BindFieldInitializer(binder, fieldSymbol, equalsValueClauseNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 5853, 5930);
                    return return_v;
                }


                int
                f_10308_5965_6004(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundInitializer)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 5965, 6004);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10308_6472_6492(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 6472, 6492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10308_6443_6493(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 6443, 6493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10308_6593_6633(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 6593, 6633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ImportChain?
                f_10308_6593_6645(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ImportChain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 6593, 6645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10308_7081_7109(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 7081, 7109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                f_10308_7047_7127(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordPropertySymbol
                this_param)
                {
                    var return_v = this_param.BackingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 7047, 7127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10308_6911_7128(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceParameterSymbol
                parameterSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundParameter((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)parameterSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 6911, 7128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10308_6911_7152(Microsoft.CodeAnalysis.CSharp.BoundParameter
                node)
                {
                    var return_v = node.MakeCompilerGenerated<Microsoft.CodeAnalysis.CSharp.BoundParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 6911, 7152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                f_10308_6739_7153(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundParameter
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue((Microsoft.CodeAnalysis.SyntaxNode)syntax, field, locals, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 6739, 7153);
                    return return_v;
                }


                int
                f_10308_6717_7154(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundInitializer)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 6717, 7154);
                    return 0;
                }


                System.Exception
                f_10308_7275_7305()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 7275, 7305);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>
                f_10308_4237_4256_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 4237, 4256);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                f_10308_3763_3775_I(System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.FieldOrPropertyInitializer>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 3763, 3775);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10308, 3284, 7401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10308, 3284, 7401);
            }
        }

        internal Binder GetFieldInitializerBinder(FieldSymbol fieldSymbol, bool suppressBinderFlagsFieldInitializer = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10308, 7413, 8437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 7554, 7821);

                f_10308_7554_7820((f_10308_7568_7592() is TypeSymbol containing && (DynAbs.Tracing.TraceSender.Expression_True(10308, 7568, 7715) && f_10308_7621_7715(containing, f_10308_7651_7677(fieldSymbol), TypeCompareKind.ConsiderEverything2))) || (DynAbs.Tracing.TraceSender.Expression_False(10308, 7567, 7819) || f_10308_7777_7819(f_10308_7777_7803(fieldSymbol))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 7916, 7937);

                Binder
                binder = this
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 7953, 8227) || true) && (f_10308_7957_7978_M(!fieldSymbol.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10308, 7957, 8130) && f_10308_7982_8087(f_10308_7982_8030(f_10308_7982_8008(fieldSymbol)).OfType<SynthesizedRecordConstructor>()) is SynthesizedRecordConstructor recordCtor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 7953, 8227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 8164, 8212);

                    binder = f_10308_8173_8211(recordCtor, binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 7953, 8227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 8243, 8426);

                return f_10308_8250_8425(f_10308_8250_8278(binder), (DynAbs.Tracing.TraceSender.Conditional_F1(10308, 8326, 8361) || ((suppressBinderFlagsFieldInitializer && DynAbs.Tracing.TraceSender.Conditional_F2(10308, 8364, 8380)) || DynAbs.Tracing.TraceSender.Conditional_F3(10308, 8383, 8411))) ? BinderFlags.None : BinderFlags.FieldInitializer, fieldSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10308, 7413, 8437);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10308_7568_7592()
                {
                    var return_v = ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 7568, 7592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10308_7651_7677(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 7651, 7677);
                    return return_v;
                }


                bool
                f_10308_7621_7715(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 7621, 7715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10308_7777_7803(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 7777, 7803);
                    return return_v;
                }


                bool
                f_10308_7777_7819(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 7777, 7819);
                    return return_v;
                }


                int
                f_10308_7554_7820(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 7554, 7820);
                    return 0;
                }


                bool
                f_10308_7957_7978_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 7957, 7978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10308_7982_8008(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 7982, 8008);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10308_7982_8030(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 7982, 8030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                f_10308_7982_8087(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor>
                source)
                {
                    var return_v = source.SingleOrDefault<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 7982, 8087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InMethodBinder
                f_10308_8173_8211(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                owner, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InMethodBinder((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)owner, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 8173, 8211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                f_10308_8250_8278(Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalScopeBinder(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 8250, 8278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10308_8250_8425(Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 8250, 8425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10308, 7413, 8437);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10308, 7413, 8437);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void BindScriptFieldInitializers(
                    CSharpCompilation compilation,
                    SynthesizedInteractiveInitializerMethod scriptInitializer,
                    ImmutableArray<ImmutableArray<FieldOrPropertyInitializer>> initializers,
                    ArrayBuilder<BoundInitializer> boundInitializers,
                    DiagnosticBag diagnostics,
                    out ImportChain? firstDebugImports)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10308, 8678, 12566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9105, 9130);

                firstDebugImports = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9155, 9160);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9146, 12555) || true) && (i < initializers.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9187, 9190)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 9146, 12555))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 9146, 12555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9224, 9305);

                        ImmutableArray<FieldOrPropertyInitializer>
                        siblingInitializers = initializers[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9646, 9682);

                        BinderFactory?
                        binderFactory = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9781, 9826);

                        ScriptLocalScopeBinder.Labels?
                        labels = null
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9855, 9860);

                            for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9846, 12540) || true) && (j < siblingInitializers.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9894, 9897)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 9846, 12540))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 9846, 12540);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 9939, 9980);

                                var
                                initializer = siblingInitializers[j]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10002, 10041);

                                var
                                fieldSymbol = initializer.FieldOpt
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10065, 10271) || true) && ((object)fieldSymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(10308, 10069, 10119) && f_10308_10100_10119(fieldSymbol)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 10065, 10271);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10239, 10248);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 10065, 10271);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10295, 10330);

                                var
                                syntaxRef = initializer.Syntax
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10352, 10390);

                                var
                                syntaxTree = f_10308_10369_10389(syntaxRef)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10412, 10476);

                                f_10308_10412_10475(f_10308_10425_10448(f_10308_10425_10443(syntaxTree)) != SourceCodeKind.Regular);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10500, 10553);

                                var
                                syntax = (CSharpSyntaxNode)f_10308_10531_10552(syntaxRef)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10575, 10628);

                                var
                                syntaxRoot = syntaxTree.GetCompilationUnitRoot()
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10652, 10907) || true) && (binderFactory == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 10652, 10907);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10727, 10784);

                                    binderFactory = f_10308_10743_10783(compilation, syntaxTree);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10810, 10884);

                                    labels = f_10308_10819_10883(scriptInitializer, syntaxRoot);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 10652, 10907);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 10931, 10990);

                                Binder
                                scriptClassBinder = f_10308_10958_10989(binderFactory, syntax)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 11012, 11112);

                                f_10308_11012_11111(f_10308_11025_11067(scriptClassBinder) is NamedTypeSymbol { IsScriptClass: true });

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 11136, 11288) || true) && (firstDebugImports == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 11136, 11288);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 11215, 11265);

                                    firstDebugImports = f_10308_11235_11264(scriptClassBinder);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 11136, 11288);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 11312, 11521);

                                Binder
                                parentBinder = f_10308_11334_11520(syntaxRoot, scriptInitializer, f_10308_11466_11519(labels, scriptClassBinder))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 11545, 11579);

                                BoundInitializer
                                boundInitializer
                                = default(BoundInitializer);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 11601, 12457) || true) && ((object?)fieldSymbol != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 11601, 12457);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 11683, 12003);

                                    boundInitializer = f_10308_11702_12002(f_10308_11753_11855(parentBinder, BinderFlags.FieldInitializer, fieldSymbol), fieldSymbol, syntax, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 11601, 12457);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 11601, 12457);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 12101, 12434);

                                    boundInitializer = f_10308_12120_12433(parentBinder, scriptInitializer, syntax, diagnostics, isLast: i == initializers.Length - 1 && (DynAbs.Tracing.TraceSender.Expression_True(10308, 12365, 12432) && j == siblingInitializers.Length - 1));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 11601, 12457);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 12481, 12521);

                                f_10308_12481_12520(
                                                    boundInitializers, boundInitializer);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10308, 1, 2695);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10308, 1, 2695);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10308, 1, 3410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10308, 1, 3410);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10308, 8678, 12566);

                bool
                f_10308_10100_10119(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsConst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 10100, 10119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10308_10369_10389(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 10369, 10389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ParseOptions
                f_10308_10425_10443(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 10425, 10443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceCodeKind
                f_10308_10425_10448(Microsoft.CodeAnalysis.ParseOptions
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 10425, 10448);
                    return return_v;
                }


                int
                f_10308_10412_10475(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 10412, 10475);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10308_10531_10552(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 10531, 10552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10308_10743_10783(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 10743, 10783);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels
                f_10308_10819_10883(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                scriptInitializer, Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels(scriptInitializer, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 10819, 10883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10308_10958_10989(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetBinder((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 10958, 10989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10308_11025_11067(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 11025, 11067);
                    return return_v;
                }


                int
                f_10308_11012_11111(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 11012, 11111);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.ImportChain?
                f_10308_11235_11264(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ImportChain;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 11235, 11264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder
                f_10308_11466_11519(Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder.Labels?
                labels, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder(labels, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 11466, 11519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10308_11334_11520(Microsoft.CodeAnalysis.CSharp.Syntax.CompilationUnitSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                memberSymbol, Microsoft.CodeAnalysis.CSharp.ScriptLocalScopeBinder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, (Microsoft.CodeAnalysis.CSharp.Binder)next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 11334, 11520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10308_11753_11855(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                containing)
                {
                    var return_v = this_param.WithAdditionalFlagsAndContainingMemberOrLambda(flags, (Microsoft.CodeAnalysis.CSharp.Symbol)containing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 11753, 11855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                f_10308_11702_12002(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                equalsValueClauseNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = BindFieldInitializer(binder, fieldSymbol, (Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax)equalsValueClauseNode, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 11702, 12002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundInitializer
                f_10308_12120_12433(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                scriptInitializer, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                statementNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                isLast)
                {
                    var return_v = BindGlobalStatement(binder, scriptInitializer, (Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax)statementNode, diagnostics, isLast: isLast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 12120, 12433);
                    return return_v;
                }


                int
                f_10308_12481_12520(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundInitializer>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundInitializer
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 12481, 12520);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10308, 8678, 12566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10308, 8678, 12566);
            }
        }

        private static BoundInitializer BindGlobalStatement(
                    Binder binder,
                    SynthesizedInteractiveInitializerMethod scriptInitializer,
                    StatementSyntax statementNode,
                    DiagnosticBag diagnostics,
                    bool isLast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10308, 12578, 14883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 12865, 12930);

                var
                statement = f_10308_12881_12929(binder, statementNode, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 12944, 14787) || true) && (isLast && (DynAbs.Tracing.TraceSender.Expression_True(10308, 12948, 12981) && f_10308_12958_12981_M(!statement.HasAnyErrors)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 12944, 14787);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 13133, 13916) || true) && (f_10308_13137_13168(f_10308_13137_13155(binder)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 13133, 13916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 13308, 13384);

                        var
                        expression = f_10308_13325_13383(statement)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 13406, 13897) || true) && (expression != null && (DynAbs.Tracing.TraceSender.Expression_True(10308, 13410, 13524) && ((object?)f_10308_13467_13482(expression) == null || (DynAbs.Tracing.TraceSender.Expression_False(10308, 13458, 13523) || !f_10308_13495_13523(f_10308_13495_13510(expression))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 13406, 13897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 13574, 13630);

                            var
                            submissionResultType = f_10308_13601_13629(scriptInitializer)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 13656, 13755);

                            expression = f_10308_13669_13754(binder, submissionResultType, expression, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 13781, 13874);

                            statement = f_10308_13793_13873(statement.Syntax, expression, f_10308_13852_13872(expression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 13406, 13897);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 13133, 13916);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 14062, 14772) || true) && (f_10308_14066_14080(statement) == BoundKind.LabeledStatement)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 14062, 14772);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 14152, 14219);

                        var
                        labeledStatementBody = f_10308_14179_14218(((BoundLabeledStatement)statement))
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 14241, 14450) || true) && (f_10308_14248_14273(labeledStatementBody) == BoundKind.LabeledStatement)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 14241, 14450);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 14353, 14427);

                                labeledStatementBody = f_10308_14376_14426(((BoundLabeledStatement)labeledStatementBody));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 14241, 14450);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10308, 14241, 14450);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10308, 14241, 14450);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 14474, 14753) || true) && (f_10308_14478_14547(labeledStatementBody) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 14474, 14753);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 14605, 14730);

                            f_10308_14605_14729(diagnostics, ErrorCode.ERR_SemicolonExpected, f_10308_14657_14728(((ExpressionStatementSyntax)labeledStatementBody.Syntax)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 14474, 14753);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 14062, 14772);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 12944, 14787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 14803, 14872);

                return f_10308_14810_14871(statementNode, statement);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10308, 12578, 14883);

                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10308_12881_12929(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindStatement(node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 12881, 12929);
                    return return_v;
                }


                bool
                f_10308_12958_12981_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 12958, 12981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10308_13137_13155(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 13137, 13155);
                    return return_v;
                }


                bool
                f_10308_13137_13168(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.IsSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 13137, 13168);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10308_13325_13383(Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = InitializerRewriter.GetTrailingScriptExpression(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 13325, 13383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10308_13467_13482(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 13467, 13482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10308_13495_13510(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 13495, 13510);
                    return return_v;
                }


                bool
                f_10308_13495_13523(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 13495, 13523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10308_13601_13629(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                this_param)
                {
                    var return_v = this_param.ResultType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 13601, 13629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10308_13669_13754(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 13669, 13754);
                    return return_v;
                }


                bool
                f_10308_13852_13872(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 13852, 13872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10308_13793_13873(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement(syntax, expression, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 13793, 13873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10308_14066_14080(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 14066, 14080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10308_14179_14218(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 14179, 14218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10308_14248_14273(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 14248, 14273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10308_14376_14426(Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 14376, 14426);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10308_14478_14547(Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = InitializerRewriter.GetTrailingScriptExpression(statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 14478, 14547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10308_14657_14728(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax
                this_param)
                {
                    var return_v = this_param.SemicolonToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 14657, 14728);
                    return return_v;
                }


                int
                f_10308_14605_14729(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxToken
                token)
                {
                    Error(diagnostics, code, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 14605, 14729);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGlobalStatementInitializer
                f_10308_14810_14871(Microsoft.CodeAnalysis.CSharp.Syntax.StatementSyntax
                syntax, Microsoft.CodeAnalysis.CSharp.BoundStatement
                statement)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundGlobalStatementInitializer((Microsoft.CodeAnalysis.SyntaxNode)syntax, statement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 14810, 14871);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10308, 12578, 14883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10308, 12578, 14883);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundFieldEqualsValue BindFieldInitializer(Binder binder, FieldSymbol fieldSymbol, EqualsValueClauseSyntax equalsValueClauseNode,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10308, 14895, 16375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 15104, 15150);

                f_10308_15104_15149(f_10308_15117_15148_M(!fieldSymbol.IsMetadataConstant));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 15166, 15213);

                var
                fieldsBeingBound = f_10308_15189_15212(binder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 15229, 15300);

                var
                sourceField = fieldSymbol as SourceMemberFieldSymbolFromDeclarator
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 15314, 15424);

                bool
                isImplicitlyTypedField = (object?)sourceField != null && (DynAbs.Tracing.TraceSender.Expression_True(10308, 15344, 15423) && f_10308_15376_15423(sourceField, fieldsBeingBound))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 15666, 15703);

                DiagnosticBag
                initializerDiagnostics
                = default(DiagnosticBag);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 15717, 15948) || true) && (isImplicitlyTypedField)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 15717, 15948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 15777, 15830);

                    initializerDiagnostics = f_10308_15802_15829();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 15717, 15948);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 15717, 15948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 15896, 15933);

                    initializerDiagnostics = diagnostics;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 15717, 15948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 15964, 16064);

                binder = f_10308_15973_16063(equalsValueClauseNode, fieldSymbol, f_10308_16034_16062(binder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 16078, 16205);

                BoundFieldEqualsValue
                boundInitValue = f_10308_16117_16204(binder, fieldSymbol, equalsValueClauseNode, initializerDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 16221, 16326) || true) && (isImplicitlyTypedField)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10308, 16221, 16326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 16281, 16311);

                    f_10308_16281_16310(initializerDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10308, 16221, 16326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10308, 16342, 16364);

                return boundInitValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10308, 14895, 16375);

                bool
                f_10308_15117_15148_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 15117, 15148);
                    return return_v;
                }


                int
                f_10308_15104_15149(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 15104, 15149);
                    return 0;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10308_15189_15212(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.FieldsBeingBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10308, 15189, 15212);
                    return return_v;
                }


                bool
                f_10308_15376_15423(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbolFromDeclarator
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound)
                {
                    var return_v = this_param.FieldTypeInferred(fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 15376, 15423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10308_15802_15829()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 15802, 15829);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                f_10308_16034_16062(Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.LocalScopeBinder(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 16034, 16062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10308_15973_16063(Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                root, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.LocalScopeBinder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, (Microsoft.CodeAnalysis.CSharp.Binder)next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 15973, 16063);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldEqualsValue
                f_10308_16117_16204(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, Microsoft.CodeAnalysis.CSharp.Syntax.EqualsValueClauseSyntax
                initializerOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindFieldInitializer(field, initializerOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 16117, 16204);
                    return return_v;
                }


                int
                f_10308_16281_16310(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10308, 16281, 16310);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10308, 14895, 16375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10308, 14895, 16375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
