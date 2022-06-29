// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using Cci = Microsoft.Cci;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal partial class ILBuilder
    {
        private sealed class LocalScopeManager
        {
            private readonly LocalScopeInfo _rootScope;

            private readonly Stack<ScopeInfo> _scopes;

            private ExceptionHandlerScope _enclosingExceptionHandler;

            internal LocalScopeManager()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(69, 886, 1091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 732, 742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 791, 798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 843, 869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 947, 981);

                    _rootScope = f_69_960_980();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 999, 1033);

                    _scopes = f_69_1009_1032(1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1051, 1076);

                    f_69_1051_1075(_scopes, _rootScope);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(69, 886, 1091);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 886, 1091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 886, 1091);
                }
            }

            private ScopeInfo CurrentScope
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 1138, 1155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1141, 1155);
                        return f_69_1141_1155(_scopes); DynAbs.Tracing.TraceSender.TraceExitMethod(69, 1138, 1155);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 1138, 1155);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 1138, 1155);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal ScopeInfo OpenScope(ScopeType scopeType, Cci.ITypeReference exceptionType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 1172, 1723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1288, 1377);

                    var
                    scope = f_69_1300_1376(f_69_1300_1312(), scopeType, exceptionType, _enclosingExceptionHandler)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1395, 1415);

                    f_69_1395_1414(_scopes, scope);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1435, 1582) || true) && (f_69_1439_1463(scope))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 1435, 1582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1505, 1563);

                        _enclosingExceptionHandler = (ExceptionHandlerScope)scope;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 1435, 1582);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1602, 1677);

                    f_69_1602_1676(_enclosingExceptionHandler == f_69_1645_1675(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1695, 1708);

                    return scope;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 1172, 1723);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_1300_1312()
                    {
                        var return_v = CurrentScope;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 1300, 1312);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_1300_1376(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.ScopeType
                    scopeType, Microsoft.Cci.ITypeReference
                    exceptionType, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    currentHandler)
                    {
                        var return_v = this_param.OpenScope(scopeType, exceptionType, currentHandler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 1300, 1376);
                        return return_v;
                    }


                    int
                    f_69_1395_1414(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    item)
                    {
                        this_param.Push(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 1395, 1414);
                        return 0;
                    }


                    bool
                    f_69_1439_1463(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param)
                    {
                        var return_v = this_param.IsExceptionHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 1439, 1463);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_1645_1675(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                    this_param)
                    {
                        var return_v = this_param.GetEnclosingExceptionHandler();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 1645, 1675);
                        return return_v;
                    }


                    int
                    f_69_1602_1676(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 1602, 1676);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 1172, 1723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 1172, 1723);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void FinishFilterCondition(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 1739, 1885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1826, 1870);

                    f_69_1826_1869(f_69_1826_1838(), builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 1739, 1885);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_1826_1838()
                    {
                        var return_v = CurrentScope;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 1826, 1838);
                        return return_v;
                    }


                    int
                    f_69_1826_1869(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder)
                    {
                        this_param.FinishFilterCondition(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 1826, 1869);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 1739, 1885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 1739, 1885);
                }
            }

            internal void ClosingScope(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 1901, 2029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 1979, 2014);

                    f_69_1979_2013(f_69_1979_1991(), builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 1901, 2029);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_1979_1991()
                    {
                        var return_v = CurrentScope;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 1979, 1991);
                        return return_v;
                    }


                    int
                    f_69_1979_2013(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder)
                    {
                        this_param.ClosingScope(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 1979, 2013);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 1901, 2029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 1901, 2029);
                }
            }

            internal void CloseScope(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 2045, 2470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 2121, 2147);

                    var
                    scope = f_69_2133_2146(_scopes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 2165, 2191);

                    f_69_2165_2190(scope, builder);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 2211, 2360) || true) && (f_69_2215_2239(scope))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 2211, 2360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 2281, 2341);

                        _enclosingExceptionHandler = f_69_2310_2340(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 2211, 2360);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 2380, 2455);

                    f_69_2380_2454(_enclosingExceptionHandler == f_69_2423_2453(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 2045, 2470);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_2133_2146(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 2133, 2146);
                        return return_v;
                    }


                    int
                    f_69_2165_2190(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder)
                    {
                        this_param.CloseScope(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 2165, 2190);
                        return 0;
                    }


                    bool
                    f_69_2215_2239(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param)
                    {
                        var return_v = this_param.IsExceptionHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 2215, 2239);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_2310_2340(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                    this_param)
                    {
                        var return_v = this_param.GetEnclosingExceptionHandler();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 2310, 2340);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_2423_2453(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeManager
                    this_param)
                    {
                        var return_v = this_param.GetEnclosingExceptionHandler();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 2423, 2453);
                        return return_v;
                    }


                    int
                    f_69_2380_2454(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 2380, 2454);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 2045, 2470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 2045, 2470);
                }
            }

            internal ExceptionHandlerScope EnclosingExceptionHandler
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 2543, 2572);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 2546, 2572);
                        return _enclosingExceptionHandler; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 2543, 2572);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 2543, 2572);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 2543, 2572);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private ExceptionHandlerScope GetEnclosingExceptionHandler()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 2589, 3184);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 2682, 3139);
                        foreach (var scope in f_69_2704_2711_I(_scopes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 2682, 3139);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 2753, 3120);

                            switch (f_69_2761_2771(scope))
                            {

                                case ScopeType.Try:
                                case ScopeType.Catch:
                                case ScopeType.Filter:
                                case ScopeType.Finally:
                                case ScopeType.Fault:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 2753, 3120);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3061, 3097);

                                    return (ExceptionHandlerScope)scope;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(69, 2753, 3120);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 2682, 3139);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 458);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 458);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3157, 3169);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 2589, 3184);

                    Microsoft.CodeAnalysis.CodeGen.ScopeType
                    f_69_2761_2771(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 2761, 2771);
                        return return_v;
                    }


                    System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>
                    f_69_2704_2711_I(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 2704, 2711);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 2589, 3184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 2589, 3184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal BasicBlock CreateBlock(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 3200, 3391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3283, 3324);

                    var
                    scope = (LocalScopeInfo)f_69_3311_3323()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3342, 3376);

                    return f_69_3349_3375(scope, builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 3200, 3391);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_3311_3323()
                    {
                        var return_v = CurrentScope;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 3311, 3323);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_69_3349_3375(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder)
                    {
                        var return_v = this_param.CreateBlock(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 3349, 3375);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 3200, 3391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 3200, 3391);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal SwitchBlock CreateSwitchBlock(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 3407, 3611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3497, 3538);

                    var
                    scope = (LocalScopeInfo)f_69_3525_3537()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3556, 3596);

                    return f_69_3563_3595(scope, builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 3407, 3611);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_3525_3537()
                    {
                        var return_v = CurrentScope;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 3525, 3537);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                    f_69_3563_3595(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder)
                    {
                        var return_v = this_param.CreateSwitchBlock(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 3563, 3595);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 3407, 3611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 3407, 3611);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void AddLocal(LocalDefinition variable)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 3627, 3807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3708, 3749);

                    var
                    scope = (LocalScopeInfo)f_69_3736_3748()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3767, 3792);

                    f_69_3767_3791(scope, variable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 3627, 3807);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_3736_3748()
                    {
                        var return_v = CurrentScope;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 3736, 3748);
                        return return_v;
                    }


                    int
                    f_69_3767_3791(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                    variable)
                    {
                        this_param.AddLocal(variable);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 3767, 3791);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 3627, 3807);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 3627, 3807);
                }
            }

            internal void AddLocalConstant(LocalConstantDefinition constant)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 3823, 4027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3920, 3961);

                    var
                    scope = (LocalScopeInfo)f_69_3948_3960()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 3979, 4012);

                    f_69_3979_4011(scope, constant);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 3823, 4027);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_3948_3960()
                    {
                        var return_v = CurrentScope;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 3948, 3960);
                        return return_v;
                    }


                    int
                    f_69_3979_4011(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition
                    constant)
                    {
                        this_param.AddLocalConstant(constant);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 3979, 4011);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 3823, 4027);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 3823, 4027);
                }
            }

            internal ImmutableArray<Cci.LocalScope> GetAllScopesWithLocals()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 4155, 5204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 4252, 4308);

                    var
                    result = f_69_4265_4307()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 4326, 4385);

                    ScopeBounds
                    rootBounds = f_69_4351_4384(_rootScope, result)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 4405, 4469);

                    int
                    expectedRootScopeLength = rootBounds.End - rootBounds.Begin
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 4622, 5013) || true) && (f_69_4626_4638(result) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(69, 4626, 4704) && result[f_69_4653_4665(result) - 1].Length != expectedRootScopeLength))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 4622, 5013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 4746, 4994);

                        f_69_4746_4993(result, f_69_4757_4992(0, expectedRootScopeLength, ImmutableArray<Cci.ILocalDefinition>.Empty, ImmutableArray<Cci.ILocalDefinition>.Empty));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 4622, 5013);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 5098, 5134);

                    f_69_5098_5133(
                                    // scopes should be sorted by position and size
                                    result, ScopeComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 5154, 5189);

                    return f_69_5161_5188(result);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 4155, 5204);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    f_69_4265_4307()
                    {
                        var return_v = ArrayBuilder<Cci.LocalScope>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 4265, 4307);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_4351_4384(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    result)
                    {
                        var return_v = this_param.GetLocalScopes(result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 4351, 4384);
                        return return_v;
                    }


                    int
                    f_69_4626_4638(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 4626, 4638);
                        return return_v;
                    }


                    int
                    f_69_4653_4665(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 4653, 4665);
                        return return_v;
                    }


                    Microsoft.Cci.LocalScope
                    f_69_4757_4992(int
                    offset, int
                    endOffset, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                    constants, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                    locals)
                    {
                        var return_v = new Microsoft.Cci.LocalScope(offset, endOffset, constants, locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 4757, 4992);
                        return return_v;
                    }


                    int
                    f_69_4746_4993(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    this_param, Microsoft.Cci.LocalScope
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 4746, 4993);
                        return 0;
                    }


                    int
                    f_69_5098_5133(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeComparer
                    comparer)
                    {
                        this_param.Sort((System.Collections.Generic.IComparer<Microsoft.Cci.LocalScope>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 5098, 5133);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.LocalScope>
                    f_69_5161_5188(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 5161, 5188);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 4155, 5204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 4155, 5204);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ImmutableArray<Cci.ExceptionHandlerRegion> GetExceptionHandlerRegions()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 5544, 5857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 5657, 5725);

                    var
                    result = f_69_5670_5724()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 5743, 5789);

                    f_69_5743_5788(_rootScope, result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 5807, 5842);

                    return f_69_5814_5841(result);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 5544, 5857);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExceptionHandlerRegion>
                    f_69_5670_5724()
                    {
                        var return_v = ArrayBuilder<Cci.ExceptionHandlerRegion>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 5670, 5724);
                        return return_v;
                    }


                    int
                    f_69_5743_5788(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExceptionHandlerRegion>
                    regions)
                    {
                        this_param.GetExceptionHandlerRegions(regions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 5743, 5788);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExceptionHandlerRegion>
                    f_69_5814_5841(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExceptionHandlerRegion>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 5814, 5841);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 5544, 5857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 5544, 5857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ImmutableArray<StateMachineHoistedLocalScope> GetHoistedLocalScopes()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 5873, 6182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 5984, 6055);

                    var
                    result = f_69_5997_6054()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6073, 6114);

                    f_69_6073_6113(_rootScope, result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6132, 6167);

                    return f_69_6139_6166(result);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 5873, 6182);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                    f_69_5997_6054()
                    {
                        var return_v = ArrayBuilder<StateMachineHoistedLocalScope>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 5997, 6054);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_6073_6113(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                    result)
                    {
                        var return_v = this_param.GetHoistedLocalScopes(result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 6073, 6113);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                    f_69_6139_6166(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 6139, 6166);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 5873, 6182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 5873, 6182);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void AddUserHoistedLocal(int slotIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 6198, 6390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6279, 6320);

                    var
                    scope = (LocalScopeInfo)f_69_6307_6319()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6338, 6375);

                    f_69_6338_6374(scope, slotIndex);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 6198, 6390);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_6307_6319()
                    {
                        var return_v = CurrentScope;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 6307, 6319);
                        return return_v;
                    }


                    int
                    f_69_6338_6374(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, int
                    slotIndex)
                    {
                        this_param.AddUserHoistedLocal(slotIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 6338, 6374);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 6198, 6390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 6198, 6390);
                }
            }

            internal void FreeBasicBlocks()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 6406, 6514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6470, 6499);

                    f_69_6470_6498(_rootScope);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 6406, 6514);

                    int
                    f_69_6470_6498(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param)
                    {
                        this_param.FreeBasicBlocks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 6470, 6498);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 6406, 6514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 6406, 6514);
                }
            }

            internal bool PossiblyDefinedOutsideOfTry(LocalDefinition local)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 6530, 7113);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6627, 6961);
                        foreach (var s in f_69_6645_6652_I(_scopes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 6627, 6961);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6694, 6806) || true) && (f_69_6698_6720(s, local))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 6694, 6806);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6770, 6783);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(69, 6694, 6806);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6830, 6942) || true) && (f_69_6834_6840(s) == ScopeType.Try)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 6830, 6942);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 6907, 6919);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(69, 6830, 6942);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 6627, 6961);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 335);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 335);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 7086, 7098);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 6530, 7113);

                    bool
                    f_69_6698_6720(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                    local)
                    {
                        var return_v = this_param.ContainsLocal(local);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 6698, 6720);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ScopeType
                    f_69_6834_6840(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 6834, 6840);
                        return return_v;
                    }


                    System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>
                    f_69_6645_6652_I(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 6645, 6652);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 6530, 7113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 6530, 7113);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static LocalScopeManager()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(69, 637, 7124);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(69, 637, 7124);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 637, 7124);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(69, 637, 7124);

            static Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
            f_69_960_980()
            {
                var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 960, 980);
                return return_v;
            }


            static System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>
            f_69_1009_1032(int
            capacity)
            {
                var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 1009, 1032);
                return return_v;
            }


            static int
            f_69_1051_1075(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>
            this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
            item)
            {
                this_param.Push((Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 1051, 1075);
                return 0;
            }


            Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
            f_69_1141_1155(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>
            this_param)
            {
                var return_v = this_param.Peek();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 1141, 1155);
                return return_v;
            }

        }
        internal abstract class ScopeInfo
        {
            public abstract ScopeType Type { get; }

            public virtual ScopeInfo OpenScope(ScopeType scopeType,
                            Microsoft.Cci.ITypeReference exceptionType,
                            ExceptionHandlerScope currentHandler)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 7555, 8160);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 7759, 8145) || true) && (scopeType == ScopeType.TryCatchFinally)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 7759, 8145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 7843, 7901);

                        return f_69_7850_7900(currentHandler);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 7759, 8145);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 7759, 8145);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 7983, 8076);

                        f_69_7983_8075(scopeType == ScopeType.Variable || (DynAbs.Tracing.TraceSender.Expression_False(69, 7996, 8074) || scopeType == ScopeType.StateMachineVariable));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 8098, 8126);

                        return f_69_8105_8125();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 7759, 8145);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 7555, 8160);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                    f_69_7850_7900(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    containingHandler)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope(containingHandler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 7850, 7900);
                        return return_v;
                    }


                    int
                    f_69_7983_8075(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 7983, 8075);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    f_69_8105_8125()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 8105, 8125);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 7555, 8160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 7555, 8160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public virtual void ClosingScope(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 8176, 8257);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 8176, 8257);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 8176, 8257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 8176, 8257);
                }
            }

            public virtual void CloseScope(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 8273, 8352);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 8273, 8352);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 8273, 8352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 8273, 8352);
                }
            }

            public virtual void FinishFilterCondition(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 8368, 8513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 8461, 8498);

                    throw f_69_8467_8497();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 8368, 8513);

                    System.Exception
                    f_69_8467_8497()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 8467, 8497);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 8368, 8513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 8368, 8513);
                }
            }

            public bool IsExceptionHandler
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 8592, 9074);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 8636, 9055);

                        switch (f_69_8644_8653(this))
                        {

                            case ScopeType.Try:
                            case ScopeType.Catch:
                            case ScopeType.Filter:
                            case ScopeType.Finally:
                            case ScopeType.Fault:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 8636, 9055);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 8943, 8955);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(69, 8636, 9055);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 8636, 9055);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 9019, 9032);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(69, 8636, 9055);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(69, 8592, 9074);

                        Microsoft.CodeAnalysis.CodeGen.ScopeType
                        f_69_8644_8653(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 8644, 8653);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 8529, 9089);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 8529, 9089);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal abstract void GetExceptionHandlerRegions(ArrayBuilder<Cci.ExceptionHandlerRegion> regions);

            internal abstract ScopeBounds GetLocalScopes(ArrayBuilder<Cci.LocalScope> result);

            protected static ScopeBounds GetLocalScopes<TScopeInfo>(ArrayBuilder<Cci.LocalScope> result, ImmutableArray<TScopeInfo>.Builder scopes)
                            where TScopeInfo : ScopeInfo
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(69, 9526, 10189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 9740, 9771);

                    f_69_9740_9770(f_69_9753_9765(scopes) > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 9791, 9816);

                    int
                    begin = int.MaxValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 9834, 9846);

                    int
                    end = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 9866, 10119);
                        foreach (var scope in f_69_9888_9894_I(scopes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 9866, 10119);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 9936, 9986);

                            ScopeBounds
                            bounds = f_69_9957_9985(scope, result)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 10008, 10046);

                            begin = f_69_10016_10045(begin, bounds.Begin);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 10068, 10100);

                            end = f_69_10074_10099(end, bounds.End);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 9866, 10119);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 254);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 254);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 10139, 10174);

                    return f_69_10146_10173(begin, end);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(69, 9526, 10189);

                    int
                    f_69_9753_9765(System.Collections.Immutable.ImmutableArray<TScopeInfo>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 9753, 9765);
                        return return_v;
                    }


                    int
                    f_69_9740_9770(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 9740, 9770);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_9957_9985(TScopeInfo
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    result)
                    {
                        var return_v = this_param.GetLocalScopes(result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 9957, 9985);
                        return return_v;
                    }


                    int
                    f_69_10016_10045(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 10016, 10045);
                        return return_v;
                    }


                    int
                    f_69_10074_10099(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 10074, 10099);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TScopeInfo>.Builder
                    f_69_9888_9894_I(System.Collections.Immutable.ImmutableArray<TScopeInfo>.Builder
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 9888, 9894);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_10146_10173(int
                    begin, int
                    end)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds(begin, end);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 10146, 10173);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 9526, 10189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 9526, 10189);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal abstract ScopeBounds GetHoistedLocalScopes(ArrayBuilder<StateMachineHoistedLocalScope> result);

            protected static ScopeBounds GetHoistedLocalScopes<TScopeInfo>(ArrayBuilder<StateMachineHoistedLocalScope> result, ImmutableArray<TScopeInfo>.Builder scopes)
                            where TScopeInfo : ScopeInfo
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(69, 10532, 11224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 10768, 10799);

                    f_69_10768_10798(f_69_10781_10793(scopes) > 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 10819, 10844);

                    int
                    begin = int.MaxValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 10862, 10874);

                    int
                    end = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 10894, 11154);
                        foreach (var scope in f_69_10916_10922_I(scopes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 10894, 11154);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 10964, 11021);

                            ScopeBounds
                            bounds = f_69_10985_11020(scope, result)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 11043, 11081);

                            begin = f_69_11051_11080(begin, bounds.Begin);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 11103, 11135);

                            end = f_69_11109_11134(end, bounds.End);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 10894, 11154);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 261);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 261);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 11174, 11209);

                    return f_69_11181_11208(begin, end);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(69, 10532, 11224);

                    int
                    f_69_10781_10793(System.Collections.Immutable.ImmutableArray<TScopeInfo>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 10781, 10793);
                        return return_v;
                    }


                    int
                    f_69_10768_10798(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 10768, 10798);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_10985_11020(TScopeInfo
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                    result)
                    {
                        var return_v = this_param.GetHoistedLocalScopes(result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 10985, 11020);
                        return return_v;
                    }


                    int
                    f_69_11051_11080(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 11051, 11080);
                        return return_v;
                    }


                    int
                    f_69_11109_11134(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 11109, 11134);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<TScopeInfo>.Builder
                    f_69_10916_10922_I(System.Collections.Immutable.ImmutableArray<TScopeInfo>.Builder
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 10916, 10922);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_11181_11208(int
                    begin, int
                    end)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds(begin, end);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 11181, 11208);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 10532, 11224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 10532, 11224);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public abstract void FreeBasicBlocks();

            internal virtual bool ContainsLocal(LocalDefinition local)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 11483, 11491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 11486, 11491);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 11483, 11491);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 11483, 11491);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 11483, 11491);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ScopeInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(69, 7442, 11503);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(69, 7442, 11503);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 7442, 11503);
            }


            static ScopeInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(69, 7442, 11503);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(69, 7442, 11503);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 7442, 11503);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(69, 7442, 11503);
        }
        internal class LocalScopeInfo : ScopeInfo
        {
            private ImmutableArray<LocalDefinition>.Builder _localVariables;

            private ImmutableArray<LocalConstantDefinition>.Builder _localConstants;

            private ImmutableArray<int>.Builder _stateMachineUserHoistedLocalSlotIndices;

            private ImmutableArray<ScopeInfo>.Builder _nestedScopes;

            protected ImmutableArray<BasicBlock>.Builder Blocks;

            public override ScopeType Type
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 12325, 12346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 12328, 12346);
                        return ScopeType.Variable; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 12325, 12346);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 12325, 12346);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 12325, 12346);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ScopeInfo OpenScope(
                            ScopeType scopeType,
                            Cci.ITypeReference exceptionType,
                            ExceptionHandlerScope currentExceptionHandler)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 12363, 12915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 12585, 12663);

                    var
                    scope = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.OpenScope(scopeType, exceptionType, currentExceptionHandler), 69, 12597, 12662)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 12681, 12826) || true) && (_nestedScopes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 12681, 12826);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 12748, 12807);

                        _nestedScopes = f_69_12764_12806(1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 12681, 12826);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 12844, 12869);

                    f_69_12844_12868(_nestedScopes, scope);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 12887, 12900);

                    return scope;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 12363, 12915);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>.Builder
                    f_69_12764_12806(int
                    initialCapacity)
                    {
                        var return_v = ImmutableArray.CreateBuilder<ScopeInfo>(initialCapacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 12764, 12806);
                        return return_v;
                    }


                    int
                    f_69_12844_12868(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>.Builder
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 12844, 12868);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 12363, 12915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 12363, 12915);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal void AddLocal(LocalDefinition variable)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 12931, 13288);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13012, 13167) || true) && (_localVariables == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 13012, 13167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13081, 13148);

                        _localVariables = f_69_13099_13147(1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 13012, 13167);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13187, 13223);

                    f_69_13187_13222(f_69_13200_13213(variable) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13243, 13273);

                    f_69_13243_13272(
                                    _localVariables, variable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 12931, 13288);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>.Builder
                    f_69_13099_13147(int
                    initialCapacity)
                    {
                        var return_v = ImmutableArray.CreateBuilder<LocalDefinition>(initialCapacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 13099, 13147);
                        return return_v;
                    }


                    string?
                    f_69_13200_13213(Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 13200, 13213);
                        return return_v;
                    }


                    int
                    f_69_13187_13222(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 13187, 13222);
                        return 0;
                    }


                    int
                    f_69_13243_13272(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>.Builder
                    this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 13243, 13272);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 12931, 13288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 12931, 13288);
                }
            }

            internal void AddLocalConstant(LocalConstantDefinition constant)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 13304, 13685);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13401, 13564) || true) && (_localConstants == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 13401, 13564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13470, 13545);

                        _localConstants = f_69_13488_13544(1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 13401, 13564);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13584, 13620);

                    f_69_13584_13619(f_69_13597_13610(constant) != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13640, 13670);

                    f_69_13640_13669(
                                    _localConstants, constant);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 13304, 13685);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition>.Builder
                    f_69_13488_13544(int
                    initialCapacity)
                    {
                        var return_v = ImmutableArray.CreateBuilder<LocalConstantDefinition>(initialCapacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 13488, 13544);
                        return return_v;
                    }


                    string
                    f_69_13597_13610(Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 13597, 13610);
                        return return_v;
                    }


                    int
                    f_69_13584_13619(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 13584, 13619);
                        return 0;
                    }


                    int
                    f_69_13640_13669(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition>.Builder
                    this_param, Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 13640, 13669);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 13304, 13685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 13304, 13685);
                }
            }

            internal void AddUserHoistedLocal(int slotIndex)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 13701, 14113);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13782, 13975) || true) && (_stateMachineUserHoistedLocalSlotIndices == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 13782, 13975);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13876, 13956);

                        _stateMachineUserHoistedLocalSlotIndices = f_69_13919_13955(1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 13782, 13975);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 13995, 14024);

                    f_69_13995_14023(slotIndex >= 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14042, 14098);

                    f_69_14042_14097(_stateMachineUserHoistedLocalSlotIndices, slotIndex);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 13701, 14113);

                    System.Collections.Immutable.ImmutableArray<int>.Builder
                    f_69_13919_13955(int
                    initialCapacity)
                    {
                        var return_v = ImmutableArray.CreateBuilder<int>(initialCapacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 13919, 13955);
                        return return_v;
                    }


                    int
                    f_69_13995_14023(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 13995, 14023);
                        return 0;
                    }


                    int
                    f_69_14042_14097(System.Collections.Immutable.ImmutableArray<int>.Builder
                    this_param, int
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 14042, 14097);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 13701, 14113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 13701, 14113);
                }
            }

            internal override bool ContainsLocal(LocalDefinition local)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 14129, 14331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14221, 14250);

                    var
                    locals = _localVariables
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14268, 14316);

                    return locals != null && (DynAbs.Tracing.TraceSender.Expression_True(69, 14275, 14315) && f_69_14293_14315(locals, local));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 14129, 14331);

                    bool
                    f_69_14293_14315(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>.Builder
                    this_param, Microsoft.CodeAnalysis.CodeGen.LocalDefinition
                    item)
                    {
                        var return_v = this_param.Contains(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 14293, 14315);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 14129, 14331);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 14129, 14331);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public virtual BasicBlock CreateBlock(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 14347, 14763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14436, 14493);

                    var
                    enclosingHandler = f_69_14459_14492(builder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14511, 14681);

                    var
                    block = (DynAbs.Tracing.TraceSender.Conditional_F1(69, 14523, 14547) || ((enclosingHandler == null && DynAbs.Tracing.TraceSender.Conditional_F2(69, 14571, 14599)) || DynAbs.Tracing.TraceSender.Conditional_F3(69, 14623, 14680))) ? f_69_14571_14599(builder) : f_69_14623_14680(builder, enclosingHandler)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14701, 14717);

                    f_69_14701_14716(this, block);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14735, 14748);

                    return block;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 14347, 14763);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_14459_14492(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    this_param)
                    {
                        var return_v = this_param.EnclosingExceptionHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 14459, 14492);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_69_14571_14599(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder)
                    {
                        var return_v = AllocatePooledBlock(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 14571, 14599);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlockWithHandlerScope
                    f_69_14623_14680(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    enclosingHandler)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlockWithHandlerScope(builder, enclosingHandler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 14623, 14680);
                        return return_v;
                    }


                    int
                    f_69_14701_14716(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    block)
                    {
                        this_param.AddBlock(block);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 14701, 14716);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 14347, 14763);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 14347, 14763);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static BasicBlock AllocatePooledBlock(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(69, 14779, 15005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14876, 14915);

                    var
                    block = f_69_14888_14914(BasicBlock.Pool)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14933, 14959);

                    f_69_14933_14958(block, builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 14977, 14990);

                    return block;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(69, 14779, 15005);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_69_14888_14914(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>
                    this_param)
                    {
                        var return_v = this_param.Allocate();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 14888, 14914);
                        return return_v;
                    }


                    int
                    f_69_14933_14958(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder)
                    {
                        this_param.Initialize(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 14933, 14958);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 14779, 15005);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 14779, 15005);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SwitchBlock CreateSwitchBlock(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 15021, 15261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15109, 15181);

                    var
                    block = f_69_15121_15180(builder, f_69_15146_15179(builder))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15199, 15215);

                    f_69_15199_15214(this, block);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15233, 15246);

                    return block;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 15021, 15261);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_15146_15179(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    this_param)
                    {
                        var return_v = this_param.EnclosingExceptionHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 15146, 15179);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                    f_69_15121_15180(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    enclosingHandler)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock(builder, enclosingHandler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 15121, 15180);
                        return return_v;
                    }


                    int
                    f_69_15199_15214(Microsoft.CodeAnalysis.CodeGen.ILBuilder.LocalScopeInfo
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.SwitchBlock
                    block)
                    {
                        this_param.AddBlock((Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock)block);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 15199, 15214);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 15021, 15261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 15021, 15261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected void AddBlock(BasicBlock block)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 15277, 15536);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15351, 15483) || true) && (Blocks == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 15351, 15483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15411, 15464);

                        Blocks = f_69_15420_15463(4);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 15351, 15483);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15503, 15521);

                    f_69_15503_15520(
                                    Blocks, block);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 15277, 15536);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>.Builder
                    f_69_15420_15463(int
                    initialCapacity)
                    {
                        var return_v = ImmutableArray.CreateBuilder<BasicBlock>(initialCapacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 15420, 15463);
                        return return_v;
                    }


                    int
                    f_69_15503_15520(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>.Builder
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 15503, 15520);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 15277, 15536);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 15277, 15536);
                }
            }

            internal override void GetExceptionHandlerRegions(ArrayBuilder<Cci.ExceptionHandlerRegion> regions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 15552, 15966);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15684, 15951) || true) && (_nestedScopes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 15684, 15951);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15760, 15765);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15767, 15792);
                            for (int
        i = 0
        ,
        cnt = f_69_15773_15792(_nestedScopes)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15751, 15932) || true) && (i < cnt)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15803, 15806)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(69, 15751, 15932))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 15751, 15932);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 15856, 15909);

                                f_69_15856_15908(f_69_15856_15872(_nestedScopes, i), regions);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 182);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 182);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 15684, 15951);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 15552, 15966);

                    int
                    f_69_15773_15792(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 15773, 15792);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_15856_15872(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 15856, 15872);
                        return return_v;
                    }


                    int
                    f_69_15856_15908(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExceptionHandlerRegion>
                    regions)
                    {
                        this_param.GetExceptionHandlerRegions(regions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 15856, 15908);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 15552, 15966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 15552, 15966);
                }
            }

            internal override ScopeBounds GetLocalScopes(ArrayBuilder<Cci.LocalScope> result)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 15982, 17871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16096, 16121);

                    int
                    begin = int.MaxValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16139, 16151);

                    int
                    end = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16329, 16822) || true) && (Blocks != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 16329, 16822);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16398, 16403);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16389, 16803) || true) && (i < f_69_16409_16421(Blocks))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16423, 16426)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(69, 16389, 16803))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 16389, 16803);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16476, 16498);

                                var
                                block = f_69_16488_16497(Blocks, i)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16526, 16780) || true) && (block.Reachability != Reachability.NotReachable)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 16526, 16780);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16635, 16672);

                                    begin = f_69_16643_16671(begin, block.Start);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16702, 16753);

                                    end = f_69_16708_16752(end, block.Start + f_69_16736_16751(block));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(69, 16526, 16780);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 415);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 415);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 16329, 16822);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 16970, 17247) || true) && (_nestedScopes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 16970, 17247);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 17037, 17102);

                        ScopeBounds
                        nestedBounds = f_69_17064_17101(result, _nestedScopes)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 17124, 17168);

                        begin = f_69_17132_17167(begin, nestedBounds.Begin);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 17190, 17228);

                        end = f_69_17196_17227(end, nestedBounds.End);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 16970, 17247);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 17357, 17801) || true) && ((_localVariables != null || (DynAbs.Tracing.TraceSender.Expression_False(69, 17362, 17412) || _localConstants != null)) && (DynAbs.Tracing.TraceSender.Expression_True(69, 17361, 17428) && end > begin))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 17357, 17801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 17470, 17737);

                        var
                        newScope = f_69_17485_17736(begin, end, f_69_17592_17650(_localConstants), f_69_17677_17735(_localVariables))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 17761, 17782);

                        f_69_17761_17781(
                                            result, newScope);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 17357, 17801);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 17821, 17856);

                    return f_69_17828_17855(begin, end);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 15982, 17871);

                    int
                    f_69_16409_16421(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 16409, 16421);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_69_16488_16497(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 16488, 16497);
                        return return_v;
                    }


                    int
                    f_69_16643_16671(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 16643, 16671);
                        return return_v;
                    }


                    int
                    f_69_16736_16751(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.TotalSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 16736, 16751);
                        return return_v;
                    }


                    int
                    f_69_16708_16752(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 16708, 16752);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_17064_17101(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>.Builder
                    scopes)
                    {
                        var return_v = GetLocalScopes(result, scopes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 17064, 17101);
                        return return_v;
                    }


                    int
                    f_69_17132_17167(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 17132, 17167);
                        return return_v;
                    }


                    int
                    f_69_17196_17227(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 17196, 17227);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                    f_69_17592_17650(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalConstantDefinition>.Builder
                    items)
                    {
                        var return_v = items.AsImmutableOrEmpty<Microsoft.Cci.ILocalDefinition>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 17592, 17650);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                    f_69_17677_17735(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.LocalDefinition>.Builder?
                    items)
                    {
                        var return_v = items.AsImmutableOrEmpty<Microsoft.Cci.ILocalDefinition>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 17677, 17735);
                        return return_v;
                    }


                    Microsoft.Cci.LocalScope
                    f_69_17485_17736(int
                    offset, int
                    endOffset, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                    constants, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ILocalDefinition>
                    locals)
                    {
                        var return_v = new Microsoft.Cci.LocalScope(offset, endOffset, constants, locals);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 17485, 17736);
                        return return_v;
                    }


                    int
                    f_69_17761_17781(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    this_param, Microsoft.Cci.LocalScope
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 17761, 17781);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_17828_17855(int
                    begin, int
                    end)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds(begin, end);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 17828, 17855);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 15982, 17871);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 15982, 17871);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ScopeBounds GetHoistedLocalScopes(ArrayBuilder<StateMachineHoistedLocalScope> result)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 17887, 19938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18023, 18048);

                    int
                    begin = int.MaxValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18066, 18078);

                    int
                    end = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18256, 18749) || true) && (Blocks != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 18256, 18749);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18325, 18330);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18316, 18730) || true) && (i < f_69_18336_18348(Blocks))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18350, 18353)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(69, 18316, 18730))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 18316, 18730);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18403, 18425);

                                var
                                block = f_69_18415_18424(Blocks, i)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18453, 18707) || true) && (block.Reachability != Reachability.NotReachable)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 18453, 18707);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18562, 18599);

                                    begin = f_69_18570_18598(begin, block.Start);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18629, 18680);

                                    end = f_69_18635_18679(end, block.Start + f_69_18663_18678(block));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(69, 18453, 18707);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 415);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 415);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 18256, 18749);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18897, 19181) || true) && (_nestedScopes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 18897, 19181);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 18964, 19036);

                        ScopeBounds
                        nestedBounds = f_69_18991_19035(result, _nestedScopes)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 19058, 19102);

                        begin = f_69_19066_19101(begin, nestedBounds.Begin);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 19124, 19162);

                        end = f_69_19130_19161(end, nestedBounds.End);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 18897, 19181);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 19291, 19868) || true) && (_stateMachineUserHoistedLocalSlotIndices != null && (DynAbs.Tracing.TraceSender.Expression_True(69, 19295, 19358) && end > begin))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 19291, 19868);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 19400, 19461);

                        var
                        newScope = f_69_19415_19460(begin, end)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 19485, 19849);
                            foreach (var slotIndex in f_69_19511_19551_I(_stateMachineUserHoistedLocalSlotIndices))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 19485, 19849);
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 19601, 19769) || true) && (f_69_19608_19620(result) <= slotIndex)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 19601, 19769);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 19691, 19742);

                                        f_69_19691_19741(result, default(StateMachineHoistedLocalScope));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 19601, 19769);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 19601, 19769);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(69, 19601, 19769);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 19797, 19826);

                                result[slotIndex] = newScope;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(69, 19485, 19849);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 365);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 365);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 19291, 19868);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 19888, 19923);

                    return f_69_19895_19922(begin, end);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 17887, 19938);

                    int
                    f_69_18336_18348(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 18336, 18348);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_69_18415_18424(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 18415, 18424);
                        return return_v;
                    }


                    int
                    f_69_18570_18598(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 18570, 18598);
                        return return_v;
                    }


                    int
                    f_69_18663_18678(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        var return_v = this_param.TotalSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 18663, 18678);
                        return return_v;
                    }


                    int
                    f_69_18635_18679(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 18635, 18679);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_18991_19035(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                    result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>.Builder
                    scopes)
                    {
                        var return_v = GetHoistedLocalScopes(result, scopes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 18991, 19035);
                        return return_v;
                    }


                    int
                    f_69_19066_19101(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 19066, 19101);
                        return return_v;
                    }


                    int
                    f_69_19130_19161(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Max(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 19130, 19161);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope
                    f_69_19415_19460(int
                    startOffset, int
                    endOffset)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope(startOffset, endOffset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 19415, 19460);
                        return return_v;
                    }


                    int
                    f_69_19608_19620(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 19608, 19620);
                        return return_v;
                    }


                    int
                    f_69_19691_19741(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                    this_param, Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 19691, 19741);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<int>.Builder
                    f_69_19511_19551_I(System.Collections.Immutable.ImmutableArray<int>.Builder
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 19511, 19551);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_19895_19922(int
                    begin, int
                    end)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds(begin, end);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 19895, 19922);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 17887, 19938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 17887, 19938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override void FreeBasicBlocks()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 19954, 20526);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20025, 20242) || true) && (Blocks != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 20025, 20242);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20094, 20099);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20101, 20119);
                            for (int
        i = 0
        ,
        cnt = f_69_20107_20119(Blocks)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20085, 20223) || true) && (i < cnt)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20130, 20133)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(69, 20085, 20223))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 20085, 20223);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20183, 20200);

                                f_69_20183_20199(f_69_20183_20192(Blocks, i));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 139);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 139);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 20025, 20242);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20262, 20511) || true) && (_nestedScopes != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 20262, 20511);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20338, 20343);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20345, 20370);
                            for (int
        i = 0
        ,
        cnt = f_69_20351_20370(_nestedScopes)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20329, 20492) || true) && (i < cnt)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20381, 20384)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(69, 20329, 20492))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 20329, 20492);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20434, 20469);

                                f_69_20434_20468(f_69_20434_20450(_nestedScopes, i));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 164);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 164);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 20262, 20511);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 19954, 20526);

                    int
                    f_69_20107_20119(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 20107, 20119);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_69_20183_20192(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 20183, 20192);
                        return return_v;
                    }


                    int
                    f_69_20183_20199(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 20183, 20199);
                        return 0;
                    }


                    int
                    f_69_20351_20370(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 20351, 20370);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    f_69_20434_20450(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 20434, 20450);
                        return return_v;
                    }


                    int
                    f_69_20434_20468(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeInfo
                    this_param)
                    {
                        this_param.FreeBasicBlocks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 20434, 20468);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 19954, 20526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 19954, 20526);
                }
            }

            public LocalScopeInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(69, 11706, 20537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 11820, 11835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 11906, 11921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 11972, 12012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 12198, 12211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 12271, 12277);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(69, 11706, 20537);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 11706, 20537);
            }


            static LocalScopeInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(69, 11706, 20537);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(69, 11706, 20537);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 11706, 20537);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(69, 11706, 20537);
        }
        internal sealed class ExceptionHandlerScope : LocalScopeInfo
        {
            private readonly ExceptionHandlerContainerScope _containingScope;

            private readonly ScopeType _type;

            private readonly Microsoft.Cci.ITypeReference _exceptionType;

            private BasicBlock _lastFilterConditionBlock;

            private object _blockedByFinallyDestination;

            public ExceptionHandlerScope(ExceptionHandlerContainerScope containingScope, ScopeType type, Microsoft.Cci.ITypeReference exceptionType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(69, 21748, 22309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20867, 20883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20925, 20930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 20991, 21005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 21041, 21066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 21703, 21731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 21917, 22074);

                    f_69_21917_22073((type == ScopeType.Try) || (DynAbs.Tracing.TraceSender.Expression_False(69, 21930, 21982) || (type == ScopeType.Catch)) || (DynAbs.Tracing.TraceSender.Expression_False(69, 21930, 22012) || (type == ScopeType.Filter)) || (DynAbs.Tracing.TraceSender.Expression_False(69, 21930, 22043) || (type == ScopeType.Finally)) || (DynAbs.Tracing.TraceSender.Expression_False(69, 21930, 22072) || (type == ScopeType.Fault)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 22092, 22159);

                    f_69_22092_22158((type == ScopeType.Catch) == (exceptionType != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 22179, 22214);

                    _containingScope = containingScope;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 22232, 22245);

                    _type = type;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 22263, 22294);

                    _exceptionType = exceptionType;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(69, 21748, 22309);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 21748, 22309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 21748, 22309);
                }
            }

            public ExceptionHandlerContainerScope ContainingExceptionScope
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 22388, 22407);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 22391, 22407);
                        return _containingScope; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 22388, 22407);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 22388, 22407);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 22388, 22407);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ScopeType Type
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 22455, 22463);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 22458, 22463);
                        return _type; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 22455, 22463);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 22455, 22463);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 22455, 22463);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public Microsoft.Cci.ITypeReference ExceptionType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 22530, 22547);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 22533, 22547);
                        return _exceptionType; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 22530, 22547);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 22530, 22547);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 22530, 22547);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void SetBlockedByFinallyDestination(object label)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 22845, 22986);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 22934, 22971);

                    _blockedByFinallyDestination = label;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 22845, 22986);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 22845, 22986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 22845, 22986);
                }
            }

            public object BlockedByFinallyDestination
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 23218, 23249);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 23221, 23249);
                        return _blockedByFinallyDestination; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 23218, 23249);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 23218, 23249);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 23218, 23249);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public void UnblockFinally()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 23335, 23447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 23396, 23432);

                    _blockedByFinallyDestination = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 23335, 23447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 23335, 23447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 23335, 23447);
                }
            }

            public int FilterHandlerStart
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 23510, 23582);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 23513, 23582);
                        return _lastFilterConditionBlock.Start + f_69_23547_23582(_lastFilterConditionBlock); DynAbs.Tracing.TraceSender.TraceExitMethod(69, 23510, 23582);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 23510, 23582);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 23510, 23582);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override void FinishFilterCondition(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 23599, 23894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 23693, 23733);

                    f_69_23693_23732(_type == ScopeType.Filter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 23751, 23799);

                    f_69_23751_23798(_lastFilterConditionBlock == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 23819, 23879);

                    _lastFilterConditionBlock = f_69_23847_23878(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 23599, 23894);

                    int
                    f_69_23693_23732(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 23693, 23732);
                        return 0;
                    }


                    int
                    f_69_23751_23798(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 23751, 23798);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
                    f_69_23847_23878(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    this_param)
                    {
                        var return_v = this_param.FinishFilterCondition();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 23847, 23878);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 23599, 23894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 23599, 23894);
                }
            }

            public override void ClosingScope(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 23910, 24730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 23995, 24715);

                    switch (_type)
                    {

                        case ScopeType.Finally:
                        case ScopeType.Fault:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 23995, 24715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 24223, 24248);

                            f_69_24223_24247(                        // Emit endfinally|endfault - they are the same opcode.
                                                    builder);
                            DynAbs.Tracing.TraceSender.TraceBreak(69, 24274, 24280);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 23995, 24715);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 23995, 24715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 24496, 24537);

                            var
                            endLabel = f_69_24511_24536(_containingScope)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 24563, 24594);

                            f_69_24563_24593(endLabel != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 24622, 24664);

                            f_69_24622_24663(
                                                    builder, ILOpCode.Br, endLabel);
                            DynAbs.Tracing.TraceSender.TraceBreak(69, 24690, 24696);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 23995, 24715);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 23910, 24730);

                    int
                    f_69_24223_24247(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    this_param)
                    {
                        this_param.EmitEndFinally();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 24223, 24247);
                        return 0;
                    }


                    object
                    f_69_24511_24536(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                    this_param)
                    {
                        var return_v = this_param.EndLabel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 24511, 24536);
                        return return_v;
                    }


                    int
                    f_69_24563_24593(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 24563, 24593);
                        return 0;
                    }


                    int
                    f_69_24622_24663(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    this_param, System.Reflection.Metadata.ILOpCode
                    code, object
                    label)
                    {
                        this_param.EmitBranch(code, label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 24622, 24663);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 23910, 24730);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 23910, 24730);
                }
            }

            public override void CloseScope(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 24746, 24878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 24829, 24863);

                    f_69_24829_24862(f_69_24842_24853() != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 24746, 24878);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                    f_69_24842_24853()
                    {
                        var return_v = LeaderBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 24842, 24853);
                        return return_v;
                    }


                    int
                    f_69_24829_24862(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 24829, 24862);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 24746, 24878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 24746, 24878);
                }
            }

            public override BasicBlock CreateBlock(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 24894, 25335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 24984, 25040);

                    f_69_24984_25039(f_69_24997_25030(builder) == this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25058, 25253);

                    var
                    block = (DynAbs.Tracing.TraceSender.Conditional_F1(69, 25070, 25086) || (((Blocks == null) && DynAbs.Tracing.TraceSender.Conditional_F2(69, 25110, 25183)) || DynAbs.Tracing.TraceSender.Conditional_F3(69, 25207, 25252))) ? f_69_25110_25183(builder, this, f_69_25157_25182(this)) : f_69_25207_25252(builder, this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25273, 25289);

                    f_69_25273_25288(this, block);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25307, 25320);

                    return block;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 24894, 25335);

                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_24997_25030(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    this_param)
                    {
                        var return_v = this_param.EnclosingExceptionHandler;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 24997, 25030);
                        return return_v;
                    }


                    int
                    f_69_24984_25039(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 24984, 25039);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BlockType
                    f_69_25157_25182(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.GetLeaderBlockType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 25157, 25182);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                    f_69_25110_25183(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    enclosingHandler, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BlockType
                    type)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock(builder, enclosingHandler, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 25110, 25183);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlockWithHandlerScope
                    f_69_25207_25252(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    builder, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    enclosingHandler)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlockWithHandlerScope(builder, enclosingHandler);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 25207, 25252);
                        return return_v;
                    }


                    int
                    f_69_25273_25288(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlockWithHandlerScope
                    block)
                    {
                        this_param.AddBlock((Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock)block);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 25273, 25288);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 24894, 25335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 24894, 25335);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ExceptionHandlerLeaderBlock LeaderBlock
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 25398, 25440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25401, 25440);
                        return (ExceptionHandlerLeaderBlock)f_69_25430_25440_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(Blocks, 69, 25430, 25440)?[0]); DynAbs.Tracing.TraceSender.TraceExitMethod(69, 25398, 25440);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 25398, 25440);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 25398, 25440);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private BlockType GetLeaderBlockType()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 25457, 26044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25528, 26029);

                    switch (_type)
                    {

                        case ScopeType.Try:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 25528, 26029);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25628, 25649);

                            return BlockType.Try;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 25528, 26029);

                        case ScopeType.Catch:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 25528, 26029);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25718, 25741);

                            return BlockType.Catch;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 25528, 26029);

                        case ScopeType.Filter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 25528, 26029);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25811, 25835);

                            return BlockType.Filter;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 25528, 26029);

                        case ScopeType.Finally:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 25528, 26029);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25906, 25931);

                            return BlockType.Finally;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 25528, 26029);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 25528, 26029);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 25987, 26010);

                            return BlockType.Fault;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 25528, 26029);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 25457, 26044);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 25457, 26044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 25457, 26044);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override void FreeBasicBlocks()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 26060, 26169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 26131, 26154);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.FreeBasicBlocks(), 69, 26131, 26153);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 26060, 26169);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 26060, 26169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 26060, 26169);
                }
            }

            static ExceptionHandlerScope()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(69, 20734, 26180);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(69, 20734, 26180);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 20734, 26180);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(69, 20734, 26180);

            static int
            f_69_21917_22073(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 21917, 22073);
                return 0;
            }


            static int
            f_69_22092_22158(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 22092, 22158);
                return 0;
            }


            int
            f_69_23547_23582(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock
            this_param)
            {
                var return_v = this_param.TotalSize;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 23547, 23582);
                return return_v;
            }


            Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
            f_69_25430_25440_M(Microsoft.CodeAnalysis.CodeGen.ILBuilder.BasicBlock?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 25430, 25440);
                return return_v;
            }

        }
        internal sealed class ExceptionHandlerContainerScope : ScopeInfo
        {
            private readonly ImmutableArray<ExceptionHandlerScope>.Builder _handlers;

            private readonly object _endLabel;

            private readonly ExceptionHandlerScope _containingHandler;

            public ExceptionHandlerContainerScope(ExceptionHandlerScope containingHandler)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(69, 26846, 27139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 26700, 26709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 26748, 26757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 26811, 26829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 26957, 27024);

                    _handlers = f_69_26969_27023(2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 27042, 27081);

                    _containingHandler = containingHandler;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 27099, 27124);

                    _endLabel = f_69_27111_27123();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(69, 26846, 27139);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 26846, 27139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 26846, 27139);
                }
            }

            public ExceptionHandlerScope ContainingHandler
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 27202, 27223);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 27205, 27223);
                        return _containingHandler; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 27202, 27223);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 27202, 27223);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 27202, 27223);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public object EndLabel
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 27263, 27275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 27266, 27275);
                        return _endLabel; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 27263, 27275);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 27263, 27275);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 27263, 27275);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ScopeType Type
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 27323, 27351);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 27326, 27351);
                        return ScopeType.TryCatchFinally; DynAbs.Tracing.TraceSender.TraceExitMethod(69, 27323, 27351);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 27323, 27351);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 27323, 27351);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ScopeInfo OpenScope(ScopeType scopeType,
                            Microsoft.Cci.ITypeReference exceptionType,
                            ExceptionHandlerScope currentExceptionHandler)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 27368, 28103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 27582, 27842);

                    f_69_27582_27841(((f_69_27597_27612(_handlers) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(69, 27596, 27650) && (scopeType == ScopeType.Try))) || (DynAbs.Tracing.TraceSender.Expression_False(69, 27595, 27840) || ((f_69_27678_27693(_handlers) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(69, 27677, 27839) && ((scopeType == ScopeType.Catch) || (DynAbs.Tracing.TraceSender.Expression_False(69, 27703, 27768) || (scopeType == ScopeType.Filter)) || (DynAbs.Tracing.TraceSender.Expression_False(69, 27703, 27804) || (scopeType == ScopeType.Finally)) || (DynAbs.Tracing.TraceSender.Expression_False(69, 27703, 27838) || (scopeType == ScopeType.Fault)))))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 27862, 27922);

                    f_69_27862_27921(currentExceptionHandler == _containingHandler);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 27942, 28014);

                    var
                    handler = f_69_27956_28013(this, scopeType, exceptionType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28032, 28055);

                    f_69_28032_28054(_handlers, handler);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28073, 28088);

                    return handler;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 27368, 28103);

                    int
                    f_69_27597_27612(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 27597, 27612);
                        return return_v;
                    }


                    int
                    f_69_27678_27693(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 27678, 27693);
                        return return_v;
                    }


                    int
                    f_69_27582_27841(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 27582, 27841);
                        return 0;
                    }


                    int
                    f_69_27862_27921(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 27862, 27921);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_27956_28013(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope
                    containingScope, Microsoft.CodeAnalysis.CodeGen.ScopeType
                    type, Microsoft.Cci.ITypeReference
                    exceptionType)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope(containingScope, type, exceptionType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 27956, 28013);
                        return return_v;
                    }


                    int
                    f_69_28032_28054(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param, Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 28032, 28054);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 27368, 28103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 27368, 28103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override void CloseScope(ILBuilder builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 28119, 29801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28202, 28236);

                    f_69_28202_28235(f_69_28215_28230(_handlers) > 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28340, 28368);

                    var
                    tryScope = f_69_28355_28367(_handlers, 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28386, 28427);

                    var
                    previousBlock = f_69_28406_28426(tryScope)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28456, 28461);

                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28447, 28762) || true) && (i < f_69_28467_28482(_handlers))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28484, 28487)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(69, 28447, 28762))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 28447, 28762);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28529, 28561);

                            var
                            handlerScope = f_69_28548_28560(_handlers, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28583, 28624);

                            var
                            nextBlock = f_69_28599_28623(handlerScope)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28648, 28695);

                            previousBlock.NextExceptionHandler = nextBlock;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28717, 28743);

                            previousBlock = nextBlock;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 316);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 316);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28847, 28876);

                    f_69_28847_28875(
                                    // Generate label for try/catch "leave" target.
                                    builder, _endLabel);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 28992, 29028);

                    f_69_28992_29027(
                                    // hide the following code, since it could be reached through the label above.
                                    builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 29048, 29121);

                    f_69_29048_29120(builder._currentBlock == builder._labelInfos[_endLabel].bb);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 29141, 29786) || true) && (f_69_29145_29162(f_69_29145_29157(_handlers, 1)) == ScopeType.Finally)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 29141, 29786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 29644, 29688);

                        f_69_29644_29687(                    // Generate "nop" branch to itself. If this block is unreachable
                                                             // (because the finally block does not complete), the "nop" will be
                                                             // replaced by Br_s. On the other hand, if this block is reachable,
                                                             // the "nop" will be skipped so any "leave" instructions jumping
                                                             // to this block will jump to the next instead.
                                            builder, ILOpCode.Nop, _endLabel);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 29712, 29767);

                        f_69_29712_29766(f_69_29712_29724(_handlers, 1), _endLabel);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 29141, 29786);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 28119, 29801);

                    int
                    f_69_28215_28230(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 28215, 28230);
                        return return_v;
                    }


                    int
                    f_69_28202_28235(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 28202, 28235);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_28355_28367(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 28355, 28367);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                    f_69_28406_28426(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.LeaderBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 28406, 28426);
                        return return_v;
                    }


                    int
                    f_69_28467_28482(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 28467, 28482);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_28548_28560(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 28548, 28560);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                    f_69_28599_28623(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.LeaderBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 28599, 28623);
                        return return_v;
                    }


                    int
                    f_69_28847_28875(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    this_param, object
                    label)
                    {
                        this_param.MarkLabel(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 28847, 28875);
                        return 0;
                    }


                    int
                    f_69_28992_29027(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    this_param)
                    {
                        this_param.DefineHiddenSequencePoint();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 28992, 29027);
                        return 0;
                    }


                    int
                    f_69_29048_29120(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 29048, 29120);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_29145_29157(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 29145, 29157);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ScopeType
                    f_69_29145_29162(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 29145, 29162);
                        return return_v;
                    }


                    int
                    f_69_29644_29687(Microsoft.CodeAnalysis.CodeGen.ILBuilder
                    this_param, System.Reflection.Metadata.ILOpCode
                    code, object
                    label)
                    {
                        this_param.EmitBranch(code, label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 29644, 29687);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_29712_29724(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 29712, 29724);
                        return return_v;
                    }


                    int
                    f_69_29712_29766(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param, object
                    label)
                    {
                        this_param.SetBlockedByFinallyDestination(label);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 29712, 29766);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 28119, 29801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 28119, 29801);
                }
            }

            internal override void GetExceptionHandlerRegions(ArrayBuilder<Cci.ExceptionHandlerRegion> regions)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 29817, 33094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 29949, 29983);

                    f_69_29949_29982(f_69_29962_29977(_handlers) > 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 30003, 30041);

                    ExceptionHandlerScope
                    tryScope = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 30059, 30101);

                    ScopeBounds
                    tryBounds = f_69_30083_30100()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 30121, 33079);
                        foreach (var handlerScope in f_69_30150_30159_I(_handlers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 30121, 33079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 30585, 30634);

                            f_69_30585_30633(                    // Partition I, section 12.4.2.5:
                                                                 // The ordering of the exception clauses in the Exception Handler Table is important. If handlers are nested, 
                                                                 // the most deeply nested try blocks shall come before the try blocks that enclose them.
                                                                 //
                                                                 // so we collect the inner regions first.
                                                handlerScope, regions);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 30658, 30702);

                            var
                            handlerBounds = f_69_30678_30701(handlerScope)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 30726, 33060) || true) && (tryScope == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 30726, 33060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 30867, 30916);

                                f_69_30867_30915(f_69_30880_30897(handlerScope) == ScopeType.Try);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 30944, 30968);

                                tryScope = handlerScope;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 30994, 31020);

                                tryBounds = handlerBounds;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 31048, 31101);

                                var
                                reachability = f_69_31067_31087(tryScope).Reachability
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 31127, 31229);

                                f_69_31127_31228((reachability == Reachability.Reachable) || (DynAbs.Tracing.TraceSender.Expression_False(69, 31140, 31227) || (reachability == Reachability.NotReachable)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 31335, 31414);

                                f_69_31335_31413(f_69_31348_31412(_handlers, h => (h.LeaderBlock.Reachability == reachability)));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 31442, 31576) || true) && (reachability != Reachability.Reachable)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 31442, 31576);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 31542, 31549);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(69, 31442, 31576);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(69, 30726, 33060);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 30726, 33060);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 31674, 31708);

                                Cci.ExceptionHandlerRegion
                                region
                                = default(Cci.ExceptionHandlerRegion);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 31734, 32989);

                                switch (f_69_31742_31759(handlerScope))
                                {

                                    case ScopeType.Finally:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 31734, 32989);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 31874, 31993);

                                        region = f_69_31883_31992(tryBounds.Begin, tryBounds.End, handlerBounds.Begin, handlerBounds.End);
                                        DynAbs.Tracing.TraceSender.TraceBreak(69, 32027, 32033);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 31734, 32989);

                                    case ScopeType.Fault:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 31734, 32989);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 32120, 32237);

                                        region = f_69_32129_32236(tryBounds.Begin, tryBounds.End, handlerBounds.Begin, handlerBounds.End);
                                        DynAbs.Tracing.TraceSender.TraceBreak(69, 32271, 32277);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 31734, 32989);

                                    case ScopeType.Catch:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 31734, 32989);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 32364, 32509);

                                        region = f_69_32373_32508(tryBounds.Begin, tryBounds.End, handlerBounds.Begin, handlerBounds.End, f_69_32481_32507(handlerScope));
                                        DynAbs.Tracing.TraceSender.TraceBreak(69, 32543, 32549);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 31734, 32989);

                                    case ScopeType.Filter:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 31734, 32989);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 32637, 32788);

                                        region = f_69_32646_32787(tryBounds.Begin, tryBounds.End, f_69_32715_32746(handlerScope), handlerBounds.End, handlerBounds.Begin);
                                        DynAbs.Tracing.TraceSender.TraceBreak(69, 32822, 32828);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 31734, 32989);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 31734, 32989);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 32902, 32962);

                                        throw f_69_32908_32961(f_69_32943_32960(handlerScope));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(69, 31734, 32989);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 33017, 33037);

                                f_69_33017_33036(
                                                        regions, region);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(69, 30726, 33060);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 30121, 33079);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 2959);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 2959);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 29817, 33094);

                    int
                    f_69_29962_29977(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 29962, 29977);
                        return return_v;
                    }


                    int
                    f_69_29949_29982(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 29949, 29982);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_30083_30100()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 30083, 30100);
                        return return_v;
                    }


                    int
                    f_69_30585_30633(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExceptionHandlerRegion>
                    regions)
                    {
                        this_param.GetExceptionHandlerRegions(regions);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 30585, 30633);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_30678_30701(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    scope)
                    {
                        var return_v = GetBounds(scope);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 30678, 30701);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ScopeType
                    f_69_30880_30897(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 30880, 30897);
                        return return_v;
                    }


                    int
                    f_69_30867_30915(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 30867, 30915);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerLeaderBlock
                    f_69_31067_31087(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.LeaderBlock;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 31067, 31087);
                        return return_v;
                    }


                    int
                    f_69_31127_31228(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 31127, 31228);
                        return 0;
                    }


                    bool
                    f_69_31348_31412(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    source, System.Func<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope, bool>
                    predicate)
                    {
                        var return_v = source.All<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 31348, 31412);
                        return return_v;
                    }


                    int
                    f_69_31335_31413(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 31335, 31413);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ScopeType
                    f_69_31742_31759(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 31742, 31759);
                        return return_v;
                    }


                    Microsoft.Cci.ExceptionHandlerRegionFinally
                    f_69_31883_31992(int
                    tryStartOffset, int
                    tryEndOffset, int
                    handlerStartOffset, int
                    handlerEndOffset)
                    {
                        var return_v = new Microsoft.Cci.ExceptionHandlerRegionFinally(tryStartOffset, tryEndOffset, handlerStartOffset, handlerEndOffset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 31883, 31992);
                        return return_v;
                    }


                    Microsoft.Cci.ExceptionHandlerRegionFault
                    f_69_32129_32236(int
                    tryStartOffset, int
                    tryEndOffset, int
                    handlerStartOffset, int
                    handlerEndOffset)
                    {
                        var return_v = new Microsoft.Cci.ExceptionHandlerRegionFault(tryStartOffset, tryEndOffset, handlerStartOffset, handlerEndOffset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 32129, 32236);
                        return return_v;
                    }


                    Microsoft.Cci.ITypeReference
                    f_69_32481_32507(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.ExceptionType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 32481, 32507);
                        return return_v;
                    }


                    Microsoft.Cci.ExceptionHandlerRegionCatch
                    f_69_32373_32508(int
                    tryStartOffset, int
                    tryEndOffset, int
                    handlerStartOffset, int
                    handlerEndOffset, Microsoft.Cci.ITypeReference
                    exceptionType)
                    {
                        var return_v = new Microsoft.Cci.ExceptionHandlerRegionCatch(tryStartOffset, tryEndOffset, handlerStartOffset, handlerEndOffset, exceptionType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 32373, 32508);
                        return return_v;
                    }


                    int
                    f_69_32715_32746(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.FilterHandlerStart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 32715, 32746);
                        return return_v;
                    }


                    Microsoft.Cci.ExceptionHandlerRegionFilter
                    f_69_32646_32787(int
                    tryStartOffset, int
                    tryEndOffset, int
                    handlerStartOffset, int
                    handlerEndOffset, int
                    filterDecisionStartOffset)
                    {
                        var return_v = new Microsoft.Cci.ExceptionHandlerRegionFilter(tryStartOffset, tryEndOffset, handlerStartOffset, handlerEndOffset, filterDecisionStartOffset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 32646, 32787);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ScopeType
                    f_69_32943_32960(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 32943, 32960);
                        return return_v;
                    }


                    System.Exception
                    f_69_32908_32961(Microsoft.CodeAnalysis.CodeGen.ScopeType
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 32908, 32961);
                        return return_v;
                    }


                    int
                    f_69_33017_33036(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExceptionHandlerRegion>
                    this_param, Microsoft.Cci.ExceptionHandlerRegion
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 33017, 33036);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    f_69_30150_30159_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 30150, 30159);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 29817, 33094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 29817, 33094);
                }
            }

            internal override ScopeBounds GetLocalScopes(ArrayBuilder<Cci.LocalScope> scopesWithVariables)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 33222, 33271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 33225, 33271);
                    return f_69_33225_33271(scopesWithVariables, _handlers); DynAbs.Tracing.TraceSender.TraceExitMethod(69, 33222, 33271);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 33222, 33271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 33222, 33271);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                f_69_33225_33271(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                scopes)
                {
                    var return_v = GetLocalScopes(result, scopes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 33225, 33271);
                    return return_v;
                }

            }

            internal override ScopeBounds GetHoistedLocalScopes(ArrayBuilder<StateMachineHoistedLocalScope> result)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 33409, 33452);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 33412, 33452);
                    return f_69_33412_33452(result, _handlers); DynAbs.Tracing.TraceSender.TraceExitMethod(69, 33409, 33452);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 33409, 33452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 33409, 33452);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                f_69_33412_33452(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Debugging.StateMachineHoistedLocalScope>
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                scopes)
                {
                    var return_v = GetHoistedLocalScopes(result, scopes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 33412, 33452);
                    return return_v;
                }

            }

            private static ScopeBounds GetBounds(ExceptionHandlerScope scope)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(69, 33469, 33762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 33567, 33623);

                    var
                    scopes = f_69_33580_33622()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 33641, 33683);

                    var
                    result = f_69_33654_33682(scope, scopes)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 33701, 33715);

                    f_69_33701_33714(scopes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 33733, 33747);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(69, 33469, 33762);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    f_69_33580_33622()
                    {
                        var return_v = ArrayBuilder<Cci.LocalScope>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 33580, 33622);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeBounds
                    f_69_33654_33682(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    result)
                    {
                        var return_v = this_param.GetLocalScopes(result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 33654, 33682);
                        return return_v;
                    }


                    int
                    f_69_33701_33714(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.LocalScope>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 33701, 33714);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 33469, 33762);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 33469, 33762);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override void FreeBasicBlocks()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 33778, 34039);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 33908, 34024);
                        foreach (var scope in f_69_33930_33939_I(_handlers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 33908, 34024);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 33981, 34005);

                            f_69_33981_34004(scope);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(69, 33908, 34024);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 1, 117);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(69, 1, 117);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 33778, 34039);

                    int
                    f_69_33981_34004(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        this_param.FreeBasicBlocks();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 33981, 34004);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    f_69_33930_33939_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 33930, 33939);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 33778, 34039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 33778, 34039);
                }
            }

            internal bool FinallyOnly()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 34055, 34790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 34115, 34135);

                    var
                    curScope = this
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 34153, 34743);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 34196, 34230);

                                var
                                handlers = curScope._handlers
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 34442, 34592) || true) && (f_69_34446_34460(handlers) != 2 || (DynAbs.Tracing.TraceSender.Expression_False(69, 34446, 34506) || f_69_34469_34485(f_69_34469_34480(handlers, 1)) != ScopeType.Finally))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(69, 34442, 34592);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 34556, 34569);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(69, 34442, 34592);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 34616, 34681);

                                curScope = f_69_34627_34680_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(curScope._containingHandler, 69, 34627, 34680)?.ContainingExceptionScope);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(69, 34153, 34743);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 34153, 34743) || true) && (curScope != null)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(69, 34153, 34743);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(69, 34153, 34743);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 34763, 34775);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 34055, 34790);

                    int
                    f_69_34446_34460(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 34446, 34460);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    f_69_34469_34480(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 34469, 34480);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ScopeType
                    f_69_34469_34485(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 34469, 34485);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope?
                    f_69_34627_34680_M(Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerContainerScope?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(69, 34627, 34680);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 34055, 34790);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 34055, 34790);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ExceptionHandlerContainerScope()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(69, 26548, 34801);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(69, 26548, 34801);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 26548, 34801);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(69, 26548, 34801);

            static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.ILBuilder.ExceptionHandlerScope>.Builder
            f_69_26969_27023(int
            initialCapacity)
            {
                var return_v = ImmutableArray.CreateBuilder<ExceptionHandlerScope>(initialCapacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 26969, 27023);
                return return_v;
            }


            static object
            f_69_27111_27123()
            {
                var return_v = new object();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 27111, 27123);
                return return_v;
            }

        }

        internal struct ScopeBounds
        {

            internal readonly int Begin;

            internal readonly int End;

            internal ScopeBounds(int begin, int end)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(69, 34977, 35172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 35050, 35087);

                    f_69_35050_35086(begin >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(69, 35063, 35085) && end >= 0));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 35105, 35124);

                    this.Begin = begin;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 35142, 35157);

                    this.End = end;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(69, 34977, 35172);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 34977, 35172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 34977, 35172);
                }
            }
            static ScopeBounds()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(69, 34813, 35183);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(69, 34813, 35183);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 34813, 35183);
            }

            static int
            f_69_35050_35086(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 35050, 35086);
                return 0;
            }

        }
        private sealed class ScopeComparer : IComparer<Cci.LocalScope>
        {
            public static readonly ScopeComparer Instance;

            private ScopeComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(69, 35497, 35524);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(69, 35497, 35524);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 35497, 35524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 35497, 35524);
                }
            }

            public int Compare(Cci.LocalScope x, Cci.LocalScope y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(69, 35540, 35779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 35627, 35679);

                    var
                    result = f_69_35640_35678(x.StartOffset, y.StartOffset)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 35697, 35764);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(69, 35704, 35717) || (((result == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(69, 35720, 35754)) || DynAbs.Tracing.TraceSender.Conditional_F3(69, 35757, 35763))) ? f_69_35720_35754(y.EndOffset, x.EndOffset) : result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(69, 35540, 35779);

                    int
                    f_69_35640_35678(int
                    this_param, int
                    value)
                    {
                        var return_v = this_param.CompareTo(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 35640, 35678);
                        return return_v;
                    }


                    int
                    f_69_35720_35754(int
                    this_param, int
                    value)
                    {
                        var return_v = this_param.CompareTo(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 35720, 35754);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(69, 35540, 35779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 35540, 35779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ScopeComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(69, 35326, 35790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(69, 35450, 35480);
                Instance = f_69_35461_35480(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(69, 35326, 35790);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(69, 35326, 35790);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(69, 35326, 35790);

            static Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeComparer
            f_69_35461_35480()
            {
                var return_v = new Microsoft.CodeAnalysis.CodeGen.ILBuilder.ScopeComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(69, 35461, 35480);
                return return_v;
            }

        }
    }
}
