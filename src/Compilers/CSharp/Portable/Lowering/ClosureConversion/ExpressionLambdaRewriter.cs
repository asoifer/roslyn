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
    internal class ExpressionLambdaRewriter // this is like a bound tree rewriter, but only handles a small subset of node kinds
    {
        private readonly SyntheticBoundNodeFactory _bound;

        private readonly TypeMap _typeMap;

        private readonly Dictionary<ParameterSymbol, BoundExpression> _parameterMap;

        private readonly bool _ignoreAccessibility;

        private int _recursionDepth;

        private NamedTypeSymbol _ExpressionType;

        private NamedTypeSymbol ExpressionType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 1099, 1376);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 1135, 1320) || true) && ((object)_ExpressionType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 1135, 1320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 1212, 1301);

                        _ExpressionType = f_10455_1230_1300(_bound, WellKnownType.System_Linq_Expressions_Expression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 1135, 1320);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 1338, 1361);

                    return _ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 1099, 1376);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10455_1230_1300(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 1230, 1300);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 1036, 1387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 1036, 1387);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private NamedTypeSymbol _ParameterExpressionType;

        private NamedTypeSymbol ParameterExpressionType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 1530, 1843);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 1566, 1778) || true) && ((object)_ParameterExpressionType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 1566, 1778);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 1652, 1759);

                        _ParameterExpressionType = f_10455_1679_1758(_bound, WellKnownType.System_Linq_Expressions_ParameterExpression);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 1566, 1778);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 1796, 1828);

                    return _ParameterExpressionType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 1530, 1843);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10455_1679_1758(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 1679, 1758);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 1458, 1854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 1458, 1854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private NamedTypeSymbol _ElementInitType;

        private NamedTypeSymbol ElementInitType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 1981, 2262);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2017, 2205) || true) && ((object)_ElementInitType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 2017, 2205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2095, 2186);

                        _ElementInitType = f_10455_2114_2185(_bound, WellKnownType.System_Linq_Expressions_ElementInit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 2017, 2205);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2223, 2247);

                    return _ElementInitType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 1981, 2262);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10455_2114_2185(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 2114, 2185);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 1917, 2273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 1917, 2273);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private NamedTypeSymbol _MemberBindingType;

        public NamedTypeSymbol MemberBindingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 2405, 2694);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2441, 2635) || true) && ((object)_MemberBindingType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 2441, 2635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2521, 2616);

                        _MemberBindingType = f_10455_2542_2615(_bound, WellKnownType.System_Linq_Expressions_MemberBinding);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 2441, 2635);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2653, 2679);

                    return _MemberBindingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 2405, 2694);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10455_2542_2615(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 2542, 2615);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 2340, 2705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 2340, 2705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly NamedTypeSymbol _int32Type;

        private readonly NamedTypeSymbol _objectType;

        private readonly NamedTypeSymbol _nullableType;

        private NamedTypeSymbol _MemberInfoType;

        private NamedTypeSymbol MemberInfoType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 3002, 3273);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3038, 3217) || true) && ((object)_MemberInfoType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 3038, 3217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3115, 3198);

                        _MemberInfoType = f_10455_3133_3197(_bound, WellKnownType.System_Reflection_MemberInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 3038, 3217);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3235, 3258);

                    return _MemberInfoType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 3002, 3273);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10455_3133_3197(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.WellKnownType
                    wt)
                    {
                        var return_v = this_param.WellKnownType(wt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 3133, 3197);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 2939, 3284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 2939, 3284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly NamedTypeSymbol _IEnumerableType;

        private DiagnosticBag Diagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 3394, 3428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3400, 3426);

                    return f_10455_3407_3425(_bound);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 3394, 3428);

                    Microsoft.CodeAnalysis.DiagnosticBag
                    f_10455_3407_3425(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Diagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 3407, 3425);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 3358, 3430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 3358, 3430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ExpressionLambdaRewriter(TypeCompilationState compilationState, TypeMap typeMap, SyntaxNode node, int recursionDepth, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10455, 3442, 4240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 693, 699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 735, 743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 816, 882);
                this._parameterMap = f_10455_832_882(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 915, 935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 958, 973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 1010, 1025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 1423, 1447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 1890, 1906);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2309, 2327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2750, 2760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2806, 2817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2863, 2876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 2913, 2928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3329, 3345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3619, 3724);

                _bound = f_10455_3628_3723(null, f_10455_3664_3685(compilationState), node, compilationState, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3738, 3815);

                _ignoreAccessibility = f_10455_3761_3814(compilationState.ModuleBuilderOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3829, 3887);

                _int32Type = f_10455_3842_3886(_bound, SpecialType.System_Int32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3901, 3961);

                _objectType = f_10455_3915_3960(_bound, SpecialType.System_Object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 3975, 4041);

                _nullableType = f_10455_3991_4040(_bound, SpecialType.System_Nullable_T);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 4055, 4147);

                _IEnumerableType = f_10455_4074_4146(_bound, SpecialType.System_Collections_Generic_IEnumerable_T);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 4163, 4182);

                _typeMap = typeMap;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 4196, 4229);

                _recursionDepth = recursionDepth;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10455, 3442, 4240);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 3442, 4240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 3442, 4240);
            }
        }

        internal static BoundNode RewriteLambda(BoundLambda node, TypeCompilationState compilationState, TypeMap typeMap, int recursionDepth, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10455, 4252, 5155);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 4473, 4579);

                    var
                    r = f_10455_4481_4578(compilationState, typeMap, node.Syntax, recursionDepth, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 4597, 4638);

                    var
                    result = f_10455_4610_4637(r, node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 4656, 4914) || true) && (!f_10455_4661_4748(f_10455_4661_4670(node), f_10455_4678_4689(result), TypeCompareKind.IgnoreNullableModifiersForReferenceTypes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 4656, 4914);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 4790, 4895);

                        f_10455_4790_4894(diagnostics, ErrorCode.ERR_MissingPredefinedMember, f_10455_4845_4865(node.Syntax), f_10455_4867_4883(r), "Lambda");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 4656, 4914);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 4932, 4946);

                    return result;
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10455, 4975, 5144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5068, 5099);

                    f_10455_5068_5098(diagnostics, f_10455_5084_5097(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5117, 5129);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10455, 4975, 5144);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10455, 4252, 5155);

                Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                f_10455_4481_4578(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                typeMap, Microsoft.CodeAnalysis.SyntaxNode
                node, int
                recursionDepth, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter(compilationState, typeMap, node, recursionDepth, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 4481, 4578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_4610_4637(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node)
                {
                    var return_v = this_param.VisitLambdaInternal(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 4610, 4637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_4661_4670(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 4661, 4670);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_4678_4689(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 4678, 4689);
                    return return_v;
                }


                bool
                f_10455_4661_4748(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 4661, 4748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10455_4845_4865(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 4845, 4865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_4867_4883(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param)
                {
                    var return_v = this_param.ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 4867, 4883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10455_4790_4894(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 4790, 4894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10455_5084_5097(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 5084, 5097);
                    return return_v;
                }


                int
                f_10455_5068_5098(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 5068, 5098);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 4252, 5155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 4252, 5155);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression TranslateLambdaBody(BoundBlock block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 5167, 6585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5253, 5288);

                f_10455_5253_5287(block.Locals.IsEmpty);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5302, 6546);
                    foreach (var s in f_10455_5320_5336_I(f_10455_5320_5336(block)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 5302, 6546);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5379, 5387);
                            for (var
            stmt = s
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5370, 6531) || true) && (stmt != null)
            ; DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 5370, 6531))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 5370, 6531);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5444, 6512);

                                switch (f_10455_5452_5461(stmt))
                                {

                                    case BoundKind.ReturnStatement:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 5444, 6512);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5572, 5635);

                                        var
                                        result = f_10455_5585_5634(this, f_10455_5591_5633(((BoundReturnStatement)stmt)))
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5665, 5794) || true) && (result != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 5665, 5794);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5749, 5763);

                                            return result;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 5665, 5794);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5824, 5836);

                                        stmt = null;
                                        DynAbs.Tracing.TraceSender.TraceBreak(10455, 5866, 5872);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 5444, 6512);

                                    case BoundKind.ExpressionStatement:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 5444, 6512);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 5963, 6021);

                                        return f_10455_5970_6020(this, f_10455_5976_6019(((BoundExpressionStatement)stmt)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 5444, 6512);

                                    case BoundKind.SequencePoint:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 5444, 6512);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6106, 6153);

                                        stmt = f_10455_6113_6152(((BoundSequencePoint)stmt));
                                        DynAbs.Tracing.TraceSender.TraceBreak(10455, 6183, 6189);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 5444, 6512);

                                    case BoundKind.SequencePointWithSpan:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 5444, 6512);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6282, 6337);

                                        stmt = f_10455_6289_6336(((BoundSequencePointWithSpan)stmt));
                                        DynAbs.Tracing.TraceSender.TraceBreak(10455, 6367, 6373);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 5444, 6512);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 5444, 6512);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6437, 6489);

                                        throw f_10455_6443_6488(f_10455_6478_6487(stmt));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 5444, 6512);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10455, 1, 1162);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10455, 1, 1162);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 5302, 6546);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10455, 1, 1245);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10455, 1, 1245);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6562, 6574);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 5167, 6585);

                int
                f_10455_5253_5287(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 5253, 5287);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10455_5320_5336(Microsoft.CodeAnalysis.CSharp.BoundBlock
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 5320, 5336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10455_5452_5461(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 5452, 5461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10455_5591_5633(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                this_param)
                {
                    var return_v = this_param.ExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 5591, 5633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_5585_5634(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 5585, 5634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_5976_6019(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 5976, 6019);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_5970_6020(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 5970, 6020);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10455_6113_6152(Microsoft.CodeAnalysis.CSharp.BoundSequencePoint
                this_param)
                {
                    var return_v = this_param.StatementOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 6113, 6152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement?
                f_10455_6289_6336(Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan
                this_param)
                {
                    var return_v = this_param.StatementOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 6289, 6336);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10455_6478_6487(Microsoft.CodeAnalysis.CSharp.BoundStatement
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 6478, 6487);
                    return return_v;
                }


                System.Exception
                f_10455_6443_6488(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 6443, 6488);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                f_10455_5320_5336_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 5320, 5336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 5167, 6585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 5167, 6585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression Visit(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 6597, 6991);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6673, 6750) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 6673, 6750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6723, 6735);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 6673, 6750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6766, 6797);

                SyntaxNode
                old = f_10455_6783_6796(_bound)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6811, 6839);

                _bound.Syntax = node.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6853, 6886);

                var
                result = f_10455_6866_6885(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6900, 6920);

                _bound.Syntax = old;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 6934, 6980);

                return f_10455_6941_6979(_bound, f_10455_6956_6970(), result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 6597, 6991);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10455_6783_6796(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Syntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 6783, 6796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_6866_6885(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitInternal(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 6866, 6885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_6956_6970()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 6956, 6970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_6941_6979(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 6941, 6979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 6597, 6991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 6597, 6991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitExpressionWithoutStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 7003, 11207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 7106, 11196);

                switch (f_10455_7114_7123(node))
                {

                    case BoundKind.ArrayAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 7206, 7254);

                        return f_10455_7213_7253(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.ArrayCreation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 7323, 7375);

                        return f_10455_7330_7374(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.ArrayLength:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 7442, 7490);

                        return f_10455_7449_7489(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.AsOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 7556, 7602);

                        return f_10455_7563_7601(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.BaseReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 7671, 7723);

                        return f_10455_7678_7722(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.BinaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 7793, 7831);

                        var
                        binOp = (BoundBinaryOperator)node
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 7853, 7954);

                        return f_10455_7860_7953(this, f_10455_7880_7898(binOp), f_10455_7900_7915(binOp), f_10455_7917_7927(binOp), f_10455_7929_7939(binOp), f_10455_7941_7952(binOp));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.UserDefinedConditionalLogicalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 8047, 8119);

                        var
                        userDefCondLogOp = (BoundUserDefinedConditionalLogicalOperator)node
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 8141, 8303);

                        return f_10455_8148_8302(this, f_10455_8168_8197(userDefCondLogOp), f_10455_8199_8231(userDefCondLogOp), f_10455_8233_8254(userDefCondLogOp), f_10455_8256_8277(userDefCondLogOp), f_10455_8279_8301(userDefCondLogOp));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 8363, 8397);

                        return f_10455_8370_8396(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.ConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 8472, 8536);

                        return f_10455_8479_8535(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 8602, 8648);

                        return f_10455_8609_8647(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.PassByCopy:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 8714, 8763);

                        return f_10455_8721_8762(this, f_10455_8727_8761(((BoundPassByCopy)node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.DelegateCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 8845, 8923);

                        return f_10455_8852_8922(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 8990, 9031);

                        var
                        fieldAccess = (BoundFieldAccess)node
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 9053, 9198) || true) && (f_10455_9057_9096(f_10455_9057_9080(fieldAccess)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 9053, 9198);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 9146, 9175);

                            return f_10455_9153_9174(this, fieldAccess);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 9053, 9198);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 9220, 9257);

                        return f_10455_9227_9256(this, fieldAccess);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.IsOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 9323, 9369);

                        return f_10455_9330_9368(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.Lambda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 9431, 9469);

                        return f_10455_9438_9468(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.NewT:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 9529, 9563);

                        return f_10455_9536_9562(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.NullCoalescingOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 9641, 9711);

                        return f_10455_9648_9710(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.ObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 9791, 9865);

                        return f_10455_9798_9864(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 9930, 9974);

                        return f_10455_9937_9973(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.PointerIndirectionOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 10056, 10134);

                        return f_10455_10063_10133(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.PointerElementAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 10210, 10276);

                        return f_10455_10217_10275(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 10346, 10400);

                        return f_10455_10353_10399(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.SizeOfOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 10470, 10524);

                        return f_10455_10477_10523(node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.UnaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 10593, 10645);

                        return f_10455_10600_10644(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    case BoundKind.DefaultExpression:
                    case BoundKind.HostObjectMemberReference:
                    case BoundKind.Literal:
                    case BoundKind.Local:
                    case BoundKind.MethodInfo:
                    case BoundKind.PreviousSubmissionReference:
                    case BoundKind.ThisReference:
                    case BoundKind.TypeOfOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11059, 11081);

                        return f_10455_11066_11080(this, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 7106, 11196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11129, 11181);

                        throw f_10455_11135_11180(f_10455_11170_11179(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 7106, 11196);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 7003, 11207);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10455_7114_7123(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 7114, 7123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_7213_7253(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitArrayAccess((Microsoft.CodeAnalysis.CSharp.BoundArrayAccess)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 7213, 7253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_7330_7374(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitArrayCreation((Microsoft.CodeAnalysis.CSharp.BoundArrayCreation)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 7330, 7374);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_7449_7489(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitArrayLength((Microsoft.CodeAnalysis.CSharp.BoundArrayLength)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 7449, 7489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_7563_7601(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitAsOperator((Microsoft.CodeAnalysis.CSharp.BoundAsOperator)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 7563, 7601);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_7678_7722(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitBaseReference((Microsoft.CodeAnalysis.CSharp.BoundBaseReference)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 7678, 7722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10455_7880_7898(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 7880, 7898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_7900_7915(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 7900, 7915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_7917_7927(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 7917, 7927);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_7929_7939(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 7929, 7939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_7941_7952(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 7941, 7952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_7860_7953(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                opKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                methodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.VisitBinaryOperator(opKind, methodOpt, type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 7860, 7953);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10455_8168_8197(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 8168, 8197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_8199_8231(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.LogicalOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 8199, 8231);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_8233_8254(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 8233, 8254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_8256_8277(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 8256, 8277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_8279_8301(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 8279, 8301);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_8148_8302(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                opKind, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.VisitBinaryOperator(opKind, methodOpt, type, left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 8148, 8302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_8370_8396(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitCall((Microsoft.CodeAnalysis.CSharp.BoundCall)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 8370, 8396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_8479_8535(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitConditionalOperator((Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 8479, 8535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_8609_8647(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitConversion((Microsoft.CodeAnalysis.CSharp.BoundConversion)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 8609, 8647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_8727_8761(Microsoft.CodeAnalysis.CSharp.BoundPassByCopy
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 8727, 8761);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_8721_8762(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 8721, 8762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_8852_8922(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitDelegateCreationExpression((Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 8852, 8922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10455_9057_9080(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 9057, 9080);
                    return return_v;
                }


                bool
                f_10455_9057_9096(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsCapturedFrame;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 9057, 9096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_9153_9174(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                node)
                {
                    var return_v = this_param.Constant((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 9153, 9174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_9227_9256(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                node)
                {
                    var return_v = this_param.VisitFieldAccess(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 9227, 9256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_9330_9368(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitIsOperator((Microsoft.CodeAnalysis.CSharp.BoundIsOperator)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 9330, 9368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_9438_9468(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitLambda((Microsoft.CodeAnalysis.CSharp.BoundLambda)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 9438, 9468);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_9536_9562(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitNewT((Microsoft.CodeAnalysis.CSharp.BoundNewT)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 9536, 9562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_9648_9710(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitNullCoalescingOperator((Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 9648, 9710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_9798_9864(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitObjectCreationExpression((Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 9798, 9864);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_9937_9973(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitParameter((Microsoft.CodeAnalysis.CSharp.BoundParameter)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 9937, 9973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_10063_10133(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = VisitPointerIndirectionOperator((Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 10063, 10133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_10217_10275(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = VisitPointerElementAccess((Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 10217, 10275);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_10353_10399(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitPropertyAccess((Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 10353, 10399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_10477_10523(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = VisitSizeOfOperator((Microsoft.CodeAnalysis.CSharp.BoundSizeOfOperator)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 10477, 10523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_10600_10644(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitUnaryOperator((Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 10600, 10644);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_11066_11080(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Constant(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 11066, 11080);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10455_11170_11179(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 11170, 11179);
                    return return_v;
                }


                System.Exception
                f_10455_11135_11180(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 11135, 11180);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 7003, 11207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 7003, 11207);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitInternal(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 11219, 11916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11303, 11326);

                BoundExpression
                result
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11340, 11358);

                _recursionDepth++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11383, 11424);

                int
                saveRecursionDepth = _recursionDepth
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11448, 11758) || true) && (_recursionDepth > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 11448, 11758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11505, 11564);

                    f_10455_11505_11563(_recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11584, 11632);

                    result = f_10455_11593_11631(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 11448, 11758);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 11448, 11758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11698, 11743);

                    result = f_10455_11707_11742(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 11448, 11758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11785, 11837);

                f_10455_11785_11836(saveRecursionDepth == _recursionDepth);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11859, 11877);

                _recursionDepth--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 11891, 11905);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 11219, 11916);

                int
                f_10455_11505_11563(int
                recursionDepth)
                {
                    StackGuard.EnsureSufficientExecutionStack(recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 11505, 11563);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_11593_11631(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithoutStackGuard(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 11593, 11631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_11707_11742(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithStackGuard(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 11707, 11742);
                    return return_v;
                }


                int
                f_10455_11785_11836(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 11785, 11836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 11219, 11916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 11219, 11916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitExpressionWithStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 11928, 12312);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12064, 12110);

                    return f_10455_12071_12109(this, node);
                }
                catch (InsufficientExecutionStackException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10455, 12139, 12301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12218, 12286);

                    throw f_10455_12224_12285(ex, node);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10455, 12139, 12301);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 11928, 12312);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_12071_12109(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithoutStackGuard(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 12071, 12109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException
                f_10455_12224_12285(System.InsufficientExecutionStackException
                inner, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException((System.Exception)inner, (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 12224, 12285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 11928, 12312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 11928, 12312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitArrayAccess(BoundArrayAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 12324, 13022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12412, 12447);

                var
                array = f_10455_12424_12446(this, f_10455_12430_12445(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12461, 13011) || true) && (node.Indices.Length == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 12461, 13011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12523, 12549);

                    var
                    arg = f_10455_12533_12545(node)[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12567, 12590);

                    var
                    index = f_10455_12579_12589(this, arg)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12608, 12802) || true) && (!f_10455_12613_12691(f_10455_12631_12641(index), _int32Type, TypeCompareKind.ConsiderEverything2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 12608, 12802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12733, 12783);

                        index = f_10455_12741_12782(this, index, f_10455_12761_12769(arg), _int32Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 12608, 12802);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12820, 12867);

                    return f_10455_12827_12866(this, "ArrayIndex", array, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 12461, 13011);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 12461, 13011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 12933, 12996);

                    return f_10455_12940_12995(this, "ArrayIndex", array, f_10455_12973_12994(this, f_10455_12981_12993(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 12461, 13011);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 12324, 13022);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_12430_12445(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 12430, 12445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_12424_12446(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 12424, 12446);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_12533_12545(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 12533, 12545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_12579_12589(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 12579, 12589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_12631_12641(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 12631, 12641);
                    return return_v;
                }


                bool
                f_10455_12613_12691(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 12613, 12691);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_12761_12769(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 12761, 12769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_12741_12782(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newType)
                {
                    var return_v = this_param.ConvertIndex(expr, oldType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)newType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 12741, 12782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_12827_12866(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 12827, 12866);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_12981_12993(Microsoft.CodeAnalysis.CSharp.BoundArrayAccess
                this_param)
                {
                    var return_v = this_param.Indices;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 12981, 12993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_12973_12994(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions)
                {
                    var return_v = this_param.Indices(expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 12973, 12994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_12940_12995(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 12940, 12995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 12324, 13022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 12324, 13022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression Indices(ImmutableArray<BoundExpression> expressions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 13034, 13659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13135, 13193);

                var
                builder = f_10455_13149_13192()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13207, 13559);
                    foreach (var arg in f_10455_13227_13238_I(expressions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 13207, 13559);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13272, 13295);

                        var
                        index = f_10455_13284_13294(this, arg)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13313, 13507) || true) && (!f_10455_13318_13396(f_10455_13336_13346(index), _int32Type, TypeCompareKind.ConsiderEverything2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 13313, 13507);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13438, 13488);

                            index = f_10455_13446_13487(this, index, f_10455_13466_13474(arg), _int32Type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 13313, 13507);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13525, 13544);

                        f_10455_13525_13543(builder, index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 13207, 13559);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10455, 1, 353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10455, 1, 353);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13575, 13648);

                return f_10455_13582_13647(_bound, f_10455_13602_13616(), f_10455_13618_13646(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 13034, 13659);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_13149_13192()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13149, 13192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_13284_13294(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13284, 13294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_13336_13346(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 13336, 13346);
                    return return_v;
                }


                bool
                f_10455_13318_13396(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13318, 13396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_13466_13474(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 13466, 13474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_13446_13487(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newType)
                {
                    var return_v = this_param.ConvertIndex(expr, oldType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)newType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13446, 13487);
                    return return_v;
                }


                int
                f_10455_13525_13543(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13525, 13543);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_13227_13238_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13227, 13238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_13602_13616()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 13602, 13616);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_13618_13646(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13618, 13646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_13582_13647(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13582, 13647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 13034, 13659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 13034, 13659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression Expressions(ImmutableArray<BoundExpression> expressions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 13671, 14052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13776, 13834);

                var
                builder = f_10455_13790_13833()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13848, 13952);
                    foreach (var arg in f_10455_13868_13879_I(expressions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 13848, 13952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13913, 13937);

                        f_10455_13913_13936(builder, f_10455_13925_13935(this, arg));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 13848, 13952);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10455, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10455, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 13968, 14041);

                return f_10455_13975_14040(_bound, f_10455_13995_14009(), f_10455_14011_14039(builder));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 13671, 14052);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_13790_13833()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13790, 13833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_13925_13935(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13925, 13935);
                    return return_v;
                }


                int
                f_10455_13913_13936(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13913, 13936);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_13868_13879_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13868, 13879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_13995_14009()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 13995, 14009);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_14011_14039(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 14011, 14039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_13975_14040(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 13975, 14040);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 13671, 14052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 13671, 14052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitArrayCreation(BoundArrayCreation node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 14064, 15135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 14156, 14199);

                var
                arrayType = (ArrayTypeSymbol)f_10455_14189_14198(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 14213, 14266);

                var
                boundType = f_10455_14229_14265(_bound, f_10455_14243_14264(arrayType))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 14280, 15124) || true) && (f_10455_14284_14303(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 14280, 15124);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 14345, 14969) || true) && (f_10455_14349_14368(arrayType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 14345, 14969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 14410, 14503);

                        return f_10455_14417_14502(this, "NewArrayInit", boundType, f_10455_14456_14501(this, f_10455_14468_14500(f_10455_14468_14487(node))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 14345, 14969);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 14345, 14969);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 14788, 14950);

                        return f_10455_14795_14949(node.Syntax, default(LookupResultKind), ImmutableArray<Symbol>.Empty, f_10455_14888_14932(node), f_10455_14934_14948());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 14345, 14969);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 14280, 15124);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 14280, 15124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 15035, 15109);

                    return f_10455_15042_15108(this, "NewArrayBounds", boundType, f_10455_15083_15107(this, f_10455_15095_15106(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 14280, 15124);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 14064, 15135);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_14189_14198(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 14189, 14198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_14243_14264(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 14243, 14264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_14229_14265(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 14229, 14265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization?
                f_10455_14284_14303(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 14284, 14303);
                    return return_v;
                }


                bool
                f_10455_14349_14368(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 14349, 14368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                f_10455_14468_14487(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.InitializerOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 14468, 14487);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_14468_14500(Microsoft.CodeAnalysis.CSharp.BoundArrayInitialization
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 14468, 14500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_14456_14501(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions)
                {
                    var return_v = this_param.Expressions(expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 14456, 14501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_14417_14502(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 14417, 14502);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_14888_14932(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 14888, 14932);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_14934_14948()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 14934, 14948);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10455_14795_14949(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 14795, 14949);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_15095_15106(Microsoft.CodeAnalysis.CSharp.BoundArrayCreation
                this_param)
                {
                    var return_v = this_param.Bounds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15095, 15106);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15083_15107(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions)
                {
                    var return_v = this_param.Expressions(expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15083, 15107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15042_15108(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15042, 15108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 14064, 15135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 14064, 15135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitArrayLength(BoundArrayLength node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 15147, 15304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 15235, 15293);

                return f_10455_15242_15292(this, "ArrayLength", f_10455_15269_15291(this, f_10455_15275_15290(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 15147, 15304);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15275_15290(Microsoft.CodeAnalysis.CSharp.BoundArrayLength
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15275, 15290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15269_15291(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15269, 15291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15242_15292(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15242, 15292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 15147, 15304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 15147, 15304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitAsOperator(BoundAsOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 15316, 15787);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 15402, 15684) || true) && (f_10455_15406_15434(f_10455_15406_15418(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 15406, 15471) && (object)f_10455_15446_15463(f_10455_15446_15458(node)) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 15402, 15684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 15505, 15578);

                    var
                    operand = f_10455_15519_15577(_bound, f_10455_15531_15576(_bound, SpecialType.System_Object))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 15596, 15669);

                    node = f_10455_15603_15668(node, operand, f_10455_15624_15639(node), f_10455_15641_15656(node), f_10455_15658_15667(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 15402, 15684);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 15700, 15776);

                return f_10455_15707_15775(this, "TypeAs", f_10455_15729_15748(this, f_10455_15735_15747(node)), f_10455_15750_15774(_bound, f_10455_15764_15773(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 15316, 15787);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15406_15418(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15406, 15418);
                    return return_v;
                }


                bool
                f_10455_15406_15434(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15406, 15434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15446_15458(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15446, 15458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_15446_15463(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15446, 15463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_15531_15576(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15531, 15576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15519_15577(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15519, 15577);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10455_15624_15639(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.TargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15624, 15639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10455_15641_15656(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15641, 15656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_15658_15667(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15658, 15667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                f_10455_15603_15668(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                targetType, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, targetType, conversion, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15603, 15668);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15735_15747(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15735, 15747);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15729_15748(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15729, 15748);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_15764_15773(Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 15764, 15773);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15750_15774(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15750, 15774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_15707_15775(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 15707, 15775);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 15316, 15787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 15316, 15787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitBaseReference(BoundBaseReference node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 15799, 16194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16045, 16183);

                return f_10455_16052_16182(node.Syntax, 0, ImmutableArray<Symbol>.Empty, f_10455_16121_16165(node), f_10455_16167_16181());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 15799, 16194);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_16121_16165(Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 16121, 16165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_16167_16181()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 16167, 16181);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10455_16052_16182(Microsoft.CodeAnalysis.SyntaxNode
                syntax, int
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, (Microsoft.CodeAnalysis.CSharp.LookupResultKind)resultKind, symbols, childBoundNodes, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 16052, 16182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 15799, 16194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 15799, 16194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetBinaryOperatorName(BinaryOperatorKind opKind, out bool isChecked, out bool isLifted, out bool requiresLifted)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10455, 16206, 17976);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16365, 16396);

                isChecked = f_10455_16377_16395(opKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16410, 16439);

                isLifted = f_10455_16421_16438(opKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16453, 16492);

                requiresLifted = f_10455_16470_16491(opKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16508, 17965);

                switch (f_10455_16516_16533(opKind))
                {

                    case BinaryOperatorKind.Addition:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16601, 16641);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 16608, 16617) || ((isChecked && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 16620, 16632)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 16635, 16640))) ? "AddChecked" : "Add";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.Multiplication:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16699, 16749);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 16706, 16715) || ((isChecked && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 16718, 16735)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 16738, 16748))) ? "MultiplyChecked" : "Multiply";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.Subtraction:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16804, 16854);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 16811, 16820) || ((isChecked && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 16823, 16840)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 16843, 16853))) ? "SubtractChecked" : "Subtract";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.Division:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16906, 16922);

                        return "Divide";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.Remainder:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 16975, 16991);

                        return "Modulo";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.And:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17038, 17084);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 17045, 17063) || ((f_10455_17045_17063(opKind) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 17066, 17075)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 17078, 17083))) ? "AndAlso" : "And";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.Xor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17131, 17152);

                        return "ExclusiveOr";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.Or:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17198, 17242);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 17205, 17223) || ((f_10455_17205_17223(opKind) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 17226, 17234)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 17237, 17241))) ? "OrElse" : "Or";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.LeftShift:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17295, 17314);

                        return "LeftShift";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.RightShift:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17368, 17388);

                        return "RightShift";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.Equal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17437, 17452);

                        return "Equal";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.NotEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17504, 17522);

                        return "NotEqual";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.LessThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17574, 17592);

                        return "LessThan";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.LessThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17651, 17676);

                        return "LessThanOrEqual";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.GreaterThan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17731, 17752);

                        return "GreaterThan";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    case BinaryOperatorKind.GreaterThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17814, 17842);

                        return "GreaterThanOrEqual";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 16508, 17965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 17890, 17950);

                        throw f_10455_17896_17949(f_10455_17931_17948(opKind));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 16508, 17965);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10455, 16206, 17976);

                bool
                f_10455_16377_16395(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsChecked();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 16377, 16395);
                    return return_v;
                }


                bool
                f_10455_16421_16438(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 16421, 16438);
                    return return_v;
                }


                bool
                f_10455_16470_16491(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsComparison();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 16470, 16491);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10455_16516_16533(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 16516, 16533);
                    return return_v;
                }


                bool
                f_10455_17045_17063(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLogical();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 17045, 17063);
                    return return_v;
                }


                bool
                f_10455_17205_17223(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLogical();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 17205, 17223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10455_17931_17948(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 17931, 17948);
                    return return_v;
                }


                System.Exception
                f_10455_17896_17949(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 17896, 17949);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 16206, 17976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 16206, 17976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitBinaryOperator(BinaryOperatorKind opKind, MethodSymbol methodOpt, TypeSymbol type, BoundExpression left, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 17988, 20203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 18169, 18210);

                bool
                isChecked
                = default(bool),
                isLifted
                = default(bool),
                requiresLifted
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 18224, 18319);

                string
                opName = f_10455_18240_18318(opKind, out isChecked, out isLifted, out requiresLifted)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 18407, 18543) || true) && ((object)f_10455_18419_18428(left) == null && (DynAbs.Tracing.TraceSender.Expression_True(10455, 18411, 18460) && f_10455_18440_18460(left)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 18407, 18543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 18494, 18528);

                    left = f_10455_18501_18527(_bound, f_10455_18516_18526(right));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 18407, 18543);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 18557, 18695) || true) && ((object)f_10455_18569_18579(right) == null && (DynAbs.Tracing.TraceSender.Expression_True(10455, 18561, 18612) && f_10455_18591_18612(right)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 18557, 18695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 18646, 18680);

                    right = f_10455_18654_18679(_bound, f_10455_18669_18678(left));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 18557, 18695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 18785, 20192);

                switch (f_10455_18793_18814(opKind))
                {

                    case BinaryOperatorKind.EnumAndUnderlying:
                    case BinaryOperatorKind.UnderlyingAndEnum:
                    case BinaryOperatorKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 18785, 20192);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 19046, 19143);

                            var
                            enumOperand = (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 19064, 19127) || (((f_10455_19065_19086(opKind) == BinaryOperatorKind.UnderlyingAndEnum) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 19130, 19135)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 19138, 19142))) ? right : left
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 19169, 19258);

                            var
                            promotedType = f_10455_19188_19257(this, f_10455_19201_19256(f_10455_19201_19232(f_10455_19201_19217(enumOperand))))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 19284, 19443) || true) && (f_10455_19288_19305(opKind))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 19284, 19443);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 19363, 19416);

                                promotedType = f_10455_19378_19415(_nullableType, promotedType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 19284, 19443);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 19471, 19547);

                            var
                            loweredLeft = f_10455_19489_19546(this, left, promotedType, isChecked)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 19573, 19651);

                            var
                            loweredRight = f_10455_19592_19650(this, right, promotedType, isChecked)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 19679, 19781);

                            var
                            result = f_10455_19692_19780(this, methodOpt, type, isLifted, requiresLifted, opName, loweredLeft, loweredRight)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 19807, 19846);

                            return f_10455_19814_19845(this, result, type, isChecked);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 18785, 20192);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 18785, 20192);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 19944, 19974);

                            var
                            loweredLeft = f_10455_19962_19973(this, left)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 20000, 20032);

                            var
                            loweredRight = f_10455_20019_20031(this, right)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 20058, 20154);

                            return f_10455_20065_20153(this, methodOpt, type, isLifted, requiresLifted, opName, loweredLeft, loweredRight);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 18785, 20192);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 17988, 20203);

                string
                f_10455_18240_18318(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                opKind, out bool
                isChecked, out bool
                isLifted, out bool
                requiresLifted)
                {
                    var return_v = GetBinaryOperatorName(opKind, out isChecked, out isLifted, out requiresLifted);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 18240, 18318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_18419_18428(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 18419, 18428);
                    return return_v;
                }


                bool
                f_10455_18440_18460(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 18440, 18460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_18516_18526(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 18516, 18526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_18501_18527(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 18501, 18527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_18569_18579(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 18569, 18579);
                    return return_v;
                }


                bool
                f_10455_18591_18612(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 18591, 18612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_18669_18678(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 18669, 18678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_18654_18679(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Default(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 18654, 18679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10455_18793_18814(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 18793, 18814);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10455_19065_19086(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19065, 19086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_19201_19217(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 19201, 19217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_19201_19232(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19201, 19232);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10455_19201_19256(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19201, 19256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_19188_19257(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                underlying)
                {
                    var return_v = this_param.PromotedType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19188, 19257);
                    return return_v;
                }


                bool
                f_10455_19288_19305(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19288, 19305);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_19378_19415(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19378, 19415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_19489_19546(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                promotedType, bool
                isChecked)
                {
                    var return_v = this_param.VisitAndPromoteEnumOperand(operand, promotedType, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19489, 19546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_19592_19650(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                promotedType, bool
                isChecked)
                {
                    var return_v = this_param.VisitAndPromoteEnumOperand(operand, promotedType, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19592, 19650);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_19692_19780(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isLifted, bool
                requiresLifted, string
                opName, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight)
                {
                    var return_v = this_param.MakeBinary(methodOpt, type, isLifted, requiresLifted, opName, loweredLeft, loweredRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19692, 19780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_19814_19845(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Demote(node, type, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19814, 19845);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_19962_19973(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 19962, 19973);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_20019_20031(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 20019, 20031);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_20065_20153(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isLifted, bool
                requiresLifted, string
                opName, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredLeft, Microsoft.CodeAnalysis.CSharp.BoundExpression
                loweredRight)
                {
                    var return_v = this_param.MakeBinary(methodOpt, type, isLifted, requiresLifted, opName, loweredLeft, loweredRight);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 20065, 20153);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 17988, 20203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 17988, 20203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression DemoteEnumOperand(BoundExpression operand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10455, 20215, 20871);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 20313, 20829) || true) && (f_10455_20317_20329(operand) == BoundKind.Conversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 20313, 20829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 20387, 20429);

                    var
                    conversion = (BoundConversion)operand
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 20447, 20814) || true) && (!f_10455_20452_20503(f_10455_20452_20477(conversion)) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 20451, 20576) && f_10455_20528_20576(f_10455_20528_20553(conversion))) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 20451, 20656) && f_10455_20601_20626(conversion) != ConversionKind.NullLiteral) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 20451, 20724) && f_10455_20681_20724(f_10455_20681_20711(f_10455_20681_20696(conversion)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 20447, 20814);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 20766, 20795);

                        operand = f_10455_20776_20794(conversion);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 20447, 20814);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 20313, 20829);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 20845, 20860);

                return operand;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10455, 20215, 20871);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10455_20317_20329(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 20317, 20329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10455_20452_20477(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 20452, 20477);
                    return return_v;
                }


                bool
                f_10455_20452_20503(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsUserDefinedConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 20452, 20503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10455_20528_20553(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 20528, 20553);
                    return return_v;
                }


                bool
                f_10455_20528_20576(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsImplicitConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 20528, 20576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10455_20601_20626(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 20601, 20626);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_20681_20696(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 20681, 20696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_20681_20711(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 20681, 20711);
                    return return_v;
                }


                bool
                f_10455_20681_20724(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 20681, 20724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_20776_20794(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 20776, 20794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 20215, 20871);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 20215, 20871);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitAndPromoteEnumOperand(BoundExpression operand, TypeSymbol promotedType, bool isChecked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 20883, 21891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 21024, 21062);

                var
                literal = operand as BoundLiteral
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 21076, 21880) || true) && (literal != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 21076, 21880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 21227, 21296);

                    return f_10455_21234_21295(this, f_10455_21243_21294(literal, f_10455_21258_21279(literal), promotedType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 21076, 21880);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 21076, 21880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 21661, 21709);

                    var
                    demotedOperand = f_10455_21682_21708(operand)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 21727, 21770);

                    var
                    loweredOperand = f_10455_21748_21769(this, demotedOperand)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 21788, 21865);

                    return f_10455_21795_21864(this, loweredOperand, f_10455_21819_21831(operand), promotedType, isChecked, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 21076, 21880);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 20883, 21891);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10455_21258_21279(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 21258, 21279);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10455_21243_21294(Microsoft.CodeAnalysis.CSharp.BoundLiteral
                this_param, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 21243, 21294);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_21234_21295(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                node)
                {
                    var return_v = this_param.Constant((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 21234, 21295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_21682_21708(Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = DemoteEnumOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 21682, 21708);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_21748_21769(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 21748, 21769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_21819_21831(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 21819, 21831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_21795_21864(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, bool
                isChecked, bool
                isExplicit)
                {
                    var return_v = this_param.Convert(operand, oldType, newType, isChecked, isExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 21795, 21864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 20883, 21891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 20883, 21891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeBinary(MethodSymbol methodOpt, TypeSymbol type, bool isLifted, bool requiresLifted, string opName, BoundExpression loweredLeft, BoundExpression loweredRight)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 21903, 22559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 22113, 22548);

                return
                (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 22137, 22164) || ((((object)methodOpt == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 22167, 22213)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 22237, 22547))) ? f_10455_22167_22213(this, opName, loweredLeft, loweredRight) : (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 22237, 22251) || ((requiresLifted && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 22254, 22443)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 22471, 22547))) ? f_10455_22254_22443(this, opName, loweredLeft, loweredRight, f_10455_22301_22412(_bound, isLifted && (DynAbs.Tracing.TraceSender.Expression_True(10455, 22316, 22411) && !f_10455_22329_22411(f_10455_22347_22367(methodOpt), type, TypeCompareKind.ConsiderEverything2))), f_10455_22414_22442(_bound, methodOpt)) : f_10455_22471_22547(this, opName, loweredLeft, loweredRight, f_10455_22518_22546(_bound, methodOpt));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 21903, 22559);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_22167_22213(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 22167, 22213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_22347_22367(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 22347, 22367);
                    return return_v;
                }


                bool
                f_10455_22329_22411(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 22329, 22411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10455_22301_22412(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, bool
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 22301, 22412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_22414_22442(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 22414, 22442);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_22254_22443(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 22254, 22443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_22518_22546(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 22518, 22546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_22471_22547(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 22471, 22547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 21903, 22559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 21903, 22559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeSymbol PromotedType(TypeSymbol underlying)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 22571, 23110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 22650, 22773) || true) && (f_10455_22654_22676(underlying) == SpecialType.System_Boolean)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 22650, 22773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 22740, 22758);

                    return underlying;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 22650, 22773);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 22789, 22862);

                var
                possiblePromote = f_10455_22811_22861(f_10455_22838_22860(underlying))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 22878, 23099) || true) && (possiblePromote == f_10455_22901_22923(underlying))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 22878, 23099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 22957, 22975);

                    return underlying;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 22878, 23099);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 22878, 23099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 23041, 23084);

                    return f_10455_23048_23083(_bound, possiblePromote);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 22878, 23099);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 22571, 23110);

                Microsoft.CodeAnalysis.SpecialType
                f_10455_22654_22676(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 22654, 22676);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10455_22838_22860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 22838, 22860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10455_22811_22861(Microsoft.CodeAnalysis.SpecialType
                underlyingType)
                {
                    var return_v = Binder.GetEnumPromotedType(underlyingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 22811, 22861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10455_22901_22923(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 22901, 22923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_23048_23083(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23048, 23083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 22571, 23110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 22571, 23110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression Demote(BoundExpression node, TypeSymbol type, bool isChecked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 23122, 23875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 23232, 23264);

                var
                e = type as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 23278, 23836) || true) && ((object)e != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 23278, 23836);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 23333, 23478) || true) && (f_10455_23337_23362(f_10455_23337_23353(e)) == TypeKind.Enum)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 23333, 23478);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 23421, 23459);

                        return f_10455_23428_23458(this, node, type, isChecked);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 23333, 23478);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 23498, 23625);

                    var
                    promotedType = (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 23517, 23535) || ((f_10455_23517_23535(e) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 23538, 23606)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 23609, 23624))) ? f_10455_23538_23606(_nullableType, f_10455_23562_23605(this, f_10455_23575_23604(e))) : f_10455_23609_23624(this, e)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 23643, 23821) || true) && (!f_10455_23648_23722(promotedType, type, TypeCompareKind.ConsiderEverything2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 23643, 23821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 23764, 23802);

                        return f_10455_23771_23801(this, node, type, isChecked);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 23643, 23821);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 23278, 23836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 23852, 23864);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 23122, 23875);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_23337_23353(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23337, 23353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10455_23337_23362(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 23337, 23362);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_23428_23458(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Convert(expr, type, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23428, 23458);
                    return return_v;
                }


                bool
                f_10455_23517_23535(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23517, 23535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_23575_23604(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23575, 23604);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_23562_23605(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                underlying)
                {
                    var return_v = this_param.PromotedType(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23562, 23605);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_23538_23606(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23538, 23606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_23609_23624(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlying)
                {
                    var return_v = this_param.PromotedType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23609, 23624);
                    return return_v;
                }


                bool
                f_10455_23648_23722(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23648, 23722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_23771_23801(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Convert(expr, type, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 23771, 23801);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 23122, 23875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 23122, 23875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression ConvertIndex(BoundExpression expr, TypeSymbol oldType, TypeSymbol newType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 23887, 24602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 24010, 24060);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 24074, 24190);

                var
                kind = f_10455_24085_24184(f_10455_24085_24115(f_10455_24085_24103(_bound)), oldType, newType, ref useSiteDiagnostics).Kind
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 24204, 24253);

                f_10455_24204_24252(f_10455_24217_24251(useSiteDiagnostics));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 24267, 24591);

                switch (kind)
                {

                    case ConversionKind.Identity:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 24267, 24591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 24364, 24376);

                        return expr;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 24267, 24591);

                    case ConversionKind.ExplicitNumeric:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 24267, 24591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 24452, 24488);

                        return f_10455_24459_24487(this, expr, newType, true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 24267, 24591);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 24267, 24591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 24536, 24576);

                        return f_10455_24543_24575(this, expr, _int32Type, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 24267, 24591);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 23887, 24602);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10455_24085_24103(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 24085, 24103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10455_24085_24115(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 24085, 24115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10455_24085_24184(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 24085, 24184);
                    return return_v;
                }


                bool
                f_10455_24217_24251(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                hashSet)
                {
                    var return_v = hashSet.IsNullOrEmpty<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 24217, 24251);
                    return return_v;
                }


                int
                f_10455_24204_24252(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 24204, 24252);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_24459_24487(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Convert(expr, type, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 24459, 24487);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_24543_24575(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Convert(expr, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 24543, 24575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 23887, 24602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 23887, 24602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitCall(BoundCall node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 24614, 25410);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 24688, 25399) || true) && (f_10455_24692_24711(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 24688, 25399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 24813, 24927);

                    return f_10455_24820_24926(this, WellKnownMemberNames.DelegateInvokeName, f_10455_24873_24896(this, f_10455_24879_24895(node)), f_10455_24898_24925(this, f_10455_24910_24924(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 24688, 25399);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 24688, 25399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 25084, 25109);

                    var
                    method = f_10455_25097_25108(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 25127, 25384);

                    return f_10455_25134_25383(this, "Call", (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 25197, 25228) || ((f_10455_25197_25228(method) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 25231, 25254)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 25257, 25284))) ? f_10455_25231_25254(this, f_10455_25237_25253(node)) : f_10455_25257_25284(_bound, f_10455_25269_25283()), f_10455_25307_25332(_bound, method), f_10455_25355_25382(this, f_10455_25367_25381(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 24688, 25399);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 24614, 25410);

                bool
                f_10455_24692_24711(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.IsDelegateCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 24692, 24711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10455_24879_24895(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 24879, 24895);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_24873_24896(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 24873, 24896);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_24910_24924(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 24910, 24924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_24898_24925(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions)
                {
                    var return_v = this_param.Expressions(expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 24898, 24925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_24820_24926(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 24820, 24926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_25097_25108(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 25097, 25108);
                    return return_v;
                }


                bool
                f_10455_25197_25228(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RequiresInstanceReceiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 25197, 25228);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10455_25237_25253(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 25237, 25253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25231_25254(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 25231, 25254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_25269_25283()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 25269, 25283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25257_25284(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 25257, 25284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25307_25332(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 25307, 25332);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_25367_25381(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 25367, 25381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25355_25382(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions)
                {
                    var return_v = this_param.Expressions(expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 25355, 25382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25134_25383(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 25134, 25383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 24614, 25410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 24614, 25410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitConditionalOperator(BoundConditionalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 25422, 25788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 25526, 25564);

                var
                condition = f_10455_25542_25563(this, f_10455_25548_25562(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 25578, 25629);

                var
                consequence = f_10455_25596_25628(this, f_10455_25611_25627(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 25643, 25694);

                var
                alternative = f_10455_25661_25693(this, f_10455_25676_25692(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 25708, 25777);

                return f_10455_25715_25776(this, "Condition", condition, consequence, alternative);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 25422, 25788);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25548_25562(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 25548, 25562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25542_25563(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 25542, 25563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25611_25627(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 25611, 25627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25596_25628(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    var return_v = this_param.VisitExactType(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 25596, 25628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25676_25692(Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 25676, 25692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25661_25693(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    var return_v = this_param.VisitExactType(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 25661, 25693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_25715_25776(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 25715, 25776);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 25422, 25788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 25422, 25788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitExactType(BoundExpression e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 26065, 26805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 26147, 26185);

                var
                conversion = e as BoundConversion
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 26199, 26762) || true) && (conversion != null && (DynAbs.Tracing.TraceSender.Expression_True(10455, 26203, 26255) && f_10455_26225_26255_M(!conversion.ExplicitCastInCode)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 26199, 26762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 26289, 26747);

                    e = f_10455_26293_26746(conversion, f_10455_26333_26351(conversion), f_10455_26374_26395(conversion), isBaseConversion: f_10455_26436_26463(conversion), @checked: f_10455_26496_26514(conversion), explicitCastInCode: true, conversionGroupOpt: f_10455_26604_26633(conversion), constantValueOpt: f_10455_26674_26701(conversion), type: f_10455_26730_26745(conversion));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 26199, 26762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 26778, 26794);

                return f_10455_26785_26793(this, e);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 26065, 26805);

                bool
                f_10455_26225_26255_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 26225, 26255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_26333_26351(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 26333, 26351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10455_26374_26395(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 26374, 26395);
                    return return_v;
                }


                bool
                f_10455_26436_26463(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.IsBaseConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 26436, 26463);
                    return return_v;
                }


                bool
                f_10455_26496_26514(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 26496, 26514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                f_10455_26604_26633(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionGroupOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 26604, 26633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10455_26674_26701(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConstantValueOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 26674, 26701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_26730_26745(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 26730, 26745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10455_26293_26746(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                isBaseConversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Update(operand, conversion, isBaseConversion: isBaseConversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 26293, 26746);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_26785_26793(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 26785, 26793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 26065, 26805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 26065, 26805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitConversion(BoundConversion node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 26817, 30473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 26903, 30462);

                switch (f_10455_26911_26930(node))
                {

                    case ConversionKind.MethodGroup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 26903, 30462);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 27045, 27085);

                            var
                            mg = (BoundMethodGroup)f_10455_27072_27084(node)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 27111, 27247);

                            return f_10455_27118_27246(this, f_10455_27135_27149(mg), f_10455_27151_27165(node), f_10455_27167_27176(node), f_10455_27178_27218_M(!f_10455_27179_27193(node).RequiresInstanceReceiver) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 27178, 27245) && f_10455_27222_27245_M(!node.IsExtensionMethod)));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 26903, 30462);

                    case ConversionKind.ExplicitUserDefined:
                    case ConversionKind.ImplicitUserDefined:
                    case ConversionKind.IntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 26903, 30462);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 27480, 27508);

                            var
                            method = f_10455_27493_27507(node)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 27534, 27570);

                            var
                            operandType = f_10455_27552_27569(f_10455_27552_27564(node))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 27596, 27649);

                            var
                            strippedOperandType = f_10455_27622_27648(operandType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 27675, 27727);

                            var
                            conversionInputType = f_10455_27701_27726(f_10455_27701_27718(method)[0])
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 27753, 27958);

                            var
                            isLifted = !f_10455_27769_27857(operandType, conversionInputType, TypeCompareKind.ConsiderEverything2) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 27768, 27957) && f_10455_27861_27957(strippedOperandType, conversionInputType, TypeCompareKind.ConsiderEverything2))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 27984, 28241);

                            bool
                            requireAdditionalCast =
                                                        !f_10455_28043_28240(strippedOperandType, ((DynAbs.Tracing.TraceSender.Conditional_F1(10455, 28083, 28142) || (((f_10455_28084_28103(node) == ConversionKind.ExplicitUserDefined) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 28145, 28164)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 28167, 28201))) ? conversionInputType : f_10455_28167_28201(conversionInputType)), TypeCompareKind.ConsiderEverything2)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 28267, 28481);

                            var
                            resultType = (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 28284, 28370) || (((isLifted && (DynAbs.Tracing.TraceSender.Expression_True(10455, 28285, 28339) && f_10455_28297_28339(f_10455_28297_28314(method))) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 28285, 28369) && f_10455_28343_28369(f_10455_28343_28352(node)))) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 28418, 28460)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 28463, 28480))) ? f_10455_28418_28460(_nullableType, f_10455_28442_28459(method)) : f_10455_28463_28480(method)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 28507, 28716);

                            var
                            e1 = (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 28516, 28537) || ((requireAdditionalCast
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 28569, 28664)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 28696, 28715))) ? f_10455_28569_28664(this, f_10455_28577_28596(this, f_10455_28583_28595(node)), f_10455_28598_28615(f_10455_28598_28610(node)), f_10455_28617_28642(f_10455_28617_28634(method)[0]), f_10455_28644_28656(node), false) : f_10455_28696_28715(this, f_10455_28702_28714(node))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 28742, 28832);

                            var
                            e2 = f_10455_28751_28831(this, "Convert", e1, f_10455_28778_28803(_bound, resultType), f_10455_28805_28830(_bound, method))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 28858, 28921);

                            return f_10455_28865_28920(this, e2, resultType, f_10455_28889_28898(node), f_10455_28900_28912(node), false);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 26903, 30462);

                    case ConversionKind.ImplicitReference:
                    case ConversionKind.Identity:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 26903, 30462);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 29096, 29130);

                            var
                            operand = f_10455_29110_29129(this, f_10455_29116_29128(node))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 29156, 29234);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 29163, 29186) || ((f_10455_29163_29186(node) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 29189, 29223)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 29226, 29233))) ? f_10455_29189_29223(this, operand, f_10455_29206_29215(node), false) : operand;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 26903, 30462);

                    case ConversionKind.ImplicitNullable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 26903, 30462);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 29334, 30115) || true) && (f_10455_29338_29372(f_10455_29338_29355(f_10455_29338_29350(node))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 29334, 30115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 29422, 29527);

                            return f_10455_29429_29526(this, f_10455_29437_29456(this, f_10455_29443_29455(node)), f_10455_29458_29475(f_10455_29458_29470(node)), f_10455_29477_29486(node), f_10455_29488_29500(node), f_10455_29502_29525(node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 29334, 30115);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 29334, 30115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 29730, 29772);

                            var
                            nullable = (NamedTypeSymbol)f_10455_29762_29771(node)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 29798, 29883);

                            var
                            intermediate = f_10455_29817_29874(nullable)[0].Type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 29909, 30001);

                            var
                            e1 = f_10455_29918_30000(this, f_10455_29926_29945(this, f_10455_29932_29944(node)), f_10455_29947_29964(f_10455_29947_29959(node)), intermediate, f_10455_29980_29992(node), false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 30027, 30092);

                            return f_10455_30034_30091(this, e1, intermediate, f_10455_30060_30069(node), f_10455_30071_30083(node), false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 29334, 30115);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 26903, 30462);

                    case ConversionKind.NullLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 26903, 30462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 30187, 30294);

                        return f_10455_30194_30293(this, f_10455_30202_30236(this, f_10455_30211_30235(_bound, _objectType)), _objectType, f_10455_30251_30260(node), false, f_10455_30269_30292(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 26903, 30462);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 26903, 30462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 30342, 30447);

                        return f_10455_30349_30446(this, f_10455_30357_30376(this, f_10455_30363_30375(node)), f_10455_30378_30395(f_10455_30378_30390(node)), f_10455_30397_30406(node), f_10455_30408_30420(node), f_10455_30422_30445(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 26903, 30462);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 26817, 30473);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10455_26911_26930(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 26911, 26930);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_27072_27084(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27072, 27084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10455_27135_27149(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27135, 27149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_27151_27165(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.SymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27151, 27165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_27167_27176(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27167, 27176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_27179_27193(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.SymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27179, 27193);
                    return return_v;
                }


                bool
                f_10455_27178_27218_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27178, 27218);
                    return return_v;
                }


                bool
                f_10455_27222_27245_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27222, 27245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_27118_27246(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType, bool
                requiresInstanceReceiver)
                {
                    var return_v = this_param.DelegateCreation(receiver, method, delegateType, requiresInstanceReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 27118, 27246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_27493_27507(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.SymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27493, 27507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_27552_27564(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27552, 27564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_27552_27569(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27552, 27569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_27622_27648(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 27622, 27648);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10455_27701_27718(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27701, 27718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_27701_27726(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 27701, 27726);
                    return return_v;
                }


                bool
                f_10455_27769_27857(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 27769, 27857);
                    return return_v;
                }


                bool
                f_10455_27861_27957(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 27861, 27957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10455_28084_28103(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28084, 28103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_28167_28201(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28167, 28201);
                    return return_v;
                }


                bool
                f_10455_28043_28240(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28043, 28240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_28297_28314(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28297, 28314);
                    return return_v;
                }


                bool
                f_10455_28297_28339(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28297, 28339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_28343_28352(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28343, 28352);
                    return return_v;
                }


                bool
                f_10455_28343_28369(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28343, 28369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_28442_28459(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28442, 28459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_28418_28460(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28418, 28460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_28463_28480(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28463, 28480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28583_28595(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28583, 28595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28577_28596(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28577, 28596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28598_28610(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28598, 28610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_28598_28615(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28598, 28615);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10455_28617_28634(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28617, 28634);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_28617_28642(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28617, 28642);
                    return return_v;
                }


                bool
                f_10455_28644_28656(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28644, 28656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28569_28664(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, bool
                isChecked, bool
                isExplicit)
                {
                    var return_v = this_param.Convert(operand, oldType, newType, isChecked, isExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28569, 28664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28702_28714(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28702, 28714);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28696_28715(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28696, 28715);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28778_28803(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28778, 28803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28805_28830(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28805, 28830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28751_28831(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28751, 28831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_28889_28898(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28889, 28898);
                    return return_v;
                }


                bool
                f_10455_28900_28912(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 28900, 28912);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_28865_28920(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, bool
                isChecked, bool
                isExplicit)
                {
                    var return_v = this_param.Convert(operand, oldType, newType, isChecked, isExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 28865, 28920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29116_29128(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29116, 29128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29110_29129(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 29110, 29129);
                    return return_v;
                }


                bool
                f_10455_29163_29186(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29163, 29186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_29206_29215(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29206, 29215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29189_29223(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Convert(expr, type, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 29189, 29223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29338_29350(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29338, 29350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_29338_29355(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29338, 29355);
                    return return_v;
                }


                bool
                f_10455_29338_29372(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 29338, 29372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29443_29455(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29443, 29455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29437_29456(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 29437, 29456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29458_29470(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29458, 29470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_29458_29475(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29458, 29475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_29477_29486(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29477, 29486);
                    return return_v;
                }


                bool
                f_10455_29488_29500(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29488, 29500);
                    return return_v;
                }


                bool
                f_10455_29502_29525(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29502, 29525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29429_29526(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, bool
                isChecked, bool
                isExplicit)
                {
                    var return_v = this_param.Convert(operand, oldType, newType, isChecked, isExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 29429, 29526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_29762_29771(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29762, 29771);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10455_29817_29874(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29817, 29874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29932_29944(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29932, 29944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29926_29945(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 29926, 29945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29947_29959(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29947, 29959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_29947_29964(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29947, 29964);
                    return return_v;
                }


                bool
                f_10455_29980_29992(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 29980, 29992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_29918_30000(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, bool
                isChecked, bool
                isExplicit)
                {
                    var return_v = this_param.Convert(operand, oldType, newType, isChecked, isExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 29918, 30000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_30060_30069(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30060, 30069);
                    return return_v;
                }


                bool
                f_10455_30071_30083(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30071, 30083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30034_30091(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, bool
                isChecked, bool
                isExplicit)
                {
                    var return_v = this_param.Convert(operand, oldType, newType, isChecked, isExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30034, 30091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30211_30235(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30211, 30235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30202_30236(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Constant(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30202, 30236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_30251_30260(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30251, 30260);
                    return return_v;
                }


                bool
                f_10455_30269_30292(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30269, 30292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30194_30293(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, bool
                isChecked, bool
                isExplicit)
                {
                    var return_v = this_param.Convert(operand, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)oldType, newType, isChecked, isExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30194, 30293);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30363_30375(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30363, 30375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30357_30376(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30357, 30376);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30378_30390(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30378, 30390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_30378_30395(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30378, 30395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_30397_30406(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30397, 30406);
                    return return_v;
                }


                bool
                f_10455_30408_30420(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Checked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30408, 30420);
                    return return_v;
                }


                bool
                f_10455_30422_30445(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 30422, 30445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30349_30446(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, bool
                isChecked, bool
                isExplicit)
                {
                    var return_v = this_param.Convert(operand, oldType, newType, isChecked, isExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30349, 30446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 26817, 30473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 26817, 30473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression Convert(BoundExpression operand, TypeSymbol oldType, TypeSymbol newType, bool isChecked, bool isExplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 30485, 30796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 30639, 30785);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 30646, 30735) || (((f_10455_30647_30719(oldType, newType, TypeCompareKind.ConsiderEverything2) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 30647, 30734) && !isExplicit)) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 30738, 30745)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 30748, 30784))) ? operand : f_10455_30748_30784(this, operand, newType, isChecked);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 30485, 30796);

                bool
                f_10455_30647_30719(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30647, 30719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30748_30784(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Convert(expr, type, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30748, 30784);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 30485, 30796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 30485, 30796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression Convert(BoundExpression expr, TypeSymbol type, bool isChecked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 30808, 31018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 30919, 31007);

                return f_10455_30926_31006(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 30938, 30947) || ((isChecked && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 30950, 30966)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 30969, 30978))) ? "ConvertChecked" : "Convert", expr, f_10455_30986_31005(_bound, type));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 30808, 31018);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30986_31005(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30986, 31005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_30926_31006(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 30926, 31006);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 30808, 31018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 30808, 31018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression DelegateCreation(BoundExpression receiver, MethodSymbol method, TypeSymbol delegateType, bool requiresInstanceReceiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 31030, 32726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 31198, 31240);

                var
                nullObject = f_10455_31215_31239(_bound, _objectType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 31254, 31386);

                receiver = (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 31265, 31289) || ((requiresInstanceReceiver && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 31292, 31302)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 31305, 31385))) ? nullObject : (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 31305, 31334) || ((f_10455_31305_31334(f_10455_31305_31318(receiver)) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 31337, 31345)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 31348, 31385))) ? receiver : f_10455_31348_31385(_bound, _objectType, receiver);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 31402, 31526);

                var
                createDelegate = f_10455_31423_31525(_bound, WellKnownMember.System_Reflection_MethodInfo__CreateDelegate, isOptional: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 31540, 31565);

                BoundExpression
                unquoted
                = default(BoundExpression);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 31579, 32357) || true) && ((object)createDelegate != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 31579, 32357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 31703, 31808);

                    unquoted = f_10455_31714_31807(_bound, f_10455_31726_31751(_bound, method), createDelegate, f_10455_31769_31796(_bound, delegateType), receiver);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 31579, 32357);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 31579, 32357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 32180, 32342);

                    unquoted = f_10455_32191_32341(_bound, f_10455_32209_32256(_bound, SpecialType.System_Delegate), "CreateDelegate", f_10455_32276_32303(_bound, delegateType), receiver, f_10455_32315_32340(_bound, method));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 31579, 32357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 32662, 32715);

                return f_10455_32669_32714(this, f_10455_32677_32692(this, unquoted), delegateType, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 31030, 32726);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_31215_31239(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 31215, 31239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_31305_31318(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 31305, 31318);
                    return return_v;
                }


                bool
                f_10455_31305_31334(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 31305, 31334);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_31348_31385(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 31348, 31385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_31423_31525(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm, bool
                isOptional)
                {
                    var return_v = this_param.WellKnownMethod(wm, isOptional: isOptional);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 31423, 31525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_31726_31751(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 31726, 31751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_31769_31796(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 31769, 31796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10455_31714_31807(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg1)
                {
                    var return_v = this_param.Call(receiver, method, arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 31714, 31807);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_32209_32256(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 32209, 32256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_32276_32303(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 32276, 32303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_32315_32340(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 32315, 32340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_32191_32341(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                receiver, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)receiver, name, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 32191, 32341);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_32677_32692(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 32677, 32692);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_32669_32714(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Convert(expr, type, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 32669, 32714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 31030, 32726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 31030, 32726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitDelegateCreationExpression(BoundDelegateCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 32738, 33715);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 32856, 33016) || true) && (f_10455_32860_32878(f_10455_32860_32873(node)) == BoundKind.MethodGroup)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 32856, 33016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 32937, 33001);

                    throw f_10455_32943_33000(BoundKind.MethodGroup);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 32856, 33016);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 33032, 33301) || true) && ((object)f_10455_33044_33058(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 33032, 33301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 33100, 33188);

                    bool
                    staticMember = f_10455_33120_33160_M(!f_10455_33121_33135(node).RequiresInstanceReceiver) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 33120, 33187) && f_10455_33164_33187_M(!node.IsExtensionMethod))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 33206, 33286);

                    return f_10455_33213_33285(this, f_10455_33230_33243(node), f_10455_33245_33259(node), f_10455_33261_33270(node), staticMember);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 33032, 33301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 33317, 33363);

                var
                d = f_10455_33325_33343(f_10455_33325_33338(node)) as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 33377, 33563) || true) && ((object)d != null && (DynAbs.Tracing.TraceSender.Expression_True(10455, 33381, 33433) && f_10455_33402_33412(d) == TypeKind.Delegate))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 33377, 33563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 33467, 33548);

                    return f_10455_33474_33547(this, f_10455_33491_33504(node), f_10455_33506_33528(d), f_10455_33530_33539(node), false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 33377, 33563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 33648, 33704);

                throw f_10455_33654_33703(f_10455_33689_33702(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 32738, 33715);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_32860_32873(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 32860, 32873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10455_32860_32878(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 32860, 32878);
                    return return_v;
                }


                System.Exception
                f_10455_32943_33000(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 32943, 33000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_33044_33058(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33044, 33058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_33121_33135(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33121, 33135);
                    return return_v;
                }


                bool
                f_10455_33120_33160_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33120, 33160);
                    return return_v;
                }


                bool
                f_10455_33164_33187_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33164, 33187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33230_33243(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33230, 33243);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_33245_33259(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33245, 33259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_33261_33270(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33261, 33270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33213_33285(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType, bool
                requiresInstanceReceiver)
                {
                    var return_v = this_param.DelegateCreation(receiver, method, delegateType, requiresInstanceReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 33213, 33285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33325_33338(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33325, 33338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_33325_33343(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33325, 33343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10455_33402_33412(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33402, 33412);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33491_33504(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33491, 33504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_33506_33528(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33506, 33528);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_33530_33539(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33530, 33539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33474_33547(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                delegateType, bool
                requiresInstanceReceiver)
                {
                    var return_v = this_param.DelegateCreation(receiver, method, delegateType, requiresInstanceReceiver);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 33474, 33547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33689_33702(Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33689, 33702);
                    return return_v;
                }


                System.Exception
                f_10455_33654_33703(Microsoft.CodeAnalysis.CSharp.BoundExpression
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 33654, 33703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 32738, 33715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 32738, 33715);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitFieldAccess(BoundFieldAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 33727, 34046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 33815, 33912);

                var
                receiver = (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 33830, 33855) || ((f_10455_33830_33855(f_10455_33830_33846(node)) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 33858, 33885)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 33888, 33911))) ? f_10455_33858_33885(_bound, f_10455_33870_33884()) : f_10455_33888_33911(this, f_10455_33894_33910(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 33926, 34035);

                return f_10455_33933_34034(this, "Field", receiver, f_10455_33999_34033(_bound, f_10455_34016_34032(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 33727, 34046);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10455_33830_33846(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33830, 33846);
                    return return_v;
                }


                bool
                f_10455_33830_33855(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33830, 33855);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_33870_33884()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33870, 33884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33858_33885(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 33858, 33885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10455_33894_33910(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 33894, 33910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33888_33911(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 33888, 33911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10455_34016_34032(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 34016, 34032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33999_34033(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                field)
                {
                    var return_v = this_param.FieldInfo(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 33999, 34033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_33933_34034(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 33933, 34034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 33727, 34046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 33727, 34046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitIsOperator(BoundIsOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 34058, 34475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 34144, 34171);

                var
                operand = f_10455_34158_34170(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 34185, 34366) || true) && ((object)f_10455_34197_34209(operand) == null && (DynAbs.Tracing.TraceSender.Expression_True(10455, 34189, 34250) && f_10455_34221_34242(operand) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 34189, 34282) && f_10455_34254_34282(f_10455_34254_34275(operand))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 34185, 34366);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 34316, 34351);

                    operand = f_10455_34326_34350(_bound, _objectType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 34185, 34366);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 34382, 34464);

                return f_10455_34389_34463(this, "TypeIs", f_10455_34411_34425(this, operand), f_10455_34427_34462(_bound, f_10455_34441_34461(f_10455_34441_34456(node))));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 34058, 34475);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_34158_34170(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 34158, 34170);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_34197_34209(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 34197, 34209);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10455_34221_34242(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 34221, 34242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10455_34254_34275(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 34254, 34275);
                    return return_v;
                }


                bool
                f_10455_34254_34282(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 34254, 34282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_34326_34350(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 34326, 34350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_34411_34425(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 34411, 34425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                f_10455_34441_34456(Microsoft.CodeAnalysis.CSharp.BoundIsOperator
                this_param)
                {
                    var return_v = this_param.TargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 34441, 34456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_34441_34461(Microsoft.CodeAnalysis.CSharp.BoundTypeExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 34441, 34461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_34427_34462(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 34427, 34462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_34389_34463(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 34389, 34463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 34058, 34475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 34058, 34475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitLambda(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 34487, 34705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 34565, 34604);

                var
                result = f_10455_34578_34603(this, node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 34618, 34694);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 34625, 34653) || ((f_10455_34625_34653(f_10455_34625_34634(node)) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 34656, 34684)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 34687, 34693))) ? f_10455_34656_34684(this, "Quote", result) : result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 34487, 34705);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_34578_34603(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLambda
                node)
                {
                    var return_v = this_param.VisitLambdaInternal(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 34578, 34603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_34625_34634(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 34625, 34634);
                    return return_v;
                }


                bool
                f_10455_34625_34653(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                _type)
                {
                    var return_v = _type.IsExpressionTree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 34625, 34653);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_34656_34684(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 34656, 34684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 34487, 34705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 34487, 34705);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitLambdaInternal(BoundLambda node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 34717, 36365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 34869, 34922);

                var
                locals = f_10455_34882_34921()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 34936, 34999);

                var
                initializers = f_10455_34955_34998()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35013, 35074);

                var
                parameters = f_10455_35030_35073()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35088, 35720);
                    foreach (var p in f_10455_35106_35128_I(f_10455_35106_35128(f_10455_35106_35117(node))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 35088, 35720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35162, 35223);

                        var
                        param = f_10455_35174_35222(_bound, f_10455_35198_35221())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35241, 35259);

                        f_10455_35241_35258(locals, param);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35277, 35322);

                        var
                        parameterReference = f_10455_35302_35321(_bound, param)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35340, 35375);

                        f_10455_35340_35374(parameters, parameterReference);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35393, 35554);

                        var
                        parameter = f_10455_35409_35553(this, "Parameter", f_10455_35477_35528(_bound, f_10455_35491_35522(_typeMap, f_10455_35515_35521(p)).Type), f_10455_35530_35552(_bound, f_10455_35545_35551(p)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35572, 35649);

                        f_10455_35572_35648(initializers, f_10455_35589_35647(_bound, parameterReference, parameter));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35667, 35705);

                        _parameterMap[p] = parameterReference;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 35088, 35720);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10455, 1, 633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10455, 1, 633);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35736, 35793);

                var
                underlyingDelegateType = f_10455_35765_35792(f_10455_35765_35774(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 35807, 36195);

                var
                result = f_10455_35820_36194(_bound, f_10455_35836_35863(locals), f_10455_35865_35898(initializers), f_10455_35917_36193(this, "Lambda", f_10455_35982_36039(underlyingDelegateType), f_10455_36062_36092(this, f_10455_36082_36091(node)), f_10455_36115_36192(_bound, f_10455_36135_36158(), f_10455_36160_36191(parameters))))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 36211, 36324);
                    foreach (var p in f_10455_36229_36251_I(f_10455_36229_36251(f_10455_36229_36240(node))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 36211, 36324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 36285, 36309);

                        f_10455_36285_36308(_parameterMap, p);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 36211, 36324);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10455, 1, 114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10455, 1, 114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 36340, 36354);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 34717, 36365);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10455_34882_34921()
                {
                    var return_v = ArrayBuilder<LocalSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 34882, 34921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_34955_34998()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 34955, 34998);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_35030_35073()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35030, 35073);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10455_35106_35117(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 35106, 35117);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10455_35106_35128(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 35106, 35128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_35198_35221()
                {
                    var return_v = ParameterExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 35198, 35221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10455_35174_35222(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35174, 35222);
                    return return_v;
                }


                int
                f_10455_35241_35258(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35241, 35258);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10455_35302_35321(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35302, 35321);
                    return return_v;
                }


                int
                f_10455_35340_35374(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35340, 35374);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_35515_35521(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 35515, 35521);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10455_35491_35522(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35491, 35522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_35477_35528(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35477, 35528);
                    return return_v;
                }


                string
                f_10455_35545_35551(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 35545, 35551);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10455_35530_35552(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35530, 35552);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_35409_35553(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35409, 35553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10455_35589_35647(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35589, 35647);
                    return return_v;
                }


                int
                f_10455_35572_35648(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35572, 35648);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10455_35106_35128_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35106, 35128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_35765_35774(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 35765, 35774);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10455_35765_35792(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35765, 35792);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10455_35836_35863(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35836, 35863);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_35865_35898(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35865, 35898);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10455_35982_36039(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                item)
                {
                    var return_v = ImmutableArray.Create<TypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35982, 36039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10455_36082_36091(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36082, 36091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36062_36092(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                block)
                {
                    var return_v = this_param.TranslateLambdaBody(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36062, 36092);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_36135_36158()
                {
                    var return_v = ParameterExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36135, 36158);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_36160_36191(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36160, 36191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36115_36192(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36115, 36192);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_35917_36193(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArgs, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, typeArgs, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35917, 36193);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_35820_36194(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 35820, 36194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                f_10455_36229_36240(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Symbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36229, 36240);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10455_36229_36251(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36229, 36251);
                    return return_v;
                }


                bool
                f_10455_36285_36308(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36285, 36308);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10455_36229_36251_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36229, 36251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 34717, 36365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 34717, 36365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitNewT(BoundNewT node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 36377, 36575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 36451, 36564);

                return f_10455_36458_36563(this, f_10455_36487_36531(this, "New", f_10455_36506_36530(_bound, f_10455_36520_36529(node))), f_10455_36533_36562(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 36377, 36575);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_36520_36529(Microsoft.CodeAnalysis.CSharp.BoundNewT
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36520, 36529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36506_36530(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36506, 36530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36487_36531(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36487, 36531);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10455_36533_36562(Microsoft.CodeAnalysis.CSharp.BoundNewT
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36533, 36562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36458_36563(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                creation, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                initializerExpressionOpt)
                {
                    var return_v = this_param.VisitObjectCreationContinued(creation, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)initializerExpressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36458, 36563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 36377, 36575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 36377, 36575);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitNullCoalescingOperator(BoundNullCoalescingOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 36587, 37203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 36697, 36732);

                var
                left = f_10455_36708_36731(this, f_10455_36714_36730(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 36746, 36783);

                var
                right = f_10455_36758_36782(this, f_10455_36764_36781(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 36797, 37192) || true) && (node.LeftConversion.IsUserDefined)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 36797, 37192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 36868, 36934);

                    TypeSymbol
                    lambdaParamType = f_10455_36897_36933(f_10455_36897_36918(f_10455_36897_36913(node)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 36952, 37067);

                    return f_10455_36959_37066(this, "Coalesce", left, right, f_10455_36996_37065(this, f_10455_37017_37036(node), lambdaParamType, f_10455_37055_37064(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 36797, 37192);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 36797, 37192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37133, 37177);

                    return f_10455_37140_37176(this, "Coalesce", left, right);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 36797, 37192);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 36587, 37203);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36714_36730(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36714, 36730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36708_36731(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36708, 36731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36764_36781(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.RightOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36764, 36781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36758_36782(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36758, 36782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36897_36913(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftOperand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36897, 36913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_36897_36918(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 36897, 36918);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_36897_36933(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36897, 36933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10455_37017_37036(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.LeftConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 37017, 37036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_37055_37064(Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 37055, 37064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36996_37065(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                fromType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                toType)
                {
                    var return_v = this_param.MakeConversionLambda(conversion, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36996, 37065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_36959_37066(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 36959, 37066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_37140_37176(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37140, 37176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 36587, 37203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 36587, 37203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeConversionLambda(Conversion conversion, TypeSymbol fromType, TypeSymbol toType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 37215, 38423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37347, 37374);

                string
                parameterName = "p"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37388, 37475);

                ParameterSymbol
                lambdaParameter = f_10455_37422_37474(_bound, fromType, parameterName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37489, 37550);

                var
                param = f_10455_37501_37549(_bound, f_10455_37525_37548())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37564, 37609);

                var
                parameterReference = f_10455_37589_37608(_bound, param)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37623, 37720);

                var
                parameter = f_10455_37639_37719(this, "Parameter", f_10455_37664_37687(_bound, fromType), f_10455_37689_37718(_bound, parameterName))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37734, 37786);

                _parameterMap[lambdaParameter] = parameterReference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37800, 37898);

                var
                convertedValue = f_10455_37821_37897(this, f_10455_37827_37896(_bound, toType, f_10455_37850_37883(_bound, lambdaParameter), conversion))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37912, 37950);

                f_10455_37912_37949(_parameterMap, lambdaParameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 37964, 38384);

                var
                result = f_10455_37977_38383(_bound, f_10455_38011_38039(param), f_10455_38058_38156(f_10455_38097_38155(_bound, parameterReference, parameter)), f_10455_38175_38382(this, "Lambda", convertedValue, f_10455_38277_38381(_bound, f_10455_38297_38320(), f_10455_38322_38380(parameterReference))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 38398, 38412);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 37215, 38423);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10455_37422_37474(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, string
                name)
                {
                    var return_v = this_param.SynthesizedParameter(type, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37422, 37474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_37525_37548()
                {
                    var return_v = ParameterExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 37525, 37548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10455_37501_37549(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37501, 37549);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10455_37589_37608(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37589, 37608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_37664_37687(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37664, 37687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10455_37689_37718(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37689, 37718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_37639_37719(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37639, 37719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10455_37850_37883(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37850, 37883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_37827_37896(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundParameter
                arg, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = this_param.Convert(type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37827, 37896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_37821_37897(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37821, 37897);
                    return return_v;
                }


                bool
                f_10455_37912_37949(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37912, 37949);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10455_38011_38039(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38011, 38039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                f_10455_38097_38155(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.AssignmentExpression((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38097, 38155);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_38058_38156(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38058, 38156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_38297_38320()
                {
                    var return_v = ParameterExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 38297, 38320);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_38322_38380(Microsoft.CodeAnalysis.CSharp.BoundLocal
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38322, 38380);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_38277_38381(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38277, 38381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_38175_38382(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38175, 38382);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_37977_38383(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                sideEffects, Microsoft.CodeAnalysis.CSharp.BoundExpression
                result)
                {
                    var return_v = this_param.Sequence(locals, sideEffects, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 37977, 38383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 37215, 38423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 37215, 38423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression InitializerMemberSetter(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 38435, 39126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 38522, 39115);

                switch (f_10455_38530_38541(symbol))
                {

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 38522, 39115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 38619, 38696);

                        return f_10455_38626_38695(_bound, f_10455_38641_38655(), f_10455_38657_38694(_bound, symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 38522, 39115);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 38522, 39115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 38761, 38841);

                        return f_10455_38768_38840(_bound, f_10455_38786_38839(((PropertySymbol)symbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 38522, 39115);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 38522, 39115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 38903, 38998);

                        return f_10455_38910_38997(_bound, f_10455_38925_38939(), f_10455_38941_38996(_bound, f_10455_38958_38995(((EventSymbol)symbol))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 38522, 39115);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 38522, 39115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 39046, 39100);

                        throw f_10455_39052_39099(f_10455_39087_39098(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 38522, 39115);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 38435, 39126);

                Microsoft.CodeAnalysis.SymbolKind
                f_10455_38530_38541(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 38530, 38541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_38641_38655()
                {
                    var return_v = MemberInfoType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 38641, 38655);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_38657_38694(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                field)
                {
                    var return_v = this_param.FieldInfo((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38657, 38694);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_38626_38695(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38626, 38695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_38786_38839(Microsoft.CodeAnalysis.CSharp.Symbol
                property)
                {
                    var return_v = ((PropertySymbol)property).GetOwnOrInheritedSetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38786, 38839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_38768_38840(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38768, 38840);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_38925_38939()
                {
                    var return_v = MemberInfoType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 38925, 38939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10455_38958_38995(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 38958, 38995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_38941_38996(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                field)
                {
                    var return_v = this_param.FieldInfo(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38941, 38996);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_38910_38997(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 38910, 38997);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10455_39087_39098(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 39087, 39098);
                    return return_v;
                }


                System.Exception
                f_10455_39052_39099(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 39052, 39099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 38435, 39126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 38435, 39126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression InitializerMemberGetter(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 39138, 39829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 39225, 39818);

                switch (f_10455_39233_39244(symbol))
                {

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 39225, 39818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 39322, 39399);

                        return f_10455_39329_39398(_bound, f_10455_39344_39358(), f_10455_39360_39397(_bound, symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 39225, 39818);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 39225, 39818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 39464, 39544);

                        return f_10455_39471_39543(_bound, f_10455_39489_39542(((PropertySymbol)symbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 39225, 39818);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 39225, 39818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 39606, 39701);

                        return f_10455_39613_39700(_bound, f_10455_39628_39642(), f_10455_39644_39699(_bound, f_10455_39661_39698(((EventSymbol)symbol))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 39225, 39818);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 39225, 39818);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 39749, 39803);

                        throw f_10455_39755_39802(f_10455_39790_39801(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 39225, 39818);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 39138, 39829);

                Microsoft.CodeAnalysis.SymbolKind
                f_10455_39233_39244(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 39233, 39244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_39344_39358()
                {
                    var return_v = MemberInfoType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 39344, 39358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_39360_39397(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                field)
                {
                    var return_v = this_param.FieldInfo((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 39360, 39397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_39329_39398(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 39329, 39398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_39489_39542(Microsoft.CodeAnalysis.CSharp.Symbol
                property)
                {
                    var return_v = ((PropertySymbol)property).GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 39489, 39542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_39471_39543(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 39471, 39543);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_39628_39642()
                {
                    var return_v = MemberInfoType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 39628, 39642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10455_39661_39698(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 39661, 39698);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_39644_39699(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                field)
                {
                    var return_v = this_param.FieldInfo(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 39644, 39699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_39613_39700(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 39613, 39700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10455_39790_39801(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 39790, 39801);
                    return return_v;
                }


                System.Exception
                f_10455_39755_39802(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 39755, 39802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 39138, 39829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 39138, 39829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private enum InitializerKind { Expression, MemberInitializer, CollectionInitializer };

        private BoundExpression VisitInitializer(BoundExpression node, out InitializerKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 39939, 43701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 40052, 43690);

                switch (f_10455_40060_40069(node))
                {

                    case BoundKind.ObjectInitializerExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 40052, 43690);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 40195, 40243);

                            var
                            oi = (BoundObjectInitializerExpression)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 40269, 40327);

                            var
                            builder = f_10455_40283_40326()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 40353, 42256);
                                foreach (BoundAssignmentOperator a in f_10455_40391_40406_I(f_10455_40391_40406(oi)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 40353, 42256);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 40464, 40526);

                                    var
                                    sym = f_10455_40474_40525(((BoundObjectInitializerMember)f_10455_40505_40511(a)))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 40690, 40724);

                                    f_10455_40690_40723((object)sym != null);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 40756, 40784);

                                    InitializerKind
                                    elementKind
                                    = default(InitializerKind);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 40814, 40869);

                                    var
                                    value = f_10455_40826_40868(this, f_10455_40843_40850(a), out elementKind)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 40899, 42229);

                                    switch (elementKind)
                                    {

                                        case InitializerKind.CollectionInitializer:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 40899, 42229);
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 41108, 41148);

                                                var
                                                left = f_10455_41119_41147(this, sym)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 41190, 41240);

                                                f_10455_41190_41239(builder, f_10455_41202_41238(this, "ListBind", left, value));
                                                DynAbs.Tracing.TraceSender.TraceBreak(10455, 41282, 41288);

                                                break;
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 40899, 42229);

                                        case InitializerKind.Expression:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 40899, 42229);
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 41474, 41514);

                                                var
                                                left = f_10455_41485_41513(this, sym)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 41556, 41602);

                                                f_10455_41556_41601(builder, f_10455_41568_41600(this, "Bind", left, value));
                                                DynAbs.Tracing.TraceSender.TraceBreak(10455, 41644, 41650);

                                                break;
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 40899, 42229);

                                        case InitializerKind.MemberInitializer:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 40899, 42229);
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 41843, 41883);

                                                var
                                                left = f_10455_41854_41882(this, sym)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 41925, 41977);

                                                f_10455_41925_41976(builder, f_10455_41937_41975(this, "MemberBind", left, value));
                                                DynAbs.Tracing.TraceSender.TraceBreak(10455, 42019, 42025);

                                                break;
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 40899, 42229);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 40899, 42229);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 42144, 42198);

                                            throw f_10455_42150_42197(elementKind);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 40899, 42229);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 40353, 42256);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10455, 1, 1904);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10455, 1, 1904);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 42284, 42325);

                            kind = InitializerKind.MemberInitializer;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 42351, 42427);

                            return f_10455_42358_42426(_bound, f_10455_42378_42395(), f_10455_42397_42425(builder));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 40052, 43690);

                    case BoundKind.CollectionInitializerExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 40052, 43690);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 42566, 42618);

                            var
                            ci = (BoundCollectionInitializerExpression)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 42644, 42686);

                            f_10455_42644_42685(ci.Initializers.Length != 0);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 42712, 42757);

                            kind = InitializerKind.CollectionInitializer;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 42785, 42843);

                            var
                            builder = f_10455_42799_42842()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 43053, 43371);
                                foreach (BoundCollectionElementInitializer i in f_10455_43101_43116_I(f_10455_43101_43116(ci)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 43053, 43371);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 43174, 43289);

                                    BoundExpression
                                    elementInit = f_10455_43204_43288(this, "ElementInit", f_10455_43231_43261(_bound, f_10455_43249_43260(i)), f_10455_43263_43287(this, f_10455_43275_43286(i)))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 43319, 43344);

                                    f_10455_43319_43343(builder, elementInit);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 43053, 43371);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10455, 1, 319);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10455, 1, 319);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 43399, 43473);

                            return f_10455_43406_43472(_bound, f_10455_43426_43441(), f_10455_43443_43471(builder));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 40052, 43690);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 40052, 43690);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 43573, 43607);

                            kind = InitializerKind.Expression;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 43633, 43652);

                            return f_10455_43640_43651(this, node);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 40052, 43690);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 39939, 43701);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10455_40060_40069(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 40060, 40069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_40283_40326()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 40283, 40326);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_40391_40406(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 40391, 40406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_40505_40511(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 40505, 40511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10455_40474_40525(Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerMember
                this_param)
                {
                    var return_v = this_param.MemberSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 40474, 40525);
                    return return_v;
                }


                int
                f_10455_40690_40723(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 40690, 40723);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_40843_40850(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 40843, 40850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_40826_40868(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, out Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter.InitializerKind
                kind)
                {
                    var return_v = this_param.VisitInitializer(node, out kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 40826, 40868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_41119_41147(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.InitializerMemberGetter(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 41119, 41147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_41202_41238(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 41202, 41238);
                    return return_v;
                }


                int
                f_10455_41190_41239(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 41190, 41239);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_41485_41513(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.InitializerMemberSetter(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 41485, 41513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_41568_41600(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 41568, 41600);
                    return return_v;
                }


                int
                f_10455_41556_41601(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 41556, 41601);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_41854_41882(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.InitializerMemberGetter(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 41854, 41882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_41937_41975(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 41937, 41975);
                    return return_v;
                }


                int
                f_10455_41925_41976(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 41925, 41976);
                    return 0;
                }


                System.Exception
                f_10455_42150_42197(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter.InitializerKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 42150, 42197);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_40391_40406_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 40391, 40406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_42378_42395()
                {
                    var return_v = MemberBindingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 42378, 42395);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_42397_42425(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 42397, 42425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_42358_42426(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 42358, 42426);
                    return return_v;
                }


                int
                f_10455_42644_42685(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 42644, 42685);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_42799_42842()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 42799, 42842);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_43101_43116(Microsoft.CodeAnalysis.CSharp.BoundCollectionInitializerExpression
                this_param)
                {
                    var return_v = this_param.Initializers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 43101, 43116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_43249_43260(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 43249, 43260);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_43231_43261(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43231, 43261);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_43275_43286(Microsoft.CodeAnalysis.CSharp.BoundCollectionElementInitializer
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 43275, 43286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_43263_43287(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions)
                {
                    var return_v = this_param.Expressions(expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43263, 43287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_43204_43288(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43204, 43288);
                    return return_v;
                }


                int
                f_10455_43319_43343(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43319, 43343);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_43101_43116_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43101, 43116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_43426_43441()
                {
                    var return_v = ElementInitType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 43426, 43441);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_43443_43471(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43443, 43471);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_43406_43472(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43406, 43472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_43640_43651(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43640, 43651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 39939, 43701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 39939, 43701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitObjectCreationExpression(BoundObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 43713, 43950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 43827, 43939);

                return f_10455_43834_43938(this, f_10455_43863_43906(this, node), f_10455_43908_43937(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 43713, 43950);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_43863_43906(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                node)
                {
                    var return_v = this_param.VisitObjectCreationExpressionInternal(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43863, 43906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                f_10455_43908_43937(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.InitializerExpressionOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 43908, 43937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_43834_43938(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                creation, Microsoft.CodeAnalysis.CSharp.BoundObjectInitializerExpressionBase?
                initializerExpressionOpt)
                {
                    var return_v = this_param.VisitObjectCreationContinued(creation, (Microsoft.CodeAnalysis.CSharp.BoundExpression?)initializerExpressionOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 43834, 43938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 43713, 43950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 43713, 43950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitObjectCreationContinued(BoundExpression creation, BoundExpression initializerExpressionOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 43962, 44824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44107, 44129);

                var
                result = creation
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44143, 44195) || true) && (initializerExpressionOpt == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 44143, 44195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44181, 44195);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 44143, 44195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44209, 44241);

                InitializerKind
                initializerKind
                = default(InitializerKind);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44255, 44330);

                var
                init = f_10455_44266_44329(this, initializerExpressionOpt, out initializerKind)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44344, 44813);

                switch (initializerKind)
                {

                    case InitializerKind.CollectionInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 44344, 44813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44466, 44511);

                        return f_10455_44473_44510(this, "ListInit", result, init);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 44344, 44813);

                    case InitializerKind.MemberInitializer:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 44344, 44813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44590, 44637);

                        return f_10455_44597_44636(this, "MemberInit", result, init);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 44344, 44813);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 44344, 44813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44685, 44743);

                        throw f_10455_44691_44742(initializerKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 44344, 44813);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 43962, 44824);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_44266_44329(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, out Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter.InitializerKind
                kind)
                {
                    var return_v = this_param.VisitInitializer(node, out kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 44266, 44329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_44473_44510(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 44473, 44510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_44597_44636(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 44597, 44636);
                    return return_v;
                }


                System.Exception
                f_10455_44691_44742(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter.InitializerKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 44691, 44742);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 43962, 44824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 43962, 44824);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitObjectCreationExpressionInternal(BoundObjectCreationExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 44836, 46317);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 44958, 45109) || true) && (f_10455_44962_44980(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 44958, 45109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45072, 45094);

                    return f_10455_45079_45093(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 44958, 45109);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45125, 45409) || true) && ((object)f_10455_45137_45153(node) == null || (DynAbs.Tracing.TraceSender.Expression_False(10455, 45129, 45239) || (node.Arguments.Length == 0 && (DynAbs.Tracing.TraceSender.Expression_True(10455, 45183, 45238) && !f_10455_45214_45238(f_10455_45214_45223(node))))) || (DynAbs.Tracing.TraceSender.Expression_False(10455, 45129, 45308) || f_10455_45260_45308(f_10455_45260_45276(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 45125, 45409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45342, 45394);

                    return f_10455_45349_45393(this, "New", f_10455_45368_45392(_bound, f_10455_45382_45391(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 45125, 45409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45425, 45477);

                var
                ctor = f_10455_45436_45476(_bound, f_10455_45459_45475(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45491, 45590);

                var
                args = f_10455_45502_45589(_bound, f_10455_45517_45559(_IEnumerableType, f_10455_45544_45558()), f_10455_45561_45588(this, f_10455_45573_45587(node)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45604, 46306) || true) && (f_10455_45608_45633(f_10455_45608_45617(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 45608, 45663) && node.Arguments.Length != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 45604, 46306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45697, 45739);

                    var
                    anonType = (NamedTypeSymbol)f_10455_45729_45738(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45757, 45822);

                    var
                    membersBuilder = f_10455_45778_45821()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45849, 45854);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45840, 46055) || true) && (i < node.Arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45883, 45886)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 45840, 46055))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 45840, 46055);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 45928, 46036);

                            f_10455_45928_46035(membersBuilder, f_10455_45947_46034(_bound, f_10455_45965_46033(f_10455_45965_46023(anonType, i))));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10455, 1, 216);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10455, 1, 216);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 46075, 46187);

                    return f_10455_46082_46186(this, "New", ctor, args, f_10455_46113_46185(_bound, f_10455_46133_46147(), f_10455_46149_46184(membersBuilder)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 45604, 46306);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 45604, 46306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 46253, 46291);

                    return f_10455_46260_46290(this, "New", ctor, args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 45604, 46306);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 44836, 46317);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10455_44962_44980(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 44962, 44980);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_45079_45093(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                node)
                {
                    var return_v = this_param.Constant((Microsoft.CodeAnalysis.CSharp.BoundExpression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45079, 45093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_45137_45153(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45137, 45153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_45214_45223(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45214, 45223);
                    return return_v;
                }


                bool
                f_10455_45214_45238(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsStructType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45214, 45238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_45260_45276(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45260, 45276);
                    return return_v;
                }


                bool
                f_10455_45260_45308(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45260, 45308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_45382_45391(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45382, 45391);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_45368_45392(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45368, 45392);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_45349_45393(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45349, 45393);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_45459_45475(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45459, 45475);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_45436_45476(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                ctor)
                {
                    var return_v = this_param.ConstructorInfo(ctor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45436, 45476);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_45544_45558()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45544, 45558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_45517_45559(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45517, 45559);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_45573_45587(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45573, 45587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_45561_45588(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                expressions)
                {
                    var return_v = this_param.Expressions(expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45561, 45588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_45502_45589(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45502, 45589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_45608_45617(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45608, 45617);
                    return return_v;
                }


                bool
                f_10455_45608_45633(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45608, 45633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_45729_45738(Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45729, 45738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_45778_45821()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45778, 45821);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10455_45965_46023(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, int
                index)
                {
                    var return_v = AnonymousTypeManager.GetAnonymousTypeProperty(type, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45965, 46023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_45965_46033(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 45965, 46033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_45947_46034(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45947, 46034);
                    return return_v;
                }


                int
                f_10455_45928_46035(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 45928, 46035);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_46133_46147()
                {
                    var return_v = MemberInfoType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 46133, 46147);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_46149_46184(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 46149, 46184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_46113_46185(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                elements)
                {
                    var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 46113, 46185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_46082_46186(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 46082, 46186);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_46260_46290(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 46260, 46290);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 44836, 46317);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 44836, 46317);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitParameter(BoundParameter node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 46329, 46467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 46413, 46456);

                return f_10455_46420_46455(_parameterMap, f_10455_46434_46454(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 46329, 46467);

                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10455_46434_46454(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 46434, 46454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_46420_46455(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 46420, 46455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 46329, 46467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 46329, 46467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression VisitPointerIndirectionOperator(BoundPointerIndirectionOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10455, 46479, 46930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 46762, 46919);

                return f_10455_46769_46918(node.Syntax, default(LookupResultKind), ImmutableArray<Symbol>.Empty, f_10455_46862_46906(node), f_10455_46908_46917(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10455, 46479, 46930);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_46862_46906(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 46862, 46906);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_46908_46917(Microsoft.CodeAnalysis.CSharp.BoundPointerIndirectionOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 46908, 46917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10455_46769_46918(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 46769, 46918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 46479, 46930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 46479, 46930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression VisitPointerElementAccess(BoundPointerElementAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10455, 46942, 47381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 47213, 47370);

                return f_10455_47220_47369(node.Syntax, default(LookupResultKind), ImmutableArray<Symbol>.Empty, f_10455_47313_47357(node), f_10455_47359_47368(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10455, 46942, 47381);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_47313_47357(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 47313, 47357);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_47359_47368(Microsoft.CodeAnalysis.CSharp.BoundPointerElementAccess
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 47359, 47368);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10455_47220_47369(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 47220, 47369);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 46942, 47381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 46942, 47381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitPropertyAccess(BoundPropertyAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 47393, 48852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 47487, 47587);

                var
                receiver = (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 47502, 47530) || ((f_10455_47502_47530(f_10455_47502_47521(node)) && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 47533, 47560)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 47563, 47586))) ? f_10455_47533_47560(_bound, f_10455_47545_47559()) : f_10455_47563_47586(this, f_10455_47569_47585(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 47601, 47666);

                var
                getMethod = f_10455_47617_47665(f_10455_47617_47636(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 48499, 48754) || true) && (f_10455_48503_48519(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10455, 48503, 48570) && f_10455_48531_48570(f_10455_48531_48552(f_10455_48531_48547(node)))) && (DynAbs.Tracing.TraceSender.Expression_True(10455, 48503, 48629) && f_10455_48591_48629_M(!f_10455_48592_48613(f_10455_48592_48608(node)).IsReferenceType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 48499, 48754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 48663, 48739);

                    receiver = f_10455_48674_48738(this, receiver, f_10455_48697_48719(getMethod), isChecked: false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 48499, 48754);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 48770, 48841);

                return f_10455_48777_48840(this, "Property", receiver, f_10455_48811_48839(_bound, getMethod));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 47393, 48852);

                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10455_47502_47521(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 47502, 47521);
                    return return_v;
                }


                bool
                f_10455_47502_47530(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 47502, 47530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_47545_47559()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 47545, 47559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_47533_47560(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 47533, 47560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10455_47569_47585(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 47569, 47585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_47563_47586(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 47563, 47586);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10455_47617_47636(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 47617, 47636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_47617_47665(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                property)
                {
                    var return_v = property.GetOwnOrInheritedGetMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 47617, 47665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10455_48503_48519(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 48503, 48519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_48531_48547(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 48531, 48547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_48531_48552(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 48531, 48552);
                    return return_v;
                }


                bool
                f_10455_48531_48570(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 48531, 48570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_48592_48608(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 48592, 48608);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_48592_48613(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 48592, 48613);
                    return return_v;
                }


                bool
                f_10455_48591_48629_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 48591, 48629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_48697_48719(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                this_param)
                {
                    var return_v = this_param.ReceiverType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 48697, 48719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_48674_48738(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Convert(expr, type, isChecked: isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 48674, 48738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_48811_48839(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 48811, 48839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_48777_48840(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 48777, 48840);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 47393, 48852);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 47393, 48852);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression VisitSizeOfOperator(BoundSizeOfOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10455, 48864, 49291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49123, 49280);

                return f_10455_49130_49279(node.Syntax, default(LookupResultKind), ImmutableArray<Symbol>.Empty, f_10455_49223_49267(node), f_10455_49269_49278(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10455, 48864, 49291);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10455_49223_49267(Microsoft.CodeAnalysis.CSharp.BoundSizeOfOperator
                item)
                {
                    var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 49223, 49267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_49269_49278(Microsoft.CodeAnalysis.CSharp.BoundSizeOfOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 49269, 49278);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10455_49130_49279(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                childBoundNodes, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBadExpression(syntax, resultKind, symbols, childBoundNodes, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 49130, 49279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 48864, 49291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 48864, 49291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression VisitUnaryOperator(BoundUnaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 49303, 51220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49395, 49418);

                var
                arg = f_10455_49405_49417(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49432, 49460);

                var
                loweredArg = f_10455_49449_49459(this, arg)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49474, 49505);

                var
                opKind = f_10455_49487_49504(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49519, 49562);

                var
                op = opKind & UnaryOperatorKind.OpMask
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49576, 49634);

                var
                isChecked = (opKind & UnaryOperatorKind.Checked) != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49650, 49664);

                string
                opname
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49678, 50412);

                switch (op)
                {

                    case UnaryOperatorKind.UnaryPlus:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 49678, 50412);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49777, 49902) || true) && ((object)f_10455_49789_49803(node) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 49777, 49902);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49861, 49879);

                            return loweredArg;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 49777, 49902);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 49924, 49945);

                        opname = "UnaryPlus";
                        DynAbs.Tracing.TraceSender.TraceBreak(10455, 49967, 49973);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 49678, 50412);

                    case UnaryOperatorKind.UnaryMinus:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 49678, 50412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50047, 50095);

                        opname = (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 50056, 50065) || ((isChecked && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 50068, 50083)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 50086, 50094))) ? "NegateChecked" : "Negate";
                        DynAbs.Tracing.TraceSender.TraceBreak(10455, 50117, 50123);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 49678, 50412);

                    case UnaryOperatorKind.BitwiseComplement:
                    case UnaryOperatorKind.LogicalNegation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 49678, 50412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50261, 50276);

                        opname = "Not";
                        DynAbs.Tracing.TraceSender.TraceBreak(10455, 50298, 50304);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 49678, 50412);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 49678, 50412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50352, 50397);

                        throw f_10455_50358_50396(op);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 49678, 50412);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50428, 51016) || true) && (f_10455_50432_50464(f_10455_50432_50449(node)) == UnaryOperatorKind.Enum && (DynAbs.Tracing.TraceSender.Expression_True(10455, 50432, 50534) && (opKind & UnaryOperatorKind.Lifted) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10455, 50428, 51016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50568, 50613);

                    f_10455_50568_50612((object)f_10455_50589_50603(node) == null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50631, 50712);

                    var
                    promotedType = f_10455_50650_50711(this, f_10455_50663_50710(f_10455_50663_50686(f_10455_50663_50671(arg))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50730, 50783);

                    promotedType = f_10455_50745_50782(_nullableType, promotedType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50801, 50876);

                    loweredArg = f_10455_50814_50875(this, loweredArg, f_10455_50834_50842(arg), promotedType, isChecked, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50894, 50939);

                    var
                    result = f_10455_50907_50938(this, opname, loweredArg)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 50957, 51001);

                    return f_10455_50964_51000(this, result, f_10455_50979_50988(node), isChecked);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10455, 50428, 51016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 51032, 51209);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 51039, 51071) || ((((object)f_10455_51048_51062(node) == null)
                && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 51091, 51122)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 51142, 51208))) ? f_10455_51091_51122(this, opname, loweredArg) : f_10455_51142_51208(this, opname, loweredArg, f_10455_51174_51207(_bound, f_10455_51192_51206(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 49303, 51220);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_49405_49417(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 49405, 49417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_49449_49459(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 49449, 49459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10455_49487_49504(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 49487, 49504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_49789_49803(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 49789, 49803);
                    return return_v;
                }


                System.Exception
                f_10455_50358_50396(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50358, 50396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10455_50432_50449(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 50432, 50449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10455_50432_50464(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50432, 50464);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_50589_50603(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 50589, 50603);
                    return return_v;
                }


                int
                f_10455_50568_50612(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50568, 50612);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_50663_50671(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 50663, 50671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_50663_50686(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50663, 50686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10455_50663_50710(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetEnumUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50663, 50710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_50650_50711(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                underlying)
                {
                    var return_v = this_param.PromotedType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50650, 50711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_50745_50782(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50745, 50782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_50834_50842(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 50834, 50842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_50814_50875(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                oldType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                newType, bool
                isChecked, bool
                isExplicit)
                {
                    var return_v = this_param.Convert(operand, oldType, newType, isChecked, isExplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50814, 50875);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_50907_50938(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50907, 50938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10455_50979_50988(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 50979, 50988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_50964_51000(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isChecked)
                {
                    var return_v = this_param.Demote(node, type, isChecked);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 50964, 51000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10455_51048_51062(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 51048, 51062);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_51091_51122(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 51091, 51122);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10455_51192_51206(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 51192, 51206);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_51174_51207(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.MethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 51174, 51207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_51142_51208(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 51142, 51208);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 49303, 51220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 49303, 51220);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression ExprFactory(string name, params BoundExpression[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 51301, 51479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 51410, 51468);

                return f_10455_51417_51467(_bound, f_10455_51435_51449(), name, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 51301, 51479);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_51435_51449()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 51435, 51449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_51417_51467(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                receiver, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)receiver, name, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 51417, 51467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 51301, 51479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 51301, 51479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression ExprFactory(string name, ImmutableArray<TypeSymbol> typeArgs, params BoundExpression[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 51491, 51791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 51637, 51780);

                return f_10455_51644_51779(_bound, (DynAbs.Tracing.TraceSender.Conditional_F1(10455, 51662, 51682) || ((_ignoreAccessibility && DynAbs.Tracing.TraceSender.Conditional_F2(10455, 51685, 51716)) || DynAbs.Tracing.TraceSender.Conditional_F3(10455, 51719, 51735))) ? BinderFlags.IgnoreAccessibility : BinderFlags.None, f_10455_51737_51751(), name, typeArgs, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 51491, 51791);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10455_51737_51751()
                {
                    var return_v = ExpressionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 51737, 51751);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_51644_51779(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                receiver, string
                name, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArgs, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall(flags, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)receiver, name, typeArgs, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 51644, 51779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 51491, 51791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 51491, 51791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression Constant(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10455, 51803, 52037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10455, 51882, 52026);

                return f_10455_51889_52025(this, "Constant", f_10455_51948_51981(_bound, _objectType, node), f_10455_52000_52024(_bound, f_10455_52014_52023(node)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10455, 51803, 52037);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_51948_51981(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg)
                {
                    var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 51948, 51981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10455_52014_52023(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 52014, 52023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_52000_52024(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = this_param.Typeof(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 52000, 52024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10455_51889_52025(Microsoft.CodeAnalysis.CSharp.ExpressionLambdaRewriter
                this_param, string
                name, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                arguments)
                {
                    var return_v = this_param.ExprFactory(name, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 51889, 52025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10455, 51803, 52037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 51803, 52037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ExpressionLambdaRewriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10455, 509, 52044);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10455, 509, 52044);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10455, 509, 52044);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10455, 509, 52044);

        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>
        f_10455_832_882()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 832, 882);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10455_3664_3685(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
        this_param)
        {
            var return_v = this_param.Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 3664, 3685);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        f_10455_3628_3723(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
        topLevelMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        currentClassOpt, Microsoft.CodeAnalysis.SyntaxNode
        node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
        compilationState, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory(topLevelMethodOpt, currentClassOpt, node, compilationState, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 3628, 3723);
            return return_v;
        }


        bool
        f_10455_3761_3814(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder?
        this_param)
        {
            var return_v = this_param.IgnoreAccessibility;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10455, 3761, 3814);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10455_3842_3886(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.SpecialType
        st)
        {
            var return_v = this_param.SpecialType(st);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 3842, 3886);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10455_3915_3960(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.SpecialType
        st)
        {
            var return_v = this_param.SpecialType(st);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 3915, 3960);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10455_3991_4040(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.SpecialType
        st)
        {
            var return_v = this_param.SpecialType(st);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 3991, 4040);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10455_4074_4146(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
        this_param, Microsoft.CodeAnalysis.SpecialType
        st)
        {
            var return_v = this_param.SpecialType(st);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10455, 4074, 4146);
            return return_v;
        }

    }
}
