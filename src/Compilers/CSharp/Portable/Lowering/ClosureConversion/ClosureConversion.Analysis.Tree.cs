// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class ClosureConversion
    {
        internal sealed partial class Analysis : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
        {
            [DebuggerDisplay("{ToString(), nq}")]
            public sealed class Scope
            {
                public readonly Scope Parent;

                public readonly ArrayBuilder<Scope> NestedScopes;

                public readonly ArrayBuilder<NestedFunction> NestedFunctions;

                public readonly SetWithInsertionOrder<Symbol> DeclaredVariables;

                public readonly BoundNode BoundNode;

                public readonly NestedFunction ContainingFunctionOpt;

                public ClosureEnvironment? DeclaredEnvironment;

                public Scope(Scope parent, BoundNode boundNode, NestedFunction containingFunction)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10452, 3990, 4313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 1454, 1460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 1517, 1565);
                        this.NestedScopes = f_10452_1532_1565(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 1804, 1864);
                        this.NestedFunctions = f_10452_1822_1864(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 2761, 2816);
                        this.DeclaredVariables = f_10452_2781_2816(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 3252, 3261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 3531, 3552);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 3922, 3948);
                        this.DeclaredEnvironment = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4576, 4637);
                        this.CanMergeWithParent = true; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4113, 4145);

                        f_10452_4113_4144(boundNode != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4169, 4185);

                        Parent = parent;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4207, 4229);

                        BoundNode = boundNode;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4251, 4294);

                        ContainingFunctionOpt = containingFunction;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10452, 3990, 4313);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 3990, 4313);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 3990, 4313);
                    }
                }

                public bool CanMergeWithParent { get; internal set; }

                public void Free()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 4657, 5095);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4716, 4836);
                            foreach (var scope in f_10452_4738_4750_I(NestedScopes))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 4716, 4836);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4800, 4813);

                                f_10452_4800_4812(scope);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 4716, 4836);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 121);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 121);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4858, 4878);

                        f_10452_4858_4877(NestedScopes);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4902, 5031);
                            foreach (var function in f_10452_4927_4942_I(NestedFunctions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 4902, 5031);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 4992, 5008);

                                f_10452_4992_5007(function);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 4902, 5031);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 130);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 130);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 5053, 5076);

                        f_10452_5053_5075(NestedFunctions);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 4657, 5095);

                        int
                        f_10452_4800_4812(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 4800, 4812);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        f_10452_4738_4750_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 4738, 4750);
                            return return_v;
                        }


                        int
                        f_10452_4858_4877(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 4858, 4877);
                            return 0;
                        }


                        int
                        f_10452_4992_5007(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 4992, 5007);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                        f_10452_4927_4942_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 4927, 4942);
                            return return_v;
                        }


                        int
                        f_10452_5053_5075(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 5053, 5075);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 4657, 5095);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 4657, 5095);
                    }
                }

                public override string ToString()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 5149, 5189);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 5152, 5189);
                        return f_10452_5152_5189(f_10452_5152_5178(BoundNode.Syntax)); DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 5149, 5189);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 5149, 5189);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 5149, 5189);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    Microsoft.CodeAnalysis.Text.SourceText
                    f_10452_5152_5178(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetText();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 5152, 5178);
                        return return_v;
                    }


                    string
                    f_10452_5152_5189(Microsoft.CodeAnalysis.Text.SourceText
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 5152, 5189);
                        return return_v;
                    }

                }

                static Scope()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10452, 1323, 5205);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10452, 1323, 5205);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 1323, 5205);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10452, 1323, 5205);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                f_10452_1532_1565()
                {
                    var return_v = ArrayBuilder<Scope>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 1532, 1565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                f_10452_1822_1864()
                {
                    var return_v = ArrayBuilder<NestedFunction>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 1822, 1864);
                    return return_v;
                }


                Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10452_2781_2816()
                {
                    var return_v = new Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 2781, 2816);
                    return return_v;
                }


                int
                f_10452_4113_4144(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 4113, 4144);
                    return 0;
                }

            }
            public sealed class NestedFunction
            {
                public readonly MethodSymbol OriginalMethodSymbol;

                public readonly SyntaxReference BlockSyntax;

                public readonly PooledHashSet<Symbol> CapturedVariables;

                public readonly ArrayBuilder<ClosureEnvironment> CapturedEnvironments
                ;

                public ClosureEnvironment ContainingEnvironmentOpt;

                private bool _capturesThis;

                public bool CapturesThis
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 7075, 7091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7078, 7091);
                            return _capturesThis; DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 7075, 7091);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 7006, 7276);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 7006, 7276);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    set
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 7114, 7257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7166, 7186);

                            f_10452_7166_7185(value);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7212, 7234);

                            _capturesThis = value;
                            DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 7114, 7257);

                            int
                            f_10452_7166_7185(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 7166, 7185);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 7006, 7276);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 7006, 7276);
                        }
                    }
                }

                public SynthesizedClosureMethod SynthesizedLoweredMethod;

                public NestedFunction(MethodSymbol symbol, SyntaxReference blockSyntax)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10452, 7373, 7633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 6062, 6082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 6264, 6275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 6334, 6389);
                        this.CapturedVariables = f_10452_6354_6389(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 6459, 6549);
                        this.CapturedEnvironments = f_10452_6503_6549(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 6596, 6620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 6654, 6667);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7328, 7352);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7485, 7514);

                        f_10452_7485_7513(symbol != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7536, 7566);

                        OriginalMethodSymbol = symbol;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7588, 7614);

                        BlockSyntax = blockSyntax;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10452, 7373, 7633);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 7373, 7633);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 7373, 7633);
                    }
                }

                public void Free()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 7653, 7806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7712, 7737);

                        f_10452_7712_7736(CapturedVariables);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7759, 7787);

                        f_10452_7759_7786(CapturedEnvironments);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 7653, 7806);

                        int
                        f_10452_7712_7736(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 7712, 7736);
                            return 0;
                        }


                        int
                        f_10452_7759_7786(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 7759, 7786);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 7653, 7806);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 7653, 7806);
                    }
                }

                static NestedFunction()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10452, 5821, 7821);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10452, 5821, 7821);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 5821, 7821);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10452, 5821, 7821);

                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10452_6354_6389()
                {
                    var return_v = PooledHashSet<Symbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 6354, 6389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ClosureEnvironment>
                f_10452_6503_6549()
                {
                    var return_v = ArrayBuilder<ClosureEnvironment>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 6503, 6549);
                    return return_v;
                }


                int
                f_10452_7485_7513(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 7485, 7513);
                    return 0;
                }

            }
            public sealed class ClosureEnvironment
            {
                public readonly SetWithInsertionOrder<Symbol> CapturedVariables;

                public bool CapturesParent;

                public readonly bool IsStruct;

                internal SynthesizedClosureEnvironment SynthesizedEnvironment;

                public ClosureEnvironment(IEnumerable<Symbol> capturedVariables, bool isStruct)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10452, 8456, 8854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 7954, 7971);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 8291, 8305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 8347, 8355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 8413, 8435);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 8576, 8632);

                        CapturedVariables = f_10452_8596_8631();
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 8654, 8793);
                            foreach (var item in f_10452_8675_8692_I(capturedVariables))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 8654, 8793);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 8742, 8770);

                                f_10452_8742_8769(CapturedVariables, item);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 8654, 8793);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 140);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 140);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 8815, 8835);

                        IsStruct = isStruct;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10452, 8456, 8854);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 8456, 8854);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 8456, 8854);
                    }
                }

                static ClosureEnvironment()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10452, 7837, 8869);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10452, 7837, 8869);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 7837, 8869);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10452, 7837, 8869);

                Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10452_8596_8631()
                {
                    var return_v = new Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 8596, 8631);
                    return return_v;
                }


                bool
                f_10452_8742_8769(Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 8742, 8769);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10452_8675_8692_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 8675, 8692);
                    return return_v;
                }

            }

            public static void VisitNestedFunctions(Scope scope, Action<Scope, NestedFunction> action)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10452, 9044, 9472);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 9167, 9298);
                        foreach (var function in f_10452_9192_9213_I(scope.NestedFunctions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 9167, 9298);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 9255, 9279);

                            f_10452_9255_9278(action, scope, function);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 9167, 9298);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 132);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 132);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 9318, 9457);
                        foreach (var nested in f_10452_9341_9359_I(scope.NestedScopes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 9318, 9457);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 9401, 9438);

                            f_10452_9401_9437(nested, action);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 9318, 9457);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 140);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10452, 9044, 9472);

                    int
                    f_10452_9255_9278(System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    arg1, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                    arg2)
                    {
                        this_param.Invoke(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 9255, 9278);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    f_10452_9192_9213_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 9192, 9213);
                        return return_v;
                    }


                    int
                    f_10452_9401_9437(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    scope, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    action)
                    {
                        VisitNestedFunctions(scope, action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 9401, 9437);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    f_10452_9341_9359_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 9341, 9359);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 9044, 9472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 9044, 9472);
                }
            }

            public static bool CheckNestedFunctions(Scope scope, Func<Scope, NestedFunction, bool> func)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10452, 9690, 10325);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 9815, 10032);
                        foreach (var function in f_10452_9840_9861_I(scope.NestedFunctions))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 9815, 10032);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 9903, 10013) || true) && (f_10452_9907_9928(func, scope, function))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 9903, 10013);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 9978, 9990);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 9903, 10013);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 9815, 10032);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 218);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 218);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 10052, 10277);
                        foreach (var nested in f_10452_10075_10093_I(scope.NestedScopes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 10052, 10277);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 10135, 10258) || true) && (f_10452_10139_10173(nested, func))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 10135, 10258);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 10223, 10235);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 10135, 10258);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 10052, 10277);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 226);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 226);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 10297, 10310);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10452, 9690, 10325);

                    bool
                    f_10452_9907_9928(System.Func<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction, bool>
                    this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    arg1, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                    arg2)
                    {
                        var return_v = this_param.Invoke(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 9907, 9928);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    f_10452_9840_9861_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 9840, 9861);
                        return return_v;
                    }


                    bool
                    f_10452_10139_10173(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    scope, System.Func<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction, bool>
                    func)
                    {
                        var return_v = CheckNestedFunctions(scope, func);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 10139, 10173);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    f_10452_10075_10093_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 10075, 10093);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 9690, 10325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 9690, 10325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static void VisitScopeTree(Scope treeRoot, Action<Scope> action)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10452, 10486, 10778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 10590, 10607);

                    f_10452_10590_10606(action, treeRoot);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 10627, 10763);
                        foreach (var nested in f_10452_10650_10671_I(treeRoot.NestedScopes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 10627, 10763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 10713, 10744);

                            f_10452_10713_10743(nested, action);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 10627, 10763);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 137);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 137);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10452, 10486, 10778);

                    int
                    f_10452_10590_10606(System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    obj)
                    {
                        this_param.Invoke(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 10590, 10606);
                        return 0;
                    }


                    int
                    f_10452_10713_10743(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                    treeRoot, System.Action<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    action)
                    {
                        VisitScopeTree(treeRoot, action);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 10713, 10743);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    f_10452_10650_10671_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 10650, 10671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 10486, 10778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 10486, 10778);
                }
            }
            private class ScopeTreeBuilder : BoundTreeWalkerWithStackGuardWithoutRecursionOnTheLeftOfBinaryOperator
            {
                private Scope _currentScope;

                private NestedFunction _currentFunction;

                private bool _inExpressionTree;

                private readonly SmallDictionary<Symbol, Scope> _localToScope;

                private readonly HashSet<Symbol> _freeVariables;

                private readonly MethodSymbol _topLevelMethod;

                private readonly HashSet<MethodSymbol> _methodsConvertedToDelegates;

                private readonly DiagnosticBag _diagnostics;

                private readonly PooledDictionary<LabelSymbol, ArrayBuilder<Scope>> _scopesAfterLabel;

                private readonly ArrayBuilder<ArrayBuilder<LabelSymbol>> _labelsInScope;

                private ScopeTreeBuilder(
                                    Scope rootScope,
                                    MethodSymbol topLevelMethod,
                                    HashSet<MethodSymbol> methodsConvertedToDelegates,
                                    DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10452, 15978, 16808);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 12475, 12488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 12699, 12722);
                        this._currentFunction = null; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 12754, 12779);
                        this._inExpressionTree = false; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 13204, 13256);
                        this._localToScope = f_10452_13220_13256(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 14161, 14199);
                        this._freeVariables = f_10452_14178_14199(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 14258, 14273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 14679, 14707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 14757, 14769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 15180, 15264);
                        this._scopesAfterLabel = f_10452_15200_15264(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 15887, 15957);
                        this._labelsInScope = f_10452_15904_15957(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 16252, 16284);

                        f_10452_16252_16283(rootScope != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 16306, 16343);

                        f_10452_16306_16342(topLevelMethod != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 16365, 16415);

                        f_10452_16365_16414(methodsConvertedToDelegates != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 16437, 16471);

                        f_10452_16437_16470(diagnostics != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 16495, 16521);

                        _currentScope = rootScope;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 16543, 16604);

                        f_10452_16543_16603(_labelsInScope, f_10452_16563_16602());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 16626, 16659);

                        _topLevelMethod = topLevelMethod;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 16681, 16740);

                        _methodsConvertedToDelegates = methodsConvertedToDelegates;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 16762, 16789);

                        _diagnostics = diagnostics;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10452, 15978, 16808);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 15978, 16808);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 15978, 16808);
                    }
                }

                public static Scope Build(
                                    BoundNode node,
                                    MethodSymbol topLevelMethod,
                                    HashSet<MethodSymbol> methodsConvertedToDelegates,
                                    DiagnosticBag diagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10452, 16828, 17695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 17160, 17206);

                        f_10452_17160_17205(node == f_10452_17181_17204(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 17228, 17265);

                        f_10452_17228_17264(topLevelMethod != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 17289, 17372);

                        var
                        rootScope = f_10452_17305_17371(parent: null, boundNode: node, containingFunction: null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 17394, 17599);

                        var
                        builder = f_10452_17408_17598(rootScope, topLevelMethod, methodsConvertedToDelegates, diagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 17621, 17637);

                        f_10452_17621_17636(builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 17659, 17676);

                        return rootScope;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10452, 16828, 17695);

                        Microsoft.CodeAnalysis.CSharp.BoundNode
                        f_10452_17181_17204(Microsoft.CodeAnalysis.CSharp.BoundNode
                        node)
                        {
                            var return_v = FindNodeToAnalyze(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 17181, 17204);
                            return return_v;
                        }


                        int
                        f_10452_17160_17205(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 17160, 17205);
                            return 0;
                        }


                        int
                        f_10452_17228_17264(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 17228, 17264);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        f_10452_17305_17371(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        parent, Microsoft.CodeAnalysis.CSharp.BoundNode
                        boundNode, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                        containingFunction)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope(parent: parent, boundNode: boundNode, containingFunction: containingFunction);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 17305, 17371);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        f_10452_17408_17598(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        rootScope, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        topLevelMethod, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                        methodsConvertedToDelegates, Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder(rootScope, topLevelMethod, methodsConvertedToDelegates, diagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 17408, 17598);
                            return return_v;
                        }


                        int
                        f_10452_17621_17636(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param)
                        {
                            this_param.Build();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 17621, 17636);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 16828, 17695);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 16828, 17695);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                private void Build()
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 17715, 18750);
                        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol thisParam = default(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 17833, 17890);

                        f_10452_17833_17889(this, _currentScope, f_10452_17862_17888(_topLevelMethod));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 17995, 18226) || true) && (f_10452_17999_18053(_topLevelMethod, out thisParam) && (DynAbs.Tracing.TraceSender.Expression_True(10452, 17999, 18082) && (object)thisParam != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 17995, 18226);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18132, 18203);

                            f_10452_18132_18202(this, _currentScope, f_10452_18161_18201(thisParam));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 17995, 18226);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18250, 18281);

                        f_10452_18250_18280(this, _currentScope.BoundNode);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18350, 18484);
                            foreach (var scopes in f_10452_18373_18397_I(f_10452_18373_18397(_scopesAfterLabel)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 18350, 18484);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18447, 18461);

                                f_10452_18447_18460(scopes);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 18350, 18484);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 135);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 135);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18506, 18531);

                        f_10452_18506_18530(_scopesAfterLabel);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18555, 18595);

                        f_10452_18555_18594(f_10452_18568_18588(_labelsInScope) == 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18617, 18651);

                        var
                        labels = f_10452_18630_18650(_labelsInScope)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18673, 18687);

                        f_10452_18673_18686(labels);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18709, 18731);

                        f_10452_18709_18730(_labelsInScope);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 17715, 18750);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10452_17862_17888(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 17862, 17888);
                            return return_v;
                        }


                        int
                        f_10452_17833_17889(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        scope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        locals)
                        {
                            this_param.DeclareLocals<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(scope, locals);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 17833, 17889);
                            return 0;
                        }


                        bool
                        f_10452_17999_18053(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param, out Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        thisParameter)
                        {
                            var return_v = this_param.TryGetThisParameter(out thisParameter);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 17999, 18053);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10452_18161_18201(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        item)
                        {
                            var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18161, 18201);
                            return return_v;
                        }


                        int
                        f_10452_18132_18202(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        scope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        locals)
                        {
                            this_param.DeclareLocals<Microsoft.CodeAnalysis.CSharp.Symbol>(scope, locals);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18132, 18202);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundNode?
                        f_10452_18250_18280(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                        node)
                        {
                            var return_v = this_param.Visit(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18250, 18280);
                            return return_v;
                        }


                        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>.ValueCollection
                        f_10452_18373_18397(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>
                        this_param)
                        {
                            var return_v = this_param.Values;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 18373, 18397);
                            return return_v;
                        }


                        int
                        f_10452_18447_18460(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18447, 18460);
                            return 0;
                        }


                        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>.ValueCollection
                        f_10452_18373_18397_I(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>.ValueCollection
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18373, 18397);
                            return return_v;
                        }


                        int
                        f_10452_18506_18530(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18506, 18530);
                            return 0;
                        }


                        int
                        f_10452_18568_18588(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                        this_param)
                        {
                            var return_v = this_param.Count;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 18568, 18588);
                            return return_v;
                        }


                        int
                        f_10452_18555_18594(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18555, 18594);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        f_10452_18630_18650(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                        builder)
                        {
                            var return_v = builder.Pop<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18630, 18650);
                            return return_v;
                        }


                        int
                        f_10452_18673_18686(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18673, 18686);
                            return 0;
                        }


                        int
                        f_10452_18709_18730(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 18709, 18730);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 17715, 18750);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 17715, 18750);
                    }
                }

                public override BoundNode VisitMethodGroup(BoundMethodGroup node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 18857, 18896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 18860, 18896);
                        throw f_10452_18866_18896(); DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 18857, 18896);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 18857, 18896);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 18857, 18896);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    System.Exception
                    f_10452_18866_18896()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 18866, 18896);
                        return return_v;
                    }

                }

                public override BoundNode VisitBlock(BoundBlock node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 18917, 19251);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19011, 19040);

                        var
                        oldScope = _currentScope
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19062, 19098);

                        f_10452_19062_19097(this, node, f_10452_19085_19096(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19120, 19155);

                        var
                        result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBlock(node), 10452, 19133, 19154)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19177, 19196);

                        f_10452_19177_19195(this, oldScope);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19218, 19232);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 18917, 19251);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        f_10452_19085_19096(Microsoft.CodeAnalysis.CSharp.BoundBlock
                        this_param)
                        {
                            var return_v = this_param.Locals;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 19085, 19096);
                            return return_v;
                        }


                        int
                        f_10452_19062_19097(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                        node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        locals)
                        {
                            this_param.PushOrReuseScope<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>((Microsoft.CodeAnalysis.CSharp.BoundNode)node, locals);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 19062, 19097);
                            return 0;
                        }


                        int
                        f_10452_19177_19195(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        scope)
                        {
                            this_param.PopScope(scope);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 19177, 19195);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 18917, 19251);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 18917, 19251);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitCatchBlock(BoundCatchBlock node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 19271, 19620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19375, 19404);

                        var
                        oldScope = _currentScope
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19426, 19462);

                        f_10452_19426_19461(this, node, f_10452_19449_19460(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19484, 19524);

                        var
                        result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(node), 10452, 19497, 19523)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19546, 19565);

                        f_10452_19546_19564(this, oldScope);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19587, 19601);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 19271, 19620);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        f_10452_19449_19460(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                        this_param)
                        {
                            var return_v = this_param.Locals;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 19449, 19460);
                            return return_v;
                        }


                        int
                        f_10452_19426_19461(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                        node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        locals)
                        {
                            this_param.PushOrReuseScope<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>((Microsoft.CodeAnalysis.CSharp.BoundNode)node, locals);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 19426, 19461);
                            return 0;
                        }


                        int
                        f_10452_19546_19564(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        scope)
                        {
                            this_param.PopScope(scope);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 19546, 19564);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 19271, 19620);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 19271, 19620);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitSequence(BoundSequence node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 19640, 19983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19740, 19769);

                        var
                        oldScope = _currentScope
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19791, 19827);

                        f_10452_19791_19826(this, node, f_10452_19814_19825(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19849, 19887);

                        var
                        result = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitSequence(node), 10452, 19862, 19886)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19909, 19928);

                        f_10452_19909_19927(this, oldScope);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 19950, 19964);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 19640, 19983);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        f_10452_19814_19825(Microsoft.CodeAnalysis.CSharp.BoundSequence
                        this_param)
                        {
                            var return_v = this_param.Locals;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 19814, 19825);
                            return return_v;
                        }


                        int
                        f_10452_19791_19826(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundSequence
                        node, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                        locals)
                        {
                            this_param.PushOrReuseScope<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>((Microsoft.CodeAnalysis.CSharp.BoundNode)node, locals);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 19791, 19826);
                            return 0;
                        }


                        int
                        f_10452_19909_19927(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        scope)
                        {
                            this_param.PopScope(scope);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 19909, 19927);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 19640, 19983);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 19640, 19983);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitLambda(BoundLambda node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 20003, 20502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 20099, 20143);

                        var
                        oldInExpressionTree = _inExpressionTree
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 20165, 20215);

                        _inExpressionTree |= f_10452_20186_20214(f_10452_20186_20195(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 20239, 20304);

                        f_10452_20239_20303(
                                            _methodsConvertedToDelegates, f_10452_20272_20302(f_10452_20272_20283(node)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 20326, 20383);

                        var
                        result = f_10452_20339_20382(this, f_10452_20359_20370(node), f_10452_20372_20381(node))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 20407, 20447);

                        _inExpressionTree = oldInExpressionTree;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 20469, 20483);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 20003, 20502);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10452_20186_20195(Microsoft.CodeAnalysis.CSharp.BoundLambda
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20186, 20195);
                            return return_v;
                        }


                        bool
                        f_10452_20186_20214(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        _type)
                        {
                            var return_v = _type.IsExpressionTree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 20186, 20214);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        f_10452_20272_20283(Microsoft.CodeAnalysis.CSharp.BoundLambda
                        this_param)
                        {
                            var return_v = this_param.Symbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20272, 20283);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10452_20272_20302(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20272, 20302);
                            return return_v;
                        }


                        bool
                        f_10452_20239_20303(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 20239, 20303);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        f_10452_20359_20370(Microsoft.CodeAnalysis.CSharp.BoundLambda
                        this_param)
                        {
                            var return_v = this_param.Symbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20359, 20370);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundBlock
                        f_10452_20372_20381(Microsoft.CodeAnalysis.CSharp.BoundLambda
                        this_param)
                        {
                            var return_v = this_param.Body;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20372, 20381);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundNode?
                        f_10452_20339_20382(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        functionSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock
                        body)
                        {
                            var return_v = this_param.VisitNestedFunction((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)functionSymbol, body);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 20339, 20382);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 20003, 20502);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 20003, 20502);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 20631, 20696);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 20634, 20696);
                        return f_10452_20634_20696(this, f_10452_20654_20684(f_10452_20654_20665(node)), f_10452_20686_20695(node)); DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 20631, 20696);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 20631, 20696);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 20631, 20696);
                    }
                    throw new System.Exception("Slicer error: unreachable code");

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                    f_10452_20654_20665(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                    this_param)
                    {
                        var return_v = this_param.Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20654, 20665);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10452_20654_20684(Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20654, 20684);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock?
                    f_10452_20686_20695(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
                    this_param)
                    {
                        var return_v = this_param.Body;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20686, 20695);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode?
                    f_10452_20634_20696(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    functionSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock?
                    body)
                    {
                        var return_v = this_param.VisitNestedFunction(functionSymbol, body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 20634, 20696);
                        return return_v;
                    }

                }

                public override BoundNode VisitCall(BoundCall node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 20717, 21148);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 20809, 21079) || true) && (f_10452_20813_20835(f_10452_20813_20824(node)) == MethodKind.LocalFunction)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 20809, 21079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 20997, 21056);

                            f_10452_20997_21055(this, f_10452_21011_21041(f_10452_21011_21022(node)), node.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 20809, 21079);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 21101, 21129);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCall(node), 10452, 21108, 21128);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 20717, 21148);

                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10452_20813_20824(Microsoft.CodeAnalysis.CSharp.BoundCall
                        this_param)
                        {
                            var return_v = this_param.Method;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20813, 20824);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind
                        f_10452_20813_20835(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.MethodKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 20813, 20835);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10452_21011_21022(Microsoft.CodeAnalysis.CSharp.BoundCall
                        this_param)
                        {
                            var return_v = this_param.Method;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 21011, 21022);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10452_21011_21041(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 21011, 21041);
                            return return_v;
                        }


                        int
                        f_10452_20997_21055(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        symbol, Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            this_param.AddIfCaptured((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 20997, 21055);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 20717, 21148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 20717, 21148);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitDelegateCreationExpression(BoundDelegateCreationExpression node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 21168, 21785);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 21304, 21694) || true) && (f_10452_21308_21334_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10452_21308_21322(node), 10452, 21308, 21334)?.MethodKind) == MethodKind.LocalFunction)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 21304, 21694);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 21496, 21543);

                            var
                            method = f_10452_21509_21542(f_10452_21509_21523(node))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 21569, 21604);

                            f_10452_21569_21603(this, method, node.Syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 21630, 21671);

                            f_10452_21630_21670(_methodsConvertedToDelegates, method);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 21304, 21694);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 21716, 21766);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitDelegateCreationExpression(node), 10452, 21723, 21765);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 21168, 21785);

                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                        f_10452_21308_21322(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                        this_param)
                        {
                            var return_v = this_param.MethodOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 21308, 21322);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind?
                        f_10452_21308_21334_M(Microsoft.CodeAnalysis.MethodKind?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 21308, 21334);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10452_21509_21523(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                        this_param)
                        {
                            var return_v = this_param.MethodOpt;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 21509, 21523);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10452_21509_21542(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.OriginalDefinition;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 21509, 21542);
                            return return_v;
                        }


                        int
                        f_10452_21569_21603(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        symbol, Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            this_param.AddIfCaptured((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 21569, 21603);
                            return 0;
                        }


                        bool
                        f_10452_21630_21670(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 21630, 21670);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 21168, 21785);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 21168, 21785);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitParameter(BoundParameter node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 21805, 22030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 21907, 21956);

                        f_10452_21907_21955(this, f_10452_21921_21941(node), node.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 21978, 22011);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitParameter(node), 10452, 21985, 22010);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 21805, 22030);

                        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        f_10452_21921_21941(Microsoft.CodeAnalysis.CSharp.BoundParameter
                        this_param)
                        {
                            var return_v = this_param.ParameterSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 21921, 21941);
                            return return_v;
                        }


                        int
                        f_10452_21907_21955(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        symbol, Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            this_param.AddIfCaptured((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 21907, 21955);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 21805, 22030);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 21805, 22030);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitLocal(BoundLocal node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 22050, 22259);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 22144, 22189);

                        f_10452_22144_22188(this, f_10452_22158_22174(node), node.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 22211, 22240);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10452, 22218, 22239);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 22050, 22259);

                        Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        f_10452_22158_22174(Microsoft.CodeAnalysis.CSharp.BoundLocal
                        this_param)
                        {
                            var return_v = this_param.LocalSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 22158, 22174);
                            return return_v;
                        }


                        int
                        f_10452_22144_22188(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        symbol, Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            this_param.AddIfCaptured((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 22144, 22188);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 22050, 22259);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 22050, 22259);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitBaseReference(BoundBaseReference node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 22279, 22525);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 22389, 22447);

                        f_10452_22389_22446(this, f_10452_22403_22432(_topLevelMethod), node.Syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 22469, 22506);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBaseReference(node), 10452, 22476, 22505);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 22279, 22525);

                        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        f_10452_22403_22432(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ThisParameter;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 22403, 22432);
                            return return_v;
                        }


                        int
                        f_10452_22389_22446(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        symbol, Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            this_param.AddIfCaptured((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 22389, 22446);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 22279, 22525);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 22279, 22525);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitThisReference(BoundThisReference node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 22545, 23751);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 22655, 22701);

                        var
                        thisParam = f_10452_22671_22700(_topLevelMethod)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 22723, 23671) || true) && (thisParam != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 22723, 23671);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 22794, 22832);

                            f_10452_22794_22831(this, thisParam, node.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 22723, 23671);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 22723, 23671);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 22723, 23671);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 23695, 23732);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitThisReference(node), 10452, 23702, 23731);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 22545, 23751);

                        Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        f_10452_22671_22700(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ThisParameter;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 22671, 22700);
                            return return_v;
                        }


                        int
                        f_10452_22794_22831(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        symbol, Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            this_param.AddIfCaptured((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 22794, 22831);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 22545, 23751);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 22545, 23751);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitLabelStatement(BoundLabelStatement node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 23771, 24091);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 23883, 23921);

                        f_10452_23883_23920(f_10452_23883_23904(_labelsInScope), f_10452_23909_23919(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 23943, 24012);

                        f_10452_23943_24011(_scopesAfterLabel, f_10452_23965_23975(node), f_10452_23977_24010());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 24034, 24072);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLabelStatement(node), 10452, 24041, 24071);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 23771, 24091);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        f_10452_23883_23904(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                        builder)
                        {
                            var return_v = builder.Peek<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 23883, 23904);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        f_10452_23909_23919(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                        this_param)
                        {
                            var return_v = this_param.Label;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 23909, 23919);
                            return return_v;
                        }


                        int
                        f_10452_23883_23920(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 23883, 23920);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        f_10452_23965_23975(Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                        this_param)
                        {
                            var return_v = this_param.Label;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 23965, 23975);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        f_10452_23977_24010()
                        {
                            var return_v = ArrayBuilder<Scope>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 23977, 24010);
                            return return_v;
                        }


                        int
                        f_10452_23943_24011(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        key, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        value)
                        {
                            this_param.Add(key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 23943, 24011);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 23771, 24091);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 23771, 24091);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitGotoStatement(BoundGotoStatement node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 24111, 24337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 24221, 24257);

                        f_10452_24221_24256(this, f_10452_24245_24255(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 24281, 24318);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitGotoStatement(node), 10452, 24288, 24317);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 24111, 24337);

                        Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        f_10452_24245_24255(Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                        this_param)
                        {
                            var return_v = this_param.Label;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 24245, 24255);
                            return return_v;
                        }


                        int
                        f_10452_24221_24256(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        jumpTarget)
                        {
                            this_param.CheckCanMergeWithParent(jumpTarget);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 24221, 24256);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 24111, 24337);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 24111, 24337);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override BoundNode VisitConditionalGoto(BoundConditionalGoto node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 24357, 24589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 24471, 24507);

                        f_10452_24471_24506(this, f_10452_24495_24505(node));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 24531, 24570);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitConditionalGoto(node), 10452, 24538, 24569);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 24357, 24589);

                        Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        f_10452_24495_24505(Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto
                        this_param)
                        {
                            var return_v = this_param.Label;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 24495, 24505);
                            return return_v;
                        }


                        int
                        f_10452_24471_24506(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        jumpTarget)
                        {
                            this_param.CheckCanMergeWithParent(jumpTarget);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 24471, 24506);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 24357, 24589);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 24357, 24589);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                private void CheckCanMergeWithParent(LabelSymbol jumpTarget)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 25052, 26227);
                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope> scopesAfterLabel = default(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 25361, 26208) || true) && (f_10452_25365_25432(_scopesAfterLabel, jumpTarget, out scopesAfterLabel))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 25361, 26208);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 25482, 26015);
                                foreach (var scope in f_10452_25504_25520_I(scopesAfterLabel))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 25482, 26015);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 25955, 25988);

                                    scope.CanMergeWithParent = false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 25482, 26015);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 534);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 534);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 26160, 26185);

                            f_10452_26160_26184(
                                                    // Prevent us repeating this process for all scopes if another jumps goes to the same label
                                                    scopesAfterLabel);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 25361, 26208);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 25052, 26227);

                        bool
                        f_10452_25365_25432(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        key, out Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 25365, 25432);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        f_10452_25504_25520_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 25504, 25520);
                            return return_v;
                        }


                        int
                        f_10452_26160_26184(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        this_param)
                        {
                            this_param.Clear();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 26160, 26184);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 25052, 26227);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 25052, 26227);
                    }
                }

                private BoundNode? VisitNestedFunction(MethodSymbol functionSymbol, BoundBlock? body)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 26265, 27888);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 26391, 26436);

                        f_10452_26391_26435(functionSymbol is object);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 26460, 26719) || true) && (body is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 26460, 26719);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 26569, 26658);

                            f_10452_26569_26657(                        // extern closure
                                                    _currentScope.NestedFunctions, f_10452_26603_26656(functionSymbol, blockSyntax: null));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 26684, 26696);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 26460, 26719);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 26888, 26966);

                        var
                        function = f_10452_26903_26965(functionSymbol, f_10452_26938_26964(body.Syntax))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 26988, 27032);

                        f_10452_26988_27031(_currentScope.NestedFunctions, function);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 27056, 27091);

                        var
                        oldFunction = _currentFunction
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 27113, 27141);

                        _currentFunction = function;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 27165, 27194);

                        var
                        oldScope = _currentScope
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 27216, 27241);

                        f_10452_27216_27240(this, body);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 27514, 27589);

                        f_10452_27514_27588(this, _currentScope, f_10452_27543_27568(functionSymbol), _inExpressionTree);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 27613, 27737);

                        var
                        result = (DynAbs.Tracing.TraceSender.Conditional_F1(10452, 27626, 27643) || ((_inExpressionTree
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10452, 27671, 27692)) || DynAbs.Tracing.TraceSender.Conditional_F3(10452, 27720, 27736))) ? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBlock(body), 10452, 27671, 27692) : f_10452_27720_27736(this, body)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 27761, 27780);

                        f_10452_27761_27779(this, oldScope);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 27802, 27833);

                        _currentFunction = oldFunction;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 27855, 27869);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 26265, 27888);

                        int
                        f_10452_26391_26435(bool
                        b)
                        {
                            RoslynDebug.Assert(b);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 26391, 26435);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                        f_10452_26603_26656(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        symbol, Microsoft.CodeAnalysis.SyntaxReference
                        blockSyntax)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction(symbol, blockSyntax: blockSyntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 26603, 26656);
                            return return_v;
                        }


                        int
                        f_10452_26569_26657(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 26569, 26657);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.SyntaxReference
                        f_10452_26938_26964(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.GetReference();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 26938, 26964);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                        f_10452_26903_26965(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        symbol, Microsoft.CodeAnalysis.SyntaxReference
                        blockSyntax)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction(symbol, blockSyntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 26903, 26965);
                            return return_v;
                        }


                        int
                        f_10452_26988_27031(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction>
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 26988, 27031);
                            return 0;
                        }


                        int
                        f_10452_27216_27240(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                        node)
                        {
                            this_param.CreateAndPushScope((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 27216, 27240);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10452_27543_27568(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 27543, 27568);
                            return return_v;
                        }


                        int
                        f_10452_27514_27588(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        scope, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        locals, bool
                        declareAsFree)
                        {
                            this_param.DeclareLocals<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>(scope, locals, declareAsFree);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 27514, 27588);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.BoundNode
                        f_10452_27720_27736(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                        node)
                        {
                            var return_v = this_param.VisitBlock(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 27720, 27736);
                            return return_v;
                        }


                        int
                        f_10452_27761_27779(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        scope)
                        {
                            this_param.PopScope(scope);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 27761, 27779);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 26265, 27888);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 26265, 27888);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                private void AddIfCaptured(Symbol symbol, SyntaxNode syntax)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 27927, 31025);
                        Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope declScope = default(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 28028, 28225);

                        f_10452_28028_28224(f_10452_28067_28078(symbol) == SymbolKind.Local || (DynAbs.Tracing.TraceSender.Expression_False(10452, 28067, 28162) || f_10452_28127_28138(symbol) == SymbolKind.Parameter) || (DynAbs.Tracing.TraceSender.Expression_False(10452, 28067, 28223) || f_10452_28191_28202(symbol) == SymbolKind.Method));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 28249, 28437) || true) && (_currentFunction == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 28249, 28437);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 28407, 28414);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 28249, 28437);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 28461, 28662) || true) && (symbol is LocalSymbol local && (DynAbs.Tracing.TraceSender.Expression_True(10452, 28465, 28509) && f_10452_28496_28509(local)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 28461, 28662);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 28632, 28639);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 28461, 28662);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 28686, 28949) || true) && (symbol is MethodSymbol method && (DynAbs.Tracing.TraceSender.Expression_True(10452, 28690, 28795) && _currentFunction.OriginalMethodSymbol == method))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 28686, 28949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 28919, 28926);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 28686, 28949);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 28973, 29019);

                        f_10452_28973_29018(f_10452_28986_29009(symbol) != null);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 29041, 31006) || true) && (f_10452_29045_29068(symbol) != _currentFunction.OriginalMethodSymbol)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 29041, 31006);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 29263, 29309);

                            f_10452_29263_29308(this, symbol, syntax);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 29414, 29440);

                            var
                            scope = _currentScope
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 29466, 29498);

                            var
                            function = _currentFunction
                            ;
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 29524, 30067) || true) && (function != null && (DynAbs.Tracing.TraceSender.Expression_True(10452, 29531, 29607) && f_10452_29551_29574(symbol) != function.OriginalMethodSymbol))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 29524, 30067);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 29665, 29704);

                                    f_10452_29665_29703(function.CapturedVariables, symbol);
                                    try
                                    {
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 29807, 29971) || true) && (scope.ContainingFunctionOpt == function)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 29807, 29971);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 29919, 29940);

                                            scope = scope.Parent;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 29807, 29971);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 29807, 29971);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 29807, 29971);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 30001, 30040);

                                    function = scope.ContainingFunctionOpt;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 29524, 30067);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 29524, 30067);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 29524, 30067);
                            }
                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 30333, 30461) || true) && (f_10452_30337_30348(symbol) == SymbolKind.Method)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 30333, 30461);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 30427, 30434);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 30333, 30461);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 30489, 30983) || true) && (f_10452_30493_30545(_localToScope, symbol, out declScope))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 30489, 30983);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 30603, 30643);

                                f_10452_30603_30642(declScope.DeclaredVariables, symbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 30489, 30983);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 30489, 30983);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 30902, 30948);

                                f_10452_30902_30947(f_10452_30915_30946(_freeVariables, symbol));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 30489, 30983);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 29041, 31006);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 27927, 31025);

                        Microsoft.CodeAnalysis.SymbolKind
                        f_10452_28067_28078(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 28067, 28078);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10452_28127_28138(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 28127, 28138);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10452_28191_28202(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 28191, 28202);
                            return return_v;
                        }


                        int
                        f_10452_28028_28224(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 28028, 28224);
                            return 0;
                        }


                        bool
                        f_10452_28496_28509(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        this_param)
                        {
                            var return_v = this_param.IsConst;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 28496, 28509);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10452_28986_29009(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 28986, 29009);
                            return return_v;
                        }


                        int
                        f_10452_28973_29018(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 28973, 29018);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10452_29045_29068(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 29045, 29068);
                            return return_v;
                        }


                        int
                        f_10452_29263_29308(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        capturedVariable, Microsoft.CodeAnalysis.SyntaxNode
                        syntax)
                        {
                            this_param.AddDiagnosticIfRestrictedType(capturedVariable, syntax);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 29263, 29308);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10452_29551_29574(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 29551, 29574);
                            return return_v;
                        }


                        bool
                        f_10452_29665_29703(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        item)
                        {
                            var return_v = this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 29665, 29703);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10452_30337_30348(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 30337, 30348);
                            return return_v;
                        }


                        bool
                        f_10452_30493_30545(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        key, out Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        value)
                        {
                            var return_v = this_param.TryGetValue(key, out value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 30493, 30545);
                            return return_v;
                        }


                        bool
                        f_10452_30603_30642(Roslyn.Utilities.SetWithInsertionOrder<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        value)
                        {
                            var return_v = this_param.Add(value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 30603, 30642);
                            return return_v;
                        }


                        bool
                        f_10452_30915_30946(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                        item)
                        {
                            var return_v = this_param.Contains(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 30915, 30946);
                            return return_v;
                        }


                        int
                        f_10452_30902_30947(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 30902, 30947);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 27927, 31025);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 27927, 31025);
                    }
                }

                private void AddDiagnosticIfRestrictedType(Symbol capturedVariable, SyntaxNode syntax)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 31202, 32335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 31329, 31345);

                        TypeSymbol
                        type
                        = default(TypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 31367, 32108);

                        switch (f_10452_31375_31396(capturedVariable))
                        {

                            case SymbolKind.Local:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 31367, 32108);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 31498, 31542);

                                type = f_10452_31505_31541(((LocalSymbol)capturedVariable));
                                DynAbs.Tracing.TraceSender.TraceBreak(10452, 31572, 31578);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 31367, 32108);

                            case SymbolKind.Parameter:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 31367, 32108);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 31660, 31708);

                                type = f_10452_31667_31707(((ParameterSymbol)capturedVariable));
                                DynAbs.Tracing.TraceSender.TraceBreak(10452, 31738, 31744);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 31367, 32108);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 31367, 32108);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 31991, 32048);

                                f_10452_31991_32047(f_10452_32004_32025(capturedVariable) == SymbolKind.Method);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 32078, 32085);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 31367, 32108);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 32132, 32316) || true) && (f_10452_32136_32159(type) == true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 32132, 32316);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 32217, 32293);

                            f_10452_32217_32292(_diagnostics, ErrorCode.ERR_SpecialByRefInLambda, f_10452_32270_32285(syntax), type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 32132, 32316);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 31202, 32335);

                        Microsoft.CodeAnalysis.SymbolKind
                        f_10452_31375_31396(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 31375, 31396);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10452_31505_31541(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 31505, 31541);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        f_10452_31667_31707(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 31667, 31707);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10452_32004_32025(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 32004, 32025);
                            return return_v;
                        }


                        int
                        f_10452_31991_32047(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 31991, 32047);
                            return 0;
                        }


                        bool
                        f_10452_32136_32159(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.IsRestrictedType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 32136, 32159);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Location
                        f_10452_32270_32285(Microsoft.CodeAnalysis.SyntaxNode
                        this_param)
                        {
                            var return_v = this_param.Location;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 32270, 32285);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                        f_10452_32217_32292(Microsoft.CodeAnalysis.DiagnosticBag
                        diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                        code, Microsoft.CodeAnalysis.Location
                        location, params object[]
                        args)
                        {
                            var return_v = diagnostics.Add(code, location, args);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 32217, 32292);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 31202, 32335);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 31202, 32335);
                    }
                }

                private void PushOrReuseScope<TSymbol>(BoundNode node, ImmutableArray<TSymbol> locals)
                                    where TSymbol : Symbol
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 32746, 33525);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 33293, 33445) || true) && (f_10452_33297_33312_M(!locals.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10452, 33297, 33347) && _currentScope.BoundNode != node))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 33293, 33445);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 33397, 33422);

                            f_10452_33397_33421<TSymbol>(this, node);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 33293, 33445);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 33469, 33506);

                        f_10452_33469_33505<TSymbol>(this, _currentScope, locals);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 32746, 33525);

                        bool
                        f_10452_33297_33312_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 33297, 33312);
                            return return_v;
                        }


                        int
                        f_10452_33397_33421<TSymbol>(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                        node) where TSymbol : Symbol

                        {
                            this_param.CreateAndPushScope(node);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 33397, 33421);
                            return 0;
                        }


                        int
                        f_10452_33469_33505<TSymbol>(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.ScopeTreeBuilder
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        scope, System.Collections.Immutable.ImmutableArray<TSymbol>
                        locals) where TSymbol : Symbol

                        {
                            this_param.DeclareLocals<TSymbol>(scope, locals);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 33469, 33505);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 32746, 33525);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 32746, 33525);
                    }
                }

                private void CreateAndPushScope(BoundNode node)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 33835, 34722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 33923, 33986);

                        var
                        scope = f_10452_33935_33985(_currentScope, _currentFunction)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 34010, 34162);
                            foreach (var label in f_10452_34032_34053_I(f_10452_34032_34053(_labelsInScope)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 34010, 34162);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 34103, 34139);

                                f_10452_34103_34138(f_10452_34103_34127(_scopesAfterLabel, label), scope);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 34010, 34162);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 153);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 153);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 34186, 34247);

                        f_10452_34186_34246(
                                            _labelsInScope, f_10452_34206_34245());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 34271, 34293);

                        _currentScope = scope;

                        Scope CreateNestedScope(Scope parentScope, NestedFunction currentFunction)
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 34317, 34703);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 34440, 34484);

                                f_10452_34440_34483(parentScope.BoundNode != node);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 34512, 34573);

                                var
                                newScope = f_10452_34527_34572(parentScope, node, currentFunction)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 34599, 34638);

                                f_10452_34599_34637(parentScope.NestedScopes, newScope);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 34664, 34680);

                                return newScope;
                                DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 34317, 34703);

                                int
                                f_10452_34440_34483(bool
                                condition)
                                {
                                    Debug.Assert(condition);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 34440, 34483);
                                    return 0;
                                }


                                Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                                f_10452_34527_34572(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                                parent, Microsoft.CodeAnalysis.CSharp.BoundNode
                                boundNode, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                                containingFunction)
                                {
                                    var return_v = new Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope(parent, boundNode, containingFunction);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 34527, 34572);
                                    return return_v;
                                }


                                int
                                f_10452_34599_34637(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                                this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                                item)
                                {
                                    this_param.Add(item);
                                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 34599, 34637);
                                    return 0;
                                }

                            }
                            catch
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 34317, 34703);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 34317, 34703);
                            }
                            throw new System.Exception("Slicer error: unreachable code");
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 33835, 34722);

                        Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        f_10452_33935_33985(Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        parentScope, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.NestedFunction
                        currentFunction)
                        {
                            var return_v = CreateNestedScope(parentScope, currentFunction);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 33935, 33985);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        f_10452_34032_34053(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                        builder)
                        {
                            var return_v = builder.Peek<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 34032, 34053);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        f_10452_34103_34127(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 34103, 34127);
                            return return_v;
                        }


                        int
                        f_10452_34103_34138(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        this_param, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        item)
                        {
                            this_param.Add(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 34103, 34138);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        f_10452_34032_34053_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 34032, 34053);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        f_10452_34206_34245()
                        {
                            var return_v = ArrayBuilder<LabelSymbol>.GetInstance();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 34206, 34245);
                            return return_v;
                        }


                        int
                        f_10452_34186_34246(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                        builder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        e)
                        {
                            builder.Push<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>(e);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 34186, 34246);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 33835, 34722);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 33835, 34722);
                    }
                }

                private void PopScope(Scope scope)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 35181, 36142);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 35256, 35362) || true) && (scope == _currentScope)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 35256, 35362);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 35332, 35339);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 35256, 35362);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 35386, 35540);

                        f_10452_35386_35539(scope == _currentScope.Parent, $"{nameof(scope)} must be {nameof(_currentScope)} or {nameof(_currentScope)}.{nameof(_currentScope.Parent)}");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 35729, 35763);

                        var
                        labels = f_10452_35742_35762(_labelsInScope)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 35787, 36024);
                            foreach (var label in f_10452_35809_35815_I(labels))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 35787, 36024);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 35865, 35903);

                                var
                                scopes = f_10452_35878_35902(_scopesAfterLabel, label)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 35929, 35943);

                                f_10452_35929_35942(scopes);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 35969, 36001);

                                f_10452_35969_36000(_scopesAfterLabel, label);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 35787, 36024);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 238);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 238);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 36048, 36062);

                        f_10452_36048_36061(
                                            labels);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 36086, 36123);

                        _currentScope = _currentScope.Parent;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 35181, 36142);

                        int
                        f_10452_35386_35539(bool
                        condition, string
                        message)
                        {
                            Debug.Assert(condition, message);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 35386, 35539);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        f_10452_35742_35762(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                        builder)
                        {
                            var return_v = builder.Pop<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 35742, 35762);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        f_10452_35878_35902(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10452, 35878, 35902);
                            return return_v;
                        }


                        int
                        f_10452_35929_35942(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 35929, 35942);
                            return 0;
                        }


                        bool
                        f_10452_35969_36000(Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                        key)
                        {
                            var return_v = this_param.Remove(key);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 35969, 36000);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        f_10452_35809_35815_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 35809, 35815);
                            return return_v;
                        }


                        int
                        f_10452_36048_36061(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                        this_param)
                        {
                            this_param.Free();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 36048, 36061);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 35181, 36142);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 35181, 36142);
                    }
                }

                private void DeclareLocals<TSymbol>(Scope scope, ImmutableArray<TSymbol> locals, bool declareAsFree = false)
                                    where TSymbol : Symbol
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10452, 36162, 36856);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 36355, 36837);
                            foreach (var local in f_10452_36377_36383_I<TSymbol>(locals))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 36355, 36837);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 36433, 36481);

                                f_10452_36433_36480<TSymbol>(!f_10452_36447_36479<TSymbol>(_localToScope, local));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 36507, 36814) || true) && (declareAsFree)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 36507, 36814);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 36593, 36633);

                                    f_10452_36593_36632<TSymbol>(f_10452_36606_36631<TSymbol>(_freeVariables, local));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 36507, 36814);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10452, 36507, 36814);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10452, 36755, 36787);

                                    f_10452_36755_36786<TSymbol>(_localToScope, local, scope);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 36507, 36814);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10452, 36355, 36837);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10452, 1, 483);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10452, 1, 483);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10452, 36162, 36856);

                        bool
                        f_10452_36447_36479<TSymbol>(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        this_param, TSymbol
                        key) where TSymbol : Symbol

                        {
                            var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.Symbol)key);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 36447, 36479);
                            return return_v;
                        }


                        int
                        f_10452_36433_36480<TSymbol>(bool
                        condition) where TSymbol : Symbol

                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 36433, 36480);
                            return 0;
                        }


                        bool
                        f_10452_36606_36631<TSymbol>(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param, TSymbol
                        item) where TSymbol : Symbol

                        {
                            var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 36606, 36631);
                            return return_v;
                        }


                        int
                        f_10452_36593_36632<TSymbol>(bool
                        condition) where TSymbol : Symbol

                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 36593, 36632);
                            return 0;
                        }


                        int
                        f_10452_36755_36786<TSymbol>(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                        this_param, TSymbol
                        key, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope
                        value) where TSymbol : Symbol

                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)key, value);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 36755, 36786);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<TSymbol>
                        f_10452_36377_36383_I<TSymbol>(System.Collections.Immutable.ImmutableArray<TSymbol>
                        i) where TSymbol : Symbol

                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 36377, 36383);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10452, 36162, 36856);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 36162, 36856);
                    }
                }

                static ScopeTreeBuilder()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10452, 12085, 36871);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10452, 12085, 36871);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10452, 12085, 36871);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10452, 12085, 36871);

                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>
                f_10452_13220_13256()
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 13220, 13256);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10452_14178_14199()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 14178, 14199);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.ClosureConversion.Analysis.Scope>>
                f_10452_15200_15264()
                {
                    var return_v = PooledDictionary<LabelSymbol, ArrayBuilder<Scope>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 15200, 15264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                f_10452_15904_15957()
                {
                    var return_v = ArrayBuilder<ArrayBuilder<LabelSymbol>>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 15904, 15957);
                    return return_v;
                }


                int
                f_10452_16252_16283(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 16252, 16283);
                    return 0;
                }


                int
                f_10452_16306_16342(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 16306, 16342);
                    return 0;
                }


                int
                f_10452_16365_16414(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 16365, 16414);
                    return 0;
                }


                int
                f_10452_16437_16470(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 16437, 16470);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                f_10452_16563_16602()
                {
                    var return_v = ArrayBuilder<LabelSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 16563, 16602);
                    return return_v;
                }


                int
                f_10452_16543_16603(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>
                builder, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>
                e)
                {
                    builder.Push<Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol>>(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10452, 16543, 16603);
                    return 0;
                }

            }
        }
    }
}
