// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Immutable;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal BoundExpression BindDeconstruction(AssignmentExpressionSyntax node, DiagnosticBag diagnostics, bool resultIsUsedOverride = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 1291, 3357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 1454, 1475);

                var
                left = f_10305_1465_1474(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 1489, 1512);

                var
                right = f_10305_1501_1511(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 1526, 1574);

                DeclarationExpressionSyntax?
                declaration = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 1588, 1624);

                ExpressionSyntax?
                expression = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 1638, 1757);

                var
                result = f_10305_1651_1756(this, node, left, right, diagnostics, ref declaration, ref expression, resultIsUsedOverride)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 1771, 3316) || true) && (declaration != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 1771, 3316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 1896, 3301);

                    switch (f_10305_1904_1923_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10305_1904_1915(node), 10305, 1904, 1923).Kind()))
                    {

                        case null:
                        case SyntaxKind.ExpressionStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 1896, 3301);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 2059, 2335) || true) && (expression != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 2059, 2335);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 2139, 2308);

                                f_10305_2139_2307(MessageID.IDS_FeatureMixedDeclarationsAndExpressionsInDeconstruction
                                , diagnostics, f_10305_2280_2291(), f_10305_2293_2306(node));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 2059, 2335);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10305, 2361, 2367);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 1896, 3301);

                        case SyntaxKind.ForStatement:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 1896, 3301);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 2444, 3081) || true) && (((ForStatementSyntax)f_10305_2469_2480(node)).Initializers.Contains(node))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 2444, 3081);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 2567, 2859) || true) && (expression != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 2567, 2859);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 2655, 2828);

                                    f_10305_2655_2827(MessageID.IDS_FeatureMixedDeclarationsAndExpressionsInDeconstruction
                                    , diagnostics, f_10305_2800_2811(), f_10305_2813_2826(node));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 2567, 2859);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 2444, 3081);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 2444, 3081);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 2973, 3054);

                                f_10305_2973_3053(diagnostics, ErrorCode.ERR_DeclarationExpressionNotPermitted, declaration);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 2444, 3081);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10305, 3107, 3113);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 1896, 3301);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 1896, 3301);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 3169, 3250);

                            f_10305_3169_3249(diagnostics, ErrorCode.ERR_DeclarationExpressionNotPermitted, declaration);
                            DynAbs.Tracing.TraceSender.TraceBreak(10305, 3276, 3282);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 1896, 3301);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 1771, 3316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 3332, 3346);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 1291, 3357);

                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10305_1465_1474(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 1465, 1474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10305_1501_1511(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 1501, 1511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                f_10305_1651_1756(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                deconstruction, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                left, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                right, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax?
                declaration, ref Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                expression, bool
                resultIsUsedOverride)
                {
                    var return_v = this_param.BindDeconstruction((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)deconstruction, left, right, diagnostics, ref declaration, ref expression, resultIsUsedOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 1651, 1756);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10305_1904_1915(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 1904, 1915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                f_10305_1904_1923_I(Microsoft.CodeAnalysis.CSharp.SyntaxKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 1904, 1923);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10305_2280_2291()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 2280, 2291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10305_2293_2306(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 2293, 2306);
                    return return_v;
                }


                bool
                f_10305_2139_2307(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.Compilation)compilation, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 2139, 2307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10305_2469_2480(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 2469, 2480);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10305_2800_2811()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 2800, 2811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10305_2813_2826(Microsoft.CodeAnalysis.CSharp.Syntax.AssignmentExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 2813, 2826);
                    return return_v;
                }


                bool
                f_10305_2655_2827(Microsoft.CodeAnalysis.CSharp.MessageID
                feature, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = feature.CheckFeatureAvailability(diagnostics, (Microsoft.CodeAnalysis.Compilation)compilation, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 2655, 2827);
                    return return_v;
                }


                int
                f_10305_2973_3053(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 2973, 3053);
                    return 0;
                }


                int
                f_10305_3169_3249(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 3169, 3249);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 1291, 3357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 1291, 3357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal BoundDeconstructionAssignmentOperator BindDeconstruction(
                    CSharpSyntaxNode deconstruction,
                    ExpressionSyntax left,
                    ExpressionSyntax right,
                    DiagnosticBag diagnostics,
                    ref DeclarationExpressionSyntax? declaration,
                    ref ExpressionSyntax? expression,
                    bool resultIsUsedOverride = false,
                    BoundDeconstructValuePlaceholder? rightPlaceholder = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 4317, 5805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 4793, 4905);

                DeconstructionVariable
                locals = f_10305_4825_4904(this, left, diagnostics, ref declaration, ref expression)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 4919, 4966);

                f_10305_4919_4965(locals.NestedVariables is object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 4982, 5034);

                var
                deconstructionDiagnostics = f_10305_5014_5033()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 5048, 5163);

                BoundExpression
                boundRight = rightPlaceholder ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder?>(10305, 5077, 5162) ?? f_10305_5097_5162(this, right, deconstructionDiagnostics, BindValueKind.RValue))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 5179, 5287);

                boundRight = f_10305_5192_5286(this, locals.NestedVariables, boundRight, deconstruction, deconstructionDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 5301, 5357);

                boundRight = f_10305_5314_5356(this, boundRight, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 5373, 5450);

                bool
                resultIsUsed = resultIsUsedOverride || (DynAbs.Tracing.TraceSender.Expression_False(10305, 5393, 5449) || f_10305_5417_5449(left))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 5464, 5609);

                var
                assignment = f_10305_5481_5608(this, deconstruction, left, boundRight, locals.NestedVariables, resultIsUsed, deconstructionDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 5623, 5698);

                f_10305_5623_5697(locals.NestedVariables);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 5714, 5762);

                f_10305_5714_5761(
                            diagnostics, deconstructionDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 5776, 5794);

                return assignment;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 4317, 5805);

                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_4825_4904(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax?
                declaration, ref Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                expression)
                {
                    var return_v = this_param.BindDeconstructionVariables(node, diagnostics, ref declaration, ref expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 4825, 4904);
                    return return_v;
                }


                int
                f_10305_4919_4965(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 4919, 4965);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticBag
                f_10305_5014_5033()
                {
                    var return_v = new Microsoft.CodeAnalysis.DiagnosticBag();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 5014, 5033);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_5097_5162(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind)
                {
                    var return_v = this_param.BindValue(node, diagnostics, valueKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 5097, 5162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_5192_5286(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                checkedVariables, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundRHS, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.FixTupleLiteral(checkedVariables, boundRHS, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 5192, 5286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_5314_5356(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 5314, 5356);
                    return return_v;
                }


                bool
                f_10305_5417_5449(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                left)
                {
                    var return_v = IsDeconstructionResultUsed(left);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 5417, 5449);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                f_10305_5481_5608(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundRHS, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                checkedVariables, bool
                resultIsUsed, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindDeconstructionAssignment(node, left, boundRHS, checkedVariables, resultIsUsed, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 5481, 5608);
                    return return_v;
                }


                int
                f_10305_5623_5697(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables)
                {
                    DeconstructionVariable.FreeDeconstructionVariables(variables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 5623, 5697);
                    return 0;
                }


                int
                f_10305_5714_5761(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                bag)
                {
                    this_param.AddRange(bag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 5714, 5761);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 4317, 5805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 4317, 5805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundDeconstructionAssignmentOperator BindDeconstructionAssignment(
                                                                CSharpSyntaxNode node,
                                                                ExpressionSyntax left,
                                                                BoundExpression boundRHS,
                                                                ArrayBuilder<DeconstructionVariable> checkedVariables,
                                                                bool resultIsUsed,
                                                                DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 5817, 9303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 6432, 6496);

                uint
                rightEscape = f_10305_6451_6495(boundRHS, f_10305_6474_6494(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 6512, 7545) || true) && ((object?)f_10305_6525_6538(boundRHS) == null || (DynAbs.Tracing.TraceSender.Expression_False(10305, 6516, 6577) || f_10305_6550_6577(f_10305_6550_6563(boundRHS))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 6512, 7545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 6675, 6758);

                    f_10305_6675_6757(this, checkedVariables, diagnostics, rightEscape);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 6776, 6850);

                    var
                    voidType = f_10305_6791_6849(this, SpecialType.System_Void, diagnostics, node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 6870, 6907);

                    var
                    type = f_10305_6881_6894(boundRHS) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10305, 6881, 6906) ?? voidType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 6925, 7530);

                    return f_10305_6932_7529(node, f_10305_7039_7140(this, left, checkedVariables, diagnostics, ignoreDiagnosticsFromTuple: true), f_10305_7171_7400(boundRHS.Syntax, boundRHS, Conversion.Deconstruction, @checked: false, explicitCastInCode: false, conversionGroupOpt: null, constantValueOpt: null, type: type, hasErrors: true), resultIsUsed, voidType, hasErrors: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 6512, 7545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 7561, 7583);

                Conversion
                conversion
                = default(Conversion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 7597, 7952);

                bool
                hasErrors = !f_10305_7615_7951(this, f_10305_7682_7695(boundRHS), node, boundRHS.Syntax, diagnostics, checkedVariables, out conversion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 7968, 8126) || true) && (conversion.Method != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 7968, 8126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 8031, 8111);

                    f_10305_8031_8110(this, boundRHS, conversion.Method, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 7968, 8126);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 8142, 8225);

                f_10305_8142_8224(this, checkedVariables, diagnostics, rightEscape);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 8241, 8397);

                var
                lhsTuple = f_10305_8256_8396(this, left, checkedVariables, diagnostics, ignoreDiagnosticsFromTuple: f_10305_8352_8378(diagnostics) || (DynAbs.Tracing.TraceSender.Expression_False(10305, 8352, 8395) || !resultIsUsed))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 8411, 8462);

                f_10305_8411_8461(hasErrors || (DynAbs.Tracing.TraceSender.Expression_False(10305, 8424, 8460) || f_10305_8437_8450(lhsTuple) is object));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 8476, 8547);

                TypeSymbol
                returnType = (DynAbs.Tracing.TraceSender.Conditional_F1(10305, 8500, 8509) || ((hasErrors && DynAbs.Tracing.TraceSender.Conditional_F2(10305, 8512, 8529)) || DynAbs.Tracing.TraceSender.Conditional_F3(10305, 8532, 8546))) ? f_10305_8512_8529(this) : lhsTuple.Type!
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 8563, 8634);

                uint
                leftEscape = f_10305_8581_8633(lhsTuple, f_10305_8612_8632(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 8648, 8738);

                boundRHS = f_10305_8659_8737(this, boundRHS, leftEscape, isByRef: false, diagnostics: diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 8754, 9168);

                var
                boundConversion = new BoundConversion(
                                boundRHS.Syntax,
                                boundRHS,
                                conversion,
                                @checked: false,
                                explicitCastInCode: false,
                                conversionGroupOpt: null,
                                constantValueOpt: null,
                                type: returnType,
                                hasErrors: hasErrors)
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10305, 8776, 9167) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9184, 9292);

                return f_10305_9191_9291(node, lhsTuple, boundConversion, resultIsUsed, returnType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 5817, 9303);

                uint
                f_10305_6474_6494(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 6474, 6494);
                    return return_v;
                }


                uint
                f_10305_6451_6495(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 6451, 6495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_6525_6538(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 6525, 6538);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10305_6550_6563(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 6550, 6563);
                    return return_v;
                }


                bool
                f_10305_6550_6577(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 6550, 6577);
                    return return_v;
                }


                int
                f_10305_6675_6757(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, uint
                rhsValEscape)
                {
                    this_param.FailRemainingInferencesAndSetValEscape(variables, diagnostics, rhsValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 6675, 6757);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10305_6791_6849(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node)
                {
                    var return_v = this_param.GetSpecialType(typeId, diagnostics, (Microsoft.CodeAnalysis.SyntaxNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 6791, 6849);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_6881_6894(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 6881, 6894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                f_10305_7039_7140(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                ignoreDiagnosticsFromTuple)
                {
                    var return_v = this_param.DeconstructionVariablesAsTuple((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, variables, diagnostics, ignoreDiagnosticsFromTuple: ignoreDiagnosticsFromTuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 7039, 7140);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10305_7171_7400(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked: @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 7171, 7400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                f_10305_6932_7529(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundConversion
                right, bool
                isUsed, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator((Microsoft.CodeAnalysis.SyntaxNode)syntax, left, right, isUsed, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 6932, 7529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10305_7682_7695(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 7682, 7695);
                    return return_v;
                }


                bool
                f_10305_7615_7951(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxNode
                rightSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, out Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = this_param.MakeDeconstructionConversion(type, (Microsoft.CodeAnalysis.SyntaxNode)syntax, rightSyntax, diagnostics, variables, out conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 7615, 7951);
                    return return_v;
                }


                bool
                f_10305_8031_8110(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckImplicitThisCopyInReadOnlyMember(receiver, method, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 8031, 8110);
                    return return_v;
                }


                int
                f_10305_8142_8224(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, uint
                rhsValEscape)
                {
                    this_param.FailRemainingInferencesAndSetValEscape(variables, diagnostics, rhsValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 8142, 8224);
                    return 0;
                }


                bool
                f_10305_8352_8378(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 8352, 8378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                f_10305_8256_8396(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                ignoreDiagnosticsFromTuple)
                {
                    var return_v = this_param.DeconstructionVariablesAsTuple((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, variables, diagnostics, ignoreDiagnosticsFromTuple: ignoreDiagnosticsFromTuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 8256, 8396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_8437_8450(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 8437, 8450);
                    return return_v;
                }


                int
                f_10305_8411_8461(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 8411, 8461);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10305_8512_8529(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.CreateErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 8512, 8529);
                    return return_v;
                }


                uint
                f_10305_8612_8632(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 8612, 8632);
                    return return_v;
                }


                uint
                f_10305_8581_8633(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                expr, uint
                scopeOfTheContainingExpression)
                {
                    var return_v = GetBroadestValEscape(expr, scopeOfTheContainingExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 8581, 8633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_8659_8737(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, uint
                escapeTo, bool
                isByRef, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateEscape(expr, escapeTo, isByRef: isByRef, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 8659, 8737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator
                f_10305_9191_9291(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundConversion
                right, bool
                isUsed, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDeconstructionAssignmentOperator((Microsoft.CodeAnalysis.SyntaxNode)syntax, left, right, isUsed, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 9191, 9291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 5817, 9303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 5817, 9303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsDeconstructionResultUsed(ExpressionSyntax left)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10305, 9315, 10409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9409, 9434);

                var
                parent = f_10305_9422_9433(left)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9448, 9584) || true) && (parent is null || (DynAbs.Tracing.TraceSender.Expression_False(10305, 9452, 9522) || f_10305_9470_9483(parent) == SyntaxKind.ForEachVariableStatement))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 9448, 9584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9556, 9569);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 9448, 9584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9600, 9669);

                f_10305_9600_9668(f_10305_9613_9626(parent) == SyntaxKind.SimpleAssignmentExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9685, 9717);

                var
                grandParent = f_10305_9703_9716(parent)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9731, 9816) || true) && (grandParent is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 9731, 9816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9788, 9801);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 9731, 9816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9832, 10398);

                switch (f_10305_9840_9858(grandParent))
                {

                    case SyntaxKind.ExpressionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 9832, 10398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 9950, 10019);

                        return f_10305_9957_10008(((ExpressionStatementSyntax)grandParent)) != parent;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 9832, 10398);

                    case SyntaxKind.ForStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 9832, 10398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 10174, 10217);

                        var
                        loop = (ForStatementSyntax)grandParent
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 10239, 10321);

                        return !f_10305_10247_10281(loop.Incrementors, parent) && (DynAbs.Tracing.TraceSender.Expression_True(10305, 10246, 10320) && !f_10305_10286_10320(loop.Initializers, parent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 9832, 10398);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 9832, 10398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 10371, 10383);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 9832, 10398);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10305, 9315, 10409);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10305_9422_9433(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 9422, 9433);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10305_9470_9483(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 9470, 9483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10305_9613_9626(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 9613, 9626);
                    return return_v;
                }


                int
                f_10305_9600_9668(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 9600, 9668);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode?
                f_10305_9703_9716(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 9703, 9716);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10305_9840_9858(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 9840, 9858);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10305_9957_10008(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionStatementSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 9957, 10008);
                    return return_v;
                }


                bool
                f_10305_10247_10281(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                list, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                item)
                {
                    var return_v = list.Contains<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 10247, 10281);
                    return return_v;
                }


                bool
                f_10305_10286_10320(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                list, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                item)
                {
                    var return_v = list.Contains<Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 10286, 10320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 9315, 10409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 9315, 10409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression FixTupleLiteral(ArrayBuilder<DeconstructionVariable> checkedVariables, BoundExpression boundRHS, CSharpSyntaxNode syntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 10521, 11856);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 10718, 11813) || true) && (f_10305_10722_10735(boundRHS) == BoundKind.TupleLiteral)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 10718, 11813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 11205, 11249);

                    bool
                    hadErrors = f_10305_11222_11248(diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 11267, 11417);

                    TypeSymbol?
                    mergedTupleType = f_10305_11297_11416(checkedVariables, boundRHS, syntax, f_10305_11372_11383(), (DynAbs.Tracing.TraceSender.Conditional_F1(10305, 11385, 11394) || ((hadErrors && DynAbs.Tracing.TraceSender.Conditional_F2(10305, 11397, 11401)) || DynAbs.Tracing.TraceSender.Conditional_F3(10305, 11404, 11415))) ? null : diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 11435, 11615) || true) && ((object?)mergedTupleType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 11435, 11615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 11513, 11596);

                        boundRHS = f_10305_11524_11595(this, mergedTupleType, boundRHS, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 11435, 11615);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 10718, 11813);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 10718, 11813);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 11649, 11813) || true) && ((object?)f_10305_11662_11675(boundRHS) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 11649, 11813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 11717, 11798);

                        f_10305_11717_11797(diagnostics, ErrorCode.ERR_DeconstructRequiresExpression, boundRHS.Syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 11649, 11813);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 10718, 11813);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 11829, 11845);

                return boundRHS;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 10521, 11856);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10305_10722_10735(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 10722, 10735);
                    return return_v;
                }


                bool
                f_10305_11222_11248(Microsoft.CodeAnalysis.DiagnosticBag
                this_param)
                {
                    var return_v = this_param.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 11222, 11248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10305_11372_11383()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 11372, 11383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_11297_11416(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                lhsVariables, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rhsLiteral, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics)
                {
                    var return_v = MakeMergedTupleType(lhsVariables, (Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral)rhsLiteral, syntax, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 11297, 11416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_11524_11595(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                targetType, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GenerateConversionForAssignment(targetType, expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 11524, 11595);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_11662_11675(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 11662, 11675);
                    return return_v;
                }


                int
                f_10305_11717_11797(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 11717, 11797);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 10521, 11856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 10521, 11856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MakeDeconstructionConversion(
                                TypeSymbol type,
                                SyntaxNode syntax,
                                SyntaxNode rightSyntax,
                                DiagnosticBag diagnostics,
                                ArrayBuilder<DeconstructionVariable> variables,
                                out Conversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 12339, 16682);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder> outPlaceholders = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 12718, 12753);

                f_10305_12718_12752((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 12767, 12820);

                ImmutableArray<TypeSymbol>
                tupleOrDeconstructedTypes
                = default(ImmutableArray<TypeSymbol>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 12834, 12873);

                conversion = Conversion.Deconstruction;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13018, 13073);

                var
                deconstructMethod = default(DeconstructMethodInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13087, 14791) || true) && (f_10305_13091_13107(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 13087, 14791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13224, 13326);

                    tupleOrDeconstructedTypes = type.TupleElementTypesWithAnnotations.SelectAsArray(TypeMap.AsTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13344, 13412);

                    f_10305_13344_13411(this, variables, tupleOrDeconstructedTypes, diagnostics);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13432, 13704) || true) && (f_10305_13436_13451(variables) != tupleOrDeconstructedTypes.Length)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 13432, 13704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13529, 13650);

                        f_10305_13529_13649(diagnostics, ErrorCode.ERR_DeconstructWrongCardinality, syntax, tupleOrDeconstructedTypes.Length, f_10305_13633_13648(variables));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13672, 13685);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 13432, 13704);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 13087, 14791);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 13087, 14791);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13770, 13957) || true) && (f_10305_13774_13789(variables) < 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 13770, 13957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13835, 13903);

                        f_10305_13835_13902(diagnostics, ErrorCode.ERR_DeconstructTooFewElements, syntax);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13925, 13938);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 13770, 13957);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 13977, 14073);

                    var
                    inputPlaceholder = f_10305_14000_14072(syntax, f_10305_14045_14065(this), type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 14091, 14343);

                    BoundExpression
                    deconstructInvocation = f_10305_14131_14342(this, f_10305_14167_14182(variables), inputPlaceholder, rightSyntax, diagnostics, outPlaceholders: out outPlaceholders, out _)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 14363, 14475) || true) && (f_10305_14367_14401(deconstructInvocation))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 14363, 14475);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 14443, 14456);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 14363, 14475);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 14495, 14599);

                    deconstructMethod = f_10305_14515_14598(deconstructInvocation, inputPlaceholder, outPlaceholders);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 14619, 14690);

                    tupleOrDeconstructedTypes = outPlaceholders.SelectAsArray(p => p.Type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 14708, 14776);

                    f_10305_14708_14775(this, variables, tupleOrDeconstructedTypes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 13087, 14791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 14911, 14934);

                bool
                hasErrors = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 14950, 14978);

                int
                count = f_10305_14962_14977(variables)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 14992, 15060);

                var
                nestedConversions = f_10305_15016_15059(count)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15083, 15088);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15074, 16503) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15101, 15104)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 15074, 16503))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 15074, 16503);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15138, 15166);

                        var
                        variable = f_10305_15153_15165(variables, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15186, 15214);

                        Conversion
                        nestedConversion
                        = default(Conversion);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15232, 16430) || true) && (variable.NestedVariables is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 15232, 16430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15312, 15432);

                            var
                            elementSyntax = (DynAbs.Tracing.TraceSender.Conditional_F1(10305, 15332, 15375) || ((f_10305_15332_15345(syntax) == SyntaxKind.TupleExpression && DynAbs.Tracing.TraceSender.Conditional_F2(10305, 15378, 15422)) || DynAbs.Tracing.TraceSender.Conditional_F3(10305, 15425, 15431))) ? f_10305_15378_15419(((TupleExpressionSyntax)syntax))[i] : syntax
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15456, 15643);

                            hasErrors |= !f_10305_15470_15642(this, tupleOrDeconstructedTypes[i], elementSyntax, rightSyntax, diagnostics, variable.NestedVariables, out nestedConversion);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 15232, 16430);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 15232, 16430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15725, 15754);

                            var
                            single = variable.Single
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15776, 15807);

                            f_10305_15776_15806(single is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15829, 15880);

                            HashSet<DiagnosticInfo>?
                            useSiteDiagnostics = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 15902, 16032);

                            nestedConversion = f_10305_15921_16031(f_10305_15921_15937(this), tupleOrDeconstructedTypes[i], f_10305_15995_16006(single), ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 16054, 16105);

                            f_10305_16054_16104(diagnostics, single.Syntax, useSiteDiagnostics);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 16129, 16411) || true) && (f_10305_16133_16161_M(!nestedConversion.IsImplicit))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 16129, 16411);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 16211, 16228);

                                hasErrors = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 16254, 16388);

                                f_10305_16254_16387(diagnostics, f_10305_16299_16310(), single.Syntax, nestedConversion, tupleOrDeconstructedTypes[i], f_10305_16375_16386(single));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 16129, 16411);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 15232, 16430);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 16448, 16488);

                        f_10305_16448_16487(nestedConversions, nestedConversion);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10305, 1, 1430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10305, 1, 1430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 16519, 16637);

                conversion = f_10305_16532_16636(ConversionKind.Deconstruction, deconstructMethod, f_10305_16597_16635(nestedConversions));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 16653, 16671);

                return !hasErrors;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 12339, 16682);

                int
                f_10305_12718_12752(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 12718, 12752);
                    return 0;
                }


                bool
                f_10305_13091_13107(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 13091, 13107);
                    return return_v;
                }


                int
                f_10305_13344_13411(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                foundTypes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.SetInferredTypes(variables, foundTypes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 13344, 13411);
                    return 0;
                }


                int
                f_10305_13436_13451(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 13436, 13451);
                    return return_v;
                }


                int
                f_10305_13633_13648(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 13633, 13648);
                    return return_v;
                }


                int
                f_10305_13529_13649(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 13529, 13649);
                    return 0;
                }


                int
                f_10305_13774_13789(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 13774, 13789);
                    return return_v;
                }


                int
                f_10305_13835_13902(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 13835, 13902);
                    return 0;
                }


                uint
                f_10305_14045_14065(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.LocalScopeDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 14045, 14065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                f_10305_14000_14072(Microsoft.CodeAnalysis.SyntaxNode
                syntax, uint
                valEscape, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder(syntax, valEscape, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 14000, 14072);
                    return return_v;
                }


                int
                f_10305_14167_14182(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 14167, 14182);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_14131_14342(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, int
                numCheckedVariables, Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                receiver, Microsoft.CodeAnalysis.SyntaxNode
                rightSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outPlaceholders, out bool
                anyApplicableCandidates)
                {
                    var return_v = this_param.MakeDeconstructInvocationExpression(numCheckedVariables, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, rightSyntax, diagnostics, out outPlaceholders, out anyApplicableCandidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 14131, 14342);
                    return return_v;
                }


                bool
                f_10305_14367_14401(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 14367, 14401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeconstructMethodInfo
                f_10305_14515_14598(Microsoft.CodeAnalysis.CSharp.BoundExpression
                invocation, Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder
                inputPlaceholder, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outputPlaceholders)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeconstructMethodInfo(invocation, inputPlaceholder, outputPlaceholders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 14515, 14598);
                    return return_v;
                }


                int
                f_10305_14708_14775(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                foundTypes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.SetInferredTypes(variables, foundTypes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 14708, 14775);
                    return 0;
                }


                int
                f_10305_14962_14977(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 14962, 14977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10305_15016_15059(int
                capacity)
                {
                    var return_v = ArrayBuilder<Conversion>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 15016, 15059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_15153_15165(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 15153, 15165);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10305_15332_15345(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 15332, 15345);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10305_15378_15419(Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 15378, 15419);
                    return return_v;
                }


                bool
                f_10305_15470_15642(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxNode
                rightSyntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, out Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = this_param.MakeDeconstructionConversion(type, syntax, rightSyntax, diagnostics, variables, out conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 15470, 15642);
                    return return_v;
                }


                int
                f_10305_15776_15806(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 15776, 15806);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversions
                f_10305_15921_15937(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Conversions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 15921, 15937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_15995_16006(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 15995, 16006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10305_15921_16031(Microsoft.CodeAnalysis.CSharp.Conversions
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 15921, 16031);
                    return return_v;
                }


                bool
                f_10305_16054_16104(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                node, System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = diagnostics.Add(node, useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 16054, 16104);
                    return return_v;
                }


                bool
                f_10305_16133_16161_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 16133, 16161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10305_16299_16310()
                {
                    var return_v = Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 16299, 16310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_16375_16386(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 16375, 16386);
                    return return_v;
                }


                int
                f_10305_16254_16387(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                targetType)
                {
                    GenerateImplicitConversionError(diagnostics, compilation, syntax, conversion, sourceType, targetType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 16254, 16387);
                    return 0;
                }


                int
                f_10305_16448_16487(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 16448, 16487);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10305_16597_16635(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 16597, 16635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10305_16532_16636(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.DeconstructMethodInfo
                deconstructMethodInfo, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, deconstructMethodInfo, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 16532, 16636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 12339, 16682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 12339, 16682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetInferredTypes(ArrayBuilder<DeconstructionVariable> variables, ImmutableArray<TypeSymbol> foundTypes, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 16794, 17526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 16962, 17024);

                var
                matchCount = f_10305_16979_17023(f_10305_16988_17003(variables), foundTypes.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17047, 17052);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17038, 17515) || true) && (i < matchCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17070, 17073)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 17038, 17515))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 17038, 17515);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17107, 17135);

                        var
                        variable = f_10305_17122_17134(variables, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17153, 17500) || true) && (variable.Single is { } pending)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 17153, 17500);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17229, 17344) || true) && ((object?)f_10305_17242_17254(pending) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 17229, 17344);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17312, 17321);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 17229, 17344);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17368, 17481);

                            variables[i] = f_10305_17383_17480(f_10305_17410_17462(this, pending, foundTypes[i], diagnostics), variable.Syntax);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 17153, 17500);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10305, 1, 478);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10305, 1, 478);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 16794, 17526);

                int
                f_10305_16988_17003(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 16988, 17003);
                    return return_v;
                }


                int
                f_10305_16979_17023(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 16979, 17023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_17122_17134(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 17122, 17134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_17242_17254(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 17242, 17254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_17410_17462(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.SetInferredType(expression, type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 17410, 17462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_17383_17480(Microsoft.CodeAnalysis.CSharp.BoundExpression
                variable, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable(variable, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 17383, 17480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 16794, 17526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 16794, 17526);
            }
        }

        private BoundExpression SetInferredType(BoundExpression expression, TypeSymbol type, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 17538, 18527);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17674, 18516);

                switch (f_10305_17682_17697(expression))
                {

                    case BoundKind.DeconstructionVariablePendingInference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 17674, 18516);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17834, 17899);

                            var
                            pending = (DeconstructionVariablePendingInference)expression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 17925, 18024);

                            return f_10305_17932_18023(pending, TypeWithAnnotations.Create(type), this, diagnostics);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 17674, 18516);

                    case BoundKind.DiscardExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 17674, 18516);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 18147, 18196);

                            var
                            pending = (BoundDiscardExpression)expression
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 18222, 18266);

                            f_10305_18222_18265((object?)f_10305_18244_18256(pending) == null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 18292, 18372);

                            return f_10305_18299_18371(pending, TypeWithAnnotations.Create(type));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 17674, 18516);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 17674, 18516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 18443, 18501);

                        throw f_10305_18449_18500(f_10305_18484_18499(expression));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 17674, 18516);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 17538, 18527);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10305_17682_17697(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 17682, 17697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_17932_18023(Microsoft.CodeAnalysis.CSharp.DeconstructionVariablePendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Binder
                binderOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.SetInferredTypeWithAnnotations(type, binderOpt, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 17932, 18023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_18244_18256(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 18244, 18256);
                    return return_v;
                }


                int
                f_10305_18222_18265(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 18222, 18265);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_18299_18371(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SetInferredTypeWithAnnotations(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 18299, 18371);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10305_18484_18499(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 18484, 18499);
                    return return_v;
                }


                System.Exception
                f_10305_18449_18500(Microsoft.CodeAnalysis.CSharp.BoundKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 18449, 18500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 17538, 18527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 17538, 18527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void FailRemainingInferencesAndSetValEscape(ArrayBuilder<DeconstructionVariable> variables, DiagnosticBag diagnostics,
                    uint rhsValEscape)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 18762, 21056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 18945, 18973);

                int
                count = f_10305_18957_18972(variables)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 18996, 19001);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 18987, 21045) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19014, 19017)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 18987, 21045))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 18987, 21045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19051, 19079);

                        var
                        variable = f_10305_19066_19078(variables, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19097, 21030) || true) && (variable.NestedVariables is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 19097, 21030);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19177, 19269);

                            f_10305_19177_19268(this, variable.NestedVariables, diagnostics, rhsValEscape);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 19097, 21030);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 19097, 21030);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19351, 19391);

                            f_10305_19351_19390(variable.Single is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19413, 20850);

                            switch (f_10305_19421_19441(variable.Single))
                            {

                                case BoundKind.Local:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 19413, 20850);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19542, 19582);

                                    var
                                    local = (BoundLocal)variable.Single
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19612, 19834) || true) && (f_10305_19616_19637(local) != BoundLocalDeclarationKind.None)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 19612, 19834);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19737, 19803);

                                        f_10305_19737_19802(((SourceLocalSymbol)f_10305_19757_19774(local)), rhsValEscape);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 19612, 19834);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10305, 19864, 19870);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 19413, 20850);

                                case BoundKind.DeconstructionVariablePendingInference:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 19413, 20850);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 19980, 20100);

                                    BoundExpression
                                    errorLocal = f_10305_20009_20099(((DeconstructionVariablePendingInference)variable.Single), this, diagnostics)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 20130, 20203);

                                    variables[i] = f_10305_20145_20202(errorLocal, errorLocal.Syntax);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10305, 20233, 20239);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 19413, 20850);

                                case BoundKind.DiscardExpression:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 19413, 20850);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 20328, 20382);

                                    var
                                    pending = (BoundDiscardExpression)variable.Single
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 20412, 20791) || true) && ((object?)f_10305_20425_20437(pending) == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 20412, 20791);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 20511, 20626);

                                        f_10305_20511_20625(diagnostics, ErrorCode.ERR_TypeInferenceFailedForImplicitlyTypedDeconstructionVariable, pending.Syntax, "_");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 20660, 20760);

                                        variables[i] = f_10305_20675_20759(f_10305_20702_20742(pending, this, diagnostics), pending.Syntax);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 20412, 20791);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10305, 20821, 20827);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 19413, 20850);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 20954, 21011);

                            f_10305_20954_21010((object?)f_10305_20976_21001(f_10305_20976_20988(variables, i).Single!) != null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 19097, 21030);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10305, 1, 2059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10305, 1, 2059);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 18762, 21056);

                int
                f_10305_18957_18972(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 18957, 18972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_19066_19078(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 19066, 19078);
                    return return_v;
                }


                int
                f_10305_19177_19268(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, uint
                rhsValEscape)
                {
                    this_param.FailRemainingInferencesAndSetValEscape(variables, diagnostics, rhsValEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 19177, 19268);
                    return 0;
                }


                int
                f_10305_19351_19390(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 19351, 19390);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10305_19421_19441(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 19421, 19441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocalDeclarationKind
                f_10305_19616_19637(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.DeclarationKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 19616, 19637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10305_19757_19774(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 19757, 19774);
                    return return_v;
                }


                int
                f_10305_19737_19802(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param, uint
                value)
                {
                    this_param.SetValEscape(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 19737, 19802);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_20009_20099(Microsoft.CodeAnalysis.CSharp.DeconstructionVariablePendingInference
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.FailInference(binder, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 20009, 20099);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_20145_20202(Microsoft.CodeAnalysis.CSharp.BoundExpression
                variable, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable(variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 20145, 20202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_20425_20437(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 20425, 20437);
                    return return_v;
                }


                int
                f_10305_20511_20625(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 20511, 20625);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                f_10305_20702_20742(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                this_param, Microsoft.CodeAnalysis.CSharp.Binder
                binder, Microsoft.CodeAnalysis.DiagnosticBag
                diagnosticsOpt)
                {
                    var return_v = this_param.FailInference(binder, diagnosticsOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 20702, 20742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_20675_20759(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                variable, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable((Microsoft.CodeAnalysis.CSharp.BoundExpression)variable, syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 20675, 20759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_20976_20988(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 20976, 20988);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_20976_21001(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 20976, 21001);
                    return return_v;
                }


                int
                f_10305_20954_21010(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 20954, 21010);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 18762, 21056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 18762, 21056);
            }
        }
        [DebuggerDisplay("{GetDebuggerDisplay(),nq}")]
        internal sealed class DeconstructionVariable
        {
            internal readonly BoundExpression? Single;

            internal readonly ArrayBuilder<DeconstructionVariable>? NestedVariables;

            internal readonly CSharpSyntaxNode Syntax;

            internal DeconstructionVariable(BoundExpression variable, SyntaxNode syntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10305, 21536, 21771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21371, 21377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21448, 21463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21513, 21519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21645, 21663);

                    Single = variable;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21681, 21704);

                    NestedVariables = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21722, 21756);

                    Syntax = (CSharpSyntaxNode)syntax;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10305, 21536, 21771);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 21536, 21771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 21536, 21771);
                }
            }

            internal DeconstructionVariable(ArrayBuilder<DeconstructionVariable> variables, SyntaxNode syntax)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10305, 21787, 22045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21371, 21377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21448, 21463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21513, 21519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21918, 21932);

                    Single = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21950, 21978);

                    NestedVariables = variables;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 21996, 22030);

                    Syntax = (CSharpSyntaxNode)syntax;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10305, 21787, 22045);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 21787, 22045);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 21787, 22045);
                }
            }

            internal static void FreeDeconstructionVariables(ArrayBuilder<DeconstructionVariable> variables)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10305, 22061, 22247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 22190, 22232);

                    f_10305_22190_22231(variables, v => v.NestedVariables);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10305, 22061, 22247);

                    int
                    f_10305_22190_22231(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                    builder, System.Func<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>>
                    getNested)
                    {
                        builder.FreeAll<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>(getNested);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 22190, 22231);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 22061, 22247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 22061, 22247);
                }
            }

            private string GetDebuggerDisplay()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 22263, 22589);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 22331, 22445) || true) && (Single != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 22331, 22445);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 22391, 22426);

                        return f_10305_22398_22425(Single);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 22331, 22445);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 22463, 22503);

                    f_10305_22463_22502(NestedVariables is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 22521, 22574);

                    return $"Nested variables ({f_10305_22549_22570(NestedVariables)})";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 22263, 22589);

                    string
                    f_10305_22398_22425(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.GetDebuggerDisplay();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 22398, 22425);
                        return return_v;
                    }


                    int
                    f_10305_22463_22502(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 22463, 22502);
                        return 0;
                    }


                    int
                    f_10305_22549_22570(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 22549, 22570);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 22263, 22589);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 22263, 22589);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static DeconstructionVariable()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10305, 21211, 22600);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10305, 21211, 22600);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 21211, 22600);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10305, 21211, 22600);
        }

        private static TypeSymbol? MakeMergedTupleType(ArrayBuilder<DeconstructionVariable> lhsVariables, BoundTupleLiteral rhsLiteral, CSharpSyntaxNode syntax, CSharpCompilation compilation, DiagnosticBag? diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10305, 23058, 26703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23294, 23330);

                int
                leftLength = f_10305_23311_23329(lhsVariables)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23344, 23390);

                int
                rightLength = rhsLiteral.Arguments.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23406, 23498);

                var
                typesWithAnnotationsBuilder = f_10305_23440_23497(leftLength)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23512, 23583);

                var
                locationsBuilder = f_10305_23535_23582(leftLength)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23606, 23611);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23597, 25637) || true) && (i < rightLength)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23630, 23633)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 23597, 25637))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 23597, 25637);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23667, 23717);

                        BoundExpression
                        element = f_10305_23693_23713(rhsLiteral)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23735, 23773);

                        TypeSymbol?
                        mergedType = f_10305_23760_23772(element)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23793, 25466) || true) && (i < leftLength)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 23793, 25466);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23853, 23884);

                            var
                            variable = f_10305_23868_23883(lhsVariables, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23906, 25062) || true) && (variable.NestedVariables is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 23906, 25062);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 23994, 24656) || true) && (f_10305_23998_24010(element) == BoundKind.TupleLiteral)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 23994, 24656);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 24178, 24299);

                                    mergedType = f_10305_24191_24298(variable.NestedVariables, element, syntax, compilation, diagnostics);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 23994, 24656);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 23994, 24656);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 24357, 24656) || true) && ((object?)mergedType == null && (DynAbs.Tracing.TraceSender.Expression_True(10305, 24361, 24413) && diagnostics is object))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 24357, 24656);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 24549, 24629);

                                        f_10305_24549_24628(diagnostics, ErrorCode.ERR_DeconstructRequiresExpression, element.Syntax);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 24357, 24656);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 23994, 24656);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 23906, 25062);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 23906, 25062);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 24754, 24794);

                                f_10305_24754_24793(variable.Single is object);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 24820, 25039) || true) && ((object?)f_10305_24833_24853(variable.Single) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 24820, 25039);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 24978, 25012);

                                    mergedType = f_10305_24991_25011(variable.Single);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 24820, 25039);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 23906, 25062);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 23793, 25466);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 23793, 25466);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 25144, 25447) || true) && ((object?)mergedType == null && (DynAbs.Tracing.TraceSender.Expression_True(10305, 25148, 25200) && diagnostics is object))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 25144, 25447);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 25344, 25424);

                                f_10305_25344_25423(diagnostics, ErrorCode.ERR_DeconstructRequiresExpression, element.Syntax);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 25144, 25447);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 23793, 25466);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 25486, 25558);

                        f_10305_25486_25557(
                                        typesWithAnnotationsBuilder, TypeWithAnnotations.Create(mergedType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 25576, 25622);

                        f_10305_25576_25621(locationsBuilder, f_10305_25597_25620(element.Syntax));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10305, 1, 2041);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10305, 1, 2041);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 25653, 25861) || true) && (f_10305_25657_25705(typesWithAnnotationsBuilder, t => !t.HasType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 25653, 25861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 25739, 25774);

                    f_10305_25739_25773(typesWithAnnotationsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 25792, 25816);

                    f_10305_25792_25815(locationsBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 25834, 25846);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 25653, 25861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 26111, 26692);

                return f_10305_26118_26691(locationOpt: null, elementTypesWithAnnotations: f_10305_26229_26277(typesWithAnnotationsBuilder), elementLocations: f_10305_26314_26351(locationsBuilder), elementNames: default(ImmutableArray<string?>), compilation: compilation, diagnostics: diagnostics, shouldCheckConstraints: true, includeNullability: false, errorPositions: default(ImmutableArray<bool>), syntax: syntax);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10305, 23058, 26703);

                int
                f_10305_23311_23329(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 23311, 23329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10305_23440_23497(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 23440, 23497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                f_10305_23535_23582(int
                capacity)
                {
                    var return_v = ArrayBuilder<Location?>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 23535, 23582);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10305_23693_23713(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 23693, 23713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_23760_23772(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 23760, 23772);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_23868_23883(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 23868, 23883);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10305_23998_24010(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 23998, 24010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_24191_24298(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                lhsVariables, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rhsLiteral, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics)
                {
                    var return_v = MakeMergedTupleType(lhsVariables, (Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral)rhsLiteral, syntax, compilation, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 24191, 24298);
                    return return_v;
                }


                int
                f_10305_24549_24628(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 24549, 24628);
                    return 0;
                }


                int
                f_10305_24754_24793(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 24754, 24793);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_24833_24853(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 24833, 24853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10305_24991_25011(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 24991, 25011);
                    return return_v;
                }


                int
                f_10305_25344_25423(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 25344, 25423);
                    return 0;
                }


                int
                f_10305_25486_25557(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 25486, 25557);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10305_25597_25620(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 25597, 25620);
                    return return_v;
                }


                int
                f_10305_25576_25621(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                this_param, Microsoft.CodeAnalysis.Location
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 25576, 25621);
                    return 0;
                }


                bool
                f_10305_25657_25705(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, bool>
                predicate)
                {
                    var return_v = builder.Any<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 25657, 25705);
                    return return_v;
                }


                int
                f_10305_25739_25773(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 25739, 25773);
                    return 0;
                }


                int
                f_10305_25792_25815(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 25792, 25815);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10305_26229_26277(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 26229, 26277);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                f_10305_26314_26351(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 26314, 26351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10305_26118_26691(Microsoft.CodeAnalysis.Location?
                locationOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                elementTypesWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics, bool
                shouldCheckConstraints, bool
                includeNullability, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = NamedTypeSymbol.CreateTuple(locationOpt: locationOpt, elementTypesWithAnnotations: elementTypesWithAnnotations, elementLocations: elementLocations, elementNames: elementNames, compilation: compilation, diagnostics: diagnostics, shouldCheckConstraints: shouldCheckConstraints, includeNullability: includeNullability, errorPositions: errorPositions, syntax: syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 26118, 26691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 23058, 26703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 23058, 26703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundTupleExpression DeconstructionVariablesAsTuple(CSharpSyntaxNode syntax, ArrayBuilder<DeconstructionVariable> variables,
                    DiagnosticBag diagnostics, bool ignoreDiagnosticsFromTuple)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 26715, 29537);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 26945, 26973);

                int
                count = f_10305_26957_26972(variables)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 26987, 27056);

                var
                valuesBuilder = f_10305_27007_27055(count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27070, 27157);

                var
                typesWithAnnotationsBuilder = f_10305_27104_27156(count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27171, 27237);

                var
                locationsBuilder = f_10305_27194_27236(count)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27251, 27311);

                var
                namesBuilder = f_10305_27270_27310(count)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27327, 28166);
                    foreach (var variable in f_10305_27352_27361_I(variables))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 27327, 28166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27395, 27417);

                        BoundExpression
                        value
                        = default(BoundExpression);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27435, 27953) || true) && (variable.NestedVariables is object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 27435, 27953);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27515, 27638);

                            value = f_10305_27523_27637(this, variable.Syntax, variable.NestedVariables, diagnostics, ignoreDiagnosticsFromTuple);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27660, 27683);

                            f_10305_27660_27682(namesBuilder, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 27435, 27953);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 27435, 27953);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27765, 27805);

                            f_10305_27765_27804(variable.Single is object);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27827, 27851);

                            value = variable.Single;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27873, 27934);

                            f_10305_27873_27933(namesBuilder, f_10305_27890_27932(value));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 27435, 27953);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 27971, 27996);

                        f_10305_27971_27995(valuesBuilder, value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28014, 28086);

                        f_10305_28014_28085(typesWithAnnotationsBuilder, TypeWithAnnotations.Create(f_10305_28073_28083(value)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28104, 28151);

                        f_10305_28104_28150(locationsBuilder, f_10305_28125_28149(variable.Syntax));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 27327, 28166);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10305, 1, 840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10305, 1, 840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28180, 28259);

                ImmutableArray<BoundExpression>
                arguments = f_10305_28224_28258(valuesBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28275, 28334);

                var
                uniqueFieldNames = f_10305_28298_28333()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28348, 28434);

                f_10305_28348_28433(ref namesBuilder, uniqueFieldNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28448, 28472);

                f_10305_28448_28471(uniqueFieldNames);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28488, 28592);

                ImmutableArray<string?>
                tupleNames = (DynAbs.Tracing.TraceSender.Conditional_F1(10305, 28525, 28545) || ((namesBuilder is null && DynAbs.Tracing.TraceSender.Conditional_F2(10305, 28548, 28555)) || DynAbs.Tracing.TraceSender.Conditional_F3(10305, 28558, 28591))) ? default : f_10305_28558_28591(namesBuilder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28606, 28721);

                ImmutableArray<bool>
                inferredPositions = (DynAbs.Tracing.TraceSender.Conditional_F1(10305, 28647, 28667) || ((tupleNames.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10305, 28670, 28677)) || DynAbs.Tracing.TraceSender.Conditional_F3(10305, 28680, 28720))) ? default : tupleNames.SelectAsArray(n => n != null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28735, 28833);

                bool
                disallowInferredNames = f_10305_28764_28832(f_10305_28764_28796(f_10305_28764_28780(this)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 28849, 29371);

                var
                type = f_10305_28860_29370(f_10305_28906_28921(syntax), f_10305_28940_28988(typesWithAnnotationsBuilder), f_10305_28990_29027(locationsBuilder), tupleNames, f_10305_29058_29074(this), shouldCheckConstraints: !ignoreDiagnosticsFromTuple, includeNullability: false, errorPositions: (DynAbs.Tracing.TraceSender.Conditional_F1(10305, 29223, 29244) || ((disallowInferredNames && DynAbs.Tracing.TraceSender.Conditional_F2(10305, 29247, 29264)) || DynAbs.Tracing.TraceSender.Conditional_F3(10305, 29267, 29274))) ? inferredPositions : default, syntax: syntax, diagnostics: (DynAbs.Tracing.TraceSender.Conditional_F1(10305, 29322, 29348) || ((ignoreDiagnosticsFromTuple && DynAbs.Tracing.TraceSender.Conditional_F2(10305, 29351, 29355)) || DynAbs.Tracing.TraceSender.Conditional_F3(10305, 29358, 29369))) ? null : diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 29387, 29526);

                return (BoundTupleExpression)f_10305_29416_29525(this, f_10305_29434_29511(syntax, arguments, tupleNames, inferredPositions, type), diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 26715, 29537);

                int
                f_10305_26957_26972(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 26957, 26972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10305_27007_27055(int
                capacity)
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27007, 27055);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10305_27104_27156(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27104, 27156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                f_10305_27194_27236(int
                capacity)
                {
                    var return_v = ArrayBuilder<Location?>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27194, 27236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                f_10305_27270_27310(int
                capacity)
                {
                    var return_v = ArrayBuilder<string?>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27270, 27310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                f_10305_27523_27637(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                ignoreDiagnosticsFromTuple)
                {
                    var return_v = this_param.DeconstructionVariablesAsTuple(syntax, variables, diagnostics, ignoreDiagnosticsFromTuple);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27523, 27637);
                    return return_v;
                }


                int
                f_10305_27660_27682(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                this_param, string?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27660, 27682);
                    return 0;
                }


                int
                f_10305_27765_27804(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27765, 27804);
                    return 0;
                }


                string?
                f_10305_27890_27932(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = ExtractDeconstructResultElementName(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27890, 27932);
                    return return_v;
                }


                int
                f_10305_27873_27933(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                this_param, string?
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27873, 27933);
                    return 0;
                }


                int
                f_10305_27971_27995(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27971, 27995);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_28073_28083(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 28073, 28083);
                    return return_v;
                }


                int
                f_10305_28014_28085(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28014, 28085);
                    return 0;
                }


                Microsoft.CodeAnalysis.Location
                f_10305_28125_28149(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 28125, 28149);
                    return return_v;
                }


                int
                f_10305_28104_28150(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                this_param, Microsoft.CodeAnalysis.Location
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28104, 28150);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                f_10305_27352_27361_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 27352, 27361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10305_28224_28258(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28224, 28258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                f_10305_28298_28333()
                {
                    var return_v = PooledHashSet<string>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28298, 28333);
                    return return_v;
                }


                int
                f_10305_28348_28433(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                inferredElementNames, Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                uniqueFieldNames)
                {
                    RemoveDuplicateInferredTupleNamesAndFreeIfEmptied(ref inferredElementNames, (System.Collections.Generic.HashSet<string>)uniqueFieldNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28348, 28433);
                    return 0;
                }


                int
                f_10305_28448_28471(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<string>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28448, 28471);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string?>
                f_10305_28558_28591(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<string?>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28558, 28591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10305_28764_28780(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 28764, 28780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10305_28764_28796(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.LanguageVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 28764, 28796);
                    return return_v;
                }


                bool
                f_10305_28764_28832(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                self)
                {
                    var return_v = self.DisallowInferredTupleElementNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28764, 28832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10305_28906_28921(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 28906, 28921);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10305_28940_28988(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28940, 28988);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                f_10305_28990_29027(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Location?>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28990, 29027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10305_29058_29074(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 29058, 29074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10305_28860_29370(Microsoft.CodeAnalysis.Location
                locationOpt, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                elementTypesWithAnnotations, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location?>
                elementLocations, System.Collections.Immutable.ImmutableArray<string?>
                elementNames, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, bool
                shouldCheckConstraints, bool
                includeNullability, System.Collections.Immutable.ImmutableArray<bool>
                errorPositions, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnostics)
                {
                    var return_v = NamedTypeSymbol.CreateTuple(locationOpt, elementTypesWithAnnotations, elementLocations, elementNames, compilation, shouldCheckConstraints: shouldCheckConstraints, includeNullability: includeNullability, errorPositions: errorPositions, syntax: syntax, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 28860, 29370);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                f_10305_29434_29511(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                arguments, System.Collections.Immutable.ImmutableArray<string?>
                argumentNamesOpt, System.Collections.Immutable.ImmutableArray<bool>
                inferredNamesOpt, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral((Microsoft.CodeAnalysis.SyntaxNode)syntax, arguments, argumentNamesOpt, inferredNamesOpt, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 29434, 29511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_29416_29525(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 29416, 29525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 26715, 29537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 26715, 29537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string? ExtractDeconstructResultElementName(BoundExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10305, 29642, 29939);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 29753, 29864) || true) && (f_10305_29757_29772(expression) == BoundKind.DiscardExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 29753, 29864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 29837, 29849);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 29753, 29864);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 29880, 29928);

                return f_10305_29887_29927(expression.Syntax);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10305, 29642, 29939);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10305_29757_29772(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 29757, 29772);
                    return return_v;
                }


                string
                f_10305_29887_29927(Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    var return_v = InferTupleElementName(syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 29887, 29927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 29642, 29939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 29642, 29939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression MakeDeconstructInvocationExpression(
                    int numCheckedVariables,
                    BoundExpression receiver,
                    SyntaxNode rightSyntax,
                    DiagnosticBag diagnostics,
                    out ImmutableArray<BoundDeconstructValuePlaceholder> outPlaceholders,
                    out bool anyApplicableCandidates)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 30455, 35506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 30824, 30856);

                anyApplicableCandidates = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 30870, 30925);

                var
                receiverSyntax = (CSharpSyntaxNode)receiver.Syntax
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 30939, 31260) || true) && (f_10305_30957_30969(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10305_30943_30956(receiver), 10305, 30943, 30969)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<bool?>(10305, 30943, 30978) ?? false))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 30939, 31260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31012, 31084);

                    f_10305_31012_31083(diagnostics, ErrorCode.ERR_CannotDeconstructDynamic, rightSyntax);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31102, 31178);

                    outPlaceholders = default(ImmutableArray<BoundDeconstructValuePlaceholder>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31198, 31245);

                    return f_10305_31205_31244(this, receiverSyntax, receiver);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 30939, 31260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31276, 31328);

                receiver = f_10305_31287_31327(this, receiver, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31342, 31398);

                var
                analyzedArguments = f_10305_31366_31397()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31412, 31507);

                var
                outVars = f_10305_31426_31506(numCheckedVariables)
                ;

                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31568, 31573);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31559, 31907) || true) && (i < numCheckedVariables)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31600, 31603)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 31559, 31907))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 31559, 31907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31645, 31714);

                            var
                            variable = f_10305_31660_31713(receiverSyntax)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31736, 31778);

                            f_10305_31736_31777(analyzedArguments.Arguments, variable);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31800, 31844);

                            f_10305_31800_31843(analyzedArguments.RefKinds, RefKind.Out);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31866, 31888);

                            f_10305_31866_31887(outVars, variable);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10305, 1, 349);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10305, 1, 349);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 31927, 31996);

                    const string
                    methodName = WellKnownMemberNames.DeconstructMethodName
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 32014, 32485);

                    var
                    memberAccess = f_10305_32033_32484(this, rightSyntax, receiverSyntax, receiver, methodName, rightArity: 0, typeArgumentsSyntax: default(SeparatedSyntaxList<TypeSyntax>), typeArgumentsWithAnnotations: default(ImmutableArray<TypeWithAnnotations>), invoked: true, indexed: false, diagnostics: diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 32505, 32593);

                    memberAccess = f_10305_32520_32592(this, memberAccess, BindValueKind.RValueOrMethodGroup, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 32611, 32652);

                    memberAccess.WasCompilerGenerated = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 32672, 32893) || true) && (f_10305_32676_32693(memberAccess) != BoundKind.MethodGroup)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 32672, 32893);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 32760, 32874);

                        return f_10305_32767_32873(this, receiver, rightSyntax, numCheckedVariables, diagnostics, out outPlaceholders, receiver);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 32672, 32893);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 33427, 33723);

                    BoundExpression
                    result = f_10305_33452_33722(this, rightSyntax, rightSyntax, methodName, memberAccess, analyzedArguments, diagnostics, queryClause: null, allowUnexpandedForm: true, anyApplicableCandidates: out anyApplicableCandidates)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 33743, 33778);

                    result.WasCompilerGenerated = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 33798, 33999) || true) && (!anyApplicableCandidates)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 33798, 33999);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 33868, 33980);

                        return f_10305_33875_33979(this, receiver, rightSyntax, numCheckedVariables, diagnostics, out outPlaceholders, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 33798, 33999);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 34224, 34275);

                    var
                    deconstructMethod = f_10305_34248_34274(((BoundCall)result))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 34293, 34339);

                    var
                    parameters = f_10305_34310_34338(deconstructMethod)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 34366, 34415);
                        for (int
        i = ((DynAbs.Tracing.TraceSender.Conditional_F1(10305, 34371, 34406) || ((f_10305_34371_34406(deconstructMethod) && DynAbs.Tracing.TraceSender.Conditional_F2(10305, 34409, 34410)) || DynAbs.Tracing.TraceSender.Conditional_F3(10305, 34413, 34414))) ? 1 : 0)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 34357, 34729) || true) && (i < parameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 34440, 34443)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 34357, 34729))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 34357, 34729);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 34485, 34710) || true) && (f_10305_34489_34510(parameters[i]) != RefKind.Out)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 34485, 34710);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 34575, 34687);

                                return f_10305_34582_34686(this, receiver, rightSyntax, numCheckedVariables, diagnostics, out outPlaceholders, result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 34485, 34710);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10305, 1, 373);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10305, 1, 373);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 34749, 35002) || true) && (f_10305_34753_34802(f_10305_34753_34781(deconstructMethod)) != SpecialType.System_Void)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 34749, 35002);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 34871, 34983);

                        return f_10305_34878_34982(this, receiver, rightSyntax, numCheckedVariables, diagnostics, out outPlaceholders, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 34749, 35002);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 35022, 35238) || true) && (f_10305_35026_35065(outVars, v => v.Placeholder is null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 35022, 35238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 35107, 35219);

                        return f_10305_35114_35218(this, receiver, rightSyntax, numCheckedVariables, diagnostics, out outPlaceholders, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 35022, 35238);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 35258, 35319);

                    outPlaceholders = f_10305_35276_35318(outVars, v => v.Placeholder!);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 35339, 35353);

                    return result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10305, 35382, 35495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 35422, 35447);

                    f_10305_35422_35446(analyzedArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 35465, 35480);

                    f_10305_35465_35479(outVars);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10305, 35382, 35495);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 30455, 35506);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_30943_30956(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 30943, 30956);
                    return return_v;
                }


                bool?
                f_10305_30957_30969(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 30957, 30969);
                    return return_v;
                }


                int
                f_10305_31012_31083(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 31012, 31083);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10305_31205_31244(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.BadExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 31205, 31244);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_31287_31327(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindToNaturalType(expression, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 31287, 31327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                f_10305_31366_31397()
                {
                    var return_v = AnalyzedArguments.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 31366, 31397);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference>
                f_10305_31426_31506(int
                capacity)
                {
                    var return_v = ArrayBuilder<OutDeconstructVarPendingInference>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 31426, 31506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference
                f_10305_31660_31713(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference((Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 31660, 31713);
                    return return_v;
                }


                int
                f_10305_31736_31777(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 31736, 31777);
                    return 0;
                }


                int
                f_10305_31800_31843(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.RefKind>
                this_param, Microsoft.CodeAnalysis.RefKind
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 31800, 31843);
                    return 0;
                }


                int
                f_10305_31866_31887(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference>
                this_param, Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 31866, 31887);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_32033_32484(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                right, Microsoft.CodeAnalysis.CSharp.BoundExpression
                boundLeft, string
                rightName, int
                rightArity, Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax>
                typeArgumentsSyntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, bool
                invoked, bool
                indexed, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindInstanceMemberAccess(node, (Microsoft.CodeAnalysis.SyntaxNode)right, boundLeft, rightName, rightArity: rightArity, typeArgumentsSyntax: typeArgumentsSyntax, typeArgumentsWithAnnotations: typeArgumentsWithAnnotations, invoked: invoked, indexed: indexed, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 32033, 32484);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_32520_32592(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValue(expr, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 32520, 32592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10305_32676_32693(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 32676, 32693);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10305_32767_32873(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.SyntaxNode
                rightSyntax, int
                numParameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outPlaceholders, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.MissingDeconstruct(receiver, rightSyntax, numParameters, diagnostics, out outPlaceholders, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 32767, 32873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_33452_33722(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.SyntaxNode
                expression, string
                methodName, Microsoft.CodeAnalysis.CSharp.BoundExpression
                methodGroup, Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                analyzedArguments, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                queryClause, bool
                allowUnexpandedForm, out bool
                anyApplicableCandidates)
                {
                    var return_v = this_param.BindMethodGroupInvocation(syntax, expression, methodName, (Microsoft.CodeAnalysis.CSharp.BoundMethodGroup)methodGroup, analyzedArguments, diagnostics, queryClause: queryClause, allowUnexpandedForm: allowUnexpandedForm, out anyApplicableCandidates);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 33452, 33722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10305_33875_33979(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.SyntaxNode
                rightSyntax, int
                numParameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outPlaceholders, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.MissingDeconstruct(receiver, rightSyntax, numParameters, diagnostics, out outPlaceholders, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 33875, 33979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10305_34248_34274(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 34248, 34274);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10305_34310_34338(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 34310, 34338);
                    return return_v;
                }


                bool
                f_10305_34371_34406(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 34371, 34406);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10305_34489_34510(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 34489, 34510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10305_34582_34686(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.SyntaxNode
                rightSyntax, int
                numParameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outPlaceholders, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.MissingDeconstruct(receiver, rightSyntax, numParameters, diagnostics, out outPlaceholders, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 34582, 34686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10305_34753_34781(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 34753, 34781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10305_34753_34802(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 34753, 34802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10305_34878_34982(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.SyntaxNode
                rightSyntax, int
                numParameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outPlaceholders, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.MissingDeconstruct(receiver, rightSyntax, numParameters, diagnostics, out outPlaceholders, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 34878, 34982);
                    return return_v;
                }


                bool
                f_10305_35026_35065(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference>
                builder, System.Func<Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference, bool>
                predicate)
                {
                    var return_v = builder.Any<Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 35026, 35065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10305_35114_35218(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.SyntaxNode
                rightSyntax, int
                numParameters, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                outPlaceholders, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.MissingDeconstruct(receiver, rightSyntax, numParameters, diagnostics, out outPlaceholders, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 35114, 35218);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                f_10305_35276_35318(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference>
                items, System.Func<Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference, Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>
                map)
                {
                    var return_v = items.SelectAsArray<Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference, Microsoft.CodeAnalysis.CSharp.BoundDeconstructValuePlaceholder>(map);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 35276, 35318);
                    return return_v;
                }


                int
                f_10305_35422_35446(Microsoft.CodeAnalysis.CSharp.AnalyzedArguments
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 35422, 35446);
                    return 0;
                }


                int
                f_10305_35465_35479(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.OutDeconstructVarPendingInference>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 35465, 35479);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 30455, 35506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 30455, 35506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundBadExpression MissingDeconstruct(BoundExpression receiver, SyntaxNode rightSyntax, int numParameters, DiagnosticBag diagnostics,
                                            out ImmutableArray<BoundDeconstructValuePlaceholder> outPlaceholders, BoundExpression childNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 35518, 36117);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 35818, 36005) || true) && (f_10305_35836_35850(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10305_35822_35835(receiver), 10305, 35822, 35850)) == false)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 35818, 36005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 35893, 35990);

                    f_10305_35893_35989(diagnostics, ErrorCode.ERR_MissingDeconstruct, rightSyntax, receiver.Type!, numParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 35818, 36005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 36021, 36047);

                outPlaceholders = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 36061, 36106);

                return f_10305_36068_36105(this, rightSyntax, childNode);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 35518, 36117);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10305_35822_35835(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 35822, 35835);
                    return return_v;
                }


                bool?
                f_10305_35836_35850(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type?.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 35836, 35850);
                    return return_v;
                }


                int
                f_10305_35893_35989(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.SyntaxNode
                syntax, params object[]
                args)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.SyntaxNodeOrToken)syntax, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 35893, 35989);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBadExpression
                f_10305_36068_36105(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                childNode)
                {
                    var return_v = this_param.BadExpression(syntax, childNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 36068, 36105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 35518, 36117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 35518, 36117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DeconstructionVariable BindDeconstructionVariables(
                    ExpressionSyntax node,
                    DiagnosticBag diagnostics,
                    ref DeclarationExpressionSyntax? declaration,
                    ref ExpressionSyntax? expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 36636, 39531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 36902, 39520);

                switch (f_10305_36910_36921(node))
                {

                    case SyntaxKind.DeclarationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 36902, 39520);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37042, 37092);

                            var
                            component = (DeclarationExpressionSyntax)node
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37118, 37250) || true) && (declaration == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 37118, 37250);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37199, 37223);

                                declaration = component;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 37118, 37250);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37278, 37289);

                            bool
                            isVar
                            = default(bool);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37315, 37336);

                            bool
                            isConst = false
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37362, 37380);

                            AliasSymbol
                            alias
                            = default(AliasSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37406, 37540);

                            var
                            declType = f_10305_37421_37539(this, f_10305_37453_37474(component), diagnostics, f_10305_37489_37503(component), ref isConst, out isVar, out alias)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37566, 37607);

                            f_10305_37566_37606(isVar == f_10305_37588_37605_M(!declType.HasType));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37633, 37999) || true) && (f_10305_37637_37665(f_10305_37637_37658(component)) == SyntaxKind.ParenthesizedVariableDesignation && (DynAbs.Tracing.TraceSender.Expression_True(10305, 37637, 37722) && !isVar))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 37633, 37999);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 37872, 37972);

                                f_10305_37872_37971(diagnostics, ErrorCode.ERR_DeconstructionVarFormDisallowsSpecificType, f_10305_37949_37970(component));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 37633, 37999);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 38027, 38119);

                            return f_10305_38034_38118(this, declType, f_10305_38072_38093(component), component, diagnostics);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 36902, 39520);

                    case SyntaxKind.TupleExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 36902, 39520);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 38241, 38285);

                            var
                            component = (TupleExpressionSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 38311, 38401);

                            var
                            builder = f_10305_38325_38400(component.Arguments.Count)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 38427, 38891);
                                foreach (var arg in f_10305_38447_38466_I(f_10305_38447_38466(component)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 38427, 38891);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 38524, 38729) || true) && (f_10305_38528_38541(arg) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 38524, 38729);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 38615, 38698);

                                        f_10305_38615_38697(diagnostics, ErrorCode.ERR_TupleElementNamesInDeconstruction, f_10305_38683_38696(arg));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 38524, 38729);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 38761, 38864);

                                    f_10305_38761_38863(
                                                                builder, f_10305_38773_38862(this, f_10305_38801_38815(arg), diagnostics, ref declaration, ref expression));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 38427, 38891);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10305, 1, 465);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10305, 1, 465);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 38919, 38968);

                            return f_10305_38926_38967(builder, node);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 36902, 39520);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 36902, 39520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 39039, 39125);

                        var
                        boundVariable = f_10305_39059_39124(this, node, diagnostics, invoked: false, indexed: false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 39147, 39234);

                        var
                        checkedVariable = f_10305_39169_39233(this, boundVariable, BindValueKind.Assignable, diagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 39256, 39424) || true) && (expression == null && (DynAbs.Tracing.TraceSender.Expression_True(10305, 39260, 39333) && f_10305_39282_39302(checkedVariable) != BoundKind.DiscardExpression))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 39256, 39424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 39383, 39401);

                            expression = node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 39256, 39424);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 39448, 39505);

                        return f_10305_39455_39504(checkedVariable, node);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 36902, 39520);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 36636, 39531);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10305_36910_36921(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 36910, 36921);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10305_37453_37474(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 37453, 37474);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                f_10305_37489_37503(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 37489, 37503);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10305_37421_37539(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                declarationNode, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                typeSyntax, ref bool
                isConst, out bool
                isVar, out Microsoft.CodeAnalysis.CSharp.Symbols.AliasSymbol
                alias)
                {
                    var return_v = this_param.BindVariableTypeWithAnnotations((Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)declarationNode, diagnostics, typeSyntax, ref isConst, out isVar, out alias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 37421, 37539);
                    return return_v;
                }


                bool
                f_10305_37588_37605_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 37588, 37605);
                    return return_v;
                }


                int
                f_10305_37566_37606(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 37566, 37606);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10305_37637_37658(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 37637, 37658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10305_37637_37665(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 37637, 37665);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10305_37949_37970(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 37949, 37970);
                    return return_v;
                }


                int
                f_10305_37872_37971(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 37872, 37971);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                f_10305_38072_38093(Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Designation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 38072, 38093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_38034_38118(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                declTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindDeconstructionVariables(declTypeWithAnnotations, node, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 38034, 38118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                f_10305_38325_38400(int
                capacity)
                {
                    var return_v = ArrayBuilder<DeconstructionVariable>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 38325, 38400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10305_38447_38466(Microsoft.CodeAnalysis.CSharp.Syntax.TupleExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 38447, 38466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax?
                f_10305_38528_38541(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 38528, 38541);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                f_10305_38683_38696(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.NameColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 38683, 38696);
                    return return_v;
                }


                int
                f_10305_38615_38697(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.Syntax.NameColonSyntax
                syntax)
                {
                    Error(diagnostics, code, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 38615, 38697);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                f_10305_38801_38815(Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 38801, 38815);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_38773_38862(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, ref Microsoft.CodeAnalysis.CSharp.Syntax.DeclarationExpressionSyntax?
                declaration, ref Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax?
                expression)
                {
                    var return_v = this_param.BindDeconstructionVariables(node, diagnostics, ref declaration, ref expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 38773, 38862);
                    return return_v;
                }


                int
                f_10305_38761_38863(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 38761, 38863);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                f_10305_38447_38466_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 38447, 38466);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_38926_38967(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable(variables, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 38926, 38967);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_39059_39124(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                invoked, bool
                indexed)
                {
                    var return_v = this_param.BindExpression(node, diagnostics, invoked: invoked, indexed: indexed);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 39059, 39124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_39169_39233(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr, Microsoft.CodeAnalysis.CSharp.Binder.BindValueKind
                valueKind, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.CheckValue(expr, valueKind, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 39169, 39233);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10305_39282_39302(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 39282, 39302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_39455_39504(Microsoft.CodeAnalysis.CSharp.BoundExpression
                variable, Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable(variable, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 39455, 39504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 36636, 39531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 36636, 39531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DeconstructionVariable BindDeconstructionVariables(
                    TypeWithAnnotations declTypeWithAnnotations,
                    VariableDesignationSyntax node,
                    CSharpSyntaxNode syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 39543, 41193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 39808, 41182);

                switch (f_10305_39816_39827(node))
                {

                    case SyntaxKind.SingleVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 39808, 41182);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 39952, 40003);

                            var
                            single = (SingleVariableDesignationSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 40029, 40153);

                            return f_10305_40036_40152(f_10305_40063_40143(this, declTypeWithAnnotations, single, syntax, diagnostics), syntax);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 39808, 41182);

                    case SyntaxKind.DiscardDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 39808, 41182);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 40278, 40325);

                            var
                            discarded = (DiscardDesignationSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 40351, 40449);

                            return f_10305_40358_40448(f_10305_40385_40439(syntax, declTypeWithAnnotations), syntax);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 39808, 41182);

                    case SyntaxKind.ParenthesizedVariableDesignation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 39808, 41182);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 40588, 40645);

                            var
                            tuple = (ParenthesizedVariableDesignationSyntax)node
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 40671, 40736);

                            var
                            builder = f_10305_40685_40735()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 40762, 40965);
                                foreach (var n in f_10305_40780_40795_I(f_10305_40780_40795(tuple)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 40762, 40965);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 40853, 40938);

                                    f_10305_40853_40937(builder, f_10305_40865_40936(this, declTypeWithAnnotations, n, n, diagnostics));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 40762, 40965);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10305, 1, 204);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10305, 1, 204);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 40991, 41042);

                            return f_10305_40998_41041(builder, syntax);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 39808, 41182);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 39808, 41182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 41113, 41167);

                        throw f_10305_41119_41166(f_10305_41154_41165(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 39808, 41182);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 39543, 41193);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10305_39816_39827(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 39816, 39827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10305_40063_40143(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                declTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                designation, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindDeconstructionVariable(declTypeWithAnnotations, designation, syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 40063, 40143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_40036_40152(Microsoft.CodeAnalysis.CSharp.BoundExpression
                variable, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable(variable, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 40036, 40152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                f_10305_40385_40439(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                declTypeWithAnnotations)
                {
                    var return_v = BindDiscardExpression((Microsoft.CodeAnalysis.SyntaxNode)syntax, declTypeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 40385, 40439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_40358_40448(Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                variable, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable((Microsoft.CodeAnalysis.CSharp.BoundExpression)variable, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 40358, 40448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                f_10305_40685_40735()
                {
                    var return_v = ArrayBuilder<DeconstructionVariable>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 40685, 40735);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10305_40780_40795(Microsoft.CodeAnalysis.CSharp.Syntax.ParenthesizedVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 40780, 40795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_40865_40936(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                declTypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                syntax, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.BindDeconstructionVariables(declTypeWithAnnotations, node, (Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode)syntax, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 40865, 40936);
                    return return_v;
                }


                int
                f_10305_40853_40937(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                this_param, Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 40853, 40937);
                    return 0;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                f_10305_40780_40795_I(Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 40780, 40795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable
                f_10305_40998_41041(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable>
                variables, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Binder.DeconstructionVariable(variables, (Microsoft.CodeAnalysis.SyntaxNode)syntax);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 40998, 41041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10305_41154_41165(Microsoft.CodeAnalysis.CSharp.Syntax.VariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 41154, 41165);
                    return return_v;
                }


                System.Exception
                f_10305_41119_41166(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 41119, 41166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 39543, 41193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 39543, 41193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundDiscardExpression BindDiscardExpression(
                    SyntaxNode syntax,
                    TypeWithAnnotations declTypeWithAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10305, 41205, 41463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 41380, 41452);

                return f_10305_41387_41451(syntax, declTypeWithAnnotations.Type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10305, 41205, 41463);

                Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression
                f_10305_41387_41451(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression(syntax, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 41387, 41451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 41205, 41463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 41205, 41463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private BoundExpression BindDeconstructionVariable(
                    TypeWithAnnotations declTypeWithAnnotations,
                    SingleVariableDesignationSyntax designation,
                    CSharpSyntaxNode syntax,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10305, 41797, 44355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 42067, 42135);

                SourceLocalSymbol
                localSymbol = f_10305_42099_42134(this, f_10305_42111_42133(designation))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 42184, 42997) || true) && ((object)localSymbol != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 42184, 42997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 42455, 42561);

                    var
                    hasErrors = f_10305_42471_42560(f_10305_42471_42494(localSymbol), localSymbol, diagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 42581, 42872) || true) && (declTypeWithAnnotations.HasType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 42581, 42872);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 42658, 42853);

                        return f_10305_42665_42852(syntax, localSymbol, BoundLocalDeclarationKind.WithExplicitType, constantValueOpt: null, isNullableUnknown: false, type: declTypeWithAnnotations.Type, hasErrors: hasErrors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 42581, 42872);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 42892, 42982);

                    return f_10305_42899_42981(syntax, localSymbol, receiverOpt: null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 42184, 42997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 43046, 43112);

                GlobalExpressionVariable
                field = f_10305_43079_43111(this, designation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 43128, 43332) || true) && ((object)field == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 43128, 43332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 43280, 43317);

                    throw f_10305_43286_43316();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 43128, 43332);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 43348, 43517);

                BoundThisReference
                receiver = f_10305_43378_43516(this, designation, f_10305_43405_43424(this), hasErrors: false, wasCompilerGenerated: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 43533, 44253) || true) && (declTypeWithAnnotations.HasType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10305, 43533, 44253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 43602, 43660);

                    var
                    fieldType = f_10305_43618_43659(field, f_10305_43637_43658(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 43678, 43793);

                    f_10305_43678_43792(f_10305_43691_43791(declTypeWithAnnotations.Type, fieldType.Type, TypeCompareKind.ConsiderEverything2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 43811, 44238);

                    return f_10305_43818_44237(syntax, receiver, field, constantValueOpt: null, resultKind: LookupResultKind.Viable, isDeclaration: true, type: fieldType.Type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10305, 43533, 44253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10305, 44269, 44344);

                return f_10305_44276_44343(syntax, field, receiver);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10305, 41797, 44355);

                Microsoft.CodeAnalysis.SyntaxToken
                f_10305_42111_42133(Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                this_param)
                {
                    var return_v = this_param.Identifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 42111, 42133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                f_10305_42099_42134(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.SyntaxToken
                nameToken)
                {
                    var return_v = this_param.LookupLocal(nameToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 42099, 42134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10305_42471_42494(Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                this_param)
                {
                    var return_v = this_param.ScopeBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 42471, 42494);
                    return return_v;
                }


                bool
                f_10305_42471_42560(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.ValidateDeclarationNameConflictsInScope((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 42471, 42560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10305_42665_42852(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                localSymbol, Microsoft.CodeAnalysis.CSharp.BoundLocalDeclarationKind
                declarationKind, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, bool
                isNullableUnknown, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                hasErrors)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLocal((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol)localSymbol, declarationKind, constantValueOpt: constantValueOpt, isNullableUnknown: isNullableUnknown, type: type, hasErrors: hasErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 42665, 42852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeconstructionVariablePendingInference
                f_10305_42899_42981(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.SourceLocalSymbol
                variableSymbol, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeconstructionVariablePendingInference((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)variableSymbol, receiverOpt: receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 42899, 42981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                f_10305_43079_43111(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                variableDesignator)
                {
                    var return_v = this_param.LookupDeclaredField(variableDesignator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 43079, 43111);
                    return return_v;
                }


                System.Exception
                f_10305_43286_43316()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 43286, 43316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10305_43405_43424(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 43405, 43424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10305_43378_43516(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.SingleVariableDesignationSyntax
                node, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                thisTypeOpt, bool
                hasErrors, bool
                wasCompilerGenerated)
                {
                    var return_v = this_param.ThisReference((Microsoft.CodeAnalysis.SyntaxNode)node, thisTypeOpt, hasErrors: hasErrors, wasCompilerGenerated: wasCompilerGenerated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 43378, 43516);
                    return return_v;
                }


                Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10305_43637_43658(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.FieldsBeingBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10305, 43637, 43658);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10305_43618_43659(Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound)
                {
                    var return_v = this_param.GetFieldType(fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 43618, 43659);
                    return return_v;
                }


                bool
                f_10305_43691_43791(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 43691, 43791);
                    return return_v;
                }


                int
                f_10305_43678_43792(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 43678, 43792);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10305_43818_44237(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                fieldSymbol, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, bool
                isDeclaration, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundFieldAccess((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)fieldSymbol, constantValueOpt: constantValueOpt, resultKind: resultKind, isDeclaration: isDeclaration, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 43818, 44237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.DeconstructionVariablePendingInference
                f_10305_44276_44343(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.Symbols.GlobalExpressionVariable
                variableSymbol, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiverOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.DeconstructionVariablePendingInference((Microsoft.CodeAnalysis.SyntaxNode)syntax, (Microsoft.CodeAnalysis.CSharp.Symbol)variableSymbol, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10305, 44276, 44343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10305, 41797, 44355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10305, 41797, 44355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
