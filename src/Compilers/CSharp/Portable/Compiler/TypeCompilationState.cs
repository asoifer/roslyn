// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class TypeCompilationState
    {
        internal struct MethodWithBody
        {

            public readonly MethodSymbol Method;

            public readonly BoundStatement Body;

            public readonly ImportChain? ImportChain;

            internal MethodWithBody(MethodSymbol method, BoundStatement body, ImportChain? importChain)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10629, 1296, 1646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 1420, 1455);

                    f_10629_1420_1454(method != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 1473, 1506);

                    f_10629_1473_1505(body != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 1526, 1547);

                    this.Method = method;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 1565, 1582);

                    this.Body = body;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 1600, 1631);

                    this.ImportChain = importChain;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10629, 1296, 1646);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 1296, 1646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 1296, 1646);
                }
            }
            static MethodWithBody()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10629, 1084, 1657);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10629, 1084, 1657);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 1084, 1657);
            }

            static int
            f_10629_1420_1454(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 1420, 1454);
                return 0;
            }


            static int
            f_10629_1473_1505(bool
            b)
            {
                RoslynDebug.Assert(b);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 1473, 1505);
                return 0;
            }

        }

        private ArrayBuilder<MethodWithBody>? _synthesizedMethods;

        private Dictionary<MethodSymbol, MethodSymbol>? _wrappers;

        private readonly NamedTypeSymbol? _typeOpt;

        public readonly PEModuleBuilder? ModuleBuilderOpt;

        public ImportChain? CurrentImportChain;

        public readonly CSharpCompilation Compilation;

        public SynthesizedClosureEnvironment? StaticLambdaFrame;

        private SmallDictionary<MethodSymbol, MethodSymbol>? _constructorInitializers;

        public TypeCompilationState(NamedTypeSymbol? typeOpt, CSharpCompilation compilation, PEModuleBuilder? moduleBuilderOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10629, 3257, 3531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 1794, 1813);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 2176, 2185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 2425, 2433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 2602, 2618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 2814, 2832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 2879, 2890);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 2941, 2958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 3220, 3244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 3401, 3432);

                this.Compilation = compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 3446, 3465);

                _typeOpt = typeOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 3479, 3520);

                this.ModuleBuilderOpt = moduleBuilderOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10629, 3257, 3531);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 3257, 3531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 3257, 3531);
            }
        }

        public NamedTypeSymbol Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 3712, 4011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 3932, 3962);

                    f_10629_3932_3961(_typeOpt is { });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 3980, 3996);

                    return _typeOpt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 3712, 4011);

                    int
                    f_10629_3932_3961(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 3932, 3961);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 3660, 4022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 3660, 4022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol? DynamicOperationContextType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 4220, 4343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 4256, 4328);

                    return f_10629_4263_4327_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(this.ModuleBuilderOpt, 10629, 4263, 4327).GetDynamicOperationContextType(f_10629_4317_4326(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 4220, 4343);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10629_4317_4326(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10629, 4317, 4326);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10629_4263_4327_I(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 4263, 4327);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 4144, 4354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 4144, 4354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [MemberNotNullWhen(true, nameof(ModuleBuilderOpt))]
        public bool Emitting
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 4472, 4512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 4478, 4510);

                    return ModuleBuilderOpt != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 4472, 4512);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 4366, 4523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 4366, 4523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ArrayBuilder<MethodWithBody>? SynthesizedMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 4615, 4650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 4621, 4648);

                    return _synthesizedMethods;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 4615, 4650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 4535, 4814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 4535, 4814);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 4664, 4803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 4700, 4742);

                    f_10629_4700_4741(_synthesizedMethods == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 4760, 4788);

                    _synthesizedMethods = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 4664, 4803);

                    int
                    f_10629_4700_4741(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 4700, 4741);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 4535, 4814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 4535, 4814);
                }
            }
        }

        public void AddSynthesizedMethod(MethodSymbol method, BoundStatement body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 4923, 5272);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 5022, 5167) || true) && (_synthesizedMethods == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10629, 5022, 5167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 5087, 5152);

                    _synthesizedMethods = f_10629_5109_5151();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10629, 5022, 5167);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 5183, 5261);

                f_10629_5183_5260(
                            _synthesizedMethods, f_10629_5207_5259(method, body, CurrentImportChain));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 4923, 5272);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                f_10629_5109_5151()
                {
                    var return_v = ArrayBuilder<MethodWithBody>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 5109, 5151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody
                f_10629_5207_5259(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body, Microsoft.CodeAnalysis.CSharp.ImportChain?
                importChain)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody(method, body, importChain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 5207, 5259);
                    return return_v;
                }


                int
                f_10629_5183_5260(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 5183, 5260);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 4923, 5272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 4923, 5272);
            }
        }

        public void AddMethodWrapper(MethodSymbol method, MethodSymbol wrapper, BoundStatement body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 5636, 5995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 5753, 5794);

                f_10629_5753_5793(this, wrapper, body);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 5810, 5937) || true) && (_wrappers == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10629, 5810, 5937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 5865, 5922);

                    _wrappers = f_10629_5877_5921();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10629, 5810, 5937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 5953, 5984);

                f_10629_5953_5983(
                            _wrappers, method, wrapper);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 5636, 5995);

                int
                f_10629_5753_5793(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.AddSynthesizedMethod(method, body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 5753, 5793);
                    return 0;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10629_5877_5921()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 5877, 5921);
                    return return_v;
                }


                int
                f_10629_5953_5983(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 5953, 5983);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 5636, 5995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 5636, 5995);
            }
        }

        public int NextWrapperMethodIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 6147, 6202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 6153, 6200);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10629, 6160, 6177) || ((_wrappers == null && DynAbs.Tracing.TraceSender.Conditional_F2(10629, 6180, 6181)) || DynAbs.Tracing.TraceSender.Conditional_F3(10629, 6184, 6199))) ? 0 : f_10629_6184_6199(_wrappers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 6147, 6202);

                    int
                    f_10629_6184_6199(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10629, 6184, 6199);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 6089, 6213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 6089, 6213);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MethodSymbol? GetMethodWrapper(MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 6535, 6760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 6618, 6647);

                MethodSymbol?
                wrapper = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 6661, 6749);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10629, 6668, 6731) || ((_wrappers != null && (DynAbs.Tracing.TraceSender.Expression_True(10629, 6668, 6731) && f_10629_6689_6731(_wrappers, method, out wrapper)) && DynAbs.Tracing.TraceSender.Conditional_F2(10629, 6734, 6741)) || DynAbs.Tracing.TraceSender.Conditional_F3(10629, 6744, 6748))) ? wrapper : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 6535, 6760);

                bool
                f_10629_6689_6731(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 6689, 6731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 6535, 6760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 6535, 6760);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 6858, 7143);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 6901, 7053) || true) && (_synthesizedMethods != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10629, 6901, 7053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 6966, 6993);

                    f_10629_6966_6992(_synthesizedMethods);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 7011, 7038);

                    _synthesizedMethods = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10629, 6901, 7053);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 7069, 7086);

                _wrappers = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 7100, 7132);

                _constructorInitializers = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 6858, 7143);

                int
                f_10629_6966_6992(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.TypeCompilationState.MethodWithBody>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 6966, 6992);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 6858, 7143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 6858, 7143);
            }
        }

        internal void ReportCtorInitializerCycles(MethodSymbol method1, MethodSymbol method2, SyntaxNode syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10629, 7646, 9518);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8138, 8306) || true) && (method1 == method2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10629, 8138, 8306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8254, 8291);

                    throw f_10629_8260_8290();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10629, 8138, 8306);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8322, 8574) || true) && (_constructorInitializers == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10629, 8322, 8574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8392, 8469);

                    _constructorInitializers = f_10629_8419_8468();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8487, 8534);

                    f_10629_8487_8533(_constructorInitializers, method1, method2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8552, 8559);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10629, 8322, 8574);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8590, 8619);

                MethodSymbol?
                next = method2
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8633, 9507) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10629, 8633, 9507);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8678, 9492) || true) && (f_10629_8682_8734(_constructorInitializers, next, out next))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10629, 8678, 9492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8776, 8817);

                            f_10629_8776_8816((object)next != null);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 8839, 9214) || true) && (method1 == next)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10629, 8839, 9214);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 9068, 9158);

                                f_10629_9068_9157(                        // We found a (new) cycle containing the edge (method1, method2). Report an
                                                                          // error and do not add the edge.
                                                        diagnostics, ErrorCode.ERR_IndirectRecursiveConstructorCall, f_10629_9132_9147(syntax), method1);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 9184, 9191);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10629, 8839, 9214);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10629, 8678, 9492);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10629, 8678, 9492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 9397, 9444);

                            f_10629_9397_9443(                    // we've reached the end of the path without finding a cycle. Add the new edge.
                                                _constructorInitializers, method1, method2);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10629, 9466, 9473);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10629, 8678, 9492);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10629, 8633, 9507);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10629, 8633, 9507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10629, 8633, 9507);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10629, 7646, 9518);

                System.Exception
                f_10629_8260_8290()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10629, 8260, 8290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10629_8419_8468()
                {
                    var return_v = new Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 8419, 8468);
                    return return_v;
                }


                int
                f_10629_8487_8533(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 8487, 8533);
                    return 0;
                }


                bool
                f_10629_8682_8734(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 8682, 8734);
                    return return_v;
                }


                int
                f_10629_8776_8816(bool
                b)
                {
                    RoslynDebug.Assert(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 8776, 8816);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10629_9132_9147(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10629, 9132, 9147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10629_9068_9157(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 9068, 9157);
                    return return_v;
                }


                int
                f_10629_9397_9443(Microsoft.CodeAnalysis.SmallDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10629, 9397, 9443);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10629, 7646, 9518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 7646, 9518);
            }
        }

        static TypeCompilationState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10629, 967, 9525);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10629, 967, 9525);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10629, 967, 9525);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10629, 967, 9525);
    }
}
