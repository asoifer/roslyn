// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class MethodToClassRewriter : BoundTreeRewriterWithStackGuard
    {
        protected Dictionary<Symbol, CapturedSymbolReplacement> proxies;

        protected readonly Dictionary<LocalSymbol, LocalSymbol> localMap;

        protected abstract TypeMap TypeMap { get; }

        protected abstract BoundExpression FramePointer(SyntaxNode syntax, NamedTypeSymbol frameClass);

        protected abstract MethodSymbol CurrentMethod { get; }

        protected abstract NamedTypeSymbol ContainingType { get; }

        protected readonly TypeCompilationState CompilationState;

        protected readonly DiagnosticBag Diagnostics;

        protected readonly VariableSlotAllocator slotAllocatorOpt;

        private readonly Dictionary<BoundValuePlaceholderBase, BoundExpression> _placeholderMap;

        protected MethodToClassRewriter(VariableSlotAllocator slotAllocatorOpt, TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10436, 3106, 3621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 1464, 1525);
                this.proxies = f_10436_1474_1525(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 1932, 1985);
                this.localMap = f_10436_1943_1985(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 2852, 2868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 2914, 2925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 2977, 2993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 3078, 3093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 3268, 3307);

                f_10436_3268_3306(compilationState != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 3321, 3355);

                f_10436_3321_3354(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 3371, 3412);

                this.CompilationState = compilationState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 3426, 3457);

                this.Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 3471, 3512);

                this.slotAllocatorOpt = slotAllocatorOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 3526, 3610);

                this._placeholderMap = f_10436_3549_3609();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10436, 3106, 3621);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 3106, 3621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 3106, 3621);
            }
        }

        protected abstract bool NeedsProxy(Symbol localOrParameter);

        protected void RewriteLocals(ImmutableArray<LocalSymbol> locals, ArrayBuilder<LocalSymbol> newLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 3941, 4319);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4067, 4308);
                    foreach (var local in f_10436_4089_4095_I(locals))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 4067, 4308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4129, 4150);

                        LocalSymbol
                        newLocal
                        = default(LocalSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4168, 4293) || true) && (f_10436_4172_4208(this, local, out newLocal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 4168, 4293);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4250, 4274);

                            f_10436_4250_4273(newLocals, newLocal);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 4168, 4293);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 4067, 4308);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10436, 1, 242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10436, 1, 242);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 3941, 4319);

                bool
                f_10436_4172_4208(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                newLocal)
                {
                    var return_v = this_param.TryRewriteLocal(local, out newLocal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 4172, 4208);
                    return return_v;
                }


                int
                f_10436_4250_4273(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 4250, 4273);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_4089_4095_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 4089, 4095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 3941, 4319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 3941, 4319);
            }
        }

        protected bool TryRewriteLocal(LocalSymbol local, out LocalSymbol newLocal)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 4331, 5180);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4431, 4593) || true) && (f_10436_4435_4452(this, local))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 4431, 4593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4531, 4547);

                    newLocal = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4565, 4578);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 4431, 4593);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4609, 4715) || true) && (f_10436_4613_4654(localMap, local, out newLocal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 4609, 4715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4688, 4700);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 4609, 4715);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4731, 4767);

                var
                newType = f_10436_4745_4766(this, f_10436_4755_4765(local))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4781, 5141) || true) && (f_10436_4785_4860(newType, f_10436_4812_4822(local), TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 4781, 5141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4894, 4911);

                    newLocal = local;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 4781, 5141);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 4781, 5141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 4977, 5078);

                    newLocal = f_10436_4988_5077(local, TypeWithAnnotations.Create(newType), f_10436_5063_5076());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5096, 5126);

                    f_10436_5096_5125(localMap, local, newLocal);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 4781, 5141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5157, 5169);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 4331, 5180);

                bool
                f_10436_4435_4452(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localOrParameter)
                {
                    var return_v = this_param.NeedsProxy((Microsoft.CodeAnalysis.CSharp.Symbol)localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 4435, 4452);
                    return return_v;
                }


                bool
                f_10436_4613_4654(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 4613, 4654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_4755_4765(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 4755, 4765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_4745_4766(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 4745, 4766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_4812_4822(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 4812, 4822);
                    return return_v;
                }


                bool
                f_10436_4785_4860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 4785, 4860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_5063_5076()
                {
                    var return_v = CurrentMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 5063, 5076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSubstitutedLocalSymbol
                f_10436_4988_5077(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                originalVariable, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                containingSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeSubstitutedLocalSymbol(originalVariable, type, (Microsoft.CodeAnalysis.CSharp.Symbol)containingSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 4988, 5077);
                    return return_v;
                }


                int
                f_10436_5096_5125(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 5096, 5125);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 4331, 5180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 4331, 5180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<LocalSymbol> RewriteLocals(ImmutableArray<LocalSymbol> locals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 5192, 5516);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5302, 5336) || true) && (locals.IsEmpty)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 5302, 5336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5322, 5336);

                    return locals;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 5302, 5336);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5350, 5406);

                var
                newLocals = f_10436_5366_5405()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5420, 5453);

                f_10436_5420_5452(this, locals, newLocals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5467, 5505);

                return f_10436_5474_5504(newLocals);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 5192, 5516);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_5366_5405()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 5366, 5405);
                    return return_v;
                }


                int
                f_10436_5420_5452(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                newLocals)
                {
                    this_param.RewriteLocals(locals, newLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 5420, 5452);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_5474_5504(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 5474, 5504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 5192, 5516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 5192, 5516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCatchBlock(BoundCatchBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 5528, 6514);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5616, 6453) || true) && (f_10436_5620_5649_M(!node.Locals.IsDefaultOrEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 5616, 6453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5917, 5960);

                    var
                    newLocals = f_10436_5933_5959(this, f_10436_5947_5958(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 5980, 6438);

                    return f_10436_5987_6437(node, newLocals, f_10436_6070_6105(this, f_10436_6081_6104(node)), f_10436_6128_6165(this, f_10436_6143_6164(node)), f_10436_6208_6251(this, f_10436_6219_6250(node)), f_10436_6291_6326(this, f_10436_6302_6325(node)), f_10436_6361_6382(this, f_10436_6372_6381(node)), f_10436_6405_6436(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 5616, 6453);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 6469, 6503);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(node), 10436, 6476, 6502);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 5528, 6514);

                bool
                f_10436_5620_5649_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 5620, 5649);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_5947_5958(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 5947, 5958);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_5933_5959(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    var return_v = this_param.RewriteLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 5933, 5959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_6081_6104(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionSourceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 6081, 6104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_6070_6105(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 6070, 6105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10436_6143_6164(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 6143, 6164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_6128_6165(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 6128, 6165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                f_10436_6219_6250(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterPrologueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 6219, 6250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_6208_6251(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatementList?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 6208, 6251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_6302_6325(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.ExceptionFilterOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 6302, 6325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_6291_6326(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 6291, 6326);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10436_6372_6381(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 6372, 6381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_6361_6382(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 6361, 6382);
                    return return_v;
                }


                bool
                f_10436_6405_6436(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param)
                {
                    var return_v = this_param.IsSynthesizedAsyncCatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 6405, 6436);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                f_10436_5987_6437(Microsoft.CodeAnalysis.CSharp.BoundCatchBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundNode?
                exceptionSourceOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                exceptionTypeOpt, Microsoft.CodeAnalysis.CSharp.BoundNode?
                exceptionFilterPrologueOpt, Microsoft.CodeAnalysis.CSharp.BoundNode?
                exceptionFilterOpt, Microsoft.CodeAnalysis.CSharp.BoundNode?
                body, bool
                isSynthesizedAsyncCatchAll)
                {
                    var return_v = this_param.Update(locals, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)exceptionSourceOpt, exceptionTypeOpt, (Microsoft.CodeAnalysis.CSharp.BoundStatementList?)exceptionFilterPrologueOpt, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)exceptionFilterOpt, (Microsoft.CodeAnalysis.CSharp.BoundBlock?)body, isSynthesizedAsyncCatchAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 5987, 6437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 5528, 6514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 5528, 6514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitBlock(BoundBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 6526, 6855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 6604, 6647);

                var
                newLocals = f_10436_6620_6646(this, f_10436_6634_6645(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 6661, 6705);

                var
                newLocalFunctions = f_10436_6685_6704(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 6719, 6766);

                var
                newStatements = f_10436_6739_6765(this, f_10436_6749_6764(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 6780, 6844);

                return f_10436_6787_6843(node, newLocals, newLocalFunctions, newStatements);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 6526, 6855);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_6634_6645(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 6634, 6645);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_6620_6646(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    var return_v = this_param.RewriteLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 6620, 6646);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                f_10436_6685_6704(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.LocalFunctions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 6685, 6704);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10436_6749_6764(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 6749, 6764);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10436_6739_6765(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundStatement>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 6739, 6765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10436_6787_6843(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol>
                localFunctions, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                statements)
                {
                    var return_v = this_param.Update(locals, localFunctions, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 6787, 6843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 6526, 6855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 6526, 6855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract override BoundNode VisitScope(BoundScope node);

        public override BoundNode VisitSequence(BoundSequence node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 6942, 7362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7026, 7069);

                var
                newLocals = f_10436_7042_7068(this, f_10436_7056_7067(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7083, 7149);

                var
                newSideEffects = f_10436_7104_7148(this, f_10436_7131_7147(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7163, 7218);

                var
                newValue = (BoundExpression)f_10436_7195_7217(this, f_10436_7206_7216(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7232, 7272);

                var
                newType = f_10436_7246_7271(this, f_10436_7261_7270(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7286, 7351);

                return f_10436_7293_7350(node, newLocals, newSideEffects, newValue, newType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 6942, 7362);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_7056_7067(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7056, 7067);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_7042_7068(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    var return_v = this_param.RewriteLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7042, 7068);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10436_7131_7147(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.SideEffects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7131, 7147);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10436_7104_7148(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7104, 7148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_7206_7216(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7206, 7216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_7195_7217(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7195, 7217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_7261_7270(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7261, 7270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_7246_7271(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7246, 7271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10436_7293_7350(Microsoft.CodeAnalysis.CSharp.BoundSequence
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(locals, sideEffects, value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7293, 7350);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 6942, 7362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 6942, 7362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitForStatement(BoundForStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 7374, 8072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7466, 7519);

                var
                newOuterLocals = f_10436_7487_7518(this, f_10436_7501_7517(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7533, 7607);

                BoundStatement
                initializer = (BoundStatement)f_10436_7578_7606(this, f_10436_7589_7605(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7621, 7674);

                var
                newInnerLocals = f_10436_7642_7673(this, f_10436_7656_7672(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7688, 7760);

                BoundExpression
                condition = (BoundExpression)f_10436_7733_7759(this, f_10436_7744_7758(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7774, 7844);

                BoundStatement
                increment = (BoundStatement)f_10436_7817_7843(this, f_10436_7828_7842(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7858, 7918);

                BoundStatement
                body = (BoundStatement)f_10436_7896_7917(this, f_10436_7907_7916(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 7932, 8061);

                return f_10436_7939_8060(node, newOuterLocals, initializer, newInnerLocals, condition, increment, body, f_10436_8024_8039(node), f_10436_8041_8059(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 7374, 8072);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_7501_7517(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.OuterLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7501, 7517);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_7487_7518(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    var return_v = this_param.RewriteLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7487, 7518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10436_7589_7605(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7589, 7605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_7578_7606(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7578, 7606);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_7656_7672(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.InnerLocals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7656, 7672);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_7642_7673(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    var return_v = this_param.RewriteLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7642, 7673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_7744_7758(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7744, 7758);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_7733_7759(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7733, 7759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10436_7828_7842(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Increment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7828, 7842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_7817_7843(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7817, 7843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10436_7907_7916(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 7907, 7916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_7896_7917(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7896, 7917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10436_8024_8039(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8024, 8039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10436_8041_8059(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8041, 8059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundForStatement
                f_10436_7939_8060(Microsoft.CodeAnalysis.CSharp.BoundForStatement
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                outerLocals, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                initializer, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                innerLocals, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                increment, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                body, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    var return_v = this_param.Update(outerLocals, initializer, innerLocals, condition, increment, body, breakLabel, continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 7939, 8060);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 7374, 8072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 7374, 8072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDoStatement(BoundDoStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 8084, 8486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 8174, 8217);

                var
                newLocals = f_10436_8190_8216(this, f_10436_8204_8215(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 8231, 8303);

                BoundExpression
                condition = (BoundExpression)f_10436_8276_8302(this, f_10436_8287_8301(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 8317, 8377);

                BoundStatement
                body = (BoundStatement)f_10436_8355_8376(this, f_10436_8366_8375(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 8391, 8475);

                return f_10436_8398_8474(node, newLocals, condition, body, f_10436_8438_8453(node), f_10436_8455_8473(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 8084, 8486);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_8204_8215(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8204, 8215);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_8190_8216(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    var return_v = this_param.RewriteLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 8190, 8216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_8287_8301(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8287, 8301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_8276_8302(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 8276, 8302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10436_8366_8375(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8366, 8375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_8355_8376(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 8355, 8376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10436_8438_8453(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8438, 8453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10436_8455_8473(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8455, 8473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                f_10436_8398_8474(Microsoft.CodeAnalysis.CSharp.BoundDoStatement
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                body, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    var return_v = this_param.Update(locals, condition, body, breakLabel, continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 8398, 8474);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 8084, 8486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 8084, 8486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitWhileStatement(BoundWhileStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 8498, 8906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 8594, 8637);

                var
                newLocals = f_10436_8610_8636(this, f_10436_8624_8635(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 8651, 8723);

                BoundExpression
                condition = (BoundExpression)f_10436_8696_8722(this, f_10436_8707_8721(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 8737, 8797);

                BoundStatement
                body = (BoundStatement)f_10436_8775_8796(this, f_10436_8786_8795(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 8811, 8895);

                return f_10436_8818_8894(node, newLocals, condition, body, f_10436_8858_8873(node), f_10436_8875_8893(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 8498, 8906);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_8624_8635(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8624, 8635);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_8610_8636(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    var return_v = this_param.RewriteLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 8610, 8636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_8707_8721(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8707, 8721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_8696_8722(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 8696, 8722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10436_8786_8795(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8786, 8795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_8775_8796(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 8775, 8796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10436_8858_8873(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.BreakLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8858, 8873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10436_8875_8893(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param)
                {
                    var return_v = this_param.ContinueLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 8875, 8893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                f_10436_8818_8894(Microsoft.CodeAnalysis.CSharp.BoundWhileStatement
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                condition, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                body, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                breakLabel, Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                continueLabel)
                {
                    var return_v = this_param.Update(locals, condition, body, breakLabel, continueLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 8818, 8894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 8498, 8906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 8498, 8906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitUsingStatement(BoundUsingStatement node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 8918, 9605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 9014, 9057);

                var
                newLocals = f_10436_9030_9056(this, f_10436_9044_9055(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 9071, 9185);

                BoundMultipleLocalDeclarations
                declarationsOpt = (BoundMultipleLocalDeclarations)f_10436_9152_9184(this, f_10436_9163_9183(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 9199, 9279);

                BoundExpression
                expressionOpt = (BoundExpression)f_10436_9248_9278(this, f_10436_9259_9277(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 9293, 9353);

                BoundStatement
                body = (BoundStatement)f_10436_9331_9352(this, f_10436_9342_9351(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 9367, 9447);

                Conversion
                disposableConversion = f_10436_9401_9446(this, f_10436_9419_9445(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 9461, 9594);

                return f_10436_9468_9593(node, newLocals, declarationsOpt, expressionOpt, disposableConversion, body, f_10436_9551_9564(node), f_10436_9566_9592(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 8918, 9605);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_9044_9055(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.Locals;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 9044, 9055);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_9030_9056(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals)
                {
                    var return_v = this_param.RewriteLocals(locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 9030, 9056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations?
                f_10436_9163_9183(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.DeclarationsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 9163, 9183);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_9152_9184(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 9152, 9184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_9259_9277(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 9259, 9277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_9248_9278(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 9248, 9278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10436_9342_9351(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 9342, 9351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_9331_9352(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 9331, 9352);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10436_9419_9445(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.IDisposableConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 9419, 9445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10436_9401_9446(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = this_param.RewriteConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 9401, 9446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                f_10436_9551_9564(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.AwaitOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 9551, 9564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                f_10436_9566_9592(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param)
                {
                    var return_v = this_param.PatternDisposeInfoOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 9566, 9592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                f_10436_9468_9593(Microsoft.CodeAnalysis.CSharp.BoundUsingStatement
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations?
                declarationsOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expressionOpt, Microsoft.CodeAnalysis.CSharp.Conversion
                iDisposableConversion, Microsoft.CodeAnalysis.CSharp.BoundStatement?
                body, Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo?
                awaitOpt, Microsoft.CodeAnalysis.CSharp.MethodArgumentInfo?
                patternDisposeInfoOpt)
                {
                    var return_v = this_param.Update(locals, declarationsOpt, expressionOpt, iDisposableConversion, body, awaitOpt, patternDisposeInfoOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 9468, 9593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 8918, 9605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 8918, 9605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion RewriteConversion(Conversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 9617, 10207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 9701, 10196);

                switch (conversion.Kind)
                {

                    case ConversionKind.ExplicitUserDefined:
                    case ConversionKind.ImplicitUserDefined:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 9701, 10196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 9878, 9985);

                        return f_10436_9885_9984(conversion.Kind, f_10436_9917_9953(this, conversion.Method), conversion.IsExtensionMethod);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 9701, 10196);

                    case ConversionKind.MethodGroup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 9701, 10196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 10057, 10115);

                        throw f_10436_10063_10114(conversion.Kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 9701, 10196);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 9701, 10196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 10163, 10181);

                        return conversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 9701, 10196);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 9617, 10207);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_9917_9953(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 9917, 9953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10436_9885_9984(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                conversionMethod, bool
                isExtensionMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, conversionMethod, isExtensionMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 9885, 9984);
                    return return_v;
                }


                System.Exception
                f_10436_10063_10114(Microsoft.CodeAnalysis.CSharp.ConversionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 10063, 10114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 9617, 10207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 9617, 10207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override TypeSymbol VisitType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 10219, 10356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 10304, 10345);

                return f_10436_10311_10339(f_10436_10311_10318(), type).Type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 10219, 10356);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10436_10311_10318()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 10311, 10318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10436_10311_10339(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 10311, 10339);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 10219, 10356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 10219, 10356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitMethodInfo(BoundMethodInfo node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 10368, 10709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 10456, 10509);

                var
                rewrittenMethod = f_10436_10478_10508(this, f_10436_10496_10507(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 10625, 10698);

                return f_10436_10632_10697(node, rewrittenMethod, f_10436_10661_10685(node), f_10436_10687_10696(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 10368, 10709);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_10496_10507(Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 10496, 10507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_10478_10508(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 10478, 10508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10436_10661_10685(Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                this_param)
                {
                    var return_v = this_param.GetMethodFromHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 10661, 10685);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_10687_10696(Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 10687, 10696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                f_10436_10632_10697(Microsoft.CodeAnalysis.CSharp.BoundMethodInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                getMethodFromHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(method, getMethodFromHandle, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 10632, 10697);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 10368, 10709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 10368, 10709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPropertyAccess(BoundPropertyAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 10721, 11094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 10817, 10888);

                var
                rewrittenPropertySymbol = f_10436_10847_10887(this, f_10436_10867_10886(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 10902, 10967);

                var
                rewrittenReceiver = (BoundExpression)f_10436_10943_10966(this, f_10436_10949_10965(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 10981, 11083);

                return f_10436_10988_11082(node, rewrittenReceiver, rewrittenPropertySymbol, f_10436_11044_11059(node), f_10436_11061_11081(this, f_10436_11071_11080(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 10721, 11094);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10436_10867_10886(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 10867, 10886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10436_10847_10887(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = this_param.VisitPropertySymbol(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 10847, 10887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_10949_10965(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 10949, 10965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_10943_10966(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 10943, 10966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10436_11044_11059(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 11044, 11059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_11071_11080(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 11071, 11080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_11061_11081(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11061, 11081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                f_10436_10988_11082(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                propertySymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiverOpt, propertySymbol, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 10988, 11082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 10721, 11094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 10721, 11094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitCall(BoundCall node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 11106, 12522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 11182, 11241);

                var
                rewrittenMethodSymbol = f_10436_11210_11240(this, f_10436_11228_11239(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 11255, 11325);

                var
                rewrittenReceiver = (BoundExpression)f_10436_11296_11324(this, f_10436_11307_11323(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 11339, 11428);

                var
                rewrittenArguments = (ImmutableArray<BoundExpression>)f_10436_11397_11427(this, f_10436_11412_11426(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 11442, 11488);

                var
                rewrittenType = f_10436_11462_11487(this, f_10436_11477_11486(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 11504, 11595);

                f_10436_11504_11594(f_10436_11517_11558(rewrittenMethodSymbol) == f_10436_11562_11593(f_10436_11562_11573(node)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 11758, 12016) || true) && (f_10436_11762_11834(f_10436_11798_11814(node), rewrittenReceiver) && (DynAbs.Tracing.TraceSender.Expression_True(10436, 11762, 11869) && f_10436_11838_11869(f_10436_11838_11849(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 11758, 12016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 11903, 12001);

                    rewrittenMethodSymbol = f_10436_11927_12000(this, rewrittenMethodSymbol, node.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 11758, 12016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 12032, 12511);

                return f_10436_12039_12510(node, rewrittenReceiver, rewrittenMethodSymbol, rewrittenArguments, f_10436_12182_12203(node), f_10436_12222_12246(node), f_10436_12265_12284(node), f_10436_12303_12316(node), f_10436_12335_12364(node), f_10436_12383_12403(node), f_10436_12422_12443(node), f_10436_12462_12477(node), rewrittenType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 11106, 12522);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_11228_11239(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 11228, 11239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_11210_11240(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11210, 11240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_11307_11323(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 11307, 11323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_11296_11324(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11296, 11324);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10436_11412_11426(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 11412, 11426);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10436_11397_11427(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11397, 11427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_11477_11486(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 11477, 11486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_11462_11487(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11462, 11487);
                    return return_v;
                }


                bool
                f_10436_11517_11558(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11517, 11558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_11562_11573(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 11562, 11573);
                    return return_v;
                }


                bool
                f_10436_11562_11593(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11562, 11593);
                    return return_v;
                }


                int
                f_10436_11504_11594(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11504, 11594);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_11798_11814(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 11798, 11814);
                    return return_v;
                }


                bool
                f_10436_11762_11834(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                originalReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                rewrittenReceiver)
                {
                    var return_v = BaseReferenceInReceiverWasRewritten(originalReceiver, rewrittenReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11762, 11834);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_11838_11849(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 11838, 11849);
                    return return_v;
                }


                bool
                f_10436_11838_11869(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11838, 11869);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_11927_12000(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodBeingCalled, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.GetMethodWrapperForBaseNonVirtualCall(methodBeingCalled, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 11927, 12000);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10436_12182_12203(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12182, 12203);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10436_12222_12246(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12222, 12246);
                    return return_v;
                }


                bool
                f_10436_12265_12284(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.IsDelegateCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12265, 12284);
                    return return_v;
                }


                bool
                f_10436_12303_12316(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12303, 12316);
                    return return_v;
                }


                bool
                f_10436_12335_12364(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.InvokedAsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12335, 12364);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10436_12383_12403(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12383, 12403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10436_12422_12443(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12422, 12443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10436_12462_12477(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12462, 12477);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10436_12039_12510(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                isDelegateCall, bool
                expanded, bool
                invokedAsExtensionMethod, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiverOpt, method, arguments, argumentNamesOpt, argumentRefKindsOpt, isDelegateCall, expanded, invokedAsExtensionMethod, argsToParamsOpt, defaultArguments, resultKind, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 12039, 12510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 11106, 12522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 11106, 12522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol GetMethodWrapperForBaseNonVirtualCall(MethodSymbol methodBeingCalled, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 12534, 13534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 12668, 12742);

                var
                newMethod = f_10436_12684_12741(this, methodBeingCalled, syntax)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 12756, 12852) || true) && (f_10436_12760_12786_M(!newMethod.IsGenericMethod))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 12756, 12852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 12820, 12837);

                    return newMethod;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 12756, 12852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 12959, 13007);

                f_10436_12959_13006(f_10436_12972_13005(methodBeingCalled));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13021, 13083);

                var
                typeArgs = f_10436_13036_13082(methodBeingCalled)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13097, 13146);

                f_10436_13097_13145(typeArgs.Length == f_10436_13129_13144(newMethod));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13162, 13247);

                var
                visitedTypeArgs = f_10436_13184_13246(typeArgs.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13261, 13442);
                    foreach (var typeArg in f_10436_13285_13293_I(typeArgs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 13261, 13442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13327, 13427);

                        f_10436_13327_13426(visitedTypeArgs, typeArg.WithTypeAndModifiers(f_10436_13376_13399(this, typeArg.Type), typeArg.CustomModifiers));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 13261, 13442);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10436, 1, 182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10436, 1, 182);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13458, 13523);

                return f_10436_13465_13522(newMethod, f_10436_13485_13521(visitedTypeArgs));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 12534, 13534);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_12684_12741(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodBeingWrapped, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.GetOrCreateBaseFunctionWrapper(methodBeingWrapped, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 12684, 12741);
                    return return_v;
                }


                bool
                f_10436_12760_12786_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12760, 12786);
                    return return_v;
                }


                bool
                f_10436_12972_13005(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 12972, 13005);
                    return return_v;
                }


                int
                f_10436_12959_13006(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 12959, 13006);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10436_13036_13082(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 13036, 13082);
                    return return_v;
                }


                int
                f_10436_13129_13144(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 13129, 13144);
                    return return_v;
                }


                int
                f_10436_13097_13145(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 13097, 13145);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10436_13184_13246(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 13184, 13246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_13376_13399(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 13376, 13399);
                    return return_v;
                }


                int
                f_10436_13327_13426(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 13327, 13426);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10436_13285_13293_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 13285, 13293);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10436_13485_13521(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 13485, 13521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_13465_13522(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 13465, 13522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 12534, 13534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 12534, 13534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol GetOrCreateBaseFunctionWrapper(MethodSymbol methodBeingWrapped, SyntaxNode syntax)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 13546, 14695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13674, 13730);

                methodBeingWrapped = f_10436_13695_13729(methodBeingWrapped);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13746, 13828);

                MethodSymbol
                wrapper = f_10436_13769_13827(this.CompilationState, methodBeingWrapped)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13842, 13933) || true) && ((object)wrapper != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 13842, 13933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13903, 13918);

                    return wrapper;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 13842, 13933);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 13949, 13990);

                var
                containingType = f_10436_13970_13989(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14046, 14153);

                string
                methodName = f_10436_14066_14152(f_10436_14107_14151(this.CompilationState))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14167, 14261);

                wrapper = f_10436_14177_14260(containingType, methodBeingWrapped, syntax, methodName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14319, 14507) || true) && (f_10436_14323_14353(this.CompilationState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 14319, 14507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14387, 14492);

                    f_10436_14387_14491(this.CompilationState.ModuleBuilderOpt, containingType, f_10436_14467_14490(wrapper));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 14319, 14507);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14523, 14573);

                f_10436_14523_14572(f_10436_14536_14571(wrapper));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14587, 14655);

                f_10436_14587_14654(wrapper, this.CompilationState, this.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14669, 14684);

                return wrapper;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 13546, 14695);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_13695_13729(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 13695, 13729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10436_13769_13827(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.GetMethodWrapper(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 13769, 13827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_13970_13989(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 13970, 13989);
                    return return_v;
                }


                int
                f_10436_14107_14151(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.NextWrapperMethodIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 14107, 14151);
                    return return_v;
                }


                string
                f_10436_14066_14152(int
                uniqueId)
                {
                    var return_v = GeneratedNames.MakeBaseMethodWrapperName(uniqueId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 14066, 14152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
                f_10436_14177_14260(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodBeingWrapped, Microsoft.CodeAnalysis.SyntaxNode
                syntax, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol(containingType, methodBeingWrapped, syntax, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 14177, 14260);
                    return return_v;
                }


                bool
                f_10436_14323_14353(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param)
                {
                    var return_v = this_param.Emitting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 14323, 14353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10436_14467_14490(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 14467, 14490);
                    return return_v;
                }


                int
                f_10436_14387_14491(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                method)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.IMethodDefinition)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 14387, 14491);
                    return 0;
                }


                bool
                f_10436_14536_14571(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.SynthesizesLoweredBoundBody;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 14536, 14571);
                    return return_v;
                }


                int
                f_10436_14523_14572(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 14523, 14572);
                    return 0;
                }


                int
                f_10436_14587_14654(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.GenerateMethodBody(compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 14587, 14654);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 13546, 14695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 13546, 14695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryReplaceWithProxy(Symbol parameterOrLocal, SyntaxNode syntax, out BoundNode replacement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 14707, 15171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14835, 14867);

                CapturedSymbolReplacement
                proxy
                = default(CapturedSymbolReplacement);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14881, 15098) || true) && (f_10436_14885_14933(proxies, parameterOrLocal, out proxy))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 14881, 15098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 14967, 15053);

                    replacement = f_10436_14981_15052(proxy, syntax, frameType => FramePointer(syntax, frameType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15071, 15083);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 14881, 15098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15114, 15133);

                replacement = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15147, 15160);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 14707, 15171);

                bool
                f_10436_14885_14933(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, out Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 14885, 14933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_14981_15052(Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                makeFrame)
                {
                    var return_v = this_param.Replacement(node, makeFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 14981, 15052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 14707, 15171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 14707, 15171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override BoundNode VisitParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 15183, 15606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15276, 15298);

                BoundNode
                replacement
                = default(BoundNode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15312, 15455) || true) && (f_10436_15316_15387(this, f_10436_15336_15356(node), node.Syntax, out replacement))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 15312, 15455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15421, 15440);

                    return replacement;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 15312, 15455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15558, 15595);

                return f_10436_15565_15594(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 15183, 15606);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10436_15336_15356(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 15336, 15356);
                    return return_v;
                }


                bool
                f_10436_15316_15387(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameterOrLocal, Microsoft.CodeAnalysis.SyntaxNode
                syntax, out Microsoft.CodeAnalysis.CSharp.BoundNode
                replacement)
                {
                    var return_v = this_param.TryReplaceWithProxy((Microsoft.CodeAnalysis.CSharp.Symbol)parameterOrLocal, syntax, out replacement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 15316, 15387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10436_15565_15594(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                node)
                {
                    var return_v = this_param.VisitUnhoistedParameter(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 15565, 15594);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 15183, 15606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 15183, 15606);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual BoundNode VisitUnhoistedParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 15618, 15759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15715, 15748);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitParameter(node), 10436, 15722, 15747);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 15618, 15759);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 15618, 15759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 15618, 15759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override BoundNode VisitLocal(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 15771, 16247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15856, 15878);

                BoundNode
                replacement
                = default(BoundNode);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15892, 16031) || true) && (f_10436_15896_15963(this, f_10436_15916_15932(node), node.Syntax, out replacement))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 15892, 16031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 15997, 16016);

                    return replacement;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 15892, 16031);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16143, 16187);

                f_10436_16143_16186(!f_10436_16157_16185(this, f_10436_16168_16184(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16203, 16236);

                return f_10436_16210_16235(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 15771, 16247);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_15916_15932(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 15916, 15932);
                    return return_v;
                }


                bool
                f_10436_15896_15963(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                parameterOrLocal, Microsoft.CodeAnalysis.SyntaxNode
                syntax, out Microsoft.CodeAnalysis.CSharp.BoundNode
                replacement)
                {
                    var return_v = this_param.TryReplaceWithProxy((Microsoft.CodeAnalysis.CSharp.Symbol)parameterOrLocal, syntax, out replacement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 15896, 15963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_16168_16184(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 16168, 16184);
                    return return_v;
                }


                bool
                f_10436_16157_16185(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localOrParameter)
                {
                    var return_v = this_param.NeedsProxy((Microsoft.CodeAnalysis.CSharp.Symbol)localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 16157, 16185);
                    return return_v;
                }


                int
                f_10436_16143_16186(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 16143, 16186);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode
                f_10436_16210_16235(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                node)
                {
                    var return_v = this_param.VisitUnhoistedLocal(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 16210, 16235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 15771, 16247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 15771, 16247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundNode VisitUnhoistedLocal(BoundLocal node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 16259, 16670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16338, 16367);

                LocalSymbol
                replacementLocal
                = default(LocalSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16381, 16614) || true) && (f_10436_16385_16450(this.localMap, f_10436_16411_16427(node), out replacementLocal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 16381, 16614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16484, 16599);

                    return f_10436_16491_16598(node.Syntax, replacementLocal, f_10436_16537_16558(node), f_10436_16560_16581(replacementLocal), f_10436_16583_16597(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 16381, 16614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16630, 16659);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLocal(node), 10436, 16637, 16658);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 16259, 16670);

                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_16411_16427(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 16411, 16427);
                    return return_v;
                }


                bool
                f_10436_16385_16450(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 16385, 16450);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10436_16537_16558(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 16537, 16558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_16560_16581(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 16560, 16581);
                    return return_v;
                }


                bool
                f_10436_16583_16597(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 16583, 16597);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10436_16491_16598(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal(syntax, localSymbol, constantValueOpt, type, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 16491, 16598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 16259, 16670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 16259, 16670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAwaitableInfo(BoundAwaitableInfo node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 16682, 17556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16776, 16837);

                var
                awaitablePlaceholder = f_10436_16803_16836(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16851, 16944) || true) && (awaitablePlaceholder is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 16851, 16944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16917, 16929);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 16851, 16944);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 16960, 17085);

                var
                rewrittenPlaceholder = f_10436_16987_17084(awaitablePlaceholder, f_10436_17015_17045(awaitablePlaceholder), f_10436_17047_17083(this, f_10436_17057_17082(awaitablePlaceholder)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17099, 17163);

                f_10436_17099_17162(_placeholderMap, awaitablePlaceholder, rewrittenPlaceholder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17179, 17241);

                var
                getAwaiter = (BoundExpression)f_10436_17213_17240(this, f_10436_17224_17239(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17255, 17311);

                var
                isCompleted = f_10436_17273_17310(this, f_10436_17293_17309(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17325, 17375);

                var
                getResult = f_10436_17341_17374(this, f_10436_17359_17373(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17391, 17436);

                f_10436_17391_17435(
                            _placeholderMap, awaitablePlaceholder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17452, 17545);

                return f_10436_17459_17544(node, rewrittenPlaceholder, f_10436_17493_17507(node), getAwaiter, isCompleted, getResult);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 16682, 17556);

                Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder?
                f_10436_16803_16836(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.AwaitableInstancePlaceholder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 16803, 16836);
                    return return_v;
                }


                uint
                f_10436_17015_17045(Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                this_param)
                {
                    var return_v = this_param.ValEscape;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 17015, 17045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10436_17057_17082(Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 17057, 17082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_17047_17083(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 17047, 17083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                f_10436_16987_17084(Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                this_param, uint
                valEscape, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(valEscape, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 16987, 17084);
                    return return_v;
                }


                int
                f_10436_17099_17162(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                key, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)key, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 17099, 17162);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_17224_17239(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.GetAwaiter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 17224, 17239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_17213_17240(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 17213, 17240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                f_10436_17293_17309(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.IsCompleted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 17293, 17309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10436_17273_17310(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol?
                property)
                {
                    var return_v = this_param.VisitPropertySymbol(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 17273, 17310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10436_17359_17373(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.GetResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 17359, 17373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_17341_17374(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 17341, 17374);
                    return return_v;
                }


                bool
                f_10436_17391_17435(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                key)
                {
                    var return_v = this_param.Remove((Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 17391, 17435);
                    return return_v;
                }


                bool
                f_10436_17493_17507(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param)
                {
                    var return_v = this_param.IsDynamic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 17493, 17507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                f_10436_17459_17544(Microsoft.CodeAnalysis.CSharp.BoundAwaitableInfo
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAwaitableValuePlaceholder
                awaitableInstancePlaceholder, bool
                isDynamic, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                getAwaiter, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                isCompleted, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                getResult)
                {
                    var return_v = this_param.Update(awaitableInstancePlaceholder, isDynamic, getAwaiter, isCompleted, getResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 17459, 17544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 16682, 17556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 16682, 17556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAwaitableValuePlaceholder(BoundAwaitableValuePlaceholder node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 17568, 17726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17686, 17715);

                return f_10436_17693_17714(_placeholderMap, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 17568, 17726);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_17693_17714(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 17693, 17714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 17568, 17726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 17568, 17726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitAssignmentOperator(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 17738, 21009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17842, 17883);

                BoundExpression
                originalLeft = f_10436_17873_17882(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17899, 18030) || true) && (f_10436_17903_17920(originalLeft) != BoundKind.Local)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 17899, 18030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 17973, 18015);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitAssignmentOperator(node), 10436, 17980, 18014);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 17899, 18030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18046, 18087);

                var
                leftLocal = (BoundLocal)originalLeft
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18103, 18146);

                BoundExpression
                originalRight = f_10436_18135_18145(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18162, 18600) || true) && (f_10436_18166_18195(f_10436_18166_18187(leftLocal)) != RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10436, 18166, 18242) && f_10436_18232_18242(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10436, 18166, 18296) && f_10436_18263_18296(this, f_10436_18274_18295(leftLocal))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 18162, 18600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18330, 18388);

                    f_10436_18330_18387(!f_10436_18344_18386(proxies, f_10436_18364_18385(leftLocal)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18406, 18482);

                    f_10436_18406_18481(f_10436_18419_18437(originalRight) != BoundKind.ConvertedStackAllocExpression);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18548, 18585);

                    throw f_10436_18554_18584();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 18162, 18600);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18616, 18929) || true) && (f_10436_18620_18653(this, f_10436_18631_18652(leftLocal)) && (DynAbs.Tracing.TraceSender.Expression_True(10436, 18620, 18700) && !f_10436_18658_18700(proxies, f_10436_18678_18699(leftLocal))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 18616, 18929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18734, 18815);

                    f_10436_18734_18814(f_10436_18747_18784(f_10436_18747_18768(leftLocal)) == LocalDeclarationKind.None);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18877, 18914);

                    throw f_10436_18883_18913();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 18616, 18929);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 18945, 19016);

                BoundExpression
                rewrittenLeft = (BoundExpression)f_10436_18994_19015(this, leftLocal)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 19030, 19106);

                BoundExpression
                rewrittenRight = (BoundExpression)f_10436_19080_19105(this, originalRight)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 19120, 19168);

                TypeSymbol
                rewrittenType = f_10436_19147_19167(this, f_10436_19157_19166(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 19661, 20905) || true) && (f_10436_19665_19683(rewrittenLeft) != BoundKind.Local && (DynAbs.Tracing.TraceSender.Expression_True(10436, 19665, 19767) && f_10436_19706_19724(originalRight) == BoundKind.ConvertedStackAllocExpression))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 19661, 20905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 20097, 20246);

                    SyntheticBoundNodeFactory
                    factory = f_10436_20133_20245(f_10436_20163_20181(this), rewrittenLeft.Syntax, this.CompilationState, this.Diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 20264, 20303);

                    BoundAssignmentOperator
                    tempAssignment
                    = default(BoundAssignmentOperator);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 20321, 20400);

                    BoundLocal
                    tempLocal = f_10436_20344_20399(factory, rewrittenRight, out tempAssignment)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 20420, 20446);

                    f_10436_20420_20445(f_10436_20433_20444_M(!node.IsRef));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 20464, 20575);

                    BoundAssignmentOperator
                    rewrittenAssignment = f_10436_20510_20574(node, rewrittenLeft, tempLocal, f_10436_20548_20558(node), rewrittenType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 20595, 20890);

                    return f_10436_20602_20889(node.Syntax, f_10436_20676_20733(f_10436_20711_20732(tempLocal)), f_10436_20756_20810(tempAssignment), rewrittenAssignment, rewrittenType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 19661, 20905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 20921, 20998);

                return f_10436_20928_20997(node, rewrittenLeft, rewrittenRight, f_10436_20971_20981(node), rewrittenType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 17738, 21009);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_17873_17882(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 17873, 17882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10436_17903_17920(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 17903, 17920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_18135_18145(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18135, 18145);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_18166_18187(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18166, 18187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10436_18166_18195(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18166, 18195);
                    return return_v;
                }


                bool
                f_10436_18232_18242(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18232, 18242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_18274_18295(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18274, 18295);
                    return return_v;
                }


                bool
                f_10436_18263_18296(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localOrParameter)
                {
                    var return_v = this_param.NeedsProxy((Microsoft.CodeAnalysis.CSharp.Symbol)localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 18263, 18296);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_18364_18385(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18364, 18385);
                    return return_v;
                }


                bool
                f_10436_18344_18386(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key)
                {
                    var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.Symbol)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 18344, 18386);
                    return return_v;
                }


                int
                f_10436_18330_18387(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 18330, 18387);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10436_18419_18437(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18419, 18437);
                    return return_v;
                }


                int
                f_10436_18406_18481(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 18406, 18481);
                    return 0;
                }


                System.Exception
                f_10436_18554_18584()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18554, 18584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_18631_18652(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18631, 18652);
                    return return_v;
                }


                bool
                f_10436_18620_18653(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                localOrParameter)
                {
                    var return_v = this_param.NeedsProxy((Microsoft.CodeAnalysis.CSharp.Symbol)localOrParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 18620, 18653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_18678_18699(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18678, 18699);
                    return return_v;
                }


                bool
                f_10436_18658_18700(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                key)
                {
                    var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.Symbol)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 18658, 18700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_18747_18768(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18747, 18768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalDeclarationKind
                f_10436_18747_18784(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.DeclarationKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18747, 18784);
                    return return_v;
                }


                int
                f_10436_18734_18814(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 18734, 18814);
                    return 0;
                }


                System.Exception
                f_10436_18883_18913()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 18883, 18913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_18994_19015(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 18994, 19015);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_19080_19105(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 19080, 19105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_19157_19166(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 19157, 19166);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_19147_19167(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 19147, 19167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10436_19665_19683(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 19665, 19683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10436_19706_19724(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 19706, 19724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_20163_20181(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param)
                {
                    var return_v = this_param.CurrentMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 20163, 20181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10436_20133_20245(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                topLevelMethod, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethod, node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 20133, 20245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10436_20344_20399(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                argument, out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                store)
                {
                    var return_v = this_param.StoreToTemp(argument, out store);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 20344, 20399);
                    return return_v;
                }


                bool
                f_10436_20433_20444_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 20433, 20444);
                    return return_v;
                }


                int
                f_10436_20420_20445(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 20420, 20445);
                    return 0;
                }


                bool
                f_10436_20548_20558(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 20548, 20558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10436_20510_20574(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundLocal
                right, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right, isRef, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 20510, 20574);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10436_20711_20732(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 20711, 20732);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10436_20676_20733(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<LocalSymbol>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 20676, 20733);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10436_20756_20810(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 20756, 20810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundSequence
                f_10436_20602_20889(Microsoft.CodeAnalysis.SyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundSequence(syntax, locals, sideEffects, (Microsoft.CodeAnalysis.CSharp.BoundExpression)value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 20602, 20889);
                    return return_v;
                }


                bool
                f_10436_20971_20981(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.IsRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 20971, 20981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10436_20928_20997(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                right, bool
                isRef, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(left, right, isRef, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 20928, 20997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 17738, 21009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 17738, 21009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFieldInfo(BoundFieldInfo node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 21021, 21356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 21107, 21260);

                var
                rewrittenField = f_10436_21128_21259(((FieldSymbol)f_10436_21142_21171(f_10436_21142_21152(node)))
                , f_10436_21217_21258(this, f_10436_21232_21257(f_10436_21232_21242(node))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 21274, 21345);

                return f_10436_21281_21344(node, rewrittenField, f_10436_21309_21332(node), f_10436_21334_21343(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 21021, 21356);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_21142_21152(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21142, 21152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_21142_21171(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21142, 21171);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_21232_21242(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param)
                {
                    var return_v = this_param.Field;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21232, 21242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_21232_21257(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21232, 21257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_21217_21258(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.VisitType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 21217, 21258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_21128_21259(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 21128, 21259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10436_21309_21332(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param)
                {
                    var return_v = this_param.GetFieldFromHandle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21309, 21332);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_21334_21343(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21334, 21343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                f_10436_21281_21344(Microsoft.CodeAnalysis.CSharp.BoundFieldInfo
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                getFieldFromHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(field, getFieldFromHandle, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 21281, 21344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 21021, 21356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 21021, 21356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFieldAccess(BoundFieldAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 21368, 21884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 21458, 21534);

                BoundExpression
                receiverOpt = (BoundExpression)f_10436_21505_21533(this, f_10436_21516_21532(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 21548, 21592);

                TypeSymbol
                type = f_10436_21566_21591(this, f_10436_21581_21590(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 21606, 21768);

                var
                fieldSymbol = f_10436_21624_21767(((FieldSymbol)f_10436_21638_21673(f_10436_21638_21654(node)))
                , f_10436_21719_21766(this, f_10436_21734_21765(f_10436_21734_21750(node))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 21782, 21873);

                return f_10436_21789_21872(node, receiverOpt, fieldSymbol, f_10436_21827_21848(node), f_10436_21850_21865(node), type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 21368, 21884);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_21516_21532(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21516, 21532);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_21505_21533(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 21505, 21533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_21581_21590(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21581, 21590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_21566_21591(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 21566, 21591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_21638_21654(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21638, 21654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_21638_21673(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21638, 21673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_21734_21750(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21734, 21750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_21734_21765(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21734, 21765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_21719_21766(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.VisitType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 21719, 21766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_21624_21767(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 21624, 21767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10436_21827_21848(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21827, 21848);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10436_21850_21865(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 21850, 21865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10436_21789_21872(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol)
                {
                    var return_v = this_param.Update(receiver, fieldSymbol, constantValueOpt, resultKind, typeSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 21789, 21872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 21368, 21884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 21368, 21884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectCreationExpression(BoundObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 21896, 22884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 22012, 22100);

                var
                rewritten = (BoundObjectCreationExpression)DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitObjectCreationExpression(node), 10436, 22059, 22099)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 22114, 22840) || true) && (!f_10436_22119_22200(f_10436_22137_22151(rewritten), f_10436_22153_22162(node), TypeCompareKind.ConsiderEverything2) && (DynAbs.Tracing.TraceSender.Expression_True(10436, 22118, 22236) && (object)f_10436_22212_22228(node) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 22114, 22840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 22270, 22326);

                    MethodSymbol
                    ctor = f_10436_22290_22325(this, f_10436_22308_22324(node))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 22344, 22825);

                    rewritten = f_10436_22356_22824(rewritten, ctor, f_10436_22422_22441(rewritten), f_10436_22464_22490(rewritten), f_10436_22513_22542(rewritten), f_10436_22565_22583(rewritten), f_10436_22606_22631(rewritten), f_10436_22654_22680(rewritten), f_10436_22703_22729(rewritten), f_10436_22752_22786(rewritten), f_10436_22809_22823(rewritten));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 22114, 22840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 22856, 22873);

                return rewritten;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 21896, 22884);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_22137_22151(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression?
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22137, 22151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_22153_22162(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22153, 22162);
                    return return_v;
                }


                bool
                f_10436_22119_22200(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 22119, 22200);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_22212_22228(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22212, 22228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_22308_22324(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22308, 22324);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_22290_22325(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 22290, 22325);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10436_22422_22441(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22422, 22441);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10436_22464_22490(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22464, 22490);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10436_22513_22542(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22513, 22542);
                    return return_v;
                }


                bool
                f_10436_22565_22583(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22565, 22583);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10436_22606_22631(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22606, 22631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10436_22654_22680(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22654, 22680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10436_22703_22729(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22703, 22729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10436_22752_22786(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22752, 22786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_22809_22823(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 22809, 22823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                f_10436_22356_22824(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                initializerExpressionOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(constructor, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, constantValueOpt, initializerExpressionOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 22356, 22824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 21896, 22884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 21896, 22884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitDelegateCreationExpression(BoundDelegateCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 22896, 23862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 23016, 23065);

                BoundExpression
                originalArgument = f_10436_23051_23064(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 23079, 23161);

                BoundExpression
                rewrittenArgument = (BoundExpression)f_10436_23132_23160(this, originalArgument)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 23175, 23212);

                MethodSymbol
                method = f_10436_23197_23211(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 23419, 23654) || true) && (f_10436_23423_23495(originalArgument, rewrittenArgument) && (DynAbs.Tracing.TraceSender.Expression_True(10436, 23423, 23525) && f_10436_23499_23525(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 23419, 23654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 23559, 23639);

                    method = f_10436_23568_23638(this, method, originalArgument.Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 23419, 23654);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 23668, 23703);

                method = f_10436_23677_23702(this, method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 23717, 23761);

                TypeSymbol
                type = f_10436_23735_23760(this, f_10436_23750_23759(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 23775, 23851);

                return f_10436_23782_23850(node, rewrittenArgument, method, f_10436_23821_23843(node), type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 22896, 23862);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_23051_23064(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 23051, 23064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_23132_23160(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 23132, 23160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10436_23197_23211(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 23197, 23211);
                    return return_v;
                }


                bool
                f_10436_23423_23495(Microsoft.CodeAnalysis.CSharp.BoundExpression
                originalReceiver, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                rewrittenReceiver)
                {
                    var return_v = BaseReferenceInReceiverWasRewritten(originalReceiver, rewrittenReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 23423, 23495);
                    return return_v;
                }


                bool
                f_10436_23499_23525(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.IsMetadataVirtual();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 23499, 23525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_23568_23638(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodBeingCalled, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = this_param.GetMethodWrapperForBaseNonVirtualCall(methodBeingCalled, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 23568, 23638);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_23677_23702(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 23677, 23702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_23750_23759(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 23750, 23759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_23735_23760(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 23735, 23760);
                    return return_v;
                }


                bool
                f_10436_23821_23843(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 23821, 23843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                f_10436_23782_23850(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                argument, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt, bool
                isExtensionMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(argument, methodOpt, isExtensionMethod, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 23782, 23850);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 22896, 23862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 22896, 23862);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitFunctionPointerLoad(BoundFunctionPointerLoad node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 23874, 24070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 23980, 24059);

                return f_10436_23987_24058(node, f_10436_23999_24035(this, f_10436_24017_24034(node)), f_10436_24037_24057(this, f_10436_24047_24056(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 23874, 24070);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_24017_24034(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param)
                {
                    var return_v = this_param.TargetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24017, 24034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_23999_24035(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 23999, 24035);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_24047_24056(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24047, 24056);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_24037_24057(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 24037, 24057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                f_10436_23987_24058(Microsoft.CodeAnalysis.CSharp.BoundFunctionPointerLoad
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                targetMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(targetMethod, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 23987, 24058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 23874, 24070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 23874, 24070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitLoweredConditionalAccess(BoundLoweredConditionalAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 24082, 24644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 24198, 24268);

                BoundExpression
                receiver = (BoundExpression)f_10436_24242_24267(this, f_10436_24253_24266(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 24282, 24358);

                BoundExpression
                whenNotNull = (BoundExpression)f_10436_24329_24357(this, f_10436_24340_24356(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 24372, 24448);

                BoundExpression
                whenNullOpt = (BoundExpression)f_10436_24419_24447(this, f_10436_24430_24446(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 24462, 24506);

                TypeSymbol
                type = f_10436_24480_24505(this, f_10436_24495_24504(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 24520, 24633);

                return f_10436_24527_24632(node, receiver, f_10436_24549_24590(this, f_10436_24567_24589(node)), whenNotNull, whenNullOpt, f_10436_24618_24625(node), type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 24082, 24644);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_24253_24266(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24253, 24266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_24242_24267(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 24242, 24267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_24340_24356(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24340, 24356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_24329_24357(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 24329, 24357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10436_24430_24446(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.WhenNullOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24430, 24446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_24419_24447(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode?)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 24419, 24447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_24495_24504(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24495, 24504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_24480_24505(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 24480, 24505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10436_24567_24589(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.HasValueMethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24567, 24589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_24549_24590(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 24549, 24590);
                    return return_v;
                }


                int
                f_10436_24618_24625(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24618, 24625);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                f_10436_24527_24632(Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                hasValueMethodOpt, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenNotNull, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                whenNullOpt, int
                id, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(receiver, hasValueMethodOpt, whenNotNull, whenNullOpt, id, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 24527, 24632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 24082, 24644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 24082, 24644);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected MethodSymbol VisitMethodSymbol(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 24656, 26053);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 24742, 24829) || true) && ((object)method == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 24742, 24829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 24802, 24814);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 24742, 24829);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 24845, 26042) || true) && (f_10436_24849_24886(f_10436_24849_24870(method)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 24845, 26042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 24969, 25065);

                    var
                    newType = (NamedTypeSymbol)f_10436_25000_25045(f_10436_25000_25007(), f_10436_25023_25044(method)).AsTypeSymbolOnly()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 25083, 25274) || true) && (f_10436_25087_25134(newType, f_10436_25112_25133(method)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 25083, 25274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 25241, 25255);

                        return method;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 25083, 25274);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 25340, 25592);
                        foreach (var member in f_10436_25363_25394_I(f_10436_25363_25394(newType, f_10436_25382_25393(method))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 25340, 25592);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 25436, 25573) || true) && (f_10436_25440_25451(member) == SymbolKind.Method)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 25436, 25573);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 25522, 25550);

                                return (MethodSymbol)member;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 25436, 25573);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 25340, 25592);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10436, 1, 253);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10436, 1, 253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 25612, 25649);

                    throw f_10436_25618_25648();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 24845, 26042);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 24845, 26042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 25761, 26027);

                    return f_10436_25768_25923(((MethodSymbol)f_10436_25783_25808(method))
                    , f_10436_25858_25903(f_10436_25858_25865(), f_10436_25881_25902(method)).AsTypeSymbolOnly()).ConstructIfGeneric(f_10436_25965_26025(f_10436_25965_25972(), f_10436_25989_26024(method)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 24845, 26042);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 24656, 26053);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_24849_24870(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24849, 24870);
                    return return_v;
                }


                bool
                f_10436_24849_24886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 24849, 24886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10436_25000_25007()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25000, 25007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_25023_25044(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25023, 25044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10436_25000_25045(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 25000, 25045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_25112_25133(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25112, 25133);
                    return return_v;
                }


                bool
                f_10436_25087_25134(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 25087, 25134);
                    return return_v;
                }


                string
                f_10436_25382_25393(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25382, 25393);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10436_25363_25394(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 25363, 25394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10436_25440_25451(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25440, 25451);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10436_25363_25394_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 25363, 25394);
                    return return_v;
                }


                System.Exception
                f_10436_25618_25648()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25618, 25648);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_25783_25808(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25783, 25808);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10436_25858_25865()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25858, 25865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_25881_25902(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25881, 25902);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10436_25858_25903(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 25858, 25903);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_25768_25923(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 25768, 25923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10436_25965_25972()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25965, 25972);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10436_25989_26024(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 25989, 26024);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10436_25965_26025(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                original)
                {
                    var return_v = this_param.SubstituteTypes(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 25965, 26025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 24656, 26053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 24656, 26053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PropertySymbol VisitPropertySymbol(PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 26065, 27282);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 26157, 26246) || true) && ((object)property == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 26157, 26246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 26219, 26231);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 26157, 26246);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 26262, 26572) || true) && (f_10436_26266_26306_M(!f_10436_26267_26290(property).IsAnonymousType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 26262, 26572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 26388, 26557);

                    return f_10436_26395_26556(((PropertySymbol)f_10436_26412_26439(property))
                    , f_10436_26489_26536(f_10436_26489_26496(), f_10436_26512_26535(property)).AsTypeSymbolOnly());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 26262, 26572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 26633, 26731);

                var
                newType = (NamedTypeSymbol)f_10436_26664_26711(f_10436_26664_26671(), f_10436_26687_26710(property)).AsTypeSymbolOnly()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 26745, 26924) || true) && (f_10436_26749_26798(newType, f_10436_26774_26797(property)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 26745, 26924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 26893, 26909);

                    return property;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 26745, 26924);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 26984, 27218);
                    foreach (var member in f_10436_27007_27040_I(f_10436_27007_27040(newType, f_10436_27026_27039(property))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 26984, 27218);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 27074, 27203) || true) && (f_10436_27078_27089(member) == SymbolKind.Property)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 27074, 27203);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 27154, 27184);

                            return (PropertySymbol)member;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 27074, 27203);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 26984, 27218);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10436, 1, 235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10436, 1, 235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 27234, 27271);

                throw f_10436_27240_27270();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 26065, 27282);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_26267_26290(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 26267, 26290);
                    return return_v;
                }


                bool
                f_10436_26266_26306_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 26266, 26306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10436_26412_26439(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 26412, 26439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10436_26489_26496()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 26489, 26496);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_26512_26535(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 26512, 26535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10436_26489_26536(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 26489, 26536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10436_26395_26556(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 26395, 26556);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10436_26664_26671()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 26664, 26671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_26687_26710(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 26687, 26710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10436_26664_26711(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 26664, 26711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_26774_26797(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 26774, 26797);
                    return return_v;
                }


                bool
                f_10436_26749_26798(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 26749, 26798);
                    return return_v;
                }


                string
                f_10436_27026_27039(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27026, 27039);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10436_27007_27040(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 27007, 27040);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10436_27078_27089(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27078, 27089);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10436_27007_27040_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 27007, 27040);
                    return return_v;
                }


                System.Exception
                f_10436_27240_27270()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27240, 27270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 26065, 27282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 26065, 27282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FieldSymbol VisitFieldSymbol(FieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 27294, 27585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 27418, 27574);

                return f_10436_27425_27573(((FieldSymbol)f_10436_27439_27463(field))
                , f_10436_27509_27553(f_10436_27509_27516(), f_10436_27532_27552(field)).AsTypeSymbolOnly());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 27294, 27585);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_27439_27463(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27439, 27463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10436_27509_27516()
                {
                    var return_v = TypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27509, 27516);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10436_27532_27552(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27532, 27552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10436_27509_27553(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 27509, 27553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_27425_27573(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 27425, 27573);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 27294, 27585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 27294, 27585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitObjectInitializerMember(BoundObjectInitializerMember node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 27597, 28558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 27711, 27819);

                ImmutableArray<BoundExpression>
                arguments = (ImmutableArray<BoundExpression>)f_10436_27788_27818(this, f_10436_27803_27817(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 27833, 27877);

                TypeSymbol
                type = f_10436_27851_27876(this, f_10436_27866_27875(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 27891, 27951);

                TypeSymbol
                receiverType = f_10436_27917_27950(this, f_10436_27932_27949(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 27967, 27998);

                var
                member = f_10436_27980_27997(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 28014, 28347);

                switch (f_10436_28022_28033(member))
                {

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 28014, 28347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 28111, 28158);

                        member = f_10436_28120_28157(this, member);
                        DynAbs.Tracing.TraceSender.TraceBreak(10436, 28180, 28186);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 28014, 28347);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 28014, 28347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 28251, 28304);

                        member = f_10436_28260_28303(this, member);
                        DynAbs.Tracing.TraceSender.TraceBreak(10436, 28326, 28332);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 28014, 28347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 28363, 28547);

                return f_10436_28370_28546(node, member, arguments, f_10436_28401_28422(node), f_10436_28424_28448(node), f_10436_28450_28463(node), f_10436_28465_28485(node), f_10436_28487_28508(node), f_10436_28510_28525(node), receiverType, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 27597, 28558);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10436_27803_27817(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27803, 27817);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10436_27788_27818(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                list)
                {
                    var return_v = this_param.VisitList<Microsoft.CodeAnalysis.CSharp.BoundExpression>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 27788, 27818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_27866_27875(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27866, 27875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_27851_27876(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 27851, 27876);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_27932_27949(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ReceiverType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27932, 27949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_27917_27950(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 27917, 27950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10436_27980_27997(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 27980, 27997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10436_28022_28033(Microsoft.CodeAnalysis.CSharp.Symbol?
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28022, 28033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10436_28120_28157(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                field)
                {
                    var return_v = this_param.VisitFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 28120, 28157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10436_28260_28303(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                property)
                {
                    var return_v = this_param.VisitPropertySymbol((Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 28260, 28303);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10436_28401_28422(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentNamesOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28401, 28422);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10436_28424_28448(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28424, 28448);
                    return return_v;
                }


                bool
                f_10436_28450_28463(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.Expanded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28450, 28463);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<int>
                f_10436_28465_28485(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ArgsToParamsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28465, 28485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.BitVector
                f_10436_28487_28508(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.DefaultArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28487, 28508);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10436_28510_28525(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28510, 28525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                f_10436_28370_28546(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                memberSymbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                argumentRefKindsOpt, bool
                expanded, System.Collections.Immutable.ImmutableArray<int>
                argsToParamsOpt, Microsoft.CodeAnalysis.BitVector
                defaultArguments, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                receiverType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(memberSymbol, arguments, argumentNamesOpt, argumentRefKindsOpt, expanded, argsToParamsOpt, defaultArguments, resultKind, receiverType, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 28370, 28546);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 27597, 28558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 27597, 28558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitReadOnlySpanFromArray(BoundReadOnlySpanFromArray node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 28570, 28950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 28680, 28748);

                BoundExpression
                operand = (BoundExpression)f_10436_28723_28747(this, f_10436_28734_28746(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 28762, 28825);

                MethodSymbol
                method = f_10436_28784_28824(this, f_10436_28802_28823(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 28839, 28883);

                TypeSymbol
                type = f_10436_28857_28882(this, f_10436_28872_28881(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 28897, 28939);

                return f_10436_28904_28938(node, operand, method, type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 28570, 28950);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10436_28734_28746(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28734, 28746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10436_28723_28747(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 28723, 28747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_28802_28823(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.ConversionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28802, 28823);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10436_28784_28824(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.VisitMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 28784, 28824);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_28872_28881(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 28872, 28881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10436_28857_28882(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.VisitType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 28857, 28882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                f_10436_28904_28938(Microsoft.CodeAnalysis.CSharp.BoundReadOnlySpanFromArray
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                conversionMethod, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, conversionMethod, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 28904, 28938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 28570, 28950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 28570, 28950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool BaseReferenceInReceiverWasRewritten(BoundExpression originalReceiver, BoundExpression rewrittenReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10436, 28962, 29308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 29111, 29297);

                return originalReceiver != null && (DynAbs.Tracing.TraceSender.Expression_True(10436, 29118, 29194) && f_10436_29146_29167(originalReceiver) == BoundKind.BaseReference) && (DynAbs.Tracing.TraceSender.Expression_True(10436, 29118, 29243) && rewrittenReceiver != null) && (DynAbs.Tracing.TraceSender.Expression_True(10436, 29118, 29296) && f_10436_29247_29269(rewrittenReceiver) != BoundKind.BaseReference);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10436, 28962, 29308);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10436_29146_29167(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 29146, 29167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10436_29247_29269(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 29247, 29269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 28962, 29308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 28962, 29308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed partial class BaseMethodWrapperSymbol : SynthesizedMethodBaseSymbol
        {
            internal BaseMethodWrapperSymbol(NamedTypeSymbol containingType, MethodSymbol methodBeingWrapped, SyntaxNode syntax, string name)
            : base(f_10436_29798_29812_C(containingType), methodBeingWrapped, f_10436_29834_29872(f_10436_29834_29851(syntax), syntax), f_10436_29874_29894(syntax), name, DeclarationModifiers.Private)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10436, 29644, 30960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 29964, 30032);

                    f_10436_29964_30031(f_10436_29977_30008(containingType) is SourceModuleSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30050, 30136);

                    f_10436_30050_30135(f_10436_30063_30134(methodBeingWrapped, f_10436_30099_30133(methodBeingWrapped)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30154, 30197);

                    f_10436_30154_30196(f_10436_30167_30195_M(!methodBeingWrapped.IsStatic));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30217, 30240);

                    TypeMap
                    typeMap = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30258, 30309);

                    ImmutableArray<TypeParameterSymbol>
                    typeParameters
                    = default(ImmutableArray<TypeParameterSymbol>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30329, 30415);

                    var
                    substitutedType = f_10436_30351_30384(methodBeingWrapped) as SubstitutedNamedTypeSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30433, 30528);

                    typeMap = ((DynAbs.Tracing.TraceSender.Conditional_F1(10436, 30444, 30475) || (((object)substitutedType == null && DynAbs.Tracing.TraceSender.Conditional_F2(10436, 30478, 30491)) || DynAbs.Tracing.TraceSender.Conditional_F3(10436, 30494, 30526))) ? f_10436_30478_30491() : f_10436_30494_30526(substitutedType));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30548, 30869) || true) && (f_10436_30552_30587_M(!methodBeingWrapped.IsGenericMethod))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 30548, 30869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30629, 30688);

                        typeParameters = ImmutableArray<TypeParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 30548, 30869);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10436, 30548, 30869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30770, 30850);

                        typeMap = f_10436_30780_30849(typeMap, methodBeingWrapped, this, out typeParameters);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10436, 30548, 30869);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 30889, 30945);

                    f_10436_30889_30944(this, typeMap, typeParameters);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10436, 29644, 30960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 29644, 30960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 29644, 30960);
                }
            }

            internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 30976, 31394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 31142, 31203);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10436, 31142, 31202);
                    base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 31142, 31202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 31223, 31379);

                    f_10436_31223_31378(ref attributes, f_10436_31263_31377(f_10436_31263_31288(this), WellKnownMember.System_Diagnostics_DebuggerHiddenAttribute__ctor));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 30976, 31394);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10436_31263_31288(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 31263, 31288);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    f_10436_31263_31377(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor)
                    {
                        var return_v = this_param.TrySynthesizeAttribute(constructor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 31263, 31377);
                        return return_v;
                    }


                    int
                    f_10436_31223_31378(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                    attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    attribute)
                    {
                        AddSynthesizedAttribute(ref attributes, attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 31223, 31378);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 30976, 31394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 30976, 31394);
                }
            }

            internal override TypeWithAnnotations IteratorElementTypeWithAnnotations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 31515, 31689);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 31655, 31670);

                        return default;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 31515, 31689);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 31410, 31704);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 31410, 31704);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsIterator
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10436, 31754, 31762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10436, 31757, 31762);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10436, 31754, 31762);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10436, 31754, 31762);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 31754, 31762);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static BaseMethodWrapperSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10436, 29537, 31774);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10436, 29537, 31774);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 29537, 31774);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10436, 29537, 31774);

            static Microsoft.CodeAnalysis.SyntaxTree
            f_10436_29834_29851(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.SyntaxTree;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 29834, 29851);
                return return_v;
            }


            static Microsoft.CodeAnalysis.SyntaxReference
            f_10436_29834_29872(Microsoft.CodeAnalysis.SyntaxTree
            this_param, Microsoft.CodeAnalysis.SyntaxNode
            node)
            {
                var return_v = this_param.GetReference(node);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 29834, 29872);
                return return_v;
            }


            static Microsoft.CodeAnalysis.Location
            f_10436_29874_29894(Microsoft.CodeAnalysis.SyntaxNode
            this_param)
            {
                var return_v = this_param.GetLocation();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 29874, 29894);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
            f_10436_29977_30008(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.ContainingModule;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 29977, 30008);
                return return_v;
            }


            int
            f_10436_29964_30031(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 29964, 30031);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10436_30099_30133(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.ConstructedFrom;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 30099, 30133);
                return return_v;
            }


            bool
            f_10436_30063_30134(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            objA, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            objB)
            {
                var return_v = ReferenceEquals((object)objA, (object)objB);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 30063, 30134);
                return return_v;
            }


            int
            f_10436_30050_30135(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 30050, 30135);
                return 0;
            }


            bool
            f_10436_30167_30195_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 30167, 30195);
                return return_v;
            }


            int
            f_10436_30154_30196(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 30154, 30196);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10436_30351_30384(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.ContainingType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 30351, 30384);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
            f_10436_30478_30491()
            {
                var return_v = TypeMap.Empty;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 30478, 30491);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
            f_10436_30494_30526(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
            this_param)
            {
                var return_v = this_param.TypeSubstitution;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 30494, 30526);
                return return_v;
            }


            bool
            f_10436_30552_30587_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10436, 30552, 30587);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
            f_10436_30780_30849(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            oldOwner, Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
            newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
            newTypeParameters)
            {
                var return_v = this_param.WithAlphaRename(oldOwner, (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, out newTypeParameters);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 30780, 30849);
                return return_v;
            }


            int
            f_10436_30889_30944(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
            typeMap, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
            typeParameters)
            {
                this_param.AssignTypeMapAndTypeParameters(typeMap, typeParameters);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 30889, 30944);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10436_29798_29812_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10436, 29644, 30960);
                return return_v;
            }

        }

        static MethodToClassRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10436, 802, 31781);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10436, 802, 31781);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10436, 802, 31781);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10436, 802, 31781);

        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>
        f_10436_1474_1525()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.CapturedSymbolReplacement>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 1474, 1525);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
        f_10436_1943_1985()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 1943, 1985);
            return return_v;
        }


        int
        f_10436_3268_3306(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 3268, 3306);
            return 0;
        }


        int
        f_10436_3321_3354(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 3321, 3354);
            return 0;
        }


        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10436_3549_3609()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.BoundValuePlaceholderBase, Microsoft.CodeAnalysis.CSharp.BoundExpression>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10436, 3549, 3609);
            return return_v;
        }

    }
}
