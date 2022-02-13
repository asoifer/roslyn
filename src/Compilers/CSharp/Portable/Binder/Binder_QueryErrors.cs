// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;
using System;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal void ReportQueryLookupFailed(
                    SyntaxNode queryClause,
                    BoundExpression instanceArgument,
                    string name,
                    ImmutableArray<Symbol> symbols,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10317, 800, 3710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1058, 1093);

                FromClauseSyntax
                fromClause = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1123, 1141);
                    for (SyntaxNode
        node = queryClause
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1107, 1396) || true) && (true)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1145, 1163)
        , node = f_10317_1152_1163(node), DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 1107, 1396))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 1107, 1396);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1197, 1235);

                        var
                        e = node as QueryExpressionSyntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1253, 1381) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 1253, 1381);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1308, 1334);

                            fromClause = f_10317_1321_1333(e);
                            DynAbs.Tracing.TraceSender.TraceBreak(10317, 1356, 1362);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 1253, 1381);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10317, 1, 290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10317, 1, 290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1412, 1462);

                HashSet<DiagnosticInfo>
                useSiteDiagnostics = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1478, 3634) || true) && (f_10317_1482_1515(f_10317_1482_1503(instanceArgument)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 1478, 3634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1680, 1866);

                    f_10317_1680_1865(                // CS1979: Query expressions over source type 'dynamic' or with a join sequence of type 'dynamic' are not allowed
                                    diagnostics, f_10317_1718_1810(ErrorCode.ERR_BadDynamicQuery, f_10317_1779_1800(), symbols), f_10317_1833_1864(queryClause));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 1478, 3634);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 1478, 3634);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 1900, 3634) || true) && (f_10317_1904_1989(this, f_10317_1937_1958(instanceArgument), name, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 1900, 3634);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 2224, 2507);

                        f_10317_2224_2506(                // Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Are you missing required assembly references or a using directive for 'System.Linq'?
                                        diagnostics, f_10317_2240_2427(ErrorCode.ERR_QueryNoProviderStandard, new object[] { f_10317_2367_2388(instanceArgument), name }, symbols), f_10317_2429_2505((DynAbs.Tracing.TraceSender.Conditional_F1(10317, 2448, 2466) || ((fromClause != null && DynAbs.Tracing.TraceSender.Conditional_F2(10317, 2469, 2490)) || DynAbs.Tracing.TraceSender.Conditional_F3(10317, 2493, 2504))) ? f_10317_2469_2490(fromClause) : queryClause));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 1900, 3634);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 1900, 3634);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 2541, 3634) || true) && (fromClause != null && (DynAbs.Tracing.TraceSender.Expression_True(10317, 2545, 2590) && f_10317_2567_2582(fromClause) == null) && (DynAbs.Tracing.TraceSender.Expression_True(10317, 2545, 2663) && f_10317_2594_2663(this, f_10317_2617_2638(instanceArgument), ref useSiteDiagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 2541, 3634);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 2882, 3163);

                            f_10317_2882_3162(                // Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.  Consider explicitly specifying the type of the range variable '{2}'.
                                            diagnostics, f_10317_2898_3118(ErrorCode.ERR_QueryNoProviderCastable, new object[] { f_10317_3025_3046(instanceArgument), name, fromClause.Identifier.ValueText }, symbols), f_10317_3120_3161(f_10317_3139_3160(fromClause)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 2541, 3634);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 2541, 3634);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 3344, 3619);

                            f_10317_3344_3618(                // Could not find an implementation of the query pattern for source type '{0}'.  '{1}' not found.
                                            diagnostics, f_10317_3360_3539(ErrorCode.ERR_QueryNoProvider, new object[] { f_10317_3479_3500(instanceArgument), name }, symbols), f_10317_3541_3617((DynAbs.Tracing.TraceSender.Conditional_F1(10317, 3560, 3578) || ((fromClause != null && DynAbs.Tracing.TraceSender.Conditional_F2(10317, 3581, 3602)) || DynAbs.Tracing.TraceSender.Conditional_F3(10317, 3605, 3616))) ? f_10317_3581_3602(fromClause) : queryClause));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 2541, 3634);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 1900, 3634);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 1478, 3634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 3650, 3699);

                f_10317_3650_3698(
                            diagnostics, queryClause, useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10317, 800, 3710);

                Microsoft.CodeAnalysis.SyntaxNode?
                f_10317_1152_1163(Microsoft.CodeAnalysis.SyntaxNode?
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 1152, 1163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                f_10317_1321_1333(Microsoft.CodeAnalysis.CSharp.Syntax.QueryExpressionSyntax
                this_param)
                {
                    var return_v = this_param.FromClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 1321, 1333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10317_1482_1503(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 1482, 1503);
                    return return_v;
                }


                bool
                f_10317_1482_1515(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 1482, 1515);
                    return return_v;
                }


                object[]
                f_10317_1779_1800()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 1779, 1800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10317_1718_1810(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 1718, 1810);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10317_1833_1864(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 1833, 1864);
                    return return_v;
                }


                int
                f_10317_1680_1865(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 1680, 1865);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10317_1937_1958(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 1937, 1958);
                    return return_v;
                }


                bool
                f_10317_1904_1989(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                instanceType, string
                name, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ImplementsStandardQueryInterface(instanceType, name, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 1904, 1989);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10317_2367_2388(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 2367, 2388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10317_2240_2427(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 2240, 2427);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10317_2469_2490(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 2469, 2490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10317_2429_2505(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 2429, 2505);
                    return return_v;
                }


                int
                f_10317_2224_2506(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 2224, 2506);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax?
                f_10317_2567_2582(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 2567, 2582);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10317_2617_2638(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 2617, 2638);
                    return return_v;
                }


                bool
                f_10317_2594_2663(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                instanceType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasCastToQueryProvider(instanceType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 2594, 2663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10317_3025_3046(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 3025, 3046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10317_2898_3118(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 2898, 3118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10317_3139_3160(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 3139, 3160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10317_3120_3161(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation((Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 3120, 3161);
                    return return_v;
                }


                int
                f_10317_2882_3162(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 2882, 3162);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10317_3479_3500(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 3479, 3500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10317_3360_3539(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 3360, 3539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10317_3581_3602(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 3581, 3602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SourceLocation
                f_10317_3541_3617(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.SourceLocation(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 3541, 3617);
                    return return_v;
                }


                int
                f_10317_3344_3618(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.SourceLocation
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, (Microsoft.CodeAnalysis.Location)location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 3344, 3618);
                    return 0;
                }


                bool
                f_10317_3650_3698(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 3650, 3698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10317, 800, 3710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10317, 800, 3710);
            }
        }

        private bool ImplementsStandardQueryInterface(TypeSymbol instanceType, string name, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10317, 3722, 4874);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 3878, 4064) || true) && (f_10317_3882_3903(instanceType) == TypeKind.Array || (DynAbs.Tracing.TraceSender.Expression_False(10317, 3882, 4003) || name == "Cast" && (DynAbs.Tracing.TraceSender.Expression_True(10317, 3925, 4003) && f_10317_3943_4003(this, instanceType, ref useSiteDiagnostics))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 3878, 4064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 4037, 4049);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 3878, 4064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 4080, 4103);

                bool
                nonUnique = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 4117, 4168);

                var
                originalType = f_10317_4136_4167(instanceType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 4182, 4283);

                var
                ienumerable_t = f_10317_4202_4282(f_10317_4202_4213(), SpecialType.System_Collections_Generic_IEnumerable_T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 4297, 4385);

                var
                iqueryable_t = f_10317_4316_4384(f_10317_4316_4327(), WellKnownType.System_Linq_IQueryable_T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 4399, 4594);

                bool
                isIenumerable = f_10317_4420_4503(originalType, ienumerable_t, TypeCompareKind.ConsiderEverything2) || (DynAbs.Tracing.TraceSender.Expression_False(10317, 4420, 4593) || f_10317_4507_4593(instanceType, ienumerable_t, ref nonUnique, ref useSiteDiagnostics))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 4608, 4799);

                bool
                isQueryable = f_10317_4627_4709(originalType, iqueryable_t, TypeCompareKind.ConsiderEverything2) || (DynAbs.Tracing.TraceSender.Expression_False(10317, 4627, 4798) || f_10317_4713_4798(instanceType, iqueryable_t, ref nonUnique, ref useSiteDiagnostics))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 4813, 4863);

                return isIenumerable != isQueryable && (DynAbs.Tracing.TraceSender.Expression_True(10317, 4820, 4862) && !nonUnique);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10317, 3722, 4874);

                Microsoft.CodeAnalysis.TypeKind
                f_10317_3882_3903(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 3882, 3903);
                    return return_v;
                }


                bool
                f_10317_3943_4003(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                instanceType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasCastToQueryProvider(instanceType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 3943, 4003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10317_4136_4167(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 4136, 4167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10317_4202_4213()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 4202, 4213);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10317_4202_4282(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 4202, 4282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10317_4316_4327()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 4316, 4327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10317_4316_4384(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 4316, 4384);
                    return return_v;
                }


                bool
                f_10317_4420_4503(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 4420, 4503);
                    return return_v;
                }


                bool
                f_10317_4507_4593(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                instanceType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                interfaceType, ref bool
                nonUnique, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = HasUniqueInterface(instanceType, interfaceType, ref nonUnique, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 4507, 4593);
                    return return_v;
                }


                bool
                f_10317_4627_4709(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 4627, 4709);
                    return return_v;
                }


                bool
                f_10317_4713_4798(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                instanceType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                interfaceType, ref bool
                nonUnique, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = HasUniqueInterface(instanceType, interfaceType, ref nonUnique, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 4713, 4798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10317, 3722, 4874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10317, 3722, 4874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasUniqueInterface(TypeSymbol instanceType, NamedTypeSymbol interfaceType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10317, 4886, 5195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 5053, 5076);

                bool
                nonUnique = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 5090, 5184);

                return f_10317_5097_5183(instanceType, interfaceType, ref nonUnique, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10317, 4886, 5195);

                bool
                f_10317_5097_5183(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                instanceType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                interfaceType, ref bool
                nonUnique, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = HasUniqueInterface(instanceType, interfaceType, ref nonUnique, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 5097, 5183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10317, 4886, 5195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10317, 4886, 5195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasUniqueInterface(TypeSymbol instanceType, NamedTypeSymbol interfaceType, ref bool nonUnique, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10317, 5207, 6160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 5394, 5422);

                TypeSymbol
                candidate = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 5436, 6100);
                    foreach (var i in f_10317_5454_5536_I(f_10317_5454_5536(instanceType, ref useSiteDiagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 5436, 6100);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 5570, 6085) || true) && (f_10317_5574_5665(f_10317_5592_5612(i), interfaceType, TypeCompareKind.ConsiderEverything2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 5570, 6085);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 5707, 6066) || true) && ((object)candidate == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 5707, 6066);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 5786, 5800);

                                candidate = i;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 5707, 6066);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 5707, 6066);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 5850, 6066) || true) && (!f_10317_5855_5923(candidate, i, TypeCompareKind.ConsiderEverything2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 5850, 6066);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 5973, 5990);

                                    nonUnique = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 6016, 6029);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 5850, 6066);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 5707, 6066);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 5570, 6085);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 5436, 6100);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10317, 1, 665);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10317, 1, 665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 6116, 6149);

                return (object)candidate != null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10317, 5207, 6160);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10317_5454_5536(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 5454, 5536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10317_5592_5612(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 5592, 5612);
                    return return_v;
                }


                bool
                f_10317_5574_5665(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 5574, 5665);
                    return return_v;
                }


                bool
                f_10317_5855_5923(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 5855, 5923);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10317_5454_5536_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 5454, 5536);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10317, 5207, 6160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10317, 5207, 6160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasCastToQueryProvider(TypeSymbol instanceType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10317, 6172, 6994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 6305, 6356);

                var
                originalType = f_10317_6324_6355(instanceType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 6370, 6459);

                var
                ienumerable = f_10317_6388_6458(f_10317_6388_6399(), SpecialType.System_Collections_IEnumerable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 6473, 6557);

                var
                iqueryable = f_10317_6490_6556(f_10317_6490_6501(), WellKnownType.System_Linq_IQueryable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 6571, 6747);

                bool
                isIenumerable = f_10317_6592_6673(originalType, ienumerable, TypeCompareKind.ConsiderEverything2) || (DynAbs.Tracing.TraceSender.Expression_False(10317, 6592, 6746) || f_10317_6677_6746(instanceType, ienumerable, ref useSiteDiagnostics))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 6761, 6933);

                bool
                isQueryable = f_10317_6780_6860(originalType, iqueryable, TypeCompareKind.ConsiderEverything2) || (DynAbs.Tracing.TraceSender.Expression_False(10317, 6780, 6932) || f_10317_6864_6932(instanceType, iqueryable, ref useSiteDiagnostics))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 6947, 6983);

                return isIenumerable != isQueryable;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10317, 6172, 6994);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10317_6324_6355(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 6324, 6355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10317_6388_6399()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 6388, 6399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10317_6388_6458(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 6388, 6458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10317_6490_6501()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 6490, 6501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10317_6490_6556(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 6490, 6556);
                    return return_v;
                }


                bool
                f_10317_6592_6673(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 6592, 6673);
                    return return_v;
                }


                bool
                f_10317_6677_6746(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                instanceType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                interfaceType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = HasUniqueInterface(instanceType, interfaceType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 6677, 6746);
                    return return_v;
                }


                bool
                f_10317_6780_6860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 6780, 6860);
                    return return_v;
                }


                bool
                f_10317_6864_6932(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                instanceType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                interfaceType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = HasUniqueInterface(instanceType, interfaceType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 6864, 6932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10317, 6172, 6994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10317, 6172, 6994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsJoinRangeVariableInLeftKey(SimpleNameSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10317, 7006, 7554);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7124, 7144);
                    for (CSharpSyntaxNode
        parent = f_10317_7133_7144(node)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7102, 7514) || true) && (parent != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7162, 7184)
        , parent = f_10317_7171_7184(parent), DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 7102, 7514))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 7102, 7514);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7218, 7499) || true) && (f_10317_7222_7235(parent) == SyntaxKind.JoinClause)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 7218, 7499);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7302, 7338);

                            var
                            join = (JoinClauseSyntax)parent
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7360, 7480) || true) && (f_10317_7364_7383(join).Span.Contains(f_10317_7398_7407(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10317, 7364, 7466) && join.Identifier.ValueText == node.Identifier.ValueText))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 7360, 7480);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7468, 7480);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 7360, 7480);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 7218, 7499);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10317, 1, 413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10317, 1, 413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7530, 7543);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10317, 7006, 7554);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10317_7133_7144(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 7133, 7144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10317_7171_7184(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 7171, 7184);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10317_7222_7235(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 7222, 7235);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10317_7364_7383(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.LeftExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 7364, 7383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10317_7398_7407(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 7398, 7407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10317, 7006, 7554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10317, 7006, 7554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsInJoinRightKey(SimpleNameSyntax node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10317, 7566, 8183);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7810, 7830);
                    // TODO: refine this test to check if the identifier is the name of a range
                    // variable of the enclosing query.
                    for (CSharpSyntaxNode
        parent = f_10317_7819_7830(node)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7788, 8143) || true) && (parent != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7848, 7870)
        , parent = f_10317_7857_7870(parent), DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 7788, 8143))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 7788, 8143);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7904, 8128) || true) && (f_10317_7908_7921(parent) == SyntaxKind.JoinClause)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 7904, 8128);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 7988, 8024);

                            var
                            join = (JoinClauseSyntax)parent
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8046, 8109) || true) && (f_10317_8050_8070(join).Span.Contains(f_10317_8085_8094(node)))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8046, 8109);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8097, 8109);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8046, 8109);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 7904, 8128);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10317, 1, 356);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10317, 1, 356);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8159, 8172);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10317, 7566, 8183);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10317_7819_7830(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 7819, 7830);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10317_7857_7870(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 7857, 7870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10317_7908_7921(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 7908, 7921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10317_8050_8070(Microsoft.CodeAnalysis.CSharp.Syntax.JoinClauseSyntax
                this_param)
                {
                    var return_v = this_param.RightExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 8050, 8070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Text.TextSpan
                f_10317_8085_8094(Microsoft.CodeAnalysis.CSharp.Syntax.SimpleNameSyntax
                this_param)
                {
                    var return_v = this_param.Span;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 8085, 8094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10317, 7566, 8183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10317, 7566, 8183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ReportQueryInferenceFailed(CSharpSyntaxNode queryClause, string methodName, BoundExpression receiver, AnalyzedArguments arguments, ImmutableArray<Symbol> symbols, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10317, 8195, 10719);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8430, 8455);

                string
                clauseKind = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8469, 8491);

                bool
                multiple = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8505, 10403);

                switch (f_10317_8513_8531(queryClause))
                {

                    case SyntaxKind.JoinClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8505, 10403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8614, 8671);

                        clauseKind = f_10317_8627_8670(SyntaxKind.JoinKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8693, 8709);

                        multiple = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10317, 8731, 8737);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8505, 10403);

                    case SyntaxKind.LetClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8505, 10403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8803, 8859);

                        clauseKind = f_10317_8816_8858(SyntaxKind.LetKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10317, 8881, 8887);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8505, 10403);

                    case SyntaxKind.SelectClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8505, 10403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 8956, 9015);

                        clauseKind = f_10317_8969_9014(SyntaxKind.SelectKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10317, 9037, 9043);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8505, 10403);

                    case SyntaxKind.WhereClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8505, 10403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 9111, 9169);

                        clauseKind = f_10317_9124_9168(SyntaxKind.WhereKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10317, 9191, 9197);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8505, 10403);

                    case SyntaxKind.OrderByClause:
                    case SyntaxKind.AscendingOrdering:
                    case SyntaxKind.DescendingOrdering:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8505, 10403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 9372, 9432);

                        clauseKind = f_10317_9385_9431(SyntaxKind.OrderByKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 9454, 9470);

                        multiple = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10317, 9492, 9498);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8505, 10403);

                    case SyntaxKind.QueryContinuation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8505, 10403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 9572, 9629);

                        clauseKind = f_10317_9585_9628(SyntaxKind.IntoKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10317, 9651, 9657);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8505, 10403);

                    case SyntaxKind.GroupClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8505, 10403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 9725, 9833);

                        clauseKind = f_10317_9738_9782(SyntaxKind.GroupKeyword) + " " + f_10317_9791_9832(SyntaxKind.ByKeyword);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 9855, 9871);

                        multiple = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(10317, 9893, 9899);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8505, 10403);

                    case SyntaxKind.FromClause:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8505, 10403);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 9966, 10172) || true) && (f_10317_9970_10092(queryClause, methodName, receiver, arguments, symbols, diagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 9966, 10172);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 10142, 10149);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 9966, 10172);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 10194, 10251);

                        clauseKind = f_10317_10207_10250(SyntaxKind.FromKeyword);
                        DynAbs.Tracing.TraceSender.TraceBreak(10317, 10273, 10279);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8505, 10403);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 8505, 10403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 10327, 10388);

                        throw f_10317_10333_10387(f_10317_10368_10386(queryClause));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 8505, 10403);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 10419, 10708);

                f_10317_10419_10707(
                            diagnostics, f_10317_10435_10663((DynAbs.Tracing.TraceSender.Conditional_F1(10317, 10483, 10491) || ((multiple && DynAbs.Tracing.TraceSender.Conditional_F2(10317, 10494, 10537)) || DynAbs.Tracing.TraceSender.Conditional_F3(10317, 10540, 10578))) ? ErrorCode.ERR_QueryTypeInferenceFailedMulti : ErrorCode.ERR_QueryTypeInferenceFailed, new object[] { clauseKind, methodName }, symbols), f_10317_10665_10692(queryClause).GetLocation());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10317, 8195, 10719);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10317_8513_8531(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 8513, 8531);
                    return return_v;
                }


                string
                f_10317_8627_8670(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 8627, 8670);
                    return return_v;
                }


                string
                f_10317_8816_8858(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 8816, 8858);
                    return return_v;
                }


                string
                f_10317_8969_9014(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 8969, 9014);
                    return return_v;
                }


                string
                f_10317_9124_9168(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 9124, 9168);
                    return return_v;
                }


                string
                f_10317_9385_9431(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 9385, 9431);
                    return return_v;
                }


                string
                f_10317_9585_9628(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 9585, 9628);
                    return return_v;
                }


                string
                f_10317_9738_9782(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 9738, 9782);
                    return return_v;
                }


                string
                f_10317_9791_9832(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 9791, 9832);
                    return return_v;
                }


                bool
                f_10317_9970_10092(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                fromClause, string
                methodName, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = ReportQueryInferenceFailedSelectMany((Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax)fromClause, methodName, receiver, arguments, symbols, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 9970, 10092);
                    return return_v;
                }


                string
                f_10317_10207_10250(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = SyntaxFacts.GetText(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 10207, 10250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10317_10368_10386(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 10368, 10386);
                    return return_v;
                }


                System.Exception
                f_10317_10333_10387(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 10333, 10387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10317_10435_10663(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 10435, 10663);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10317_10665_10692(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 10665, 10692);
                    return return_v;
                }


                int
                f_10317_10419_10707(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 10419, 10707);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10317, 8195, 10719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10317, 8195, 10719);
            }
        }

        private static bool ReportQueryInferenceFailedSelectMany(FromClauseSyntax fromClause, string methodName, BoundExpression receiver, AnalyzedArguments arguments, ImmutableArray<Symbol> symbols, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10317, 10731, 12096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 10974, 11015);

                f_10317_10974_11014(methodName == "SelectMany");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11100, 11188);

                BoundExpression
                arg = f_10317_11122_11187(arguments, (DynAbs.Tracing.TraceSender.Conditional_F1(10317, 11141, 11178) || ((arguments.IsExtensionMethodInvocation && DynAbs.Tracing.TraceSender.Conditional_F2(10317, 11181, 11182)) || DynAbs.Tracing.TraceSender.Conditional_F3(10317, 11185, 11186))) ? 1 : 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11202, 11225);

                TypeSymbol
                type = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11239, 11625) || true) && (f_10317_11243_11251(arg) == BoundKind.UnboundLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 11239, 11625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11312, 11345);

                    var
                    unbound = (UnboundLambda)arg
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11363, 11610);
                        foreach (var t in f_10317_11381_11415_I(f_10317_11381_11415(f_10317_11381_11393(unbound))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 11363, 11610);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11457, 11591) || true) && (!f_10317_11462_11477(t))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 11457, 11591);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11527, 11536);

                                type = t;
                                DynAbs.Tracing.TraceSender.TraceBreak(10317, 11562, 11568);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 11457, 11591);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 11363, 11610);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10317, 1, 248);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10317, 1, 248);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 11239, 11625);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11641, 11749) || true) && ((object)type == null || (DynAbs.Tracing.TraceSender.Expression_False(10317, 11645, 11687) || f_10317_11669_11687(type)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10317, 11641, 11749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11721, 11734);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10317, 11641, 11749);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11765, 11806);

                TypeSymbol
                receiverType = f_10317_11791_11805_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(receiver, 10317, 11791, 11805)?.Type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 11820, 12059);

                f_10317_11820_12058(diagnostics, f_10317_11836_12025(ErrorCode.ERR_QueryTypeInferenceFailedSelectMany, new object[] { type, receiverType, methodName }, symbols), f_10317_12027_12057(f_10317_12027_12048(fromClause)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10317, 12073, 12085);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10317, 10731, 12096);

                int
                f_10317_10974_11014(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 10974, 11014);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10317_11122_11187(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param, int
                i)
                {
                    var return_v = this_param.Argument(i);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 11122, 11187);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10317_11243_11251(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 11243, 11251);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                f_10317_11381_11393(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 11381, 11393);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10317_11381_11415(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
                this_param)
                {
                    var return_v = this_param.InferredReturnTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 11381, 11415);
                    return return_v;
                }


                bool
                f_10317_11462_11477(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 11462, 11477);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10317_11381_11415_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 11381, 11415);
                    return return_v;
                }


                bool
                f_10317_11669_11687(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 11669, 11687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10317_11791_11805_M(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 11791, 11805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                f_10317_11836_12025(Microsoft.CodeAnalysis.CSharp.ErrorCode
                errorCode, object[]
                arguments, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols(errorCode, arguments, symbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 11836, 12025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10317_12027_12048(Microsoft.CodeAnalysis.CSharp.Syntax.FromClauseSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 12027, 12048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10317_12027_12057(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10317, 12027, 12057);
                    return return_v;
                }


                int
                f_10317_11820_12058(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.DiagnosticInfoWithSymbols
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10317, 11820, 12058);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10317, 10731, 12096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10317, 10731, 12096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
