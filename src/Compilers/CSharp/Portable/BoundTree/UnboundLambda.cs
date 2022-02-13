// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal interface IBoundLambdaOrFunction
    {

        MethodSymbol Symbol { get; }

        SyntaxNode Syntax { get; }

        BoundBlock Body { get; }

        bool WasCompilerGenerated { get; }
    }
    internal sealed partial class BoundLocalFunctionStatement : IBoundLambdaOrFunction
    {
        MethodSymbol IBoundLambdaOrFunction.Symbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 996, 1018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 1002, 1016);

                    return f_10591_1009_1015();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 996, 1018);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalFunctionSymbol
                    f_10591_1009_1015()
                    {
                        var return_v = Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 1009, 1015);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 951, 1020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 951, 1020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        SyntaxNode IBoundLambdaOrFunction.Syntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 1075, 1097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 1081, 1095);

                    return Syntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 1075, 1097);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 1032, 1099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 1032, 1099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        BoundBlock IBoundLambdaOrFunction.Body
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 1156, 1168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 1159, 1168);
                    return f_10591_1159_1168(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 1156, 1168);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 1111, 1171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 1111, 1171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Microsoft.CodeAnalysis.CSharp.BoundBlock?
        f_10591_1159_1168(Microsoft.CodeAnalysis.CSharp.BoundLocalFunctionStatement
        this_param)
        {
            var return_v = this_param.Body;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 1159, 1168);
            return return_v;
        }

    }

    internal readonly struct InferredLambdaReturnType
    {

        internal readonly int NumExpressions;

        internal readonly bool HadExpressionlessReturn;

        internal readonly RefKind RefKind;

        internal readonly TypeWithAnnotations TypeWithAnnotations;

        internal readonly ImmutableArray<DiagnosticInfo> UseSiteDiagnostics;

        internal InferredLambdaReturnType(
                    int numExpressions,
                    bool hadExpressionlessReturn,
                    RefKind refKind,
                    TypeWithAnnotations typeWithAnnotations,
                    ImmutableArray<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10591, 1548, 2080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 1831, 1863);

                NumExpressions = numExpressions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 1877, 1927);

                HadExpressionlessReturn = hadExpressionlessReturn;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 1941, 1959);

                RefKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 1973, 2015);

                TypeWithAnnotations = typeWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 2029, 2069);

                UseSiteDiagnostics = useSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10591, 1548, 2080);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 1548, 2080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 1548, 2080);
            }
        }
        static InferredLambdaReturnType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10591, 1186, 2087);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10591, 1186, 2087);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 1186, 2087);
        }
    }
    internal sealed partial class BoundLambda : IBoundLambdaOrFunction
    {
        public MessageID MessageID
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 2207, 2326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 2213, 2324);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 2220, 2273) || ((f_10591_2220_2233(Syntax) == SyntaxKind.AnonymousMethodExpression && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 2276, 2300)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 2303, 2323))) ? MessageID.IDS_AnonMethod : MessageID.IDS_Lambda;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 2207, 2326);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10591_2220_2233(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 2220, 2233);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 2178, 2328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 2178, 2328);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal InferredLambdaReturnType InferredReturnType { get; private set; }

        MethodSymbol IBoundLambdaOrFunction.Symbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 2471, 2493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 2477, 2491);

                    return f_10591_2484_2490();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 2471, 2493);

                    Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                    f_10591_2484_2490()
                    {
                        var return_v = Symbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 2484, 2490);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 2426, 2495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 2426, 2495);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        SyntaxNode IBoundLambdaOrFunction.Syntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 2550, 2572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 2556, 2570);

                    return Syntax;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 2550, 2572);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 2507, 2574);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 2507, 2574);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public BoundLambda(SyntaxNode syntax, UnboundLambda unboundLambda, BoundBlock body, ImmutableArray<Diagnostic> diagnostics, Binder binder, TypeSymbol delegateType, InferredLambdaReturnType inferredReturnType)
        : this(f_10591_2815_2821_C(syntax), f_10591_2823_2850(unboundLambda), (LambdaSymbol)f_10591_2866_2897(binder), body, diagnostics, binder, delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10591, 2586, 3468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 2964, 3004);

                InferredReturnType = inferredReturnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 3020, 3457);

                f_10591_3020_3456(f_10591_3051_3079(syntax) || (DynAbs.Tracing.TraceSender.Expression_False(10591, 3051, 3279) || syntax is ExpressionSyntax && (DynAbs.Tracing.TraceSender.Expression_True(10591, 3186, 3279) && f_10591_3216_3279(syntax, allowReducedLambdas: true))) || (DynAbs.Tracing.TraceSender.Expression_False(10591, 3051, 3358) || f_10591_3317_3358(syntax)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10591, 2586, 3468);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 2586, 3468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 2586, 3468);
            }
        }

        public TypeWithAnnotations GetInferredReturnType(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 3480, 3764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 3660, 3753);

                return f_10591_3667_3752(this, conversions: null, nullableState: null, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 3480, 3764);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10591_3667_3752(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                nullableState, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetInferredReturnType(conversions: conversions, nullableState: nullableState, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 3667, 3752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 3480, 3764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 3480, 3764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeWithAnnotations GetInferredReturnType(ConversionsBase conversions, NullableWalker.VariableState nullableState, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 4115, 6407);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 4309, 4716) || true) && (f_10591_4313_4359_M(!f_10591_4314_4332().UseSiteDiagnostics.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 4309, 4716);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 4393, 4535) || true) && (useSiteDiagnostics == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 4393, 4535);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 4465, 4516);

                        useSiteDiagnostics = f_10591_4486_4515();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 4393, 4535);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 4553, 4701);
                        foreach (var info in f_10591_4574_4611_I(f_10591_4574_4592().UseSiteDiagnostics))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 4553, 4701);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 4653, 4682);

                            f_10591_4653_4681(useSiteDiagnostics, info);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 4553, 4701);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 149);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 149);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 4309, 4716);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 4730, 6396) || true) && (nullableState == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 4730, 6396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 4789, 4835);

                    return f_10591_4796_4814().TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 4730, 6396);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 4730, 6396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 4901, 4935);

                    f_10591_4901_4934(conversions != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 5389, 5479);

                    var
                    returnTypes = f_10591_5407_5478()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 5497, 5543);

                    var
                    diagnostics = f_10591_5515_5542()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 5561, 5603);

                    var
                    delegateType = f_10591_5580_5602(f_10591_5580_5584())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 5621, 5658);

                    var
                    compilation = f_10591_5639_5657(f_10591_5639_5645())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 5676, 6108);

                    f_10591_5676_6107(compilation, lambda: this, conversions, diagnostics, delegateInvokeMethodOpt: f_10591_5950_5984_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(delegateType, 10591, 5950, 5984)?.DelegateInvokeMethod), initialState: nullableState, returnTypes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 6126, 6145);

                    f_10591_6126_6144(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 6163, 6280);

                    var
                    inferredReturnType = f_10591_6188_6279(returnTypes, node: this, f_10591_6229_6235(), delegateType, f_10591_6251_6265(f_10591_6251_6257()), conversions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 6298, 6317);

                    f_10591_6298_6316(returnTypes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 6335, 6381);

                    return inferredReturnType.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 4730, 6396);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 4115, 6407);

                Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType
                f_10591_4314_4332()
                {
                    var return_v = InferredReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 4314, 4332);
                    return return_v;
                }


                bool
                f_10591_4313_4359_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 4313, 4359);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10591_4486_4515()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 4486, 4515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType
                f_10591_4574_4592()
                {
                    var return_v = InferredReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 4574, 4592);
                    return return_v;
                }


                bool
                f_10591_4653_4681(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 4653, 4681);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10591_4574_4611_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 4574, 4611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType
                f_10591_4796_4814()
                {
                    var return_v = InferredReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 4796, 4814);
                    return return_v;
                }


                int
                f_10591_4901_4934(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 4901, 4934);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                f_10591_5407_5478()
                {
                    var return_v = ArrayBuilder<(BoundReturnStatement, TypeWithAnnotations)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 5407, 5478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10591_5515_5542()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 5515, 5542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10591_5580_5584()
                {
                    var return_v = Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 5580, 5584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10591_5580_5602(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 5580, 5602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10591_5639_5645()
                {
                    var return_v = Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 5639, 5645);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10591_5639_5657(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 5639, 5657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10591_5950_5984_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 5950, 5984);
                    return return_v;
                }


                int
                f_10591_5676_6107(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.BoundLambda
                lambda, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                delegateInvokeMethodOpt, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                initialState, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                returnTypesOpt)
                {
                    NullableWalker.Analyze(compilation, lambda: lambda, (Microsoft.CodeAnalysis.CSharp.Conversions)conversions, diagnostics, delegateInvokeMethodOpt: delegateInvokeMethodOpt, initialState: initialState, returnTypesOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 5676, 6107);
                    return 0;
                }


                int
                f_10591_6126_6144(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 6126, 6144);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10591_6229_6235()
                {
                    var return_v = Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 6229, 6235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10591_6251_6257()
                {
                    var return_v = Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 6251, 6257);
                    return return_v;
                }


                bool
                f_10591_6251_6265(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 6251, 6265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType
                f_10591_6188_6279(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                returnTypes, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                delegateType, bool
                isAsync, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions)
                {
                    var return_v = InferReturnType(returnTypes, node: (Microsoft.CodeAnalysis.CSharp.BoundNode)node, binder, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)delegateType, isAsync, conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 6188, 6279);
                    return return_v;
                }


                int
                f_10591_6298_6316(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 6298, 6316);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 4115, 6407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 4115, 6407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LambdaSymbol CreateLambdaSymbol(NamedTypeSymbol delegateType, Symbol containingSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 6515, 6600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 6531, 6600);
                return f_10591_6531_6600(f_10591_6531_6549(f_10591_6531_6544()), delegateType, containingSymbol); DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 6515, 6600);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 6515, 6600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 6515, 6600);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.UnboundLambda
            f_10591_6531_6544()
            {
                var return_v = UnboundLambda;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 6531, 6544);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            f_10591_6531_6549(Microsoft.CodeAnalysis.CSharp.UnboundLambda
            this_param)
            {
                var return_v = this_param.Data;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 6531, 6549);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
            f_10591_6531_6600(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            delegateType, Microsoft.CodeAnalysis.CSharp.Symbol
            containingSymbol)
            {
                var return_v = this_param.CreateLambdaSymbol(delegateType, containingSymbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 6531, 6600);
                return return_v;
            }

        }

        internal LambdaSymbol CreateLambdaSymbol(
                    Symbol containingSymbol,
                    TypeWithAnnotations returnType,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds,
                    RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 6902, 7244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 6905, 7244);
                return f_10591_6905_7244(f_10591_6905_6923(f_10591_6905_6918()), containingSymbol, returnType, diagnostics: null, parameterTypes, (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 7094, 7121) || ((parameterRefKinds.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 7124, 7197)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 7200, 7217))) ? f_10591_7124_7197(f_10591_7124_7178(RefKind.None, parameterTypes.Length)) : parameterRefKinds, refKind); DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 6902, 7244);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 6902, 7244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 6902, 7244);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.UnboundLambda
            f_10591_6905_6918()
            {
                var return_v = UnboundLambda;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 6905, 6918);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            f_10591_6905_6923(Microsoft.CodeAnalysis.CSharp.UnboundLambda
            this_param)
            {
                var return_v = this_param.Data;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 6905, 6923);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.RefKind>
            f_10591_7124_7178(Microsoft.CodeAnalysis.RefKind
            element, int
            count)
            {
                var return_v = Enumerable.Repeat(element, count);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 7124, 7178);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
            f_10591_7124_7197(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.RefKind>
            items)
            {
                var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.RefKind>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 7124, 7197);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
            f_10591_6905_7244(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            this_param, Microsoft.CodeAnalysis.CSharp.Symbol
            containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            returnType, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
            parameterRefKinds, Microsoft.CodeAnalysis.RefKind
            refKind)
            {
                var return_v = this_param.CreateLambdaSymbol(containingSymbol, returnType, diagnostics: diagnostics, parameterTypes, parameterRefKinds, refKind);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 6905, 7244);
                return return_v;
            }

        }

        internal static readonly TypeSymbol NoReturnExpression;

        internal static InferredLambdaReturnType InferReturnType(ArrayBuilder<(BoundReturnStatement, TypeWithAnnotations)> returnTypes,
                    BoundNode node, Binder binder, TypeSymbol delegateType, bool isAsync, ConversionsBase conversions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 7678, 9103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 7942, 8021);

                var
                types = f_10591_7954_8020()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8035, 8073);

                bool
                hasReturnWithoutArgument = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8087, 8118);

                RefKind
                refKind = RefKind.None
                ;
                foreach (var (returnStatement, type) in returnTypes)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8217, 8254);

                    RefKind
                    rk = f_10591_8230_8253(returnStatement)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8272, 8368) || true) && (rk != RefKind.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 8272, 8368);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8336, 8349);

                        refKind = rk;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 8272, 8368);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8388, 8655) || true) && ((object)type.Type == NoReturnExpression)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 8388, 8655);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8473, 8505);

                        hasReturnWithoutArgument = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 8388, 8655);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 8388, 8655);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8587, 8636);

                        f_10591_8587_8635(types, (f_10591_8598_8627(returnStatement), type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 8388, 8655);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8686, 8736);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8750, 8866);

                var
                bestType = f_10591_8765_8865(binder, conversions, delegateType, types, isAsync, node, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8880, 8913);

                int
                numExpressions = f_10591_8901_8912(types)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8927, 8940);

                f_10591_8927_8939(types);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 8954, 9092);

                return f_10591_8961_9091(numExpressions, hasReturnWithoutArgument, refKind, bestType, f_10591_9051_9090(useSiteDiagnostics));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 7678, 9103);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                f_10591_7954_8020()
                {
                    var return_v = ArrayBuilder<(BoundExpression, TypeWithAnnotations)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 7954, 8020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10591_8230_8253(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 8230, 8253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10591_8598_8627(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 8598, 8627);
                    return return_v;
                }


                int
                f_10591_8587_8635(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                this_param, (Microsoft.CodeAnalysis.CSharp.BoundExpression? ExpressionOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations type)
                item)
                {
                    this_param.Add(((Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations))item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 8587, 8635);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10591_8765_8865(Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                returns, bool
                isAsync, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = CalculateReturnType(binder, conversions, delegateType, returns, isAsync, node, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 8765, 8865);
                    return return_v;
                }


                int
                f_10591_8901_8912(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 8901, 8912);
                    return return_v;
                }


                int
                f_10591_8927_8939(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 8927, 8939);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10591_9051_9090(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                items)
                {
                    var return_v = items.AsImmutableOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 9051, 9090);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType
                f_10591_8961_9091(int
                numExpressions, bool
                hadExpressionlessReturn, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType(numExpressions, hadExpressionlessReturn, refKind, typeWithAnnotations, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 8961, 9091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 7678, 9103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 7678, 9103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeWithAnnotations CalculateReturnType(
                    Binder binder,
                    ConversionsBase conversions,
                    TypeSymbol delegateType,
                    ArrayBuilder<(BoundExpression, TypeWithAnnotations resultType)> returns,
                    bool isAsync,
                    BoundNode node,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 9115, 13225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 9506, 9541);

                TypeWithAnnotations
                bestResultType
                = default(TypeWithAnnotations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 9555, 9577);

                int
                n = f_10591_9563_9576(returns)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 9591, 10841);

                switch (n)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 9591, 10841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 9663, 9688);

                        bestResultType = default;
                        DynAbs.Tracing.TraceSender.TraceBreak(10591, 9710, 9716);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 9591, 10841);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 9591, 10841);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 9763, 9802);

                        bestResultType = returns[0].resultType;
                        DynAbs.Tracing.TraceSender.TraceBreak(10591, 9824, 9830);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 9591, 10841);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 9591, 10841);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 9980, 10798) || true) && (conversions.IncludeNullability)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 9980, 10798);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 10064, 10170);

                            bestResultType = f_10591_10081_10169(returns, binder, node, conversions);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 9980, 10798);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 9980, 10798);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 10268, 10324);

                            var
                            typesOnly = f_10591_10284_10323(n)
                            ;
                            foreach (var (_, resultType) in returns)
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 10447, 10478);

                                f_10591_10447_10477(typesOnly, resultType.Type);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 10531, 10623);

                            var
                            bestType = f_10591_10546_10622(typesOnly, conversions, ref useSiteDiagnostics)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 10649, 10732);

                            bestResultType = (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 10666, 10682) || ((bestType is null && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 10685, 10692)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 10695, 10731))) ? default : TypeWithAnnotations.Create(bestType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 10758, 10775);

                            f_10591_10758_10774(typesOnly);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 9980, 10798);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10591, 10820, 10826);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 9591, 10841);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 10857, 10940) || true) && (!isAsync)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 10857, 10940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 10903, 10925);

                    return bestResultType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 10857, 10940);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 11173, 11205);

                NamedTypeSymbol
                taskType = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 11242, 11327);

                NamedTypeSymbol?
                a = (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 11263, 11286) || ((!(delegateType is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 11289, 11319)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 11322, 11326))) ? f_10591_11289_11319(delegateType) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 11341, 11403);

                MethodSymbol
                b = (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 11358, 11370) || ((!(a is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 11373, 11395)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 11398, 11402))) ? f_10591_11373_11395(a) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 11417, 11508);

                NamedTypeSymbol
                delegateReturnType = (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 11454, 11466) || ((!(b is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 11469, 11500)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 11503, 11507))) ? f_10591_11469_11481(b) as NamedTypeSymbol : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 11648, 11971) || true) && ((object)delegateReturnType != null && (DynAbs.Tracing.TraceSender.Expression_True(10591, 11652, 11722) && !f_10591_11691_11722(delegateReturnType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 11648, 11971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 11756, 11775);

                    object
                    builderType
                    = default(object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 11793, 11956) || true) && (f_10591_11797_11849(delegateReturnType, out builderType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 11793, 11956);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 11891, 11937);

                        taskType = f_10591_11902_11936(delegateReturnType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 11793, 11956);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 11648, 11971);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 11987, 12465) || true) && (n == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 11987, 12465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 12187, 12386);

                    var
                    resultType = (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 12204, 12251) || (((object)taskType != null && (DynAbs.Tracing.TraceSender.Expression_True(10591, 12204, 12251) && f_10591_12232_12246(taskType) == 0) && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 12275, 12283)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 12307, 12385))) ? taskType : f_10591_12307_12385(f_10591_12307_12325(binder), WellKnownType.System_Threading_Tasks_Task)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 12404, 12450);

                    return TypeWithAnnotations.Create(resultType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 11987, 12465);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 12481, 12749) || true) && (f_10591_12485_12508_M(!bestResultType.HasType) || (DynAbs.Tracing.TraceSender.Expression_False(10591, 12485, 12539) || bestResultType.IsVoidType()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 12481, 12749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 12719, 12734);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 12481, 12749);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 12914, 13106);

                var
                taskTypeT = (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 12930, 12977) || (((object)taskType != null && (DynAbs.Tracing.TraceSender.Expression_True(10591, 12930, 12977) && f_10591_12958_12972(taskType) == 1) && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 12997, 13005)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 13025, 13105))) ? taskType : f_10591_13025_13105(f_10591_13025_13043(binder), WellKnownType.System_Threading_Tasks_Task_T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 13120, 13214);

                return TypeWithAnnotations.Create(f_10591_13154_13212(taskTypeT, f_10591_13174_13211(bestResultType)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 9115, 13225);

                int
                f_10591_9563_9576(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations resultType)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 9563, 9576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10591_10081_10169(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations resultType)>
                returns, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions)
                {
                    var return_v = NullableWalker.BestTypeForLambdaReturns(returns, binder, node, (Microsoft.CodeAnalysis.CSharp.Conversions)conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 10081, 10169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10591_10284_10323(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 10284, 10323);
                    return return_v;
                }


                int
                f_10591_10447_10477(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 10447, 10477);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10591_10546_10622(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                types, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = BestTypeInferrer.GetBestType(types, conversions, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 10546, 10622);
                    return return_v;
                }


                int
                f_10591_10758_10774(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 10758, 10774);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10591_11289_11319(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 11289, 11319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10591_11373_11395(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 11373, 11395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10591_11469_11481(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 11469, 11481);
                    return return_v;
                }


                bool
                f_10591_11691_11722(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 11691, 11722);
                    return return_v;
                }


                bool
                f_10591_11797_11849(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, out object
                builderArgument)
                {
                    var return_v = type.IsCustomTaskType(out builderArgument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 11797, 11849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10591_11902_11936(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 11902, 11936);
                    return return_v;
                }


                int
                f_10591_12232_12246(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 12232, 12246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10591_12307_12325(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 12307, 12325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10591_12307_12385(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 12307, 12385);
                    return return_v;
                }


                bool
                f_10591_12485_12508_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 12485, 12508);
                    return return_v;
                }


                int
                f_10591_12958_12972(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 12958, 12972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10591_13025_13043(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 13025, 13043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10591_13025_13105(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 13025, 13105);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10591_13174_13211(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 13174, 13211);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10591_13154_13212(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 13154, 13212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 9115, 13225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 9115, 13225);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal sealed class BlockReturns : BoundTreeWalker
        {
            private readonly ArrayBuilder<(BoundReturnStatement, TypeWithAnnotations)> _builder;

            private BlockReturns(ArrayBuilder<(BoundReturnStatement, TypeWithAnnotations)> builder)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10591, 13414, 13568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 13389, 13397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 13534, 13553);

                    _builder = builder;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10591, 13414, 13568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 13414, 13568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 13414, 13568);
                }
            }

            public static void GetReturnTypes(ArrayBuilder<(BoundReturnStatement, TypeWithAnnotations)> builder, BoundBlock block)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 13584, 13841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 13735, 13787);

                    var
                    visitor = f_10591_13749_13786(builder)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 13805, 13826);

                    f_10591_13805_13825(visitor, block);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 13584, 13841);

                    Microsoft.CodeAnalysis.CSharp.BoundLambda.BlockReturns
                    f_10591_13749_13786(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                    builder)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLambda.BlockReturns(builder);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 13749, 13786);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundNode
                    f_10591_13805_13825(Microsoft.CodeAnalysis.CSharp.BoundLambda.BlockReturns
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    node)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 13805, 13825);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 13584, 13841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 13584, 13841);
                }
            }

            public override BoundNode Visit(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 13857, 14099);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 13937, 14052) || true) && (!(node is BoundExpression))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 13937, 14052);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 14009, 14033);

                        return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(node), 10591, 14016, 14032);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 13937, 14052);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 14072, 14084);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 13857, 14099);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 13857, 14099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 13857, 14099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override BoundExpression VisitExpressionWithoutStackGuard(BoundExpression node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 14115, 14289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 14237, 14274);

                    throw f_10591_14243_14273();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 14115, 14289);

                    System.Exception
                    f_10591_14243_14273()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 14243, 14273);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 14115, 14289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 14115, 14289);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitLocalFunctionStatement(BoundLocalFunctionStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 14305, 14538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 14511, 14523);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 14305, 14538);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 14305, 14538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 14305, 14538);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override BoundNode VisitReturnStatement(BoundReturnStatement node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 14554, 14987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 14660, 14696);

                    var
                    expression = f_10591_14677_14695(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 14714, 14869);

                    var
                    type = (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 14725, 14745) || (((expression is null) && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 14769, 14787)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 14811, 14868))) ? NoReturnExpression : f_10591_14811_14868_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10591_14811_14826(expression), 10591, 14811, 14868).SetUnknownNullabilityForReferenceTypes())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 14887, 14942);

                    f_10591_14887_14941(_builder, (node, TypeWithAnnotations.Create(type)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 14960, 14972);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 14554, 14987);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    f_10591_14677_14695(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    this_param)
                    {
                        var return_v = this_param.ExpressionOpt;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 14677, 14695);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10591_14811_14826(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 14811, 14826);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    f_10591_14811_14868_I(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 14811, 14868);
                        return return_v;
                    }


                    int
                    f_10591_14887_14941(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                    this_param, (Microsoft.CodeAnalysis.CSharp.BoundReturnStatement node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)
                    item)
                    {
                        this_param.Add(((Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations))item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 14887, 14941);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 14554, 14987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 14554, 14987);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static BlockReturns()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10591, 13237, 14998);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10591, 13237, 14998);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 13237, 14998);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10591, 13237, 14998);
        }

        static Microsoft.CodeAnalysis.CSharp.UnboundLambda
        f_10591_2823_2850(Microsoft.CodeAnalysis.CSharp.UnboundLambda
        this_param)
        {
            var return_v = this_param.WithNoCache();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 2823, 2850);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol?
        f_10591_2866_2897(Microsoft.CodeAnalysis.CSharp.Binder
        this_param)
        {
            var return_v = this_param.ContainingMemberOrLambda;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 2866, 2897);
            return return_v;
        }


        bool
        f_10591_3051_3079(Microsoft.CodeAnalysis.SyntaxNode
        syntax)
        {
            var return_v = syntax.IsAnonymousFunction();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 3051, 3079);
            return return_v;
        }


        bool
        f_10591_3216_3279(Microsoft.CodeAnalysis.SyntaxNode
        node, bool
        allowReducedLambdas)
        {
            var return_v = LambdaUtilities.IsLambdaBody(node, allowReducedLambdas: allowReducedLambdas);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 3216, 3279);
            return return_v;
        }


        bool
        f_10591_3317_3358(Microsoft.CodeAnalysis.SyntaxNode
        syntax)
        {
            var return_v = LambdaUtilities.IsQueryPairLambda(syntax);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 3317, 3358);
            return return_v;
        }


        int
        f_10591_3020_3456(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 3020, 3456);
            return 0;
        }


        static Microsoft.CodeAnalysis.SyntaxNode
        f_10591_2815_2821_C(Microsoft.CodeAnalysis.SyntaxNode
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10591, 2586, 3468);
            return return_v;
        }

    }
    internal partial class UnboundLambda
    {
        private readonly NullableWalker.VariableState _nullableState;

        public UnboundLambda(
                    CSharpSyntaxNode syntax,
                    Binder binder,
                    ImmutableArray<RefKind> refKinds,
                    ImmutableArray<TypeWithAnnotations> types,
                    ImmutableArray<string> names,
                    ImmutableArray<bool> discardsOpt,
                    bool isAsync,
                    bool isStatic)
        : base(f_10591_15495_15518_C(BoundKind.UnboundLambda), syntax, null, f_10591_15534_15550_M(!types.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 15534, 15606) && types.Any(t => t.Type?.Kind == SymbolKind.ErrorType)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10591, 15139, 15873);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 15112, 15126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 353767, 353806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 15632, 15661);

                f_10591_15632_15660(binder != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 15675, 15718);

                f_10591_15675_15717(f_10591_15688_15716(syntax));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 15732, 15862);

                this.Data = f_10591_15744_15861(this, binder, names, discardsOpt, types, refKinds, isAsync, isStatic, includeCache: true);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10591, 15139, 15873);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 15139, 15873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 15139, 15873);
            }
        }

        private UnboundLambda(SyntaxNode syntax, UnboundLambdaState state, NullableWalker.VariableState nullableState, bool hasErrors) : base(f_10591_16032_16055_C(BoundKind.UnboundLambda), syntax, null, hasErrors)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10591, 15885, 16185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 15112, 15126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10732, 353767, 353806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16106, 16142);

                this._nullableState = nullableState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16156, 16174);

                this.Data = state;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10591, 15885, 16185);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 15885, 16185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 15885, 16185);
            }
        }

        internal UnboundLambda WithNullableState(Binder binder, NullableWalker.VariableState nullableState)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 16197, 16523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16321, 16355);

                var
                data = f_10591_16332_16354(f_10591_16332_16336(), true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16369, 16440);

                var
                lambda = f_10591_16382_16439(Syntax, data, nullableState, f_10591_16429_16438())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16454, 16484);

                f_10591_16454_16483(data, lambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16498, 16512);

                return lambda;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 16197, 16523);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_16332_16336()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 16332, 16336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_16332_16354(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, bool
                includeCache)
                {
                    var return_v = this_param.WithCaching(includeCache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 16332, 16354);
                    return return_v;
                }


                bool
                f_10591_16429_16438()
                {
                    var return_v = HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 16429, 16438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10591_16382_16439(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                state, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                nullableState, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnboundLambda(syntax, state, nullableState, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 16382, 16439);
                    return return_v;
                }


                int
                f_10591_16454_16483(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                unbound)
                {
                    this_param.SetUnboundLambda(unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 16454, 16483);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 16197, 16523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 16197, 16523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal UnboundLambda WithNoCache()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 16535, 16901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16596, 16631);

                var
                data = f_10591_16607_16630(f_10591_16607_16611(), false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16645, 16730) || true) && ((object)data == f_10591_16665_16669())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 16645, 16730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16703, 16715);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 16645, 16730);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16746, 16818);

                var
                lambda = f_10591_16759_16817(Syntax, data, _nullableState, f_10591_16807_16816())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16832, 16862);

                f_10591_16832_16861(data, lambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16876, 16890);

                return lambda;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 16535, 16901);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_16607_16611()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 16607, 16611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_16607_16630(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, bool
                includeCache)
                {
                    var return_v = this_param.WithCaching(includeCache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 16607, 16630);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_16665_16669()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 16665, 16669);
                    return return_v;
                }


                bool
                f_10591_16807_16816()
                {
                    var return_v = HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 16807, 16816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10591_16759_16817(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                state, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
                nullableState, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.UnboundLambda(syntax, state, nullableState, hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 16759, 16817);
                    return return_v;
                }


                int
                f_10591_16832_16861(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                unbound)
                {
                    this_param.SetUnboundLambda(unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 16832, 16861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 16535, 16901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 16535, 16901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MessageID MessageID
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 16942, 16972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 16948, 16970);

                    return f_10591_16955_16969(f_10591_16955_16959());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 16942, 16972);

                    Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    f_10591_16955_16959()
                    {
                        var return_v = Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 16955, 16959);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.MessageID
                    f_10591_16955_16969(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    this_param)
                    {
                        var return_v = this_param.MessageID;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 16955, 16969);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 16913, 16974);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 16913, 16974);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public BoundLambda Bind(NamedTypeSymbol delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 17053, 17097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 17056, 17097);
                return f_10591_17056_17097(this, f_10591_17073_17096(f_10591_17073_17077(), delegateType)); DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 17053, 17097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 17053, 17097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 17053, 17097);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            f_10591_17073_17077()
            {
                var return_v = Data;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17073, 17077);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundLambda
            f_10591_17073_17096(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            delegateType)
            {
                var return_v = this_param.Bind(delegateType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 17073, 17096);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundLambda
            f_10591_17056_17097(Microsoft.CodeAnalysis.CSharp.UnboundLambda
            this_param, Microsoft.CodeAnalysis.CSharp.BoundLambda
            lambda)
            {
                var return_v = this_param.SuppressIfNeeded(lambda);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 17056, 17097);
                return return_v;
            }

        }

        public BoundLambda BindForErrorRecovery()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 17165, 17213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 17168, 17213);
                return f_10591_17168_17213(this, f_10591_17185_17212(f_10591_17185_17189())); DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 17165, 17213);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 17165, 17213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 17165, 17213);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            f_10591_17185_17189()
            {
                var return_v = Data;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17185, 17189);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundLambda
            f_10591_17185_17212(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            this_param)
            {
                var return_v = this_param.BindForErrorRecovery();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 17185, 17212);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundLambda
            f_10591_17168_17213(Microsoft.CodeAnalysis.CSharp.UnboundLambda
            this_param, Microsoft.CodeAnalysis.CSharp.BoundLambda
            lambda)
            {
                var return_v = this_param.SuppressIfNeeded(lambda);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 17168, 17213);
                return return_v;
            }

        }

        public BoundLambda BindForReturnTypeInference(NamedTypeSymbol delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 17315, 17381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 17318, 17381);
                return f_10591_17318_17381(this, f_10591_17335_17380(f_10591_17335_17339(), delegateType)); DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 17315, 17381);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 17315, 17381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 17315, 17381);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            f_10591_17335_17339()
            {
                var return_v = Data;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17335, 17339);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundLambda
            f_10591_17335_17380(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            delegateType)
            {
                var return_v = this_param.BindForReturnTypeInference(delegateType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 17335, 17380);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundLambda
            f_10591_17318_17381(Microsoft.CodeAnalysis.CSharp.UnboundLambda
            this_param, Microsoft.CodeAnalysis.CSharp.BoundLambda
            lambda)
            {
                var return_v = this_param.SuppressIfNeeded(lambda);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 17318, 17381);
                return return_v;
            }

        }

        private BoundLambda SuppressIfNeeded(BoundLambda lambda)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 17464, 17533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 17467, 17533);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 17467, 17484) || ((f_10591_17467_17484(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 17487, 17524)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 17527, 17533))) ? (BoundLambda)f_10591_17500_17524(lambda) : lambda; DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 17464, 17533);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 17464, 17533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 17464, 17533);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10591_17467_17484(Microsoft.CodeAnalysis.CSharp.UnboundLambda
            this_param)
            {
                var return_v = this_param.IsSuppressed;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17467, 17484);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.BoundExpression
            f_10591_17500_17524(Microsoft.CodeAnalysis.CSharp.BoundLambda
            this_param)
            {
                var return_v = this_param.WithSuppression();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 17500, 17524);
                return return_v;
            }

        }

        public bool HasSignature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 17573, 17606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 17579, 17604);

                    return f_10591_17586_17603(f_10591_17586_17590());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 17573, 17606);

                    Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    f_10591_17586_17590()
                    {
                        var return_v = Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17586, 17590);
                        return return_v;
                    }


                    bool
                    f_10591_17586_17603(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    this_param)
                    {
                        var return_v = this_param.HasSignature;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17586, 17603);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 17546, 17608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 17546, 17608);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasExplicitlyTypedParameterList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 17664, 17716);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 17670, 17714);

                    return f_10591_17677_17713(f_10591_17677_17681());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 17664, 17716);

                    Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    f_10591_17677_17681()
                    {
                        var return_v = Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17677, 17681);
                        return return_v;
                    }


                    bool
                    f_10591_17677_17713(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    this_param)
                    {
                        var return_v = this_param.HasExplicitlyTypedParameterList;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17677, 17713);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 17618, 17718);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 17618, 17718);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 17756, 17791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 17762, 17789);

                    return f_10591_17769_17788(f_10591_17769_17773());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 17756, 17791);

                    Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    f_10591_17769_17773()
                    {
                        var return_v = Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17769, 17773);
                        return return_v;
                    }


                    int
                    f_10591_17769_17788(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 17769, 17788);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 17728, 17793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 17728, 17793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeWithAnnotations InferReturnType(ConversionsBase conversions, NamedTypeSymbol delegateType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 17966, 18084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 17969, 18084);
                return f_10591_17969_18084(f_10591_17969_18009(this, delegateType), conversions, _nullableState, ref useSiteDiagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 17966, 18084);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 17966, 18084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 17966, 18084);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.BoundLambda
            f_10591_17969_18009(Microsoft.CodeAnalysis.CSharp.UnboundLambda
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            delegateType)
            {
                var return_v = this_param.BindForReturnTypeInference(delegateType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 17969, 18009);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10591_17969_18084(Microsoft.CodeAnalysis.CSharp.BoundLambda
            this_param, Microsoft.CodeAnalysis.CSharp.ConversionsBase
            conversions, Microsoft.CodeAnalysis.CSharp.NullableWalker.VariableState
            nullableState, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
            useSiteDiagnostics)
            {
                var return_v = this_param.GetInferredReturnType(conversions, nullableState, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 17969, 18084);
                return return_v;
            }

        }

        public RefKind RefKind(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 18097, 18162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 18133, 18160);

                return f_10591_18140_18159(f_10591_18140_18144(), index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 18097, 18162);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_18140_18144()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18140, 18144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10591_18140_18159(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, int
                index)
                {
                    var return_v = this_param.RefKind(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 18140, 18159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 18097, 18162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 18097, 18162);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void GenerateAnonymousFunctionConversionError(DiagnosticBag diagnostics, TypeSymbol targetType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 18172, 18350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 18277, 18348);

                f_10591_18277_18347(f_10591_18277_18281(), diagnostics, targetType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 18172, 18350);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_18277_18281()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18277, 18281);
                    return return_v;
                }


                int
                f_10591_18277_18347(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType)
                {
                    this_param.GenerateAnonymousFunctionConversionError(diagnostics, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 18277, 18347);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 18172, 18350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 18172, 18350);
            }
        }

        public bool GenerateSummaryErrors(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 18360, 18472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 18423, 18470);

                return f_10591_18430_18469(f_10591_18430_18434(), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 18360, 18472);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_18430_18434()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18430, 18434);
                    return return_v;
                }


                bool
                f_10591_18430_18469(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateSummaryErrors(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 18430, 18469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 18360, 18472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 18360, 18472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 18504, 18532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 18510, 18530);

                    return f_10591_18517_18529(f_10591_18517_18521());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 18504, 18532);

                    Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    f_10591_18517_18521()
                    {
                        var return_v = Data;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18517, 18521);
                        return return_v;
                    }


                    bool
                    f_10591_18517_18529(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                    this_param)
                    {
                        var return_v = this_param.IsAsync;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18517, 18529);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 18482, 18534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 18482, 18534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 18565, 18581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 18568, 18581);
                    return f_10591_18568_18581(f_10591_18568_18572()); DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 18565, 18581);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 18565, 18581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 18565, 18581);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeWithAnnotations ParameterTypeWithAnnotations(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 18592, 18711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 18661, 18709);

                return f_10591_18668_18708(f_10591_18668_18672(), index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 18592, 18711);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_18668_18672()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18668, 18672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10591_18668_18708(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterTypeWithAnnotations(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 18668, 18708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 18592, 18711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 18592, 18711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TypeSymbol ParameterType(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 18721, 18816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 18766, 18814);

                return f_10591_18773_18808(this, index).Type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 18721, 18816);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10591_18773_18808(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterTypeWithAnnotations(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 18773, 18808);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 18721, 18816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 18721, 18816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Location ParameterLocation(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 18826, 18912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 18873, 18910);

                return f_10591_18880_18909(f_10591_18880_18884(), index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 18826, 18912);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_18880_18884()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18880, 18884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10591_18880_18909(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterLocation(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 18880, 18909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 18826, 18912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 18826, 18912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string ParameterName(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 18922, 18998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 18963, 18996);

                return f_10591_18970_18995(f_10591_18970_18974(), index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 18922, 18998);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_18970_18974()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18970, 18974);
                    return return_v;
                }


                string
                f_10591_18970_18995(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterName(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 18970, 18995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 18922, 18998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 18922, 18998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ParameterIsDiscard(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 19008, 19092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 19052, 19090);

                return f_10591_19059_19089(f_10591_19059_19063(), index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 19008, 19092);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_19059_19063()
                {
                    var return_v = Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 19059, 19063);
                    return return_v;
                }


                bool
                f_10591_19059_19089(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterIsDiscard(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 19059, 19089);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 19008, 19092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 19008, 19092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static bool
        f_10591_15534_15550_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 15534, 15550);
            return return_v;
        }


        int
        f_10591_15632_15660(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 15632, 15660);
            return 0;
        }


        bool
        f_10591_15688_15716(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
        syntax)
        {
            var return_v = syntax.IsAnonymousFunction();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 15688, 15716);
            return return_v;
        }


        int
        f_10591_15675_15717(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 15675, 15717);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState
        f_10591_15744_15861(Microsoft.CodeAnalysis.CSharp.UnboundLambda
        unboundLambda, Microsoft.CodeAnalysis.CSharp.Binder
        binder, System.Collections.Immutable.ImmutableArray<string>
        parameterNames, System.Collections.Immutable.ImmutableArray<bool>
        parameterIsDiscardOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        parameterTypesWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
        parameterRefKinds, bool
        isAsync, bool
        isStatic, bool
        includeCache)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState(unboundLambda, binder, parameterNames, parameterIsDiscardOpt, parameterTypesWithAnnotations, parameterRefKinds, isAsync, isStatic, includeCache: includeCache);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 15744, 15861);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.BoundKind
        f_10591_15495_15518_C(Microsoft.CodeAnalysis.CSharp.BoundKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10591, 15139, 15873);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.BoundKind
        f_10591_16032_16055_C(Microsoft.CodeAnalysis.CSharp.BoundKind
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10591, 15885, 16185);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
        f_10591_18568_18572()
        {
            var return_v = Data;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18568, 18572);
            return return_v;
        }


        bool
        f_10591_18568_18581(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 18568, 18581);
            return return_v;
        }

    }
    internal abstract class UnboundLambdaState
    {
        private UnboundLambda _unboundLambda;

        internal readonly Binder Binder;

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/issues/23582",
                    Constraint = "Avoid " + nameof(ConcurrentDictionary<NamedTypeSymbol, BoundLambda>) + " which has a large default size, but this cache is normally small.")]
        private ImmutableDictionary<NamedTypeSymbol, BoundLambda> _bindingCache;

        [PerformanceSensitive(
                    "https://github.com/dotnet/roslyn/issues/23582",
                    Constraint = "Avoid " + nameof(ConcurrentDictionary<ReturnInferenceCacheKey, BoundLambda>) + " which has a large default size, but this cache is normally small.")]
        private ImmutableDictionary<ReturnInferenceCacheKey, BoundLambda> _returnInferenceCache;

        private BoundLambda _errorBinding;

        public UnboundLambdaState(Binder binder, UnboundLambda unboundLambdaOpt, bool includeCache)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10591, 20092, 20720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 19188, 19202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 19309, 19315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 19649, 19662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20012, 20033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20066, 20079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20208, 20237);

                f_10591_20208_20236(binder != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20253, 20561) || true) && (includeCache)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 20253, 20561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20303, 20440);

                    _bindingCache = f_10591_20319_20439(ImmutableDictionary<NamedTypeSymbol, BoundLambda>.Empty, Symbols.SymbolEqualityComparer.ConsiderEverything);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20458, 20546);

                    _returnInferenceCache = ImmutableDictionary<ReturnInferenceCacheKey, BoundLambda>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 20253, 20561);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20640, 20674);

                _unboundLambda = unboundLambdaOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20688, 20709);

                this.Binder = binder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10591, 20092, 20720);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 20092, 20720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 20092, 20720);
            }
        }

        public void SetUnboundLambda(UnboundLambda unbound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 20732, 20976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20808, 20838);

                f_10591_20808_20837(unbound != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20852, 20926);

                f_10591_20852_20925(_unboundLambda == null || (DynAbs.Tracing.TraceSender.Expression_False(10591, 20865, 20924) || (object)_unboundLambda == unbound));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 20940, 20965);

                _unboundLambda = unbound;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 20732, 20976);

                int
                f_10591_20808_20837(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 20808, 20837);
                    return 0;
                }


                int
                f_10591_20852_20925(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 20852, 20925);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 20732, 20976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 20732, 20976);
            }
        }

        protected abstract UnboundLambdaState WithCachingCore(bool includeCache);

        internal UnboundLambdaState WithCaching(bool includeCache)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 21073, 21430);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 21156, 21260) || true) && ((_bindingCache == null) != includeCache)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 21156, 21260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 21233, 21245);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 21156, 21260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 21276, 21318);

                var
                state = f_10591_21288_21317(this, includeCache)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 21332, 21392);

                f_10591_21332_21391((state._bindingCache == null) != includeCache);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 21406, 21419);

                return state;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 21073, 21430);

                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10591_21288_21317(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, bool
                includeCache)
                {
                    var return_v = this_param.WithCachingCore(includeCache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 21288, 21317);
                    return return_v;
                }


                int
                f_10591_21332_21391(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 21332, 21391);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 21073, 21430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 21073, 21430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public UnboundLambda UnboundLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 21477, 21494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 21480, 21494);
                    return _unboundLambda; DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 21477, 21494);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 21477, 21494);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 21477, 21494);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract MessageID MessageID { get; }

        public abstract string ParameterName(int index);

        public abstract bool ParameterIsDiscard(int index);

        public abstract bool HasSignature { get; }

        public abstract bool HasExplicitlyTypedParameterList { get; }

        public abstract int ParameterCount { get; }

        public abstract bool IsAsync { get; }

        public abstract bool HasNames { get; }

        public abstract bool IsStatic { get; }

        public abstract Location ParameterLocation(int index);

        public abstract TypeWithAnnotations ParameterTypeWithAnnotations(int index);

        public abstract RefKind RefKind(int index);

        protected abstract BoundBlock BindLambdaBody(LambdaSymbol lambdaSymbol, Binder lambdaBodyBinder, DiagnosticBag diagnostics);

        protected abstract BoundExpression GetLambdaExpressionBody(BoundBlock body);

        protected abstract BoundBlock CreateBlockFromLambdaExpressionBody(Binder lambdaBodyBinder, BoundExpression expression, DiagnosticBag diagnostics);

        public virtual void GenerateAnonymousFunctionConversionError(DiagnosticBag diagnostics, TypeSymbol targetType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 22965, 23228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23100, 23217);

                f_10591_23100_23216(this.Binder, diagnostics, _unboundLambda.Syntax, _unboundLambda, targetType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 22965, 23228);

                int
                f_10591_23100_23216(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                anonymousFunction, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType)
                {
                    this_param.GenerateAnonymousFunctionConversionError(diagnostics, syntax, anonymousFunction, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 23100, 23216);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 22965, 23228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 22965, 23228);
            }
        }

        public BoundLambda Bind(NamedTypeSymbol delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 23319, 23708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23397, 23416);

                BoundLambda
                result
                = default(BoundLambda);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23430, 23667) || true) && (!f_10591_23435_23486(_bindingCache, delegateType, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 23430, 23667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23520, 23554);

                    result = f_10591_23529_23553(this, delegateType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23572, 23652);

                    result = f_10591_23581_23651(ref _bindingCache, delegateType, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 23430, 23667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23683, 23697);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 23319, 23708);

                bool
                f_10591_23435_23486(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, out Microsoft.CodeAnalysis.CSharp.BoundLambda
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 23435, 23486);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_23529_23553(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType)
                {
                    var return_v = this_param.ReallyBind(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 23529, 23553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_23581_23651(ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                location, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, Microsoft.CodeAnalysis.CSharp.BoundLambda
                value)
                {
                    var return_v = ImmutableInterlocked.GetOrAdd(ref location, key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 23581, 23651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 23319, 23708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 23319, 23708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IEnumerable<TypeSymbol> InferredReturnTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 23720, 24413);

                var listYield = new List<TypeSymbol>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23799, 23816);

                bool
                any = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23830, 24138);
                    foreach (var lambda in f_10591_23853_23881_I(f_10591_23853_23881(_returnInferenceCache)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 23830, 24138);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23915, 23972);

                        var
                        type = lambda.InferredReturnType.TypeWithAnnotations
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 23990, 24123) || true) && (type.HasType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 23990, 24123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24048, 24059);

                            any = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24081, 24104);

                            listYield.Add(type.Type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 23990, 24123);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 23830, 24138);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 309);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24154, 24402) || true) && (!any)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 24154, 24402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24196, 24269);

                    var
                    type = f_10591_24207_24229(this).InferredReturnType.TypeWithAnnotations
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24287, 24387) || true) && (type.HasType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 24287, 24387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24345, 24368);

                        listYield.Add(type.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 24287, 24387);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 24154, 24402);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 23720, 24413);

                return listYield;

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.BoundLambda>
                f_10591_23853_23881(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 23853, 23881);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.BoundLambda>
                f_10591_23853_23881_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.BoundLambda>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 23853, 23881);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_24207_24229(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param)
                {
                    var return_v = this_param.BindForErrorRecovery();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 24207, 24229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 23720, 24413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 23720, 24413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodSymbol DelegateInvokeMethod(NamedTypeSymbol delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 24425, 24599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24528, 24588);

                return f_10591_24535_24587_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10591_24535_24565(delegateType), 10591, 24535, 24587)?.DelegateInvokeMethod);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 24425, 24599);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10591_24535_24565(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 24535, 24565);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10591_24535_24587_M(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 24535, 24587);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 24425, 24599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 24425, 24599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeWithAnnotations DelegateReturnTypeWithAnnotations(MethodSymbol invokeMethod, out RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 24611, 25011);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24745, 24895) || true) && ((object)invokeMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 24745, 24895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24811, 24847);

                    refKind = CodeAnalysis.RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24865, 24880);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 24745, 24895);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24909, 24940);

                refKind = f_10591_24919_24939(invokeMethod);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 24954, 25000);

                return f_10591_24961_24999(invokeMethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 24611, 25011);

                Microsoft.CodeAnalysis.RefKind
                f_10591_24919_24939(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 24919, 24939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10591_24961_24999(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 24961, 24999);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 24611, 25011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 24611, 25011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool DelegateNeedsReturn(MethodSymbol invokeMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 25023, 25430);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25107, 25229) || true) && ((object)invokeMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10591, 25111, 25167) || f_10591_25143_25167(invokeMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 25107, 25229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25201, 25214);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 25107, 25229);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25245, 25391) || true) && (f_10591_25249_25256() && (DynAbs.Tracing.TraceSender.Expression_True(10591, 25249, 25329) && f_10591_25260_25329(f_10591_25260_25283(invokeMethod), f_10591_25305_25328(this.Binder))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 25245, 25391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25363, 25376);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 25245, 25391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25407, 25419);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 25023, 25430);

                bool
                f_10591_25143_25167(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 25143, 25167);
                    return return_v;
                }


                bool
                f_10591_25249_25256()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 25249, 25256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10591_25260_25283(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 25260, 25283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10591_25305_25328(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 25305, 25328);
                    return return_v;
                }


                bool
                f_10591_25260_25329(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsNonGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 25260, 25329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 25023, 25430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 25023, 25430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundLambda ReallyBind(NamedTypeSymbol delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 25442, 31411);
                Microsoft.CodeAnalysis.RefKind refKind = default(Microsoft.CodeAnalysis.RefKind);
                Microsoft.CodeAnalysis.CSharp.BoundLambda returnInferenceLambda = default(Microsoft.CodeAnalysis.CSharp.BoundLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25527, 25581);

                var
                invokeMethod = f_10591_25546_25580(delegateType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25595, 25681);

                var
                returnType = f_10591_25612_25680(this, invokeMethod, out refKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25697, 25723);

                LambdaSymbol
                lambdaSymbol
                = default(LambdaSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25737, 25761);

                Binder
                lambdaBodyBinder
                = default(Binder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25775, 25792);

                BoundBlock
                block
                = default(BoundBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25808, 25854);

                var
                diagnostics = f_10591_25826_25853()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25868, 25905);

                var
                compilation = f_10591_25886_25904(Binder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 25919, 25988);

                var
                cacheKey = f_10591_25934_25987(delegateType, f_10591_25979_25986())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 26472, 27731) || true) && (refKind == CodeAnalysis.RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10591, 26476, 26615) && f_10591_26533_26615(_returnInferenceCache, cacheKey, out returnInferenceLambda)) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 26476, 26717) && f_10591_26636_26687(this, f_10591_26660_26686(returnInferenceLambda)) is BoundExpression expression) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 26476, 26802) && f_10591_26738_26791((lambdaSymbol = f_10591_26754_26782(returnInferenceLambda))) == refKind) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 26476, 26897) && (object)LambdaSymbol.InferenceFailureReturnType != f_10591_26874_26897(lambdaSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 26476, 27011) && lambdaSymbol.ReturnTypeWithAnnotations.Equals(returnType, TypeCompareKind.ConsiderEverything)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 26472, 27731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 27045, 27093);

                    lambdaBodyBinder = f_10591_27064_27092(returnInferenceLambda);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 27111, 27198);

                    block = f_10591_27119_27197(this, lambdaBodyBinder, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 27216, 27272);

                    f_10591_27216_27271(diagnostics, f_10591_27237_27270(returnInferenceLambda));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 26472, 27731);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 26472, 27731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 27338, 27492);

                    lambdaSymbol = f_10591_27353_27491(this, f_10591_27372_27403(Binder), returnType, diagnostics, cacheKey.ParameterTypes, cacheKey.ParameterRefKinds, refKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 27510, 27630);

                    lambdaBodyBinder = f_10591_27529_27629(_unboundLambda.Syntax, lambdaSymbol, f_10591_27591_27628(this, lambdaSymbol, Binder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 27648, 27716);

                    block = f_10591_27656_27715(this, lambdaSymbol, lambdaBodyBinder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 26472, 27731);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 27747, 27972) || true) && (f_10591_27751_27771(lambdaSymbol) == CodeAnalysis.RefKind.RefReadOnly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 27747, 27972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 27841, 27957);

                    f_10591_27841_27956(compilation, diagnostics, f_10591_27898_27929(lambdaSymbol), modifyCompilation: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 27747, 27972);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 27988, 28035);

                var
                lambdaParameters = f_10591_28011_28034(lambdaSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 28049, 28168);

                f_10591_28049_28167(compilation, lambdaParameters, diagnostics, modifyCompilation: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 28184, 28943) || true) && (returnType.HasType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 28184, 28943);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 28240, 28463) || true) && (f_10591_28244_28283(returnType.Type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 28240, 28463);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 28325, 28444);

                        f_10591_28325_28443(compilation, diagnostics, f_10591_28385_28416(lambdaSymbol), modifyCompilation: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 28240, 28463);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 28483, 28928) || true) && (f_10591_28487_28541(compilation, lambdaSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 28487, 28601) && returnType.NeedsNullableAttribute()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 28483, 28928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 28643, 28757);

                        f_10591_28643_28756(compilation, diagnostics, f_10591_28698_28729(lambdaSymbol), modifyCompilation: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 28483, 28928);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 28184, 28943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 28959, 29081);

                f_10591_28959_29080(compilation, lambdaParameters, diagnostics, modifyCompilation: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 29095, 29226);

                f_10591_29095_29225(compilation, lambdaSymbol, lambdaParameters, diagnostics, modifyCompilation: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 29386, 29449);

                f_10591_29386_29448(this, diagnostics, cacheKey.ParameterTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 29465, 29561);

                bool
                reachableEndpoint = f_10591_29490_29560(compilation, lambdaSymbol, block, diagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 29575, 30100) || true) && (reachableEndpoint)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 29575, 30100);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 29630, 30085) || true) && (f_10591_29634_29667(this, invokeMethod))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 29630, 30085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 29788, 29917);

                        f_10591_29788_29916(                    // Not all code paths return a value in {0} of type '{1}'
                                            diagnostics, ErrorCode.ERR_AnonymousReturnExpected, f_10591_29843_29874(lambdaSymbol), f_10591_29876_29901(f_10591_29876_29890(this)), delegateType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 29630, 30085);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 29630, 30085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 29999, 30066);

                        block = f_10591_30007_30065(block, lambdaSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 29630, 30085);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 29575, 30100);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 30116, 30894) || true) && (f_10591_30120_30127() && (DynAbs.Tracing.TraceSender.Expression_True(10591, 30120, 30192) && !f_10591_30132_30192(diagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 30116, 30894);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 30226, 30879) || true) && (returnType.HasType && (DynAbs.Tracing.TraceSender.Expression_True(10591, 30230, 30363) && !returnType.IsVoidType()) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 30230, 30438) && !f_10591_30389_30438(returnType.Type, compilation)) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 30230, 30510) && !f_10591_30464_30510(returnType.Type, compilation)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 30226, 30879);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 30718, 30860);

                        f_10591_30718_30859(                    // Cannot convert async {0} to delegate type '{1}'. An async {0} may return void, Task or Task&lt;T&gt;, none of which are convertible to '{1}'.
                                            diagnostics, ErrorCode.ERR_CantConvAsyncAnonFuncReturns, f_10591_30778_30809(lambdaSymbol), f_10591_30811_30844(f_10591_30811_30833(lambdaSymbol)), delegateType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 30226, 30879);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 30116, 30894);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 30910, 31109) || true) && (f_10591_30914_30921())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 30910, 31109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 30955, 30990);

                    f_10591_30955_30989(f_10591_30968_30988(lambdaSymbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 31008, 31094);

                    f_10591_31008_31093(lambdaSymbol, diagnostics, f_10591_31061_31092(lambdaSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 30910, 31109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 31125, 31370);

                var
                result = new BoundLambda(_unboundLambda.Syntax, _unboundLambda, block, f_10591_31200_31231(diagnostics), lambdaBodyBinder, delegateType, inferredReturnType: default)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10591_31332_31367(_unboundLambda), 10591, 31138, 31369) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 31386, 31400);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 25442, 31411);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10591_25546_25580(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType)
                {
                    var return_v = DelegateInvokeMethod(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 25546, 25580);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10591_25612_25680(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                invokeMethod, out Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.DelegateReturnTypeWithAnnotations(invokeMethod, out refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 25612, 25680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10591_25826_25853()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 25826, 25853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10591_25886_25904(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 25886, 25904);
                    return return_v;
                }


                bool
                f_10591_25979_25986()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 25979, 25986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey
                f_10591_25934_25987(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, bool
                isAsync)
                {
                    var return_v = ReturnInferenceCacheKey.Create(delegateType, isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 25934, 25987);
                    return return_v;
                }


                bool
                f_10591_26533_26615(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                this_param, Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey
                key, out Microsoft.CodeAnalysis.CSharp.BoundLambda
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 26533, 26615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10591_26660_26686(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 26660, 26686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10591_26636_26687(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    var return_v = this_param.GetLambdaExpressionBody(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 26636, 26687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10591_26754_26782(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 26754, 26782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10591_26738_26791(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 26738, 26791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10591_26874_26897(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 26874, 26897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10591_27064_27092(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Binder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 27064, 27092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10591_27119_27197(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                lambdaBodyBinder, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateBlockFromLambdaExpressionBody(lambdaBodyBinder, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 27119, 27197);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10591_27237_27270(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 27237, 27270);
                    return return_v;
                }


                int
                f_10591_27216_27271(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange<Microsoft.CodeAnalysis.Diagnostic>(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 27216, 27271);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10591_27372_27403(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 27372, 27403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10591_27353_27491(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.CreateLambdaSymbol(containingSymbol, returnType, diagnostics, parameterTypes, parameterRefKinds, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 27353, 27491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10591_27591_27628(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                lambdaSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = this_param.ParameterBinder(lambdaSymbol, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 27591, 27628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10591_27529_27629(Microsoft.CodeAnalysis.SyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder(root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 27529, 27629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10591_27656_27715(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                lambdaSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                lambdaBodyBinder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindLambdaBody(lambdaSymbol, lambdaBodyBinder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 27656, 27715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10591_27751_27771(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 27751, 27771);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10591_27898_27929(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.DiagnosticLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 27898, 27929);
                    return return_v;
                }


                int
                f_10591_27841_27956(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureIsReadOnlyAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 27841, 27956);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10591_28011_28034(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 28011, 28034);
                    return return_v;
                }


                int
                f_10591_28049_28167(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureIsReadOnlyAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 28049, 28167);
                    return 0;
                }


                bool
                f_10591_28244_28283(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 28244, 28283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10591_28385_28416(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.DiagnosticLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 28385, 28416);
                    return return_v;
                }


                int
                f_10591_28325_28443(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNativeIntegerAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 28325, 28443);
                    return 0;
                }


                bool
                f_10591_28487_28541(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 28487, 28541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10591_28698_28729(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.DiagnosticLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 28698, 28729);
                    return return_v;
                }


                int
                f_10591_28643_28756(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location, bool
                modifyCompilation)
                {
                    this_param.EnsureNullableAttributeExists(diagnostics, location, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 28643, 28756);
                    return 0;
                }


                int
                f_10591_28959_29080(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNativeIntegerAttributeExists(compilation, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 28959, 29080);
                    return 0;
                }


                int
                f_10591_29095_29225(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                modifyCompilation)
                {
                    ParameterHelpers.EnsureNullableAttributeExists(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)container, parameters, diagnostics, modifyCompilation: modifyCompilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 29095, 29225);
                    return 0;
                }


                int
                f_10591_29386_29448(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                targetParameterTypes)
                {
                    this_param.ValidateUnsafeParameters(diagnostics, targetParameterTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 29386, 29448);
                    return 0;
                }


                bool
                f_10591_29490_29560(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                member, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ControlFlowPass.Analyze(compilation, (Microsoft.CodeAnalysis.CSharp.Symbol)member, block, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 29490, 29560);
                    return return_v;
                }


                bool
                f_10591_29634_29667(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                invokeMethod)
                {
                    var return_v = this_param.DelegateNeedsReturn(invokeMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 29634, 29667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10591_29843_29874(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.DiagnosticLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 29843, 29874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MessageID
                f_10591_29876_29890(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param)
                {
                    var return_v = this_param.MessageID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 29876, 29890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10591_29876_29901(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 29876, 29901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10591_29788_29916(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 29788, 29916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10591_30007_30065(Microsoft.CodeAnalysis.CSharp.BoundBlock
                body, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                method)
                {
                    var return_v = FlowAnalysisPass.AppendImplicitReturn(body, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 30007, 30065);
                    return return_v;
                }


                bool
                f_10591_30120_30127()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 30120, 30127);
                    return return_v;
                }


                bool
                f_10591_30132_30192(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ErrorFacts.PreventsSuccessfulDelegateConversion(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 30132, 30192);
                    return return_v;
                }


                bool
                f_10591_30389_30438(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsNonGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 30389, 30438);
                    return return_v;
                }


                bool
                f_10591_30464_30510(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = type.IsGenericTaskType(compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 30464, 30510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10591_30778_30809(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.DiagnosticLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 30778, 30809);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.MessageID
                f_10591_30811_30833(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.MessageID;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 30811, 30833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10591_30811_30844(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 30811, 30844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10591_30718_30859(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 30718, 30859);
                    return return_v;
                }


                bool
                f_10591_30914_30921()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 30914, 30921);
                    return return_v;
                }


                bool
                f_10591_30968_30988(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 30968, 30988);
                    return return_v;
                }


                int
                f_10591_30955_30989(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 30955, 30989);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10591_31061_31092(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.DiagnosticLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 31061, 31092);
                    return return_v;
                }


                int
                f_10591_31008_31093(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    this_param.ReportAsyncParameterErrors(diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 31008, 31093);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10591_31200_31231(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 31200, 31231);
                    return return_v;
                }


                bool
                f_10591_31332_31367(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 31332, 31367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 25442, 31411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 25442, 31411);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal LambdaSymbol CreateLambdaSymbol(
                    Symbol containingSymbol,
                    TypeWithAnnotations returnType,
                    DiagnosticBag diagnostics,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds,
                    RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 31752, 32031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 31755, 32031);
                return f_10591_31755_32031(f_10591_31790_31808(Binder), containingSymbol, _unboundLambda, parameterTypes, parameterRefKinds, refKind, returnType, diagnostics); DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 31752, 32031);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 31752, 32031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 31752, 32031);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            f_10591_31790_31808(Microsoft.CodeAnalysis.CSharp.Binder
            this_param)
            {
                var return_v = this_param.Compilation;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 31790, 31808);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
            f_10591_31755_32031(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            compilation, Microsoft.CodeAnalysis.CSharp.Symbol
            containingSymbol, Microsoft.CodeAnalysis.CSharp.UnboundLambda
            unboundLambda, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
            parameterRefKinds, Microsoft.CodeAnalysis.RefKind
            refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            returnType, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol(compilation, containingSymbol, unboundLambda, parameterTypes, parameterRefKinds, refKind, returnType, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 31755, 32031);
                return return_v;
            }

        }

        internal LambdaSymbol CreateLambdaSymbol(NamedTypeSymbol delegateType, Symbol containingSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 32044, 32565);
                Microsoft.CodeAnalysis.RefKind refKind = default(Microsoft.CodeAnalysis.RefKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 32164, 32218);

                var
                invokeMethod = f_10591_32183_32217(delegateType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 32232, 32318);

                var
                returnType = f_10591_32249_32317(this, invokeMethod, out refKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 32332, 32401);

                var
                cacheKey = f_10591_32347_32400(delegateType, f_10591_32392_32399())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 32415, 32554);

                return f_10591_32422_32553(this, containingSymbol, returnType, f_10591_32471_32490(), cacheKey.ParameterTypes, cacheKey.ParameterRefKinds, refKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 32044, 32565);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10591_32183_32217(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType)
                {
                    var return_v = DelegateInvokeMethod(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 32183, 32217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10591_32249_32317(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                invokeMethod, out Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.DelegateReturnTypeWithAnnotations(invokeMethod, out refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 32249, 32317);
                    return return_v;
                }


                bool
                f_10591_32392_32399()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 32392, 32399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey
                f_10591_32347_32400(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, bool
                isAsync)
                {
                    var return_v = ReturnInferenceCacheKey.Create(delegateType, isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 32347, 32400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10591_32471_32490()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 32471, 32490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10591_32422_32553(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.CreateLambdaSymbol(containingSymbol, returnType, diagnostics, parameterTypes, parameterRefKinds, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 32422, 32553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 32044, 32565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 32044, 32565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ValidateUnsafeParameters(DiagnosticBag diagnostics, ImmutableArray<TypeWithAnnotations> targetParameterTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 32577, 33767);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 33115, 33756) || true) && (f_10591_33119_33136(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 33115, 33756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 33343, 33424);

                    var
                    numParametersToCheck = f_10591_33370_33423(targetParameterTypes.Length, f_10591_33408_33422())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 33451, 33456);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 33442, 33741) || true) && (i < numParametersToCheck)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 33484, 33487)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 33442, 33741))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 33442, 33741);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 33529, 33722) || true) && (f_10591_33533_33572(targetParameterTypes[i].Type))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 33529, 33722);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 33622, 33699);

                                f_10591_33622_33698(this.Binder, f_10591_33659_33684(this, i), diagnostics);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 33529, 33722);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 300);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 300);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 33115, 33756);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 32577, 33767);

                bool
                f_10591_33119_33136(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param)
                {
                    var return_v = this_param.HasSignature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 33119, 33136);
                    return return_v;
                }


                int
                f_10591_33408_33422()
                {
                    var return_v = ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 33408, 33422);
                    return return_v;
                }


                int
                f_10591_33370_33423(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 33370, 33423);
                    return return_v;
                }


                bool
                f_10591_33533_33572(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsUnsafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 33533, 33572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10591_33659_33684(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterLocation(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 33659, 33684);
                    return return_v;
                }


                bool
                f_10591_33622_33698(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ReportUnsafeIfNotAllowed(location, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 33622, 33698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 32577, 33767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 32577, 33767);
            }
        }

        private BoundLambda ReallyInferReturnType(
                    NamedTypeSymbol delegateType,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 33779, 35651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 34010, 34168);

                (var lambdaSymbol, var block, var lambdaBodyBinder, var diagnostics) = f_10591_34081_34167(this, parameterTypes, parameterRefKinds, returnType: default);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 34182, 34272);

                var
                returnTypes = f_10591_34200_34271()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 34286, 34346);

                f_10591_34286_34345(returnTypes, block);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 34360, 34526);

                var
                inferredReturnType = f_10591_34385_34525(returnTypes, _unboundLambda, lambdaBodyBinder, delegateType, f_10591_34474_34494(lambdaSymbol), f_10591_34496_34524(lambdaBodyBinder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 34540, 34896);

                var
                result = new BoundLambda(
                                _unboundLambda.Syntax,
                                _unboundLambda,
                                block,
                f_10591_34684_34715(diagnostics),
                                lambdaBodyBinder,
                                delegateType,
                                inferredReturnType)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10591_34858_34893(_unboundLambda), 10591, 34553, 34895) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 35019, 35075);

                var
                returnType = inferredReturnType.TypeWithAnnotations
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 35089, 35488) || true) && (f_10591_35093_35112_M(!returnType.HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 35089, 35488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 35146, 35191);

                    bool
                    forErrorRecovery = delegateType is null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 35209, 35473);

                    returnType = (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 35222, 35266) || (((forErrorRecovery && (DynAbs.Tracing.TraceSender.Expression_True(10591, 35223, 35265) && f_10591_35243_35260(returnTypes) == 0))
                    && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 35290, 35381)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 35405, 35472))) ? TypeWithAnnotations.Create(f_10591_35317_35380(f_10591_35317_35340(this.Binder), SpecialType.System_Void)) : TypeWithAnnotations.Create(LambdaSymbol.InferenceFailureReturnType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 35089, 35488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 35504, 35579);

                f_10591_35504_35578(
                            lambdaSymbol, inferredReturnType.RefKind, returnType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 35593, 35612);

                f_10591_35593_35611(returnTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 35626, 35640);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 33779, 35651);

                (Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol lambdaSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder lambdaBodyBinder, Microsoft.CodeAnalysis.DiagnosticBag diagnostics)
                f_10591_34081_34167(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType)
                {
                    var return_v = this_param.BindWithParameterAndReturnType(parameterTypes, parameterRefKinds, returnType: returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 34081, 34167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                f_10591_34200_34271()
                {
                    var return_v = ArrayBuilder<(BoundReturnStatement, TypeWithAnnotations)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 34200, 34271);
                    return return_v;
                }


                int
                f_10591_34286_34345(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                builder, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    BoundLambda.BlockReturns.GetReturnTypes(builder, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 34286, 34345);
                    return 0;
                }


                bool
                f_10591_34474_34494(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 34474, 34494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10591_34496_34524(Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 34496, 34524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType
                f_10591_34385_34525(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                returnTypes, Microsoft.CodeAnalysis.CSharp.UnboundLambda
                node, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                binder, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, bool
                isAsync, Microsoft.CodeAnalysis.CSharp.Conversions
                conversions)
                {
                    var return_v = BoundLambda.InferReturnType(returnTypes, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, (Microsoft.CodeAnalysis.CSharp.Binder)binder, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)delegateType, isAsync, (Microsoft.CodeAnalysis.CSharp.ConversionsBase)conversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 34385, 34525);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10591_34684_34715(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.ToReadOnlyAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 34684, 34715);
                    return return_v;
                }


                bool
                f_10591_34858_34893(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.WasCompilerGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 34858, 34893);
                    return return_v;
                }


                bool
                f_10591_35093_35112_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 35093, 35112);
                    return return_v;
                }


                int
                f_10591_35243_35260(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 35243, 35260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10591_35317_35340(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 35317, 35340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10591_35317_35380(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 35317, 35380);
                    return return_v;
                }


                int
                f_10591_35504_35578(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param, Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                inferredReturnType)
                {
                    this_param.SetInferredReturnType(refKind, inferredReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 35504, 35578);
                    return 0;
                }


                int
                f_10591_35593_35611(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 35593, 35611);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 33779, 35651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 33779, 35651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private (LambdaSymbol lambdaSymbol, BoundBlock block, ExecutableCodeBinder lambdaBodyBinder, DiagnosticBag diagnostics) BindWithDelegateAndReturnType(
                    NamedTypeSymbol delegateType,
                    TypeWithAnnotations returnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 35663, 36123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 35926, 35995);

                var
                cacheKey = f_10591_35941_35994(delegateType, f_10591_35986_35993())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 36009, 36112);

                return f_10591_36016_36111(this, cacheKey.ParameterTypes, cacheKey.ParameterRefKinds, returnType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 35663, 36123);

                bool
                f_10591_35986_35993()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 35986, 35993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey
                f_10591_35941_35994(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, bool
                isAsync)
                {
                    var return_v = ReturnInferenceCacheKey.Create(delegateType, isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 35941, 35994);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol lambdaSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder lambdaBodyBinder, Microsoft.CodeAnalysis.DiagnosticBag diagnostics)
                f_10591_36016_36111(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType)
                {
                    var return_v = this_param.BindWithParameterAndReturnType(parameterTypes, parameterRefKinds, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 36016, 36111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 35663, 36123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 35663, 36123);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private (LambdaSymbol lambdaSymbol, BoundBlock block, ExecutableCodeBinder lambdaBodyBinder, DiagnosticBag diagnostics) BindWithParameterAndReturnType(
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds,
                    TypeWithAnnotations returnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 36135, 37259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 36477, 36523);

                var
                diagnostics = f_10591_36495_36522()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 36537, 36950);

                var
                lambdaSymbol = f_10591_36556_36949(this, f_10591_36575_36606(Binder), returnType, diagnostics, parameterTypes, parameterRefKinds, CodeAnalysis.RefKind.None)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 36964, 37088);

                var
                lambdaBodyBinder = f_10591_36987_37087(_unboundLambda.Syntax, lambdaSymbol, f_10591_37049_37086(this, lambdaSymbol, Binder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 37102, 37174);

                var
                block = f_10591_37114_37173(this, lambdaSymbol, lambdaBodyBinder, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 37188, 37248);

                return (lambdaSymbol, block, lambdaBodyBinder, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 36135, 37259);

                Microsoft.CodeAnalysis.DiagnosticBag
                f_10591_36495_36522()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 36495, 36522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10591_36575_36606(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingMemberOrLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 36575, 36606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10591_36556_36949(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol?
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds, Microsoft.CodeAnalysis.RefKind
                refKind)
                {
                    var return_v = this_param.CreateLambdaSymbol(containingSymbol, returnType, diagnostics, parameterTypes, parameterRefKinds, refKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 36556, 36949);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10591_37049_37086(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                lambdaSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = this_param.ParameterBinder(lambdaSymbol, binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 37049, 37086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10591_36987_37087(Microsoft.CodeAnalysis.SyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder(root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 36987, 37087);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10591_37114_37173(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                lambdaSymbol, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                lambdaBodyBinder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindLambdaBody(lambdaSymbol, (Microsoft.CodeAnalysis.CSharp.Binder)lambdaBodyBinder, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 37114, 37173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 36135, 37259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 36135, 37259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLambda BindForReturnTypeInference(NamedTypeSymbol delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 37271, 37839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 37371, 37440);

                var
                cacheKey = f_10591_37386_37439(delegateType, f_10591_37431_37438())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 37456, 37475);

                BoundLambda
                result
                = default(BoundLambda);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 37489, 37798) || true) && (!f_10591_37494_37549(_returnInferenceCache, cacheKey, out result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 37489, 37798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 37583, 37681);

                    result = f_10591_37592_37680(this, delegateType, cacheKey.ParameterTypes, cacheKey.ParameterRefKinds);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 37699, 37783);

                    result = f_10591_37708_37782(ref _returnInferenceCache, cacheKey, result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 37489, 37798);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 37814, 37828);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 37271, 37839);

                bool
                f_10591_37431_37438()
                {
                    var return_v = IsAsync;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 37431, 37438);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey
                f_10591_37386_37439(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, bool
                isAsync)
                {
                    var return_v = ReturnInferenceCacheKey.Create(delegateType, isAsync);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 37386, 37439);
                    return return_v;
                }


                bool
                f_10591_37494_37549(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                this_param, Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey
                key, out Microsoft.CodeAnalysis.CSharp.BoundLambda
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 37494, 37549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_37592_37680(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds)
                {
                    var return_v = this_param.ReallyInferReturnType(delegateType, parameterTypes, parameterRefKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 37592, 37680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_37708_37782(ref System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                location, Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey
                key, Microsoft.CodeAnalysis.CSharp.BoundLambda
                value)
                {
                    var return_v = ImmutableInterlocked.GetOrAdd(ref location, key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 37708, 37782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 37271, 37839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 37271, 37839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class ReturnInferenceCacheKey
        {
            public readonly ImmutableArray<TypeWithAnnotations> ParameterTypes;

            public readonly ImmutableArray<RefKind> ParameterRefKinds;

            public readonly NamedTypeSymbol TaskLikeReturnTypeOpt;

            public static readonly ReturnInferenceCacheKey Empty;

            private ReturnInferenceCacheKey(ImmutableArray<TypeWithAnnotations> parameterTypes, ImmutableArray<RefKind> parameterRefKinds, NamedTypeSymbol taskLikeReturnTypeOpt)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10591, 38474, 39149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 38257, 38278);
                    object? builderArgument = default(object?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 38672, 38736);

                    f_10591_38672_38735(parameterTypes.Length == parameterRefKinds.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 38754, 38949);

                    f_10591_38754_38948((object)taskLikeReturnTypeOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10591, 38767, 38947) || ((object)taskLikeReturnTypeOpt == f_10591_38842_38879(taskLikeReturnTypeOpt) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 38809, 38946) && f_10591_38883_38946(taskLikeReturnTypeOpt, out builderArgument)))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 38967, 39004);

                    this.ParameterTypes = parameterTypes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39022, 39065);

                    this.ParameterRefKinds = parameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39083, 39134);

                    this.TaskLikeReturnTypeOpt = taskLikeReturnTypeOpt;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10591, 38474, 39149);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 38474, 39149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 38474, 39149);
                }
            }

            public override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 39165, 40178);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39237, 39333) || true) && ((object)this == obj)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 39237, 39333);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39302, 39314);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 39237, 39333);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39353, 39396);

                    var
                    other = obj as ReturnInferenceCacheKey
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39416, 39734) || true) && ((object)other == null || (DynAbs.Tracing.TraceSender.Expression_False(10591, 39420, 39523) || other.ParameterTypes.Length != this.ParameterTypes.Length) || (DynAbs.Tracing.TraceSender.Expression_False(10591, 39420, 39660) || !f_10591_39549_39660(other.TaskLikeReturnTypeOpt, this.TaskLikeReturnTypeOpt, TypeCompareKind.ConsiderEverything2)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 39416, 39734);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39702, 39715);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 39416, 39734);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39763, 39768);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39754, 40131) || true) && (i < this.ParameterTypes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39802, 39805)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 39754, 40131))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 39754, 40131);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 39847, 40112) || true) && (!other.ParameterTypes[i].Equals(this.ParameterTypes[i], TypeCompareKind.ConsiderEverything) || (DynAbs.Tracing.TraceSender.Expression_False(10591, 39851, 40026) || other.ParameterRefKinds[i] != this.ParameterRefKinds[i]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 39847, 40112);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 40076, 40089);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 39847, 40112);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 378);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 378);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 40151, 40163);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 39165, 40178);

                    bool
                    f_10591_39549_39660(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 39549, 39660);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 39165, 40178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 39165, 40178);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 40194, 40513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 40260, 40314);

                    var
                    value = f_10591_40272_40308_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(TaskLikeReturnTypeOpt, 10591, 40272, 40308)?.GetHashCode()) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10591, 40272, 40313) ?? 0)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 40332, 40467);
                        foreach (var type in f_10591_40353_40367_I(ParameterTypes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 40332, 40467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 40409, 40448);

                            value = f_10591_40417_40447(type.Type, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 40332, 40467);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 136);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 136);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 40485, 40498);

                    return value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 40194, 40513);

                    int?
                    f_10591_40272_40308_I(int?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 40272, 40308);
                        return return_v;
                    }


                    int
                    f_10591_40417_40447(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    newKeyPart, int
                    currentKey)
                    {
                        var return_v = Hash.Combine(newKeyPart, currentKey);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 40417, 40447);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10591_40353_40367_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 40353, 40367);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 40194, 40513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 40194, 40513);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static ReturnInferenceCacheKey Create(NamedTypeSymbol delegateType, bool isAsync)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 40529, 42852);
                    object? builderType = default(object?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 40835, 40898);

                    var
                    parameterTypes = ImmutableArray<TypeWithAnnotations>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 40916, 40970);

                    var
                    parameterRefKinds = ImmutableArray<RefKind>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 40988, 41033);

                    NamedTypeSymbol
                    taskLikeReturnTypeOpt = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41051, 41108);

                    MethodSymbol
                    invoke = f_10591_41073_41107(delegateType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41126, 42534) || true) && ((object)invoke != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 41126, 42534);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41194, 41237);

                        int
                        parameterCount = f_10591_41215_41236(invoke)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41259, 41944) || true) && (parameterCount > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 41259, 41944);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41331, 41412);

                            var
                            typesBuilder = f_10591_41350_41411(parameterCount)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41438, 41510);

                            var
                            refKindsBuilder = f_10591_41460_41509(parameterCount)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41538, 41759);
                                foreach (var p in f_10591_41556_41573_I(f_10591_41556_41573(invoke)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 41538, 41759);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41631, 41662);

                                    f_10591_41631_41661(refKindsBuilder, f_10591_41651_41660(p));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41692, 41732);

                                    f_10591_41692_41731(typesBuilder, f_10591_41709_41730(p));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 41538, 41759);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 222);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 222);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41787, 41838);

                            parameterTypes = f_10591_41804_41837(typesBuilder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41864, 41921);

                            parameterRefKinds = f_10591_41884_41920(refKindsBuilder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 41259, 41944);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 41968, 42515) || true) && (isAsync)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 41968, 42515);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 42029, 42091);

                            var
                            delegateReturnType = f_10591_42054_42071(invoke) as NamedTypeSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 42117, 42492) || true) && ((object)delegateReturnType != null && (DynAbs.Tracing.TraceSender.Expression_True(10591, 42121, 42191) && !f_10591_42160_42191(delegateReturnType)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 42117, 42492);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 42249, 42465) || true) && (f_10591_42253_42309(delegateReturnType, out builderType))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 42249, 42465);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 42375, 42434);

                                    taskLikeReturnTypeOpt = f_10591_42399_42433(delegateReturnType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 42249, 42465);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 42117, 42492);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 41968, 42515);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 41126, 42534);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 42554, 42724) || true) && (parameterTypes.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10591, 42558, 42609) && parameterRefKinds.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 42558, 42650) && (object)taskLikeReturnTypeOpt == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 42554, 42724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 42692, 42705);

                        return Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 42554, 42724);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 42744, 42837);

                    return f_10591_42751_42836(parameterTypes, parameterRefKinds, taskLikeReturnTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 40529, 42852);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10591_41073_41107(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    delegateType)
                    {
                        var return_v = DelegateInvokeMethod(delegateType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 41073, 41107);
                        return return_v;
                    }


                    int
                    f_10591_41215_41236(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 41215, 41236);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10591_41350_41411(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 41350, 41411);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                    f_10591_41460_41509(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<RefKind>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 41460, 41509);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10591_41556_41573(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 41556, 41573);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10591_41651_41660(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 41651, 41660);
                        return return_v;
                    }


                    int
                    f_10591_41631_41661(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                    this_param, Microsoft.CodeAnalysis.RefKind
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 41631, 41661);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10591_41709_41730(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 41709, 41730);
                        return return_v;
                    }


                    int
                    f_10591_41692_41731(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 41692, 41731);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10591_41556_41573_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 41556, 41573);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10591_41804_41837(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 41804, 41837);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                    f_10591_41884_41920(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 41884, 41920);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10591_42054_42071(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 42054, 42071);
                        return return_v;
                    }


                    bool
                    f_10591_42160_42191(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsVoidType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 42160, 42191);
                        return return_v;
                    }


                    bool
                    f_10591_42253_42309(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, out object?
                    builderArgument)
                    {
                        var return_v = type.IsCustomTaskType(out builderArgument);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 42253, 42309);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10591_42399_42433(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstructedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 42399, 42433);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey
                    f_10591_42751_42836(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                    parameterRefKinds, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    taskLikeReturnTypeOpt)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey(parameterTypes, parameterRefKinds, taskLikeReturnTypeOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 42751, 42836);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 40529, 42852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 40529, 42852);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ReturnInferenceCacheKey()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10591, 38003, 42863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 38342, 38457);
                Empty = f_10591_38350_38457(ImmutableArray<TypeWithAnnotations>.Empty, ImmutableArray<RefKind>.Empty, null); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10591, 38003, 42863);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 38003, 42863);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10591, 38003, 42863);

            static Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey
            f_10591_38350_38457(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
            parameterRefKinds, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            taskLikeReturnTypeOpt)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey(parameterTypes, parameterRefKinds, taskLikeReturnTypeOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 38350, 38457);
                return return_v;
            }


            int
            f_10591_38672_38735(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 38672, 38735);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10591_38842_38879(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.ConstructedFrom;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 38842, 38879);
                return return_v;
            }


            bool
            f_10591_38883_38946(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            type, out object?
            builderArgument)
            {
                var return_v = type.IsCustomTaskType(out builderArgument);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 38883, 38946);
                return return_v;
            }


            int
            f_10591_38754_38948(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 38754, 38948);
                return 0;
            }

        }

        public virtual Binder ParameterBinder(LambdaSymbol lambdaSymbol, Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 42875, 43050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 42979, 43039);

                return f_10591_42986_43038(lambdaSymbol, binder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 42875, 43050);

                Microsoft.CodeAnalysis.CSharp.WithLambdaParametersBinder
                f_10591_42986_43038(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                lambdaSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                enclosing)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.WithLambdaParametersBinder(lambdaSymbol, enclosing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 42986, 43038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 42875, 43050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 42875, 43050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public BoundLambda BindForErrorRecovery()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 44279, 45054);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 44849, 45006) || true) && (_errorBinding == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 44849, 45006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 44908, 44991);

                    f_10591_44908_44990(ref _errorBinding, f_10591_44955_44983(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 44849, 45006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 45022, 45043);

                return _errorBinding;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 44279, 45054);

                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_44955_44983(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param)
                {
                    var return_v = this_param.ReallyBindForErrorRecovery();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 44955, 44983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda?
                f_10591_44908_44990(ref Microsoft.CodeAnalysis.CSharp.BoundLambda?
                location1, Microsoft.CodeAnalysis.CSharp.BoundLambda
                value, Microsoft.CodeAnalysis.CSharp.BoundLambda?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 44908, 44990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 44279, 45054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 44279, 45054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundLambda ReallyBindForErrorRecovery()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 45066, 47612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 45313, 45575);

                return
                f_10591_45337_45372(_bindingCache) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundLambda>(10591, 45337, 45574) ?? f_10591_45393_45444(f_10591_45400_45443(_returnInferenceCache)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundLambda>(10591, 45393, 45574) ?? f_10591_45465_45574(f_10591_45472_45573(this, null, ImmutableArray<TypeWithAnnotations>.Empty, ImmutableArray<RefKind>.Empty))));

                BoundLambda rebind(BoundLambda lambda)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 45688, 47601);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 45759, 45812) || true) && (lambda is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 45759, 45812);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 45800, 45812);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 45759, 45812);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 45830, 45878);

                        var
                        delegateType = (NamedTypeSymbol)f_10591_45866_45877(lambda)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 45896, 45968);

                        InferredLambdaReturnType
                        inferredReturnType = f_10591_45942_45967(lambda)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 45986, 46042);

                        var
                        returnType = inferredReturnType.TypeWithAnnotations
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 46060, 46096);

                        var
                        refKind = f_10591_46074_46095(f_10591_46074_46087(lambda))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 46114, 46891) || true) && (f_10591_46118_46137_M(!returnType.HasType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 46114, 46891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 46179, 46233);

                            var
                            invokeMethod = f_10591_46198_46232(delegateType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 46255, 46329);

                            returnType = f_10591_46268_46328(this, invokeMethod, out refKind);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 46351, 46872) || true) && (f_10591_46355_46374_M(!returnType.HasType) || (DynAbs.Tracing.TraceSender.Expression_False(10591, 46355, 46417) || f_10591_46378_46417(returnType.Type)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 46351, 46872);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 46467, 46718);

                                var
                                t = (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 46475, 46561) || (((inferredReturnType.HadExpressionlessReturn || (DynAbs.Tracing.TraceSender.Expression_False(10591, 46476, 46560) || inferredReturnType.NumExpressions == 0))
                                && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 46593, 46656)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 46688, 46717))) ? f_10591_46593_46656(f_10591_46593_46616(this.Binder), SpecialType.System_Void) : f_10591_46688_46717(this.Binder)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 46744, 46787);

                                returnType = TypeWithAnnotations.Create(t);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 46813, 46849);

                                refKind = CodeAnalysis.RefKind.None;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 46351, 46872);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 46114, 46891);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 46911, 47038);

                        (var lambdaSymbol, var block, var lambdaBodyBinder, var diagnostics) = f_10591_46982_47037(this, delegateType, returnType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 47056, 47586);

                        return new BoundLambda(
                                            _unboundLambda.Syntax,
                                            _unboundLambda,
                                            block,
                        f_10591_47210_47241(diagnostics),
                                            lambdaBodyBinder,
                                            delegateType,
                        f_10591_47338_47504(inferredReturnType.NumExpressions, inferredReturnType.HadExpressionlessReturn, refKind, returnType, ImmutableArray<DiagnosticInfo>.Empty))
                        { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_10591_47548_47583(_unboundLambda), 10591, 47063, 47585) };
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 45688, 47601);

                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                        f_10591_45866_45877(Microsoft.CodeAnalysis.CSharp.BoundLambda
                        this_param)
                        {
                            var return_v = this_param.Type;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 45866, 45877);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType
                        f_10591_45942_45967(Microsoft.CodeAnalysis.CSharp.BoundLambda
                        this_param)
                        {
                            var return_v = this_param.InferredReturnType;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 45942, 45967);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        f_10591_46074_46087(Microsoft.CodeAnalysis.CSharp.BoundLambda
                        this_param)
                        {
                            var return_v = this_param.Symbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 46074, 46087);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.RefKind
                        f_10591_46074_46095(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                        this_param)
                        {
                            var return_v = this_param.RefKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 46074, 46095);
                            return return_v;
                        }


                        bool
                        f_10591_46118_46137_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 46118, 46137);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10591_46198_46232(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                        delegateType)
                        {
                            var return_v = DelegateInvokeMethod(delegateType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 46198, 46232);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10591_46268_46328(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        invokeMethod, out Microsoft.CodeAnalysis.RefKind
                        refKind)
                        {
                            var return_v = this_param.DelegateReturnTypeWithAnnotations(invokeMethod, out refKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 46268, 46328);
                            return return_v;
                        }


                        bool
                        f_10591_46355_46374_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 46355, 46374);
                            return return_v;
                        }


                        bool
                        f_10591_46378_46417(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type)
                        {
                            var return_v = type.ContainsTypeParameter();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 46378, 46417);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10591_46593_46616(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 46593, 46616);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10591_46593_46656(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param, Microsoft.CodeAnalysis.SpecialType
                        specialType)
                        {
                            var return_v = this_param.GetSpecialType(specialType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 46593, 46656);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        f_10591_46688_46717(Microsoft.CodeAnalysis.CSharp.Binder
                        this_param)
                        {
                            var return_v = this_param.CreateErrorType();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 46688, 46717);
                            return return_v;
                        }


                        (Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol lambdaSymbol, Microsoft.CodeAnalysis.CSharp.BoundBlock block, Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder lambdaBodyBinder, Microsoft.CodeAnalysis.DiagnosticBag diagnostics)
                        f_10591_46982_47037(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        delegateType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        returnType)
                        {
                            var return_v = this_param.BindWithDelegateAndReturnType(delegateType, returnType);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 46982, 47037);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                        f_10591_47210_47241(Microsoft.CodeAnalysis.DiagnosticBag
                        this_param)
                        {
                            var return_v = this_param.ToReadOnlyAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 47210, 47241);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType
                        f_10591_47338_47504(int
                        numExpressions, bool
                        hadExpressionlessReturn, Microsoft.CodeAnalysis.RefKind
                        refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        typeWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.InferredLambdaReturnType(numExpressions, hadExpressionlessReturn, refKind, typeWithAnnotations, useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 47338, 47504);
                            return return_v;
                        }


                        bool
                        f_10591_47548_47583(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                        this_param)
                        {
                            var return_v = this_param.WasCompilerGenerated;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 47548, 47583);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 45688, 47601);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 45688, 47601);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 45066, 47612);

                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_45337_45372(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                candidates)
                {
                    var return_v = GuessBestBoundLambda(candidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 45337, 45372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_45400_45443(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.UnboundLambdaState.ReturnInferenceCacheKey, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                candidates)
                {
                    var return_v = GuessBestBoundLambda(candidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 45400, 45443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_45393_45444(Microsoft.CodeAnalysis.CSharp.BoundLambda
                lambda)
                {
                    var return_v = rebind(lambda);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 45393, 45444);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_45472_45573(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds)
                {
                    var return_v = this_param.ReallyInferReturnType(delegateType, parameterTypes, parameterRefKinds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 45472, 45573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10591_45465_45574(Microsoft.CodeAnalysis.CSharp.BoundLambda
                lambda)
                {
                    var return_v = rebind(lambda);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 45465, 45574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 45066, 47612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 45066, 47612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundLambda GuessBestBoundLambda<T>(ImmutableDictionary<T, BoundLambda> candidates)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 47624, 48622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 47747, 48611);

                switch (f_10591_47755_47771<T>(candidates))
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 47747, 48611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 47834, 47846);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 47747, 48611);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 47747, 48611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 47893, 47925);

                        return f_10591_47900_47918<T>(candidates).Value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 47747, 48611);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 47747, 48611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 48039, 48201);

                        IEnumerable<KeyValuePair<T, BoundLambda>>
                        minDiagnosticsGroup = f_10591_48103_48200<T>(f_10591_48103_48192<T>(f_10591_48103_48164<T>(candidates, lambda => lambda.Value.Diagnostics.Length), group => group.Key))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 48408, 48596);

                        return f_10591_48415_48563<T>(f_10591_48415_48520<T>(minDiagnosticsGroup
                        , lambda => GetLambdaSortString(lambda.Value.Symbol))).Value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 47747, 48611);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 47624, 48622);

                int
                f_10591_47755_47771<T>(System.Collections.Immutable.ImmutableDictionary<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 47755, 47771);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                f_10591_47900_47918<T>(System.Collections.Immutable.ImmutableDictionary<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                source)
                {
                    var return_v = source.First<System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 47900, 47918);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>>
                f_10591_48103_48164<T>(System.Collections.Immutable.ImmutableDictionary<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                source, System.Func<System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>, int>
                keySelector)
                {
                    var return_v = source.GroupBy<System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>, int>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 48103, 48164);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Linq.IGrouping<int, System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>>
                f_10591_48103_48192<T>(System.Collections.Generic.IEnumerable<System.Linq.IGrouping<int, System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>>
                source, System.Func<System.Linq.IGrouping<int, System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>, int>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Linq.IGrouping<int, System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>, int>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 48103, 48192);
                    return return_v;
                }


                System.Linq.IGrouping<int, System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>
                f_10591_48103_48200<T>(System.Linq.IOrderedEnumerable<System.Linq.IGrouping<int, System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>>
                source)
                {
                    var return_v = source.First<System.Linq.IGrouping<int, System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 48103, 48200);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>
                f_10591_48415_48520<T>(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>
                source, System.Func<System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>, string>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 48415, 48520);
                    return return_v;
                }


                System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>
                f_10591_48415_48563<T>(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>
                source)
                {
                    var return_v = source.FirstOrDefault<System.Collections.Generic.KeyValuePair<T, Microsoft.CodeAnalysis.CSharp.BoundLambda>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 48415, 48563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 47624, 48622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 47624, 48622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetLambdaSortString(LambdaSymbol lambda)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 48634, 49291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 48721, 48769);

                var
                builder = f_10591_48735_48768()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 48785, 48973);
                    foreach (var parameter in f_10591_48811_48828_I(f_10591_48811_48828(lambda)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 48785, 48973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 48862, 48958);

                        f_10591_48862_48957(builder.Builder, f_10591_48885_48956(parameter, f_10591_48911_48955()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 48785, 48973);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 189);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 48989, 49197) || true) && (lambda.ReturnTypeWithAnnotations.HasType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 48989, 49197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 49067, 49182);

                    f_10591_49067_49181(builder.Builder, lambda.ReturnTypeWithAnnotations.ToDisplayString(f_10591_49139_49179()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 48989, 49197);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 49213, 49252);

                var
                result = f_10591_49226_49251(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 49266, 49280);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 48634, 49291);

                Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                f_10591_48735_48768()
                {
                    var return_v = PooledStringBuilder.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 48735, 48768);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10591_48811_48828(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 48811, 48828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10591_48911_48955()
                {
                    var return_v = SymbolDisplayFormat.CSharpErrorMessageFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 48911, 48955);
                    return return_v;
                }


                string
                f_10591_48885_48956(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 48885, 48956);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10591_48862_48957(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 48862, 48957);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10591_48811_48828_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 48811, 48828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolDisplayFormat
                f_10591_49139_49179()
                {
                    var return_v = SymbolDisplayFormat.FullyQualifiedFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 49139, 49179);
                    return return_v;
                }


                System.Text.StringBuilder
                f_10591_49067_49181(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 49067, 49181);
                    return return_v;
                }


                string
                f_10591_49226_49251(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                this_param)
                {
                    var return_v = this_param.ToStringAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 49226, 49251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 48634, 49291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 48634, 49291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool GenerateSummaryErrors(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 49303, 53090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 51456, 51542);

                var
                convBags = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from boundLambda in _bindingCache select boundLambda.Value.Diagnostics, 10591, 51471, 51541)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 51556, 51650);

                var
                retBags = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from boundLambda in _returnInferenceCache.Values select boundLambda.Diagnostics, 10591, 51570, 51649)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 51664, 51703);

                var
                allBags = f_10591_51678_51702(convBags, retBags)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 51719, 51771);

                FirstAmongEqualsSet<Diagnostic>
                intersection = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 51785, 52129);
                    foreach (ImmutableArray<Diagnostic> bag in f_10591_51828_51835_I(allBags))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 51785, 52129);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 51869, 52114) || true) && (intersection == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 51869, 52114);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 51935, 51981);

                            intersection = f_10591_51950_51980(bag);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 51869, 52114);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 51869, 52114);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52063, 52095);

                            f_10591_52063_52094(intersection, bag);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 51869, 52114);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 51785, 52129);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 345);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52145, 52402) || true) && (intersection != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 52145, 52402);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52203, 52387) || true) && (f_10591_52207_52257(intersection))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 52203, 52387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52299, 52334);

                        f_10591_52299_52333(diagnostics, intersection);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52356, 52368);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 52203, 52387);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 52145, 52402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52418, 52463);

                FirstAmongEqualsSet<Diagnostic>
                union = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52479, 52798);
                    foreach (ImmutableArray<Diagnostic> bag in f_10591_52522_52529_I(allBags))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 52479, 52798);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52563, 52783) || true) && (union == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 52563, 52783);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52622, 52661);

                            union = f_10591_52630_52660(bag);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 52563, 52783);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 52563, 52783);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52743, 52764);

                            f_10591_52743_52763(union, bag);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 52563, 52783);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 52479, 52798);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 320);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 320);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52814, 53050) || true) && (union != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 52814, 53050);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52865, 53035) || true) && (f_10591_52869_52912(union))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 52865, 53035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 52954, 52982);

                        f_10591_52954_52981(diagnostics, union);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 53004, 53016);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 52865, 53035);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 52814, 53050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 53066, 53079);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 49303, 53090);

                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_10591_51678_51702(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                first, System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                second)
                {
                    var return_v = first.Concat<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 51678, 51702);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                f_10591_51950_51980(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                bag)
                {
                    var return_v = CreateFirstAmongEqualsSet(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 51950, 51980);
                    return return_v;
                }


                int
                f_10591_52063_52094(Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                items)
                {
                    this_param.IntersectWith((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 52063, 52094);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_10591_51828_51835_I(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 51828, 51835);
                    return return_v;
                }


                bool
                f_10591_52207_52257(Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                set)
                {
                    var return_v = PreventsSuccessfulDelegateConversion(set);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 52207, 52257);
                    return return_v;
                }


                int
                f_10591_52299_52333(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 52299, 52333);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                f_10591_52630_52660(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                bag)
                {
                    var return_v = CreateFirstAmongEqualsSet(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 52630, 52660);
                    return return_v;
                }


                int
                f_10591_52743_52763(Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                items)
                {
                    this_param.UnionWith((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 52743, 52763);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                f_10591_52522_52529_I(System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 52522, 52529);
                    return return_v;
                }


                bool
                f_10591_52869_52912(Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                set)
                {
                    var return_v = PreventsSuccessfulDelegateConversion(set);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 52869, 52912);
                    return return_v;
                }


                int
                f_10591_52954_52981(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 52954, 52981);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 49303, 53090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 49303, 53090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool PreventsSuccessfulDelegateConversion(FirstAmongEqualsSet<Diagnostic> set)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 53102, 53489);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 53220, 53451);
                    foreach (var diagnostic in f_10591_53247_53250_I(set))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 53220, 53451);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 53284, 53436) || true) && (f_10591_53288_53363(f_10591_53347_53362(diagnostic)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 53284, 53436);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 53405, 53417);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 53284, 53436);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 53220, 53451);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 232);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 53465, 53478);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 53102, 53489);

                int
                f_10591_53347_53362(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 53347, 53362);
                    return return_v;
                }


                bool
                f_10591_53288_53363(int
                code)
                {
                    var return_v = ErrorFacts.PreventsSuccessfulDelegateConversion((Microsoft.CodeAnalysis.CSharp.ErrorCode)code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 53288, 53363);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                f_10591_53247_53250_I(Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 53247, 53250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 53102, 53489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 53102, 53489);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static FirstAmongEqualsSet<Diagnostic> CreateFirstAmongEqualsSet(ImmutableArray<Diagnostic> bag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 53501, 54090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 53913, 54079);

                return f_10591_53920_54078(bag, CommonDiagnosticComparer.Instance, CanonicallyCompareDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 53501, 54090);

                Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>
                f_10591_53920_54078(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                items, Microsoft.CodeAnalysis.CommonDiagnosticComparer
                equalityComparer, System.Func<Microsoft.CodeAnalysis.Diagnostic, Microsoft.CodeAnalysis.Diagnostic, int>
                canonicalComparer)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.FirstAmongEqualsSet<Microsoft.CodeAnalysis.Diagnostic>((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Diagnostic>)items, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.Diagnostic>)equalityComparer, canonicalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 53920, 54078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 53501, 54090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 53501, 54090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int CanonicallyCompareDiagnostics(Diagnostic x, Diagnostic y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10591, 54495, 55200);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54640, 54702) || true) && (f_10591_54644_54650(x) != f_10591_54654_54660(y))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 54640, 54702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54679, 54702);

                    return f_10591_54686_54692(x) - f_10591_54695_54701(y);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 54640, 54702);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54718, 54751);

                var
                nx = f_10591_54727_54745_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10591_54727_54738(x), 10591, 54727, 54745)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10591, 54727, 54750) ?? 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54765, 54798);

                var
                ny = f_10591_54774_54792_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10591_54774_54785(y), 10591, 54774, 54792)?.Count) ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(10591, 54774, 54797) ?? 0)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54821, 54826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54828, 54848);
                    for (int
        i = 0
        ,
        n = f_10591_54832_54848(nx, ny)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54812, 55158) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54857, 54860)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 54812, 55158))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 54812, 55158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54894, 54923);

                        object
                        argx = f_10591_54908_54922(f_10591_54908_54919(x), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54941, 54970);

                        object
                        argy = f_10591_54955_54969(f_10591_54955_54966(y), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 54990, 55065);

                        int
                        argCompare = f_10591_55007_55064(f_10591_55029_55045_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(argx, 10591, 55029, 55045)?.ToString()), f_10591_55047_55063_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(argy, 10591, 55047, 55063)?.ToString()))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 55083, 55143) || true) && (argCompare != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 55083, 55143);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 55125, 55143);

                            return argCompare;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 55083, 55143);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10591, 1, 347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10591, 1, 347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 55174, 55189);

                return nx - ny;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10591, 54495, 55200);

                int
                f_10591_54644_54650(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54644, 54650);
                    return return_v;
                }


                int
                f_10591_54654_54660(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54654, 54660);
                    return return_v;
                }


                int
                f_10591_54686_54692(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54686, 54692);
                    return return_v;
                }


                int
                f_10591_54695_54701(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Code;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54695, 54701);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_10591_54727_54738(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54727, 54738);
                    return return_v;
                }


                int?
                f_10591_54727_54745_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54727, 54745);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>
                f_10591_54774_54785(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54774, 54785);
                    return return_v;
                }


                int?
                f_10591_54774_54792_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54774, 54792);
                    return return_v;
                }


                int
                f_10591_54832_54848(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 54832, 54848);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>?
                f_10591_54908_54919(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54908, 54919);
                    return return_v;
                }


                object?
                f_10591_54908_54922(System.Collections.Generic.IReadOnlyList<object?>?
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54908, 54922);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyList<object?>?
                f_10591_54955_54966(Microsoft.CodeAnalysis.Diagnostic
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54955, 54966);
                    return return_v;
                }


                object?
                f_10591_54955_54969(System.Collections.Generic.IReadOnlyList<object?>?
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 54955, 54969);
                    return return_v;
                }


                string?
                f_10591_55029_55045_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 55029, 55045);
                    return return_v;
                }


                string?
                f_10591_55047_55063_I(string?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 55047, 55063);
                    return return_v;
                }


                int
                f_10591_55007_55064(string?
                strA, string?
                strB)
                {
                    var return_v = string.CompareOrdinal(strA, strB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 55007, 55064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 54495, 55200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 54495, 55200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UnboundLambdaState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10591, 19107, 55207);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10591, 19107, 55207);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 19107, 55207);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10591, 19107, 55207);

        int
        f_10591_20208_20236(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 20208, 20236);
            return 0;
        }


        System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundLambda>
        f_10591_20319_20439(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.BoundLambda>
        this_param, System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
        keyComparer)
        {
            var return_v = this_param.WithComparers((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>)keyComparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 20319, 20439);
            return return_v;
        }

    }
    internal sealed class PlainUnboundLambdaState : UnboundLambdaState
    {
        private readonly ImmutableArray<string> _parameterNames;

        private readonly ImmutableArray<bool> _parameterIsDiscardOpt;

        private readonly ImmutableArray<TypeWithAnnotations> _parameterTypesWithAnnotations;

        private readonly ImmutableArray<RefKind> _parameterRefKinds;

        private readonly bool _isAsync;

        private readonly bool _isStatic;

        internal PlainUnboundLambdaState(
                    UnboundLambda unboundLambda,
                    Binder binder,
                    ImmutableArray<string> parameterNames,
                    ImmutableArray<bool> parameterIsDiscardOpt,
                    ImmutableArray<TypeWithAnnotations> parameterTypesWithAnnotations,
                    ImmutableArray<RefKind> parameterRefKinds,
                    bool isAsync,
                    bool isStatic,
                    bool includeCache)
        : base(f_10591_56140_56146_C(binder), unboundLambda, includeCache)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10591, 55684, 56504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 55621, 55629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 55662, 55671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56201, 56234);

                _parameterNames = parameterNames;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56248, 56295);

                _parameterIsDiscardOpt = parameterIsDiscardOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56309, 56372);

                _parameterTypesWithAnnotations = parameterTypesWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56386, 56425);

                _parameterRefKinds = parameterRefKinds;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56439, 56458);

                _isAsync = isAsync;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56472, 56493);

                _isStatic = isStatic;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10591, 55684, 56504);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 55684, 56504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 55684, 56504);
            }
        }

        public override bool HasNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 56548, 56590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56554, 56588);

                    return f_10591_56561_56587_M(!_parameterNames.IsDefault);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 56548, 56590);

                    bool
                    f_10591_56561_56587_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 56561, 56587);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 56516, 56592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 56516, 56592);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasSignature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 56640, 56682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56646, 56680);

                    return f_10591_56653_56679_M(!_parameterNames.IsDefault);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 56640, 56682);

                    bool
                    f_10591_56653_56679_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 56653, 56679);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 56604, 56684);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 56604, 56684);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HasExplicitlyTypedParameterList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 56751, 56808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56757, 56806);

                    return f_10591_56764_56805_M(!_parameterTypesWithAnnotations.IsDefault);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 56751, 56808);

                    bool
                    f_10591_56764_56805_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 56764, 56805);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 56696, 56810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 56696, 56810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 56859, 56929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56865, 56927);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 56872, 56897) || ((_parameterNames.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 56900, 56901)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 56904, 56926))) ? 0 : _parameterNames.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 56859, 56929);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 56822, 56931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 56822, 56931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 56974, 56998);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 56980, 56996);

                    return _isAsync;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 56974, 56998);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 56943, 57000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 56943, 57000);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 57042, 57054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 57045, 57054);
                    return _isStatic; DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 57042, 57054);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 57042, 57054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 57042, 57054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MessageID MessageID
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 57105, 57243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 57111, 57241);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 57118, 57190) || ((f_10591_57118_57150(f_10591_57118_57136(this).Syntax) == SyntaxKind.AnonymousMethodExpression && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 57193, 57217)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 57220, 57240))) ? MessageID.IDS_AnonMethod : MessageID.IDS_Lambda;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 57105, 57243);

                    Microsoft.CodeAnalysis.CSharp.UnboundLambda
                    f_10591_57118_57136(Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState
                    this_param)
                    {
                        var return_v = this_param.UnboundLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 57118, 57136);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10591_57118_57150(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 57118, 57150);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 57067, 57245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 57067, 57245);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CSharpSyntaxNode Body
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 57311, 57414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 57347, 57399);

                    return f_10591_57354_57398(f_10591_57354_57367().Syntax);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 57311, 57414);

                    Microsoft.CodeAnalysis.CSharp.UnboundLambda
                    f_10591_57354_57367()
                    {
                        var return_v = UnboundLambda;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 57354, 57367);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10591_57354_57398(Microsoft.CodeAnalysis.SyntaxNode
                    lambda)
                    {
                        var return_v = lambda.AnonymousFunctionBody();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 57354, 57398);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 57257, 57425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 57257, 57425);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Location ParameterLocation(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 57437, 58277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 57515, 57582);

                f_10591_57515_57581(f_10591_57528_57540() && (DynAbs.Tracing.TraceSender.Expression_True(10591, 57528, 57554) && 0 <= index) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 57528, 57580) && index < f_10591_57566_57580()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 57596, 57630);

                var
                syntax = f_10591_57609_57622().Syntax
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 57644, 58266);

                switch (f_10591_57652_57665(syntax))
                {

                    default:
                    case SyntaxKind.SimpleLambdaExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 57644, 58266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 57786, 57867);

                        return f_10591_57793_57841(((SimpleLambdaExpressionSyntax)syntax)).Identifier.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 57644, 58266);

                    case SyntaxKind.ParenthesizedLambdaExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 57644, 58266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 57953, 58063);

                        return f_10591_57960_58030(f_10591_57960_58019(((ParenthesizedLambdaExpressionSyntax)syntax)))[index].Identifier.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 57644, 58266);

                    case SyntaxKind.AnonymousMethodExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 57644, 58266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 58145, 58251);

                        return f_10591_58152_58218(f_10591_58152_58207(((AnonymousMethodExpressionSyntax)syntax)))[index].Identifier.GetLocation();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 57644, 58266);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 57437, 58277);

                bool
                f_10591_57528_57540()
                {
                    var return_v = HasSignature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 57528, 57540);
                    return return_v;
                }


                int
                f_10591_57566_57580()
                {
                    var return_v = ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 57566, 57580);
                    return return_v;
                }


                int
                f_10591_57515_57581(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 57515, 57581);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambda
                f_10591_57609_57622()
                {
                    var return_v = UnboundLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 57609, 57622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10591_57652_57665(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 57652, 57665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax
                f_10591_57793_57841(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 57793, 57841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                f_10591_57960_58019(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedLambdaExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 57960, 58019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                f_10591_57960_58030(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 57960, 58030);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                f_10591_58152_58207(Microsoft.CodeAnalysis.CSharp.Syntax.AnonymousMethodExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 58152, 58207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ParameterSyntax>
                f_10591_58152_58218(Microsoft.CodeAnalysis.CSharp.Syntax.ParameterListSyntax?
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 58152, 58218);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 57437, 58277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 57437, 58277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsExpressionLambda
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 58323, 58370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 58329, 58368);

                    return f_10591_58336_58347(f_10591_58336_58340()) != SyntaxKind.Block;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 58323, 58370);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10591_58336_58340()
                    {
                        var return_v = Body;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 58336, 58340);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10591_58336_58347(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 58336, 58347);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 58289, 58372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 58289, 58372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ParameterName(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 58384, 58600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 58456, 58545);

                f_10591_58456_58544(f_10591_58469_58495_M(!_parameterNames.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 58469, 58509) && 0 <= index) && (DynAbs.Tracing.TraceSender.Expression_True(10591, 58469, 58543) && index < _parameterNames.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 58559, 58589);

                return _parameterNames[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 58384, 58600);

                bool
                f_10591_58469_58495_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 58469, 58495);
                    return return_v;
                }


                int
                f_10591_58456_58544(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 58456, 58544);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 58384, 58600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 58384, 58600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool ParameterIsDiscard(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 58612, 58778);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 58687, 58767);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 58694, 58726) || ((_parameterIsDiscardOpt.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 58729, 58734)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 58737, 58766))) ? false : _parameterIsDiscardOpt[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 58612, 58778);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 58612, 58778);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 58612, 58778);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override RefKind RefKind(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 58790, 59058);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 58857, 58931);

                f_10591_58857_58930(0 <= index && (DynAbs.Tracing.TraceSender.Expression_True(10591, 58870, 58929) && index < _parameterTypesWithAnnotations.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 58945, 59047);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10591, 58952, 58980) || ((_parameterRefKinds.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10591, 58983, 59018)) || DynAbs.Tracing.TraceSender.Conditional_F3(10591, 59021, 59046))) ? Microsoft.CodeAnalysis.RefKind.None : _parameterRefKinds[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 58790, 59058);

                int
                f_10591_58857_58930(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 58857, 58930);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 58790, 59058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 58790, 59058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override TypeWithAnnotations ParameterTypeWithAnnotations(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 59070, 59379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 59170, 59221);

                f_10591_59170_59220(f_10591_59183_59219(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 59235, 59309);

                f_10591_59235_59308(0 <= index && (DynAbs.Tracing.TraceSender.Expression_True(10591, 59248, 59307) && index < _parameterTypesWithAnnotations.Length));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 59323, 59368);

                return _parameterTypesWithAnnotations[index];
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 59070, 59379);

                bool
                f_10591_59183_59219(Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState
                this_param)
                {
                    var return_v = this_param.HasExplicitlyTypedParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 59183, 59219);
                    return return_v;
                }


                int
                f_10591_59170_59220(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 59170, 59220);
                    return 0;
                }


                int
                f_10591_59235_59308(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 59235, 59308);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 59070, 59379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 59070, 59379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override UnboundLambdaState WithCachingCore(bool includeCache)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 59391, 59691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 59488, 59680);

                return f_10591_59495_59679(unboundLambda: null, Binder, _parameterNames, _parameterIsDiscardOpt, _parameterTypesWithAnnotations, _parameterRefKinds, _isAsync, _isStatic, includeCache);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 59391, 59691);

                Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState
                f_10591_59495_59679(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                unboundLambda, Microsoft.CodeAnalysis.CSharp.Binder
                binder, System.Collections.Immutable.ImmutableArray<string>
                parameterNames, System.Collections.Immutable.ImmutableArray<bool>
                parameterIsDiscardOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                parameterTypesWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                parameterRefKinds, bool
                isAsync, bool
                isStatic, bool
                includeCache)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState(unboundLambda: unboundLambda, binder, parameterNames, parameterIsDiscardOpt, parameterTypesWithAnnotations, parameterRefKinds, isAsync, isStatic, includeCache);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 59495, 59679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 59391, 59691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 59391, 59691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundExpression GetLambdaExpressionBody(BoundBlock body)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 59703, 60330);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 59803, 60293) || true) && (f_10591_59807_59825())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 59803, 60293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 59859, 59892);

                    var
                    statements = f_10591_59876_59891(body)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 59910, 60278) || true) && (statements.Length == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10591, 59914, 60205) &&                    // To simplify Binder.CreateBlockFromExpression (used below), we only reuse by-value return values.
                                        statements[0] is BoundReturnStatement { RefKind: Microsoft.CodeAnalysis.RefKind.None, ExpressionOpt: BoundExpression expr }))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 59910, 60278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 60247, 60259);

                        return expr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 59910, 60278);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 59803, 60293);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 60307, 60319);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 59703, 60330);

                bool
                f_10591_59807_59825()
                {
                    var return_v = IsExpressionLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 59807, 59825);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10591_59876_59891(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 59876, 59891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 59703, 60330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 59703, 60330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundBlock CreateBlockFromLambdaExpressionBody(Binder lambdaBodyBinder, BoundExpression expression, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 60342, 60627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 60512, 60616);

                return f_10591_60519_60615(lambdaBodyBinder, f_10591_60580_60589(this), expression, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 60342, 60627);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10591_60580_60589(Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 60580, 60589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10591_60519_60615(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                body, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CreateBlockFromExpression((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)body, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 60519, 60615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 60342, 60627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 60342, 60627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override BoundBlock BindLambdaBody(LambdaSymbol lambdaSymbol, Binder lambdaBodyBinder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10591, 60639, 61113);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 60787, 61102) || true) && (f_10591_60791_60814(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 60787, 61102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 60848, 60942);

                    return f_10591_60855_60941(lambdaBodyBinder, f_10591_60918_60927(this), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 60787, 61102);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10591, 60787, 61102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10591, 61008, 61087);

                    return f_10591_61015_61086(lambdaBodyBinder, f_10591_61063_61072(this), diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10591, 60787, 61102);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10591, 60639, 61113);

                bool
                f_10591_60791_60814(Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState
                this_param)
                {
                    var return_v = this_param.IsExpressionLambda;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 60791, 60814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10591_60918_60927(Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 60918, 60927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10591_60855_60941(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                body, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindLambdaExpressionAsBlock((Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax)body, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 60855, 60941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10591_61063_61072(Microsoft.CodeAnalysis.CSharp.PlainUnboundLambdaState
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10591, 61063, 61072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10591_61015_61086(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindEmbeddedBlock((Microsoft.CodeAnalysis.CSharp.Syntax.BlockSyntax)node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10591, 61015, 61086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10591, 60639, 61113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 60639, 61113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PlainUnboundLambdaState()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10591, 55215, 61120);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10591, 55215, 61120);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10591, 55215, 61120);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10591, 55215, 61120);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10591_56140_56146_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10591, 55684, 56504);
            return return_v;
        }

    }
}
