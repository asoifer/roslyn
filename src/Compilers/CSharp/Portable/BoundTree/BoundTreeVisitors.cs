// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using Roslyn.Utilities;
using System.Linq;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class BoundTreeVisitor<A, R>
    {
        protected BoundTreeVisitor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10577, 564, 614);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10577, 564, 614);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 564, 614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 564, 614);
            }
        }

        public virtual R Visit(BoundNode node, A arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10577, 626, 7337);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 696, 779) || true) && (node == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 696, 779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 746, 764);

                    return default(R);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 696, 779);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 876, 7278);

                switch (f_10577_884_893(node))
                {

                    case BoundKind.TypeExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 979, 1040);

                        return f_10577_986_1039(this, node as BoundTypeExpression, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.NamespaceExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 1115, 1186);

                        return f_10577_1122_1185(this, node as BoundNamespaceExpression, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.UnaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 1255, 1314);

                        return f_10577_1262_1313(this, node as BoundUnaryOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.IncrementOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 1387, 1454);

                        return f_10577_1394_1453(this, node as BoundIncrementOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.BinaryOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 1524, 1585);

                        return f_10577_1531_1584(this, node as BoundBinaryOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.CompoundAssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 1667, 1752);

                        return f_10577_1674_1751(this, node as BoundCompoundAssignmentOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.AssignmentOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 1826, 1895);

                        return f_10577_1833_1894(this, node as BoundAssignmentOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.NullCoalescingOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 1973, 2050);

                        return f_10577_1980_2049(this, node as BoundNullCoalescingOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ConditionalOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 2125, 2196);

                        return f_10577_2132_2195(this, node as BoundConditionalOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ArrayAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 2263, 2318);

                        return f_10577_2270_2317(this, node as BoundArrayAccess, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.TypeOfOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 2388, 2449);

                        return f_10577_2395_2448(this, node as BoundTypeOfOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.DefaultLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 2519, 2580);

                        return f_10577_2526_2579(this, node as BoundDefaultLiteral, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.DefaultExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 2653, 2720);

                        return f_10577_2660_2719(this, node as BoundDefaultExpression, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.IsOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 2786, 2839);

                        return f_10577_2793_2838(this, node as BoundIsOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.AsOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 2905, 2958);

                        return f_10577_2912_2957(this, node as BoundAsOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 3024, 3077);

                        return f_10577_3031_3076(this, node as BoundConversion, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.SequencePointExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 3156, 3235);

                        return f_10577_3163_3234(this, node as BoundSequencePointExpression, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.SequencePoint:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 3304, 3363);

                        return f_10577_3311_3362(this, node as BoundSequencePoint, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.SequencePointWithSpan:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 3440, 3515);

                        return f_10577_3447_3514(this, node as BoundSequencePointWithSpan, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.Block:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 3576, 3619);

                        return f_10577_3583_3618(this, node as BoundBlock, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.LocalDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 3691, 3756);

                        return f_10577_3698_3755(this, node as BoundLocalDeclaration, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.MultipleLocalDeclarations:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 3837, 3920);

                        return f_10577_3844_3919(this, node as BoundMultipleLocalDeclarations, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.Sequence:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 3984, 4033);

                        return f_10577_3991_4032(this, node as BoundSequence, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.NoOpStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 4102, 4161);

                        return f_10577_4109_4160(this, node as BoundNoOpStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ReturnStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 4232, 4295);

                        return f_10577_4239_4294(this, node as BoundReturnStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ThrowStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 4365, 4426);

                        return f_10577_4372_4425(this, node as BoundThrowStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ExpressionStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 4501, 4572);

                        return f_10577_4508_4571(this, node as BoundExpressionStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.BreakStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 4642, 4703);

                        return f_10577_4649_4702(this, node as BoundBreakStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ContinueStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 4776, 4843);

                        return f_10577_4783_4842(this, node as BoundContinueStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.IfStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 4910, 4965);

                        return f_10577_4917_4964(this, node as BoundIfStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ForEachStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 5037, 5102);

                        return f_10577_5044_5101(this, node as BoundForEachStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.TryStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 5170, 5227);

                        return f_10577_5177_5226(this, node as BoundTryStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.Literal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 5290, 5337);

                        return f_10577_5297_5336(this, node as BoundLiteral, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ThisReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 5406, 5465);

                        return f_10577_5413_5464(this, node as BoundThisReference, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 5526, 5569);

                        return f_10577_5533_5568(this, node as BoundLocal, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 5634, 5685);

                        return f_10577_5641_5684(this, node as BoundParameter, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.LabelStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 5755, 5816);

                        return f_10577_5762_5815(this, node as BoundLabelStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.GotoStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 5885, 5944);

                        return f_10577_5892_5943(this, node as BoundGotoStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.LabeledStatement:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 6016, 6081);

                        return f_10577_6023_6080(this, node as BoundLabeledStatement, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.StatementList:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 6150, 6209);

                        return f_10577_6157_6208(this, node as BoundStatementList, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ConditionalGoto:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 6280, 6343);

                        return f_10577_6287_6342(this, node as BoundConditionalGoto, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 6403, 6444);

                        return f_10577_6410_6443(this, node as BoundCall, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.ObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 6524, 6605);

                        return f_10577_6531_6604(this, node as BoundObjectCreationExpression, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.DelegateCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 6687, 6772);

                        return f_10577_6694_6771(this, node as BoundDelegateCreationExpression, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 6839, 6894);

                        return f_10577_6846_6893(this, node as BoundFieldAccess, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 6964, 7025);

                        return f_10577_6971_7024(this, node as BoundPropertyAccess, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.Lambda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 7087, 7132);

                        return f_10577_7094_7131(this, node as BoundLambda, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);

                    case BoundKind.NameOfOperator:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 876, 7278);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 7202, 7263);

                        return f_10577_7209_7262(this, node as BoundNameOfOperator, arg);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 876, 7278);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 7294, 7326);

                return f_10577_7301_7325(this, node, arg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10577, 626, 7337);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10577_884_893(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10577, 884, 893);
                    return return_v;
                }


                R
                f_10577_986_1039(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitTypeExpression((Microsoft.CodeAnalysis.CSharp.BoundTypeExpression?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 986, 1039);
                    return return_v;
                }


                R
                f_10577_1122_1185(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitNamespaceExpression((Microsoft.CodeAnalysis.CSharp.BoundNamespaceExpression?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 1122, 1185);
                    return return_v;
                }


                R
                f_10577_1262_1313(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitUnaryOperator((Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 1262, 1313);
                    return return_v;
                }


                R
                f_10577_1394_1453(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitIncrementOperator((Microsoft.CodeAnalysis.CSharp.BoundIncrementOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 1394, 1453);
                    return return_v;
                }


                R
                f_10577_1531_1584(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitBinaryOperator((Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 1531, 1584);
                    return return_v;
                }


                R
                f_10577_1674_1751(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitCompoundAssignmentOperator((Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 1674, 1751);
                    return return_v;
                }


                R
                f_10577_1833_1894(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitAssignmentOperator((Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 1833, 1894);
                    return return_v;
                }


                R
                f_10577_1980_2049(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitNullCoalescingOperator((Microsoft.CodeAnalysis.CSharp.BoundNullCoalescingOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 1980, 2049);
                    return return_v;
                }


                R
                f_10577_2132_2195(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitConditionalOperator((Microsoft.CodeAnalysis.CSharp.BoundConditionalOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 2132, 2195);
                    return return_v;
                }


                R
                f_10577_2270_2317(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitArrayAccess((Microsoft.CodeAnalysis.CSharp.BoundArrayAccess?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 2270, 2317);
                    return return_v;
                }


                R
                f_10577_2395_2448(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitTypeOfOperator((Microsoft.CodeAnalysis.CSharp.BoundTypeOfOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 2395, 2448);
                    return return_v;
                }


                R
                f_10577_2526_2579(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitDefaultLiteral((Microsoft.CodeAnalysis.CSharp.BoundDefaultLiteral?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 2526, 2579);
                    return return_v;
                }


                R
                f_10577_2660_2719(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitDefaultExpression((Microsoft.CodeAnalysis.CSharp.BoundDefaultExpression?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 2660, 2719);
                    return return_v;
                }


                R
                f_10577_2793_2838(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitIsOperator((Microsoft.CodeAnalysis.CSharp.BoundIsOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 2793, 2838);
                    return return_v;
                }


                R
                f_10577_2912_2957(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitAsOperator((Microsoft.CodeAnalysis.CSharp.BoundAsOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 2912, 2957);
                    return return_v;
                }


                R
                f_10577_3031_3076(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitConversion((Microsoft.CodeAnalysis.CSharp.BoundConversion?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 3031, 3076);
                    return return_v;
                }


                R
                f_10577_3163_3234(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitSequencePointExpression((Microsoft.CodeAnalysis.CSharp.BoundSequencePointExpression?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 3163, 3234);
                    return return_v;
                }


                R
                f_10577_3311_3362(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitSequencePoint((Microsoft.CodeAnalysis.CSharp.BoundSequencePoint?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 3311, 3362);
                    return return_v;
                }


                R
                f_10577_3447_3514(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitSequencePointWithSpan((Microsoft.CodeAnalysis.CSharp.BoundSequencePointWithSpan?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 3447, 3514);
                    return return_v;
                }


                R
                f_10577_3583_3618(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitBlock((Microsoft.CodeAnalysis.CSharp.BoundBlock?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 3583, 3618);
                    return return_v;
                }


                R
                f_10577_3698_3755(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitLocalDeclaration((Microsoft.CodeAnalysis.CSharp.BoundLocalDeclaration?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 3698, 3755);
                    return return_v;
                }


                R
                f_10577_3844_3919(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitMultipleLocalDeclarations((Microsoft.CodeAnalysis.CSharp.BoundMultipleLocalDeclarations?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 3844, 3919);
                    return return_v;
                }


                R
                f_10577_3991_4032(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitSequence((Microsoft.CodeAnalysis.CSharp.BoundSequence?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 3991, 4032);
                    return return_v;
                }


                R
                f_10577_4109_4160(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitNoOpStatement((Microsoft.CodeAnalysis.CSharp.BoundNoOpStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 4109, 4160);
                    return return_v;
                }


                R
                f_10577_4239_4294(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitReturnStatement((Microsoft.CodeAnalysis.CSharp.BoundReturnStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 4239, 4294);
                    return return_v;
                }


                R
                f_10577_4372_4425(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitThrowStatement((Microsoft.CodeAnalysis.CSharp.BoundThrowStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 4372, 4425);
                    return return_v;
                }


                R
                f_10577_4508_4571(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitExpressionStatement((Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 4508, 4571);
                    return return_v;
                }


                R
                f_10577_4649_4702(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitBreakStatement((Microsoft.CodeAnalysis.CSharp.BoundBreakStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 4649, 4702);
                    return return_v;
                }


                R
                f_10577_4783_4842(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitContinueStatement((Microsoft.CodeAnalysis.CSharp.BoundContinueStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 4783, 4842);
                    return return_v;
                }


                R
                f_10577_4917_4964(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitIfStatement((Microsoft.CodeAnalysis.CSharp.BoundIfStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 4917, 4964);
                    return return_v;
                }


                R
                f_10577_5044_5101(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitForEachStatement((Microsoft.CodeAnalysis.CSharp.BoundForEachStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 5044, 5101);
                    return return_v;
                }


                R
                f_10577_5177_5226(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitTryStatement((Microsoft.CodeAnalysis.CSharp.BoundTryStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 5177, 5226);
                    return return_v;
                }


                R
                f_10577_5297_5336(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitLiteral((Microsoft.CodeAnalysis.CSharp.BoundLiteral?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 5297, 5336);
                    return return_v;
                }


                R
                f_10577_5413_5464(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitThisReference((Microsoft.CodeAnalysis.CSharp.BoundThisReference?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 5413, 5464);
                    return return_v;
                }


                R
                f_10577_5533_5568(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitLocal((Microsoft.CodeAnalysis.CSharp.BoundLocal?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 5533, 5568);
                    return return_v;
                }


                R
                f_10577_5641_5684(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitParameter((Microsoft.CodeAnalysis.CSharp.BoundParameter?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 5641, 5684);
                    return return_v;
                }


                R
                f_10577_5762_5815(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitLabelStatement((Microsoft.CodeAnalysis.CSharp.BoundLabelStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 5762, 5815);
                    return return_v;
                }


                R
                f_10577_5892_5943(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitGotoStatement((Microsoft.CodeAnalysis.CSharp.BoundGotoStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 5892, 5943);
                    return return_v;
                }


                R
                f_10577_6023_6080(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitLabeledStatement((Microsoft.CodeAnalysis.CSharp.BoundLabeledStatement?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 6023, 6080);
                    return return_v;
                }


                R
                f_10577_6157_6208(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitStatementList((Microsoft.CodeAnalysis.CSharp.BoundStatementList?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 6157, 6208);
                    return return_v;
                }


                R
                f_10577_6287_6342(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitConditionalGoto((Microsoft.CodeAnalysis.CSharp.BoundConditionalGoto?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 6287, 6342);
                    return return_v;
                }


                R
                f_10577_6410_6443(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitCall((Microsoft.CodeAnalysis.CSharp.BoundCall?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 6410, 6443);
                    return return_v;
                }


                R
                f_10577_6531_6604(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitObjectCreationExpression((Microsoft.CodeAnalysis.CSharp.BoundObjectCreationExpression?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 6531, 6604);
                    return return_v;
                }


                R
                f_10577_6694_6771(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitDelegateCreationExpression((Microsoft.CodeAnalysis.CSharp.BoundDelegateCreationExpression?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 6694, 6771);
                    return return_v;
                }


                R
                f_10577_6846_6893(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitFieldAccess((Microsoft.CodeAnalysis.CSharp.BoundFieldAccess?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 6846, 6893);
                    return return_v;
                }


                R
                f_10577_6971_7024(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitPropertyAccess((Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 6971, 7024);
                    return return_v;
                }


                R
                f_10577_7094_7131(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitLambda((Microsoft.CodeAnalysis.CSharp.BoundLambda?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 7094, 7131);
                    return return_v;
                }


                R
                f_10577_7209_7262(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitNameOfOperator((Microsoft.CodeAnalysis.CSharp.BoundNameOfOperator?)node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 7209, 7262);
                    return return_v;
                }


                R
                f_10577_7301_7325(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor<A, R>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundNode
                node, A
                arg)
                {
                    var return_v = this_param.VisitInternal(node, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 7301, 7325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 626, 7337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 626, 7337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual R DefaultVisit(BoundNode node, A arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10577, 7349, 7455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 7426, 7444);

                return default(R);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10577, 7349, 7455);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 7349, 7455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 7349, 7455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundTreeVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10577, 493, 7462);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10577, 493, 7462);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 493, 7462);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10577, 493, 7462);
    }
    internal abstract partial class BoundTreeVisitor
    {
        protected BoundTreeVisitor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10577, 7535, 7585);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10577, 7535, 7585);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 7535, 7585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 7535, 7585);
            }
        }

        [DebuggerHidden]
        public virtual BoundNode Visit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10577, 7597, 7823);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 7694, 7784) || true) && (node != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 7694, 7784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 7744, 7769);

                    return f_10577_7751_7768(node, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 7694, 7784);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 7800, 7812);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10577, 7597, 7823);

                Microsoft.CodeAnalysis.CSharp.BoundNode?
                f_10577_7751_7768(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor
                visitor)
                {
                    var return_v = this_param.Accept(visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 7751, 7768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 7597, 7823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 7597, 7823);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerHidden]
        public virtual BoundNode DefaultVisit(BoundNode node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10577, 7835, 7962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 7939, 7951);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10577, 7835, 7962);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 7835, 7962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 7835, 7962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        public class CancelledByStackGuardException : Exception
        {
            public readonly BoundNode Node;

            public CancelledByStackGuardException(Exception inner, BoundNode node)
            : base(f_10577_8196_8209_C(f_10577_8196_8209(inner)), inner)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10577, 8101, 8277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 8080, 8084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 8250, 8262);

                    Node = node;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10577, 8101, 8277);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 8101, 8277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 8101, 8277);
                }
            }

            public void AddAnError(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10577, 8293, 8489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 8375, 8474);

                    f_10577_8375_8473(diagnostics, ErrorCode.ERR_InsufficientStack, f_10577_8424_8472(Node));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10577, 8293, 8489);

                    Microsoft.CodeAnalysis.Location
                    f_10577_8424_8472(Microsoft.CodeAnalysis.CSharp.BoundNode
                    node)
                    {
                        var return_v = GetTooLongOrComplexExpressionErrorLocation(node);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 8424, 8472);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10577_8375_8473(Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, Microsoft.CodeAnalysis.Location
                    location)
                    {
                        var return_v = diagnostics.Add(code, location);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 8375, 8473);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 8293, 8489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 8293, 8489);
                }
            }

            public static Location GetTooLongOrComplexExpressionErrorLocation(BoundNode node)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10577, 8505, 8961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 8619, 8651);

                    SyntaxNode
                    syntax = node.Syntax
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 8671, 8882) || true) && (!(syntax is ExpressionSyntax))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 8671, 8882);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 8746, 8863);

                        syntax = f_10577_8755_8852(f_10577_8755_8835(f_10577_8755_8808(syntax, n => !(n is ExpressionSyntax)))) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>(10577, 8755, 8862) ?? syntax);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 8671, 8882);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 8902, 8946);

                    return f_10577_8909_8931(syntax).GetLocation();
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10577, 8505, 8961);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                    f_10577_8755_8808(Microsoft.CodeAnalysis.SyntaxNode
                    this_param, System.Func<Microsoft.CodeAnalysis.SyntaxNode, bool>?
                    descendIntoChildren)
                    {
                        var return_v = this_param.DescendantNodes(descendIntoChildren);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 8755, 8808);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                    f_10577_8755_8835(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.SyntaxNode>
                    source)
                    {
                        var return_v = source.OfType<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 8755, 8835);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                    f_10577_8755_8852(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                    source)
                    {
                        var return_v = source.FirstOrDefault<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 8755, 8852);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxToken
                    f_10577_8909_8931(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetFirstToken();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 8909, 8931);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 8505, 8961);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 8505, 8961);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static CancelledByStackGuardException()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10577, 7974, 8972);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10577, 7974, 8972);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 7974, 8972);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10577, 7974, 8972);

            static string
            f_10577_8196_8209(System.Exception
            this_param)
            {
                var return_v = this_param.Message;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10577, 8196, 8209);
                return return_v;
            }


            static string
            f_10577_8196_8209_C(string
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10577, 8101, 8277);
                return return_v;
            }

        }

        [DebuggerStepThrough]
        protected BoundExpression VisitExpressionWithStackGuard(ref int recursionDepth, BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10577, 9134, 9979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9291, 9314);

                BoundExpression
                result
                = default(BoundExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9328, 9345);

                recursionDepth++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9370, 9410);

                int
                saveRecursionDepth = recursionDepth
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9434, 9823) || true) && (recursionDepth > 1 || (DynAbs.Tracing.TraceSender.Expression_False(10577, 9438, 9537) || !f_10577_9461_9537(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 9434, 9823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9571, 9629);

                    f_10577_9571_9628(recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9649, 9697);

                    result = f_10577_9658_9696(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 9434, 9823);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10577, 9434, 9823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9763, 9808);

                    result = f_10577_9772_9807(this, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10577, 9434, 9823);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9850, 9901);

                f_10577_9850_9900(saveRecursionDepth == recursionDepth);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9923, 9940);

                recursionDepth--;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 9954, 9968);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10577, 9134, 9979);

                bool
                f_10577_9461_9537(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor
                this_param)
                {
                    var return_v = this_param.ConvertInsufficientExecutionStackExceptionToCancelledByStackGuardException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 9461, 9537);
                    return return_v;
                }


                int
                f_10577_9571_9628(int
                recursionDepth)
                {
                    StackGuard.EnsureSufficientExecutionStack(recursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 9571, 9628);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10577_9658_9696(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithoutStackGuard(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 9658, 9696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10577_9772_9807(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithStackGuard(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 9772, 9807);
                    return return_v;
                }


                int
                f_10577_9850_9900(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 9850, 9900);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 9134, 9979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 9134, 9979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual bool ConvertInsufficientExecutionStackExceptionToCancelledByStackGuardException()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10577, 9991, 10138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 10115, 10127);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10577, 9991, 10138);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 9991, 10138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 9991, 10138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [DebuggerStepThrough]
        private BoundExpression? VisitExpressionWithStackGuard(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10577, 10168, 10567);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 10336, 10382);

                    return f_10577_10343_10381(this, node);
                }
                catch (InsufficientExecutionStackException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10577, 10411, 10556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10577, 10490, 10541);

                    throw f_10577_10496_10540(ex, node);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10577, 10411, 10556);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10577, 10168, 10567);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10577_10343_10381(Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = this_param.VisitExpressionWithoutStackGuard(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 10343, 10381);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException
                f_10577_10496_10540(System.InsufficientExecutionStackException
                inner, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundTreeVisitor.CancelledByStackGuardException((System.Exception)inner, (Microsoft.CodeAnalysis.CSharp.BoundNode)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10577, 10496, 10540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10577, 10168, 10567);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10577, 10168, 10567);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract BoundExpression? VisitExpressionWithoutStackGuard(BoundExpression node);
    }
}
