// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        private sealed partial class AnonymousTypeConstructorSymbol : SynthesizedMethodBase
        {
            internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 639, 2849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1055, 1144);

                    SyntheticBoundNodeFactory
                    F = f_10620_1085_1143(this, compilationState, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1164, 1201);

                    int
                    paramCount = f_10620_1181_1200(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1260, 1325);

                    BoundStatement[]
                    statements = new BoundStatement[paramCount + 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1343, 1366);

                    int
                    statementIndex = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1438, 1537);

                    f_10620_1438_1536(f_10620_1451_1506(f_10620_1451_1494(f_10620_1451_1465())) == SpecialType.System_Object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1555, 1660);

                    BoundExpression
                    call = f_10620_1578_1659(this, diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1678, 1850) || true) && (call == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 1678, 1850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1824, 1831);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 1678, 1850);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1868, 1927);

                    statements[statementIndex++] = f_10620_1899_1926(F, call);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 1947, 2632) || true) && (paramCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 1947, 2632);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 2007, 2100);

                        AnonymousTypeTemplateSymbol
                        anonymousType = (AnonymousTypeTemplateSymbol)f_10620_2080_2099(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 2122, 2182);

                        f_10620_2122_2181(anonymousType.Properties.Length == paramCount);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 2253, 2262);

                            // Assign fields
                            for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 2244, 2613) || true) && (index < f_10620_2272_2291(this))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 2293, 2300)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 2244, 2613))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 2244, 2613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 2419, 2590);

                                statements[statementIndex++] =
                                f_10620_2479_2589(F, f_10620_2492_2555(F, f_10620_2500_2508(F), f_10620_2510_2554(anonymousType.Properties[index])), f_10620_2557_2588(F, _parameters[index]));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10620, 1, 370);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10620, 1, 370);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 1947, 2632);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 2695, 2737);

                    statements[statementIndex++] = f_10620_2726_2736(F);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 2799, 2834);

                    f_10620_2799_2833(
                                    // Create a bound block 
                                    F, f_10620_2813_2832(F, statements));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 639, 2849);

                    Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    f_10620_1085_1143(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateBoundNodeFactory(compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 1085, 1143);
                        return return_v;
                    }


                    int
                    f_10620_1181_1200(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 1181, 1200);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_1451_1465()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 1451, 1465);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_1451_1494(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 1451, 1494);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10620_1451_1506(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 1451, 1506);
                        return return_v;
                    }


                    int
                    f_10620_1438_1536(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 1438, 1536);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10620_1578_1659(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
                    constructor, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = MethodCompiler.GenerateBaseParameterlessConstructorInitializer((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)constructor, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 1578, 1659);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10620_1899_1926(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement(expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 1899, 1926);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_2080_2099(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 2080, 2099);
                        return return_v;
                    }


                    int
                    f_10620_2122_2181(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 2122, 2181);
                        return 0;
                    }


                    int
                    f_10620_2272_2291(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 2272, 2291);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10620_2500_2508(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 2500, 2508);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10620_2510_2554(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.BackingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 2510, 2554);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10620_2492_2555(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 2492, 2555);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10620_2557_2588(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 2557, 2588);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10620_2479_2589(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    left, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    right)
                    {
                        var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 2479, 2589);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10620_2726_2736(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Return();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 2726, 2736);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10620_2813_2832(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 2813, 2832);
                        return return_v;
                    }


                    int
                    f_10620_2799_2833(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 2799, 2833);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 639, 2849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 639, 2849);
                }
            }

            internal override bool HasSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 2935, 2955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 2941, 2953);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 2935, 2955);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 2865, 2970);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 2865, 2970);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static AnonymousTypeConstructorSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10620, 531, 2981);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10620, 531, 2981);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 531, 2981);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10620, 531, 2981);
        }
        private sealed partial class AnonymousTypePropertyGetAccessorSymbol : SynthesizedMethodBase
        {
            internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 3109, 3600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 3402, 3491);

                    SyntheticBoundNodeFactory
                    F = f_10620_3432_3490(this, compilationState, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 3509, 3585);

                    f_10620_3509_3584(F, f_10620_3523_3583(F, f_10620_3531_3582(F, f_10620_3540_3581(F, f_10620_3548_3556(F), f_10620_3558_3580(_property)))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 3109, 3600);

                    Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    f_10620_3432_3490(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertyGetAccessorSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateBoundNodeFactory(compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 3432, 3490);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10620_3548_3556(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 3548, 3556);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10620_3558_3580(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.BackingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 3558, 3580);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10620_3540_3581(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 3540, 3581);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10620_3531_3582(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    expression)
                    {
                        var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 3531, 3582);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10620_3523_3583(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 3523, 3583);
                        return return_v;
                    }


                    int
                    f_10620_3509_3584(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 3509, 3584);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 3109, 3600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 3109, 3600);
                }
            }

            internal override bool HasSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 3686, 3706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 3692, 3704);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 3686, 3706);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 3616, 3721);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 3616, 3721);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static AnonymousTypePropertyGetAccessorSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10620, 2993, 3732);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10620, 2993, 3732);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 2993, 3732);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10620, 2993, 3732);
        }
        private sealed partial class AnonymousTypeEqualsMethodSymbol : SynthesizedMethodBase
        {
            internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 3853, 6613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 3993, 4083);

                    AnonymousTypeManager
                    manager = ((AnonymousTypeTemplateSymbol)f_10620_4054_4073(this)).Manager
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 4101, 4190);

                    SyntheticBoundNodeFactory
                    F = f_10620_4131_4189(this, compilationState, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 4784, 4877);

                    AnonymousTypeTemplateSymbol
                    anonymousType = (AnonymousTypeTemplateSymbol)f_10620_4857_4876(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 4924, 4965);

                    BoundAssignmentOperator
                    assignmentToTemp
                    = default(BoundAssignmentOperator);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 4983, 5093);

                    BoundLocal
                    boundLocal = f_10620_5007_5092(F, f_10620_5021_5069(F, f_10620_5026_5053(F, _parameters[0]), anonymousType), out assignmentToTemp)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 5188, 5256);

                    BoundStatement
                    assignment = f_10620_5216_5255(F, assignmentToTemp)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 5396, 5747);

                    BoundExpression
                    retExpression = f_10620_5428_5746(F, BinaryOperatorKind.ObjectNotEqual, f_10620_5530_5552(manager), f_10620_5612_5656(F, f_10620_5622_5643(manager), boundLocal), f_10620_5716_5745(F, f_10620_5723_5744(manager)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 5802, 6310) || true) && (anonymousType.Properties.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 5802, 6310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 5883, 5967);

                        var
                        fields = f_10620_5896_5966(anonymousType.Properties.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 5989, 6137);
                            foreach (var prop in f_10620_6010_6034_I(anonymousType.Properties))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 5989, 6137);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 6084, 6114);

                                f_10620_6084_6113(fields, f_10620_6095_6112(prop));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 5989, 6137);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10620, 1, 149);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10620, 1, 149);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 6159, 6255);

                        retExpression = f_10620_6175_6254(retExpression, boundLocal, fields, F);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 6277, 6291);

                        f_10620_6277_6290(fields);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 5802, 6310);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 6373, 6427);

                    BoundStatement
                    retStatement = f_10620_6403_6426(F, retExpression)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 6489, 6598);

                    f_10620_6489_6597(
                                    // Create a bound block 
                                    F, f_10620_6503_6596(F, f_10620_6511_6569(f_10620_6546_6568(boundLocal)), assignment, retStatement));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 3853, 6613);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_4054_4073(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeEqualsMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 4054, 4073);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    f_10620_4131_4189(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeEqualsMethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateBoundNodeFactory(compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 4131, 4189);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_4857_4876(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeEqualsMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 4857, 4876);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundParameter
                    f_10620_5026_5053(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    p)
                    {
                        var return_v = this_param.Parameter(p);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 5026, 5053);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                    f_10620_5021_5069(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                    operand, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    type)
                    {
                        var return_v = this_param.As((Microsoft.CodeAnalysis.CSharp.BoundExpression)operand, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 5021, 5069);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLocal
                    f_10620_5007_5092(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundAsOperator
                    argument, out Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    store)
                    {
                        var return_v = this_param.StoreToTemp((Microsoft.CodeAnalysis.CSharp.BoundExpression)argument, out store);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 5007, 5092);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    f_10620_5216_5255(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                    expr)
                    {
                        var return_v = this_param.ExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpression)expr);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 5216, 5255);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_5530_5552(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Boolean;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 5530, 5552);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_5622_5643(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Object;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 5622, 5643);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10620_5612_5656(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    arg)
                    {
                        var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 5612, 5656);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_5723_5744(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Object;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 5723, 5744);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10620_5716_5745(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = this_param.Null((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 5716, 5745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                    f_10620_5428_5746(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    right)
                    {
                        var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 5428, 5746);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    f_10620_5896_5966(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<FieldSymbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 5896, 5966);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10620_6095_6112(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.BackingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 6095, 6112);
                        return return_v;
                    }


                    int
                    f_10620_6084_6113(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 6084, 6113);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
                    f_10620_6010_6034_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 6010, 6034);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10620_6175_6254(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    initialExpression, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    otherReceiver, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    fields, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    F)
                    {
                        var return_v = MethodBodySynthesizer.GenerateFieldEquals(initialExpression, (Microsoft.CodeAnalysis.CSharp.BoundExpression)otherReceiver, fields, F);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 6175, 6254);
                        return return_v;
                    }


                    int
                    f_10620_6277_6290(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 6277, 6290);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10620_6403_6426(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression)
                    {
                        var return_v = this_param.Return(expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 6403, 6426);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10620_6546_6568(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 6546, 6568);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10620_6511_6569(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create<LocalSymbol>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 6511, 6569);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10620_6503_6596(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(locals, statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 6503, 6596);
                        return return_v;
                    }


                    int
                    f_10620_6489_6597(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 6489, 6597);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 3853, 6613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 3853, 6613);
                }
            }

            internal override bool HasSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 6699, 6720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 6705, 6718);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 6699, 6720);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 6629, 6735);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 6629, 6735);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
        }
        private sealed partial class AnonymousTypeGetHashCodeMethodSymbol : SynthesizedMethodBase
        {
            internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 6872, 10053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 7012, 7102);

                    AnonymousTypeManager
                    manager = ((AnonymousTypeTemplateSymbol)f_10620_7073_7092(this)).Manager
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 7120, 7209);

                    SyntheticBoundNodeFactory
                    F = f_10620_7150_7208(this, compilationState, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 8375, 8468);

                    AnonymousTypeTemplateSymbol
                    anonymousType = (AnonymousTypeTemplateSymbol)f_10620_8448_8467(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 8519, 8536);

                    int
                    initHash = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 8554, 8781);
                        foreach (var property in f_10620_8579_8603_I(anonymousType.Properties))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 8554, 8781);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 8645, 8762);

                            initHash = unchecked(initHash * MethodBodySynthesizer.HASH_FACTOR + f_10620_8713_8760(f_10620_8733_8759(f_10620_8733_8754(property))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 8554, 8781);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10620, 1, 228);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10620, 1, 228);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 8920, 8972);

                    BoundExpression
                    retExpression = f_10620_8952_8971(F, initHash)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 9029, 9140);

                    MethodSymbol
                    equalityComparer_GetHashCode = f_10620_9073_9139(manager)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 9158, 9269);

                    MethodSymbol
                    equalityComparer_get_Default = f_10620_9202_9268(manager)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 9328, 9364);

                    BoundLiteral
                    boundHashFactor = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 9428, 9437);

                        // Process fields
                        for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 9419, 9928) || true) && (index < anonymousType.Properties.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 9480, 9487)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 9419, 9928))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 9419, 9928);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 9529, 9909);

                            retExpression = f_10620_9545_9908(retExpression, equalityComparer_GetHashCode, equalityComparer_get_Default, ref boundHashFactor, f_10620_9762_9825(F, f_10620_9770_9778(F), f_10620_9780_9824(anonymousType.Properties[index])), F);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10620, 1, 510);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10620, 1, 510);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 9990, 10038);

                    f_10620_9990_10037(
                                    // Create a bound block 
                                    F, f_10620_10004_10036(F, f_10620_10012_10035(F, retExpression)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 6872, 10053);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_7073_7092(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeGetHashCodeMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 7073, 7092);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    f_10620_7150_7208(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeGetHashCodeMethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateBoundNodeFactory(compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 7150, 7208);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_8448_8467(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeGetHashCodeMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 8448, 8467);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10620_8733_8754(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.BackingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 8733, 8754);
                        return return_v;
                    }


                    string
                    f_10620_8733_8759(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 8733, 8759);
                        return return_v;
                    }


                    int
                    f_10620_8713_8760(string
                    text)
                    {
                        var return_v = Hash.GetFNVHashCode(text);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 8713, 8760);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
                    f_10620_8579_8603_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 8579, 8603);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10620_8952_8971(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, int
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 8952, 8971);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10620_9073_9139(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Collections_Generic_EqualityComparer_T__GetHashCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 9073, 9139);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10620_9202_9268(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Collections_Generic_EqualityComparer_T__get_Default;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 9202, 9268);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10620_9770_9778(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 9770, 9778);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10620_9780_9824(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.BackingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 9780, 9824);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10620_9762_9825(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 9762, 9825);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10620_9545_9908(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    currentHashValue, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    system_Collections_Generic_EqualityComparer_T__GetHashCode, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    system_Collections_Generic_EqualityComparer_T__get_Default, ref Microsoft.CodeAnalysis.CSharp.BoundLiteral?
                    boundHashFactor, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    valueToHash, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    F)
                    {
                        var return_v = MethodBodySynthesizer.GenerateHashCombine(currentHashValue, system_Collections_Generic_EqualityComparer_T__GetHashCode, system_Collections_Generic_EqualityComparer_T__get_Default, ref boundHashFactor, (Microsoft.CodeAnalysis.CSharp.BoundExpression)valueToHash, F);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 9545, 9908);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10620_10012_10035(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression)
                    {
                        var return_v = this_param.Return(expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 10012, 10035);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10620_10004_10036(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 10004, 10036);
                        return return_v;
                    }


                    int
                    f_10620_9990_10037(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 9990, 10037);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 6872, 10053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 6872, 10053);
                }
            }

            internal override bool HasSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 10139, 10160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 10145, 10158);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 10139, 10160);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 10069, 10175);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 10069, 10175);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
        }
        private sealed partial class AnonymousTypeToStringMethodSymbol : SynthesizedMethodBase
        {
            internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 10309, 14222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 10449, 10539);

                    AnonymousTypeManager
                    manager = ((AnonymousTypeTemplateSymbol)f_10620_10510_10529(this)).Manager
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 10557, 10646);

                    SyntheticBoundNodeFactory
                    F = f_10620_10587_10645(this, compilationState, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11115, 11208);

                    AnonymousTypeTemplateSymbol
                    anonymousType = (AnonymousTypeTemplateSymbol)f_10620_11188_11207(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11265, 11314);

                    int
                    fieldCount = anonymousType.Properties.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11332, 11369);

                    BoundExpression
                    retExpression = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11389, 14139) || true) && (fieldCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 11389, 14139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11527, 11589);

                        BoundExpression[]
                        arguments = new BoundExpression[fieldCount]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11657, 11726);

                        PooledStringBuilder
                        formatString = f_10620_11692_11725()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11757, 11762);
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11748, 13314) || true) && (i < fieldCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11780, 11783)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 11748, 13314))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 11748, 13314);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11833, 11900);

                                AnonymousTypePropertySymbol
                                property = anonymousType.Properties[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 11976, 12079);

                                f_10620_11976_12078(
                                                        // build format string
                                                        formatString.Builder, (DynAbs.Tracing.TraceSender.Conditional_F1(10620, 12010, 12016) || ((i == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10620, 12019, 12039)) || DynAbs.Tracing.TraceSender.Conditional_F3(10620, 12042, 12059))) ? "{{{{ {0} = {{{1}}}" : ", {0} = {{{1}}}", f_10620_12061_12074(property), i);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 12150, 13291);

                                arguments[i] = f_10620_12165_13290(F, f_10620_12175_12196(manager), f_10620_12248_13209(f_10620_12282_12290(F), f_10620_12369_12409(F, f_10620_12377_12385(F), f_10620_12387_12408(property)), null, f_10620_12571_12935(F, f_10620_12578_12901(f_10620_12689_12697(F), id: i, type: f_10620_12874_12900(f_10620_12874_12895(property))), f_10620_12903_12934(manager)), null, id: i, type: f_10620_13187_13208(manager)), Conversion.ImplicitReference);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10620, 1, 1567);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10620, 1, 1567);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 13336, 13371);

                        f_10620_13336_13370(formatString.Builder, " }}");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 13447, 13514);

                        BoundExpression
                        format = f_10620_13472_13513(F, f_10620_13482_13512(formatString))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 13677, 13742);

                        var
                        formatMethod = f_10620_13696_13741(manager)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 13764, 13929);

                        retExpression = f_10620_13780_13928(F, f_10620_13793_13814(manager), formatMethod, f_10620_13830_13869(F, f_10620_13837_13868(f_10620_13837_13860(formatMethod)[0])), format, f_10620_13879_13927(F, f_10620_13894_13915(manager), arguments));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 11389, 14139);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10620, 11389, 14139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 14087, 14120);

                        retExpression = f_10620_14103_14119(F, "{ }");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10620, 11389, 14139);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 14159, 14207);

                    f_10620_14159_14206(
                                    F, f_10620_14173_14205(F, f_10620_14181_14204(F, retExpression)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 10309, 14222);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_10510_10529(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeToStringMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 10510, 10529);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    f_10620_10587_10645(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeToStringMethodSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.CreateBoundNodeFactory(compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 10587, 10645);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_11188_11207(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeToStringMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 11188, 11207);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    f_10620_11692_11725()
                    {
                        var return_v = PooledStringBuilder.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 11692, 11725);
                        return return_v;
                    }


                    string
                    f_10620_12061_12074(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 12061, 12074);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10620_11976_12078(System.Text.StringBuilder
                    this_param, string
                    format, string
                    arg0, int
                    arg1)
                    {
                        var return_v = this_param.AppendFormat(format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 11976, 12078);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_12175_12196(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Object;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 12175, 12196);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10620_12282_12290(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Syntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 12282, 12290);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    f_10620_12377_12385(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.This();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 12377, 12385);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10620_12387_12408(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.BackingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 12387, 12408);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    f_10620_12369_12409(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f)
                    {
                        var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 12369, 12409);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxNode
                    f_10620_12689_12697(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.Syntax;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 12689, 12697);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10620_12874_12895(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.BackingField;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 12874, 12895);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10620_12874_12900(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 12874, 12900);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver
                    f_10620_12578_12901(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, int
                    id, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver(syntax, id: id, type: type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 12578, 12901);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10620_12903_12934(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Object__ToString;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 12903, 12934);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10620_12571_12935(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundConditionalReceiver
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 12571, 12935);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_13187_13208(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_String;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 13187, 13208);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                    f_10620_12248_13209(Microsoft.CodeAnalysis.SyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    hasValueMethodOpt, Microsoft.CodeAnalysis.CSharp.BoundCall
                    whenNotNull, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                    whenNullOpt, int
                    id, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, hasValueMethodOpt, (Microsoft.CodeAnalysis.CSharp.BoundExpression)whenNotNull, whenNullOpt, id: id, type: (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 12248, 13209);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10620_12165_13290(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.BoundLoweredConditionalAccess
                    arg, Microsoft.CodeAnalysis.CSharp.Conversion
                    conversion)
                    {
                        var return_v = this_param.Convert((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 12165, 13290);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10620_13336_13370(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 13336, 13370);
                        return return_v;
                    }


                    string
                    f_10620_13482_13512(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToStringAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 13482, 13512);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10620_13472_13513(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 13472, 13513);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10620_13696_13741(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_String__Format_IFormatProvider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 13696, 13741);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_13793_13814(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_String;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 13793, 13814);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10620_13837_13860(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 13837, 13860);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10620_13837_13868(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 13837, 13868);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10620_13830_13869(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = this_param.Null(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 13830, 13869);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10620_13894_13915(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Object;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10620, 13894, 13915);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10620_13879_13927(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    elementType, Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    elements)
                    {
                        var return_v = this_param.ArrayOrEmpty((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType, elements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 13879, 13927);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10620_13780_13928(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                    args)
                    {
                        var return_v = this_param.StaticCall((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)receiver, method, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 13780, 13928);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundLiteral
                    f_10620_14103_14119(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Literal(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 14103, 14119);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10620_14181_14204(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expression)
                    {
                        var return_v = this_param.Return(expression);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 14181, 14204);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10620_14173_14205(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 14173, 14205);
                        return return_v;
                    }


                    int
                    f_10620_14159_14206(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10620, 14159, 14206);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 10309, 14222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 10309, 14222);
                }
            }

            internal override bool HasSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10620, 14308, 14329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10620, 14314, 14327);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10620, 14308, 14329);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10620, 14238, 14344);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10620, 14238, 14344);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
        }
    }
}
