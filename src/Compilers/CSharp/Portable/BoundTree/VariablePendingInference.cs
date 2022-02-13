// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Roslyn.Utilities;
using System.Diagnostics;
using System;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class DeconstructionVariablePendingInference
    {
        protected override ErrorCode InferenceFailedError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10592, 544, 620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 547, 620);
                    return ErrorCode.ERR_TypeInferenceFailedForImplicitlyTypedDeconstructionVariable; DynAbs.Tracing.TraceSender.TraceExitMethod(10592, 544, 620);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10592, 544, 620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10592, 544, 620);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal partial class OutVariablePendingInference
    {
        protected override ErrorCode InferenceFailedError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10592, 753, 818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 756, 818);
                    return ErrorCode.ERR_TypeInferenceFailedForImplicitlyTypedOutVariable; DynAbs.Tracing.TraceSender.TraceExitMethod(10592, 753, 818);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10592, 753, 818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10592, 753, 818);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
    internal partial class VariablePendingInference : BoundExpression
    {
        internal BoundExpression SetInferredTypeWithAnnotations(TypeWithAnnotations type, DiagnosticBag? diagnosticsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10592, 916, 1173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 1053, 1080);

                f_10592_1053_1079(type.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 1096, 1162);

                return f_10592_1103_1161(this, type, null, diagnosticsOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10592, 916, 1173);

                int
                f_10592_1053_1079(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 1053, 1079);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10592_1103_1161(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Binder?
                binderOpt, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt)
                {
                    var return_v = this_param.SetInferredTypeWithAnnotations(type, binderOpt, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 1103, 1161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10592, 916, 1173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10592, 916, 1173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression SetInferredTypeWithAnnotations(TypeWithAnnotations type, Binder? binderOpt, DiagnosticBag? diagnosticsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10592, 1185, 4342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 1341, 1389);

                f_10592_1341_1388(binderOpt != null || (DynAbs.Tracing.TraceSender.Expression_False(10592, 1354, 1387) || type.HasType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 1403, 1679);

                f_10592_1403_1678(f_10592_1416_1434(this.Syntax) == SyntaxKind.SingleVariableDesignation || (DynAbs.Tracing.TraceSender.Expression_False(10592, 1416, 1677) || (f_10592_1496_1514(this.Syntax) == SyntaxKind.DeclarationExpression && (DynAbs.Tracing.TraceSender.Expression_True(10592, 1496, 1676) && f_10592_1575_1636(f_10592_1575_1629(((DeclarationExpressionSyntax)this.Syntax))) == SyntaxKind.SingleVariableDesignation))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 1695, 1732);

                bool
                inferenceFailed = f_10592_1718_1731_M(!type.HasType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 1748, 1885) || true) && (inferenceFailed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 1748, 1885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 1801, 1870);

                    type = TypeWithAnnotations.Create(f_10592_1835_1868(binderOpt!, "var"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 1748, 1885);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 1901, 4331);

                switch (f_10592_1909_1933(f_10592_1909_1928(this)))
                {

                    case SymbolKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 1901, 4331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 2011, 2068);

                        var
                        localSymbol = (SourceLocalSymbol)f_10592_2048_2067(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 2092, 2824) || true) && (diagnosticsOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 2092, 2824);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 2168, 2801) || true) && (inferenceFailed)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 2168, 2801);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 2245, 2284);

                                f_10592_2245_2283(this, diagnosticsOpt);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 2168, 2801);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 2168, 2801);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 2398, 2620);

                                SyntaxNode
                                typeOrDesignationSyntax = (DynAbs.Tracing.TraceSender.Conditional_F1(10592, 2435, 2489) || ((f_10592_2435_2453(this.Syntax) == SyntaxKind.DeclarationExpression && DynAbs.Tracing.TraceSender.Conditional_F2(10592, 2525, 2572)) || DynAbs.Tracing.TraceSender.Conditional_F3(10592, 2608, 2619))) ? f_10592_2525_2572(((DeclarationExpressionSyntax)this.Syntax)) : this.Syntax
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 2652, 2774);

                                f_10592_2652_2773(f_10592_2692_2720(localSymbol), type.Type, diagnosticsOpt, typeOrDesignationSyntax);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 2168, 2801);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 2092, 2824);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 2848, 2889);

                        f_10592_2848_2888(
                                            localSymbol, type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 2911, 3135);

                        return f_10592_2918_3134(f_10592_2918_3115(this.Syntax, localSymbol, BoundLocalDeclarationKind.WithInferredType, constantValueOpt: null, isNullableUnknown: false, type: type.Type, hasErrors: f_10592_3081_3095(this) || (DynAbs.Tracing.TraceSender.Expression_False(10592, 3081, 3114) || inferenceFailed)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 1901, 4331);

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 1901, 4331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 3199, 3263);

                        var
                        fieldSymbol = (GlobalExpressionVariable)f_10592_3243_3262(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 3285, 3340);

                        var
                        inferenceDiagnostics = f_10592_3312_3339()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 3364, 3501) || true) && (inferenceFailed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 3364, 3501);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 3433, 3478);

                            f_10592_3433_3477(this, inferenceDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 3364, 3501);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 3525, 3595);

                        type = f_10592_3532_3594(fieldSymbol, type, inferenceDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 3617, 3645);

                        f_10592_3617_3644(inferenceDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 3669, 4199);

                        return f_10592_3676_4198(this.Syntax, f_10592_3759_3775(this), fieldSymbol, null, LookupResultKind.Viable, isDeclaration: true, type: type.Type, hasErrors: f_10592_4164_4178(this) || (DynAbs.Tracing.TraceSender.Expression_False(10592, 4164, 4197) || inferenceFailed));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 1901, 4331);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 1901, 4331);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 4249, 4316);

                        throw f_10592_4255_4315(f_10592_4290_4314(f_10592_4290_4309(this)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 1901, 4331);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10592, 1185, 4342);

                int
                f_10592_1341_1388(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 1341, 1388);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10592_1416_1434(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 1416, 1434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10592_1496_1514(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 1496, 1514);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10592_1575_1629(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 1575, 1629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10592_1575_1636(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 1575, 1636);
                    return return_v;
                }


                int
                f_10592_1403_1678(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 1403, 1678);
                    return 0;
                }


                bool
                f_10592_1718_1731_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 1718, 1731);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10592_1835_1868(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, string
                name)
                {
                    var return_v = this_param.CreateErrorType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 1835, 1868);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10592_1909_1928(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param)
                {
                    var return_v = this_param.VariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 1909, 1928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10592_1909_1933(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 1909, 1933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10592_2048_2067(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param)
                {
                    var return_v = this_param.VariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 2048, 2067);
                    return return_v;
                }


                int
                f_10592_2245_2283(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportInferenceFailure(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 2245, 2283);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10592_2435_2453(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 2435, 2453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10592_2525_2572(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 2525, 2572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10592_2692_2720(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 2692, 2720);
                    return return_v;
                }


                bool
                f_10592_2652_2773(Microsoft.CodeAnalysis.CSharp.Symbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = Binder.CheckRestrictedTypeInAsyncMethod(containingSymbol, type, diagnostics, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 2652, 2773);
                    return return_v;
                }


                int
                f_10592_2848_2888(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                newType)
                {
                    this_param.SetTypeWithAnnotations(newType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 2848, 2888);
                    return 0;
                }


                bool
                f_10592_3081_3095(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 3081, 3095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10592_2918_3115(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                localSymbol, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclarationKind
                declarationKind, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, bool
                isNullableUnknown, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal(syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)localSymbol, declarationKind, constantValueOpt: constantValueOpt, isNullableUnknown: isNullableUnknown, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 2918, 3115);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10592_2918_3134(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.WithWasConverted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 2918, 3134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10592_3243_3262(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param)
                {
                    var return_v = this_param.VariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 3243, 3262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10592_3312_3339()
                {
                    var return_v = DiagnosticBag.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 3312, 3339);
                    return return_v;
                }


                int
                f_10592_3433_3477(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportInferenceFailure(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 3433, 3477);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10592_3532_3594(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.SetTypeWithAnnotations(type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 3532, 3594);
                    return return_v;
                }


                int
                f_10592_3617_3644(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 3617, 3644);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10592_3759_3775(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 3759, 3775);
                    return return_v;
                }


                bool
                f_10592_4164_4178(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param)
                {
                    var return_v = this_param.HasErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 4164, 4178);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10592_3676_4198(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, bool
                isDeclaration, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess(syntax, receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)fieldSymbol, constantValueOpt, resultKind, isDeclaration: isDeclaration, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 3676, 4198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10592_4290_4309(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param)
                {
                    var return_v = this_param.VariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 4290, 4309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10592_4290_4314(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 4290, 4314);
                    return return_v;
                }


                System.Exception
                f_10592_4255_4315(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 4255, 4315);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10592, 1185, 4342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10592, 1185, 4342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundExpression FailInference(Binder binder, DiagnosticBag? diagnosticsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10592, 4354, 4550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 4463, 4539);

                return f_10592_4470_4538(this, default, binder, diagnosticsOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10592, 4354, 4550);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10592_4470_4538(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Binder
                binderOpt, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt)
                {
                    var return_v = this_param.SetInferredTypeWithAnnotations(type, binderOpt, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 4470, 4538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10592, 4354, 4550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10592, 4354, 4550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReportInferenceFailure(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10592, 4562, 5399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 4649, 4693);

                SingleVariableDesignationSyntax
                designation
                = default(SingleVariableDesignationSyntax);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 4707, 5226);

                switch (f_10592_4715_4733(this.Syntax))
                {

                    case SyntaxKind.DeclarationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 4707, 5226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 4827, 4929);

                        designation = (SingleVariableDesignationSyntax)f_10592_4874_4928(((DeclarationExpressionSyntax)this.Syntax));
                        DynAbs.Tracing.TraceSender.TraceBreak(10592, 4951, 4957);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 4707, 5226);

                    case SyntaxKind.SingleVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 4707, 5226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 5039, 5098);

                        designation = (SingleVariableDesignationSyntax)this.Syntax;
                        DynAbs.Tracing.TraceSender.TraceBreak(10592, 5120, 5126);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 4707, 5226);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10592, 4707, 5226);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 5174, 5211);

                        throw f_10592_5180_5210();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10592, 4707, 5226);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10592, 5242, 5388);

                f_10592_5242_5387(diagnostics, f_10592_5286_5311(this), f_10592_5313_5335(designation), designation.Identifier.ValueText);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10592, 4562, 5399);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10592_4715_4733(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 4715, 4733);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10592_4874_4928(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 4874, 4928);
                    return return_v;
                }


                System.Exception
                f_10592_5180_5210()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 5180, 5210);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ErrorCode
                f_10592_5286_5311(Microsoft.CodeAnalysis.CSharp.VariablePendingInference
                this_param)
                {
                    var return_v = this_param.InferenceFailedError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 5286, 5311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10592_5313_5335(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10592, 5313, 5335);
                    return return_v;
                }


                int
                f_10592_5242_5387(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxToken
                token, params object[]
                args)
                {
                    Binder.Error(diagnostics, code, token, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10592, 5242, 5387);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10592, 4562, 5399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10592, 4562, 5399);
            }
        }

        protected abstract ErrorCode InferenceFailedError { get; }

        static VariablePendingInference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10592, 834, 5476);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10592, 834, 5476);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10592, 834, 5476);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10592, 834, 5476);
    }
}
