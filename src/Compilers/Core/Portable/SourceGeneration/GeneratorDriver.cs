// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
namespace Microsoft.CodeAnalysis
{
    public abstract class GeneratorDriver
    {
        internal readonly GeneratorDriverState _state;

        internal GeneratorDriver(GeneratorDriverState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(550, 1760, 2019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 1837, 1929);

                // LAFHIS
                //f_550_1837_1928(f_550_1850_1900(f_550_1850_1892(ref state.Generators, s => s.GetType())) == state.Generators.Length);

                var temp = state.Generators.GroupBy<Microsoft.CodeAnalysis.ISourceGenerator, System.Type>(s => s.GetType());
                DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 1850, 1892);

                f_550_1837_1928(f_550_1850_1900(temp) == state.Generators.Length);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 1993, 2008);

                _state = state;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(550, 1760, 2019);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 1760, 2019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 1760, 2019);
            }
        }

        internal GeneratorDriver(ParseOptions parseOptions, ImmutableArray<ISourceGenerator> generators, AnalyzerConfigOptionsProvider optionsProvider, ImmutableArray<AdditionalText> additionalTexts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(550, 2031, 2468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 2247, 2457);

                _state = f_550_2256_2456(parseOptions, optionsProvider, generators, additionalTexts, f_550_2341_2401(new GeneratorState[generators.Length]), ImmutableArray<PendingEdit>.Empty, editsFailed: true);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(550, 2031, 2468);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 2031, 2468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 2031, 2468);
            }
        }

        public GeneratorDriver RunGenerators(Compilation compilation, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 2480, 2796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 2613, 2697);

                var
                state = f_550_2625_2696(this, compilation, diagnosticsBag: null, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 2761, 2785);

                return f_550_2768_2784(this, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 2480, 2796);

                Microsoft.CodeAnalysis.GeneratorDriverState
                f_550_2625_2696(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsBag, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.RunGeneratorsCore(compilation, diagnosticsBag: diagnosticsBag, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 2625, 2696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorDriver
                f_550_2768_2784(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = this_param.FromState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 2768, 2784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 2480, 2796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 2480, 2796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GeneratorDriver RunGeneratorsAndUpdateCompilation(Compilation compilation, out Compilation outputCompilation, out ImmutableArray<Diagnostic> diagnostics, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 2808, 3413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3040, 3089);

                var
                diagnosticsBag = f_550_3061_3088()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3103, 3181);

                var
                state = f_550_3115_3180(this, compilation, diagnosticsBag, cancellationToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3248, 3297);

                diagnostics = f_550_3262_3296(diagnosticsBag);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3311, 3402);

                return f_550_3318_3401(this, compilation, out outputCompilation, state, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 2808, 3413);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_550_3061_3088()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 3061, 3088);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorDriverState
                f_550_3115_3180(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsBag, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.RunGeneratorsCore(compilation, diagnosticsBag, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 3115, 3180);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_550_3262_3296(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 3262, 3296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorDriver
                f_550_3318_3401(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, out Microsoft.CodeAnalysis.Compilation
                outputCompilation, Microsoft.CodeAnalysis.GeneratorDriverState
                state, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.BuildFinalCompilation(compilation, out outputCompilation, state, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 3318, 3401);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 2808, 3413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 2808, 3413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GeneratorDriver TryApplyEdits(Compilation compilation, out Compilation outputCompilation, out bool success, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 3425, 4615);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3688, 3897) || true) && (_state.EditsFailed || (DynAbs.Tracing.TraceSender.Expression_False(550, 3692, 3738) || _state.Edits.Length == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 3688, 3897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3772, 3804);

                    outputCompilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3822, 3852);

                    success = !_state.EditsFailed;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3870, 3882);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(550, 3688, 3897);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3953, 3972);

                var
                state = _state
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 3986, 4329);
                    foreach (var edit in f_550_4007_4019_I(_state.Edits))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 3986, 4329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 4053, 4110);

                        state = f_550_4061_4109(this, state, edit, cancellationToken);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 4128, 4314) || true) && (state.EditsFailed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 4128, 4314);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 4191, 4223);

                            outputCompilation = compilation;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 4245, 4261);

                            success = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 4283, 4295);

                            return this;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(550, 4128, 4314);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(550, 3986, 4329);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 344);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 4406, 4468);

                compilation = f_550_4420_4467(_state, compilation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 4484, 4499);

                success = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 4513, 4604);

                return f_550_4520_4603(this, compilation, out outputCompilation, state, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 3425, 4615);

                Microsoft.CodeAnalysis.GeneratorDriverState
                f_550_4061_4109(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state, Microsoft.CodeAnalysis.PendingEdit
                edit, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ApplyPartialEdit(state, edit, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 4061, 4109);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PendingEdit>
                f_550_4007_4019_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PendingEdit>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 4007, 4019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_550_4420_4467(Microsoft.CodeAnalysis.GeneratorDriverState
                state, Microsoft.CodeAnalysis.Compilation
                compilation)
                {
                    var return_v = RemoveGeneratedSyntaxTrees(state, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 4420, 4467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorDriver
                f_550_4520_4603(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, out Microsoft.CodeAnalysis.Compilation
                outputCompilation, Microsoft.CodeAnalysis.GeneratorDriverState
                state, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.BuildFinalCompilation(compilation, out outputCompilation, state, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 4520, 4603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 3425, 4615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 3425, 4615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GeneratorDriver AddGenerators(ImmutableArray<ISourceGenerator> generators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 4627, 5066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 4827, 5014);

                var
                newState = _state.With(generators: _state.Generators.AddRange(generators), generatorStates: _state.GeneratorStates.AddRange(new GeneratorState[generators.Length]), editsFailed: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5028, 5055);

                return f_550_5035_5054(this, newState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 4627, 5066);

                Microsoft.CodeAnalysis.GeneratorDriver
                f_550_5035_5054(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = this_param.FromState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 5035, 5054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 4627, 5066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 4627, 5066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GeneratorDriver RemoveGenerators(ImmutableArray<ISourceGenerator> generators)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 5078, 5724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5187, 5225);

                var
                newGenerators = _state.Generators
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5239, 5278);

                var
                newStates = _state.GeneratorStates
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5301, 5306);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5292, 5612) || true) && (i < newGenerators.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5334, 5337)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(550, 5292, 5612))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 5292, 5612);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5371, 5597) || true) && (generators.Contains(newGenerators[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 5371, 5597);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5454, 5496);

                            newGenerators = newGenerators.RemoveAt(i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5518, 5552);

                            newStates = newStates.RemoveAt(i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5574, 5578);

                            i--;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(550, 5371, 5597);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5628, 5713);

                return f_550_5635_5712(this, _state.With(generators: newGenerators, generatorStates: newStates));
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 5078, 5724);

                Microsoft.CodeAnalysis.GeneratorDriver
                f_550_5635_5712(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = this_param.FromState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 5635, 5712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 5078, 5724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 5078, 5724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GeneratorDriver AddAdditionalTexts(ImmutableArray<AdditionalText> additionalTexts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 5736, 5996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5850, 5944);

                var
                newState = _state.With(additionalTexts: _state.AdditionalTexts.AddRange(additionalTexts))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 5958, 5985);

                return f_550_5965_5984(this, newState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 5736, 5996);

                Microsoft.CodeAnalysis.GeneratorDriver
                f_550_5965_5984(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = this_param.FromState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 5965, 5984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 5736, 5996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 5736, 5996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GeneratorDriver RemoveAdditionalTexts(ImmutableArray<AdditionalText> additionalTexts)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 6008, 6274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 6125, 6222);

                var
                newState = _state.With(additionalTexts: _state.AdditionalTexts.RemoveRange(additionalTexts))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 6236, 6263);

                return f_550_6243_6262(this, newState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 6008, 6274);

                Microsoft.CodeAnalysis.GeneratorDriver
                f_550_6243_6262(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = this_param.FromState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 6243, 6262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 6008, 6274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 6008, 6274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GeneratorDriverRunResult GetRunResult()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 6286, 7754);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 6357, 6892);

                var
                results = _state.Generators.ZipAsArray(_state.GeneratorStates, (generator, generatorState)
=> new GeneratorRunResult(generator,
                   diagnostics: generatorState.Diagnostics,
                   exception: generatorState.Exception,
                   generatedSources: getGeneratorSources(generatorState)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 6906, 6951);

                return f_550_6913_6950(results);

                static ImmutableArray<GeneratedSourceResult> getGeneratorSources(GeneratorState generatorState)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(550, 6967, 7743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 7095, 7265);

                        ArrayBuilder<GeneratedSourceResult>
                        sources = f_550_7141_7264(generatorState.PostInitTrees.Length + generatorState.GeneratedTrees.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 7283, 7469);
                            foreach (var tree in f_550_7304_7332_I(generatorState.PostInitTrees))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 7283, 7469);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 7374, 7450);

                                f_550_7374_7449(sources, f_550_7386_7448(tree.Tree, tree.Text, tree.HintName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(550, 7283, 7469);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 187);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 187);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 7487, 7674);
                            foreach (var tree in f_550_7508_7537_I(generatorState.GeneratedTrees))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 7487, 7674);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 7579, 7655);

                                f_550_7579_7654(sources, f_550_7591_7653(tree.Tree, tree.Text, tree.HintName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(550, 7487, 7674);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 188);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 188);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 7692, 7728);

                        return f_550_7699_7727(sources);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(550, 6967, 7743);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceResult>
                        f_550_7141_7264(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<GeneratedSourceResult>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 7141, 7264);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.GeneratedSourceResult
                        f_550_7386_7448(Microsoft.CodeAnalysis.SyntaxTree
                        tree, Microsoft.CodeAnalysis.Text.SourceText
                        text, string
                        hintName)
                        {
                            var return_v = new Microsoft.CodeAnalysis.GeneratedSourceResult(tree, text, hintName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 7386, 7448);
                            return return_v;
                        }


                        int
                        f_550_7374_7449(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceResult>
                        this_param, Microsoft.CodeAnalysis.GeneratedSourceResult
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 7374, 7449);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                        f_550_7304_7332_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 7304, 7332);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.GeneratedSourceResult
                        f_550_7591_7653(Microsoft.CodeAnalysis.SyntaxTree
                        tree, Microsoft.CodeAnalysis.Text.SourceText
                        text, string
                        hintName)
                        {
                            var return_v = new Microsoft.CodeAnalysis.GeneratedSourceResult(tree, text, hintName);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 7591, 7653);
                            return return_v;
                        }


                        int
                        f_550_7579_7654(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceResult>
                        this_param, Microsoft.CodeAnalysis.GeneratedSourceResult
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 7579, 7654);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                        f_550_7508_7537_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 7508, 7537);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceResult>
                        f_550_7699_7727(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSourceResult>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 7699, 7727);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 6967, 7743);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 6967, 7743);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 6286, 7754);

                Microsoft.CodeAnalysis.GeneratorDriverRunResult
                f_550_6913_6950(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorRunResult>
                results)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorDriverRunResult(results);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 6913, 6950);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 6286, 7754);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 6286, 7754);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GeneratorDriverState RunGeneratorsCore(Compilation compilation, DiagnosticBag? diagnosticsBag, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 7766, 15463);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8000, 8092) || true) && (_state.Generators.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 8000, 8092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8063, 8077);

                    return _state;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(550, 8000, 8092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8150, 8199);

                var
                state = f_550_8162_8198(_state)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8213, 8298);

                var
                stateBuilder = f_550_8232_8297(state.Generators.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8312, 8380);

                var
                constantSourcesBuilder = f_550_8341_8379()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8394, 8509);

                var
                walkerBuilder = f_550_8414_8508(state.Generators.Length, fillWithValue: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8566, 8588);

                int
                receiverCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8613, 8618);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8604, 12035) || true) && (i < state.Generators.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8649, 8652)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(550, 8604, 12035))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 8604, 12035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8686, 8722);

                        var
                        generator = state.Generators[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8740, 8786);

                        var
                        generatorState = state.GeneratorStates[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8861, 10750) || true) && (f_550_8865_8897_M(!generatorState.Info.Initialized))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 8861, 10750);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 8939, 9007);

                            var
                            context = f_550_8953_9006(cancellationToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 9029, 9050);

                            Exception?
                            ex = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 9124, 9154);

                                f_550_9124_9153(generator, context);
                            }
                            catch (Exception e) when (f_550_9225_9286(e, cancellationToken))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(550, 9199, 9366);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 9336, 9343);

                                ex = e;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(550, 9199, 9366);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 9388, 9664);

                            generatorState = (DynAbs.Tracing.TraceSender.Conditional_F1(550, 9405, 9415) || ((ex is null
                            && DynAbs.Tracing.TraceSender.Conditional_F2(550, 9456, 9509)) || DynAbs.Tracing.TraceSender.Conditional_F3(550, 9550, 9663))) ? f_550_9456_9509(f_550_9475_9508(context.InfoBuilder)) : f_550_9550_9663(f_550_9572_9587(), GeneratorState.Uninitialized, generator, ex, diagnosticsBag, isInit: true);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 9755, 10731) || true) && (generatorState.Info.PostInitCallback is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 9755, 10731);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 9855, 9910);

                                var
                                sourcesCollection = f_550_9879_9909(this)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 9936, 10031);

                                var
                                postContext = f_550_9954_10030(sourcesCollection, cancellationToken)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 10117, 10167);

                                    f_550_10117_10166(generatorState.Info, postContext);
                                }
                                catch (Exception e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(550, 10220, 10330);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 10296, 10303);

                                    ex = e;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(550, 10220, 10330);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 10358, 10708);

                                generatorState = (DynAbs.Tracing.TraceSender.Conditional_F1(550, 10375, 10385) || ((ex is null
                                && DynAbs.Tracing.TraceSender.Conditional_F2(550, 10430, 10563)) || DynAbs.Tracing.TraceSender.Conditional_F3(550, 10608, 10707))) ? f_550_10430_10563(generatorState.Info, f_550_10470_10562(this, generator, f_550_10504_10542(sourcesCollection), cancellationToken)) : f_550_10608_10707(f_550_10630_10645(), generatorState, generator, ex, diagnosticsBag, isInit: true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(550, 9755, 10731);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(550, 8861, 10750);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 10830, 11677) || true) && (generatorState.Info.SyntaxContextReceiverCreator is object && (DynAbs.Tracing.TraceSender.Expression_True(550, 10834, 10928) && generatorState.Exception is null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 10830, 11677);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 10970, 11004);

                            ISyntaxContextReceiver?
                            rx = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 11078, 11134);

                                rx = f_550_11083_11133(generatorState.Info);
                            }
                            catch (Exception e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(550, 11179, 11372);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 11247, 11349);

                                generatorState = f_550_11264_11348(f_550_11286_11301(), generatorState, generator, e, diagnosticsBag);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(550, 11179, 11372);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 11396, 11658) || true) && (rx is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 11396, 11658);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 11462, 11518);

                                f_550_11462_11517(walkerBuilder, i, f_550_11487_11516(rx));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 11544, 11593);

                                generatorState = generatorState.WithReceiver(rx);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 11619, 11635);

                                receiverCount++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(550, 11396, 11658);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(550, 10830, 11677);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 11745, 11967) || true) && (generatorState.Exception is null && (DynAbs.Tracing.TraceSender.Expression_True(550, 11749, 11824) && generatorState.PostInitTrees.Length > 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 11745, 11967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 11866, 11948);

                            f_550_11866_11947(constantSourcesBuilder, generatorState.PostInitTrees.Select(t => t.Tree));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(550, 11745, 11967);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 11987, 12020);

                        f_550_11987_12019(
                                        stateBuilder, generatorState);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 3432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 3432);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12116, 12266) || true) && (f_550_12120_12148(constantSourcesBuilder) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 12116, 12266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12186, 12251);

                    compilation = f_550_12200_12250(compilation, constantSourcesBuilder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(550, 12116, 12266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12280, 12310);

                f_550_12280_12309(constantSourcesBuilder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12398, 13621) || true) && (receiverCount > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 12398, 13621);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12453, 13606);
                        foreach (var tree in f_550_12474_12497_I(f_550_12474_12497(compilation)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 12453, 13606);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12539, 12582);

                            var
                            root = f_550_12550_12581(tree, cancellationToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12604, 12659);

                            var
                            semanticModel = f_550_12624_12658(compilation, tree)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12802, 12807);

                                // https://github.com/dotnet/roslyn/issues/42629: should be possible to parallelize this
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12793, 13587) || true) && (i < f_550_12813_12832(walkerBuilder))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12834, 12837)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(550, 12793, 13587))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 12793, 13587);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12887, 12917);

                                    var
                                    walker = f_550_12900_12916(walkerBuilder, i)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 12943, 13564) || true) && (walker is object)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 12943, 13564);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 13089, 13132);

                                            f_550_13089_13131(walker, semanticModel, root);
                                        }
                                        catch (Exception e)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(550, 13193, 13537);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 13277, 13391);

                                            stateBuilder[i] = f_550_13295_13390(f_550_13317_13332(), f_550_13334_13349(stateBuilder, i), state.Generators[i], e, diagnosticsBag);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 13425, 13456);

                                            f_550_13425_13455(walkerBuilder, i, null);
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(550, 13193, 13537);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(550, 12943, 13564);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 795);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 795);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(550, 12453, 13606);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 1154);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 1154);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(550, 12398, 13621);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 13635, 13656);

                f_550_13635_13655(walkerBuilder);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 13783, 13788);

                    // https://github.com/dotnet/roslyn/issues/42629: should be possible to parallelize this
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 13774, 15340) || true) && (i < state.Generators.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 13819, 13822)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(550, 13774, 15340))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 13774, 15340);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 13856, 13892);

                        var
                        generator = state.Generators[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 13910, 13947);

                        var
                        generatorState = f_550_13931_13946(stateBuilder, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 14050, 14158) || true) && (generatorState.Exception is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 14050, 14158);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 14130, 14139);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(550, 14050, 14158);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 14176, 14222);

                        f_550_14176_14221(generatorState.Info.Initialized);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 14383, 14597);

                        var
                        context = f_550_14397_14596(compilation, state.ParseOptions, state.AdditionalTexts.NullToEmpty(), state.OptionsProvider, generatorState.SyntaxReceiver, f_550_14551_14576(this), cancellationToken)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 14659, 14686);

                            f_550_14659_14685(generator, context);
                        }
                        catch (Exception e) when (f_550_14749_14810(e, cancellationToken))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(550, 14723, 15005);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 14852, 14955);

                            stateBuilder[i] = f_550_14870_14954(f_550_14892_14907(), generatorState, generator, e, diagnosticsBag);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 14977, 14986);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(550, 14723, 15005);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 15025, 15087);

                        (var sources, var diagnostics) = context.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 15105, 15269);

                        stateBuilder[i] = f_550_15123_15268(generatorState.Info, generatorState.PostInitTrees, f_550_15193_15254(this, generator, sources, cancellationToken), diagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 15287, 15325);

                        DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(diagnosticsBag, 550, 15287, 15324)?.AddRange(diagnostics), 550, 15302, 15324);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 1567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 1567);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 15354, 15425);

                state = state.With(generatorStates: f_550_15390_15423(stateBuilder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 15439, 15452);

                return state;
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 7766, 15463);

                Microsoft.CodeAnalysis.GeneratorDriverState
                f_550_8162_8198(Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = StateWithPendingEditsApplied(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 8162, 8198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorState>
                f_550_8232_8297(int
                capacity)
                {
                    var return_v = ArrayBuilder<GeneratorState>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 8232, 8297);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                f_550_8341_8379()
                {
                    var return_v = ArrayBuilder<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 8341, 8379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorSyntaxWalker?>
                f_550_8414_8508(int
                capacity, Microsoft.CodeAnalysis.GeneratorSyntaxWalker?
                fillWithValue)
                {
                    var return_v = ArrayBuilder<GeneratorSyntaxWalker?>.GetInstance(capacity, fillWithValue: fillWithValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 8414, 8508);
                    return return_v;
                }


                bool
                f_550_8865_8897_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 8865, 8897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorInitializationContext
                f_550_8953_9006(System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorInitializationContext(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 8953, 9006);
                    return return_v;
                }


                int
                f_550_9124_9153(Microsoft.CodeAnalysis.ISourceGenerator
                this_param, Microsoft.CodeAnalysis.GeneratorInitializationContext
                context)
                {
                    this_param.Initialize(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 9124, 9153);
                    return 0;
                }


                bool
                f_550_9225_9286(System.Exception
                exception, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = FatalError.ReportAndCatchUnlessCanceled(exception, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 9225, 9286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorInfo
                f_550_9475_9508(Microsoft.CodeAnalysis.GeneratorInfo.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 9475, 9508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_9456_9509(Microsoft.CodeAnalysis.GeneratorInfo
                info)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorState(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 9456, 9509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_550_9572_9587()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 9572, 9587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_9550_9663(Microsoft.CodeAnalysis.CommonMessageProvider
                provider, Microsoft.CodeAnalysis.GeneratorState
                generatorState, Microsoft.CodeAnalysis.ISourceGenerator
                generator, System.Exception
                e, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticBag, bool
                isInit)
                {
                    var return_v = SetGeneratorException(provider, generatorState, generator, e, diagnosticBag, isInit: isInit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 9550, 9663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AdditionalSourcesCollection
                f_550_9879_9909(Microsoft.CodeAnalysis.GeneratorDriver
                this_param)
                {
                    var return_v = this_param.CreateSourcesCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 9879, 9909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorPostInitializationContext
                f_550_9954_10030(Microsoft.CodeAnalysis.AdditionalSourcesCollection
                additionalSources, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorPostInitializationContext(additionalSources, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 9954, 10030);
                    return return_v;
                }


                int
                f_550_10117_10166(Microsoft.CodeAnalysis.GeneratorInfo
                this_param, Microsoft.CodeAnalysis.GeneratorPostInitializationContext
                obj)
                {
                    this_param.PostInitCallback(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 10117, 10166);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
                f_550_10504_10542(Microsoft.CodeAnalysis.AdditionalSourcesCollection
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 10504, 10542);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                f_550_10470_10562(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.ISourceGenerator
                generator, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
                generatedSources, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ParseAdditionalSources(generator, generatedSources, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 10470, 10562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_10430_10563(Microsoft.CodeAnalysis.GeneratorInfo
                info, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                postInitTrees)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorState(info, postInitTrees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 10430, 10563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_550_10630_10645()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 10630, 10645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_10608_10707(Microsoft.CodeAnalysis.CommonMessageProvider
                provider, Microsoft.CodeAnalysis.GeneratorState
                generatorState, Microsoft.CodeAnalysis.ISourceGenerator
                generator, System.Exception
                e, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticBag, bool
                isInit)
                {
                    var return_v = SetGeneratorException(provider, generatorState, generator, e, diagnosticBag, isInit: isInit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 10608, 10707);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ISyntaxContextReceiver?
                f_550_11083_11133(Microsoft.CodeAnalysis.GeneratorInfo
                this_param)
                {
                    var return_v = this_param.SyntaxContextReceiverCreator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 11083, 11133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_550_11286_11301()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 11286, 11301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_11264_11348(Microsoft.CodeAnalysis.CommonMessageProvider
                provider, Microsoft.CodeAnalysis.GeneratorState
                generatorState, Microsoft.CodeAnalysis.ISourceGenerator
                generator, System.Exception
                e, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticBag)
                {
                    var return_v = SetGeneratorException(provider, generatorState, generator, e, diagnosticBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 11264, 11348);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorSyntaxWalker
                f_550_11487_11516(Microsoft.CodeAnalysis.ISyntaxContextReceiver
                syntaxReceiver)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorSyntaxWalker(syntaxReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 11487, 11516);
                    return return_v;
                }


                int
                f_550_11462_11517(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorSyntaxWalker?>
                this_param, int
                index, Microsoft.CodeAnalysis.GeneratorSyntaxWalker
                value)
                {
                    this_param.SetItem(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 11462, 11517);
                    return 0;
                }


                int
                f_550_11866_11947(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 11866, 11947);
                    return 0;
                }


                int
                f_550_11987_12019(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorState>
                this_param, Microsoft.CodeAnalysis.GeneratorState
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 11987, 12019);
                    return 0;
                }


                int
                f_550_12120_12148(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 12120, 12148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_550_12200_12250(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                trees)
                {
                    var return_v = this_param.AddSyntaxTrees((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 12200, 12250);
                    return return_v;
                }


                int
                f_550_12280_12309(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 12280, 12309);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_550_12474_12497(Microsoft.CodeAnalysis.Compilation
                this_param)
                {
                    var return_v = this_param.SyntaxTrees;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 12474, 12497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_550_12550_12581(Microsoft.CodeAnalysis.SyntaxTree
                this_param, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetRoot(cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 12550, 12581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SemanticModel
                f_550_12624_12658(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetSemanticModel(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 12624, 12658);
                    return return_v;
                }


                int
                f_550_12813_12832(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorSyntaxWalker?>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 12813, 12832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorSyntaxWalker?
                f_550_12900_12916(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorSyntaxWalker?>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 12900, 12916);
                    return return_v;
                }


                int
                f_550_13089_13131(Microsoft.CodeAnalysis.GeneratorSyntaxWalker
                this_param, Microsoft.CodeAnalysis.SemanticModel
                model, Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    this_param.VisitWithModel(model, node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 13089, 13131);
                    return 0;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_550_13317_13332()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 13317, 13332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_13334_13349(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorState>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 13334, 13349);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_13295_13390(Microsoft.CodeAnalysis.CommonMessageProvider
                provider, Microsoft.CodeAnalysis.GeneratorState
                generatorState, Microsoft.CodeAnalysis.ISourceGenerator
                generator, System.Exception
                e, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticBag)
                {
                    var return_v = SetGeneratorException(provider, generatorState, generator, e, diagnosticBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 13295, 13390);
                    return return_v;
                }


                int
                f_550_13425_13455(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorSyntaxWalker?>
                this_param, int
                index, Microsoft.CodeAnalysis.GeneratorSyntaxWalker?
                value)
                {
                    this_param.SetItem(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 13425, 13455);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                f_550_12474_12497_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 12474, 12497);
                    return return_v;
                }


                int
                f_550_13635_13655(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorSyntaxWalker?>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 13635, 13655);
                    return 0;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_13931_13946(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorState>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 13931, 13946);
                    return return_v;
                }


                int
                f_550_14176_14221(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 14176, 14221);
                    return 0;
                }


                Microsoft.CodeAnalysis.AdditionalSourcesCollection
                f_550_14551_14576(Microsoft.CodeAnalysis.GeneratorDriver
                this_param)
                {
                    var return_v = this_param.CreateSourcesCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 14551, 14576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorExecutionContext
                f_550_14397_14596(Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.ParseOptions
                parseOptions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
                additionalTexts, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
                optionsProvider, Microsoft.CodeAnalysis.ISyntaxContextReceiver?
                syntaxReceiver, Microsoft.CodeAnalysis.AdditionalSourcesCollection
                additionalSources, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorExecutionContext(compilation, parseOptions, additionalTexts, optionsProvider, syntaxReceiver, additionalSources, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 14397, 14596);
                    return return_v;
                }


                int
                f_550_14659_14685(Microsoft.CodeAnalysis.ISourceGenerator
                this_param, Microsoft.CodeAnalysis.GeneratorExecutionContext
                context)
                {
                    this_param.Execute(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 14659, 14685);
                    return 0;
                }


                bool
                f_550_14749_14810(System.Exception
                exception, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = FatalError.ReportAndCatchUnlessCanceled(exception, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 14749, 14810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonMessageProvider
                f_550_14892_14907()
                {
                    var return_v = MessageProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 14892, 14907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_14870_14954(Microsoft.CodeAnalysis.CommonMessageProvider
                provider, Microsoft.CodeAnalysis.GeneratorState
                generatorState, Microsoft.CodeAnalysis.ISourceGenerator
                generator, System.Exception
                e, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticBag)
                {
                    var return_v = SetGeneratorException(provider, generatorState, generator, e, diagnosticBag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 14870, 14954);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                f_550_15193_15254(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.ISourceGenerator
                generator, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
                generatedSources, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ParseAdditionalSources(generator, generatedSources, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 15193, 15254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_15123_15268(Microsoft.CodeAnalysis.GeneratorInfo
                info, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                postInitTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                generatedTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorState(info, postInitTrees, generatedTrees, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 15123, 15268);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorState>
                f_550_15390_15423(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratorState>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 15390, 15423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 7766, 15463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 7766, 15463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GeneratorDriver WithPendingEdits(ImmutableArray<PendingEdit> edits)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 15584, 15801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 15685, 15749);

                var
                newState = _state.With(edits: _state.Edits.AddRange(edits))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 15763, 15790);

                return f_550_15770_15789(this, newState);
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 15584, 15801);

                Microsoft.CodeAnalysis.GeneratorDriver
                f_550_15770_15789(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = this_param.FromState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 15770, 15789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 15584, 15801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 15584, 15801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GeneratorDriverState ApplyPartialEdit(GeneratorDriverState state, PendingEdit edit, CancellationToken cancellationToken = default)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 15813, 17689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 15976, 16001);

                var
                initialState = state
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16083, 16167);

                var
                stateBuilder = f_550_16102_16166()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16190, 16195);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16181, 17610) || true) && (i < initialState.Generators.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16233, 16236)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(550, 16181, 17610))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 16181, 17610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16270, 16313);

                        var
                        generator = initialState.Generators[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16331, 16384);

                        var
                        generatorState = initialState.GeneratorStates[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16402, 17595) || true) && (f_550_16406_16442(edit, generatorState.Info))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 16402, 17595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16534, 16582);

                            var
                            previousSources = f_550_16556_16581(this)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16604, 16660);

                            f_550_16604_16659(previousSources, generatorState.GeneratedTrees);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16682, 16757);

                            var
                            context = f_550_16696_16756(previousSources, cancellationToken)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16779, 16839);

                            var
                            succeeded = f_550_16795_16838(edit, generatorState.Info, context)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 16861, 17132) || true) && (!succeeded)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 16861, 17132);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 17065, 17109);

                                return initialState.With(editsFailed: true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(550, 16861, 17132);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 17216, 17277);

                            var
                            additionalSources = f_550_17240_17276(previousSources)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 17299, 17576);

                            state = state.With(generatorStates: state.GeneratorStates.SetItem(i, f_550_17368_17573(generatorState.Info, generatorState.PostInitTrees, generatedTrees: f_550_17454_17525(this, generator, additionalSources, cancellationToken), diagnostics: ImmutableArray<Diagnostic>.Empty)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(550, 16402, 17595);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 1430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 1430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 17624, 17651);

                state = f_550_17632_17650(edit, state);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 17665, 17678);

                return state;
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 15813, 17689);

                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.ISourceGenerator, Microsoft.CodeAnalysis.GeneratorState>
                f_550_16102_16166()
                {
                    var return_v = PooledDictionary<ISourceGenerator, GeneratorState>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 16102, 16166);
                    return return_v;
                }


                bool
                f_550_16406_16442(Microsoft.CodeAnalysis.PendingEdit
                this_param, Microsoft.CodeAnalysis.GeneratorInfo
                info)
                {
                    var return_v = this_param.AcceptedBy(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 16406, 16442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AdditionalSourcesCollection
                f_550_16556_16581(Microsoft.CodeAnalysis.GeneratorDriver
                this_param)
                {
                    var return_v = this_param.CreateSourcesCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 16556, 16581);
                    return return_v;
                }


                int
                f_550_16604_16659(Microsoft.CodeAnalysis.AdditionalSourcesCollection
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                trees)
                {
                    this_param.AddRange(trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 16604, 16659);
                    return 0;
                }


                Microsoft.CodeAnalysis.GeneratorEditContext
                f_550_16696_16756(Microsoft.CodeAnalysis.AdditionalSourcesCollection
                sources, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorEditContext(sources, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 16696, 16756);
                    return return_v;
                }


                bool
                f_550_16795_16838(Microsoft.CodeAnalysis.PendingEdit
                this_param, Microsoft.CodeAnalysis.GeneratorInfo
                info, Microsoft.CodeAnalysis.GeneratorEditContext
                context)
                {
                    var return_v = this_param.TryApply(info, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 16795, 16838);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
                f_550_17240_17276(Microsoft.CodeAnalysis.AdditionalSourcesCollection
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 17240, 17276);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                f_550_17454_17525(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.ISourceGenerator
                generator, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
                generatedSources, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ParseAdditionalSources(generator, generatedSources, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 17454, 17525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_17368_17573(Microsoft.CodeAnalysis.GeneratorInfo
                info, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                postInitTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                generatedTrees, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorState(info, postInitTrees, generatedTrees: generatedTrees, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 17368, 17573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorDriverState
                f_550_17632_17650(Microsoft.CodeAnalysis.PendingEdit
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = this_param.Commit(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 17632, 17650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 15813, 17689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 15813, 17689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static GeneratorDriverState StateWithPendingEditsApplied(GeneratorDriverState state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(550, 17701, 18136);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 17818, 17907) || true) && (state.Edits.Length == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 17818, 17907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 17879, 17892);

                    return state;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(550, 17818, 17907);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 17923, 18031);
                    foreach (var edit in f_550_17944_17955_I(state.Edits))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 17923, 18031);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 17989, 18016);

                        state = f_550_17997_18015(edit, state);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(550, 17923, 18031);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 18045, 18125);

                return state.With(edits: ImmutableArray<PendingEdit>.Empty, editsFailed: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(550, 17701, 18136);

                Microsoft.CodeAnalysis.GeneratorDriverState
                f_550_17997_18015(Microsoft.CodeAnalysis.PendingEdit
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = this_param.Commit(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 17997, 18015);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PendingEdit>
                f_550_17944_17955_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PendingEdit>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 17944, 17955);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 17701, 18136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 17701, 18136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Compilation RemoveGeneratedSyntaxTrees(GeneratorDriverState state, Compilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(550, 18148, 18903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 18279, 18351);

                ArrayBuilder<SyntaxTree>
                trees = f_550_18312_18350()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 18365, 18775);
                    foreach (var generatorState in f_550_18396_18417_I(state.GeneratorStates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 18365, 18775);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 18451, 18760);
                            foreach (var generatedTree in f_550_18481_18510_I(generatorState.GeneratedTrees))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 18451, 18760);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 18552, 18741) || true) && (generatedTree.Tree is object && (DynAbs.Tracing.TraceSender.Expression_True(550, 18556, 18638) && f_550_18588_18638(compilation, generatedTree.Tree)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 18552, 18741);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 18688, 18718);

                                    f_550_18688_18717(trees, generatedTree.Tree);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(550, 18552, 18741);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(550, 18451, 18760);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 310);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 310);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(550, 18365, 18775);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 411);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 18791, 18839);

                var
                comp = f_550_18802_18838(compilation, trees)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 18853, 18866);

                f_550_18853_18865(trees);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 18880, 18892);

                return comp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(550, 18148, 18903);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                f_550_18312_18350()
                {
                    var return_v = ArrayBuilder<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 18312, 18350);
                    return return_v;
                }


                bool
                f_550_18588_18638(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.ContainsSyntaxTree(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 18588, 18638);
                    return return_v;
                }


                int
                f_550_18688_18717(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 18688, 18717);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                f_550_18481_18510_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 18481, 18510);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorState>
                f_550_18396_18417_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorState>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 18396, 18417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_550_18802_18838(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                trees)
                {
                    var return_v = this_param.RemoveSyntaxTrees((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 18802, 18838);
                    return return_v;
                }


                int
                f_550_18853_18865(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 18853, 18865);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 18148, 18903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 18148, 18903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<GeneratedSyntaxTree> ParseAdditionalSources(ISourceGenerator generator, ImmutableArray<GeneratedSourceText> generatedSources, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 18915, 19673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 19125, 19208);

                var
                trees = f_550_19137_19207(generatedSources.Length)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 19222, 19253);

                var
                type = f_550_19233_19252(generator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 19267, 19321);

                var
                prefix = f_550_19280_19320(generator)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 19335, 19614);
                    foreach (var source in f_550_19358_19374_I(generatedSources))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 19335, 19614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 19408, 19510);

                        var
                        tree = f_550_19419_19509(this, source, f_550_19452_19489(prefix, source.HintName), cancellationToken)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 19528, 19599);

                        f_550_19528_19598(trees, f_550_19538_19597(source.HintName, source.Text, tree));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(550, 19335, 19614);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 19628, 19662);

                return f_550_19635_19661(trees);
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 18915, 19673);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                f_550_19137_19207(int
                capacity)
                {
                    var return_v = ArrayBuilder<GeneratedSyntaxTree>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19137, 19207);
                    return return_v;
                }


                System.Type
                f_550_19233_19252(Microsoft.CodeAnalysis.ISourceGenerator
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19233, 19252);
                    return return_v;
                }


                string
                f_550_19280_19320(Microsoft.CodeAnalysis.ISourceGenerator
                generator)
                {
                    var return_v = GetFilePathPrefixForGenerator(generator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19280, 19320);
                    return return_v;
                }


                string
                f_550_19452_19489(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19452, 19489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_550_19419_19509(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.GeneratedSourceText
                input, string
                fileName, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.ParseGeneratedSourceText(input, fileName, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19419, 19509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratedSyntaxTree
                f_550_19538_19597(string
                hintName, Microsoft.CodeAnalysis.Text.SourceText
                text, Microsoft.CodeAnalysis.SyntaxTree
                tree)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratedSyntaxTree(hintName, text, tree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19538, 19597);
                    return return_v;
                }


                int
                f_550_19528_19598(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                this_param, Microsoft.CodeAnalysis.GeneratedSyntaxTree
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19528, 19598);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
                f_550_19358_19374_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSourceText>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19358, 19374);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                f_550_19635_19661(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.GeneratedSyntaxTree>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19635, 19661);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 18915, 19673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 18915, 19673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GeneratorDriver BuildFinalCompilation(Compilation compilation, out Compilation outputCompilation, GeneratorDriverState state, CancellationToken cancellationToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(550, 19685, 20489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 19880, 19952);

                ArrayBuilder<SyntaxTree>
                trees = f_550_19913_19951()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 19966, 20216);
                    foreach (var generatorState in f_550_19997_20018_I(state.GeneratorStates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(550, 19966, 20216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 20052, 20117);

                        f_550_20052_20116(trees, generatorState.PostInitTrees.Select(t => t.Tree));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 20135, 20201);

                        f_550_20135_20200(trees, generatorState.GeneratedTrees.Select(t => t.Tree));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(550, 19966, 20216);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(550, 1, 251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(550, 1, 251);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 20230, 20284);

                outputCompilation = f_550_20250_20283(compilation, trees);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 20298, 20311);

                f_550_20298_20310(trees);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 20327, 20440);

                state = state.With(edits: ImmutableArray<PendingEdit>.Empty, editsFailed: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 20454, 20478);

                return f_550_20461_20477(this, state);
                DynAbs.Tracing.TraceSender.TraceExitMethod(550, 19685, 20489);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                f_550_19913_19951()
                {
                    var return_v = ArrayBuilder<SyntaxTree>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19913, 19951);
                    return return_v;
                }


                int
                f_550_20052_20116(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 20052, 20116);
                    return 0;
                }


                int
                f_550_20135_20200(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 20135, 20200);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorState>
                f_550_19997_20018_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorState>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 19997, 20018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Compilation
                f_550_20250_20283(Microsoft.CodeAnalysis.Compilation
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                trees)
                {
                    var return_v = this_param.AddSyntaxTrees((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxTree>)trees);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 20250, 20283);
                    return return_v;
                }


                int
                f_550_20298_20310(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SyntaxTree>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 20298, 20310);
                    return 0;
                }


                Microsoft.CodeAnalysis.GeneratorDriver
                f_550_20461_20477(Microsoft.CodeAnalysis.GeneratorDriver
                this_param, Microsoft.CodeAnalysis.GeneratorDriverState
                state)
                {
                    var return_v = this_param.FromState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 20461, 20477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 19685, 20489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 19685, 20489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static GeneratorState SetGeneratorException(CommonMessageProvider provider, GeneratorState generatorState, ISourceGenerator generator, Exception e, DiagnosticBag? diagnosticBag, bool isInit = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(550, 20501, 22052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 20732, 20853);

                var
                errorCode = (DynAbs.Tracing.TraceSender.Conditional_F1(550, 20748, 20754) || ((isInit && DynAbs.Tracing.TraceSender.Conditional_F2(550, 20757, 20805)) || DynAbs.Tracing.TraceSender.Conditional_F3(550, 20808, 20852))) ? f_550_20757_20805(provider) : f_550_20808_20852(provider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 21199, 21309);

                var
                description = f_550_21217_21308(f_550_21231_21304(f_550_21231_21265(provider, errorCode), f_550_21275_21303()), e)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 21325, 21785);

                var
                descriptor = f_550_21342_21784(f_550_21385_21422(provider, errorCode), f_550_21441_21469(provider, errorCode), f_550_21488_21524(provider, errorCode), description: description, category: "Compiler", defaultSeverity: DiagnosticSeverity.Warning, isEnabledByDefault: true, customTags: WellKnownDiagnosticTags.AnalyzerException)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 21801, 21918);

                var
                diagnostic = f_550_21818_21917(descriptor, f_550_21848_21861(), f_550_21863_21887(f_550_21863_21882(generator)), f_550_21889_21905(f_550_21889_21900(e)), f_550_21907_21916(e))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 21934, 21965);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(diagnosticBag, 550, 21934, 21964)?.Add(diagnostic), 550, 21948, 21964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 21979, 22041);

                return f_550_21986_22040(generatorState.Info, e, diagnostic);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(550, 20501, 22052);

                int
                f_550_20757_20805(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.WRN_GeneratorFailedDuringInitialization;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 20757, 20805);
                    return return_v;
                }


                int
                f_550_20808_20852(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param)
                {
                    var return_v = this_param.WRN_GeneratorFailedDuringGeneration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 20808, 20852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_550_21231_21265(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code)
                {
                    var return_v = this_param.GetDescription(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21231, 21265);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_550_21275_21303()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 21275, 21303);
                    return return_v;
                }


                string
                f_550_21231_21304(Microsoft.CodeAnalysis.LocalizableString
                this_param, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21231, 21304);
                    return return_v;
                }


                string
                f_550_21217_21308(string
                format, System.Exception
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21217, 21308);
                    return return_v;
                }


                string
                f_550_21385_21422(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode(errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21385, 21422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_550_21441_21469(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code)
                {
                    var return_v = this_param.GetTitle(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21441, 21469);
                    return return_v;
                }


                Microsoft.CodeAnalysis.LocalizableString
                f_550_21488_21524(Microsoft.CodeAnalysis.CommonMessageProvider
                this_param, int
                code)
                {
                    var return_v = this_param.GetMessageFormat(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21488, 21524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticDescriptor
                f_550_21342_21784(string
                id, Microsoft.CodeAnalysis.LocalizableString
                title, Microsoft.CodeAnalysis.LocalizableString
                messageFormat, string
                description, string
                category, Microsoft.CodeAnalysis.DiagnosticSeverity
                defaultSeverity, bool
                isEnabledByDefault, params string[]
                customTags)
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticDescriptor(id, title, messageFormat, description: (Microsoft.CodeAnalysis.LocalizableString)description, category: category, defaultSeverity: defaultSeverity, isEnabledByDefault: isEnabledByDefault, customTags: customTags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21342, 21784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_550_21848_21861()
                {
                    var return_v = Location.None;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 21848, 21861);
                    return return_v;
                }


                System.Type
                f_550_21863_21882(Microsoft.CodeAnalysis.ISourceGenerator
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21863, 21882);
                    return return_v;
                }


                string
                f_550_21863_21887(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 21863, 21887);
                    return return_v;
                }


                System.Type
                f_550_21889_21900(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21889, 21900);
                    return return_v;
                }


                string
                f_550_21889_21905(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 21889, 21905);
                    return return_v;
                }


                string
                f_550_21907_21916(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 21907, 21916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_550_21818_21917(Microsoft.CodeAnalysis.DiagnosticDescriptor
                descriptor, Microsoft.CodeAnalysis.Location
                location, params object?[]
                messageArgs)
                {
                    var return_v = Diagnostic.Create(descriptor, location, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21818, 21917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.GeneratorState
                f_550_21986_22040(Microsoft.CodeAnalysis.GeneratorInfo
                info, System.Exception
                e, Microsoft.CodeAnalysis.Diagnostic
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.GeneratorState(info, e, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 21986, 22040);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 20501, 22052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 20501, 22052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetFilePathPrefixForGenerator(ISourceGenerator generator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(550, 22064, 22307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 22169, 22200);

                var
                type = f_550_22180_22199(generator)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(550, 22214, 22296);

                return f_550_22221_22295(f_550_22234_22262(f_550_22234_22257(f_550_22234_22247(type))) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(550, 22234, 22278) ?? string.Empty), type.FullName!);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(550, 22064, 22307);

                System.Type
                f_550_22180_22199(Microsoft.CodeAnalysis.ISourceGenerator
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 22180, 22199);
                    return return_v;
                }


                System.Reflection.Assembly
                f_550_22234_22247(System.Type
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 22234, 22247);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_550_22234_22257(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.GetName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 22234, 22257);
                    return return_v;
                }


                string?
                f_550_22234_22262(System.Reflection.AssemblyName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(550, 22234, 22262);
                    return return_v;
                }


                string
                f_550_22221_22295(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 22221, 22295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(550, 22064, 22307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 22064, 22307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract CommonMessageProvider MessageProvider { get; }

        internal abstract GeneratorDriver FromState(GeneratorDriverState state);

        internal abstract SyntaxTree ParseGeneratedSourceText(GeneratedSourceText input, string fileName, CancellationToken cancellationToken);

        internal abstract AdditionalSourcesCollection CreateSourcesCollection();

        static GeneratorDriver()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(550, 1648, 22705);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(550, 1648, 22705);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(550, 1648, 22705);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(550, 1648, 22705);

        static System.Collections.Generic.IEnumerable<System.Linq.IGrouping<System.Type, Microsoft.CodeAnalysis.ISourceGenerator>>
        f_550_1850_1892(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
        source, System.Func<Microsoft.CodeAnalysis.ISourceGenerator, System.Type>
        keySelector)
        {
            var return_v = source.GroupBy<Microsoft.CodeAnalysis.ISourceGenerator, System.Type>(keySelector);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 1850, 1892);
            return return_v;
        }


        static int
        f_550_1850_1900(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<System.Type, Microsoft.CodeAnalysis.ISourceGenerator>>
        source)
        {
            var return_v = source.Count<System.Linq.IGrouping<System.Type, Microsoft.CodeAnalysis.ISourceGenerator>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 1850, 1900);
            return return_v;
        }


        static int
        f_550_1837_1928(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 1837, 1928);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorState>
        f_550_2341_2401(params Microsoft.CodeAnalysis.GeneratorState[]
        items)
        {
            var return_v = ImmutableArray.Create(items);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 2341, 2401);
            return return_v;
        }


        static Microsoft.CodeAnalysis.GeneratorDriverState
        f_550_2256_2456(Microsoft.CodeAnalysis.ParseOptions
        parseOptions, Microsoft.CodeAnalysis.Diagnostics.AnalyzerConfigOptionsProvider
        optionsProvider, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISourceGenerator>
        generators, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AdditionalText>
        additionalTexts, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.GeneratorState>
        generatorStates, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PendingEdit>
        edits, bool
        editsFailed)
        {
            var return_v = new Microsoft.CodeAnalysis.GeneratorDriverState(parseOptions, optionsProvider, generators, additionalTexts, generatorStates, edits, editsFailed: editsFailed);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(550, 2256, 2456);
            return return_v;
        }

    }
}
